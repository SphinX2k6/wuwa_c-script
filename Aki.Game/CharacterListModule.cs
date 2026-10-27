using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001308 RID: 4872
[NullableContext(1)]
[Nullable(0)]
public class CharacterListModule<[Nullable(0)] T> : UiPanelBase where T : GridProxyAbstract<CharacterData>
{
	// Token: 0x06008705 RID: 34565 RVA: 0x001CD212 File Offset: 0x001CB412
	public CharacterListModule(Func<T> func)
	{
		this.InitCharacterItemFunc = func;
	}

	// Token: 0x06008706 RID: 34566 RVA: 0x001CD221 File Offset: 0x001CB421
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06008707 RID: 34567 RVA: 0x001CD25A File Offset: 0x001CB45A
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<T, CharacterData>(base.GetLayoutBase(0), new Func<T>(this.InitCharacterItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06008708 RID: 34568 RVA: 0x001CD290 File Offset: 0x001CB490
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

	// Token: 0x06008709 RID: 34569 RVA: 0x001CD2DB File Offset: 0x001CB4DB
	private T InitCharacterItem()
	{
		return this.InitCharacterItemFunc();
	}

	// Token: 0x0600870A RID: 34570 RVA: 0x001CD2E8 File Offset: 0x001CB4E8
	public List<T> GetItemList()
	{
		return this.Layout.GetLayoutItemList();
	}

	// Token: 0x04003C54 RID: 15444
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<T, CharacterData> Layout;

	// Token: 0x04003C55 RID: 15445
	private readonly Func<T> InitCharacterItemFunc;

	// Token: 0x02007946 RID: 31046
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027F1E RID: 163614
		public const int CharacterList = 0;

		// Token: 0x04027F1F RID: 163615
		public const int CharacterItem = 1;
	}
}
