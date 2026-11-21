using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004302 RID: 17154
	public class IItemVariableBase_UnionUnion
	{
		// Token: 0x17007574 RID: 30068
		// (get) Token: 0x0601819F RID: 98719 RVA: 0x003704A8 File Offset: 0x0036E6A8
		// (set) Token: 0x060181A0 RID: 98720 RVA: 0x003704B0 File Offset: 0x0036E6B0
		public IItemVariableBase_Union Type { get; set; }

		// Token: 0x17007575 RID: 30069
		// (get) Token: 0x060181A1 RID: 98721 RVA: 0x003704B9 File Offset: 0x0036E6B9
		// (set) Token: 0x060181A2 RID: 98722 RVA: 0x003704C1 File Offset: 0x0036E6C1
		public object Value { get; set; }

		// Token: 0x060181A3 RID: 98723 RVA: 0x003704CA File Offset: 0x0036E6CA
		public IItemVariableBase_UnionUnion()
		{
			this.Type = IItemVariableBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060181A4 RID: 98724 RVA: 0x003704E0 File Offset: 0x0036E6E0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060181A5 RID: 98725 RVA: 0x003704F2 File Offset: 0x0036E6F2
		public IItemVariableBaseT AsIItemVariableBase()
		{
			return this.As<IItemVariableBaseT>();
		}

		// Token: 0x060181A6 RID: 98726 RVA: 0x003704FA File Offset: 0x0036E6FA
		public static IItemVariableBase_UnionUnion FromIItemVariableBase(IItemVariableBaseT _iitemvariablebase)
		{
			return new IItemVariableBase_UnionUnion
			{
				Type = IItemVariableBase_Union.IItemVariableBase,
				Value = _iitemvariablebase
			};
		}

		// Token: 0x060181A7 RID: 98727 RVA: 0x0037050F File Offset: 0x0036E70F
		public IItemIdVariableT AsIItemIdVariable()
		{
			return this.As<IItemIdVariableT>();
		}

		// Token: 0x060181A8 RID: 98728 RVA: 0x00370517 File Offset: 0x0036E717
		public static IItemVariableBase_UnionUnion FromIItemIdVariable(IItemIdVariableT _iitemidvariable)
		{
			return new IItemVariableBase_UnionUnion
			{
				Type = IItemVariableBase_Union.IItemIdVariable,
				Value = _iitemidvariable
			};
		}

		// Token: 0x060181A9 RID: 98729 RVA: 0x0037052C File Offset: 0x0036E72C
		public IItemTypeVariableT AsIItemTypeVariable()
		{
			return this.As<IItemTypeVariableT>();
		}

		// Token: 0x060181AA RID: 98730 RVA: 0x00370534 File Offset: 0x0036E734
		public static IItemVariableBase_UnionUnion FromIItemTypeVariable(IItemTypeVariableT _iitemtypevariable)
		{
			return new IItemVariableBase_UnionUnion
			{
				Type = IItemVariableBase_Union.IItemTypeVariable,
				Value = _iitemtypevariable
			};
		}

		// Token: 0x060181AB RID: 98731 RVA: 0x0037054C File Offset: 0x0036E74C
		public static int Pack(FlatBufferBuilder builder, IItemVariableBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IItemVariableBase_Union.IItemVariableBase:
				return IItemVariableBase.Pack(builder, _o.AsIItemVariableBase()).Value;
			case IItemVariableBase_Union.IItemIdVariable:
				return IItemIdVariable.Pack(builder, _o.AsIItemIdVariable()).Value;
			case IItemVariableBase_Union.IItemTypeVariable:
				return IItemTypeVariable.Pack(builder, _o.AsIItemTypeVariable()).Value;
			default:
				return 0;
			}
		}
	}
}
