using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001A10 RID: 6672
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeResultData
{
	// Token: 0x0600C3DE RID: 50142 RVA: 0x002C5B33 File Offset: 0x002C3D33
	public int GetPassTime()
	{
		return this.PassTime;
	}

	// Token: 0x0600C3DF RID: 50143 RVA: 0x002C5B3B File Offset: 0x002C3D3B
	public int GetMinPassTime()
	{
		return this.MinPassTime;
	}

	// Token: 0x0600C3E0 RID: 50144 RVA: 0x002C5B43 File Offset: 0x002C3D43
	public bool GetIfSuccess()
	{
		return this.IfSuccess;
	}

	// Token: 0x0600C3E1 RID: 50145 RVA: 0x002C5B4B File Offset: 0x002C3D4B
	public global::AbyssChallengeResultPlayerInfo[] GetPlayerInfoList()
	{
		return this.PlayerInfoList;
	}

	// Token: 0x0600C3E2 RID: 50146 RVA: 0x002C5B54 File Offset: 0x002C3D54
	[NullableContext(2)]
	public global::AbyssChallengeResultPlayerInfo GetPlayerInfoByPlayerId(int playerId)
	{
		foreach (global::AbyssChallengeResultPlayerInfo abyssChallengeResultPlayerInfo in this.PlayerInfoList)
		{
			if (abyssChallengeResultPlayerInfo.GetPlayerId() == playerId)
			{
				return abyssChallengeResultPlayerInfo;
			}
		}
		return null;
	}

	// Token: 0x0600C3E3 RID: 50147 RVA: 0x002C5B88 File Offset: 0x002C3D88
	[NullableContext(2)]
	public void Phrase(AbyssChallengeResultInfo data)
	{
		if (data == null)
		{
			return;
		}
		this.PassTime = data.PassTime;
		this.MinPassTime = data.MinPassTime;
		this.IfSuccess = data.Success;
		this.PlayerInfoList = Array.Empty<global::AbyssChallengeResultPlayerInfo>();
		List<global::AbyssChallengeResultPlayerInfo> list = new List<global::AbyssChallengeResultPlayerInfo>();
		int count = data.PlayerInfos.Count;
		for (int i = 0; i < count; i++)
		{
			global::AbyssChallengeResultPlayerInfo abyssChallengeResultPlayerInfo = new global::AbyssChallengeResultPlayerInfo();
			abyssChallengeResultPlayerInfo.Phrase(data.PlayerInfos[i]);
			list.Add(abyssChallengeResultPlayerInfo);
		}
		this.PlayerInfoList = list.ToArray();
	}

	// Token: 0x04005A54 RID: 23124
	private int PassTime;

	// Token: 0x04005A55 RID: 23125
	private int MinPassTime;

	// Token: 0x04005A56 RID: 23126
	private bool IfSuccess;

	// Token: 0x04005A57 RID: 23127
	private global::AbyssChallengeResultPlayerInfo[] PlayerInfoList = Array.Empty<global::AbyssChallengeResultPlayerInfo>();
}
