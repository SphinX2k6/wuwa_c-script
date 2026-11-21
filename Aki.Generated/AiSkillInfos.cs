using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCB RID: 3019
	public struct AiSkillInfos : IFlatbufferObject
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06004C36 RID: 19510 RVA: 0x001F37DE File Offset: 0x001F19DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x001F37EB File Offset: 0x001F19EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x001F37F4 File Offset: 0x001F19F4
		public static AiSkillInfos GetRootAsAiSkillInfos(ByteBuffer _bb)
		{
			return AiSkillInfos.GetRootAsAiSkillInfos(_bb, default(AiSkillInfos));
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x001F3810 File Offset: 0x001F1A10
		public static AiSkillInfos GetRootAsAiSkillInfos(ByteBuffer _bb, AiSkillInfos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x001F382D File Offset: 0x001F1A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x001F383C File Offset: 0x001F1A3C
		public AiSkillInfos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x001F384C File Offset: 0x001F1A4C
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

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x001F3888 File Offset: 0x001F1A88
		public int SkillWeight
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06004C3E RID: 19518 RVA: 0x001F38C4 File Offset: 0x001F1AC4
		public int SkillPreconditionId
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

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x001F3900 File Offset: 0x001F1B00
		public string SkillId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x001F3938 File Offset: 0x001F1B38
		public Span<byte> GetSkillIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x001F3948 File Offset: 0x001F1B48
		public byte[] GetSkillIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06004C42 RID: 19522 RVA: 0x001F3960 File Offset: 0x001F1B60
		public FloatRange? SkillCdRange
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06004C43 RID: 19523 RVA: 0x001F39C0 File Offset: 0x001F1BC0
		public int SkillType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050AC RID: 20652
		private Table __p;
	}
}
