using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x020064A1 RID: 25761
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeRoleSelectView : UiViewBase
	{
		// Token: 0x06040B0A RID: 264970 RVA: 0x00FA90A2 File Offset: 0x00FA72A2
		public MatchThreeRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x170094B5 RID: 38069
		// (get) Token: 0x06040B0B RID: 264971 RVA: 0x00FA90C8 File Offset: 0x00FA72C8
		private EMatchThreeRolePopupMode Mode
		{
			get
			{
				MatchThreeRoleSelectViewParams @params = this.Params;
				if (@params == null)
				{
					return EMatchThreeRolePopupMode.Select;
				}
				return @params.Mode;
			}
		}

		// Token: 0x170094B6 RID: 38070
		// (get) Token: 0x06040B0C RID: 264972 RVA: 0x00FA90DB File Offset: 0x00FA72DB
		private bool IsSelectMode
		{
			get
			{
				return this.Mode == EMatchThreeRolePopupMode.Select;
			}
		}

		// Token: 0x06040B0D RID: 264973 RVA: 0x00FA90E8 File Offset: 0x00FA72E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickPre));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickNext));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickCloseMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040B0E RID: 264974 RVA: 0x00FA938C File Offset: 0x00FA758C
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeRoleSelectView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeRoleSelectView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040B0F RID: 264975 RVA: 0x00FA93D0 File Offset: 0x00FA75D0
		protected override void OnBeforeShow()
		{
			if (this.RoleDataList.Count == 0)
			{
				return;
			}
			this.CurrentIndex = -1;
			int initialIndex = this.FindInitialIndex();
			if (!this.IsSelectMode)
			{
				this.SelectRole(initialIndex, false);
				return;
			}
			GenericLayout<MatchThreeRoleToggleItem, MatchThreeRoleToggleData> roleLayout = this.RoleLayout;
			if (roleLayout == null)
			{
				return;
			}
			roleLayout.RefreshByData(this.RoleDataList, delegate
			{
				this.SelectRole(initialIndex, false);
			}, false);
		}

		// Token: 0x06040B10 RID: 264976 RVA: 0x00FA9444 File Offset: 0x00FA7644
		protected override void OnBeforeDestroy()
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(0);
			if (spine != null)
			{
				spine.AnimationComplete.Clear();
			}
			if (!this.SkipCloseCallback)
			{
				MatchThreeRoleSelectViewParams @params = this.Params;
				if (@params == null)
				{
					return;
				}
				Action onClosed = @params.OnClosed;
				if (onClosed == null)
				{
					return;
				}
				onClosed();
			}
		}

		// Token: 0x06040B11 RID: 264977 RVA: 0x00FA947F File Offset: 0x00FA767F
		protected override void OnAfterDestroy()
		{
			if (this.Mode == EMatchThreeRolePopupMode.Unlock)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MatchThreeRoleUnlockViewClosed");
			}
		}

		// Token: 0x06040B12 RID: 264978 RVA: 0x00FA94A0 File Offset: 0x00FA76A0
		private void InitRoleLayout()
		{
			UUIItem uuiitem = base.GetItem(3) ?? base.GetItem(2);
			AActor aactor = (uuiitem != null) ? uuiitem.GetOwner() : null;
			if (aactor == null)
			{
				return;
			}
			UUILayoutBase uuilayoutBase;
			if ((uuilayoutBase = (aactor.GetComponentByClass(UUIHorizontalLayout.StaticClass()) as UUILayoutBase)) == null)
			{
				uuilayoutBase = ((aactor.GetComponentByClass(UUIVerticalLayout.StaticClass()) as UUILayoutBase) ?? (aactor.GetComponentByClass(UUIGridLayout.StaticClass()) as UUILayoutBase));
			}
			UUILayoutBase uuilayoutBase2 = uuilayoutBase;
			if (uuilayoutBase2 == null)
			{
				return;
			}
			this.RoleLayout = new GenericLayout<MatchThreeRoleToggleItem, MatchThreeRoleToggleData>(uuilayoutBase2, new Func<MatchThreeRoleToggleItem>(this.InitRoleToggle), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06040B13 RID: 264979 RVA: 0x00FA9548 File Offset: 0x00FA7748
		private void RefreshModeUi()
		{
			bool isSelectMode = this.IsSelectMode;
			bool uiactive = this.Mode == EMatchThreeRolePopupMode.Unlock;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isSelectMode);
			}
			UUIButtonComponent button = base.GetButton(9);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(isSelectMode);
				}
			}
			UUIButtonComponent button2 = base.GetButton(10);
			if (button2 != null)
			{
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(isSelectMode);
				}
			}
			UUIButtonComponent button3 = base.GetButton(11);
			if (button3 != null)
			{
				UUIItem uuiitem3 = button3.RootUIComp.Get();
				if (uuiitem3 != null)
				{
					uuiitem3.SetUIActive(isSelectMode);
				}
			}
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			UUIText text = base.GetText(13);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIButtonComponent button4 = base.GetButton(14);
			if (button4 == null)
			{
				return;
			}
			UUIItem uuiitem4 = button4.RootUIComp.Get();
			if (uuiitem4 == null)
			{
				return;
			}
			uuiitem4.SetUIActive(true);
		}

		// Token: 0x06040B14 RID: 264980 RVA: 0x00FA963B File Offset: 0x00FA783B
		private MatchThreeRoleToggleItem InitRoleToggle()
		{
			MatchThreeRoleToggleItem matchThreeRoleToggleItem = new MatchThreeRoleToggleItem();
			matchThreeRoleToggleItem.SetClickCallback(delegate(int _, int index)
			{
				this.SelectRole(index, true);
			});
			return matchThreeRoleToggleItem;
		}

		// Token: 0x06040B15 RID: 264981 RVA: 0x00FA9654 File Offset: 0x00FA7854
		private void BuildRoleDataList()
		{
			this.RoleDataList.Clear();
			if (this.ActivityData == null)
			{
				return;
			}
			if (!this.IsSelectMode)
			{
				MatchThreeRoleSelectViewParams @params = this.Params;
				this.AddRoleData((@params != null) ? @params.FocusRoleId : 0);
				return;
			}
			foreach (MatchThreeRole role in ActivityMatchThreeConfig.Instance.GetAllRoleConfigs())
			{
				this.RoleDataList.Add(this.CreateRoleToggleData(role));
			}
		}

		// Token: 0x06040B16 RID: 264982 RVA: 0x00FA96E8 File Offset: 0x00FA78E8
		private void AddRoleData(int roleId)
		{
			MatchThreeRole? roleConfig = ActivityMatchThreeConfig.Instance.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				return;
			}
			this.RoleDataList.Add(this.CreateRoleToggleData(roleConfig.Value));
		}

		// Token: 0x06040B17 RID: 264983 RVA: 0x00FA9724 File Offset: 0x00FA7924
		private MatchThreeRoleToggleData CreateRoleToggleData(MatchThreeRole role)
		{
			return new MatchThreeRoleToggleData
			{
				RoleId = role.Id,
				IsUnlocked = this.ActivityData.IsRoleUnlocked(role),
				PreLevel = role.PreLevel,
				ShowRedDot = this.ActivityData.HasNewRoleRedDot(role.Id)
			};
		}

		// Token: 0x06040B18 RID: 264984 RVA: 0x00FA977C File Offset: 0x00FA797C
		private int FindInitialIndex()
		{
			if (this.RoleDataList.Count == 0)
			{
				return 0;
			}
			int num;
			if (!this.IsSelectMode)
			{
				MatchThreeRoleSelectViewParams @params = this.Params;
				num = ((@params != null) ? @params.FocusRoleId : 0);
			}
			else
			{
				MatchThreeRoleSelectViewParams params2 = this.Params;
				int? num2;
				if (params2 == null)
				{
					num2 = null;
				}
				else
				{
					MatchThreeLevelDetailViewModel viewModel = params2.ViewModel;
					num2 = ((viewModel != null) ? new int?(viewModel.SelectedRoleId) : null);
				}
				int? num3 = num2;
				num = num3.GetValueOrDefault();
			}
			int num4 = num;
			if (num4 <= 0)
			{
				return 0;
			}
			for (int i = 0; i < this.RoleDataList.Count; i++)
			{
				if (this.RoleDataList[i].RoleId == num4)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06040B19 RID: 264985 RVA: 0x00FA9824 File Offset: 0x00FA7A24
		private void SelectRole(int index, bool playSwitchAnim)
		{
			if (index < 0 || index >= this.RoleDataList.Count)
			{
				return;
			}
			if (index == this.CurrentIndex)
			{
				this.TryClearRoleRedDot(this.RoleDataList[index]);
				return;
			}
			this.CurrentIndex = index;
			if (playSwitchAnim)
			{
				base.PlayOrReplaySequence("Swtich", false, null);
			}
			if (this.IsSelectMode)
			{
				GenericLayout<MatchThreeRoleToggleItem, MatchThreeRoleToggleData> roleLayout = this.RoleLayout;
				if (roleLayout != null)
				{
					roleLayout.SelectGridProxy(index, false);
				}
			}
			this.TryClearRoleRedDot(this.RoleDataList[index]);
			this.RefreshCurrentRole();
		}

		// Token: 0x06040B1A RID: 264986 RVA: 0x00FA98B4 File Offset: 0x00FA7AB4
		private void TryClearRoleRedDot(MatchThreeRoleToggleData roleData)
		{
			if (this.ActivityData == null || !roleData.ShowRedDot || !roleData.IsUnlocked)
			{
				return;
			}
			this.ActivityData.MarkNewRoleRedDotClicked(roleData.RoleId);
			roleData.ShowRedDot = false;
			if (this.IsSelectMode)
			{
				GenericLayout<MatchThreeRoleToggleItem, MatchThreeRoleToggleData> roleLayout = this.RoleLayout;
				if (roleLayout == null)
				{
					return;
				}
				MatchThreeRoleToggleItem layoutItemByIndex = roleLayout.GetLayoutItemByIndex(this.CurrentIndex);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.Refresh(roleData, true, this.CurrentIndex);
			}
		}

		// Token: 0x06040B1B RID: 264987 RVA: 0x00FA9924 File Offset: 0x00FA7B24
		private void RefreshCurrentRole()
		{
			if (this.ActivityData == null || this.CurrentIndex < 0 || this.CurrentIndex >= this.RoleDataList.Count)
			{
				return;
			}
			MatchThreeRoleToggleData matchThreeRoleToggleData = this.RoleDataList[this.CurrentIndex];
			MatchThreeRole? roleConfig = ActivityMatchThreeConfig.Instance.GetRoleConfig(matchThreeRoleToggleData.RoleId);
			if (roleConfig == null)
			{
				return;
			}
			matchThreeRoleToggleData.IsUnlocked = this.ActivityData.IsRoleUnlocked(roleConfig.Value);
			this.RefreshRoleName(roleConfig.Value);
			this.RefreshRoleSpine(roleConfig.Value).Forget();
			bool flag = !this.IsSelectMode || matchThreeRoleToggleData.IsUnlocked;
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(this.IsSelectMode && !matchThreeRoleToggleData.IsUnlocked);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar != null)
			{
				UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag);
				}
			}
			if (flag)
			{
				this.RefreshSkillList(roleConfig.Value);
			}
			if (this.IsSelectMode)
			{
				this.RefreshArrowVisible();
				this.RefreshConfirmButton(matchThreeRoleToggleData);
			}
		}

		// Token: 0x06040B1C RID: 264988 RVA: 0x00FA9A40 File Offset: 0x00FA7C40
		private void RefreshRoleName(MatchThreeRole roleConfig)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(roleConfig.Name))
			{
				text.SetText(string.Empty, true);
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(text, roleConfig.Name, Array.Empty<object>());
		}

		// Token: 0x06040B1D RID: 264989 RVA: 0x00FA9A8C File Offset: 0x00FA7C8C
		private UniTask RefreshRoleSpine(MatchThreeRole roleConfig)
		{
			MatchThreeRoleSelectView.<RefreshRoleSpine>d__31 <RefreshRoleSpine>d__;
			<RefreshRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleSpine>d__.<>4__this = this;
			<RefreshRoleSpine>d__.roleConfig = roleConfig;
			<RefreshRoleSpine>d__.<>1__state = -1;
			<RefreshRoleSpine>d__.<>t__builder.Start<MatchThreeRoleSelectView.<RefreshRoleSpine>d__31>(ref <RefreshRoleSpine>d__);
			return <RefreshRoleSpine>d__.<>t__builder.Task;
		}

		// Token: 0x06040B1E RID: 264990 RVA: 0x00FA9AD7 File Offset: 0x00FA7CD7
		private void PlayRoleSpineAnim(USpineSkeletonAnimationComponent spine)
		{
			spine.AnimationComplete.Clear();
			spine.SetTimeScale(1f);
			spine.SetAnimation(0, (this.Mode == EMatchThreeRolePopupMode.Unlock) ? "pose" : "idle", true);
		}

		// Token: 0x06040B1F RID: 264991 RVA: 0x00FA9B10 File Offset: 0x00FA7D10
		private void RefreshSkillList(MatchThreeRole role)
		{
			this.SkillDataList.Clear();
			for (int i = 0; i < role.SkillsLength; i++)
			{
				MatchThreeSkill? skillConfig = ActivityMatchThreeConfig.Instance.GetSkillConfig(role.Skills(i));
				if (skillConfig != null)
				{
					this.SkillDataList.Add(skillConfig.Value);
				}
			}
			GenericScrollViewNew<MatchThreeSkillItem, MatchThreeSkill> skillScroll = this.SkillScroll;
			if (skillScroll == null)
			{
				return;
			}
			skillScroll.RefreshByData(this.SkillDataList, null, false);
		}

		// Token: 0x06040B20 RID: 264992 RVA: 0x00FA9B80 File Offset: 0x00FA7D80
		private void RefreshArrowVisible()
		{
			UUIButtonComponent button = base.GetButton(9);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(this.CurrentIndex > 0);
				}
			}
			UUIButtonComponent button2 = base.GetButton(10);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(this.CurrentIndex < this.RoleDataList.Count - 1);
		}

		// Token: 0x06040B21 RID: 264993 RVA: 0x00FA9BF5 File Offset: 0x00FA7DF5
		private void RefreshConfirmButton(MatchThreeRoleToggleData roleData)
		{
			if (this.ConfirmBtn == null)
			{
				return;
			}
			this.ConfirmBtn.SetEnableClick(roleData.IsUnlocked);
			this.ConfirmBtn.SetLocalTextNew(roleData.IsUnlocked ? "RolePanel_Confirm" : "RolePanel_Locked", Array.Empty<object>());
		}

		// Token: 0x06040B22 RID: 264994 RVA: 0x00FA9C35 File Offset: 0x00FA7E35
		private void OnClickPre()
		{
			this.SelectRole(this.CurrentIndex - 1, true);
		}

		// Token: 0x06040B23 RID: 264995 RVA: 0x00FA9C46 File Offset: 0x00FA7E46
		private void OnClickNext()
		{
			this.SelectRole(this.CurrentIndex + 1, true);
		}

		// Token: 0x06040B24 RID: 264996 RVA: 0x00FA9C57 File Offset: 0x00FA7E57
		private void OnClickCloseMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x06040B25 RID: 264997 RVA: 0x00FA9C60 File Offset: 0x00FA7E60
		private void OnClickConfirm(int _)
		{
			if (this.IsSelectMode && this.ActivityData != null)
			{
				MatchThreeRoleSelectViewParams @params = this.Params;
				if (((@params != null) ? @params.ViewModel : null) != null)
				{
					if (this.CurrentIndex < 0 || this.CurrentIndex >= this.RoleDataList.Count)
					{
						return;
					}
					MatchThreeRoleToggleData matchThreeRoleToggleData = this.RoleDataList[this.CurrentIndex];
					if (!matchThreeRoleToggleData.IsUnlocked)
					{
						return;
					}
					this.Params.ViewModel.SelectedRoleId = matchThreeRoleToggleData.RoleId;
					this.ActivityData.SaveSelectedRoleId(this.Params.ViewModel.ChapterData.Chapter, matchThreeRoleToggleData.RoleId);
					Action onRoleSelected = this.Params.OnRoleSelected;
					if (onRoleSelected != null)
					{
						onRoleSelected();
					}
					this.SkipCloseCallback = true;
					base.CloseMe(null);
					return;
				}
			}
		}

		// Token: 0x04021A9F RID: 137887
		[Nullable(2)]
		private MatchThreeRoleSelectViewParams Params;

		// Token: 0x04021AA0 RID: 137888
		[Nullable(2)]
		private ActivityMatchThreeData ActivityData;

		// Token: 0x04021AA1 RID: 137889
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MatchThreeRoleToggleItem, MatchThreeRoleToggleData> RoleLayout;

		// Token: 0x04021AA2 RID: 137890
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<MatchThreeSkillItem, MatchThreeSkill> SkillScroll;

		// Token: 0x04021AA3 RID: 137891
		[Nullable(2)]
		private ButtonItem ConfirmBtn;

		// Token: 0x04021AA4 RID: 137892
		private readonly List<MatchThreeRoleToggleData> RoleDataList = new List<MatchThreeRoleToggleData>();

		// Token: 0x04021AA5 RID: 137893
		private readonly List<MatchThreeSkill> SkillDataList = new List<MatchThreeSkill>();

		// Token: 0x04021AA6 RID: 137894
		private int CurrentIndex = -1;

		// Token: 0x04021AA7 RID: 137895
		private bool SkipCloseCallback;

		// Token: 0x04021AA8 RID: 137896
		private int SpineLoadSerial;
	}
}
