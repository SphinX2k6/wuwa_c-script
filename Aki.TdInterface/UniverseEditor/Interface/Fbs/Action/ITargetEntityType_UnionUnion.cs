using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007362 RID: 29538
	public class ITargetEntityType_UnionUnion
	{
		// Token: 0x1700E04D RID: 57421
		// (get) Token: 0x060359C2 RID: 219586 RVA: 0x0074D0F1 File Offset: 0x0074B2F1
		// (set) Token: 0x060359C3 RID: 219587 RVA: 0x0074D0F9 File Offset: 0x0074B2F9
		public ITargetEntityType_Union Type { get; set; }

		// Token: 0x1700E04E RID: 57422
		// (get) Token: 0x060359C4 RID: 219588 RVA: 0x0074D102 File Offset: 0x0074B302
		// (set) Token: 0x060359C5 RID: 219589 RVA: 0x0074D10A File Offset: 0x0074B30A
		public object Value { get; set; }

		// Token: 0x060359C6 RID: 219590 RVA: 0x0074D113 File Offset: 0x0074B313
		public ITargetEntityType_UnionUnion()
		{
			this.Type = ITargetEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060359C7 RID: 219591 RVA: 0x0074D129 File Offset: 0x0074B329
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060359C8 RID: 219592 RVA: 0x0074D13B File Offset: 0x0074B33B
		public ITargetEntityTypeT AsITargetEntityType()
		{
			return this.As<ITargetEntityTypeT>();
		}

		// Token: 0x060359C9 RID: 219593 RVA: 0x0074D143 File Offset: 0x0074B343
		public static ITargetEntityType_UnionUnion FromITargetEntityType(ITargetEntityTypeT _itargetentitytype)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntityType,
				Value = _itargetentitytype
			};
		}

		// Token: 0x060359CA RID: 219594 RVA: 0x0074D158 File Offset: 0x0074B358
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x060359CB RID: 219595 RVA: 0x0074D160 File Offset: 0x0074B360
		public static ITargetEntityType_UnionUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x060359CC RID: 219596 RVA: 0x0074D175 File Offset: 0x0074B375
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x060359CD RID: 219597 RVA: 0x0074D17D File Offset: 0x0074B37D
		public static ITargetEntityType_UnionUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x060359CE RID: 219598 RVA: 0x0074D192 File Offset: 0x0074B392
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x060359CF RID: 219599 RVA: 0x0074D19A File Offset: 0x0074B39A
		public static ITargetEntityType_UnionUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x060359D0 RID: 219600 RVA: 0x0074D1AF File Offset: 0x0074B3AF
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x060359D1 RID: 219601 RVA: 0x0074D1B7 File Offset: 0x0074B3B7
		public static ITargetEntityType_UnionUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x060359D2 RID: 219602 RVA: 0x0074D1CC File Offset: 0x0074B3CC
		public IVehicleEntityT AsIVehicleEntity()
		{
			return this.As<IVehicleEntityT>();
		}

		// Token: 0x060359D3 RID: 219603 RVA: 0x0074D1D4 File Offset: 0x0074B3D4
		public static ITargetEntityType_UnionUnion FromIVehicleEntity(IVehicleEntityT _ivehicleentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.IVehicleEntity,
				Value = _ivehicleentity
			};
		}

		// Token: 0x060359D4 RID: 219604 RVA: 0x0074D1EC File Offset: 0x0074B3EC
		public static int Pack(FlatBufferBuilder builder, ITargetEntityType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITargetEntityType_Union.ITargetEntityType:
				return ITargetEntityType.Pack(builder, _o.AsITargetEntityType()).Value;
			case ITargetEntityType_Union.ITargetEntity:
				return ITargetEntity.Pack(builder, _o.AsITargetEntity()).Value;
			case ITargetEntityType_Union.ISelfEntity:
				return ISelfEntity.Pack(builder, _o.AsISelfEntity()).Value;
			case ITargetEntityType_Union.ITriggeredEntity:
				return ITriggeredEntity.Pack(builder, _o.AsITriggeredEntity()).Value;
			case ITargetEntityType_Union.IPlayerEntity:
				return IPlayerEntity.Pack(builder, _o.AsIPlayerEntity()).Value;
			case ITargetEntityType_Union.IVehicleEntity:
				return IVehicleEntity.Pack(builder, _o.AsIVehicleEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
