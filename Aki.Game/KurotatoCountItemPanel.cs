using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200117B RID: 4475
[NullableContext(1)]
[Nullable(0)]
public class KurotatoCountItemPanel : UiPanelBase
{
	// Token: 0x0600B24C RID: 45644 RVA: 0x0034AD17 File Offset: 0x00348F17
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600B24D RID: 45645 RVA: 0x0034AD50 File Offset: 0x00348F50
	protected override void OnStart()
	{
		this.TextNum = base.GetText(0);
		this.SpriteArrow = base.GetSprite(1);
		this.SpriteArrow.SetUIActive(false);
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B24E RID: 45646 RVA: 0x0034AD89 File Offset: 0x00348F89
	public void Refresh(int num)
	{
		this.TextNum.SetText(num.ToString(), true);
	}

	// Token: 0x0600B24F RID: 45647 RVA: 0x0034ADA0 File Offset: 0x00348FA0
	public void PlayAcquireAnim()
	{
		this.SeqPlayer.PlayOrReplaySequenceByName("Acqu", false, null);
	}

	// Token: 0x040066D9 RID: 26329
	private UUIText TextNum;

	// Token: 0x040066DA RID: 26330
	private UUISprite SpriteArrow;

	// Token: 0x040066DB RID: 26331
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0200742C RID: 29740
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025CF7 RID: 154871
		public const int TextNum = 0;

		// Token: 0x04025CF8 RID: 154872
		public const int SpriteArrow = 1;
	}
}
