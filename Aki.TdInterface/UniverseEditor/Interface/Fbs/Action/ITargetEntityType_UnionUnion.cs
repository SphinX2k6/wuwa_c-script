using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B3D RID: 31549
	public class ITargetEntityType_UnionUnion
	{
		// Token: 0x1700EC4E RID: 60494
		// (get) Token: 0x06038D0B RID: 232715 RVA: 0x007AEEC5 File Offset: 0x007AD0C5
		// (set) Token: 0x06038D0C RID: 232716 RVA: 0x007AEECD File Offset: 0x007AD0CD
		public ITargetEntityType_Union Type { get; set; }

		// Token: 0x1700EC4F RID: 60495
		// (get) Token: 0x06038D0D RID: 232717 RVA: 0x007AEED6 File Offset: 0x007AD0D6
		// (set) Token: 0x06038D0E RID: 232718 RVA: 0x007AEEDE File Offset: 0x007AD0DE
		public object Value { get; set; }

		// Token: 0x06038D0F RID: 232719 RVA: 0x007AEEE7 File Offset: 0x007AD0E7
		public ITargetEntityType_UnionUnion()
		{
			this.Type = ITargetEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038D10 RID: 232720 RVA: 0x007AEEFD File Offset: 0x007AD0FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038D11 RID: 232721 RVA: 0x007AEF0F File Offset: 0x007AD10F
		public ITargetEntityTypeT AsITargetEntityType()
		{
			return this.As<ITargetEntityTypeT>();
		}

		// Token: 0x06038D12 RID: 232722 RVA: 0x007AEF17 File Offset: 0x007AD117
		public static ITargetEntityType_UnionUnion FromITargetEntityType(ITargetEntityTypeT _itargetentitytype)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntityType,
				Value = _itargetentitytype
			};
		}

		// Token: 0x06038D13 RID: 232723 RVA: 0x007AEF2C File Offset: 0x007AD12C
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x06038D14 RID: 232724 RVA: 0x007AEF34 File Offset: 0x007AD134
		public static ITargetEntityType_UnionUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x06038D15 RID: 232725 RVA: 0x007AEF49 File Offset: 0x007AD149
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x06038D16 RID: 232726 RVA: 0x007AEF51 File Offset: 0x007AD151
		public static ITargetEntityType_UnionUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x06038D17 RID: 232727 RVA: 0x007AEF66 File Offset: 0x007AD166
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x06038D18 RID: 232728 RVA: 0x007AEF6E File Offset: 0x007AD16E
		public static ITargetEntityType_UnionUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x06038D19 RID: 232729 RVA: 0x007AEF83 File Offset: 0x007AD183
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x06038D1A RID: 232730 RVA: 0x007AEF8B File Offset: 0x007AD18B
		public static ITargetEntityType_UnionUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x06038D1B RID: 232731 RVA: 0x007AEFA0 File Offset: 0x007AD1A0
		public IVehicleEntityT AsIVehicleEntity()
		{
			return this.As<IVehicleEntityT>();
		}

		// Token: 0x06038D1C RID: 232732 RVA: 0x007AEFA8 File Offset: 0x007AD1A8
		public static ITargetEntityType_UnionUnion FromIVehicleEntity(IVehicleEntityT _ivehicleentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.IVehicleEntity,
				Value = _ivehicleentity
			};
		}

		// Token: 0x06038D1D RID: 232733 RVA: 0x007AEFC0 File Offset: 0x007AD1C0
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
