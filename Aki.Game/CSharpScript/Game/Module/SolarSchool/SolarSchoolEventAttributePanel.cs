using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005902 RID: 22786
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolEventAttributePanel : UiPanelBase
	{
		// Token: 0x060382C0 RID: 230080 RVA: 0x00FB3A5C File Offset: 0x00FB1C5C
		public SolarSchoolEventAttributePanel()
		{
			this.AttrItemComponents = new int[]
			{
				4,
				5,
				6,
				7,
				8
			};
		}

		// Token: 0x060382C1 RID: 230081 RVA: 0x00FB3AC4 File Offset: 0x00FB1CC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060382C2 RID: 230082 RVA: 0x00FB3CE4 File Offset: 0x00FB1EE4
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolEventAttributePanel.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolEventAttributePanel.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060382C3 RID: 230083 RVA: 0x00FB3D27 File Offset: 0x00FB1F27
		protected override void OnStart()
		{
			this.InitAttr();
			this.ResetResultColorTransition();
		}

		// Token: 0x060382C4 RID: 230084 RVA: 0x00FB3D35 File Offset: 0x00FB1F35
		protected override void OnBeforeDestroy()
		{
			this.ClearResultColorLerpTimer();
		}

		// Token: 0x060382C5 RID: 230085 RVA: 0x00FB3D40 File Offset: 0x00FB1F40
		private void InitAttr()
		{
			for (int i = 0; i < SolarSchoolDefine.AttrsShowList.Length; i++)
			{
				ESolarSchoolSecondAttr attrId = SolarSchoolDefine.AttrsShowList[i];
				this.AttrItems[i].RefreshAttr(attrId);
			}
		}

		// Token: 0x060382C6 RID: 230086 RVA: 0x00FB3D7C File Offset: 0x00FB1F7C
		public void SetPlayerAttr(float[] radii)
		{
			UUITexture texture = base.GetTexture(3);
			if (radii.Length != SolarSchoolDefine.AttrsShowList.Length)
			{
				return;
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA0"), radii[0]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA1"), radii[1]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA2"), radii[2]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA3"), radii[3]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA4"), radii[4]);
			}
		}

		// Token: 0x060382C7 RID: 230087 RVA: 0x00FB3E0C File Offset: 0x00FB200C
		public void SetEventAttr(float[] radii)
		{
			UUITexture texture = base.GetTexture(3);
			if (radii.Length != SolarSchoolDefine.AttrsShowList.Length)
			{
				return;
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB0"), radii[0]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB1"), radii[1]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB2"), radii[2]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB3"), radii[3]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB4"), radii[4]);
			}
		}

		// Token: 0x060382C8 RID: 230088 RVA: 0x00FB3E9C File Offset: 0x00FB209C
		public void SetSuccess()
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetCustomMaterialVectorParameter(new FName("ColorOverlap"), SolarSchoolEventAttributePanel.GetOverlapColor("EventCheckSuccessOverlapColor"));
			}
			this.StartResultColorTransition(0f, 0f, 1f);
			this.SetPanelPointVisible(true, new ESolarSchoolEventCheckPointState?(ESolarSchoolEventCheckPointState.Success));
		}

		// Token: 0x060382C9 RID: 230089 RVA: 0x00FB3EF4 File Offset: 0x00FB20F4
		public void SetFail()
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetCustomMaterialVectorParameter(new FName("ColorOverlap"), SolarSchoolEventAttributePanel.GetOverlapColor("EventCheckFailOverlapColor"));
			}
			this.StartResultColorTransition(0f, 1f, 1f);
			this.SetPanelPointVisible(true, new ESolarSchoolEventCheckPointState?(ESolarSchoolEventCheckPointState.Fail));
		}

		// Token: 0x060382CA RID: 230090 RVA: 0x00FB3F49 File Offset: 0x00FB2149
		public void ResetResultColorTransition()
		{
			this.ClearResultColorLerpTimer();
			this.SetResultColorBlend(0f);
		}

		// Token: 0x060382CB RID: 230091 RVA: 0x00FB3F5C File Offset: 0x00FB215C
		private void StartResultColorTransition(float enableAOnlyTarget, float enableBOnlyTarget, float enableOverlapTarget)
		{
			this.ClearResultColorLerpTimer();
			this.ResultColorLerpElapsedTime = 0f;
			this.EnableAOnlyTarget = Math.Clamp(enableAOnlyTarget, 0f, 1f);
			this.EnableBOnlyTarget = Math.Clamp(enableBOnlyTarget, 0f, 1f);
			this.EnableOverlapTarget = Math.Clamp(enableOverlapTarget, 0f, 1f);
			this.SetResultColorBlend(0f);
			this.ResultColorLerpTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.UpdateResultColorTransition), 20f, 1f, null, null, true);
		}

		// Token: 0x060382CC RID: 230092 RVA: 0x00FB3FF0 File Offset: 0x00FB21F0
		private void UpdateResultColorTransition(float deltaTime)
		{
			this.ResultColorLerpElapsedTime = Math.Min(this.ResultColorLerpElapsedTime + deltaTime, 100f);
			float num = this.ResultColorLerpElapsedTime / 100f;
			this.SetResultColorBlend(num);
			if (num >= 1f)
			{
				this.ClearResultColorLerpTimer();
			}
		}

		// Token: 0x060382CD RID: 230093 RVA: 0x00FB4038 File Offset: 0x00FB2238
		private void SetResultColorBlend(float progress)
		{
			UUITexture texture = base.GetTexture(3);
			float num = Math.Clamp(progress, 0f, 1f);
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(this.EnableAOnlyParameterName, this.EnableAOnlyTarget * num);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(this.EnableBOnlyParameterName, this.EnableBOnlyTarget * num);
			}
			if (texture == null)
			{
				return;
			}
			texture.SetCustomMaterialScalarParameter(this.EnableOverlapParameterName, this.EnableOverlapTarget * num);
		}

		// Token: 0x060382CE RID: 230094 RVA: 0x00FB40A9 File Offset: 0x00FB22A9
		private void ClearResultColorLerpTimer()
		{
			if (this.ResultColorLerpTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ResultColorLerpTimer);
				this.ResultColorLerpTimer = null;
			}
		}

		// Token: 0x060382CF RID: 230095 RVA: 0x00FB40CC File Offset: 0x00FB22CC
		private static FLinearColor GetOverlapColor(string key)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			FColor fcolor = FColor.FromHex(SolarSchoolConfig.Instance.TryGetParamString(activityId, key));
			return FLinearColor.FromSRGBColor(fcolor);
		}

		// Token: 0x060382D0 RID: 230096 RVA: 0x00FB4100 File Offset: 0x00FB2300
		public void SetRatio(double ratePercent, bool useChangeColor = false)
		{
			double value = ratePercent / 100.0;
			UUIText text = base.GetText(2);
			UUIText text2 = base.GetText(1);
			if (text != null)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<double>(value, "0.##");
				defaultInterpolatedStringHandler.AppendLiteral("%");
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			if (text2 != null)
			{
				UUIItem uuiitem = text2;
				FColor? fcolor;
				FColor? fcolor2;
				if (text2 == null)
				{
					fcolor = null;
					fcolor2 = fcolor;
				}
				else
				{
					fcolor2 = new FColor?(text2.changeColor);
				}
				fcolor = fcolor2;
				uuiitem.SetChangeColor(useChangeColor, fcolor);
			}
			if (text != null)
			{
				UUIItem uuiitem2 = text;
				FColor? fcolor;
				FColor? fcolor3;
				if (text == null)
				{
					fcolor = null;
					fcolor3 = fcolor;
				}
				else
				{
					fcolor3 = new FColor?(text.changeColor);
				}
				fcolor = fcolor3;
				uuiitem2.SetChangeColor(useChangeColor, fcolor);
			}
		}

		// Token: 0x060382D1 RID: 230097 RVA: 0x00FB41AC File Offset: 0x00FB23AC
		public void SetPanelRatioVisible(bool visible)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(visible);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!visible);
		}

		// Token: 0x060382D2 RID: 230098 RVA: 0x00FB41D8 File Offset: 0x00FB23D8
		public void SetPointPosition(float normX, float normY)
		{
			UUITexture texture = base.GetTexture(3);
			UUIItem item = base.GetItem(9);
			if (texture == null || item == null)
			{
				return;
			}
			item.SetAnchorOffsetX(normX * texture.GetWidth() * 0.5f);
			item.SetAnchorOffsetY(normY * texture.GetHeight() * 0.5f);
		}

		// Token: 0x060382D3 RID: 230099 RVA: 0x00FB4228 File Offset: 0x00FB2428
		public void SetPanelPointVisible(bool visible, ESolarSchoolEventCheckPointState? state = null)
		{
			if (state != null)
			{
				ESolarSchoolEventCheckPointState? esolarSchoolEventCheckPointState = state;
				ESolarSchoolEventCheckPointState esolarSchoolEventCheckPointState2 = ESolarSchoolEventCheckPointState.Going;
				bool flag = esolarSchoolEventCheckPointState.GetValueOrDefault() == esolarSchoolEventCheckPointState2 & esolarSchoolEventCheckPointState != null;
				bool uiactive = state.GetValueOrDefault() == ESolarSchoolEventCheckPointState.Success;
				bool uiactive2 = state.GetValueOrDefault() == ESolarSchoolEventCheckPointState.Fail;
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(flag);
				}
				UUIItem item2 = base.GetItem(11);
				if (item2 != null)
				{
					item2.SetUIActive(uiactive);
				}
				UUIItem item3 = base.GetItem(12);
				if (item3 != null)
				{
					item3.SetUIActive(uiactive2);
				}
				UUIItem item4 = base.GetItem(13);
				if (item4 != null)
				{
					item4.SetUIActive(!flag);
				}
			}
			UUIItem item5 = base.GetItem(9);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(visible);
		}

		// Token: 0x0401D931 RID: 121137
		private const string EventCheckSuccessOverlapColorKey = "EventCheckSuccessOverlapColor";

		// Token: 0x0401D932 RID: 121138
		private const string EventCheckFailOverlapColorKey = "EventCheckFailOverlapColor";

		// Token: 0x0401D933 RID: 121139
		private const float ResultColorLerpDurationMs = 100f;

		// Token: 0x0401D934 RID: 121140
		private readonly FName EnableAOnlyParameterName = new FName("EnableAOnly");

		// Token: 0x0401D935 RID: 121141
		private readonly FName EnableBOnlyParameterName = new FName("EnableBOnly");

		// Token: 0x0401D936 RID: 121142
		private readonly FName EnableOverlapParameterName = new FName("EnableOverlap");

		// Token: 0x0401D937 RID: 121143
		private readonly int[] AttrItemComponents;

		// Token: 0x0401D938 RID: 121144
		private readonly List<SolarSchoolEventAttributeItem> AttrItems = new List<SolarSchoolEventAttributeItem>();

		// Token: 0x0401D939 RID: 121145
		[Nullable(2)]
		private TimerHandle ResultColorLerpTimer;

		// Token: 0x0401D93A RID: 121146
		private float ResultColorLerpElapsedTime;

		// Token: 0x0401D93B RID: 121147
		private float EnableAOnlyTarget;

		// Token: 0x0401D93C RID: 121148
		private float EnableBOnlyTarget;

		// Token: 0x0401D93D RID: 121149
		private float EnableOverlapTarget;

		// Token: 0x0200B4BE RID: 46270
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037E2D RID: 228909
			public const int PnlAttrComplete = 0;

			// Token: 0x04037E2E RID: 228910
			public const int TxtRatioName = 1;

			// Token: 0x04037E2F RID: 228911
			public const int TxtRatio = 2;

			// Token: 0x04037E30 RID: 228912
			public const int TexEventAttrRadar = 3;

			// Token: 0x04037E31 RID: 228913
			public const int AttrItem01 = 4;

			// Token: 0x04037E32 RID: 228914
			public const int AttrItem02 = 5;

			// Token: 0x04037E33 RID: 228915
			public const int AttrItem03 = 6;

			// Token: 0x04037E34 RID: 228916
			public const int AttrItem04 = 7;

			// Token: 0x04037E35 RID: 228917
			public const int AttrItem05 = 8;

			// Token: 0x04037E36 RID: 228918
			public const int PanelPoint = 9;

			// Token: 0x04037E37 RID: 228919
			public const int ItemPointGoing = 10;

			// Token: 0x04037E38 RID: 228920
			public const int ItemPointSuccess = 11;

			// Token: 0x04037E39 RID: 228921
			public const int ItemPointFail = 12;

			// Token: 0x04037E3A RID: 228922
			public const int PnlResult = 13;

			// Token: 0x04037E3B RID: 228923
			public const int PnlMyAttr = 14;
		}
	}
}
