using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x0200285A RID: 10330
[NullableContext(1)]
[Nullable(0)]
public class GongduolaAudioComponent : VehicleAudioComponent
{
	// Token: 0x0601A252 RID: 107090 RVA: 0x008145FC File Offset: 0x008127FC
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

	// Token: 0x0601A253 RID: 107091 RVA: 0x0081463A File Offset: 0x0081283A
	protected override void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
	{
		GameAudioModel.Instance.GondolaGetOnAudioEvent(base.Entity);
	}

	// Token: 0x0601A254 RID: 107092 RVA: 0x0081464C File Offset: 0x0081284C
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

	// Token: 0x0601A255 RID: 107093 RVA: 0x00814704 File Offset: 0x00812904
	private void StopMoveSound(AActor owner)
	{
		if (this.MoveSoundEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.MoveSoundEventHandle, EAudioActionType.Stop, null);
			this.MoveSoundEventHandle = 0;
		}
	}

	// Token: 0x0601A256 RID: 107094 RVA: 0x0081473C File Offset: 0x0081293C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		GongduolaAudioComponent gongduolaAudioComponent = (GongduolaAudioComponent)componentTemplate;
		this.LastSpeed = gongduolaAudioComponent.LastSpeed;
		this.MoveSoundEventHandle = gongduolaAudioComponent.MoveSoundEventHandle;
		return true;
	}

	// Token: 0x17002A9E RID: 10910
	// (get) Token: 0x0601A257 RID: 107095 RVA: 0x00814774 File Offset: 0x00812974
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A9F RID: 10911
	// (get) Token: 0x0601A258 RID: 107096 RVA: 0x00814777 File Offset: 0x00812977
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AA0 RID: 10912
	// (get) Token: 0x0601A259 RID: 107097 RVA: 0x0081477A File Offset: 0x0081297A
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AA1 RID: 10913
	// (get) Token: 0x0601A25A RID: 107098 RVA: 0x0081477D File Offset: 0x0081297D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E552 RID: 58706
	private const string VEHICLE_MOVE_EVENT = "play_interactive_gongduola_move";

	// Token: 0x0400E553 RID: 58707
	private const float MAX_VEHICLE_SPEED_RTPC_PARAM = 50f;

	// Token: 0x0400E554 RID: 58708
	private const float CHANGE_VEHICLE_SPEED_TOLERENCE = 50f;

	// Token: 0x0400E555 RID: 58709
	private const float VEHICLE_MOVE_SPEED_MAPPING = 100f;

	// Token: 0x0400E556 RID: 58710
	private float LastSpeed;

	// Token: 0x0400E557 RID: 58711
	private int MoveSoundEventHandle;
}
