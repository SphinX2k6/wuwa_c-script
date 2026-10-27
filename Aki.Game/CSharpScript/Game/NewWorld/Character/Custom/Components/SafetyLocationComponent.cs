using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.Character.Custom.Components
{
	// Token: 0x020070AD RID: 28845
	[NullableContext(2)]
	[Nullable(0)]
	public class SafetyLocationComponent : EntityComponent
	{
		// Token: 0x0604654B RID: 288075 RVA: 0x011A11E0 File Offset: 0x0119F3E0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			LocationSafetyComponent compConfig = args.GetP1<CreateEntityData>().GetParam<SafetyLocationComponent>() as LocationSafetyComponent;
			this.CompConfig = compConfig;
			return true;
		}

		// Token: 0x0604654C RID: 288076 RVA: 0x011A1206 File Offset: 0x0119F406
		protected override bool OnStart()
		{
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerOverlapCallback));
			return true;
		}

		// Token: 0x0604654D RID: 288077 RVA: 0x011A122B File Offset: 0x0119F42B
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerOverlapCallback));
			if (this.IsMyPlayerInRange)
			{
				this.OnMyPlayerOverlapCallback(false);
			}
			return true;
		}

		// Token: 0x0604654E RID: 288078 RVA: 0x011A1260 File Offset: 0x0119F460
		private void OnMyPlayerOverlapCallback(bool isEnter)
		{
			this.IsMyPlayerInRange = isEnter;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			RoleLocationSafetyComponent roleLocationSafetyComponent;
			if (baseCharacter == null)
			{
				roleLocationSafetyComponent = null;
			}
			else
			{
				Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
				roleLocationSafetyComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<RoleLocationSafetyComponent>() : null);
			}
			RoleLocationSafetyComponent roleLocationSafetyComponent2 = roleLocationSafetyComponent;
			if (roleLocationSafetyComponent2 == null)
			{
				return;
			}
			if (isEnter)
			{
				roleLocationSafetyComponent2.AddSafetyLocationConfig(base.Entity, this.CompConfig);
				return;
			}
			roleLocationSafetyComponent2.RemoveSafetyLocationConfig(base.Entity);
		}

		// Token: 0x0604654F RID: 288079 RVA: 0x011A12B8 File Offset: 0x0119F4B8
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SafetyLocationComponent safetyLocationComponent = (SafetyLocationComponent)componentTemplate;
			if (base.CanResetComponentProperty("CompConfig"))
			{
				if (safetyLocationComponent.CompConfig == null)
				{
					this.CompConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LocationSafetyComponent>(this.CompConfig), "CompConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsMyPlayerInRange"))
			{
				this.IsMyPlayerInRange = safetyLocationComponent.IsMyPlayerInRange;
			}
			return true;
		}

		// Token: 0x04024DAB RID: 150955
		private LocationSafetyComponent CompConfig;

		// Token: 0x04024DAC RID: 150956
		private bool IsMyPlayerInRange;
	}
}
