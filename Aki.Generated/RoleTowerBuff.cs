using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200114B RID: 4427
	public struct RoleTowerBuff : IFlatbufferObject
	{
		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600D1DF RID: 53727 RVA: 0x0031D54C File Offset: 0x0031B74C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x0031D559 File Offset: 0x0031B759
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x0031D560 File Offset: 0x0031B760
		public static RoleTowerBuff GetRootAsRoleTowerBuff(ByteBuffer _bb)
		{
			return RoleTowerBuff.GetRootAsRoleTowerBuff(_bb, default(RoleTowerBuff));
		}

		// Token: 0x0600D1E2 RID: 53730 RVA: 0x0031D57C File Offset: 0x0031B77C
		public static RoleTowerBuff GetRootAsRoleTowerBuff(ByteBuffer _bb, RoleTowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x0031D599 File Offset: 0x0031B799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x0031D5A8 File Offset: 0x0031B7A8
		public RoleTowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600D1E5 RID: 53733 RVA: 0x0031D5B8 File Offset: 0x0031B7B8
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

		// Token: 0x04005750 RID: 22352
		private Table __p;
	}
}
