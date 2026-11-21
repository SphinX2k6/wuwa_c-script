using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E5 RID: 1509
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct OSPlatform : IEquatable<OSPlatform>
	{
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06007148 RID: 29000 RVA: 0x0010FB6A File Offset: 0x0010DD6A
		public static OSPlatform FreeBSD { get; } = new OSPlatform("FREEBSD");

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06007149 RID: 29001 RVA: 0x0010FB71 File Offset: 0x0010DD71
		public static OSPlatform Linux { get; } = new OSPlatform("LINUX");

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x0600714A RID: 29002 RVA: 0x0010FB78 File Offset: 0x0010DD78
		public static OSPlatform OSX { get; } = new OSPlatform("OSX");

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x0600714B RID: 29003 RVA: 0x0010FB7F File Offset: 0x0010DD7F
		public static OSPlatform Windows { get; } = new OSPlatform("WINDOWS");

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x0600714C RID: 29004 RVA: 0x0010FB86 File Offset: 0x0010DD86
		internal string Name { get; }

		// Token: 0x0600714D RID: 29005 RVA: 0x0010FB8E File Offset: 0x0010DD8E
		private OSPlatform(string osPlatform)
		{
			ArgumentException.ThrowIfNullOrEmpty(osPlatform, "osPlatform");
			this.Name = osPlatform;
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x0010FBA2 File Offset: 0x0010DDA2
		public static OSPlatform Create(string osPlatform)
		{
			return new OSPlatform(osPlatform);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x0010FBAA File Offset: 0x0010DDAA
		public bool Equals(OSPlatform other)
		{
			return this.Equals(other.Name);
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x0010FBB9 File Offset: 0x0010DDB9
		internal bool Equals(string other)
		{
			return string.Equals(this.Name, other, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x0010FBC8 File Offset: 0x0010DDC8
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is OSPlatform)
			{
				OSPlatform other = (OSPlatform)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x0010FBED File Offset: 0x0010DDED
		public override int GetHashCode()
		{
			if (this.Name != null)
			{
				return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Name);
			}
			return 0;
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x0010FC09 File Offset: 0x0010DE09
		public override string ToString()
		{
			return this.Name ?? string.Empty;
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x0010FC1A File Offset: 0x0010DE1A
		public static bool operator ==(OSPlatform left, OSPlatform right)
		{
			return left.Equals(right);
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x0010FC24 File Offset: 0x0010DE24
		public static bool operator !=(OSPlatform left, OSPlatform right)
		{
			return !(left == right);
		}
	}
}
