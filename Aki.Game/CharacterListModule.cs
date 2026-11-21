using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007BC RID: 1980
[NullableContext(1)]
[Nullable(0)]
public class CharacterListModule<[Nullable(0)] T> : UiPanelBase where T : GridProxyAbstract<CharacterData>
{
	// Token: 0x06005AA0 RID: 23200 RVA: 0x001D607E File Offset: 0x001D427E
	public CharacterListModule(Func<T> func)
	{
		this.InitCharacterItemFunc = func;
	}

	// Token: 0x06005AA1 RID: 23201 RVA: 0x001D608D File Offset: 0x001D428D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06005AA2 RID: 23202 RVA: 0x001D60C6 File Offset: 0x001D42C6
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<T, CharacterData>(base.GetLayoutBase(0), new Func<T>(this.InitCharacterItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06005AA3 RID: 23203 RVA: 0x001D60FC File Offset: 0x001D42FC
	public UniTask RefreshByDataAsync(IReadOnlyList<CharacterData> dataList)
	{
		CharacterListModule<T>.<RefreshByDataAsync>d__6 <RefreshByDataAsync>d__;
		<RefreshByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByDataAsync>d__.<>4__this = this;
		<RefreshByDataAsync>d__.dataList = dataList;
		<RefreshByDataAsync>d__.<>1__state = -1;
		<RefreshByDataAsync>d__.<>t__builder.Start<CharacterListModule<T>.<RefreshByDataAsync>d__6>(ref <RefreshByDataAsync>d__);
		return <RefreshByDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005AA4 RID: 23204 RVA: 0x001D6147 File Offset: 0x001D4347
	private T InitCharacterItem()
	{
		return this.InitCharacterItemFunc();
	}

	// Token: 0x06005AA5 RID: 23205 RVA: 0x001D6154 File Offset: 0x001D4354
	public List<T> GetItemList()
	{
		return this.Layout.GetLayoutItemList();
	}

	// Token: 0x04003CEC RID: 15596
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<T, CharacterData> Layout;

	// Token: 0x04003CED RID: 15597
	private readonly Func<T> InitCharacterItemFunc;

	// Token: 0x02006AD0 RID: 27344
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402324B RID: 143947
		public const int CharacterList = 0;

		// Token: 0x0402324C RID: 143948
		public const int CharacterItem = 1;
	}
}
