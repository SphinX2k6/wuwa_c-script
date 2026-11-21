using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F2E RID: 32558
	public class TLiveUiConfigUnion
	{
		// Token: 0x1700F297 RID: 62103
		// (get) Token: 0x0603AB9D RID: 240541 RVA: 0x007E5A7A File Offset: 0x007E3C7A
		// (set) Token: 0x0603AB9E RID: 240542 RVA: 0x007E5A82 File Offset: 0x007E3C82
		public TLiveUiConfig Type { get; set; }

		// Token: 0x1700F298 RID: 62104
		// (get) Token: 0x0603AB9F RID: 240543 RVA: 0x007E5A8B File Offset: 0x007E3C8B
		// (set) Token: 0x0603ABA0 RID: 240544 RVA: 0x007E5A93 File Offset: 0x007E3C93
		public object Value { get; set; }

		// Token: 0x0603ABA1 RID: 240545 RVA: 0x007E5A9C File Offset: 0x007E3C9C
		public TLiveUiConfigUnion()
		{
			this.Type = TLiveUiConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603ABA2 RID: 240546 RVA: 0x007E5AB2 File Offset: 0x007E3CB2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ABA3 RID: 240547 RVA: 0x007E5AC4 File Offset: 0x007E3CC4
		public ILiveUiFinishConfigT AsILiveUiFinishConfig()
		{
			return this.As<ILiveUiFinishConfigT>();
		}

		// Token: 0x0603ABA4 RID: 240548 RVA: 0x007E5ACC File Offset: 0x007E3CCC
		public static TLiveUiConfigUnion FromILiveUiFinishConfig(ILiveUiFinishConfigT _iliveuifinishconfig)
		{
			return new TLiveUiConfigUnion
			{
				Type = TLiveUiConfig.ILiveUiFinishConfig,
				Value = _iliveuifinishconfig
			};
		}

		// Token: 0x0603ABA5 RID: 240549 RVA: 0x007E5AE1 File Offset: 0x007E3CE1
		public ILiveUiHideConfigT AsILiveUiHideConfig()
		{
			return this.As<ILiveUiHideConfigT>();
		}

		// Token: 0x0603ABA6 RID: 240550 RVA: 0x007E5AE9 File Offset: 0x007E3CE9
		public static TLiveUiConfigUnion FromILiveUiHideConfig(ILiveUiHideConfigT _iliveuihideconfig)
		{
			return new TLiveUiConfigUnion
			{
				Type = TLiveUiConfig.ILiveUiHideConfig,
				Value = _iliveuihideconfig
			};
		}

		// Token: 0x0603ABA7 RID: 240551 RVA: 0x007E5AFE File Offset: 0x007E3CFE
		public ILiveUiPauseConfigT AsILiveUiPauseConfig()
		{
			return this.As<ILiveUiPauseConfigT>();
		}

		// Token: 0x0603ABA8 RID: 240552 RVA: 0x007E5B06 File Offset: 0x007E3D06
		public static TLiveUiConfigUnion FromILiveUiPauseConfig(ILiveUiPauseConfigT _iliveuipauseconfig)
		{
			return new TLiveUiConfigUnion
			{
				Type = TLiveUiConfig.ILiveUiPauseConfig,
				Value = _iliveuipauseconfig
			};
		}

		// Token: 0x0603ABA9 RID: 240553 RVA: 0x007E5B1B File Offset: 0x007E3D1B
		public ILiveUiResumeConfigT AsILiveUiResumeConfig()
		{
			return this.As<ILiveUiResumeConfigT>();
		}

		// Token: 0x0603ABAA RID: 240554 RVA: 0x007E5B23 File Offset: 0x007E3D23
		public static TLiveUiConfigUnion FromILiveUiResumeConfig(ILiveUiResumeConfigT _iliveuiresumeconfig)
		{
			return new TLiveUiConfigUnion
			{
				Type = TLiveUiConfig.ILiveUiResumeConfig,
				Value = _iliveuiresumeconfig
			};
		}

		// Token: 0x0603ABAB RID: 240555 RVA: 0x007E5B38 File Offset: 0x007E3D38
		public ILiveUiShowConfigT AsILiveUiShowConfig()
		{
			return this.As<ILiveUiShowConfigT>();
		}

		// Token: 0x0603ABAC RID: 240556 RVA: 0x007E5B40 File Offset: 0x007E3D40
		public static TLiveUiConfigUnion FromILiveUiShowConfig(ILiveUiShowConfigT _iliveuishowconfig)
		{
			return new TLiveUiConfigUnion
			{
				Type = TLiveUiConfig.ILiveUiShowConfig,
				Value = _iliveuishowconfig
			};
		}

		// Token: 0x0603ABAD RID: 240557 RVA: 0x007E5B55 File Offset: 0x007E3D55
		public ILiveUiStartConfigT AsILiveUiStartConfig()
		{
			return this.As<ILiveUiStartConfigT>();
		}

		// Token: 0x0603ABAE RID: 240558 RVA: 0x007E5B5D File Offset: 0x007E3D5D
		public static TLiveUiConfigUnion FromILiveUiStartConfig(ILiveUiStartConfigT _iliveuistartconfig)
		{
			return new TLiveUiConfigUnion
			{
				Type = TLiveUiConfig.ILiveUiStartConfig,
				Value = _iliveuistartconfig
			};
		}

		// Token: 0x0603ABAF RID: 240559 RVA: 0x007E5B74 File Offset: 0x007E3D74
		public static int Pack(FlatBufferBuilder builder, TLiveUiConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TLiveUiConfig.ILiveUiFinishConfig:
				return ILiveUiFinishConfig.Pack(builder, _o.AsILiveUiFinishConfig()).Value;
			case TLiveUiConfig.ILiveUiHideConfig:
				return ILiveUiHideConfig.Pack(builder, _o.AsILiveUiHideConfig()).Value;
			case TLiveUiConfig.ILiveUiPauseConfig:
				return ILiveUiPauseConfig.Pack(builder, _o.AsILiveUiPauseConfig()).Value;
			case TLiveUiConfig.ILiveUiResumeConfig:
				return ILiveUiResumeConfig.Pack(builder, _o.AsILiveUiResumeConfig()).Value;
			case TLiveUiConfig.ILiveUiShowConfig:
				return ILiveUiShowConfig.Pack(builder, _o.AsILiveUiShowConfig()).Value;
			case TLiveUiConfig.ILiveUiStartConfig:
				return ILiveUiStartConfig.Pack(builder, _o.AsILiveUiStartConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
