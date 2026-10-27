using System;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;

// Token: 0x02002512 RID: 9490
public class PhoneMsgBgItemData
{
	// Token: 0x06013148 RID: 78152 RVA: 0x004BAC04 File Offset: 0x004B8E04
	public ChatBg GetConfig()
	{
		return PhoneMsgConfig.Instance.GetChatBgConfig(this.BgId).Value;
	}

	// Token: 0x06013149 RID: 78153 RVA: 0x004BAC29 File Offset: 0x004B8E29
	public bool IsHasRedDot()
	{
		return PhoneMsgModel.Instance.IsChatShowHasRedDotById(this.BgId);
	}

	// Token: 0x04008FE7 RID: 36839
	public int BgId;

	// Token: 0x04008FE8 RID: 36840
	public bool IsSelected;

	// Token: 0x04008FE9 RID: 36841
	public bool IsUsing;

	// Token: 0x04008FEA RID: 36842
	public bool IsUnlocked;
}
