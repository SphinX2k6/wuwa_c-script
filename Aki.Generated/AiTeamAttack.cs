using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCF RID: 3023
	public struct AiTeamAttack : IFlatbufferObject
	{
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x001F40CE File Offset: 0x001F22CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x001F40DB File Offset: 0x001F22DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x001F40E4 File Offset: 0x001F22E4
		public static AiTeamAttack GetRootAsAiTeamAttack(ByteBuffer _bb)
		{
			return AiTeamAttack.GetRootAsAiTeamAttack(_bb, default(AiTeamAttack));
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x001F4100 File Offset: 0x001F2300
		public static AiTeamAttack GetRootAsAiTeamAttack(ByteBuffer _bb, AiTeamAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x001F411D File Offset: 0x001F231D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x001F412C File Offset: 0x001F232C
		public AiTeamAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06004C77 RID: 19575 RVA: 0x001F413C File Offset: 0x001F233C
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06004C78 RID: 19576 RVA: 0x001F4178 File Offset: 0x001F2378
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

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06004C79 RID: 19577 RVA: 0x001F41B8 File Offset: 0x001F23B8
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x001F41F8 File Offset: 0x001F23F8
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

		// Token: 0x040050B0 RID: 20656
		private Table __p;
	}
}
