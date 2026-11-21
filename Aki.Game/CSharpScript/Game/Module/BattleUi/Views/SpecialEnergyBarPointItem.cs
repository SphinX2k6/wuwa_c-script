using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E0C RID: 19980
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarPointItem : UiPanelBase
	{
		// Token: 0x06032449 RID: 205897 RVA: 0x00E16FFA File Offset: 0x00E151FA
		public void InitPrefabInfo(int pointNum, float pointWidth, bool leftToRight = true)
		{
			this.TotalPointNum = pointNum;
			this.PointWidth = pointWidth;
			this.LeftToRight = leftToRight;
		}

		// Token: 0x0603244A RID: 205898 RVA: 0x00E17014 File Offset: 0x00E15214
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			for (int i = 0; i < 3; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i + 3, typeof(UUINiagara)));
			}
		}

		// Token: 0x0603244B RID: 205899 RVA: 0x00E170C8 File Offset: 0x00E152C8
		protected override void OnStart()
		{
			for (int i = 0; i < 3; i++)
			{
				SpecialEnergyBarPointEffectInfo specialEnergyBarPointEffectInfo = new SpecialEnergyBarPointEffectInfo();
				specialEnergyBarPointEffectInfo.Effect = base.GetUiNiagara(i + 3);
				specialEnergyBarPointEffectInfo.Effect.SetUIActive(false);
				this.PointEffectInfoList.Add(specialEnergyBarPointEffectInfo);
			}
		}

		// Token: 0x0603244C RID: 205900 RVA: 0x00E17110 File Offset: 0x00E15310
		public void SetFullEffectColor(in FLinearColor color, bool isMorph = false)
		{
			base.GetUiNiagara(1).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(2).SetNiagaraVarLinearColor("Color", color);
			foreach (SpecialEnergyBarPointEffectInfo specialEnergyBarPointEffectInfo in this.PointEffectInfoList)
			{
				specialEnergyBarPointEffectInfo.Effect.SetNiagaraVarLinearColor("Color", color);
			}
			base.GetUiNiagara(1).SetNiagaraVarFloat("Default", !isMorph);
			base.GetUiNiagara(1).SetNiagaraVarFloat("Shift", isMorph > false);
		}

		// Token: 0x0603244D RID: 205901 RVA: 0x00E171CC File Offset: 0x00E153CC
		public void SetEffectBasePercent(float value)
		{
			this.SetEffectBasePercents(value, new float?(value), 0, null);
		}

		// Token: 0x0603244E RID: 205902 RVA: 0x00E171F0 File Offset: 0x00E153F0
		public void SetEffectBasePercents(float fullEffectPercent, float? fullBgEffectPercent = null, int fullEffectPointNum = 0, int? fullBgEffectPointNum = null)
		{
			this.FullEffectBasePercent = fullEffectPercent;
			this.FullBgEffectBasePercent = fullBgEffectPercent.GetValueOrDefault(fullEffectPercent);
			this.FullEffectPointNum = fullEffectPointNum;
			this.FullBgEffectPointNum = fullBgEffectPointNum.GetValueOrDefault(fullEffectPointNum);
			base.GetUiNiagara(1).SetNiagaraVarFloat("Dissolve", this.FullEffectBasePercent);
			base.GetUiNiagara(2).SetNiagaraVarFloat("Dissolve", this.FullBgEffectBasePercent);
		}

		// Token: 0x0603244F RID: 205903 RVA: 0x00E17258 File Offset: 0x00E15458
		public void UpdatePercent(float percent, bool playPointEffect = true, int pointEffectOffsetNum = 0)
		{
			int num = this.TotalPointNum - pointEffectOffsetNum;
			int num2 = (int)Math.Ceiling((double)(percent * (float)num));
			int num3 = (this.FullEffectPointNum > 0) ? this.FullEffectPointNum : this.TotalPointNum;
			int num4 = (this.FullBgEffectPointNum > 0) ? this.FullBgEffectPointNum : this.TotalPointNum;
			int num5 = (int)Math.Ceiling((double)(percent * (float)num3));
			int num6 = (int)Math.Ceiling((double)(percent * (float)num4));
			float num7 = this.FullEffectBasePercent * (float)num5 / (float)num3;
			float num8 = this.FullBgEffectBasePercent * (float)num6 / (float)num4;
			base.GetUiNiagara(1).SetNiagaraVarFloat("Dissolve", num7);
			base.GetUiNiagara(2).SetNiagaraVarFloat("Dissolve", num8);
			base.GetUiNiagara(1).SetUIActive(num7 > 0f);
			base.GetUiNiagara(2).SetUIActive(num8 > 0f);
			if (playPointEffect && this.CurNum > num2)
			{
				double finishTime = 500.0 + Time.Instance.Now;
				for (int i = Math.Min(num2 + 3, this.CurNum) - 1; i >= num2; i--)
				{
					int num9 = i + pointEffectOffsetNum;
					if (!this.LeftToRight)
					{
						num9 = this.TotalPointNum - num9 - 1;
					}
					float anchorOffsetX = this.PointWidth * (float)(num9 - (this.TotalPointNum - 1) / 2);
					SpecialEnergyBarPointEffectInfo nextPointEffect = this.GetNextPointEffect();
					UUINiagara effect = nextPointEffect.Effect;
					effect.SetAnchorOffsetX(anchorOffsetX);
					if (!nextPointEffect.IsPlaying)
					{
						effect.SetUIActive(true);
					}
					effect.ActivateSystem(true);
					nextPointEffect.IsPlaying = true;
					nextPointEffect.FinishTime = finishTime;
				}
				this.IsAnyEffectPlaying = true;
			}
			this.CurNum = num2;
		}

		// Token: 0x06032450 RID: 205904 RVA: 0x00E173F6 File Offset: 0x00E155F6
		public void UpdatePercentWithVisible(float percent, bool visible, bool changeVisible, bool isStart)
		{
			if (changeVisible || isStart)
			{
				this.RootItem.SetUIActive(visible);
			}
			if (visible)
			{
				this.UpdatePercent(percent, !changeVisible && !isStart, 0);
			}
		}

		// Token: 0x06032451 RID: 205905 RVA: 0x00E17420 File Offset: 0x00E15620
		public void UpdateLeftRightPercent(float leftPercent, float rightPercent)
		{
			int num = (int)Math.Ceiling((double)(leftPercent * (float)this.TotalPointNum));
			int num2 = (int)Math.Ceiling((double)(rightPercent * (float)this.TotalPointNum));
			if (this.LeftNum == num && this.RightNum == num2)
			{
				return;
			}
			this.LeftNum = num;
			this.RightNum = num2;
			float anchorOffsetX = this.PointWidth * (float)num;
			base.GetItem(0).SetAnchorOffsetX(anchorOffsetX);
			float value = (float)(num2 - num) / (float)this.TotalPointNum;
			base.GetUiNiagara(1).SetNiagaraVarFloat("Dissolve", value);
			base.GetUiNiagara(2).SetNiagaraVarFloat("Dissolve", value);
		}

		// Token: 0x06032452 RID: 205906 RVA: 0x00E174B8 File Offset: 0x00E156B8
		private SpecialEnergyBarPointEffectInfo GetNextPointEffect()
		{
			SpecialEnergyBarPointEffectInfo result = this.PointEffectInfoList[this.NextPointEffectIndex];
			this.NextPointEffectIndex++;
			if (this.NextPointEffectIndex >= 3)
			{
				this.NextPointEffectIndex = 0;
			}
			return result;
		}

		// Token: 0x06032453 RID: 205907 RVA: 0x00E174EC File Offset: 0x00E156EC
		public void Tick(float delta)
		{
			if (!this.IsAnyEffectPlaying)
			{
				return;
			}
			this.IsAnyEffectPlaying = false;
			foreach (SpecialEnergyBarPointEffectInfo specialEnergyBarPointEffectInfo in this.PointEffectInfoList)
			{
				if (specialEnergyBarPointEffectInfo.IsPlaying)
				{
					if (specialEnergyBarPointEffectInfo.FinishTime <= Time.Instance.Now)
					{
						specialEnergyBarPointEffectInfo.Effect.SetUIActive(false);
						specialEnergyBarPointEffectInfo.IsPlaying = false;
					}
					else
					{
						this.IsAnyEffectPlaying = true;
					}
				}
			}
		}

		// Token: 0x06032454 RID: 205908 RVA: 0x00E17580 File Offset: 0x00E15780
		public void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(1);
			if (this.DefaultFullEffectNiagara == null)
			{
				this.DefaultFullEffectNiagara = uiNiagara.NiagaraSystemReference;
			}
			uiNiagara.SetNiagaraSystem(niagara);
		}

		// Token: 0x06032455 RID: 205909 RVA: 0x00E175B0 File Offset: 0x00E157B0
		public void ResetFullEffect()
		{
			if (this.DefaultFullEffectNiagara != null)
			{
				base.GetUiNiagara(1).SetNiagaraSystem(this.DefaultFullEffectNiagara);
				this.DefaultFullEffectNiagara = null;
			}
		}

		// Token: 0x06032456 RID: 205910 RVA: 0x00E175D3 File Offset: 0x00E157D3
		protected override void OnBeforeDestroy()
		{
			this.ResetFullEffect();
		}

		// Token: 0x0401AA3A RID: 109114
		private const int POINT_EFFECT_NUM = 3;

		// Token: 0x0401AA3B RID: 109115
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401AA3C RID: 109116
		private int TotalPointNum = 1;

		// Token: 0x0401AA3D RID: 109117
		private float PointWidth;

		// Token: 0x0401AA3E RID: 109118
		private bool LeftToRight = true;

		// Token: 0x0401AA3F RID: 109119
		private int CurNum;

		// Token: 0x0401AA40 RID: 109120
		private int LeftNum;

		// Token: 0x0401AA41 RID: 109121
		private int RightNum;

		// Token: 0x0401AA42 RID: 109122
		private readonly List<SpecialEnergyBarPointEffectInfo> PointEffectInfoList = new List<SpecialEnergyBarPointEffectInfo>();

		// Token: 0x0401AA43 RID: 109123
		private int NextPointEffectIndex;

		// Token: 0x0401AA44 RID: 109124
		private bool IsAnyEffectPlaying;

		// Token: 0x0401AA45 RID: 109125
		private float FullEffectBasePercent = 1f;

		// Token: 0x0401AA46 RID: 109126
		private float FullBgEffectBasePercent = 1f;

		// Token: 0x0401AA47 RID: 109127
		private int FullEffectPointNum;

		// Token: 0x0401AA48 RID: 109128
		private int FullBgEffectPointNum;

		// Token: 0x0401AA49 RID: 109129
		[Nullable(2)]
		private UNiagaraSystem DefaultFullEffectNiagara;

		// Token: 0x0200ABB6 RID: 43958
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035239 RID: 217657
			EffectMaskItem,
			// Token: 0x0403523A RID: 217658
			FullEffect,
			// Token: 0x0403523B RID: 217659
			FullBgEffect,
			// Token: 0x0403523C RID: 217660
			PointEffect1
		}
	}
}
