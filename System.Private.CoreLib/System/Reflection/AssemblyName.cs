using System;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Mono;

namespace System.Reflection
{
	// Token: 0x020006ED RID: 1773
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class AssemblyName : ICloneable, IDeserializationCallback, ISerializable
	{
		// Token: 0x0600756E RID: 30062 RVA: 0x00116D38 File Offset: 0x00114F38
		internal unsafe static AssemblyName Create(IntPtr monoAssembly, string codeBase)
		{
			AssemblyName assemblyName = new AssemblyName();
			MonoAssemblyName* nativeName = AssemblyName.GetNativeName(monoAssembly);
			assemblyName.FillName(nativeName, codeBase, true, true, true);
			return assemblyName;
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00116D5C File Offset: 0x00114F5C
		internal unsafe void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken)
		{
			this._name = Marshal.PtrToStringUTF8(native->name);
			this._flags = (AssemblyNameFlags)native->flags;
			this._hashAlgorithm = (AssemblyHashAlgorithm)native->hash_alg;
			this._versionCompatibility = AssemblyVersionCompatibility.SameMachine;
			if (addVersion)
			{
				int num = (native->build == 65535) ? -1 : native->build;
				int num2 = (native->revision == 65535) ? -1 : native->revision;
				if (num == -1)
				{
					this._version = new Version(native->major, native->minor);
				}
				else if (num2 == -1)
				{
					this._version = new Version(native->major, native->minor, num);
				}
				else
				{
					this._version = new Version(native->major, native->minor, num, num2);
				}
			}
			this._codeBase = codeBase;
			if (native->culture != IntPtr.Zero)
			{
				this._cultureInfo = CultureInfo.GetCultureInfo(Marshal.PtrToStringUTF8(native->culture));
			}
			if (native->public_key != IntPtr.Zero)
			{
				this._publicKey = AssemblyName.DecodeBlobArray(native->public_key);
				this._flags |= AssemblyNameFlags.PublicKey;
			}
			else if (addPublickey)
			{
				this._publicKey = Array.Empty<byte>();
				this._flags |= AssemblyNameFlags.PublicKey;
			}
			if (native->public_key_token.FixedElementField != 0)
			{
				byte[] array = new byte[8];
				int i = 0;
				int num3 = 0;
				while (i < 8)
				{
					array[i] = (byte)(HexConverter.FromChar((int)(*(ref native->public_key_token.FixedElementField + num3++))) << 4 | HexConverter.FromChar((int)(*(ref native->public_key_token.FixedElementField + num3++))));
					i++;
				}
				this._publicKeyToken = array;
				return;
			}
			if (defaultToken)
			{
				this._publicKeyToken = Array.Empty<byte>();
			}
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00116F0C File Offset: 0x0011510C
		private unsafe static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr)
		{
			uint result;
			byte* ptr;
			if ((*in_ptr & 128) == 0)
			{
				result = (uint)(*in_ptr & 127);
				ptr = in_ptr + 1;
			}
			else if ((*in_ptr & 64) == 0)
			{
				result = (uint)(((int)(*in_ptr & 63) << 8) + (int)(*(in_ptr + 1)));
				ptr = in_ptr + 2;
			}
			else
			{
				result = (uint)(((int)(*in_ptr & 31) << 24) + ((int)(*(in_ptr + 1)) << 16) + ((int)(*(in_ptr + 2)) << 8) + (int)(*(in_ptr + 3)));
				ptr = in_ptr + 4;
			}
			out_ptr = ptr;
			return (int)result;
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00116F70 File Offset: 0x00115170
		internal static byte[] DecodeBlobArray(IntPtr ptr)
		{
			IntPtr source;
			int num = AssemblyName.DecodeBlobSize(ptr, out source);
			byte[] array = new byte[num];
			Marshal.Copy(source, array, 0, num);
			return array;
		}

		// Token: 0x06007572 RID: 30066
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct);

		// Token: 0x06007573 RID: 30067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern MonoAssemblyName* GetNativeName(IntPtr assemblyPtr);

		// Token: 0x06007574 RID: 30068 RVA: 0x00116F98 File Offset: 0x00115198
		[NullableContext(1)]
		public AssemblyName(string assemblyName) : this()
		{
			ArgumentException.ThrowIfNullOrEmpty(assemblyName, "assemblyName");
			if (assemblyName[0] == '\0')
			{
				throw new ArgumentException(SR.Format_StringZeroLength);
			}
			AssemblyNameParser.AssemblyNameParts assemblyNameParts = AssemblyNameParser.Parse(assemblyName);
			this._name = assemblyNameParts._name;
			this._version = assemblyNameParts._version;
			this._flags = assemblyNameParts._flags;
			if ((assemblyNameParts._flags & AssemblyNameFlags.PublicKey) != AssemblyNameFlags.None)
			{
				this._publicKey = assemblyNameParts._publicKeyOrToken;
			}
			else
			{
				this._publicKeyToken = assemblyNameParts._publicKeyOrToken;
			}
			if (assemblyNameParts._cultureName != null)
			{
				this._cultureInfo = new CultureInfo(assemblyNameParts._cultureName);
			}
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00117032 File Offset: 0x00115232
		public AssemblyName()
		{
			this._versionCompatibility = AssemblyVersionCompatibility.SameMachine;
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06007576 RID: 30070 RVA: 0x00117041 File Offset: 0x00115241
		// (set) Token: 0x06007577 RID: 30071 RVA: 0x00117049 File Offset: 0x00115249
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06007578 RID: 30072 RVA: 0x00117052 File Offset: 0x00115252
		// (set) Token: 0x06007579 RID: 30073 RVA: 0x0011705A File Offset: 0x0011525A
		public Version Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x0600757A RID: 30074 RVA: 0x00117063 File Offset: 0x00115263
		// (set) Token: 0x0600757B RID: 30075 RVA: 0x0011706B File Offset: 0x0011526B
		public CultureInfo CultureInfo
		{
			get
			{
				return this._cultureInfo;
			}
			set
			{
				this._cultureInfo = value;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x0600757C RID: 30076 RVA: 0x00117074 File Offset: 0x00115274
		// (set) Token: 0x0600757D RID: 30077 RVA: 0x00117087 File Offset: 0x00115287
		public string CultureName
		{
			get
			{
				CultureInfo cultureInfo = this._cultureInfo;
				if (cultureInfo == null)
				{
					return null;
				}
				return cultureInfo.Name;
			}
			set
			{
				this._cultureInfo = ((value == null) ? null : new CultureInfo(value));
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x0600757E RID: 30078 RVA: 0x0011709B File Offset: 0x0011529B
		// (set) Token: 0x0600757F RID: 30079 RVA: 0x001170A3 File Offset: 0x001152A3
		[Obsolete("AssemblyName.CodeBase and AssemblyName.EscapedCodeBase are obsolete. Using them for loading an assembly is not supported.", DiagnosticId = "SYSLIB0044", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public string CodeBase
		{
			[RequiresAssemblyFiles("The code will return an empty string for assemblies embedded in a single-file app")]
			get
			{
				return this._codeBase;
			}
			set
			{
				this._codeBase = value;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06007580 RID: 30080 RVA: 0x001170AC File Offset: 0x001152AC
		[Obsolete("AssemblyName.CodeBase and AssemblyName.EscapedCodeBase are obsolete. Using them for loading an assembly is not supported.", DiagnosticId = "SYSLIB0044", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresAssemblyFiles("The code will return an empty string for assemblies embedded in a single-file app")]
		public string EscapedCodeBase
		{
			get
			{
				if (this._codeBase == null)
				{
					return null;
				}
				return AssemblyName.EscapeCodeBase(this._codeBase);
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06007581 RID: 30081 RVA: 0x001170C4 File Offset: 0x001152C4
		// (set) Token: 0x06007582 RID: 30082 RVA: 0x001170E4 File Offset: 0x001152E4
		[Obsolete("AssemblyName members HashAlgorithm, ProcessorArchitecture, and VersionCompatibility are obsolete and not supported.", DiagnosticId = "SYSLIB0037", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public ProcessorArchitecture ProcessorArchitecture
		{
			get
			{
				int num = (int)((this._flags & (AssemblyNameFlags)112) >> 4);
				if (num > 5)
				{
					num = 0;
				}
				return (ProcessorArchitecture)num;
			}
			set
			{
				int num = (int)(value & (ProcessorArchitecture)7);
				if (num <= 5)
				{
					this._flags = (AssemblyNameFlags)((long)this._flags & (long)((ulong)-241));
					this._flags |= (AssemblyNameFlags)(num << 4);
				}
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06007583 RID: 30083 RVA: 0x00117120 File Offset: 0x00115320
		// (set) Token: 0x06007584 RID: 30084 RVA: 0x00117144 File Offset: 0x00115344
		public AssemblyContentType ContentType
		{
			get
			{
				int num = (int)((this._flags & (AssemblyNameFlags)3584) >> 9);
				if (num > 1)
				{
					num = 0;
				}
				return (AssemblyContentType)num;
			}
			set
			{
				int num = (int)(value & (AssemblyContentType)7);
				if (num <= 1)
				{
					this._flags = (AssemblyNameFlags)((long)this._flags & (long)((ulong)-3585));
					this._flags |= (AssemblyNameFlags)(num << 9);
				}
			}
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00117180 File Offset: 0x00115380
		[NullableContext(1)]
		public object Clone()
		{
			AssemblyName assemblyName = new AssemblyName();
			assemblyName._name = this._name;
			byte[] publicKey = this._publicKey;
			assemblyName._publicKey = (byte[])((publicKey != null) ? publicKey.Clone() : null);
			byte[] publicKeyToken = this._publicKeyToken;
			assemblyName._publicKeyToken = (byte[])((publicKeyToken != null) ? publicKeyToken.Clone() : null);
			assemblyName._cultureInfo = this._cultureInfo;
			assemblyName._version = this._version;
			assemblyName._flags = this._flags;
			assemblyName._codeBase = this._codeBase;
			assemblyName._hashAlgorithm = this._hashAlgorithm;
			assemblyName._versionCompatibility = this._versionCompatibility;
			return assemblyName;
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x00117220 File Offset: 0x00115420
		private static Func<string, AssemblyName> InitGetAssemblyName()
		{
			Type type = Type.GetType("System.Reflection.Metadata.MetadataReader, System.Reflection.Metadata", true);
			MethodInfo method = type.GetMethod("GetAssemblyName", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(string)
			}, null);
			if (method == null)
			{
				throw new MissingMethodException(type.FullName, "GetAssemblyName");
			}
			return AssemblyName.s_getAssemblyName = method.CreateDelegate<Func<string, AssemblyName>>();
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x0011727B File Offset: 0x0011547B
		[NullableContext(1)]
		public static AssemblyName GetAssemblyName(string assemblyFile)
		{
			return (AssemblyName.s_getAssemblyName ?? AssemblyName.InitGetAssemblyName())(assemblyFile);
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00117291 File Offset: 0x00115491
		public byte[] GetPublicKey()
		{
			return this._publicKey;
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00117299 File Offset: 0x00115499
		public void SetPublicKey(byte[] publicKey)
		{
			this._publicKey = publicKey;
			if (publicKey == null)
			{
				this._flags &= ~AssemblyNameFlags.PublicKey;
				return;
			}
			this._flags |= AssemblyNameFlags.PublicKey;
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x001172C4 File Offset: 0x001154C4
		public byte[] GetPublicKeyToken()
		{
			byte[] result;
			if ((result = this._publicKeyToken) == null)
			{
				result = (this._publicKeyToken = AssemblyNameHelpers.ComputePublicKeyToken(this._publicKey));
			}
			return result;
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x001172EF File Offset: 0x001154EF
		public void SetPublicKeyToken(byte[] publicKeyToken)
		{
			this._publicKeyToken = publicKeyToken;
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x0600758C RID: 30092 RVA: 0x001172F8 File Offset: 0x001154F8
		// (set) Token: 0x0600758D RID: 30093 RVA: 0x00117306 File Offset: 0x00115506
		public AssemblyNameFlags Flags
		{
			get
			{
				return this._flags & (AssemblyNameFlags)(-3825);
			}
			set
			{
				this._flags &= (AssemblyNameFlags)3824;
				this._flags |= (value & (AssemblyNameFlags)(-3825));
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x0600758E RID: 30094 RVA: 0x0011732E File Offset: 0x0011552E
		// (set) Token: 0x0600758F RID: 30095 RVA: 0x00117336 File Offset: 0x00115536
		[Obsolete("AssemblyName members HashAlgorithm, ProcessorArchitecture, and VersionCompatibility are obsolete and not supported.", DiagnosticId = "SYSLIB0037", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public AssemblyHashAlgorithm HashAlgorithm
		{
			get
			{
				return this._hashAlgorithm;
			}
			set
			{
				this._hashAlgorithm = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06007590 RID: 30096 RVA: 0x0011733F File Offset: 0x0011553F
		// (set) Token: 0x06007591 RID: 30097 RVA: 0x00117347 File Offset: 0x00115547
		[Obsolete("AssemblyName members HashAlgorithm, ProcessorArchitecture, and VersionCompatibility are obsolete and not supported.", DiagnosticId = "SYSLIB0037", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public AssemblyVersionCompatibility VersionCompatibility
		{
			get
			{
				return this._versionCompatibility;
			}
			set
			{
				this._versionCompatibility = value;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06007592 RID: 30098 RVA: 0x00117350 File Offset: 0x00115550
		// (set) Token: 0x06007593 RID: 30099 RVA: 0x00117350 File Offset: 0x00115550
		[Obsolete("Strong name signing is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0017", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public StrongNameKeyPair KeyPair
		{
			get
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_StrongNameSigning);
			}
			set
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_StrongNameSigning);
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06007594 RID: 30100 RVA: 0x0011735C File Offset: 0x0011555C
		[Nullable(1)]
		public string FullName
		{
			[NullableContext(1)]
			get
			{
				if (string.IsNullOrEmpty(this.Name))
				{
					return string.Empty;
				}
				byte[] pkt = this._publicKeyToken ?? AssemblyNameHelpers.ComputePublicKeyToken(this._publicKey);
				return AssemblyNameFormatter.ComputeDisplayName(this.Name, this.Version, this.CultureName, pkt, this.Flags, this.ContentType, null);
			}
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x001173B8 File Offset: 0x001155B8
		[NullableContext(1)]
		public override string ToString()
		{
			string fullName = this.FullName;
			if (fullName == null)
			{
				return base.ToString();
			}
			return fullName;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public void OnDeserialization(object sender)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x001173D8 File Offset: 0x001155D8
		public static bool ReferenceMatchesDefinition(AssemblyName reference, AssemblyName definition)
		{
			if (reference == definition)
			{
				return true;
			}
			ArgumentNullException.ThrowIfNull(reference, "reference");
			ArgumentNullException.ThrowIfNull(definition, "definition");
			string text = reference.Name ?? string.Empty;
			string value = definition.Name ?? string.Empty;
			return text.Equals(value, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00117428 File Offset: 0x00115628
		[RequiresAssemblyFiles("The code will return an empty string for assemblies embedded in a single-file app")]
		internal static string EscapeCodeBase(string codebase)
		{
			if (codebase == null)
			{
				return string.Empty;
			}
			int length = 0;
			char[] array = AssemblyName.EscapeString(codebase, 0, codebase.Length, null, ref length, true, char.MaxValue, char.MaxValue, char.MaxValue);
			if (array == null)
			{
				return codebase;
			}
			return new string(array, 0, length);
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00117470 File Offset: 0x00115670
		internal unsafe static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd)
		{
			int i = start;
			int num = start;
			byte* ptr = stackalloc byte[(UIntPtr)160];
			char* ptr2;
			if (input == null)
			{
				ptr2 = null;
			}
			else
			{
				fixed (char* ptr3 = input.GetPinnableReference())
				{
					ptr2 = ptr3;
				}
			}
			char* ptr4 = ptr2;
			while (i < end)
			{
				char c = ptr4[i];
				if (c > '\u007f')
				{
					short num2 = (short)Math.Min(end - i, 39);
					short num3 = 1;
					while (num3 < num2 && ptr4[i + (int)num3] > '\u007f')
					{
						num3 += 1;
					}
					if (ptr4[i + (int)num3 - 1] >= '\ud800' && ptr4[i + (int)num3 - 1] <= '\udbff')
					{
						if (num3 == 1 || (int)num3 == end - i)
						{
							throw new FormatException(SR.Arg_FormatException);
						}
						num3 += 1;
					}
					dest = AssemblyName.EnsureDestinationSize(ptr4, dest, i, num3 * 4 * 3, 480, ref destPos, num);
					short num4 = (short)Encoding.UTF8.GetBytes(ptr4 + i, (int)num3, ptr, 160);
					if (num4 == 0)
					{
						throw new FormatException(SR.Arg_FormatException);
					}
					i += (int)(num3 - 1);
					for (num3 = 0; num3 < num4; num3 += 1)
					{
						AssemblyName.EscapeAsciiChar((char)ptr[num3], dest, ref destPos);
					}
					num = i + 1;
				}
				else if (c == '%' && rsvd == '%')
				{
					dest = AssemblyName.EnsureDestinationSize(ptr4, dest, i, 3, 120, ref destPos, num);
					if (i + 2 < end && char.IsAsciiHexDigit(ptr4[i + 1]) && char.IsAsciiHexDigit(ptr4[i + 2]))
					{
						char[] array = dest;
						int num5 = destPos;
						destPos = num5 + 1;
						array[num5] = 37;
						char[] array2 = dest;
						num5 = destPos;
						destPos = num5 + 1;
						array2[num5] = ptr4[i + 1];
						char[] array3 = dest;
						num5 = destPos;
						destPos = num5 + 1;
						array3[num5] = ptr4[i + 2];
						i += 2;
					}
					else
					{
						AssemblyName.EscapeAsciiChar('%', dest, ref destPos);
					}
					num = i + 1;
				}
				else if (c == force1 || c == force2 || (c != rsvd && (isUriString ? (!AssemblyName.IsReservedUnreservedOrHash(c)) : (!AssemblyName.IsUnreserved(c)))))
				{
					dest = AssemblyName.EnsureDestinationSize(ptr4, dest, i, 3, 120, ref destPos, num);
					AssemblyName.EscapeAsciiChar(c, dest, ref destPos);
					num = i + 1;
				}
				i++;
			}
			if (num != i && (num != start || dest != null))
			{
				dest = AssemblyName.EnsureDestinationSize(ptr4, dest, i, 0, 0, ref destPos, num);
			}
			char* ptr3 = null;
			return dest;
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x001176B0 File Offset: 0x001158B0
		private unsafe static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos)
		{
			if (dest == null || dest.Length < destPos + (currentInputPos - prevInputPos) + (int)charsToAdd)
			{
				char[] array = new char[destPos + (currentInputPos - prevInputPos) + (int)minReallocateChars];
				if (dest != null && destPos != 0)
				{
					Buffer.BlockCopy(dest, 0, array, 0, destPos << 1);
				}
				dest = array;
			}
			while (prevInputPos != currentInputPos)
			{
				char[] array2 = dest;
				int num = destPos;
				destPos = num + 1;
				array2[num] = pStr[prevInputPos++];
			}
			return dest;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x0011771C File Offset: 0x0011591C
		internal static void EscapeAsciiChar(char ch, char[] to, ref int pos)
		{
			int num = pos;
			pos = num + 1;
			to[num] = '%';
			num = pos;
			pos = num + 1;
			to[num] = HexConverter.ToCharUpper((int)(ch >> 4));
			num = pos;
			pos = num + 1;
			to[num] = HexConverter.ToCharUpper((int)ch);
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x0011775A File Offset: 0x0011595A
		private static bool IsReservedUnreservedOrHash(char c)
		{
			return AssemblyName.IsUnreserved(c) || ":/?#[]@!$&'()*+,;=".Contains(c);
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x00117771 File Offset: 0x00115971
		internal static bool IsUnreserved(char c)
		{
			return char.IsAsciiLetterOrDigit(c) || "-._~".Contains(c);
		}

		// Token: 0x0400151D RID: 5405
		private string _name;

		// Token: 0x0400151E RID: 5406
		private byte[] _publicKey;

		// Token: 0x0400151F RID: 5407
		private byte[] _publicKeyToken;

		// Token: 0x04001520 RID: 5408
		private CultureInfo _cultureInfo;

		// Token: 0x04001521 RID: 5409
		private string _codeBase;

		// Token: 0x04001522 RID: 5410
		private Version _version;

		// Token: 0x04001523 RID: 5411
		private AssemblyHashAlgorithm _hashAlgorithm;

		// Token: 0x04001524 RID: 5412
		private AssemblyVersionCompatibility _versionCompatibility;

		// Token: 0x04001525 RID: 5413
		private AssemblyNameFlags _flags;

		// Token: 0x04001526 RID: 5414
		private static Func<string, AssemblyName> s_getAssemblyName;
	}
}
