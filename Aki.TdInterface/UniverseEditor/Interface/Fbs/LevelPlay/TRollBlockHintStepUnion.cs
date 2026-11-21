using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A80 RID: 19072
	public class TRollBlockHintStepUnion
	{
		// Token: 0x170085B0 RID: 34224
		// (get) Token: 0x0601CAC0 RID: 117440 RVA: 0x0040B530 File Offset: 0x00409730
		// (set) Token: 0x0601CAC1 RID: 117441 RVA: 0x0040B538 File Offset: 0x00409738
		public TRollBlockHintStep Type { get; set; }

		// Token: 0x170085B1 RID: 34225
		// (get) Token: 0x0601CAC2 RID: 117442 RVA: 0x0040B541 File Offset: 0x00409741
		// (set) Token: 0x0601CAC3 RID: 117443 RVA: 0x0040B549 File Offset: 0x00409749
		public object Value { get; set; }

		// Token: 0x0601CAC4 RID: 117444 RVA: 0x0040B552 File Offset: 0x00409752
		public TRollBlockHintStepUnion()
		{
			this.Type = TRollBlockHintStep.NONE;
			this.Value = null;
		}

		// Token: 0x0601CAC5 RID: 117445 RVA: 0x0040B568 File Offset: 0x00409768
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CAC6 RID: 117446 RVA: 0x0040B57A File Offset: 0x0040977A
		public IRollBlockHintStepJumpT AsIRollBlockHintStepJump()
		{
			return this.As<IRollBlockHintStepJumpT>();
		}

		// Token: 0x0601CAC7 RID: 117447 RVA: 0x0040B582 File Offset: 0x00409782
		public static TRollBlockHintStepUnion FromIRollBlockHintStepJump(IRollBlockHintStepJumpT _irollblockhintstepjump)
		{
			return new TRollBlockHintStepUnion
			{
				Type = TRollBlockHintStep.IRollBlockHintStepJump,
				Value = _irollblockhintstepjump
			};
		}

		// Token: 0x0601CAC8 RID: 117448 RVA: 0x0040B597 File Offset: 0x00409797
		public IRollBlockHintStepOperationT AsIRollBlockHintStepOperation()
		{
			return this.As<IRollBlockHintStepOperationT>();
		}

		// Token: 0x0601CAC9 RID: 117449 RVA: 0x0040B59F File Offset: 0x0040979F
		public static TRollBlockHintStepUnion FromIRollBlockHintStepOperation(IRollBlockHintStepOperationT _irollblockhintstepoperation)
		{
			return new TRollBlockHintStepUnion
			{
				Type = TRollBlockHintStep.IRollBlockHintStepOperation,
				Value = _irollblockhintstepoperation
			};
		}

		// Token: 0x0601CACA RID: 117450 RVA: 0x0040B5B4 File Offset: 0x004097B4
		public IRollBlockHintStepRollT AsIRollBlockHintStepRoll()
		{
			return this.As<IRollBlockHintStepRollT>();
		}

		// Token: 0x0601CACB RID: 117451 RVA: 0x0040B5BC File Offset: 0x004097BC
		public static TRollBlockHintStepUnion FromIRollBlockHintStepRoll(IRollBlockHintStepRollT _irollblockhintsteproll)
		{
			return new TRollBlockHintStepUnion
			{
				Type = TRollBlockHintStep.IRollBlockHintStepRoll,
				Value = _irollblockhintsteproll
			};
		}

		// Token: 0x0601CACC RID: 117452 RVA: 0x0040B5D4 File Offset: 0x004097D4
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
