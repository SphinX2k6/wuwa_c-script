using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001089 RID: 4233
public class RhythmGameRoleInfoPanel : UiPanelBase
{
	// Token: 0x06006E13 RID: 28179 RVA: 0x00166230 File Offset: 0x00164430
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06006E14 RID: 28180 RVA: 0x0016628C File Offset: 0x0016448C
	protected override void OnBeforeShow()
	{
		int? num = this.OpenParam as int?;
		if (num == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.BB, "RhythmGameRoleInfoPanel OpenParam is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.roleId = num.Value;
		RhythmRole? rhythmRoleById = RhythmShipConfig.Instance.GetRhythmRoleById(this.roleId);
		if (rhythmRoleById == null)
		{
			return;
		}
		this.RoleSkillAudio = rhythmRoleById.Value.RoleSkillMusic;
		base.SetTextureShowUntilLoaded(rhythmRoleById.Value.RoleHeadTexture2, base.GetTexture(0), null);
		base.GetItem(1).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rhythmRoleById.Value.RoleSkillText, Array.Empty<object>());
	}

	// Token: 0x06006E15 RID: 28181 RVA: 0x0016635F File Offset: 0x0016455F
	protected override void OnAfterShow()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(this.roleId != 0);
	}

	// Token: 0x06006E16 RID: 28182 RVA: 0x0016637C File Offset: 0x0016457C
	public void ShowRoleFeverInfo()
	{
		base.GetItem(1).SetUIActive(true);
		if (this.RoleSkillAudio != "")
		{
			RhythmGameController.Instance.PlayRoleFeverAudio(this.RoleSkillAudio);
		}
		TimerSystemInstance rhythmGameTimerSystem = RhythmGameController.Instance.RhythmGameTimerSystem;
		if (rhythmGameTimerSystem == null)
		{
			return;
		}
		rhythmGameTimerSystem.Delay(delegate(float _)
		{
			base.GetItem(1).SetUIActive(false);
		}, (float)this.RhythmGameRoleFeverAudioDelayTime, null, null, true, 1f);
	}

	// Token: 0x040032F7 RID: 13047
	private readonly int RhythmGameRoleFeverAudioDelayTime = 4000;

	// Token: 0x040032F8 RID: 13048
	[Nullable(1)]
	private string RoleSkillAudio = "";

	// Token: 0x040032F9 RID: 13049
	private int roleId;

	// Token: 0x02007681 RID: 30337
	private enum EComponent
	{
		// Token: 0x040271A9 RID: 160169
		IconRole,
		// Token: 0x040271AA RID: 160170
		InfoItem,
		// Token: 0x040271AB RID: 160171
		RoleSkillText
	}
}
