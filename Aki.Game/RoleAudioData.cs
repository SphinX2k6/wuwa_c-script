using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D2B RID: 7467
[NullableContext(1)]
[Nullable(0)]
public class RoleAudioData : RoleModuleDataBase
{
	// Token: 0x06012844 RID: 75844 RVA: 0x00579042 File Offset: 0x00577242
	public RoleAudioData(int roleId) : base(roleId)
	{
		this.InitAudioData();
	}

	// Token: 0x06012845 RID: 75845 RVA: 0x0057905C File Offset: 0x0057725C
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

	// Token: 0x06012846 RID: 75846 RVA: 0x005790DC File Offset: 0x005772DC
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

	// Token: 0x0400A0E1 RID: 41185
	private readonly Dictionary<string, RoleAnimAudioData> AudioMap = new Dictionary<string, RoleAnimAudioData>();
}
