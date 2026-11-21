using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Launcher.Platform;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006437 RID: 25655
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraModel : ModelBase
	{
		// Token: 0x17007674 RID: 30324
		// (get) Token: 0x0603E481 RID: 255105 RVA: 0x01219909 File Offset: 0x01217B09
		// (set) Token: 0x0603E482 RID: 255106 RVA: 0x01219911 File Offset: 0x01217B11
		public CameraModelInstance MainModel { get; private set; }

		// Token: 0x0603E483 RID: 255107 RVA: 0x0121991C File Offset: 0x01217B1C
		public CameraModelInstance CreateSeparateCameraModel(string cameraName)
		{
			CameraModelInstance separateCameraModel = this.GetSeparateCameraModel(cameraName);
			if (separateCameraModel != null)
			{
				return separateCameraModel;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[分屏相机][CameraModel]新建分屏相机";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cameraName", cameraName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			CameraModelInstance cameraModelInstance = new CameraModelInstance(cameraName);
			this.CameraModelInstanceMap[cameraName] = cameraModelInstance;
			cameraModelInstance.Init();
			return cameraModelInstance;
		}

		// Token: 0x0603E484 RID: 255108 RVA: 0x01219979 File Offset: 0x01217B79
		[return: Nullable(2)]
		public CameraModelInstance GetSeparateCameraModel(string cameraName = "MainCamera")
		{
			if (cameraName == "MainCamera")
			{
				return this.MainModel;
			}
			return this.CameraModelInstanceMap.GetValueOrDefault(cameraName);
		}

		// Token: 0x0603E485 RID: 255109 RVA: 0x0121999B File Offset: 0x01217B9B
		public bool HasSeparateCamera()
		{
			return this.CameraModelInstanceMap.Count > 0;
		}

		// Token: 0x0603E486 RID: 255110 RVA: 0x012199AC File Offset: 0x01217BAC
		[return: Nullable(2)]
		public CameraModelInstance DetachSeparateCameraModel(string cameraName)
		{
			if (cameraName == "MainCamera")
			{
				return null;
			}
			CameraModelInstance separateCameraModel = this.GetSeparateCameraModel(cameraName);
			if (separateCameraModel == null)
			{
				return null;
			}
			this.CameraModelInstanceMap.Remove(cameraName);
			return separateCameraModel;
		}

		// Token: 0x0603E487 RID: 255111 RVA: 0x012199E4 File Offset: 0x01217BE4
		public void DestroySeparateCameraModel(string cameraName)
		{
			CameraModelInstance cameraModelInstance = this.DetachSeparateCameraModel(cameraName);
			if (cameraModelInstance == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[分屏相机][CameraModel]销毁分屏相机";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cameraName", cameraName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			cameraModelInstance.Clear();
		}

		// Token: 0x0603E488 RID: 255112 RVA: 0x01219A2B File Offset: 0x01217C2B
		protected override bool OnInit()
		{
			this.UpdateCameraParam();
			this.MainModel = new CameraModelInstance("MainCamera");
			return this.MainModel.Init();
		}

		// Token: 0x0603E489 RID: 255113 RVA: 0x01219A50 File Offset: 0x01217C50
		public void ModelIterator(Action<CameraModelInstance> action)
		{
			action(this.MainModel);
			foreach (KeyValuePair<string, CameraModelInstance> keyValuePair in new Dictionary<string, CameraModelInstance>(this.CameraModelInstanceMap))
			{
				string text;
				CameraModelInstance cameraModelInstance;
				keyValuePair.Deconstruct(out text, out cameraModelInstance);
				CameraModelInstance obj = cameraModelInstance;
				action(obj);
			}
		}

		// Token: 0x0603E48A RID: 255114 RVA: 0x01219AC4 File Offset: 0x01217CC4
		protected override bool OnClear()
		{
			this.ModelIterator(delegate(CameraModelInstance instance)
			{
				instance.Clear();
			});
			this.CameraModelInstanceMap.Clear();
			APlayerController playerController = Global.PlayerController;
			if (playerController != null)
			{
				playerController.RemoveAdditionalPlayerCameraManagers();
			}
			return true;
		}

		// Token: 0x0603E48B RID: 255115 RVA: 0x01219B14 File Offset: 0x01217D14
		private void UpdateCameraParam()
		{
			if (Info.Instance.IsMobilePlatform())
			{
				if ((Info.Instance.PlatformType == ESourcePlatformType.Android && Platform.Instance.IsHuaWeiDevice()) || Platform.Instance.IsHonorDevice())
				{
					this.UpdateHuaWeiParam();
					return;
				}
				this.UpdateMobileParam();
				return;
			}
			else
			{
				if (CloudGameManager.Instance.IsCloudGame)
				{
					this.UpdateCloudGameParam();
					return;
				}
				this.MobileDensityYawScale = 0.0055555557f;
				this.MobileDensityPitchScale = 0.0055555557f;
				return;
			}
		}

		// Token: 0x0603E48C RID: 255116 RVA: 0x01219B8C File Offset: 0x01217D8C
		private unsafe void UpdateHuaWeiParam()
		{
			FVector2D physicalScreenResolution = KuroScreen.GetPhysicalScreenResolution();
			float x = physicalScreenResolution.X;
			float y = physicalScreenResolution.Y;
			FVector2D physicalScreenResolutionV = KuroScreen.GetPhysicalScreenResolutionV2();
			float x2 = physicalScreenResolutionV.X;
			float y2 = physicalScreenResolutionV.Y;
			FVector2D displayScreenResolution = KuroScreen.GetDisplayScreenResolution();
			float x3 = displayScreenResolution.X;
			float y3 = displayScreenResolution.Y;
			FIntPoint defaultScreenResolution = GameSettingsDeviceRender.Instance.GetDefaultScreenResolution();
			int x4 = defaultScreenResolution.X;
			int y4 = defaultScreenResolution.Y;
			this.PhysicalScreenWidth = Math.Max(x, y);
			this.PhysicalScreenHeight = Math.Min(x, y);
			this.PhysicalScreenWidthV2 = Math.Max(x2, y2);
			this.PhysicalScreenHeightV2 = Math.Min(x2, y2);
			this.DisplayScreenWidth = Math.Max(x3, y3);
			this.DisplayScreenHeight = Math.Min(x3, y3);
			this.GameScreenWidth = (float)Math.Max(x4, y4);
			this.GameScreenHeight = (float)Math.Min(x4, y4);
			this.PhysicalDensityDpi = Math.Max((float)KuroScreen.GetPhysicalScreenDensityDPI(), 160f);
			this.RealPhysicalDensityDpi = this.PhysicalScreenWidth / this.DisplayScreenWidth * this.PhysicalDensityDpi;
			if (MathUtils.Instance.IsNearlyEqual((double)this.PhysicalScreenWidthV2, 0.0, null) || MathUtils.Instance.IsNearlyEqual((double)this.PhysicalScreenHeightV2, 0.0, null))
			{
				this.PhysicalScreenWidthV2 = this.GameScreenWidth;
				this.PhysicalScreenHeightV2 = this.GameScreenHeight;
			}
			this.MobileDensityYawScale = this.PhysicalScreenWidthV2 / (this.GameScreenWidth * this.RealPhysicalDensityDpi);
			this.MobileDensityPitchScale = this.PhysicalScreenHeightV2 / (this.GameScreenHeight * this.RealPhysicalDensityDpi);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "CameraModel HuaWeiParam";
			<>y__InlineArray12<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray12<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GameScreenWidth", this.GameScreenWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GameScreenHeight", this.GameScreenHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PhysicalScreenWidth", this.PhysicalScreenWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PhysicalScreenHeight", this.PhysicalScreenHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("PhysicalScreenWidthV2", this.PhysicalScreenWidthV2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("PhysicalScreenHeightV2", this.PhysicalScreenHeightV2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("DisplayScreenWidth", this.DisplayScreenWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("DisplayScreenHeight", this.DisplayScreenHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("PhysicalDensityDpi", this.PhysicalDensityDpi);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("RealPhysicalDensityDpi", this.RealPhysicalDensityDpi);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 10) = new ValueTuple<string, object>("MobileDensityYawScale", this.MobileDensityYawScale);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 11) = new ValueTuple<string, object>("MobileDensityPitchScale", this.MobileDensityPitchScale);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray12<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 12));
		}

		// Token: 0x0603E48D RID: 255117 RVA: 0x01219EE4 File Offset: 0x012180E4
		private unsafe void UpdateMobileParam()
		{
			FVector2D physicalScreenResolution = KuroScreen.GetPhysicalScreenResolution();
			float x = physicalScreenResolution.X;
			float y = physicalScreenResolution.Y;
			FIntPoint defaultScreenResolution = GameSettingsDeviceRender.Instance.GetDefaultScreenResolution();
			int x2 = defaultScreenResolution.X;
			int y2 = defaultScreenResolution.Y;
			this.GameScreenWidth = (float)Math.Max(x2, y2);
			this.GameScreenHeight = (float)Math.Min(x2, y2);
			this.PhysicalScreenWidth = Math.Max(x, y);
			this.PhysicalScreenHeight = Math.Min(x, y);
			if (Info.Instance.PlatformType == ESourcePlatformType.IOS)
			{
				this.PhysicalDensityDpi = Math.Max((float)KuroScreen.ComputePhysicalScreenDensity(), 160f);
			}
			else
			{
				this.PhysicalDensityDpi = Math.Max((float)KuroScreen.GetPhysicalScreenDensityDPI(), 160f);
			}
			if (MathUtils.Instance.IsNearlyEqual((double)this.PhysicalScreenWidth, 0.0, null) || MathUtils.Instance.IsNearlyEqual((double)this.PhysicalScreenHeight, 0.0, null))
			{
				this.PhysicalScreenWidth = this.GameScreenWidth;
				this.PhysicalScreenHeight = this.GameScreenHeight;
			}
			this.MobileDensityYawScale = this.PhysicalScreenWidth / (this.GameScreenWidth * this.PhysicalDensityDpi);
			this.MobileDensityPitchScale = this.PhysicalScreenHeight / (this.GameScreenHeight * this.PhysicalDensityDpi);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "CameraModel MobileParam";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GameScreenWidth", this.GameScreenWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GameScreenHeight", this.GameScreenHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PhysicalScreenWidth", this.PhysicalScreenWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PhysicalScreenHeight", this.PhysicalScreenHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("PhysicalDensityDpi", this.PhysicalDensityDpi);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("MobileDensityYawScale", this.MobileDensityYawScale);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("MobileDensityPitchScale", this.MobileDensityPitchScale);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}

		// Token: 0x0603E48E RID: 255118 RVA: 0x0121A134 File Offset: 0x01218334
		private unsafe void UpdateCloudGameParam()
		{
			int deviceScreenWidth = CloudGameManager.Instance.DeviceScreenWidth;
			int deviceScreenHeight = CloudGameManager.Instance.DeviceScreenHeight;
			this.PhysicalDensityDpi = (float)CloudGameManager.Instance.CloudGameDpi;
			int screenWidth = CloudGameManager.Instance.ScreenWidth;
			int screenHeight = CloudGameManager.Instance.ScreenHeight;
			this.GameScreenWidth = (float)Math.Max(screenWidth, screenHeight);
			this.GameScreenHeight = (float)Math.Min(screenWidth, screenHeight);
			this.PhysicalScreenWidth = (float)Math.Max(deviceScreenWidth, deviceScreenHeight);
			this.PhysicalScreenHeight = (float)Math.Min(deviceScreenWidth, deviceScreenHeight);
			if (MathUtils.Instance.IsNearlyEqual((double)this.PhysicalScreenWidth, 0.0, null) || MathUtils.Instance.IsNearlyEqual((double)this.PhysicalScreenHeight, 0.0, null))
			{
				this.PhysicalScreenWidth = this.GameScreenWidth;
				this.PhysicalScreenHeight = this.GameScreenHeight;
			}
			this.MobileDensityYawScale = this.PhysicalScreenWidth / (this.GameScreenWidth * this.PhysicalDensityDpi);
			this.MobileDensityPitchScale = this.PhysicalScreenHeight / (this.GameScreenHeight * this.PhysicalDensityDpi);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "CameraModel CloudGameParam";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GameScreenWidth", this.GameScreenWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GameScreenHeight", this.GameScreenHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("PhysicalScreenWidth", this.PhysicalScreenWidth);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PhysicalScreenHeight", this.PhysicalScreenHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("PhysicalDensityDpi", this.PhysicalDensityDpi);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("MobileDensityYawScale", this.MobileDensityYawScale);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("MobileDensityPitchScale", this.MobileDensityPitchScale);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}

		// Token: 0x17007675 RID: 30325
		// (get) Token: 0x0603E48F RID: 255119 RVA: 0x0121A35F File Offset: 0x0121855F
		public static CameraModel Instance
		{
			get
			{
				return CameraModel._Instance;
			}
		}

		// Token: 0x0603E490 RID: 255120 RVA: 0x0121A366 File Offset: 0x01218566
		public static CameraModel GetOrCreateInstance()
		{
			if (CameraModel._Instance == null)
			{
				CameraModel.CreateInstance();
			}
			return CameraModel._Instance;
		}

		// Token: 0x0603E491 RID: 255121 RVA: 0x0121A37A File Offset: 0x0121857A
		public static bool CreateInstance()
		{
			if (CameraModel._Instance != null)
			{
				return true;
			}
			CameraModel._Instance = new CameraModel();
			return true;
		}

		// Token: 0x0603E492 RID: 255122 RVA: 0x0121A390 File Offset: 0x01218590
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E493 RID: 255123 RVA: 0x0121A392 File Offset: 0x01218592
		public static void ResetStaticDefaultValue()
		{
			CameraModel._Instance = null;
		}

		// Token: 0x0603E494 RID: 255124 RVA: 0x0121A39A File Offset: 0x0121859A
		static CameraModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CameraModel.CreateStaticDefaultValue), new Action(CameraModel.ResetStaticDefaultValue));
		}

		// Token: 0x040212A7 RID: 135847
		public const string MAIN_CAMERA = "MainCamera";

		// Token: 0x040212A8 RID: 135848
		public const float CAMER_DEFAULT_NEAR_CLIP = 10f;

		// Token: 0x040212A9 RID: 135849
		internal const int MIN_PHYSICAL_DENSITY_DPI = 160;

		// Token: 0x040212AA RID: 135850
		internal const int DEFAULT_DPI = 180;

		// Token: 0x040212AC RID: 135852
		private readonly Dictionary<string, CameraModelInstance> CameraModelInstanceMap = new Dictionary<string, CameraModelInstance>();

		// Token: 0x040212AD RID: 135853
		private float GameScreenWidth;

		// Token: 0x040212AE RID: 135854
		private float GameScreenHeight;

		// Token: 0x040212AF RID: 135855
		private float PhysicalScreenWidth;

		// Token: 0x040212B0 RID: 135856
		private float PhysicalScreenHeight;

		// Token: 0x040212B1 RID: 135857
		private float PhysicalScreenWidthV2;

		// Token: 0x040212B2 RID: 135858
		private float PhysicalScreenHeightV2;

		// Token: 0x040212B3 RID: 135859
		private float DisplayScreenWidth;

		// Token: 0x040212B4 RID: 135860
		private float DisplayScreenHeight;

		// Token: 0x040212B5 RID: 135861
		private float PhysicalDensityDpi;

		// Token: 0x040212B6 RID: 135862
		private float RealPhysicalDensityDpi;

		// Token: 0x040212B7 RID: 135863
		public float MobileDensityYawScale;

		// Token: 0x040212B8 RID: 135864
		public float MobileDensityPitchScale;

		// Token: 0x040212B9 RID: 135865
		[Nullable(2)]
		private static CameraModel _Instance;
	}
}
