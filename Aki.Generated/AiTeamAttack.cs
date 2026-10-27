using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF5 RID: 2805
	public struct AiTeamAttack : IFlatbufferObject
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x001D472D File Offset: 0x001D292D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x001D473A File Offset: 0x001D293A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x001D4744 File Offset: 0x001D2944
		public static AiTeamAttack GetRootAsAiTeamAttack(ByteBuffer _bb)
		{
			return AiTeamAttack.GetRootAsAiTeamAttack(_bb, default(AiTeamAttack));
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x001D4760 File Offset: 0x001D2960
		public static AiTeamAttack GetRootAsAiTeamAttack(ByteBuffer _bb, AiTeamAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x001D477D File Offset: 0x001D297D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x001D478C File Offset: 0x001D298C
		public AiTeamAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x001D479C File Offset: 0x001D299C
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

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06004731 RID: 18225 RVA: 0x001D47D8 File Offset: 0x001D29D8
		public float ExtraWeight
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 3000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x001D4818 File Offset: 0x001D2A18
		public float DistanceCoefficient
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06004733 RID: 18227 RVA: 0x001D4858 File Offset: 0x001D2A58
		public float AngleCoefficient
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004AD6 RID: 19158
		private Table __p;
	}
}
