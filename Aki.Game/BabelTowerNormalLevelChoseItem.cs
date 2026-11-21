using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200062D RID: 1581
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerNormalLevelChoseItem : GridProxyAbstract<BabelActivityLevelInfo>
{
	// Token: 0x060049CB RID: 18891 RVA: 0x00191150 File Offset: 0x0018F350
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

	// Token: 0x060049CC RID: 18892 RVA: 0x00191322 File Offset: 0x0018F522
	protected override void OnStart()
	{
		this.LevelPlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060049CD RID: 18893 RVA: 0x00191338 File Offset: 0x0018F538
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

	// Token: 0x060049CE RID: 18894 RVA: 0x00191550 File Offset: 0x0018F750
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerNewLevel, base.GetItem(6), this.LevelId);
	}

	// Token: 0x060049CF RID: 18895 RVA: 0x0019156E File Offset: 0x0018F76E
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

	// Token: 0x060049D0 RID: 18896 RVA: 0x0019159C File Offset: 0x0018F79C
	public void PlayLoopSequence()
	{
		if (this.LevelPlayer.IsPlayingSequence("Loop_Diffculty"))
		{
			this.LevelPlayer.ReplaySequenceByKey("Loop_Diffculty");
			return;
		}
		this.LevelPlayer.PlayLevelSequenceByName("Loop_Diffculty", false, null, false);
	}

	// Token: 0x060049D1 RID: 18897 RVA: 0x001915E7 File Offset: 0x0018F7E7
	public void StopLoopSequence()
	{
		this.LevelPlayer.StopCurrentSequence(false, true);
	}

	// Token: 0x060049D2 RID: 18898 RVA: 0x001915F6 File Offset: 0x0018F7F6
	public bool IsPlayingSequence()
	{
		return this.LevelPlayer.IsPlayingSequence("Loop_Diffculty");
	}

	// Token: 0x040036CD RID: 14029
	private bool IsUnlock;

	// Token: 0x040036CE RID: 14030
	private bool RedDotHaveBind;

	// Token: 0x040036CF RID: 14031
	private int LevelId;

	// Token: 0x040036D0 RID: 14032
	public Action<int> OnClickButtonCallBack;

	// Token: 0x040036D1 RID: 14033
	private LevelSequencePlayer LevelPlayer;

	// Token: 0x020068D7 RID: 26839
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040228D9 RID: 141529
		public const int Button = 0;

		// Token: 0x040228DA RID: 141530
		public const int IndexText = 1;

		// Token: 0x040228DB RID: 141531
		public const int NameText = 2;

		// Token: 0x040228DC RID: 141532
		public const int DoneItem = 3;

		// Token: 0x040228DD RID: 141533
		public const int BgTexture = 4;

		// Token: 0x040228DE RID: 141534
		public const int OptionText = 5;

		// Token: 0x040228DF RID: 141535
		public const int RedDotItem = 6;

		// Token: 0x040228E0 RID: 141536
		public const int GoItem = 7;

		// Token: 0x040228E1 RID: 141537
		public const int LockItem = 8;

		// Token: 0x040228E2 RID: 141538
		public const int LockText = 9;

		// Token: 0x040228E3 RID: 141539
		public const int NameDesText = 10;
	}
}
