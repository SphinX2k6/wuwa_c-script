using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F28 RID: 3880
	public struct MotorFightCondition : IFlatbufferObject
	{
		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06009E5E RID: 40542 RVA: 0x002AC5A1 File Offset: 0x002AA7A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x002AC5AE File Offset: 0x002AA7AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x002AC5B8 File Offset: 0x002AA7B8
		public static MotorFightCondition GetRootAsMotorFightCondition(ByteBuffer _bb)
		{
			return MotorFightCondition.GetRootAsMotorFightCondition(_bb, default(MotorFightCondition));
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x002AC5D4 File Offset: 0x002AA7D4
		public static MotorFightCondition GetRootAsMotorFightCondition(ByteBuffer _bb, MotorFightCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x002AC5F1 File Offset: 0x002AA7F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x002AC600 File Offset: 0x002AA800
		public MotorFightCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06009E64 RID: 40548 RVA: 0x002AC610 File Offset: 0x002AA810
		public int ConditionId
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

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06009E65 RID: 40549 RVA: 0x002AC64C File Offset: 0x002AA84C
		public int ConditionType
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

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06009E66 RID: 40550 RVA: 0x002AC688 File Offset: 0x002AA888
		public int CompareType
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

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06009E67 RID: 40551 RVA: 0x002AC6C4 File Offset: 0x002AA8C4
		public int ConditionParam
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

		// Token: 0x040054D0 RID: 21712
		private Table __p;
	}
}
