using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02004F8F RID: 20367
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleQuickHackView : QuickHackViewBase
	{
		// Token: 0x0603426E RID: 213614 RVA: 0x00C3D5DD File Offset: 0x00C3B7DD
		public BattleQuickHackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603426F RID: 213615 RVA: 0x00C3D5E8 File Offset: 0x00C3B7E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 36;
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
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034270 RID: 213616 RVA: 0x00C3DAD0 File Offset: 0x00C3BCD0
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
				return 14;
			case EQuickHackUiType.DurationLimitBarSprite:
				return 16;
			case EQuickHackUiType.DurationLimitText:
				return 15;
			case EQuickHackUiType.TargetItem:
				return 21;
			case EQuickHackUiType.RamSpriteDarkBlue:
				return 22;
			case EQuickHackUiType.RamSpriteBlue:
				return 23;
			case EQuickHackUiType.RamSpriteRedA:
				return 24;
			case EQuickHackUiType.RamSpriteRedB:
				return 25;
			case EQuickHackUiType.UseSkillKeyItem:
				return 27;
			case EQuickHackUiType.InfoLineItem:
				return 29;
			default:
				return -1;
			}
		}

		// Token: 0x06034271 RID: 213617 RVA: 0x00C3DB6C File Offset: 0x00C3BD6C
		protected override void RefreshInput(bool enable)
		{
			if (enable)
			{
				UUIButtonComponent button = base.GetButton(17);
				button.OnPointDownCallBack.Bind(new Action(this.UseSkillPress));
				button.OnPointUpCallBack.Bind(new Action(this.UseSkillRelease));
				button.OnPointCancelCallBack.Bind(new Action(this.UseSkillRelease));
				InputDistributeController.Instance.BindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
				return;
			}
			UUIButtonComponent button2 = base.GetButton(17);
			button2.OnPointDownCallBack.Unbind();
			button2.OnPointUpCallBack.Unbind();
			button2.OnPointCancelCallBack.Unbind();
			InputDistributeController.Instance.UnBindAxis("WheelAxis", new TInputHandle<float>(this.OnInputWheelAxis));
		}

		// Token: 0x06034272 RID: 213618 RVA: 0x00C3DC28 File Offset: 0x00C3BE28
		protected override UniTask OnBeforeStartAsync()
		{
			BattleQuickHackView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleQuickHackView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034273 RID: 213619 RVA: 0x00C3DC6C File Offset: 0x00C3BE6C
		protected override void OnStart()
		{
			this.AutoUseSkillLongPressTime = ConfigCommonParamById.GetIntConfig("QuickHackAutoUseSkillLongPressTime").GetValueOrDefault();
			this.TryExitLongPressTime = ConfigCommonParamById.GetIntConfig("QuickHackTryExitLongPressTime").GetValueOrDefault();
			base.GetButton(18).RootUIComp.Get().SetUIActive(false);
			base.OnStart();
		}

		// Token: 0x06034274 RID: 213620 RVA: 0x00C3DCCC File Offset: 0x00C3BECC
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			QuickHackTargetSelector targetSelector = QuickHackModel.Instance.TargetSelector;
			IQuickHackLockTargetInfo quickHackLockTargetInfo = (targetSelector != null) ? targetSelector.GetLockTargetInfo() : null;
			this.HasLockOnTarget = (quickHackLockTargetInfo != null && quickHackLockTargetInfo.HackType != null);
			this.RefreshUseSkillLongPressMode(this.HasLockOnTarget);
		}

		// Token: 0x06034275 RID: 213621 RVA: 0x00C3DD1C File Offset: 0x00C3BF1C
		protected override void OnTick(float delta)
		{
			base.OnTick(delta);
			BattleQuickHackLongPressItem useSkillLongPressItem = this.UseSkillLongPressItem;
			if (useSkillLongPressItem != null)
			{
				useSkillLongPressItem.Update(delta);
			}
			QuickHackTargetSelector targetSelector = QuickHackModel.Instance.TargetSelector;
			IQuickHackLockTargetInfo quickHackLockTargetInfo = (targetSelector != null) ? targetSelector.GetLockTargetInfo() : null;
			bool flag = quickHackLockTargetInfo != null && quickHackLockTargetInfo.HackType != null;
			if (this.HasLockOnTarget != flag)
			{
				this.HasLockOnTarget = flag;
				this.RefreshUseSkillLongPressMode(flag);
			}
		}

		// Token: 0x06034276 RID: 213622 RVA: 0x00C3DD85 File Offset: 0x00C3BF85
		protected override bool ShouldShowTargetItem()
		{
			return false;
		}

		// Token: 0x06034277 RID: 213623 RVA: 0x00C3DD88 File Offset: 0x00C3BF88
		protected override string GetSelectSkillAudioPath()
		{
			return "play_role_lucy_bat_burst01_qh_select";
		}

		// Token: 0x06034278 RID: 213624 RVA: 0x00C3DD90 File Offset: 0x00C3BF90
		protected override List<UUIItem> GetSkillItems()
		{
			return new List<UUIItem>
			{
				base.GetItem(6),
				base.GetItem(30),
				base.GetItem(31),
				base.GetItem(32),
				base.GetItem(33),
				base.GetItem(34),
				base.GetItem(35)
			};
		}

		// Token: 0x06034279 RID: 213625 RVA: 0x00C3DE03 File Offset: 0x00C3C003
		protected override string[] GetInputDistributeTags()
		{
			return new string[]
			{
				"FightInputRoot.FightInput.ActionInput",
				"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			};
		}

		// Token: 0x0603427A RID: 213626 RVA: 0x00C3DE2B File Offset: 0x00C3C02B
		protected override bool UseCurrentSkill()
		{
			bool flag = base.UseCurrentSkill();
			if (flag)
			{
				AudioSystem.Instance.PostEvent("play_role_lucy_bat_burst01_qh_scanning");
			}
			return flag;
		}

		// Token: 0x0603427B RID: 213627 RVA: 0x00C3DE46 File Offset: 0x00C3C046
		private void OnInputWheelAxis(string name, float value, InputIdentification inputIdentification)
		{
			if (value != 0f)
			{
				AudioSystem.Instance.PostEvent("play_role_lucy_bat_burst01_qh_select");
				QuickHackController.Instance.SelectNextSkill(value < 0f, false);
			}
		}

		// Token: 0x0603427C RID: 213628 RVA: 0x00C3DE73 File Offset: 0x00C3C073
		private void RefreshUseSkillLongPressMode(bool hasLockOnTarget)
		{
			BattleQuickHackLongPressItem useSkillLongPressItem = this.UseSkillLongPressItem;
			if (useSkillLongPressItem != null)
			{
				useSkillLongPressItem.SetActive(!hasLockOnTarget);
			}
			base.GetItem(28).SetUIActive(hasLockOnTarget);
			if (this.UseSkillLongPressTimer != null)
			{
				this.UseSkillLongPress();
			}
		}

		// Token: 0x0603427D RID: 213629 RVA: 0x00C3DEA6 File Offset: 0x00C3C0A6
		private void UseSkillPress()
		{
			if (!QuickHackController.Instance.CheckRamEnoughUseAnySkill())
			{
				QuickHackController.Instance.InteractFinish();
				return;
			}
			if (this.UseCurrentSkill())
			{
				QuickHackController.Instance.SelectNextSkill(true, true);
			}
			this.UseSkillLongPress();
		}

		// Token: 0x0603427E RID: 213630 RVA: 0x00C3DEDC File Offset: 0x00C3C0DC
		private void UseSkillLongPress()
		{
			BattleQuickHackLongPressItem useSkillLongPressItem = this.UseSkillLongPressItem;
			if (useSkillLongPressItem != null)
			{
				useSkillLongPressItem.StopLongPress();
			}
			TimerHandle useSkillLongPressTimer = this.UseSkillLongPressTimer;
			if (useSkillLongPressTimer != null)
			{
				useSkillLongPressTimer.Remove();
			}
			this.UseSkillLongPressTimer = null;
			if (this.HasLockOnTarget)
			{
				if (this.AutoUseSkillLongPressTime <= 0)
				{
					return;
				}
				this.UseSkillLongPressTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					if (!QuickHackController.Instance.CheckAnySkillCanUse())
					{
						TimerHandle useSkillLongPressTimer2 = this.UseSkillLongPressTimer;
						if (useSkillLongPressTimer2 != null)
						{
							useSkillLongPressTimer2.Remove();
						}
						this.UseSkillLongPressTimer = null;
						QuickHackController.Instance.InteractFinish();
						return;
					}
					this.UseCurrentSkill();
					QuickHackController.Instance.SelectNextSkill(true, true);
				}, (float)this.AutoUseSkillLongPressTime, 1f, null, null, true);
				return;
			}
			else
			{
				if (this.TryExitLongPressTime <= 0)
				{
					return;
				}
				BattleQuickHackLongPressItem useSkillLongPressItem2 = this.UseSkillLongPressItem;
				if (useSkillLongPressItem2 != null)
				{
					useSkillLongPressItem2.StartLongPress((float)this.TryExitLongPressTime);
				}
				this.UseSkillLongPressTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.UseSkillLongPressTimer = null;
					if (!QuickHackController.Instance.CheckAnySkillCanUse())
					{
						QuickHackController.Instance.InteractFinish();
					}
				}, (float)this.TryExitLongPressTime, null, null, true, 1f);
				return;
			}
		}

		// Token: 0x0603427F RID: 213631 RVA: 0x00C3DF9E File Offset: 0x00C3C19E
		private void UseSkillRelease()
		{
			BattleQuickHackLongPressItem useSkillLongPressItem = this.UseSkillLongPressItem;
			if (useSkillLongPressItem != null)
			{
				useSkillLongPressItem.StopLongPress();
			}
			TimerHandle useSkillLongPressTimer = this.UseSkillLongPressTimer;
			if (useSkillLongPressTimer != null)
			{
				useSkillLongPressTimer.Remove();
			}
			this.UseSkillLongPressTimer = null;
		}

		// Token: 0x0401BB96 RID: 113558
		[Nullable(2)]
		private BattleQuickHackLongPressItem UseSkillLongPressItem;

		// Token: 0x0401BB97 RID: 113559
		private bool HasLockOnTarget;

		// Token: 0x0401BB98 RID: 113560
		[Nullable(2)]
		private TimerHandle UseSkillLongPressTimer;

		// Token: 0x0401BB99 RID: 113561
		private int AutoUseSkillLongPressTime;

		// Token: 0x0401BB9A RID: 113562
		private int TryExitLongPressTime;

		// Token: 0x0200B0A3 RID: 45219
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x040359B5 RID: 219573
			public const int RamTitleText = 0;

			// Token: 0x040359B6 RID: 219574
			public const int RamBarLayout = 1;

			// Token: 0x040359B7 RID: 219575
			public const int RamItem = 2;

			// Token: 0x040359B8 RID: 219576
			public const int TipItem = 3;

			// Token: 0x040359B9 RID: 219577
			public const int TipText = 4;

			// Token: 0x040359BA RID: 219578
			public const int SkillPanelLayout = 5;

			// Token: 0x040359BB RID: 219579
			public const int SkillItem = 6;

			// Token: 0x040359BC RID: 219580
			public const int InfoPanelItem = 7;

			// Token: 0x040359BD RID: 219581
			public const int InfoTitleText = 8;

			// Token: 0x040359BE RID: 219582
			public const int InfoTagBgSprite = 9;

			// Token: 0x040359BF RID: 219583
			public const int InfoTagText = 10;

			// Token: 0x040359C0 RID: 219584
			public const int InfoDurationText = 11;

			// Token: 0x040359C1 RID: 219585
			public const int InfoUploadText = 12;

			// Token: 0x040359C2 RID: 219586
			public const int InfoDescText = 13;

			// Token: 0x040359C3 RID: 219587
			public const int DurationLimitItem = 14;

			// Token: 0x040359C4 RID: 219588
			public const int DurationLimitText = 15;

			// Token: 0x040359C5 RID: 219589
			public const int DurationLimitBarSprite = 16;

			// Token: 0x040359C6 RID: 219590
			public const int UseSkillButton = 17;

			// Token: 0x040359C7 RID: 219591
			public const int FinishButton = 18;

			// Token: 0x040359C8 RID: 219592
			public const int UnlockItem = 19;

			// Token: 0x040359C9 RID: 219593
			public const int LockItem = 20;

			// Token: 0x040359CA RID: 219594
			public const int TargetItem = 21;

			// Token: 0x040359CB RID: 219595
			public const int RamSpriteDarkBlue = 22;

			// Token: 0x040359CC RID: 219596
			public const int RamSpriteBlue = 23;

			// Token: 0x040359CD RID: 219597
			public const int RamSpriteRedA = 24;

			// Token: 0x040359CE RID: 219598
			public const int RamSpriteRedB = 25;

			// Token: 0x040359CF RID: 219599
			public const int UseSkillLongPressItem = 26;

			// Token: 0x040359D0 RID: 219600
			public const int UseSkillKeyItem = 27;

			// Token: 0x040359D1 RID: 219601
			public const int UseSkillNiagaraItem = 28;

			// Token: 0x040359D2 RID: 219602
			public const int InfoLineItem = 29;

			// Token: 0x040359D3 RID: 219603
			public const int SkillItem2 = 30;

			// Token: 0x040359D4 RID: 219604
			public const int SkillItem3 = 31;

			// Token: 0x040359D5 RID: 219605
			public const int SkillItem4 = 32;

			// Token: 0x040359D6 RID: 219606
			public const int SkillItem5 = 33;

			// Token: 0x040359D7 RID: 219607
			public const int SkillItem6 = 34;

			// Token: 0x040359D8 RID: 219608
			public const int SkillItem7 = 35;
		}
	}
}
