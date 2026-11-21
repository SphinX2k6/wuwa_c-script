using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BC RID: 21436
	public class IAkEventTypeConfig_UnionUnion
	{
		// Token: 0x170097A2 RID: 38818
		// (get) Token: 0x06021763 RID: 137059 RVA: 0x0049DA29 File Offset: 0x0049BC29
		// (set) Token: 0x06021764 RID: 137060 RVA: 0x0049DA31 File Offset: 0x0049BC31
		public IAkEventTypeConfig_Union Type { get; set; }

		// Token: 0x170097A3 RID: 38819
		// (get) Token: 0x06021765 RID: 137061 RVA: 0x0049DA3A File Offset: 0x0049BC3A
		// (set) Token: 0x06021766 RID: 137062 RVA: 0x0049DA42 File Offset: 0x0049BC42
		public object Value { get; set; }

		// Token: 0x06021767 RID: 137063 RVA: 0x0049DA4B File Offset: 0x0049BC4B
		public IAkEventTypeConfig_UnionUnion()
		{
			this.Type = IAkEventTypeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021768 RID: 137064 RVA: 0x0049DA61 File Offset: 0x0049BC61
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021769 RID: 137065 RVA: 0x0049DA73 File Offset: 0x0049BC73
		public IAkEventTypeConfigT AsIAkEventTypeConfig()
		{
			return this.As<IAkEventTypeConfigT>();
		}

		// Token: 0x0602176A RID: 137066 RVA: 0x0049DA7B File Offset: 0x0049BC7B
		public static IAkEventTypeConfig_UnionUnion FromIAkEventTypeConfig(IAkEventTypeConfigT _iakeventtypeconfig)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IAkEventTypeConfig,
				Value = _iakeventtypeconfig
			};
		}

		// Token: 0x0602176B RID: 137067 RVA: 0x0049DA90 File Offset: 0x0049BC90
		public IPointAkEventT AsIPointAkEvent()
		{
			return this.As<IPointAkEventT>();
		}

		// Token: 0x0602176C RID: 137068 RVA: 0x0049DA98 File Offset: 0x0049BC98
		public static IAkEventTypeConfig_UnionUnion FromIPointAkEvent(IPointAkEventT _ipointakevent)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IPointAkEvent,
				Value = _ipointakevent
			};
		}

		// Token: 0x0602176D RID: 137069 RVA: 0x0049DAAD File Offset: 0x0049BCAD
		public IBoxAkEventT AsIBoxAkEvent()
		{
			return this.As<IBoxAkEventT>();
		}

		// Token: 0x0602176E RID: 137070 RVA: 0x0049DAB5 File Offset: 0x0049BCB5
		public static IAkEventTypeConfig_UnionUnion FromIBoxAkEvent(IBoxAkEventT _iboxakevent)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IBoxAkEvent,
				Value = _iboxakevent
			};
		}

		// Token: 0x0602176F RID: 137071 RVA: 0x0049DACA File Offset: 0x0049BCCA
		public IDefaultAkEventT AsIDefaultAkEvent()
		{
			return this.As<IDefaultAkEventT>();
		}

		// Token: 0x06021770 RID: 137072 RVA: 0x0049DAD2 File Offset: 0x0049BCD2
		public static IAkEventTypeConfig_UnionUnion FromIDefaultAkEvent(IDefaultAkEventT _idefaultakevent)
		{
			return new IAkEventTypeConfig_UnionUnion
			{
				Type = IAkEventTypeConfig_Union.IDefaultAkEvent,
				Value = _idefaultakevent
			};
		}

		// Token: 0x06021771 RID: 137073 RVA: 0x0049DAE8 File Offset: 0x0049BCE8
		public static int Pack(FlatBufferBuilder builder, IAkEventTypeConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAkEventTypeConfig_Union.IAkEventTypeConfig:
				return IAkEventTypeConfig.Pack(builder, _o.AsIAkEventTypeConfig()).Value;
			case IAkEventTypeConfig_Union.IPointAkEvent:
				return IPointAkEvent.Pack(builder, _o.AsIPointAkEvent()).Value;
			case IAkEventTypeConfig_Union.IBoxAkEvent:
				return IBoxAkEvent.Pack(builder, _o.AsIBoxAkEvent()).Value;
			case IAkEventTypeConfig_Union.IDefaultAkEvent:
				return IDefaultAkEvent.Pack(builder, _o.AsIDefaultAkEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
