using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB2 RID: 4018
	public struct PhantomBattleCountType : IFlatbufferObject
	{
		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x0600AD03 RID: 44291 RVA: 0x002CC8F5 File Offset: 0x002CAAF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x002CC902 File Offset: 0x002CAB02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x002CC90C File Offset: 0x002CAB0C
		public static PhantomBattleCountType GetRootAsPhantomBattleCountType(ByteBuffer _bb)
		{
			return PhantomBattleCountType.GetRootAsPhantomBattleCountType(_bb, default(PhantomBattleCountType));
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x002CC928 File Offset: 0x002CAB28
		public static PhantomBattleCountType GetRootAsPhantomBattleCountType(ByteBuffer _bb, PhantomBattleCountType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x002CC945 File Offset: 0x002CAB45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x002CC954 File Offset: 0x002CAB54
		public PhantomBattleCountType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x0600AD09 RID: 44297 RVA: 0x002CC964 File Offset: 0x002CAB64
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

		// Token: 0x04005570 RID: 21872
		private Table __p;
	}
}
