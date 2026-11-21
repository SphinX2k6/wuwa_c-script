using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DE9 RID: 7657
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorLockComponent : RoleFavorViewComponentBase
{
	// Token: 0x06012ED7 RID: 77527 RVA: 0x0058C3CC File Offset: 0x0058A5CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06012ED8 RID: 77528 RVA: 0x0058C468 File Offset: 0x0058A668
	protected override void OnStart()
	{
		this.GenericLayout = new GenericLayout<RoleFavorLockItem, RoleFavorLockItemData>(base.GetVerticalLayout(0), new Func<RoleFavorLockItem>(this.CreateLockItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06012ED9 RID: 77529 RVA: 0x0058C49B File Offset: 0x0058A69B
	protected override void OnBeforeDestroy()
	{
		this.ClearGenericLayout();
		this.RoleFavorLockItemData = new List<RoleFavorLockItemData>();
	}

	// Token: 0x06012EDA RID: 77530 RVA: 0x0058C4AE File Offset: 0x0058A6AE
	protected override void OnSetData(RoleFavorContentDataBase contentData)
	{
		this.RoleFavorLockItemData = new List<RoleFavorLockItemData>();
	}

	// Token: 0x06012EDB RID: 77531 RVA: 0x0058C4BB File Offset: 0x0058A6BB
	protected override void OnRefreshView()
	{
		this.SetTitleText();
		this.SetTipsText();
		this.SetConditionDesc();
	}

	// Token: 0x06012EDC RID: 77532 RVA: 0x0058C4CF File Offset: 0x0058A6CF
	private void ClearGenericLayout()
	{
		if (this.GenericLayout != null)
		{
			this.GenericLayout.ClearChildren();
			this.GenericLayout = null;
		}
	}

	// Token: 0x06012EDD RID: 77533 RVA: 0x0058C4EB File Offset: 0x0058A6EB
	private void SetConditionDesc()
	{
		this.RoleFavorLockItemData = this.GetRoleFavorLockItemData();
		GenericLayout<RoleFavorLockItem, RoleFavorLockItemData> genericLayout = this.GenericLayout;
		if (genericLayout == null)
		{
			return;
		}
		genericLayout.RefreshByData(this.RoleFavorLockItemData, null, false);
	}

	// Token: 0x06012EDE RID: 77534 RVA: 0x0058C511 File Offset: 0x0058A711
	private RoleFavorLockItem CreateLockItem()
	{
		return new RoleFavorLockItem();
	}

	// Token: 0x06012EDF RID: 77535 RVA: 0x0058C518 File Offset: 0x0058A718
	private void SetTitleText()
	{
		string titleTableId = this.GetTitleTableId();
		LguiUtil.Instance.SetLocalText(base.GetText(2), titleTableId, Array.Empty<object>());
	}

	// Token: 0x06012EE0 RID: 77536 RVA: 0x0058C544 File Offset: 0x0058A744
	private void SetTipsText()
	{
		UUIItem item = base.GetItem(4);
		UUIItem item2 = base.GetItem(3);
		if (this.ContentData != null && this.ContentData.FavorContentType == EFavorContentType.Action)
		{
			RoleFavorActionContentData roleFavorActionContentData = this.ContentData as RoleFavorActionContentData;
			if (roleFavorActionContentData != null && roleFavorActionContentData.FavorActionParamType == EFavorActionType.IdleAction)
			{
				if (item != null)
				{
					item.SetUIActive(true);
				}
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalText(base.GetText(1), "FavorUnlockNewIdleAction", Array.Empty<object>());
				return;
			}
		}
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
	}

	// Token: 0x06012EE1 RID: 77537 RVA: 0x0058C5D4 File Offset: 0x0058A7D4
	private string GetTitleTableId()
	{
		string result = "";
		if (this.ContentData == null)
		{
			return result;
		}
		switch (this.ContentData.FavorContentType)
		{
		case EFavorContentType.Voice:
			result = "FavorUnlockVoiceCondition";
			break;
		case EFavorContentType.ExperienceFile:
		case EFavorContentType.ExperienceStory:
			result = "FavorUnlockkStoryCondition";
			break;
		case EFavorContentType.Action:
			result = "FavorUnlockActionCondition";
			break;
		case EFavorContentType.PreciousItem:
			result = "FavorUnlockPreciousItemCondition";
			break;
		}
		return result;
	}

	// Token: 0x06012EE2 RID: 77538 RVA: 0x0058C638 File Offset: 0x0058A838
	private List<RoleFavorLockItemData> GetRoleFavorLockItemData()
	{
		List<RoleFavorLockItemData> result = new List<RoleFavorLockItemData>();
		if (this.ContentData == null)
		{
			return result;
		}
		int configId = this.ContentData.ConfigId;
		int configConGroupId = this.ContentData.ConfigConGroupId;
		return this.GetRoleFavorLockItemDataByConfig(configId, configConGroupId);
	}

	// Token: 0x06012EE3 RID: 77539 RVA: 0x0058C678 File Offset: 0x0058A878
	private List<RoleFavorLockItemData> GetRoleFavorLockItemDataByConfig(int id, int condGroupId)
	{
		List<RoleFavorLockItemData> list = new List<RoleFavorLockItemData>();
		if (this.ContentData == null)
		{
			return list;
		}
		int roleId = this.ContentData.RoleId;
		EFavorContentType favorContentType = this.ContentData.FavorContentType;
		ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(condGroupId);
		if (conditionGroupConfig == null)
		{
			return list;
		}
		int[] groupIdArray = conditionGroupConfig.Value.GetGroupIdArray();
		int num = groupIdArray.Length;
		for (int i = 0; i < num; i++)
		{
			int conditionId = groupIdArray[i];
			Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
			bool flag;
			if (favorContentType == EFavorContentType.Action)
			{
				flag = MotionModel.Instance.IsCondtionFinish(roleId, id, conditionId);
			}
			else
			{
				flag = RoleFavorConditionModel.Instance.IsConditionFinish(roleId, favorContentType, id, conditionId);
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(conditionConfig.Value.Description, null);
			list.Add(new RoleFavorLockItemData(!flag, localTextNew ?? ""));
		}
		return list;
	}

	// Token: 0x0400A31C RID: 41756
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleFavorLockItem, RoleFavorLockItemData> GenericLayout;

	// Token: 0x0400A31D RID: 41757
	private List<RoleFavorLockItemData> RoleFavorLockItemData = new List<RoleFavorLockItemData>();
}
