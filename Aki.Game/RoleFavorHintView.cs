using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002864 RID: 10340
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorHintView : UiTickViewBase
{
	// Token: 0x060154AA RID: 87210 RVA: 0x005603CE File Offset: 0x0055E5CE
	public RoleFavorHintView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060154AB RID: 87211 RVA: 0x005603E2 File Offset: 0x0055E5E2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout))
		};
	}

	// Token: 0x060154AC RID: 87212 RVA: 0x0056041C File Offset: 0x0055E61C
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

	// Token: 0x060154AD RID: 87213 RVA: 0x0056050C File Offset: 0x0055E70C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<RoleFavorHintData>>(EEventName.UpdateRoleFavorHintView, new Action<IReadOnlyList<RoleFavorHintData>>(this.UpdateRoleFavorHintView));
	}

	// Token: 0x060154AE RID: 87214 RVA: 0x0056052A File Offset: 0x0055E72A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateRoleFavorHintView, new Action<IReadOnlyList<RoleFavorHintData>>(this.UpdateRoleFavorHintView));
	}

	// Token: 0x060154AF RID: 87215 RVA: 0x00560548 File Offset: 0x0055E748
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

	// Token: 0x060154B0 RID: 87216 RVA: 0x0056064C File Offset: 0x0055E84C
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

	// Token: 0x060154B1 RID: 87217 RVA: 0x0056077C File Offset: 0x0055E97C
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

	// Token: 0x060154B2 RID: 87218 RVA: 0x005607AA File Offset: 0x0055E9AA
	private void OnSequenceFinishCallBack()
	{
		this.FinishSequenceItemCount--;
		if (this.FinishSequenceItemCount == 0)
		{
			UiManager.Instance.CloseView(EUiViewName.RoleFavorHintView, null);
		}
	}

	// Token: 0x04009F0A RID: 40714
	private List<RoleFavorHintData> RoleFavorHintDataList = new List<RoleFavorHintData>();

	// Token: 0x04009F0B RID: 40715
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<RoleFavorHintItem> VerticalLayout;

	// Token: 0x04009F0C RID: 40716
	private int FinishSequenceItemCount;

	// Token: 0x02008E87 RID: 36487
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402E39D RID: 189341
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static TLayoutRefresh<RoleFavorHintItem> <0>__InitFavorExpItem;
	}
}
