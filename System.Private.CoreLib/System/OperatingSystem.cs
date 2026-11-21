using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x02000188 RID: 392
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class OperatingSystem : ISerializable, ICloneable
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x00054B50 File Offset: 0x00052D50
		public OperatingSystem(PlatformID platform, Version version) : this(platform, version, null)
		{
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00054B5C File Offset: 0x00052D5C
		internal OperatingSystem(PlatformID platform, Version version, string servicePack)
		{
			if (platform < PlatformID.Win32S || platform > PlatformID.Other)
			{
				throw new ArgumentOutOfRangeException("platform", platform, SR.Format(SR.Arg_EnumIllegalVal, platform));
			}
			ArgumentNullException.ThrowIfNull(version, "version");
			this._platform = platform;
			this._version = version;
			this._servicePack = servicePack;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00054BB8 File Offset: 0x00052DB8
		public PlatformID Platform
		{
			get
			{
				return this._platform;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00054BC0 File Offset: 0x00052DC0
		public string ServicePack
		{
			get
			{
				return this._servicePack ?? string.Empty;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x00054BD1 File Offset: 0x00052DD1
		public Version Version
		{
			get
			{
				return this._version;
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00054BD9 File Offset: 0x00052DD9
		public object Clone()
		{
			return new OperatingSystem(this._platform, this._version, this._servicePack);
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00054BF2 File Offset: 0x00052DF2
		public override string ToString()
		{
			return this.VersionString;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00054BFC File Offset: 0x00052DFC
		public unsafe string VersionString
		{
			get
			{
				if (this._versionString == null)
				{
					string value;
					switch (this._platform)
					{
					case PlatformID.Win32S:
						value = "Microsoft Win32S ";
						break;
					case PlatformID.Win32Windows:
						value = ((this._version.Major > 4 || (this._version.Major == 4 && this._version.Minor > 0)) ? "Microsoft Windows 98 " : "Microsoft Windows 95 ");
						break;
					case PlatformID.Win32NT:
						value = "Microsoft Windows NT ";
						break;
					case PlatformID.WinCE:
						value = "Microsoft Windows CE ";
						break;
					case PlatformID.Unix:
						value = "Unix ";
						break;
					case PlatformID.Xbox:
						value = "Xbox ";
						break;
					case PlatformID.MacOSX:
						value = "Mac OS X ";
						break;
					case PlatformID.Other:
						value = "Other ";
						break;
					default:
						value = "<unknown> ";
						break;
					}
					Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
					string versionString;
					if (!string.IsNullOrEmpty(this._servicePack))
					{
						IFormatProvider formatProvider = null;
						IFormatProvider provider = formatProvider;
						Span<char> span2 = span;
						Span<char> initialBuffer = span2;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3, formatProvider, span2);
						defaultInterpolatedStringHandler.AppendFormatted(value);
						defaultInterpolatedStringHandler.AppendFormatted(this._version.ToString(3));
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(this._servicePack);
						versionString = string.Create(provider, initialBuffer, ref defaultInterpolatedStringHandler);
					}
					else
					{
						IFormatProvider formatProvider = null;
						IFormatProvider provider2 = formatProvider;
						Span<char> span2 = span;
						Span<char> initialBuffer2 = span2;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(0, 2, formatProvider, span2);
						defaultInterpolatedStringHandler2.AppendFormatted(value);
						defaultInterpolatedStringHandler2.AppendFormatted<Version>(this._version);
						versionString = string.Create(provider2, initialBuffer2, ref defaultInterpolatedStringHandler2);
					}
					this._versionString = versionString;
				}
				return this._versionString;
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00054D67 File Offset: 0x00052F67
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOSPlatform(string platform)
		{
			ArgumentNullException.ThrowIfNull(platform, "platform");
			return platform.Equals("WINDOWS", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00054D80 File Offset: 0x00052F80
		public static bool IsOSPlatformVersionAtLeast(string platform, int major, int minor = 0, int build = 0, int revision = 0)
		{
			return OperatingSystem.IsOSPlatform(platform) && OperatingSystem.IsOSVersionAtLeast(major, minor, build, revision);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsBrowser()
		{
			return false;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsWasi()
		{
			return false;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsLinux()
		{
			return false;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsFreeBSD()
		{
			return false;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00054D96 File Offset: 0x00052F96
		public static bool IsFreeBSDVersionAtLeast(int major, int minor = 0, int build = 0, int revision = 0)
		{
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsAndroid()
		{
			return false;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsOhos()
		{
			return false;
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00054D96 File Offset: 0x00052F96
		public static bool IsAndroidVersionAtLeast(int major, int minor = 0, int build = 0, int revision = 0)
		{
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00007B65 File Offset: 0x00005D65
		[SupportedOSPlatformGuard("maccatalyst")]
		[NonVersionable]
		public static bool IsIOS()
		{
			return false;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00054D96 File Offset: 0x00052F96
		[SupportedOSPlatformGuard("maccatalyst")]
		[NonVersionable]
		public static bool IsIOSVersionAtLeast(int major, int minor = 0, int build = 0)
		{
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsMacOS()
		{
			return false;
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00054D96 File Offset: 0x00052F96
		public static bool IsMacOSVersionAtLeast(int major, int minor = 0, int build = 0)
		{
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsMacCatalyst()
		{
			return false;
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00054D96 File Offset: 0x00052F96
		public static bool IsMacCatalystVersionAtLeast(int major, int minor = 0, int build = 0)
		{
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsTvOS()
		{
			return false;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00054D96 File Offset: 0x00052F96
		public static bool IsTvOSVersionAtLeast(int major, int minor = 0, int build = 0)
		{
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00007B65 File Offset: 0x00005D65
		[NonVersionable]
		public static bool IsWatchOS()
		{
			return false;
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00054D96 File Offset: 0x00052F96
		public static bool IsWatchOSVersionAtLeast(int major, int minor = 0, int build = 0)
		{
			if (false)
			{
			}
			return false;
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000070DD File Offset: 0x000052DD
		[NonVersionable]
		public static bool IsWindows()
		{
			return true;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00054D9C File Offset: 0x00052F9C
		public static bool IsWindowsVersionAtLeast(int major, int minor = 0, int build = 0, int revision = 0)
		{
			return OperatingSystem.IsOSVersionAtLeast(major, minor, build, revision);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00054DAC File Offset: 0x00052FAC
		private static bool IsOSVersionAtLeast(int major, int minor, int build, int revision)
		{
			Version version = Environment.OSVersion.Version;
			if (version.Major != major)
			{
				return version.Major > major;
			}
			if (version.Minor != minor)
			{
				return version.Minor > minor;
			}
			int num = (version.Build < 0) ? 0 : version.Build;
			build = ((build < 0) ? 0 : build);
			if (num != build)
			{
				return num > build;
			}
			int num2 = (version.Revision < 0) ? 0 : version.Revision;
			revision = ((revision < 0) ? 0 : revision);
			return num2 >= revision;
		}

		// Token: 0x04000536 RID: 1334
		private readonly Version _version;

		// Token: 0x04000537 RID: 1335
		private readonly PlatformID _platform;

		// Token: 0x04000538 RID: 1336
		private readonly string _servicePack;

		// Token: 0x04000539 RID: 1337
		private string _versionString;
	}
}
