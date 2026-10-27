using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x020032E8 RID: 13032
[NullableContext(1)]
[Nullable(0)]
public class GongduolaAudioComponent : VehicleAudioComponent
{
	// Token: 0x0601C59F RID: 116127 RVA: 0x007EDEB6 File Offset: 0x007EC0B6
	protected override void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
	{
		GameAudioModel.Instance.GondolaGetOnAudioEvent(base.Entity);
		if (info.IsNpcPassenger())
		{
			GameAudioModel instance = GameAudioModel.Instance;
			if (instance != null && instance.CheckRideSharingState())
			{
				GameAudioModel instance2 = GameAudioModel.Instance;
				if (instance2 == null)
				{
					return;
				}
				instance2.PlayRideSharingPlotAudio(EGondolaVoiceTriggeredType.InviteRole);
			}
		}
	}

	// Token: 0x0601C5A0 RID: 116128 RVA: 0x007EDEF4 File Offset: 0x007EC0F4
	protected override void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
	{
		GameAudioModel.Instance.GondolaGetOnAudioEvent(base.Entity);
	}

	// Token: 0x0601C5A1 RID: 116129 RVA: 0x007EDF08 File Offset: 0x007EC108
	public override void UpdateVehicleMoveSound(float speed, AActor owner)
	{
		if (Math.Abs(this.LastSpeed - speed) < 50f && (this.LastSpeed == 0f || speed != 0f))
		{
			return;
		}
		this.LastSpeed = speed;
		AudioSystem.Instance.SetRtpcValue("vehicle_speed", MathUtils.Instance.Clamp(speed / 100f, 0f, 50f), new SetRtpcValueArgs?(new SetRtpcValueArgs
		{
			Actor = owner
		}));
		if (speed == 0f)
		{
			this.StopMoveSound(owner);
			return;
		}
		if (this.MoveSoundEventHandle == 0)
		{
			this.MoveSoundEventHandle = AudioSystem.Instance.PostEvent("play_interactive_gongduola_move", owner, null);
		}
	}

	// Token: 0x0601C5A2 RID: 116130 RVA: 0x007EDFC0 File Offset: 0x007EC1C0
	private void StopMoveSound(AActor owner)
	{
		if (this.MoveSoundEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.MoveSoundEventHandle, EAudioActionType.Stop, null);
			this.MoveSoundEventHandle = 0;
		}
	}

	// Token: 0x0601C5A3 RID: 116131 RVA: 0x007EDFF8 File Offset: 0x007EC1F8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		GongduolaAudioComponent gongduolaAudioComponent = (GongduolaAudioComponent)componentTemplate;
		if (base.CanResetComponentProperty("LastSpeed"))
		{
			this.LastSpeed = gongduolaAudioComponent.LastSpeed;
		}
		if (base.CanResetComponentProperty("MoveSoundEventHandle"))
		{
			this.MoveSoundEventHandle = gongduolaAudioComponent.MoveSoundEventHandle;
		}
		return true;
	}

	// Token: 0x0400E0A7 RID: 57511
	private const string VEHICLE_MOVE_EVENT = "play_interactive_gongduola_move";

	// Token: 0x0400E0A8 RID: 57512
	private const float MAX_VEHICLE_SPEED_RTPC_PARAM = 50f;

	// Token: 0x0400E0A9 RID: 57513
	private const float CHANGE_VEHICLE_SPEED_TOLERENCE = 50f;

	// Token: 0x0400E0AA RID: 57514
	private const float VEHICLE_MOVE_SPEED_MAPPING = 100f;

	// Token: 0x0400E0AB RID: 57515
	private float LastSpeed;

	// Token: 0x0400E0AC RID: 57516
	private int MoveSoundEventHandle;
}
