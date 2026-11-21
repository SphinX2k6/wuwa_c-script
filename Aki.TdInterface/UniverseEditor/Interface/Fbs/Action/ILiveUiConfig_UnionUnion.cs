using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713D RID: 28989
	public class ILiveUiConfig_UnionUnion
	{
		// Token: 0x1700D436 RID: 54326
		// (get) Token: 0x060325C0 RID: 206272 RVA: 0x006CF0C9 File Offset: 0x006CD2C9
		// (set) Token: 0x060325C1 RID: 206273 RVA: 0x006CF0D1 File Offset: 0x006CD2D1
		public ILiveUiConfig_Union Type { get; set; }

		// Token: 0x1700D437 RID: 54327
		// (get) Token: 0x060325C2 RID: 206274 RVA: 0x006CF0DA File Offset: 0x006CD2DA
		// (set) Token: 0x060325C3 RID: 206275 RVA: 0x006CF0E2 File Offset: 0x006CD2E2
		public object Value { get; set; }

		// Token: 0x060325C4 RID: 206276 RVA: 0x006CF0EB File Offset: 0x006CD2EB
		public ILiveUiConfig_UnionUnion()
		{
			this.Type = ILiveUiConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060325C5 RID: 206277 RVA: 0x006CF101 File Offset: 0x006CD301
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060325C6 RID: 206278 RVA: 0x006CF113 File Offset: 0x006CD313
		public ILiveUiConfigT AsILiveUiConfig()
		{
			return this.As<ILiveUiConfigT>();
		}

		// Token: 0x060325C7 RID: 206279 RVA: 0x006CF11B File Offset: 0x006CD31B
		public static ILiveUiConfig_UnionUnion FromILiveUiConfig(ILiveUiConfigT _iliveuiconfig)
		{
			return new ILiveUiConfig_UnionUnion
			{
				Type = ILiveUiConfig_Union.ILiveUiConfig,
				Value = _iliveuiconfig
			};
		}

		// Token: 0x060325C8 RID: 206280 RVA: 0x006CF130 File Offset: 0x006CD330
		public ILiveUiFinishConfigT AsILiveUiFinishConfig()
		{
			return this.As<ILiveUiFinishConfigT>();
		}

		// Token: 0x060325C9 RID: 206281 RVA: 0x006CF138 File Offset: 0x006CD338
		public static ILiveUiConfig_UnionUnion FromILiveUiFinishConfig(ILiveUiFinishConfigT _iliveuifinishconfig)
		{
			return new ILiveUiConfig_UnionUnion
			{
				Type = ILiveUiConfig_Union.ILiveUiFinishConfig,
				Value = _iliveuifinishconfig
			};
		}

		// Token: 0x060325CA RID: 206282 RVA: 0x006CF14D File Offset: 0x006CD34D
		public ILiveUiHideConfigT AsILiveUiHideConfig()
		{
			return this.As<ILiveUiHideConfigT>();
		}

		// Token: 0x060325CB RID: 206283 RVA: 0x006CF155 File Offset: 0x006CD355
		public static ILiveUiConfig_UnionUnion FromILiveUiHideConfig(ILiveUiHideConfigT _iliveuihideconfig)
		{
			return new ILiveUiConfig_UnionUnion
			{
				Type = ILiveUiConfig_Union.ILiveUiHideConfig,
				Value = _iliveuihideconfig
			};
		}

		// Token: 0x060325CC RID: 206284 RVA: 0x006CF16A File Offset: 0x006CD36A
		public ILiveUiPauseConfigT AsILiveUiPauseConfig()
		{
			return this.As<ILiveUiPauseConfigT>();
		}

		// Token: 0x060325CD RID: 206285 RVA: 0x006CF172 File Offset: 0x006CD372
		public static ILiveUiConfig_UnionUnion FromILiveUiPauseConfig(ILiveUiPauseConfigT _iliveuipauseconfig)
		{
			return new ILiveUiConfig_UnionUnion
			{
				Type = ILiveUiConfig_Union.ILiveUiPauseConfig,
				Value = _iliveuipauseconfig
			};
		}

		// Token: 0x060325CE RID: 206286 RVA: 0x006CF187 File Offset: 0x006CD387
		public ILiveUiResumeConfigT AsILiveUiResumeConfig()
		{
			return this.As<ILiveUiResumeConfigT>();
		}

		// Token: 0x060325CF RID: 206287 RVA: 0x006CF18F File Offset: 0x006CD38F
		public static ILiveUiConfig_UnionUnion FromILiveUiResumeConfig(ILiveUiResumeConfigT _iliveuiresumeconfig)
		{
			return new ILiveUiConfig_UnionUnion
			{
				Type = ILiveUiConfig_Union.ILiveUiResumeConfig,
				Value = _iliveuiresumeconfig
			};
		}

		// Token: 0x060325D0 RID: 206288 RVA: 0x006CF1A4 File Offset: 0x006CD3A4
		public ILiveUiShowConfigT AsILiveUiShowConfig()
		{
			return this.As<ILiveUiShowConfigT>();
		}

		// Token: 0x060325D1 RID: 206289 RVA: 0x006CF1AC File Offset: 0x006CD3AC
		public static ILiveUiConfig_UnionUnion FromILiveUiShowConfig(ILiveUiShowConfigT _iliveuishowconfig)
		{
			return new ILiveUiConfig_UnionUnion
			{
				Type = ILiveUiConfig_Union.ILiveUiShowConfig,
				Value = _iliveuishowconfig
			};
		}

		// Token: 0x060325D2 RID: 206290 RVA: 0x006CF1C1 File Offset: 0x006CD3C1
		public ILiveUiStartConfigT AsILiveUiStartConfig()
		{
			return this.As<ILiveUiStartConfigT>();
		}

		// Token: 0x060325D3 RID: 206291 RVA: 0x006CF1C9 File Offset: 0x006CD3C9
		public static ILiveUiConfig_UnionUnion FromILiveUiStartConfig(ILiveUiStartConfigT _iliveuistartconfig)
		{
			return new ILiveUiConfig_UnionUnion
			{
				Type = ILiveUiConfig_Union.ILiveUiStartConfig,
				Value = _iliveuistartconfig
			};
		}

		// Token: 0x060325D4 RID: 206292 RVA: 0x006CF1E0 File Offset: 0x006CD3E0
		public static int Pack(FlatBufferBuilder builder, ILiveUiConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILiveUiConfig_Union.ILiveUiConfig:
				return ILiveUiConfig.Pack(builder, _o.AsILiveUiConfig()).Value;
			case ILiveUiConfig_Union.ILiveUiFinishConfig:
				return ILiveUiFinishConfig.Pack(builder, _o.AsILiveUiFinishConfig()).Value;
			case ILiveUiConfig_Union.ILiveUiHideConfig:
				return ILiveUiHideConfig.Pack(builder, _o.AsILiveUiHideConfig()).Value;
			case ILiveUiConfig_Union.ILiveUiPauseConfig:
				return ILiveUiPauseConfig.Pack(builder, _o.AsILiveUiPauseConfig()).Value;
			case ILiveUiConfig_Union.ILiveUiResumeConfig:
				return ILiveUiResumeConfig.Pack(builder, _o.AsILiveUiResumeConfig()).Value;
			case ILiveUiConfig_Union.ILiveUiShowConfig:
				return ILiveUiShowConfig.Pack(builder, _o.AsILiveUiShowConfig()).Value;
			case ILiveUiConfig_Union.ILiveUiStartConfig:
				return ILiveUiStartConfig.Pack(builder, _o.AsILiveUiStartConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
