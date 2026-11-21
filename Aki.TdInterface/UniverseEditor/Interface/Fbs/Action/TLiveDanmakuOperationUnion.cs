using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F22 RID: 32546
	public class TLiveDanmakuOperationUnion
	{
		// Token: 0x1700F28F RID: 62095
		// (get) Token: 0x0603AB61 RID: 240481 RVA: 0x007E54DC File Offset: 0x007E36DC
		// (set) Token: 0x0603AB62 RID: 240482 RVA: 0x007E54E4 File Offset: 0x007E36E4
		public TLiveDanmakuOperation Type { get; set; }

		// Token: 0x1700F290 RID: 62096
		// (get) Token: 0x0603AB63 RID: 240483 RVA: 0x007E54ED File Offset: 0x007E36ED
		// (set) Token: 0x0603AB64 RID: 240484 RVA: 0x007E54F5 File Offset: 0x007E36F5
		public object Value { get; set; }

		// Token: 0x0603AB65 RID: 240485 RVA: 0x007E54FE File Offset: 0x007E36FE
		public TLiveDanmakuOperationUnion()
		{
			this.Type = TLiveDanmakuOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603AB66 RID: 240486 RVA: 0x007E5514 File Offset: 0x007E3714
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AB67 RID: 240487 RVA: 0x007E5526 File Offset: 0x007E3726
		public ILiveLoadDanmakuConfigT AsILiveLoadDanmakuConfig()
		{
			return this.As<ILiveLoadDanmakuConfigT>();
		}

		// Token: 0x0603AB68 RID: 240488 RVA: 0x007E552E File Offset: 0x007E372E
		public static TLiveDanmakuOperationUnion FromILiveLoadDanmakuConfig(ILiveLoadDanmakuConfigT _iliveloaddanmakuconfig)
		{
			return new TLiveDanmakuOperationUnion
			{
				Type = TLiveDanmakuOperation.ILiveLoadDanmakuConfig,
				Value = _iliveloaddanmakuconfig
			};
		}

		// Token: 0x0603AB69 RID: 240489 RVA: 0x007E5543 File Offset: 0x007E3743
		public ILiveStartInteractDanmakuConfigT AsILiveStartInteractDanmakuConfig()
		{
			return this.As<ILiveStartInteractDanmakuConfigT>();
		}

		// Token: 0x0603AB6A RID: 240490 RVA: 0x007E554B File Offset: 0x007E374B
		public static TLiveDanmakuOperationUnion FromILiveStartInteractDanmakuConfig(ILiveStartInteractDanmakuConfigT _ilivestartinteractdanmakuconfig)
		{
			return new TLiveDanmakuOperationUnion
			{
				Type = TLiveDanmakuOperation.ILiveStartInteractDanmakuConfig,
				Value = _ilivestartinteractdanmakuconfig
			};
		}

		// Token: 0x0603AB6B RID: 240491 RVA: 0x007E5560 File Offset: 0x007E3760
		public ILiveStopInteractDanmakuConfigT AsILiveStopInteractDanmakuConfig()
		{
			return this.As<ILiveStopInteractDanmakuConfigT>();
		}

		// Token: 0x0603AB6C RID: 240492 RVA: 0x007E5568 File Offset: 0x007E3768
		public static TLiveDanmakuOperationUnion FromILiveStopInteractDanmakuConfig(ILiveStopInteractDanmakuConfigT _ilivestopinteractdanmakuconfig)
		{
			return new TLiveDanmakuOperationUnion
			{
				Type = TLiveDanmakuOperation.ILiveStopInteractDanmakuConfig,
				Value = _ilivestopinteractdanmakuconfig
			};
		}

		// Token: 0x0603AB6D RID: 240493 RVA: 0x007E557D File Offset: 0x007E377D
		public ILiveUnloadDanmakuConfigT AsILiveUnloadDanmakuConfig()
		{
			return this.As<ILiveUnloadDanmakuConfigT>();
		}

		// Token: 0x0603AB6E RID: 240494 RVA: 0x007E5585 File Offset: 0x007E3785
		public static TLiveDanmakuOperationUnion FromILiveUnloadDanmakuConfig(ILiveUnloadDanmakuConfigT _iliveunloaddanmakuconfig)
		{
			return new TLiveDanmakuOperationUnion
			{
				Type = TLiveDanmakuOperation.ILiveUnloadDanmakuConfig,
				Value = _iliveunloaddanmakuconfig
			};
		}

		// Token: 0x0603AB6F RID: 240495 RVA: 0x007E559C File Offset: 0x007E379C
		public static int Pack(FlatBufferBuilder builder, TLiveDanmakuOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TLiveDanmakuOperation.ILiveLoadDanmakuConfig:
				return ILiveLoadDanmakuConfig.Pack(builder, _o.AsILiveLoadDanmakuConfig()).Value;
			case TLiveDanmakuOperation.ILiveStartInteractDanmakuConfig:
				return ILiveStartInteractDanmakuConfig.Pack(builder, _o.AsILiveStartInteractDanmakuConfig()).Value;
			case TLiveDanmakuOperation.ILiveStopInteractDanmakuConfig:
				return ILiveStopInteractDanmakuConfig.Pack(builder, _o.AsILiveStopInteractDanmakuConfig()).Value;
			case TLiveDanmakuOperation.ILiveUnloadDanmakuConfig:
				return ILiveUnloadDanmakuConfig.Pack(builder, _o.AsILiveUnloadDanmakuConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
