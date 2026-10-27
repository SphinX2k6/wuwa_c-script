using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CF5 RID: 19701
	public class ITargetEntityType_UnionUnion
	{
		// Token: 0x17008EF3 RID: 36595
		// (get) Token: 0x0601F442 RID: 128066 RVA: 0x0045CD19 File Offset: 0x0045AF19
		// (set) Token: 0x0601F443 RID: 128067 RVA: 0x0045CD21 File Offset: 0x0045AF21
		public ITargetEntityType_Union Type { get; set; }

		// Token: 0x17008EF4 RID: 36596
		// (get) Token: 0x0601F444 RID: 128068 RVA: 0x0045CD2A File Offset: 0x0045AF2A
		// (set) Token: 0x0601F445 RID: 128069 RVA: 0x0045CD32 File Offset: 0x0045AF32
		public object Value { get; set; }

		// Token: 0x0601F446 RID: 128070 RVA: 0x0045CD3B File Offset: 0x0045AF3B
		public ITargetEntityType_UnionUnion()
		{
			this.Type = ITargetEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F447 RID: 128071 RVA: 0x0045CD51 File Offset: 0x0045AF51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F448 RID: 128072 RVA: 0x0045CD63 File Offset: 0x0045AF63
		public ITargetEntityTypeT AsITargetEntityType()
		{
			return this.As<ITargetEntityTypeT>();
		}

		// Token: 0x0601F449 RID: 128073 RVA: 0x0045CD6B File Offset: 0x0045AF6B
		public static ITargetEntityType_UnionUnion FromITargetEntityType(ITargetEntityTypeT _itargetentitytype)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntityType,
				Value = _itargetentitytype
			};
		}

		// Token: 0x0601F44A RID: 128074 RVA: 0x0045CD80 File Offset: 0x0045AF80
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x0601F44B RID: 128075 RVA: 0x0045CD88 File Offset: 0x0045AF88
		public static ITargetEntityType_UnionUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x0601F44C RID: 128076 RVA: 0x0045CD9D File Offset: 0x0045AF9D
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x0601F44D RID: 128077 RVA: 0x0045CDA5 File Offset: 0x0045AFA5
		public static ITargetEntityType_UnionUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x0601F44E RID: 128078 RVA: 0x0045CDBA File Offset: 0x0045AFBA
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x0601F44F RID: 128079 RVA: 0x0045CDC2 File Offset: 0x0045AFC2
		public static ITargetEntityType_UnionUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x0601F450 RID: 128080 RVA: 0x0045CDD7 File Offset: 0x0045AFD7
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x0601F451 RID: 128081 RVA: 0x0045CDDF File Offset: 0x0045AFDF
		public static ITargetEntityType_UnionUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x0601F452 RID: 128082 RVA: 0x0045CDF4 File Offset: 0x0045AFF4
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
			default:
				return 0;
			}
		}
	}
}
