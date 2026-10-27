using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001246 RID: 4678
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyRoundBuffShowItem : GridProxyAbstract<IDangoMonopolyRoundBuffData>
{
	// Token: 0x06007F02 RID: 32514 RVA: 0x001AEB54 File Offset: 0x001ACD54
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

	// Token: 0x06007F03 RID: 32515 RVA: 0x001AEBC4 File Offset: 0x001ACDC4
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundBuffShowItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundBuffShowItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007F04 RID: 32516 RVA: 0x001AEC08 File Offset: 0x001ACE08
	public override void Refresh(IDangoMonopolyRoundBuffData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.SetTextureByPath(this.ItemData.DangoIcon, base.GetTexture(1), null, null);
		base.GetText(2).ShowTextNew(this.ItemData.DangoName);
		base.GetText(3).ShowTextNew(this.ItemData.PropertyDesc);
	}

	// Token: 0x040039D5 RID: 14805
	private IDangoMonopolyRoundBuffData ItemData;

	// Token: 0x0200785D RID: 30813
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027A9E RID: 162462
		ItemSelf,
		// Token: 0x04027A9F RID: 162463
		TextureIcon,
		// Token: 0x04027AA0 RID: 162464
		TxtName,
		// Token: 0x04027AA1 RID: 162465
		TxtDesc
	}
}
