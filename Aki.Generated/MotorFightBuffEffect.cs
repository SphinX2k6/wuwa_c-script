using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F24 RID: 3876
	public struct MotorFightBuffEffect : IFlatbufferObject
	{
		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06009E1C RID: 40476 RVA: 0x002ABC71 File Offset: 0x002A9E71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E1D RID: 40477 RVA: 0x002ABC7E File Offset: 0x002A9E7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E1E RID: 40478 RVA: 0x002ABC88 File Offset: 0x002A9E88
		public static MotorFightBuffEffect GetRootAsMotorFightBuffEffect(ByteBuffer _bb)
		{
			return MotorFightBuffEffect.GetRootAsMotorFightBuffEffect(_bb, default(MotorFightBuffEffect));
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x002ABCA4 File Offset: 0x002A9EA4
		public static MotorFightBuffEffect GetRootAsMotorFightBuffEffect(ByteBuffer _bb, MotorFightBuffEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E20 RID: 40480 RVA: 0x002ABCC1 File Offset: 0x002A9EC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E21 RID: 40481 RVA: 0x002ABCD0 File Offset: 0x002A9ED0
		public MotorFightBuffEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06009E22 RID: 40482 RVA: 0x002ABCE0 File Offset: 0x002A9EE0
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

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06009E23 RID: 40483 RVA: 0x002ABD1C File Offset: 0x002A9F1C
		public int BuffId
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

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06009E24 RID: 40484 RVA: 0x002ABD58 File Offset: 0x002A9F58
		public int DurationType
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

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06009E25 RID: 40485 RVA: 0x002ABD94 File Offset: 0x002A9F94
		public int Param1
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

		// Token: 0x040054CC RID: 21708
		private Table __p;
	}
}
