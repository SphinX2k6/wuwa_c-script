using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F22 RID: 7970
public class ShipTowerCoverView : UiViewBase
{
	// Token: 0x06013BB0 RID: 80816 RVA: 0x005C1BF8 File Offset: 0x005BFDF8
	[NullableContext(1)]
	public ShipTowerCoverView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013BB1 RID: 80817 RVA: 0x005C1C04 File Offset: 0x005BFE04
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

	// Token: 0x06013BB2 RID: 80818 RVA: 0x005C1C90 File Offset: 0x005BFE90
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerCoverView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerCoverView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013BB3 RID: 80819 RVA: 0x005C1CD4 File Offset: 0x005BFED4
	protected override void OnBeforeShow()
	{
		ShipTowerStageData stageData = (this.OpenParam as ShipTowerCoverViewParams).StageData;
		this.LeftItem.UpdateData(stageData, false);
		this.RightItem.UpdateData(stageData, true);
	}

	// Token: 0x06013BB4 RID: 80820 RVA: 0x005C1D0C File Offset: 0x005BFF0C
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

	// Token: 0x06013BB5 RID: 80821 RVA: 0x005C1D2C File Offset: 0x005BFF2C
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

	// Token: 0x0400A8AB RID: 43179
	[Nullable(2)]
	private ShipTowerCoverItem LeftItem;

	// Token: 0x0400A8AC RID: 43180
	[Nullable(2)]
	private ShipTowerCoverItem RightItem;

	// Token: 0x0400A8AD RID: 43181
	private bool SureCover;

	// Token: 0x020081FD RID: 33277
	private enum EChildType
	{
		// Token: 0x04029FA6 RID: 171942
		ItemLeft,
		// Token: 0x04029FA7 RID: 171943
		ItemRight,
		// Token: 0x04029FA8 RID: 171944
		TxtTitle
	}
}
