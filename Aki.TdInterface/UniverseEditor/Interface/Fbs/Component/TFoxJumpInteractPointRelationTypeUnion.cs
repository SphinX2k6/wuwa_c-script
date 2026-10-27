using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C28 RID: 23592
	public class TFoxJumpInteractPointRelationTypeUnion
	{
		// Token: 0x1700B1F8 RID: 45560
		// (get) Token: 0x06028747 RID: 165703 RVA: 0x00591250 File Offset: 0x0058F450
		// (set) Token: 0x06028748 RID: 165704 RVA: 0x00591258 File Offset: 0x0058F458
		public TFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x1700B1F9 RID: 45561
		// (get) Token: 0x06028749 RID: 165705 RVA: 0x00591261 File Offset: 0x0058F461
		// (set) Token: 0x0602874A RID: 165706 RVA: 0x00591269 File Offset: 0x0058F469
		public object Value { get; set; }

		// Token: 0x0602874B RID: 165707 RVA: 0x00591272 File Offset: 0x0058F472
		public TFoxJumpInteractPointRelationTypeUnion()
		{
			this.Type = TFoxJumpInteractPointRelationType.NONE;
			this.Value = null;
		}

		// Token: 0x0602874C RID: 165708 RVA: 0x00591288 File Offset: 0x0058F488
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602874D RID: 165709 RVA: 0x0059129A File Offset: 0x0058F49A
		public IFoxJumpPositionOnPathDrivenSpawnedActorT AsIFoxJumpPositionOnPathDrivenSpawnedActor()
		{
			return this.As<IFoxJumpPositionOnPathDrivenSpawnedActorT>();
		}

		// Token: 0x0602874E RID: 165710 RVA: 0x005912A2 File Offset: 0x0058F4A2
		public static TFoxJumpInteractPointRelationTypeUnion FromIFoxJumpPositionOnPathDrivenSpawnedActor(IFoxJumpPositionOnPathDrivenSpawnedActorT _ifoxjumppositiononpathdrivenspawnedactor)
		{
			return new TFoxJumpInteractPointRelationTypeUnion
			{
				Type = TFoxJumpInteractPointRelationType.IFoxJumpPositionOnPathDrivenSpawnedActor,
				Value = _ifoxjumppositiononpathdrivenspawnedactor
			};
		}

		// Token: 0x0602874F RID: 165711 RVA: 0x005912B7 File Offset: 0x0058F4B7
		public IFoxJumpPositionOnThisEntityT AsIFoxJumpPositionOnThisEntity()
		{
			return this.As<IFoxJumpPositionOnThisEntityT>();
		}

		// Token: 0x06028750 RID: 165712 RVA: 0x005912BF File Offset: 0x0058F4BF
		public static TFoxJumpInteractPointRelationTypeUnion FromIFoxJumpPositionOnThisEntity(IFoxJumpPositionOnThisEntityT _ifoxjumppositiononthisentity)
		{
			return new TFoxJumpInteractPointRelationTypeUnion
			{
				Type = TFoxJumpInteractPointRelationType.IFoxJumpPositionOnThisEntity,
				Value = _ifoxjumppositiononthisentity
			};
		}

		// Token: 0x06028751 RID: 165713 RVA: 0x005912D4 File Offset: 0x0058F4D4
		public static int Pack(FlatBufferBuilder builder, TFoxJumpInteractPointRelationTypeUnion _o)
		{
			TFoxJumpInteractPointRelationType type = _o.Type;
			if (type == TFoxJumpInteractPointRelationType.IFoxJumpPositionOnPathDrivenSpawnedActor)
			{
				return IFoxJumpPositionOnPathDrivenSpawnedActor.Pack(builder, _o.AsIFoxJumpPositionOnPathDrivenSpawnedActor()).Value;
			}
			if (type != TFoxJumpInteractPointRelationType.IFoxJumpPositionOnThisEntity)
			{
				return 0;
			}
			return IFoxJumpPositionOnThisEntity.Pack(builder, _o.AsIFoxJumpPositionOnThisEntity()).Value;
		}
	}
}
