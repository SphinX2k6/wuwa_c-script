using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DFE RID: 24062
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarRuibeika : SpecialEnergyBarBase
	{
		// Token: 0x0603D2C4 RID: 250564 RVA: 0x00EBBD10 File Offset: 0x00EB9F10
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

		// Token: 0x0603D2C5 RID: 250565 RVA: 0x00EBBDA8 File Offset: 0x00EB9FA8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarRuibeika.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarRuibeika.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D2C6 RID: 250566 RVA: 0x00EBBDEC File Offset: 0x00EB9FEC
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

		// Token: 0x0603D2C7 RID: 250567 RVA: 0x00EBBE60 File Offset: 0x00EBA060
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

		// Token: 0x0603D2C8 RID: 250568 RVA: 0x00EBBFFC File Offset: 0x00EBA1FC
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

		// Token: 0x0603D2C9 RID: 250569 RVA: 0x00EBC0F2 File Offset: 0x00EBA2F2
		protected override void OnBeforeDestroy()
		{
			this.RemoveTimer();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D2CA RID: 250570 RVA: 0x00EBC100 File Offset: 0x00EBA300
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

		// Token: 0x0603D2CB RID: 250571 RVA: 0x00EBC242 File Offset: 0x00EBA442
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

		// Token: 0x0603D2CC RID: 250572 RVA: 0x00EBC27B File Offset: 0x00EBA47B
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603D2CD RID: 250573 RVA: 0x00EBC2A0 File Offset: 0x00EBA4A0
		private void UpdateNorDotMode(bool doubleColor)
		{
			this.DelayedDoubleColorMode = doubleColor;
			this.PendingDoubleColorModeSwitch = true;
			if (this.DurationAniUse == 0f)
			{
				SpecialEnergyBarRuibeikaDot specialEnergyBarRuibeikaDot = this.C2DotItems.ElementAtOrDefault(0);
				this.DurationAniUse = Math.Max((specialEnergyBarRuibeikaDot != null) ? specialEnergyBarRuibeikaDot.GetAniUseDuration() : 0.2f, 0.2f);
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

		// Token: 0x0603D2CE RID: 250574 RVA: 0x00EBC32C File Offset: 0x00EBA52C
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

		// Token: 0x0603D2CF RID: 250575 RVA: 0x00EBC39C File Offset: 0x00EBA59C
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

		// Token: 0x0603D2D0 RID: 250576 RVA: 0x00EBC424 File Offset: 0x00EBA624
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

		// Token: 0x0603D2D1 RID: 250577 RVA: 0x00EBC474 File Offset: 0x00EBA674
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

		// Token: 0x0603D2D2 RID: 250578 RVA: 0x00EBC4DC File Offset: 0x00EBA6DC
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

		// Token: 0x0603D2D3 RID: 250579 RVA: 0x00EBC618 File Offset: 0x00EBA818
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

		// Token: 0x0603D2D6 RID: 250582 RVA: 0x00EBC728 File Offset: 0x00EBA928
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

		// Token: 0x0603D2D8 RID: 250584 RVA: 0x00EBC751 File Offset: 0x00EBA951
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

		// Token: 0x0401FE50 RID: 130640
		private const int BTN_ULTCONFIG = 130801;

		// Token: 0x0401FE51 RID: 130641
		private const EAttributeType ENERGY_ATTR_DOT = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FE52 RID: 130642
		private const EAttributeType ENERGY_MAX_ATTR_DOT = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FE53 RID: 130643
		private const EAttributeType ENERGY_ATTR_ULT = EAttributeType.SpecialEnergy3;

		// Token: 0x0401FE54 RID: 130644
		private const EAttributeType ENERGY_MAX_ATTR_ULT = EAttributeType.SpecialEnergy3Max;

		// Token: 0x0401FE55 RID: 130645
		[Nullable(2)]
		private SpecialEnergyBarSlotItem SlotItem;

		// Token: 0x0401FE56 RID: 130646
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FE57 RID: 130647
		private readonly List<SpecialEnergyBarRuibeikaDot> C1DotItems = new List<SpecialEnergyBarRuibeikaDot>();

		// Token: 0x0401FE58 RID: 130648
		private readonly List<SpecialEnergyBarRuibeikaDot> C2DotItems = new List<SpecialEnergyBarRuibeikaDot>();

		// Token: 0x0401FE59 RID: 130649
		private readonly MotorcyclePercentMachine UltCdMachine = new MotorcyclePercentMachine();

		// Token: 0x0401FE5A RID: 130650
		private float EnergyMaxB = 1f;

		// Token: 0x0401FE5B RID: 130651
		private float EnergyMaxC = 1f;

		// Token: 0x0401FE5C RID: 130652
		private SpecialEnergyBarRuibeika.EState CurState;

		// Token: 0x0401FE5D RID: 130653
		private float BarTipsWidth = 1f;

		// Token: 0x0401FE5E RID: 130654
		private bool IsDoubleColorMode;

		// Token: 0x0401FE5F RID: 130655
		private bool DelayedDoubleColorMode;

		// Token: 0x0401FE60 RID: 130656
		private bool PendingDoubleColorModeSwitch;

		// Token: 0x0401FE61 RID: 130657
		private float DurationAniUse;

		// Token: 0x0401FE62 RID: 130658
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401FE63 RID: 130659
		[Nullable(2)]
		private UUISprite UltCdBar;

		// Token: 0x0401FE64 RID: 130660
		private int UltCdDoneAnim;

		// Token: 0x0401FE65 RID: 130661
		private int UltLevel;

		// Token: 0x0401FE66 RID: 130662
		private bool IsUltFinalDone;

		// Token: 0x0200C14A RID: 49482
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A627 RID: 239143
			PnlNor,
			// Token: 0x0403A628 RID: 239144
			PnlBarC1,
			// Token: 0x0403A629 RID: 239145
			PnlItemC1,
			// Token: 0x0403A62A RID: 239146
			PnlBarC2,
			// Token: 0x0403A62B RID: 239147
			PnlItemC2,
			// Token: 0x0403A62C RID: 239148
			SlotNor,
			// Token: 0x0403A62D RID: 239149
			PnlIconGun,
			// Token: 0x0403A62E RID: 239150
			PnlIconRifle,
			// Token: 0x0403A62F RID: 239151
			PnlUlt,
			// Token: 0x0403A630 RID: 239152
			SprUltIcon,
			// Token: 0x0403A631 RID: 239153
			SprUltBar0,
			// Token: 0x0403A632 RID: 239154
			SprUltBar1,
			// Token: 0x0403A633 RID: 239155
			SprUltBar2,
			// Token: 0x0403A634 RID: 239156
			PnlHotKey,
			// Token: 0x0403A635 RID: 239157
			AniRedGun,
			// Token: 0x0403A636 RID: 239158
			AniGreenGun,
			// Token: 0x0403A637 RID: 239159
			AniNorToUlt,
			// Token: 0x0403A638 RID: 239160
			AniUltToNor,
			// Token: 0x0403A639 RID: 239161
			AniState1Done,
			// Token: 0x0403A63A RID: 239162
			AniState1To2,
			// Token: 0x0403A63B RID: 239163
			AniState2Done,
			// Token: 0x0403A63C RID: 239164
			AniState2To3,
			// Token: 0x0403A63D RID: 239165
			AniState3Done,
			// Token: 0x0403A63E RID: 239166
			AniState3Use,
			// Token: 0x0403A63F RID: 239167
			NiaUltGun,
			// Token: 0x0403A640 RID: 239168
			PnlUltBar,
			// Token: 0x0403A641 RID: 239169
			PnlUltCdDone,
			// Token: 0x0403A642 RID: 239170
			MaxCount
		}

		// Token: 0x0200C14B RID: 49483
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A644 RID: 239172
			StateGun,
			// Token: 0x0403A645 RID: 239173
			StateRifle,
			// Token: 0x0403A646 RID: 239174
			StateUlt
		}
	}
}
