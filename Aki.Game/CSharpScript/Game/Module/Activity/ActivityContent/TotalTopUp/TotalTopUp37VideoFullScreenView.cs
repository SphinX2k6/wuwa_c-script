using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F9E RID: 20382
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37VideoFullScreenView : UiViewBase
	{
		// Token: 0x06033156 RID: 209238 RVA: 0x00E51532 File Offset: 0x00E4F732
		public TotalTopUp37VideoFullScreenView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033157 RID: 209239 RVA: 0x00E5153B File Offset: 0x00E4F73B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x06033158 RID: 209240 RVA: 0x00E51574 File Offset: 0x00E4F774
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUp37VideoFullScreenView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUp37VideoFullScreenView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033159 RID: 209241 RVA: 0x00E515B7 File Offset: 0x00E4F7B7
		protected override void OnStart()
		{
			this.ShowSharedVideo();
		}

		// Token: 0x0603315A RID: 209242 RVA: 0x00E515C0 File Offset: 0x00E4F7C0
		private void ShowSharedVideo()
		{
			TotalTopUp37VideoFullScreenParam param = this.Param;
			if (param == null || param.ResourcePath.Length <= 0)
			{
				return;
			}
			if (Info.Instance.PlatformType == ESourcePlatformType.Android)
			{
				this.LoadVideoMaterial().Forget();
			}
		}

		// Token: 0x0603315B RID: 209243 RVA: 0x00E51600 File Offset: 0x00E4F800
		private UniTask LoadVideoMaterial()
		{
			TotalTopUp37VideoFullScreenView.<LoadVideoMaterial>d__8 <LoadVideoMaterial>d__;
			<LoadVideoMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadVideoMaterial>d__.<>4__this = this;
			<LoadVideoMaterial>d__.<>1__state = -1;
			<LoadVideoMaterial>d__.<>t__builder.Start<TotalTopUp37VideoFullScreenView.<LoadVideoMaterial>d__8>(ref <LoadVideoMaterial>d__);
			return <LoadVideoMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0603315C RID: 209244 RVA: 0x00E51643 File Offset: 0x00E4F843
		private void OnClickClose()
		{
			base.CloseMe(delegate(bool _)
			{
				TotalTopUp37VideoFullScreenParam param = this.Param;
				if (param == null)
				{
					return;
				}
				Action onClose = param.OnClose;
				if (onClose == null)
				{
					return;
				}
				onClose();
			});
		}

		// Token: 0x0401B1FA RID: 111098
		private const string VIDEO_MATERIAL_ID = "M_VideoTextureMat_RectClip";

		// Token: 0x0401B1FB RID: 111099
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401B1FC RID: 111100
		[Nullable(2)]
		private TotalTopUp37VideoFullScreenParam Param;
	}
}
