using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E3 RID: 4579
	public struct SolarSchoolExamChoice : IFlatbufferObject
	{
		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600E109 RID: 57609 RVA: 0x00340187 File Offset: 0x0033E387
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E10A RID: 57610 RVA: 0x00340194 File Offset: 0x0033E394
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E10B RID: 57611 RVA: 0x0034019C File Offset: 0x0033E39C
		public static SolarSchoolExamChoice GetRootAsSolarSchoolExamChoice(ByteBuffer _bb)
		{
			return SolarSchoolExamChoice.GetRootAsSolarSchoolExamChoice(_bb, default(SolarSchoolExamChoice));
		}

		// Token: 0x0600E10C RID: 57612 RVA: 0x003401B8 File Offset: 0x0033E3B8
		public static SolarSchoolExamChoice GetRootAsSolarSchoolExamChoice(ByteBuffer _bb, SolarSchoolExamChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E10D RID: 57613 RVA: 0x003401D5 File Offset: 0x0033E3D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E10E RID: 57614 RVA: 0x003401E4 File Offset: 0x0033E3E4
		public SolarSchoolExamChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600E10F RID: 57615 RVA: 0x003401F4 File Offset: 0x0033E3F4
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

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600E110 RID: 57616 RVA: 0x00340230 File Offset: 0x0033E430
		public int GroupId
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

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600E111 RID: 57617 RVA: 0x0034026C File Offset: 0x0033E46C
		public bool IsCorrect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600E112 RID: 57618 RVA: 0x003402AC File Offset: 0x0033E4AC
		public string TextKey
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

		// Token: 0x0600E113 RID: 57619 RVA: 0x003402E4 File Offset: 0x0033E4E4
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E114 RID: 57620 RVA: 0x003402F4 File Offset: 0x0033E4F4
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005820 RID: 22560
		private Table __p;
	}
}
