using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200629E RID: 25246
	public class TNpcSpecialMarkUnion
	{
		// Token: 0x1700BB80 RID: 48000
		// (get) Token: 0x0602AEF9 RID: 175865 RVA: 0x005DBC06 File Offset: 0x005D9E06
		// (set) Token: 0x0602AEFA RID: 175866 RVA: 0x005DBC0E File Offset: 0x005D9E0E
		public TNpcSpecialMark Type { get; set; }

		// Token: 0x1700BB81 RID: 48001
		// (get) Token: 0x0602AEFB RID: 175867 RVA: 0x005DBC17 File Offset: 0x005D9E17
		// (set) Token: 0x0602AEFC RID: 175868 RVA: 0x005DBC1F File Offset: 0x005D9E1F
		public object Value { get; set; }

		// Token: 0x0602AEFD RID: 175869 RVA: 0x005DBC28 File Offset: 0x005D9E28
		public TNpcSpecialMarkUnion()
		{
			this.Type = TNpcSpecialMark.NONE;
			this.Value = null;
		}

		// Token: 0x0602AEFE RID: 175870 RVA: 0x005DBC3E File Offset: 0x005D9E3E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AEFF RID: 175871 RVA: 0x005DBC50 File Offset: 0x005D9E50
		public INpcSpecialMarkIgnoreCameraHideNpcT AsINpcSpecialMarkIgnoreCameraHideNpc()
		{
			return this.As<INpcSpecialMarkIgnoreCameraHideNpcT>();
		}

		// Token: 0x0602AF00 RID: 175872 RVA: 0x005DBC58 File Offset: 0x005D9E58
		public static TNpcSpecialMarkUnion FromINpcSpecialMarkIgnoreCameraHideNpc(INpcSpecialMarkIgnoreCameraHideNpcT _inpcspecialmarkignorecamerahidenpc)
		{
			return new TNpcSpecialMarkUnion
			{
				Type = TNpcSpecialMark.INpcSpecialMarkIgnoreCameraHideNpc,
				Value = _inpcspecialmarkignorecamerahidenpc
			};
		}

		// Token: 0x0602AF01 RID: 175873 RVA: 0x005DBC6D File Offset: 0x005D9E6D
		public INpcSpecialMarkTrafficLightT AsINpcSpecialMarkTrafficLight()
		{
			return this.As<INpcSpecialMarkTrafficLightT>();
		}

		// Token: 0x0602AF02 RID: 175874 RVA: 0x005DBC75 File Offset: 0x005D9E75
		public static TNpcSpecialMarkUnion FromINpcSpecialMarkTrafficLight(INpcSpecialMarkTrafficLightT _inpcspecialmarktrafficlight)
		{
			return new TNpcSpecialMarkUnion
			{
				Type = TNpcSpecialMark.INpcSpecialMarkTrafficLight,
				Value = _inpcspecialmarktrafficlight
			};
		}

		// Token: 0x0602AF03 RID: 175875 RVA: 0x005DBC8A File Offset: 0x005D9E8A
		public INpcSpecialMarkTriggerBlueprintFootprintEventT AsINpcSpecialMarkTriggerBlueprintFootprintEvent()
		{
			return this.As<INpcSpecialMarkTriggerBlueprintFootprintEventT>();
		}

		// Token: 0x0602AF04 RID: 175876 RVA: 0x005DBC92 File Offset: 0x005D9E92
		public static TNpcSpecialMarkUnion FromINpcSpecialMarkTriggerBlueprintFootprintEvent(INpcSpecialMarkTriggerBlueprintFootprintEventT _inpcspecialmarktriggerblueprintfootprintevent)
		{
			return new TNpcSpecialMarkUnion
			{
				Type = TNpcSpecialMark.INpcSpecialMarkTriggerBlueprintFootprintEvent,
				Value = _inpcspecialmarktriggerblueprintfootprintevent
			};
		}

		// Token: 0x0602AF05 RID: 175877 RVA: 0x005DBCA8 File Offset: 0x005D9EA8
		public static int Pack(FlatBufferBuilder builder, TNpcSpecialMarkUnion _o)
		{
			switch (_o.Type)
			{
			case TNpcSpecialMark.INpcSpecialMarkIgnoreCameraHideNpc:
				return INpcSpecialMarkIgnoreCameraHideNpc.Pack(builder, _o.AsINpcSpecialMarkIgnoreCameraHideNpc()).Value;
			case TNpcSpecialMark.INpcSpecialMarkTrafficLight:
				return INpcSpecialMarkTrafficLight.Pack(builder, _o.AsINpcSpecialMarkTrafficLight()).Value;
			case TNpcSpecialMark.INpcSpecialMarkTriggerBlueprintFootprintEvent:
				return INpcSpecialMarkTriggerBlueprintFootprintEvent.Pack(builder, _o.AsINpcSpecialMarkTriggerBlueprintFootprintEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
