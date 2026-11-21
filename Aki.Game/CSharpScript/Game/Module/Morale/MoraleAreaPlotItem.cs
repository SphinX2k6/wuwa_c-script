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
	// Token: 0x02004380 RID: 17280
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleAreaPlotItem : UiPanelBase
	{
		// Token: 0x0602BA42 RID: 178754 RVA: 0x00C408FC File Offset: 0x00C3EAFC
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

		// Token: 0x0602BA43 RID: 178755 RVA: 0x00C40950 File Offset: 0x00C3EB50
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

		// Token: 0x0602BA44 RID: 178756 RVA: 0x00C409FC File Offset: 0x00C3EBFC
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaPlotItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaPlotItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA45 RID: 178757 RVA: 0x00C40A3F File Offset: 0x00C3EC3F
		public void SetPlotActive(bool active)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x0602BA46 RID: 178758 RVA: 0x00C40A53 File Offset: 0x00C3EC53
		public void UpdatePlotState()
		{
			this.SetPlotActive(this.GetPlotIsActive());
		}

		// Token: 0x0602BA47 RID: 178759 RVA: 0x00C40A64 File Offset: 0x00C3EC64
		public bool GetPlotIsActive()
		{
			int flagId = this.PlotData.FlagId;
			int areaId = this.PlotData.AreaId;
			MoraleAreaData areaData = MoraleModel.Instance.GetAreaData(areaId);
			MoraleAreaFlagData moraleAreaFlagData = (areaData != null) ? areaData.GetFlag(flagId) : null;
			return moraleAreaFlagData != null && moraleAreaFlagData.IsActive;
		}

		// Token: 0x0602BA48 RID: 178760 RVA: 0x00C40AAD File Offset: 0x00C3ECAD
		public void SetPlotLight(bool active)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x0602BA49 RID: 178761 RVA: 0x00C40AC1 File Offset: 0x00C3ECC1
		public void SetPlotLightAlpha(float alpha)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(alpha);
		}

		// Token: 0x0602BA4A RID: 178762 RVA: 0x00C40AD5 File Offset: 0x00C3ECD5
		public void SetPlotNewUnlock(bool active)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(active);
		}

		// Token: 0x0602BA4B RID: 178763 RVA: 0x00C40AE9 File Offset: 0x00C3ECE9
		private void PlayEnterEffectStart()
		{
			this.SetPlotActive(true);
			this.SetPlotLight(true);
			this.PlayEnterTickCallback(0f);
			this.SetPlotNewUnlock(false);
		}

		// Token: 0x0602BA4C RID: 178764 RVA: 0x00C40B0C File Offset: 0x00C3ED0C
		private void PlayEnterTickCallback(float addDeltaTime)
		{
			float curveValue = this.GetCurveValue(addDeltaTime, this.EnterConfig);
			this.SetPlotLightAlpha(curveValue);
		}

		// Token: 0x0602BA4D RID: 178765 RVA: 0x00C40B2E File Offset: 0x00C3ED2E
		private void PlayLoopEffectStart()
		{
			this.SetPlotActive(true);
			this.SetPlotLight(true);
			this.PlayLoopTickCallback(0f);
			this.SetPlotNewUnlock(false);
		}

		// Token: 0x0602BA4E RID: 178766 RVA: 0x00C40B50 File Offset: 0x00C3ED50
		private void PlayLoopTickCallback(float addDeltaTime)
		{
			float curveValue = this.GetCurveValue(addDeltaTime, this.LoopConfig);
			this.SetPlotLightAlpha(curveValue);
		}

		// Token: 0x0602BA4F RID: 178767 RVA: 0x00C40B72 File Offset: 0x00C3ED72
		private void PlayNewUnlockEffectStart()
		{
			this.SetPlotActive(true);
			this.SetPlotLight(false);
			this.SetPlotLightAlpha(0f);
			this.SetPlotNewUnlock(true);
		}

		// Token: 0x0602BA50 RID: 178768 RVA: 0x00C40B94 File Offset: 0x00C3ED94
		private float GetCurveTime(UCurveFloat curve)
		{
			int num = (curve != null) ? curve.FloatCurve.Keys.Num() : 0;
			return ((num > 0) ? curve.FloatCurve.Keys.Get(num - 1).Time : 1f) * 1000f;
		}

		// Token: 0x0602BA51 RID: 178769 RVA: 0x00C40BE1 File Offset: 0x00C3EDE1
		private float GetCurveValue(float time, BP_MoraleEffectConfig_C config)
		{
			UCurveFloat ucurveFloat = (config != null) ? config.格子入场曲线 : null;
			if (ucurveFloat == null)
			{
				return 0f;
			}
			return ucurveFloat.GetFloatValue(time / 1000f);
		}

		// Token: 0x0602BA52 RID: 178770 RVA: 0x00C40C05 File Offset: 0x00C3EE05
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

		// Token: 0x0602BA53 RID: 178771 RVA: 0x00C40C3C File Offset: 0x00C3EE3C
		public UniTask PlayEnterEffect()
		{
			MoraleAreaPlotItem.<PlayEnterEffect>d__24 <PlayEnterEffect>d__;
			<PlayEnterEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEnterEffect>d__.<>4__this = this;
			<PlayEnterEffect>d__.<>1__state = -1;
			<PlayEnterEffect>d__.<>t__builder.Start<MoraleAreaPlotItem.<PlayEnterEffect>d__24>(ref <PlayEnterEffect>d__);
			return <PlayEnterEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA54 RID: 178772 RVA: 0x00C40C80 File Offset: 0x00C3EE80
		public UniTask PlayNewUnlockEffect()
		{
			MoraleAreaPlotItem.<PlayNewUnlockEffect>d__25 <PlayNewUnlockEffect>d__;
			<PlayNewUnlockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayNewUnlockEffect>d__.<>4__this = this;
			<PlayNewUnlockEffect>d__.<>1__state = -1;
			<PlayNewUnlockEffect>d__.<>t__builder.Start<MoraleAreaPlotItem.<PlayNewUnlockEffect>d__25>(ref <PlayNewUnlockEffect>d__);
			return <PlayNewUnlockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA55 RID: 178773 RVA: 0x00C40CC4 File Offset: 0x00C3EEC4
		public UniTask PlayLoopEffect()
		{
			MoraleAreaPlotItem.<PlayLoopEffect>d__26 <PlayLoopEffect>d__;
			<PlayLoopEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayLoopEffect>d__.<>4__this = this;
			<PlayLoopEffect>d__.<>1__state = -1;
			<PlayLoopEffect>d__.<>t__builder.Start<MoraleAreaPlotItem.<PlayLoopEffect>d__26>(ref <PlayLoopEffect>d__);
			return <PlayLoopEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA56 RID: 178774 RVA: 0x00C40D07 File Offset: 0x00C3EF07
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

		// Token: 0x040178C1 RID: 96449
		[Nullable(1)]
		public MoraleAreaPlotData PlotData;

		// Token: 0x040178C2 RID: 96450
		[Nullable(1)]
		public BP_MoraleEffectConfig_C EnterConfig;

		// Token: 0x040178C3 RID: 96451
		[Nullable(1)]
		public BP_MoraleEffectConfig_C LoopConfig;

		// Token: 0x040178C4 RID: 96452
		public MoraleTickPromise EnterTickPromise;

		// Token: 0x040178C5 RID: 96453
		public MoraleTickPromise NewUnlockTickPromise;

		// Token: 0x040178C6 RID: 96454
		public MoraleTickPromise LoopTickPromise;

		// Token: 0x0200A048 RID: 41032
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04031CC0 RID: 203968
			ItemPlotRoot,
			// Token: 0x04031CC1 RID: 203969
			SpriteIcon,
			// Token: 0x04031CC2 RID: 203970
			ItemLight,
			// Token: 0x04031CC3 RID: 203971
			UiNiagaraNewUnlock
		}
	}
}
