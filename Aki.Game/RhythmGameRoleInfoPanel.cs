using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200053D RID: 1341
public class RhythmGameRoleInfoPanel : UiPanelBase
{
	// Token: 0x060041A8 RID: 16808 RVA: 0x0016EB64 File Offset: 0x0016CD64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x0016EBC0 File Offset: 0x0016CDC0
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

	// Token: 0x060041AA RID: 16810 RVA: 0x0016EC93 File Offset: 0x0016CE93
	protected override void OnAfterShow()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(this.roleId != 0);
	}

	// Token: 0x060041AB RID: 16811 RVA: 0x0016ECB0 File Offset: 0x0016CEB0
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

	// Token: 0x04003390 RID: 13200
	private readonly int RhythmGameRoleFeverAudioDelayTime = 4000;

	// Token: 0x04003391 RID: 13201
	[Nullable(1)]
	private string RoleSkillAudio = "";

	// Token: 0x04003392 RID: 13202
	private int roleId;

	// Token: 0x02006815 RID: 26645
	private enum EComponent
	{
		// Token: 0x040224F4 RID: 140532
		IconRole,
		// Token: 0x040224F5 RID: 140533
		InfoItem,
		// Token: 0x040224F6 RID: 140534
		RoleSkillText
	}
}
