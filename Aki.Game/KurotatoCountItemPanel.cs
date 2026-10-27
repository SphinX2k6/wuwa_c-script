using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CB9 RID: 7353
[NullableContext(1)]
[Nullable(0)]
public class KurotatoCountItemPanel : UiPanelBase
{
	// Token: 0x0600DE2F RID: 56879 RVA: 0x0033F2DB File Offset: 0x0033D4DB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600DE30 RID: 56880 RVA: 0x0033F314 File Offset: 0x0033D514
	protected override void OnStart()
	{
		this.TextNum = base.GetText(0);
		this.SpriteArrow = base.GetSprite(1);
		this.SpriteArrow.SetUIActive(false);
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600DE31 RID: 56881 RVA: 0x0033F34D File Offset: 0x0033D54D
	public void Refresh(int num)
	{
		this.TextNum.SetText(num.ToString(), true);
	}

	// Token: 0x0600DE32 RID: 56882 RVA: 0x0033F364 File Offset: 0x0033D564
	public void PlayAcquireAnim()
	{
		this.SeqPlayer.PlayOrReplaySequenceByName("Acqu", false, null);
	}

	// Token: 0x040065FA RID: 26106
	private UUIText TextNum;

	// Token: 0x040065FB RID: 26107
	private UUISprite SpriteArrow;

	// Token: 0x040065FC RID: 26108
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x020082A2 RID: 33442
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402A9CC RID: 174540
		public const int TextNum = 0;

		// Token: 0x0402A9CD RID: 174541
		public const int SpriteArrow = 1;
	}
}
