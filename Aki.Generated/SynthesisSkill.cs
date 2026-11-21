using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001249 RID: 4681
	public struct SynthesisSkill : IFlatbufferObject
	{
		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x00354375 File Offset: 0x00352575
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9FE RID: 59902 RVA: 0x00354382 File Offset: 0x00352582
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9FF RID: 59903 RVA: 0x0035438C File Offset: 0x0035258C
		public static SynthesisSkill GetRootAsSynthesisSkill(ByteBuffer _bb)
		{
			return SynthesisSkill.GetRootAsSynthesisSkill(_bb, default(SynthesisSkill));
		}

		// Token: 0x0600EA00 RID: 59904 RVA: 0x003543A8 File Offset: 0x003525A8
		public static SynthesisSkill GetRootAsSynthesisSkill(ByteBuffer _bb, SynthesisSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA01 RID: 59905 RVA: 0x003543C5 File Offset: 0x003525C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA02 RID: 59906 RVA: 0x003543D4 File Offset: 0x003525D4
		public SynthesisSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x003543E4 File Offset: 0x003525E4
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

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x0600EA04 RID: 59908 RVA: 0x00354420 File Offset: 0x00352620
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

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x0035445C File Offset: 0x0035265C
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

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600EA06 RID: 59910 RVA: 0x00354498 File Offset: 0x00352698
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

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600EA07 RID: 59911 RVA: 0x003544D8 File Offset: 0x003526D8
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

		// Token: 0x04005893 RID: 22675
		private Table __p;
	}
}
