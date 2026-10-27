using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF2 RID: 2802
	public struct AiSkillPrecondition : IFlatbufferObject
	{
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x001D403D File Offset: 0x001D223D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x001D404A File Offset: 0x001D224A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x001D4054 File Offset: 0x001D2254
		public static AiSkillPrecondition GetRootAsAiSkillPrecondition(ByteBuffer _bb)
		{
			return AiSkillPrecondition.GetRootAsAiSkillPrecondition(_bb, default(AiSkillPrecondition));
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x001D4070 File Offset: 0x001D2270
		public static AiSkillPrecondition GetRootAsAiSkillPrecondition(ByteBuffer _bb, AiSkillPrecondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x001D408D File Offset: 0x001D228D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x001D409C File Offset: 0x001D229C
		public AiSkillPrecondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x001D40AC File Offset: 0x001D22AC
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x001D40E8 File Offset: 0x001D22E8
		public FloatRange? DistanceRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06004705 RID: 18181 RVA: 0x001D4148 File Offset: 0x001D2348
		public FloatRange? AngleRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x001D41A8 File Offset: 0x001D23A8
		public FloatRange? TargetAngleRange
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x001D4208 File Offset: 0x001D2408
		public FloatRange? HeightRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x001D4268 File Offset: 0x001D2468
		public string NeedTag
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

		// Token: 0x06004709 RID: 18185 RVA: 0x001D42A0 File Offset: 0x001D24A0
		public Span<byte> GetNeedTagBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x001D42B0 File Offset: 0x001D24B0
		public byte[] GetNeedTagArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x001D42C8 File Offset: 0x001D24C8
		public bool NeedTarget
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004AD3 RID: 19155
		private Table __p;
	}
}
