using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004738 RID: 18232
	public class TItemVariableUnion
	{
		// Token: 0x17007F7B RID: 32635
		// (get) Token: 0x0601AD99 RID: 109977 RVA: 0x003CFAC0 File Offset: 0x003CDCC0
		// (set) Token: 0x0601AD9A RID: 109978 RVA: 0x003CFAC8 File Offset: 0x003CDCC8
		public TItemVariable Type { get; set; }

		// Token: 0x17007F7C RID: 32636
		// (get) Token: 0x0601AD9B RID: 109979 RVA: 0x003CFAD1 File Offset: 0x003CDCD1
		// (set) Token: 0x0601AD9C RID: 109980 RVA: 0x003CFAD9 File Offset: 0x003CDCD9
		public object Value { get; set; }

		// Token: 0x0601AD9D RID: 109981 RVA: 0x003CFAE2 File Offset: 0x003CDCE2
		public TItemVariableUnion()
		{
			this.Type = TItemVariable.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD9E RID: 109982 RVA: 0x003CFAF8 File Offset: 0x003CDCF8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD9F RID: 109983 RVA: 0x003CFB0A File Offset: 0x003CDD0A
		public IItemIdVariableT AsIItemIdVariable()
		{
			return this.As<IItemIdVariableT>();
		}

		// Token: 0x0601ADA0 RID: 109984 RVA: 0x003CFB12 File Offset: 0x003CDD12
		public static TItemVariableUnion FromIItemIdVariable(IItemIdVariableT _iitemidvariable)
		{
			return new TItemVariableUnion
			{
				Type = TItemVariable.IItemIdVariable,
				Value = _iitemidvariable
			};
		}

		// Token: 0x0601ADA1 RID: 109985 RVA: 0x003CFB27 File Offset: 0x003CDD27
		public IItemTypeVariableT AsIItemTypeVariable()
		{
			return this.As<IItemTypeVariableT>();
		}

		// Token: 0x0601ADA2 RID: 109986 RVA: 0x003CFB2F File Offset: 0x003CDD2F
		public static TItemVariableUnion FromIItemTypeVariable(IItemTypeVariableT _iitemtypevariable)
		{
			return new TItemVariableUnion
			{
				Type = TItemVariable.IItemTypeVariable,
				Value = _iitemtypevariable
			};
		}

		// Token: 0x0601ADA3 RID: 109987 RVA: 0x003CFB44 File Offset: 0x003CDD44
		public static int Pack(FlatBufferBuilder builder, TItemVariableUnion _o)
		{
			TItemVariable type = _o.Type;
			if (type == TItemVariable.IItemIdVariable)
			{
				return IItemIdVariable.Pack(builder, _o.AsIItemIdVariable()).Value;
			}
			if (type != TItemVariable.IItemTypeVariable)
			{
				return 0;
			}
			return IItemTypeVariable.Pack(builder, _o.AsIItemTypeVariable()).Value;
		}
	}
}
