using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000707 RID: 1799
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyTipsView : UiViewBase
{
	// Token: 0x17000AF0 RID: 2800
	// (get) Token: 0x0600530C RID: 21260 RVA: 0x001B8DEA File Offset: 0x001B6FEA
	public new DangoMonopolyTipsViewParams OpenParam
	{
		get
		{
			return this.OpenParam as DangoMonopolyTipsViewParams;
		}
	}

	// Token: 0x0600530D RID: 21261 RVA: 0x001B8DF7 File Offset: 0x001B6FF7
	[NullableContext(1)]
	public DangoMonopolyTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600530E RID: 21262 RVA: 0x001B8E00 File Offset: 0x001B7000
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600530F RID: 21263 RVA: 0x001B8E39 File Offset: 0x001B7039
	private void InitDataParam()
	{
	}

	// Token: 0x06005310 RID: 21264 RVA: 0x001B8E3C File Offset: 0x001B703C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005311 RID: 21265 RVA: 0x001B8E7F File Offset: 0x001B707F
	protected override void OnBeforeShow()
	{
		this.ShowData().Forget();
	}

	// Token: 0x06005312 RID: 21266 RVA: 0x001B8E8C File Offset: 0x001B708C
	public UniTask ShowData()
	{
		DangoMonopolyTipsView.<ShowData>d__8 <ShowData>d__;
		<ShowData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowData>d__.<>4__this = this;
		<ShowData>d__.<>1__state = -1;
		<ShowData>d__.<>t__builder.Start<DangoMonopolyTipsView.<ShowData>d__8>(ref <ShowData>d__);
		return <ShowData>d__.<>t__builder.Task;
	}

	// Token: 0x06005313 RID: 21267 RVA: 0x001B8ECF File Offset: 0x001B70CF
	public void UpdateIcon(string icon)
	{
		if (icon != null)
		{
			base.SetTextureShowUntilLoaded(icon, base.GetTexture(0), null);
		}
	}

	// Token: 0x020069F7 RID: 27127
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022E16 RID: 142870
		TextureIcon,
		// Token: 0x04022E17 RID: 142871
		TxtDesc
	}
}
