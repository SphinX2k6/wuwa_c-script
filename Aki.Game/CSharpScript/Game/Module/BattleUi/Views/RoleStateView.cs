using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DB0 RID: 23984
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleStateView : BattleVisibleChildView
	{
		// Token: 0x0603CE9D RID: 249501 RVA: 0x00EA1EF4 File Offset: 0x00EA00F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CE9E RID: 249502 RVA: 0x00EA2068 File Offset: 0x00EA0268
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.Ignore);
			this.BufferAnimLengthInternal = ConfigCommonParamById.GetIntConfig("PlayerHPAttenuateBufferSpeed").Value;
			this.HpMask = (base.GetItem(8).GetOwner().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
			this.HpTextWidth = base.GetText(1).GetWidth();
			this.ShieldSequence = new LevelSequencePlayer(base.GetSprite(5));
			this.AddEvents();
		}

		// Token: 0x0603CE9F RID: 249503 RVA: 0x00EA20EC File Offset: 0x00EA02EC
		protected override void OnBeforeDestroy()
		{
			this.Refresh(null);
			if (this.MotorcycleShieldItem != null)
			{
				this.MotorcycleShieldItem.ExistShieldChanged = null;
				this.MotorcycleShieldItem.Destroy(null);
				this.MotorcycleShieldItem = null;
			}
		}

		// Token: 0x0603CEA0 RID: 249504 RVA: 0x00EA211C File Offset: 0x00EA031C
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603CEA1 RID: 249505 RVA: 0x00EA212C File Offset: 0x00EA032C
		public void Refresh(BattleUiRoleData roleData)
		{
			if (roleData == null)
			{
				this.RoleData = null;
				this.EntityId = null;
				this.AttributeComponent = null;
				this.ShieldComponent = null;
				this.DeactivateRoleState();
				return;
			}
			this.RoleData = roleData;
			EntityHandle entityHandle = roleData.EntityHandle;
			this.EntityId = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			this.AttributeComponent = roleData.AttributeComponent;
			EntityHandle entityHandle2 = roleData.EntityHandle;
			CharacterShieldComponent shieldComponent;
			if (entityHandle2 == null)
			{
				shieldComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle2.Entity;
				shieldComponent = ((entity != null) ? entity.GetComponent<CharacterShieldComponent>() : null);
			}
			this.ShieldComponent = shieldComponent;
			this.RefreshRoleState();
		}

		// Token: 0x0603CEA2 RID: 249506 RVA: 0x00EA21C6 File Offset: 0x00EA03C6
		public bool IsValid()
		{
			BattleUiRoleData roleData = this.RoleData;
			return ((roleData != null) ? roleData.EntityHandle : null) != null;
		}

		// Token: 0x0603CEA3 RID: 249507 RVA: 0x00EA21DD File Offset: 0x00EA03DD
		public int? GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x0603CEA4 RID: 249508 RVA: 0x00EA21E8 File Offset: 0x00EA03E8
		private void AddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.BattleUiHealthChanged, new Action<int>(this.OnHealthChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiShieldChanged, new Action<int>(this.OnShieldChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiLevelChanged, new Action<int>(this.OnLevelChanged));
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x0603CEA5 RID: 249509 RVA: 0x00EA2284 File Offset: 0x00EA0484
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiHealthChanged, new Action<int>(this.OnHealthChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiShieldChanged, new Action<int>(this.OnShieldChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiLevelChanged, new Action<int>(this.OnLevelChanged));
			EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x0603CEA6 RID: 249510 RVA: 0x00EA231D File Offset: 0x00EA051D
		public void Tick(float delta)
		{
			this.LerpBarPercent(delta);
			MotorcycleShieldItem motorcycleShieldItem = this.MotorcycleShieldItem;
			if (motorcycleShieldItem == null)
			{
				return;
			}
			motorcycleShieldItem.Tick(delta);
		}

		// Token: 0x0603CEA7 RID: 249511 RVA: 0x00EA2337 File Offset: 0x00EA0537
		private void DeactivateRoleState()
		{
			if (TimerSystem.Instance.Has(this.DelayTimerId))
			{
				TimerSystem.Instance.Remove(this.DelayTimerId);
			}
			this.StopBarLerpAnimation();
			this.DelayTimerId = null;
			base.SetVisible(1, false);
		}

		// Token: 0x0603CEA8 RID: 249512 RVA: 0x00EA2374 File Offset: 0x00EA0574
		private void LerpBarPercent(float delta)
		{
			if (this.AnimTime == -1f)
			{
				return;
			}
			if (this.AnimTime >= (float)this.BufferAnimLengthInternal)
			{
				this.StopBarLerpAnimation();
			}
			if (this.TargetBarPercent >= this.SourceBarPercent)
			{
				return;
			}
			float alpha = this.AnimTime / (float)this.BufferAnimLengthInternal;
			float barBufferPercent = MathUtils.Instance.Lerp(this.SourceBarPercent, this.TargetBarPercent, alpha);
			this.SetBarBufferPercent(barBufferPercent);
			this.AnimTime += delta;
		}

		// Token: 0x0603CEA9 RID: 249513 RVA: 0x00EA23F0 File Offset: 0x00EA05F0
		public void SetNiagaraActive(bool bActive)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			uiNiagara.SetUIActive(bActive);
			if (bActive)
			{
				uiNiagara.SetNiagaraVarFloat("Dissolve", this.CurrentBarPercent);
				uiNiagara.ActivateSystem(true);
				return;
			}
			uiNiagara.DeactivateSystem();
		}

		// Token: 0x0603CEAA RID: 249514 RVA: 0x00EA242E File Offset: 0x00EA062E
		public void RefreshRoleState()
		{
			if (!this.IsValid())
			{
				return;
			}
			this.StopBarLerpAnimation();
			this.RefreshHpAndShield(false);
			this.RefreshLevel();
			this.RefreshMotorcycleShield();
			base.SetVisible(1, true);
		}

		// Token: 0x0603CEAB RID: 249515 RVA: 0x00EA245C File Offset: 0x00EA065C
		private void OnShieldChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603CEAC RID: 249516 RVA: 0x00EA248C File Offset: 0x00EA068C
		private void OnHealthChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshHpAndShield(true);
			this.SetNiagaraActive(true);
		}

		// Token: 0x0603CEAD RID: 249517 RVA: 0x00EA24C4 File Offset: 0x00EA06C4
		private void OnLevelChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshLevel();
		}

		// Token: 0x0603CEAE RID: 249518 RVA: 0x00EA24F3 File Offset: 0x00EA06F3
		[NullableContext(1)]
		private void OnRefreshText(string s, string s1)
		{
			this.RefreshLevel();
			this.RefreshHpAndShield(false);
		}

		// Token: 0x0603CEAF RID: 249519 RVA: 0x00EA2502 File Offset: 0x00EA0702
		private void OnMotorcycleStateChanged(bool b)
		{
			this.RefreshMotorcycleShield();
		}

		// Token: 0x0603CEB0 RID: 249520 RVA: 0x00EA250C File Offset: 0x00EA070C
		public void RefreshHpAndShield(bool bPlayBarAnimation = false)
		{
			if (!this.IsValid())
			{
				return;
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			float currentValue = attributeComponent.GetCurrentValue(EAttributeType.Life);
			float currentValue2 = attributeComponent.GetCurrentValue(EAttributeType.LifeMax);
			float shieldTotal = this.ShieldComponent.ShieldTotal;
			float num = currentValue / currentValue2;
			float shieldBarPercent = Math.Min(shieldTotal / currentValue2, 1f);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)currentValue));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Ceiling((double)currentValue2));
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			this.UeMargin.Right = -(1f - num) * this.HpTextWidth;
			this.HpMask.SetRectClipOffset(this.UeMargin);
			base.GetText(1).SetText(newText, true);
			base.GetText(7).SetText(newText, true);
			this.SetHpBarPercent(num);
			this.SetShieldBarPercent(shieldBarPercent);
			if (bPlayBarAnimation)
			{
				this.PlayBarAnimation();
			}
			else
			{
				this.StopBarLerpAnimation();
			}
			this.CurrentBarPercent = num;
		}

		// Token: 0x0603CEB1 RID: 249521 RVA: 0x00EA2604 File Offset: 0x00EA0804
		private void PlayBarAnimation()
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			float currentValue = attributeComponent.GetCurrentValue(EAttributeType.Life);
			float currentValue2 = attributeComponent.GetCurrentValue(EAttributeType.LifeMax);
			float num = currentValue / currentValue2;
			float currentBarPercent = this.CurrentBarPercent;
			if (num >= currentBarPercent)
			{
				return;
			}
			this.TargetBarPercent = num;
			this.SourceBarPercent = currentBarPercent;
			this.AnimTime = 0f;
		}

		// Token: 0x0603CEB2 RID: 249522 RVA: 0x00EA2658 File Offset: 0x00EA0858
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(4);
			sprite.SetFillAmount(percent);
			sprite.SetUIActive(true);
		}

		// Token: 0x0603CEB3 RID: 249523 RVA: 0x00EA266E File Offset: 0x00EA086E
		private void StopBarLerpAnimation()
		{
			base.GetSprite(4).SetUIActive(false);
			this.TargetBarPercent = 0f;
			this.SourceBarPercent = 0f;
			this.AnimTime = -1f;
		}

		// Token: 0x0603CEB4 RID: 249524 RVA: 0x00EA26A0 File Offset: 0x00EA08A0
		private void SetHpBarPercent(float percent)
		{
			this.RefreshHpSpriteVisible(percent);
			UUISprite sprite = base.GetSprite(3);
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite.bIsUIActive)
			{
				sprite.SetFillAmount(percent);
			}
			if (sprite2.bIsUIActive)
			{
				sprite2.SetFillAmount(percent);
			}
		}

		// Token: 0x0603CEB5 RID: 249525 RVA: 0x00EA26E4 File Offset: 0x00EA08E4
		private void RefreshHpSpriteVisible(float percent)
		{
			UUISprite sprite = base.GetSprite(3);
			UUISprite sprite2 = base.GetSprite(0);
			if (percent <= 0.2f)
			{
				sprite.SetUIActive(true);
				sprite2.SetUIActive(false);
				return;
			}
			sprite.SetUIActive(false);
			sprite2.SetUIActive(true);
		}

		// Token: 0x0603CEB6 RID: 249526 RVA: 0x00EA2728 File Offset: 0x00EA0928
		private void SetShieldBarPercent(float percent)
		{
			this.ShieldPercent = percent;
			UUISprite sprite = base.GetSprite(5);
			MotorcycleShieldItem motorcycleShieldItem = this.MotorcycleShieldItem;
			bool flag = (motorcycleShieldItem == null || !motorcycleShieldItem.ExistShield) && percent > 0f;
			sprite.SetUIActive(flag);
			if (this.ShieldLastState != flag)
			{
				this.ShieldLastState = flag;
				if (flag)
				{
					this.ShieldSequence.PlayLevelSequenceByName("Start", false, null, false);
				}
			}
			if (flag)
			{
				sprite.SetFillAmount(percent);
			}
		}

		// Token: 0x0603CEB7 RID: 249527 RVA: 0x00EA27A4 File Offset: 0x00EA09A4
		private void RefreshLevel()
		{
			if (!this.IsValid())
			{
				return;
			}
			UUIText text = base.GetText(2);
			RoleInfo? roleConfig = this.RoleData.RoleConfig;
			if (((roleConfig != null) ? new int?(roleConfig.GetValueOrDefault().RoleType) : null).Value == 2)
			{
				text.SetText(string.Empty, true);
				return;
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				text.SetText(string.Empty, true);
				return;
			}
			int num = (int)attributeComponent.GetCurrentValue(EAttributeType.Lv);
			LguiUtil.Instance.SetLocalTextNew(text, "LevelShowNew", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x0603CEB8 RID: 249528 RVA: 0x00EA284C File Offset: 0x00EA0A4C
		private void RefreshMotorcycleShield()
		{
			if (BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				if (this.MotorcycleShieldItem == null)
				{
					this.MotorcycleShieldItem = new MotorcycleShieldItem();
					this.MotorcycleShieldItem.ExistShieldChanged = new Action(this.ExistShieldChanged);
					this.MotorcycleShieldItem.CreateThenShowByResourceIdAsync("UiItem_MotorcycleShieldBar", base.GetRootItem(), false);
					return;
				}
			}
			else if (this.MotorcycleShieldItem != null)
			{
				this.MotorcycleShieldItem.ExistShieldChanged = null;
				this.MotorcycleShieldItem.Destroy(null);
				this.MotorcycleShieldItem = null;
				this.ExistShieldChanged();
			}
		}

		// Token: 0x0603CEB9 RID: 249529 RVA: 0x00EA28DA File Offset: 0x00EA0ADA
		private void ExistShieldChanged()
		{
			this.SetShieldBarPercent(this.ShieldPercent);
		}

		// Token: 0x0401FB8B RID: 129931
		private const float LOW_HP_PERCENT = 0.2f;

		// Token: 0x0401FB8C RID: 129932
		private BattleUiRoleData RoleData;

		// Token: 0x0401FB8D RID: 129933
		private int? EntityId;

		// Token: 0x0401FB8E RID: 129934
		private BaseAttributeComponent AttributeComponent;

		// Token: 0x0401FB8F RID: 129935
		private CharacterShieldComponent ShieldComponent;

		// Token: 0x0401FB90 RID: 129936
		private TimerHandle DelayTimerId;

		// Token: 0x0401FB91 RID: 129937
		private float CurrentBarPercent = -1f;

		// Token: 0x0401FB92 RID: 129938
		private float TargetBarPercent;

		// Token: 0x0401FB93 RID: 129939
		private float SourceBarPercent;

		// Token: 0x0401FB94 RID: 129940
		private float AnimTime = -1f;

		// Token: 0x0401FB95 RID: 129941
		private int BufferAnimLengthInternal;

		// Token: 0x0401FB96 RID: 129942
		private ULGUICanvas HpMask;

		// Token: 0x0401FB97 RID: 129943
		private FMargin UeMargin;

		// Token: 0x0401FB98 RID: 129944
		private float HpTextWidth;

		// Token: 0x0401FB99 RID: 129945
		private LevelSequencePlayer ShieldSequence;

		// Token: 0x0401FB9A RID: 129946
		private bool ShieldLastState;

		// Token: 0x0401FB9B RID: 129947
		private float ShieldPercent;

		// Token: 0x0401FB9C RID: 129948
		private MotorcycleShieldItem MotorcycleShieldItem;

		// Token: 0x0200C090 RID: 49296
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x0403A1B9 RID: 238009
			RoleHpBar,
			// Token: 0x0403A1BA RID: 238010
			RoleHpNumber,
			// Token: 0x0403A1BB RID: 238011
			RoleLvNumber,
			// Token: 0x0403A1BC RID: 238012
			HpLowBarSprite,
			// Token: 0x0403A1BD RID: 238013
			HpBufferSprite,
			// Token: 0x0403A1BE RID: 238014
			ShieldFrameSprite,
			// Token: 0x0403A1BF RID: 238015
			Niagara,
			// Token: 0x0403A1C0 RID: 238016
			RoleHpNumber2,
			// Token: 0x0403A1C1 RID: 238017
			RoleHpMask,
			// Token: 0x0403A1C2 RID: 238018
			HpAdjustNode,
			// Token: 0x0403A1C3 RID: 238019
			HpLockSprite,
			// Token: 0x0403A1C4 RID: 238020
			HpAdditionNode
		}
	}
}
