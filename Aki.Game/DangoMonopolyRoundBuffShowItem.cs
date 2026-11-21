using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006FA RID: 1786
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyRoundBuffShowItem : GridProxyAbstract<IDangoMonopolyRoundBuffData>
{
	// Token: 0x06005299 RID: 21145 RVA: 0x001B780C File Offset: 0x001B5A0C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600529A RID: 21146 RVA: 0x001B787C File Offset: 0x001B5A7C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundBuffShowItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundBuffShowItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600529B RID: 21147 RVA: 0x001B78C0 File Offset: 0x001B5AC0
	public override void Refresh(IDangoMonopolyRoundBuffData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.SetTextureByPath(this.ItemData.DangoIcon, base.GetTexture(1), null, null);
		base.GetText(2).ShowTextNew(this.ItemData.DangoName);
		base.GetText(3).ShowTextNew(this.ItemData.PropertyDesc);
	}

	// Token: 0x04003A6D RID: 14957
	private IDangoMonopolyRoundBuffData ItemData;

	// Token: 0x020069E8 RID: 27112
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022DCF RID: 142799
		ItemSelf,
		// Token: 0x04022DD0 RID: 142800
		TextureIcon,
		// Token: 0x04022DD1 RID: 142801
		TxtName,
		// Token: 0x04022DD2 RID: 142802
		TxtDesc
	}
}
