using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004585 RID: 17797
	public class IRollBlockHintStepBase_UnionUnion
	{
		// Token: 0x17007E72 RID: 32370
		// (get) Token: 0x0601AE13 RID: 110099 RVA: 0x003D61D5 File Offset: 0x003D43D5
		// (set) Token: 0x0601AE14 RID: 110100 RVA: 0x003D61DD File Offset: 0x003D43DD
		public IRollBlockHintStepBase_Union Type { get; set; }

		// Token: 0x17007E73 RID: 32371
		// (get) Token: 0x0601AE15 RID: 110101 RVA: 0x003D61E6 File Offset: 0x003D43E6
		// (set) Token: 0x0601AE16 RID: 110102 RVA: 0x003D61EE File Offset: 0x003D43EE
		public object Value { get; set; }

		// Token: 0x0601AE17 RID: 110103 RVA: 0x003D61F7 File Offset: 0x003D43F7
		public IRollBlockHintStepBase_UnionUnion()
		{
			this.Type = IRollBlockHintStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE18 RID: 110104 RVA: 0x003D620D File Offset: 0x003D440D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE19 RID: 110105 RVA: 0x003D621F File Offset: 0x003D441F
		public IRollBlockHintStepBaseT AsIRollBlockHintStepBase()
		{
			return this.As<IRollBlockHintStepBaseT>();
		}

		// Token: 0x0601AE1A RID: 110106 RVA: 0x003D6227 File Offset: 0x003D4427
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepBase(IRollBlockHintStepBaseT _irollblockhintstepbase)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepBase,
				Value = _irollblockhintstepbase
			};
		}

		// Token: 0x0601AE1B RID: 110107 RVA: 0x003D623C File Offset: 0x003D443C
		public IRollBlockHintStepRollT AsIRollBlockHintStepRoll()
		{
			return this.As<IRollBlockHintStepRollT>();
		}

		// Token: 0x0601AE1C RID: 110108 RVA: 0x003D6244 File Offset: 0x003D4444
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepRoll(IRollBlockHintStepRollT _irollblockhintsteproll)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepRoll,
				Value = _irollblockhintsteproll
			};
		}

		// Token: 0x0601AE1D RID: 110109 RVA: 0x003D6259 File Offset: 0x003D4459
		public IRollBlockHintStepJumpT AsIRollBlockHintStepJump()
		{
			return this.As<IRollBlockHintStepJumpT>();
		}

		// Token: 0x0601AE1E RID: 110110 RVA: 0x003D6261 File Offset: 0x003D4461
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepJump(IRollBlockHintStepJumpT _irollblockhintstepjump)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepJump,
				Value = _irollblockhintstepjump
			};
		}

		// Token: 0x0601AE1F RID: 110111 RVA: 0x003D6276 File Offset: 0x003D4476
		public IRollBlockHintStepOperationT AsIRollBlockHintStepOperation()
		{
			return this.As<IRollBlockHintStepOperationT>();
		}

		// Token: 0x0601AE20 RID: 110112 RVA: 0x003D627E File Offset: 0x003D447E
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepOperation(IRollBlockHintStepOperationT _irollblockhintstepoperation)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepOperation,
				Value = _irollblockhintstepoperation
			};
		}

		// Token: 0x0601AE21 RID: 110113 RVA: 0x003D6294 File Offset: 0x003D4494
		public static int Pack(FlatBufferBuilder builder, IRollBlockHintStepBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRollBlockHintStepBase_Union.IRollBlockHintStepBase:
				return IRollBlockHintStepBase.Pack(builder, _o.AsIRollBlockHintStepBase()).Value;
			case IRollBlockHintStepBase_Union.IRollBlockHintStepRoll:
				return IRollBlockHintStepRoll.Pack(builder, _o.AsIRollBlockHintStepRoll()).Value;
			case IRollBlockHintStepBase_Union.IRollBlockHintStepJump:
				return IRollBlockHintStepJump.Pack(builder, _o.AsIRollBlockHintStepJump()).Value;
			case IRollBlockHintStepBase_Union.IRollBlockHintStepOperation:
				return IRollBlockHintStepOperation.Pack(builder, _o.AsIRollBlockHintStepOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
