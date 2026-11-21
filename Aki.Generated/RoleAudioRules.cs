using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001120 RID: 4384
	public struct RoleAudioRules : IFlatbufferObject
	{
		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x003135B8 File Offset: 0x003117B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD81 RID: 52609 RVA: 0x003135C5 File Offset: 0x003117C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD82 RID: 52610 RVA: 0x003135CC File Offset: 0x003117CC
		public static RoleAudioRules GetRootAsRoleAudioRules(ByteBuffer _bb)
		{
			return RoleAudioRules.GetRootAsRoleAudioRules(_bb, default(RoleAudioRules));
		}

		// Token: 0x0600CD83 RID: 52611 RVA: 0x003135E8 File Offset: 0x003117E8
		public static RoleAudioRules GetRootAsRoleAudioRules(ByteBuffer _bb, RoleAudioRules obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD84 RID: 52612 RVA: 0x00313605 File Offset: 0x00311805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD85 RID: 52613 RVA: 0x00313614 File Offset: 0x00311814
		public RoleAudioRules __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600CD86 RID: 52614 RVA: 0x00313624 File Offset: 0x00311824
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

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600CD87 RID: 52615 RVA: 0x00313660 File Offset: 0x00311860
		public int TeamColdTime
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

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600CD88 RID: 52616 RVA: 0x0031369C File Offset: 0x0031189C
		public int CharacterColdTime
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

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600CD89 RID: 52617 RVA: 0x003136D8 File Offset: 0x003118D8
		public int PostProbability
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

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600CD8A RID: 52618 RVA: 0x00313718 File Offset: 0x00311918
		public int GroupID
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400571D RID: 22301
		private Table __p;
	}
}
