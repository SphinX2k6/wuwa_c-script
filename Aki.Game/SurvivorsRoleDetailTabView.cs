using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200207C RID: 8316
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoleDetailTabView : UiPanelBase
{
	// Token: 0x0601487A RID: 84090 RVA: 0x005FB83C File Offset: 0x005F9A3C
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

	// Token: 0x0601487B RID: 84091 RVA: 0x005FB934 File Offset: 0x005F9B34
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRoleDetailTabView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRoleDetailTabView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601487C RID: 84092 RVA: 0x005FB978 File Offset: 0x005F9B78
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

	// Token: 0x0601487D RID: 84093 RVA: 0x005FBA34 File Offset: 0x005F9C34
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

	// Token: 0x0601487E RID: 84094 RVA: 0x005FBA88 File Offset: 0x005F9C88
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

	// Token: 0x0601487F RID: 84095 RVA: 0x005FBB34 File Offset: 0x005F9D34
	private void RefreshSkillInfo(int roleEvolveId)
	{
		SurvivorsRoleEvolve? survivorsRoleEvolve = SurvivorsRogueConfig.Instance.GetSurvivorsRoleEvolve(roleEvolveId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), survivorsRoleEvolve.Value.Describe, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), survivorsRoleEvolve.Value.EvolveName, Array.Empty<object>());
		base.SetTextureByPath(survivorsRoleEvolve.Value.Icon, base.GetTexture(7), null, null);
	}

	// Token: 0x06014880 RID: 84096 RVA: 0x005FBBC0 File Offset: 0x005F9DC0
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

	// Token: 0x06014881 RID: 84097 RVA: 0x005FBD1F File Offset: 0x005F9F1F
	private SurvivorsAttributeItem CreateGridProxy()
	{
		return new SurvivorsAttributeItem();
	}

	// Token: 0x0400AE07 RID: 44551
	[Nullable(2)]
	private RoleCardItem RoleCardItem;

	// Token: 0x0400AE08 RID: 44552
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<SurvivorsAttributeItem, ISurvivorsAttributeUiData> AttributeScrollView;
}
