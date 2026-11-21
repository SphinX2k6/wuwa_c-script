using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D0E RID: 7438
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerVisionDetailInfoPanel
{
	// Token: 0x060126A2 RID: 75426 RVA: 0x0057123F File Offset: 0x0056F43F
	public RoleTowerVisionDetailInfoPanel(UUIItem actor)
	{
		this.Host = actor;
	}

	// Token: 0x060126A3 RID: 75427 RVA: 0x00571250 File Offset: 0x0056F450
	public UniTask Init()
	{
		RoleTowerVisionDetailInfoPanel.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<RoleTowerVisionDetailInfoPanel.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060126A4 RID: 75428 RVA: 0x00571293 File Offset: 0x0056F493
	public void SetActive(bool active)
	{
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.SetActive(active);
	}

	// Token: 0x060126A5 RID: 75429 RVA: 0x005712A8 File Offset: 0x0056F4A8
	public void Refresh(PhantomBattleData phantom, int roleId)
	{
		ItemTipsData itemTipsData = RoleTowerVisionDetailInfoPanel.BuildTipsData(phantom, roleId);
		if (itemTipsData == null)
		{
			return;
		}
		ItemTipsComponentContentComponent content = this.Content;
		if (content == null)
		{
			return;
		}
		content.Refresh(itemTipsData);
	}

	// Token: 0x060126A6 RID: 75430 RVA: 0x005712D4 File Offset: 0x0056F4D4
	public UniTask RefreshAsync(PhantomBattleData phantom, int roleId)
	{
		RoleTowerVisionDetailInfoPanel.<RefreshAsync>d__6 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.phantom = phantom;
		<RefreshAsync>d__.roleId = roleId;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleTowerVisionDetailInfoPanel.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060126A7 RID: 75431 RVA: 0x00571328 File Offset: 0x0056F528
	[return: Nullable(2)]
	private static ItemTipsData BuildTipsData(PhantomBattleData phantom, int roleId)
	{
		int uniqueId = phantom.GetUniqueId();
		ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(phantom.GetConfigId(false), (uniqueId > 0) ? new int?(uniqueId) : null, null);
		TipsVisionData tipsVisionData = tipsDataById as TipsVisionData;
		if (tipsVisionData == null || tipsVisionData.AttributeData == null)
		{
			return tipsDataById;
		}
		int querySubPropExtraRate = RoleTowerModel.Instance.GetQuerySubPropExtraRate(roleId);
		if (querySubPropExtraRate != 0)
		{
			foreach (ITipsAttributeItemData tipsAttributeItemData in tipsVisionData.AttributeData)
			{
				if (!tipsAttributeItemData.IsMainAttribute)
				{
					tipsAttributeItemData.Value = tipsAttributeItemData.Value * (double)(10000 + querySubPropExtraRate) / 10000.0;
				}
			}
		}
		RoleTowerVisionDetailInfoPanel.ClearAttrHighlight(tipsVisionData.AttributeData);
		return tipsVisionData;
	}

	// Token: 0x060126A8 RID: 75432 RVA: 0x005713DC File Offset: 0x0056F5DC
	private static void ClearAttrHighlight(ITipsAttributeItemData[] attrs)
	{
		for (int i = 0; i < attrs.Length; i++)
		{
			attrs[i].IsMainAttribute = false;
		}
	}

	// Token: 0x0400A06B RID: 41067
	private readonly UUIItem Host;

	// Token: 0x0400A06C RID: 41068
	[Nullable(2)]
	private ItemTipsComponentContentComponent Content;
}
