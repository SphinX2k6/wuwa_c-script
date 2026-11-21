using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000499 RID: 1177
[NullableContext(1)]
[Nullable(0)]
public class FurniturePresetView : UiViewBase
{
	// Token: 0x06003C0D RID: 15373 RVA: 0x00154905 File Offset: 0x00152B05
	public FurniturePresetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003C0E RID: 15374 RVA: 0x00154910 File Offset: 0x00152B10
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

	// Token: 0x06003C0F RID: 15375 RVA: 0x00154990 File Offset: 0x00152B90
	protected override UniTask OnBeforeStartAsync()
	{
		FurniturePresetView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurniturePresetView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003C10 RID: 15376 RVA: 0x001549D3 File Offset: 0x00152BD3
	private void OnClickApplyButton(FurnitureAreaData areaData)
	{
		this.ApplyFurniturePresetAsync();
	}

	// Token: 0x06003C11 RID: 15377 RVA: 0x001549DC File Offset: 0x00152BDC
	private UniTask ApplyFurniturePresetAsync()
	{
		FurniturePresetView.<ApplyFurniturePresetAsync>d__6 <ApplyFurniturePresetAsync>d__;
		<ApplyFurniturePresetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyFurniturePresetAsync>d__.<>4__this = this;
		<ApplyFurniturePresetAsync>d__.<>1__state = -1;
		<ApplyFurniturePresetAsync>d__.<>t__builder.Start<FurniturePresetView.<ApplyFurniturePresetAsync>d__6>(ref <ApplyFurniturePresetAsync>d__);
		return <ApplyFurniturePresetAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003C12 RID: 15378 RVA: 0x00154A1F File Offset: 0x00152C1F
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400305A RID: 12378
	[Nullable(2)]
	private FurniturePresetItem FurniturePresetItem;

	// Token: 0x0400305B RID: 12379
	private bool IsApplying;
}
