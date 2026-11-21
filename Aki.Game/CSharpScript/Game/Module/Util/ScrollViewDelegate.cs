using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003858 RID: 14424
	[NullableContext(1)]
	[Nullable(0)]
	public class ScrollViewDelegate<TProxy, [Nullable(2)] TData> : IScrollViewDelegate<TProxy, TData> where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x0602578C RID: 153484 RVA: 0x00A8E136 File Offset: 0x00A8C336
		public ScrollViewDelegate(Func<TProxy> proxyCreateFunction)
		{
			this.ProxyCreateFunction = proxyCreateFunction;
		}

		// Token: 0x0602578D RID: 153485 RVA: 0x00A8E16D File Offset: 0x00A8C36D
		public void SetData(IReadOnlyList<TData> data)
		{
			this.ClearData();
			this.Data.AddRange(data);
			this.DataLength = this.Data.Count;
		}

		// Token: 0x0602578E RID: 153486 RVA: 0x00A8E192 File Offset: 0x00A8C392
		public IReadOnlyList<TData> GetDatas()
		{
			return this.Data.AsReadOnly();
		}

		// Token: 0x0602578F RID: 153487 RVA: 0x00A8E19F File Offset: 0x00A8C39F
		public void SetDataProxy(Func<int, TData> dataProxyFunction, int dataLength, bool cacheData = true)
		{
			this.ClearData();
			this.DataProxyFunction = dataProxyFunction;
			this.DataLength = dataLength;
			this.IsCacheProxyData = cacheData;
		}

		// Token: 0x06025790 RID: 153488 RVA: 0x00A8E1BC File Offset: 0x00A8C3BC
		public void OnGridsUpdate(int gridIndex, int displayIndex, int startGridIndex, int endGridIndex)
		{
			if (gridIndex >= this.DataLength || displayIndex >= this.Proxies.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ScrollViewGrid;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(63, 4);
				defaultInterpolatedStringHandler.AppendLiteral("参数值非法 gridIndex: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" displayIndex: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(displayIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" Data.length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.DataLength);
				defaultInterpolatedStringHandler.AppendLiteral(" Proxies.length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Proxies.Count);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.SelectedGridIndex != -1 && (this.SelectedGridIndex < startGridIndex || this.SelectedGridIndex > endGridIndex))
			{
				this.SelectedProxy = default(TProxy);
			}
			if (displayIndex < this.ProxyValidBits.Count)
			{
				this.ProxyValidBits[displayIndex] = true;
			}
			this.RefreshGridProxy(gridIndex, displayIndex);
		}

		// Token: 0x06025791 RID: 153489 RVA: 0x00A8E2B8 File Offset: 0x00A8C4B8
		public void RefreshGridProxy(int gridIndex, int displayIndex)
		{
			if (gridIndex >= this.DataLength || displayIndex >= this.Proxies.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ScrollViewGrid;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(63, 4);
				defaultInterpolatedStringHandler.AppendLiteral("参数值非法 gridIndex: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" displayIndex: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(displayIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" Data.length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.DataLength);
				defaultInterpolatedStringHandler.AppendLiteral(" Proxies.length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Proxies.Count);
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TProxy gridProxy = this.GetGridProxy(displayIndex);
			if (gridProxy == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.ScrollViewGrid;
				ELogAuthor author2 = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 4);
				defaultInterpolatedStringHandler.AppendLiteral("Proxy获取异常 gridIndex: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" displayIndex: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(displayIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" Data.length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.DataLength);
				defaultInterpolatedStringHandler.AppendLiteral(" Proxies.length: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Proxies.Count);
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			bool flag = gridIndex != -1 && gridIndex == this.SelectedGridIndex;
			if (flag && this.SelectedProxy == null)
			{
				this.SelectedProxy = gridProxy;
			}
			TData data = this.GetData(gridIndex, displayIndex);
			gridProxy.GridIndex = gridIndex;
			gridProxy.DisplayIndex = displayIndex;
			gridProxy.Refresh(data, flag, gridIndex);
		}

		// Token: 0x06025792 RID: 153490 RVA: 0x00A8E45C File Offset: 0x00A8C65C
		public UniTask RefreshGridProxyAsync(int gridIndex, int displayIndex)
		{
			ScrollViewDelegate<TProxy, TData>.<RefreshGridProxyAsync>d__15 <RefreshGridProxyAsync>d__;
			<RefreshGridProxyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshGridProxyAsync>d__.<>4__this = this;
			<RefreshGridProxyAsync>d__.gridIndex = gridIndex;
			<RefreshGridProxyAsync>d__.displayIndex = displayIndex;
			<RefreshGridProxyAsync>d__.<>1__state = -1;
			<RefreshGridProxyAsync>d__.<>t__builder.Start<ScrollViewDelegate<TProxy, TData>.<RefreshGridProxyAsync>d__15>(ref <RefreshGridProxyAsync>d__);
			return <RefreshGridProxyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025793 RID: 153491 RVA: 0x00A8E4B0 File Offset: 0x00A8C6B0
		private TData GetData(int gridIndex, int displayIndex)
		{
			TData tdata = default(TData);
			if (this.Data.Count > gridIndex)
			{
				tdata = this.Data[gridIndex];
			}
			if (tdata == null && this.DataProxyFunction != null)
			{
				tdata = this.DataProxyFunction(gridIndex);
				if (this.IsCacheProxyData && this.Data.Count > gridIndex)
				{
					this.Data[gridIndex] = tdata;
				}
			}
			return tdata;
		}

		// Token: 0x06025794 RID: 153492 RVA: 0x00A8E524 File Offset: 0x00A8C724
		[NullableContext(2)]
		public TData TryGetCachedData(int gridIndex)
		{
			if (this.Data.Count > gridIndex)
			{
				return this.Data[gridIndex];
			}
			return default(TData);
		}

		// Token: 0x06025795 RID: 153493 RVA: 0x00A8E558 File Offset: 0x00A8C758
		public TProxy CreateGridProxy(int displayIndex, AActor actor)
		{
			if (displayIndex < this.Proxies.Count && this.Proxies[displayIndex] != null)
			{
				Log.Instance.Error(ELogModule.ScrollViewGrid, ELogAuthor.LZK, "Proxy已经存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return this.Proxies[displayIndex];
			}
			TProxy tproxy = this.ProxyCreateFunction();
			tproxy.CreateThenShowByActor(actor, null);
			while (this.Proxies.Count <= displayIndex)
			{
				this.Proxies.Add(default(TProxy));
				this.ProxyValidBits.Add(false);
			}
			this.Proxies[displayIndex] = tproxy;
			this.ProxyValidBits[displayIndex] = false;
			tproxy.ScrollViewDelegate = this;
			return tproxy;
		}

		// Token: 0x06025796 RID: 153494 RVA: 0x00A8E620 File Offset: 0x00A8C820
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<TProxy> CreateGridProxyAsync(int displayIndex, AActor actor, bool bShow = true)
		{
			ScrollViewDelegate<TProxy, TData>.<CreateGridProxyAsync>d__19 <CreateGridProxyAsync>d__;
			<CreateGridProxyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<TProxy>.Create();
			<CreateGridProxyAsync>d__.<>4__this = this;
			<CreateGridProxyAsync>d__.displayIndex = displayIndex;
			<CreateGridProxyAsync>d__.actor = actor;
			<CreateGridProxyAsync>d__.bShow = bShow;
			<CreateGridProxyAsync>d__.<>1__state = -1;
			<CreateGridProxyAsync>d__.<>t__builder.Start<ScrollViewDelegate<TProxy, TData>.<CreateGridProxyAsync>d__19>(ref <CreateGridProxyAsync>d__);
			return <CreateGridProxyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025797 RID: 153495 RVA: 0x00A8E67C File Offset: 0x00A8C87C
		[NullableContext(2)]
		public TProxy GetGridProxy(int displayIndex)
		{
			if (displayIndex >= this.ProxyValidBits.Count || displayIndex < 0 || !this.ProxyValidBits[displayIndex])
			{
				return default(TProxy);
			}
			if (displayIndex < this.Proxies.Count)
			{
				return this.Proxies[displayIndex];
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ScrollViewGrid;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "无法获取Proxy";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DisplayIndex", displayIndex);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return default(TProxy);
		}

		// Token: 0x06025798 RID: 153496 RVA: 0x00A8E703 File Offset: 0x00A8C903
		public void ClearGridProxy(int gridIndex, int displayIndex)
		{
			TProxy tproxy = this.GetGridProxy(displayIndex);
			if (tproxy == null)
			{
				return;
			}
			tproxy.Clear();
		}

		// Token: 0x06025799 RID: 153497 RVA: 0x00A8E71C File Offset: 0x00A8C91C
		public void SelectGridProxy(int gridIndex, int displayIndex, bool fireEvent)
		{
			if (this.SelectedGridIndex == gridIndex)
			{
				return;
			}
			this.DeselectCurrentGridProxy(fireEvent);
			TProxy gridProxy = this.GetGridProxy(displayIndex);
			if (gridProxy != null)
			{
				gridProxy.OnSelected(fireEvent);
				this.SelectedProxy = gridProxy;
			}
			this.SelectedGridIndex = gridIndex;
		}

		// Token: 0x0602579A RID: 153498 RVA: 0x00A8E764 File Offset: 0x00A8C964
		public void DeselectCurrentGridProxy(bool fireEvent)
		{
			this.SelectedGridIndex = -1;
			if (this.SelectedProxy != null)
			{
				this.SelectedProxy.OnDeselected(fireEvent);
				this.SelectedProxy = default(TProxy);
			}
		}

		// Token: 0x0602579B RID: 153499 RVA: 0x00A8E797 File Offset: 0x00A8C997
		public void ClearSelectInfo()
		{
			this.SelectedGridIndex = -1;
			this.SelectedProxy = default(TProxy);
		}

		// Token: 0x0602579C RID: 153500 RVA: 0x00A8E7AC File Offset: 0x00A8C9AC
		[NullableContext(2)]
		public TProxy GetSelectedProxy()
		{
			return this.SelectedProxy;
		}

		// Token: 0x0602579D RID: 153501 RVA: 0x00A8E7B4 File Offset: 0x00A8C9B4
		public int GetSelectedGridIndex()
		{
			return this.SelectedGridIndex;
		}

		// Token: 0x0602579E RID: 153502 RVA: 0x00A8E7BC File Offset: 0x00A8C9BC
		public int GetDataLength()
		{
			return this.DataLength;
		}

		// Token: 0x0602579F RID: 153503 RVA: 0x00A8E7C4 File Offset: 0x00A8C9C4
		public bool IsProxyValid(int displayIndex)
		{
			return displayIndex < this.ProxyValidBits.Count && this.ProxyValidBits[displayIndex];
		}

		// Token: 0x060257A0 RID: 153504 RVA: 0x00A8E7E2 File Offset: 0x00A8C9E2
		public void ClearData()
		{
			this.Data.Clear();
			this.DataLength = 0;
		}

		// Token: 0x060257A1 RID: 153505 RVA: 0x00A8E7F8 File Offset: 0x00A8C9F8
		public void Destroy()
		{
			this.ClearData();
			foreach (TProxy tproxy in this.Proxies)
			{
				tproxy.ScrollViewDelegate = null;
			}
			this.Proxies.Clear();
			this.ProxyValidBits.Clear();
			this.ProxyCreateFunction = null;
			this.DataProxyFunction = null;
		}

		// Token: 0x04014B76 RID: 84854
		private List<TData> Data = new List<TData>();

		// Token: 0x04014B77 RID: 84855
		private int DataLength;

		// Token: 0x04014B78 RID: 84856
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<TProxy> Proxies = new List<TProxy>();

		// Token: 0x04014B79 RID: 84857
		private readonly List<bool> ProxyValidBits = new List<bool>();

		// Token: 0x04014B7A RID: 84858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<TProxy> ProxyCreateFunction;

		// Token: 0x04014B7B RID: 84859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, TData> DataProxyFunction;

		// Token: 0x04014B7C RID: 84860
		private bool IsCacheProxyData;

		// Token: 0x04014B7D RID: 84861
		private int SelectedGridIndex = -1;

		// Token: 0x04014B7E RID: 84862
		[Nullable(2)]
		private TProxy SelectedProxy;
	}
}
