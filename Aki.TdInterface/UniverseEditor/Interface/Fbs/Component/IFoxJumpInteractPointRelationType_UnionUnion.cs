using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005833 RID: 22579
	public class IFoxJumpInteractPointRelationType_UnionUnion
	{
		// Token: 0x1700A375 RID: 41845
		// (get) Token: 0x060248CF RID: 149711 RVA: 0x00505972 File Offset: 0x00503B72
		// (set) Token: 0x060248D0 RID: 149712 RVA: 0x0050597A File Offset: 0x00503B7A
		public IFoxJumpInteractPointRelationType_Union Type { get; set; }

		// Token: 0x1700A376 RID: 41846
		// (get) Token: 0x060248D1 RID: 149713 RVA: 0x00505983 File Offset: 0x00503B83
		// (set) Token: 0x060248D2 RID: 149714 RVA: 0x0050598B File Offset: 0x00503B8B
		public object Value { get; set; }

		// Token: 0x060248D3 RID: 149715 RVA: 0x00505994 File Offset: 0x00503B94
		public IFoxJumpInteractPointRelationType_UnionUnion()
		{
			this.Type = IFoxJumpInteractPointRelationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060248D4 RID: 149716 RVA: 0x005059AA File Offset: 0x00503BAA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060248D5 RID: 149717 RVA: 0x005059BC File Offset: 0x00503BBC
		public IFoxJumpInteractPointRelationTypeT AsIFoxJumpInteractPointRelationType()
		{
			return this.As<IFoxJumpInteractPointRelationTypeT>();
		}

		// Token: 0x060248D6 RID: 149718 RVA: 0x005059C4 File Offset: 0x00503BC4
		public static IFoxJumpInteractPointRelationType_UnionUnion FromIFoxJumpInteractPointRelationType(IFoxJumpInteractPointRelationTypeT _ifoxjumpinteractpointrelationtype)
		{
			return new IFoxJumpInteractPointRelationType_UnionUnion
			{
				Type = IFoxJumpInteractPointRelationType_Union.IFoxJumpInteractPointRelationType,
				Value = _ifoxjumpinteractpointrelationtype
			};
		}

		// Token: 0x060248D7 RID: 149719 RVA: 0x005059D9 File Offset: 0x00503BD9
		public IFoxJumpPositionOnThisEntityT AsIFoxJumpPositionOnThisEntity()
		{
			return this.As<IFoxJumpPositionOnThisEntityT>();
		}

		// Token: 0x060248D8 RID: 149720 RVA: 0x005059E1 File Offset: 0x00503BE1
		public static IFoxJumpInteractPointRelationType_UnionUnion FromIFoxJumpPositionOnThisEntity(IFoxJumpPositionOnThisEntityT _ifoxjumppositiononthisentity)
		{
			return new IFoxJumpInteractPointRelationType_UnionUnion
			{
				Type = IFoxJumpInteractPointRelationType_Union.IFoxJumpPositionOnThisEntity,
				Value = _ifoxjumppositiononthisentity
			};
		}

		// Token: 0x060248D9 RID: 149721 RVA: 0x005059F6 File Offset: 0x00503BF6
		public IFoxJumpPositionOnPathDrivenSpawnedActorT AsIFoxJumpPositionOnPathDrivenSpawnedActor()
		{
			return this.As<IFoxJumpPositionOnPathDrivenSpawnedActorT>();
		}

		// Token: 0x060248DA RID: 149722 RVA: 0x005059FE File Offset: 0x00503BFE
		public static IFoxJumpInteractPointRelationType_UnionUnion FromIFoxJumpPositionOnPathDrivenSpawnedActor(IFoxJumpPositionOnPathDrivenSpawnedActorT _ifoxjumppositiononpathdrivenspawnedactor)
		{
			return new IFoxJumpInteractPointRelationType_UnionUnion
			{
				Type = IFoxJumpInteractPointRelationType_Union.IFoxJumpPositionOnPathDrivenSpawnedActor,
				Value = _ifoxjumppositiononpathdrivenspawnedactor
			};
		}

		// Token: 0x060248DB RID: 149723 RVA: 0x00505A14 File Offset: 0x00503C14
		public static int Pack(FlatBufferBuilder builder, IFoxJumpInteractPointRelationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFoxJumpInteractPointRelationType_Union.IFoxJumpInteractPointRelationType:
				return IFoxJumpInteractPointRelationType.Pack(builder, _o.AsIFoxJumpInteractPointRelationType()).Value;
			case IFoxJumpInteractPointRelationType_Union.IFoxJumpPositionOnThisEntity:
				return IFoxJumpPositionOnThisEntity.Pack(builder, _o.AsIFoxJumpPositionOnThisEntity()).Value;
			case IFoxJumpInteractPointRelationType_Union.IFoxJumpPositionOnPathDrivenSpawnedActor:
				return IFoxJumpPositionOnPathDrivenSpawnedActor.Pack(builder, _o.AsIFoxJumpPositionOnPathDrivenSpawnedActor()).Value;
			default:
				return 0;
			}
		}
	}
}
