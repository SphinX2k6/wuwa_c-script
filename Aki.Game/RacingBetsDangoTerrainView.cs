using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200272E RID: 10030
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoTerrainView : UiViewBase
{
	// Token: 0x060148E9 RID: 84201 RVA: 0x00531980 File Offset: 0x0052FB80
	public RacingBetsDangoTerrainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148EA RID: 84202 RVA: 0x0053198C File Offset: 0x0052FB8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseButton))
		};
	}

	// Token: 0x060148EB RID: 84203 RVA: 0x00531A50 File Offset: 0x0052FC50
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDangoTerrainView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDangoTerrainView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148EC RID: 84204 RVA: 0x00531A93 File Offset: 0x0052FC93
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x060148ED RID: 84205 RVA: 0x00531A9C File Offset: 0x0052FC9C
	private RacingBetsDangoTerrainItem DungeonTerrainItemProxyCreate()
	{
		return new RacingBetsDangoTerrainItem();
	}

	// Token: 0x04009A89 RID: 39561
	private GenericLayout<RacingBetsDangoTerrainItem, int> DungeonTerrainLayout;

	// Token: 0x02008D8B RID: 36235
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DEE6 RID: 188134
		public const int CloseButton = 0;

		// Token: 0x0402DEE7 RID: 188135
		public const int TerrainLayout = 1;

		// Token: 0x0402DEE8 RID: 188136
		public const int TerrainItem = 2;

		// Token: 0x0402DEE9 RID: 188137
		public const int MaskButton = 3;

		// Token: 0x0402DEEA RID: 188138
		public const int TitleText = 4;
	}
}
