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
	// Token: 0x02005229 RID: 21033
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBadgeUnlockView : UiViewBase
	{
		// Token: 0x06035C3B RID: 220219 RVA: 0x00CB9665 File Offset: 0x00CB7865
		public PhantomArenaBadgeUnlockView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06035C3C RID: 220220 RVA: 0x00CB9670 File Offset: 0x00CB7870
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

		// Token: 0x06035C3D RID: 220221 RVA: 0x00CB975C File Offset: 0x00CB795C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBadgeUnlockView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBadgeUnlockView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035C3E RID: 220222 RVA: 0x00CB979F File Offset: 0x00CB799F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x06035C3F RID: 220223 RVA: 0x00CB97BD File Offset: 0x00CB79BD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x06035C40 RID: 220224 RVA: 0x00CB97DC File Offset: 0x00CB79DC
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

		// Token: 0x06035C41 RID: 220225 RVA: 0x00CB9810 File Offset: 0x00CB7A10
		public UniTask ShowNextAsync()
		{
			PhantomArenaBadgeUnlockView.<ShowNextAsync>d__10 <ShowNextAsync>d__;
			<ShowNextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextAsync>d__.<>4__this = this;
			<ShowNextAsync>d__.<>1__state = -1;
			<ShowNextAsync>d__.<>t__builder.Start<PhantomArenaBadgeUnlockView.<ShowNextAsync>d__10>(ref <ShowNextAsync>d__);
			return <ShowNextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035C42 RID: 220226 RVA: 0x00CB9854 File Offset: 0x00CB7A54
		public void RefreshViewByBadgeId(int badgeId)
		{
			PhantomBattleBadge phantomBattleBadgeById = PhantomArenaConfig.Instance.GetPhantomBattleBadgeById(badgeId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), phantomBattleBadgeById.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), phantomBattleBadgeById.Desc, Array.Empty<object>());
			base.GetSprite(4).SetSprite(this.BadgeSprite, true);
		}

		// Token: 0x06035C43 RID: 220227 RVA: 0x00CB98BA File Offset: 0x00CB7ABA
		private void OnCloseBtnClick()
		{
			if (PhantomArenaModel.Instance.BadgeUnlockQueue.Count > 0)
			{
				this.ShowNext();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06035C44 RID: 220228 RVA: 0x00CB98DC File Offset: 0x00CB7ADC
		protected override void OnAfterDestroy()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x06035C45 RID: 220229 RVA: 0x00CB98E9 File Offset: 0x00CB7AE9
		private void OnSeqEvent(string param)
		{
			if (this.IsWaitingChange && param == "Change")
			{
				this.RefreshViewByBadgeId(this.BadgeId);
				this.IsWaitingChange = false;
			}
		}

		// Token: 0x0401C7DA RID: 116698
		protected int BadgeId;

		// Token: 0x0401C7DB RID: 116699
		protected bool IsWaitingChange;

		// Token: 0x0401C7DC RID: 116700
		protected ULGUISpriteData_BaseObject BadgeSprite;

		// Token: 0x0200B3BC RID: 46012
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036792 RID: 223122
			public const int CloseBtn = 0;

			// Token: 0x04036793 RID: 223123
			public const int RoleRootItem = 1;

			// Token: 0x04036794 RID: 223124
			public const int RoleTexture = 2;

			// Token: 0x04036795 RID: 223125
			public const int BadgeRootItem = 3;

			// Token: 0x04036796 RID: 223126
			public const int BadgeSprite = 4;

			// Token: 0x04036797 RID: 223127
			public const int TitleText = 5;

			// Token: 0x04036798 RID: 223128
			public const int NameText = 6;

			// Token: 0x04036799 RID: 223129
			public const int BgDescText = 7;
		}
	}
}
