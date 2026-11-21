using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE3 RID: 19939
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarRuibeika : SpecialEnergyBarBase
	{
		// Token: 0x06032253 RID: 205395 RVA: 0x00E0D25C File Offset: 0x00E0B45C
		protected override void OnRegisterComponent()
		{
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
			dictionary[9] = typeof(UUISprite);
			dictionary[10] = typeof(UUISprite);
			dictionary[11] = typeof(UUISprite);
			dictionary[12] = typeof(UUISprite);
			Dictionary<int, Type> dictionary2 = dictionary;
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			for (int i = 0; i < 27; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, dictionary2.GetValueOrDefault(i, typeof(UUIItem))));
			}
		}

		// Token: 0x06032254 RID: 205396 RVA: 0x00E0D2F4 File Offset: 0x00E0B4F4
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarRuibeika.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarRuibeika.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032255 RID: 205397 RVA: 0x00E0D338 File Offset: 0x00E0B538
		private void InitDotItems(List<SpecialEnergyBarRuibeikaDot> arr, SpecialEnergyBarRuibeika.EChildType org, SpecialEnergyBarRuibeika.EChildType parent, int mode)
		{
			UUIItem item = base.GetItem((int)org);
			UUIItem item2 = base.GetItem((int)parent);
			for (int i = 0; i < 34; i++)
			{
				AActor actor = (i == 0) ? item.GetOwner() : LguiUtil.Instance.DuplicateActor(item.GetOwner(), item2);
				SpecialEnergyBarRuibeikaDot specialEnergyBarRuibeikaDot = new SpecialEnergyBarRuibeikaDot(mode);
				specialEnergyBarRuibeikaDot.SkipDestroyActor = true;
				specialEnergyBarRuibeikaDot.Index = i;
				specialEnergyBarRuibeikaDot.CreateByActorAsync(actor, null, false);
				arr.Add(specialEnergyBarRuibeikaDot);
			}
		}

		// Token: 0x06032256 RID: 205398 RVA: 0x00E0D3AC File Offset: 0x00E0B5AC
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.手枪状态"], this.<AddEvents>g__onStateChanged|18_0(SpecialEnergyBarRuibeika.EState.StateGun));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.铁胆状态"], this.<AddEvents>g__onStateChanged|18_0(SpecialEnergyBarRuibeika.EState.StateRifle));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.机枪状态"], this.<AddEvents>g__onStateChanged|18_0(SpecialEnergyBarRuibeika.EState.StateUlt));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.强化切枪开启中"], delegate(int tagId, bool tagExist)
			{
				this.UpdateNorDotMode(tagExist);
			});
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射一阶"], this.<AddEvents>g__onUltLevelChanged|18_2(1));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射二阶"], this.<AddEvents>g__onUltLevelChanged|18_2(2));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.连射三阶"], this.<AddEvents>g__onUltLevelChanged|18_2(3));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.技能ID.大招组.终结一击"], delegate(int tagId, bool tagExist)
			{
				if (tagExist)
				{
					BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
					if (tweenAnimPlayer == null)
					{
						return;
					}
					tweenAnimPlayer.PlayTweenAnim(23);
				}
			});
			this.EnergyMaxB = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max);
			this.UpdateNorDot(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2), false);
			this.EnergyMaxC = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy3Max);
			this.UpdateUltBarPercent(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy3));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, delegate(EAttributeType attrId, float newValue, float oldValue)
			{
				this.UpdateNorDot(newValue, false);
			});
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2Max, delegate(EAttributeType attrId, float newValue, float oldValue)
			{
				this.EnergyMaxB = newValue;
			});
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy3, delegate(EAttributeType attrId, float newValue, float oldValue)
			{
				this.UpdateUltBarPercent(newValue);
			});
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy3Max, delegate(EAttributeType attrId, float newValue, float oldValue)
			{
				this.EnergyMaxC = newValue;
			});
		}

		// Token: 0x06032257 RID: 205399 RVA: 0x00E0D548 File Offset: 0x00E0B748
		protected override void OnStart()
		{
			base.OnStart();
			this.ConfigList.Add(this.Config);
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130801));
			this.BarTipsWidth = base.GetSprite(9).Width;
			for (int i = 14; i <= 23; i++)
			{
				base.InitTweenAnim(i);
			}
			BaseTagComponent tagComponent = this.TagComponent;
			if (((tagComponent != null) ? new bool?(tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.机枪状态"])) : null).GetValueOrDefault())
			{
				this.SetState(SpecialEnergyBarRuibeika.EState.StateUlt, true);
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				this.SetState(((tagComponent2 != null) ? new bool?(tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1RebeccaMd10011.状态.铁胆状态"])) : null).GetValueOrDefault() ? SpecialEnergyBarRuibeika.EState.StateRifle : SpecialEnergyBarRuibeika.EState.StateGun, true);
			}
			this.OnBarPercentChanged();
		}

		// Token: 0x06032258 RID: 205400 RVA: 0x00E0D63E File Offset: 0x00E0B83E
		protected override void OnBeforeDestroy()
		{
			this.RemoveTimer();
			base.OnBeforeDestroy();
		}

		// Token: 0x06032259 RID: 205401 RVA: 0x00E0D64C File Offset: 0x00E0B84C
		private void SetState(SpecialEnergyBarRuibeika.EState state, bool force = false)
		{
			if (this.CurState == state && !force)
			{
				return;
			}
			SpecialEnergyBarRuibeika.EState curState = this.CurState;
			this.CurState = state;
			if (state == SpecialEnergyBarRuibeika.EState.StateUlt)
			{
				this.IsUltFinalDone = false;
				this.SwitchKeyItem(this.ConfigList[1]);
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.RefreshKeyEnable(false, true);
				}
				if (curState != SpecialEnergyBarRuibeika.EState.StateUlt || force)
				{
					base.PlayTweenAnim(16);
				}
				this.UpdateUltBarPercent(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy3));
				this.UpdateUltLevel(0);
				return;
			}
			this.SwitchKeyItem(this.ConfigList[0]);
			SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
			if (keyItem2 != null)
			{
				keyItem2.RefreshKeyEnable(this.GetKeyEnable(), true);
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(state == SpecialEnergyBarRuibeika.EState.StateGun);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(state == SpecialEnergyBarRuibeika.EState.StateRifle);
			}
			UUIItem item3 = base.GetItem(1);
			if (item3 != null)
			{
				item3.SetUIActive(!this.IsDoubleColorMode);
			}
			UUIItem item4 = base.GetItem(3);
			if (item4 != null)
			{
				item4.SetUIActive(this.IsDoubleColorMode);
			}
			if (curState == SpecialEnergyBarRuibeika.EState.StateUlt || force)
			{
				base.PlayTweenAnim(17);
			}
			base.PlayTweenAnim((state == SpecialEnergyBarRuibeika.EState.StateGun) ? 14 : 15);
			this.UpdateNorDot(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2), true);
		}

		// Token: 0x0603225A RID: 205402 RVA: 0x00E0D78E File Offset: 0x00E0B98E
		[NullableContext(2)]
		private void SwitchKeyItem(SpecialEnergyBarInfo cfg)
		{
			if (cfg != null)
			{
				this.Config = cfg;
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.SetConfig(cfg);
				}
				SpecialEnergyBarKeyItem keyItem2 = this.KeyItem;
				if (keyItem2 == null)
				{
					return;
				}
				keyItem2.SwitchToKeyInfoList(this.Config.KeyInfoList);
			}
		}

		// Token: 0x0603225B RID: 205403 RVA: 0x00E0D7C7 File Offset: 0x00E0B9C7
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603225C RID: 205404 RVA: 0x00E0D7EC File Offset: 0x00E0B9EC
		private void UpdateNorDotMode(bool doubleColor)
		{
			this.DelayedDoubleColorMode = doubleColor;
			this.PendingDoubleColorModeSwitch = true;
			if (this.DurationAniUse == 0f)
			{
				float val;
				if (this.C2DotItems.Count <= 0)
				{
					val = 0.2f;
				}
				else
				{
					SpecialEnergyBarRuibeikaDot specialEnergyBarRuibeikaDot = this.C2DotItems[0];
					val = ((specialEnergyBarRuibeikaDot != null) ? specialEnergyBarRuibeikaDot.GetAniUseDuration() : 0.2f);
				}
				this.DurationAniUse = Math.Max(val, 0.2f);
			}
			this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.TimerHandle = null;
				if (base.IsShowOrShowing)
				{
					this.UpdateNorDotModeInner();
				}
			}, this.DurationAniUse * 1000f, null, null, true, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		}

		// Token: 0x0603225D RID: 205405 RVA: 0x00E0D88C File Offset: 0x00E0BA8C
		private void UpdateNorDotModeInner()
		{
			this.PendingDoubleColorModeSwitch = false;
			this.IsDoubleColorMode = this.DelayedDoubleColorMode;
			this.RemoveTimer();
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!this.IsDoubleColorMode);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(this.IsDoubleColorMode);
			}
			this.UpdateNorDot(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2), true);
		}

		// Token: 0x0603225E RID: 205406 RVA: 0x00E0D8FC File Offset: 0x00E0BAFC
		private void UpdateNorDot(float attrValue, bool force = false)
		{
			float num = attrValue / this.EnergyMaxB;
			if (this.PendingDoubleColorModeSwitch && num * (float)this.C2DotItems.Count > 1f)
			{
				this.UpdateNorDotModeInner();
			}
			List<SpecialEnergyBarRuibeikaDot> list = this.IsDoubleColorMode ? this.C2DotItems : this.C1DotItems;
			float num2 = num * (float)list.Count;
			for (int i = 0; i < list.Count; i++)
			{
				list[i].SetVisible((float)i < num2, this.CurState == SpecialEnergyBarRuibeika.EState.StateGun, force);
			}
		}

		// Token: 0x0603225F RID: 205407 RVA: 0x00E0D984 File Offset: 0x00E0BB84
		protected override void OnBarPercentChanged()
		{
			SpecialEnergyBarSlotItem slotItem = this.SlotItem;
			if (slotItem != null)
			{
				slotItem.UpdatePercent(this.PercentMachine.GetCurPercent(), this.GetKeyEnable(), false);
			}
			if (this.CurState != SpecialEnergyBarRuibeika.EState.StateUlt)
			{
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.RefreshKeyEnable(this.GetKeyEnable(), false);
			}
		}

		// Token: 0x06032260 RID: 205408 RVA: 0x00E0D9D4 File Offset: 0x00E0BBD4
		private void UpdateUltBarPercent(float attrValue)
		{
			float num = attrValue / this.EnergyMaxC;
			UUISprite sprite = base.GetSprite(9);
			if (sprite != null)
			{
				sprite.SetFillAmount(num);
			}
			if (!this.IsUltFinalDone)
			{
				UUIItem item = base.GetItem(24);
				if (item != null)
				{
					item.SetUIActive(true);
				}
			}
			UUIItem item2 = base.GetItem(24);
			if (item2 == null)
			{
				return;
			}
			item2.SetAnchorOffsetX(this.BarTipsWidth * (num - 0.5f));
		}

		// Token: 0x06032261 RID: 205409 RVA: 0x00E0DA3C File Offset: 0x00E0BC3C
		private void UpdateUltLevel(int lv)
		{
			if (this.UltLevel == lv)
			{
				return;
			}
			this.IsUltFinalDone = false;
			this.UltLevel = lv;
			if (lv == 1)
			{
				this.UltCdDoneAnim = 18;
			}
			else if (lv == 2)
			{
				base.PlayTweenAnim(19);
				this.UltCdDoneAnim = 20;
			}
			else if (lv == 3)
			{
				base.PlayTweenAnim(21);
				this.UltCdDoneAnim = 22;
			}
			UUISprite sprite = base.GetSprite(10);
			if (sprite != null)
			{
				sprite.SetUIActive(lv == 1);
			}
			UUISprite sprite2 = base.GetSprite(11);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(lv == 2);
			}
			UUISprite sprite3 = base.GetSprite(12);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(lv == 3);
			}
			UUIItem item = base.GetItem(25);
			if (item != null)
			{
				item.SetUIActive(lv != 3);
			}
			UUIItem item2 = base.GetItem(26);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			if (lv > 0)
			{
				this.UltCdMachine.Init(0f, new float?((float)1000));
				this.UltCdMachine.SetTargetPercent(1f);
				this.UltCdBar = base.GetSprite(10 + lv - 1);
				UUISprite ultCdBar = this.UltCdBar;
				if (ultCdBar != null)
				{
					ultCdBar.SetFillAmount(0f);
				}
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.RefreshKeyEnable(false, true);
			}
		}

		// Token: 0x06032262 RID: 205410 RVA: 0x00E0DB78 File Offset: 0x00E0BD78
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.UltCdMachine.Update(delta))
			{
				UUISprite ultCdBar = this.UltCdBar;
				if (ultCdBar != null)
				{
					ultCdBar.SetFillAmount(this.UltCdMachine.GetCurPercent());
				}
				if (this.UltCdMachine.GetCurPercent() >= 1f)
				{
					if (this.CurState == SpecialEnergyBarRuibeika.EState.StateUlt && this.UltLevel <= 2)
					{
						SpecialEnergyBarKeyItem keyItem = this.KeyItem;
						if (keyItem != null)
						{
							keyItem.RefreshKeyEnable(true, true);
						}
					}
					UUIItem item = base.GetItem(26);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					if (this.UltLevel == 3)
					{
						this.IsUltFinalDone = true;
					}
					base.PlayTweenAnim(this.UltCdDoneAnim);
				}
			}
		}

		// Token: 0x06032265 RID: 205413 RVA: 0x00E0DC88 File Offset: 0x00E0BE88
		[CompilerGenerated]
		private BaseTagComponent.TTagSwitchedCallback <AddEvents>g__onStateChanged|18_0(SpecialEnergyBarRuibeika.EState state)
		{
			return delegate(int tagId, bool tagExist)
			{
				if (tagExist)
				{
					this.SetState(state, false);
				}
			};
		}

		// Token: 0x06032267 RID: 205415 RVA: 0x00E0DCB1 File Offset: 0x00E0BEB1
		[CompilerGenerated]
		private BaseTagComponent.TTagSwitchedCallback <AddEvents>g__onUltLevelChanged|18_2(int lv)
		{
			return delegate(int tagId, bool tagExist)
			{
				if (tagExist)
				{
					this.UpdateUltLevel(lv);
				}
			};
		}

		// Token: 0x0401A917 RID: 108823
		private const int BTN_ULTCONFIG = 130801;

		// Token: 0x0401A918 RID: 108824
		private const EAttributeType ENERGY_ATTR_DOT = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A919 RID: 108825
		private const EAttributeType ENERGY_MAX_ATTR_DOT = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A91A RID: 108826
		private const EAttributeType ENERGY_ATTR_ULT = EAttributeType.SpecialEnergy3;

		// Token: 0x0401A91B RID: 108827
		private const EAttributeType ENERGY_MAX_ATTR_ULT = EAttributeType.SpecialEnergy3Max;

		// Token: 0x0401A91C RID: 108828
		[Nullable(2)]
		private SpecialEnergyBarSlotItem SlotItem;

		// Token: 0x0401A91D RID: 108829
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A91E RID: 108830
		private readonly List<SpecialEnergyBarRuibeikaDot> C1DotItems = new List<SpecialEnergyBarRuibeikaDot>();

		// Token: 0x0401A91F RID: 108831
		private readonly List<SpecialEnergyBarRuibeikaDot> C2DotItems = new List<SpecialEnergyBarRuibeikaDot>();

		// Token: 0x0401A920 RID: 108832
		private readonly MotorcyclePercentMachine UltCdMachine = new MotorcyclePercentMachine();

		// Token: 0x0401A921 RID: 108833
		private float EnergyMaxB = 1f;

		// Token: 0x0401A922 RID: 108834
		private float EnergyMaxC = 1f;

		// Token: 0x0401A923 RID: 108835
		private SpecialEnergyBarRuibeika.EState CurState;

		// Token: 0x0401A924 RID: 108836
		private float BarTipsWidth = 1f;

		// Token: 0x0401A925 RID: 108837
		private bool IsDoubleColorMode;

		// Token: 0x0401A926 RID: 108838
		private bool DelayedDoubleColorMode;

		// Token: 0x0401A927 RID: 108839
		private bool PendingDoubleColorModeSwitch;

		// Token: 0x0401A928 RID: 108840
		private float DurationAniUse;

		// Token: 0x0401A929 RID: 108841
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401A92A RID: 108842
		[Nullable(2)]
		private UUISprite UltCdBar;

		// Token: 0x0401A92B RID: 108843
		private int UltCdDoneAnim;

		// Token: 0x0401A92C RID: 108844
		private int UltLevel;

		// Token: 0x0401A92D RID: 108845
		private bool IsUltFinalDone;

		// Token: 0x0200AB59 RID: 43865
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035019 RID: 217113
			PnlNor,
			// Token: 0x0403501A RID: 217114
			PnlBarC1,
			// Token: 0x0403501B RID: 217115
			PnlItemC1,
			// Token: 0x0403501C RID: 217116
			PnlBarC2,
			// Token: 0x0403501D RID: 217117
			PnlItemC2,
			// Token: 0x0403501E RID: 217118
			SlotNor,
			// Token: 0x0403501F RID: 217119
			PnlIconGun,
			// Token: 0x04035020 RID: 217120
			PnlIconRifle,
			// Token: 0x04035021 RID: 217121
			PnlUlt,
			// Token: 0x04035022 RID: 217122
			SprUltIcon,
			// Token: 0x04035023 RID: 217123
			SprUltBar0,
			// Token: 0x04035024 RID: 217124
			SprUltBar1,
			// Token: 0x04035025 RID: 217125
			SprUltBar2,
			// Token: 0x04035026 RID: 217126
			PnlHotKey,
			// Token: 0x04035027 RID: 217127
			AniRedGun,
			// Token: 0x04035028 RID: 217128
			AniGreenGun,
			// Token: 0x04035029 RID: 217129
			AniNorToUlt,
			// Token: 0x0403502A RID: 217130
			AniUltToNor,
			// Token: 0x0403502B RID: 217131
			AniState1Done,
			// Token: 0x0403502C RID: 217132
			AniState1To2,
			// Token: 0x0403502D RID: 217133
			AniState2Done,
			// Token: 0x0403502E RID: 217134
			AniState2To3,
			// Token: 0x0403502F RID: 217135
			AniState3Done,
			// Token: 0x04035030 RID: 217136
			AniState3Use,
			// Token: 0x04035031 RID: 217137
			NiaUltGun,
			// Token: 0x04035032 RID: 217138
			PnlUltBar,
			// Token: 0x04035033 RID: 217139
			PnlUltCdDone,
			// Token: 0x04035034 RID: 217140
			MaxCount
		}

		// Token: 0x0200AB5A RID: 43866
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04035036 RID: 217142
			StateGun,
			// Token: 0x04035037 RID: 217143
			StateRifle,
			// Token: 0x04035038 RID: 217144
			StateUlt
		}
	}
}
