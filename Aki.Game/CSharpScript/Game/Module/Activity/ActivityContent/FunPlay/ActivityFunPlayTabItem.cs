using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x02006572 RID: 25970
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFunPlayTabItem : UiPanelBase, IGridProxy<ActivityFunPlayChallengeData>
	{
		// Token: 0x17009548 RID: 38216
		// (get) Token: 0x06041154 RID: 266580 RVA: 0x00FC5E17 File Offset: 0x00FC4017
		// (set) Token: 0x06041155 RID: 266581 RVA: 0x00FC5E1F File Offset: 0x00FC401F
		public IScrollViewDelegate<IGridProxy<ActivityFunPlayChallengeData>, ActivityFunPlayChallengeData> ScrollViewDelegate { get; set; }

		// Token: 0x17009549 RID: 38217
		// (get) Token: 0x06041156 RID: 266582 RVA: 0x00FC5E28 File Offset: 0x00FC4028
		// (set) Token: 0x06041157 RID: 266583 RVA: 0x00FC5E30 File Offset: 0x00FC4030
		public int GridIndex { get; set; }

		// Token: 0x1700954A RID: 38218
		// (get) Token: 0x06041158 RID: 266584 RVA: 0x00FC5E39 File Offset: 0x00FC4039
		// (set) Token: 0x06041159 RID: 266585 RVA: 0x00FC5E41 File Offset: 0x00FC4041
		public int DisplayIndex { get; set; }

		// Token: 0x0604115A RID: 266586 RVA: 0x00FC5E4C File Offset: 0x00FC404C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604115B RID: 266587 RVA: 0x00FC6040 File Offset: 0x00FC4240
		public void TryBindRedDot()
		{
			if (this.IsRedDotBind || this.ChallengeData == null)
			{
				return;
			}
			this.IsRedDotBind = true;
			RedDotController.Instance.BindRedDot(ERedDotName.ActivityFunPlay, base.GetItem(10), null, this.ChallengeData.GetChallengeId());
			RedDotController.Instance.BindRedDot(ERedDotName.ActivityFunPlay, base.GetItem(6), null, this.ChallengeData.GetChallengeId());
		}

		// Token: 0x0604115C RID: 266588 RVA: 0x00FC60AA File Offset: 0x00FC42AA
		private void OnClickItem(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				IScrollViewDelegate<IGridProxy<ActivityFunPlayChallengeData>, ActivityFunPlayChallengeData> scrollViewDelegate = this.ScrollViewDelegate;
				if (scrollViewDelegate == null)
				{
					return;
				}
				scrollViewDelegate.SelectGridProxy(this.GridIndex, this.DisplayIndex, true);
			}
		}

		// Token: 0x0604115D RID: 266589 RVA: 0x00FC60CD File Offset: 0x00FC42CD
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0604115E RID: 266590 RVA: 0x00FC60E8 File Offset: 0x00FC42E8
		protected override void OnBeforeDestroy()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityFunPlay, base.GetItem(10), this.ChallengeData.GetChallengeId());
			RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityFunPlay, base.GetItem(6), this.ChallengeData.GetChallengeId());
		}

		// Token: 0x0604115F RID: 266591 RVA: 0x00FC6141 File Offset: 0x00FC4341
		private void RefreshView()
		{
			this.RefreshBg();
			this.RefreshTitle();
			this.RefreshFinishedItem();
			this.RefreshLockItem();
		}

		// Token: 0x06041160 RID: 266592 RVA: 0x00FC615C File Offset: 0x00FC435C
		private void RefreshBg()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			base.SetTextureByPath(this.ChallengeData.GetBackgroundTexturePath(), base.GetTexture(11), null, null);
		}

		// Token: 0x06041161 RID: 266593 RVA: 0x00FC6195 File Offset: 0x00FC4395
		private void RefreshTitle()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.ChallengeData.GetTabTitle(), Array.Empty<object>());
		}

		// Token: 0x06041162 RID: 266594 RVA: 0x00FC61C4 File Offset: 0x00FC43C4
		private void RefreshFinishedItem()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			bool uiactive = this.ChallengeData.CheckRewardStatus(FunPlayChallengeRewardStatus.FunPlayRewarded);
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(uiactive);
			}
			UUISprite sprite2 = base.GetSprite(8);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(uiactive);
			}
			UUISprite sprite3 = base.GetSprite(2);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(false);
			}
			string text = (this.GridIndex + 1).ToString();
			this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}", new string[]
			{
				text,
				text
			}), base.GetSprite(7), false, null, null);
		}

		// Token: 0x06041163 RID: 266595 RVA: 0x00FC6264 File Offset: 0x00FC4464
		private void RefreshLockItem()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(!this.ChallengeData.GetIsUnlock());
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!this.ChallengeData.GetIsUnlock());
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(!this.ChallengeData.GetIsUnlock());
		}

		// Token: 0x06041164 RID: 266596 RVA: 0x00FC62DA File Offset: 0x00FC44DA
		public void Refresh(ActivityFunPlayChallengeData data, bool isSelected, int gridIndex)
		{
			this.ChallengeData = data;
			this.TryBindRedDot();
			this.RefreshView();
		}

		// Token: 0x06041165 RID: 266597 RVA: 0x00FC62EF File Offset: 0x00FC44EF
		public void Clear()
		{
		}

		// Token: 0x06041166 RID: 266598 RVA: 0x00FC62F4 File Offset: 0x00FC44F4
		public void OnSelected(bool fireEvent)
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
			}
			ActivityFunPlayModel.Instance.SetCurrentChallengeData(this.ChallengeData.GetChallengeId());
			EventSystem.Instance.Emit(EEventName.OnSelectActivityFunPlayChallengeItem);
			this.ChallengeData.RefreshUnlockRedDot();
		}

		// Token: 0x06041167 RID: 266599 RVA: 0x00FC6351 File Offset: 0x00FC4551
		public void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06041168 RID: 266600 RVA: 0x00FC6369 File Offset: 0x00FC4569
		public object GetKey(ActivityFunPlayChallengeData data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x04021E9E RID: 138910
		private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

		// Token: 0x04021EA2 RID: 138914
		[Nullable(2)]
		private ActivityFunPlayChallengeData ChallengeData;

		// Token: 0x04021EA3 RID: 138915
		private bool IsRedDotBind;

		// Token: 0x0200C769 RID: 51049
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403C3EF RID: 246767
			public const int Toggle = 0;

			// Token: 0x0403C3F0 RID: 246768
			public const int Title = 1;

			// Token: 0x0403C3F1 RID: 246769
			public const int SprRome = 2;

			// Token: 0x0403C3F2 RID: 246770
			public const int SprDone = 3;

			// Token: 0x0403C3F3 RID: 246771
			public const int LockItemSelected = 4;

			// Token: 0x0403C3F4 RID: 246772
			public const int LockMask = 5;

			// Token: 0x0403C3F5 RID: 246773
			public const int RedPointSelected = 6;

			// Token: 0x0403C3F6 RID: 246774
			public const int SprRomeIcon = 7;

			// Token: 0x0403C3F7 RID: 246775
			public const int SprDoneSelected = 8;

			// Token: 0x0403C3F8 RID: 246776
			public const int LockItem = 9;

			// Token: 0x0403C3F9 RID: 246777
			public const int RedPoint = 10;

			// Token: 0x0403C3FA RID: 246778
			public const int TexBg = 11;
		}
	}
}
