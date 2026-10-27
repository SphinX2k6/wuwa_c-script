using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

// Token: 0x02001D30 RID: 7472
public class TrapDefenseMonsterMarkView : TrapDefenseMarkView
{
	// Token: 0x0600E249 RID: 57929 RVA: 0x00352950 File Offset: 0x00350B50
	public TrapDefenseMonsterMarkView(int markId) : base(markId)
	{
		this.NeedUpdatePositionInner = true;
	}

	// Token: 0x0600E24A RID: 57930 RVA: 0x00352960 File Offset: 0x00350B60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600E24B RID: 57931 RVA: 0x00352983 File Offset: 0x00350B83
	protected override void OnStart()
	{
		base.GetRootItem().SetAlpha(0f);
		this.RefreshIcon();
	}

	// Token: 0x0600E24C RID: 57932 RVA: 0x0035299C File Offset: 0x00350B9C
	private void RefreshIcon()
	{
		TrapDefenseMonsterMarkItem trapDefenseMonsterMarkItem = base.GetMarkData() as TrapDefenseMonsterMarkItem;
		if (trapDefenseMonsterMarkItem == null || trapDefenseMonsterMarkItem.EnemyType == this.CurrentEnemyType)
		{
			return;
		}
		this.CurrentEnemyType = trapDefenseMonsterMarkItem.EnemyType;
		UUISprite sprite = base.GetSprite(0);
		if (TowerDefenseEventController.Instance.ProcessStatus == ETowerDefenseEventProcessStatus.Ready)
		{
			this.SetSpriteByPath(TrapDefenseDefine.enemyResourcePreviewRecord[trapDefenseMonsterMarkItem.EnemyType], sprite, true, null, delegate(bool _)
			{
				sprite.SetUIActive(true);
			});
			return;
		}
		this.SetSpriteByPath(TrapDefenseDefine.enemyResourceBattleRecord[trapDefenseMonsterMarkItem.EnemyType], sprite, true, null, delegate(bool _)
		{
			sprite.SetUIActive(true);
		});
	}

	// Token: 0x0600E24D RID: 57933 RVA: 0x00352A58 File Offset: 0x00350C58
	[NullableContext(1)]
	public override void UpdatePosition(float scale, Vector2D centerOffset)
	{
		this.RefreshIcon();
		base.UpdatePosition(scale, centerOffset);
	}

	// Token: 0x040068AE RID: 26798
	private ETrapDefenseEnemyType CurrentEnemyType;

	// Token: 0x02008334 RID: 33588
	private static class EChildComponent
	{
		// Token: 0x0402AC93 RID: 175251
		public const int Icon = 0;
	}
}
