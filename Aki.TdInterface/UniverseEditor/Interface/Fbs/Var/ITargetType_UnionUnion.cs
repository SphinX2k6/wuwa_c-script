using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EED RID: 16109
	public class ITargetType_UnionUnion
	{
		// Token: 0x17006D0E RID: 27918
		// (get) Token: 0x06015D70 RID: 89456 RVA: 0x0032432D File Offset: 0x0032252D
		// (set) Token: 0x06015D71 RID: 89457 RVA: 0x00324335 File Offset: 0x00322535
		public ITargetType_Union Type { get; set; }

		// Token: 0x17006D0F RID: 27919
		// (get) Token: 0x06015D72 RID: 89458 RVA: 0x0032433E File Offset: 0x0032253E
		// (set) Token: 0x06015D73 RID: 89459 RVA: 0x00324346 File Offset: 0x00322546
		public object Value { get; set; }

		// Token: 0x06015D74 RID: 89460 RVA: 0x0032434F File Offset: 0x0032254F
		public ITargetType_UnionUnion()
		{
			this.Type = ITargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015D75 RID: 89461 RVA: 0x00324365 File Offset: 0x00322565
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015D76 RID: 89462 RVA: 0x00324377 File Offset: 0x00322577
		public ITargetTypeT AsITargetType()
		{
			return this.As<ITargetTypeT>();
		}

		// Token: 0x06015D77 RID: 89463 RVA: 0x0032437F File Offset: 0x0032257F
		public static ITargetType_UnionUnion FromITargetType(ITargetTypeT _itargettype)
		{
			return new ITargetType_UnionUnion
			{
				Type = ITargetType_Union.ITargetType,
				Value = _itargettype
			};
		}

		// Token: 0x06015D78 RID: 89464 RVA: 0x00324394 File Offset: 0x00322594
		public ITargetPlayT AsITargetPlay()
		{
			return this.As<ITargetPlayT>();
		}

		// Token: 0x06015D79 RID: 89465 RVA: 0x0032439C File Offset: 0x0032259C
		public static ITargetType_UnionUnion FromITargetPlay(ITargetPlayT _itargetplay)
		{
			return new ITargetType_UnionUnion
			{
				Type = ITargetType_Union.ITargetPlay,
				Value = _itargetplay
			};
		}

		// Token: 0x06015D7A RID: 89466 RVA: 0x003243B1 File Offset: 0x003225B1
		public ITargetLevelEntityT AsITargetLevelEntity()
		{
			return this.As<ITargetLevelEntityT>();
		}

		// Token: 0x06015D7B RID: 89467 RVA: 0x003243B9 File Offset: 0x003225B9
		public static ITargetType_UnionUnion FromITargetLevelEntity(ITargetLevelEntityT _itargetlevelentity)
		{
			return new ITargetType_UnionUnion
			{
				Type = ITargetType_Union.ITargetLevelEntity,
				Value = _itargetlevelentity
			};
		}

		// Token: 0x06015D7C RID: 89468 RVA: 0x003243D0 File Offset: 0x003225D0
		public static int Pack(FlatBufferBuilder builder, ITargetType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITargetType_Union.ITargetType:
				return ITargetType.Pack(builder, _o.AsITargetType()).Value;
			case ITargetType_Union.ITargetPlay:
				return ITargetPlay.Pack(builder, _o.AsITargetPlay()).Value;
			case ITargetType_Union.ITargetLevelEntity:
				return ITargetLevelEntity.Pack(builder, _o.AsITargetLevelEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
