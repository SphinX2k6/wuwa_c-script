using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029A7 RID: 10663
public class ShipTowerCoverView : UiViewBase
{
	// Token: 0x060161AA RID: 90538 RVA: 0x00596C38 File Offset: 0x00594E38
	[NullableContext(1)]
	public ShipTowerCoverView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060161AB RID: 90539 RVA: 0x00596C44 File Offset: 0x00594E44
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060161AC RID: 90540 RVA: 0x00596CD0 File Offset: 0x00594ED0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerCoverView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerCoverView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060161AD RID: 90541 RVA: 0x00596D14 File Offset: 0x00594F14
	protected override void OnBeforeShow()
	{
		ShipTowerStageData stageData = (this.OpenParam as ShipTowerCoverViewParams).StageData;
		this.LeftItem.UpdateData(stageData, false);
		this.RightItem.UpdateData(stageData, true);
	}

	// Token: 0x060161AE RID: 90542 RVA: 0x00596D4C File Offset: 0x00594F4C
	[NullableContext(1)]
	private void OnConfirmCallback(ShipTowerStageData data, bool isCover)
	{
		this.SureCover = isCover;
		if (isCover)
		{
			data.SureCoverChallenge().Forget();
		}
		base.CloseMe(null);
	}

	// Token: 0x060161AF RID: 90543 RVA: 0x00596D6C File Offset: 0x00594F6C
	protected override void OnBeforeDestroy()
	{
		if (!this.SureCover)
		{
			ShipTowerStageData stageData = (this.OpenParam as ShipTowerCoverViewParams).StageData;
			stageData.UpdateToEdit();
			ShipTowerModel.Instance.SetChallengeStageDataNull();
			EventSystem.Instance.Emit<int>(EEventName.ShipTowerStageUpdate, stageData.Id);
		}
	}

	// Token: 0x0400A4C1 RID: 42177
	[Nullable(2)]
	private ShipTowerCoverItem LeftItem;

	// Token: 0x0400A4C2 RID: 42178
	[Nullable(2)]
	private ShipTowerCoverItem RightItem;

	// Token: 0x0400A4C3 RID: 42179
	private bool SureCover;

	// Token: 0x02008FB4 RID: 36788
	private enum EChildType
	{
		// Token: 0x0402E8A7 RID: 190631
		ItemLeft,
		// Token: 0x0402E8A8 RID: 190632
		ItemRight,
		// Token: 0x0402E8A9 RID: 190633
		TxtTitle
	}
}
