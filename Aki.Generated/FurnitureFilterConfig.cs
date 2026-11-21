using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBD RID: 3517
	public struct FurnitureFilterConfig : IFlatbufferObject
	{
		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06007DC0 RID: 32192 RVA: 0x00263B94 File Offset: 0x00261D94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x00263BA1 File Offset: 0x00261DA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x00263BA8 File Offset: 0x00261DA8
		public static FurnitureFilterConfig GetRootAsFurnitureFilterConfig(ByteBuffer _bb)
		{
			return FurnitureFilterConfig.GetRootAsFurnitureFilterConfig(_bb, default(FurnitureFilterConfig));
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x00263BC4 File Offset: 0x00261DC4
		public static FurnitureFilterConfig GetRootAsFurnitureFilterConfig(ByteBuffer _bb, FurnitureFilterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DC4 RID: 32196 RVA: 0x00263BE1 File Offset: 0x00261DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DC5 RID: 32197 RVA: 0x00263BF0 File Offset: 0x00261DF0
		public FurnitureFilterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x00263C00 File Offset: 0x00261E00
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

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06007DC7 RID: 32199 RVA: 0x00263C3C File Offset: 0x00261E3C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x00263C73 File Offset: 0x00261E73
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x00263C82 File Offset: 0x00261E82
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x00263C9C File Offset: 0x00261E9C
		public int TagList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06007DCB RID: 32203 RVA: 0x00263CDC File Offset: 0x00261EDC
		public int TagListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x00263D07 File Offset: 0x00261F07
		public Span<int> GetTagListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x00263D16 File Offset: 0x00261F16
		public int[] GetTagListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007DCE RID: 32206 RVA: 0x00263D2D File Offset: 0x00261F2D
		[NullableContext(1)]
		public int[] TagList()
		{
			return this.GetTagListArray();
		}

		// Token: 0x06007DCF RID: 32207 RVA: 0x00263D35 File Offset: 0x00261F35
		[NullableContext(1)]
		public IEnumerable<int> TagListIter()
		{
			FurnitureFilterConfig.<TagListIter>d__20 <TagListIter>d__ = new FurnitureFilterConfig.<TagListIter>d__20(-2);
			<TagListIter>d__.<>3__<>4__this = this;
			return <TagListIter>d__;
		}

		// Token: 0x0400532D RID: 21293
		private Table __p;
	}
}
