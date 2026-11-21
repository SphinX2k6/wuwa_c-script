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
	// Token: 0x02004190 RID: 16784
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaRoleUnlockView : UiViewBase
	{
		// Token: 0x0602A85D RID: 174173 RVA: 0x00BFFC07 File Offset: 0x00BFDE07
		public PhantomArenaRoleUnlockView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0602A85E RID: 174174 RVA: 0x00BFFC10 File Offset: 0x00BFDE10
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

		// Token: 0x0602A85F RID: 174175 RVA: 0x00BFFCFC File Offset: 0x00BFDEFC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleUnlockView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleUnlockView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A860 RID: 174176 RVA: 0x00BFFD3F File Offset: 0x00BFDF3F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602A861 RID: 174177 RVA: 0x00BFFD5D File Offset: 0x00BFDF5D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnSeqEvent));
		}

		// Token: 0x0602A862 RID: 174178 RVA: 0x00BFFD7C File Offset: 0x00BFDF7C
		protected void RefreshViewByCardRoleId(int cardRoleId)
		{
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(cardRoleId);
			int roleConfigId = phantomBattleCardRole.RoleConfigId;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), roleConfig.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), phantomBattleCardRole.BgDesc, Array.Empty<object>());
			base.GetTexture(2).SetTexture(this.RoleTexture);
		}

		// Token: 0x0602A863 RID: 174179 RVA: 0x00BFFE00 File Offset: 0x00BFE000
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

		// Token: 0x0602A864 RID: 174180 RVA: 0x00BFFE34 File Offset: 0x00BFE034
		public UniTask ShowNextAsync()
		{
			PhantomArenaRoleUnlockView.<ShowNextAsync>d__12 <ShowNextAsync>d__;
			<ShowNextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextAsync>d__.<>4__this = this;
			<ShowNextAsync>d__.<>1__state = -1;
			<ShowNextAsync>d__.<>t__builder.Start<PhantomArenaRoleUnlockView.<ShowNextAsync>d__12>(ref <ShowNextAsync>d__);
			return <ShowNextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A865 RID: 174181 RVA: 0x00BFFE77 File Offset: 0x00BFE077
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

		// Token: 0x0602A866 RID: 174182 RVA: 0x00BFFEA4 File Offset: 0x00BFE0A4
		protected override void OnAfterDestroy()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x0602A867 RID: 174183 RVA: 0x00BFFEB1 File Offset: 0x00BFE0B1
		private void OnSeqEvent(string param)
		{
			if (this.IsWaitingChange && param == "Change")
			{
				this.RefreshViewByCardRoleId(this.CardRoleId);
			}
		}

		// Token: 0x0401714F RID: 94543
		protected int CardRoleId;

		// Token: 0x04017150 RID: 94544
		protected bool IsWaitingChange;

		// Token: 0x04017151 RID: 94545
		protected UTexture RoleTexture;

		// Token: 0x04017152 RID: 94546
		[Nullable(2)]
		private Action CallbackOnClose;

		// Token: 0x02009D87 RID: 40327
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030FF1 RID: 200689
			public const int CloseBtn = 0;

			// Token: 0x04030FF2 RID: 200690
			public const int RoleRootItem = 1;

			// Token: 0x04030FF3 RID: 200691
			public const int RoleTexture = 2;

			// Token: 0x04030FF4 RID: 200692
			public const int BadgeRootItem = 3;

			// Token: 0x04030FF5 RID: 200693
			public const int BadgeSprite = 4;

			// Token: 0x04030FF6 RID: 200694
			public const int TitleText = 5;

			// Token: 0x04030FF7 RID: 200695
			public const int NameText = 6;

			// Token: 0x04030FF8 RID: 200696
			public const int BgDescText = 7;
		}
	}
}
