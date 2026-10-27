using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC4 RID: 16068
	public class IItemVariableBase_UnionUnion
	{
		// Token: 0x17006F87 RID: 28551
		// (get) Token: 0x06016B52 RID: 93010 RVA: 0x00347520 File Offset: 0x00345720
		// (set) Token: 0x06016B53 RID: 93011 RVA: 0x00347528 File Offset: 0x00345728
		public IItemVariableBase_Union Type { get; set; }

		// Token: 0x17006F88 RID: 28552
		// (get) Token: 0x06016B54 RID: 93012 RVA: 0x00347531 File Offset: 0x00345731
		// (set) Token: 0x06016B55 RID: 93013 RVA: 0x00347539 File Offset: 0x00345739
		public object Value { get; set; }

		// Token: 0x06016B56 RID: 93014 RVA: 0x00347542 File Offset: 0x00345742
		public IItemVariableBase_UnionUnion()
		{
			this.Type = IItemVariableBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016B57 RID: 93015 RVA: 0x00347558 File Offset: 0x00345758
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016B58 RID: 93016 RVA: 0x0034756A File Offset: 0x0034576A
		public IItemVariableBaseT AsIItemVariableBase()
		{
			return this.As<IItemVariableBaseT>();
		}

		// Token: 0x06016B59 RID: 93017 RVA: 0x00347572 File Offset: 0x00345772
		public static IItemVariableBase_UnionUnion FromIItemVariableBase(IItemVariableBaseT _iitemvariablebase)
		{
			return new IItemVariableBase_UnionUnion
			{
				Type = IItemVariableBase_Union.IItemVariableBase,
				Value = _iitemvariablebase
			};
		}

		// Token: 0x06016B5A RID: 93018 RVA: 0x00347587 File Offset: 0x00345787
		public IItemIdVariableT AsIItemIdVariable()
		{
			return this.As<IItemIdVariableT>();
		}

		// Token: 0x06016B5B RID: 93019 RVA: 0x0034758F File Offset: 0x0034578F
		public static IItemVariableBase_UnionUnion FromIItemIdVariable(IItemIdVariableT _iitemidvariable)
		{
			return new IItemVariableBase_UnionUnion
			{
				Type = IItemVariableBase_Union.IItemIdVariable,
				Value = _iitemidvariable
			};
		}

		// Token: 0x06016B5C RID: 93020 RVA: 0x003475A4 File Offset: 0x003457A4
		public IItemTypeVariableT AsIItemTypeVariable()
		{
			return this.As<IItemTypeVariableT>();
		}

		// Token: 0x06016B5D RID: 93021 RVA: 0x003475AC File Offset: 0x003457AC
		public static IItemVariableBase_UnionUnion FromIItemTypeVariable(IItemTypeVariableT _iitemtypevariable)
		{
			return new IItemVariableBase_UnionUnion
			{
				Type = IItemVariableBase_Union.IItemTypeVariable,
				Value = _iitemtypevariable
			};
		}

		// Token: 0x06016B5E RID: 93022 RVA: 0x003475C4 File Offset: 0x003457C4
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
