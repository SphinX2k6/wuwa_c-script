using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020024E6 RID: 9446
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendRightPanelView : UiPanelBase
{
	// Token: 0x06012FE5 RID: 77797 RVA: 0x004B40D4 File Offset: 0x004B22D4
	public VisionNewRecommendRightPanelView(VisionNewRecommendProxy proxy)
	{
		this.Proxy = proxy;
		this.Proxy.RefreshSelectedRecommendDetail = new Action<Action>(this.RefreshSelectedRecommendDetail);
	}

	// Token: 0x06012FE6 RID: 77798 RVA: 0x004B4108 File Offset: 0x004B2308
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickGuideBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickTrackBtn))
		};
	}

	// Token: 0x06012FE7 RID: 77799 RVA: 0x004B4221 File Offset: 0x004B2421
	protected override void OnStart()
	{
		this.InitAllLayouts();
	}

	// Token: 0x06012FE8 RID: 77800 RVA: 0x004B422C File Offset: 0x004B242C
	private void InitAllLayouts()
	{
		this.FetterDescLayout = new GenericScrollViewNew<VisionNewRecommendFetterDescItem, VisionNewRecommendFetterDescItemData>(base.GetScrollViewWithScrollbar(1), new Func<VisionNewRecommendFetterDescItem>(this.InitFetterDescItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		this.FirstVisionLayout = new GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData>(base.GetLayoutBase(3), new Func<VisionNewRecommendVisionView>(this.InitVisionItem), null, false, true);
	}

	// Token: 0x06012FE9 RID: 77801 RVA: 0x004B428B File Offset: 0x004B248B
	private VisionNewRecommendVisionView InitVisionItem()
	{
		return new VisionNewRecommendVisionView
		{
			OnSelectedCallback = new Action<int, VisionNewRecommendVisionItemData>(this.OnVisionItemSelected)
		};
	}

	// Token: 0x06012FEA RID: 77802 RVA: 0x004B42A4 File Offset: 0x004B24A4
	private void OnVisionItemSelected(int index, VisionNewRecommendVisionItemData data)
	{
		IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(data.VisionMonsterId);
		if (phantomItemByMonsterId == null || phantomItemByMonsterId.Count == 0)
		{
			return;
		}
		PhantomItem phantomItem = phantomItemByMonsterId[0];
		GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData> firstVisionLayout = this.FirstVisionLayout;
		if (firstVisionLayout != null)
		{
			firstVisionLayout.SelectGridProxy(index, false);
		}
		this.Proxy.CurrentSelectFirstVisionMonsterId = data.VisionMonsterId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), phantomItem.MonsterName, Array.Empty<object>());
		this.CurrentSkillId = phantomItem.SkillId;
		this.RefreshSkillDesc();
	}

	// Token: 0x06012FEB RID: 77803 RVA: 0x004B432C File Offset: 0x004B252C
	private void RefreshSkillDesc()
	{
		if (this.CurrentSkillId == 0)
		{
			return;
		}
		UUIText text = base.GetText(8);
		PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(this.CurrentSkillId);
		if (this.Proxy.IsSimpleMode)
		{
			if (!StringUtils.IsEmpty((phantomSkillBySkillId != null) ? phantomSkillBySkillId.GetValueOrDefault().SimplyDescription : null))
			{
				LguiUtil.Instance.SetLocalTextNew(text, phantomSkillBySkillId.Value.SimplyDescription, Array.Empty<object>());
				return;
			}
			if (text != null)
			{
				text.SetText("", true);
				return;
			}
		}
		else
		{
			string[] phantomSkillDescExBySkillIdAndQuality = PhantomBattleConfig.Instance.GetPhantomSkillDescExBySkillIdAndQuality(phantomSkillBySkillId.Value.Id, 2);
			LguiUtil.Instance.SetLocalTextNew(text, phantomSkillBySkillId.Value.DescriptionEx, phantomSkillDescExBySkillIdAndQuality);
		}
	}

	// Token: 0x06012FEC RID: 77804 RVA: 0x004B43F0 File Offset: 0x004B25F0
	[NullableContext(2)]
	private void RefreshSelectedRecommendDetail(Action callback = null)
	{
		VisionFetterRecommendInfo currentSelectRecommendInfo = this.Proxy.GetCurrentSelectRecommendInfo();
		if (currentSelectRecommendInfo == null)
		{
			return;
		}
		this.FetterDataList.Clear();
		foreach (IVisionFetterCount fetterData in currentSelectRecommendInfo.GetFetterCountList())
		{
			this.FetterDataList.Add(new VisionNewRecommendFetterDescItemData
			{
				FetterData = fetterData,
				IsNeedLine = false
			});
		}
		this.FetterDataList.Sort(delegate(VisionNewRecommendFetterDescItemData a, VisionNewRecommendFetterDescItemData b)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(a.FetterData.GroupId);
			PhantomFetterGroup fetterGroupById2 = PhantomBattleConfig.Instance.GetFetterGroupById(b.FetterData.GroupId);
			if (fetterGroupById.FetterType != fetterGroupById2.FetterType)
			{
				return fetterGroupById2.FetterType - fetterGroupById.FetterType;
			}
			return b.FetterData.GroupId - a.FetterData.GroupId;
		});
		for (int i = 0; i < this.FetterDataList.Count; i++)
		{
			this.FetterDataList[i].IsNeedLine = (i < this.FetterDataList.Count - 1);
		}
		GenericScrollViewNew<VisionNewRecommendFetterDescItem, VisionNewRecommendFetterDescItemData> fetterDescLayout = this.FetterDescLayout;
		if (fetterDescLayout != null)
		{
			fetterDescLayout.RefreshByData(this.FetterDataList, null, false);
		}
		int count = 2;
		List<VisionNewRecommendVisionItemData> data = currentSelectRecommendInfo.GetMainPhantomList().Take(count).ToList<MainPhantomRecommendInfo>().Select(delegate(MainPhantomRecommendInfo info)
		{
			int monsterId = info.GetMonsterId();
			IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId);
			PhantomItem? phantomItem = (phantomItemByMonsterId != null && phantomItemByMonsterId.Count > 0) ? new PhantomItem?(phantomItemByMonsterId[0]) : null;
			int rareId = (phantomItem != null) ? phantomItem.GetValueOrDefault().Rarity : 0;
			PhantomRarity? phantomRareConfig = PhantomBattleConfig.Instance.GetPhantomRareConfig(rareId);
			int cost = (phantomRareConfig != null) ? phantomRareConfig.Value.Cost : 0;
			return new VisionNewRecommendVisionItemData
			{
				VisionMonsterId = monsterId,
				FetterGroupId = info.GetFetterGroupId(),
				Cost = cost,
				Obtained = PhantomBattleModel.Instance.GetIfHasMonsterInInventory(monsterId),
				Usage = info.GetUsage()
			};
		}).ToList<VisionNewRecommendVisionItemData>();
		GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData> firstVisionLayout = this.FirstVisionLayout;
		if (firstVisionLayout == null)
		{
			return;
		}
		firstVisionLayout.RefreshByData(data, delegate
		{
			if (this.Proxy.IsFromRoleDevFirstSelect)
			{
				GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData> firstVisionLayout2 = this.FirstVisionLayout;
				if (firstVisionLayout2 != null)
				{
					firstVisionLayout2.SelectGridProxyByKey(this.Proxy.GetSelectedFirstVisionMonsterIdCallBack(this.Proxy.CurrentSelectRoleId), true);
				}
				this.Proxy.IsFromRoleDevFirstSelect = false;
				return;
			}
			GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData> firstVisionLayout3 = this.FirstVisionLayout;
			if (firstVisionLayout3 == null)
			{
				return;
			}
			firstVisionLayout3.SelectGridProxy(0, true);
		}, false);
	}

	// Token: 0x06012FED RID: 77805 RVA: 0x004B4554 File Offset: 0x004B2754
	private VisionNewRecommendFetterDescItem InitFetterDescItem()
	{
		VisionNewRecommendFetterDescItem visionNewRecommendFetterDescItem = new VisionNewRecommendFetterDescItem();
		visionNewRecommendFetterDescItem.SetSimpleMode(this.Proxy.IsSimpleMode);
		return visionNewRecommendFetterDescItem;
	}

	// Token: 0x06012FEE RID: 77806 RVA: 0x004B456C File Offset: 0x004B276C
	public void RefreshSimpleMode()
	{
		GenericScrollViewNew<VisionNewRecommendFetterDescItem, VisionNewRecommendFetterDescItemData> fetterDescLayout = this.FetterDescLayout;
		foreach (VisionNewRecommendFetterDescItem visionNewRecommendFetterDescItem in (((fetterDescLayout != null) ? fetterDescLayout.GetScrollItemList() : null) ?? new List<VisionNewRecommendFetterDescItem>()))
		{
			visionNewRecommendFetterDescItem.SetSimpleMode(this.Proxy.IsSimpleMode);
		}
		this.RefreshSkillDesc();
	}

	// Token: 0x06012FEF RID: 77807 RVA: 0x004B45E4 File Offset: 0x004B27E4
	private void OnClickGuideBtn()
	{
		VisionFetterRecommendInfo currentSelectRecommendInfo = this.Proxy.GetCurrentSelectRecommendInfo();
		if (currentSelectRecommendInfo == null)
		{
			return;
		}
		bool showFastFilter = RoleModel.Instance.IsRoleOwned(this.Proxy.CurrentSelectRoleId);
		PhantomBattleController.Instance.OpenPhantomBattleFetterView(currentSelectRecommendInfo.GetRecommendFetterGroupId(), this.Proxy.CurrentSelectRoleId, showFastFilter, currentSelectRecommendInfo.BuildFetterList()).Forget();
	}

	// Token: 0x06012FF0 RID: 77808 RVA: 0x004B463E File Offset: 0x004B283E
	private void OnClickTrackBtn()
	{
		CalabashController.Instance.JumpToCalabashCollectTabView(this.Proxy.CurrentSelectFirstVisionMonsterId);
	}

	// Token: 0x04008EF6 RID: 36598
	private readonly VisionNewRecommendProxy Proxy;

	// Token: 0x04008EF7 RID: 36599
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<VisionNewRecommendFetterDescItem, VisionNewRecommendFetterDescItemData> FetterDescLayout;

	// Token: 0x04008EF8 RID: 36600
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData> FirstVisionLayout;

	// Token: 0x04008EF9 RID: 36601
	private readonly List<VisionNewRecommendFetterDescItemData> FetterDataList = new List<VisionNewRecommendFetterDescItemData>();

	// Token: 0x04008EFA RID: 36602
	private int CurrentSkillId;

	// Token: 0x02008A76 RID: 35446
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CF62 RID: 184162
		GuideBtn,
		// Token: 0x0402CF63 RID: 184163
		FetterScroll,
		// Token: 0x0402CF64 RID: 184164
		FetterItem,
		// Token: 0x0402CF65 RID: 184165
		FirstVisionLayout,
		// Token: 0x0402CF66 RID: 184166
		FirstVisionItem,
		// Token: 0x0402CF67 RID: 184167
		VisionName,
		// Token: 0x0402CF68 RID: 184168
		TrackBtn,
		// Token: 0x0402CF69 RID: 184169
		VisionSkillScroll,
		// Token: 0x0402CF6A RID: 184170
		VisionSkillDesc
	}
}
