using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200114E RID: 4430
public class BabelTowerDeTermSelectDesItem : GridProxyAbstract<int>
{
	// Token: 0x06007442 RID: 29762 RVA: 0x0017BE30 File Offset: 0x0017A030
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

	// Token: 0x06007443 RID: 29763 RVA: 0x0017BF18 File Offset: 0x0017A118
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06007444 RID: 29764 RVA: 0x0017BF2C File Offset: 0x0017A12C
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

	// Token: 0x06007445 RID: 29765 RVA: 0x0017BFBD File Offset: 0x0017A1BD
	private void OnClickBtn()
	{
		Action<int> onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack(this.DeTermId);
	}

	// Token: 0x06007446 RID: 29766 RVA: 0x0017BFD8 File Offset: 0x0017A1D8
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

	// Token: 0x0400358B RID: 13707
	public int DeTermId;

	// Token: 0x0400358C RID: 13708
	[Nullable(2)]
	public LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400358D RID: 13709
	[Nullable(2)]
	public Action<int> OnClickCallBack;

	// Token: 0x020076FF RID: 30463
	private class EComponentDefine
	{
		// Token: 0x0402741E RID: 160798
		public const int NameText = 0;

		// Token: 0x0402741F RID: 160799
		public const int NumberText = 1;

		// Token: 0x04027420 RID: 160800
		public const int BgItem = 2;

		// Token: 0x04027421 RID: 160801
		public const int DeTermBtn = 3;

		// Token: 0x04027422 RID: 160802
		public const int TitleText = 4;
	}
}
