using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002490 RID: 9360
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionAssembleSuitItem : GridProxyAbstract<VisionAssembleSuitItemData>
{
	// Token: 0x06012C8E RID: 76942 RVA: 0x004A24CA File Offset: 0x004A06CA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06012C8F RID: 76943 RVA: 0x004A2504 File Offset: 0x004A0704
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleSuitItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleSuitItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C90 RID: 76944 RVA: 0x004A2548 File Offset: 0x004A0748
	[NullableContext(1)]
	public override void Refresh(VisionAssembleSuitItemData data, bool isSelected, int gridIndex)
	{
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterGroupId);
		VisionFetterSuitItem visionFetterSuitItem = this.VisionFetterSuitItem;
		if (visionFetterSuitItem != null)
		{
			visionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupById));
		}
		UUIText text = base.GetText(1);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendLiteral("（");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.CurrentProgress);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.MaxProgress);
		defaultInterpolatedStringHandler.AppendLiteral("）");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x04008D73 RID: 36211
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02008A0A RID: 35338
	private enum EComponent
	{
		// Token: 0x0402CD45 RID: 183621
		ElementItem,
		// Token: 0x0402CD46 RID: 183622
		InfoText
	}
}
