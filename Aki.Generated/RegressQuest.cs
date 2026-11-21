using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001099 RID: 4249
	public struct RegressQuest : IFlatbufferObject
	{
		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x0600C161 RID: 49505 RVA: 0x002F8A78 File Offset: 0x002F6C78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C162 RID: 49506 RVA: 0x002F8A85 File Offset: 0x002F6C85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x002F8A8C File Offset: 0x002F6C8C
		public static RegressQuest GetRootAsRegressQuest(ByteBuffer _bb)
		{
			return RegressQuest.GetRootAsRegressQuest(_bb, default(RegressQuest));
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x002F8AA8 File Offset: 0x002F6CA8
		public static RegressQuest GetRootAsRegressQuest(ByteBuffer _bb, RegressQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x002F8AC5 File Offset: 0x002F6CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C166 RID: 49510 RVA: 0x002F8AD4 File Offset: 0x002F6CD4
		public RegressQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0600C167 RID: 49511 RVA: 0x002F8AE4 File Offset: 0x002F6CE4
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

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x0600C168 RID: 49512 RVA: 0x002F8B20 File Offset: 0x002F6D20
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0600C169 RID: 49513 RVA: 0x002F8B5C File Offset: 0x002F6D5C
		public string TargetName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C16A RID: 49514 RVA: 0x002F8B93 File Offset: 0x002F6D93
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C16B RID: 49515 RVA: 0x002F8BA2 File Offset: 0x002F6DA2
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0600C16C RID: 49516 RVA: 0x002F8BBC File Offset: 0x002F6DBC
		public int TaskSubType
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

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0600C16D RID: 49517 RVA: 0x002F8BFC File Offset: 0x002F6DFC
		public int AccessPathId
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

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600C16E RID: 49518 RVA: 0x002F8C3C File Offset: 0x002F6E3C
		public int TargetReward
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0600C16F RID: 49519 RVA: 0x002F8C7C File Offset: 0x002F6E7C
		public int ProgressType
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

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600C170 RID: 49520 RVA: 0x002F8CBC File Offset: 0x002F6EBC
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600C171 RID: 49521 RVA: 0x002F8CFC File Offset: 0x002F6EFC
		public int Version
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

		// Token: 0x04005672 RID: 22130
		private Table __p;
	}
}
