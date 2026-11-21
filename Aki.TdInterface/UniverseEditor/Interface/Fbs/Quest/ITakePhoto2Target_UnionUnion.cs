using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045FC RID: 17916
	public class ITakePhoto2Target_UnionUnion
	{
		// Token: 0x17007D54 RID: 32084
		// (get) Token: 0x0601A300 RID: 107264 RVA: 0x003BAD81 File Offset: 0x003B8F81
		// (set) Token: 0x0601A301 RID: 107265 RVA: 0x003BAD89 File Offset: 0x003B8F89
		public ITakePhoto2Target_Union Type { get; set; }

		// Token: 0x17007D55 RID: 32085
		// (get) Token: 0x0601A302 RID: 107266 RVA: 0x003BAD92 File Offset: 0x003B8F92
		// (set) Token: 0x0601A303 RID: 107267 RVA: 0x003BAD9A File Offset: 0x003B8F9A
		public object Value { get; set; }

		// Token: 0x0601A304 RID: 107268 RVA: 0x003BADA3 File Offset: 0x003B8FA3
		public ITakePhoto2Target_UnionUnion()
		{
			this.Type = ITakePhoto2Target_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A305 RID: 107269 RVA: 0x003BADB9 File Offset: 0x003B8FB9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A306 RID: 107270 RVA: 0x003BADCB File Offset: 0x003B8FCB
		public ITakePhoto2TargetT AsITakePhoto2Target()
		{
			return this.As<ITakePhoto2TargetT>();
		}

		// Token: 0x0601A307 RID: 107271 RVA: 0x003BADD3 File Offset: 0x003B8FD3
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2Target(ITakePhoto2TargetT _itakephoto2target)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2Target,
				Value = _itakephoto2target
			};
		}

		// Token: 0x0601A308 RID: 107272 RVA: 0x003BADE8 File Offset: 0x003B8FE8
		public ITakePhoto2EntityTargetT AsITakePhoto2EntityTarget()
		{
			return this.As<ITakePhoto2EntityTargetT>();
		}

		// Token: 0x0601A309 RID: 107273 RVA: 0x003BADF0 File Offset: 0x003B8FF0
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2EntityTarget(ITakePhoto2EntityTargetT _itakephoto2entitytarget)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2EntityTarget,
				Value = _itakephoto2entitytarget
			};
		}

		// Token: 0x0601A30A RID: 107274 RVA: 0x003BAE05 File Offset: 0x003B9005
		public ITakePhoto2PhotoTargetEntityTargetT AsITakePhoto2PhotoTargetEntityTarget()
		{
			return this.As<ITakePhoto2PhotoTargetEntityTargetT>();
		}

		// Token: 0x0601A30B RID: 107275 RVA: 0x003BAE0D File Offset: 0x003B900D
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2PhotoTargetEntityTarget(ITakePhoto2PhotoTargetEntityTargetT _itakephoto2phototargetentitytarget)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2PhotoTargetEntityTarget,
				Value = _itakephoto2phototargetentitytarget
			};
		}

		// Token: 0x0601A30C RID: 107276 RVA: 0x003BAE22 File Offset: 0x003B9022
		public ITakePhoto2TargetEntityTypeT AsITakePhoto2TargetEntityType()
		{
			return this.As<ITakePhoto2TargetEntityTypeT>();
		}

		// Token: 0x0601A30D RID: 107277 RVA: 0x003BAE2A File Offset: 0x003B902A
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2TargetEntityType(ITakePhoto2TargetEntityTypeT _itakephoto2targetentitytype)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2TargetEntityType,
				Value = _itakephoto2targetentitytype
			};
		}

		// Token: 0x0601A30E RID: 107278 RVA: 0x003BAE3F File Offset: 0x003B903F
		public ITakePhoto2TaggedActorTargetT AsITakePhoto2TaggedActorTarget()
		{
			return this.As<ITakePhoto2TaggedActorTargetT>();
		}

		// Token: 0x0601A30F RID: 107279 RVA: 0x003BAE47 File Offset: 0x003B9047
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2TaggedActorTarget(ITakePhoto2TaggedActorTargetT _itakephoto2taggedactortarget)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2TaggedActorTarget,
				Value = _itakephoto2taggedactortarget
			};
		}

		// Token: 0x0601A310 RID: 107280 RVA: 0x003BAE5C File Offset: 0x003B905C
		public static int Pack(FlatBufferBuilder builder, ITakePhoto2Target_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITakePhoto2Target_Union.ITakePhoto2Target:
				return ITakePhoto2Target.Pack(builder, _o.AsITakePhoto2Target()).Value;
			case ITakePhoto2Target_Union.ITakePhoto2EntityTarget:
				return ITakePhoto2EntityTarget.Pack(builder, _o.AsITakePhoto2EntityTarget()).Value;
			case ITakePhoto2Target_Union.ITakePhoto2PhotoTargetEntityTarget:
				return ITakePhoto2PhotoTargetEntityTarget.Pack(builder, _o.AsITakePhoto2PhotoTargetEntityTarget()).Value;
			case ITakePhoto2Target_Union.ITakePhoto2TargetEntityType:
				return ITakePhoto2TargetEntityType.Pack(builder, _o.AsITakePhoto2TargetEntityType()).Value;
			case ITakePhoto2Target_Union.ITakePhoto2TaggedActorTarget:
				return ITakePhoto2TaggedActorTarget.Pack(builder, _o.AsITakePhoto2TaggedActorTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
