using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000528 RID: 1320
public class GuessJokerHpItem : GridProxyAbstract<bool>
{
	// Token: 0x06004065 RID: 16485 RVA: 0x00168E6A File Offset: 0x0016706A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06004066 RID: 16486 RVA: 0x00168EA3 File Offset: 0x001670A3
	protected override void OnStart()
	{
		base.GetSprite(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		this.LastIsShow = true;
	}

	// Token: 0x06004067 RID: 16487 RVA: 0x00168EC6 File Offset: 0x001670C6
	public override void Refresh(bool isShow, bool isSelected, int gridIndex)
	{
		if (this.LastIsShow && !isShow)
		{
			this.ShowBrokenAnim();
		}
		base.GetSprite(0).SetUIActive(isShow);
		base.GetItem(1).SetUIActive(!isShow);
		this.LastIsShow = isShow;
	}

	// Token: 0x06004068 RID: 16488 RVA: 0x00168F00 File Offset: 0x00167100
	public void ShowBrokenAnim()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("Damage", false, null, false);
	}

	// Token: 0x040032FF RID: 13055
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003300 RID: 13056
	private bool LastIsShow = true;

	// Token: 0x020067FE RID: 26622
	private static class EComponentDefine
	{
		// Token: 0x040224AE RID: 140462
		public const int LightSprite = 0;

		// Token: 0x040224AF RID: 140463
		public const int BrokenItem = 1;
	}
}
