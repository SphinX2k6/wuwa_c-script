using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E43 RID: 3651
	public struct MotorFightCondition : IFlatbufferObject
	{
		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x0600983E RID: 38974 RVA: 0x0028E979 File Offset: 0x0028CB79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600983F RID: 38975 RVA: 0x0028E986 File Offset: 0x0028CB86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009840 RID: 38976 RVA: 0x0028E990 File Offset: 0x0028CB90
		public static MotorFightCondition GetRootAsMotorFightCondition(ByteBuffer _bb)
		{
			return MotorFightCondition.GetRootAsMotorFightCondition(_bb, default(MotorFightCondition));
		}

		// Token: 0x06009841 RID: 38977 RVA: 0x0028E9AC File Offset: 0x0028CBAC
		public static MotorFightCondition GetRootAsMotorFightCondition(ByteBuffer _bb, MotorFightCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009842 RID: 38978 RVA: 0x0028E9C9 File Offset: 0x0028CBC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x0028E9D8 File Offset: 0x0028CBD8
		public MotorFightCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06009844 RID: 38980 RVA: 0x0028E9E8 File Offset: 0x0028CBE8
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

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06009845 RID: 38981 RVA: 0x0028EA24 File Offset: 0x0028CC24
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

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06009846 RID: 38982 RVA: 0x0028EA60 File Offset: 0x0028CC60
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

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06009847 RID: 38983 RVA: 0x0028EA9C File Offset: 0x0028CC9C
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

		// Token: 0x04004EEB RID: 20203
		private Table __p;
	}
}
