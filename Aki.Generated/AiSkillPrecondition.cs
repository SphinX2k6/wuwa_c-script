using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCC RID: 3020
	public struct AiSkillPrecondition : IFlatbufferObject
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06004C44 RID: 19524 RVA: 0x001F39FD File Offset: 0x001F1BFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x001F3A0A File Offset: 0x001F1C0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x001F3A14 File Offset: 0x001F1C14
		public static AiSkillPrecondition GetRootAsAiSkillPrecondition(ByteBuffer _bb)
		{
			return AiSkillPrecondition.GetRootAsAiSkillPrecondition(_bb, default(AiSkillPrecondition));
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x001F3A30 File Offset: 0x001F1C30
		public static AiSkillPrecondition GetRootAsAiSkillPrecondition(ByteBuffer _bb, AiSkillPrecondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x001F3A4D File Offset: 0x001F1C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x001F3A5C File Offset: 0x001F1C5C
		public AiSkillPrecondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x001F3A6C File Offset: 0x001F1C6C
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

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06004C4B RID: 19531 RVA: 0x001F3AA8 File Offset: 0x001F1CA8
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

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x001F3B08 File Offset: 0x001F1D08
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

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06004C4D RID: 19533 RVA: 0x001F3B68 File Offset: 0x001F1D68
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

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x001F3BC8 File Offset: 0x001F1DC8
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06004C4F RID: 19535 RVA: 0x001F3C28 File Offset: 0x001F1E28
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

		// Token: 0x06004C50 RID: 19536 RVA: 0x001F3C60 File Offset: 0x001F1E60
		public Span<byte> GetNeedTagBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x001F3C70 File Offset: 0x001F1E70
		public byte[] GetNeedTagArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06004C52 RID: 19538 RVA: 0x001F3C88 File Offset: 0x001F1E88
		public bool NeedTarget
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040050AD RID: 20653
		private Table __p;
	}
}
