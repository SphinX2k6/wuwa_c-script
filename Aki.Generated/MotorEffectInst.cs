using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1E RID: 3870
	public struct MotorEffectInst : IFlatbufferObject
	{
		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06009DC5 RID: 40389 RVA: 0x002AAE21 File Offset: 0x002A9021
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x002AAE2E File Offset: 0x002A902E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DC7 RID: 40391 RVA: 0x002AAE38 File Offset: 0x002A9038
		public static MotorEffectInst GetRootAsMotorEffectInst(ByteBuffer _bb)
		{
			return MotorEffectInst.GetRootAsMotorEffectInst(_bb, default(MotorEffectInst));
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x002AAE54 File Offset: 0x002A9054
		public static MotorEffectInst GetRootAsMotorEffectInst(ByteBuffer _bb, MotorEffectInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x002AAE71 File Offset: 0x002A9071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x002AAE80 File Offset: 0x002A9080
		public MotorEffectInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06009DCB RID: 40395 RVA: 0x002AAE90 File Offset: 0x002A9090
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

		// Token: 0x040054C6 RID: 21702
		private Table __p;
	}
}
