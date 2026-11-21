using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.BadgeUnlock
{
	// Token: 0x020041F9 RID: 16889
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBadgeUnlockView : UiViewBase
	{
		// Token: 0x0602AB36 RID: 174902 RVA: 0x00C06CA5 File Offset: 0x00C04EA5
		public PhantomArenaBadgeUnlockView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0602AB37 RID: 174903 RVA: 0x00C06CB0 File Offset: 0x00C04EB0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick))
			};
		}

		// Token: 0x0602AB38 RID: 174904 RVA: 0x00C06D9C File Offset: 0x00C04F9C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBadgeUnlockView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBadgeUnlockView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AB39 RID: 174905 RVA: 0x00C06DDF File Offset: 0x00C04FDF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602AB3A RID: 174906 RVA: 0x00C06DFD File Offset: 0x00C04FFD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602AB3B RID: 174907 RVA: 0x00C06E1C File Offset: 0x00C0501C
		public void ShowNext()
		{
			UiAsyncTask task = new UiAsyncTask("PhantomArenaBadgeUnlockView", delegate()
			{
				PhantomArenaBadgeUnlockView.<<ShowNext>b__9_0>d <<ShowNext>b__9_0>d;
				<<ShowNext>b__9_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ShowNext>b__9_0>d.<>4__this = this;
				<<ShowNext>b__9_0>d.<>1__state = -1;
				<<ShowNext>b__9_0>d.<>t__builder.Start<PhantomArenaBadgeUnlockView.<<ShowNext>b__9_0>d>(ref <<ShowNext>b__9_0>d);
				return <<ShowNext>b__9_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0602AB3C RID: 174908 RVA: 0x00C06E50 File Offset: 0x00C05050
		public UniTask ShowNextAsync()
		{
			PhantomArenaBadgeUnlockView.<ShowNextAsync>d__10 <ShowNextAsync>d__;
			<ShowNextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextAsync>d__.<>4__this = this;
			<ShowNextAsync>d__.<>1__state = -1;
			<ShowNextAsync>d__.<>t__builder.Start<PhantomArenaBadgeUnlockView.<ShowNextAsync>d__10>(ref <ShowNextAsync>d__);
			return <ShowNextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AB3D RID: 174909 RVA: 0x00C06E94 File Offset: 0x00C05094
		public void RefreshViewByBadgeId(int badgeId)
		{
			PhantomBattleBadge phantomBattleBadgeById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), phantomBattleBadgeById.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), phantomBattleBadgeById.Desc, Array.Empty<object>());
			base.GetSprite(4).SetSprite(this.BadgeSprite, true);
		}

		// Token: 0x0602AB3E RID: 174910 RVA: 0x00C06EFA File Offset: 0x00C050FA
		private void OnCloseBtnClick()
		{
			if (PhantomArenaModel.Instance.BadgeUnlockQueue.Count > 0)
			{
				this.ShowNext();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0602AB3F RID: 174911 RVA: 0x00C06F1C File Offset: 0x00C0511C
		protected override void OnAfterDestroy()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x0602AB40 RID: 174912 RVA: 0x00C06F29 File Offset: 0x00C05129
		private void OnSeqEvent(string param)
		{
			if (this.IsWaitingChange && param == "Change")
			{
				this.RefreshViewByBadgeId(this.BadgeId);
				this.IsWaitingChange = false;
			}
		}

		// Token: 0x0401720F RID: 94735
		protected int BadgeId;

		// Token: 0x04017210 RID: 94736
		protected bool IsWaitingChange;

		// Token: 0x04017211 RID: 94737
		protected ULGUISpriteData_BaseObject BadgeSprite;

		// Token: 0x02009DF4 RID: 40436
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040311E5 RID: 201189
			public const int CloseBtn = 0;

			// Token: 0x040311E6 RID: 201190
			public const int RoleRootItem = 1;

			// Token: 0x040311E7 RID: 201191
			public const int RoleTexture = 2;

			// Token: 0x040311E8 RID: 201192
			public const int BadgeRootItem = 3;

			// Token: 0x040311E9 RID: 201193
			public const int BadgeSprite = 4;

			// Token: 0x040311EA RID: 201194
			public const int TitleText = 5;

			// Token: 0x040311EB RID: 201195
			public const int NameText = 6;

			// Token: 0x040311EC RID: 201196
			public const int BgDescText = 7;
		}
	}
}
