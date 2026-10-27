using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x02007029 RID: 28713
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleStrengthComponent : EntityComponent
	{
		// Token: 0x06045E6B RID: 286315 RVA: 0x011652BC File Offset: 0x011634BC
		private void SetBannedSprint(bool banned)
		{
			if (this.BannedSprint == banned)
			{
				return;
			}
			this.BannedSprint = banned;
			if (banned)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null)
				{
					return;
				}
				tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用氮气.氮气耗尽"]));
				return;
			}
			else
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 == null)
				{
					return;
				}
				tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用氮气.氮气耗尽"]));
				return;
			}
		}

		// Token: 0x06045E6C RID: 286316 RVA: 0x01165327 File Offset: 0x01163527
		private void RegisterStrengthListener()
		{
			if (this.IsListeningStrength)
			{
				return;
			}
			this.IsListeningStrength = true;
			FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged), null);
		}

		// Token: 0x06045E6D RID: 286317 RVA: 0x01165352 File Offset: 0x01163552
		private void UnregisterStrengthListener()
		{
			if (!this.IsListeningStrength)
			{
				return;
			}
			this.IsListeningStrength = false;
			FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged));
		}

		// Token: 0x06045E6E RID: 286318 RVA: 0x0116537C File Offset: 0x0116357C
		private void OnStrengthChanged(EFormationAttributeId attributeId, float newValue, float oldValue)
		{
			if (this.BannedSprint)
			{
				if (newValue > 20f)
				{
					this.SetBannedSprint(false);
					return;
				}
			}
			else if (newValue < 1f)
			{
				this.SetBannedSprint(true);
			}
		}

		// Token: 0x06045E6F RID: 286319 RVA: 0x011653A8 File Offset: 0x011635A8
		private void OnVehicleDriverChange(Entity oldDriver, Entity newDriver)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
			if (newDriver != null)
			{
				int id = newDriver.Id;
				int? num2 = num;
				if (id == num2.GetValueOrDefault() & num2 != null)
				{
					this.RegisterStrengthListener();
					float value = FormationAttributeController.Instance.GetValue(EFormationAttributeId.MotorcycleStrength);
					if (value < 1f)
					{
						this.SetBannedSprint(true);
						return;
					}
					if (value > 20f)
					{
						this.SetBannedSprint(false);
						return;
					}
					return;
				}
			}
			if (oldDriver != null)
			{
				int id2 = oldDriver.Id;
				int? num2 = num;
				if (id2 == num2.GetValueOrDefault() & num2 != null)
				{
					this.UnregisterStrengthListener();
					this.SetBannedSprint(false);
				}
			}
		}

		// Token: 0x06045E70 RID: 286320 RVA: 0x01165450 File Offset: 0x01163650
		protected override bool OnStart()
		{
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			if (!this.TagComp)
			{
				return false;
			}
			EventSystem.Instance.AddWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
			return true;
		}

		// Token: 0x06045E71 RID: 286321 RVA: 0x011654A0 File Offset: 0x011636A0
		protected override bool OnEnd()
		{
			this.UnregisterStrengthListener();
			EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
			return true;
		}

		// Token: 0x06045E72 RID: 286322 RVA: 0x011654CC File Offset: 0x011636CC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleStrengthComponent motorcycleStrengthComponent = (MotorcycleStrengthComponent)componentTemplate;
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (motorcycleStrengthComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BannedSprint"))
			{
				this.BannedSprint = motorcycleStrengthComponent.BannedSprint;
			}
			if (base.CanResetComponentProperty("IsListeningStrength"))
			{
				this.IsListeningStrength = motorcycleStrengthComponent.IsListeningStrength;
			}
			return true;
		}

		// Token: 0x040248CB RID: 149707
		private const float BANNED_SPRINT_THRESHOLD_MIN = 1f;

		// Token: 0x040248CC RID: 149708
		private const float BANNED_SPRINT_THRESHOLD_MAX = 20f;

		// Token: 0x040248CD RID: 149709
		protected BaseTagComponent TagComp;

		// Token: 0x040248CE RID: 149710
		private bool BannedSprint;

		// Token: 0x040248CF RID: 149711
		private bool IsListeningStrength;
	}
}
