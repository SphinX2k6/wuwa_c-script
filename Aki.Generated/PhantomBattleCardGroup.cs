using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA9 RID: 4009
	public struct PhantomBattleCardGroup : IFlatbufferObject
	{
		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x0600ABD6 RID: 43990 RVA: 0x002C9D12 File Offset: 0x002C7F12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x002C9D1F File Offset: 0x002C7F1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x002C9D28 File Offset: 0x002C7F28
		public static PhantomBattleCardGroup GetRootAsPhantomBattleCardGroup(ByteBuffer _bb)
		{
			return PhantomBattleCardGroup.GetRootAsPhantomBattleCardGroup(_bb, default(PhantomBattleCardGroup));
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x002C9D44 File Offset: 0x002C7F44
		public static PhantomBattleCardGroup GetRootAsPhantomBattleCardGroup(ByteBuffer _bb, PhantomBattleCardGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x002C9D61 File Offset: 0x002C7F61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x002C9D70 File Offset: 0x002C7F70
		public PhantomBattleCardGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x002C9D80 File Offset: 0x002C7F80
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

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x0600ABDD RID: 43997 RVA: 0x002C9DBC File Offset: 0x002C7FBC
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

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x0600ABDE RID: 43998 RVA: 0x002C9DF8 File Offset: 0x002C7FF8
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

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x0600ABDF RID: 43999 RVA: 0x002C9E34 File Offset: 0x002C8034
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

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x0600ABE0 RID: 44000 RVA: 0x002C9E74 File Offset: 0x002C8074
		public bool IsCore
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005565 RID: 21861
		private Table __p;
	}
}
