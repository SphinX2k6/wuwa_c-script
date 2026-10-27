using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431E RID: 17182
	public class TTakePhoto2TargetConfigUnion
	{
		// Token: 0x17007976 RID: 31094
		// (get) Token: 0x060197B5 RID: 104373 RVA: 0x003A6A90 File Offset: 0x003A4C90
		// (set) Token: 0x060197B6 RID: 104374 RVA: 0x003A6A98 File Offset: 0x003A4C98
		public TTakePhoto2TargetConfig Type { get; set; }

		// Token: 0x17007977 RID: 31095
		// (get) Token: 0x060197B7 RID: 104375 RVA: 0x003A6AA1 File Offset: 0x003A4CA1
		// (set) Token: 0x060197B8 RID: 104376 RVA: 0x003A6AA9 File Offset: 0x003A4CA9
		public object Value { get; set; }

		// Token: 0x060197B9 RID: 104377 RVA: 0x003A6AB2 File Offset: 0x003A4CB2
		public TTakePhoto2TargetConfigUnion()
		{
			this.Type = TTakePhoto2TargetConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060197BA RID: 104378 RVA: 0x003A6AC8 File Offset: 0x003A4CC8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060197BB RID: 104379 RVA: 0x003A6ADA File Offset: 0x003A4CDA
		public ITakePhoto2EntityTargetT AsITakePhoto2EntityTarget()
		{
			return this.As<ITakePhoto2EntityTargetT>();
		}

		// Token: 0x060197BC RID: 104380 RVA: 0x003A6AE2 File Offset: 0x003A4CE2
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2EntityTarget(ITakePhoto2EntityTargetT _itakephoto2entitytarget)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2EntityTarget,
				Value = _itakephoto2entitytarget
			};
		}

		// Token: 0x060197BD RID: 104381 RVA: 0x003A6AF7 File Offset: 0x003A4CF7
		public ITakePhoto2PhotoTargetEntityTargetT AsITakePhoto2PhotoTargetEntityTarget()
		{
			return this.As<ITakePhoto2PhotoTargetEntityTargetT>();
		}

		// Token: 0x060197BE RID: 104382 RVA: 0x003A6AFF File Offset: 0x003A4CFF
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2PhotoTargetEntityTarget(ITakePhoto2PhotoTargetEntityTargetT _itakephoto2phototargetentitytarget)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2PhotoTargetEntityTarget,
				Value = _itakephoto2phototargetentitytarget
			};
		}

		// Token: 0x060197BF RID: 104383 RVA: 0x003A6B14 File Offset: 0x003A4D14
		public ITakePhoto2TaggedActorTargetT AsITakePhoto2TaggedActorTarget()
		{
			return this.As<ITakePhoto2TaggedActorTargetT>();
		}

		// Token: 0x060197C0 RID: 104384 RVA: 0x003A6B1C File Offset: 0x003A4D1C
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2TaggedActorTarget(ITakePhoto2TaggedActorTargetT _itakephoto2taggedactortarget)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2TaggedActorTarget,
				Value = _itakephoto2taggedactortarget
			};
		}

		// Token: 0x060197C1 RID: 104385 RVA: 0x003A6B31 File Offset: 0x003A4D31
		public ITakePhoto2TargetEntityTypeT AsITakePhoto2TargetEntityType()
		{
			return this.As<ITakePhoto2TargetEntityTypeT>();
		}

		// Token: 0x060197C2 RID: 104386 RVA: 0x003A6B39 File Offset: 0x003A4D39
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2TargetEntityType(ITakePhoto2TargetEntityTypeT _itakephoto2targetentitytype)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2TargetEntityType,
				Value = _itakephoto2targetentitytype
			};
		}

		// Token: 0x060197C3 RID: 104387 RVA: 0x003A6B50 File Offset: 0x003A4D50
		public static int Pack(FlatBufferBuilder builder, TTakePhoto2TargetConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TTakePhoto2TargetConfig.ITakePhoto2EntityTarget:
				return ITakePhoto2EntityTarget.Pack(builder, _o.AsITakePhoto2EntityTarget()).Value;
			case TTakePhoto2TargetConfig.ITakePhoto2PhotoTargetEntityTarget:
				return ITakePhoto2PhotoTargetEntityTarget.Pack(builder, _o.AsITakePhoto2PhotoTargetEntityTarget()).Value;
			case TTakePhoto2TargetConfig.ITakePhoto2TaggedActorTarget:
				return ITakePhoto2TaggedActorTarget.Pack(builder, _o.AsITakePhoto2TaggedActorTarget()).Value;
			case TTakePhoto2TargetConfig.ITakePhoto2TargetEntityType:
				return ITakePhoto2TargetEntityType.Pack(builder, _o.AsITakePhoto2TargetEntityType()).Value;
			default:
				return 0;
			}
		}
	}
}
