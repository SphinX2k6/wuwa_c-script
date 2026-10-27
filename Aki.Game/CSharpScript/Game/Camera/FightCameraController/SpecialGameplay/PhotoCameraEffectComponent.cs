using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072FD RID: 29437
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Effect)]
	public class PhotoCameraEffectComponent : PhotoCameraComponentBase
	{
		// Token: 0x060483B9 RID: 295865 RVA: 0x0128E408 File Offset: 0x0128C608
		protected override void OnInit()
		{
			this.EnterTimeControl();
			this.EffectActor = ActorSystem.Instance.Spawn<BP_CameraEffect_C>(BP_CameraEffect_C.StaticClass(), new FTransformDouble(), null);
			if (this.EffectActor == null)
			{
				Log.Instance.Error(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:BP_CameraEffect 创建失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:BP_CameraEffect 创建完成", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060483BA RID: 295866 RVA: 0x0128E480 File Offset: 0x0128C680
		protected override void OnDestroy()
		{
			this.ExitTimeControl();
			this.CloseClusterEffect();
			this.ResetFrame();
			this.ResetWeather();
			if (this.EffectActor != null)
			{
				UKuroActorManager.DestroyActor(this.EffectActor);
				this.EffectActor = null;
			}
			this.WindStrengthMap.Clear();
			this.AtmosphereStrengthMap.Clear();
			this.LightDirectionMap.Clear();
			this.CurrentWindId = 0;
			this.CurrentAtmosphereId = 0;
			this.CurrentLightId = 0;
			this.UserSelectedLightId = 0;
			this.CurrentLight = null;
			Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:已销毁 BP_CameraEffect", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060483BB RID: 295867 RVA: 0x0128E528 File Offset: 0x0128C728
		public unsafe int SelectWind(int windId, int direction, int defaultStrength, bool isDefault)
		{
			this.CurrentWindId = windId;
			if (isDefault)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:选中默认风向,风力归零";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("windId", windId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ApplyWind(direction, 0f);
				return 0;
			}
			float num;
			if (!this.WindStrengthMap.TryGetValue(windId, out num))
			{
				num = (float)defaultStrength;
				this.WindStrengthMap[windId] = num;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PhotoCamera;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "拍照效果组件:选中风向";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("windId", windId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("direction", direction);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("strength", num);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.ApplyWind(direction, num);
			return (int)num;
		}

		// Token: 0x060483BC RID: 295868 RVA: 0x0128E624 File Offset: 0x0128C824
		public void SetWindStrength(float strength)
		{
			this.WindStrengthMap[this.CurrentWindId] = strength;
			float? strength2 = new float?(strength / 100f);
			this.SetWind(null, strength2);
		}

		// Token: 0x060483BD RID: 295869 RVA: 0x0128E661 File Offset: 0x0128C861
		private void ApplyWind(int direction, float strength)
		{
			this.SetWind(new float?((float)direction), new float?(strength / 100f));
		}

		// Token: 0x060483BE RID: 295870 RVA: 0x0128E67C File Offset: 0x0128C87C
		private void SetWind(float? direction = null, float? strength01 = null)
		{
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				Log.Instance.Error(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:风向写入失败,BP_CameraEffect 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (direction != null)
			{
				this.EffectActor.全局风方向 = direction.Value;
			}
			if (strength01 != null)
			{
				this.EffectActor.全局风强度 = strength01.Value;
			}
			this.EffectActor.UpdateWindFieldDirectoin();
		}

		// Token: 0x060483BF RID: 295871 RVA: 0x0128E700 File Offset: 0x0128C900
		public unsafe int SelectAtmosphere(int atmosphereId, EPhotoClusterEffectType effectType, int defaultStrength, bool isDefault)
		{
			this.CurrentAtmosphereId = atmosphereId;
			if (isDefault || effectType == EPhotoClusterEffectType.None)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:选中无氛围,关闭集群特效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("atmosphereId", atmosphereId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("effectType", effectType.ToString());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CloseClusterEffect();
				return 0;
			}
			float num;
			if (!this.AtmosphereStrengthMap.TryGetValue(atmosphereId, out num))
			{
				num = (float)defaultStrength;
				this.AtmosphereStrengthMap[atmosphereId] = num;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PhotoCamera;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "拍照效果组件:选中氛围";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("atmosphereId", atmosphereId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("effectType", effectType.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("strength", num);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			this.SetClusterEffectDensity(num / 100f);
			this.OpenClusterEffect(effectType);
			return (int)num;
		}

		// Token: 0x060483C0 RID: 295872 RVA: 0x0128E844 File Offset: 0x0128CA44
		public void SetAtmosphereStrength(float strength)
		{
			this.AtmosphereStrengthMap[this.CurrentAtmosphereId] = strength;
			this.SetClusterEffectDensity(strength / 100f);
		}

		// Token: 0x060483C1 RID: 295873 RVA: 0x0128E868 File Offset: 0x0128CA68
		private unsafe void OpenClusterEffect(EPhotoClusterEffectType effectType)
		{
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:集群特效开启失败,BP_CameraEffect 无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("effectType", effectType.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!Enum.IsDefined(typeof(EPhotoClusterEffectType), effectType))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PhotoCamera;
				ELogAuthor author2 = ELogAuthor.CXJ;
				string message2 = "拍照效果组件:氛围配表集群特效类型非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("atmosphereId", this.CurrentAtmosphereId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("effectType", (int)effectType);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.CurrentClusterEffectType = EPhotoClusterEffectType.None;
				return;
			}
			if (this.CurrentClusterEffectType != EPhotoClusterEffectType.None)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PhotoCamera;
				ELogAuthor author3 = ELogAuthor.CXJ;
				string message3 = "拍照效果组件:切换前关闭旧集群特效";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("oldEffectType", this.CurrentClusterEffectType.ToString());
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.EffectActor.SetNiagaraEffect(0);
			}
			this.EffectActor.SetNiagaraEffect((int)effectType);
			this.CurrentClusterEffectType = effectType;
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.PhotoCamera;
			ELogAuthor author4 = ELogAuthor.CXJ;
			string message4 = "拍照效果组件:集群特效已开启";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("effectType", effectType.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("index", (int)effectType);
			instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}

		// Token: 0x060483C2 RID: 295874 RVA: 0x0128EA10 File Offset: 0x0128CC10
		private void CloseClusterEffect()
		{
			if (this.CurrentClusterEffectType == EPhotoClusterEffectType.None)
			{
				return;
			}
			EPhotoClusterEffectType currentClusterEffectType = this.CurrentClusterEffectType;
			this.CurrentClusterEffectType = EPhotoClusterEffectType.None;
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:集群特效关闭失败,BP_CameraEffect 无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("effectType", currentClusterEffectType.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.EffectActor.SetNiagaraEffect(0);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PhotoCamera;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "拍照效果组件:集群特效已关闭";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("effectType", currentClusterEffectType.ToString());
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x060483C3 RID: 295875 RVA: 0x0128EAC4 File Offset: 0x0128CCC4
		private void SetClusterEffectDensity(float density)
		{
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				Log.Instance.Error(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:集群特效密度写入失败,BP_CameraEffect 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.EffectActor.集群特效密度 = density;
		}

		// Token: 0x060483C4 RID: 295876 RVA: 0x0128EB14 File Offset: 0x0128CD14
		public unsafe void SelectWeather(int weatherId, bool isDefault)
		{
			this.CurrentWeatherId = (isDefault ? 0 : weatherId);
			if (isDefault)
			{
				Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:选中默认天气,清空PPV天气DA", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CancelWeatherLoadTask();
				this.ApplyWeatherDA(null);
				return;
			}
			Weather? config = ConfigWeatherById.GetConfig(weatherId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:天气配表缺失";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("weatherId", weatherId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			string daPath = config.Value.DAPath;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PhotoCamera;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "拍照效果组件:选中天气";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("weatherId", weatherId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("daPath", daPath);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.CancelWeatherLoadTask();
			this.WeatherLoadTask = ResourceSystem.Instance.LoadAsync<UKuroWeatherDataAsset>(daPath, delegate([Nullable(2)] UKuroWeatherDataAsset dataAsset, string _)
			{
				this.WeatherLoadTask = 0;
				if (dataAsset == null || !dataAsset.IsValid())
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.PhotoCamera;
					ELogAuthor author3 = ELogAuthor.CXJ;
					string message3 = "拍照效果组件:天气DA加载失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("weatherId", weatherId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("daPath", daPath);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					return;
				}
				if (this.CurrentWeatherId != weatherId)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.PhotoCamera;
					ELogAuthor author4 = ELogAuthor.CXJ;
					string message4 = "拍照效果组件:天气DA加载完成但已切走,丢弃";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("loadedWeatherId", weatherId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("currentWeatherId", this.CurrentWeatherId);
					instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					return;
				}
				this.ApplyWeatherDA(dataAsset);
			}, ResourceSystem.EResourceLoadPriority.Default, "Ui.WeatherUi");
		}

		// Token: 0x060483C5 RID: 295877 RVA: 0x0128EC6D File Offset: 0x0128CE6D
		public int GetCurrentWeatherId()
		{
			return this.CurrentWeatherId;
		}

		// Token: 0x060483C6 RID: 295878 RVA: 0x0128EC78 File Offset: 0x0128CE78
		[NullableContext(2)]
		private void ApplyWeatherDA(UKuroWeatherDataAsset dataAsset)
		{
			if (dataAsset == null)
			{
				WeatherModel.Instance.GetWorldWeatherActor().RestorePostProcessWeight();
			}
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				Log.Instance.Error(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:天气写入失败,BP_CameraEffect 无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.EffectActor.SetPPVWeatherDA(dataAsset);
			if (dataAsset != null)
			{
				WeatherModel.Instance.GetWorldWeatherActor().SuppressPostProcessWeight();
			}
			if (!this.IsPPVPriorityApplied)
			{
				this.EffectActor.SetPPVPriority(9999999f);
				this.IsPPVPriorityApplied = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:PPV优先级已设置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("priority", 9999999f);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060483C7 RID: 295879 RVA: 0x0128ED3C File Offset: 0x0128CF3C
		private void CancelWeatherLoadTask()
		{
			if (this.WeatherLoadTask != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.WeatherLoadTask);
				this.WeatherLoadTask = 0;
			}
		}

		// Token: 0x060483C8 RID: 295880 RVA: 0x0128ED60 File Offset: 0x0128CF60
		private void ResetWeather()
		{
			this.CancelWeatherLoadTask();
			this.CurrentWeatherId = 0;
			this.ApplyWeatherDA(null);
			this.IsPPVPriorityApplied = false;
			Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:天气已复位,PPV天气DA已清空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060483C9 RID: 295881 RVA: 0x0128EDA8 File Offset: 0x0128CFA8
		private void EnterTimeControl()
		{
			if (this.IsTimeControlEntered)
			{
				return;
			}
			BP_GlobalGI_C globalGIActor = this.GetGlobalGIActor();
			if (globalGIActor == null)
			{
				Log.Instance.Error(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:时间接管失败,BP_GlobalGI 取不到", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.PhotoTimeHour = (float)TodDayTime.ConvertToHour(TimeOfDayModel.Instance.GameTime.Second);
			globalGIActor.bEnableUpdateTimeTick = false;
			globalGIActor.UpdateTimeOnce(this.PhotoTimeHour);
			this.IsTimeControlEntered = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "拍照效果组件:已接管时间,关闭GI时间Tick";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("hour", this.PhotoTimeHour);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060483CA RID: 295882 RVA: 0x0128EE54 File Offset: 0x0128D054
		public void SetPhotoTime(float hour)
		{
			BP_GlobalGI_C globalGIActor = this.GetGlobalGIActor();
			if (globalGIActor == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:时间写入失败,BP_GlobalGI 取不到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("hour", hour);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.PhotoTimeHour = hour;
			globalGIActor.UpdateTimeOnce(hour);
		}

		// Token: 0x060483CB RID: 295883 RVA: 0x0128EEA9 File Offset: 0x0128D0A9
		public float GetPhotoTime()
		{
			if (this.PhotoTimeHour < 0f)
			{
				return (float)TodDayTime.ConvertToHour(TimeOfDayModel.Instance.GameTime.Second);
			}
			return this.PhotoTimeHour;
		}

		// Token: 0x060483CC RID: 295884 RVA: 0x0128EED4 File Offset: 0x0128D0D4
		private void ExitTimeControl()
		{
			if (!this.IsTimeControlEntered)
			{
				return;
			}
			this.IsTimeControlEntered = false;
			this.PhotoTimeHour = -1f;
			BP_GlobalGI_C globalGIActor = this.GetGlobalGIActor();
			if (globalGIActor == null)
			{
				Log.Instance.Error(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:时间还原失败,BP_GlobalGI 取不到", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			globalGIActor.bEnableUpdateTimeTick = true;
			Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:已交回时间控制权,恢复GI时间Tick", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060483CD RID: 295885 RVA: 0x0128EF4C File Offset: 0x0128D14C
		[NullableContext(2)]
		private BP_GlobalGI_C GetGlobalGIActor()
		{
			UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
			return ((kuroGISystem != null) ? kuroGISystem.GetKuroGlobalGIActor() : null) as BP_GlobalGI_C;
		}

		// Token: 0x060483CE RID: 295886 RVA: 0x0128EF69 File Offset: 0x0128D169
		public int SelectLight(PhotoLight data)
		{
			this.UserSelectedLightId = data.Id;
			return this.ApplyLight(data);
		}

		// Token: 0x060483CF RID: 295887 RVA: 0x0128EF80 File Offset: 0x0128D180
		public unsafe int ApplyLight(PhotoLight data)
		{
			this.CurrentLightId = data.Id;
			this.CurrentLight = new PhotoLight?(data);
			float direction;
			if (!this.LightDirectionMap.TryGetValue(data.Id, out direction))
			{
				direction = data.Direction;
				this.LightDirectionMap[data.Id] = direction;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhotoCamera;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "拍照效果组件:应用灯光";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("lightId", data.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isDefault", data.IsDefault);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("direction", direction);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("userSelectedLightId", this.UserSelectedLightId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.ApplyCharacterLight(data, direction);
			return (int)direction;
		}

		// Token: 0x060483D0 RID: 295888 RVA: 0x0128F08C File Offset: 0x0128D28C
		public int GetUserSelectedLightId()
		{
			return this.UserSelectedLightId;
		}

		// Token: 0x060483D1 RID: 295889 RVA: 0x0128F094 File Offset: 0x0128D294
		public int GetCurrentLightId()
		{
			return this.CurrentLightId;
		}

		// Token: 0x060483D2 RID: 295890 RVA: 0x0128F09C File Offset: 0x0128D29C
		public float GetCurrentLightDirection()
		{
			float result;
			if (!this.LightDirectionMap.TryGetValue(this.CurrentLightId, out result))
			{
				return 0f;
			}
			return result;
		}

		// Token: 0x060483D3 RID: 295891 RVA: 0x0128F0C8 File Offset: 0x0128D2C8
		public void SetLightDirection(float direction)
		{
			this.LightDirectionMap[this.CurrentLightId] = direction;
			if (this.CurrentLight == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:灯光方向变更失败,尚未选中灯光";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("direction", direction);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ApplyCharacterLight(this.CurrentLight.Value, direction);
		}

		// Token: 0x060483D4 RID: 295892 RVA: 0x0128F138 File Offset: 0x0128D338
		private void ApplyCharacterLight(PhotoLight data, float direction)
		{
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:角色光照写入失败,BP_CameraEffect 无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("lightId", data.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.EffectActor.角色光照方向_水平_ = direction;
			this.EffectActor.角色光照亮部Hue = data.HighlightHue;
			this.EffectActor.角色光照亮部Saturation = data.HighlightSaturation;
			this.EffectActor.角色光照亮部Value = data.HighlightValue;
			this.EffectActor.角色光照暗部Hue = data.ShadowHue;
			this.EffectActor.角色光照暗部Saturation = data.ShadowSaturation;
			this.EffectActor.角色光照暗部Value = data.ShadowValue;
			this.EffectActor.角色光照边缘光Hue = data.RimLightHue;
			this.EffectActor.角色光照边缘光Saturation = data.RimLightSaturation;
			this.EffectActor.角色光照边缘光Value = data.RimLightValue;
			this.EffectActor.UpdateCharacterLight();
		}

		// Token: 0x060483D5 RID: 295893 RVA: 0x0128F24C File Offset: 0x0128D44C
		public unsafe void ApplyFrame(PhotoFrame config, float frameXRatio, float frameYRatio, bool usePreviewBlur)
		{
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照效果组件:画幅写入失败,BP_CameraEffect 无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("frameId", config.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			switch (config.Mode)
			{
			case 0:
				this.EffectActor.默认();
				break;
			case 1:
				this.EffectActor.纯色遮罩();
				break;
			case 2:
				this.EffectActor.艺术画框();
				break;
			case 3:
				this.EffectActor.圆形遮罩();
				break;
			case 4:
				this.EffectActor.菱形遮罩();
				break;
			case 5:
				this.EffectActor.贴图画框();
				break;
			default:
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PhotoCamera;
				ELogAuthor author2 = ELogAuthor.CXJ;
				string message2 = "拍照效果组件:画幅配表 Mode 非法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("frameId", config.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mode", config.Mode);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			}
			this.EffectActor.MaskWidth = config.MaskWidth;
			this.EffectActor.MaskHeight = config.MaskHeight;
			this.EffectActor.MaskColor = FColor.FromHex(config.MaskColor);
			this.EffectActor.RhombusRadius = config.RhombusRadius;
			this.EffectActor.CircleMaskRadius = config.CircleMaskRadius;
			this.EffectActor.CircleMaskSoftness = config.CircleMaskSoftness;
			this.EffectActor.BackgroundStrength = config.BackgroundStrength;
			this.EffectActor.CircleRadius = config.CircleRadius;
			this.EffectActor.FrameThickness = config.FrameThickness;
			this.EffectActor.LineThickness = config.LineThickness;
			this.EffectActor.RotationAngle = config.RotationAngle;
			this.EffectActor.FrameX = frameXRatio;
			this.EffectActor.FrameY = frameYRatio;
			this.EffectActor.PositionHorizon = frameXRatio * config.PositionHorizon * 0.5f;
			this.EffectActor.PositionVertical = frameYRatio * config.PositionVertical * 0.5f;
			this.EffectActor.ShadowPower = config.ShadowPower;
			this.EffectActor.ShadowRange = config.ShadowRange;
			this.EffectActor.ShadowStrength = config.ShadowStrength;
			this.EffectActor.ShadowColor = FColor.FromHex(config.ShadowColor);
			this.EffectActor.EmissionPower = config.EmissionPower;
			this.EffectActor.EmissionRange = config.EmissionRange;
			this.EffectActor.EmissionStrength = config.EmissionStrength;
			this.EffectActor.EmissionColor = FColor.FromHex(config.EmissionColor);
			this.EffectActor.BlurIntensity = (usePreviewBlur ? config.PreviewBlurIntensity : config.CaptureBlurIntensity);
			this.EffectActor.SetParameter();
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.PhotoCamera;
			ELogAuthor author3 = ELogAuthor.CXJ;
			string message3 = "拍照效果组件:画幅已应用";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("frameId", config.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("mode", config.Mode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("usePreviewBlur", usePreviewBlur);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}

		// Token: 0x060483D6 RID: 295894 RVA: 0x0128F5F8 File Offset: 0x0128D7F8
		public void ResetFrame()
		{
			if (this.EffectActor == null || !this.EffectActor.IsValid())
			{
				return;
			}
			this.EffectActor.默认();
			this.EffectActor.SetParameter();
			Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "拍照效果组件:画幅已复位", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060483D7 RID: 295895 RVA: 0x0128F650 File Offset: 0x0128D850
		public int GetCurrentWindId()
		{
			return this.CurrentWindId;
		}

		// Token: 0x060483D8 RID: 295896 RVA: 0x0128F658 File Offset: 0x0128D858
		public int GetCurrentAtmosphereId()
		{
			return this.CurrentAtmosphereId;
		}

		// Token: 0x0402629B RID: 156315
		[Nullable(2)]
		private BP_CameraEffect_C EffectActor;

		// Token: 0x0402629C RID: 156316
		private readonly Dictionary<int, float> WindStrengthMap = new Dictionary<int, float>();

		// Token: 0x0402629D RID: 156317
		private readonly Dictionary<int, float> AtmosphereStrengthMap = new Dictionary<int, float>();

		// Token: 0x0402629E RID: 156318
		private readonly Dictionary<int, float> LightDirectionMap = new Dictionary<int, float>();

		// Token: 0x0402629F RID: 156319
		private int CurrentWindId;

		// Token: 0x040262A0 RID: 156320
		private int CurrentAtmosphereId;

		// Token: 0x040262A1 RID: 156321
		private int CurrentLightId;

		// Token: 0x040262A2 RID: 156322
		private int UserSelectedLightId;

		// Token: 0x040262A3 RID: 156323
		private PhotoLight? CurrentLight;

		// Token: 0x040262A4 RID: 156324
		private EPhotoClusterEffectType CurrentClusterEffectType;

		// Token: 0x040262A5 RID: 156325
		private const float PPV_WEATHER_PRIORITY = 9999999f;

		// Token: 0x040262A6 RID: 156326
		private int CurrentWeatherId;

		// Token: 0x040262A7 RID: 156327
		private bool IsPPVPriorityApplied;

		// Token: 0x040262A8 RID: 156328
		private int WeatherLoadTask;

		// Token: 0x040262A9 RID: 156329
		private float PhotoTimeHour = -1f;

		// Token: 0x040262AA RID: 156330
		private bool IsTimeControlEntered;
	}
}
