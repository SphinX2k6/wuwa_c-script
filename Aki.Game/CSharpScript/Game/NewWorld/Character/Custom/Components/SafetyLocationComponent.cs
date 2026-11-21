using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.Character.Custom.Components
{
	// Token: 0x0200630C RID: 25356
	[NullableContext(2)]
	[Nullable(0)]
	public class SafetyLocationComponent : EntityComponent
	{
		// Token: 0x0603D5F1 RID: 251377 RVA: 0x011BEAF4 File Offset: 0x011BCCF4
		protected override bool OnInitData(IEntityArgs args = null)
		{
			LocationSafetyComponent compConfig = args.GetP1<CreateEntityData>().GetParam<SafetyLocationComponent>() as LocationSafetyComponent;
			this.CompConfig = compConfig;
			return true;
		}

		// Token: 0x0603D5F2 RID: 251378 RVA: 0x011BEB1A File Offset: 0x011BCD1A
		protected override bool OnStart()
		{
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerOverlapCallback));
			return true;
		}

		// Token: 0x0603D5F3 RID: 251379 RVA: 0x011BEB3F File Offset: 0x011BCD3F
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnMyPlayerOverlapCallback));
			if (this.IsMyPlayerInRange)
			{
				this.OnMyPlayerOverlapCallback(false);
			}
			return true;
		}

		// Token: 0x0603D5F4 RID: 251380 RVA: 0x011BEB74 File Offset: 0x011BCD74
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

		// Token: 0x0603D5F5 RID: 251381 RVA: 0x011BEBCC File Offset: 0x011BCDCC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SafetyLocationComponent safetyLocationComponent = (SafetyLocationComponent)componentTemplate;
			if (safetyLocationComponent.CompConfig == null)
			{
				this.CompConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CompConfig), "CompConfig"))
			{
				return false;
			}
			this.IsMyPlayerInRange = safetyLocationComponent.IsMyPlayerInRange;
			return true;
		}

		// Token: 0x17007447 RID: 29767
		// (get) Token: 0x0603D5F6 RID: 251382 RVA: 0x011BEC23 File Offset: 0x011BCE23
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007448 RID: 29768
		// (get) Token: 0x0603D5F7 RID: 251383 RVA: 0x011BEC26 File Offset: 0x011BCE26
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040208D2 RID: 133330
		private LocationSafetyComponent CompConfig;

		// Token: 0x040208D3 RID: 133331
		private bool IsMyPlayerInRange;
	}
}
