using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002032 RID: 8242
public class CommonKeySettingView : UiViewBase
{
	// Token: 0x060102D1 RID: 66257 RVA: 0x003F08E3 File Offset: 0x003EEAE3
	[NullableContext(1)]
	public CommonKeySettingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060102D2 RID: 66258 RVA: 0x003F08EC File Offset: 0x003EEAEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x060102D3 RID: 66259 RVA: 0x003F0948 File Offset: 0x003EEB48
	protected override UniTask OnBeforeStartAsync()
	{
		CommonKeySettingView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonKeySettingView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060102D4 RID: 66260 RVA: 0x003F098C File Offset: 0x003EEB8C
	protected override void OnStart()
	{
		ICommonKeySettingViewOpenData commonKeySettingViewOpenData = this.OpenParam as ICommonKeySettingViewOpenData;
		if (string.IsNullOrEmpty((commonKeySettingViewOpenData != null) ? commonKeySettingViewOpenData.BgSourceId : null))
		{
			return;
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(commonKeySettingViewOpenData.BgSourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(2), null, null);
	}

	// Token: 0x0400778B RID: 30603
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400778C RID: 30604
	[Nullable(2)]
	private CommonKeySettingPanel KeySettingPanel;

	// Token: 0x0200862D RID: 34349
	private static class EComponentDefine
	{
		// Token: 0x0402BA97 RID: 178839
		public const int ItemCaption = 0;

		// Token: 0x0402BA98 RID: 178840
		public const int ItemAttachParent = 1;

		// Token: 0x0402BA99 RID: 178841
		public const int BgTexture = 2;
	}
}
