using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004251 RID: 16977
	public class IEventTypeConfig_UnionUnion
	{
		// Token: 0x170073BE RID: 29630
		// (get) Token: 0x06017A11 RID: 96785 RVA: 0x0035EA99 File Offset: 0x0035CC99
		// (set) Token: 0x06017A12 RID: 96786 RVA: 0x0035EAA1 File Offset: 0x0035CCA1
		public IEventTypeConfig_Union Type { get; set; }

		// Token: 0x170073BF RID: 29631
		// (get) Token: 0x06017A13 RID: 96787 RVA: 0x0035EAAA File Offset: 0x0035CCAA
		// (set) Token: 0x06017A14 RID: 96788 RVA: 0x0035EAB2 File Offset: 0x0035CCB2
		public object Value { get; set; }

		// Token: 0x06017A15 RID: 96789 RVA: 0x0035EABB File Offset: 0x0035CCBB
		public IEventTypeConfig_UnionUnion()
		{
			this.Type = IEventTypeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017A16 RID: 96790 RVA: 0x0035EAD1 File Offset: 0x0035CCD1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017A17 RID: 96791 RVA: 0x0035EAE3 File Offset: 0x0035CCE3
		public IEventTypeConfigT AsIEventTypeConfig()
		{
			return this.As<IEventTypeConfigT>();
		}

		// Token: 0x06017A18 RID: 96792 RVA: 0x0035EAEB File Offset: 0x0035CCEB
		public static IEventTypeConfig_UnionUnion FromIEventTypeConfig(IEventTypeConfigT _ieventtypeconfig)
		{
			return new IEventTypeConfig_UnionUnion
			{
				Type = IEventTypeConfig_Union.IEventTypeConfig,
				Value = _ieventtypeconfig
			};
		}

		// Token: 0x06017A19 RID: 96793 RVA: 0x0035EB00 File Offset: 0x0035CD00
		public ICommonEventVarValueChangeT AsICommonEventVarValueChange()
		{
			return this.As<ICommonEventVarValueChangeT>();
		}

		// Token: 0x06017A1A RID: 96794 RVA: 0x0035EB08 File Offset: 0x0035CD08
		public static IEventTypeConfig_UnionUnion FromICommonEventVarValueChange(ICommonEventVarValueChangeT _icommoneventvarvaluechange)
		{
			return new IEventTypeConfig_UnionUnion
			{
				Type = IEventTypeConfig_Union.ICommonEventVarValueChange,
				Value = _icommoneventvarvaluechange
			};
		}

		// Token: 0x06017A1B RID: 96795 RVA: 0x0035EB1D File Offset: 0x0035CD1D
		public ICommonEventEntityStateChangeT AsICommonEventEntityStateChange()
		{
			return this.As<ICommonEventEntityStateChangeT>();
		}

		// Token: 0x06017A1C RID: 96796 RVA: 0x0035EB25 File Offset: 0x0035CD25
		public static IEventTypeConfig_UnionUnion FromICommonEventEntityStateChange(ICommonEventEntityStateChangeT _icommonevententitystatechange)
		{
			return new IEventTypeConfig_UnionUnion
			{
				Type = IEventTypeConfig_Union.ICommonEventEntityStateChange,
				Value = _icommonevententitystatechange
			};
		}

		// Token: 0x06017A1D RID: 96797 RVA: 0x0035EB3C File Offset: 0x0035CD3C
		public static int Pack(FlatBufferBuilder builder, IEventTypeConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEventTypeConfig_Union.IEventTypeConfig:
				return IEventTypeConfig.Pack(builder, _o.AsIEventTypeConfig()).Value;
			case IEventTypeConfig_Union.ICommonEventVarValueChange:
				return ICommonEventVarValueChange.Pack(builder, _o.AsICommonEventVarValueChange()).Value;
			case IEventTypeConfig_Union.ICommonEventEntityStateChange:
				return ICommonEventEntityStateChange.Pack(builder, _o.AsICommonEventEntityStateChange()).Value;
			default:
				return 0;
			}
		}
	}
}
