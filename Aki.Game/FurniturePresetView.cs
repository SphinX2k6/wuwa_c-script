using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000FE4 RID: 4068
[NullableContext(1)]
[Nullable(0)]
public class FurniturePresetView : UiViewBase
{
	// Token: 0x06006875 RID: 26741 RVA: 0x0014C041 File Offset: 0x0014A241
	public FurniturePresetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006876 RID: 26742 RVA: 0x0014C04C File Offset: 0x0014A24C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickCloseButton))
		};
	}

	// Token: 0x06006877 RID: 26743 RVA: 0x0014C0CC File Offset: 0x0014A2CC
	protected override UniTask OnBeforeStartAsync()
	{
		FurniturePresetView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurniturePresetView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006878 RID: 26744 RVA: 0x0014C10F File Offset: 0x0014A30F
	private void OnClickApplyButton(FurnitureAreaData areaData)
	{
		this.ApplyFurniturePresetAsync();
	}

	// Token: 0x06006879 RID: 26745 RVA: 0x0014C118 File Offset: 0x0014A318
	private UniTask ApplyFurniturePresetAsync()
	{
		FurniturePresetView.<ApplyFurniturePresetAsync>d__6 <ApplyFurniturePresetAsync>d__;
		<ApplyFurniturePresetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyFurniturePresetAsync>d__.<>4__this = this;
		<ApplyFurniturePresetAsync>d__.<>1__state = -1;
		<ApplyFurniturePresetAsync>d__.<>t__builder.Start<FurniturePresetView.<ApplyFurniturePresetAsync>d__6>(ref <ApplyFurniturePresetAsync>d__);
		return <ApplyFurniturePresetAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600687A RID: 26746 RVA: 0x0014C15B File Offset: 0x0014A35B
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x04002FC1 RID: 12225
	[Nullable(2)]
	private FurniturePresetItem FurniturePresetItem;

	// Token: 0x04002FC2 RID: 12226
	private bool IsApplying;
}
