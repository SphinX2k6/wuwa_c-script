using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D4B RID: 23883
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterNpcAttackHeadState : HeadStateViewBase
	{
		// Token: 0x0603CA07 RID: 248327 RVA: 0x00E8CBA4 File Offset: 0x00E8ADA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 27;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.ScaleToleration = 0.003f;
		}

		// Token: 0x0603CA08 RID: 248328 RVA: 0x00E8CF64 File Offset: 0x00E8B164
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.RefreshNeedCorrectionOutside();
			this.RefreshHpAndShield(false);
			this.RefreshLevelText();
			base.RefreshHeadStateRotation();
			this.RefreshHeadStateDetail();
			this.RefreshLevelTextVisible();
			this.RefreshBuffVisible();
			this.RefreshBuff();
			this.RefreshHpColor();
			this.RefreshSpecialEnergy4(false);
			this.RefreshSlowChargeState(null);
			this.RefreshFastChargeState(null);
			this.RefreshAttackReadyState(null);
			this.RefreshAttackBeginState(null);
			this.RefreshAttackEndState(null);
			this.RefreshAttackBrokenState(null);
		}

		// Token: 0x0603CA09 RID: 248329 RVA: 0x00E8D010 File Offset: 0x00E8B210
		protected override void OnStart()
		{
			this.InitAllTweenAnim();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.HitLargePercent = (float)ConfigCommonParamById.GetIntConfig("HitLargeBufferPercent").Value / 10000f;
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(16);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(18);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(false);
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(17);
			if (uiNiagara3 != null)
			{
				uiNiagara3.SetUIActive(false);
			}
			UUINiagara uiNiagara4 = base.GetUiNiagara(19);
			if (uiNiagara4 != null)
			{
				uiNiagara4.SetUIActive(false);
			}
			this.BuffItemContainer.Init(base.GetItem(8), 6, true, false, false, null);
		}

		// Token: 0x0603CA0A RID: 248330 RVA: 0x00E8D0E5 File Offset: 0x00E8B2E5
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603CA0B RID: 248331 RVA: 0x00E8D0F9 File Offset: 0x00E8B2F9
		protected override void ResetBattleHeadState()
		{
			this.BuffItemContainer.ClearAll();
			base.ResetBattleHeadState();
		}

		// Token: 0x0603CA0C RID: 248332 RVA: 0x00E8D10C File Offset: 0x00E8B30C
		protected override string GetResourceId()
		{
			return "UiItem_EnergyBarAogusita";
		}

		// Token: 0x0603CA0D RID: 248333 RVA: 0x00E8D113 File Offset: 0x00E8B313
		public override void OnRefresh(float distance, float scale, float delta)
		{
			base.OnRefresh(distance, scale, delta);
			if (!this.IsActivated)
			{
				return;
			}
			this.RefreshHeadStateDetail();
			this.RefreshLevelTextVisible();
			this.RefreshBuffVisible();
			this.TickBuffItem(delta);
			this.LerpAttackPercent(delta);
		}

		// Token: 0x0603CA0E RID: 248334 RVA: 0x00E8D147 File Offset: 0x00E8B347
		protected override void OnAddOrRemoveBuff(int entityId, in GameplayCue cueConfig, bool isAdd, int handleId)
		{
			if (this.HeadStateData.GetEntityId() != entityId)
			{
				return;
			}
			if (isAdd)
			{
				this.BuffItemContainer.AddBuffByCue(cueConfig, handleId, true);
				return;
			}
			this.BuffItemContainer.RemoveBuffByCue(cueConfig, handleId, true);
		}

		// Token: 0x0603CA0F RID: 248335 RVA: 0x00E8D180 File Offset: 0x00E8B380
		private void RefreshBuff()
		{
			if (this.HeadStateData == null)
			{
				this.BuffItemContainer.ClearAll();
				return;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(this.HeadStateData.GetEntityId());
			this.BuffItemContainer.RefreshBuff(handle);
		}

		// Token: 0x0603CA10 RID: 248336 RVA: 0x00E8D1C4 File Offset: 0x00E8B3C4
		private void RefreshHeadStateDetail()
		{
			bool uiactive = base.IsDetailVisible();
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x0603CA11 RID: 248337 RVA: 0x00E8D1E8 File Offset: 0x00E8B3E8
		private void RefreshLevelTextVisible()
		{
			bool uiactive = base.IsLevelTextVisible();
			base.GetText(4).SetUIActive(uiactive);
		}

		// Token: 0x0603CA12 RID: 248338 RVA: 0x00E8D20C File Offset: 0x00E8B40C
		private void RefreshBuffVisible()
		{
			bool uiactive = base.IsBuffVisible();
			base.GetItem(8).SetUIActive(uiactive);
		}

		// Token: 0x0603CA13 RID: 248339 RVA: 0x00E8D22D File Offset: 0x00E8B42D
		private void TickBuffItem(float delta)
		{
			if (!base.IsBuffVisible())
			{
				return;
			}
			this.BuffItemContainer.Tick(delta);
		}

		// Token: 0x0603CA14 RID: 248340 RVA: 0x00E8D244 File Offset: 0x00E8B444
		private void LerpAttackPercent(float delta)
		{
			this.AttackMachine.UpdatePercent(delta);
			if (this.AttackMachine.HasUpdate())
			{
				this.RefreshEnergyBar(this.AttackMachine.CurrentPercent);
			}
		}

		// Token: 0x0603CA15 RID: 248341 RVA: 0x00E8D274 File Offset: 0x00E8B474
		private void RefreshNeedCorrectionOutside()
		{
			CharacterActorComponent characterActorComponent = this.HeadStateData.ActorComponent as CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.HalfHeight > this.HeadStateData.CommonParam.OutMonsterHalfHeight)
			{
				this.NeedCorrectionOutside = true;
			}
		}

		// Token: 0x0603CA16 RID: 248342 RVA: 0x00E8D2B4 File Offset: 0x00E8B4B4
		public void RefreshHpAndShield(bool bPlayBarAnimation = false)
		{
			ValueTuple<float, float> hpAndShieldPercent = base.GetHpAndShieldPercent();
			float item = hpAndShieldPercent.Item1;
			float item2 = hpAndShieldPercent.Item2;
			this.SetHpBarPercent(item);
			this.SetShieldBarPercent(item2);
			if (bPlayBarAnimation)
			{
				if (item < this.CurrentBarPercent)
				{
					float num = this.CurrentBarPercent - item;
					float hitLargePercent = this.HitLargePercent;
				}
				this.PlayBarAnimation(item);
				return;
			}
			this.StopBarLerpAnimation();
		}

		// Token: 0x0603CA17 RID: 248343 RVA: 0x00E8D30C File Offset: 0x00E8B50C
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603CA18 RID: 248344 RVA: 0x00E8D315 File Offset: 0x00E8B515
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603CA19 RID: 248345 RVA: 0x00E8D32A File Offset: 0x00E8B52A
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x0603CA1A RID: 248346 RVA: 0x00E8D333 File Offset: 0x00E8B533
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x0603CA1B RID: 248347 RVA: 0x00E8D344 File Offset: 0x00E8B544
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetFillAmount(percent);
			sprite.SetUIActive(true);
			UUISprite sprite2 = base.GetSprite(2);
			sprite2.SetStretchLeft(this.HpParentWidth * this.CurrentBarPercent - 2f);
			sprite2.SetStretchRight(this.HpParentWidth * (1f - percent) - 2f);
		}

		// Token: 0x0603CA1C RID: 248348 RVA: 0x00E8D3A0 File Offset: 0x00E8B5A0
		private void SetShieldBarPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(3);
			if (percent > 0f)
			{
				sprite.SetFillAmount(percent);
				sprite.SetUIActive(true);
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0603CA1D RID: 248349 RVA: 0x00E8D3D4 File Offset: 0x00E8B5D4
		protected override void BindCallback()
		{
			base.BindCallback();
			if (this.HeadStateData == null)
			{
				return;
			}
			MonsterNpcAttackHeadStateData monsterNpcAttackHeadStateData = (MonsterNpcAttackHeadStateData)this.HeadStateData;
			monsterNpcAttackHeadStateData.BindOnSpecialEnergy4Changed(new Action<EAttributeType, float, float>(this.OnSpecialEnergy4Changed));
			monsterNpcAttackHeadStateData.BindOnSlowChargeStateChanged(new Action<int, bool>(this.OnSlowChargeStateChanged));
			monsterNpcAttackHeadStateData.BindOnFastChargeStateChanged(new Action<int, bool>(this.OnFastChargeStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackReadyStateChanged(new Action<int, bool>(this.OnAttackReadyStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackBeginStateChanged(new Action<int, bool>(this.OnAttackBeginStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackEndStateChanged(new Action<int, bool>(this.OnAttackEndStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackBrokenStateChanged(new Action<int, bool>(this.OnAttackBrokenStateChanged));
		}

		// Token: 0x0603CA1E RID: 248350 RVA: 0x00E8D478 File Offset: 0x00E8B678
		protected override void OnShieldChanged(float shield)
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603CA1F RID: 248351 RVA: 0x00E8D481 File Offset: 0x00E8B681
		protected override void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603CA20 RID: 248352 RVA: 0x00E8D489 File Offset: 0x00E8B689
		protected override void OnRoleLevelChange(int configId, int exp, int level)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603CA21 RID: 248353 RVA: 0x00E8D491 File Offset: 0x00E8B691
		protected override void OnChangeTeam()
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603CA22 RID: 248354 RVA: 0x00E8D499 File Offset: 0x00E8B699
		protected override void OnHealthChanged()
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603CA23 RID: 248355 RVA: 0x00E8D4A2 File Offset: 0x00E8B6A2
		private void OnSpecialEnergy4Changed(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshSpecialEnergy4(true);
		}

		// Token: 0x0603CA24 RID: 248356 RVA: 0x00E8D4AB File Offset: 0x00E8B6AB
		private void OnSlowChargeStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshSlowChargeState(new bool?(bTagExists));
		}

		// Token: 0x0603CA25 RID: 248357 RVA: 0x00E8D4B9 File Offset: 0x00E8B6B9
		private void OnFastChargeStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshFastChargeState(new bool?(bTagExists));
		}

		// Token: 0x0603CA26 RID: 248358 RVA: 0x00E8D4C7 File Offset: 0x00E8B6C7
		private void OnAttackReadyStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackReadyState(new bool?(bTagExists));
		}

		// Token: 0x0603CA27 RID: 248359 RVA: 0x00E8D4D5 File Offset: 0x00E8B6D5
		private void OnAttackBeginStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackBeginState(new bool?(bTagExists));
		}

		// Token: 0x0603CA28 RID: 248360 RVA: 0x00E8D4E3 File Offset: 0x00E8B6E3
		private void OnAttackEndStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackEndState(new bool?(bTagExists));
		}

		// Token: 0x0603CA29 RID: 248361 RVA: 0x00E8D4F1 File Offset: 0x00E8B6F1
		private void OnAttackBrokenStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackBrokenState(new bool?(bTagExists));
		}

		// Token: 0x0603CA2A RID: 248362 RVA: 0x00E8D500 File Offset: 0x00E8B700
		private void RefreshLevelText()
		{
			if (this.HeadStateData == null)
			{
				return;
			}
			int level = this.GetLevel();
			UUIText text = base.GetText(4);
			string threadColor = BattleUiConfig.Instance.GetThreadColor(level, this.HeadStateData.Camp);
			text.SetColor(FColor.FromHex(threadColor));
			LguiUtil.Instance.SetLocalText(text, "LevelShow", new <>z__ReadOnlySingleElementList<object>(level));
		}

		// Token: 0x0603CA2B RID: 248363 RVA: 0x00E8D563 File Offset: 0x00E8B763
		protected override void RefreshOnCampChanged()
		{
			this.RefreshLevelText();
			this.RefreshHpColor();
		}

		// Token: 0x0603CA2C RID: 248364 RVA: 0x00E8D574 File Offset: 0x00E8B774
		private void RefreshHpColor()
		{
			string hpColor = base.GetHpColor();
			if (string.IsNullOrEmpty(hpColor))
			{
				return;
			}
			FColor color = FColor.FromHex(hpColor);
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(color);
		}

		// Token: 0x0603CA2D RID: 248365 RVA: 0x00E8D5AC File Offset: 0x00E8B7AC
		private void RefreshEnergyBar(float percent)
		{
			if (percent > 0f)
			{
				UUIItem item = base.GetItem(21);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUISliderComponent slider = base.GetSlider(10);
				if (slider != null)
				{
					slider.SetValue(percent, true);
				}
				UUISliderComponent slider2 = base.GetSlider(12);
				if (slider2 != null)
				{
					slider2.SetValue(percent, true);
				}
				if (this.EnergyPercent >= 1f)
				{
					UUINiagara uiNiagara = base.GetUiNiagara(16);
					if (uiNiagara != null)
					{
						uiNiagara.SetUIActive(false);
					}
					UUINiagara uiNiagara2 = base.GetUiNiagara(18);
					if (uiNiagara2 != null)
					{
						uiNiagara2.SetUIActive(false);
					}
					UUINiagara uiNiagara3 = base.GetUiNiagara(17);
					if (uiNiagara3 != null)
					{
						uiNiagara3.SetUIActive(false);
					}
					UUINiagara uiNiagara4 = base.GetUiNiagara(19);
					if (uiNiagara4 == null)
					{
						return;
					}
					uiNiagara4.SetUIActive(false);
				}
				return;
			}
			UUIItem item2 = base.GetItem(21);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0603CA2E RID: 248366 RVA: 0x00E8D670 File Offset: 0x00E8B870
		private void RefreshSpecialEnergy4(bool lerp)
		{
			float attributeCurrentValueById = this.HeadStateData.GetAttributeCurrentValueById(EAttributeType.SpecialEnergy4);
			float attributeCurrentValueById2 = this.HeadStateData.GetAttributeCurrentValueById(EAttributeType.SpecialEnergy4Max);
			float num = (attributeCurrentValueById2 == 0f) ? 0f : (attributeCurrentValueById / attributeCurrentValueById2);
			if (num == this.EnergyPercent)
			{
				return;
			}
			this.EnergyPercent = num;
			this.AttackMachine.SetTargetPercent(num, lerp ? 200f : 0f);
		}

		// Token: 0x0603CA2F RID: 248367 RVA: 0x00E8D6D8 File Offset: 0x00E8B8D8
		private void RefreshSlowChargeState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.未出手状态_慢充"]))
			{
				if (!this.IsFullEnergy())
				{
					UUINiagara uiNiagara = base.GetUiNiagara(16);
					if (uiNiagara != null)
					{
						uiNiagara.SetUIActive(true);
					}
					UUINiagara uiNiagara2 = base.GetUiNiagara(18);
					if (uiNiagara2 == null)
					{
						return;
					}
					uiNiagara2.SetUIActive(true);
					return;
				}
			}
			else
			{
				UUINiagara uiNiagara3 = base.GetUiNiagara(16);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(false);
				}
				UUINiagara uiNiagara4 = base.GetUiNiagara(18);
				if (uiNiagara4 == null)
				{
					return;
				}
				uiNiagara4.SetUIActive(false);
			}
		}

		// Token: 0x0603CA30 RID: 248368 RVA: 0x00E8D76C File Offset: 0x00E8B96C
		private void RefreshFastChargeState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.未出手状态_快充"]))
			{
				if (!this.IsFullEnergy())
				{
					UUINiagara uiNiagara = base.GetUiNiagara(17);
					if (uiNiagara != null)
					{
						uiNiagara.SetUIActive(true);
					}
					UUINiagara uiNiagara2 = base.GetUiNiagara(19);
					if (uiNiagara2 == null)
					{
						return;
					}
					uiNiagara2.SetUIActive(true);
					return;
				}
			}
			else
			{
				UUINiagara uiNiagara3 = base.GetUiNiagara(17);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(false);
				}
				UUINiagara uiNiagara4 = base.GetUiNiagara(19);
				if (uiNiagara4 == null)
				{
					return;
				}
				uiNiagara4.SetUIActive(false);
			}
		}

		// Token: 0x0603CA31 RID: 248369 RVA: 0x00E8D800 File Offset: 0x00E8BA00
		private void RefreshAttackReadyState(bool? isInState = null)
		{
			bool flag = isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.准备状态"]);
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				this.PlayTweenAnim(25);
				return;
			}
			this.StopTweenAnim(25);
			this.PlayTweenAnim(26);
		}

		// Token: 0x0603CA32 RID: 248370 RVA: 0x00E8D86C File Offset: 0x00E8BA6C
		private void RefreshAttackBeginState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态"]))
			{
				this.PlayTweenAnim(22);
				return;
			}
			this.StopTweenAnim(22);
		}

		// Token: 0x0603CA33 RID: 248371 RVA: 0x00E8D8BC File Offset: 0x00E8BABC
		private void RefreshAttackEndState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态退出_弱"]))
			{
				this.PlayTweenAnim(23);
				return;
			}
			this.StopTweenAnim(23);
		}

		// Token: 0x0603CA34 RID: 248372 RVA: 0x00E8D90C File Offset: 0x00E8BB0C
		private void RefreshAttackBrokenState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态退出_强"]))
			{
				this.PlayTweenAnim(24);
				return;
			}
			this.StopTweenAnim(24);
		}

		// Token: 0x0603CA35 RID: 248373 RVA: 0x00E8D95A File Offset: 0x00E8BB5A
		private bool IsFullEnergy()
		{
			return this.EnergyPercent >= 1f;
		}

		// Token: 0x0603CA36 RID: 248374 RVA: 0x00E8D96C File Offset: 0x00E8BB6C
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(22);
			this.InitTweenAnim(23);
			this.InitTweenAnim(24);
			this.InitTweenAnim(25);
			this.InitTweenAnim(26);
		}

		// Token: 0x0603CA37 RID: 248375 RVA: 0x00E8D998 File Offset: 0x00E8BB98
		private void InitTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			foreach (UActorComponent uactorComponent in base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()))
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x0603CA38 RID: 248376 RVA: 0x00E8DA14 File Offset: 0x00E8BC14
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x0603CA39 RID: 248377 RVA: 0x00E8DA70 File Offset: 0x00E8BC70
		private void StopTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x0401F94B RID: 129355
		private const float SCALE_TOLERATION = 0.003f;

		// Token: 0x0401F94C RID: 129356
		private const float LERP_ANIM_TIME = 200f;

		// Token: 0x0401F94D RID: 129357
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F94E RID: 129358
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401F94F RID: 129359
		private readonly MonsterNpcAttackMachine AttackMachine = new MonsterNpcAttackMachine();

		// Token: 0x0401F950 RID: 129360
		private float HitLargePercent;

		// Token: 0x0401F951 RID: 129361
		private float HpParentWidth;

		// Token: 0x0401F952 RID: 129362
		private float EnergyPercent;

		// Token: 0x0401F953 RID: 129363
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200BFEF RID: 49135
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039EB2 RID: 237234
			NormalHpBarSprite,
			// Token: 0x04039EB3 RID: 237235
			BarBufferSprite,
			// Token: 0x04039EB4 RID: 237236
			HpLight,
			// Token: 0x04039EB5 RID: 237237
			ShieldBarSprite,
			// Token: 0x04039EB6 RID: 237238
			LevelText,
			// Token: 0x04039EB7 RID: 237239
			DetailItem,
			// Token: 0x04039EB8 RID: 237240
			HpItem,
			// Token: 0x04039EB9 RID: 237241
			HpBarItem,
			// Token: 0x04039EBA RID: 237242
			BuffHorizontalItem,
			// Token: 0x04039EBB RID: 237243
			EnergyItem,
			// Token: 0x04039EBC RID: 237244
			EnergySliderLeft,
			// Token: 0x04039EBD RID: 237245
			EnergyFullSpriteLeft,
			// Token: 0x04039EBE RID: 237246
			EnergySliderRight,
			// Token: 0x04039EBF RID: 237247
			EnergyFullSpriteRight,
			// Token: 0x04039EC0 RID: 237248
			EnergyCenterPoint,
			// Token: 0x04039EC1 RID: 237249
			BrokenItem,
			// Token: 0x04039EC2 RID: 237250
			SlowChargeLeft,
			// Token: 0x04039EC3 RID: 237251
			FastChargeLeft,
			// Token: 0x04039EC4 RID: 237252
			SlowChargeRight,
			// Token: 0x04039EC5 RID: 237253
			FastChargeRight,
			// Token: 0x04039EC6 RID: 237254
			EnergyFullItem,
			// Token: 0x04039EC7 RID: 237255
			EnergyBarItem,
			// Token: 0x04039EC8 RID: 237256
			AnimWarningStart,
			// Token: 0x04039EC9 RID: 237257
			AnimWarningClose,
			// Token: 0x04039ECA RID: 237258
			AnimWarningBreak,
			// Token: 0x04039ECB RID: 237259
			AnimWarningReady,
			// Token: 0x04039ECC RID: 237260
			AnimWarningReadyClose
		}
	}
}
