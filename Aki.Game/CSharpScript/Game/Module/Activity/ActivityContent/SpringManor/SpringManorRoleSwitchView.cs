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
	// Token: 0x02006074 RID: 24692
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorRoleSwitchView : UiViewBase
	{
		// Token: 0x0603E710 RID: 255760 RVA: 0x00F15DAC File Offset: 0x00F13FAC
		public SpringManorRoleSwitchView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E711 RID: 255761 RVA: 0x00F15DB8 File Offset: 0x00F13FB8
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

		// Token: 0x0603E712 RID: 255762 RVA: 0x00F16038 File Offset: 0x00F14238
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorRoleSwitchView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorRoleSwitchView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E713 RID: 255763 RVA: 0x00F1607C File Offset: 0x00F1427C
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

		// Token: 0x0603E714 RID: 255764 RVA: 0x00F1615E File Offset: 0x00F1435E
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0603E715 RID: 255765 RVA: 0x00F16168 File Offset: 0x00F14368
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

		// Token: 0x0603E716 RID: 255766 RVA: 0x00F161D8 File Offset: 0x00F143D8
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

		// Token: 0x0603E717 RID: 255767 RVA: 0x00F162B0 File Offset: 0x00F144B0
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

		// Token: 0x0603E718 RID: 255768 RVA: 0x00F1632F File Offset: 0x00F1452F
		private void BackClick()
		{
			this.TryCloseMe();
		}

		// Token: 0x0603E719 RID: 255769 RVA: 0x00F16338 File Offset: 0x00F14538
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

		// Token: 0x0603E71A RID: 255770 RVA: 0x00F163B9 File Offset: 0x00F145B9
		private void TryCloseMe()
		{
			if (this.IsClosed)
			{
				return;
			}
			this.IsClosed = true;
			base.CloseMe(null);
		}

		// Token: 0x0603E71B RID: 255771 RVA: 0x00F163D4 File Offset: 0x00F145D4
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

		// Token: 0x0603E71C RID: 255772 RVA: 0x00F1649E File Offset: 0x00F1469E
		private SpringManorRoleGridItem OnGridProxyCreate()
		{
			SpringManorRoleGridItem springManorRoleGridItem = new SpringManorRoleGridItem();
			springManorRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
			springManorRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
			return springManorRoleGridItem;
		}

		// Token: 0x0603E71D RID: 255773 RVA: 0x00F164CC File Offset: 0x00F146CC
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

		// Token: 0x0603E71E RID: 255774 RVA: 0x00F1651B File Offset: 0x00F1471B
		protected bool CanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return state != EToggleState.ETT_Checked;
		}

		// Token: 0x04020A60 RID: 133728
		private int SelectedRoleId;

		// Token: 0x04020A61 RID: 133729
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<SpringManorRoleGridItem, RoleDataBase> RoleScrollView;

		// Token: 0x04020A62 RID: 133730
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x04020A63 RID: 133731
		[Nullable(2)]
		protected TimerHandle DelayLoadingTimer;

		// Token: 0x04020A64 RID: 133732
		[Nullable(2)]
		protected TimerHandle AutoCloseTimer;

		// Token: 0x04020A65 RID: 133733
		[Nullable(2)]
		protected UiSequencePlayer LoadingSequencePlayer;

		// Token: 0x04020A66 RID: 133734
		[Nullable(2)]
		private ButtonItem ConfirmButton;

		// Token: 0x04020A67 RID: 133735
		private bool IsClosed;

		// Token: 0x04020A68 RID: 133736
		private const string ROLE_LOADING_MASK_TAG = "SpringManorRoleSwitchViewLoading";
	}
}
