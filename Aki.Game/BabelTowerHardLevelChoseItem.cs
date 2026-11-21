using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000610 RID: 1552
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerHardLevelChoseItem : GridProxyAbstract<BabelActivityLevelInfo>
{
	// Token: 0x060048AE RID: 18606 RVA: 0x00189C8C File Offset: 0x00187E8C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 20;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickResetButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060048AF RID: 18607 RVA: 0x00189FB4 File Offset: 0x001881B4
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<BabelTowerHardLevelRoleItem, int>(base.GetHorizontalLayout(8), new Func<BabelTowerHardLevelRoleItem>(this.InitRoleItem), null, false, true);
		this.LevelPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060048B0 RID: 18608 RVA: 0x00189FE8 File Offset: 0x001881E8
	public override void Refresh(BabelActivityLevelInfo data, bool isSelected, int gridIndex)
	{
		base.GetText(2).SetText((gridIndex + 1).ToString() ?? "", true);
		this.LevelId = data.LevelsId;
		bool isFinished = data.IsFinished;
		base.GetItem(9).SetUIActive(false);
		base.GetItem(10).SetUIActive(false);
		int num = 1;
		for (int i = 0; i < data.MaxPassBuffSelection.Count; i++)
		{
			int id = data.MaxPassBuffSelection[i];
			BabelTowerBuff babelTowerBuff = BabelTowerConfig.Instance.GetBabelTowerBuff(id);
			if (num == 1)
			{
				base.GetItem(9).SetUIActive(true);
				base.SetTextureByPath(babelTowerBuff.Texture, base.GetTexture(15), null, null);
			}
			if (num == 2)
			{
				base.GetItem(10).SetUIActive(true);
				base.SetTextureByPath(babelTowerBuff.Texture, base.GetTexture(16), null, null);
			}
			num++;
		}
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(data.LevelsId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), babelTowerLevelConfig.NameText, Array.Empty<object>());
		base.SetTextureByPath(babelTowerLevelConfig.Texture, base.GetTexture(1), null, null);
		base.GetItem(5).SetUIActive(isFinished);
		base.GetItem(19).SetUIActive(isFinished);
		base.GetItem(6).SetUIActive(!isFinished);
		base.GetButton(11).RootUIComp.Get().SetUIActive(isFinished);
		if (isFinished)
		{
			base.GetText(7).SetText(data.PassStar.ToString() ?? "", true);
			GenericLayout<BabelTowerHardLevelRoleItem, int> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.RefreshByData(new List<int>(data.MaxPassRoleSelection), null, false);
			}
			base.GetText(4).SetText(TimeUtil.Instance.GetTimeDataFormatWithHour((double)data.MaxPassUseTime), true);
		}
		else
		{
			base.GetText(4).SetText("", true);
		}
		long num2 = MathUtils.Instance.LongToNumber(data.UnlockTime);
		this.IsUnlock = ((double)num2 <= TimeUtil.Instance.GetServerTimeStamp());
		base.GetItem(12).SetUIActive(this.IsUnlock);
		base.GetItem(13).SetUIActive(!this.IsUnlock);
		if (!this.IsUnlock)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(((double)num2 - TimeUtil.Instance.GetServerTimeStamp()) * TimeUtil.Instance.Millisecond);
			base.GetText(14).SetText(remainTimeDataFormat.CountDownText ?? "", true);
		}
		if (!this.RedDotHaveBind)
		{
			this.RedDotHaveBind = true;
		}
		else
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevel, base.GetItem(17), this.LevelId);
		}
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerNewLevel, base.GetItem(17), null, this.LevelId);
		if (BabelTowerModel.Instance.LevelChoseHandle == this.LevelId)
		{
			this.PlayLoopSequence();
			return;
		}
		this.StopLoopSequence();
	}

	// Token: 0x060048B1 RID: 18609 RVA: 0x0018A2FF File Offset: 0x001884FF
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevel, base.GetItem(17), this.LevelId);
	}

	// Token: 0x060048B2 RID: 18610 RVA: 0x0018A31E File Offset: 0x0018851E
	private void OnClickButton()
	{
		if (this.IsUnlock)
		{
			Action<int> onClickButtonCallBack = this.OnClickButtonCallBack;
			if (onClickButtonCallBack != null)
			{
				onClickButtonCallBack(this.LevelId);
			}
		}
		this.LevelPlayer.StopCurrentSequence(false, false);
	}

	// Token: 0x060048B3 RID: 18611 RVA: 0x0018A34C File Offset: 0x0018854C
	private void OnClickResetButton()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerResetView, this.LevelId, null);
	}

	// Token: 0x060048B4 RID: 18612 RVA: 0x0018A369 File Offset: 0x00188569
	private BabelTowerHardLevelRoleItem InitRoleItem()
	{
		return new BabelTowerHardLevelRoleItem();
	}

	// Token: 0x060048B5 RID: 18613 RVA: 0x0018A370 File Offset: 0x00188570
	public void DisableButton()
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(false);
		base.GetItem(12).SetUIActive(false);
	}

	// Token: 0x060048B6 RID: 18614 RVA: 0x0018A3A8 File Offset: 0x001885A8
	public void PlayLoopSequence()
	{
		if (this.LevelPlayer.IsPlayingSequence("Loop_item"))
		{
			this.LevelPlayer.ReplaySequenceByKey("Loop_item");
			return;
		}
		this.LevelPlayer.PlayLevelSequenceByName("Loop_item", false, null, false);
	}

	// Token: 0x060048B7 RID: 18615 RVA: 0x0018A3F3 File Offset: 0x001885F3
	public void StopLoopSequence()
	{
		this.LevelPlayer.StopCurrentSequence(false, true);
	}

	// Token: 0x060048B8 RID: 18616 RVA: 0x0018A402 File Offset: 0x00188602
	public bool IsPlayingSequence()
	{
		return this.LevelPlayer.IsPlayingSequence("Loop_item");
	}

	// Token: 0x0400366A RID: 13930
	private bool IsUnlock;

	// Token: 0x0400366B RID: 13931
	private bool RedDotHaveBind;

	// Token: 0x0400366C RID: 13932
	private int LevelId;

	// Token: 0x0400366D RID: 13933
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerHardLevelRoleItem, int> RoleLayout;

	// Token: 0x0400366E RID: 13934
	[Nullable(2)]
	public Action<int> OnClickButtonCallBack;

	// Token: 0x0400366F RID: 13935
	[Nullable(2)]
	private LevelSequencePlayer LevelPlayer;

	// Token: 0x020068B0 RID: 26800
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040227FC RID: 141308
		public const int Button = 0;

		// Token: 0x040227FD RID: 141309
		public const int BgTexture = 1;

		// Token: 0x040227FE RID: 141310
		public const int IndexText = 2;

		// Token: 0x040227FF RID: 141311
		public const int NameText = 3;

		// Token: 0x04022800 RID: 141312
		public const int TimeText = 4;

		// Token: 0x04022801 RID: 141313
		public const int DoneItem = 5;

		// Token: 0x04022802 RID: 141314
		public const int NoneItem = 6;

		// Token: 0x04022803 RID: 141315
		public const int StarText = 7;

		// Token: 0x04022804 RID: 141316
		public const int RoleLayout = 8;

		// Token: 0x04022805 RID: 141317
		public const int BuffItem1 = 9;

		// Token: 0x04022806 RID: 141318
		public const int BuffItem2 = 10;

		// Token: 0x04022807 RID: 141319
		public const int ResetBtn = 11;

		// Token: 0x04022808 RID: 141320
		public const int GoItem = 12;

		// Token: 0x04022809 RID: 141321
		public const int LockItem = 13;

		// Token: 0x0402280A RID: 141322
		public const int OptionText = 14;

		// Token: 0x0402280B RID: 141323
		public const int BuffTexture1 = 15;

		// Token: 0x0402280C RID: 141324
		public const int BuffTexture2 = 16;

		// Token: 0x0402280D RID: 141325
		public const int RedDotItem = 17;

		// Token: 0x0402280E RID: 141326
		public const int TimeItem = 18;

		// Token: 0x0402280F RID: 141327
		public const int FinishedItem = 19;
	}
}
