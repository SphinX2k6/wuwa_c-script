using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA6 RID: 2982
	public struct CoopTaskConfig : IFlatbufferObject
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06005A15 RID: 23061 RVA: 0x0020131D File Offset: 0x001FF51D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0020132A File Offset: 0x001FF52A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00201334 File Offset: 0x001FF534
		public static CoopTaskConfig GetRootAsCoopTaskConfig(ByteBuffer _bb)
		{
			return CoopTaskConfig.GetRootAsCoopTaskConfig(_bb, default(CoopTaskConfig));
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00201350 File Offset: 0x001FF550
		public static CoopTaskConfig GetRootAsCoopTaskConfig(ByteBuffer _bb, CoopTaskConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x0020136D File Offset: 0x001FF56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x0020137C File Offset: 0x001FF57C
		public CoopTaskConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06005A1B RID: 23067 RVA: 0x0020138C File Offset: 0x001FF58C
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06005A1C RID: 23068 RVA: 0x002013C8 File Offset: 0x001FF5C8
		public int CoopRoleId
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

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06005A1D RID: 23069 RVA: 0x00201404 File Offset: 0x001FF604
		public int CoopLevelId
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x00201440 File Offset: 0x001FF640
		public int CoopPreQuest
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06005A1F RID: 23071 RVA: 0x00201480 File Offset: 0x001FF680
		public int ConditionGroup
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06005A20 RID: 23072 RVA: 0x002014C0 File Offset: 0x001FF6C0
		public string TaskTitle2
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x002014F8 File Offset: 0x001FF6F8
		public Span<byte> GetTaskTitle2Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x00201508 File Offset: 0x001FF708
		public byte[] GetTaskTitle2Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x00201520 File Offset: 0x001FF720
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06005A24 RID: 23076 RVA: 0x00201560 File Offset: 0x001FF760
		public int Condition2MapId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x002015A0 File Offset: 0x001FF7A0
		public int Condition2MarkId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06005A26 RID: 23078 RVA: 0x002015E0 File Offset: 0x001FF7E0
		public int LevelId1
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06005A27 RID: 23079 RVA: 0x00201620 File Offset: 0x001FF820
		public string TaskTitle3
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00201658 File Offset: 0x001FF858
		public Span<byte> GetTaskTitle3Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00201668 File Offset: 0x001FF868
		public byte[] GetTaskTitle3Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06005A2A RID: 23082 RVA: 0x00201680 File Offset: 0x001FF880
		public int TraceMarkId3
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06005A2B RID: 23083 RVA: 0x002016C0 File Offset: 0x001FF8C0
		public int LevelId2
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06005A2C RID: 23084 RVA: 0x00201700 File Offset: 0x001FF900
		public string TaskTitle4
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x00201738 File Offset: 0x001FF938
		public Span<byte> GetTaskTitle4Bytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x00201748 File Offset: 0x001FF948
		public byte[] GetTaskTitle4Array()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x00201760 File Offset: 0x001FF960
		public int TraceMarkId4
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06005A30 RID: 23088 RVA: 0x002017A0 File Offset: 0x001FF9A0
		public int OpenTimeId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x002017E0 File Offset: 0x001FF9E0
		public string TaskTitle5
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x00201818 File Offset: 0x001FFA18
		public Span<byte> GetTaskTitle5Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x00201828 File Offset: 0x001FFA28
		public byte[] GetTaskTitle5Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BC9 RID: 19401
		private Table __p;
	}
}
