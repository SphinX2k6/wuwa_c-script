using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200115C RID: 4444
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerHardLevelChoseItem : GridProxyAbstract<BabelActivityLevelInfo>
{
	// Token: 0x06007517 RID: 29975 RVA: 0x0018115C File Offset: 0x0017F35C
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

	// Token: 0x06007518 RID: 29976 RVA: 0x00181484 File Offset: 0x0017F684
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<BabelTowerHardLevelRoleItem, int>(base.GetHorizontalLayout(8), new Func<BabelTowerHardLevelRoleItem>(this.InitRoleItem), null, false, true);
		this.LevelPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06007519 RID: 29977 RVA: 0x001814B8 File Offset: 0x0017F6B8
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

	// Token: 0x0600751A RID: 29978 RVA: 0x001817CF File Offset: 0x0017F9CF
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevel, base.GetItem(17), this.LevelId);
	}

	// Token: 0x0600751B RID: 29979 RVA: 0x001817EE File Offset: 0x0017F9EE
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

	// Token: 0x0600751C RID: 29980 RVA: 0x0018181C File Offset: 0x0017FA1C
	private void OnClickResetButton()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerResetView, this.LevelId, null);
	}

	// Token: 0x0600751D RID: 29981 RVA: 0x00181839 File Offset: 0x0017FA39
	private BabelTowerHardLevelRoleItem InitRoleItem()
	{
		return new BabelTowerHardLevelRoleItem();
	}

	// Token: 0x0600751E RID: 29982 RVA: 0x00181840 File Offset: 0x0017FA40
	public void DisableButton()
	{
		base.GetButton(11).RootUIComp.Get().SetUIActive(false);
		base.GetItem(12).SetUIActive(false);
	}

	// Token: 0x0600751F RID: 29983 RVA: 0x00181878 File Offset: 0x0017FA78
	public void PlayLoopSequence()
	{
		if (this.LevelPlayer.IsPlayingSequence("Loop_item"))
		{
			this.LevelPlayer.ReplaySequenceByKey("Loop_item");
			return;
		}
		this.LevelPlayer.PlayLevelSequenceByName("Loop_item", false, null, false);
	}

	// Token: 0x06007520 RID: 29984 RVA: 0x001818C3 File Offset: 0x0017FAC3
	public void StopLoopSequence()
	{
		this.LevelPlayer.StopCurrentSequence(false, true);
	}

	// Token: 0x06007521 RID: 29985 RVA: 0x001818D2 File Offset: 0x0017FAD2
	public bool IsPlayingSequence()
	{
		return this.LevelPlayer.IsPlayingSequence("Loop_item");
	}

	// Token: 0x040035D1 RID: 13777
	private bool IsUnlock;

	// Token: 0x040035D2 RID: 13778
	private bool RedDotHaveBind;

	// Token: 0x040035D3 RID: 13779
	private int LevelId;

	// Token: 0x040035D4 RID: 13780
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<BabelTowerHardLevelRoleItem, int> RoleLayout;

	// Token: 0x040035D5 RID: 13781
	[Nullable(2)]
	public Action<int> OnClickButtonCallBack;

	// Token: 0x040035D6 RID: 13782
	[Nullable(2)]
	private LevelSequencePlayer LevelPlayer;

	// Token: 0x02007722 RID: 30498
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040274BD RID: 160957
		public const int Button = 0;

		// Token: 0x040274BE RID: 160958
		public const int BgTexture = 1;

		// Token: 0x040274BF RID: 160959
		public const int IndexText = 2;

		// Token: 0x040274C0 RID: 160960
		public const int NameText = 3;

		// Token: 0x040274C1 RID: 160961
		public const int TimeText = 4;

		// Token: 0x040274C2 RID: 160962
		public const int DoneItem = 5;

		// Token: 0x040274C3 RID: 160963
		public const int NoneItem = 6;

		// Token: 0x040274C4 RID: 160964
		public const int StarText = 7;

		// Token: 0x040274C5 RID: 160965
		public const int RoleLayout = 8;

		// Token: 0x040274C6 RID: 160966
		public const int BuffItem1 = 9;

		// Token: 0x040274C7 RID: 160967
		public const int BuffItem2 = 10;

		// Token: 0x040274C8 RID: 160968
		public const int ResetBtn = 11;

		// Token: 0x040274C9 RID: 160969
		public const int GoItem = 12;

		// Token: 0x040274CA RID: 160970
		public const int LockItem = 13;

		// Token: 0x040274CB RID: 160971
		public const int OptionText = 14;

		// Token: 0x040274CC RID: 160972
		public const int BuffTexture1 = 15;

		// Token: 0x040274CD RID: 160973
		public const int BuffTexture2 = 16;

		// Token: 0x040274CE RID: 160974
		public const int RedDotItem = 17;

		// Token: 0x040274CF RID: 160975
		public const int TimeItem = 18;

		// Token: 0x040274D0 RID: 160976
		public const int FinishedItem = 19;
	}
}
