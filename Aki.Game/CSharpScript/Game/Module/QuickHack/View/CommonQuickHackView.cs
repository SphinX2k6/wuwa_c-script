using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02004F90 RID: 20368
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonQuickHackView : QuickHackViewBase
	{
		// Token: 0x06034283 RID: 213635 RVA: 0x00C3E043 File Offset: 0x00C3C243
		public CommonQuickHackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034284 RID: 213636 RVA: 0x00C3E04C File Offset: 0x00C3C24C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 33;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnUseSkillClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnFinishClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnRightClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034285 RID: 213637 RVA: 0x00C3E578 File Offset: 0x00C3C778
		protected override int GetUiComponentType(EQuickHackUiType uiType)
		{
			switch (uiType)
			{
			case EQuickHackUiType.RamItem:
				return 2;
			case EQuickHackUiType.SkillPanelLayout:
				return 5;
			case EQuickHackUiType.RamTitleText:
				return 0;
			case EQuickHackUiType.TipItem:
				return 3;
			case EQuickHackUiType.TipText:
				return 4;
			case EQuickHackUiType.InfoTitleText:
				return 8;
			case EQuickHackUiType.InfoTagText:
				return 10;
			case EQuickHackUiType.InfoDescText:
				return 13;
			case EQuickHackUiType.InfoDurationText:
				return 11;
			case EQuickHackUiType.InfoUploadText:
				return 12;
			case EQuickHackUiType.DurationLimitItem:
				return 21;
			case EQuickHackUiType.DurationLimitBarSprite:
				return 23;
			case EQuickHackUiType.DurationLimitText:
				return 22;
			case EQuickHackUiType.TargetItem:
				return 20;
			case EQuickHackUiType.RamSpriteDarkBlue:
				return 24;
			case EQuickHackUiType.RamSpriteBlue:
				return 25;
			case EQuickHackUiType.RamSpriteRedA:
				return 26;
			case EQuickHackUiType.RamSpriteRedB:
				return 27;
			case EQuickHackUiType.UseSkillKeyItem:
				return 28;
			case EQuickHackUiType.InfoLineItem:
				return 29;
			default:
				return -1;
			}
		}

		// Token: 0x06034286 RID: 213638 RVA: 0x00C3E614 File Offset: 0x00C3C814
		protected override void RefreshInput(bool enable)
		{
			if (enable)
			{
				InputDistributeController.Instance.BindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
				return;
			}
			InputDistributeController.Instance.UnBindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x06034287 RID: 213639 RVA: 0x00C3E650 File Offset: 0x00C3C850
		protected override void OnUpdateCurrentSkillCanUse(bool canUse)
		{
			base.GetButton(14).SetSelfInteractive(canUse);
		}

		// Token: 0x06034288 RID: 213640 RVA: 0x00C3E660 File Offset: 0x00C3C860
		protected override string GetSelectSkillAudioPath()
		{
			return "play_ui_focus_mode_scanning_choice";
		}

		// Token: 0x06034289 RID: 213641 RVA: 0x00C3E667 File Offset: 0x00C3C867
		protected override List<UUIItem> GetSkillItems()
		{
			return new List<UUIItem>
			{
				base.GetItem(6),
				base.GetItem(30),
				base.GetItem(31),
				base.GetItem(32)
			};
		}

		// Token: 0x0603428A RID: 213642 RVA: 0x00C3E6A5 File Offset: 0x00C3C8A5
		private void OnUseSkillClick()
		{
			this.UseCurrentSkill();
			if (!QuickHackController.Instance.CheckRamEnoughUseAnySkill())
			{
				QuickHackController.Instance.InteractFinish();
			}
		}

		// Token: 0x0603428B RID: 213643 RVA: 0x00C3E6C4 File Offset: 0x00C3C8C4
		private void OnFinishClick()
		{
			QuickHackController.Instance.InteractFinish();
		}

		// Token: 0x0603428C RID: 213644 RVA: 0x00C3E6D0 File Offset: 0x00C3C8D0
		private void OnLeftClick()
		{
			QuickHackController.Instance.LookAtNextEnableLockTarget(true);
		}

		// Token: 0x0603428D RID: 213645 RVA: 0x00C3E6DD File Offset: 0x00C3C8DD
		private void OnRightClick()
		{
			QuickHackController.Instance.LookAtNextEnableLockTarget(false);
		}

		// Token: 0x0603428E RID: 213646 RVA: 0x00C3E6EC File Offset: 0x00C3C8EC
		private void OnInputWheelAxis(string name, float value, InputIdentification inputIdentification)
		{
			if (value == 0f)
			{
				return;
			}
			List<QuickHackSkillInstance> currentSkillList = QuickHackModel.Instance.CurrentSkillList;
			if (currentSkillList == null || currentSkillList.Count == 0)
			{
				return;
			}
			AudioSystem.Instance.PostEvent("play_ui_focus_mode_scanning_choice");
			QuickHackController.Instance.SelectNextSkill(value < 0f, false);
		}

		// Token: 0x0200B0A5 RID: 45221
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x040359DD RID: 219613
			public const int RamTitleText = 0;

			// Token: 0x040359DE RID: 219614
			public const int RamBarLayout = 1;

			// Token: 0x040359DF RID: 219615
			public const int RamItem = 2;

			// Token: 0x040359E0 RID: 219616
			public const int TipItem = 3;

			// Token: 0x040359E1 RID: 219617
			public const int TipText = 4;

			// Token: 0x040359E2 RID: 219618
			public const int SkillPanelLayout = 5;

			// Token: 0x040359E3 RID: 219619
			public const int SkillItem = 6;

			// Token: 0x040359E4 RID: 219620
			public const int InfoPanelItem = 7;

			// Token: 0x040359E5 RID: 219621
			public const int InfoTitleText = 8;

			// Token: 0x040359E6 RID: 219622
			public const int InfoTagBgSprite = 9;

			// Token: 0x040359E7 RID: 219623
			public const int InfoTagText = 10;

			// Token: 0x040359E8 RID: 219624
			public const int InfoDurationText = 11;

			// Token: 0x040359E9 RID: 219625
			public const int InfoUploadText = 12;

			// Token: 0x040359EA RID: 219626
			public const int InfoDescText = 13;

			// Token: 0x040359EB RID: 219627
			public const int UseSkillButton = 14;

			// Token: 0x040359EC RID: 219628
			public const int FinishButton = 15;

			// Token: 0x040359ED RID: 219629
			public const int LeftButton = 16;

			// Token: 0x040359EE RID: 219630
			public const int RightButton = 17;

			// Token: 0x040359EF RID: 219631
			public const int UnlockItem = 18;

			// Token: 0x040359F0 RID: 219632
			public const int LockItem = 19;

			// Token: 0x040359F1 RID: 219633
			public const int TargetItem = 20;

			// Token: 0x040359F2 RID: 219634
			public const int DurationLimitItem = 21;

			// Token: 0x040359F3 RID: 219635
			public const int DurationLimitText = 22;

			// Token: 0x040359F4 RID: 219636
			public const int DurationLimitBarSprite = 23;

			// Token: 0x040359F5 RID: 219637
			public const int RamSpriteDarkBlue = 24;

			// Token: 0x040359F6 RID: 219638
			public const int RamSpriteBlue = 25;

			// Token: 0x040359F7 RID: 219639
			public const int RamSpriteRedA = 26;

			// Token: 0x040359F8 RID: 219640
			public const int RamSpriteRedB = 27;

			// Token: 0x040359F9 RID: 219641
			public const int UseSkillKeyItem = 28;

			// Token: 0x040359FA RID: 219642
			public const int InfoLineItem = 29;

			// Token: 0x040359FB RID: 219643
			public const int SkillItem2 = 30;

			// Token: 0x040359FC RID: 219644
			public const int SkillItem3 = 31;

			// Token: 0x040359FD RID: 219645
			public const int SkillItem4 = 32;
		}
	}
}
