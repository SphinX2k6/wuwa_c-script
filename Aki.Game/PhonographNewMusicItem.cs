using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200254B RID: 9547
public class PhonographNewMusicItem : GridProxyAbstract<int>
{
	// Token: 0x060133A5 RID: 78757 RVA: 0x004C84B5 File Offset: 0x004C66B5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060133A6 RID: 78758 RVA: 0x004C84D8 File Offset: 0x004C66D8
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

	// Token: 0x02008B07 RID: 35591
	private static class EPhonographNewMusicItemDefine
	{
		// Token: 0x0402D24D RID: 184909
		public const int TxtName = 0;
	}
}
