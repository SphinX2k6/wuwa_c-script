using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BEF RID: 23535
	public class INpcSpecialMarkBase_UnionUnion
	{
		// Token: 0x1700AC34 RID: 44084
		// (get) Token: 0x06026DD6 RID: 159190 RVA: 0x00552235 File Offset: 0x00550435
		// (set) Token: 0x06026DD7 RID: 159191 RVA: 0x0055223D File Offset: 0x0055043D
		public INpcSpecialMarkBase_Union Type { get; set; }

		// Token: 0x1700AC35 RID: 44085
		// (get) Token: 0x06026DD8 RID: 159192 RVA: 0x00552246 File Offset: 0x00550446
		// (set) Token: 0x06026DD9 RID: 159193 RVA: 0x0055224E File Offset: 0x0055044E
		public object Value { get; set; }

		// Token: 0x06026DDA RID: 159194 RVA: 0x00552257 File Offset: 0x00550457
		public INpcSpecialMarkBase_UnionUnion()
		{
			this.Type = INpcSpecialMarkBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026DDB RID: 159195 RVA: 0x0055226D File Offset: 0x0055046D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026DDC RID: 159196 RVA: 0x0055227F File Offset: 0x0055047F
		public INpcSpecialMarkBaseT AsINpcSpecialMarkBase()
		{
			return this.As<INpcSpecialMarkBaseT>();
		}

		// Token: 0x06026DDD RID: 159197 RVA: 0x00552287 File Offset: 0x00550487
		public static INpcSpecialMarkBase_UnionUnion FromINpcSpecialMarkBase(INpcSpecialMarkBaseT _inpcspecialmarkbase)
		{
			return new INpcSpecialMarkBase_UnionUnion
			{
				Type = INpcSpecialMarkBase_Union.INpcSpecialMarkBase,
				Value = _inpcspecialmarkbase
			};
		}

		// Token: 0x06026DDE RID: 159198 RVA: 0x0055229C File Offset: 0x0055049C
		public INpcSpecialMarkTrafficLightT AsINpcSpecialMarkTrafficLight()
		{
			return this.As<INpcSpecialMarkTrafficLightT>();
		}

		// Token: 0x06026DDF RID: 159199 RVA: 0x005522A4 File Offset: 0x005504A4
		public static INpcSpecialMarkBase_UnionUnion FromINpcSpecialMarkTrafficLight(INpcSpecialMarkTrafficLightT _inpcspecialmarktrafficlight)
		{
			return new INpcSpecialMarkBase_UnionUnion
			{
				Type = INpcSpecialMarkBase_Union.INpcSpecialMarkTrafficLight,
				Value = _inpcspecialmarktrafficlight
			};
		}

		// Token: 0x06026DE0 RID: 159200 RVA: 0x005522B9 File Offset: 0x005504B9
		public INpcSpecialMarkIgnoreCameraHideNpcT AsINpcSpecialMarkIgnoreCameraHideNpc()
		{
			return this.As<INpcSpecialMarkIgnoreCameraHideNpcT>();
		}

		// Token: 0x06026DE1 RID: 159201 RVA: 0x005522C1 File Offset: 0x005504C1
		public static INpcSpecialMarkBase_UnionUnion FromINpcSpecialMarkIgnoreCameraHideNpc(INpcSpecialMarkIgnoreCameraHideNpcT _inpcspecialmarkignorecamerahidenpc)
		{
			return new INpcSpecialMarkBase_UnionUnion
			{
				Type = INpcSpecialMarkBase_Union.INpcSpecialMarkIgnoreCameraHideNpc,
				Value = _inpcspecialmarkignorecamerahidenpc
			};
		}

		// Token: 0x06026DE2 RID: 159202 RVA: 0x005522D6 File Offset: 0x005504D6
		public INpcSpecialMarkTriggerBlueprintFootprintEventT AsINpcSpecialMarkTriggerBlueprintFootprintEvent()
		{
			return this.As<INpcSpecialMarkTriggerBlueprintFootprintEventT>();
		}

		// Token: 0x06026DE3 RID: 159203 RVA: 0x005522DE File Offset: 0x005504DE
		public static INpcSpecialMarkBase_UnionUnion FromINpcSpecialMarkTriggerBlueprintFootprintEvent(INpcSpecialMarkTriggerBlueprintFootprintEventT _inpcspecialmarktriggerblueprintfootprintevent)
		{
			return new INpcSpecialMarkBase_UnionUnion
			{
				Type = INpcSpecialMarkBase_Union.INpcSpecialMarkTriggerBlueprintFootprintEvent,
				Value = _inpcspecialmarktriggerblueprintfootprintevent
			};
		}

		// Token: 0x06026DE4 RID: 159204 RVA: 0x005522F4 File Offset: 0x005504F4
		public static int Pack(FlatBufferBuilder builder, INpcSpecialMarkBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcSpecialMarkBase_Union.INpcSpecialMarkBase:
				return INpcSpecialMarkBase.Pack(builder, _o.AsINpcSpecialMarkBase()).Value;
			case INpcSpecialMarkBase_Union.INpcSpecialMarkTrafficLight:
				return INpcSpecialMarkTrafficLight.Pack(builder, _o.AsINpcSpecialMarkTrafficLight()).Value;
			case INpcSpecialMarkBase_Union.INpcSpecialMarkIgnoreCameraHideNpc:
				return INpcSpecialMarkIgnoreCameraHideNpc.Pack(builder, _o.AsINpcSpecialMarkIgnoreCameraHideNpc()).Value;
			case INpcSpecialMarkBase_Union.INpcSpecialMarkTriggerBlueprintFootprintEvent:
				return INpcSpecialMarkTriggerBlueprintFootprintEvent.Pack(builder, _o.AsINpcSpecialMarkTriggerBlueprintFootprintEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
