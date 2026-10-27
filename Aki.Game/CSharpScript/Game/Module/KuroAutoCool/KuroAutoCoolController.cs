using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Core.Framework;
using CSharpScript.Game.GameSettings;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Game.Module.KuroAutoCool
{
	// Token: 0x020057A3 RID: 22435
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class KuroAutoCoolController : ControllerBase
	{
		// Token: 0x0603901B RID: 233499 RVA: 0x00D8C6E8 File Offset: 0x00D8A8E8
		public void SetMaxFrameRate(int fps)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("t.MaxFPS ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(fps);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x0603901C RID: 233500 RVA: 0x00D8C725 File Offset: 0x00D8A925
		public int GetMaxFrameRate()
		{
			return (int)UKismetSystemLibrary.GetConsoleVariableFloatValue("t.MaxFPS");
		}

		// Token: 0x0603901D RID: 233501 RVA: 0x00D8C732 File Offset: 0x00D8A932
		public int? GetCurrentValue(int handle)
		{
			return GameSettingsManager.Instance.GetCurrentValue((EFunction)handle, true, true);
		}

		// Token: 0x0603901E RID: 233502 RVA: 0x00D8C744 File Offset: 0x00D8A944
		public void ApplyNiagaraQuality(int value)
		{
			bool flag = GameSettingsDeviceRender.Instance.IsIosAndAndroidHighDevice();
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.DisableDistortion ");
			defaultInterpolatedStringHandler.AppendFormatted<int>((value > 0 && flag) ? 0 : 1);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			UObject world2 = GlobalData.World;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("fx.Niagara.QualityLevel ");
			defaultInterpolatedStringHandler.AppendFormatted<int>((value > 0) ? 1 : 0);
			UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x0603901F RID: 233503 RVA: 0x00D8C7CC File Offset: 0x00D8A9CC
		public void ApplyMobileResolution(int value)
		{
			float num = (float)GameSettingsDeviceRender.Instance.GetMobileResolutionByIndex(value);
			float consoleVariableFloatValue = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.SecondaryScreenPercentage.GameViewport");
			if (GameSettingsDeviceRender.Instance.GetDefaultScreenResolution().Y < 750 && consoleVariableFloatValue < 70f)
			{
				num = Math.Min(num * 1.5f, 100f);
			}
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.ScreenPercentage ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(num);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x06039020 RID: 233504 RVA: 0x00D8C854 File Offset: 0x00D8AA54
		public unsafe void ReduceImageQualityAndFrameRate(int currentFps)
		{
			int? currentValue = this.GetCurrentValue(67);
			int? currentValue2 = this.GetCurrentValue(55);
			int? currentValue3 = this.GetCurrentValue(64);
			int? currentValue4 = this.GetCurrentValue(56);
			int? currentValue5 = this.GetCurrentValue(54);
			int? currentValue6 = this.GetCurrentValue(79);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.YJL;
			string message = "自动渲染调节触发前";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentFps", currentFps);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Resolution", currentValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Niagara", currentValue2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ImageDetail", currentValue4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("VolumeLight", currentValue3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Shadow", currentValue5);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("NpcDensity", currentValue6);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			if (currentFps > 55)
			{
				this.IsAutoCoolState = true;
				this.SetMaxFrameRate(55);
				currentFps = 55;
				if (currentValue2 != null)
				{
					int? num = currentValue2;
					int num2 = 1;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						this.ApplyNiagaraQuality(1);
						currentValue2 = new int?(1);
					}
				}
				if (currentValue != null)
				{
					int? num = currentValue;
					int num2 = 1;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						this.ApplyMobileResolution(1);
						currentValue = new int?(1);
					}
				}
			}
			else if (currentFps > 50 && currentFps <= 55)
			{
				this.IsAutoCoolState = true;
				this.SetMaxFrameRate(50);
				currentFps = 50;
				if (currentValue3 != null)
				{
					int? num = currentValue3;
					int num2 = 0;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						GameSettingsUtils.ApplyVolumeLight(0);
						currentValue3 = new int?(0);
					}
				}
				if (currentValue4 != null)
				{
					int? num = currentValue4;
					int num2 = 1;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						GameSettingsUtils.ApplyImageDetail(1);
						currentValue4 = new int?(1);
					}
				}
			}
			else if (currentFps > 45 && currentFps <= 50)
			{
				this.IsAutoCoolState = true;
				this.SetMaxFrameRate(45);
				currentFps = 45;
				if (currentValue6 != null)
				{
					int? num = currentValue6;
					int num2 = 1;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						GameSettingsUtils.ApplyNpcDensity(1);
						currentValue6 = new int?(1);
					}
				}
			}
			else if (currentFps > 40 && currentFps <= 45)
			{
				this.IsAutoCoolState = true;
				this.SetMaxFrameRate(40);
				currentFps = 40;
				if (currentValue5 != null)
				{
					int? num = currentValue5;
					int num2 = 1;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						GameSettingsUtils.ApplyShadowQuality(1);
						currentValue5 = new int?(1);
					}
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Render;
			ELogAuthor author2 = ELogAuthor.YJL;
			string message2 = "自动渲染调节触发后";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CurrentFps", currentFps);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Resolution", currentValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Niagara", currentValue2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("ImageDetail", currentValue4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("VolumeLight", currentValue3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("Shadow", currentValue5);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("NpcDensity", currentValue6);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 7));
		}

		// Token: 0x06039021 RID: 233505 RVA: 0x00D8CC40 File Offset: 0x00D8AE40
		public unsafe void RestoreImageQualityAndFrameRate(int currentFps)
		{
			int? currentValue = this.GetCurrentValue(67);
			int? currentValue2 = this.GetCurrentValue(55);
			int? currentValue3 = this.GetCurrentValue(64);
			int? currentValue4 = this.GetCurrentValue(56);
			int? currentValue5 = this.GetCurrentValue(54);
			int? currentValue6 = this.GetCurrentValue(79);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.YJL;
			string message = "自动渲染调节恢复前";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurrentFps", currentFps);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (Platform.Instance.IsMobilePlatform())
			{
				this.IsAutoCoolState = false;
			}
			int num = currentFps;
			if (currentFps >= 55)
			{
				this.IsAutoCoolState = false;
				MenuModel instance2 = MenuModel.Instance;
				int valueOrDefault = ((instance2 != null) ? instance2.GetDataCacheOrCurValue(EFunction.HIGHESTFPS) : null).GetValueOrDefault();
				num = GameSettingsDeviceRender.Instance.GetFrameByList(valueOrDefault);
				if (currentValue2 != null)
				{
					int? num2 = currentValue2;
					int num3 = 1;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						this.ApplyNiagaraQuality(currentValue2.Value);
					}
				}
				if (currentValue != null)
				{
					int? num2 = currentValue;
					int num3 = 1;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						this.ApplyMobileResolution(currentValue.Value);
					}
				}
			}
			else if (currentFps >= 50 && currentFps < 55)
			{
				num = 55;
				if (currentValue3 != null)
				{
					int? num2 = currentValue3;
					int num3 = 0;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						GameSettingsUtils.ApplyVolumeLight(currentValue3.Value);
					}
				}
				if (currentValue4 != null)
				{
					int? num2 = currentValue4;
					int num3 = 1;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						GameSettingsUtils.ApplyImageDetail(currentValue4.Value);
					}
				}
			}
			else if (currentFps >= 45 && currentFps < 50)
			{
				num = 50;
				if (currentValue6 != null)
				{
					int? num2 = currentValue6;
					int num3 = 1;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						GameSettingsUtils.ApplyNpcDensity(currentValue6.Value);
					}
				}
			}
			else if (currentFps >= 40 && currentFps < 45)
			{
				num = 45;
				if (currentValue5 != null)
				{
					int? num2 = currentValue5;
					int num3 = 1;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						GameSettingsUtils.ApplyShadowQuality(currentValue5.Value);
					}
				}
			}
			this.SetMaxFrameRate(num);
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.Render;
			ELogAuthor author2 = ELogAuthor.YJL;
			string message2 = "自动渲染调节恢复后";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MaxFps", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Resolution", currentValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Niagara", currentValue2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ImageDetail", currentValue4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("VolumeLight", currentValue3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("NpcDensity", currentValue6);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("Shadow", currentValue5);
			instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}

		// Token: 0x06039022 RID: 233506 RVA: 0x00D8CF70 File Offset: 0x00D8B170
		private unsafe void OnGetTemperatureDataFromMAGT(bool bResult, float currentTemperature, float tempBudget)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.YJL;
			string message = "KuroAutoCoolController.temperature";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bResult", bResult);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentTemperature", currentTemperature);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("tempBudget", tempBudget);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			int maxFps = UKuroRenderingRuntimeBPPluginBPLibrary.GetMaxFps();
			if (!bResult || tempBudget <= 5f)
			{
				this.ReduceImageQualityAndFrameRate(maxFps);
				return;
			}
			if (this.IsAutoCoolState)
			{
				this.RestoreImageQualityAndFrameRate(maxFps);
			}
		}

		// Token: 0x06039023 RID: 233507 RVA: 0x00D8D020 File Offset: 0x00D8B220
		private void OnGetTemperatureDataFromOthers()
		{
			int cpuTemperature = UKuroRenderingRuntimeBPPluginBPLibrary.GetCpuTemperature();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.YJL;
			string message = "当前CPU温度";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CpuTemperature", cpuTemperature);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CheckCount = 0;
			int maxFps = UKuroRenderingRuntimeBPPluginBPLibrary.GetMaxFps();
			if (this.IsAutoCoolState && cpuTemperature < 65)
			{
				this.RestoreImageQualityAndFrameRate(maxFps);
				return;
			}
			if (cpuTemperature >= 65)
			{
				this.ReduceImageQualityAndFrameRate(maxFps);
			}
		}

		// Token: 0x06039024 RID: 233508 RVA: 0x00D8D090 File Offset: 0x00D8B290
		private unsafe void OnAutoAdjustImageQualityPcPlatform(float delta)
		{
			if (delta <= 0f)
			{
				return;
			}
			float num = 1000f / delta;
			this.fpsHistory.Add(num);
			this.frameTimes.Add(delta);
			if (this.frameTimes.Count > 3)
			{
				this.frameTimes.RemoveAt(0);
			}
			if (this.frameTimes.Count == 3)
			{
				float num2 = (this.frameTimes[0] + this.frameTimes[1] + this.frameTimes[2]) / 3f;
				bool flag = delta > num2 * 2f && delta > 84f;
				this.jankCountHistory.Add((flag > false) ? 1 : 0);
				if (flag)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Render;
					ELogAuthor author = ELogAuthor.LQX;
					string message = "检测到Jank帧";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentFrameTime", delta);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AvgLast3FrameTime", num2);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			long num3 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			if (num3 - this.lastJankCheckTime >= 5000L)
			{
				int num4 = 0;
				foreach (int num5 in this.jankCountHistory)
				{
					num4 += num5;
				}
				float num6 = (this.fpsHistory.Count > 0) ? (this.fpsHistory.Sum() / (float)this.fpsHistory.Count) : 0f;
				this.lastJankCheckTime = num3;
				this.jankCountHistory.Clear();
				this.fpsHistory.Clear();
				if (num4 >= 2)
				{
					this.consecutiveJankWindows++;
					this.consecutiveNoJankWindows = 0;
				}
				else if (num4 >= 1)
				{
					this.consecutiveNoJankWindows = 0;
				}
				else
				{
					this.consecutiveNoJankWindows++;
					this.consecutiveJankWindows = 0;
				}
				float val = 50f;
				EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
				if (recommendQualityLv != null)
				{
					DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(recommendQualityLv.Value);
					if (deviceRenderFeature != null)
					{
						int? valueOrNull = GameSettingsDeviceRender.Instance.GetOtherChangedValue(deviceRenderFeature.Value).GetValueOrNull(EFunction.HIGHESTFPS);
						if (valueOrNull != null)
						{
							val = (float)GameSettingsDeviceRender.Instance.GetFrameByList(valueOrNull.Value);
						}
					}
				}
				float num7 = Math.Min(val, (float)this.GetMaxFrameRate()) * 0.9f;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Render;
				ELogAuthor author2 = ELogAuthor.LQX;
				string message2 = "5秒窗口统计";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("JankCount", num4);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CurrentFrameTime", delta);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("FpsThreshold", num7);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("AvgFPS", num6);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				if (!this.IsAutoCoolState && (this.consecutiveJankWindows >= 2 || num6 < num7))
				{
					Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "触发降画质", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.ReduceImageQualityAndFrameRate((int)num);
				}
				else if (this.IsAutoCoolState && (num4 >= 1 || num6 < num7))
				{
					Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "维持降画质状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else if (this.IsAutoCoolState && this.consecutiveNoJankWindows >= 3 && num6 >= num7)
				{
					Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "恢复升画质", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.RestoreImageQualityAndFrameRate((int)num);
				}
				this.CheckCount = 0;
			}
		}

		// Token: 0x06039025 RID: 233509 RVA: 0x00D8D478 File Offset: 0x00D8B678
		protected override bool OnInit()
		{
			this.TemperatureDelegate = DelegateUtils.ToManualReleaseDelegate<FGetCurrentTemperatureDataDelegate>(new Action<bool, float, float>(this.OnGetTemperatureDataFromMAGT));
			this.IsAutoCoolState = false;
			return true;
		}

		// Token: 0x06039026 RID: 233510 RVA: 0x00D8D499 File Offset: 0x00D8B699
		protected override bool OnClear()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, float, float>(this.OnGetTemperatureDataFromMAGT));
			this.TemperatureDelegate = null;
			return true;
		}

		// Token: 0x06039027 RID: 233511 RVA: 0x00D8D4B4 File Offset: 0x00D8B6B4
		protected override void OnTick(float delta)
		{
			if (UKuroRenderingRuntimeBPPluginBPLibrary.GetCVarFloat("r.Kuro.AutoCoolEnable") > 0f && UKuroRenderingRuntimeBPPluginBPLibrary.GetCVarFloat("r.Kuro.AutoCoolUIEnable") > 0f)
			{
				this.CheckCount += (int)delta;
				if (this.CheckCount < 10000)
				{
					return;
				}
				if (Platform.Instance.IsMobilePlatform())
				{
					if (KuroPerformanceController.Instance.IsEnable)
					{
						UKuroPerformanceBPLibrary.GetCurrentTemperatureData(this.TemperatureDelegate);
					}
					else
					{
						this.OnGetTemperatureDataFromOthers();
					}
				}
				else if (Platform.Instance.IsPcPlatform())
				{
					this.OnAutoAdjustImageQualityPcPlatform(delta);
				}
				this.CheckCount = 0;
			}
		}

		// Token: 0x170088D2 RID: 35026
		// (get) Token: 0x06039028 RID: 233512 RVA: 0x00D8D54B File Offset: 0x00D8B74B
		public static KuroAutoCoolController Instance
		{
			get
			{
				return KuroAutoCoolController._Instance;
			}
		}

		// Token: 0x06039029 RID: 233513 RVA: 0x00D8D552 File Offset: 0x00D8B752
		public static KuroAutoCoolController GetOrCreateInstance()
		{
			if (KuroAutoCoolController._Instance == null)
			{
				KuroAutoCoolController.CreateInstance();
			}
			return KuroAutoCoolController._Instance;
		}

		// Token: 0x0603902A RID: 233514 RVA: 0x00D8D566 File Offset: 0x00D8B766
		public static bool CreateInstance()
		{
			if (KuroAutoCoolController._Instance != null)
			{
				return true;
			}
			KuroAutoCoolController._Instance = new KuroAutoCoolController();
			return true;
		}

		// Token: 0x0603902B RID: 233515 RVA: 0x00D8D57C File Offset: 0x00D8B77C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603902C RID: 233516 RVA: 0x00D8D57E File Offset: 0x00D8B77E
		public static void ResetStaticDefaultValue()
		{
			KuroAutoCoolController._Instance = null;
		}

		// Token: 0x0603902D RID: 233517 RVA: 0x00D8D586 File Offset: 0x00D8B786
		static KuroAutoCoolController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KuroAutoCoolController.CreateStaticDefaultValue), new Action(KuroAutoCoolController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DDD4 RID: 122324
		private const int CHECK_TIME = 10000;

		// Token: 0x0401DDD5 RID: 122325
		private const bool DebugLogEnabled = true;

		// Token: 0x0401DDD6 RID: 122326
		private const int CpuTemperatureThreshold = 65;

		// Token: 0x0401DDD7 RID: 122327
		private const int FpsThreshold = 50;

		// Token: 0x0401DDD8 RID: 122328
		private int CheckCount;

		// Token: 0x0401DDD9 RID: 122329
		private bool IsAutoCoolState;

		// Token: 0x0401DDDA RID: 122330
		private const int ResolutionThreshold = 1;

		// Token: 0x0401DDDB RID: 122331
		private const int NiagaraThreshold = 1;

		// Token: 0x0401DDDC RID: 122332
		private const int ImageDetailThreshold = 1;

		// Token: 0x0401DDDD RID: 122333
		private const int VolumeLightThreshold = 0;

		// Token: 0x0401DDDE RID: 122334
		private const int NpcDensityThreshold = 1;

		// Token: 0x0401DDDF RID: 122335
		private const int ShadowThreshold = 1;

		// Token: 0x0401DDE0 RID: 122336
		[Nullable(2)]
		public FGetCurrentTemperatureDataDelegate TemperatureDelegate;

		// Token: 0x0401DDE1 RID: 122337
		private List<float> frameTimes = new List<float>();

		// Token: 0x0401DDE2 RID: 122338
		private List<int> jankCountHistory = new List<int>();

		// Token: 0x0401DDE3 RID: 122339
		private List<float> fpsHistory = new List<float>();

		// Token: 0x0401DDE4 RID: 122340
		private long lastJankCheckTime;

		// Token: 0x0401DDE5 RID: 122341
		private int consecutiveJankWindows;

		// Token: 0x0401DDE6 RID: 122342
		private int consecutiveNoJankWindows;

		// Token: 0x0401DDE7 RID: 122343
		private const int jankCheckInterval = 5000;

		// Token: 0x0401DDE8 RID: 122344
		[Nullable(2)]
		private static KuroAutoCoolController _Instance;
	}
}
