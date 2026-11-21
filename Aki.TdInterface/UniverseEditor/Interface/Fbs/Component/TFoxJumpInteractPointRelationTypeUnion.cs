using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006247 RID: 25159
	public class TFoxJumpInteractPointRelationTypeUnion
	{
		// Token: 0x1700BB46 RID: 47942
		// (get) Token: 0x0602AD39 RID: 175417 RVA: 0x005D91E0 File Offset: 0x005D73E0
		// (set) Token: 0x0602AD3A RID: 175418 RVA: 0x005D91E8 File Offset: 0x005D73E8
		public TFoxJumpInteractPointRelationType Type { get; set; }

		// Token: 0x1700BB47 RID: 47943
		// (get) Token: 0x0602AD3B RID: 175419 RVA: 0x005D91F1 File Offset: 0x005D73F1
		// (set) Token: 0x0602AD3C RID: 175420 RVA: 0x005D91F9 File Offset: 0x005D73F9
		public object Value { get; set; }

		// Token: 0x0602AD3D RID: 175421 RVA: 0x005D9202 File Offset: 0x005D7402
		public TFoxJumpInteractPointRelationTypeUnion()
		{
			this.Type = TFoxJumpInteractPointRelationType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD3E RID: 175422 RVA: 0x005D9218 File Offset: 0x005D7418
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD3F RID: 175423 RVA: 0x005D922A File Offset: 0x005D742A
		public IFoxJumpPositionOnPathDrivenSpawnedActorT AsIFoxJumpPositionOnPathDrivenSpawnedActor()
		{
			return this.As<IFoxJumpPositionOnPathDrivenSpawnedActorT>();
		}

		// Token: 0x0602AD40 RID: 175424 RVA: 0x005D9232 File Offset: 0x005D7432
		public static TFoxJumpInteractPointRelationTypeUnion FromIFoxJumpPositionOnPathDrivenSpawnedActor(IFoxJumpPositionOnPathDrivenSpawnedActorT _ifoxjumppositiononpathdrivenspawnedactor)
		{
			return new TFoxJumpInteractPointRelationTypeUnion
			{
				Type = TFoxJumpInteractPointRelationType.IFoxJumpPositionOnPathDrivenSpawnedActor,
				Value = _ifoxjumppositiononpathdrivenspawnedactor
			};
		}

		// Token: 0x0602AD41 RID: 175425 RVA: 0x005D9247 File Offset: 0x005D7447
		public IFoxJumpPositionOnThisEntityT AsIFoxJumpPositionOnThisEntity()
		{
			return this.As<IFoxJumpPositionOnThisEntityT>();
		}

		// Token: 0x0602AD42 RID: 175426 RVA: 0x005D924F File Offset: 0x005D744F
		public static TFoxJumpInteractPointRelationTypeUnion FromIFoxJumpPositionOnThisEntity(IFoxJumpPositionOnThisEntityT _ifoxjumppositiononthisentity)
		{
			return new TFoxJumpInteractPointRelationTypeUnion
			{
				Type = TFoxJumpInteractPointRelationType.IFoxJumpPositionOnThisEntity,
				Value = _ifoxjumppositiononthisentity
			};
		}

		// Token: 0x0602AD43 RID: 175427 RVA: 0x005D9264 File Offset: 0x005D7464
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
