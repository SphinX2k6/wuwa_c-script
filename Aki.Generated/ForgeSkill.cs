using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB0 RID: 3504
	public struct ForgeSkill : IFlatbufferObject
	{
		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06007C8A RID: 31882 RVA: 0x0026109F File Offset: 0x0025F29F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C8B RID: 31883 RVA: 0x002610AC File Offset: 0x0025F2AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x002610B4 File Offset: 0x0025F2B4
		public static ForgeSkill GetRootAsForgeSkill(ByteBuffer _bb)
		{
			return ForgeSkill.GetRootAsForgeSkill(_bb, default(ForgeSkill));
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x002610D0 File Offset: 0x0025F2D0
		public static ForgeSkill GetRootAsForgeSkill(ByteBuffer _bb, ForgeSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x002610ED File Offset: 0x0025F2ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x002610FC File Offset: 0x0025F2FC
		public ForgeSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06007C90 RID: 31888 RVA: 0x0026110C File Offset: 0x0025F30C
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

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06007C91 RID: 31889 RVA: 0x00261148 File Offset: 0x0025F348
		public int ExtraItemId
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

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06007C92 RID: 31890 RVA: 0x00261184 File Offset: 0x0025F384
		public int EffectiveProbability
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

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06007C93 RID: 31891 RVA: 0x002611C0 File Offset: 0x0025F3C0
		public int Typeld
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06007C94 RID: 31892 RVA: 0x00261200 File Offset: 0x0025F400
		public int SkillDescription
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

		// Token: 0x04005320 RID: 21280
		private Table __p;
	}
}
