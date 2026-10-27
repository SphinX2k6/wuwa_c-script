using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B14 RID: 2836
	public struct AvignonStage : IFlatbufferObject
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x001DAB70 File Offset: 0x001D8D70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x001DAB7D File Offset: 0x001D8D7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x001DAB84 File Offset: 0x001D8D84
		public static AvignonStage GetRootAsAvignonStage(ByteBuffer _bb)
		{
			return AvignonStage.GetRootAsAvignonStage(_bb, default(AvignonStage));
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x001DABA0 File Offset: 0x001D8DA0
		public static AvignonStage GetRootAsAvignonStage(ByteBuffer _bb, AvignonStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x001DABBD File Offset: 0x001D8DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x001DABCC File Offset: 0x001D8DCC
		public AvignonStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x001DABDC File Offset: 0x001D8DDC
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

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x001DAC18 File Offset: 0x001D8E18
		public string Title
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x001DAC4F File Offset: 0x001D8E4F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x001DAC5E File Offset: 0x001D8E5E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x001DAC78 File Offset: 0x001D8E78
		public int OpenConditionId
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

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060049ED RID: 18925 RVA: 0x001DACB4 File Offset: 0x001D8EB4
		public string Icon
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

		// Token: 0x060049EE RID: 18926 RVA: 0x001DACEC File Offset: 0x001D8EEC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x001DACFC File Offset: 0x001D8EFC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060049F0 RID: 18928 RVA: 0x001DAD14 File Offset: 0x001D8F14
		public string FemaleIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x001DAD4C File Offset: 0x001D8F4C
		public Span<byte> GetFemaleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x001DAD5C File Offset: 0x001D8F5C
		public byte[] GetFemaleIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x001DAD74 File Offset: 0x001D8F74
		public string RomaIcon
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

		// Token: 0x060049F4 RID: 18932 RVA: 0x001DADAC File Offset: 0x001D8FAC
		public Span<byte> GetRomaIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x001DADBC File Offset: 0x001D8FBC
		public byte[] GetRomaIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x001DADD4 File Offset: 0x001D8FD4
		public int QuestionId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004AFC RID: 19196
		private Table __p;
	}
}
