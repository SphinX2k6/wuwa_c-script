using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.RoleUnlock
{
	// Token: 0x020051C0 RID: 20928
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleUnlockView : UiViewBase
	{
		// Token: 0x06035962 RID: 219490 RVA: 0x00CB25CB File Offset: 0x00CB07CB
		public PhantomArenaRoleUnlockView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06035963 RID: 219491 RVA: 0x00CB25D4 File Offset: 0x00CB07D4
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

		// Token: 0x06035964 RID: 219492 RVA: 0x00CB26C0 File Offset: 0x00CB08C0
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleUnlockView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleUnlockView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035965 RID: 219493 RVA: 0x00CB2703 File Offset: 0x00CB0903
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x06035966 RID: 219494 RVA: 0x00CB2721 File Offset: 0x00CB0921
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x06035967 RID: 219495 RVA: 0x00CB2740 File Offset: 0x00CB0940
		protected void RefreshViewByCardRoleId(int cardRoleId)
		{
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(cardRoleId);
			int roleConfigId = phantomBattleCardRole.RoleConfigId;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), roleConfig.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), phantomBattleCardRole.BgDesc, Array.Empty<object>());
			base.GetTexture(2).SetTexture(this.RoleTexture);
		}

		// Token: 0x06035968 RID: 219496 RVA: 0x00CB27C4 File Offset: 0x00CB09C4
		public void ShowNext()
		{
			UiAsyncTask task = new UiAsyncTask("PhantomArenaRoleUnlockView", delegate()
			{
				PhantomArenaRoleUnlockView.<<ShowNext>b__11_0>d <<ShowNext>b__11_0>d;
				<<ShowNext>b__11_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ShowNext>b__11_0>d.<>4__this = this;
				<<ShowNext>b__11_0>d.<>1__state = -1;
				<<ShowNext>b__11_0>d.<>t__builder.Start<PhantomArenaRoleUnlockView.<<ShowNext>b__11_0>d>(ref <<ShowNext>b__11_0>d);
				return <<ShowNext>b__11_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06035969 RID: 219497 RVA: 0x00CB27F8 File Offset: 0x00CB09F8
		public UniTask ShowNextAsync()
		{
			PhantomArenaRoleUnlockView.<ShowNextAsync>d__12 <ShowNextAsync>d__;
			<ShowNextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextAsync>d__.<>4__this = this;
			<ShowNextAsync>d__.<>1__state = -1;
			<ShowNextAsync>d__.<>t__builder.Start<PhantomArenaRoleUnlockView.<ShowNextAsync>d__12>(ref <ShowNextAsync>d__);
			return <ShowNextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603596A RID: 219498 RVA: 0x00CB283B File Offset: 0x00CB0A3B
		private void OnCloseBtnClick()
		{
			if (PhantomArenaModel.Instance.RoleUnlockQueue.Count > 0)
			{
				this.ShowNext();
				return;
			}
			base.CloseMe(delegate(bool _)
			{
				Action callbackOnClose = this.CallbackOnClose;
				if (callbackOnClose == null)
				{
					return;
				}
				callbackOnClose();
			});
		}

		// Token: 0x0603596B RID: 219499 RVA: 0x00CB2868 File Offset: 0x00CB0A68
		protected override void OnAfterDestroy()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x0603596C RID: 219500 RVA: 0x00CB2875 File Offset: 0x00CB0A75
		private void OnSeqEvent(string param)
		{
			if (this.IsWaitingChange && param == "Change")
			{
				this.RefreshViewByCardRoleId(this.CardRoleId);
			}
		}

		// Token: 0x0401C71A RID: 116506
		protected int CardRoleId;

		// Token: 0x0401C71B RID: 116507
		protected bool IsWaitingChange;

		// Token: 0x0401C71C RID: 116508
		protected UTexture RoleTexture;

		// Token: 0x0401C71D RID: 116509
		[Nullable(2)]
		private Action CallbackOnClose;

		// Token: 0x0200B34F RID: 45903
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403659E RID: 222622
			public const int CloseBtn = 0;

			// Token: 0x0403659F RID: 222623
			public const int RoleRootItem = 1;

			// Token: 0x040365A0 RID: 222624
			public const int RoleTexture = 2;

			// Token: 0x040365A1 RID: 222625
			public const int BadgeRootItem = 3;

			// Token: 0x040365A2 RID: 222626
			public const int BadgeSprite = 4;

			// Token: 0x040365A3 RID: 222627
			public const int TitleText = 5;

			// Token: 0x040365A4 RID: 222628
			public const int NameText = 6;

			// Token: 0x040365A5 RID: 222629
			public const int BgDescText = 7;
		}
	}
}
