using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E88 RID: 3720
	public struct NewPlayerSupportTask : IFlatbufferObject
	{
		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x06009EDC RID: 40668 RVA: 0x0029D1B1 File Offset: 0x0029B3B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x0029D1BE File Offset: 0x0029B3BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x0029D1C8 File Offset: 0x0029B3C8
		public static NewPlayerSupportTask GetRootAsNewPlayerSupportTask(ByteBuffer _bb)
		{
			return NewPlayerSupportTask.GetRootAsNewPlayerSupportTask(_bb, default(NewPlayerSupportTask));
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x0029D1E4 File Offset: 0x0029B3E4
		public static NewPlayerSupportTask GetRootAsNewPlayerSupportTask(ByteBuffer _bb, NewPlayerSupportTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x0029D201 File Offset: 0x0029B401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x0029D210 File Offset: 0x0029B410
		public NewPlayerSupportTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06009EE2 RID: 40674 RVA: 0x0029D220 File Offset: 0x0029B420
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

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x0029D25C File Offset: 0x0029B45C
		public int ActivityId
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

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x06009EE4 RID: 40676 RVA: 0x0029D298 File Offset: 0x0029B498
		public int Index
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

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06009EE5 RID: 40677 RVA: 0x0029D2D4 File Offset: 0x0029B4D4
		public int ConditionGroup
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

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x06009EE6 RID: 40678 RVA: 0x0029D314 File Offset: 0x0029B514
		public int NormalDropId
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

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x0029D354 File Offset: 0x0029B554
		public int TrialRoleGroupId
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

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x06009EE8 RID: 40680 RVA: 0x0029D394 File Offset: 0x0029B594
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009EE9 RID: 40681 RVA: 0x0029D3CC File Offset: 0x0029B5CC
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009EEA RID: 40682 RVA: 0x0029D3DC File Offset: 0x0029B5DC
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F36 RID: 20278
		private Table __p;
	}
}
