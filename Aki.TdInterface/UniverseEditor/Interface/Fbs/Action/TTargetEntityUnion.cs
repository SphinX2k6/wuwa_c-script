using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CF RID: 30671
	public class TTargetEntityUnion
	{
		// Token: 0x1700E6CD RID: 59085
		// (get) Token: 0x06037A2C RID: 227884 RVA: 0x007863FA File Offset: 0x007845FA
		// (set) Token: 0x06037A2D RID: 227885 RVA: 0x00786402 File Offset: 0x00784602
		public TTargetEntity Type { get; set; }

		// Token: 0x1700E6CE RID: 59086
		// (get) Token: 0x06037A2E RID: 227886 RVA: 0x0078640B File Offset: 0x0078460B
		// (set) Token: 0x06037A2F RID: 227887 RVA: 0x00786413 File Offset: 0x00784613
		public object Value { get; set; }

		// Token: 0x06037A30 RID: 227888 RVA: 0x0078641C File Offset: 0x0078461C
		public TTargetEntityUnion()
		{
			this.Type = TTargetEntity.NONE;
			this.Value = null;
		}

		// Token: 0x06037A31 RID: 227889 RVA: 0x00786432 File Offset: 0x00784632
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A32 RID: 227890 RVA: 0x00786444 File Offset: 0x00784644
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x06037A33 RID: 227891 RVA: 0x0078644C File Offset: 0x0078464C
		public static TTargetEntityUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x06037A34 RID: 227892 RVA: 0x00786461 File Offset: 0x00784661
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x06037A35 RID: 227893 RVA: 0x00786469 File Offset: 0x00784669
		public static TTargetEntityUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x06037A36 RID: 227894 RVA: 0x0078647E File Offset: 0x0078467E
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x06037A37 RID: 227895 RVA: 0x00786486 File Offset: 0x00784686
		public static TTargetEntityUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x06037A38 RID: 227896 RVA: 0x0078649B File Offset: 0x0078469B
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x06037A39 RID: 227897 RVA: 0x007864A3 File Offset: 0x007846A3
		public static TTargetEntityUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x06037A3A RID: 227898 RVA: 0x007864B8 File Offset: 0x007846B8
		public IVehicleEntityT AsIVehicleEntity()
		{
			return this.As<IVehicleEntityT>();
		}

		// Token: 0x06037A3B RID: 227899 RVA: 0x007864C0 File Offset: 0x007846C0
		public static TTargetEntityUnion FromIVehicleEntity(IVehicleEntityT _ivehicleentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.IVehicleEntity,
				Value = _ivehicleentity
			};
		}

		// Token: 0x06037A3C RID: 227900 RVA: 0x007864D8 File Offset: 0x007846D8
		public static int Pack(FlatBufferBuilder builder, TTargetEntityUnion _o)
		{
			switch (_o.Type)
			{
			case TTargetEntity.IPlayerEntity:
				return IPlayerEntity.Pack(builder, _o.AsIPlayerEntity()).Value;
			case TTargetEntity.ISelfEntity:
				return ISelfEntity.Pack(builder, _o.AsISelfEntity()).Value;
			case TTargetEntity.ITargetEntity:
				return ITargetEntity.Pack(builder, _o.AsITargetEntity()).Value;
			case TTargetEntity.ITriggeredEntity:
				return ITriggeredEntity.Pack(builder, _o.AsITriggeredEntity()).Value;
			case TTargetEntity.IVehicleEntity:
				return IVehicleEntity.Pack(builder, _o.AsIVehicleEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
