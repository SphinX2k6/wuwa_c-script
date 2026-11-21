using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018C2 RID: 6338
public class PersonalPlayerTitleMiniPreView : UiPanelBase
{
	// Token: 0x0600FA5F RID: 64095 RVA: 0x0049340C File Offset: 0x0049160C
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

	// Token: 0x0600FA60 RID: 64096 RVA: 0x00493494 File Offset: 0x00491694
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleMiniPreView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleMiniPreView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA61 RID: 64097 RVA: 0x004934D8 File Offset: 0x004916D8
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

	// Token: 0x04008C21 RID: 35873
	[Nullable(2)]
	private PlayerTitleItem PlayerTitleItem;

	// Token: 0x02007B09 RID: 31497
	private enum EComponent
	{
		// Token: 0x04027E03 RID: 163331
		PnlSatate,
		// Token: 0x04027E04 RID: 163332
		ItemCard,
		// Token: 0x04027E05 RID: 163333
		ItemUsed,
		// Token: 0x04027E06 RID: 163334
		ItemLock,
		// Token: 0x04027E07 RID: 163335
		PersonalTitleItem
	}
}
