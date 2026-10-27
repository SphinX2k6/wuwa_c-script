using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001074 RID: 4212
public class GuessJokerHpItem : GridProxyAbstract<bool>
{
	// Token: 0x06006CD0 RID: 27856 RVA: 0x00160536 File Offset: 0x0015E736
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06006CD1 RID: 27857 RVA: 0x0016056F File Offset: 0x0015E76F
	protected override void OnStart()
	{
		base.GetSprite(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		this.LastIsShow = true;
	}

	// Token: 0x06006CD2 RID: 27858 RVA: 0x00160592 File Offset: 0x0015E792
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

	// Token: 0x06006CD3 RID: 27859 RVA: 0x001605CC File Offset: 0x0015E7CC
	public void ShowBrokenAnim()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("Damage", false, null, false);
	}

	// Token: 0x04003266 RID: 12902
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003267 RID: 12903
	private bool LastIsShow = true;

	// Token: 0x0200766A RID: 30314
	private static class EComponentDefine
	{
		// Token: 0x04027163 RID: 160099
		public const int LightSprite = 0;

		// Token: 0x04027164 RID: 160100
		public const int BrokenItem = 1;
	}
}
