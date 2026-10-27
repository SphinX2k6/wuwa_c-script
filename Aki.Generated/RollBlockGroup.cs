using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001069 RID: 4201
	public struct RollBlockGroup : IFlatbufferObject
	{
		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600CBE8 RID: 52200 RVA: 0x00301CF1 File Offset: 0x002FFEF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBE9 RID: 52201 RVA: 0x00301CFE File Offset: 0x002FFEFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x00301D08 File Offset: 0x002FFF08
		public static RollBlockGroup GetRootAsRollBlockGroup(ByteBuffer _bb)
		{
			return RollBlockGroup.GetRootAsRollBlockGroup(_bb, default(RollBlockGroup));
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x00301D24 File Offset: 0x002FFF24
		public static RollBlockGroup GetRootAsRollBlockGroup(ByteBuffer _bb, RollBlockGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x00301D41 File Offset: 0x002FFF41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBED RID: 52205 RVA: 0x00301D50 File Offset: 0x002FFF50
		public RollBlockGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600CBEE RID: 52206 RVA: 0x00301D60 File Offset: 0x002FFF60
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

		// Token: 0x0600CBEF RID: 52207 RVA: 0x00301D9C File Offset: 0x002FFF9C
		public int Grids(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600CBF0 RID: 52208 RVA: 0x00301DDC File Offset: 0x002FFFDC
		public int GridsLength
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

		// Token: 0x0600CBF1 RID: 52209 RVA: 0x00301E07 File Offset: 0x00300007
		public Span<int> GetGridsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CBF2 RID: 52210 RVA: 0x00301E16 File Offset: 0x00300016
		public int[] GetGridsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600CBF3 RID: 52211 RVA: 0x00301E30 File Offset: 0x00300030
		public string Description
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CBF4 RID: 52212 RVA: 0x00301E67 File Offset: 0x00300067
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CBF5 RID: 52213 RVA: 0x00301E76 File Offset: 0x00300076
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x00301E90 File Offset: 0x00300090
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GridsIter()或GetGridsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Grids()
		{
			RollBlockGroup rollBlockGroup = this;
			return rollBlockGroup.GetGridsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x00301EB4 File Offset: 0x003000B4
		[NullableContext(1)]
		public readonly IEnumerable<int> GridsIter()
		{
			RollBlockGroup.<GridsIter>d__20 <GridsIter>d__ = new RollBlockGroup.<GridsIter>d__20(-2);
			<GridsIter>d__.<>3__<>4__this = this;
			return <GridsIter>d__;
		}

		// Token: 0x0400516E RID: 20846
		private Table __p;
	}
}
