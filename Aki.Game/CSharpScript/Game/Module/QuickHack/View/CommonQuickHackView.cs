using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02003F59 RID: 16217
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonQuickHackView : QuickHackViewBase
	{
		// Token: 0x060290F1 RID: 168177 RVA: 0x00B877EF File Offset: 0x00B859EF
		public CommonQuickHackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060290F2 RID: 168178 RVA: 0x00B877F8 File Offset: 0x00B859F8
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

		// Token: 0x060290F3 RID: 168179 RVA: 0x00B87D24 File Offset: 0x00B85F24
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

		// Token: 0x060290F4 RID: 168180 RVA: 0x00B87DC0 File Offset: 0x00B85FC0
		protected override void RefreshInput(bool enable)
		{
			if (enable)
			{
				InputDistributeController.Instance.BindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
				return;
			}
			InputDistributeController.Instance.UnBindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x060290F5 RID: 168181 RVA: 0x00B87DFC File Offset: 0x00B85FFC
		protected override void OnUpdateCurrentSkillCanUse(bool canUse)
		{
			base.GetButton(14).SetSelfInteractive(canUse);
		}

		// Token: 0x060290F6 RID: 168182 RVA: 0x00B87E0C File Offset: 0x00B8600C
		protected override string GetSelectSkillAudioPath()
		{
			return "play_ui_focus_mode_scanning_choice";
		}

		// Token: 0x060290F7 RID: 168183 RVA: 0x00B87E13 File Offset: 0x00B86013
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

		// Token: 0x060290F8 RID: 168184 RVA: 0x00B87E51 File Offset: 0x00B86051
		private void OnUseSkillClick()
		{
			this.UseCurrentSkill();
			if (!QuickHackController.Instance.CheckRamEnoughUseAnySkill())
			{
				QuickHackController.Instance.InteractFinish();
			}
		}

		// Token: 0x060290F9 RID: 168185 RVA: 0x00B87E70 File Offset: 0x00B86070
		private void OnFinishClick()
		{
			QuickHackController.Instance.InteractFinish();
		}

		// Token: 0x060290FA RID: 168186 RVA: 0x00B87E7C File Offset: 0x00B8607C
		private void OnLeftClick()
		{
			QuickHackController.Instance.LookAtNextEnableLockTarget(true);
		}

		// Token: 0x060290FB RID: 168187 RVA: 0x00B87E89 File Offset: 0x00B86089
		private void OnRightClick()
		{
			QuickHackController.Instance.LookAtNextEnableLockTarget(false);
		}

		// Token: 0x060290FC RID: 168188 RVA: 0x00B87E98 File Offset: 0x00B86098
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

		// Token: 0x02009AD5 RID: 39637
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x04030408 RID: 197640
			public const int RamTitleText = 0;

			// Token: 0x04030409 RID: 197641
			public const int RamBarLayout = 1;

			// Token: 0x0403040A RID: 197642
			public const int RamItem = 2;

			// Token: 0x0403040B RID: 197643
			public const int TipItem = 3;

			// Token: 0x0403040C RID: 197644
			public const int TipText = 4;

			// Token: 0x0403040D RID: 197645
			public const int SkillPanelLayout = 5;

			// Token: 0x0403040E RID: 197646
			public const int SkillItem = 6;

			// Token: 0x0403040F RID: 197647
			public const int InfoPanelItem = 7;

			// Token: 0x04030410 RID: 197648
			public const int InfoTitleText = 8;

			// Token: 0x04030411 RID: 197649
			public const int InfoTagBgSprite = 9;

			// Token: 0x04030412 RID: 197650
			public const int InfoTagText = 10;

			// Token: 0x04030413 RID: 197651
			public const int InfoDurationText = 11;

			// Token: 0x04030414 RID: 197652
			public const int InfoUploadText = 12;

			// Token: 0x04030415 RID: 197653
			public const int InfoDescText = 13;

			// Token: 0x04030416 RID: 197654
			public const int UseSkillButton = 14;

			// Token: 0x04030417 RID: 197655
			public const int FinishButton = 15;

			// Token: 0x04030418 RID: 197656
			public const int LeftButton = 16;

			// Token: 0x04030419 RID: 197657
			public const int RightButton = 17;

			// Token: 0x0403041A RID: 197658
			public const int UnlockItem = 18;

			// Token: 0x0403041B RID: 197659
			public const int LockItem = 19;

			// Token: 0x0403041C RID: 197660
			public const int TargetItem = 20;

			// Token: 0x0403041D RID: 197661
			public const int DurationLimitItem = 21;

			// Token: 0x0403041E RID: 197662
			public const int DurationLimitText = 22;

			// Token: 0x0403041F RID: 197663
			public const int DurationLimitBarSprite = 23;

			// Token: 0x04030420 RID: 197664
			public const int RamSpriteDarkBlue = 24;

			// Token: 0x04030421 RID: 197665
			public const int RamSpriteBlue = 25;

			// Token: 0x04030422 RID: 197666
			public const int RamSpriteRedA = 26;

			// Token: 0x04030423 RID: 197667
			public const int RamSpriteRedB = 27;

			// Token: 0x04030424 RID: 197668
			public const int UseSkillKeyItem = 28;

			// Token: 0x04030425 RID: 197669
			public const int InfoLineItem = 29;

			// Token: 0x04030426 RID: 197670
			public const int SkillItem2 = 30;

			// Token: 0x04030427 RID: 197671
			public const int SkillItem3 = 31;

			// Token: 0x04030428 RID: 197672
			public const int SkillItem4 = 32;
		}
	}
}
