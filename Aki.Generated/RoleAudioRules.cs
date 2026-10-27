using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001038 RID: 4152
	public struct RoleAudioRules : IFlatbufferObject
	{
		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600C736 RID: 50998 RVA: 0x002F7744 File Offset: 0x002F5944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C737 RID: 50999 RVA: 0x002F7751 File Offset: 0x002F5951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C738 RID: 51000 RVA: 0x002F7758 File Offset: 0x002F5958
		public static RoleAudioRules GetRootAsRoleAudioRules(ByteBuffer _bb)
		{
			return RoleAudioRules.GetRootAsRoleAudioRules(_bb, default(RoleAudioRules));
		}

		// Token: 0x0600C739 RID: 51001 RVA: 0x002F7774 File Offset: 0x002F5974
		public static RoleAudioRules GetRootAsRoleAudioRules(ByteBuffer _bb, RoleAudioRules obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C73A RID: 51002 RVA: 0x002F7791 File Offset: 0x002F5991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x002F77A0 File Offset: 0x002F59A0
		public RoleAudioRules __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600C73C RID: 51004 RVA: 0x002F77B0 File Offset: 0x002F59B0
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

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600C73D RID: 51005 RVA: 0x002F77EC File Offset: 0x002F59EC
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

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600C73E RID: 51006 RVA: 0x002F7828 File Offset: 0x002F5A28
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

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600C73F RID: 51007 RVA: 0x002F7864 File Offset: 0x002F5A64
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

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600C740 RID: 51008 RVA: 0x002F78A4 File Offset: 0x002F5AA4
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

		// Token: 0x04005135 RID: 20789
		private Table __p;
	}
}
