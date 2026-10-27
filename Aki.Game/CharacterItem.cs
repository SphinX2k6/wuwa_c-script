using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001304 RID: 4868
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterItem : GridProxyAbstract<CharacterData>
{
	// Token: 0x060086E6 RID: 34534 RVA: 0x001CCCEF File Offset: 0x001CAEEF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060086E7 RID: 34535 RVA: 0x001CCD28 File Offset: 0x001CAF28
	protected override UniTask OnBeforeStartAsync()
	{
		CharacterItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CharacterItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060086E8 RID: 34536 RVA: 0x001CCD6B File Offset: 0x001CAF6B
	public override void Refresh(CharacterData data, bool isSelected, int gridIndex)
	{
		this.Id = data.Id;
		this.NameItem.Refresh(data, false, 0);
		this.ValueItem.Refresh(data, false, 0);
	}

	// Token: 0x060086E9 RID: 34537 RVA: 0x001CCD95 File Offset: 0x001CAF95
	public void RefreshName(CharacterData data)
	{
		this.NameItem.Refresh(data, false, 0);
	}

	// Token: 0x060086EA RID: 34538 RVA: 0x001CCDA5 File Offset: 0x001CAFA5
	public void RefreshProgress(int value, int maxValue)
	{
		this.ValueItem.RefreshProgress(value, maxValue);
	}

	// Token: 0x060086EB RID: 34539 RVA: 0x001CCDB4 File Offset: 0x001CAFB4
	public void RefreshCurrentValue(int value)
	{
		this.ValueItem.RefreshCurrentValue(value);
	}

	// Token: 0x060086EC RID: 34540 RVA: 0x001CCDC2 File Offset: 0x001CAFC2
	public void RefreshProgressAdd(int value, int maxValue)
	{
		this.ValueItem.RefreshProgressAdd(value, maxValue);
	}

	// Token: 0x060086ED RID: 34541 RVA: 0x001CCDD1 File Offset: 0x001CAFD1
	public void SetLightProgressWidth()
	{
		this.ValueItem.SetLightProgressWidth();
	}

	// Token: 0x060086EE RID: 34542 RVA: 0x001CCDDE File Offset: 0x001CAFDE
	public void SetGoodItemActive(bool value)
	{
		CharacterNameItem nameItem = this.NameItem;
		if (nameItem == null)
		{
			return;
		}
		nameItem.SetGoodItemActive(value);
	}

	// Token: 0x060086EF RID: 34543 RVA: 0x001CCDF1 File Offset: 0x001CAFF1
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x04003C4C RID: 15436
	[Nullable(2)]
	protected CharacterNameItem NameItem;

	// Token: 0x04003C4D RID: 15437
	[Nullable(2)]
	protected CharacterValueItem ValueItem;

	// Token: 0x04003C4E RID: 15438
	protected int Id;

	// Token: 0x0200793E RID: 31038
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027F05 RID: 163589
		public const int NameItem = 0;

		// Token: 0x04027F06 RID: 163590
		public const int ValueItem = 1;
	}
}
