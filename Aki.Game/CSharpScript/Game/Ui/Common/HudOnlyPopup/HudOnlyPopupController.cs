using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MovieMode;

namespace CSharpScript.Game.Ui.Common.HudOnlyPopup
{
	// Token: 0x020046EC RID: 18156
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class HudOnlyPopupController : UiControllerBase
	{
		// Token: 0x0602F7C7 RID: 194503 RVA: 0x00B01EA2 File Offset: 0x00B000A2
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		}

		// Token: 0x0602F7C8 RID: 194504 RVA: 0x00B01EDC File Offset: 0x00B000DC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnAnyViewClose));
			EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			this.Queue.Clear();
		}

		// Token: 0x0602F7C9 RID: 194505 RVA: 0x00B01F2C File Offset: 0x00B0012C
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

		// Token: 0x0602F7CA RID: 194506 RVA: 0x00B01FDD File Offset: 0x00B001DD
		public bool Cancel(string dedupKey)
		{
			return this.Queue.RemoveByKey(dedupKey);
		}

		// Token: 0x0602F7CB RID: 194507 RVA: 0x00B01FEB File Offset: 0x00B001EB
		public void ClearAll()
		{
			this.Queue.Clear();
		}

		// Token: 0x0602F7CC RID: 194508 RVA: 0x00B01FF8 File Offset: 0x00B001F8
		public bool CanShowNow()
		{
			UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
			return uiViewBase != null && uiViewBase.ViewInfo.Name.Equals(UiModel.Instance.MainViewName) && UiModel.Instance.PopList.Count <= 0 && !MovieModeController.Instance.IsInMovieMode() && !UiManager.Instance.IsViewOpen(EUiViewName.GuideFocusView);
		}

		// Token: 0x0602F7CD RID: 194509 RVA: 0x00B0206F File Offset: 0x00B0026F
		private void OnAnyViewClose(EUiViewName viewName, int viewId)
		{
			if (this.Queue.IsEmpty)
			{
				return;
			}
			this.TryFlush();
		}

		// Token: 0x0602F7CE RID: 194510 RVA: 0x00B02085 File Offset: 0x00B00285
		private void OnActiveBattleView()
		{
			if (this.Queue.IsEmpty)
			{
				return;
			}
			this.TryFlush();
		}

		// Token: 0x0602F7CF RID: 194511 RVA: 0x00B0209C File Offset: 0x00B0029C
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

		// Token: 0x17007688 RID: 30344
		// (get) Token: 0x0602F7D0 RID: 194512 RVA: 0x00B02168 File Offset: 0x00B00368
		public static HudOnlyPopupController Instance
		{
			get
			{
				return HudOnlyPopupController._Instance;
			}
		}

		// Token: 0x0602F7D1 RID: 194513 RVA: 0x00B0216F File Offset: 0x00B0036F
		public static HudOnlyPopupController GetOrCreateInstance()
		{
			if (HudOnlyPopupController._Instance == null)
			{
				HudOnlyPopupController.CreateInstance();
			}
			return HudOnlyPopupController._Instance;
		}

		// Token: 0x0602F7D2 RID: 194514 RVA: 0x00B02183 File Offset: 0x00B00383
		public static bool CreateInstance()
		{
			if (HudOnlyPopupController._Instance != null)
			{
				return true;
			}
			HudOnlyPopupController._Instance = new HudOnlyPopupController();
			return true;
		}

		// Token: 0x0602F7D3 RID: 194515 RVA: 0x00B02199 File Offset: 0x00B00399
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F7D4 RID: 194516 RVA: 0x00B0219B File Offset: 0x00B0039B
		public static void ResetStaticDefaultValue()
		{
			HudOnlyPopupController._Instance = null;
		}

		// Token: 0x0602F7D5 RID: 194517 RVA: 0x00B021A3 File Offset: 0x00B003A3
		static HudOnlyPopupController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HudOnlyPopupController.CreateStaticDefaultValue), new Action(HudOnlyPopupController.ResetStaticDefaultValue));
		}

		// Token: 0x04019A76 RID: 105078
		private readonly HudOnlyPopupQueue Queue = new HudOnlyPopupQueue();

		// Token: 0x04019A77 RID: 105079
		[Nullable(2)]
		private static HudOnlyPopupController _Instance;
	}
}
