using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC7 RID: 4039
	public struct RhythmTask : IFlatbufferObject
	{
		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0600BCFB RID: 48379 RVA: 0x002E0498 File Offset: 0x002DE698
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x002E04A5 File Offset: 0x002DE6A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x002E04AC File Offset: 0x002DE6AC
		public static RhythmTask GetRootAsRhythmTask(ByteBuffer _bb)
		{
			return RhythmTask.GetRootAsRhythmTask(_bb, default(RhythmTask));
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x002E04C8 File Offset: 0x002DE6C8
		public static RhythmTask GetRootAsRhythmTask(ByteBuffer _bb, RhythmTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x002E04E5 File Offset: 0x002DE6E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x002E04F4 File Offset: 0x002DE6F4
		public RhythmTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600BD01 RID: 48385 RVA: 0x002E0504 File Offset: 0x002DE704
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

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600BD02 RID: 48386 RVA: 0x002E0540 File Offset: 0x002DE740
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

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600BD03 RID: 48387 RVA: 0x002E057C File Offset: 0x002DE77C
		public int TaskType
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

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x0600BD04 RID: 48388 RVA: 0x002E05B8 File Offset: 0x002DE7B8
		public int TaskTab
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

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0600BD05 RID: 48389 RVA: 0x002E05F8 File Offset: 0x002DE7F8
		public int SortId
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

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0600BD06 RID: 48390 RVA: 0x002E0638 File Offset: 0x002DE838
		public string TaskName
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

		// Token: 0x0600BD07 RID: 48391 RVA: 0x002E0670 File Offset: 0x002DE870
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x002E0680 File Offset: 0x002DE880
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600BD09 RID: 48393 RVA: 0x002E0698 File Offset: 0x002DE898
		public int DropId
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

		// Token: 0x040050A2 RID: 20642
		private Table __p;
	}
}
