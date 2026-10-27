using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F59 RID: 3929
public class DrinksFlavorValueItem : UiPanelBase
{
	// Token: 0x06006485 RID: 25733 RVA: 0x0013E1A4 File Offset: 0x0013C3A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x06006486 RID: 25734 RVA: 0x0013E240 File Offset: 0x0013C440
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06006487 RID: 25735 RVA: 0x0013E253 File Offset: 0x0013C453
	[NullableContext(1)]
	public void RefreshState(bool isActive, string[] value, bool needAlpha)
	{
		this.RefreshAnim(isActive);
		this.RefreshTxt(value, needAlpha);
	}

	// Token: 0x06006488 RID: 25736 RVA: 0x0013E264 File Offset: 0x0013C464
	[NullableContext(1)]
	private void RefreshTxt(string[] value, bool needAlpha)
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(value.Length == 1);
		}
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetUIActive(value.Length > 1);
		}
		UUIText text3 = base.GetText(5);
		if (text3 != null)
		{
			text3.SetUIActive(value.Length > 1);
		}
		if (value.Length == 1)
		{
			UUIText text4 = base.GetText(2);
			if (text4 != null)
			{
				text4.SetText(value[0], true);
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(needAlpha ? 0.5f : 1f);
			return;
		}
		else
		{
			UUIText text5 = base.GetText(4);
			if (text5 != null)
			{
				text5.SetText(value[0], true);
			}
			UUIText text6 = base.GetText(5);
			if (text6 != null)
			{
				text6.SetText(value[1], true);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetAlpha(1f);
			return;
		}
	}

	// Token: 0x06006489 RID: 25737 RVA: 0x0013E338 File Offset: 0x0013C538
	private void RefreshAnim(bool isActive)
	{
		if (isActive != this.OldActive || isActive)
		{
			this.OldActive = isActive;
			if (isActive)
			{
				LevelSequencePlayer levelSequence = this.LevelSequence;
				if (levelSequence != null && levelSequence.IsPlayingSequence("Close"))
				{
					LevelSequencePlayer levelSequence2 = this.LevelSequence;
					if (levelSequence2 != null)
					{
						levelSequence2.StopCurrentSequence(false, true);
					}
				}
				LevelSequencePlayer levelSequence3 = this.LevelSequence;
				if (levelSequence3 == null)
				{
					return;
				}
				levelSequence3.PlayLevelSequenceByName("Start", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequence4 = this.LevelSequence;
				if (levelSequence4 != null && levelSequence4.IsPlayingSequence("Start"))
				{
					LevelSequencePlayer levelSequence5 = this.LevelSequence;
					if (levelSequence5 != null)
					{
						levelSequence5.StopCurrentSequence(false, true);
					}
				}
				LevelSequencePlayer levelSequence6 = this.LevelSequence;
				if (levelSequence6 == null)
				{
					return;
				}
				levelSequence6.PlayLevelSequenceByName("Close", false, null, false);
			}
		}
	}

	// Token: 0x04002DA1 RID: 11681
	protected bool OldActive;

	// Token: 0x04002DA2 RID: 11682
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x020075A5 RID: 30117
	private class EValue
	{
		// Token: 0x04026E33 RID: 159283
		public const int PanelOffset = 0;

		// Token: 0x04026E34 RID: 159284
		public const int TexIcon = 1;

		// Token: 0x04026E35 RID: 159285
		public const int TxtValue = 2;

		// Token: 0x04026E36 RID: 159286
		public const int PanelActive = 3;

		// Token: 0x04026E37 RID: 159287
		public const int TxtActive1 = 4;

		// Token: 0x04026E38 RID: 159288
		public const int TxtActive2 = 5;
	}
}
