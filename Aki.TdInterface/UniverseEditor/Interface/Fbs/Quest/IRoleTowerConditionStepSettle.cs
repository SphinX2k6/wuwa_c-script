using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040DC RID: 16604
	public struct IRoleTowerConditionStepSettle : IFlatbufferObject
	{
		// Token: 0x17007510 RID: 29968
		// (get) Token: 0x06018310 RID: 99088 RVA: 0x0037BF81 File Offset: 0x0037A181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018311 RID: 99089 RVA: 0x0037BF8E File Offset: 0x0037A18E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018312 RID: 99090 RVA: 0x0037BF98 File Offset: 0x0037A198
		public static IRoleTowerConditionStepSettle GetRootAsIRoleTowerConditionStepSettle(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepSettle.GetRootAsIRoleTowerConditionStepSettle(_bb, default(IRoleTowerConditionStepSettle));
		}

		// Token: 0x06018313 RID: 99091 RVA: 0x0037BFB4 File Offset: 0x0037A1B4
		public static IRoleTowerConditionStepSettle GetRootAsIRoleTowerConditionStepSettle(ByteBuffer _bb, IRoleTowerConditionStepSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018314 RID: 99092 RVA: 0x0037BFD1 File Offset: 0x0037A1D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018315 RID: 99093 RVA: 0x0037BFE0 File Offset: 0x0037A1E0
		public IRoleTowerConditionStepSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007511 RID: 29969
		// (get) Token: 0x06018316 RID: 99094 RVA: 0x0037BFF0 File Offset: 0x0037A1F0
		public ERoleTowerConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerConditionStep.Prepare;
				}
				return (ERoleTowerConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018317 RID: 99095 RVA: 0x0037C02C File Offset: 0x0037A22C
		public static Offset<IRoleTowerConditionStepSettle> CreateIRoleTowerConditionStepSettle(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepSettle.AddType(builder, Type);
			return IRoleTowerConditionStepSettle.EndIRoleTowerConditionStepSettle(builder);
		}

		// Token: 0x06018318 RID: 99096 RVA: 0x0037C042 File Offset: 0x0037A242
		public static void StartIRoleTowerConditionStepSettle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018319 RID: 99097 RVA: 0x0037C04B File Offset: 0x0037A24B
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601831A RID: 99098 RVA: 0x0037C056 File Offset: 0x0037A256
		public static Offset<IRoleTowerConditionStepSettle> EndIRoleTowerConditionStepSettle(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepSettle>(builder.EndTable());
		}

		// Token: 0x0601831B RID: 99099 RVA: 0x0037C064 File Offset: 0x0037A264
		public IRoleTowerConditionStepSettleT UnPack()
		{
			IRoleTowerConditionStepSettleT roleTowerConditionStepSettleT = new IRoleTowerConditionStepSettleT();
			this.UnPackTo(roleTowerConditionStepSettleT);
			return roleTowerConditionStepSettleT;
		}

		// Token: 0x0601831C RID: 99100 RVA: 0x0037C07F File Offset: 0x0037A27F
		public void UnPackTo(IRoleTowerConditionStepSettleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601831D RID: 99101 RVA: 0x0037C090 File Offset: 0x0037A290
		public static Offset<IRoleTowerConditionStepSettle> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepSettleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepSettle>);
			}
			return IRoleTowerConditionStepSettle.CreateIRoleTowerConditionStepSettle(builder, _o.Type);
		}

		// Token: 0x0400BC76 RID: 48246
		private Table __p;
	}
}
