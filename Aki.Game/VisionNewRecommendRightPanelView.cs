using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020019CD RID: 6605
[NullableContext(1)]
[Nullable(0)]
public class VisionNewRecommendRightPanelView : UiPanelBase
{
	// Token: 0x060104A4 RID: 66724 RVA: 0x004C1C6C File Offset: 0x004BFE6C
	public VisionNewRecommendRightPanelView(VisionNewRecommendProxy proxy)
	{
		this.Proxy = proxy;
		this.Proxy.RefreshSelectedRecommendDetail = new Action<Action>(this.RefreshSelectedRecommendDetail);
	}

	// Token: 0x060104A5 RID: 66725 RVA: 0x004C1CA0 File Offset: 0x004BFEA0
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

	// Token: 0x060104A6 RID: 66726 RVA: 0x004C1DB9 File Offset: 0x004BFFB9
	protected override void OnStart()
	{
		this.InitAllLayouts();
	}

	// Token: 0x060104A7 RID: 66727 RVA: 0x004C1DC4 File Offset: 0x004BFFC4
	private void InitAllLayouts()
	{
		this.FetterDescLayout = new GenericScrollViewNew<VisionNewRecommendFetterDescItem, VisionNewRecommendFetterDescItemData>(base.GetScrollViewWithScrollbar(1), new Func<VisionNewRecommendFetterDescItem>(this.InitFetterDescItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		this.FirstVisionLayout = new GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData>(base.GetLayoutBase(3), new Func<VisionNewRecommendVisionView>(this.InitVisionItem), null, false, true);
	}

	// Token: 0x060104A8 RID: 66728 RVA: 0x004C1E23 File Offset: 0x004C0023
	private VisionNewRecommendVisionView InitVisionItem()
	{
		return new VisionNewRecommendVisionView
		{
			OnSelectedCallback = new Action<int, VisionNewRecommendVisionItemData>(this.OnVisionItemSelected)
		};
	}

	// Token: 0x060104A9 RID: 66729 RVA: 0x004C1E3C File Offset: 0x004C003C
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

	// Token: 0x060104AA RID: 66730 RVA: 0x004C1EC4 File Offset: 0x004C00C4
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

	// Token: 0x060104AB RID: 66731 RVA: 0x004C1F88 File Offset: 0x004C0188
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
		int num = 2;
		List<MainPhantomRecommendInfo> mainPhantomList = currentSelectRecommendInfo.GetMainPhantomList();
		List<MainPhantomRecommendInfo> list = new List<MainPhantomRecommendInfo>();
		int num2 = 0;
		while (num2 < mainPhantomList.Count && num2 < num)
		{
			list.Add(mainPhantomList[num2]);
			num2++;
		}
		List<VisionNewRecommendVisionItemData> list2 = new List<VisionNewRecommendVisionItemData>();
		foreach (MainPhantomRecommendInfo mainPhantomRecommendInfo in list)
		{
			int monsterId = mainPhantomRecommendInfo.GetMonsterId();
			IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(monsterId);
			PhantomItem? phantomItem = (phantomItemByMonsterId != null && phantomItemByMonsterId.Count > 0) ? new PhantomItem?(phantomItemByMonsterId[0]) : null;
			int rareId = (phantomItem != null) ? phantomItem.GetValueOrDefault().Rarity : 0;
			PhantomRarity? phantomRareConfig = PhantomBattleConfig.Instance.GetPhantomRareConfig(rareId);
			int cost = (phantomRareConfig != null) ? phantomRareConfig.Value.Cost : 0;
			list2.Add(new VisionNewRecommendVisionItemData
			{
				VisionMonsterId = monsterId,
				FetterGroupId = mainPhantomRecommendInfo.GetFetterGroupId(),
				Cost = cost,
				Obtained = PhantomBattleModel.Instance.GetIfHasMonsterInInventory(monsterId),
				Usage = mainPhantomRecommendInfo.GetUsage()
			});
		}
		GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData> firstVisionLayout = this.FirstVisionLayout;
		if (firstVisionLayout == null)
		{
			return;
		}
		firstVisionLayout.RefreshByData(list2, delegate
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

	// Token: 0x060104AC RID: 66732 RVA: 0x004C2200 File Offset: 0x004C0400
	private VisionNewRecommendFetterDescItem InitFetterDescItem()
	{
		VisionNewRecommendFetterDescItem visionNewRecommendFetterDescItem = new VisionNewRecommendFetterDescItem();
		visionNewRecommendFetterDescItem.SetSimpleMode(this.Proxy.IsSimpleMode);
		return visionNewRecommendFetterDescItem;
	}

	// Token: 0x060104AD RID: 66733 RVA: 0x004C2218 File Offset: 0x004C0418
	public void RefreshSimpleMode()
	{
		GenericScrollViewNew<VisionNewRecommendFetterDescItem, VisionNewRecommendFetterDescItemData> fetterDescLayout = this.FetterDescLayout;
		foreach (VisionNewRecommendFetterDescItem visionNewRecommendFetterDescItem in (((fetterDescLayout != null) ? fetterDescLayout.GetScrollItemList() : null) ?? new List<VisionNewRecommendFetterDescItem>()))
		{
			visionNewRecommendFetterDescItem.SetSimpleMode(this.Proxy.IsSimpleMode);
		}
		this.RefreshSkillDesc();
	}

	// Token: 0x060104AE RID: 66734 RVA: 0x004C2290 File Offset: 0x004C0490
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

	// Token: 0x060104AF RID: 66735 RVA: 0x004C22EA File Offset: 0x004C04EA
	private void OnClickTrackBtn()
	{
		CalabashController.Instance.JumpToCalabashCollectTabView(this.Proxy.CurrentSelectFirstVisionMonsterId);
	}

	// Token: 0x04009040 RID: 36928
	private readonly VisionNewRecommendProxy Proxy;

	// Token: 0x04009041 RID: 36929
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<VisionNewRecommendFetterDescItem, VisionNewRecommendFetterDescItemData> FetterDescLayout;

	// Token: 0x04009042 RID: 36930
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionNewRecommendVisionView, VisionNewRecommendVisionItemData> FirstVisionLayout;

	// Token: 0x04009043 RID: 36931
	private readonly List<VisionNewRecommendFetterDescItemData> FetterDataList = new List<VisionNewRecommendFetterDescItemData>();

	// Token: 0x04009044 RID: 36932
	private int CurrentSkillId;

	// Token: 0x02007BFE RID: 31742
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402827B RID: 164475
		GuideBtn,
		// Token: 0x0402827C RID: 164476
		FetterScroll,
		// Token: 0x0402827D RID: 164477
		FetterItem,
		// Token: 0x0402827E RID: 164478
		FirstVisionLayout,
		// Token: 0x0402827F RID: 164479
		FirstVisionItem,
		// Token: 0x04028280 RID: 164480
		VisionName,
		// Token: 0x04028281 RID: 164481
		TrackBtn,
		// Token: 0x04028282 RID: 164482
		VisionSkillScroll,
		// Token: 0x04028283 RID: 164483
		VisionSkillDesc
	}
}
