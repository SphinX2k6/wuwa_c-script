using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001505 RID: 5381
public class CommonKeySettingView : UiViewBase
{
	// Token: 0x0600D739 RID: 55097 RVA: 0x003FCEDB File Offset: 0x003FB0DB
	[NullableContext(1)]
	public CommonKeySettingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D73A RID: 55098 RVA: 0x003FCEE4 File Offset: 0x003FB0E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600D73B RID: 55099 RVA: 0x003FCF40 File Offset: 0x003FB140
	protected override UniTask OnBeforeStartAsync()
	{
		CommonKeySettingView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonKeySettingView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D73C RID: 55100 RVA: 0x003FCF84 File Offset: 0x003FB184
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

	// Token: 0x04007874 RID: 30836
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x04007875 RID: 30837
	[Nullable(2)]
	private CommonKeySettingPanel KeySettingPanel;

	// Token: 0x020077B4 RID: 30644
	private static class EComponentDefine
	{
		// Token: 0x04026DA6 RID: 159142
		public const int ItemCaption = 0;

		// Token: 0x04026DA7 RID: 159143
		public const int ItemAttachParent = 1;

		// Token: 0x04026DA8 RID: 159144
		public const int BgTexture = 2;
	}
}
