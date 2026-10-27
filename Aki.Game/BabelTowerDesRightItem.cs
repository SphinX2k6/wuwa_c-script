using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001153 RID: 4435
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerDesRightItem : UiPanelBase
{
	// Token: 0x06007479 RID: 29817 RVA: 0x0017D7F0 File Offset: 0x0017B9F0
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

	// Token: 0x0600747A RID: 29818 RVA: 0x0017D898 File Offset: 0x0017BA98
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

	// Token: 0x0600747B RID: 29819 RVA: 0x0017DA6A File Offset: 0x0017BC6A
	protected override void OnStart()
	{
		this.BuffScrollView = new GenericScrollViewNew<DesRightBuffGridItem, int>(base.GetScrollViewWithScrollbar(2), new Func<DesRightBuffGridItem>(this.InitBuffItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, null);
	}

	// Token: 0x0600747C RID: 29820 RVA: 0x0017DA9D File Offset: 0x0017BC9D
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

	// Token: 0x0600747D RID: 29821 RVA: 0x0017DAC0 File Offset: 0x0017BCC0
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

	// Token: 0x0600747E RID: 29822 RVA: 0x0017DB3C File Offset: 0x0017BD3C
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

	// Token: 0x0600747F RID: 29823 RVA: 0x0017DC08 File Offset: 0x0017BE08
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

	// Token: 0x06007480 RID: 29824 RVA: 0x0017DCA4 File Offset: 0x0017BEA4
	private void SetTipInfoText(string text)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Babelstar_xueliang", new <>z__ReadOnlySingleElementList<object>(text));
	}

	// Token: 0x06007481 RID: 29825 RVA: 0x0017DCC4 File Offset: 0x0017BEC4
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

	// Token: 0x06007482 RID: 29826 RVA: 0x0017DCFC File Offset: 0x0017BEFC
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

	// Token: 0x06007483 RID: 29827 RVA: 0x0017DDAC File Offset: 0x0017BFAC
	public void SetStarNum(int starNum)
	{
		UUIArtText artText = base.GetArtText(4);
		if (artText != null)
		{
			artText.SetText(((starNum < 10) ? "0" : "") + starNum.ToString());
		}
	}

	// Token: 0x06007484 RID: 29828 RVA: 0x0017DDE8 File Offset: 0x0017BFE8
	public void SetMaxRecordText(int starNum)
	{
		UUIText text = base.GetText(7);
		if (text != null)
		{
			text.SetText(starNum.ToString() ?? "", true);
		}
	}

	// Token: 0x06007485 RID: 29829 RVA: 0x0017DE17 File Offset: 0x0017C017
	public void SetColorBg(FColor color)
	{
		UUITexture texture = base.GetTexture(5);
		if (texture == null)
		{
			return;
		}
		texture.SetColor(color);
	}

	// Token: 0x06007486 RID: 29830 RVA: 0x0017DE2B File Offset: 0x0017C02B
	public void SetDifficultyText(string textKey)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textKey, Array.Empty<object>());
	}

	// Token: 0x06007487 RID: 29831 RVA: 0x0017DE44 File Offset: 0x0017C044
	private void SetDeBuffItemNum(int count)
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "BabelLoad_Quantity", new <>z__ReadOnlySingleElementList<object>(count));
		}
	}

	// Token: 0x06007488 RID: 29832 RVA: 0x0017DE77 File Offset: 0x0017C077
	private void OnClickGoBtnHandler()
	{
		Action onClickGoBtn = this.OnClickGoBtn;
		if (onClickGoBtn == null)
		{
			return;
		}
		onClickGoBtn();
	}

	// Token: 0x0400359F RID: 13727
	[Nullable(2)]
	public Action OnClickGoBtn;

	// Token: 0x040035A0 RID: 13728
	[Nullable(2)]
	public Action<int> OnBuffClick;

	// Token: 0x040035A1 RID: 13729
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<DesRightBuffGridItem, int> BuffScrollView;

	// Token: 0x040035A2 RID: 13730
	private Dictionary<int, int> MonstMaxLifeAddRatioMap = new Dictionary<int, int>();

	// Token: 0x0200770B RID: 30475
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402745A RID: 160858
		public const int ItemNumText = 0;

		// Token: 0x0402745B RID: 160859
		public const int EmptyTextTips = 1;

		// Token: 0x0402745C RID: 160860
		public const int LoopScrollView = 2;

		// Token: 0x0402745D RID: 160861
		public const int BuffInfoItem = 3;

		// Token: 0x0402745E RID: 160862
		public const int BuffLevelTextArt = 4;

		// Token: 0x0402745F RID: 160863
		public const int TexBgColor = 5;

		// Token: 0x04027460 RID: 160864
		public const int TxtDiffTitle = 6;

		// Token: 0x04027461 RID: 160865
		public const int TxtBestStar = 7;

		// Token: 0x04027462 RID: 160866
		public const int BtnConfirmB = 8;

		// Token: 0x04027463 RID: 160867
		public const int BottomTips = 9;

		// Token: 0x04027464 RID: 160868
		public const int TxtTipInfo = 10;
	}
}
