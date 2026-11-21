using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FF2 RID: 20466
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorRoleSwitchView : UiViewBase
	{
		// Token: 0x060333D4 RID: 209876 RVA: 0x00E5CB70 File Offset: 0x00E5AD70
		public SpringManorRoleSwitchView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060333D5 RID: 209877 RVA: 0x00E5CB7C File Offset: 0x00E5AD7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.BackClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060333D6 RID: 209878 RVA: 0x00E5CDFC File Offset: 0x00E5AFFC
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorRoleSwitchView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorRoleSwitchView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060333D7 RID: 209879 RVA: 0x00E5CE40 File Offset: 0x00E5B040
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(9);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIText text2 = base.GetText(18);
			if (text2 != null)
			{
				text2.ShowTextNew("Spring26_RoleSwitch_Loading");
			}
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetShowText("Spring26_ChangeRoleBtn_Text");
			}
			this.RoleScrollView = new LoopScrollView<SpringManorRoleGridItem, RoleDataBase>(base.GetLoopScrollViewComponent(1), base.GetItem(10).GetOwner() as AUIBaseActor, new Func<SpringManorRoleGridItem>(this.OnGridProxyCreate), false);
			UUIItem item2 = base.GetItem(8);
			this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(item2, new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
			this.FilterSortEntrance.UpdateData(EFilterSortGroupId.EditFormation, RoleModel.Instance.GetRoleDataList(true), Array.Empty<object>());
			this.LoadingSequencePlayer = new UiSequencePlayer(base.GetItem(13));
		}

		// Token: 0x060333D8 RID: 209880 RVA: 0x00E5CF22 File Offset: 0x00E5B122
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x060333D9 RID: 209881 RVA: 0x00E5CF2C File Offset: 0x00E5B12C
		private void RefreshView()
		{
			FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
			int? num = (currentFormationData != null) ? currentFormationData.CurrentRoleConfigId : null;
			int selectedRoleId = this.SelectedRoleId;
			bool flag = num.GetValueOrDefault() == selectedRoleId & num != null;
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton == null)
			{
				return;
			}
			UUIButtonComponent btn = confirmButton.GetBtn();
			if (btn == null)
			{
				return;
			}
			btn.SetSelfInteractive(this.SelectedRoleId != 0 && !flag);
		}

		// Token: 0x060333DA RID: 209882 RVA: 0x00E5CF9C File Offset: 0x00E5B19C
		private void ConfirmClick(int __)
		{
			if (this.SelectedRoleId == 0)
			{
				return;
			}
			if (SpringManorModel.Instance.IsRoleDead(this.SelectedRoleId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_300038_Text", Array.Empty<object>());
				return;
			}
			FormationModel instance = FormationModel.Instance;
			FormationData formationData = (instance != null) ? instance.CurrentFormationData : null;
			if (formationData == null)
			{
				Log.Instance.Error(ELogModule.SpringManor, ELogAuthor.LJ, "检查试用角色时无当前编队数据！", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			List<int> roleIdList = formationData.RoleIdList;
			int value = formationData.CurrentRolePosition - 1;
			if (RoleUtils.HasMultiTrialRole(this.SelectedRoleId, roleIdList.ToArray(), new int?(value)))
			{
				ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamMultiTrialRole", Array.Empty<object>());
				return;
			}
			this.ShowLoading();
			SpringManorController.Instance.ChangeRoleRequest(this.SelectedRoleId).ContinueWith(new Action(this.TryCloseMe));
		}

		// Token: 0x060333DB RID: 209883 RVA: 0x00E5D074 File Offset: 0x00E5B274
		private void ShowLoading()
		{
			if (this.DelayLoadingTimer == null)
			{
				UiLayer.Instance.SetShowMaskLayer("SpringManorRoleSwitchViewLoading", true);
				this.DelayLoadingTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					UUIButtonComponent button = base.GetButton(4);
					if (button != null)
					{
						button.RootUIComp.Get().SetUIActive(false);
					}
					UUIItem item = base.GetItem(13);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					UiSequencePlayer loadingSequencePlayer = this.LoadingSequencePlayer;
					if (loadingSequencePlayer == null)
					{
						return;
					}
					loadingSequencePlayer.PlaySequence("Progressing", false, null);
				}, 500f, null, null, true, 1f);
			}
			if (this.AutoCloseTimer == null)
			{
				this.AutoCloseTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.TryCloseMe();
				}, 30000f, null, null, true, 1f);
			}
		}

		// Token: 0x060333DC RID: 209884 RVA: 0x00E5D0F3 File Offset: 0x00E5B2F3
		private void BackClick()
		{
			this.TryCloseMe();
		}

		// Token: 0x060333DD RID: 209885 RVA: 0x00E5D0FC File Offset: 0x00E5B2FC
		protected override void OnBeforeDestroy()
		{
			if (this.DelayLoadingTimer != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.DelayLoadingTimer))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.DelayLoadingTimer);
				}
				this.DelayLoadingTimer = null;
			}
			if (this.AutoCloseTimer != null)
			{
				if (TimerSystem.GameplayTimeInstance.Has(this.AutoCloseTimer))
				{
					TimerSystem.GameplayTimeInstance.Remove(this.AutoCloseTimer);
				}
				this.AutoCloseTimer = null;
			}
			UiLayer.Instance.SetShowMaskLayer("SpringManorRoleSwitchViewLoading", false);
		}

		// Token: 0x060333DE RID: 209886 RVA: 0x00E5D17D File Offset: 0x00E5B37D
		private void TryCloseMe()
		{
			if (this.IsClosed)
			{
				return;
			}
			this.IsClosed = true;
			base.CloseMe(null);
		}

		// Token: 0x060333DF RID: 209887 RVA: 0x00E5D198 File Offset: 0x00E5B398
		private void UpdateRoleList(List<RoleDataBase> list, bool isShowText, EFilterSortType OperationType)
		{
			List<RoleDataBase> list2 = new List<RoleDataBase>();
			RoleModel instance = RoleModel.Instance;
			RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(this.SelectedRoleId, true) : null;
			if (roleDataBase != null)
			{
				list2.Add(roleDataBase);
			}
			list2.AddRange(list);
			if (roleDataBase != null)
			{
				for (int i = list2.Count - 1; i >= 1; i--)
				{
					if (list2[i] == roleDataBase)
					{
						list2.RemoveAt(i);
					}
				}
			}
			bool flag = list2.Count > 0;
			base.GetItem(11).SetUIActive(!flag);
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetUiActive(flag);
			}
			base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(flag);
			if (!flag)
			{
				return;
			}
			this.RoleScrollView.RefreshByData(list2, false, delegate
			{
				LoopScrollView<SpringManorRoleGridItem, RoleDataBase> roleScrollView = this.RoleScrollView;
				if (roleScrollView == null)
				{
					return;
				}
				SpringManorRoleGridItem springManorRoleGridItem = roleScrollView.UnsafeGetGridProxy(0, false);
				if (springManorRoleGridItem == null)
				{
					return;
				}
				springManorRoleGridItem.SetToggleState(true, true, false);
			}, false);
		}

		// Token: 0x060333E0 RID: 209888 RVA: 0x00E5D262 File Offset: 0x00E5B462
		private SpringManorRoleGridItem OnGridProxyCreate()
		{
			SpringManorRoleGridItem springManorRoleGridItem = new SpringManorRoleGridItem();
			springManorRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
			springManorRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
			return springManorRoleGridItem;
		}

		// Token: 0x060333E1 RID: 209889 RVA: 0x00E5D290 File Offset: 0x00E5B490
		protected void ToggleFunction(MediumItemGridExtendCallback parameters)
		{
			RoleDataBase roleDataBase = parameters.Data as RoleDataBase;
			this.SelectedRoleId = roleDataBase.GetDataId();
			SpringManorRoleGridItem springManorRoleGridItem = parameters.MediumItemGrid as SpringManorRoleGridItem;
			LoopScrollView<SpringManorRoleGridItem, RoleDataBase> roleScrollView = this.RoleScrollView;
			if (roleScrollView != null)
			{
				roleScrollView.SelectGridProxy(springManorRoleGridItem.GridIndex, false);
			}
			this.RefreshView();
		}

		// Token: 0x060333E2 RID: 209890 RVA: 0x00E5D2DF File Offset: 0x00E5B4DF
		protected bool CanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return state != EToggleState.ETT_Checked;
		}

		// Token: 0x0401B38D RID: 111501
		private int SelectedRoleId;

		// Token: 0x0401B38E RID: 111502
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<SpringManorRoleGridItem, RoleDataBase> RoleScrollView;

		// Token: 0x0401B38F RID: 111503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x0401B390 RID: 111504
		[Nullable(2)]
		protected TimerHandle DelayLoadingTimer;

		// Token: 0x0401B391 RID: 111505
		[Nullable(2)]
		protected TimerHandle AutoCloseTimer;

		// Token: 0x0401B392 RID: 111506
		[Nullable(2)]
		protected UiSequencePlayer LoadingSequencePlayer;

		// Token: 0x0401B393 RID: 111507
		[Nullable(2)]
		private ButtonItem ConfirmButton;

		// Token: 0x0401B394 RID: 111508
		private bool IsClosed;

		// Token: 0x0401B395 RID: 111509
		private const string ROLE_LOADING_MASK_TAG = "SpringManorRoleSwitchViewLoading";
	}
}
