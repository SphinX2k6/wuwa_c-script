using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C8 RID: 21192
	public class IFoxJumpInteractPointRelationType_UnionUnion
	{
		// Token: 0x17009B6C RID: 39788
		// (get) Token: 0x0602290B RID: 141579 RVA: 0x004CA876 File Offset: 0x004C8A76
		// (set) Token: 0x0602290C RID: 141580 RVA: 0x004CA87E File Offset: 0x004C8A7E
		public IFoxJumpInteractPointRelationType_Union Type { get; set; }

		// Token: 0x17009B6D RID: 39789
		// (get) Token: 0x0602290D RID: 141581 RVA: 0x004CA887 File Offset: 0x004C8A87
		// (set) Token: 0x0602290E RID: 141582 RVA: 0x004CA88F File Offset: 0x004C8A8F
		public object Value { get; set; }

		// Token: 0x0602290F RID: 141583 RVA: 0x004CA898 File Offset: 0x004C8A98
		public IFoxJumpInteractPointRelationType_UnionUnion()
		{
			this.Type = IFoxJumpInteractPointRelationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022910 RID: 141584 RVA: 0x004CA8AE File Offset: 0x004C8AAE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022911 RID: 141585 RVA: 0x004CA8C0 File Offset: 0x004C8AC0
		public IFoxJumpInteractPointRelationTypeT AsIFoxJumpInteractPointRelationType()
		{
			return this.As<IFoxJumpInteractPointRelationTypeT>();
		}

		// Token: 0x06022912 RID: 141586 RVA: 0x004CA8C8 File Offset: 0x004C8AC8
		public static IFoxJumpInteractPointRelationType_UnionUnion FromIFoxJumpInteractPointRelationType(IFoxJumpInteractPointRelationTypeT _ifoxjumpinteractpointrelationtype)
		{
			return new IFoxJumpInteractPointRelationType_UnionUnion
			{
				Type = IFoxJumpInteractPointRelationType_Union.IFoxJumpInteractPointRelationType,
				Value = _ifoxjumpinteractpointrelationtype
			};
		}

		// Token: 0x06022913 RID: 141587 RVA: 0x004CA8DD File Offset: 0x004C8ADD
		public IFoxJumpPositionOnThisEntityT AsIFoxJumpPositionOnThisEntity()
		{
			return this.As<IFoxJumpPositionOnThisEntityT>();
		}

		// Token: 0x06022914 RID: 141588 RVA: 0x004CA8E5 File Offset: 0x004C8AE5
		public static IFoxJumpInteractPointRelationType_UnionUnion FromIFoxJumpPositionOnThisEntity(IFoxJumpPositionOnThisEntityT _ifoxjumppositiononthisentity)
		{
			return new IFoxJumpInteractPointRelationType_UnionUnion
			{
				Type = IFoxJumpInteractPointRelationType_Union.IFoxJumpPositionOnThisEntity,
				Value = _ifoxjumppositiononthisentity
			};
		}

		// Token: 0x06022915 RID: 141589 RVA: 0x004CA8FA File Offset: 0x004C8AFA
		public IFoxJumpPositionOnPathDrivenSpawnedActorT AsIFoxJumpPositionOnPathDrivenSpawnedActor()
		{
			return this.As<IFoxJumpPositionOnPathDrivenSpawnedActorT>();
		}

		// Token: 0x06022916 RID: 141590 RVA: 0x004CA902 File Offset: 0x004C8B02
		public static IFoxJumpInteractPointRelationType_UnionUnion FromIFoxJumpPositionOnPathDrivenSpawnedActor(IFoxJumpPositionOnPathDrivenSpawnedActorT _ifoxjumppositiononpathdrivenspawnedactor)
		{
			return new IFoxJumpInteractPointRelationType_UnionUnion
			{
				Type = IFoxJumpInteractPointRelationType_Union.IFoxJumpPositionOnPathDrivenSpawnedActor,
				Value = _ifoxjumppositiononpathdrivenspawnedactor
			};
		}

		// Token: 0x06022917 RID: 141591 RVA: 0x004CA918 File Offset: 0x004C8B18
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
