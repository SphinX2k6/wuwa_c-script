using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C2 RID: 22978
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolMapItem : UiPanelBase
	{
		// Token: 0x06038A1A RID: 231962 RVA: 0x00FD897C File Offset: 0x00FD6B7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnMapItemStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038A1B RID: 231963 RVA: 0x00FD8B0C File Offset: 0x00FD6D0C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolMapItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolMapItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038A1C RID: 231964 RVA: 0x00FD8B50 File Offset: 0x00FD6D50
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(() => this.IsEnable);
			}
			if (extendToggle != null)
			{
				extendToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnMapItemPointerDown));
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnUndeterminedClicked.Add(new Action(this.OnMapItemUndeterminedClicked));
		}

		// Token: 0x06038A1D RID: 231965 RVA: 0x00FD8BCA File Offset: 0x00FD6DCA
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06038A1E RID: 231966 RVA: 0x00FD8BCC File Offset: 0x00FD6DCC
		public void RefreshByLocation(SolarSchoolLocation loc, bool enable)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolSpecialBehaviorCenter instance2 = SolarSchoolSpecialBehaviorCenter.Instance;
			this.LocationId = loc.Id;
			bool flag = this.PendingUnlockLocationId == loc.Id;
			this.RefreshLockHint(loc);
			this.SetEnable(enable);
			SolarSchoolMapLocationItem locationItem = this.LocationItem;
			if (locationItem != null)
			{
				locationItem.SetLocationName(loc.Name, loc.Id);
			}
			SolarSchoolMapLocationItem locationItem2 = this.LocationItem;
			if (locationItem2 != null)
			{
				locationItem2.SetLocationIcon(loc.MapIcon);
			}
			SolarSchoolMapLocationItem locationItem3 = this.LocationItem;
			if (locationItem3 != null)
			{
				locationItem3.SetRedDotActive(instance.HasLocationNormalRedPoint(this.LocationId), instance.HasLocationAffinityRedPoint(this.LocationId));
			}
			SolarSchoolLocationRole locationRole = instance.MapData.GetLocationRole(loc.Id);
			bool showAcceptEntry = instance2.ShowAcceptEntry(locationRole.RoleId);
			this.HasUnviewedSpecialBehavior = instance2.HasUnviewedSpecialBehavior(locationRole.RoleId);
			SolarSchoolMapHeadItem headA = this.HeadA;
			if (headA != null)
			{
				headA.RefreshByRole(locationRole.RoleId);
			}
			SolarSchoolMapHeadItem headA2 = this.HeadA;
			if (headA2 != null)
			{
				headA2.RefreshSpecialBehaviorState(showAcceptEntry, this.HasUnviewedSpecialBehavior);
			}
			SolarSchoolMapHeadItem headB = this.HeadB;
			if (headB != null)
			{
				headB.RefreshByRole(0);
			}
			this.RefreshCelebrate(loc.FestivalName);
			if (flag)
			{
				this.SetAnimationFirstFrame(this.PendingUnlockAnimationName);
				this.SetEnable(false);
			}
		}

		// Token: 0x06038A1F RID: 231967 RVA: 0x00FD8D08 File Offset: 0x00FD6F08
		private void RefreshLockHint(SolarSchoolLocation location)
		{
			bool flag = !string.IsNullOrEmpty(location.LockIcon);
			this.HasLockIcon = flag;
			if (!flag)
			{
				return;
			}
			base.SetTextureByPath(location.LockIcon, base.GetTexture(7), null, null);
			UUIText text = base.GetText(8);
			LguiUtil.Instance.SetLocalTextNew(text, "SolarSchool_LocationUnlockCondition", new <>z__ReadOnlyArray<object>(new object[]
			{
				location.LockIcon,
				location.LockParam
			}));
		}

		// Token: 0x06038A20 RID: 231968 RVA: 0x00FD8D8C File Offset: 0x00FD6F8C
		private void RefreshCelebrate(string festivalName)
		{
			if (!string.IsNullOrEmpty(festivalName))
			{
				SolarSchoolMapCelebrateItem celebrateItem = this.CelebrateItem;
				if (celebrateItem != null)
				{
					celebrateItem.SetFestivalText(festivalName);
				}
				SolarSchoolMapCelebrateItem celebrateItem2 = this.CelebrateItem;
				if (celebrateItem2 == null)
				{
					return;
				}
				celebrateItem2.PlayShow();
				return;
			}
			else
			{
				SolarSchoolMapCelebrateItem celebrateItem3 = this.CelebrateItem;
				if (celebrateItem3 == null)
				{
					return;
				}
				celebrateItem3.SetUiActive(false);
				return;
			}
		}

		// Token: 0x06038A21 RID: 231969 RVA: 0x00FD8DD8 File Offset: 0x00FD6FD8
		public UUIItem GetRedDotItem()
		{
			SolarSchoolMapLocationItem locationItem = this.LocationItem;
			if (locationItem == null)
			{
				return null;
			}
			return locationItem.GetRedDotItem();
		}

		// Token: 0x06038A22 RID: 231970 RVA: 0x00FD8DEB File Offset: 0x00FD6FEB
		public UUIItem GetGuideLocationItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x06038A23 RID: 231971 RVA: 0x00FD8E00 File Offset: 0x00FD7000
		[NullableContext(1)]
		public bool PlayAnimation(string animationName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayOrReplaySequenceByName(animationName, false, null);
			}
			return true;
		}

		// Token: 0x06038A24 RID: 231972 RVA: 0x00FD8E2C File Offset: 0x00FD702C
		[NullableContext(0)]
		public UniTask<bool> PlayAnimationAsync([Nullable(1)] string animationName, bool blockClick = true)
		{
			SolarSchoolMapItem.<PlayAnimationAsync>d__24 <PlayAnimationAsync>d__;
			<PlayAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayAnimationAsync>d__.<>4__this = this;
			<PlayAnimationAsync>d__.animationName = animationName;
			<PlayAnimationAsync>d__.blockClick = blockClick;
			<PlayAnimationAsync>d__.<>1__state = -1;
			<PlayAnimationAsync>d__.<>t__builder.Start<SolarSchoolMapItem.<PlayAnimationAsync>d__24>(ref <PlayAnimationAsync>d__);
			return <PlayAnimationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038A25 RID: 231973 RVA: 0x00FD8E80 File Offset: 0x00FD7080
		[NullableContext(1)]
		public bool PrepareUnlockAnimation(int locationId, string animationName)
		{
			bool isEnable = this.IsEnable;
			this.PendingUnlockLocationId = locationId;
			this.PendingUnlockAnimationName = animationName;
			if (this.SetAnimationFirstFrame(animationName))
			{
				this.SetEnable(false);
				return true;
			}
			this.PendingUnlockLocationId = 0;
			this.PendingUnlockAnimationName = string.Empty;
			this.SetEnable(isEnable);
			return false;
		}

		// Token: 0x06038A26 RID: 231974 RVA: 0x00FD8ED0 File Offset: 0x00FD70D0
		[NullableContext(0)]
		public UniTask<bool> PlayUnlockAnimationAsync(int locationId, [Nullable(1)] string animationName, bool blockClick)
		{
			SolarSchoolMapItem.<PlayUnlockAnimationAsync>d__26 <PlayUnlockAnimationAsync>d__;
			<PlayUnlockAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayUnlockAnimationAsync>d__.<>4__this = this;
			<PlayUnlockAnimationAsync>d__.locationId = locationId;
			<PlayUnlockAnimationAsync>d__.animationName = animationName;
			<PlayUnlockAnimationAsync>d__.blockClick = blockClick;
			<PlayUnlockAnimationAsync>d__.<>1__state = -1;
			<PlayUnlockAnimationAsync>d__.<>t__builder.Start<SolarSchoolMapItem.<PlayUnlockAnimationAsync>d__26>(ref <PlayUnlockAnimationAsync>d__);
			return <PlayUnlockAnimationAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038A27 RID: 231975 RVA: 0x00FD8F2C File Offset: 0x00FD712C
		[NullableContext(1)]
		private bool SetAnimationFirstFrame(string animationName)
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				FFrameTime fframeTime = new FFrameTime();
				rootActor.SequenceJumpToSecondByKey(animationName, fframeTime);
			}
			return true;
		}

		// Token: 0x06038A28 RID: 231976 RVA: 0x00FD8F54 File Offset: 0x00FD7154
		public void SetSelected(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038A29 RID: 231977 RVA: 0x00FD8F74 File Offset: 0x00FD7174
		public void SetEnable(bool enable)
		{
			this.IsEnable = enable;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(this.IsEnable ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnDetermined, false, false, false);
			}
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(this.IsEnable);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!this.IsEnable && this.HasLockIcon);
		}

		// Token: 0x06038A2A RID: 231978 RVA: 0x00FD8FE3 File Offset: 0x00FD71E3
		private void OnMapItemStateChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.LocationId == 0 || !this.IsEnable)
			{
				return;
			}
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback != null)
			{
				clickCallback(this.LocationId);
			}
			this.SetSelected(false);
		}

		// Token: 0x06038A2B RID: 231979 RVA: 0x00FD9018 File Offset: 0x00FD7218
		private void OnMapItemPointerDown(EToggleState _)
		{
			Action pointerDownCallback = this.PointerDownCallback;
			if (pointerDownCallback == null)
			{
				return;
			}
			pointerDownCallback();
		}

		// Token: 0x06038A2C RID: 231980 RVA: 0x00FD902C File Offset: 0x00FD722C
		private void OnMapItemUndeterminedClicked()
		{
			SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(this.LocationId);
			if (location == null)
			{
				return;
			}
			int conditionGroupId = location.Value.ConditionGroupId;
			if (conditionGroupId == 0)
			{
				return;
			}
			Aki.Config.ActivityConditionGroup? conditionGroupConfig = ActivityConditionConfig.Instance.GetConditionGroupConfig(conditionGroupId);
			if (!StringUtils.IsEmpty(conditionGroupConfig.Value.HintText))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupConfig.Value.HintText, Array.Empty<object>());
			}
		}

		// Token: 0x0401DD25 RID: 122149
		private int LocationId;

		// Token: 0x0401DD26 RID: 122150
		private bool IsEnable = true;

		// Token: 0x0401DD27 RID: 122151
		private bool HasLockIcon;

		// Token: 0x0401DD28 RID: 122152
		private SolarSchoolMapHeadItem HeadA;

		// Token: 0x0401DD29 RID: 122153
		private SolarSchoolMapHeadItem HeadB;

		// Token: 0x0401DD2A RID: 122154
		private SolarSchoolMapLocationItem LocationItem;

		// Token: 0x0401DD2B RID: 122155
		private SolarSchoolMapCelebrateItem CelebrateItem;

		// Token: 0x0401DD2C RID: 122156
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401DD2D RID: 122157
		private bool HasUnviewedSpecialBehavior;

		// Token: 0x0401DD2E RID: 122158
		private int PendingUnlockLocationId;

		// Token: 0x0401DD2F RID: 122159
		[Nullable(1)]
		private string PendingUnlockAnimationName = string.Empty;

		// Token: 0x0401DD30 RID: 122160
		public Action<int> ClickCallback;

		// Token: 0x0401DD31 RID: 122161
		public Action PointerDownCallback;

		// Token: 0x0200B56E RID: 46446
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038188 RID: 229768
			public const int TogMapItem = 0;

			// Token: 0x04038189 RID: 229769
			public const int PnlHead01 = 1;

			// Token: 0x0403818A RID: 229770
			public const int PnlHead02 = 2;

			// Token: 0x0403818B RID: 229771
			public const int PnlCelebrate = 3;

			// Token: 0x0403818C RID: 229772
			public const int PnlMapLocation = 4;

			// Token: 0x0403818D RID: 229773
			public const int PnlInfo = 5;

			// Token: 0x0403818E RID: 229774
			public const int PnlLock = 6;

			// Token: 0x0403818F RID: 229775
			public const int TexIconLock = 7;

			// Token: 0x04038190 RID: 229776
			public const int TxtContentLock = 8;
		}
	}
}
