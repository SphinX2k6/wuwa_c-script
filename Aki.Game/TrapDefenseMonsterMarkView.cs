using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;
using UnrealEngine;

// Token: 0x020011F2 RID: 4594
public class TrapDefenseMonsterMarkView : TrapDefenseMarkView
{
	// Token: 0x0600B666 RID: 46694 RVA: 0x0035E380 File Offset: 0x0035C580
	public TrapDefenseMonsterMarkView(int markId) : base(markId)
	{
		this.NeedUpdatePositionInner = true;
	}

	// Token: 0x0600B667 RID: 46695 RVA: 0x0035E390 File Offset: 0x0035C590
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600B668 RID: 46696 RVA: 0x0035E3B3 File Offset: 0x0035C5B3
	protected override void OnStart()
	{
		base.GetRootItem().SetAlpha(0f);
		this.RefreshIcon();
	}

	// Token: 0x0600B669 RID: 46697 RVA: 0x0035E3CC File Offset: 0x0035C5CC
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

	// Token: 0x0600B66A RID: 46698 RVA: 0x0035E488 File Offset: 0x0035C688
	[NullableContext(1)]
	public override void UpdatePosition(float scale, Vector2D centerOffset)
	{
		this.RefreshIcon();
		base.UpdatePosition(scale, centerOffset);
	}

	// Token: 0x0400698D RID: 27021
	private ETrapDefenseEnemyType CurrentEnemyType;

	// Token: 0x020074BD RID: 29885
	private static class EChildComponent
	{
		// Token: 0x04025FBB RID: 155579
		public const int Icon = 0;
	}
}
