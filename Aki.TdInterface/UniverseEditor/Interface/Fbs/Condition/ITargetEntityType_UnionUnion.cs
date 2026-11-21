using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F1 RID: 20977
	public class ITargetEntityType_UnionUnion
	{
		// Token: 0x1700962C RID: 38444
		// (get) Token: 0x06021087 RID: 135303 RVA: 0x00490C69 File Offset: 0x0048EE69
		// (set) Token: 0x06021088 RID: 135304 RVA: 0x00490C71 File Offset: 0x0048EE71
		public ITargetEntityType_Union Type { get; set; }

		// Token: 0x1700962D RID: 38445
		// (get) Token: 0x06021089 RID: 135305 RVA: 0x00490C7A File Offset: 0x0048EE7A
		// (set) Token: 0x0602108A RID: 135306 RVA: 0x00490C82 File Offset: 0x0048EE82
		public object Value { get; set; }

		// Token: 0x0602108B RID: 135307 RVA: 0x00490C8B File Offset: 0x0048EE8B
		public ITargetEntityType_UnionUnion()
		{
			this.Type = ITargetEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602108C RID: 135308 RVA: 0x00490CA1 File Offset: 0x0048EEA1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602108D RID: 135309 RVA: 0x00490CB3 File Offset: 0x0048EEB3
		public ITargetEntityTypeT AsITargetEntityType()
		{
			return this.As<ITargetEntityTypeT>();
		}

		// Token: 0x0602108E RID: 135310 RVA: 0x00490CBB File Offset: 0x0048EEBB
		public static ITargetEntityType_UnionUnion FromITargetEntityType(ITargetEntityTypeT _itargetentitytype)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntityType,
				Value = _itargetentitytype
			};
		}

		// Token: 0x0602108F RID: 135311 RVA: 0x00490CD0 File Offset: 0x0048EED0
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x06021090 RID: 135312 RVA: 0x00490CD8 File Offset: 0x0048EED8
		public static ITargetEntityType_UnionUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x06021091 RID: 135313 RVA: 0x00490CED File Offset: 0x0048EEED
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x06021092 RID: 135314 RVA: 0x00490CF5 File Offset: 0x0048EEF5
		public static ITargetEntityType_UnionUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x06021093 RID: 135315 RVA: 0x00490D0A File Offset: 0x0048EF0A
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x06021094 RID: 135316 RVA: 0x00490D12 File Offset: 0x0048EF12
		public static ITargetEntityType_UnionUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x06021095 RID: 135317 RVA: 0x00490D27 File Offset: 0x0048EF27
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x06021096 RID: 135318 RVA: 0x00490D2F File Offset: 0x0048EF2F
		public static ITargetEntityType_UnionUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new ITargetEntityType_UnionUnion
			{
				Type = ITargetEntityType_Union.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x06021097 RID: 135319 RVA: 0x00490D44 File Offset: 0x0048EF44
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
