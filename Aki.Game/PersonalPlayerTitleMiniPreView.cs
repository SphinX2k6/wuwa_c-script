using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023DD RID: 9181
public class PersonalPlayerTitleMiniPreView : UiPanelBase
{
	// Token: 0x060125AD RID: 75181 RVA: 0x00485F00 File Offset: 0x00484100
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x060125AE RID: 75182 RVA: 0x00485F88 File Offset: 0x00484188
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleMiniPreView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleMiniPreView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125AF RID: 75183 RVA: 0x00485FCC File Offset: 0x004841CC
	[NullableContext(1)]
	public void RefreshView(PersonalPlayerTitleData data)
	{
		if (data == null)
		{
			return;
		}
		int sex = PersonalModel.Instance.GetSex();
		this.PlayerTitleItem.Refresh(new int?(data.PlayerTitleId), data.StarLevel, new int?(sex));
	}

	// Token: 0x04008ADA RID: 35546
	[Nullable(2)]
	private PlayerTitleItem PlayerTitleItem;

	// Token: 0x02008980 RID: 35200
	private enum EComponent
	{
		// Token: 0x0402CAE8 RID: 183016
		PnlSatate,
		// Token: 0x0402CAE9 RID: 183017
		ItemCard,
		// Token: 0x0402CAEA RID: 183018
		ItemUsed,
		// Token: 0x0402CAEB RID: 183019
		ItemLock,
		// Token: 0x0402CAEC RID: 183020
		PersonalTitleItem
	}
}
