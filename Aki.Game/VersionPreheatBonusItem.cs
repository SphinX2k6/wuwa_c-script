using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001571 RID: 5489
[NullableContext(1)]
[Nullable(0)]
internal class VersionPreheatBonusItem : UiPanelBase
{
	// Token: 0x06009CFC RID: 40188 RVA: 0x0021F5A0 File Offset: 0x0021D7A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.HandleOnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009CFD RID: 40189 RVA: 0x0021F6EC File Offset: 0x0021D8EC
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatBonusItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatBonusItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009CFE RID: 40190 RVA: 0x0021F730 File Offset: 0x0021D930
	public UniTask RefreshExternalAsync(VersionPreheatBonusData data)
	{
		VersionPreheatBonusItem.<RefreshExternalAsync>d__3 <RefreshExternalAsync>d__;
		<RefreshExternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshExternalAsync>d__.<>4__this = this;
		<RefreshExternalAsync>d__.<>1__state = -1;
		<RefreshExternalAsync>d__.<>t__builder.Start<VersionPreheatBonusItem.<RefreshExternalAsync>d__3>(ref <RefreshExternalAsync>d__);
		return <RefreshExternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009CFF RID: 40191 RVA: 0x0021F774 File Offset: 0x0021D974
	private void RefreshWhenActive()
	{
		base.GetRootItem().SetUIActive(true);
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(VersionPreheatModel.Instance.IsBonusClicked());
		}
		UUIItem item3 = base.GetItem(6);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(!VersionPreheatModel.Instance.IsBonusClicked());
	}

	// Token: 0x06009D00 RID: 40192 RVA: 0x0021F800 File Offset: 0x0021DA00
	private void HandleOnClick()
	{
		VersionPreheatModel.Instance.SetBonusClicked();
		ActivityVersionPreheatController.Instance.OpenTargetViewAsyncById(null, false);
		ActivityVersionPreheatController.Instance.SendDetailClickLogData(null);
	}

	// Token: 0x040044E7 RID: 17639
	private UiSequencePlayer Player;
}
