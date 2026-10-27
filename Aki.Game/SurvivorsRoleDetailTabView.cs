using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B00 RID: 11008
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoleDetailTabView : UiPanelBase
{
	// Token: 0x06016E49 RID: 93769 RVA: 0x005CECBC File Offset: 0x005CCEBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
	}

	// Token: 0x06016E4A RID: 93770 RVA: 0x005CEDB4 File Offset: 0x005CCFB4
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRoleDetailTabView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRoleDetailTabView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016E4B RID: 93771 RVA: 0x005CEDF8 File Offset: 0x005CCFF8
	protected override void OnStart()
	{
		SurvivorsRoleGainData roleGainData = SurvivorsRogueModel.Instance.GainData.GetRoleGainData();
		int configId = roleGainData.ConfigId;
		int level = roleGainData.Data.Level;
		int currentEvolveId = roleGainData.GetCurrentEvolveId();
		TMap<EKSC_AttrType, int> attrs_ = KuroSimpleCombatController.Instance.CurSubModel.KscPlayerEntity.GetSkillComp().AttrSet_.Attrs_;
		this.RefreshRoleInfo(configId, level);
		this.RefreshRoleStatus((double)attrs_.Get(EKSC_AttrType.Life), (double)attrs_.Get(EKSC_AttrType.LifeMax), (double)attrs_.Get(EKSC_AttrType.Shield));
		this.RefreshAttributeList(configId, attrs_);
		this.RefreshSkillInfo(currentEvolveId);
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(9),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.SurvivorsRogue
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x06016E4C RID: 93772 RVA: 0x005CEEB4 File Offset: 0x005CD0B4
	private void RefreshRoleInfo(int survivorsRoleId, int level)
	{
		RoleCardItem roleCardItem = this.RoleCardItem;
		if (roleCardItem != null)
		{
			roleCardItem.RefreshBySurvivorRoleId(survivorsRoleId);
		}
		RoleCardItem roleCardItem2 = this.RoleCardItem;
		if (roleCardItem2 != null)
		{
			roleCardItem2.SetLevel(level);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x06016E4D RID: 93773 RVA: 0x005CEF08 File Offset: 0x005CD108
	private void RefreshRoleStatus(double hp, double maxHp, double dp)
	{
		double num = (maxHp != 0.0) ? (hp / maxHp) : 0.0;
		double num2 = (maxHp != 0.0) ? (dp / maxHp) : 0.0;
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			sprite.SetFillAmount((float)num);
		}
		UUISprite sprite2 = base.GetSprite(3);
		if (sprite2 != null)
		{
			sprite2.SetFillAmount((float)num2);
		}
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<double>(hp);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<double>(maxHp);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06016E4E RID: 93774 RVA: 0x005CEFB4 File Offset: 0x005CD1B4
	private void RefreshSkillInfo(int roleEvolveId)
	{
		SurvivorsRoleEvolve? survivorsRoleEvolve = SurvivorsRogueConfig.Instance.GetSurvivorsRoleEvolve(roleEvolveId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), survivorsRoleEvolve.Value.Describe, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), survivorsRoleEvolve.Value.EvolveName, Array.Empty<object>());
		base.SetTextureByPath(survivorsRoleEvolve.Value.Icon, base.GetTexture(7), null, null);
	}

	// Token: 0x06016E4F RID: 93775 RVA: 0x005CF040 File Offset: 0x005CD240
	private void RefreshAttributeList(int survivorsRoleId, TMap<EKSC_AttrType, int> attributeMap)
	{
		SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(survivorsRoleId);
		HashSet<int> hashSet = new HashSet<int>(survivorsRole.Value.GetRecommendPropertyArray());
		List<ISurvivorsAttributeUiData> list = new List<ISurvivorsAttributeUiData>();
		foreach (int num in survivorsRole.Value.GetPropertyListArray())
		{
			SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(num);
			double num2;
			if (propertyConfig.Value.IsSpecial)
			{
				num2 = (double)SurvivorsRogueModel.Instance.GainData.GetRoleSpecialPropertyValue(num);
			}
			else
			{
				num2 = (double)attributeMap.Get((EKSC_AttrType)num);
			}
			if (num2 != 0.0)
			{
				bool isBasePermyriad = propertyConfig.Value.IsBasePermyriad;
				SurvivorsAttributeUiData item = new SurvivorsAttributeUiData
				{
					AttrId = num,
					IsRecommend = hashSet.Contains(num),
					Value = (isBasePermyriad ? (num2 / 10000.0) : num2),
					IsAddition = new bool?(propertyConfig.Value.IsSpecial)
				};
				list.Add(item);
			}
		}
		list.Sort(delegate(ISurvivorsAttributeUiData a, ISurvivorsAttributeUiData b)
		{
			if (a.IsRecommend == b.IsRecommend)
			{
				return a.AttrId - b.AttrId;
			}
			if (!a.IsRecommend)
			{
				return 1;
			}
			return -1;
		});
		this.AttributeScrollView.RefreshByData(list, false, null, false);
	}

	// Token: 0x06016E50 RID: 93776 RVA: 0x005CF19F File Offset: 0x005CD39F
	private SurvivorsAttributeItem CreateGridProxy()
	{
		return new SurvivorsAttributeItem();
	}

	// Token: 0x0400AA01 RID: 43521
	[Nullable(2)]
	private RoleCardItem RoleCardItem;

	// Token: 0x0400AA02 RID: 43522
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsAttributeItem, ISurvivorsAttributeUiData> AttributeScrollView;
}
