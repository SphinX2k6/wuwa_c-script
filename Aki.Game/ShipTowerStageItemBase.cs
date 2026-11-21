using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F50 RID: 8016
public class ShipTowerStageItemBase : UiPanelBase
{
	// Token: 0x06013D16 RID: 81174 RVA: 0x005C7EAC File Offset: 0x005C60AC
	[NullableContext(1)]
	public UniTask Init(UUIItem item, int data)
	{
		ShipTowerStageItemBase.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.data = data;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerStageItemBase.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06013D17 RID: 81175 RVA: 0x005C7F00 File Offset: 0x005C6100
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnEnter))
		};
	}

	// Token: 0x06013D18 RID: 81176 RVA: 0x005C7F68 File Offset: 0x005C6168
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerStageItemBase.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerStageItemBase.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D19 RID: 81177 RVA: 0x005C7FAB File Offset: 0x005C61AB
	public void UpdateData()
	{
		this.StageItem.UpdateData();
	}

	// Token: 0x06013D1A RID: 81178 RVA: 0x005C7FB8 File Offset: 0x005C61B8
	protected void OnClickBtnEnter()
	{
		ShipTowerStageData stageDataById = ShipTowerModel.Instance.GetStageDataById(this.ItemDataId);
		if (stageDataById == null)
		{
			return;
		}
		stageDataById.OpenViewStageDesc();
	}

	// Token: 0x06013D1B RID: 81179 RVA: 0x005C7FD4 File Offset: 0x005C61D4
	public void SetClickEnable(bool enable)
	{
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(enable);
	}

	// Token: 0x0400A91E RID: 43294
	[Nullable(2)]
	protected ShipTowerStageItem StageItem;

	// Token: 0x0400A91F RID: 43295
	protected int ItemDataId;

	// Token: 0x02008247 RID: 33351
	private static class EChildTypeBase
	{
		// Token: 0x0402A108 RID: 172296
		public const int ItemBase = 0;

		// Token: 0x0402A109 RID: 172297
		public const int BtnEnter = 1;
	}
}
