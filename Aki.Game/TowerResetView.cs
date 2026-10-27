using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C01 RID: 11265
public class TowerResetView : UiViewBase
{
	// Token: 0x0601765F RID: 95839 RVA: 0x005F5067 File Offset: 0x005F3267
	[NullableContext(1)]
	public TowerResetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017660 RID: 95840 RVA: 0x005F5078 File Offset: 0x005F3278
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCancelButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickConfirmButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017661 RID: 95841 RVA: 0x005F51A4 File Offset: 0x005F33A4
	protected override void OnStart()
	{
		this.InitView();
	}

	// Token: 0x06017662 RID: 95842 RVA: 0x005F51AC File Offset: 0x005F33AC
	protected override void OnBeforeDestroy()
	{
		this.RoleLayout = null;
	}

	// Token: 0x06017663 RID: 95843 RVA: 0x005F51B8 File Offset: 0x005F33B8
	private void InitView()
	{
		this.TowerId = (int)this.OpenParam;
		TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(this.TowerId);
		if (floorData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CycleTower;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "重置爬塔成绩时，无法获取到爬塔数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TowerId", this.TowerId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.RoleLayout = new GenericLayout<TowerResetItem, int>(base.GetVerticalLayout(0), new Func<TowerResetItem>(this.RefreshItem), null, false, true);
		List<int> list = new List<int>();
		foreach (TowerRolePb towerRolePb in floorData.Formation)
		{
			list.Add(towerRolePb.RoleId);
		}
		this.RoleLayout.RefreshByData(list, null, false);
		int difficultyStars = TowerModel.Instance.GetDifficultyStars(floorData.Difficulties);
		base.GetText(1).SetText(difficultyStars.ToString(), true);
		base.GetText(2).SetText((difficultyStars - floorData.Star).ToString(), true);
	}

	// Token: 0x06017664 RID: 95844 RVA: 0x005F52E4 File Offset: 0x005F34E4
	[NullableContext(1)]
	private TowerResetItem RefreshItem()
	{
		return new TowerResetItem();
	}

	// Token: 0x06017665 RID: 95845 RVA: 0x005F52EB File Offset: 0x005F34EB
	private void OnClickCancelButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06017666 RID: 95846 RVA: 0x005F52F4 File Offset: 0x005F34F4
	private void OnClickConfirmButton()
	{
		TowerController.Instance.TowerResetRequest(this.TowerId);
		base.CloseMe(null);
	}

	// Token: 0x0400AF0A RID: 44810
	private int TowerId = -1;

	// Token: 0x0400AF0B RID: 44811
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerResetItem, int> RoleLayout;

	// Token: 0x020091C8 RID: 37320
	private enum EChildType
	{
		// Token: 0x0402F2B7 RID: 193207
		RoleLayout,
		// Token: 0x0402F2B8 RID: 193208
		CurrentStarText,
		// Token: 0x0402F2B9 RID: 193209
		ChangeToStarText,
		// Token: 0x0402F2BA RID: 193210
		CancelButton,
		// Token: 0x0402F2BB RID: 193211
		ConfirmButton
	}
}
