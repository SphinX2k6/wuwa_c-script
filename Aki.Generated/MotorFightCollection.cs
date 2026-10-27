using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E42 RID: 3650
	public struct MotorFightCollection : IFlatbufferObject
	{
		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06009833 RID: 38963 RVA: 0x0028E7D9 File Offset: 0x0028C9D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009834 RID: 38964 RVA: 0x0028E7E6 File Offset: 0x0028C9E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009835 RID: 38965 RVA: 0x0028E7F0 File Offset: 0x0028C9F0
		public static MotorFightCollection GetRootAsMotorFightCollection(ByteBuffer _bb)
		{
			return MotorFightCollection.GetRootAsMotorFightCollection(_bb, default(MotorFightCollection));
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x0028E80C File Offset: 0x0028CA0C
		public static MotorFightCollection GetRootAsMotorFightCollection(ByteBuffer _bb, MotorFightCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x0028E829 File Offset: 0x0028CA29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009838 RID: 38968 RVA: 0x0028E838 File Offset: 0x0028CA38
		public MotorFightCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06009839 RID: 38969 RVA: 0x0028E848 File Offset: 0x0028CA48
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

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600983A RID: 38970 RVA: 0x0028E884 File Offset: 0x0028CA84
		public int CollectionId
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

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600983B RID: 38971 RVA: 0x0028E8C0 File Offset: 0x0028CAC0
		public int GroupId
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

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600983C RID: 38972 RVA: 0x0028E8FC File Offset: 0x0028CAFC
		public int ConditionId
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

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600983D RID: 38973 RVA: 0x0028E93C File Offset: 0x0028CB3C
		public int Weight
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004EEA RID: 20202
		private Table __p;
	}
}
