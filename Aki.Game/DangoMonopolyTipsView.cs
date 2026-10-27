using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001253 RID: 4691
[NullableContext(2)]
[Nullable(0)]
public class DangoMonopolyTipsView : UiViewBase
{
	// Token: 0x17000AD0 RID: 2768
	// (get) Token: 0x06007F75 RID: 32629 RVA: 0x001B013A File Offset: 0x001AE33A
	public new DangoMonopolyTipsViewParams OpenParam
	{
		get
		{
			return this.OpenParam as DangoMonopolyTipsViewParams;
		}
	}

	// Token: 0x06007F76 RID: 32630 RVA: 0x001B0147 File Offset: 0x001AE347
	[NullableContext(1)]
	public DangoMonopolyTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007F77 RID: 32631 RVA: 0x001B0150 File Offset: 0x001AE350
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06007F78 RID: 32632 RVA: 0x001B0189 File Offset: 0x001AE389
	private void InitDataParam()
	{
	}

	// Token: 0x06007F79 RID: 32633 RVA: 0x001B018C File Offset: 0x001AE38C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007F7A RID: 32634 RVA: 0x001B01CF File Offset: 0x001AE3CF
	protected override void OnBeforeShow()
	{
		this.ShowData().Forget();
	}

	// Token: 0x06007F7B RID: 32635 RVA: 0x001B01DC File Offset: 0x001AE3DC
	public UniTask ShowData()
	{
		DangoMonopolyTipsView.<ShowData>d__8 <ShowData>d__;
		<ShowData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowData>d__.<>4__this = this;
		<ShowData>d__.<>1__state = -1;
		<ShowData>d__.<>t__builder.Start<DangoMonopolyTipsView.<ShowData>d__8>(ref <ShowData>d__);
		return <ShowData>d__.<>t__builder.Task;
	}

	// Token: 0x06007F7C RID: 32636 RVA: 0x001B021F File Offset: 0x001AE41F
	public void UpdateIcon(string icon)
	{
		if (icon != null)
		{
			base.SetTextureShowUntilLoaded(icon, base.GetTexture(0), null);
		}
	}

	// Token: 0x0200786C RID: 30828
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027AE5 RID: 162533
		TextureIcon,
		// Token: 0x04027AE6 RID: 162534
		TxtDesc
	}
}
