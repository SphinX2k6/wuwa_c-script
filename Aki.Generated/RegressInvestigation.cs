using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAE RID: 4014
	public struct RegressInvestigation : IFlatbufferObject
	{
		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x0600BAFA RID: 47866 RVA: 0x002DBF55 File Offset: 0x002DA155
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x002DBF62 File Offset: 0x002DA162
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x002DBF6C File Offset: 0x002DA16C
		public static RegressInvestigation GetRootAsRegressInvestigation(ByteBuffer _bb)
		{
			return RegressInvestigation.GetRootAsRegressInvestigation(_bb, default(RegressInvestigation));
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x002DBF88 File Offset: 0x002DA188
		public static RegressInvestigation GetRootAsRegressInvestigation(ByteBuffer _bb, RegressInvestigation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x002DBFA5 File Offset: 0x002DA1A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x002DBFB4 File Offset: 0x002DA1B4
		public RegressInvestigation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x0600BB00 RID: 47872 RVA: 0x002DBFC4 File Offset: 0x002DA1C4
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

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0600BB01 RID: 47873 RVA: 0x002DC000 File Offset: 0x002DA200
		public int InvestigationType
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

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0600BB02 RID: 47874 RVA: 0x002DC03C File Offset: 0x002DA23C
		public bool IfGlobal
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600BB03 RID: 47875 RVA: 0x002DC07C File Offset: 0x002DA27C
		public int QuestionnaireId
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

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0600BB04 RID: 47876 RVA: 0x002DC0BC File Offset: 0x002DA2BC
		public int Reward
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

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600BB05 RID: 47877 RVA: 0x002DC0FC File Offset: 0x002DA2FC
		public string HyperLink
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

		// Token: 0x0600BB06 RID: 47878 RVA: 0x002DC134 File Offset: 0x002DA334
		public Span<byte> GetHyperLinkBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BB07 RID: 47879 RVA: 0x002DC144 File Offset: 0x002DA344
		public byte[] GetHyperLinkArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005087 RID: 20615
		private Table __p;
	}
}
