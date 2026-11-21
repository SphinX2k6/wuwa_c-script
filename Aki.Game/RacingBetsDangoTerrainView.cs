using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C19 RID: 7193
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoTerrainView : UiViewBase
{
	// Token: 0x06011DCB RID: 73163 RVA: 0x00540698 File Offset: 0x0053E898
	public RacingBetsDangoTerrainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DCC RID: 73164 RVA: 0x005406A4 File Offset: 0x0053E8A4
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

	// Token: 0x06011DCD RID: 73165 RVA: 0x00540768 File Offset: 0x0053E968
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDangoTerrainView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDangoTerrainView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011DCE RID: 73166 RVA: 0x005407AB File Offset: 0x0053E9AB
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011DCF RID: 73167 RVA: 0x005407B4 File Offset: 0x0053E9B4
	private RacingBetsDangoTerrainItem DungeonTerrainItemProxyCreate()
	{
		return new RacingBetsDangoTerrainItem();
	}

	// Token: 0x04009BE1 RID: 39905
	private GenericLayout<RacingBetsDangoTerrainItem, int> DungeonTerrainLayout;

	// Token: 0x02007F13 RID: 32531
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040291FC RID: 168444
		public const int CloseButton = 0;

		// Token: 0x040291FD RID: 168445
		public const int TerrainLayout = 1;

		// Token: 0x040291FE RID: 168446
		public const int TerrainItem = 2;

		// Token: 0x040291FF RID: 168447
		public const int MaskButton = 3;

		// Token: 0x04029200 RID: 168448
		public const int TitleText = 4;
	}
}
