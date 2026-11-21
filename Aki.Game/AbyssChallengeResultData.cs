using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000ECF RID: 3791
[NullableContext(1)]
[Nullable(0)]
public class AbyssChallengeResultData
{
	// Token: 0x060097EE RID: 38894 RVA: 0x002D0B8C File Offset: 0x002CED8C
	public int GetPassTime()
	{
		return this.PassTime;
	}

	// Token: 0x060097EF RID: 38895 RVA: 0x002D0B94 File Offset: 0x002CED94
	public int GetMinPassTime()
	{
		return this.MinPassTime;
	}

	// Token: 0x060097F0 RID: 38896 RVA: 0x002D0B9C File Offset: 0x002CED9C
	public bool GetIfSuccess()
	{
		return this.IfSuccess;
	}

	// Token: 0x060097F1 RID: 38897 RVA: 0x002D0BA4 File Offset: 0x002CEDA4
	public global::AbyssChallengeResultPlayerInfo[] GetPlayerInfoList()
	{
		return this.PlayerInfoList;
	}

	// Token: 0x060097F2 RID: 38898 RVA: 0x002D0BAC File Offset: 0x002CEDAC
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

	// Token: 0x060097F3 RID: 38899 RVA: 0x002D0BE0 File Offset: 0x002CEDE0
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

	// Token: 0x04005B23 RID: 23331
	private int PassTime;

	// Token: 0x04005B24 RID: 23332
	private int MinPassTime;

	// Token: 0x04005B25 RID: 23333
	private bool IfSuccess;

	// Token: 0x04005B26 RID: 23334
	private global::AbyssChallengeResultPlayerInfo[] PlayerInfoList = Array.Empty<global::AbyssChallengeResultPlayerInfo>();
}
