using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Core.Framework;
using CSharpScript.Game.GameSettings;
using CSharpScript.Launcher.Platform;
using UnrealEngine;

namespace CSharpScript.Game.Module.KuroAutoCool
{
	// Token: 0x0200477A RID: 18298
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class KuroAutoCoolController : ControllerBase
	{
		// Token: 0x0602DF2B RID: 188203 RVA: 0x00CDB464 File Offset: 0x00CD9664
		public void SetMaxFrameRate(int fps)
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("t.MaxFPS ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(fps);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x0602DF2C RID: 188204 RVA: 0x00CDB4A1 File Offset: 0x00CD96A1
		public int GetMaxFrameRate()
		{
			return (int)UKismetSystemLibrary.GetConsoleVariableFloatValue("t.MaxFPS");
		}

		// Token: 0x0602DF2D RID: 188205 RVA: 0x00CDB4AE File Offset: 0x00CD96AE
		public int? GetCurrentValue(int handle)
		{
			return GameSettingsManager.Instance.GetCurrentValue((EFunction)handle, true, true);
		}

		// Token: 0x0602DF2E RID: 188206 RVA: 0x00CDB4C0 File Offset: 0x00CD96C0
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

		// Token: 0x0602DF2F RID: 188207 RVA: 0x00CDB548 File Offset: 0x00CD9748
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

		// Token: 0x0602DF30 RID: 188208 RVA: 0x00CDB5D0 File Offset: 0x00CD97D0
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

		// Token: 0x0602DF31 RID: 188209 RVA: 0x00CDB9BC File Offset: 0x00CD9BBC
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

		// Token: 0x0602DF32 RID: 188210 RVA: 0x00CDBCEC File Offset: 0x00CD9EEC
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

		// Token: 0x0602DF33 RID: 188211 RVA: 0x00CDBD9C File Offset: 0x00CD9F9C
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

		// Token: 0x0602DF34 RID: 188212 RVA: 0x00CDBE0C File Offset: 0x00CDA00C
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
				float num6 = 0f;
				foreach (float num7 in this.fpsHistory)
				{
					num6 += num7;
				}
				float num8 = (this.fpsHistory.Count > 0) ? (num6 / (float)this.fpsHistory.Count) : 0f;
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
				float num9 = Math.Min(val, (float)this.GetMaxFrameRate()) * 0.9f;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Render;
				ELogAuthor author2 = ELogAuthor.LQX;
				string message2 = "5秒窗口统计";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("JankCount", num4);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CurrentFrameTime", delta);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("FpsThreshold", num9);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("AvgFPS", num8);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				if (!this.IsAutoCoolState && (this.consecutiveJankWindows >= 2 || num8 < num9))
				{
					Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "触发降画质", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.ReduceImageQualityAndFrameRate((int)num);
				}
				else if (this.IsAutoCoolState && (num4 >= 1 || num8 < num9))
				{
					Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "维持降画质状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				else if (this.IsAutoCoolState && this.consecutiveNoJankWindows >= 3 && num8 >= num9)
				{
					Log.Instance.Info(ELogModule.Render, ELogAuthor.LQX, "恢复升画质", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.RestoreImageQualityAndFrameRate((int)num);
				}
				this.CheckCount = 0;
			}
		}

		// Token: 0x0602DF35 RID: 188213 RVA: 0x00CDC234 File Offset: 0x00CDA434
		protected override bool OnInit()
		{
			this.TemperatureDelegate = DelegateUtils.ToManualReleaseDelegate<FGetCurrentTemperatureDataDelegate>(new Action<bool, float, float>(this.OnGetTemperatureDataFromMAGT));
			this.IsAutoCoolState = false;
			return true;
		}

		// Token: 0x0602DF36 RID: 188214 RVA: 0x00CDC255 File Offset: 0x00CDA455
		protected override bool OnClear()
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, float, float>(this.OnGetTemperatureDataFromMAGT));
			this.TemperatureDelegate = null;
			return true;
		}

		// Token: 0x0602DF37 RID: 188215 RVA: 0x00CDC270 File Offset: 0x00CDA470
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

		// Token: 0x17005C9A RID: 23706
		// (get) Token: 0x0602DF38 RID: 188216 RVA: 0x00CDC307 File Offset: 0x00CDA507
		public static KuroAutoCoolController Instance
		{
			get
			{
				return KuroAutoCoolController._Instance;
			}
		}

		// Token: 0x0602DF39 RID: 188217 RVA: 0x00CDC30E File Offset: 0x00CDA50E
		public static KuroAutoCoolController GetOrCreateInstance()
		{
			if (KuroAutoCoolController._Instance == null)
			{
				KuroAutoCoolController.CreateInstance();
			}
			return KuroAutoCoolController._Instance;
		}

		// Token: 0x0602DF3A RID: 188218 RVA: 0x00CDC322 File Offset: 0x00CDA522
		public static bool CreateInstance()
		{
			if (KuroAutoCoolController._Instance != null)
			{
				return true;
			}
			KuroAutoCoolController._Instance = new KuroAutoCoolController();
			return true;
		}

		// Token: 0x0602DF3B RID: 188219 RVA: 0x00CDC338 File Offset: 0x00CDA538
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DF3C RID: 188220 RVA: 0x00CDC33A File Offset: 0x00CDA53A
		public static void ResetStaticDefaultValue()
		{
			KuroAutoCoolController._Instance = null;
		}

		// Token: 0x0602DF3D RID: 188221 RVA: 0x00CDC342 File Offset: 0x00CDA542
		static KuroAutoCoolController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KuroAutoCoolController.CreateStaticDefaultValue), new Action(KuroAutoCoolController.ResetStaticDefaultValue));
		}

		// Token: 0x0401886A RID: 100458
		private const int CHECK_TIME = 10000;

		// Token: 0x0401886B RID: 100459
		private const bool DebugLogEnabled = true;

		// Token: 0x0401886C RID: 100460
		private const int CpuTemperatureThreshold = 65;

		// Token: 0x0401886D RID: 100461
		private const int FpsThreshold = 50;

		// Token: 0x0401886E RID: 100462
		private int CheckCount;

		// Token: 0x0401886F RID: 100463
		private bool IsAutoCoolState;

		// Token: 0x04018870 RID: 100464
		private const int ResolutionThreshold = 1;

		// Token: 0x04018871 RID: 100465
		private const int NiagaraThreshold = 1;

		// Token: 0x04018872 RID: 100466
		private const int ImageDetailThreshold = 1;

		// Token: 0x04018873 RID: 100467
		private const int VolumeLightThreshold = 0;

		// Token: 0x04018874 RID: 100468
		private const int NpcDensityThreshold = 1;

		// Token: 0x04018875 RID: 100469
		private const int ShadowThreshold = 1;

		// Token: 0x04018876 RID: 100470
		[Nullable(2)]
		public FGetCurrentTemperatureDataDelegate TemperatureDelegate;

		// Token: 0x04018877 RID: 100471
		private List<float> frameTimes = new List<float>();

		// Token: 0x04018878 RID: 100472
		private List<int> jankCountHistory = new List<int>();

		// Token: 0x04018879 RID: 100473
		private List<float> fpsHistory = new List<float>();

		// Token: 0x0401887A RID: 100474
		private long lastJankCheckTime;

		// Token: 0x0401887B RID: 100475
		private int consecutiveJankWindows;

		// Token: 0x0401887C RID: 100476
		private int consecutiveNoJankWindows;

		// Token: 0x0401887D RID: 100477
		private const int jankCheckInterval = 5000;

		// Token: 0x0401887E RID: 100478
		[Nullable(2)]
		private static KuroAutoCoolController _Instance;
	}
}
