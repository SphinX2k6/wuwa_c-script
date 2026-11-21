using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DataLayerSwitch
{
	// Token: 0x02004AB2 RID: 19122
	[NullableContext(2)]
	[Nullable(0)]
	public class DataLayerSwitchContext
	{
		// Token: 0x17006001 RID: 24577
		// (get) Token: 0x0602FD7E RID: 195966 RVA: 0x00D5A665 File Offset: 0x00D58865
		public bool DataLayerSwitching
		{
			get
			{
				return this.DataLayerSwitchingInternal;
			}
		}

		// Token: 0x17006002 RID: 24578
		// (get) Token: 0x0602FD7F RID: 195967 RVA: 0x00D5A66D File Offset: 0x00D5886D
		public bool DataLayerStreaming
		{
			get
			{
				return this.DataLayerStreamingInternal;
			}
		}

		// Token: 0x17006003 RID: 24579
		// (get) Token: 0x0602FD80 RID: 195968 RVA: 0x00D5A675 File Offset: 0x00D58875
		public int CurrentSwitchInstId
		{
			get
			{
				return this.CurrentSwitchInstIdInternal;
			}
		}

		// Token: 0x17006004 RID: 24580
		// (get) Token: 0x0602FD81 RID: 195969 RVA: 0x00D5A67D File Offset: 0x00D5887D
		public bool DataLayerSwitchAborted
		{
			get
			{
				return this.DataLayerSwitchAbortedInternal;
			}
		}

		// Token: 0x17006005 RID: 24581
		// (get) Token: 0x0602FD82 RID: 195970 RVA: 0x00D5A685 File Offset: 0x00D58885
		public CustomPromise<bool> DataLayerSwitchAbortPromise
		{
			get
			{
				return this.DataLayerSwitchAbortPromiseInternal;
			}
		}

		// Token: 0x0602FD83 RID: 195971 RVA: 0x00D5A690 File Offset: 0x00D58890
		public void ResetDataLayerSwitchAbort()
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.ZYL, "DataLayerSwitchContext:重置打断标志并新建打断信号", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.DataLayerSwitchAbortedInternal = false;
			this.DataLayerSwitchAbortPromiseInternal = new CustomPromise<bool>();
		}

		// Token: 0x0602FD84 RID: 195972 RVA: 0x00D5A6CC File Offset: 0x00D588CC
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

		// Token: 0x0602FD85 RID: 195973 RVA: 0x00D5A758 File Offset: 0x00D58958
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

		// Token: 0x17006006 RID: 24582
		// (get) Token: 0x0602FD86 RID: 195974 RVA: 0x00D5A7B3 File Offset: 0x00D589B3
		public CustomPromise<bool> DataLayerChangeVoxelPromise
		{
			get
			{
				return this.DataLayerChangeVoxelPromiseInternal;
			}
		}

		// Token: 0x17006007 RID: 24583
		// (get) Token: 0x0602FD87 RID: 195975 RVA: 0x00D5A7BB File Offset: 0x00D589BB
		public CustomPromise<bool> DataLayerChangeStreamingPromise
		{
			get
			{
				return this.DataLayerChangeStreamingPromiseInternal;
			}
		}

		// Token: 0x0602FD88 RID: 195976 RVA: 0x00D5A7C4 File Offset: 0x00D589C4
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

		// Token: 0x0602FD89 RID: 195977 RVA: 0x00D5A82C File Offset: 0x00D58A2C
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

		// Token: 0x0602FD8A RID: 195978 RVA: 0x00D5A874 File Offset: 0x00D58A74
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

		// Token: 0x04019658 RID: 104024
		private bool DataLayerSwitchingInternal;

		// Token: 0x04019659 RID: 104025
		private bool DataLayerStreamingInternal;

		// Token: 0x0401965A RID: 104026
		private int CurrentSwitchInstIdInternal;

		// Token: 0x0401965B RID: 104027
		private bool DataLayerSwitchAbortedInternal;

		// Token: 0x0401965C RID: 104028
		private CustomPromise<bool> DataLayerSwitchAbortPromiseInternal;

		// Token: 0x0401965D RID: 104029
		private CustomPromise<bool> DataLayerChangeVoxelPromiseInternal;

		// Token: 0x0401965E RID: 104030
		private CustomPromise<bool> DataLayerChangeStreamingPromiseInternal;
	}
}
