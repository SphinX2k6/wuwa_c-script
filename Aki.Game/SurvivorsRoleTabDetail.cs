using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020A5 RID: 8357
public class SurvivorsRoleTabDetail : UiPanelBase
{
	// Token: 0x0601492E RID: 84270 RVA: 0x005FF060 File Offset: 0x005FD260
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickMoreBtn))
		};
	}

	// Token: 0x0601492F RID: 84271 RVA: 0x005FF10C File Offset: 0x005FD30C
	protected override void OnStart()
	{
		this.RoleVisionAttribute = new SurvivorsRoleVisionAttribute(base.GetItem(1));
		this.RoleVisionAttribute.Init();
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(3),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.SurvivorsRogue
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x06014930 RID: 84272 RVA: 0x005FF164 File Offset: 0x005FD364
	public void Refresh(int cfgId, bool playGridAnim = false, int showAttrNum = 4)
	{
		SurvivorsRole value = SurvivorsRogueConfig.Instance.GetSurvivorsRole(cfgId).Value;
		int trialRoleId = value.TrialRoleId;
		this.CurrentRoleId = cfgId;
		IEnumerable<int> recommendPropertyArray = value.GetRecommendPropertyArray();
		int[] propertyListArray = value.GetPropertyListArray();
		List<int> list = new List<int>(recommendPropertyArray);
		if (list.Count > showAttrNum)
		{
			list = list.GetRange(0, showAttrNum);
		}
		if (list.Count < showAttrNum)
		{
			foreach (int item in propertyListArray)
			{
				if (!list.Contains(item))
				{
					list.Add(item);
					if (list.Count == showAttrNum)
					{
						break;
					}
				}
			}
		}
		List<ISurvivorsAttributeUiData> roleDefaultAttributeList = SurvivorsRogueModel.Instance.GetRoleDefaultAttributeList(cfgId, list);
		SurvivorsRoleVisionAttribute roleVisionAttribute = this.RoleVisionAttribute;
		if (roleVisionAttribute != null)
		{
			roleVisionAttribute.Refresh(roleDefaultAttributeList, playGridAnim);
		}
		SurvivorsRoleEvolve value2 = SurvivorsRogueConfig.Instance.GetSurvivorsRoleDefaultEvolve(cfgId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value2.Describe, Array.Empty<object>());
		RoleInfo value3 = RoleConfig.Instance.GetRoleConfig(trialRoleId).Value;
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(value3.Name);
	}

	// Token: 0x06014931 RID: 84273 RVA: 0x005FF27B File Offset: 0x005FD47B
	public void RefreshFourAttr(int cfgId, bool playGridAnim = false)
	{
		this.Refresh(cfgId, playGridAnim, 4);
	}

	// Token: 0x06014932 RID: 84274 RVA: 0x005FF288 File Offset: 0x005FD488
	private void OnClickMoreBtn()
	{
		if (this.CurrentRoleId == 0)
		{
			return;
		}
		SurvivorsRole value = SurvivorsRogueConfig.Instance.GetSurvivorsRole(this.CurrentRoleId).Value;
		UiManager.Instance.OpenView(EUiViewName.SurvivorsAttributeDetailView, SurvivorsRogueModel.Instance.GetRoleDefaultAttributeList(this.CurrentRoleId, value.GetPropertyListArray()), null);
	}

	// Token: 0x0400AECB RID: 44747
	[Nullable(2)]
	private SurvivorsRoleVisionAttribute RoleVisionAttribute;

	// Token: 0x0400AECC RID: 44748
	private int CurrentRoleId;

	// Token: 0x0400AECD RID: 44749
	private const int DEFAULT_SHOW_ATTRIBUTE_NUM = 4;
}
