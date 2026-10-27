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
	// Token: 0x02005FB7 RID: 24503
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUp37VideoFullScreenView : UiViewBase
	{
		// Token: 0x0603E1BC RID: 254396 RVA: 0x00EFF876 File Offset: 0x00EFDA76
		public TotalTopUp37VideoFullScreenView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E1BD RID: 254397 RVA: 0x00EFF87F File Offset: 0x00EFDA7F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x0603E1BE RID: 254398 RVA: 0x00EFF8B8 File Offset: 0x00EFDAB8
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUp37VideoFullScreenView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUp37VideoFullScreenView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1BF RID: 254399 RVA: 0x00EFF8FB File Offset: 0x00EFDAFB
		protected override void OnStart()
		{
			this.ShowSharedVideo();
		}

		// Token: 0x0603E1C0 RID: 254400 RVA: 0x00EFF904 File Offset: 0x00EFDB04
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

		// Token: 0x0603E1C1 RID: 254401 RVA: 0x00EFF944 File Offset: 0x00EFDB44
		private UniTask LoadVideoMaterial()
		{
			TotalTopUp37VideoFullScreenView.<LoadVideoMaterial>d__8 <LoadVideoMaterial>d__;
			<LoadVideoMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadVideoMaterial>d__.<>4__this = this;
			<LoadVideoMaterial>d__.<>1__state = -1;
			<LoadVideoMaterial>d__.<>t__builder.Start<TotalTopUp37VideoFullScreenView.<LoadVideoMaterial>d__8>(ref <LoadVideoMaterial>d__);
			return <LoadVideoMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0603E1C2 RID: 254402 RVA: 0x00EFF987 File Offset: 0x00EFDB87
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

		// Token: 0x04020728 RID: 132904
		private const string VIDEO_MATERIAL_ID = "M_VideoTextureMat_RectClip";

		// Token: 0x04020729 RID: 132905
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0402072A RID: 132906
		[Nullable(2)]
		private TotalTopUp37VideoFullScreenParam Param;
	}
}
