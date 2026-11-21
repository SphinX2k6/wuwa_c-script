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
	// Token: 0x02004D7F RID: 19839
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleHudSpeedItem : UiPanelBase
	{
		// Token: 0x06031CC0 RID: 203968 RVA: 0x00DECF4C File Offset: 0x00DEB14C
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

		// Token: 0x06031CC1 RID: 203969 RVA: 0x00DED084 File Offset: 0x00DEB284
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

		// Token: 0x06031CC2 RID: 203970 RVA: 0x00DED1D8 File Offset: 0x00DEB3D8
		private void LoadResource()
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("MotorHudSoarAngleScaleCurve");
			ResourceSystem.Instance.LoadAsync<UCurveFloat>(stringConfig, delegate([Nullable(2)] UCurveFloat res, string _)
			{
				this.AngleScaleCurve = res;
			}, 100, "js_undefined");
		}

		// Token: 0x06031CC3 RID: 203971 RVA: 0x00DED20F File Offset: 0x00DEB40F
		protected override void OnBeforeShowImplement()
		{
			if (!this.IsLeft)
			{
				EventSystem.Instance.Add(EEventName.OnInteractViewVisibleChanged, new Action<bool>(this.OnInteractViewVisibleChanged));
			}
		}

		// Token: 0x06031CC4 RID: 203972 RVA: 0x00DED235 File Offset: 0x00DEB435
		protected override void OnAfterHideImplement()
		{
			if (!this.IsLeft)
			{
				EventSystem.Instance.Remove(EEventName.OnInteractViewVisibleChanged, new Action<bool>(this.OnInteractViewVisibleChanged));
			}
		}

		// Token: 0x06031CC5 RID: 203973 RVA: 0x00DED25C File Offset: 0x00DEB45C
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

		// Token: 0x06031CC6 RID: 203974 RVA: 0x00DED2A9 File Offset: 0x00DEB4A9
		public void SetSpeed(float speed, float maxSpeed)
		{
			this.MaxSpeed = maxSpeed;
			this.SpeedMachine.SetTargetPercent(speed);
		}

		// Token: 0x06031CC7 RID: 203975 RVA: 0x00DED2C0 File Offset: 0x00DEB4C0
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

		// Token: 0x06031CC8 RID: 203976 RVA: 0x00DED3FC File Offset: 0x00DEB5FC
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

		// Token: 0x06031CC9 RID: 203977 RVA: 0x00DED473 File Offset: 0x00DEB673
		private void OnInteractViewVisibleChanged(bool visible)
		{
			this.SetRootAlphaState(visible ? MotorcycleHudSpeedItem.EAlphaState.Transparent : MotorcycleHudSpeedItem.EAlphaState.Normal, false);
		}

		// Token: 0x06031CCA RID: 203978 RVA: 0x00DED484 File Offset: 0x00DEB684
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

		// Token: 0x06031CCB RID: 203979 RVA: 0x00DED4E8 File Offset: 0x00DEB6E8
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

		// Token: 0x06031CCC RID: 203980 RVA: 0x00DED540 File Offset: 0x00DEB740
		private void UpdateNodeAlpha(float a)
		{
			this.SpeedItem.SetAlpha(MathUtils.Instance.Lerp(1f, 0f, a * 2f));
			this.AngleItem.SetAlpha(MathUtils.Instance.Lerp(0f, 1f, a * 2f - 1f));
		}

		// Token: 0x06031CCD RID: 203981 RVA: 0x00DED59F File Offset: 0x00DEB79F
		public void SetMainColor(in FLinearColor color)
		{
			UUITexture barPointTexture = this.BarPointTexture;
			if (barPointTexture == null)
			{
				return;
			}
			barPointTexture.SetColor(color.ToFColor(true));
		}

		// Token: 0x06031CCE RID: 203982 RVA: 0x00DED5B8 File Offset: 0x00DEB7B8
		public void SetPointerColor(in FLinearColor color)
		{
			UUITexture arrowTexture = this.ArrowTexture;
			if (arrowTexture == null)
			{
				return;
			}
			arrowTexture.SetColor(color.ToFColor(true));
		}

		// Token: 0x06031CCF RID: 203983 RVA: 0x00DED5D1 File Offset: 0x00DEB7D1
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

		// Token: 0x06031CD0 RID: 203984 RVA: 0x00DED5F2 File Offset: 0x00DEB7F2
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

		// Token: 0x06031CD1 RID: 203985 RVA: 0x00DED613 File Offset: 0x00DEB813
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

		// Token: 0x0401A5B9 RID: 107961
		private const float ALPHA_TARGET_VALUE = 0.2f;

		// Token: 0x0401A5BA RID: 107962
		private const float ALPHA_CHANGE_DURATION = 300f;

		// Token: 0x0401A5BB RID: 107963
		public bool IsLeft;

		// Token: 0x0401A5BC RID: 107964
		[Nullable(1)]
		private readonly MotorcyclePercentMachine SpeedMachine = new MotorcyclePercentMachine();

		// Token: 0x0401A5BD RID: 107965
		private UUITexture BarTexture;

		// Token: 0x0401A5BE RID: 107966
		private UUITexture ArrowTexture;

		// Token: 0x0401A5BF RID: 107967
		private UUITexture BarPointTexture;

		// Token: 0x0401A5C0 RID: 107968
		private UUIArtText NumText;

		// Token: 0x0401A5C1 RID: 107969
		private UUIArtText NumTextStroke;

		// Token: 0x0401A5C2 RID: 107970
		private UUIArtText NumTextGlow;

		// Token: 0x0401A5C3 RID: 107971
		private UUITexture AngleTexture;

		// Token: 0x0401A5C4 RID: 107972
		private UUIItem SpeedItem;

		// Token: 0x0401A5C5 RID: 107973
		private UUIItem AngleItem;

		// Token: 0x0401A5C6 RID: 107974
		private float MaxSpeed;

		// Token: 0x0401A5C7 RID: 107975
		private float StartYaw = 30f;

		// Token: 0x0401A5C8 RID: 107976
		private float EndYaw = 175f;

		// Token: 0x0401A5C9 RID: 107977
		[Nullable(1)]
		private MotorcyclePercentMachine RootAlphaMachine = new MotorcyclePercentMachine();

		// Token: 0x0401A5CA RID: 107978
		private MotorcycleHudSpeedItem.EAlphaState RootAlphaState;

		// Token: 0x0401A5CB RID: 107979
		[Nullable(1)]
		private MotorcyclePercentMachine NodeAlphaMachine = new MotorcyclePercentMachine();

		// Token: 0x0401A5CC RID: 107980
		private MotorcycleHudSpeedItem.ENodeAlphaState NodeAlphaState;

		// Token: 0x0401A5CD RID: 107981
		private UCurveFloat AngleScaleCurve;

		// Token: 0x0401A5CE RID: 107982
		private bool IsVehicleSoar;

		// Token: 0x0200AA7A RID: 43642
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034AF1 RID: 215793
			BarTexture,
			// Token: 0x04034AF2 RID: 215794
			ArrowTexture,
			// Token: 0x04034AF3 RID: 215795
			BarPointTexture,
			// Token: 0x04034AF4 RID: 215796
			NumText,
			// Token: 0x04034AF5 RID: 215797
			NumTextStroke,
			// Token: 0x04034AF6 RID: 215798
			NumTextGlow,
			// Token: 0x04034AF7 RID: 215799
			SpeedItem,
			// Token: 0x04034AF8 RID: 215800
			AngleItem,
			// Token: 0x04034AF9 RID: 215801
			AngleTexture
		}

		// Token: 0x0200AA7B RID: 43643
		[NullableContext(0)]
		private enum EAlphaState
		{
			// Token: 0x04034AFB RID: 215803
			Normal,
			// Token: 0x04034AFC RID: 215804
			Transparent
		}

		// Token: 0x0200AA7C RID: 43644
		[NullableContext(0)]
		private enum ENodeAlphaState
		{
			// Token: 0x04034AFE RID: 215806
			Speed,
			// Token: 0x04034AFF RID: 215807
			Angle
		}
	}
}
