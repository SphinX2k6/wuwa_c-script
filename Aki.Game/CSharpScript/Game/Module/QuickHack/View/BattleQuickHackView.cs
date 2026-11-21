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
	// Token: 0x02003F58 RID: 16216
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleQuickHackView : QuickHackViewBase
	{
		// Token: 0x060290DC RID: 168156 RVA: 0x00B86D89 File Offset: 0x00B84F89
		public BattleQuickHackView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060290DD RID: 168157 RVA: 0x00B86D94 File Offset: 0x00B84F94
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

		// Token: 0x060290DE RID: 168158 RVA: 0x00B8727C File Offset: 0x00B8547C
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

		// Token: 0x060290DF RID: 168159 RVA: 0x00B87318 File Offset: 0x00B85518
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

		// Token: 0x060290E0 RID: 168160 RVA: 0x00B873D4 File Offset: 0x00B855D4
		protected override UniTask OnBeforeStartAsync()
		{
			BattleQuickHackView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleQuickHackView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060290E1 RID: 168161 RVA: 0x00B87418 File Offset: 0x00B85618
		protected override void OnStart()
		{
			this.AutoUseSkillLongPressTime = ConfigCommonParamById.GetIntConfig("QuickHackAutoUseSkillLongPressTime").GetValueOrDefault();
			this.TryExitLongPressTime = ConfigCommonParamById.GetIntConfig("QuickHackTryExitLongPressTime").GetValueOrDefault();
			base.GetButton(18).RootUIComp.Get().SetUIActive(false);
			base.OnStart();
		}

		// Token: 0x060290E2 RID: 168162 RVA: 0x00B87478 File Offset: 0x00B85678
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			QuickHackTargetSelector targetSelector = QuickHackModel.Instance.TargetSelector;
			IQuickHackLockTargetInfo quickHackLockTargetInfo = (targetSelector != null) ? targetSelector.GetLockTargetInfo() : null;
			this.HasLockOnTarget = (quickHackLockTargetInfo != null && quickHackLockTargetInfo.HackType != null);
			this.RefreshUseSkillLongPressMode(this.HasLockOnTarget);
		}

		// Token: 0x060290E3 RID: 168163 RVA: 0x00B874C8 File Offset: 0x00B856C8
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

		// Token: 0x060290E4 RID: 168164 RVA: 0x00B87531 File Offset: 0x00B85731
		protected override bool ShouldShowTargetItem()
		{
			return false;
		}

		// Token: 0x060290E5 RID: 168165 RVA: 0x00B87534 File Offset: 0x00B85734
		protected override string GetSelectSkillAudioPath()
		{
			return "play_role_lucy_bat_burst01_qh_select";
		}

		// Token: 0x060290E6 RID: 168166 RVA: 0x00B8753C File Offset: 0x00B8573C
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

		// Token: 0x060290E7 RID: 168167 RVA: 0x00B875AF File Offset: 0x00B857AF
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

		// Token: 0x060290E8 RID: 168168 RVA: 0x00B875D7 File Offset: 0x00B857D7
		protected override bool UseCurrentSkill()
		{
			bool flag = base.UseCurrentSkill();
			if (flag)
			{
				AudioSystem.Instance.PostEvent("play_role_lucy_bat_burst01_qh_scanning");
			}
			return flag;
		}

		// Token: 0x060290E9 RID: 168169 RVA: 0x00B875F2 File Offset: 0x00B857F2
		private void OnInputWheelAxis(string name, float value, InputIdentification inputIdentification)
		{
			if (value != 0f)
			{
				AudioSystem.Instance.PostEvent("play_role_lucy_bat_burst01_qh_select");
				QuickHackController.Instance.SelectNextSkill(value < 0f, false);
			}
		}

		// Token: 0x060290EA RID: 168170 RVA: 0x00B8761F File Offset: 0x00B8581F
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

		// Token: 0x060290EB RID: 168171 RVA: 0x00B87652 File Offset: 0x00B85852
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

		// Token: 0x060290EC RID: 168172 RVA: 0x00B87688 File Offset: 0x00B85888
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

		// Token: 0x060290ED RID: 168173 RVA: 0x00B8774A File Offset: 0x00B8594A
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

		// Token: 0x0401656B RID: 91499
		[Nullable(2)]
		private BattleQuickHackLongPressItem UseSkillLongPressItem;

		// Token: 0x0401656C RID: 91500
		private bool HasLockOnTarget;

		// Token: 0x0401656D RID: 91501
		[Nullable(2)]
		private TimerHandle UseSkillLongPressTimer;

		// Token: 0x0401656E RID: 91502
		private int AutoUseSkillLongPressTime;

		// Token: 0x0401656F RID: 91503
		private int TryExitLongPressTime;

		// Token: 0x02009AD3 RID: 39635
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x040303E0 RID: 197600
			public const int RamTitleText = 0;

			// Token: 0x040303E1 RID: 197601
			public const int RamBarLayout = 1;

			// Token: 0x040303E2 RID: 197602
			public const int RamItem = 2;

			// Token: 0x040303E3 RID: 197603
			public const int TipItem = 3;

			// Token: 0x040303E4 RID: 197604
			public const int TipText = 4;

			// Token: 0x040303E5 RID: 197605
			public const int SkillPanelLayout = 5;

			// Token: 0x040303E6 RID: 197606
			public const int SkillItem = 6;

			// Token: 0x040303E7 RID: 197607
			public const int InfoPanelItem = 7;

			// Token: 0x040303E8 RID: 197608
			public const int InfoTitleText = 8;

			// Token: 0x040303E9 RID: 197609
			public const int InfoTagBgSprite = 9;

			// Token: 0x040303EA RID: 197610
			public const int InfoTagText = 10;

			// Token: 0x040303EB RID: 197611
			public const int InfoDurationText = 11;

			// Token: 0x040303EC RID: 197612
			public const int InfoUploadText = 12;

			// Token: 0x040303ED RID: 197613
			public const int InfoDescText = 13;

			// Token: 0x040303EE RID: 197614
			public const int DurationLimitItem = 14;

			// Token: 0x040303EF RID: 197615
			public const int DurationLimitText = 15;

			// Token: 0x040303F0 RID: 197616
			public const int DurationLimitBarSprite = 16;

			// Token: 0x040303F1 RID: 197617
			public const int UseSkillButton = 17;

			// Token: 0x040303F2 RID: 197618
			public const int FinishButton = 18;

			// Token: 0x040303F3 RID: 197619
			public const int UnlockItem = 19;

			// Token: 0x040303F4 RID: 197620
			public const int LockItem = 20;

			// Token: 0x040303F5 RID: 197621
			public const int TargetItem = 21;

			// Token: 0x040303F6 RID: 197622
			public const int RamSpriteDarkBlue = 22;

			// Token: 0x040303F7 RID: 197623
			public const int RamSpriteBlue = 23;

			// Token: 0x040303F8 RID: 197624
			public const int RamSpriteRedA = 24;

			// Token: 0x040303F9 RID: 197625
			public const int RamSpriteRedB = 25;

			// Token: 0x040303FA RID: 197626
			public const int UseSkillLongPressItem = 26;

			// Token: 0x040303FB RID: 197627
			public const int UseSkillKeyItem = 27;

			// Token: 0x040303FC RID: 197628
			public const int UseSkillNiagaraItem = 28;

			// Token: 0x040303FD RID: 197629
			public const int InfoLineItem = 29;

			// Token: 0x040303FE RID: 197630
			public const int SkillItem2 = 30;

			// Token: 0x040303FF RID: 197631
			public const int SkillItem3 = 31;

			// Token: 0x04030400 RID: 197632
			public const int SkillItem4 = 32;

			// Token: 0x04030401 RID: 197633
			public const int SkillItem5 = 33;

			// Token: 0x04030402 RID: 197634
			public const int SkillItem6 = 34;

			// Token: 0x04030403 RID: 197635
			public const int SkillItem7 = 35;
		}
	}
}
