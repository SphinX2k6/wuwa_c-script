using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001977 RID: 6519
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionAssembleSuitItem : GridProxyAbstract<VisionAssembleSuitItemData>
{
	// Token: 0x0601014F RID: 65871 RVA: 0x004AFFBA File Offset: 0x004AE1BA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06010150 RID: 65872 RVA: 0x004AFFF4 File Offset: 0x004AE1F4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleSuitItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleSuitItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010151 RID: 65873 RVA: 0x004B0038 File Offset: 0x004AE238
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

	// Token: 0x04008EBC RID: 36540
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007B94 RID: 31636
	private enum EComponent
	{
		// Token: 0x04028065 RID: 163941
		ElementItem,
		// Token: 0x04028066 RID: 163942
		InfoText
	}
}
