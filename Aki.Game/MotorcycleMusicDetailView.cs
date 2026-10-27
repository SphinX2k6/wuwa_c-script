using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022C0 RID: 8896
public class MotorcycleMusicDetailView : UiViewBase
{
	// Token: 0x06011757 RID: 71511 RVA: 0x004474EA File Offset: 0x004456EA
	[NullableContext(1)]
	public MotorcycleMusicDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011758 RID: 71512 RVA: 0x004474F4 File Offset: 0x004456F4
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

	// Token: 0x06011759 RID: 71513 RVA: 0x004475A0 File Offset: 0x004457A0
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleMusicDetailView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleMusicDetailView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601175A RID: 71514 RVA: 0x004475E3 File Offset: 0x004457E3
	private void OnClickMaskBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x02008831 RID: 34865
	private class EComponents
	{
		// Token: 0x0402C40B RID: 181259
		public const int BtnMask = 0;

		// Token: 0x0402C40C RID: 181260
		public const int TexAlbum = 1;

		// Token: 0x0402C40D RID: 181261
		public const int TxtAlbumName = 2;

		// Token: 0x0402C40E RID: 181262
		public const int TxtMusicName = 3;

		// Token: 0x0402C40F RID: 181263
		public const int TxtDesc = 4;
	}
}
