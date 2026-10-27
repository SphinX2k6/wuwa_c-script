using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020029A2 RID: 10658
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBurningTideItem : UiPanelBase
{
	// Token: 0x06016184 RID: 90500 RVA: 0x005962A4 File Offset: 0x005944A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06016185 RID: 90501 RVA: 0x0059632C File Offset: 0x0059452C
	protected override void OnStart()
	{
		this.PointRotator = new FRotator(0f, 0f, 0f);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		this.ProgressText = base.GetText(2);
		this.ProgressText.SetText("0%", true);
	}

	// Token: 0x06016186 RID: 90502 RVA: 0x0059639C File Offset: 0x0059459C
	public void UpdateValue(int curScore, int maxScore)
	{
		float num = (float)curScore / (float)maxScore;
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetFillAmount(num);
		}
		this.PointRotator.Yaw = num * -360f;
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIRelativeRotation(this.PointRotator);
		}
		int num2 = (int)(num * 100f);
		this.ProgressText.SetText(num2.ToString() + "%", true);
		UUIItem progressText = this.ProgressText;
		bool bUseChangeColor = curScore >= maxScore;
		FColor? fcolor = new FColor?(this.ProgressText.changeColor);
		progressText.SetChangeColor(bUseChangeColor, fcolor);
		if (num >= 1f)
		{
			this.PlayLevelSequence("Immortal");
			return;
		}
		this.PlayLevelSequence("Start2");
	}

	// Token: 0x06016187 RID: 90503 RVA: 0x00596458 File Offset: 0x00594658
	private void PlayLevelSequence(string sequenceName)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ShipTower;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "ShipTowerBurningTideItem 播放序列";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sequenceName", sequenceName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlaySequencePurely(sequenceName, false, false, null, null, false);
	}

	// Token: 0x06016188 RID: 90504 RVA: 0x005964C0 File Offset: 0x005946C0
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			this.PlayLevelSequence("Loop2");
			return;
		}
		if (sequenceName == "Start2")
		{
			this.PlayLevelSequence("Loop1");
		}
	}

	// Token: 0x06016189 RID: 90505 RVA: 0x005964F3 File Offset: 0x005946F3
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0400A4B2 RID: 42162
	private FRotator PointRotator;

	// Token: 0x0400A4B3 RID: 42163
	private UUIText ProgressText;

	// Token: 0x0400A4B4 RID: 42164
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008FAB RID: 36779
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x0402E884 RID: 190596
		public const int ProgressSprite = 0;

		// Token: 0x0402E885 RID: 190597
		public const int BuffIconTexture = 1;

		// Token: 0x0402E886 RID: 190598
		public const int ProgressText = 2;

		// Token: 0x0402E887 RID: 190599
		public const int Button = 3;

		// Token: 0x0402E888 RID: 190600
		public const int PointItem = 4;
	}
}
