using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F1D RID: 7965
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerBurningTideItem : UiPanelBase
{
	// Token: 0x06013B8A RID: 80778 RVA: 0x005C1264 File Offset: 0x005BF464
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

	// Token: 0x06013B8B RID: 80779 RVA: 0x005C12EC File Offset: 0x005BF4EC
	protected override void OnStart()
	{
		this.PointRotator = new FRotator(0f, 0f, 0f);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		this.ProgressText = base.GetText(2);
		this.ProgressText.SetText("0%", true);
	}

	// Token: 0x06013B8C RID: 80780 RVA: 0x005C135C File Offset: 0x005BF55C
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

	// Token: 0x06013B8D RID: 80781 RVA: 0x005C1418 File Offset: 0x005BF618
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

	// Token: 0x06013B8E RID: 80782 RVA: 0x005C1480 File Offset: 0x005BF680
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

	// Token: 0x06013B8F RID: 80783 RVA: 0x005C14B3 File Offset: 0x005BF6B3
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0400A89C RID: 43164
	private FRotator PointRotator;

	// Token: 0x0400A89D RID: 43165
	private UUIText ProgressText;

	// Token: 0x0400A89E RID: 43166
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020081F4 RID: 33268
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x04029F83 RID: 171907
		public const int ProgressSprite = 0;

		// Token: 0x04029F84 RID: 171908
		public const int BuffIconTexture = 1;

		// Token: 0x04029F85 RID: 171909
		public const int ProgressText = 2;

		// Token: 0x04029F86 RID: 171910
		public const int Button = 3;

		// Token: 0x04029F87 RID: 171911
		public const int PointItem = 4;
	}
}
