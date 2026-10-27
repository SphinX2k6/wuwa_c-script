using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048E1 RID: 18657
	[NullableContext(1)]
	[Nullable(0)]
	public class ScrollViewDelegate<TProxy, [Nullable(2)] TData> : IScrollViewDelegate<TProxy, TData> where TProxy : class, IGridProxy<TData>
	{
		// Token: 0x06030C5F RID: 199775 RVA: 0x00B532C6 File Offset: 0x00B514C6
		public ScrollViewDelegate(Func<TProxy> proxyCreateFunction)
		{
			this.ProxyCreateFunction = proxyCreateFunction;
		}

		// Token: 0x06030C60 RID: 199776 RVA: 0x00B532FD File Offset: 0x00B514FD
		public void SetData(IReadOnlyList<TData> data)
		{
			this.ClearData();
			this.Data.AddRange(data);
			this.DataLength = this.Data.Count;
		}

		// Token: 0x06030C61 RID: 199777 RVA: 0x00B53322 File Offset: 0x00B51522
		public IReadOnlyList<TData> GetDatas()
		{
			return this.Data.AsReadOnly();
		}

		// Token: 0x06030C62 RID: 199778 RVA: 0x00B5332F File Offset: 0x00B5152F
		public void SetDataProxy(Func<int, TData> dataProxyFunction, int dataLength, bool cacheData = true)
		{
			this.ClearData();
			this.DataProxyFunction = dataProxyFunction;
			this.DataLength = dataLength;
			this.IsCacheProxyData = cacheData;
		}

		// Token: 0x06030C63 RID: 199779 RVA: 0x00B5334C File Offset: 0x00B5154C
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

		// Token: 0x06030C64 RID: 199780 RVA: 0x00B53448 File Offset: 0x00B51648
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

		// Token: 0x06030C65 RID: 199781 RVA: 0x00B535EC File Offset: 0x00B517EC
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

		// Token: 0x06030C66 RID: 199782 RVA: 0x00B53640 File Offset: 0x00B51840
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

		// Token: 0x06030C67 RID: 199783 RVA: 0x00B536B4 File Offset: 0x00B518B4
		[NullableContext(2)]
		public TData TryGetCachedData(int gridIndex)
		{
			if (this.Data.Count > gridIndex)
			{
				return this.Data[gridIndex];
			}
			return default(TData);
		}

		// Token: 0x06030C68 RID: 199784 RVA: 0x00B536E8 File Offset: 0x00B518E8
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

		// Token: 0x06030C69 RID: 199785 RVA: 0x00B537B0 File Offset: 0x00B519B0
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

		// Token: 0x06030C6A RID: 199786 RVA: 0x00B5380C File Offset: 0x00B51A0C
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

		// Token: 0x06030C6B RID: 199787 RVA: 0x00B53893 File Offset: 0x00B51A93
		public void ClearGridProxy(int gridIndex, int displayIndex)
		{
			TProxy tproxy = this.GetGridProxy(displayIndex);
			if (tproxy == null)
			{
				return;
			}
			tproxy.Clear();
		}

		// Token: 0x06030C6C RID: 199788 RVA: 0x00B538AC File Offset: 0x00B51AAC
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

		// Token: 0x06030C6D RID: 199789 RVA: 0x00B538F4 File Offset: 0x00B51AF4
		public void DeselectCurrentGridProxy(bool fireEvent)
		{
			this.SelectedGridIndex = -1;
			if (this.SelectedProxy != null)
			{
				this.SelectedProxy.OnDeselected(fireEvent);
				this.SelectedProxy = default(TProxy);
			}
		}

		// Token: 0x06030C6E RID: 199790 RVA: 0x00B53927 File Offset: 0x00B51B27
		public void ClearSelectInfo()
		{
			this.SelectedGridIndex = -1;
			this.SelectedProxy = default(TProxy);
		}

		// Token: 0x06030C6F RID: 199791 RVA: 0x00B5393C File Offset: 0x00B51B3C
		[NullableContext(2)]
		public TProxy GetSelectedProxy()
		{
			return this.SelectedProxy;
		}

		// Token: 0x06030C70 RID: 199792 RVA: 0x00B53944 File Offset: 0x00B51B44
		public int GetSelectedGridIndex()
		{
			return this.SelectedGridIndex;
		}

		// Token: 0x06030C71 RID: 199793 RVA: 0x00B5394C File Offset: 0x00B51B4C
		public int GetDataLength()
		{
			return this.DataLength;
		}

		// Token: 0x06030C72 RID: 199794 RVA: 0x00B53954 File Offset: 0x00B51B54
		public bool IsProxyValid(int displayIndex)
		{
			return displayIndex < this.ProxyValidBits.Count && this.ProxyValidBits[displayIndex];
		}

		// Token: 0x06030C73 RID: 199795 RVA: 0x00B53972 File Offset: 0x00B51B72
		public void ClearData()
		{
			this.Data.Clear();
			this.DataLength = 0;
		}

		// Token: 0x06030C74 RID: 199796 RVA: 0x00B53988 File Offset: 0x00B51B88
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

		// Token: 0x0401A303 RID: 107267
		private List<TData> Data = new List<TData>();

		// Token: 0x0401A304 RID: 107268
		private int DataLength;

		// Token: 0x0401A305 RID: 107269
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<TProxy> Proxies = new List<TProxy>();

		// Token: 0x0401A306 RID: 107270
		private readonly List<bool> ProxyValidBits = new List<bool>();

		// Token: 0x0401A307 RID: 107271
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<TProxy> ProxyCreateFunction;

		// Token: 0x0401A308 RID: 107272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, TData> DataProxyFunction;

		// Token: 0x0401A309 RID: 107273
		private bool IsCacheProxyData;

		// Token: 0x0401A30A RID: 107274
		private int SelectedGridIndex = -1;

		// Token: 0x0401A30B RID: 107275
		[Nullable(2)]
		private TProxy SelectedProxy;
	}
}
