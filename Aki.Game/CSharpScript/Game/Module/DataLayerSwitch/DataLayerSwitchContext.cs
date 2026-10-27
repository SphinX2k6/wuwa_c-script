using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DataLayerSwitch
{
	// Token: 0x02005AD1 RID: 23249
	[NullableContext(2)]
	[Nullable(0)]
	public class DataLayerSwitchContext
	{
		// Token: 0x17008C27 RID: 35879
		// (get) Token: 0x0603AE0C RID: 241164 RVA: 0x00E09985 File Offset: 0x00E07B85
		public bool DataLayerSwitching
		{
			get
			{
				return this.DataLayerSwitchingInternal;
			}
		}

		// Token: 0x17008C28 RID: 35880
		// (get) Token: 0x0603AE0D RID: 241165 RVA: 0x00E0998D File Offset: 0x00E07B8D
		public bool DataLayerStreaming
		{
			get
			{
				return this.DataLayerStreamingInternal;
			}
		}

		// Token: 0x17008C29 RID: 35881
		// (get) Token: 0x0603AE0E RID: 241166 RVA: 0x00E09995 File Offset: 0x00E07B95
		public int CurrentSwitchInstId
		{
			get
			{
				return this.CurrentSwitchInstIdInternal;
			}
		}

		// Token: 0x17008C2A RID: 35882
		// (get) Token: 0x0603AE0F RID: 241167 RVA: 0x00E0999D File Offset: 0x00E07B9D
		public bool DataLayerSwitchAborted
		{
			get
			{
				return this.DataLayerSwitchAbortedInternal;
			}
		}

		// Token: 0x17008C2B RID: 35883
		// (get) Token: 0x0603AE10 RID: 241168 RVA: 0x00E099A5 File Offset: 0x00E07BA5
		public CustomPromise<bool> DataLayerSwitchAbortPromise
		{
			get
			{
				return this.DataLayerSwitchAbortPromiseInternal;
			}
		}

		// Token: 0x0603AE11 RID: 241169 RVA: 0x00E099B0 File Offset: 0x00E07BB0
		public void ResetDataLayerSwitchAbort()
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.ZYL, "DataLayerSwitchContext:重置打断标志并新建打断信号", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.DataLayerSwitchAbortedInternal = false;
			this.DataLayerSwitchAbortPromiseInternal = new CustomPromise<bool>();
		}

		// Token: 0x0603AE12 RID: 241170 RVA: 0x00E099EC File Offset: 0x00E07BEC
		public unsafe void AbortDataLayerSwitch()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "DataLayerSwitchContext:打断DataLayer切换";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("InstId", this.CurrentSwitchInstIdInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("已打断", this.DataLayerSwitchAbortedInternal);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.DataLayerSwitchAbortedInternal = true;
			CustomPromise<bool> dataLayerSwitchAbortPromiseInternal = this.DataLayerSwitchAbortPromiseInternal;
			if (dataLayerSwitchAbortPromiseInternal == null)
			{
				return;
			}
			dataLayerSwitchAbortPromiseInternal.SetResult(true);
		}

		// Token: 0x0603AE13 RID: 241171 RVA: 0x00E09A78 File Offset: 0x00E07C78
		public void InitDataLayerStreamingData()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "DataLayerSwitchContext:初始化流送数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", this.CurrentSwitchInstIdInternal);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DataLayerStreamingInternal = true;
			this.DataLayerChangeVoxelPromiseInternal = new CustomPromise<bool>();
			this.DataLayerChangeStreamingPromiseInternal = new CustomPromise<bool>();
		}

		// Token: 0x17008C2C RID: 35884
		// (get) Token: 0x0603AE14 RID: 241172 RVA: 0x00E09AD3 File Offset: 0x00E07CD3
		public CustomPromise<bool> DataLayerChangeVoxelPromise
		{
			get
			{
				return this.DataLayerChangeVoxelPromiseInternal;
			}
		}

		// Token: 0x17008C2D RID: 35885
		// (get) Token: 0x0603AE15 RID: 241173 RVA: 0x00E09ADB File Offset: 0x00E07CDB
		public CustomPromise<bool> DataLayerChangeStreamingPromise
		{
			get
			{
				return this.DataLayerChangeStreamingPromiseInternal;
			}
		}

		// Token: 0x0603AE16 RID: 241174 RVA: 0x00E09AE4 File Offset: 0x00E07CE4
		public void ClearDataLayerStreamingData()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "DataLayerSwitchContext:清理流送数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", this.CurrentSwitchInstIdInternal);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DataLayerStreamingInternal = false;
			CustomPromise<bool> dataLayerChangeVoxelPromiseInternal = this.DataLayerChangeVoxelPromiseInternal;
			if (dataLayerChangeVoxelPromiseInternal != null)
			{
				dataLayerChangeVoxelPromiseInternal.SetResult(true);
			}
			CustomPromise<bool> dataLayerChangeStreamingPromiseInternal = this.DataLayerChangeStreamingPromiseInternal;
			if (dataLayerChangeStreamingPromiseInternal == null)
			{
				return;
			}
			dataLayerChangeStreamingPromiseInternal.SetResult(true);
		}

		// Token: 0x0603AE17 RID: 241175 RVA: 0x00E09B4C File Offset: 0x00E07D4C
		public void BeginDataLayerSwitch(int currentSwitchInstId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "DataLayerSwitchContext:开始DataLayer切换";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", currentSwitchInstId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DataLayerSwitchingInternal = true;
			this.CurrentSwitchInstIdInternal = currentSwitchInstId;
		}

		// Token: 0x0603AE18 RID: 241176 RVA: 0x00E09B94 File Offset: 0x00E07D94
		public void FinishDataLayerSwitch()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "DataLayerSwitchContext:结束DataLayer切换";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", this.CurrentSwitchInstIdInternal);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DataLayerSwitchingInternal = false;
			this.CurrentSwitchInstIdInternal = 0;
		}

		// Token: 0x0401EB9C RID: 125852
		private bool DataLayerSwitchingInternal;

		// Token: 0x0401EB9D RID: 125853
		private bool DataLayerStreamingInternal;

		// Token: 0x0401EB9E RID: 125854
		private int CurrentSwitchInstIdInternal;

		// Token: 0x0401EB9F RID: 125855
		private bool DataLayerSwitchAbortedInternal;

		// Token: 0x0401EBA0 RID: 125856
		private CustomPromise<bool> DataLayerSwitchAbortPromiseInternal;

		// Token: 0x0401EBA1 RID: 125857
		private CustomPromise<bool> DataLayerChangeVoxelPromiseInternal;

		// Token: 0x0401EBA2 RID: 125858
		private CustomPromise<bool> DataLayerChangeStreamingPromiseInternal;
	}
}
