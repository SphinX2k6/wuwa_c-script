using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004618 RID: 17944
	public class TRollBlockHintStepUnion
	{
		// Token: 0x17007F6F RID: 32623
		// (get) Token: 0x0601B2EB RID: 111339 RVA: 0x003DF294 File Offset: 0x003DD494
		// (set) Token: 0x0601B2EC RID: 111340 RVA: 0x003DF29C File Offset: 0x003DD49C
		public TRollBlockHintStep Type { get; set; }

		// Token: 0x17007F70 RID: 32624
		// (get) Token: 0x0601B2ED RID: 111341 RVA: 0x003DF2A5 File Offset: 0x003DD4A5
		// (set) Token: 0x0601B2EE RID: 111342 RVA: 0x003DF2AD File Offset: 0x003DD4AD
		public object Value { get; set; }

		// Token: 0x0601B2EF RID: 111343 RVA: 0x003DF2B6 File Offset: 0x003DD4B6
		public TRollBlockHintStepUnion()
		{
			this.Type = TRollBlockHintStep.NONE;
			this.Value = null;
		}

		// Token: 0x0601B2F0 RID: 111344 RVA: 0x003DF2CC File Offset: 0x003DD4CC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B2F1 RID: 111345 RVA: 0x003DF2DE File Offset: 0x003DD4DE
		public IRollBlockHintStepJumpT AsIRollBlockHintStepJump()
		{
			return this.As<IRollBlockHintStepJumpT>();
		}

		// Token: 0x0601B2F2 RID: 111346 RVA: 0x003DF2E6 File Offset: 0x003DD4E6
		public static TRollBlockHintStepUnion FromIRollBlockHintStepJump(IRollBlockHintStepJumpT _irollblockhintstepjump)
		{
			return new TRollBlockHintStepUnion
			{
				Type = TRollBlockHintStep.IRollBlockHintStepJump,
				Value = _irollblockhintstepjump
			};
		}

		// Token: 0x0601B2F3 RID: 111347 RVA: 0x003DF2FB File Offset: 0x003DD4FB
		public IRollBlockHintStepOperationT AsIRollBlockHintStepOperation()
		{
			return this.As<IRollBlockHintStepOperationT>();
		}

		// Token: 0x0601B2F4 RID: 111348 RVA: 0x003DF303 File Offset: 0x003DD503
		public static TRollBlockHintStepUnion FromIRollBlockHintStepOperation(IRollBlockHintStepOperationT _irollblockhintstepoperation)
		{
			return new TRollBlockHintStepUnion
			{
				Type = TRollBlockHintStep.IRollBlockHintStepOperation,
				Value = _irollblockhintstepoperation
			};
		}

		// Token: 0x0601B2F5 RID: 111349 RVA: 0x003DF318 File Offset: 0x003DD518
		public IRollBlockHintStepRollT AsIRollBlockHintStepRoll()
		{
			return this.As<IRollBlockHintStepRollT>();
		}

		// Token: 0x0601B2F6 RID: 111350 RVA: 0x003DF320 File Offset: 0x003DD520
		public static TRollBlockHintStepUnion FromIRollBlockHintStepRoll(IRollBlockHintStepRollT _irollblockhintsteproll)
		{
			return new TRollBlockHintStepUnion
			{
				Type = TRollBlockHintStep.IRollBlockHintStepRoll,
				Value = _irollblockhintsteproll
			};
		}

		// Token: 0x0601B2F7 RID: 111351 RVA: 0x003DF338 File Offset: 0x003DD538
		public static int Pack(FlatBufferBuilder builder, TRollBlockHintStepUnion _o)
		{
			switch (_o.Type)
			{
			case TRollBlockHintStep.IRollBlockHintStepJump:
				return IRollBlockHintStepJump.Pack(builder, _o.AsIRollBlockHintStepJump()).Value;
			case TRollBlockHintStep.IRollBlockHintStepOperation:
				return IRollBlockHintStepOperation.Pack(builder, _o.AsIRollBlockHintStepOperation()).Value;
			case TRollBlockHintStep.IRollBlockHintStepRoll:
				return IRollBlockHintStepRoll.Pack(builder, _o.AsIRollBlockHintStepRoll()).Value;
			default:
				return 0;
			}
		}
	}
}
