using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059AD RID: 22957
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolTipCostItem : UiPanelBase
	{
		// Token: 0x06038980 RID: 231808 RVA: 0x00FD58DC File Offset: 0x00FD3ADC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnTipCostClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038981 RID: 231809 RVA: 0x00FD5AB0 File Offset: 0x00FD3CB0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolTipCostItem.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolTipCostItem.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038982 RID: 231810 RVA: 0x00FD5AF3 File Offset: 0x00FD3CF3
		protected override void OnStart()
		{
			this.Refresh();
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Add<int, bool>(EEventName.SolarSchoolBehaviorSettled, new Action<int, bool>(this.OnBehaviorSettled));
		}

		// Token: 0x06038983 RID: 231811 RVA: 0x00FD5B34 File Offset: 0x00FD3D34
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Remove<int, bool>(EEventName.SolarSchoolBehaviorSettled, new Action<int, bool>(this.OnBehaviorSettled));
			this.ClearFatigueTimer();
			this.HasFatiguePreview = false;
			this.HasHeldFatigue = false;
			this.HasDisplayFatigue = false;
			this.FatigueState = null;
		}

		// Token: 0x06038984 RID: 231812 RVA: 0x00FD5B9B File Offset: 0x00FD3D9B
		public void Refresh()
		{
			this.RefreshFatigue();
			this.RefreshAttr(ESolarSchoolSecondAttr.Money, 3, 4);
		}

		// Token: 0x06038985 RID: 231813 RVA: 0x00FD5BAC File Offset: 0x00FD3DAC
		public void SetFatiguePreview(int fatigue)
		{
			if (this.HasFatiguePreview && this.FatiguePreview == fatigue)
			{
				return;
			}
			this.HasFatiguePreview = true;
			this.FatiguePreview = fatigue;
			this.RefreshFatigue();
		}

		// Token: 0x06038986 RID: 231814 RVA: 0x00FD5BD4 File Offset: 0x00FD3DD4
		public void ClearFatiguePreview()
		{
			if (!this.HasFatiguePreview)
			{
				return;
			}
			this.HasFatiguePreview = false;
			this.RefreshFatigue();
		}

		// Token: 0x06038987 RID: 231815 RVA: 0x00FD5BEC File Offset: 0x00FD3DEC
		public void HoldFatigueUntilSettled(int fatigue)
		{
			this.HasHeldFatigue = true;
			this.HeldFatigue = fatigue;
			this.RefreshFatigue();
		}

		// Token: 0x06038988 RID: 231816 RVA: 0x00FD5C04 File Offset: 0x00FD3E04
		private void RefreshFatigue()
		{
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(this.HasFatiguePreview);
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (instance.PlayerData == null)
			{
				return;
			}
			this.TargetFatigue = (this.HasFatiguePreview ? this.FatiguePreview : (this.HasHeldFatigue ? this.HeldFatigue : instance.PlayerData.GetAttr(ESolarSchoolSecondAttr.Fatigue)));
			if (!this.HasDisplayFatigue)
			{
				this.HasDisplayFatigue = true;
				this.DisplayFatigue = (float)this.TargetFatigue;
				this.ApplyFatigue(this.DisplayFatigue);
				return;
			}
			if (this.FatigueTimer == null && Math.Abs((float)this.TargetFatigue - this.DisplayFatigue) >= 0.5f)
			{
				this.FatigueTimer = TimerSystem.Instance.Forever(new TTimerAction(this.TickFatigue), 20f, 1f, null, null, true);
			}
		}

		// Token: 0x06038989 RID: 231817 RVA: 0x00FD5CE0 File Offset: 0x00FD3EE0
		private void TickFatigue(float deltaMs)
		{
			float num = 1f - MathF.Pow(0.1f, deltaMs / 250f);
			this.DisplayFatigue += ((float)this.TargetFatigue - this.DisplayFatigue) * num;
			if (Math.Abs((float)this.TargetFatigue - this.DisplayFatigue) < 0.5f)
			{
				this.DisplayFatigue = (float)this.TargetFatigue;
				this.ClearFatigueTimer();
			}
			this.ApplyFatigue(this.DisplayFatigue);
		}

		// Token: 0x0603898A RID: 231818 RVA: 0x00FD5D5B File Offset: 0x00FD3F5B
		private void ClearFatigueTimer()
		{
			if (this.FatigueTimer != null)
			{
				this.FatigueTimer.Remove();
				this.FatigueTimer = null;
			}
		}

		// Token: 0x0603898B RID: 231819 RVA: 0x00FD5D78 File Offset: 0x00FD3F78
		private void ApplyFatigue(float displayFatigue)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int num = (int)MathF.Round(displayFatigue);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(ESolarSchoolSecondAttr.Fatigue);
			if (attrConfig != null)
			{
				int minValue = attrConfig.Value.MinValue;
				int maxValue = attrConfig.Value.MaxValue;
				float value = (maxValue > minValue) ? ((displayFatigue - (float)minValue) / (float)(maxValue - minValue)) : 0f;
				UUISliderComponent slider = base.GetSlider(6);
				if (slider != null)
				{
					slider.SetValue(Math.Clamp(value, 0f, 1f), true);
				}
			}
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(instance.ActivityId, "TiredThreshold", 0);
			int paramInt2 = SolarSchoolConfig.Instance.GetParamInt(instance.ActivityId, "SickThreshold", 0);
			ESolarSchoolFatigueStage stage = SolarSchoolUtils.CalcFatigueStage(num, paramInt, paramInt2);
			SolarSchoolFatigueStateItem fatigueState = this.FatigueState;
			if (fatigueState != null)
			{
				fatigueState.SetStage(stage);
			}
			UUISprite sprite = base.GetSprite(7);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(FColor.FromHex(this.GetFillColorHex(stage)));
		}

		// Token: 0x0603898C RID: 231820 RVA: 0x00FD5EAC File Offset: 0x00FD40AC
		private string GetFillColorHex(ESolarSchoolFatigueStage stage)
		{
			string result;
			if (stage != ESolarSchoolFatigueStage.Healthy)
			{
				if (stage != ESolarSchoolFatigueStage.Tired)
				{
					result = "#FF8181";
				}
				else
				{
					result = "#F7B163";
				}
			}
			else
			{
				result = "#ADD87C";
			}
			return result;
		}

		// Token: 0x0603898D RID: 231821 RVA: 0x00FD5EDC File Offset: 0x00FD40DC
		private void RefreshAttr(ESolarSchoolSecondAttr attr, int iconComponent, int textComponent)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (instance.PlayerData != null)
			{
				UUIText text = base.GetText(textComponent);
				if (text != null)
				{
					text.SetText(instance.PlayerData.GetAttr(attr).ToString(), true);
				}
			}
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(attr);
			if (attrConfig == null)
			{
				return;
			}
			base.SetTextureByPath(attrConfig.Value.IconSmall, base.GetTexture(iconComponent), null, null);
		}

		// Token: 0x0603898E RID: 231822 RVA: 0x00FD5F57 File Offset: 0x00FD4157
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			if (attr != ESolarSchoolSecondAttr.Fatigue && attr != ESolarSchoolSecondAttr.Money)
			{
				return;
			}
			this.Refresh();
		}

		// Token: 0x0603898F RID: 231823 RVA: 0x00FD5F68 File Offset: 0x00FD4168
		private void OnBehaviorSettled(int behaviorId, bool success)
		{
			if (!this.HasHeldFatigue)
			{
				return;
			}
			this.HasHeldFatigue = false;
			this.RefreshFatigue();
		}

		// Token: 0x06038990 RID: 231824 RVA: 0x00FD5F80 File Offset: 0x00FD4180
		private void OnBtnTipCostClick()
		{
			HelpController.Instance.OpenHelpById(699);
		}

		// Token: 0x0401DCE5 RID: 122085
		private const int HelpGroupId = 699;

		// Token: 0x0401DCE6 RID: 122086
		private const string HealthyFillColor = "#ADD87C";

		// Token: 0x0401DCE7 RID: 122087
		private const string TiredFillColor = "#F7B163";

		// Token: 0x0401DCE8 RID: 122088
		private const string SickFillColor = "#FF8181";

		// Token: 0x0401DCE9 RID: 122089
		private const float FatigueCatchUpMs = 250f;

		// Token: 0x0401DCEA RID: 122090
		private const float FatigueSnapDistance = 0.5f;

		// Token: 0x0401DCEB RID: 122091
		[Nullable(2)]
		private SolarSchoolFatigueStateItem FatigueState;

		// Token: 0x0401DCEC RID: 122092
		private bool HasFatiguePreview;

		// Token: 0x0401DCED RID: 122093
		private int FatiguePreview;

		// Token: 0x0401DCEE RID: 122094
		private bool HasHeldFatigue;

		// Token: 0x0401DCEF RID: 122095
		private int HeldFatigue;

		// Token: 0x0401DCF0 RID: 122096
		private bool HasDisplayFatigue;

		// Token: 0x0401DCF1 RID: 122097
		private float DisplayFatigue;

		// Token: 0x0401DCF2 RID: 122098
		private int TargetFatigue;

		// Token: 0x0401DCF3 RID: 122099
		[Nullable(2)]
		private TimerHandle FatigueTimer;

		// Token: 0x0200B557 RID: 46423
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403810F RID: 229647
			public const int BtnTipCost = 0;

			// Token: 0x04038110 RID: 229648
			public const int TexIcon = 1;

			// Token: 0x04038111 RID: 229649
			public const int TxtValue = 2;

			// Token: 0x04038112 RID: 229650
			public const int TexCoinIcon = 3;

			// Token: 0x04038113 RID: 229651
			public const int TxtNum = 4;

			// Token: 0x04038114 RID: 229652
			public const int PnlState = 5;

			// Token: 0x04038115 RID: 229653
			public const int SldBar = 6;

			// Token: 0x04038116 RID: 229654
			public const int SprFill = 7;

			// Token: 0x04038117 RID: 229655
			public const int SprUp = 8;

			// Token: 0x04038118 RID: 229656
			public const int PnlTips = 9;

			// Token: 0x04038119 RID: 229657
			public const int TxtTips = 10;
		}
	}
}
