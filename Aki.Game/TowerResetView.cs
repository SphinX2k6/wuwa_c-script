using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200217C RID: 8572
public class TowerResetView : UiViewBase
{
	// Token: 0x06015090 RID: 86160 RVA: 0x00621B8F File Offset: 0x0061FD8F
	[NullableContext(1)]
	public TowerResetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015091 RID: 86161 RVA: 0x00621BA0 File Offset: 0x0061FDA0
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

	// Token: 0x06015092 RID: 86162 RVA: 0x00621CCC File Offset: 0x0061FECC
	protected override void OnStart()
	{
		this.InitView();
	}

	// Token: 0x06015093 RID: 86163 RVA: 0x00621CD4 File Offset: 0x0061FED4
	protected override void OnBeforeDestroy()
	{
		this.RoleLayout = null;
	}

	// Token: 0x06015094 RID: 86164 RVA: 0x00621CE0 File Offset: 0x0061FEE0
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

	// Token: 0x06015095 RID: 86165 RVA: 0x00621E0C File Offset: 0x0062000C
	[NullableContext(1)]
	private TowerResetItem RefreshItem()
	{
		return new TowerResetItem();
	}

	// Token: 0x06015096 RID: 86166 RVA: 0x00621E13 File Offset: 0x00620013
	private void OnClickCancelButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015097 RID: 86167 RVA: 0x00621E1C File Offset: 0x0062001C
	private void OnClickConfirmButton()
	{
		TowerController.Instance.TowerResetRequest(this.TowerId);
		base.CloseMe(null);
	}

	// Token: 0x0400B30F RID: 45839
	private int TowerId = -1;

	// Token: 0x0400B310 RID: 45840
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerResetItem, int> RoleLayout;

	// Token: 0x0200840B RID: 33803
	private enum EChildType
	{
		// Token: 0x0402A9B8 RID: 174520
		RoleLayout,
		// Token: 0x0402A9B9 RID: 174521
		CurrentStarText,
		// Token: 0x0402A9BA RID: 174522
		ChangeToStarText,
		// Token: 0x0402A9BB RID: 174523
		CancelButton,
		// Token: 0x0402A9BC RID: 174524
		ConfirmButton
	}
}
