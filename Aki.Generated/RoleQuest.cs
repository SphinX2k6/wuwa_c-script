using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001140 RID: 4416
	public struct RoleQuest : IFlatbufferObject
	{
		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600D038 RID: 53304 RVA: 0x0031962C File Offset: 0x0031782C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D039 RID: 53305 RVA: 0x00319639 File Offset: 0x00317839
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D03A RID: 53306 RVA: 0x00319640 File Offset: 0x00317840
		public static RoleQuest GetRootAsRoleQuest(ByteBuffer _bb)
		{
			return RoleQuest.GetRootAsRoleQuest(_bb, default(RoleQuest));
		}

		// Token: 0x0600D03B RID: 53307 RVA: 0x0031965C File Offset: 0x0031785C
		public static RoleQuest GetRootAsRoleQuest(ByteBuffer _bb, RoleQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D03C RID: 53308 RVA: 0x00319679 File Offset: 0x00317879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D03D RID: 53309 RVA: 0x00319688 File Offset: 0x00317888
		public RoleQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600D03E RID: 53310 RVA: 0x00319698 File Offset: 0x00317898
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

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600D03F RID: 53311 RVA: 0x003196D4 File Offset: 0x003178D4
		public int RoleId
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

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600D040 RID: 53312 RVA: 0x00319710 File Offset: 0x00317910
		public string Region
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

		// Token: 0x0600D041 RID: 53313 RVA: 0x00319747 File Offset: 0x00317947
		public Span<byte> GetRegionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D042 RID: 53314 RVA: 0x00319756 File Offset: 0x00317956
		public byte[] GetRegionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600D043 RID: 53315 RVA: 0x00319770 File Offset: 0x00317970
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600D044 RID: 53316 RVA: 0x003197B0 File Offset: 0x003179B0
		public int QuestId
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

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600D045 RID: 53317 RVA: 0x003197F0 File Offset: 0x003179F0
		public string QuestName
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

		// Token: 0x0600D046 RID: 53318 RVA: 0x00319828 File Offset: 0x00317A28
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D047 RID: 53319 RVA: 0x00319838 File Offset: 0x00317A38
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600D048 RID: 53320 RVA: 0x00319850 File Offset: 0x00317A50
		public string Chapter
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

		// Token: 0x0600D049 RID: 53321 RVA: 0x00319888 File Offset: 0x00317A88
		public Span<byte> GetChapterBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D04A RID: 53322 RVA: 0x00319898 File Offset: 0x00317A98
		public byte[] GetChapterArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600D04B RID: 53323 RVA: 0x003198B0 File Offset: 0x00317AB0
		public int Consume
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

		// Token: 0x04005742 RID: 22338
		private Table __p;
	}
}
