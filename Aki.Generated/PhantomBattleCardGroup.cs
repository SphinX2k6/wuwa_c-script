using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC4 RID: 3780
	public struct PhantomBattleCardGroup : IFlatbufferObject
	{
		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x0600A5B5 RID: 42421 RVA: 0x002ACB3D File Offset: 0x002AAD3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x002ACB4A File Offset: 0x002AAD4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x002ACB54 File Offset: 0x002AAD54
		public static PhantomBattleCardGroup GetRootAsPhantomBattleCardGroup(ByteBuffer _bb)
		{
			return PhantomBattleCardGroup.GetRootAsPhantomBattleCardGroup(_bb, default(PhantomBattleCardGroup));
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x002ACB70 File Offset: 0x002AAD70
		public static PhantomBattleCardGroup GetRootAsPhantomBattleCardGroup(ByteBuffer _bb, PhantomBattleCardGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x002ACB8D File Offset: 0x002AAD8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x002ACB9C File Offset: 0x002AAD9C
		public PhantomBattleCardGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x0600A5BB RID: 42427 RVA: 0x002ACBAC File Offset: 0x002AADAC
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

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x0600A5BC RID: 42428 RVA: 0x002ACBE8 File Offset: 0x002AADE8
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x0600A5BD RID: 42429 RVA: 0x002ACC24 File Offset: 0x002AAE24
		public int CardId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x0600A5BE RID: 42430 RVA: 0x002ACC60 File Offset: 0x002AAE60
		public int Num
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x0600A5BF RID: 42431 RVA: 0x002ACCA0 File Offset: 0x002AAEA0
		public bool IsCore
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004F80 RID: 20352
		private Table __p;
	}
}
