using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A80 RID: 6784
[NullableContext(2)]
[Nullable(0)]
public class DeadEyeProgressItem : UiPanelBase
{
	// Token: 0x0600C7DF RID: 51167 RVA: 0x002D8894 File Offset: 0x002D6A94
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C7E0 RID: 51168 RVA: 0x002D8960 File Offset: 0x002D6B60
	protected override void OnStart()
	{
		this.RootSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.EnergySlider = base.GetSlider(3);
		this.ReduceSlider = base.GetSlider(2);
		this.SetRealProgressByEnergy(DeadEyeModeModel.Instance.CurrentEnergy);
		this.SetReduceProgressByEnergy(DeadEyeModeModel.Instance.CurrentEnergy);
		this.EnableReduceSlider(false);
		EventSystem.Instance.Add(EEventName.DeadEyeModeTargetPointLocked, new Action(this.OnLockedTarget));
	}

	// Token: 0x0600C7E1 RID: 51169 RVA: 0x002D89DC File Offset: 0x002D6BDC
	protected override void OnAfterShow()
	{
		if (this.RootSequencePlayer != null)
		{
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			this.RootSequencePlayer.PlaySequenceAsync("Start", stopPromise, false, false, null, false).ContinueWith(delegate()
			{
				this.StartSequenceFinished = true;
			});
		}
	}

	// Token: 0x0600C7E2 RID: 51170 RVA: 0x002D8A28 File Offset: 0x002D6C28
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeProgressItem.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeProgressItem.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7E3 RID: 51171 RVA: 0x002D8A6B File Offset: 0x002D6C6B
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.DeadEyeModeTargetPointLocked, new Action(this.OnLockedTarget));
	}

	// Token: 0x0600C7E4 RID: 51172 RVA: 0x002D8A8C File Offset: 0x002D6C8C
	public void OnTick(float delta)
	{
		if (!this.StartSequenceFinished)
		{
			return;
		}
		DeadEyeModeModel instance = DeadEyeModeModel.Instance;
		double num = (double)delta * TimeUtil.Instance.Millisecond;
		float num2 = (float)((double)instance.TimeConsumption * num);
		instance.CurrentEnergy = Math.Max(0f, instance.CurrentEnergy - num2);
		this.SetRealProgressByEnergy(instance.CurrentEnergy);
		if (this.CurLerpTime <= 1000f)
		{
			this.CurLerpTime += delta;
			float alpha = this.CurLerpTime / 1000f;
			float reduceProgress = MathCommon.Lerp(this.ReduceSliderLerpStartValue, this.EnergySlider.GetValue(), alpha);
			this.SetReduceProgress(reduceProgress);
			return;
		}
		if (this.ReduceSlider != null && this.ReduceSlider.RootUIComp.Get().IsUIActiveSelf())
		{
			this.EnableReduceSlider(false);
		}
	}

	// Token: 0x0600C7E5 RID: 51173 RVA: 0x002D8B5C File Offset: 0x002D6D5C
	private void OnLockedTarget()
	{
		DeadEyeModeModel instance = DeadEyeModeModel.Instance;
		float currentEnergy = instance.CurrentEnergy;
		instance.CurrentEnergy -= (float)DeadEyeModeModel.Instance.BulletConsumption;
		this.SetRealProgressByEnergy(instance.CurrentEnergy);
		this.CurLerpTime = (float)((currentEnergy == instance.CurrentEnergy) ? 1000 : 0);
		this.ReduceSliderLerpStartValue = this.ReduceSlider.GetValue();
		this.EnableReduceSlider(true);
	}

	// Token: 0x0600C7E6 RID: 51174 RVA: 0x002D8BCC File Offset: 0x002D6DCC
	private void EnableReduceSlider(bool enable)
	{
		UUISliderComponent reduceSlider = this.ReduceSlider;
		if (reduceSlider != null)
		{
			reduceSlider.RootUIComp.Get().SetUIActive(enable);
		}
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(enable);
	}

	// Token: 0x0600C7E7 RID: 51175 RVA: 0x002D8C0A File Offset: 0x002D6E0A
	private void SetRealProgressByEnergy(float energy)
	{
		this.SetRealProgress(energy / (float)DeadEyeModeModel.Instance.MaxEnergy);
	}

	// Token: 0x0600C7E8 RID: 51176 RVA: 0x002D8C1F File Offset: 0x002D6E1F
	private void SetReduceProgressByEnergy(float energy)
	{
		this.SetReduceProgress(energy / (float)DeadEyeModeModel.Instance.MaxEnergy);
	}

	// Token: 0x0600C7E9 RID: 51177 RVA: 0x002D8C34 File Offset: 0x002D6E34
	private void SetRealProgress(float value)
	{
		DeadEyeProgressItem.SetSliderValue(this.EnergySlider, value);
	}

	// Token: 0x0600C7EA RID: 51178 RVA: 0x002D8C42 File Offset: 0x002D6E42
	private void SetReduceProgress(float value)
	{
		DeadEyeProgressItem.SetSliderValue(this.ReduceSlider, value);
	}

	// Token: 0x0600C7EB RID: 51179 RVA: 0x002D8C50 File Offset: 0x002D6E50
	private static void SetSliderValue(UUISliderComponent slider, float value)
	{
		if (slider != null)
		{
			slider.SetValue(value, true);
		}
	}

	// Token: 0x04005C4C RID: 23628
	private const float LERP_TIME = 1000f;

	// Token: 0x04005C4D RID: 23629
	private UUISliderComponent EnergySlider;

	// Token: 0x04005C4E RID: 23630
	private UUISliderComponent ReduceSlider;

	// Token: 0x04005C4F RID: 23631
	private LevelSequencePlayer RootSequencePlayer;

	// Token: 0x04005C50 RID: 23632
	private float CurLerpTime = 1001f;

	// Token: 0x04005C51 RID: 23633
	private float ReduceSliderLerpStartValue;

	// Token: 0x04005C52 RID: 23634
	private bool StartSequenceFinished;

	// Token: 0x02007FDC RID: 32732
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04029BD6 RID: 170966
		public const int TipsNode = 0;

		// Token: 0x04029BD7 RID: 170967
		public const int TipsText = 1;

		// Token: 0x04029BD8 RID: 170968
		public const int ReduceSlider = 2;

		// Token: 0x04029BD9 RID: 170969
		public const int EnergySlider = 3;

		// Token: 0x04029BDA RID: 170970
		public const int PanelReduceLength = 4;
	}
}
