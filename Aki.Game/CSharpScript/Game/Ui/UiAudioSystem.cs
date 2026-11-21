using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003551 RID: 13649
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class UiAudioSystem : ControllerBase
	{
		// Token: 0x06022B2B RID: 142123 RVA: 0x009DE858 File Offset: 0x009DCA58
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x06022B2C RID: 142124 RVA: 0x009DE861 File Offset: 0x009DCA61
		protected override bool OnClear()
		{
			this.RemoveEvents();
			this.ClearBgmState();
			this.AudioCovers.Clear();
			this.RefreshAudioCover();
			return true;
		}

		// Token: 0x17004896 RID: 18582
		// (get) Token: 0x06022B2D RID: 142125 RVA: 0x009DE881 File Offset: 0x009DCA81
		// (set) Token: 0x06022B2E RID: 142126 RVA: 0x009DE889 File Offset: 0x009DCA89
		public bool BgmEnabled
		{
			get
			{
				return this.BgmEnabledInternal;
			}
			set
			{
				if (this.BgmEnabledInternal == value)
				{
					return;
				}
				this.BgmEnabledInternal = value;
				this.RefreshPlayingBgm();
			}
		}

		// Token: 0x06022B2F RID: 142127 RVA: 0x009DE8A2 File Offset: 0x009DCAA2
		internal void ActivateViewBgm(UiViewBase view)
		{
			this.ActiveBgmViewIds.Add(view.ComponentId);
			this.RefreshViewBgm(view);
			this.RefreshPlayingBgm();
		}

		// Token: 0x06022B30 RID: 142128 RVA: 0x009DE8C3 File Offset: 0x009DCAC3
		internal void DeactivateViewBgm(UiViewBase view)
		{
			this.ActiveBgmViewIds.Remove(view.ComponentId);
			if (this.RemoveViewBgm(view))
			{
				this.RefreshPlayingBgm();
			}
		}

		// Token: 0x06022B31 RID: 142129 RVA: 0x009DE8E6 File Offset: 0x009DCAE6
		internal void ReleaseViewBgm(UiViewBase view)
		{
			this.DeactivateViewBgm(view);
			this.ViewBgmOverrides.Remove(view.ComponentId);
		}

		// Token: 0x06022B32 RID: 142130 RVA: 0x009DE901 File Offset: 0x009DCB01
		public void PlayViewBgm(UiViewBase view, string eventName)
		{
			this.ViewBgmOverrides[view.ComponentId] = eventName;
			if (!this.ActiveBgmViewIds.Contains(view.ComponentId))
			{
				return;
			}
			this.RefreshViewBgm(view);
			this.RefreshPlayingBgm();
		}

		// Token: 0x06022B33 RID: 142131 RVA: 0x009DE936 File Offset: 0x009DCB36
		public void StopViewBgm(UiViewBase view)
		{
			this.ViewBgmOverrides.Remove(view.ComponentId);
			if (this.RemoveViewBgm(view))
			{
				this.RefreshPlayingBgm();
			}
		}

		// Token: 0x06022B34 RID: 142132 RVA: 0x009DE95C File Offset: 0x009DCB5C
		private void RefreshViewBgm(UiViewBase view)
		{
			string text;
			bool flag = this.ViewBgmOverrides.TryGetValue(view.ComponentId, out text);
			if (!flag)
			{
				text = view.GetBgm();
			}
			if (!flag && (!view.GetBgmSwitch() || string.IsNullOrEmpty(text)))
			{
				if (!view.ViewInfo.KeepLoopEvent)
				{
					this.RemoveViewBgm(view);
					return;
				}
				text = (this.GetPlayingBgmEvent() ?? string.Empty);
			}
			this.SetViewBgm(view, text);
		}

		// Token: 0x06022B35 RID: 142133 RVA: 0x009DE9D0 File Offset: 0x009DCBD0
		private void SetViewBgm(UiViewBase view, string eventName)
		{
			UUIItem rootItem = view.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			UiAudioSystem.ViewBgm value = new UiAudioSystem.ViewBgm(view.ComponentId, rootItem.GetFlattenHierarchyIndex(), eventName);
			this.ViewBgms[view.ComponentId] = value;
		}

		// Token: 0x06022B36 RID: 142134 RVA: 0x009DEA0E File Offset: 0x009DCC0E
		private bool RemoveViewBgm(UiViewBase view)
		{
			return this.ViewBgms.Remove(view.ComponentId);
		}

		// Token: 0x06022B37 RID: 142135 RVA: 0x009DEA21 File Offset: 0x009DCC21
		[NullableContext(2)]
		private string GetPlayingBgmEvent()
		{
			if (this.PlayingBgm == null)
			{
				return null;
			}
			return this.PlayingBgm.Value.EventName;
		}

		// Token: 0x06022B38 RID: 142136 RVA: 0x009DEA44 File Offset: 0x009DCC44
		public void AddAudioCover(UiAudioCoverState state)
		{
			this.AudioCovers.Add(state);
			AudioSystem.Instance.SetRtpcValue("RPTC_COVER_LEVEL_OPENING", state.Level, null);
			this.RefreshAudioCover();
		}

		// Token: 0x06022B39 RID: 142137 RVA: 0x009DEA84 File Offset: 0x009DCC84
		public void RemoveAudioCover(UiAudioCoverState state)
		{
			if (!this.AudioCovers.Remove(state))
			{
				return;
			}
			AudioSystem.Instance.SetRtpcValue("RPTC_COVER_LEVEL_CLOSING", state.Level, null);
			this.RefreshAudioCover();
		}

		// Token: 0x06022B3A RID: 142138 RVA: 0x009DEAC4 File Offset: 0x009DCCC4
		private void RefreshPlayingBgm()
		{
			UiAudioSystem.ViewBgm? viewBgm = this.FindTopViewBgm();
			if (this.IsPlayingSameBgm(viewBgm))
			{
				this.PlayingBgm = viewBgm;
				return;
			}
			if (this.PlayingBgmHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlayingBgmHandle, EAudioActionType.Stop, null);
				this.PlayingBgmHandle = 0;
			}
			this.PlayingBgm = viewBgm;
			if (viewBgm == null)
			{
				return;
			}
			UiAudioSystem.ViewBgm value = viewBgm.Value;
			if (string.IsNullOrEmpty(value.EventName))
			{
				return;
			}
			this.PlayingBgmHandle = AudioSystem.Instance.PostEvent(value.EventName);
		}

		// Token: 0x06022B3B RID: 142139 RVA: 0x009DEB50 File Offset: 0x009DCD50
		private UiAudioSystem.ViewBgm? FindTopViewBgm()
		{
			if (!this.BgmEnabled || this.ViewBgms.Count == 0)
			{
				return null;
			}
			UiAudioSystem.ViewBgm? result = null;
			foreach (UiAudioSystem.ViewBgm viewBgm in this.ViewBgms.Values)
			{
				if (this.ActiveBgmViewIds.Contains(viewBgm.OwnerId) && (result == null || viewBgm.Depth >= result.Value.Depth))
				{
					result = new UiAudioSystem.ViewBgm?(viewBgm);
				}
			}
			return result;
		}

		// Token: 0x06022B3C RID: 142140 RVA: 0x009DEC00 File Offset: 0x009DCE00
		[NullableContext(2)]
		private void OnStackViewTransitionStart(UiViewBase hideView, UiViewBase showView)
		{
			if (showView == null)
			{
				return;
			}
			this.RefreshViewBgm(showView);
			if (hideView != null)
			{
				this.RemoveViewBgm(hideView);
			}
		}

		// Token: 0x06022B3D RID: 142141 RVA: 0x009DEC18 File Offset: 0x009DCE18
		private void AddEvents()
		{
			EventSystem.Instance.Add<UiViewBase, UiViewBase>(EEventName.StackViewTransitionStart, new Action<UiViewBase, UiViewBase>(this.OnStackViewTransitionStart));
		}

		// Token: 0x06022B3E RID: 142142 RVA: 0x009DEC33 File Offset: 0x009DCE33
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<UiViewBase, UiViewBase>(EEventName.StackViewTransitionStart, new Action<UiViewBase, UiViewBase>(this.OnStackViewTransitionStart));
		}

		// Token: 0x06022B3F RID: 142143 RVA: 0x009DEC50 File Offset: 0x009DCE50
		private void ClearBgmState()
		{
			this.ViewBgms.Clear();
			this.ViewBgmOverrides.Clear();
			this.ActiveBgmViewIds.Clear();
			this.PlayingBgm = null;
			if (this.PlayingBgmHandle == 0)
			{
				return;
			}
			AudioSystem.Instance.ExecuteAction(this.PlayingBgmHandle, EAudioActionType.Stop, null);
			this.PlayingBgmHandle = 0;
		}

		// Token: 0x06022B40 RID: 142144 RVA: 0x009DECB4 File Offset: 0x009DCEB4
		private bool IsPlayingSameBgm(UiAudioSystem.ViewBgm? bgm)
		{
			if (this.PlayingBgm == null)
			{
				return bgm == null;
			}
			return bgm != null && this.PlayingBgm.Value.EventName == bgm.Value.EventName;
		}

		// Token: 0x06022B41 RID: 142145 RVA: 0x009DED08 File Offset: 0x009DCF08
		private unsafe void RefreshAudioCover()
		{
			float num = 0f;
			float num2 = 0f;
			foreach (UiAudioCoverState uiAudioCoverState in this.AudioCovers)
			{
				if (num < uiAudioCoverState.Level)
				{
					num = uiAudioCoverState.Level;
				}
				num2 = num2 + uiAudioCoverState.Alpha - num2 * uiAudioCoverState.Alpha;
			}
			AudioSystem.Instance.SetRtpcValue("RTPC_COVER_LEVEL", num, null);
			AudioSystem.Instance.SetRtpcValue("RTPC_COVER_ALPHA", num2, null);
			float num3 = num - this.LastCoverLevel;
			this.LastCoverLevel = num;
			AudioSystem.Instance.SetRtpcValue("RTPC_COVER_LEVEL_DELTA", num3, null);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "Audio计算结果";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RTPC_COVER_LEVEL", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RTPC_COVER_ALPHA", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RTPC_COVER_LEVEL_DELTA", num3);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x17004897 RID: 18583
		// (get) Token: 0x06022B42 RID: 142146 RVA: 0x009DEE60 File Offset: 0x009DD060
		public static UiAudioSystem Instance
		{
			get
			{
				return UiAudioSystem._Instance;
			}
		}

		// Token: 0x06022B43 RID: 142147 RVA: 0x009DEE67 File Offset: 0x009DD067
		public static UiAudioSystem GetOrCreateInstance()
		{
			if (UiAudioSystem._Instance == null)
			{
				UiAudioSystem.CreateInstance();
			}
			return UiAudioSystem._Instance;
		}

		// Token: 0x06022B44 RID: 142148 RVA: 0x009DEE7B File Offset: 0x009DD07B
		public static bool CreateInstance()
		{
			if (UiAudioSystem._Instance != null)
			{
				return true;
			}
			UiAudioSystem._Instance = new UiAudioSystem();
			return true;
		}

		// Token: 0x06022B45 RID: 142149 RVA: 0x009DEE91 File Offset: 0x009DD091
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022B46 RID: 142150 RVA: 0x009DEE93 File Offset: 0x009DD093
		public static void ResetStaticDefaultValue()
		{
			UiAudioSystem._Instance = null;
		}

		// Token: 0x06022B47 RID: 142151 RVA: 0x009DEE9B File Offset: 0x009DD09B
		static UiAudioSystem()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiAudioSystem.CreateStaticDefaultValue), new Action(UiAudioSystem.ResetStaticDefaultValue));
		}

		// Token: 0x04013391 RID: 78737
		private const string RPTC_COVER_LEVEL_CLOSING = "RPTC_COVER_LEVEL_CLOSING";

		// Token: 0x04013392 RID: 78738
		private const string RPTC_COVER_LEVEL_OPENING = "RPTC_COVER_LEVEL_OPENING";

		// Token: 0x04013393 RID: 78739
		private const string RTPC_COVER_ALPHA = "RTPC_COVER_ALPHA";

		// Token: 0x04013394 RID: 78740
		private const string RTPC_COVER_LEVEL = "RTPC_COVER_LEVEL";

		// Token: 0x04013395 RID: 78741
		private const string RTPC_COVER_LEVEL_DELTA = "RTPC_COVER_LEVEL_DELTA";

		// Token: 0x04013396 RID: 78742
		private readonly Dictionary<int, UiAudioSystem.ViewBgm> ViewBgms = new Dictionary<int, UiAudioSystem.ViewBgm>();

		// Token: 0x04013397 RID: 78743
		private readonly Dictionary<int, string> ViewBgmOverrides = new Dictionary<int, string>();

		// Token: 0x04013398 RID: 78744
		private readonly HashSet<int> ActiveBgmViewIds = new HashSet<int>();

		// Token: 0x04013399 RID: 78745
		private readonly HashSet<UiAudioCoverState> AudioCovers = new HashSet<UiAudioCoverState>();

		// Token: 0x0401339A RID: 78746
		private bool BgmEnabledInternal = true;

		// Token: 0x0401339B RID: 78747
		private UiAudioSystem.ViewBgm? PlayingBgm;

		// Token: 0x0401339C RID: 78748
		private int PlayingBgmHandle;

		// Token: 0x0401339D RID: 78749
		private float LastCoverLevel;

		// Token: 0x0401339E RID: 78750
		[Nullable(2)]
		private static UiAudioSystem _Instance;

		// Token: 0x02009218 RID: 37400
		[Nullable(0)]
		private readonly struct ViewBgm
		{
			// Token: 0x06043996 RID: 276886 RVA: 0x013F6A16 File Offset: 0x013F4C16
			public ViewBgm(int ownerId, int depth, string eventName)
			{
				this.OwnerId = ownerId;
				this.Depth = depth;
				this.EventName = eventName;
			}

			// Token: 0x0402DB95 RID: 187285
			public readonly int OwnerId;

			// Token: 0x0402DB96 RID: 187286
			public readonly int Depth;

			// Token: 0x0402DB97 RID: 187287
			public readonly string EventName;
		}
	}
}
