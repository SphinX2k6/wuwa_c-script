using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020027B0 RID: 10160
[NullableContext(1)]
[Nullable(0)]
public class RoleAudioData : RoleModuleDataBase
{
	// Token: 0x06014E45 RID: 85573 RVA: 0x0054E31A File Offset: 0x0054C51A
	public RoleAudioData(int roleId) : base(roleId)
	{
		this.InitAudioData();
	}

	// Token: 0x06014E46 RID: 85574 RVA: 0x0054E334 File Offset: 0x0054C534
	private void InitAudioData()
	{
		IReadOnlyList<RoleAnimAudio> roleAudioMap = RoleConfig.Instance.GetRoleAudioMap(this.RoleId);
		if (roleAudioMap == null)
		{
			return;
		}
		foreach (RoleAnimAudio roleAnimAudio in roleAudioMap)
		{
			RoleAnimAudioData value = new RoleAnimAudioData(roleAnimAudio.CanInterrupt, roleAnimAudio.AudioPath);
			this.AudioMap[roleAnimAudio.ActionName] = value;
		}
	}

	// Token: 0x06014E47 RID: 85575 RVA: 0x0054E3B4 File Offset: 0x0054C5B4
	[return: Nullable(2)]
	public RoleAnimAudioData GetAudioPathByName(string animName)
	{
		if (this.AudioMap == null)
		{
			return null;
		}
		RoleAnimAudioData result;
		if (!this.AudioMap.TryGetValue(animName, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x04009CFE RID: 40190
	private readonly Dictionary<string, RoleAnimAudioData> AudioMap = new Dictionary<string, RoleAnimAudioData>();
}
