using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F27 RID: 3879
	public struct MotorFightCollection : IFlatbufferObject
	{
		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06009E53 RID: 40531 RVA: 0x002AC401 File Offset: 0x002AA601
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x002AC40E File Offset: 0x002AA60E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x002AC418 File Offset: 0x002AA618
		public static MotorFightCollection GetRootAsMotorFightCollection(ByteBuffer _bb)
		{
			return MotorFightCollection.GetRootAsMotorFightCollection(_bb, default(MotorFightCollection));
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x002AC434 File Offset: 0x002AA634
		public static MotorFightCollection GetRootAsMotorFightCollection(ByteBuffer _bb, MotorFightCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E57 RID: 40535 RVA: 0x002AC451 File Offset: 0x002AA651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x002AC460 File Offset: 0x002AA660
		public MotorFightCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06009E59 RID: 40537 RVA: 0x002AC470 File Offset: 0x002AA670
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

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06009E5A RID: 40538 RVA: 0x002AC4AC File Offset: 0x002AA6AC
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

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06009E5B RID: 40539 RVA: 0x002AC4E8 File Offset: 0x002AA6E8
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

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06009E5C RID: 40540 RVA: 0x002AC524 File Offset: 0x002AA724
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

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06009E5D RID: 40541 RVA: 0x002AC564 File Offset: 0x002AA764
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

		// Token: 0x040054CF RID: 21711
		private Table __p;
	}
}
