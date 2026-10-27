using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006632 RID: 26162
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingWarningTips : UiTickViewBase
	{
		// Token: 0x0604194F RID: 268623 RVA: 0x00FE8057 File Offset: 0x00FE6257
		public FishingWarningTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06041950 RID: 268624 RVA: 0x00FE8068 File Offset: 0x00FE6268
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

		// Token: 0x06041951 RID: 268625 RVA: 0x00FE80F4 File Offset: 0x00FE62F4
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

		// Token: 0x06041952 RID: 268626 RVA: 0x00FE818F File Offset: 0x00FE638F
		private void OnEndSequence(string sequenceName)
		{
			if (sequenceName == "NumChange")
			{
				this.AddText.SetUIActive(false);
				this.IsTextActive = false;
			}
		}

		// Token: 0x06041953 RID: 268627 RVA: 0x00FE81B1 File Offset: 0x00FE63B1
		protected override void OnAddEventListener()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.AddAttributeListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
			shipData.AddAttributeListener(EAttributeType.SpecialEnergy1Max, new Action<EAttributeType, float, float>(this.OnAttributeMaxChanged));
		}

		// Token: 0x06041954 RID: 268628 RVA: 0x00FE81E4 File Offset: 0x00FE63E4
		protected override void OnRemoveEventListener()
		{
			FishingShipData shipData = FishingModel.Instance.GetShipData();
			shipData.RemoveAttributeListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
			shipData.RemoveAttributeListener(EAttributeType.SpecialEnergy1Max, new Action<EAttributeType, float, float>(this.OnAttributeMaxChanged));
		}

		// Token: 0x06041955 RID: 268629 RVA: 0x00FE8217 File Offset: 0x00FE6417
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
		}

		// Token: 0x06041956 RID: 268630 RVA: 0x00FE8224 File Offset: 0x00FE6424
		private void OnAttributeChanged(EAttributeType id, float newValue, float oldValue)
		{
			this.TargetValue = newValue;
			this.AddValue = (int)(newValue - oldValue);
			this.IsTick = true;
			this.HandleShowAddValue();
		}

		// Token: 0x06041957 RID: 268631 RVA: 0x00FE8244 File Offset: 0x00FE6444
		private void OnAttributeMaxChanged(EAttributeType id, float newValue, float oldValue)
		{
			this.BarMaxValue = newValue;
			this.HandleWarningBar(0f);
		}

		// Token: 0x06041958 RID: 268632 RVA: 0x00FE8258 File Offset: 0x00FE6458
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

		// Token: 0x06041959 RID: 268633 RVA: 0x00FE8280 File Offset: 0x00FE6480
		protected void HandleWarningBar(float delta)
		{
			double num = (double)(20f * delta) * TimeUtil.Instance.Millisecond;
			this.LastBarValue = (float)MathUtils.Instance.Clamp((double)this.LastBarValue + num, (double)this.LastBarValue, (double)this.TargetValue);
			this.SpriteBar.SetFillAmount(this.LastBarValue / this.BarMaxValue);
		}

		// Token: 0x0604195A RID: 268634 RVA: 0x00FE82E4 File Offset: 0x00FE64E4
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

		// Token: 0x040221E4 RID: 139748
		private const int ADD_VALUE = 20;

		// Token: 0x040221E5 RID: 139749
		protected UUIText AddText;

		// Token: 0x040221E6 RID: 139750
		protected UUISprite SpriteBar;

		// Token: 0x040221E7 RID: 139751
		protected int AddValue;

		// Token: 0x040221E8 RID: 139752
		protected float LastBarValue;

		// Token: 0x040221E9 RID: 139753
		protected float BarMaxValue;

		// Token: 0x040221EA RID: 139754
		protected float TargetValue;

		// Token: 0x040221EB RID: 139755
		private bool IsTick = true;

		// Token: 0x040221EC RID: 139756
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040221ED RID: 139757
		private bool IsTextActive;

		// Token: 0x0200C84F RID: 51279
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C820 RID: 247840
			public const int SpriteBar = 0;

			// Token: 0x0403C821 RID: 247841
			public const int AddText = 1;

			// Token: 0x0403C822 RID: 247842
			public const int NumberItem = 2;
		}
	}
}
