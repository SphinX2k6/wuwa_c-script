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
	// Token: 0x02004CFC RID: 19708
	[NullableContext(2)]
	[Nullable(0)]
	public class ConcertoResponseItem : BattleVisibleChildView
	{
		// Token: 0x060315D6 RID: 202198 RVA: 0x00DCBBA4 File Offset: 0x00DC9DA4
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

		// Token: 0x060315D7 RID: 202199 RVA: 0x00DCBC0D File Offset: 0x00DC9E0D
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.Ignore);
			this.AddEvents();
		}

		// Token: 0x060315D8 RID: 202200 RVA: 0x00DCBC24 File Offset: 0x00DC9E24
		protected override void OnBeforeDestroy()
		{
			this.Refresh(null);
		}

		// Token: 0x060315D9 RID: 202201 RVA: 0x00DCBC2D File Offset: 0x00DC9E2D
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

		// Token: 0x060315DA RID: 202202 RVA: 0x00DCBC64 File Offset: 0x00DC9E64
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

		// Token: 0x060315DB RID: 202203 RVA: 0x00DCBD62 File Offset: 0x00DC9F62
		public int? GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x060315DC RID: 202204 RVA: 0x00DCBD6C File Offset: 0x00DC9F6C
		private void AddEvents()
		{
			EventSystem.Instance.Add<int>(EEventName.BattleUiElementEnergyChanged, new Action<int>(this.OnElementEnergyChanged));
			EventSystem.Instance.Add<int, int, bool>(EEventName.BattleUiElementHideTagChanged, new Action<int, int, bool>(this.OnHideTagChanged));
			EventSystem.Instance.Add<ESkillButtonExtraEffect, float>(EEventName.BattleUiConcertoExtraEffectRefresh, new Action<ESkillButtonExtraEffect, float>(this.OnExtraEffectRefresh));
		}

		// Token: 0x060315DD RID: 202205 RVA: 0x00DCBDD0 File Offset: 0x00DC9FD0
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiElementEnergyChanged, new Action<int>(this.OnElementEnergyChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiElementHideTagChanged, new Action<int, int, bool>(this.OnHideTagChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiConcertoExtraEffectRefresh, new Action<ESkillButtonExtraEffect, float>(this.OnExtraEffectRefresh));
		}

		// Token: 0x060315DE RID: 202206 RVA: 0x00DCBE34 File Offset: 0x00DCA034
		private void OnElementEnergyChanged(int entityId)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.UpdateElementBar();
		}

		// Token: 0x060315DF RID: 202207 RVA: 0x00DCBE64 File Offset: 0x00DCA064
		private void OnHideTagChanged(int entityId, int tagId, bool tagExist)
		{
			int? entityId2 = this.EntityId;
			if (!(entityId == entityId2.GetValueOrDefault() & entityId2 != null))
			{
				return;
			}
			this.RefreshVisible();
		}

		// Token: 0x060315E0 RID: 202208 RVA: 0x00DCBE94 File Offset: 0x00DCA094
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

		// Token: 0x060315E1 RID: 202209 RVA: 0x00DCBEFB File Offset: 0x00DCA0FB
		private void OnExtraEffectRefresh(ESkillButtonExtraEffect effectType, float duration)
		{
			this.RefreshExtraEffect(effectType, duration);
		}

		// Token: 0x060315E2 RID: 202210 RVA: 0x00DCBF08 File Offset: 0x00DCA108
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

		// Token: 0x060315E3 RID: 202211 RVA: 0x00DCBFC4 File Offset: 0x00DCA1C4
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

		// Token: 0x060315E4 RID: 202212 RVA: 0x00DCC05D File Offset: 0x00DCA25D
		private void UpdateElementBar()
		{
			base.GetSprite(0).SetFillAmount(this.GetElementPercent());
		}

		// Token: 0x060315E5 RID: 202213 RVA: 0x00DCC071 File Offset: 0x00DCA271
		public float GetElementPercent()
		{
			if (this.RoleData == null)
			{
				return 0f;
			}
			return this.RoleData.GetElementAttributePercent();
		}

		// Token: 0x0401A249 RID: 107081
		private BattleUiRoleData RoleData;

		// Token: 0x0401A24A RID: 107082
		private int? EntityId;

		// Token: 0x0401A24B RID: 107083
		private BaseTagComponent GameplayTagComponent;

		// Token: 0x0401A24C RID: 107084
		private ElementInfo? ElementConfig;

		// Token: 0x0401A24D RID: 107085
		private EElementType? ElementType;

		// Token: 0x0401A24E RID: 107086
		private int HandleId;

		// Token: 0x0401A24F RID: 107087
		private BattleSkillExtraEffectItem ExtraEffectComponent;

		// Token: 0x0401A250 RID: 107088
		private ESkillButtonExtraEffect EffectType;

		// Token: 0x0200A998 RID: 43416
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034683 RID: 214659
			ResponseBarSprite,
			// Token: 0x04034684 RID: 214660
			ElementTexture
		}
	}
}
