using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F2B RID: 32555
	public class TLiveScOperationUnion
	{
		// Token: 0x1700F295 RID: 62101
		// (get) Token: 0x0603AB91 RID: 240529 RVA: 0x007E5980 File Offset: 0x007E3B80
		// (set) Token: 0x0603AB92 RID: 240530 RVA: 0x007E5988 File Offset: 0x007E3B88
		public TLiveScOperation Type { get; set; }

		// Token: 0x1700F296 RID: 62102
		// (get) Token: 0x0603AB93 RID: 240531 RVA: 0x007E5991 File Offset: 0x007E3B91
		// (set) Token: 0x0603AB94 RID: 240532 RVA: 0x007E5999 File Offset: 0x007E3B99
		public object Value { get; set; }

		// Token: 0x0603AB95 RID: 240533 RVA: 0x007E59A2 File Offset: 0x007E3BA2
		public TLiveScOperationUnion()
		{
			this.Type = TLiveScOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603AB96 RID: 240534 RVA: 0x007E59B8 File Offset: 0x007E3BB8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AB97 RID: 240535 RVA: 0x007E59CA File Offset: 0x007E3BCA
		public ILiveClearScConfigT AsILiveClearScConfig()
		{
			return this.As<ILiveClearScConfigT>();
		}

		// Token: 0x0603AB98 RID: 240536 RVA: 0x007E59D2 File Offset: 0x007E3BD2
		public static TLiveScOperationUnion FromILiveClearScConfig(ILiveClearScConfigT _iliveclearscconfig)
		{
			return new TLiveScOperationUnion
			{
				Type = TLiveScOperation.ILiveClearScConfig,
				Value = _iliveclearscconfig
			};
		}

		// Token: 0x0603AB99 RID: 240537 RVA: 0x007E59E7 File Offset: 0x007E3BE7
		public ILiveSendScConfigT AsILiveSendScConfig()
		{
			return this.As<ILiveSendScConfigT>();
		}

		// Token: 0x0603AB9A RID: 240538 RVA: 0x007E59EF File Offset: 0x007E3BEF
		public static TLiveScOperationUnion FromILiveSendScConfig(ILiveSendScConfigT _ilivesendscconfig)
		{
			return new TLiveScOperationUnion
			{
				Type = TLiveScOperation.ILiveSendScConfig,
				Value = _ilivesendscconfig
			};
		}

		// Token: 0x0603AB9B RID: 240539 RVA: 0x007E5A04 File Offset: 0x007E3C04
		public static int Pack(FlatBufferBuilder builder, TLiveScOperationUnion _o)
		{
			TLiveScOperation type = _o.Type;
			if (type == TLiveScOperation.ILiveClearScConfig)
			{
				return ILiveClearScConfig.Pack(builder, _o.AsILiveClearScConfig()).Value;
			}
			if (type != TLiveScOperation.ILiveSendScConfig)
			{
				return 0;
			}
			return ILiveSendScConfig.Pack(builder, _o.AsILiveSendScConfig()).Value;
		}
	}
}
