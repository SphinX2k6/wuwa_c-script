using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A3 RID: 16803
	public class ITakePhoto2Target_UnionUnion
	{
		// Token: 0x17007728 RID: 30504
		// (get) Token: 0x06018BAA RID: 101290 RVA: 0x0038F92D File Offset: 0x0038DB2D
		// (set) Token: 0x06018BAB RID: 101291 RVA: 0x0038F935 File Offset: 0x0038DB35
		public ITakePhoto2Target_Union Type { get; set; }

		// Token: 0x17007729 RID: 30505
		// (get) Token: 0x06018BAC RID: 101292 RVA: 0x0038F93E File Offset: 0x0038DB3E
		// (set) Token: 0x06018BAD RID: 101293 RVA: 0x0038F946 File Offset: 0x0038DB46
		public object Value { get; set; }

		// Token: 0x06018BAE RID: 101294 RVA: 0x0038F94F File Offset: 0x0038DB4F
		public ITakePhoto2Target_UnionUnion()
		{
			this.Type = ITakePhoto2Target_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018BAF RID: 101295 RVA: 0x0038F965 File Offset: 0x0038DB65
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018BB0 RID: 101296 RVA: 0x0038F977 File Offset: 0x0038DB77
		public ITakePhoto2TargetT AsITakePhoto2Target()
		{
			return this.As<ITakePhoto2TargetT>();
		}

		// Token: 0x06018BB1 RID: 101297 RVA: 0x0038F97F File Offset: 0x0038DB7F
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2Target(ITakePhoto2TargetT _itakephoto2target)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2Target,
				Value = _itakephoto2target
			};
		}

		// Token: 0x06018BB2 RID: 101298 RVA: 0x0038F994 File Offset: 0x0038DB94
		public ITakePhoto2EntityTargetT AsITakePhoto2EntityTarget()
		{
			return this.As<ITakePhoto2EntityTargetT>();
		}

		// Token: 0x06018BB3 RID: 101299 RVA: 0x0038F99C File Offset: 0x0038DB9C
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2EntityTarget(ITakePhoto2EntityTargetT _itakephoto2entitytarget)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2EntityTarget,
				Value = _itakephoto2entitytarget
			};
		}

		// Token: 0x06018BB4 RID: 101300 RVA: 0x0038F9B1 File Offset: 0x0038DBB1
		public ITakePhoto2PhotoTargetEntityTargetT AsITakePhoto2PhotoTargetEntityTarget()
		{
			return this.As<ITakePhoto2PhotoTargetEntityTargetT>();
		}

		// Token: 0x06018BB5 RID: 101301 RVA: 0x0038F9B9 File Offset: 0x0038DBB9
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2PhotoTargetEntityTarget(ITakePhoto2PhotoTargetEntityTargetT _itakephoto2phototargetentitytarget)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2PhotoTargetEntityTarget,
				Value = _itakephoto2phototargetentitytarget
			};
		}

		// Token: 0x06018BB6 RID: 101302 RVA: 0x0038F9CE File Offset: 0x0038DBCE
		public ITakePhoto2TargetEntityTypeT AsITakePhoto2TargetEntityType()
		{
			return this.As<ITakePhoto2TargetEntityTypeT>();
		}

		// Token: 0x06018BB7 RID: 101303 RVA: 0x0038F9D6 File Offset: 0x0038DBD6
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2TargetEntityType(ITakePhoto2TargetEntityTypeT _itakephoto2targetentitytype)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2TargetEntityType,
				Value = _itakephoto2targetentitytype
			};
		}

		// Token: 0x06018BB8 RID: 101304 RVA: 0x0038F9EB File Offset: 0x0038DBEB
		public ITakePhoto2TaggedActorTargetT AsITakePhoto2TaggedActorTarget()
		{
			return this.As<ITakePhoto2TaggedActorTargetT>();
		}

		// Token: 0x06018BB9 RID: 101305 RVA: 0x0038F9F3 File Offset: 0x0038DBF3
		public static ITakePhoto2Target_UnionUnion FromITakePhoto2TaggedActorTarget(ITakePhoto2TaggedActorTargetT _itakephoto2taggedactortarget)
		{
			return new ITakePhoto2Target_UnionUnion
			{
				Type = ITakePhoto2Target_Union.ITakePhoto2TaggedActorTarget,
				Value = _itakephoto2taggedactortarget
			};
		}

		// Token: 0x06018BBA RID: 101306 RVA: 0x0038FA08 File Offset: 0x0038DC08
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
