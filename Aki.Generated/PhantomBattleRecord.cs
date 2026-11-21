using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBE RID: 4030
	public struct PhantomBattleRecord : IFlatbufferObject
	{
		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x0600ADD7 RID: 44503 RVA: 0x002CE421 File Offset: 0x002CC621
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADD8 RID: 44504 RVA: 0x002CE42E File Offset: 0x002CC62E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADD9 RID: 44505 RVA: 0x002CE438 File Offset: 0x002CC638
		public static PhantomBattleRecord GetRootAsPhantomBattleRecord(ByteBuffer _bb)
		{
			return PhantomBattleRecord.GetRootAsPhantomBattleRecord(_bb, default(PhantomBattleRecord));
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x002CE454 File Offset: 0x002CC654
		public static PhantomBattleRecord GetRootAsPhantomBattleRecord(ByteBuffer _bb, PhantomBattleRecord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x002CE471 File Offset: 0x002CC671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADDC RID: 44508 RVA: 0x002CE480 File Offset: 0x002CC680
		public PhantomBattleRecord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x0600ADDD RID: 44509 RVA: 0x002CE490 File Offset: 0x002CC690
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

		// Token: 0x0400557C RID: 21884
		private Table __p;
	}
}
