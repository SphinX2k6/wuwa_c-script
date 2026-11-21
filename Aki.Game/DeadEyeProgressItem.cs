using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F3F RID: 3903
[NullableContext(2)]
[Nullable(0)]
public class DeadEyeProgressItem : UiPanelBase
{
	// Token: 0x06009BEF RID: 39919 RVA: 0x002E39B0 File Offset: 0x002E1BB0
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

	// Token: 0x06009BF0 RID: 39920 RVA: 0x002E3A7C File Offset: 0x002E1C7C
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

	// Token: 0x06009BF1 RID: 39921 RVA: 0x002E3AF8 File Offset: 0x002E1CF8
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

	// Token: 0x06009BF2 RID: 39922 RVA: 0x002E3B44 File Offset: 0x002E1D44
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeProgressItem.<OnBeforeHideAsync>d__11 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeProgressItem.<OnBeforeHideAsync>d__11>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009BF3 RID: 39923 RVA: 0x002E3B87 File Offset: 0x002E1D87
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.DeadEyeModeTargetPointLocked, new Action(this.OnLockedTarget));
	}

	// Token: 0x06009BF4 RID: 39924 RVA: 0x002E3BA8 File Offset: 0x002E1DA8
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

	// Token: 0x06009BF5 RID: 39925 RVA: 0x002E3C78 File Offset: 0x002E1E78
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

	// Token: 0x06009BF6 RID: 39926 RVA: 0x002E3CE8 File Offset: 0x002E1EE8
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

	// Token: 0x06009BF7 RID: 39927 RVA: 0x002E3D26 File Offset: 0x002E1F26
	private void SetRealProgressByEnergy(float energy)
	{
		this.SetRealProgress(energy / (float)DeadEyeModeModel.Instance.MaxEnergy);
	}

	// Token: 0x06009BF8 RID: 39928 RVA: 0x002E3D3B File Offset: 0x002E1F3B
	private void SetReduceProgressByEnergy(float energy)
	{
		this.SetReduceProgress(energy / (float)DeadEyeModeModel.Instance.MaxEnergy);
	}

	// Token: 0x06009BF9 RID: 39929 RVA: 0x002E3D50 File Offset: 0x002E1F50
	private void SetRealProgress(float value)
	{
		DeadEyeProgressItem.SetSliderValue(this.EnergySlider, value);
	}

	// Token: 0x06009BFA RID: 39930 RVA: 0x002E3D5E File Offset: 0x002E1F5E
	private void SetReduceProgress(float value)
	{
		DeadEyeProgressItem.SetSliderValue(this.ReduceSlider, value);
	}

	// Token: 0x06009BFB RID: 39931 RVA: 0x002E3D6C File Offset: 0x002E1F6C
	private static void SetSliderValue(UUISliderComponent slider, float value)
	{
		if (slider != null)
		{
			slider.SetValue(value, true);
		}
	}

	// Token: 0x04005D1B RID: 23835
	private const float LERP_TIME = 1000f;

	// Token: 0x04005D1C RID: 23836
	private UUISliderComponent EnergySlider;

	// Token: 0x04005D1D RID: 23837
	private UUISliderComponent ReduceSlider;

	// Token: 0x04005D1E RID: 23838
	private LevelSequencePlayer RootSequencePlayer;

	// Token: 0x04005D1F RID: 23839
	private float CurLerpTime = 1001f;

	// Token: 0x04005D20 RID: 23840
	private float ReduceSliderLerpStartValue;

	// Token: 0x04005D21 RID: 23841
	private bool StartSequenceFinished;

	// Token: 0x0200716B RID: 29035
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04024F13 RID: 151315
		public const int TipsNode = 0;

		// Token: 0x04024F14 RID: 151316
		public const int TipsText = 1;

		// Token: 0x04024F15 RID: 151317
		public const int ReduceSlider = 2;

		// Token: 0x04024F16 RID: 151318
		public const int EnergySlider = 3;

		// Token: 0x04024F17 RID: 151319
		public const int PanelReduceLength = 4;
	}
}
