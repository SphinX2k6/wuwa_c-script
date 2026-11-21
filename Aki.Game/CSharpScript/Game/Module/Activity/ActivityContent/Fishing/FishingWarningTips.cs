using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055B0 RID: 21936
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingWarningTips : UiTickViewBase
	{
		// Token: 0x06036614 RID: 222740 RVA: 0x00F2F10F File Offset: 0x00F2D30F
		public FishingWarningTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06036615 RID: 222741 RVA: 0x00F2F120 File Offset: 0x00F2D320
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036616 RID: 222742 RVA: 0x00F2F1AC File Offset: 0x00F2D3AC
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(base.GetItem(2));
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequence));
			this.AddText = base.GetText(1);
			this.AddText.SetUIActive(false);
			this.SpriteBar = base.GetSprite(0);
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			this.LastBarValue = shipData.GetAttributeValue(EAttributeType.SpecialEnergy1);
			this.BarMaxValue = shipData.GetAttributeValue(EAttributeType.SpecialEnergy1Max);
			this.SpriteBar.SetFillAmount(this.LastBarValue / this.BarMaxValue);
		}

		// Token: 0x06036617 RID: 222743 RVA: 0x00F2F247 File Offset: 0x00F2D447
		private void OnEndSequence(string sequenceName)
		{
			if (sequenceName == "NumChange")
			{
				this.AddText.SetUIActive(false);
				this.IsTextActive = false;
			}
		}

		// Token: 0x06036618 RID: 222744 RVA: 0x00F2F269 File Offset: 0x00F2D469
		protected override void OnAddEventListener()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.AddAttributeListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
			shipData.AddAttributeListener(EAttributeType.SpecialEnergy1Max, new Action<EAttributeType, float, float>(this.OnAttributeMaxChanged));
		}

		// Token: 0x06036619 RID: 222745 RVA: 0x00F2F29C File Offset: 0x00F2D49C
		protected override void OnRemoveEventListener()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.RemoveAttributeListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
			shipData.RemoveAttributeListener(EAttributeType.SpecialEnergy1Max, new Action<EAttributeType, float, float>(this.OnAttributeMaxChanged));
		}

		// Token: 0x0603661A RID: 222746 RVA: 0x00F2F2CF File Offset: 0x00F2D4CF
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x0603661B RID: 222747 RVA: 0x00F2F2DC File Offset: 0x00F2D4DC
		private void OnAttributeChanged(EAttributeType id, float newValue, float oldValue)
		{
			this.TargetValue = newValue;
			this.AddValue = (int)(newValue - oldValue);
			this.IsTick = true;
			this.HandleShowAddValue();
		}

		// Token: 0x0603661C RID: 222748 RVA: 0x00F2F2FC File Offset: 0x00F2D4FC
		private void OnAttributeMaxChanged(EAttributeType id, float newValue, float oldValue)
		{
			this.BarMaxValue = newValue;
			this.HandleWarningBar(0f);
		}

		// Token: 0x0603661D RID: 222749 RVA: 0x00F2F310 File Offset: 0x00F2D510
		protected override void OnTick(float delta)
		{
			if (!this.IsTick)
			{
				return;
			}
			this.HandleWarningBar(delta);
			if (this.LastBarValue == this.TargetValue)
			{
				this.IsTick = false;
			}
		}

		// Token: 0x0603661E RID: 222750 RVA: 0x00F2F338 File Offset: 0x00F2D538
		protected void HandleWarningBar(float delta)
		{
			double num = (double)(20f * delta) * TimeUtil.Instance.Millisecond;
			this.LastBarValue = (float)MathUtils.Instance.Clamp((double)this.LastBarValue + num, (double)this.LastBarValue, (double)this.TargetValue);
			this.SpriteBar.SetFillAmount(this.LastBarValue / this.BarMaxValue);
		}

		// Token: 0x0603661F RID: 222751 RVA: 0x00F2F39C File Offset: 0x00F2D59C
		protected void HandleShowAddValue()
		{
			if (this.AddValue > 1)
			{
				if (!this.IsTextActive)
				{
					this.AddText.SetUIActive(true);
					this.IsTextActive = true;
					this.AddText.SetText("+" + this.AddValue.ToString(), true);
					this.SequencePlayer.PlaySequence("NumChange", false, null);
					return;
				}
				this.AddText.SetText("+" + this.AddValue.ToString(), true);
				this.SequencePlayer.ReplaySequence("NumChange");
			}
		}

		// Token: 0x0401CB15 RID: 117525
		private const int ADD_VALUE = 20;

		// Token: 0x0401CB16 RID: 117526
		protected UUIText AddText;

		// Token: 0x0401CB17 RID: 117527
		protected UUISprite SpriteBar;

		// Token: 0x0401CB18 RID: 117528
		protected int AddValue;

		// Token: 0x0401CB19 RID: 117529
		protected float LastBarValue;

		// Token: 0x0401CB1A RID: 117530
		protected float BarMaxValue;

		// Token: 0x0401CB1B RID: 117531
		protected float TargetValue;

		// Token: 0x0401CB1C RID: 117532
		private bool IsTick = true;

		// Token: 0x0401CB1D RID: 117533
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401CB1E RID: 117534
		private bool IsTextActive;

		// Token: 0x0200B231 RID: 45617
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04037165 RID: 225637
			public const int SpriteBar = 0;

			// Token: 0x04037166 RID: 225638
			public const int AddText = 1;

			// Token: 0x04037167 RID: 225639
			public const int NumberItem = 2;
		}
	}
}
