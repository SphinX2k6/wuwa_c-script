using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EC RID: 28908
	public class ILiveDanmakuOperation_UnionUnion
	{
		// Token: 0x1700D3B1 RID: 54193
		// (get) Token: 0x06032330 RID: 205616 RVA: 0x006CA605 File Offset: 0x006C8805
		// (set) Token: 0x06032331 RID: 205617 RVA: 0x006CA60D File Offset: 0x006C880D
		public ILiveDanmakuOperation_Union Type { get; set; }

		// Token: 0x1700D3B2 RID: 54194
		// (get) Token: 0x06032332 RID: 205618 RVA: 0x006CA616 File Offset: 0x006C8816
		// (set) Token: 0x06032333 RID: 205619 RVA: 0x006CA61E File Offset: 0x006C881E
		public object Value { get; set; }

		// Token: 0x06032334 RID: 205620 RVA: 0x006CA627 File Offset: 0x006C8827
		public ILiveDanmakuOperation_UnionUnion()
		{
			this.Type = ILiveDanmakuOperation_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032335 RID: 205621 RVA: 0x006CA63D File Offset: 0x006C883D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032336 RID: 205622 RVA: 0x006CA64F File Offset: 0x006C884F
		public ILiveDanmakuOperationT AsILiveDanmakuOperation()
		{
			return this.As<ILiveDanmakuOperationT>();
		}

		// Token: 0x06032337 RID: 205623 RVA: 0x006CA657 File Offset: 0x006C8857
		public static ILiveDanmakuOperation_UnionUnion FromILiveDanmakuOperation(ILiveDanmakuOperationT _ilivedanmakuoperation)
		{
			return new ILiveDanmakuOperation_UnionUnion
			{
				Type = ILiveDanmakuOperation_Union.ILiveDanmakuOperation,
				Value = _ilivedanmakuoperation
			};
		}

		// Token: 0x06032338 RID: 205624 RVA: 0x006CA66C File Offset: 0x006C886C
		public ILiveLoadDanmakuConfigT AsILiveLoadDanmakuConfig()
		{
			return this.As<ILiveLoadDanmakuConfigT>();
		}

		// Token: 0x06032339 RID: 205625 RVA: 0x006CA674 File Offset: 0x006C8874
		public static ILiveDanmakuOperation_UnionUnion FromILiveLoadDanmakuConfig(ILiveLoadDanmakuConfigT _iliveloaddanmakuconfig)
		{
			return new ILiveDanmakuOperation_UnionUnion
			{
				Type = ILiveDanmakuOperation_Union.ILiveLoadDanmakuConfig,
				Value = _iliveloaddanmakuconfig
			};
		}

		// Token: 0x0603233A RID: 205626 RVA: 0x006CA689 File Offset: 0x006C8889
		public ILiveUnloadDanmakuConfigT AsILiveUnloadDanmakuConfig()
		{
			return this.As<ILiveUnloadDanmakuConfigT>();
		}

		// Token: 0x0603233B RID: 205627 RVA: 0x006CA691 File Offset: 0x006C8891
		public static ILiveDanmakuOperation_UnionUnion FromILiveUnloadDanmakuConfig(ILiveUnloadDanmakuConfigT _iliveunloaddanmakuconfig)
		{
			return new ILiveDanmakuOperation_UnionUnion
			{
				Type = ILiveDanmakuOperation_Union.ILiveUnloadDanmakuConfig,
				Value = _iliveunloaddanmakuconfig
			};
		}

		// Token: 0x0603233C RID: 205628 RVA: 0x006CA6A6 File Offset: 0x006C88A6
		public ILiveStartInteractDanmakuConfigT AsILiveStartInteractDanmakuConfig()
		{
			return this.As<ILiveStartInteractDanmakuConfigT>();
		}

		// Token: 0x0603233D RID: 205629 RVA: 0x006CA6AE File Offset: 0x006C88AE
		public static ILiveDanmakuOperation_UnionUnion FromILiveStartInteractDanmakuConfig(ILiveStartInteractDanmakuConfigT _ilivestartinteractdanmakuconfig)
		{
			return new ILiveDanmakuOperation_UnionUnion
			{
				Type = ILiveDanmakuOperation_Union.ILiveStartInteractDanmakuConfig,
				Value = _ilivestartinteractdanmakuconfig
			};
		}

		// Token: 0x0603233E RID: 205630 RVA: 0x006CA6C3 File Offset: 0x006C88C3
		public ILiveStopInteractDanmakuConfigT AsILiveStopInteractDanmakuConfig()
		{
			return this.As<ILiveStopInteractDanmakuConfigT>();
		}

		// Token: 0x0603233F RID: 205631 RVA: 0x006CA6CB File Offset: 0x006C88CB
		public static ILiveDanmakuOperation_UnionUnion FromILiveStopInteractDanmakuConfig(ILiveStopInteractDanmakuConfigT _ilivestopinteractdanmakuconfig)
		{
			return new ILiveDanmakuOperation_UnionUnion
			{
				Type = ILiveDanmakuOperation_Union.ILiveStopInteractDanmakuConfig,
				Value = _ilivestopinteractdanmakuconfig
			};
		}

		// Token: 0x06032340 RID: 205632 RVA: 0x006CA6E0 File Offset: 0x006C88E0
		public static int Pack(FlatBufferBuilder builder, ILiveDanmakuOperation_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILiveDanmakuOperation_Union.ILiveDanmakuOperation:
				return ILiveDanmakuOperation.Pack(builder, _o.AsILiveDanmakuOperation()).Value;
			case ILiveDanmakuOperation_Union.ILiveLoadDanmakuConfig:
				return ILiveLoadDanmakuConfig.Pack(builder, _o.AsILiveLoadDanmakuConfig()).Value;
			case ILiveDanmakuOperation_Union.ILiveUnloadDanmakuConfig:
				return ILiveUnloadDanmakuConfig.Pack(builder, _o.AsILiveUnloadDanmakuConfig()).Value;
			case ILiveDanmakuOperation_Union.ILiveStartInteractDanmakuConfig:
				return ILiveStartInteractDanmakuConfig.Pack(builder, _o.AsILiveStartInteractDanmakuConfig()).Value;
			case ILiveDanmakuOperation_Union.ILiveStopInteractDanmakuConfig:
				return ILiveStopInteractDanmakuConfig.Pack(builder, _o.AsILiveStopInteractDanmakuConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
