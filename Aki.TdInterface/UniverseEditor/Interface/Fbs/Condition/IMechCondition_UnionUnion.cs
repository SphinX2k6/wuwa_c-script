using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200514C RID: 20812
	public class IMechCondition_UnionUnion
	{
		// Token: 0x17009527 RID: 38183
		// (get) Token: 0x06020BD5 RID: 134101 RVA: 0x00489135 File Offset: 0x00487335
		// (set) Token: 0x06020BD6 RID: 134102 RVA: 0x0048913D File Offset: 0x0048733D
		public IMechCondition_Union Type { get; set; }

		// Token: 0x17009528 RID: 38184
		// (get) Token: 0x06020BD7 RID: 134103 RVA: 0x00489146 File Offset: 0x00487346
		// (set) Token: 0x06020BD8 RID: 134104 RVA: 0x0048914E File Offset: 0x0048734E
		public object Value { get; set; }

		// Token: 0x06020BD9 RID: 134105 RVA: 0x00489157 File Offset: 0x00487357
		public IMechCondition_UnionUnion()
		{
			this.Type = IMechCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020BDA RID: 134106 RVA: 0x0048916D File Offset: 0x0048736D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020BDB RID: 134107 RVA: 0x0048917F File Offset: 0x0048737F
		public IMechConditionT AsIMechCondition()
		{
			return this.As<IMechConditionT>();
		}

		// Token: 0x06020BDC RID: 134108 RVA: 0x00489187 File Offset: 0x00487387
		public static IMechCondition_UnionUnion FromIMechCondition(IMechConditionT _imechcondition)
		{
			return new IMechCondition_UnionUnion
			{
				Type = IMechCondition_Union.IMechCondition,
				Value = _imechcondition
			};
		}

		// Token: 0x06020BDD RID: 134109 RVA: 0x0048919C File Offset: 0x0048739C
		public ICheckPlayerInMechT AsICheckPlayerInMech()
		{
			return this.As<ICheckPlayerInMechT>();
		}

		// Token: 0x06020BDE RID: 134110 RVA: 0x004891A4 File Offset: 0x004873A4
		public static IMechCondition_UnionUnion FromICheckPlayerInMech(ICheckPlayerInMechT _icheckplayerinmech)
		{
			return new IMechCondition_UnionUnion
			{
				Type = IMechCondition_Union.ICheckPlayerInMech,
				Value = _icheckplayerinmech
			};
		}

		// Token: 0x06020BDF RID: 134111 RVA: 0x004891BC File Offset: 0x004873BC
		public static int Pack(FlatBufferBuilder builder, IMechCondition_UnionUnion _o)
		{
			IMechCondition_Union type = _o.Type;
			if (type == IMechCondition_Union.IMechCondition)
			{
				return IMechCondition.Pack(builder, _o.AsIMechCondition()).Value;
			}
			if (type != IMechCondition_Union.ICheckPlayerInMech)
			{
				return 0;
			}
			return ICheckPlayerInMech.Pack(builder, _o.AsICheckPlayerInMech()).Value;
		}
	}
}
