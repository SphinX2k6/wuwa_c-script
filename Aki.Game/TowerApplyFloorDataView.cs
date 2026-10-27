using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002BDE RID: 11230
public class TowerApplyFloorDataView : UiViewBase
{
	// Token: 0x06017536 RID: 95542 RVA: 0x005EE084 File Offset: 0x005EC284
	[NullableContext(1)]
	public TowerApplyFloorDataView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017537 RID: 95543 RVA: 0x005EE090 File Offset: 0x005EC290
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickCancelButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickConfirmButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017538 RID: 95544 RVA: 0x005EE263 File Offset: 0x005EC463
	protected override void OnStart()
	{
		this.InitView();
	}

	// Token: 0x06017539 RID: 95545 RVA: 0x005EE26C File Offset: 0x005EC46C
	private void InitView()
	{
		TowerFloorInfo currentNotConfirmedFloor = TowerModel.Instance.CurrentNotConfirmedFloor;
		if (currentNotConfirmedFloor == null)
		{
			Log.Instance.Error(ELogModule.CycleTower, ELogAuthor.LJQ, "打开爬塔成绩确认框时失败，未能获取到新挑战数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(currentNotConfirmedFloor.TowerId);
		UUIItem item = base.GetItem(8);
		UUIItem item2 = base.GetItem(5);
		for (int i = 0; i < currentNotConfirmedFloor.Star; i++)
		{
			LguiUtil.Instance.DuplicateActor(item.GetOwner(), item2);
		}
		UUIItem item3 = base.GetItem(3);
		for (int j = 0; j < floorData.Star; j++)
		{
			LguiUtil.Instance.DuplicateActor(item.GetOwner(), item3);
		}
		item.SetUIActive(false);
		UUIItem item4 = base.GetItem(9);
		UUIItem item5 = base.GetItem(4);
		List<int> list = new List<int>();
		foreach (TowerRolePb towerRolePb in currentNotConfirmedFloor.Formation)
		{
			list.Add(towerRolePb.RoleId);
		}
		using (List<int>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				int role = enumerator2.Current;
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(item4, item5);
				TowerRoleComplexItem newRole = new TowerRoleComplexItem();
				newRole.CreateThenShowByActorAsync(uuiitem.GetOwner(), null, false).ContinueWith(delegate()
				{
					newRole.RefreshRoleId(role);
				});
			}
		}
		UUIItem item6 = base.GetItem(2);
		List<int> list2 = new List<int>();
		foreach (TowerRolePb towerRolePb2 in floorData.Formation)
		{
			list2.Add(towerRolePb2.RoleId);
		}
		using (List<int>.Enumerator enumerator2 = list2.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				int role = enumerator2.Current;
				UUIItem uuiitem2 = LguiUtil.Instance.CopyItem(item4, item6);
				TowerRoleComplexItem newRole = new TowerRoleComplexItem();
				newRole.CreateThenShowByActorAsync(uuiitem2.GetOwner(), null, false).ContinueWith(delegate()
				{
					newRole.RefreshRoleId(role);
				});
			}
		}
		item4.SetUIActive(false);
		string textStringId = "";
		if (currentNotConfirmedFloor.Difficulties == 1)
		{
			textStringId = "Text_LowRiskAreaFloor_Text";
		}
		else if (currentNotConfirmedFloor.Difficulties == 2)
		{
			textStringId = "Text_HighRiskAreaFloor_Text";
		}
		else if (currentNotConfirmedFloor.Difficulties == 3)
		{
			textStringId = "Text_VariationAreaFloor_Text";
		}
		else if (currentNotConfirmedFloor.Difficulties == 4)
		{
			textStringId = "Text_OverLockAreaFloor_Text";
		}
		string towerAreaName = TowerClimbConfig.Instance.GetTowerAreaName(currentNotConfirmedFloor.TowerId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlyArray<object>(new object[]
		{
			towerAreaName,
			currentNotConfirmedFloor.FloorNumber
		}));
	}

	// Token: 0x0601753A RID: 95546 RVA: 0x005EE598 File Offset: 0x005EC798
	protected override void OnBeforeDestroy()
	{
		TowerModel.Instance.ClearNotConfirmedData();
	}

	// Token: 0x0601753B RID: 95547 RVA: 0x005EE5A4 File Offset: 0x005EC7A4
	private void OnClickCancelButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601753C RID: 95548 RVA: 0x005EE5AD File Offset: 0x005EC7AD
	private void OnClickConfirmButton()
	{
		TowerController.Instance.TowerApplyFloorDataRequest(true);
		base.CloseMe(null);
	}

	// Token: 0x02009194 RID: 37268
	private enum EChildType
	{
		// Token: 0x0402F1B3 RID: 192947
		TitleText,
		// Token: 0x0402F1B4 RID: 192948
		DescriptionText,
		// Token: 0x0402F1B5 RID: 192949
		OldRoleItem,
		// Token: 0x0402F1B6 RID: 192950
		OldStarRootItem,
		// Token: 0x0402F1B7 RID: 192951
		NewRoleItem,
		// Token: 0x0402F1B8 RID: 192952
		NewStarRootItem,
		// Token: 0x0402F1B9 RID: 192953
		CancelButton,
		// Token: 0x0402F1BA RID: 192954
		ConfirmButton,
		// Token: 0x0402F1BB RID: 192955
		StarItem,
		// Token: 0x0402F1BC RID: 192956
		RoleItem
	}
}
