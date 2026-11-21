using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061AA RID: 25002
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleStrengthComponent : EntityComponent
	{
		// Token: 0x0603C042 RID: 245826 RVA: 0x0110F23C File Offset: 0x0110D43C
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

		// Token: 0x0603C043 RID: 245827 RVA: 0x0110F2A7 File Offset: 0x0110D4A7
		private void RegisterStrengthListener()
		{
			if (this.IsListeningStrength)
			{
				return;
			}
			this.IsListeningStrength = true;
			FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged), null);
		}

		// Token: 0x0603C044 RID: 245828 RVA: 0x0110F2D2 File Offset: 0x0110D4D2
		private void UnregisterStrengthListener()
		{
			if (!this.IsListeningStrength)
			{
				return;
			}
			this.IsListeningStrength = false;
			FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.MotorcycleStrength, new TValueListener(this.OnStrengthChanged));
		}

		// Token: 0x0603C045 RID: 245829 RVA: 0x0110F2FC File Offset: 0x0110D4FC
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

		// Token: 0x0603C046 RID: 245830 RVA: 0x0110F328 File Offset: 0x0110D528
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

		// Token: 0x0603C047 RID: 245831 RVA: 0x0110F3D0 File Offset: 0x0110D5D0
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

		// Token: 0x0603C048 RID: 245832 RVA: 0x0110F420 File Offset: 0x0110D620
		protected override bool OnEnd()
		{
			this.UnregisterStrengthListener();
			EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
			return true;
		}

		// Token: 0x0603C049 RID: 245833 RVA: 0x0110F44C File Offset: 0x0110D64C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleStrengthComponent motorcycleStrengthComponent = (MotorcycleStrengthComponent)componentTemplate;
			if (motorcycleStrengthComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			this.BannedSprint = motorcycleStrengthComponent.BannedSprint;
			this.IsListeningStrength = motorcycleStrengthComponent.IsListeningStrength;
			return true;
		}

		// Token: 0x1700712E RID: 28974
		// (get) Token: 0x0603C04A RID: 245834 RVA: 0x0110F4AF File Offset: 0x0110D6AF
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700712F RID: 28975
		// (get) Token: 0x0603C04B RID: 245835 RVA: 0x0110F4B2 File Offset: 0x0110D6B2
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FB81 RID: 129921
		private const float BANNED_SPRINT_THRESHOLD_MIN = 1f;

		// Token: 0x0401FB82 RID: 129922
		private const float BANNED_SPRINT_THRESHOLD_MAX = 20f;

		// Token: 0x0401FB83 RID: 129923
		protected BaseTagComponent TagComp;

		// Token: 0x0401FB84 RID: 129924
		private bool BannedSprint;

		// Token: 0x0401FB85 RID: 129925
		private bool IsListeningStrength;
	}
}
