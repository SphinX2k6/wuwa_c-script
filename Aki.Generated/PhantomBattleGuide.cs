using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB7 RID: 4023
	public struct PhantomBattleGuide : IFlatbufferObject
	{
		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600AD5C RID: 44380 RVA: 0x002CD3CE File Offset: 0x002CB5CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD5D RID: 44381 RVA: 0x002CD3DB File Offset: 0x002CB5DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x002CD3E4 File Offset: 0x002CB5E4
		public static PhantomBattleGuide GetRootAsPhantomBattleGuide(ByteBuffer _bb)
		{
			return PhantomBattleGuide.GetRootAsPhantomBattleGuide(_bb, default(PhantomBattleGuide));
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x002CD400 File Offset: 0x002CB600
		public static PhantomBattleGuide GetRootAsPhantomBattleGuide(ByteBuffer _bb, PhantomBattleGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x002CD41D File Offset: 0x002CB61D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x002CD42C File Offset: 0x002CB62C
		public PhantomBattleGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600AD62 RID: 44386 RVA: 0x002CD43C File Offset: 0x002CB63C
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

		// Token: 0x04005575 RID: 21877
		private Table __p;
	}
}
