using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000278 RID: 632
	[NullableContext(1)]
	[Nullable(0)]
	public class VersionInfo
	{
		// Token: 0x06000F80 RID: 3968 RVA: 0x0005BE8F File Offset: 0x0005A08F
		private VersionInfo(int major, int minor, int patch)
		{
			this.MajVer = major;
			this.MinVer = minor;
			this.PatVer = patch;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0005BEAC File Offset: 0x0005A0AC
		public int Major
		{
			get
			{
				return this.MajVer;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
		public int Minor
		{
			get
			{
				return this.MinVer;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0005BEBC File Offset: 0x0005A0BC
		public int Patch
		{
			get
			{
				return this.PatVer;
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0005BEC4 File Offset: 0x0005A0C4
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

		// Token: 0x06000F85 RID: 3973 RVA: 0x0005BF80 File Offset: 0x0005A180
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

		// Token: 0x06000F86 RID: 3974 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
		[NullableContext(2)]
		public static bool PackageEquals(VersionInfo a, VersionInfo b)
		{
			return a != null && b != null && a.MajVer == b.MajVer && a.MinVer == b.MinVer;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0005C01E File Offset: 0x0005A21E
		[NullableContext(2)]
		public static bool Equals(VersionInfo a, VersionInfo b)
		{
			return a != null && b != null && a.MajVer == b.MajVer && a.MinVer == b.MinVer && a.PatVer == b.PatVer;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0005C054 File Offset: 0x0005A254
		public static bool LessThanOrEqual(VersionInfo a, VersionInfo b)
		{
			return a.MajVer < b.MajVer || (a.MajVer <= b.MajVer && (a.MinVer < b.MinVer || (a.MinVer <= b.MinVer && a.PatVer <= b.PatVer)));
		}

		// Token: 0x04000A68 RID: 2664
		private readonly int MajVer;

		// Token: 0x04000A69 RID: 2665
		private readonly int MinVer;

		// Token: 0x04000A6A RID: 2666
		private readonly int PatVer;
	}
}
