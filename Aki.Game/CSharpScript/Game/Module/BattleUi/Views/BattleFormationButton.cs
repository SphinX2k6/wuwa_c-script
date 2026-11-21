using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CB7 RID: 19639
	public class BattleFormationButton : BattleEntranceButton
	{
		// Token: 0x0603117A RID: 201082 RVA: 0x00DB51C7 File Offset: 0x00DB33C7
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0603117B RID: 201083 RVA: 0x00DB51EA File Offset: 0x00DB33EA
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnEnterVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnEnterVehicleRideSharing));
			EventSystem.Instance.Add(EEventName.OnLeaveVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnLeaveVehicleRideSharing));
		}

		// Token: 0x0603117C RID: 201084 RVA: 0x00DB5224 File Offset: 0x00DB3424
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnEnterVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnEnterVehicleRideSharing));
			EventSystem.Instance.Remove(EEventName.OnLeaveVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnLeaveVehicleRideSharing));
		}

		// Token: 0x0603117D RID: 201085 RVA: 0x00DB525E File Offset: 0x00DB345E
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.AddEvents();
		}

		// Token: 0x0603117E RID: 201086 RVA: 0x00DB526D File Offset: 0x00DB346D
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603117F RID: 201087 RVA: 0x00DB527B File Offset: 0x00DB347B
		[NullableContext(1)]
		private void OnEnterVehicleRideSharing(VehiclePassengerInfo info)
		{
		}

		// Token: 0x06031180 RID: 201088 RVA: 0x00DB527D File Offset: 0x00DB347D
		[NullableContext(1)]
		private void OnLeaveVehicleRideSharing(VehiclePassengerInfo info)
		{
		}

		// Token: 0x0200A92E RID: 43310
		private enum EChildType
		{
			// Token: 0x04034450 RID: 214096
			Button,
			// Token: 0x04034451 RID: 214097
			RedDotItem,
			// Token: 0x04034452 RID: 214098
			IconSprite
		}
	}
}
