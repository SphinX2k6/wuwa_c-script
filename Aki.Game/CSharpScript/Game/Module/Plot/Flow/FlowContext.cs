using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x0200509B RID: 20635
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowContext : IStaticVariableResetter
	{
		// Token: 0x06034E18 RID: 216600 RVA: 0x00C82C0E File Offset: 0x00C80E0E
		static FlowContext()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlowContext.CreateStaticDefaultValue), new Action(FlowContext.ResetStaticDefaultValue));
		}

		// Token: 0x1700808C RID: 32908
		// (get) Token: 0x06034E19 RID: 216601 RVA: 0x00C82C2D File Offset: 0x00C80E2D
		public static Pool<FlowContext> Pool
		{
			get
			{
				return FlowContext._pool;
			}
		}

		// Token: 0x06034E1A RID: 216602 RVA: 0x00C82C34 File Offset: 0x00C80E34
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

		// Token: 0x06034E1B RID: 216603 RVA: 0x00C82D60 File Offset: 0x00C80F60
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

		// Token: 0x06034E1C RID: 216604 RVA: 0x00C82E58 File Offset: 0x00C81058
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

		// Token: 0x06034E1D RID: 216605 RVA: 0x00C82F6D File Offset: 0x00C8116D
		public void AddDeferredFinalizeFlag(ESeamlessFinalizeFlag flag)
		{
			this.DeferredFinalizeFlags |= flag;
		}

		// Token: 0x06034E1E RID: 216606 RVA: 0x00C82F7D File Offset: 0x00C8117D
		public ESeamlessFinalizeFlag ConsumeDeferredFinalizeFlags()
		{
			ESeamlessFinalizeFlag deferredFinalizeFlags = this.DeferredFinalizeFlags;
			this.DeferredFinalizeFlags = ESeamlessFinalizeFlag.None;
			return deferredFinalizeFlags;
		}

		// Token: 0x06034E1F RID: 216607 RVA: 0x00C82F8C File Offset: 0x00C8118C
		public static FlowContext Create()
		{
			return FlowContext.Pool.Get() ?? FlowContext.Pool.Create();
		}

		// Token: 0x06034E20 RID: 216608 RVA: 0x00C82FA6 File Offset: 0x00C811A6
		public void Recycle()
		{
			this.Clear();
			FlowContext.Pool.Put(this);
		}

		// Token: 0x1700808D RID: 32909
		// (get) Token: 0x06034E21 RID: 216609 RVA: 0x00C82FBC File Offset: 0x00C811BC
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

		// Token: 0x06034E22 RID: 216610 RVA: 0x00C8302C File Offset: 0x00C8122C
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

		// Token: 0x06034E23 RID: 216611 RVA: 0x00C83129 File Offset: 0x00C81329
		public static void CreateStaticDefaultValue()
		{
			FlowContext._pool = new Pool<FlowContext>(20, () => new FlowContext(), null);
		}

		// Token: 0x06034E24 RID: 216612 RVA: 0x00C83157 File Offset: 0x00C81357
		public static void ResetStaticDefaultValue()
		{
			FlowContext._pool = null;
		}

		// Token: 0x0401C296 RID: 115350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Pool<FlowContext> _pool;

		// Token: 0x0401C297 RID: 115351
		public bool IsServerNotify;

		// Token: 0x0401C298 RID: 115352
		public string FlowListName;

		// Token: 0x0401C299 RID: 115353
		public int FlowId;

		// Token: 0x0401C29A RID: 115354
		public int FlowStateId;

		// Token: 0x0401C29B RID: 115355
		[Nullable(2)]
		public GeneralContext Context;

		// Token: 0x0401C29C RID: 115356
		public int CurActionId;

		// Token: 0x0401C29D RID: 115357
		public bool IsWaitRenderData;

		// Token: 0x0401C29E RID: 115358
		public int CurSubActionId;

		// Token: 0x0401C29F RID: 115359
		[Nullable(2)]
		public ShowTalk CurShowTalk;

		// Token: 0x0401C2A0 RID: 115360
		public int CurShowTalkActionId;

		// Token: 0x0401C2A1 RID: 115361
		public int CurTalkId;

		// Token: 0x0401C2A2 RID: 115362
		public int CurOptionId;

		// Token: 0x0401C2A3 RID: 115363
		public bool IsBackground;

		// Token: 0x0401C2A4 RID: 115364
		public bool IsSegmentSkipping;

		// Token: 0x0401C2A5 RID: 115365
		public bool HasSkipped;

		// Token: 0x0401C2A6 RID: 115366
		public bool IsFadeSkip;

		// Token: 0x0401C2A7 RID: 115367
		public bool IsBreakdown;

		// Token: 0x0401C2A8 RID: 115368
		public bool HasClientError;

		// Token: 0x0401C2A9 RID: 115369
		public bool IsServerEnd;

		// Token: 0x0401C2AA RID: 115370
		public bool IsAsync;

		// Token: 0x0401C2AB RID: 115371
		public long FlowIncId;

		// Token: 0x0401C2AC RID: 115372
		public bool HasAdjustCamera;

		// Token: 0x0401C2AD RID: 115373
		public bool CanSkip;

		// Token: 0x0401C2AE RID: 115374
		public List<TalkRecord> TalkHistory;

		// Token: 0x0401C2AF RID: 115375
		public Dictionary<int, Dictionary<int, int>> OptionsHistory;

		// Token: 0x0401C2B0 RID: 115376
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0
		})]
		public List<ValueTuple<int, List<ValueTuple<int, int>>>> OptionsCollection;

		// Token: 0x0401C2B1 RID: 115377
		[Nullable(2)]
		public UiParam UiParam;

		// Token: 0x0401C2B2 RID: 115378
		[Nullable(2)]
		public string FormatIdInner;

		// Token: 0x0401C2B3 RID: 115379
		[Nullable(2)]
		public Vector Pos;

		// Token: 0x0401C2B4 RID: 115380
		public List<ActionRecord> RollbackRecord;

		// Token: 0x0401C2B5 RID: 115381
		public bool KeepMainRolePose;

		// Token: 0x0401C2B6 RID: 115382
		public bool SeamlessPlot;

		// Token: 0x0401C2B7 RID: 115383
		public ESeamlessFinalizeFlag DeferredFinalizeFlags;

		// Token: 0x0401C2B8 RID: 115384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> NeedPreloadUiSequenceData;

		// Token: 0x0401C2B9 RID: 115385
		public EPromptStyle? PromptStyle;

		// Token: 0x0401C2BA RID: 115386
		[Nullable(2)]
		public Action Callback;
	}
}
