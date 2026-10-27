using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E39 RID: 3641
	public struct MotorEffectInst : IFlatbufferObject
	{
		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x060097A5 RID: 38821 RVA: 0x0028D1BD File Offset: 0x0028B3BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x0028D1CA File Offset: 0x0028B3CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x0028D1D4 File Offset: 0x0028B3D4
		public static MotorEffectInst GetRootAsMotorEffectInst(ByteBuffer _bb)
		{
			return MotorEffectInst.GetRootAsMotorEffectInst(_bb, default(MotorEffectInst));
		}

		// Token: 0x060097A8 RID: 38824 RVA: 0x0028D1F0 File Offset: 0x0028B3F0
		public static MotorEffectInst GetRootAsMotorEffectInst(ByteBuffer _bb, MotorEffectInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097A9 RID: 38825 RVA: 0x0028D20D File Offset: 0x0028B40D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x0028D21C File Offset: 0x0028B41C
		public MotorEffectInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x060097AB RID: 38827 RVA: 0x0028D22C File Offset: 0x0028B42C
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

		// Token: 0x04004EE1 RID: 20193
		private Table __p;
	}
}
