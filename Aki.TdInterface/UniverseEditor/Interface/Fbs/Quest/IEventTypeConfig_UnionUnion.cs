using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E16 RID: 15894
	public class IEventTypeConfig_UnionUnion
	{
		// Token: 0x17006DD8 RID: 28120
		// (get) Token: 0x060163E4 RID: 91108 RVA: 0x00335EA1 File Offset: 0x003340A1
		// (set) Token: 0x060163E5 RID: 91109 RVA: 0x00335EA9 File Offset: 0x003340A9
		public IEventTypeConfig_Union Type { get; set; }

		// Token: 0x17006DD9 RID: 28121
		// (get) Token: 0x060163E6 RID: 91110 RVA: 0x00335EB2 File Offset: 0x003340B2
		// (set) Token: 0x060163E7 RID: 91111 RVA: 0x00335EBA File Offset: 0x003340BA
		public object Value { get; set; }

		// Token: 0x060163E8 RID: 91112 RVA: 0x00335EC3 File Offset: 0x003340C3
		public IEventTypeConfig_UnionUnion()
		{
			this.Type = IEventTypeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060163E9 RID: 91113 RVA: 0x00335ED9 File Offset: 0x003340D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060163EA RID: 91114 RVA: 0x00335EEB File Offset: 0x003340EB
		public IEventTypeConfigT AsIEventTypeConfig()
		{
			return this.As<IEventTypeConfigT>();
		}

		// Token: 0x060163EB RID: 91115 RVA: 0x00335EF3 File Offset: 0x003340F3
		public static IEventTypeConfig_UnionUnion FromIEventTypeConfig(IEventTypeConfigT _ieventtypeconfig)
		{
			return new IEventTypeConfig_UnionUnion
			{
				Type = IEventTypeConfig_Union.IEventTypeConfig,
				Value = _ieventtypeconfig
			};
		}

		// Token: 0x060163EC RID: 91116 RVA: 0x00335F08 File Offset: 0x00334108
		public ICommonEventVarValueChangeT AsICommonEventVarValueChange()
		{
			return this.As<ICommonEventVarValueChangeT>();
		}

		// Token: 0x060163ED RID: 91117 RVA: 0x00335F10 File Offset: 0x00334110
		public static IEventTypeConfig_UnionUnion FromICommonEventVarValueChange(ICommonEventVarValueChangeT _icommoneventvarvaluechange)
		{
			return new IEventTypeConfig_UnionUnion
			{
				Type = IEventTypeConfig_Union.ICommonEventVarValueChange,
				Value = _icommoneventvarvaluechange
			};
		}

		// Token: 0x060163EE RID: 91118 RVA: 0x00335F25 File Offset: 0x00334125
		public ICommonEventEntityStateChangeT AsICommonEventEntityStateChange()
		{
			return this.As<ICommonEventEntityStateChangeT>();
		}

		// Token: 0x060163EF RID: 91119 RVA: 0x00335F2D File Offset: 0x0033412D
		public static IEventTypeConfig_UnionUnion FromICommonEventEntityStateChange(ICommonEventEntityStateChangeT _icommonevententitystatechange)
		{
			return new IEventTypeConfig_UnionUnion
			{
				Type = IEventTypeConfig_Union.ICommonEventEntityStateChange,
				Value = _icommonevententitystatechange
			};
		}

		// Token: 0x060163F0 RID: 91120 RVA: 0x00335F44 File Offset: 0x00334144
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
