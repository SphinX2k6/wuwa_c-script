using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D9D RID: 23965
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleHudSpeedItem : UiPanelBase
	{
		// Token: 0x0603CD63 RID: 249187 RVA: 0x00E9C694 File Offset: 0x00E9A894
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			if (this.IsLeft)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIArtText)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIArtText)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIArtText)));
				return;
			}
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUITexture)));
		}

		// Token: 0x0603CD64 RID: 249188 RVA: 0x00E9C7CC File Offset: 0x00E9A9CC
		protected override void OnStart()
		{
			this.BarTexture = base.GetTexture(0);
			this.ArrowTexture = base.GetTexture(1);
			this.BarPointTexture = base.GetTexture(2);
			if (this.IsLeft)
			{
				this.NumText = base.GetArtText(3);
				this.NumTextStroke = base.GetArtText(4);
				this.NumTextGlow = base.GetArtText(5);
				this.ArrowTexture.SetUIActive(false);
			}
			else
			{
				this.SpeedItem = base.GetItem(6);
				this.AngleItem = base.GetItem(7);
				this.AngleTexture = base.GetTexture(8);
				this.SpeedItem.SetUIActive(true);
				this.AngleItem.SetUIActive(false);
				this.SetRootAlphaState(UiManager.Instance.IsViewShow(EUiViewName.InteractionHintView) ? MotorcycleHudSpeedItem.EAlphaState.Transparent : MotorcycleHudSpeedItem.EAlphaState.Normal, true);
				this.NodeAlphaMachine.Duration = ConfigCommonParamById.GetFloatConfig("MotorHudSoarRightNodeAlphaDuration").Value;
				this.SetNodeAlphaState(MotorcycleHudSpeedItem.ENodeAlphaState.Speed, true);
				this.LoadResource();
			}
			this.SpeedMachine.Init(0f, null);
			IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("MotorHudPointerYawRange");
			if (floatArrayConfig != null && floatArrayConfig.Count > 1)
			{
				this.StartYaw = floatArrayConfig[0];
				this.EndYaw = floatArrayConfig[1];
			}
			this.OnSpeedUpdate(0f);
		}

		// Token: 0x0603CD65 RID: 249189 RVA: 0x00E9C920 File Offset: 0x00E9AB20
		private void LoadResource()
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("MotorHudSoarAngleScaleCurve");
			ResourceSystem.Instance.LoadAsync<UCurveFloat>(stringConfig, delegate([Nullable(2)] UCurveFloat res, string _)
			{
				this.AngleScaleCurve = res;
			}, 100, "js_undefined");
		}

		// Token: 0x0603CD66 RID: 249190 RVA: 0x00E9C957 File Offset: 0x00E9AB57
		protected override void OnBeforeShowImplement()
		{
			if (!this.IsLeft)
			{
				EventSystem.Instance.Add(EEventName.OnInteractViewVisibleChanged, new Action<bool>(this.OnInteractViewVisibleChanged));
			}
		}

		// Token: 0x0603CD67 RID: 249191 RVA: 0x00E9C97D File Offset: 0x00E9AB7D
		protected override void OnAfterHideImplement()
		{
			if (!this.IsLeft)
			{
				EventSystem.Instance.Remove(EEventName.OnInteractViewVisibleChanged, new Action<bool>(this.OnInteractViewVisibleChanged));
			}
		}

		// Token: 0x0603CD68 RID: 249192 RVA: 0x00E9C9A4 File Offset: 0x00E9ABA4
		public void SetSoarMode(bool vehicleSoar)
		{
			if (this.IsLeft)
			{
				return;
			}
			if (this.IsVehicleSoar == vehicleSoar)
			{
				return;
			}
			this.IsVehicleSoar = vehicleSoar;
			this.SpeedItem.SetUIActive(true);
			this.AngleItem.SetUIActive(true);
			this.SetNodeAlphaState(vehicleSoar ? MotorcycleHudSpeedItem.ENodeAlphaState.Angle : MotorcycleHudSpeedItem.ENodeAlphaState.Speed, false);
		}

		// Token: 0x0603CD69 RID: 249193 RVA: 0x00E9C9F1 File Offset: 0x00E9ABF1
		public void SetSpeed(float speed, float maxSpeed)
		{
			this.MaxSpeed = maxSpeed;
			this.SpeedMachine.SetTargetPercent(speed);
		}

		// Token: 0x0603CD6A RID: 249194 RVA: 0x00E9CA08 File Offset: 0x00E9AC08
		private void OnSpeedUpdate(float speed)
		{
			float num = (this.MaxSpeed > 0f) ? Math.Min(1f, speed / this.MaxSpeed) : 0f;
			if (!this.IsLeft && this.IsVehicleSoar && this.AngleScaleCurve != null)
			{
				num = this.AngleScaleCurve.GetFloatValue(num);
			}
			this.BarTexture.SetFillAmount(0.33f + num * 0.43f);
			if (!this.IsLeft && this.IsVehicleSoar)
			{
				UUIItem angleTexture = this.AngleTexture;
				FRotator frotator = new FRotator();
				frotator.Yaw = this.StartYaw + num * (this.EndYaw - this.StartYaw);
				angleTexture.SetUIRelativeRotation(frotator);
			}
			else
			{
				UUIItem arrowTexture = this.ArrowTexture;
				FRotator frotator = new FRotator();
				frotator.Yaw = this.StartYaw + num * (this.EndYaw - this.StartYaw);
				arrowTexture.SetUIRelativeRotation(frotator);
			}
			this.BarPointTexture.SetFillAmount(num);
			if (this.IsLeft)
			{
				string text = ((int)(speed * 0.036f)).ToString();
				this.NumText.SetText(text);
				UUIArtText numTextStroke = this.NumTextStroke;
				if (numTextStroke != null)
				{
					numTextStroke.SetText(text);
				}
				UUIArtText numTextGlow = this.NumTextGlow;
				if (numTextGlow == null)
				{
					return;
				}
				numTextGlow.SetText(text);
			}
		}

		// Token: 0x0603CD6B RID: 249195 RVA: 0x00E9CB44 File Offset: 0x00E9AD44
		public void Tick(float delta)
		{
			if (this.SpeedMachine.Update(delta))
			{
				this.OnSpeedUpdate(this.SpeedMachine.GetCurPercent());
			}
			if (!this.IsLeft)
			{
				if (this.RootAlphaMachine.Update(delta))
				{
					base.GetRootItem().SetAlpha(this.RootAlphaMachine.GetCurPercent());
				}
				if (this.NodeAlphaMachine.Update(delta))
				{
					this.UpdateNodeAlpha(this.NodeAlphaMachine.GetCurPercent());
				}
			}
		}

		// Token: 0x0603CD6C RID: 249196 RVA: 0x00E9CBBB File Offset: 0x00E9ADBB
		private void OnInteractViewVisibleChanged(bool visible)
		{
			this.SetRootAlphaState(visible ? MotorcycleHudSpeedItem.EAlphaState.Transparent : MotorcycleHudSpeedItem.EAlphaState.Normal, false);
		}

		// Token: 0x0603CD6D RID: 249197 RVA: 0x00E9CBCC File Offset: 0x00E9ADCC
		private void SetRootAlphaState(MotorcycleHudSpeedItem.EAlphaState state, bool force = false)
		{
			if (state == this.RootAlphaState && !force)
			{
				return;
			}
			this.RootAlphaState = state;
			float num = (state == MotorcycleHudSpeedItem.EAlphaState.Normal) ? 1f : 0.2f;
			if (!force)
			{
				this.RootAlphaMachine.SetTargetPercent(num);
				return;
			}
			this.RootAlphaMachine.Init(num, new float?(300f));
			base.GetRootItem().SetAlpha(num);
		}

		// Token: 0x0603CD6E RID: 249198 RVA: 0x00E9CC30 File Offset: 0x00E9AE30
		private void SetNodeAlphaState(MotorcycleHudSpeedItem.ENodeAlphaState state, bool force = false)
		{
			if (state == this.NodeAlphaState && !force)
			{
				return;
			}
			this.NodeAlphaState = state;
			int num = (state > MotorcycleHudSpeedItem.ENodeAlphaState.Speed) ? 1 : 0;
			if (!force)
			{
				this.NodeAlphaMachine.SetTargetPercent((float)num);
				return;
			}
			this.NodeAlphaMachine.Init((float)num, null);
			this.UpdateNodeAlpha((float)num);
		}

		// Token: 0x0603CD6F RID: 249199 RVA: 0x00E9CC88 File Offset: 0x00E9AE88
		private void UpdateNodeAlpha(float a)
		{
			this.SpeedItem.SetAlpha(MathUtils.Instance.Lerp(1f, 0f, a * 2f));
			this.AngleItem.SetAlpha(MathUtils.Instance.Lerp(0f, 1f, a * 2f - 1f));
		}

		// Token: 0x0603CD70 RID: 249200 RVA: 0x00E9CCE7 File Offset: 0x00E9AEE7
		public void SetMainColor(in FLinearColor color)
		{
			UUITexture barPointTexture = this.BarPointTexture;
			if (barPointTexture == null)
			{
				return;
			}
			barPointTexture.SetColor(color.ToFColor(true));
		}

		// Token: 0x0603CD71 RID: 249201 RVA: 0x00E9CD00 File Offset: 0x00E9AF00
		public void SetPointerColor(in FLinearColor color)
		{
			UUITexture arrowTexture = this.ArrowTexture;
			if (arrowTexture == null)
			{
				return;
			}
			arrowTexture.SetColor(color.ToFColor(true));
		}

		// Token: 0x0603CD72 RID: 249202 RVA: 0x00E9CD19 File Offset: 0x00E9AF19
		public void SetNumTextColor(in FLinearColor color)
		{
			if (this.IsLeft)
			{
				UUIArtText numText = this.NumText;
				if (numText == null)
				{
					return;
				}
				numText.SetColor(color.ToFColor(true));
			}
		}

		// Token: 0x0603CD73 RID: 249203 RVA: 0x00E9CD3A File Offset: 0x00E9AF3A
		public void SetNumTextStrokeColor(in FLinearColor color)
		{
			if (this.IsLeft)
			{
				UUIArtText numTextStroke = this.NumTextStroke;
				if (numTextStroke == null)
				{
					return;
				}
				numTextStroke.SetColor(color.ToFColor(true));
			}
		}

		// Token: 0x0603CD74 RID: 249204 RVA: 0x00E9CD5B File Offset: 0x00E9AF5B
		public void SetNumTextGlowColor(in FLinearColor color)
		{
			if (this.IsLeft)
			{
				UUIArtText numTextGlow = this.NumTextGlow;
				if (numTextGlow == null)
				{
					return;
				}
				numTextGlow.SetColor(color.ToFColor(true));
			}
		}

		// Token: 0x0401FB01 RID: 129793
		private const float ALPHA_TARGET_VALUE = 0.2f;

		// Token: 0x0401FB02 RID: 129794
		private const float ALPHA_CHANGE_DURATION = 300f;

		// Token: 0x0401FB03 RID: 129795
		public bool IsLeft;

		// Token: 0x0401FB04 RID: 129796
		[Nullable(1)]
		private readonly MotorcyclePercentMachine SpeedMachine = new MotorcyclePercentMachine();

		// Token: 0x0401FB05 RID: 129797
		private UUITexture BarTexture;

		// Token: 0x0401FB06 RID: 129798
		private UUITexture ArrowTexture;

		// Token: 0x0401FB07 RID: 129799
		private UUITexture BarPointTexture;

		// Token: 0x0401FB08 RID: 129800
		private UUIArtText NumText;

		// Token: 0x0401FB09 RID: 129801
		private UUIArtText NumTextStroke;

		// Token: 0x0401FB0A RID: 129802
		private UUIArtText NumTextGlow;

		// Token: 0x0401FB0B RID: 129803
		private UUITexture AngleTexture;

		// Token: 0x0401FB0C RID: 129804
		private UUIItem SpeedItem;

		// Token: 0x0401FB0D RID: 129805
		private UUIItem AngleItem;

		// Token: 0x0401FB0E RID: 129806
		private float MaxSpeed;

		// Token: 0x0401FB0F RID: 129807
		private float StartYaw = 30f;

		// Token: 0x0401FB10 RID: 129808
		private float EndYaw = 175f;

		// Token: 0x0401FB11 RID: 129809
		[Nullable(1)]
		private MotorcyclePercentMachine RootAlphaMachine = new MotorcyclePercentMachine();

		// Token: 0x0401FB12 RID: 129810
		private MotorcycleHudSpeedItem.EAlphaState RootAlphaState;

		// Token: 0x0401FB13 RID: 129811
		[Nullable(1)]
		private MotorcyclePercentMachine NodeAlphaMachine = new MotorcyclePercentMachine();

		// Token: 0x0401FB14 RID: 129812
		private MotorcycleHudSpeedItem.ENodeAlphaState NodeAlphaState;

		// Token: 0x0401FB15 RID: 129813
		private UCurveFloat AngleScaleCurve;

		// Token: 0x0401FB16 RID: 129814
		private bool IsVehicleSoar;

		// Token: 0x0200C074 RID: 49268
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A12E RID: 237870
			BarTexture,
			// Token: 0x0403A12F RID: 237871
			ArrowTexture,
			// Token: 0x0403A130 RID: 237872
			BarPointTexture,
			// Token: 0x0403A131 RID: 237873
			NumText,
			// Token: 0x0403A132 RID: 237874
			NumTextStroke,
			// Token: 0x0403A133 RID: 237875
			NumTextGlow,
			// Token: 0x0403A134 RID: 237876
			SpeedItem,
			// Token: 0x0403A135 RID: 237877
			AngleItem,
			// Token: 0x0403A136 RID: 237878
			AngleTexture
		}

		// Token: 0x0200C075 RID: 49269
		[NullableContext(0)]
		private enum EAlphaState
		{
			// Token: 0x0403A138 RID: 237880
			Normal,
			// Token: 0x0403A139 RID: 237881
			Transparent
		}

		// Token: 0x0200C076 RID: 49270
		[NullableContext(0)]
		private enum ENodeAlphaState
		{
			// Token: 0x0403A13B RID: 237883
			Speed,
			// Token: 0x0403A13C RID: 237884
			Angle
		}
	}
}
