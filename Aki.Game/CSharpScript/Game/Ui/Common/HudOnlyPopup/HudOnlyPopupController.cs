using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MovieMode;

namespace CSharpScript.Game.Ui.Common.HudOnlyPopup
{
	// Token: 0x0200361C RID: 13852
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class HudOnlyPopupController : UiControllerBase
	{
		// Token: 0x06023F90 RID: 147344 RVA: 0x00A31CDE File Offset: 0x00A2FEDE
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		}

		// Token: 0x06023F91 RID: 147345 RVA: 0x00A31D18 File Offset: 0x00A2FF18
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			this.Queue.Clear();
		}

		// Token: 0x06023F92 RID: 147346 RVA: 0x00A31D68 File Offset: 0x00A2FF68
		public unsafe void Push(HudOnlyPopupTask task)
		{
			this.Queue.Push(task);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "[HudOnlyPopup] 任务入队";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", task.ViewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DedupKey", task.DedupKey ?? string.Empty);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("QueueLen", this.Queue.Length);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.TryFlush();
		}

		// Token: 0x06023F93 RID: 147347 RVA: 0x00A31E19 File Offset: 0x00A30019
		public bool Cancel(string dedupKey)
		{
			return this.Queue.RemoveByKey(dedupKey);
		}

		// Token: 0x06023F94 RID: 147348 RVA: 0x00A31E27 File Offset: 0x00A30027
		public void ClearAll()
		{
			this.Queue.Clear();
		}

		// Token: 0x06023F95 RID: 147349 RVA: 0x00A31E34 File Offset: 0x00A30034
		public bool CanShowNow()
		{
			UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
			return uiViewBase != null && uiViewBase.ViewInfo.Name.Equals(UiModel.Instance.MainViewName) && UiModel.Instance.PopList.Count <= 0 && !MovieModeController.Instance.IsInMovieMode() && !UiManager.Instance.IsViewOpen(EUiViewName.GuideFocusView);
		}

		// Token: 0x06023F96 RID: 147350 RVA: 0x00A31EAB File Offset: 0x00A300AB
		private void OnAnyViewClose(EUiViewName viewName, int viewId)
		{
			if (this.Queue.IsEmpty)
			{
				return;
			}
			this.TryFlush();
		}

		// Token: 0x06023F97 RID: 147351 RVA: 0x00A31EC1 File Offset: 0x00A300C1
		private void OnActiveBattleView()
		{
			if (this.Queue.IsEmpty)
			{
				return;
			}
			this.TryFlush();
		}

		// Token: 0x06023F98 RID: 147352 RVA: 0x00A31ED8 File Offset: 0x00A300D8
		private unsafe void TryFlush()
		{
			int length = this.Queue.Length;
			while (length-- > 0 && !this.Queue.IsEmpty && this.CanShowNow())
			{
				HudOnlyPopupTask hudOnlyPopupTask = this.Queue.Shift();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCommon;
				ELogAuthor author = ELogAuthor.SYB;
				string message = "[HudOnlyPopup] 任务出队播放";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", hudOnlyPopupTask.ViewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DedupKey", hudOnlyPopupTask.DedupKey ?? string.Empty);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				UiManager.Instance.OpenView(hudOnlyPopupTask.ViewName, hudOnlyPopupTask.ViewParam, null);
			}
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x06023F99 RID: 147353 RVA: 0x00A31FA4 File Offset: 0x00A301A4
		public static HudOnlyPopupController Instance
		{
			get
			{
				return HudOnlyPopupController._Instance;
			}
		}

		// Token: 0x06023F9A RID: 147354 RVA: 0x00A31FAB File Offset: 0x00A301AB
		public static HudOnlyPopupController GetOrCreateInstance()
		{
			if (HudOnlyPopupController._Instance == null)
			{
				HudOnlyPopupController.CreateInstance();
			}
			return HudOnlyPopupController._Instance;
		}

		// Token: 0x06023F9B RID: 147355 RVA: 0x00A31FBF File Offset: 0x00A301BF
		public static bool CreateInstance()
		{
			if (HudOnlyPopupController._Instance != null)
			{
				return true;
			}
			HudOnlyPopupController._Instance = new HudOnlyPopupController();
			return true;
		}

		// Token: 0x06023F9C RID: 147356 RVA: 0x00A31FD5 File Offset: 0x00A301D5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023F9D RID: 147357 RVA: 0x00A31FD7 File Offset: 0x00A301D7
		public static void ResetStaticDefaultValue()
		{
			HudOnlyPopupController._Instance = null;
		}

		// Token: 0x06023F9E RID: 147358 RVA: 0x00A31FDF File Offset: 0x00A301DF
		static HudOnlyPopupController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HudOnlyPopupController.CreateStaticDefaultValue), new Action(HudOnlyPopupController.ResetStaticDefaultValue));
		}

		// Token: 0x04014125 RID: 82213
		private readonly HudOnlyPopupQueue Queue = new HudOnlyPopupQueue();

		// Token: 0x04014126 RID: 82214
		[Nullable(2)]
		private static HudOnlyPopupController _Instance;
	}
}
