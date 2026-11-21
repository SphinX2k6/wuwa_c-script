using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics
{
	// Token: 0x0200424A RID: 16970
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDamageStatisticsItem : UiPanelBase
	{
		// Token: 0x0602AEF4 RID: 175860 RVA: 0x00C14A20 File Offset: 0x00C12C20
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
		}

		// Token: 0x0602AEF5 RID: 175861 RVA: 0x00C14ABC File Offset: 0x00C12CBC
		protected override void OnStart()
		{
			this.ValueSprite = base.GetSprite(4);
			this.ValueTween = new LguiFloatTween();
			this.ValueTween.BindUpdateTween(new Action<float>(this.UpdateSlider));
			this.OffsetTween = new LguiIntTween();
			this.OffsetTween.BindUpdateTween(new Action<int>(this.UpdateOffsetY));
		}

		// Token: 0x0602AEF6 RID: 175862 RVA: 0x00C14B1A File Offset: 0x00C12D1A
		protected override void OnDestroy()
		{
			this.ValueTween.Destroy();
			this.OffsetTween.Destroy();
			this.RemoveEntityEvents(this.Entity);
			this.Entity = null;
		}

		// Token: 0x0602AEF7 RID: 175863 RVA: 0x00C14B48 File Offset: 0x00C12D48
		private void RefreshIcon()
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(this.EntityId);
			base.SetTextureByPath(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardDataByEntityId.ConfigId).BvbIcon, base.GetTexture(2), null, null);
		}

		// Token: 0x0602AEF8 RID: 175864 RVA: 0x00C14B9C File Offset: 0x00C12D9C
		private void RefreshName()
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(this.EntityId);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardDataByEntityId.ConfigId);
			UUIText text = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text, phantomBattleCardConfig.Name, Array.Empty<object>());
			UUIItem uuiitem = text;
			bool isNpcCard = cardDataByEntityId.IsNpcCard;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(isNpcCard, fcolor);
		}

		// Token: 0x0602AEF9 RID: 175865 RVA: 0x00C14C0C File Offset: 0x00C12E0C
		private void RefreshBg()
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(this.EntityId);
			base.GetItem(0).SetUIActive(!cardDataByEntityId.IsNpcCard);
			base.GetItem(1).SetUIActive(cardDataByEntityId.IsNpcCard);
			UUIItem valueSprite = this.ValueSprite;
			bool isNpcCard = cardDataByEntityId.IsNpcCard;
			FColor? fcolor = new FColor?(this.ValueSprite.changeColor);
			valueSprite.SetChangeColor(isNpcCard, fcolor);
		}

		// Token: 0x0602AEFA RID: 175866 RVA: 0x00C14C7C File Offset: 0x00C12E7C
		public void Init(long entityId, UCurveFloat lerpCurve, float offsetY)
		{
			this.RemoveEntityEvents(this.Entity);
			this.LerpCurve = lerpCurve;
			this.EntityId = entityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			this.Entity = ((entity != null) ? entity.Entity : null);
			Entity entity2 = this.Entity;
			this.AttributeComp = ((entity2 != null) ? entity2.GetComponent<BaseAttributeComponent>() : null);
			this.AddEntityEvents(this.Entity);
			this.GetOriginalItem().SetAnchorOffsetY(offsetY);
			this.RefreshIcon();
			this.RefreshName();
			this.RefreshBg();
		}

		// Token: 0x0602AEFB RID: 175867 RVA: 0x00C14D04 File Offset: 0x00C12F04
		public void RefreshOffsetY(float offsetY)
		{
			float anchorOffsetY = this.GetOriginalItem().GetAnchorOffsetY();
			this.OffsetTween.PlayTween((int)anchorOffsetY, (int)offsetY, 0.3f, null);
		}

		// Token: 0x0602AEFC RID: 175868 RVA: 0x00C14D34 File Offset: 0x00C12F34
		public void RefreshCount()
		{
			int num = this.GetAllCount();
			if (num == 0)
			{
				this.ValueSprite.SetFillAmount(0f);
				base.GetText(5).SetText("0", true);
				return;
			}
			int num2 = this.GetCount(this.EntityId);
			float fillAmount = this.ValueSprite.GetFillAmount();
			float end = (float)num2 / (float)num;
			this.ValueTween.PlayTween(fillAmount, end, 0.3f, null);
			base.GetText(5).SetText(num2.ToString(), true);
		}

		// Token: 0x0602AEFD RID: 175869 RVA: 0x00C14DC0 File Offset: 0x00C12FC0
		private void AddEntityEvents(Entity entity)
		{
			if (entity == null)
			{
				return;
			}
			if (!EventSystem.Instance.HasWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityInjury)))
			{
				EventSystem.Instance.AddWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityInjury));
			}
			if (!EventSystem.Instance.HasWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityDamage)))
			{
				EventSystem.Instance.AddWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityDamage));
			}
		}

		// Token: 0x0602AEFE RID: 175870 RVA: 0x00C14E3C File Offset: 0x00C1303C
		private void RemoveEntityEvents(Entity entity)
		{
			if (entity == null)
			{
				return;
			}
			if (EventSystem.Instance.HasWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityInjury)))
			{
				EventSystem.Instance.RemoveWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityInjury));
			}
			if (EventSystem.Instance.HasWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityDamage)))
			{
				EventSystem.Instance.RemoveWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityDamage));
			}
		}

		// Token: 0x0602AEFF RID: 175871 RVA: 0x00C14EB8 File Offset: 0x00C130B8
		private void OnEntityInjury(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble _)
		{
			int arg = (int)this.AttributeComp.GetCurrentValue(EAttributeType.LifeMax);
			Action<long, int, int, EDamageStatisticsRankType> notifyValueChange = this.NotifyValueChange;
			if (notifyValueChange == null)
			{
				return;
			}
			notifyValueChange(this.EntityId, (int)Math.Abs(damageResult.Damage), arg, EDamageStatisticsRankType.Injury);
		}

		// Token: 0x0602AF00 RID: 175872 RVA: 0x00C14EF8 File Offset: 0x00C130F8
		private void OnEntityDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble _)
		{
			if (damageResult.DamageData.Id == 700020001L)
			{
				return;
			}
			if (damageResult.DamageData.CalculateType != 0)
			{
				return;
			}
			int arg = (int)victim.GetComponent<BaseAttributeComponent>().GetCurrentValue(EAttributeType.LifeMax);
			Action<long, int, int, EDamageStatisticsRankType> notifyValueChange = this.NotifyValueChange;
			if (notifyValueChange == null)
			{
				return;
			}
			notifyValueChange(this.EntityId, (int)Math.Abs(damageResult.Damage), arg, EDamageStatisticsRankType.Damage);
		}

		// Token: 0x0602AF01 RID: 175873 RVA: 0x00C14F5C File Offset: 0x00C1315C
		private void UpdateSlider(float value)
		{
			this.ValueSprite.SetFillAmount(value);
		}

		// Token: 0x0602AF02 RID: 175874 RVA: 0x00C14F6A File Offset: 0x00C1316A
		private void UpdateOffsetY(int value)
		{
			this.GetOriginalItem().SetAnchorOffsetY((float)value);
		}

		// Token: 0x040173AF RID: 95151
		private const int BURN_BLOOD_BUFF_RESULT_ID = 700020001;

		// Token: 0x040173B0 RID: 95152
		protected LguiFloatTween ValueTween;

		// Token: 0x040173B1 RID: 95153
		protected LguiIntTween OffsetTween;

		// Token: 0x040173B2 RID: 95154
		protected long EntityId;

		// Token: 0x040173B3 RID: 95155
		protected Entity Entity;

		// Token: 0x040173B4 RID: 95156
		protected BaseAttributeComponent AttributeComp;

		// Token: 0x040173B5 RID: 95157
		protected UUISprite ValueSprite;

		// Token: 0x040173B6 RID: 95158
		protected UCurveFloat LerpCurve;

		// Token: 0x040173B7 RID: 95159
		public Func<int> GetAllCount;

		// Token: 0x040173B8 RID: 95160
		public Func<long, int> GetCount;

		// Token: 0x040173B9 RID: 95161
		public Action<long, int, int, EDamageStatisticsRankType> NotifyValueChange;

		// Token: 0x02009EB1 RID: 40625
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031531 RID: 202033
			public const int OwnBg = 0;

			// Token: 0x04031532 RID: 202034
			public const int OpponentBg = 1;

			// Token: 0x04031533 RID: 202035
			public const int Icon = 2;

			// Token: 0x04031534 RID: 202036
			public const int Name = 3;

			// Token: 0x04031535 RID: 202037
			public const int ValueSprite = 4;

			// Token: 0x04031536 RID: 202038
			public const int Count = 5;
		}
	}
}
