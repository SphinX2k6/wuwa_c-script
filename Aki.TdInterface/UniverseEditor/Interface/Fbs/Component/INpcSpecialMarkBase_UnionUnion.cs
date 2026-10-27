using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005651 RID: 22097
	public class INpcSpecialMarkBase_UnionUnion
	{
		// Token: 0x1700A3AA RID: 41898
		// (get) Token: 0x06024BB7 RID: 150455 RVA: 0x00511911 File Offset: 0x0050FB11
		// (set) Token: 0x06024BB8 RID: 150456 RVA: 0x00511919 File Offset: 0x0050FB19
		public INpcSpecialMarkBase_Union Type { get; set; }

		// Token: 0x1700A3AB RID: 41899
		// (get) Token: 0x06024BB9 RID: 150457 RVA: 0x00511922 File Offset: 0x0050FB22
		// (set) Token: 0x06024BBA RID: 150458 RVA: 0x0051192A File Offset: 0x0050FB2A
		public object Value { get; set; }

		// Token: 0x06024BBB RID: 150459 RVA: 0x00511933 File Offset: 0x0050FB33
		public INpcSpecialMarkBase_UnionUnion()
		{
			this.Type = INpcSpecialMarkBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024BBC RID: 150460 RVA: 0x00511949 File Offset: 0x0050FB49
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024BBD RID: 150461 RVA: 0x0051195B File Offset: 0x0050FB5B
		public INpcSpecialMarkBaseT AsINpcSpecialMarkBase()
		{
			return this.As<INpcSpecialMarkBaseT>();
		}

		// Token: 0x06024BBE RID: 150462 RVA: 0x00511963 File Offset: 0x0050FB63
		public static INpcSpecialMarkBase_UnionUnion FromINpcSpecialMarkBase(INpcSpecialMarkBaseT _inpcspecialmarkbase)
		{
			return new INpcSpecialMarkBase_UnionUnion
			{
				Type = INpcSpecialMarkBase_Union.INpcSpecialMarkBase,
				Value = _inpcspecialmarkbase
			};
		}

		// Token: 0x06024BBF RID: 150463 RVA: 0x00511978 File Offset: 0x0050FB78
		public INpcSpecialMarkTrafficLightT AsINpcSpecialMarkTrafficLight()
		{
			return this.As<INpcSpecialMarkTrafficLightT>();
		}

		// Token: 0x06024BC0 RID: 150464 RVA: 0x00511980 File Offset: 0x0050FB80
		public static INpcSpecialMarkBase_UnionUnion FromINpcSpecialMarkTrafficLight(INpcSpecialMarkTrafficLightT _inpcspecialmarktrafficlight)
		{
			return new INpcSpecialMarkBase_UnionUnion
			{
				Type = INpcSpecialMarkBase_Union.INpcSpecialMarkTrafficLight,
				Value = _inpcspecialmarktrafficlight
			};
		}

		// Token: 0x06024BC1 RID: 150465 RVA: 0x00511995 File Offset: 0x0050FB95
		public INpcSpecialMarkIgnoreCameraHideNpcT AsINpcSpecialMarkIgnoreCameraHideNpc()
		{
			return this.As<INpcSpecialMarkIgnoreCameraHideNpcT>();
		}

		// Token: 0x06024BC2 RID: 150466 RVA: 0x0051199D File Offset: 0x0050FB9D
		public static INpcSpecialMarkBase_UnionUnion FromINpcSpecialMarkIgnoreCameraHideNpc(INpcSpecialMarkIgnoreCameraHideNpcT _inpcspecialmarkignorecamerahidenpc)
		{
			return new INpcSpecialMarkBase_UnionUnion
			{
				Type = INpcSpecialMarkBase_Union.INpcSpecialMarkIgnoreCameraHideNpc,
				Value = _inpcspecialmarkignorecamerahidenpc
			};
		}

		// Token: 0x06024BC3 RID: 150467 RVA: 0x005119B4 File Offset: 0x0050FBB4
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
			default:
				return 0;
			}
		}
	}
}
