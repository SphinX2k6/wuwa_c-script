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
	// Token: 0x020054F0 RID: 21744
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFunPlayTabItem : UiPanelBase, IGridProxy<ActivityFunPlayChallengeData>
	{
		// Token: 0x170068AA RID: 26794
		// (get) Token: 0x06035E19 RID: 220697 RVA: 0x00F0CDFB File Offset: 0x00F0AFFB
		// (set) Token: 0x06035E1A RID: 220698 RVA: 0x00F0CE03 File Offset: 0x00F0B003
		public IScrollViewDelegate<IGridProxy<ActivityFunPlayChallengeData>, ActivityFunPlayChallengeData> ScrollViewDelegate { get; set; }

		// Token: 0x170068AB RID: 26795
		// (get) Token: 0x06035E1B RID: 220699 RVA: 0x00F0CE0C File Offset: 0x00F0B00C
		// (set) Token: 0x06035E1C RID: 220700 RVA: 0x00F0CE14 File Offset: 0x00F0B014
		public int GridIndex { get; set; }

		// Token: 0x170068AC RID: 26796
		// (get) Token: 0x06035E1D RID: 220701 RVA: 0x00F0CE1D File Offset: 0x00F0B01D
		// (set) Token: 0x06035E1E RID: 220702 RVA: 0x00F0CE25 File Offset: 0x00F0B025
		public int DisplayIndex { get; set; }

		// Token: 0x06035E1F RID: 220703 RVA: 0x00F0CE30 File Offset: 0x00F0B030
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

		// Token: 0x06035E20 RID: 220704 RVA: 0x00F0D024 File Offset: 0x00F0B224
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

		// Token: 0x06035E21 RID: 220705 RVA: 0x00F0D08E File Offset: 0x00F0B28E
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

		// Token: 0x06035E22 RID: 220706 RVA: 0x00F0D0B1 File Offset: 0x00F0B2B1
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06035E23 RID: 220707 RVA: 0x00F0D0CC File Offset: 0x00F0B2CC
		protected override void OnBeforeDestroy()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityFunPlay, base.GetItem(10), this.ChallengeData.GetChallengeId());
			RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityFunPlay, base.GetItem(6), this.ChallengeData.GetChallengeId());
		}

		// Token: 0x06035E24 RID: 220708 RVA: 0x00F0D125 File Offset: 0x00F0B325
		private void RefreshView()
		{
			this.RefreshBg();
			this.RefreshTitle();
			this.RefreshFinishedItem();
			this.RefreshLockItem();
		}

		// Token: 0x06035E25 RID: 220709 RVA: 0x00F0D140 File Offset: 0x00F0B340
		private void RefreshBg()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			base.SetTextureByPath(this.ChallengeData.GetBackgroundTexturePath(), base.GetTexture(11), null, null);
		}

		// Token: 0x06035E26 RID: 220710 RVA: 0x00F0D179 File Offset: 0x00F0B379
		private void RefreshTitle()
		{
			if (this.ChallengeData == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.ChallengeData.GetTabTitle(), Array.Empty<object>());
		}

		// Token: 0x06035E27 RID: 220711 RVA: 0x00F0D1A8 File Offset: 0x00F0B3A8
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

		// Token: 0x06035E28 RID: 220712 RVA: 0x00F0D248 File Offset: 0x00F0B448
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

		// Token: 0x06035E29 RID: 220713 RVA: 0x00F0D2BE File Offset: 0x00F0B4BE
		public void Refresh(ActivityFunPlayChallengeData data, bool isSelected, int gridIndex)
		{
			this.ChallengeData = data;
			this.TryBindRedDot();
			this.RefreshView();
		}

		// Token: 0x06035E2A RID: 220714 RVA: 0x00F0D2D3 File Offset: 0x00F0B4D3
		public void Clear()
		{
		}

		// Token: 0x06035E2B RID: 220715 RVA: 0x00F0D2D8 File Offset: 0x00F0B4D8
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

		// Token: 0x06035E2C RID: 220716 RVA: 0x00F0D335 File Offset: 0x00F0B535
		public void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06035E2D RID: 220717 RVA: 0x00F0D34D File Offset: 0x00F0B54D
		public object GetKey(ActivityFunPlayChallengeData data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0401C7CF RID: 116687
		private const string ROME_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ComRomeText_0{0}.SP_ComRomeText_0{1}";

		// Token: 0x0401C7D3 RID: 116691
		[Nullable(2)]
		private ActivityFunPlayChallengeData ChallengeData;

		// Token: 0x0401C7D4 RID: 116692
		private bool IsRedDotBind;

		// Token: 0x0200B14E RID: 45390
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036D41 RID: 224577
			public const int Toggle = 0;

			// Token: 0x04036D42 RID: 224578
			public const int Title = 1;

			// Token: 0x04036D43 RID: 224579
			public const int SprRome = 2;

			// Token: 0x04036D44 RID: 224580
			public const int SprDone = 3;

			// Token: 0x04036D45 RID: 224581
			public const int LockItemSelected = 4;

			// Token: 0x04036D46 RID: 224582
			public const int LockMask = 5;

			// Token: 0x04036D47 RID: 224583
			public const int RedPointSelected = 6;

			// Token: 0x04036D48 RID: 224584
			public const int SprRomeIcon = 7;

			// Token: 0x04036D49 RID: 224585
			public const int SprDoneSelected = 8;

			// Token: 0x04036D4A RID: 224586
			public const int LockItem = 9;

			// Token: 0x04036D4B RID: 224587
			public const int RedPoint = 10;

			// Token: 0x04036D4C RID: 224588
			public const int TexBg = 11;
		}
	}
}
