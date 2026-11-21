using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using Internal.Win32;
using Microsoft.Win32.SafeHandles;

namespace System
{
	// Token: 0x0200007E RID: 126
	[NullableContext(1)]
	[Nullable(0)]
	public static class Environment
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000E5BF File Offset: 0x0000C7BF
		public static int CurrentManagedThreadId
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060003C7 RID: 967
		// (set) Token: 0x060003C8 RID: 968
		public static extern int ExitCode { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x060003C9 RID: 969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetProcessorCount();

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060003CA RID: 970
		public static extern int TickCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060003CB RID: 971
		public static extern long TickCount64 { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060003CC RID: 972
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Exit(int exitCode);

		// Token: 0x060003CD RID: 973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] GetCommandLineArgs();

		// Token: 0x060003CE RID: 974 RVA: 0x0000E5CB File Offset: 0x0000C7CB
		[NullableContext(2)]
		[DoesNotReturn]
		public static void FailFast(string message)
		{
			Environment.FailFast(message, null, null);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000E5D5 File Offset: 0x0000C7D5
		[NullableContext(2)]
		[DoesNotReturn]
		public static void FailFast(string message, Exception exception)
		{
			Environment.FailFast(message, exception, null);
		}

		// Token: 0x060003D0 RID: 976
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FailFast(string message, Exception exception, string errorSource);

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000E5DF File Offset: 0x0000C7DF
		public static int ProcessorCount { get; } = Environment.GetProcessorCount();

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000E5E6 File Offset: 0x0000C7E6
		internal static bool IsSingleProcessor
		{
			get
			{
				return Environment.ProcessorCount == 1;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		public static bool IsPrivilegedProcess
		{
			get
			{
				sbyte b = Environment.s_privilegedProcess;
				if (b == 0)
				{
					b = (Environment.s_privilegedProcess = (Environment.IsPrivilegedProcessCore() ? 1 : -1));
				}
				return b > 0;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool HasShutdownStarted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000E620 File Offset: 0x0000C820
		[return: Nullable(2)]
		public static string GetEnvironmentVariable(string variable)
		{
			ArgumentNullException.ThrowIfNull(variable, "variable");
			return Environment.GetEnvironmentVariableCore(variable);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000E634 File Offset: 0x0000C834
		[return: Nullable(2)]
		public static string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target)
		{
			if (target == EnvironmentVariableTarget.Process)
			{
				return Environment.GetEnvironmentVariable(variable);
			}
			ArgumentNullException.ThrowIfNull(variable, "variable");
			bool fromMachine = Environment.ValidateAndConvertRegistryTarget(target);
			return Environment.GetEnvironmentVariableFromRegistry(variable, fromMachine);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000E664 File Offset: 0x0000C864
		public static IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target)
		{
			if (target == EnvironmentVariableTarget.Process)
			{
				return Environment.GetEnvironmentVariables();
			}
			return Environment.GetEnvironmentVariablesFromRegistry(Environment.ValidateAndConvertRegistryTarget(target));
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000E67A File Offset: 0x0000C87A
		public static void SetEnvironmentVariable(string variable, [Nullable(2)] string value)
		{
			Environment.ValidateVariable(variable);
			Environment.SetEnvironmentVariableCore(variable, value);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000E68C File Offset: 0x0000C88C
		public static void SetEnvironmentVariable(string variable, [Nullable(2)] string value, EnvironmentVariableTarget target)
		{
			if (target == EnvironmentVariableTarget.Process)
			{
				Environment.SetEnvironmentVariable(variable, value);
				return;
			}
			Environment.ValidateVariable(variable);
			bool fromMachine = Environment.ValidateAndConvertRegistryTarget(target);
			Environment.SetEnvironmentVariableFromRegistry(variable, value, fromMachine);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000E6B9 File Offset: 0x0000C8B9
		public static string CommandLine
		{
			get
			{
				return PasteArguments.Paste(Environment.GetCommandLineArgs(), true);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000E6C6 File Offset: 0x0000C8C6
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0000E6CD File Offset: 0x0000C8CD
		public static string CurrentDirectory
		{
			get
			{
				return Environment.CurrentDirectoryCore;
			}
			set
			{
				ArgumentException.ThrowIfNullOrEmpty(value, "value");
				Environment.CurrentDirectoryCore = value;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
		public static string ExpandEnvironmentVariables(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (name.Length == 0)
			{
				return name;
			}
			return Environment.ExpandEnvironmentVariablesCore(name);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000E6FD File Offset: 0x0000C8FD
		public static string GetFolderPath(Environment.SpecialFolder folder)
		{
			return Environment.GetFolderPath(folder, Environment.SpecialFolderOption.None);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000E708 File Offset: 0x0000C908
		public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			if (!Enum.IsDefined<Environment.SpecialFolder>(folder))
			{
				throw new ArgumentOutOfRangeException("folder", folder, SR.Format(SR.Arg_EnumIllegalVal, folder));
			}
			if (option != Environment.SpecialFolderOption.None && !Enum.IsDefined<Environment.SpecialFolderOption>(option))
			{
				throw new ArgumentOutOfRangeException("option", option, SR.Format(SR.Arg_EnumIllegalVal, option));
			}
			return Environment.GetFolderPathCore(folder, option);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000E774 File Offset: 0x0000C974
		public static int ProcessId
		{
			get
			{
				int num = Environment.s_processId;
				if (num == 0)
				{
					num = (Environment.s_processId = Environment.GetProcessId());
				}
				return num;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000E79C File Offset: 0x0000C99C
		[Nullable(2)]
		public static string ProcessPath
		{
			[NullableContext(2)]
			get
			{
				string text = Environment.s_processPath;
				if (text == null)
				{
					Interlocked.CompareExchange<string>(ref Environment.s_processPath, Environment.GetProcessPath() ?? "", null);
					text = Environment.s_processPath;
				}
				if (text.Length == 0)
				{
					return null;
				}
				return text;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000E7E1 File Offset: 0x0000C9E1
		public static bool Is64BitProcess
		{
			get
			{
				return 8 == 8;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000E7EB File Offset: 0x0000C9EB
		public static bool Is64BitOperatingSystem
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000E7F5 File Offset: 0x0000C9F5
		public static string NewLine
		{
			get
			{
				return "\r\n";
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000E7FC File Offset: 0x0000C9FC
		public static OperatingSystem OSVersion
		{
			get
			{
				OperatingSystem operatingSystem = Environment.s_osVersion;
				if (operatingSystem == null)
				{
					Interlocked.CompareExchange<OperatingSystem>(ref Environment.s_osVersion, Environment.GetOSVersion(), null);
					operatingSystem = Environment.s_osVersion;
				}
				return operatingSystem;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000E82E File Offset: 0x0000CA2E
		public static string StackTrace
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return new StackTrace(true).ToString(System.Diagnostics.StackTrace.TraceFormat.Normal);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000E83C File Offset: 0x0000CA3C
		public static int SystemPageSize
		{
			get
			{
				int num = Environment.s_systemPageSize;
				if (num == 0)
				{
					num = (Environment.s_systemPageSize = Environment.GetSystemPageSize());
				}
				return num;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000E863 File Offset: 0x0000CA63
		private static bool ValidateAndConvertRegistryTarget(EnvironmentVariableTarget target)
		{
			if (target == EnvironmentVariableTarget.Machine)
			{
				return true;
			}
			if (target == EnvironmentVariableTarget.User)
			{
				return false;
			}
			throw new ArgumentOutOfRangeException("target", target, SR.Format(SR.Arg_EnumIllegalVal, target));
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000E891 File Offset: 0x0000CA91
		private static void ValidateVariable(string variable)
		{
			ArgumentException.ThrowIfNullOrEmpty(variable, "variable");
			if (variable[0] == '\0')
			{
				throw new ArgumentException(SR.Argument_StringFirstCharIsZero, "variable");
			}
			if (variable.Contains('='))
			{
				throw new ArgumentException(SR.Argument_IllegalEnvVarName, "variable");
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000E8D1 File Offset: 0x0000CAD1
		internal static bool IsWindows8OrAbove
		{
			get
			{
				return Environment.WindowsVersion.IsWindows8OrAbove;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		private static string GetEnvironmentVariableFromRegistry(string variable, bool fromMachine)
		{
			string result;
			using (RegistryKey registryKey = Environment.OpenEnvironmentKeyIfExists(fromMachine, false))
			{
				result = (((registryKey != null) ? registryKey.GetValue(variable) : null) as string);
			}
			return result;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000E920 File Offset: 0x0000CB20
		private static Hashtable GetEnvironmentVariablesFromRegistry(bool fromMachine)
		{
			Hashtable hashtable = new Hashtable();
			using (RegistryKey registryKey = Environment.OpenEnvironmentKeyIfExists(fromMachine, false))
			{
				if (registryKey != null)
				{
					foreach (string text in registryKey.GetValueNames())
					{
						string value = registryKey.GetValue(text, "").ToString();
						try
						{
							hashtable.Add(text, value);
						}
						catch (ArgumentException)
						{
						}
					}
				}
			}
			return hashtable;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		private static RegistryKey OpenEnvironmentKeyIfExists(bool fromMachine, bool writable)
		{
			RegistryKey registryKey;
			string name;
			if (fromMachine)
			{
				registryKey = Registry.LocalMachine;
				name = "System\\CurrentControlSet\\Control\\Session Manager\\Environment";
			}
			else
			{
				registryKey = Registry.CurrentUser;
				name = "Environment";
			}
			return registryKey.OpenSubKey(name, writable);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		public unsafe static string UserName
		{
			get
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)80], 40);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				Environment.GetUserName(ref valueStringBuilder);
				ReadOnlySpan<char> span = valueStringBuilder.AsSpan();
				int num = span.IndexOf('\\');
				if (num >= 0)
				{
					span = span.Slice(num + 1);
				}
				string result = span.ToString();
				valueStringBuilder.Dispose();
				return result;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000EA38 File Offset: 0x0000CC38
		private static void GetUserName(ref ValueStringBuilder builder)
		{
			uint num = 0U;
			while (Interop.Secur32.GetUserNameExW(2, builder.GetPinnableReference(), ref num) == Interop.BOOLEAN.FALSE)
			{
				if (Marshal.GetLastPInvokeError() != 234)
				{
					builder.Length = 0;
					return;
				}
				builder.EnsureCapacity(checked((int)num));
			}
			builder.Length = (int)num;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000EA80 File Offset: 0x0000CC80
		private unsafe static void SetEnvironmentVariableFromRegistry(string variable, string value, bool fromMachine)
		{
			if (!fromMachine && variable.Length >= 255)
			{
				throw new ArgumentException(SR.Argument_LongEnvVarValue, "variable");
			}
			using (RegistryKey registryKey = Environment.OpenEnvironmentKeyIfExists(fromMachine, true))
			{
				if (registryKey != null)
				{
					if (value == null)
					{
						registryKey.DeleteValue(variable, false);
					}
					else
					{
						registryKey.SetValue(variable, value);
					}
				}
			}
			fixed (char* pinnableReference = "Environment".GetPinnableReference())
			{
				char* lParam = pinnableReference;
				IntPtr intPtr;
				Interop.User32.SendMessageTimeout(new IntPtr(65535), 26, IntPtr.Zero, lParam, 0, 1000, &intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000EB1C File Offset: 0x0000CD1C
		public unsafe static string UserDomainName
		{
			get
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)80], 40);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				Environment.GetUserName(ref valueStringBuilder);
				int num = valueStringBuilder.AsSpan().IndexOf('\\');
				if (num >= 0)
				{
					valueStringBuilder.Length = num;
					return valueStringBuilder.ToString();
				}
				initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
				ValueStringBuilder valueStringBuilder2 = new ValueStringBuilder(initialBuffer);
				uint capacity = (uint)valueStringBuilder2.Capacity;
				Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)68], 68);
				uint num2 = 68U;
				uint num3;
				while (!Interop.Advapi32.LookupAccountNameW(null, valueStringBuilder.GetPinnableReference(), MemoryMarshal.GetReference<byte>(span), ref num2, valueStringBuilder2.GetPinnableReference(), ref capacity, out num3))
				{
					int lastPInvokeError = Marshal.GetLastPInvokeError();
					if (lastPInvokeError != 122)
					{
						throw new InvalidOperationException(Marshal.GetPInvokeErrorMessage(lastPInvokeError));
					}
					valueStringBuilder2.EnsureCapacity((int)capacity);
				}
				valueStringBuilder.Dispose();
				valueStringBuilder2.Length = (int)capacity;
				return valueStringBuilder2.ToString();
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000EC08 File Offset: 0x0000CE08
		private static string GetFolderPathCore(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			string g;
			switch (folder)
			{
			case Environment.SpecialFolder.Desktop:
				g = "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}";
				goto IL_2BE;
			case Environment.SpecialFolder.Programs:
				g = "{A77F5D77-2E2B-44C3-A6A2-ABA601054A51}";
				goto IL_2BE;
			case Environment.SpecialFolder.Personal:
				g = "{FDD39AD0-238F-46AF-ADB4-6C85480369C7}";
				goto IL_2BE;
			case Environment.SpecialFolder.Favorites:
				g = "{1777F761-68AD-4D8A-87BD-30B759FA33DD}";
				goto IL_2BE;
			case Environment.SpecialFolder.Startup:
				g = "{B97D20BB-F46A-4C97-BA10-5E3608430854}";
				goto IL_2BE;
			case Environment.SpecialFolder.Recent:
				g = "{AE50C081-EBD2-438A-8655-8A092E34987A}";
				goto IL_2BE;
			case Environment.SpecialFolder.SendTo:
				g = "{8983036C-27C0-404B-8F08-102D10DCFD74}";
				goto IL_2BE;
			case Environment.SpecialFolder.StartMenu:
				g = "{625B53C3-AB48-4EC1-BA1F-A1EF4146FC19}";
				goto IL_2BE;
			case Environment.SpecialFolder.MyMusic:
				g = "{4BD8D571-6D19-48D3-BE97-422220080E43}";
				goto IL_2BE;
			case Environment.SpecialFolder.MyVideos:
				g = "{18989B1D-99B5-455B-841C-AB7C74E4DDFC}";
				goto IL_2BE;
			case Environment.SpecialFolder.DesktopDirectory:
				g = "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}";
				goto IL_2BE;
			case Environment.SpecialFolder.MyComputer:
				g = "{0AC0837C-BBF8-452A-850D-79D08E667CA7}";
				goto IL_2BE;
			case Environment.SpecialFolder.NetworkShortcuts:
				g = "{C5ABBF53-E17F-4121-8900-86626FC2C973}";
				goto IL_2BE;
			case Environment.SpecialFolder.Fonts:
				g = "{FD228CB7-AE11-4AE3-864C-16F3910AB8FE}";
				goto IL_2BE;
			case Environment.SpecialFolder.Templates:
				g = "{A63293E8-664E-48DB-A079-DF759E0509F7}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonStartMenu:
				g = "{A4115719-D62E-491D-AA7C-E74B8BE3B067}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonPrograms:
				g = "{0139D44E-6AFE-49F2-8690-3DAFCAE6FFB8}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonStartup:
				g = "{82A5EA35-D9CD-47C5-9629-E15D2F714E6E}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonDesktopDirectory:
				g = "{C4AA340D-F20F-4863-AFEF-F87EF2E6BA25}";
				goto IL_2BE;
			case Environment.SpecialFolder.ApplicationData:
				g = "{3EB685DB-65F9-4CF6-A03A-E3EF65729F3D}";
				goto IL_2BE;
			case Environment.SpecialFolder.PrinterShortcuts:
				g = "{76FC4E2D-D6AD-4519-A663-37BD56068185}";
				goto IL_2BE;
			case Environment.SpecialFolder.LocalApplicationData:
				g = "{F1B32785-6FBA-4FCF-9D55-7B8E7F157091}";
				goto IL_2BE;
			case Environment.SpecialFolder.InternetCache:
				g = "{352481E8-33BE-4251-BA85-6007CAEDCF9D}";
				goto IL_2BE;
			case Environment.SpecialFolder.Cookies:
				g = "{2B0F765D-C0E9-4171-908E-08A611B84FF6}";
				goto IL_2BE;
			case Environment.SpecialFolder.History:
				g = "{D9DC8A3B-B784-432E-A781-5A1130A75963}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonApplicationData:
				g = "{62AB5D82-FDC1-4DC3-A9DD-070D1D495D97}";
				goto IL_2BE;
			case Environment.SpecialFolder.Windows:
				g = "{F38BF404-1D43-42F2-9305-67DE0B28FC23}";
				goto IL_2BE;
			case Environment.SpecialFolder.System:
				return Environment.SystemDirectory;
			case Environment.SpecialFolder.ProgramFiles:
				g = "{905e63b6-c1bf-494e-b29c-65b732d3d21a}";
				goto IL_2BE;
			case Environment.SpecialFolder.MyPictures:
				g = "{33E28130-4E1E-4676-835A-98395C3BC3BB}";
				goto IL_2BE;
			case Environment.SpecialFolder.UserProfile:
				g = "{5E6C858F-0E22-4760-9AFE-EA3317B67173}";
				goto IL_2BE;
			case Environment.SpecialFolder.SystemX86:
				g = "{D65231B0-B2F1-4857-A4CE-A8E7C6EA7D27}";
				goto IL_2BE;
			case Environment.SpecialFolder.ProgramFilesX86:
				g = "{7C5A40EF-A0FB-4BFC-874A-C0F2E0B9FA8E}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonProgramFiles:
				g = "{F7F1ED05-9F6D-47A2-AAAE-29D317C6F066}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonProgramFilesX86:
				g = "{DE974D24-D9C6-4D3E-BF91-F4455120B917}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonTemplates:
				g = "{B94237E7-57AC-4347-9151-B08C6C32D1F7}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonDocuments:
				g = "{ED4824AF-DCE4-45A8-81E2-FC7965083634}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonAdminTools:
				g = "{D0384E7D-BAC3-4797-8F14-CBA229B392B5}";
				goto IL_2BE;
			case Environment.SpecialFolder.AdminTools:
				g = "{724EF170-A42D-4FEF-9F26-B60E846FBA4F}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonMusic:
				g = "{3214FAB5-9757-4298-BB61-92A9DEAA44FF}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonPictures:
				g = "{B6EBFB86-6907-413C-9AF7-4FC2ABF07CC5}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonVideos:
				g = "{2400183A-6185-49FB-A2D8-4A392A602BA3}";
				goto IL_2BE;
			case Environment.SpecialFolder.Resources:
				g = "{8AD10C31-2ADB-4296-A8F7-E4701232C972}";
				goto IL_2BE;
			case Environment.SpecialFolder.LocalizedResources:
				g = "{2A00375E-224C-49DE-B8D1-440DF7EF3DDC}";
				goto IL_2BE;
			case Environment.SpecialFolder.CommonOemLinks:
				g = "{C1BAE2D0-10DF-4334-BEDD-7AA20B227A9D}";
				goto IL_2BE;
			case Environment.SpecialFolder.CDBurning:
				g = "{9E52AB10-F80D-49DF-ACB8-4330F5687855}";
				goto IL_2BE;
			}
			return string.Empty;
			IL_2BE:
			Guid guid = new Guid(g);
			string result;
			if (Interop.Shell32.SHGetKnownFolderPath(guid, (uint)option, IntPtr.Zero, out result) != 0)
			{
				return string.Empty;
			}
			return result;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0000EF8C File Offset: 0x0000D18C
		private unsafe static string CurrentDirectoryCore
		{
			get
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				uint currentDirectory;
				while ((ulong)(currentDirectory = Interop.Kernel32.GetCurrentDirectory((uint)valueStringBuilder.Capacity, valueStringBuilder.GetPinnableReference())) > (ulong)((long)valueStringBuilder.Capacity))
				{
					valueStringBuilder.EnsureCapacity((int)currentDirectory);
				}
				if (currentDirectory == 0U)
				{
					throw Win32Marshal.GetExceptionForLastWin32Error("");
				}
				valueStringBuilder.Length = (int)currentDirectory;
				if (valueStringBuilder.AsSpan().Contains('~'))
				{
					string result = PathHelper.TryExpandShortFileName(ref valueStringBuilder, null);
					valueStringBuilder.Dispose();
					return result;
				}
				return valueStringBuilder.ToString();
			}
			set
			{
				if (!Interop.Kernel32.SetCurrentDirectory(value))
				{
					int lastPInvokeError = Marshal.GetLastPInvokeError();
					throw Win32Marshal.GetExceptionForWin32Error((lastPInvokeError == 2) ? 3 : lastPInvokeError, value, null);
				}
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000EFB7 File Offset: 0x0000D1B7
		public static string[] GetLogicalDrives()
		{
			return DriveInfoInternal.GetLogicalDrives();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
		private unsafe static int GetSystemPageSize()
		{
			Interop.Kernel32.SYSTEM_INFO system_INFO;
			Interop.Kernel32.GetSystemInfo(&system_INFO);
			return system_INFO.dwPageSize;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		private unsafe static string ExpandEnvironmentVariablesCore(string name)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			uint num;
			while ((ulong)(num = Interop.Kernel32.ExpandEnvironmentStrings(name, valueStringBuilder.GetPinnableReference(), (uint)valueStringBuilder.Capacity)) > (ulong)((long)valueStringBuilder.Capacity))
			{
				valueStringBuilder.EnsureCapacity((int)num);
			}
			if (num == 0U)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			valueStringBuilder.Length = (int)(num - 1U);
			return valueStringBuilder.ToString();
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000F054 File Offset: 0x0000D254
		public unsafe static string SystemDirectory
		{
			get
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)64], 32);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				uint systemDirectoryW;
				while ((ulong)(systemDirectoryW = Interop.Kernel32.GetSystemDirectoryW(valueStringBuilder.GetPinnableReference(), (uint)valueStringBuilder.Capacity)) > (ulong)((long)valueStringBuilder.Capacity))
				{
					valueStringBuilder.EnsureCapacity((int)systemDirectoryW);
				}
				if (systemDirectoryW == 0U)
				{
					throw Win32Marshal.GetExceptionForLastWin32Error("");
				}
				valueStringBuilder.Length = (int)systemDirectoryW;
				return valueStringBuilder.ToString();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public static long WorkingSet
		{
			get
			{
				Interop.Kernel32.PROCESS_MEMORY_COUNTERS process_MEMORY_COUNTERS = default(Interop.Kernel32.PROCESS_MEMORY_COUNTERS);
				process_MEMORY_COUNTERS.cb = (uint)sizeof(Interop.Kernel32.PROCESS_MEMORY_COUNTERS);
				if (!Interop.Kernel32.GetProcessMemoryInfo(Interop.Kernel32.GetCurrentProcess(), ref process_MEMORY_COUNTERS, process_MEMORY_COUNTERS.cb))
				{
					return 0L;
				}
				return (long)((ulong)process_MEMORY_COUNTERS.WorkingSetSize);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000F104 File Offset: 0x0000D304
		public static string MachineName
		{
			get
			{
				string computerName = Interop.Kernel32.GetComputerName();
				if (computerName == null)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ComputerName);
				}
				return computerName;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000F11A File Offset: 0x0000D31A
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int GetProcessId()
		{
			return (int)Interop.Kernel32.GetCurrentProcessId();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000F124 File Offset: 0x0000D324
		private unsafe static string GetProcessPath()
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)520], 260);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			uint moduleFileName;
			while ((ulong)(moduleFileName = Interop.Kernel32.GetModuleFileName(IntPtr.Zero, valueStringBuilder.GetPinnableReference(), (uint)valueStringBuilder.Capacity)) >= (ulong)((long)valueStringBuilder.Capacity))
			{
				valueStringBuilder.EnsureCapacity((int)moduleFileName);
			}
			if (moduleFileName == 0U)
			{
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			valueStringBuilder.Length = (int)moduleFileName;
			return valueStringBuilder.ToString();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		private unsafe static OperatingSystem GetOSVersion()
		{
			Interop.NtDll.RTL_OSVERSIONINFOEX rtl_OSVERSIONINFOEX;
			if (Interop.NtDll.RtlGetVersionEx(out rtl_OSVERSIONINFOEX) != 0)
			{
				throw new InvalidOperationException(SR.InvalidOperation_GetVersion);
			}
			Version version = new Version((int)rtl_OSVERSIONINFOEX.dwMajorVersion, (int)rtl_OSVERSIONINFOEX.dwMinorVersion, (int)rtl_OSVERSIONINFOEX.dwBuildNumber, 0);
			if (rtl_OSVERSIONINFOEX.szCSDVersion.FixedElementField == '\0')
			{
				return new OperatingSystem(PlatformID.Win32NT, version);
			}
			return new OperatingSystem(PlatformID.Win32NT, version, new string(&rtl_OSVERSIONINFOEX.szCSDVersion.FixedElementField));
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000F20C File Offset: 0x0000D40C
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("tvos")]
		[UnsupportedOSPlatform("browser")]
		[SupportedOSPlatform("maccatalyst")]
		public static Environment.ProcessCpuUsage CpuUsage
		{
			get
			{
				long num;
				long num2;
				long ticks;
				long ticks2;
				if (!Interop.Kernel32.GetProcessTimes(Interop.Kernel32.GetCurrentProcess(), out num, out num2, out ticks, out ticks2))
				{
					return new Environment.ProcessCpuUsage
					{
						UserTime = TimeSpan.Zero,
						PrivilegedTime = TimeSpan.Zero
					};
				}
				return new Environment.ProcessCpuUsage
				{
					UserTime = new TimeSpan(ticks2),
					PrivilegedTime = new TimeSpan(ticks)
				};
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000F274 File Offset: 0x0000D474
		private unsafe static bool IsPrivilegedProcessCore()
		{
			SafeTokenHandle safeTokenHandle = null;
			try
			{
				if (Interop.Advapi32.OpenProcessToken(Interop.Kernel32.GetCurrentProcess(), 131080, out safeTokenHandle))
				{
					Interop.Advapi32.TOKEN_ELEVATION token_ELEVATION = default(Interop.Advapi32.TOKEN_ELEVATION);
					uint num;
					if (Interop.Advapi32.GetTokenInformation(safeTokenHandle, Interop.Advapi32.TOKEN_INFORMATION_CLASS.TokenElevation, (void*)(&token_ELEVATION), (uint)sizeof(Interop.Advapi32.TOKEN_ELEVATION), out num))
					{
						return token_ELEVATION.TokenIsElevated > Interop.BOOL.FALSE;
					}
				}
				throw Win32Marshal.GetExceptionForLastWin32Error("");
			}
			finally
			{
				if (safeTokenHandle != null)
				{
					safeTokenHandle.Dispose();
				}
			}
			bool result;
			return result;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		public unsafe static bool UserInteractive
		{
			get
			{
				IntPtr processWindowStation = Interop.User32.GetProcessWindowStation();
				if (processWindowStation != IntPtr.Zero)
				{
					Interop.User32.USEROBJECTFLAGS userobjectflags = default(Interop.User32.USEROBJECTFLAGS);
					uint num = 0U;
					if (Interop.User32.GetUserObjectInformationW(processWindowStation, 1, (void*)(&userobjectflags), (uint)sizeof(Interop.User32.USEROBJECTFLAGS), ref num))
					{
						return (userobjectflags.dwFlags & 1) != 0;
					}
				}
				return true;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000F330 File Offset: 0x0000D530
		private unsafe static string GetEnvironmentVariableCore(string variable)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			uint environmentVariable;
			while ((ulong)(environmentVariable = Interop.Kernel32.GetEnvironmentVariable(variable, valueStringBuilder.GetPinnableReference(), (uint)valueStringBuilder.Capacity)) > (ulong)((long)valueStringBuilder.Capacity))
			{
				valueStringBuilder.EnsureCapacity((int)environmentVariable);
			}
			if (environmentVariable == 0U && Marshal.GetLastPInvokeError() == 203)
			{
				valueStringBuilder.Dispose();
				return null;
			}
			valueStringBuilder.Length = (int)environmentVariable;
			return valueStringBuilder.ToString();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
		internal unsafe static string GetEnvironmentVariableCore_NoArrayPool(string variable)
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			uint environmentVariable = Interop.Kernel32.GetEnvironmentVariable(variable, MemoryMarshal.GetReference<char>(span), (uint)span.Length);
			if (environmentVariable <= 0U || (ulong)environmentVariable > (ulong)((long)span.Length))
			{
				return null;
			}
			return span.Slice(0, (int)environmentVariable).ToString();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000F410 File Offset: 0x0000D610
		private static void SetEnvironmentVariableCore(string variable, string value)
		{
			if (!Interop.Kernel32.SetEnvironmentVariable(variable, value))
			{
				int lastPInvokeError = Marshal.GetLastPInvokeError();
				if (lastPInvokeError <= 203)
				{
					if (lastPInvokeError != 8)
					{
						if (lastPInvokeError != 203)
						{
							goto IL_4F;
						}
						return;
					}
				}
				else
				{
					if (lastPInvokeError == 206)
					{
						throw new ArgumentException(SR.Argument_LongEnvVarValue);
					}
					if (lastPInvokeError != 1450)
					{
						goto IL_4F;
					}
				}
				throw new OutOfMemoryException(Marshal.GetPInvokeErrorMessage(lastPInvokeError));
				IL_4F:
				throw new ArgumentException(Marshal.GetPInvokeErrorMessage(lastPInvokeError));
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000F478 File Offset: 0x0000D678
		public unsafe static IDictionary GetEnvironmentVariables()
		{
			char* environmentStringsW = Interop.Kernel32.GetEnvironmentStringsW();
			if (environmentStringsW == null)
			{
				throw new OutOfMemoryException();
			}
			IDictionary result;
			try
			{
				Hashtable hashtable = new Hashtable();
				char* ptr = environmentStringsW;
				for (;;)
				{
					ReadOnlySpan<char> span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated(ptr);
					if (span.IsEmpty)
					{
						break;
					}
					int num = span.IndexOf('=');
					if (num > 0)
					{
						string key = new string(span.Slice(0, num));
						string value = new string(span.Slice(num + 1));
						try
						{
							hashtable.Add(key, value);
						}
						catch (ArgumentException)
						{
						}
					}
					ptr += span.Length + 1;
				}
				result = hashtable;
			}
			finally
			{
				Interop.Kernel32.FreeEnvironmentStringsW(environmentStringsW);
			}
			return result;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0000F52C File Offset: 0x0000D72C
		[Nullable(0)]
		public static Version Version
		{
			[NullableContext(0)]
			get
			{
				return new Version(9, 0, 6);
			}
		}

		// Token: 0x0400020B RID: 523
		private static volatile sbyte s_privilegedProcess;

		// Token: 0x0400020C RID: 524
		private static volatile int s_processId;

		// Token: 0x0400020D RID: 525
		private static volatile string s_processPath;

		// Token: 0x0400020E RID: 526
		private static volatile OperatingSystem s_osVersion;

		// Token: 0x0400020F RID: 527
		private static volatile int s_systemPageSize;

		// Token: 0x0200007F RID: 127
		[NullableContext(0)]
		public readonly struct ProcessCpuUsage
		{
			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000F543 File Offset: 0x0000D743
			// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000F54B File Offset: 0x0000D74B
			public TimeSpan UserTime { get; internal set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000F554 File Offset: 0x0000D754
			// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000F55C File Offset: 0x0000D75C
			public TimeSpan PrivilegedTime { get; internal set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000F565 File Offset: 0x0000D765
			public TimeSpan TotalTime
			{
				get
				{
					return this.UserTime + this.PrivilegedTime;
				}
			}
		}

		// Token: 0x02000080 RID: 128
		[NullableContext(0)]
		public enum SpecialFolder
		{
			// Token: 0x04000213 RID: 531
			ApplicationData = 26,
			// Token: 0x04000214 RID: 532
			CommonApplicationData = 35,
			// Token: 0x04000215 RID: 533
			LocalApplicationData = 28,
			// Token: 0x04000216 RID: 534
			Cookies = 33,
			// Token: 0x04000217 RID: 535
			Desktop = 0,
			// Token: 0x04000218 RID: 536
			Favorites = 6,
			// Token: 0x04000219 RID: 537
			History = 34,
			// Token: 0x0400021A RID: 538
			InternetCache = 32,
			// Token: 0x0400021B RID: 539
			Programs = 2,
			// Token: 0x0400021C RID: 540
			MyComputer = 17,
			// Token: 0x0400021D RID: 541
			MyMusic = 13,
			// Token: 0x0400021E RID: 542
			MyPictures = 39,
			// Token: 0x0400021F RID: 543
			MyVideos = 14,
			// Token: 0x04000220 RID: 544
			Recent = 8,
			// Token: 0x04000221 RID: 545
			SendTo,
			// Token: 0x04000222 RID: 546
			StartMenu = 11,
			// Token: 0x04000223 RID: 547
			Startup = 7,
			// Token: 0x04000224 RID: 548
			System = 37,
			// Token: 0x04000225 RID: 549
			Templates = 21,
			// Token: 0x04000226 RID: 550
			DesktopDirectory = 16,
			// Token: 0x04000227 RID: 551
			Personal = 5,
			// Token: 0x04000228 RID: 552
			MyDocuments = 5,
			// Token: 0x04000229 RID: 553
			ProgramFiles = 38,
			// Token: 0x0400022A RID: 554
			CommonProgramFiles = 43,
			// Token: 0x0400022B RID: 555
			AdminTools = 48,
			// Token: 0x0400022C RID: 556
			CDBurning = 59,
			// Token: 0x0400022D RID: 557
			CommonAdminTools = 47,
			// Token: 0x0400022E RID: 558
			CommonDocuments = 46,
			// Token: 0x0400022F RID: 559
			CommonMusic = 53,
			// Token: 0x04000230 RID: 560
			CommonOemLinks = 58,
			// Token: 0x04000231 RID: 561
			CommonPictures = 54,
			// Token: 0x04000232 RID: 562
			CommonStartMenu = 22,
			// Token: 0x04000233 RID: 563
			CommonPrograms,
			// Token: 0x04000234 RID: 564
			CommonStartup,
			// Token: 0x04000235 RID: 565
			CommonDesktopDirectory,
			// Token: 0x04000236 RID: 566
			CommonTemplates = 45,
			// Token: 0x04000237 RID: 567
			CommonVideos = 55,
			// Token: 0x04000238 RID: 568
			Fonts = 20,
			// Token: 0x04000239 RID: 569
			NetworkShortcuts = 19,
			// Token: 0x0400023A RID: 570
			PrinterShortcuts = 27,
			// Token: 0x0400023B RID: 571
			UserProfile = 40,
			// Token: 0x0400023C RID: 572
			CommonProgramFilesX86 = 44,
			// Token: 0x0400023D RID: 573
			ProgramFilesX86 = 42,
			// Token: 0x0400023E RID: 574
			Resources = 56,
			// Token: 0x0400023F RID: 575
			LocalizedResources,
			// Token: 0x04000240 RID: 576
			SystemX86 = 41,
			// Token: 0x04000241 RID: 577
			Windows = 36
		}

		// Token: 0x02000081 RID: 129
		[NullableContext(0)]
		public enum SpecialFolderOption
		{
			// Token: 0x04000243 RID: 579
			None,
			// Token: 0x04000244 RID: 580
			Create = 32768,
			// Token: 0x04000245 RID: 581
			DoNotVerify = 16384
		}

		// Token: 0x02000082 RID: 130
		private static class WindowsVersion
		{
			// Token: 0x04000246 RID: 582
			internal static readonly bool IsWindows8OrAbove = OperatingSystem.IsWindowsVersionAtLeast(6, 2, 0, 0);
		}
	}
}
