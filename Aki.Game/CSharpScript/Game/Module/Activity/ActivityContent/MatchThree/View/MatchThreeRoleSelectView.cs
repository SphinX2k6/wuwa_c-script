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
	// Token: 0x0200541F RID: 21535
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeRoleSelectView : UiViewBase
	{
		// Token: 0x060357CE RID: 219086 RVA: 0x00EF00EA File Offset: 0x00EEE2EA
		public MatchThreeRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17006817 RID: 26647
		// (get) Token: 0x060357CF RID: 219087 RVA: 0x00EF0110 File Offset: 0x00EEE310
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

		// Token: 0x17006818 RID: 26648
		// (get) Token: 0x060357D0 RID: 219088 RVA: 0x00EF0123 File Offset: 0x00EEE323
		private bool IsSelectMode
		{
			get
			{
				return this.Mode == EMatchThreeRolePopupMode.Select;
			}
		}

		// Token: 0x060357D1 RID: 219089 RVA: 0x00EF0130 File Offset: 0x00EEE330
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

		// Token: 0x060357D2 RID: 219090 RVA: 0x00EF03D4 File Offset: 0x00EEE5D4
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeRoleSelectView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeRoleSelectView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060357D3 RID: 219091 RVA: 0x00EF0418 File Offset: 0x00EEE618
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

		// Token: 0x060357D4 RID: 219092 RVA: 0x00EF048C File Offset: 0x00EEE68C
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

		// Token: 0x060357D5 RID: 219093 RVA: 0x00EF04C7 File Offset: 0x00EEE6C7
		protected override void OnAfterDestroy()
		{
			if (this.Mode == EMatchThreeRolePopupMode.Unlock)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MatchThreeRoleUnlockViewClosed");
			}
		}

		// Token: 0x060357D6 RID: 219094 RVA: 0x00EF04E8 File Offset: 0x00EEE6E8
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

		// Token: 0x060357D7 RID: 219095 RVA: 0x00EF0590 File Offset: 0x00EEE790
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

		// Token: 0x060357D8 RID: 219096 RVA: 0x00EF0683 File Offset: 0x00EEE883
		private MatchThreeRoleToggleItem InitRoleToggle()
		{
			MatchThreeRoleToggleItem matchThreeRoleToggleItem = new MatchThreeRoleToggleItem();
			matchThreeRoleToggleItem.SetClickCallback(delegate(int _, int index)
			{
				this.SelectRole(index, true);
			});
			return matchThreeRoleToggleItem;
		}

		// Token: 0x060357D9 RID: 219097 RVA: 0x00EF069C File Offset: 0x00EEE89C
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

		// Token: 0x060357DA RID: 219098 RVA: 0x00EF0730 File Offset: 0x00EEE930
		private void AddRoleData(int roleId)
		{
			MatchThreeRole? roleConfig = ActivityMatchThreeConfig.Instance.GetRoleConfig(roleId);
			if (roleConfig == null)
			{
				return;
			}
			this.RoleDataList.Add(this.CreateRoleToggleData(roleConfig.Value));
		}

		// Token: 0x060357DB RID: 219099 RVA: 0x00EF076C File Offset: 0x00EEE96C
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

		// Token: 0x060357DC RID: 219100 RVA: 0x00EF07C4 File Offset: 0x00EEE9C4
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

		// Token: 0x060357DD RID: 219101 RVA: 0x00EF086C File Offset: 0x00EEEA6C
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

		// Token: 0x060357DE RID: 219102 RVA: 0x00EF08FC File Offset: 0x00EEEAFC
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

		// Token: 0x060357DF RID: 219103 RVA: 0x00EF096C File Offset: 0x00EEEB6C
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

		// Token: 0x060357E0 RID: 219104 RVA: 0x00EF0A88 File Offset: 0x00EEEC88
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

		// Token: 0x060357E1 RID: 219105 RVA: 0x00EF0AD4 File Offset: 0x00EEECD4
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

		// Token: 0x060357E2 RID: 219106 RVA: 0x00EF0B1F File Offset: 0x00EEED1F
		private void PlayRoleSpineAnim(USpineSkeletonAnimationComponent spine)
		{
			spine.AnimationComplete.Clear();
			spine.SetTimeScale(1f);
			spine.SetAnimation(0, (this.Mode == EMatchThreeRolePopupMode.Unlock) ? "pose" : "idle", true);
		}

		// Token: 0x060357E3 RID: 219107 RVA: 0x00EF0B58 File Offset: 0x00EEED58
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

		// Token: 0x060357E4 RID: 219108 RVA: 0x00EF0BC8 File Offset: 0x00EEEDC8
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

		// Token: 0x060357E5 RID: 219109 RVA: 0x00EF0C3D File Offset: 0x00EEEE3D
		private void RefreshConfirmButton(MatchThreeRoleToggleData roleData)
		{
			if (this.ConfirmBtn == null)
			{
				return;
			}
			this.ConfirmBtn.SetEnableClick(roleData.IsUnlocked);
			this.ConfirmBtn.SetLocalTextNew(roleData.IsUnlocked ? "RolePanel_Confirm" : "RolePanel_Locked", Array.Empty<object>());
		}

		// Token: 0x060357E6 RID: 219110 RVA: 0x00EF0C7D File Offset: 0x00EEEE7D
		private void OnClickPre()
		{
			this.SelectRole(this.CurrentIndex - 1, true);
		}

		// Token: 0x060357E7 RID: 219111 RVA: 0x00EF0C8E File Offset: 0x00EEEE8E
		private void OnClickNext()
		{
			this.SelectRole(this.CurrentIndex + 1, true);
		}

		// Token: 0x060357E8 RID: 219112 RVA: 0x00EF0C9F File Offset: 0x00EEEE9F
		private void OnClickCloseMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x060357E9 RID: 219113 RVA: 0x00EF0CA8 File Offset: 0x00EEEEA8
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

		// Token: 0x0401C3D0 RID: 115664
		[Nullable(2)]
		private MatchThreeRoleSelectViewParams Params;

		// Token: 0x0401C3D1 RID: 115665
		[Nullable(2)]
		private ActivityMatchThreeData ActivityData;

		// Token: 0x0401C3D2 RID: 115666
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MatchThreeRoleToggleItem, MatchThreeRoleToggleData> RoleLayout;

		// Token: 0x0401C3D3 RID: 115667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<MatchThreeSkillItem, MatchThreeSkill> SkillScroll;

		// Token: 0x0401C3D4 RID: 115668
		[Nullable(2)]
		private ButtonItem ConfirmBtn;

		// Token: 0x0401C3D5 RID: 115669
		private readonly List<MatchThreeRoleToggleData> RoleDataList = new List<MatchThreeRoleToggleData>();

		// Token: 0x0401C3D6 RID: 115670
		private readonly List<MatchThreeSkill> SkillDataList = new List<MatchThreeSkill>();

		// Token: 0x0401C3D7 RID: 115671
		private int CurrentIndex = -1;

		// Token: 0x0401C3D8 RID: 115672
		private bool SkipCloseCallback;

		// Token: 0x0401C3D9 RID: 115673
		private int SpineLoadSerial;
	}
}
