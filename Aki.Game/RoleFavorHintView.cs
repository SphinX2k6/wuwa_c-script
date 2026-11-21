using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DDF RID: 7647
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorHintView : UiTickViewBase
{
	// Token: 0x06012EA8 RID: 77480 RVA: 0x0058B12A File Offset: 0x0058932A
	public RoleFavorHintView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012EA9 RID: 77481 RVA: 0x0058B13E File Offset: 0x0058933E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout))
		};
	}

	// Token: 0x06012EAA RID: 77482 RVA: 0x0058B178 File Offset: 0x00589378
	protected override void OnStart()
	{
		this.RoleFavorHintDataList = ((this.OpenParam as List<RoleFavorHintData>) ?? new List<RoleFavorHintData>());
		this.RoleFavorHintDataList = this.CombineData(this.RoleFavorHintDataList);
		UUILayoutBase verticalLayout = base.GetVerticalLayout(1);
		TLayoutRefresh<RoleFavorHintItem> refreshFunction;
		if ((refreshFunction = RoleFavorHintView.<>O.<0>__InitFavorExpItem) == null)
		{
			refreshFunction = (RoleFavorHintView.<>O.<0>__InitFavorExpItem = new TLayoutRefresh<RoleFavorHintItem>(FavorExpItemFactory.InitFavorExpItem));
		}
		this.VerticalLayout = new GenericLayoutNew<RoleFavorHintItem>(verticalLayout, refreshFunction, null);
		this.VerticalLayout.RebuildLayoutByDataNew<RoleFavorHintData>(this.RoleFavorHintDataList, null);
		this.FinishSequenceItemCount = this.RoleFavorHintDataList.Count;
		foreach (KeyValuePair<object, RoleFavorHintItem> keyValuePair in this.VerticalLayout.GetLayoutItemMap())
		{
			keyValuePair.Value.SetSequenceFinishCallBack(new TOnSequenceFinishCallBack(this.OnSequenceFinishCallBack));
		}
	}

	// Token: 0x06012EAB RID: 77483 RVA: 0x0058B268 File Offset: 0x00589468
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<RoleFavorHintData>>(EEventName.UpdateRoleFavorHintView, new Action<IReadOnlyList<RoleFavorHintData>>(this.UpdateRoleFavorHintView));
	}

	// Token: 0x06012EAC RID: 77484 RVA: 0x0058B286 File Offset: 0x00589486
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateRoleFavorHintView, new Action<IReadOnlyList<RoleFavorHintData>>(this.UpdateRoleFavorHintView));
	}

	// Token: 0x06012EAD RID: 77485 RVA: 0x0058B2A4 File Offset: 0x005894A4
	private void UpdateRoleFavorHintView(IReadOnlyList<RoleFavorHintData> roleFavorHintData)
	{
		List<RoleFavorHintData> list = new List<RoleFavorHintData>(roleFavorHintData.Count);
		for (int i = 0; i < roleFavorHintData.Count; i++)
		{
			list.Add(roleFavorHintData[i]);
		}
		List<RoleFavorHintData> list2 = this.CombineData(list);
		int count = list2.Count;
		for (int j = 0; j < count; j++)
		{
			RoleFavorHintData item = list2[j];
			this.RoleFavorHintDataList.Add(item);
		}
		this.VerticalLayout.ClearChildren();
		this.VerticalLayout.RebuildLayoutByDataNew<RoleFavorHintData>(this.RoleFavorHintDataList, null);
		this.FinishSequenceItemCount = this.RoleFavorHintDataList.Count;
		foreach (KeyValuePair<object, RoleFavorHintItem> keyValuePair in this.VerticalLayout.GetLayoutItemMap())
		{
			keyValuePair.Value.SetSequenceFinishCallBack(new TOnSequenceFinishCallBack(this.OnSequenceFinishCallBack));
		}
	}

	// Token: 0x06012EAE RID: 77486 RVA: 0x0058B3A8 File Offset: 0x005895A8
	private List<RoleFavorHintData> CombineData(List<RoleFavorHintData> roleFavorHintData)
	{
		if (FormationModel.Instance.CurrentFormationData == null)
		{
			return roleFavorHintData;
		}
		List<int> roleIdList = FormationModel.Instance.CurrentFormationData.RoleIdList;
		if (roleIdList == null || roleIdList.Count == 0)
		{
			return roleFavorHintData;
		}
		int count = roleIdList.Count;
		HashSet<int> hashSet = new HashSet<int>();
		int num = 0;
		bool flag = true;
		RoleFavorHintData roleFavorHintData2 = null;
		for (int i = 0; i < count; i++)
		{
			int num2 = roleIdList[i];
			int count2 = roleFavorHintData.Count;
			bool flag2 = false;
			for (int j = 0; j < count2; j++)
			{
				RoleFavorHintData roleFavorHintData3 = roleFavorHintData[j];
				if (roleFavorHintData3.RoleConfig.Value.Id == num2)
				{
					if (num == 0)
					{
						num = roleFavorHintData3.Exp;
						flag2 = true;
						roleFavorHintData2 = roleFavorHintData3;
					}
					else
					{
						flag2 = (roleFavorHintData3.Exp == num);
					}
					hashSet.Add(j);
					break;
				}
			}
			if (!flag2)
			{
				flag = false;
			}
		}
		if (flag && roleFavorHintData2 != null)
		{
			int count3 = roleFavorHintData.Count;
			List<RoleFavorHintData> list = new List<RoleFavorHintData>();
			list.Add(roleFavorHintData2);
			for (int k = 0; k < count3; k++)
			{
				if (!hashSet.Contains(k))
				{
					RoleFavorHintData item = roleFavorHintData[k];
					list.Add(item);
				}
			}
			return list;
		}
		return roleFavorHintData;
	}

	// Token: 0x06012EAF RID: 77487 RVA: 0x0058B4D8 File Offset: 0x005896D8
	protected override void OnBeforeDestroy()
	{
		this.RoleFavorHintDataList.Clear();
		if (this.VerticalLayout != null)
		{
			this.VerticalLayout.ClearChildren();
			this.VerticalLayout = null;
		}
		this.FinishSequenceItemCount = 0;
	}

	// Token: 0x06012EB0 RID: 77488 RVA: 0x0058B506 File Offset: 0x00589706
	private void OnSequenceFinishCallBack()
	{
		this.FinishSequenceItemCount--;
		if (this.FinishSequenceItemCount == 0)
		{
			UiManager.Instance.CloseView(EUiViewName.RoleFavorHintView, null);
		}
	}

	// Token: 0x0400A2F3 RID: 41715
	private List<RoleFavorHintData> RoleFavorHintDataList = new List<RoleFavorHintData>();

	// Token: 0x0400A2F4 RID: 41716
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<RoleFavorHintItem> VerticalLayout;

	// Token: 0x0400A2F5 RID: 41717
	private int FinishSequenceItemCount;

	// Token: 0x020080CD RID: 32973
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04029A97 RID: 170647
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static TLayoutRefresh<RoleFavorHintItem> <0>__InitFavorExpItem;
	}
}
