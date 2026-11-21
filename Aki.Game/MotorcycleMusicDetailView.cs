using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017A4 RID: 6052
public class MotorcycleMusicDetailView : UiViewBase
{
	// Token: 0x0600EBEF RID: 60399 RVA: 0x00454142 File Offset: 0x00452342
	[NullableContext(1)]
	public MotorcycleMusicDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EBF0 RID: 60400 RVA: 0x0045414C File Offset: 0x0045234C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickMaskBtn))
		};
	}

	// Token: 0x0600EBF1 RID: 60401 RVA: 0x004541F8 File Offset: 0x004523F8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleMusicDetailView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleMusicDetailView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBF2 RID: 60402 RVA: 0x0045423B File Offset: 0x0045243B
	private void OnClickMaskBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x020079B6 RID: 31158
	private class EComponents
	{
		// Token: 0x04027712 RID: 161554
		public const int BtnMask = 0;

		// Token: 0x04027713 RID: 161555
		public const int TexAlbum = 1;

		// Token: 0x04027714 RID: 161556
		public const int TxtAlbumName = 2;

		// Token: 0x04027715 RID: 161557
		public const int TxtMusicName = 3;

		// Token: 0x04027716 RID: 161558
		public const int TxtDesc = 4;
	}
}
