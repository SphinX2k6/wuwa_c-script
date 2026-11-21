using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using Internal.Win32.SafeHandles;

namespace Internal.Win32
{
	// Token: 0x02000069 RID: 105
	internal sealed class RegistryKey : IDisposable
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00005CBF File Offset: 0x00003EBF
		private RegistryKey(SafeRegistryHandle hkey)
		{
			this._hkey = hkey;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00005CCE File Offset: 0x00003ECE
		void IDisposable.Dispose()
		{
			SafeRegistryHandle hkey = this._hkey;
			if (hkey == null)
			{
				return;
			}
			hkey.Dispose();
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00005CE0 File Offset: 0x00003EE0
		public void DeleteValue(string name, bool throwOnMissingValue)
		{
			int num = Interop.Advapi32.RegDeleteValue(this._hkey, name);
			if (num == 2 || num == 206)
			{
				if (throwOnMissingValue)
				{
					throw new ArgumentException(SR.Arg_RegSubKeyValueAbsent);
				}
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00005D16 File Offset: 0x00003F16
		internal static RegistryKey OpenBaseKey(IntPtr hKey)
		{
			return new RegistryKey(new SafeRegistryHandle(hKey, false));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00005D24 File Offset: 0x00003F24
		public RegistryKey OpenSubKey(string name)
		{
			return this.OpenSubKey(name, false);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00005D30 File Offset: 0x00003F30
		public RegistryKey OpenSubKey(string name, bool writable)
		{
			SafeRegistryHandle safeRegistryHandle;
			int num = Interop.Advapi32.RegOpenKeyEx(this._hkey, name, 0, writable ? 131103 : 131097, out safeRegistryHandle);
			if (num == 0 && !safeRegistryHandle.IsInvalid)
			{
				return new RegistryKey(safeRegistryHandle);
			}
			safeRegistryHandle.Dispose();
			if (num == 5 || num == 1346)
			{
				throw new SecurityException(SR.Security_RegistryPermission);
			}
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00005D8C File Offset: 0x00003F8C
		public unsafe string[] GetSubKeyNames()
		{
			List<string> list = new List<string>();
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			int length = span.Length;
			int num;
			while ((num = Interop.Advapi32.RegEnumKeyEx(this._hkey, list.Count, MemoryMarshal.GetReference<char>(span), ref length, null, null, null, null)) != 259)
			{
				if (num == 0)
				{
					list.Add(new string(span.Slice(0, length)));
					length = span.Length;
				}
				else
				{
					RegistryKey.Win32Error(num, null);
				}
			}
			return list.ToArray();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00005E18 File Offset: 0x00004018
		public string[] GetValueNames()
		{
			List<string> list = new List<string>();
			char[] array = ArrayPool<char>.Shared.Rent(100);
			try
			{
				int length = array.Length;
				int num;
				while ((num = Interop.Advapi32.RegEnumValue(this._hkey, list.Count, array, ref length, IntPtr.Zero, null, null, null)) != 259)
				{
					if (num != 0)
					{
						if (num != 234)
						{
							RegistryKey.Win32Error(num, null);
						}
						else
						{
							char[] array2 = array;
							int num2 = array2.Length;
							array = null;
							ArrayPool<char>.Shared.Return(array2, false);
							array = ArrayPool<char>.Shared.Rent(checked(num2 * 2));
						}
					}
					else
					{
						list.Add(new string(array, 0, length));
					}
					length = array.Length;
				}
			}
			finally
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
			}
			return list.ToArray();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00005EDC File Offset: 0x000040DC
		public object GetValue(string name)
		{
			return this.GetValue(name, null);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00005EE8 File Offset: 0x000040E8
		[return: NotNullIfNotNull("defaultValue")]
		public unsafe object GetValue(string name, object defaultValue)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)512], 512);
			byte[] array = null;
			object result;
			try
			{
				int num2;
				for (;;)
				{
					int num = 0;
					int length = span.Length;
					try
					{
						fixed (byte* ptr = MemoryMarshal.GetReference<byte>(span))
						{
							byte* lpData = ptr;
							num2 = Interop.Advapi32.RegQueryValueEx(this._hkey, name, null, &num, lpData, (uint*)(&length));
							if (length < 0)
							{
								throw new IOException(SR.Arg_RegValueTooLarge);
							}
						}
					}
					finally
					{
						byte* ptr = null;
					}
					if (num2 != 234)
					{
						goto IL_A1;
					}
					if (array != null)
					{
						byte[] array2 = array;
						array = null;
						ArrayPool<byte>.Shared.Return(array2, false);
					}
					if (length < 0)
					{
						break;
					}
					span = (array = ArrayPool<byte>.Shared.Rent(length));
				}
				throw new IOException(SR.Arg_RegValueTooLarge);
				IL_A1:
				if (num2 != 0)
				{
					result = defaultValue;
				}
				else
				{
					int num;
					switch (num)
					{
					case 0:
					case 3:
					case 5:
					{
						int length;
						return span.Slice(0, length).ToArray();
					}
					case 1:
					case 2:
					case 7:
					{
						int length;
						if (length % 2 == 1)
						{
							if (length == 2147483647)
							{
								throw new IOException(SR.Arg_RegValueTooLarge);
							}
							if (length >= span.Length)
							{
								byte[] array3 = ArrayPool<byte>.Shared.Rent(length + 1);
								span.CopyTo(array3);
								if (array != null)
								{
									byte[] array4 = array;
									array = null;
									ArrayPool<byte>.Shared.Return(array4, false);
								}
								span = (array = array3);
							}
							*span[length++] = 0;
						}
						ReadOnlySpan<char> span2 = MemoryMarshal.Cast<byte, char>(span.Slice(0, length));
						if (num == 7)
						{
							string[] array5 = Array.Empty<string>();
							int num3 = 0;
							while (span2.Length > 1 || (span2.Length == 1 && *span2[0] != 0))
							{
								int num4 = span2.IndexOf('\0');
								string text;
								if (num4 < 0)
								{
									text = span2.ToString();
									span2 = default(ReadOnlySpan<char>);
								}
								else
								{
									text = span2.Slice(0, num4).ToString();
									span2 = span2.Slice(num4 + 1);
								}
								if (num3 == array5.Length)
								{
									Array.Resize<string>(ref array5, (num3 == 0) ? 4 : (num3 * 2));
								}
								array5[num3++] = text;
							}
							if (num3 != 0)
							{
								Array.Resize<string>(ref array5, num3);
							}
							return array5;
						}
						if (span2.Length == 0)
						{
							return string.Empty;
						}
						if (*span2[span2.Length - 1] == 0)
						{
							ref ReadOnlySpan<char> ptr2 = ref span2;
							span2 = ptr2.Slice(0, ptr2.Length - 1);
						}
						string text2 = span2.ToString();
						if (num == 2)
						{
							text2 = Environment.ExpandEnvironmentVariables(text2);
						}
						return text2;
					}
					case 4:
					case 11:
					{
						int length;
						object result2;
						if (length != 4)
						{
							if (length != 8)
							{
								result2 = span.Slice(0, length).ToArray();
							}
							else
							{
								result2 = MemoryMarshal.Read<long>(span);
							}
						}
						else
						{
							result2 = MemoryMarshal.Read<int>(span);
						}
						return result2;
					}
					}
					result = defaultValue;
				}
			}
			finally
			{
				if (array != null)
				{
					ArrayPool<byte>.Shared.Return(array, false);
				}
			}
			return result;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00006238 File Offset: 0x00004438
		internal void SetValue(string name, string value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (name != null && name.Length > 16383)
			{
				throw new ArgumentException(SR.Arg_RegValStrLenBug, "name");
			}
			int num = Interop.Advapi32.RegSetValueEx(this._hkey, name, 0, 1, value, checked(value.Length * 2 + 2));
			if (num != 0)
			{
				RegistryKey.Win32Error(num, null);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00006294 File Offset: 0x00004494
		internal static void Win32Error(int errorCode, string str)
		{
			if (errorCode == 2)
			{
				throw new IOException(SR.Arg_RegKeyNotFound, errorCode);
			}
			if (errorCode != 5)
			{
				throw new IOException(Interop.Kernel32.GetMessage(errorCode), errorCode);
			}
			if (str != null)
			{
				throw new UnauthorizedAccessException(SR.Format(SR.UnauthorizedAccess_RegistryKeyGeneric_Key, str));
			}
			throw new UnauthorizedAccessException();
		}

		// Token: 0x040001D7 RID: 471
		private readonly SafeRegistryHandle _hkey;
	}
}
