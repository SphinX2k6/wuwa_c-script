using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000638 RID: 1592
public class BabelTowerResetView : UiViewBase
{
	// Token: 0x06004A2E RID: 18990 RVA: 0x0019375A File Offset: 0x0019195A
	[NullableContext(1)]
	public BabelTowerResetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004A2F RID: 18991 RVA: 0x00193764 File Offset: 0x00191964
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

	// Token: 0x06004A30 RID: 18992 RVA: 0x00193850 File Offset: 0x00191A50
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerResetView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerResetView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A31 RID: 18993 RVA: 0x00193893 File Offset: 0x00191A93
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06004A32 RID: 18994 RVA: 0x0019389C File Offset: 0x00191A9C
	private void OnClickConfirmBtn()
	{
		BabelTowerController.Instance.ResetBabelTowerLevelRequest(this.LevelId);
		base.CloseMe(null);
	}

	// Token: 0x04003703 RID: 14083
	private int LevelId;

	// Token: 0x020068EB RID: 26859
	private class EComponentDefine
	{
		// Token: 0x04022939 RID: 141625
		public const int LevelItem = 0;

		// Token: 0x0402293A RID: 141626
		public const int CancelBtn = 1;

		// Token: 0x0402293B RID: 141627
		public const int ConfirmBtn = 2;
	}
}
