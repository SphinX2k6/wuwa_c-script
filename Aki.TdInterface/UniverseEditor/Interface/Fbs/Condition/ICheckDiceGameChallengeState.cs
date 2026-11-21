using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E84 RID: 20100
	public struct ICheckDiceGameChallengeState : IFlatbufferObject
	{
		// Token: 0x17008F57 RID: 36695
		// (get) Token: 0x0601F225 RID: 127525 RVA: 0x00457CC8 File Offset: 0x00455EC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F226 RID: 127526 RVA: 0x00457CD5 File Offset: 0x00455ED5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F227 RID: 127527 RVA: 0x00457CDC File Offset: 0x00455EDC
		public static ICheckDiceGameChallengeState GetRootAsICheckDiceGameChallengeState(ByteBuffer _bb)
		{
			return ICheckDiceGameChallengeState.GetRootAsICheckDiceGameChallengeState(_bb, default(ICheckDiceGameChallengeState));
		}

		// Token: 0x0601F228 RID: 127528 RVA: 0x00457CF8 File Offset: 0x00455EF8
		public static ICheckDiceGameChallengeState GetRootAsICheckDiceGameChallengeState(ByteBuffer _bb, ICheckDiceGameChallengeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F229 RID: 127529 RVA: 0x00457D15 File Offset: 0x00455F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F22A RID: 127530 RVA: 0x00457D24 File Offset: 0x00455F24
		public ICheckDiceGameChallengeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F58 RID: 36696
		// (get) Token: 0x0601F22B RID: 127531 RVA: 0x00457D34 File Offset: 0x00455F34
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F59 RID: 36697
		// (get) Token: 0x0601F22C RID: 127532 RVA: 0x00457D70 File Offset: 0x00455F70
		public int ChallengeId
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

		// Token: 0x17008F5A RID: 36698
		// (get) Token: 0x0601F22D RID: 127533 RVA: 0x00457DAC File Offset: 0x00455FAC
		public EDiceGameChallengeStateType ChallengeState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EDiceGameChallengeStateType.Default;
				}
				return (EDiceGameChallengeStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F22E RID: 127534 RVA: 0x00457DE8 File Offset: 0x00455FE8
		public static Offset<ICheckDiceGameChallengeState> CreateICheckDiceGameChallengeState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ChallengeId = 0, EDiceGameChallengeStateType ChallengeState = EDiceGameChallengeStateType.Default)
		{
			builder.StartTable(3);
			ICheckDiceGameChallengeState.AddChallengeId(builder, ChallengeId);
			ICheckDiceGameChallengeState.AddChallengeState(builder, ChallengeState);
			ICheckDiceGameChallengeState.AddType(builder, Type);
			return ICheckDiceGameChallengeState.EndICheckDiceGameChallengeState(builder);
		}

		// Token: 0x0601F22F RID: 127535 RVA: 0x00457E0C File Offset: 0x0045600C
		public static void StartICheckDiceGameChallengeState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F230 RID: 127536 RVA: 0x00457E15 File Offset: 0x00456015
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F231 RID: 127537 RVA: 0x00457E20 File Offset: 0x00456020
		public static void AddChallengeId(FlatBufferBuilder builder, int challengeId)
		{
			builder.AddInt(1, challengeId, 0);
		}

		// Token: 0x0601F232 RID: 127538 RVA: 0x00457E2B File Offset: 0x0045602B
		public static void AddChallengeState(FlatBufferBuilder builder, EDiceGameChallengeStateType challengeState)
		{
			builder.AddByte(2, (byte)challengeState, 0);
		}

		// Token: 0x0601F233 RID: 127539 RVA: 0x00457E36 File Offset: 0x00456036
		public static Offset<ICheckDiceGameChallengeState> EndICheckDiceGameChallengeState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDiceGameChallengeState>(builder.EndTable());
		}

		// Token: 0x0601F234 RID: 127540 RVA: 0x00457E44 File Offset: 0x00456044
		public ICheckDiceGameChallengeStateT UnPack()
		{
			ICheckDiceGameChallengeStateT checkDiceGameChallengeStateT = new ICheckDiceGameChallengeStateT();
			this.UnPackTo(checkDiceGameChallengeStateT);
			return checkDiceGameChallengeStateT;
		}

		// Token: 0x0601F235 RID: 127541 RVA: 0x00457E5F File Offset: 0x0045605F
		public void UnPackTo(ICheckDiceGameChallengeStateT _o)
		{
			_o.Type = this.Type;
			_o.ChallengeId = this.ChallengeId;
			_o.ChallengeState = this.ChallengeState;
		}

		// Token: 0x0601F236 RID: 127542 RVA: 0x00457E88 File Offset: 0x00456088
		public static Offset<ICheckDiceGameChallengeState> Pack(FlatBufferBuilder builder, ICheckDiceGameChallengeStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDiceGameChallengeState>);
			}
			return ICheckDiceGameChallengeState.CreateICheckDiceGameChallengeState(builder, _o.Type, _o.ChallengeId, _o.ChallengeState);
		}

		// Token: 0x0400DCC0 RID: 56512
		private Table __p;
	}
}
