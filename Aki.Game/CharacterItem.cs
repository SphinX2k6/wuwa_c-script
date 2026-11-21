using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007B8 RID: 1976
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItem : GridProxyAbstract<CharacterData>
{
	// Token: 0x06005A81 RID: 23169 RVA: 0x001D5B5B File Offset: 0x001D3D5B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06005A82 RID: 23170 RVA: 0x001D5B94 File Offset: 0x001D3D94
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005A83 RID: 23171 RVA: 0x001D5BD7 File Offset: 0x001D3DD7
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		this.Id = data.Id;
		this.NameItem.Refresh(data, false, 0);
		this.ValueItem.Refresh(data, false, 0);
	}

	// Token: 0x06005A84 RID: 23172 RVA: 0x001D5C01 File Offset: 0x001D3E01
	public void RefreshName(CharacterData data)
	{
		this.NameItem.Refresh(data, false, 0);
	}

	// Token: 0x06005A85 RID: 23173 RVA: 0x001D5C11 File Offset: 0x001D3E11
	public void RefreshProgress(int value, int maxValue)
	{
		this.ValueItem.RefreshProgress(value, maxValue);
	}

	// Token: 0x06005A86 RID: 23174 RVA: 0x001D5C20 File Offset: 0x001D3E20
	public void RefreshCurrentValue(int value)
	{
		this.ValueItem.RefreshCurrentValue(value);
	}

	// Token: 0x06005A87 RID: 23175 RVA: 0x001D5C2E File Offset: 0x001D3E2E
	public void RefreshProgressAdd(int value, int maxValue)
	{
		this.ValueItem.RefreshProgressAdd(value, maxValue);
	}

	// Token: 0x06005A88 RID: 23176 RVA: 0x001D5C3D File Offset: 0x001D3E3D
	public void SetLightProgressWidth()
	{
		this.ValueItem.SetLightProgressWidth();
	}

	// Token: 0x06005A89 RID: 23177 RVA: 0x001D5C4A File Offset: 0x001D3E4A
	public void SetGoodItemActive(bool value)
	{
		CharacterNameItem nameItem = this.NameItem;
		if (nameItem == null)
		{
			return;
		}
		nameItem.SetGoodItemActive(value);
	}

	// Token: 0x06005A8A RID: 23178 RVA: 0x001D5C5D File Offset: 0x001D3E5D
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x04003CE4 RID: 15588
	[Nullable(2)]
	protected CharacterNameItem NameItem;

	// Token: 0x04003CE5 RID: 15589
	[Nullable(2)]
	protected CharacterValueItem ValueItem;

	// Token: 0x04003CE6 RID: 15590
	protected int Id;

	// Token: 0x02006AC8 RID: 27336
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04023232 RID: 143922
		public const int NameItem = 0;

		// Token: 0x04023233 RID: 143923
		public const int ValueItem = 1;
	}
}
