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
	// Token: 0x02004D94 RID: 19860
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleStateView : BattleVisibleChildView
	{
		// Token: 0x06031E14 RID: 204308 RVA: 0x00DF2DC8 File Offset: 0x00DF0FC8
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

		// Token: 0x06031E15 RID: 204309 RVA: 0x00DF2F3C File Offset: 0x00DF113C
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

		// Token: 0x06031E16 RID: 204310 RVA: 0x00DF2FC0 File Offset: 0x00DF11C0
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

		// Token: 0x06031E17 RID: 204311 RVA: 0x00DF2FF0 File Offset: 0x00DF11F0
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x06031E18 RID: 204312 RVA: 0x00DF3000 File Offset: 0x00DF1200
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

		// Token: 0x06031E19 RID: 204313 RVA: 0x00DF309A File Offset: 0x00DF129A
		public bool IsValid()
		{
			BattleUiRoleData roleData = this.RoleData;
			return ((roleData != null) ? roleData.EntityHandle : null) != null;
		}

		// Token: 0x06031E1A RID: 204314 RVA: 0x00DF30B1 File Offset: 0x00DF12B1
		public int? GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x06031E1B RID: 204315 RVA: 0x00DF30BC File Offset: 0x00DF12BC
		private void AddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.BattleUiHealthChanged, new Action<int>(this.OnHealthChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiShieldChanged, new Action<int>(this.OnShieldChanged));
			EventSystem.Instance.Add<int>(EEventName.BattleUiLevelChanged, new Action<int>(this.OnLevelChanged));
			EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06031E1C RID: 204316 RVA: 0x00DF3158 File Offset: 0x00DF1358
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiHealthChanged, new Action<int>(this.OnHealthChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiShieldChanged, new Action<int>(this.OnShieldChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiLevelChanged, new Action<int>(this.OnLevelChanged));
			EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnRefreshText));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		}

		// Token: 0x06031E1D RID: 204317 RVA: 0x00DF31F1 File Offset: 0x00DF13F1
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

		// Token: 0x06031E1E RID: 204318 RVA: 0x00DF320B File Offset: 0x00DF140B
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

		// Token: 0x06031E1F RID: 204319 RVA: 0x00DF3248 File Offset: 0x00DF1448
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

		// Token: 0x06031E20 RID: 204320 RVA: 0x00DF32C4 File Offset: 0x00DF14C4
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

		// Token: 0x06031E21 RID: 204321 RVA: 0x00DF3302 File Offset: 0x00DF1502
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

		// Token: 0x06031E22 RID: 204322 RVA: 0x00DF3330 File Offset: 0x00DF1530
		private void OnShieldChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshHpAndShield(true);
		}

		// Token: 0x06031E23 RID: 204323 RVA: 0x00DF3360 File Offset: 0x00DF1560
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

		// Token: 0x06031E24 RID: 204324 RVA: 0x00DF3398 File Offset: 0x00DF1598
		private void OnLevelChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshLevel();
		}

		// Token: 0x06031E25 RID: 204325 RVA: 0x00DF33C7 File Offset: 0x00DF15C7
		[NullableContext(1)]
		private void OnRefreshText(string s, string s1)
		{
			this.RefreshLevel();
			this.RefreshHpAndShield(false);
		}

		// Token: 0x06031E26 RID: 204326 RVA: 0x00DF33D6 File Offset: 0x00DF15D6
		private void OnMotorcycleStateChanged(bool b)
		{
			this.RefreshMotorcycleShield();
		}

		// Token: 0x06031E27 RID: 204327 RVA: 0x00DF33E0 File Offset: 0x00DF15E0
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

		// Token: 0x06031E28 RID: 204328 RVA: 0x00DF34D8 File Offset: 0x00DF16D8
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

		// Token: 0x06031E29 RID: 204329 RVA: 0x00DF352C File Offset: 0x00DF172C
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(4);
			sprite.SetFillAmount(percent);
			sprite.SetUIActive(true);
		}

		// Token: 0x06031E2A RID: 204330 RVA: 0x00DF3542 File Offset: 0x00DF1742
		private void StopBarLerpAnimation()
		{
			base.GetSprite(4).SetUIActive(false);
			this.TargetBarPercent = 0f;
			this.SourceBarPercent = 0f;
			this.AnimTime = -1f;
		}

		// Token: 0x06031E2B RID: 204331 RVA: 0x00DF3574 File Offset: 0x00DF1774
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

		// Token: 0x06031E2C RID: 204332 RVA: 0x00DF35B8 File Offset: 0x00DF17B8
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

		// Token: 0x06031E2D RID: 204333 RVA: 0x00DF35FC File Offset: 0x00DF17FC
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

		// Token: 0x06031E2E RID: 204334 RVA: 0x00DF3678 File Offset: 0x00DF1878
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

		// Token: 0x06031E2F RID: 204335 RVA: 0x00DF3720 File Offset: 0x00DF1920
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

		// Token: 0x06031E30 RID: 204336 RVA: 0x00DF37AE File Offset: 0x00DF19AE
		private void ExistShieldChanged()
		{
			this.SetShieldBarPercent(this.ShieldPercent);
		}

		// Token: 0x0401A648 RID: 108104
		private const float LOW_HP_PERCENT = 0.2f;

		// Token: 0x0401A649 RID: 108105
		private BattleUiRoleData RoleData;

		// Token: 0x0401A64A RID: 108106
		private int? EntityId;

		// Token: 0x0401A64B RID: 108107
		private BaseAttributeComponent AttributeComponent;

		// Token: 0x0401A64C RID: 108108
		private CharacterShieldComponent ShieldComponent;

		// Token: 0x0401A64D RID: 108109
		private TimerHandle DelayTimerId;

		// Token: 0x0401A64E RID: 108110
		private float CurrentBarPercent = -1f;

		// Token: 0x0401A64F RID: 108111
		private float TargetBarPercent;

		// Token: 0x0401A650 RID: 108112
		private float SourceBarPercent;

		// Token: 0x0401A651 RID: 108113
		private float AnimTime = -1f;

		// Token: 0x0401A652 RID: 108114
		private int BufferAnimLengthInternal;

		// Token: 0x0401A653 RID: 108115
		private ULGUICanvas HpMask;

		// Token: 0x0401A654 RID: 108116
		private FMargin UeMargin;

		// Token: 0x0401A655 RID: 108117
		private float HpTextWidth;

		// Token: 0x0401A656 RID: 108118
		private LevelSequencePlayer ShieldSequence;

		// Token: 0x0401A657 RID: 108119
		private bool ShieldLastState;

		// Token: 0x0401A658 RID: 108120
		private float ShieldPercent;

		// Token: 0x0401A659 RID: 108121
		private MotorcycleShieldItem MotorcycleShieldItem;

		// Token: 0x0200AA99 RID: 43673
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04034B8B RID: 215947
			RoleHpBar,
			// Token: 0x04034B8C RID: 215948
			RoleHpNumber,
			// Token: 0x04034B8D RID: 215949
			RoleLvNumber,
			// Token: 0x04034B8E RID: 215950
			HpLowBarSprite,
			// Token: 0x04034B8F RID: 215951
			HpBufferSprite,
			// Token: 0x04034B90 RID: 215952
			ShieldFrameSprite,
			// Token: 0x04034B91 RID: 215953
			Niagara,
			// Token: 0x04034B92 RID: 215954
			RoleHpNumber2,
			// Token: 0x04034B93 RID: 215955
			RoleHpMask,
			// Token: 0x04034B94 RID: 215956
			HpAdjustNode,
			// Token: 0x04034B95 RID: 215957
			HpLockSprite,
			// Token: 0x04034B96 RID: 215958
			HpAdditionNode
		}
	}
}
