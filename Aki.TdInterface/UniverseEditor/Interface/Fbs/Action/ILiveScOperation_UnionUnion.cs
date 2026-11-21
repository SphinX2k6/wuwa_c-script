using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007122 RID: 28962
	public class ILiveScOperation_UnionUnion
	{
		// Token: 0x1700D416 RID: 54294
		// (get) Token: 0x060324F1 RID: 206065 RVA: 0x006CD5A1 File Offset: 0x006CB7A1
		// (set) Token: 0x060324F2 RID: 206066 RVA: 0x006CD5A9 File Offset: 0x006CB7A9
		public ILiveScOperation_Union Type { get; set; }

		// Token: 0x1700D417 RID: 54295
		// (get) Token: 0x060324F3 RID: 206067 RVA: 0x006CD5B2 File Offset: 0x006CB7B2
		// (set) Token: 0x060324F4 RID: 206068 RVA: 0x006CD5BA File Offset: 0x006CB7BA
		public object Value { get; set; }

		// Token: 0x060324F5 RID: 206069 RVA: 0x006CD5C3 File Offset: 0x006CB7C3
		public ILiveScOperation_UnionUnion()
		{
			this.Type = ILiveScOperation_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060324F6 RID: 206070 RVA: 0x006CD5D9 File Offset: 0x006CB7D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060324F7 RID: 206071 RVA: 0x006CD5EB File Offset: 0x006CB7EB
		public ILiveScOperationT AsILiveScOperation()
		{
			return this.As<ILiveScOperationT>();
		}

		// Token: 0x060324F8 RID: 206072 RVA: 0x006CD5F3 File Offset: 0x006CB7F3
		public static ILiveScOperation_UnionUnion FromILiveScOperation(ILiveScOperationT _ilivescoperation)
		{
			return new ILiveScOperation_UnionUnion
			{
				Type = ILiveScOperation_Union.ILiveScOperation,
				Value = _ilivescoperation
			};
		}

		// Token: 0x060324F9 RID: 206073 RVA: 0x006CD608 File Offset: 0x006CB808
		public ILiveSendScConfigT AsILiveSendScConfig()
		{
			return this.As<ILiveSendScConfigT>();
		}

		// Token: 0x060324FA RID: 206074 RVA: 0x006CD610 File Offset: 0x006CB810
		public static ILiveScOperation_UnionUnion FromILiveSendScConfig(ILiveSendScConfigT _ilivesendscconfig)
		{
			return new ILiveScOperation_UnionUnion
			{
				Type = ILiveScOperation_Union.ILiveSendScConfig,
				Value = _ilivesendscconfig
			};
		}

		// Token: 0x060324FB RID: 206075 RVA: 0x006CD625 File Offset: 0x006CB825
		public ILiveClearScConfigT AsILiveClearScConfig()
		{
			return this.As<ILiveClearScConfigT>();
		}

		// Token: 0x060324FC RID: 206076 RVA: 0x006CD62D File Offset: 0x006CB82D
		public static ILiveScOperation_UnionUnion FromILiveClearScConfig(ILiveClearScConfigT _iliveclearscconfig)
		{
			return new ILiveScOperation_UnionUnion
			{
				Type = ILiveScOperation_Union.ILiveClearScConfig,
				Value = _iliveclearscconfig
			};
		}

		// Token: 0x060324FD RID: 206077 RVA: 0x006CD644 File Offset: 0x006CB844
		public static int Pack(FlatBufferBuilder builder, ILiveScOperation_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILiveScOperation_Union.ILiveScOperation:
				return ILiveScOperation.Pack(builder, _o.AsILiveScOperation()).Value;
			case ILiveScOperation_Union.ILiveSendScConfig:
				return ILiveSendScConfig.Pack(builder, _o.AsILiveSendScConfig()).Value;
			case ILiveScOperation_Union.ILiveClearScConfig:
				return ILiveClearScConfig.Pack(builder, _o.AsILiveClearScConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
