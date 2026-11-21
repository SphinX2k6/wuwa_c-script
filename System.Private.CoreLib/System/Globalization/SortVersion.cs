using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x0200030C RID: 780
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class SortVersion : IEquatable<SortVersion>
	{
		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x000BC7B6 File Offset: 0x000BA9B6
		public int FullVersion
		{
			get
			{
				return this.m_NlsVersion;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x000BC7BE File Offset: 0x000BA9BE
		public Guid SortId
		{
			get
			{
				return this.m_SortId;
			}
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x000BC7C6 File Offset: 0x000BA9C6
		public SortVersion(int fullVersion, Guid sortId)
		{
			this.m_SortId = sortId;
			this.m_NlsVersion = fullVersion;
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x000BC7DC File Offset: 0x000BA9DC
		internal SortVersion(int nlsVersion, int effectiveId, Guid customVersion)
		{
			this.m_NlsVersion = nlsVersion;
			if (customVersion == Guid.Empty)
			{
				byte h = (byte)(effectiveId >> 24);
				byte i = (byte)((effectiveId & 16711680) >> 16);
				byte j = (byte)((effectiveId & 65280) >> 8);
				byte k = (byte)(effectiveId & 255);
				customVersion = new Guid(0, 0, 0, 0, 0, 0, 0, h, i, j, k);
			}
			this.m_SortId = customVersion;
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x000BC844 File Offset: 0x000BAA44
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			SortVersion sortVersion = obj as SortVersion;
			return sortVersion != null && this.Equals(sortVersion);
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x000BC864 File Offset: 0x000BAA64
		public bool Equals([NotNullWhen(true)] SortVersion other)
		{
			return !(other == null) && this.m_NlsVersion == other.m_NlsVersion && this.m_SortId == other.m_SortId;
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x000BC892 File Offset: 0x000BAA92
		public override int GetHashCode()
		{
			return this.m_NlsVersion * 7 | this.m_SortId.GetHashCode();
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x000BC8AE File Offset: 0x000BAAAE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(SortVersion left, SortVersion right)
		{
			if (right == null)
			{
				return left == null;
			}
			return right.Equals(left);
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x000BC8BF File Offset: 0x000BAABF
		public static bool operator !=(SortVersion left, SortVersion right)
		{
			return !(left == right);
		}

		// Token: 0x04000B4A RID: 2890
		private readonly int m_NlsVersion;

		// Token: 0x04000B4B RID: 2891
		private readonly Guid m_SortId;
	}
}
