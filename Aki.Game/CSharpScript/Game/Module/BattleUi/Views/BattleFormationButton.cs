using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD5 RID: 23765
	public class BattleFormationButton : BattleEntranceButton
	{
		// Token: 0x0603C224 RID: 246308 RVA: 0x00E64BEB File Offset: 0x00E62DEB
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUISprite)));
		}

		// Token: 0x0603C225 RID: 246309 RVA: 0x00E64C0E File Offset: 0x00E62E0E
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnEnterVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnEnterVehicleRideSharing));
			EventSystem.Instance.Add(EEventName.OnLeaveVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnLeaveVehicleRideSharing));
		}

		// Token: 0x0603C226 RID: 246310 RVA: 0x00E64C48 File Offset: 0x00E62E48
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnEnterVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnEnterVehicleRideSharing));
			EventSystem.Instance.Remove(EEventName.OnLeaveVehicleRideSharing, new Action<VehiclePassengerInfo>(this.OnLeaveVehicleRideSharing));
		}

		// Token: 0x0603C227 RID: 246311 RVA: 0x00E64C82 File Offset: 0x00E62E82
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.AddEvents();
		}

		// Token: 0x0603C228 RID: 246312 RVA: 0x00E64C91 File Offset: 0x00E62E91
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603C229 RID: 246313 RVA: 0x00E64C9F File Offset: 0x00E62E9F
		[NullableContext(1)]
		private void OnEnterVehicleRideSharing(VehiclePassengerInfo info)
		{
		}

		// Token: 0x0603C22A RID: 246314 RVA: 0x00E64CA1 File Offset: 0x00E62EA1
		[NullableContext(1)]
		private void OnLeaveVehicleRideSharing(VehiclePassengerInfo info)
		{
		}

		// Token: 0x0200BF28 RID: 48936
		private enum EChildType
		{
			// Token: 0x04039A8E RID: 236174
			Button,
			// Token: 0x04039A8F RID: 236175
			RedDotItem,
			// Token: 0x04039A90 RID: 236176
			IconSprite
		}
	}
}
