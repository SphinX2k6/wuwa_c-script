using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A36 RID: 6710
public class PhonographNewMusicItem : GridProxyAbstract<int>
{
	// Token: 0x06010885 RID: 67717 RVA: 0x004D7031 File Offset: 0x004D5231
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06010886 RID: 67718 RVA: 0x004D7054 File Offset: 0x004D5254
	public override void Refresh(int musicId, bool isSelected, int gridIndex)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(musicId) : null;
		if (phonographMusic == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), phonographMusic.Value.Title, Array.Empty<object>());
	}

	// Token: 0x02007C8D RID: 31885
	private static class EPhonographNewMusicItemDefine
	{
		// Token: 0x0402855C RID: 165212
		public const int TxtName = 0;
	}
}
