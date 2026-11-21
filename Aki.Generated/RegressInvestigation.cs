using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001096 RID: 4246
	public struct RegressInvestigation : IFlatbufferObject
	{
		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600C144 RID: 49476 RVA: 0x002F86E5 File Offset: 0x002F68E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C145 RID: 49477 RVA: 0x002F86F2 File Offset: 0x002F68F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C146 RID: 49478 RVA: 0x002F86FC File Offset: 0x002F68FC
		public static RegressInvestigation GetRootAsRegressInvestigation(ByteBuffer _bb)
		{
			return RegressInvestigation.GetRootAsRegressInvestigation(_bb, default(RegressInvestigation));
		}

		// Token: 0x0600C147 RID: 49479 RVA: 0x002F8718 File Offset: 0x002F6918
		public static RegressInvestigation GetRootAsRegressInvestigation(ByteBuffer _bb, RegressInvestigation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C148 RID: 49480 RVA: 0x002F8735 File Offset: 0x002F6935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C149 RID: 49481 RVA: 0x002F8744 File Offset: 0x002F6944
		public RegressInvestigation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0600C14A RID: 49482 RVA: 0x002F8754 File Offset: 0x002F6954
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

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0600C14B RID: 49483 RVA: 0x002F8790 File Offset: 0x002F6990
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

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0600C14C RID: 49484 RVA: 0x002F87CC File Offset: 0x002F69CC
		public bool IfGlobal
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0600C14D RID: 49485 RVA: 0x002F880C File Offset: 0x002F6A0C
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

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0600C14E RID: 49486 RVA: 0x002F884C File Offset: 0x002F6A4C
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

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0600C14F RID: 49487 RVA: 0x002F888C File Offset: 0x002F6A8C
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

		// Token: 0x0600C150 RID: 49488 RVA: 0x002F88C4 File Offset: 0x002F6AC4
		public Span<byte> GetHyperLinkBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C151 RID: 49489 RVA: 0x002F88D4 File Offset: 0x002F6AD4
		public byte[] GetHyperLinkArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400566F RID: 22127
		private Table __p;
	}
}
