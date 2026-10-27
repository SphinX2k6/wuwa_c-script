using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D3 RID: 16595
	public struct IRoleTowerConditionStepBattle : IFlatbufferObject
	{
		// Token: 0x17007507 RID: 29959
		// (get) Token: 0x060182DA RID: 99034 RVA: 0x0037BB1A File Offset: 0x00379D1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182DB RID: 99035 RVA: 0x0037BB27 File Offset: 0x00379D27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182DC RID: 99036 RVA: 0x0037BB30 File Offset: 0x00379D30
		public static IRoleTowerConditionStepBattle GetRootAsIRoleTowerConditionStepBattle(ByteBuffer _bb)
		{
			return IRoleTowerConditionStepBattle.GetRootAsIRoleTowerConditionStepBattle(_bb, default(IRoleTowerConditionStepBattle));
		}

		// Token: 0x060182DD RID: 99037 RVA: 0x0037BB4C File Offset: 0x00379D4C
		public static IRoleTowerConditionStepBattle GetRootAsIRoleTowerConditionStepBattle(ByteBuffer _bb, IRoleTowerConditionStepBattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182DE RID: 99038 RVA: 0x0037BB69 File Offset: 0x00379D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182DF RID: 99039 RVA: 0x0037BB78 File Offset: 0x00379D78
		public IRoleTowerConditionStepBattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007508 RID: 29960
		// (get) Token: 0x060182E0 RID: 99040 RVA: 0x0037BB88 File Offset: 0x00379D88
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

		// Token: 0x060182E1 RID: 99041 RVA: 0x0037BBC4 File Offset: 0x00379DC4
		public static Offset<IRoleTowerConditionStepBattle> CreateIRoleTowerConditionStepBattle(FlatBufferBuilder builder, ERoleTowerConditionStep Type = ERoleTowerConditionStep.Prepare)
		{
			builder.StartTable(1);
			IRoleTowerConditionStepBattle.AddType(builder, Type);
			return IRoleTowerConditionStepBattle.EndIRoleTowerConditionStepBattle(builder);
		}

		// Token: 0x060182E2 RID: 99042 RVA: 0x0037BBDA File Offset: 0x00379DDA
		public static void StartIRoleTowerConditionStepBattle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182E3 RID: 99043 RVA: 0x0037BBE3 File Offset: 0x00379DE3
		public static void AddType(FlatBufferBuilder builder, ERoleTowerConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182E4 RID: 99044 RVA: 0x0037BBEE File Offset: 0x00379DEE
		public static Offset<IRoleTowerConditionStepBattle> EndIRoleTowerConditionStepBattle(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerConditionStepBattle>(builder.EndTable());
		}

		// Token: 0x060182E5 RID: 99045 RVA: 0x0037BBFC File Offset: 0x00379DFC
		public IRoleTowerConditionStepBattleT UnPack()
		{
			IRoleTowerConditionStepBattleT roleTowerConditionStepBattleT = new IRoleTowerConditionStepBattleT();
			this.UnPackTo(roleTowerConditionStepBattleT);
			return roleTowerConditionStepBattleT;
		}

		// Token: 0x060182E6 RID: 99046 RVA: 0x0037BC17 File Offset: 0x00379E17
		public void UnPackTo(IRoleTowerConditionStepBattleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182E7 RID: 99047 RVA: 0x0037BC28 File Offset: 0x00379E28
		public static Offset<IRoleTowerConditionStepBattle> Pack(FlatBufferBuilder builder, IRoleTowerConditionStepBattleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerConditionStepBattle>);
			}
			return IRoleTowerConditionStepBattle.CreateIRoleTowerConditionStepBattle(builder, _o.Type);
		}

		// Token: 0x0400BC70 RID: 48240
		private Table __p;
	}
}
