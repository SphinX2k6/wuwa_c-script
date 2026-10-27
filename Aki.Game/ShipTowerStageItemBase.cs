using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029D5 RID: 10709
public class ShipTowerStageItemBase : UiPanelBase
{
	// Token: 0x06016310 RID: 90896 RVA: 0x0059CEF4 File Offset: 0x0059B0F4
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

	// Token: 0x06016311 RID: 90897 RVA: 0x0059CF48 File Offset: 0x0059B148
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

	// Token: 0x06016312 RID: 90898 RVA: 0x0059CFB0 File Offset: 0x0059B1B0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerStageItemBase.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerStageItemBase.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016313 RID: 90899 RVA: 0x0059CFF3 File Offset: 0x0059B1F3
	public void UpdateData()
	{
		this.StageItem.UpdateData();
	}

	// Token: 0x06016314 RID: 90900 RVA: 0x0059D000 File Offset: 0x0059B200
	protected void OnClickBtnEnter()
	{
		ShipTowerStageData stageDataById = ShipTowerModel.Instance.GetStageDataById(this.ItemDataId);
		if (stageDataById == null)
		{
			return;
		}
		stageDataById.OpenViewStageDesc();
	}

	// Token: 0x06016315 RID: 90901 RVA: 0x0059D01C File Offset: 0x0059B21C
	public void SetClickEnable(bool enable)
	{
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(enable);
	}

	// Token: 0x0400A534 RID: 42292
	[Nullable(2)]
	protected ShipTowerStageItem StageItem;

	// Token: 0x0400A535 RID: 42293
	protected int ItemDataId;

	// Token: 0x02009000 RID: 36864
	private static class EChildTypeBase
	{
		// Token: 0x0402EA10 RID: 190992
		public const int ItemBase = 0;

		// Token: 0x0402EA11 RID: 190993
		public const int BtnEnter = 1;
	}
}
