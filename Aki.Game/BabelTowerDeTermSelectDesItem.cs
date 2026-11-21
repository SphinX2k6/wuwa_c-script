using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000602 RID: 1538
public class BabelTowerDeTermSelectDesItem : GridProxyAbstract<int>
{
	// Token: 0x060047D9 RID: 18393 RVA: 0x0018497C File Offset: 0x00182B7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060047DA RID: 18394 RVA: 0x00184A64 File Offset: 0x00182C64
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060047DB RID: 18395 RVA: 0x00184A78 File Offset: 0x00182C78
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.DeTermId = data;
		BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(data);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), babelTowerDeTerm.DesText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), babelTowerDeTerm.NameText, Array.Empty<object>());
		base.GetText(1).SetText(babelTowerDeTerm.Star.ToString() ?? "", true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.StopCurrentSequence(false, true);
	}

	// Token: 0x060047DC RID: 18396 RVA: 0x00184B09 File Offset: 0x00182D09
	private void OnClickBtn()
	{
		Action<int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(this.DeTermId);
	}

	// Token: 0x060047DD RID: 18397 RVA: 0x00184B24 File Offset: 0x00182D24
	public void PlayChoseSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Loop_Center_Once", false, null, false);
	}

	// Token: 0x04003624 RID: 13860
	public int DeTermId;

	// Token: 0x04003625 RID: 13861
	[Nullable(2)]
	public LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003626 RID: 13862
	[Nullable(2)]
	public Action<int> OnClickCallBack;

	// Token: 0x0200688E RID: 26766
	private class EComponentDefine
	{
		// Token: 0x0402275F RID: 141151
		public const int NameText = 0;

		// Token: 0x04022760 RID: 141152
		public const int NumberText = 1;

		// Token: 0x04022761 RID: 141153
		public const int BgItem = 2;

		// Token: 0x04022762 RID: 141154
		public const int DeTermBtn = 3;

		// Token: 0x04022763 RID: 141155
		public const int TitleText = 4;
	}
}
