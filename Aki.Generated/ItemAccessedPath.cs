using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E60 RID: 3680
	public struct ItemAccessedPath : IFlatbufferObject
	{
		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x00283AD0 File Offset: 0x00281CD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x00283ADD File Offset: 0x00281CDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x00283AE4 File Offset: 0x00281CE4
		public static ItemAccessedPath GetRootAsItemAccessedPath(ByteBuffer _bb)
		{
			return ItemAccessedPath.GetRootAsItemAccessedPath(_bb, default(ItemAccessedPath));
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x00283B00 File Offset: 0x00281D00
		public static ItemAccessedPath GetRootAsItemAccessedPath(ByteBuffer _bb, ItemAccessedPath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x00283B1D File Offset: 0x00281D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x00283B2C File Offset: 0x00281D2C
		public ItemAccessedPath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06008C51 RID: 35921 RVA: 0x00283B3C File Offset: 0x00281D3C
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

		// Token: 0x06008C52 RID: 35922 RVA: 0x00283B78 File Offset: 0x00281D78
		public int GiftItemGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06008C53 RID: 35923 RVA: 0x00283BB8 File Offset: 0x00281DB8
		public int GiftItemGroupLength
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

		// Token: 0x06008C54 RID: 35924 RVA: 0x00283BE3 File Offset: 0x00281DE3
		public Span<int> GetGiftItemGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x00283BF2 File Offset: 0x00281DF2
		public int[] GetGiftItemGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x00283C09 File Offset: 0x00281E09
		[NullableContext(1)]
		public int[] GiftItemGroup()
		{
			return this.GetGiftItemGroupArray();
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x00283C11 File Offset: 0x00281E11
		[NullableContext(1)]
		public IEnumerable<int> GiftItemGroupIter()
		{
			ItemAccessedPath.<GiftItemGroupIter>d__16 <GiftItemGroupIter>d__ = new ItemAccessedPath.<GiftItemGroupIter>d__16(-2);
			<GiftItemGroupIter>d__.<>3__<>4__this = this;
			return <GiftItemGroupIter>d__;
		}

		// Token: 0x040053E8 RID: 21480
		private Table __p;
	}
}
