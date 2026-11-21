using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004780 RID: 18304
	public class TTakePhoto2TargetConfigUnion
	{
		// Token: 0x17007FAB RID: 32683
		// (get) Token: 0x0601AF43 RID: 110403 RVA: 0x003D24BA File Offset: 0x003D06BA
		// (set) Token: 0x0601AF44 RID: 110404 RVA: 0x003D24C2 File Offset: 0x003D06C2
		public TTakePhoto2TargetConfig Type { get; set; }

		// Token: 0x17007FAC RID: 32684
		// (get) Token: 0x0601AF45 RID: 110405 RVA: 0x003D24CB File Offset: 0x003D06CB
		// (set) Token: 0x0601AF46 RID: 110406 RVA: 0x003D24D3 File Offset: 0x003D06D3
		public object Value { get; set; }

		// Token: 0x0601AF47 RID: 110407 RVA: 0x003D24DC File Offset: 0x003D06DC
		public TTakePhoto2TargetConfigUnion()
		{
			this.Type = TTakePhoto2TargetConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF48 RID: 110408 RVA: 0x003D24F2 File Offset: 0x003D06F2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF49 RID: 110409 RVA: 0x003D2504 File Offset: 0x003D0704
		public ITakePhoto2EntityTargetT AsITakePhoto2EntityTarget()
		{
			return this.As<ITakePhoto2EntityTargetT>();
		}

		// Token: 0x0601AF4A RID: 110410 RVA: 0x003D250C File Offset: 0x003D070C
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2EntityTarget(ITakePhoto2EntityTargetT _itakephoto2entitytarget)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2EntityTarget,
				Value = _itakephoto2entitytarget
			};
		}

		// Token: 0x0601AF4B RID: 110411 RVA: 0x003D2521 File Offset: 0x003D0721
		public ITakePhoto2PhotoTargetEntityTargetT AsITakePhoto2PhotoTargetEntityTarget()
		{
			return this.As<ITakePhoto2PhotoTargetEntityTargetT>();
		}

		// Token: 0x0601AF4C RID: 110412 RVA: 0x003D2529 File Offset: 0x003D0729
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2PhotoTargetEntityTarget(ITakePhoto2PhotoTargetEntityTargetT _itakephoto2phototargetentitytarget)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2PhotoTargetEntityTarget,
				Value = _itakephoto2phototargetentitytarget
			};
		}

		// Token: 0x0601AF4D RID: 110413 RVA: 0x003D253E File Offset: 0x003D073E
		public ITakePhoto2TaggedActorTargetT AsITakePhoto2TaggedActorTarget()
		{
			return this.As<ITakePhoto2TaggedActorTargetT>();
		}

		// Token: 0x0601AF4E RID: 110414 RVA: 0x003D2546 File Offset: 0x003D0746
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2TaggedActorTarget(ITakePhoto2TaggedActorTargetT _itakephoto2taggedactortarget)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2TaggedActorTarget,
				Value = _itakephoto2taggedactortarget
			};
		}

		// Token: 0x0601AF4F RID: 110415 RVA: 0x003D255B File Offset: 0x003D075B
		public ITakePhoto2TargetEntityTypeT AsITakePhoto2TargetEntityType()
		{
			return this.As<ITakePhoto2TargetEntityTypeT>();
		}

		// Token: 0x0601AF50 RID: 110416 RVA: 0x003D2563 File Offset: 0x003D0763
		public static TTakePhoto2TargetConfigUnion FromITakePhoto2TargetEntityType(ITakePhoto2TargetEntityTypeT _itakephoto2targetentitytype)
		{
			return new TTakePhoto2TargetConfigUnion
			{
				Type = TTakePhoto2TargetConfig.ITakePhoto2TargetEntityType,
				Value = _itakephoto2targetentitytype
			};
		}

		// Token: 0x0601AF51 RID: 110417 RVA: 0x003D2578 File Offset: 0x003D0778
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
