using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9F RID: 2975
	public struct CookingSkill : IFlatbufferObject
	{
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x001FF98D File Offset: 0x001FDB8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x001FF99A File Offset: 0x001FDB9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x001FF9A4 File Offset: 0x001FDBA4
		public static CookingSkill GetRootAsCookingSkill(ByteBuffer _bb)
		{
			return CookingSkill.GetRootAsCookingSkill(_bb, default(CookingSkill));
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x001FF9C0 File Offset: 0x001FDBC0
		public static CookingSkill GetRootAsCookingSkill(ByteBuffer _bb, CookingSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x001FF9DD File Offset: 0x001FDBDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x001FF9EC File Offset: 0x001FDBEC
		public CookingSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x001FF9FC File Offset: 0x001FDBFC
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

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x001FFA38 File Offset: 0x001FDC38
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x001FFA74 File Offset: 0x001FDC74
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

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06005966 RID: 22886 RVA: 0x001FFAB0 File Offset: 0x001FDCB0
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x001FFAF0 File Offset: 0x001FDCF0
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

		// Token: 0x04004BC1 RID: 19393
		private Table __p;
	}
}
