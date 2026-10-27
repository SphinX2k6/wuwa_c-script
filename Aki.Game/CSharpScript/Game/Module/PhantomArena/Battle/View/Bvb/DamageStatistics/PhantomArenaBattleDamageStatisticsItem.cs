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
	// Token: 0x0200527A RID: 21114
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDamageStatisticsItem : UiPanelBase
	{
		// Token: 0x06035FF9 RID: 221177 RVA: 0x00CC7320 File Offset: 0x00CC5520
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

		// Token: 0x06035FFA RID: 221178 RVA: 0x00CC73BC File Offset: 0x00CC55BC
		protected override void OnStart()
		{
			this.ValueSprite = base.GetSprite(4);
			this.ValueTween = new LguiFloatTween();
			this.ValueTween.BindUpdateTween(new Action<float>(this.UpdateSlider));
			this.OffsetTween = new LguiIntTween();
			this.OffsetTween.BindUpdateTween(new Action<int>(this.UpdateOffsetY));
		}

		// Token: 0x06035FFB RID: 221179 RVA: 0x00CC741A File Offset: 0x00CC561A
		protected override void OnDestroy()
		{
			this.ValueTween.Destroy();
			this.OffsetTween.Destroy();
			this.RemoveEntityEvents(this.Entity);
			this.Entity = null;
		}

		// Token: 0x06035FFC RID: 221180 RVA: 0x00CC7448 File Offset: 0x00CC5648
		private void RefreshIcon()
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(this.EntityId);
			base.SetTextureByPath(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardDataByEntityId.ConfigId).BvbIcon, base.GetTexture(2), null, null);
		}

		// Token: 0x06035FFD RID: 221181 RVA: 0x00CC749C File Offset: 0x00CC569C
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

		// Token: 0x06035FFE RID: 221182 RVA: 0x00CC750C File Offset: 0x00CC570C
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

		// Token: 0x06035FFF RID: 221183 RVA: 0x00CC757C File Offset: 0x00CC577C
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

		// Token: 0x06036000 RID: 221184 RVA: 0x00CC7604 File Offset: 0x00CC5804
		public void RefreshOffsetY(float offsetY)
		{
			float anchorOffsetY = this.GetOriginalItem().GetAnchorOffsetY();
			this.OffsetTween.PlayTween((int)anchorOffsetY, (int)offsetY, 0.3f, null);
		}

		// Token: 0x06036001 RID: 221185 RVA: 0x00CC7634 File Offset: 0x00CC5834
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

		// Token: 0x06036002 RID: 221186 RVA: 0x00CC76C0 File Offset: 0x00CC58C0
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

		// Token: 0x06036003 RID: 221187 RVA: 0x00CC773C File Offset: 0x00CC593C
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

		// Token: 0x06036004 RID: 221188 RVA: 0x00CC77B8 File Offset: 0x00CC59B8
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

		// Token: 0x06036005 RID: 221189 RVA: 0x00CC77F8 File Offset: 0x00CC59F8
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

		// Token: 0x06036006 RID: 221190 RVA: 0x00CC785C File Offset: 0x00CC5A5C
		private void UpdateSlider(float value)
		{
			this.ValueSprite.SetFillAmount(value);
		}

		// Token: 0x06036007 RID: 221191 RVA: 0x00CC786A File Offset: 0x00CC5A6A
		private void UpdateOffsetY(int value)
		{
			this.GetOriginalItem().SetAnchorOffsetY((float)value);
		}

		// Token: 0x0401C97A RID: 117114
		private const int BURN_BLOOD_BUFF_RESULT_ID = 700020001;

		// Token: 0x0401C97B RID: 117115
		protected LguiFloatTween ValueTween;

		// Token: 0x0401C97C RID: 117116
		protected LguiIntTween OffsetTween;

		// Token: 0x0401C97D RID: 117117
		protected long EntityId;

		// Token: 0x0401C97E RID: 117118
		protected Entity Entity;

		// Token: 0x0401C97F RID: 117119
		protected BaseAttributeComponent AttributeComp;

		// Token: 0x0401C980 RID: 117120
		protected UUISprite ValueSprite;

		// Token: 0x0401C981 RID: 117121
		protected UCurveFloat LerpCurve;

		// Token: 0x0401C982 RID: 117122
		public Func<int> GetAllCount;

		// Token: 0x0401C983 RID: 117123
		public Func<long, int> GetCount;

		// Token: 0x0401C984 RID: 117124
		public Action<long, int, int, EDamageStatisticsRankType> NotifyValueChange;

		// Token: 0x0200B479 RID: 46201
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036ADE RID: 223966
			public const int OwnBg = 0;

			// Token: 0x04036ADF RID: 223967
			public const int OpponentBg = 1;

			// Token: 0x04036AE0 RID: 223968
			public const int Icon = 2;

			// Token: 0x04036AE1 RID: 223969
			public const int Name = 3;

			// Token: 0x04036AE2 RID: 223970
			public const int ValueSprite = 4;

			// Token: 0x04036AE3 RID: 223971
			public const int Count = 5;
		}
	}
}
