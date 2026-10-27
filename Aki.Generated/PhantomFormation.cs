using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE8 RID: 3816
	public struct PhantomFormation : IFlatbufferObject
	{
		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x0600A8B0 RID: 43184 RVA: 0x002B3674 File Offset: 0x002B1874
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x002B3681 File Offset: 0x002B1881
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x002B3688 File Offset: 0x002B1888
		public static PhantomFormation GetRootAsPhantomFormation(ByteBuffer _bb)
		{
			return PhantomFormation.GetRootAsPhantomFormation(_bb, default(PhantomFormation));
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x002B36A4 File Offset: 0x002B18A4
		public static PhantomFormation GetRootAsPhantomFormation(ByteBuffer _bb, PhantomFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x002B36C1 File Offset: 0x002B18C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A8B5 RID: 43189 RVA: 0x002B36D0 File Offset: 0x002B18D0
		public PhantomFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x0600A8B6 RID: 43190 RVA: 0x002B36E0 File Offset: 0x002B18E0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x002B371C File Offset: 0x002B191C
		public int Roles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x0600A8B8 RID: 43192 RVA: 0x002B375C File Offset: 0x002B195C
		public int RolesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x002B3787 File Offset: 0x002B1987
		public Span<int> GetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A8BA RID: 43194 RVA: 0x002B3796 File Offset: 0x002B1996
		public int[] GetRolesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x002B37B0 File Offset: 0x002B19B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RolesIter()或GetRolesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Roles()
		{
			PhantomFormation phantomFormation = this;
			return phantomFormation.GetRolesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x002B37D4 File Offset: 0x002B19D4
		[NullableContext(1)]
		public readonly IEnumerable<int> RolesIter()
		{
			PhantomFormation.<RolesIter>d__16 <RolesIter>d__ = new PhantomFormation.<RolesIter>d__16(-2);
			<RolesIter>d__.<>3__<>4__this = this;
			return <RolesIter>d__;
		}

		// Token: 0x04004FAA RID: 20394
		private Table __p;
	}
}
