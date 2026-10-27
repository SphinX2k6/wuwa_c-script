using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001179 RID: 4473
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerNormalLevelChoseItem : GridProxyAbstract<BabelActivityLevelInfo>
{
	// Token: 0x06007634 RID: 30260 RVA: 0x001885A0 File Offset: 0x001867A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007635 RID: 30261 RVA: 0x00188772 File Offset: 0x00186972
	protected override void OnStart()
	{
		this.LevelPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06007636 RID: 30262 RVA: 0x00188788 File Offset: 0x00186988
	[NullableContext(1)]
	public override void Refresh(BabelActivityLevelInfo data, bool isSelected, int gridIndex)
	{
		base.GetText(1).SetText((gridIndex + 1).ToString() ?? "", true);
		this.LevelId = data.LevelsId;
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(data.LevelsId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), babelTowerLevelConfig.NameText, Array.Empty<object>());
		if (!StringUtils.IsEmpty(babelTowerLevelConfig.DesText))
		{
			base.GetText(10).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), babelTowerLevelConfig.DesText, Array.Empty<object>());
		}
		else
		{
			base.GetText(10).SetUIActive(false);
		}
		base.SetTextureByPath(babelTowerLevelConfig.Texture, base.GetTexture(4), null, null);
		base.GetItem(3).SetUIActive(data.IsFinished && data.PassStar >= babelTowerLevelConfig.PassStar);
		long num = MathUtils.Instance.LongToNumber(data.UnlockTime);
		this.IsUnlock = ((double)num <= TimeUtil.Instance.GetServerTimeStamp());
		base.GetItem(7).SetUIActive(this.IsUnlock);
		base.GetItem(8).SetUIActive(!this.IsUnlock);
		if (this.IsUnlock)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "BabelTowerLevelGoto", Array.Empty<object>());
		}
		else
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(((double)num - TimeUtil.Instance.GetServerTimeStamp()) * TimeUtil.Instance.Millisecond);
			base.GetText(9).SetText(remainTimeDataFormat.CountDownText ?? "", true);
		}
		if (!this.RedDotHaveBind)
		{
			this.RedDotHaveBind = true;
		}
		else
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevel, base.GetItem(6), this.LevelId);
		}
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerNewLevel, base.GetItem(6), null, this.LevelId);
		if (BabelTowerModel.Instance.LevelChoseHandle == this.LevelId)
		{
			this.PlayLoopSequence();
			return;
		}
		this.StopLoopSequence();
	}

	// Token: 0x06007637 RID: 30263 RVA: 0x001889A0 File Offset: 0x00186BA0
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevel, base.GetItem(6), this.LevelId);
	}

	// Token: 0x06007638 RID: 30264 RVA: 0x001889BE File Offset: 0x00186BBE
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

	// Token: 0x06007639 RID: 30265 RVA: 0x001889EC File Offset: 0x00186BEC
	public void PlayLoopSequence()
	{
		if (this.LevelPlayer.IsPlayingSequence("Loop_Diffculty"))
		{
			this.LevelPlayer.ReplaySequenceByKey("Loop_Diffculty");
			return;
		}
		this.LevelPlayer.PlayLevelSequenceByName("Loop_Diffculty", false, null, false);
	}

	// Token: 0x0600763A RID: 30266 RVA: 0x00188A37 File Offset: 0x00186C37
	public void StopLoopSequence()
	{
		this.LevelPlayer.StopCurrentSequence(false, true);
	}

	// Token: 0x0600763B RID: 30267 RVA: 0x00188A46 File Offset: 0x00186C46
	public bool IsPlayingSequence()
	{
		return this.LevelPlayer.IsPlayingSequence("Loop_Diffculty");
	}

	// Token: 0x04003634 RID: 13876
	private bool IsUnlock;

	// Token: 0x04003635 RID: 13877
	private bool RedDotHaveBind;

	// Token: 0x04003636 RID: 13878
	private int LevelId;

	// Token: 0x04003637 RID: 13879
	public Action<int> OnClickButtonCallBack;

	// Token: 0x04003638 RID: 13880
	private LevelSequencePlayer LevelPlayer;

	// Token: 0x0200774A RID: 30538
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040275A0 RID: 161184
		public const int Button = 0;

		// Token: 0x040275A1 RID: 161185
		public const int IndexText = 1;

		// Token: 0x040275A2 RID: 161186
		public const int NameText = 2;

		// Token: 0x040275A3 RID: 161187
		public const int DoneItem = 3;

		// Token: 0x040275A4 RID: 161188
		public const int BgTexture = 4;

		// Token: 0x040275A5 RID: 161189
		public const int OptionText = 5;

		// Token: 0x040275A6 RID: 161190
		public const int RedDotItem = 6;

		// Token: 0x040275A7 RID: 161191
		public const int GoItem = 7;

		// Token: 0x040275A8 RID: 161192
		public const int LockItem = 8;

		// Token: 0x040275A9 RID: 161193
		public const int LockText = 9;

		// Token: 0x040275AA RID: 161194
		public const int NameDesText = 10;
	}
}
