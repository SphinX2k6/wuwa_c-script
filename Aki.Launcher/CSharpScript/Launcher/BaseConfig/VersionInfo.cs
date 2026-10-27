using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000271 RID: 625
	[NullableContext(1)]
	[Nullable(0)]
	public class VersionInfo
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x00058EE8 File Offset: 0x000570E8
		private VersionInfo(int major, int minor, int patch)
		{
			this.MajVer = major;
			this.MinVer = minor;
			this.PatVer = patch;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00058F05 File Offset: 0x00057105
		public int Major
		{
			get
			{
				return this.MajVer;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00058F0D File Offset: 0x0005710D
		public int Minor
		{
			get
			{
				return this.MinVer;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00058F15 File Offset: 0x00057115
		public int Patch
		{
			get
			{
				return this.PatVer;
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00058F20 File Offset: 0x00057120
		public string ToString(int num = 3)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (num == 1)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.MajVer);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (num == 2)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.MajVer);
				defaultInterpolatedStringHandler.AppendLiteral(".");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.MinVer);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.MajVer);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.MinVer);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.PatVer);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00058FDC File Offset: 0x000571DC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static ValueTuple<bool, VersionInfo> TryParse(string version)
		{
			if (string.IsNullOrEmpty(version) || version.Length <= 0)
			{
				return new ValueTuple<bool, VersionInfo>(false, null);
			}
			string[] array = version.Split('.', StringSplitOptions.None);
			if (array.Length < 3)
			{
				return new ValueTuple<bool, VersionInfo>(false, null);
			}
			int major;
			int minor;
			int patch;
			if (!int.TryParse(array[0], out major) || !int.TryParse(array[1], out minor) || !int.TryParse(array[2], out patch))
			{
				return new ValueTuple<bool, VersionInfo>(false, null);
			}
			return new ValueTuple<bool, VersionInfo>(true, new VersionInfo(major, minor, patch));
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00059054 File Offset: 0x00057254
		[NullableContext(2)]
		public static bool PackageEquals(VersionInfo a, VersionInfo b)
		{
			return a != null && b != null && a.MajVer == b.MajVer && a.MinVer == b.MinVer;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0005907A File Offset: 0x0005727A
		[NullableContext(2)]
		public static bool Equals(VersionInfo a, VersionInfo b)
		{
			return a != null && b != null && a.MajVer == b.MajVer && a.MinVer == b.MinVer && a.PatVer == b.PatVer;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x000590B0 File Offset: 0x000572B0
		public static bool LessThanOrEqual(VersionInfo a, VersionInfo b)
		{
			return a.MajVer < b.MajVer || (a.MajVer <= b.MajVer && (a.MinVer < b.MinVer || (a.MinVer <= b.MinVer && a.PatVer <= b.PatVer)));
		}

		// Token: 0x04000A1A RID: 2586
		private readonly int MajVer;

		// Token: 0x04000A1B RID: 2587
		private readonly int MinVer;

		// Token: 0x04000A1C RID: 2588
		private readonly int PatVer;
	}
}
