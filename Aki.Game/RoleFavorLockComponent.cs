using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200286E RID: 10350
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorLockComponent : RoleFavorViewComponentBase
{
	// Token: 0x060154D9 RID: 87257 RVA: 0x00561670 File Offset: 0x0055F870
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

	// Token: 0x060154DA RID: 87258 RVA: 0x0056170C File Offset: 0x0055F90C
	protected override void OnStart()
	{
		this.GenericLayout = new GenericLayout<RoleFavorLockItem, RoleFavorLockItemData>(base.GetVerticalLayout(0), new Func<RoleFavorLockItem>(this.CreateLockItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060154DB RID: 87259 RVA: 0x0056173F File Offset: 0x0055F93F
	protected override void OnBeforeDestroy()
	{
		this.ClearGenericLayout();
		this.RoleFavorLockItemData = new List<RoleFavorLockItemData>();
	}

	// Token: 0x060154DC RID: 87260 RVA: 0x00561752 File Offset: 0x0055F952
	protected override void OnSetData(RoleFavorContentDataBase contentData)
	{
		this.RoleFavorLockItemData = new List<RoleFavorLockItemData>();
	}

	// Token: 0x060154DD RID: 87261 RVA: 0x0056175F File Offset: 0x0055F95F
	protected override void OnRefreshView()
	{
		this.SetTitleText();
		this.SetTipsText();
		this.SetConditionDesc();
	}

	// Token: 0x060154DE RID: 87262 RVA: 0x00561773 File Offset: 0x0055F973
	private void ClearGenericLayout()
	{
		if (this.GenericLayout != null)
		{
			this.GenericLayout.ClearChildren();
			this.GenericLayout = null;
		}
	}

	// Token: 0x060154DF RID: 87263 RVA: 0x0056178F File Offset: 0x0055F98F
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

	// Token: 0x060154E0 RID: 87264 RVA: 0x005617B5 File Offset: 0x0055F9B5
	private RoleFavorLockItem CreateLockItem()
	{
		return new RoleFavorLockItem();
	}

	// Token: 0x060154E1 RID: 87265 RVA: 0x005617BC File Offset: 0x0055F9BC
	private void SetTitleText()
	{
		string titleTableId = this.GetTitleTableId();
		LguiUtil.Instance.SetLocalText(base.GetText(2), titleTableId, Array.Empty<object>());
	}

	// Token: 0x060154E2 RID: 87266 RVA: 0x005617E8 File Offset: 0x0055F9E8
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

	// Token: 0x060154E3 RID: 87267 RVA: 0x00561878 File Offset: 0x0055FA78
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

	// Token: 0x060154E4 RID: 87268 RVA: 0x005618DC File Offset: 0x0055FADC
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

	// Token: 0x060154E5 RID: 87269 RVA: 0x0056191C File Offset: 0x0055FB1C
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

	// Token: 0x04009F33 RID: 40755
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleFavorLockItem, RoleFavorLockItemData> GenericLayout;

	// Token: 0x04009F34 RID: 40756
	private List<RoleFavorLockItemData> RoleFavorLockItemData = new List<RoleFavorLockItemData>();
}
