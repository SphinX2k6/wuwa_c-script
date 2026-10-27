using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001184 RID: 4484
public class BabelTowerResetView : UiViewBase
{
	// Token: 0x06007697 RID: 30359 RVA: 0x0018ABAA File Offset: 0x00188DAA
	[NullableContext(1)]
	public BabelTowerResetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007698 RID: 30360 RVA: 0x0018ABB4 File Offset: 0x00188DB4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickCancelBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007699 RID: 30361 RVA: 0x0018ACA0 File Offset: 0x00188EA0
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerResetView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerResetView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600769A RID: 30362 RVA: 0x0018ACE3 File Offset: 0x00188EE3
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600769B RID: 30363 RVA: 0x0018ACEC File Offset: 0x00188EEC
	private void OnClickConfirmBtn()
	{
		BabelTowerController.Instance.ResetBabelTowerLevelRequest(this.LevelId);
		base.CloseMe(null);
	}

	// Token: 0x0400366A RID: 13930
	private int LevelId;

	// Token: 0x0200775E RID: 30558
	private class EComponentDefine
	{
		// Token: 0x04027600 RID: 161280
		public const int LevelItem = 0;

		// Token: 0x04027601 RID: 161281
		public const int CancelBtn = 1;

		// Token: 0x04027602 RID: 161282
		public const int ConfirmBtn = 2;
	}
}
