using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049ED RID: 18925
	public class IRollBlockHintStepBase_UnionUnion
	{
		// Token: 0x170084B3 RID: 33971
		// (get) Token: 0x0601C5E8 RID: 116200 RVA: 0x00402471 File Offset: 0x00400671
		// (set) Token: 0x0601C5E9 RID: 116201 RVA: 0x00402479 File Offset: 0x00400679
		public IRollBlockHintStepBase_Union Type { get; set; }

		// Token: 0x170084B4 RID: 33972
		// (get) Token: 0x0601C5EA RID: 116202 RVA: 0x00402482 File Offset: 0x00400682
		// (set) Token: 0x0601C5EB RID: 116203 RVA: 0x0040248A File Offset: 0x0040068A
		public object Value { get; set; }

		// Token: 0x0601C5EC RID: 116204 RVA: 0x00402493 File Offset: 0x00400693
		public IRollBlockHintStepBase_UnionUnion()
		{
			this.Type = IRollBlockHintStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C5ED RID: 116205 RVA: 0x004024A9 File Offset: 0x004006A9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C5EE RID: 116206 RVA: 0x004024BB File Offset: 0x004006BB
		public IRollBlockHintStepBaseT AsIRollBlockHintStepBase()
		{
			return this.As<IRollBlockHintStepBaseT>();
		}

		// Token: 0x0601C5EF RID: 116207 RVA: 0x004024C3 File Offset: 0x004006C3
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepBase(IRollBlockHintStepBaseT _irollblockhintstepbase)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepBase,
				Value = _irollblockhintstepbase
			};
		}

		// Token: 0x0601C5F0 RID: 116208 RVA: 0x004024D8 File Offset: 0x004006D8
		public IRollBlockHintStepRollT AsIRollBlockHintStepRoll()
		{
			return this.As<IRollBlockHintStepRollT>();
		}

		// Token: 0x0601C5F1 RID: 116209 RVA: 0x004024E0 File Offset: 0x004006E0
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepRoll(IRollBlockHintStepRollT _irollblockhintsteproll)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepRoll,
				Value = _irollblockhintsteproll
			};
		}

		// Token: 0x0601C5F2 RID: 116210 RVA: 0x004024F5 File Offset: 0x004006F5
		public IRollBlockHintStepJumpT AsIRollBlockHintStepJump()
		{
			return this.As<IRollBlockHintStepJumpT>();
		}

		// Token: 0x0601C5F3 RID: 116211 RVA: 0x004024FD File Offset: 0x004006FD
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepJump(IRollBlockHintStepJumpT _irollblockhintstepjump)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepJump,
				Value = _irollblockhintstepjump
			};
		}

		// Token: 0x0601C5F4 RID: 116212 RVA: 0x00402512 File Offset: 0x00400712
		public IRollBlockHintStepOperationT AsIRollBlockHintStepOperation()
		{
			return this.As<IRollBlockHintStepOperationT>();
		}

		// Token: 0x0601C5F5 RID: 116213 RVA: 0x0040251A File Offset: 0x0040071A
		public static IRollBlockHintStepBase_UnionUnion FromIRollBlockHintStepOperation(IRollBlockHintStepOperationT _irollblockhintstepoperation)
		{
			return new IRollBlockHintStepBase_UnionUnion
			{
				Type = IRollBlockHintStepBase_Union.IRollBlockHintStepOperation,
				Value = _irollblockhintstepoperation
			};
		}

		// Token: 0x0601C5F6 RID: 116214 RVA: 0x00402530 File Offset: 0x00400730
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
