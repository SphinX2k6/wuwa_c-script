using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002159 RID: 8537
public class TowerApplyFloorDataView : UiViewBase
{
	// Token: 0x06014F67 RID: 85863 RVA: 0x0061ABC4 File Offset: 0x00618DC4
	[NullableContext(1)]
	public TowerApplyFloorDataView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014F68 RID: 85864 RVA: 0x0061ABD0 File Offset: 0x00618DD0
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

	// Token: 0x06014F69 RID: 85865 RVA: 0x0061ADA3 File Offset: 0x00618FA3
	protected override void OnStart()
	{
		this.InitView();
	}

	// Token: 0x06014F6A RID: 85866 RVA: 0x0061ADAC File Offset: 0x00618FAC
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

	// Token: 0x06014F6B RID: 85867 RVA: 0x0061B0D8 File Offset: 0x006192D8
	protected override void OnBeforeDestroy()
	{
		TowerModel.Instance.ClearNotConfirmedData();
	}

	// Token: 0x06014F6C RID: 85868 RVA: 0x0061B0E4 File Offset: 0x006192E4
	private void OnClickCancelButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014F6D RID: 85869 RVA: 0x0061B0ED File Offset: 0x006192ED
	private void OnClickConfirmButton()
	{
		TowerController.Instance.TowerApplyFloorDataRequest(true);
		base.CloseMe(null);
	}

	// Token: 0x020083D8 RID: 33752
	private enum EChildType
	{
		// Token: 0x0402A8B8 RID: 174264
		TitleText,
		// Token: 0x0402A8B9 RID: 174265
		DescriptionText,
		// Token: 0x0402A8BA RID: 174266
		OldRoleItem,
		// Token: 0x0402A8BB RID: 174267
		OldStarRootItem,
		// Token: 0x0402A8BC RID: 174268
		NewRoleItem,
		// Token: 0x0402A8BD RID: 174269
		NewStarRootItem,
		// Token: 0x0402A8BE RID: 174270
		CancelButton,
		// Token: 0x0402A8BF RID: 174271
		ConfirmButton,
		// Token: 0x0402A8C0 RID: 174272
		StarItem,
		// Token: 0x0402A8C1 RID: 174273
		RoleItem
	}
}
