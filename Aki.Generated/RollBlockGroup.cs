using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001164 RID: 4452
	public struct RollBlockGroup : IFlatbufferObject
	{
		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600D3BB RID: 54203 RVA: 0x003215A9 File Offset: 0x0031F7A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3BC RID: 54204 RVA: 0x003215B6 File Offset: 0x0031F7B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3BD RID: 54205 RVA: 0x003215C0 File Offset: 0x0031F7C0
		public static RollBlockGroup GetRootAsRollBlockGroup(ByteBuffer _bb)
		{
			return RollBlockGroup.GetRootAsRollBlockGroup(_bb, default(RollBlockGroup));
		}

		// Token: 0x0600D3BE RID: 54206 RVA: 0x003215DC File Offset: 0x0031F7DC
		public static RollBlockGroup GetRootAsRollBlockGroup(ByteBuffer _bb, RollBlockGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3BF RID: 54207 RVA: 0x003215F9 File Offset: 0x0031F7F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3C0 RID: 54208 RVA: 0x00321608 File Offset: 0x0031F808
		public RollBlockGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600D3C1 RID: 54209 RVA: 0x00321618 File Offset: 0x0031F818
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

		// Token: 0x0600D3C2 RID: 54210 RVA: 0x00321654 File Offset: 0x0031F854
		public int Grids(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600D3C3 RID: 54211 RVA: 0x00321694 File Offset: 0x0031F894
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

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x003216BF File Offset: 0x0031F8BF
		public Span<int> GetGridsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x003216CE File Offset: 0x0031F8CE
		public int[] GetGridsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600D3C6 RID: 54214 RVA: 0x003216E8 File Offset: 0x0031F8E8
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

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x0032171F File Offset: 0x0031F91F
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D3C8 RID: 54216 RVA: 0x0032172E File Offset: 0x0031F92E
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D3C9 RID: 54217 RVA: 0x00321745 File Offset: 0x0031F945
		[NullableContext(1)]
		public int[] Grids()
		{
			return this.GetGridsArray();
		}

		// Token: 0x0600D3CA RID: 54218 RVA: 0x0032174D File Offset: 0x0031F94D
		[NullableContext(1)]
		public IEnumerable<int> GridsIter()
		{
			RollBlockGroup.<GridsIter>d__20 <GridsIter>d__ = new RollBlockGroup.<GridsIter>d__20(-2);
			<GridsIter>d__.<>3__<>4__this = this;
			return <GridsIter>d__;
		}

		// Token: 0x0400576D RID: 22381
		private Table __p;
	}
}
