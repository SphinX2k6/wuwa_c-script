using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.UI.View.Morale;
using CSharpScript.Game.Module.Morale.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200539D RID: 21405
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleAreaPlotItem : UiPanelBase
	{
		// Token: 0x06036AFC RID: 223996 RVA: 0x00CF1854 File Offset: 0x00CEFA54
		[NullableContext(1)]
		public UniTask Init(UUIItem item, MoraleAreaPlotData plotData)
		{
			MoraleAreaPlotItem.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.plotData = plotData;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleAreaPlotItem.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036AFD RID: 223997 RVA: 0x00CF18A8 File Offset: 0x00CEFAA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036AFE RID: 223998 RVA: 0x00CF1954 File Offset: 0x00CEFB54
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaPlotItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaPlotItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036AFF RID: 223999 RVA: 0x00CF1997 File Offset: 0x00CEFB97
		public void SetPlotActive(bool active)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06036B00 RID: 224000 RVA: 0x00CF19AB File Offset: 0x00CEFBAB
		public void UpdatePlotState()
		{
			this.SetPlotActive(this.GetPlotIsActive());
		}

		// Token: 0x06036B01 RID: 224001 RVA: 0x00CF19BC File Offset: 0x00CEFBBC
		public bool GetPlotIsActive()
		{
			int flagId = this.PlotData.FlagId;
			int areaId = this.PlotData.AreaId;
			MoraleAreaData areaData = MoraleModel.Instance.GetAreaData(areaId);
			MoraleAreaFlagData moraleAreaFlagData = (areaData != null) ? areaData.GetFlag(flagId) : null;
			return moraleAreaFlagData != null && moraleAreaFlagData.IsActive;
		}

		// Token: 0x06036B02 RID: 224002 RVA: 0x00CF1A05 File Offset: 0x00CEFC05
		public void SetPlotLight(bool active)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06036B03 RID: 224003 RVA: 0x00CF1A19 File Offset: 0x00CEFC19
		public void SetPlotLightAlpha(float alpha)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(alpha);
		}

		// Token: 0x06036B04 RID: 224004 RVA: 0x00CF1A2D File Offset: 0x00CEFC2D
		public void SetPlotNewUnlock(bool active)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(active);
		}

		// Token: 0x06036B05 RID: 224005 RVA: 0x00CF1A41 File Offset: 0x00CEFC41
		private void PlayEnterEffectStart()
		{
			this.SetPlotActive(true);
			this.SetPlotLight(true);
			this.PlayEnterTickCallback(0f);
			this.SetPlotNewUnlock(false);
		}

		// Token: 0x06036B06 RID: 224006 RVA: 0x00CF1A64 File Offset: 0x00CEFC64
		private void PlayEnterTickCallback(float addDeltaTime)
		{
			float curveValue = this.GetCurveValue(addDeltaTime, this.EnterConfig);
			this.SetPlotLightAlpha(curveValue);
		}

		// Token: 0x06036B07 RID: 224007 RVA: 0x00CF1A86 File Offset: 0x00CEFC86
		private void PlayLoopEffectStart()
		{
			this.SetPlotActive(true);
			this.SetPlotLight(true);
			this.PlayLoopTickCallback(0f);
			this.SetPlotNewUnlock(false);
		}

		// Token: 0x06036B08 RID: 224008 RVA: 0x00CF1AA8 File Offset: 0x00CEFCA8
		private void PlayLoopTickCallback(float addDeltaTime)
		{
			float curveValue = this.GetCurveValue(addDeltaTime, this.LoopConfig);
			this.SetPlotLightAlpha(curveValue);
		}

		// Token: 0x06036B09 RID: 224009 RVA: 0x00CF1ACA File Offset: 0x00CEFCCA
		private void PlayNewUnlockEffectStart()
		{
			this.SetPlotActive(true);
			this.SetPlotLight(false);
			this.SetPlotLightAlpha(0f);
			this.SetPlotNewUnlock(true);
		}

		// Token: 0x06036B0A RID: 224010 RVA: 0x00CF1AEC File Offset: 0x00CEFCEC
		private float GetCurveTime(UCurveFloat curve)
		{
			int num = (curve != null) ? curve.FloatCurve.Keys.Num() : 0;
			return ((num > 0) ? curve.FloatCurve.Keys.Get(num - 1).Time : 1f) * 1000f;
		}

		// Token: 0x06036B0B RID: 224011 RVA: 0x00CF1B39 File Offset: 0x00CEFD39
		private float GetCurveValue(float time, BP_MoraleEffectConfig_C config)
		{
			UCurveFloat ucurveFloat = (config != null) ? config.格子入场曲线 : null;
			if (ucurveFloat == null)
			{
				return 0f;
			}
			return ucurveFloat.GetFloatValue(time / 1000f);
		}

		// Token: 0x06036B0C RID: 224012 RVA: 0x00CF1B5D File Offset: 0x00CEFD5D
		public void OnTick(float delta)
		{
			MoraleTickPromise enterTickPromise = this.EnterTickPromise;
			if (enterTickPromise != null)
			{
				enterTickPromise.Tick(delta);
			}
			MoraleTickPromise newUnlockTickPromise = this.NewUnlockTickPromise;
			if (newUnlockTickPromise != null)
			{
				newUnlockTickPromise.Tick(delta);
			}
			MoraleTickPromise loopTickPromise = this.LoopTickPromise;
			if (loopTickPromise == null)
			{
				return;
			}
			loopTickPromise.Tick(delta);
		}

		// Token: 0x06036B0D RID: 224013 RVA: 0x00CF1B94 File Offset: 0x00CEFD94
		public UniTask PlayEnterEffect()
		{
			MoraleAreaPlotItem.<PlayEnterEffect>d__24 <PlayEnterEffect>d__;
			<PlayEnterEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEnterEffect>d__.<>4__this = this;
			<PlayEnterEffect>d__.<>1__state = -1;
			<PlayEnterEffect>d__.<>t__builder.Start<MoraleAreaPlotItem.<PlayEnterEffect>d__24>(ref <PlayEnterEffect>d__);
			return <PlayEnterEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036B0E RID: 224014 RVA: 0x00CF1BD8 File Offset: 0x00CEFDD8
		public UniTask PlayNewUnlockEffect()
		{
			MoraleAreaPlotItem.<PlayNewUnlockEffect>d__25 <PlayNewUnlockEffect>d__;
			<PlayNewUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayNewUnlockEffect>d__.<>4__this = this;
			<PlayNewUnlockEffect>d__.<>1__state = -1;
			<PlayNewUnlockEffect>d__.<>t__builder.Start<MoraleAreaPlotItem.<PlayNewUnlockEffect>d__25>(ref <PlayNewUnlockEffect>d__);
			return <PlayNewUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036B0F RID: 224015 RVA: 0x00CF1C1C File Offset: 0x00CEFE1C
		public UniTask PlayLoopEffect()
		{
			MoraleAreaPlotItem.<PlayLoopEffect>d__26 <PlayLoopEffect>d__;
			<PlayLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayLoopEffect>d__.<>4__this = this;
			<PlayLoopEffect>d__.<>1__state = -1;
			<PlayLoopEffect>d__.<>t__builder.Start<MoraleAreaPlotItem.<PlayLoopEffect>d__26>(ref <PlayLoopEffect>d__);
			return <PlayLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06036B10 RID: 224016 RVA: 0x00CF1C5F File Offset: 0x00CEFE5F
		protected override void OnBeforeDestroy()
		{
			MoraleTickPromise enterTickPromise = this.EnterTickPromise;
			if (enterTickPromise != null)
			{
				enterTickPromise.Destroy();
			}
			MoraleTickPromise newUnlockTickPromise = this.NewUnlockTickPromise;
			if (newUnlockTickPromise != null)
			{
				newUnlockTickPromise.Destroy();
			}
			MoraleTickPromise loopTickPromise = this.LoopTickPromise;
			if (loopTickPromise == null)
			{
				return;
			}
			loopTickPromise.Destroy();
		}

		// Token: 0x0401CE29 RID: 118313
		[Nullable(1)]
		public MoraleAreaPlotData PlotData;

		// Token: 0x0401CE2A RID: 118314
		[Nullable(1)]
		public BP_MoraleEffectConfig_C EnterConfig;

		// Token: 0x0401CE2B RID: 118315
		[Nullable(1)]
		public BP_MoraleEffectConfig_C LoopConfig;

		// Token: 0x0401CE2C RID: 118316
		public MoraleTickPromise EnterTickPromise;

		// Token: 0x0401CE2D RID: 118317
		public MoraleTickPromise NewUnlockTickPromise;

		// Token: 0x0401CE2E RID: 118318
		public MoraleTickPromise LoopTickPromise;

		// Token: 0x0200B610 RID: 46608
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403726B RID: 225899
			ItemPlotRoot,
			// Token: 0x0403726C RID: 225900
			SpriteIcon,
			// Token: 0x0403726D RID: 225901
			ItemLight,
			// Token: 0x0403726E RID: 225902
			UiNiagaraNewUnlock
		}
	}
}
