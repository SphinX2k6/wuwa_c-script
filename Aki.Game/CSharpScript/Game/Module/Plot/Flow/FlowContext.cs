using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x0200406B RID: 16491
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowContext : IStaticVariableResetter
	{
		// Token: 0x06029D11 RID: 171281 RVA: 0x00BCFE2E File Offset: 0x00BCE02E
		static FlowContext()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowContext.CreateStaticDefaultValue), new Action(FlowContext.ResetStaticDefaultValue));
		}

		// Token: 0x1700544C RID: 21580
		// (get) Token: 0x06029D12 RID: 171282 RVA: 0x00BCFE4D File Offset: 0x00BCE04D
		public static Pool<FlowContext> Pool
		{
			get
			{
				return FlowContext._pool;
			}
		}

		// Token: 0x06029D13 RID: 171283 RVA: 0x00BCFE54 File Offset: 0x00BCE054
		public FlowContext()
		{
			this.IsServerNotify = false;
			this.FlowListName = "";
			this.FlowId = 0;
			this.FlowStateId = 0;
			this.Context = null;
			this.CurActionId = 0;
			this.IsWaitRenderData = true;
			this.CurSubActionId = 0;
			this.CurShowTalk = null;
			this.CurShowTalkActionId = 0;
			this.CurTalkId = -1;
			this.CurOptionId = -1;
			this.IsBackground = false;
			this.IsSegmentSkipping = false;
			this.HasSkipped = false;
			this.IsFadeSkip = false;
			this.IsBreakdown = false;
			this.HasClientError = false;
			this.IsServerEnd = false;
			this.IsAsync = false;
			this.FlowIncId = 0L;
			this.HasAdjustCamera = false;
			this.CanSkip = false;
			this.TalkHistory = new List<TalkRecord>();
			this.OptionsHistory = new Dictionary<int, Dictionary<int, int>>();
			this.OptionsCollection = new List<ValueTuple<int, List<ValueTuple<int, int>>>>();
			this.UiParam = null;
			this.FormatIdInner = null;
			this.Pos = null;
			this.RollbackRecord = new List<ActionRecord>();
			this.KeepMainRolePose = false;
			this.SeamlessPlot = false;
			this.DeferredFinalizeFlags = ESeamlessFinalizeFlag.None;
			this.NeedPreloadUiSequenceData = null;
			this.PromptStyle = null;
			this.Callback = null;
		}

		// Token: 0x06029D14 RID: 171284 RVA: 0x00BCFF80 File Offset: 0x00BCE180
		public void Init(PlotInfo p, bool isSkip)
		{
			this.Clear();
			this.IsServerNotify = p.IsServerNotify;
			this.FlowIncId = p.FlowIncId;
			this.FlowListName = p.FlowListName;
			this.FlowId = p.FlowId;
			this.IsBackground = isSkip;
			this.IsBreakdown = p.IsBreakdown;
			this.Context = p.Context;
			this.IsAsync = p.IsAsync;
			this.UiParam = p.UiParam;
			this.FlowStateId = p.StateId.GetValueOrDefault();
			this.Pos = p.Pos;
			this.KeepMainRolePose = p.KeepMainRolePose;
			this.SeamlessPlot = p.Seamless;
			this.IsServerEnd = p.IsServerEnd;
			if (p.PreloadSequenceUiData != null)
			{
				this.NeedPreloadUiSequenceData = new List<string>();
				this.NeedPreloadUiSequenceData.AddRange(p.PreloadSequenceUiData);
			}
			this.PromptStyle = p.PromptStyle;
			this.Callback = p.Callback;
		}

		// Token: 0x06029D15 RID: 171285 RVA: 0x00BD0078 File Offset: 0x00BCE278
		private void Clear()
		{
			this.FlowIncId = -1L;
			this.Context = null;
			this.CurActionId = 0;
			this.CurSubActionId = 0;
			this.IsAsync = false;
			this.CurShowTalk = null;
			this.CurTalkId = -1;
			this.CurOptionId = -1;
			this.IsBackground = false;
			this.IsSegmentSkipping = false;
			this.HasSkipped = false;
			this.IsBreakdown = false;
			this.HasClientError = false;
			this.IsServerEnd = false;
			this.HasAdjustCamera = false;
			this.TalkHistory.Clear();
			this.OptionsHistory.Clear();
			this.OptionsCollection.Clear();
			this.UiParam = null;
			this.FlowListName = "";
			this.FlowId = 0;
			this.FlowStateId = 0;
			this.FormatIdInner = null;
			this.CanSkip = false;
			this.CurShowTalkActionId = 0;
			this.IsFadeSkip = false;
			this.Pos = null;
			this.RollbackRecord.Clear();
			this.KeepMainRolePose = false;
			this.SeamlessPlot = false;
			this.DeferredFinalizeFlags = ESeamlessFinalizeFlag.None;
			this.NeedPreloadUiSequenceData = null;
			this.PromptStyle = null;
			this.Callback = null;
		}

		// Token: 0x06029D16 RID: 171286 RVA: 0x00BD018D File Offset: 0x00BCE38D
		public void AddDeferredFinalizeFlag(ESeamlessFinalizeFlag flag)
		{
			this.DeferredFinalizeFlags |= flag;
		}

		// Token: 0x06029D17 RID: 171287 RVA: 0x00BD019D File Offset: 0x00BCE39D
		public ESeamlessFinalizeFlag ConsumeDeferredFinalizeFlags()
		{
			ESeamlessFinalizeFlag deferredFinalizeFlags = this.DeferredFinalizeFlags;
			this.DeferredFinalizeFlags = ESeamlessFinalizeFlag.None;
			return deferredFinalizeFlags;
		}

		// Token: 0x06029D18 RID: 171288 RVA: 0x00BD01AC File Offset: 0x00BCE3AC
		public static FlowContext Create()
		{
			return FlowContext.Pool.Get() ?? FlowContext.Pool.Create();
		}

		// Token: 0x06029D19 RID: 171289 RVA: 0x00BD01C6 File Offset: 0x00BCE3C6
		public void Recycle()
		{
			this.Clear();
			FlowContext.Pool.Put(this);
		}

		// Token: 0x1700544D RID: 21581
		// (get) Token: 0x06029D1A RID: 171290 RVA: 0x00BD01DC File Offset: 0x00BCE3DC
		public string FormatId
		{
			get
			{
				if (this.FormatIdInner == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
					defaultInterpolatedStringHandler.AppendFormatted(this.FlowListName);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.FlowId);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.FlowStateId);
					this.FormatIdInner = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				return this.FormatIdInner;
			}
		}

		// Token: 0x06029D1B RID: 171291 RVA: 0x00BD024C File Offset: 0x00BCE44C
		public void LogError(string text, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[Flow] " + text;
			ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
			int num = 0;
			ValueTuple<string, object>[] array = new ValueTuple<string, object>[5 + readOnlySpan.Length];
			readOnlySpan.CopyTo(new Span<ValueTuple<string, object>>(array).Slice(num, readOnlySpan.Length));
			num += readOnlySpan.Length;
			array[num] = new ValueTuple<string, object>("IncId", this.FlowIncId);
			num++;
			array[num] = new ValueTuple<string, object>("Id", this.FormatId);
			num++;
			array[num] = new ValueTuple<string, object>("ActionId", this.CurActionId);
			num++;
			array[num] = new ValueTuple<string, object>("SubActionId", this.CurSubActionId);
			num++;
			array[num] = new ValueTuple<string, object>("TalkId", this.CurTalkId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(array));
		}

		// Token: 0x06029D1C RID: 171292 RVA: 0x00BD0349 File Offset: 0x00BCE549
		public static void CreateStaticDefaultValue()
		{
			FlowContext._pool = new Pool<FlowContext>(20, () => new FlowContext(), null);
		}

		// Token: 0x06029D1D RID: 171293 RVA: 0x00BD0377 File Offset: 0x00BCE577
		public static void ResetStaticDefaultValue()
		{
			FlowContext._pool = null;
		}

		// Token: 0x04016CC5 RID: 93381
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Pool<FlowContext> _pool;

		// Token: 0x04016CC6 RID: 93382
		public bool IsServerNotify;

		// Token: 0x04016CC7 RID: 93383
		public string FlowListName;

		// Token: 0x04016CC8 RID: 93384
		public int FlowId;

		// Token: 0x04016CC9 RID: 93385
		public int FlowStateId;

		// Token: 0x04016CCA RID: 93386
		[Nullable(2)]
		public GeneralContext Context;

		// Token: 0x04016CCB RID: 93387
		public int CurActionId;

		// Token: 0x04016CCC RID: 93388
		public bool IsWaitRenderData;

		// Token: 0x04016CCD RID: 93389
		public int CurSubActionId;

		// Token: 0x04016CCE RID: 93390
		[Nullable(2)]
		public ShowTalk CurShowTalk;

		// Token: 0x04016CCF RID: 93391
		public int CurShowTalkActionId;

		// Token: 0x04016CD0 RID: 93392
		public int CurTalkId;

		// Token: 0x04016CD1 RID: 93393
		public int CurOptionId;

		// Token: 0x04016CD2 RID: 93394
		public bool IsBackground;

		// Token: 0x04016CD3 RID: 93395
		public bool IsSegmentSkipping;

		// Token: 0x04016CD4 RID: 93396
		public bool HasSkipped;

		// Token: 0x04016CD5 RID: 93397
		public bool IsFadeSkip;

		// Token: 0x04016CD6 RID: 93398
		public bool IsBreakdown;

		// Token: 0x04016CD7 RID: 93399
		public bool HasClientError;

		// Token: 0x04016CD8 RID: 93400
		public bool IsServerEnd;

		// Token: 0x04016CD9 RID: 93401
		public bool IsAsync;

		// Token: 0x04016CDA RID: 93402
		public long FlowIncId;

		// Token: 0x04016CDB RID: 93403
		public bool HasAdjustCamera;

		// Token: 0x04016CDC RID: 93404
		public bool CanSkip;

		// Token: 0x04016CDD RID: 93405
		public List<TalkRecord> TalkHistory;

		// Token: 0x04016CDE RID: 93406
		public Dictionary<int, Dictionary<int, int>> OptionsHistory;

		// Token: 0x04016CDF RID: 93407
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0
		})]
		public List<ValueTuple<int, List<ValueTuple<int, int>>>> OptionsCollection;

		// Token: 0x04016CE0 RID: 93408
		[Nullable(2)]
		public UiParam UiParam;

		// Token: 0x04016CE1 RID: 93409
		[Nullable(2)]
		public string FormatIdInner;

		// Token: 0x04016CE2 RID: 93410
		[Nullable(2)]
		public Vector Pos;

		// Token: 0x04016CE3 RID: 93411
		public List<ActionRecord> RollbackRecord;

		// Token: 0x04016CE4 RID: 93412
		public bool KeepMainRolePose;

		// Token: 0x04016CE5 RID: 93413
		public bool SeamlessPlot;

		// Token: 0x04016CE6 RID: 93414
		public ESeamlessFinalizeFlag DeferredFinalizeFlags;

		// Token: 0x04016CE7 RID: 93415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> NeedPreloadUiSequenceData;

		// Token: 0x04016CE8 RID: 93416
		public EPromptStyle? PromptStyle;

		// Token: 0x04016CE9 RID: 93417
		[Nullable(2)]
		public Action Callback;
	}
}
