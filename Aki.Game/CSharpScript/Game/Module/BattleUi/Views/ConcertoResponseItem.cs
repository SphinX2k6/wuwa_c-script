using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D1A RID: 23834
	[NullableContext(2)]
	[Nullable(0)]
	public class ConcertoResponseItem : BattleVisibleChildView
	{
		// Token: 0x0603C67D RID: 247421 RVA: 0x00E7B524 File Offset: 0x00E79724
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C67E RID: 247422 RVA: 0x00E7B58D File Offset: 0x00E7978D
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.Ignore);
			this.AddEvents();
		}

		// Token: 0x0603C67F RID: 247423 RVA: 0x00E7B5A4 File Offset: 0x00E797A4
		protected override void OnBeforeDestroy()
		{
			this.Refresh(null);
		}

		// Token: 0x0603C680 RID: 247424 RVA: 0x00E7B5AD File Offset: 0x00E797AD
		public override void Reset()
		{
			this.RemoveEvents();
			if (this.ExtraEffectComponent != null)
			{
				this.ExtraEffectComponent.Stop();
				this.ExtraEffectComponent.Destroy(null);
				this.ExtraEffectComponent = null;
			}
			base.Reset();
		}

		// Token: 0x0603C681 RID: 247425 RVA: 0x00E7B5E4 File Offset: 0x00E797E4
		public void Refresh(BattleUiRoleData roleData)
		{
			if (roleData == null || (roleData.RoleConfig != null && roleData.RoleConfig.GetValueOrDefault().RoleType == 2))
			{
				this.RoleData = null;
				this.EntityId = null;
				this.GameplayTagComponent = null;
				this.ElementType = null;
				this.ElementConfig = null;
				base.SetVisible(1, false);
				return;
			}
			this.RoleData = roleData;
			EntityHandle entityHandle = roleData.EntityHandle;
			this.EntityId = ((entityHandle != null) ? new int?(entityHandle.Id) : null);
			this.GameplayTagComponent = this.RoleData.GameplayTagComponent;
			this.ElementConfig = this.RoleData.ElementConfig;
			if (this.HandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
				this.HandleId = 0;
			}
			this.SetElementStyle(this.RoleData.ElementType.Value);
			this.UpdateElementBar();
			this.RefreshVisible();
		}

		// Token: 0x0603C682 RID: 247426 RVA: 0x00E7B6E2 File Offset: 0x00E798E2
		public int? GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x0603C683 RID: 247427 RVA: 0x00E7B6EC File Offset: 0x00E798EC
		private void AddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.BattleUiElementEnergyChanged, new Action<int>(this.OnElementEnergyChanged));
			EventSystem.Instance.Add<int, int, bool>(EEventName.BattleUiElementHideTagChanged, new Action<int, int, bool>(this.OnHideTagChanged));
			EventSystem.Instance.Add<ESkillButtonExtraEffect, float>(EEventName.BattleUiConcertoExtraEffectRefresh, new Action<ESkillButtonExtraEffect, float>(this.OnExtraEffectRefresh));
		}

		// Token: 0x0603C684 RID: 247428 RVA: 0x00E7B750 File Offset: 0x00E79950
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiElementEnergyChanged, new Action<int>(this.OnElementEnergyChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiElementHideTagChanged, new Action<int, int, bool>(this.OnHideTagChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiConcertoExtraEffectRefresh, new Action<ESkillButtonExtraEffect, float>(this.OnExtraEffectRefresh));
		}

		// Token: 0x0603C685 RID: 247429 RVA: 0x00E7B7B4 File Offset: 0x00E799B4
		private void OnElementEnergyChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.UpdateElementBar();
		}

		// Token: 0x0603C686 RID: 247430 RVA: 0x00E7B7E4 File Offset: 0x00E799E4
		private void OnHideTagChanged(int entityId, int tagId, bool tagExist)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshVisible();
		}

		// Token: 0x0603C687 RID: 247431 RVA: 0x00E7B814 File Offset: 0x00E79A14
		public void RefreshVisible()
		{
			if (this.RoleData == null)
			{
				return;
			}
			if (!FunctionModel.Instance.IsOpen(10036))
			{
				base.SetVisible(1, false);
				return;
			}
			foreach (int tagId in BattleUiRoleData.HideElementTagList)
			{
				if (this.GameplayTagComponent.HasTag(tagId))
				{
					base.SetVisible(1, false);
					return;
				}
			}
			base.SetVisible(1, true);
		}

		// Token: 0x0603C688 RID: 247432 RVA: 0x00E7B87B File Offset: 0x00E79A7B
		private void OnExtraEffectRefresh(ESkillButtonExtraEffect effectType, float duration)
		{
			this.RefreshExtraEffect(effectType, duration);
		}

		// Token: 0x0603C689 RID: 247433 RVA: 0x00E7B888 File Offset: 0x00E79A88
		public void RefreshExtraEffect(ESkillButtonExtraEffect effectType, float duration)
		{
			if (effectType == ESkillButtonExtraEffect.None)
			{
				if (this.ExtraEffectComponent != null)
				{
					this.ExtraEffectComponent.SetComponentActive(false);
				}
				return;
			}
			if (this.ExtraEffectComponent != null)
			{
				if (this.ExtraEffectComponent.GetEffectType() == this.EffectType)
				{
					this.ExtraEffectComponent.SetComponentActive(true);
					this.ExtraEffectComponent.Refresh(duration);
					return;
				}
				this.ExtraEffectComponent.Destroy(null);
				this.ExtraEffectComponent = null;
			}
			this.EffectType = effectType;
			if (effectType == ESkillButtonExtraEffect.Rhythm)
			{
				this.ExtraEffectComponent = new BattleSkillExtraEffectRhythmItem();
				this.ExtraEffectComponent.Init(this.RootItem);
				this.ExtraEffectComponent.SetComponentActive(true);
				this.ExtraEffectComponent.Refresh(duration);
			}
			BattleSkillExtraEffectItem extraEffectComponent = this.ExtraEffectComponent;
			if (extraEffectComponent == null)
			{
				return;
			}
			extraEffectComponent.SetEffectType(effectType);
		}

		// Token: 0x0603C68A RID: 247434 RVA: 0x00E7B944 File Offset: 0x00E79B44
		private void SetElementStyle(EElementType elementType)
		{
			EElementType? elementType2 = this.ElementType;
			if (elementType2.GetValueOrDefault() == elementType & elementType2 != null)
			{
				return;
			}
			string icon = this.ElementConfig.Value.Icon5;
			UUITexture texture = base.GetTexture(1);
			UUIItem sprite = base.GetSprite(0);
			base.SetElementIcon(icon, texture, (int)elementType, null);
			texture.SetColor(this.RoleData.ElementColor.Value);
			sprite.SetColor(this.RoleData.ElementColor.Value);
			this.ElementType = new EElementType?(elementType);
		}

		// Token: 0x0603C68B RID: 247435 RVA: 0x00E7B9DD File Offset: 0x00E79BDD
		private void UpdateElementBar()
		{
			base.GetSprite(0).SetFillAmount(this.GetElementPercent());
		}

		// Token: 0x0603C68C RID: 247436 RVA: 0x00E7B9F1 File Offset: 0x00E79BF1
		public float GetElementPercent()
		{
			if (this.RoleData == null)
			{
				return 0f;
			}
			return this.RoleData.GetElementAttributePercent();
		}

		// Token: 0x0401F790 RID: 128912
		private BattleUiRoleData RoleData;

		// Token: 0x0401F791 RID: 128913
		private int? EntityId;

		// Token: 0x0401F792 RID: 128914
		private BaseTagComponent GameplayTagComponent;

		// Token: 0x0401F793 RID: 128915
		private ElementInfo? ElementConfig;

		// Token: 0x0401F794 RID: 128916
		private EElementType? ElementType;

		// Token: 0x0401F795 RID: 128917
		private int HandleId;

		// Token: 0x0401F796 RID: 128918
		private BattleSkillExtraEffectItem ExtraEffectComponent;

		// Token: 0x0401F797 RID: 128919
		private ESkillButtonExtraEffect EffectType;

		// Token: 0x0200BF92 RID: 49042
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039CC1 RID: 236737
			ResponseBarSprite,
			// Token: 0x04039CC2 RID: 236738
			ElementTexture
		}
	}
}
