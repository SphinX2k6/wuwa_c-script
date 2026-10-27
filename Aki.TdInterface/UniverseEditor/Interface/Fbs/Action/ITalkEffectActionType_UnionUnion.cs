using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AE RID: 29358
	public class ITalkEffectActionType_UnionUnion
	{
		// Token: 0x1700D9BD RID: 55741
		// (get) Token: 0x0603416D RID: 213357 RVA: 0x007005F9 File Offset: 0x006FE7F9
		// (set) Token: 0x0603416E RID: 213358 RVA: 0x00700601 File Offset: 0x006FE801
		public ITalkEffectActionType_Union Type { get; set; }

		// Token: 0x1700D9BE RID: 55742
		// (get) Token: 0x0603416F RID: 213359 RVA: 0x0070060A File Offset: 0x006FE80A
		// (set) Token: 0x06034170 RID: 213360 RVA: 0x00700612 File Offset: 0x006FE812
		public object Value { get; set; }

		// Token: 0x06034171 RID: 213361 RVA: 0x0070061B File Offset: 0x006FE81B
		public ITalkEffectActionType_UnionUnion()
		{
			this.Type = ITalkEffectActionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034172 RID: 213362 RVA: 0x00700631 File Offset: 0x006FE831
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034173 RID: 213363 RVA: 0x00700643 File Offset: 0x006FE843
		public ITalkEffectActionTypeT AsITalkEffectActionType()
		{
			return this.As<ITalkEffectActionTypeT>();
		}

		// Token: 0x06034174 RID: 213364 RVA: 0x0070064B File Offset: 0x006FE84B
		public static ITalkEffectActionType_UnionUnion FromITalkEffectActionType(ITalkEffectActionTypeT _italkeffectactiontype)
		{
			return new ITalkEffectActionType_UnionUnion
			{
				Type = ITalkEffectActionType_Union.ITalkEffectActionType,
				Value = _italkeffectactiontype
			};
		}

		// Token: 0x06034175 RID: 213365 RVA: 0x00700660 File Offset: 0x006FE860
		public ITalkEffectPlayT AsITalkEffectPlay()
		{
			return this.As<ITalkEffectPlayT>();
		}

		// Token: 0x06034176 RID: 213366 RVA: 0x00700668 File Offset: 0x006FE868
		public static ITalkEffectActionType_UnionUnion FromITalkEffectPlay(ITalkEffectPlayT _italkeffectplay)
		{
			return new ITalkEffectActionType_UnionUnion
			{
				Type = ITalkEffectActionType_Union.ITalkEffectPlay,
				Value = _italkeffectplay
			};
		}

		// Token: 0x06034177 RID: 213367 RVA: 0x0070067D File Offset: 0x006FE87D
		public ITalkEffectStopT AsITalkEffectStop()
		{
			return this.As<ITalkEffectStopT>();
		}

		// Token: 0x06034178 RID: 213368 RVA: 0x00700685 File Offset: 0x006FE885
		public static ITalkEffectActionType_UnionUnion FromITalkEffectStop(ITalkEffectStopT _italkeffectstop)
		{
			return new ITalkEffectActionType_UnionUnion
			{
				Type = ITalkEffectActionType_Union.ITalkEffectStop,
				Value = _italkeffectstop
			};
		}

		// Token: 0x06034179 RID: 213369 RVA: 0x0070069C File Offset: 0x006FE89C
		public static int Pack(FlatBufferBuilder builder, ITalkEffectActionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkEffectActionType_Union.ITalkEffectActionType:
				return ITalkEffectActionType.Pack(builder, _o.AsITalkEffectActionType()).Value;
			case ITalkEffectActionType_Union.ITalkEffectPlay:
				return ITalkEffectPlay.Pack(builder, _o.AsITalkEffectPlay()).Value;
			case ITalkEffectActionType_Union.ITalkEffectStop:
				return ITalkEffectStop.Pack(builder, _o.AsITalkEffectStop()).Value;
			default:
				return 0;
			}
		}
	}
}
