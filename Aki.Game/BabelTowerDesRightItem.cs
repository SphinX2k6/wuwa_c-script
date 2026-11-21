using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000607 RID: 1543
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerDesRightItem : UiPanelBase
{
	// Token: 0x06004810 RID: 18448 RVA: 0x0018633C File Offset: 0x0018453C
	public void SetLevelId(int levelId)
	{
		BabelTowerLevel? config = ConfigBabelTowerLevelById.GetConfig(levelId, true);
		if (config != null)
		{
			BabelTowerLevel valueOrDefault = config.GetValueOrDefault();
			this.MonstMaxLifeAddRatioMap = new Dictionary<int, int>();
			for (int i = 0; i < valueOrDefault.MonstMaxLifeAddRatioLength; i++)
			{
				DicIntInt? dicIntInt = valueOrDefault.MonstMaxLifeAddRatio(i);
				if (dicIntInt != null)
				{
					DicIntInt valueOrDefault2 = dicIntInt.GetValueOrDefault();
					this.MonstMaxLifeAddRatioMap[valueOrDefault2.Key] = valueOrDefault2.Value;
				}
			}
		}
		else
		{
			this.MonstMaxLifeAddRatioMap = new Dictionary<int, int>();
		}
		if (this.MonstMaxLifeAddRatioMap.Count <= 0)
		{
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x001863E4 File Offset: 0x001845E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickGoBtnHandler));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004812 RID: 18450 RVA: 0x001865B6 File Offset: 0x001847B6
	protected override void OnStart()
	{
		this.BuffScrollView = new GenericScrollViewNew<DesRightBuffGridItem, int>(base.GetScrollViewWithScrollbar(2), new Func<DesRightBuffGridItem>(this.InitBuffItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, null);
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x001865E9 File Offset: 0x001847E9
	private DesRightBuffGridItem InitBuffItem()
	{
		return new DesRightBuffGridItem
		{
			SkipDestroyActor = true,
			OnClickCallBack = delegate(int deTermId)
			{
				Action<int> onBuffClick = this.OnBuffClick;
				if (onBuffClick == null)
				{
					return;
				}
				onBuffClick(deTermId);
			}
		};
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x0018660C File Offset: 0x0018480C
	public void RefreshBuffList(int scrollToDeTermId = 0)
	{
		List<int> list = this.BuildDeTermIdList();
		GenericScrollViewNew<DesRightBuffGridItem, int> buffScrollView = this.BuffScrollView;
		UUIItem item;
		if (buffScrollView != null)
		{
			buffScrollView.RefreshByData(list, delegate
			{
				if (scrollToDeTermId > 0)
				{
					using (List<DesRightBuffGridItem>.Enumerator enumerator = this.BuffScrollView.GetScrollItemList().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							DesRightBuffGridItem item = enumerator.Current;
							if (item.DeTermId == scrollToDeTermId)
							{
								this.BuffScrollView.LateScrollTo(item.GetRootItem(), delegate
								{
									item.PlayStartSequence();
								}, false);
								break;
							}
						}
					}
				}
			}, false);
		}
		int count = list.Count;
		this.SetDeBuffItemNum(count);
		item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(list.Count <= 0);
		}
		this.UpdateTipInfo(list);
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x00186688 File Offset: 0x00184888
	private void UpdateTipInfo(List<int> deTermIdList)
	{
		if (deTermIdList.Count <= 0)
		{
			this.SetTipInfoText("");
			return;
		}
		int num = 0;
		foreach (int p0Id in deTermIdList)
		{
			BabelTowerDeTerm? config = ConfigBabelTowerDeTermById.GetConfig(p0Id, true);
			if (config != null)
			{
				num += config.GetValueOrDefault().Star;
			}
		}
		int? ratioValue = this.GetRatioValue(num);
		if (ratioValue != null)
		{
			this.SetTipInfoText(((float)ratioValue.Value / 100f + 100f).ToString() ?? "");
			return;
		}
		this.SetTipInfoText("");
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x00186754 File Offset: 0x00184954
	private int? GetRatioValue(int starNum)
	{
		int value;
		if (this.MonstMaxLifeAddRatioMap.TryGetValue(starNum, out value))
		{
			return new int?(value);
		}
		int num = int.MinValue;
		foreach (int num2 in this.MonstMaxLifeAddRatioMap.Keys)
		{
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (num != -2147483648 && starNum > num)
		{
			return new int?(this.MonstMaxLifeAddRatioMap[num]);
		}
		return null;
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x001867F0 File Offset: 0x001849F0
	private void SetTipInfoText(string text)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Babelstar_xueliang", new <>z__ReadOnlySingleElementList<object>(text));
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x00186810 File Offset: 0x00184A10
	public void ScrollToDeTerm(int deTermId)
	{
		if (this.BuffScrollView == null || deTermId == 0)
		{
			return;
		}
		int num = this.BuildDeTermIdList().IndexOf(deTermId);
		if (num >= 0)
		{
			this.BuffScrollView.ScrollToTopByIndex(num);
		}
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x00186848 File Offset: 0x00184A48
	private List<int> BuildDeTermIdList()
	{
		Dictionary<int, IBabelTowerSelectInfo> map = BabelTowerModel.Instance.DeTermSelectInfo;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in map)
		{
			int key = keyValuePair.Key;
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (key != 0 && (value.State == EBabelTowerDeTermState.Select || value.State == EBabelTowerDeTermState.StaticSelect))
			{
				list.Add(key);
			}
		}
		list.Sort(delegate(int a, int b)
		{
			IBabelTowerSelectInfo valueOrDefault = map.GetValueOrDefault(a);
			IBabelTowerSelectInfo valueOrDefault2 = map.GetValueOrDefault(b);
			if (valueOrDefault == null || valueOrDefault2 == null)
			{
				return 0;
			}
			return valueOrDefault2.SelectIndex - valueOrDefault.SelectIndex;
		});
		return list;
	}

	// Token: 0x0600481A RID: 18458 RVA: 0x001868F8 File Offset: 0x00184AF8
	public void SetStarNum(int starNum)
	{
		UUIArtText artText = base.GetArtText(4);
		if (artText != null)
		{
			artText.SetText(((starNum < 10) ? "0" : "") + starNum.ToString());
		}
	}

	// Token: 0x0600481B RID: 18459 RVA: 0x00186934 File Offset: 0x00184B34
	public void SetMaxRecordText(int starNum)
	{
		UUIText text = base.GetText(7);
		if (text != null)
		{
			text.SetText(starNum.ToString() ?? "", true);
		}
	}

	// Token: 0x0600481C RID: 18460 RVA: 0x00186963 File Offset: 0x00184B63
	public void SetColorBg(FColor color)
	{
		UUITexture texture = base.GetTexture(5);
		if (texture == null)
		{
			return;
		}
		texture.SetColor(color);
	}

	// Token: 0x0600481D RID: 18461 RVA: 0x00186977 File Offset: 0x00184B77
	public void SetDifficultyText(string textKey)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textKey, Array.Empty<object>());
	}

	// Token: 0x0600481E RID: 18462 RVA: 0x00186990 File Offset: 0x00184B90
	private void SetDeBuffItemNum(int count)
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "BabelLoad_Quantity", new <>z__ReadOnlySingleElementList<object>(count));
		}
	}

	// Token: 0x0600481F RID: 18463 RVA: 0x001869C3 File Offset: 0x00184BC3
	private void OnClickGoBtnHandler()
	{
		Action onClickGoBtn = this.OnClickGoBtn;
		if (onClickGoBtn == null)
		{
			return;
		}
		onClickGoBtn();
	}

	// Token: 0x04003638 RID: 13880
	[Nullable(2)]
	public Action OnClickGoBtn;

	// Token: 0x04003639 RID: 13881
	[Nullable(2)]
	public Action<int> OnBuffClick;

	// Token: 0x0400363A RID: 13882
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<DesRightBuffGridItem, int> BuffScrollView;

	// Token: 0x0400363B RID: 13883
	private Dictionary<int, int> MonstMaxLifeAddRatioMap = new Dictionary<int, int>();

	// Token: 0x0200689A RID: 26778
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402279B RID: 141211
		public const int ItemNumText = 0;

		// Token: 0x0402279C RID: 141212
		public const int EmptyTextTips = 1;

		// Token: 0x0402279D RID: 141213
		public const int LoopScrollView = 2;

		// Token: 0x0402279E RID: 141214
		public const int BuffInfoItem = 3;

		// Token: 0x0402279F RID: 141215
		public const int BuffLevelTextArt = 4;

		// Token: 0x040227A0 RID: 141216
		public const int TexBgColor = 5;

		// Token: 0x040227A1 RID: 141217
		public const int TxtDiffTitle = 6;

		// Token: 0x040227A2 RID: 141218
		public const int TxtBestStar = 7;

		// Token: 0x040227A3 RID: 141219
		public const int BtnConfirmB = 8;

		// Token: 0x040227A4 RID: 141220
		public const int BottomTips = 9;

		// Token: 0x040227A5 RID: 141221
		public const int TxtTipInfo = 10;
	}
}
