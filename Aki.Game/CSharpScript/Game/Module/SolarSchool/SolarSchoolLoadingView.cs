using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A2B RID: 23083
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolLoadingView : UiTickViewBase
	{
		// Token: 0x06038D8C RID: 232844 RVA: 0x00FEA134 File Offset: 0x00FE8334
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06038D8D RID: 232845 RVA: 0x00FEA18E File Offset: 0x00FE838E
		public SolarSchoolLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038D8E RID: 232846 RVA: 0x00FEA1A4 File Offset: 0x00FE83A4
		protected override void OnStart()
		{
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("SolarSchoolLoadSpeed");
			if (floatConfig != null)
			{
				this.ProgressSpeed = floatConfig.Value;
			}
			this.InitProgress();
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "SolarSchoolLoadingtext", Array.Empty<object>());
		}

		// Token: 0x06038D8F RID: 232847 RVA: 0x00FEA1F4 File Offset: 0x00FE83F4
		protected override void OnTick(float delta)
		{
			float delta2 = delta / (float)TimeUtil.Instance.InverseMillisecond;
			this.TickProgress(delta2);
		}

		// Token: 0x06038D90 RID: 232848 RVA: 0x00FEA218 File Offset: 0x00FE8418
		private void TickProgress(float delta)
		{
			if (this.Closing)
			{
				return;
			}
			SolarSchoolModel instance = SolarSchoolModel.Instance;
			int num = 100;
			float num2 = Math.Min(instance.CurrentProgress + this.ProgressSpeed * delta, (float)instance.CurrentPhase);
			float progressRate = num2 / (float)num;
			instance.CurrentProgress = num2;
			this.UpdateProgress(progressRate, num2);
			if (num2 >= (float)num)
			{
				this.Closing = true;
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			}
		}

		// Token: 0x06038D91 RID: 232849 RVA: 0x00FEA289 File Offset: 0x00FE8489
		protected override void OnAfterHide()
		{
			SolarSchoolModel.Instance.OnLoadingViewHidden();
		}

		// Token: 0x06038D92 RID: 232850 RVA: 0x00FEA298 File Offset: 0x00FE8498
		private void InitProgress()
		{
			float currentProgress = SolarSchoolModel.Instance.CurrentProgress;
			float progressRate = currentProgress / 100f;
			this.UpdateProgress(progressRate, currentProgress);
		}

		// Token: 0x06038D93 RID: 232851 RVA: 0x00FEA2C0 File Offset: 0x00FE84C0
		private void UpdateProgress(float progressRate, float progressValue)
		{
			base.GetSlider(0).SetValue(progressRate, true);
			double num = Math.Round((double)progressValue);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), "SolarSchoolLoadingNum", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x06038D94 RID: 232852 RVA: 0x00FEA304 File Offset: 0x00FE8504
		protected override void OnBeforeShow()
		{
			GameAudioController.Instance.UpdateLoadingType(new ELoadingPerform?(ELoadingPerform.Loading));
			AudioSystem.Instance.SetState("mute_3_8_avgloading_music", "mute", true);
		}

		// Token: 0x06038D95 RID: 232853 RVA: 0x00FEA32C File Offset: 0x00FE852C
		protected override void OnBeforeHide()
		{
			GameAudioController.Instance.UpdateLoadingType(null);
			AudioSystem.Instance.SetState("mute_3_8_avgloading_music", "none", true);
		}

		// Token: 0x0401DEA9 RID: 122537
		private const string MUTE_MUSIC_STATE_GROUP = "mute_3_8_avgloading_music";

		// Token: 0x0401DEAA RID: 122538
		private const string MUTE_STATE = "mute";

		// Token: 0x0401DEAB RID: 122539
		private const string NONE_STATE = "none";

		// Token: 0x0401DEAC RID: 122540
		private bool Closing;

		// Token: 0x0401DEAD RID: 122541
		private float ProgressSpeed = 1f;

		// Token: 0x0200B5FC RID: 46588
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038468 RID: 230504
			public const int ProgressSld = 0;

			// Token: 0x04038469 RID: 230505
			public const int ProgressNumText = 1;

			// Token: 0x0403846A RID: 230506
			public const int TipsText = 2;
		}
	}
}
