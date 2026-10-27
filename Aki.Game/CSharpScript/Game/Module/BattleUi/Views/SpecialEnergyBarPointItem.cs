using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E27 RID: 24103
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarPointItem : UiPanelBase
	{
		// Token: 0x0603D4BA RID: 251066 RVA: 0x00EC5A9A File Offset: 0x00EC3C9A
		public void InitPrefabInfo(int pointNum, float pointWidth, bool leftToRight = true)
		{
			this.TotalPointNum = pointNum;
			this.PointWidth = pointWidth;
			this.LeftToRight = leftToRight;
		}

		// Token: 0x0603D4BB RID: 251067 RVA: 0x00EC5AB4 File Offset: 0x00EC3CB4
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

		// Token: 0x0603D4BC RID: 251068 RVA: 0x00EC5B68 File Offset: 0x00EC3D68
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

		// Token: 0x0603D4BD RID: 251069 RVA: 0x00EC5BB0 File Offset: 0x00EC3DB0
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

		// Token: 0x0603D4BE RID: 251070 RVA: 0x00EC5C6C File Offset: 0x00EC3E6C
		public void SetEffectBasePercent(float value)
		{
			this.SetEffectBasePercents(value, new float?(value), 0, null);
		}

		// Token: 0x0603D4BF RID: 251071 RVA: 0x00EC5C90 File Offset: 0x00EC3E90
		public void SetEffectBasePercents(float fullEffectPercent, float? fullBgEffectPercent = null, int fullEffectPointNum = 0, int? fullBgEffectPointNum = null)
		{
			this.FullEffectBasePercent = fullEffectPercent;
			this.FullBgEffectBasePercent = fullBgEffectPercent.GetValueOrDefault(fullEffectPercent);
			this.FullEffectPointNum = fullEffectPointNum;
			this.FullBgEffectPointNum = fullBgEffectPointNum.GetValueOrDefault(fullEffectPointNum);
			base.GetUiNiagara(1).SetNiagaraVarFloat("Dissolve", this.FullEffectBasePercent);
			base.GetUiNiagara(2).SetNiagaraVarFloat("Dissolve", this.FullBgEffectBasePercent);
		}

		// Token: 0x0603D4C0 RID: 251072 RVA: 0x00EC5CF8 File Offset: 0x00EC3EF8
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

		// Token: 0x0603D4C1 RID: 251073 RVA: 0x00EC5E96 File Offset: 0x00EC4096
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

		// Token: 0x0603D4C2 RID: 251074 RVA: 0x00EC5EC0 File Offset: 0x00EC40C0
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

		// Token: 0x0603D4C3 RID: 251075 RVA: 0x00EC5F58 File Offset: 0x00EC4158
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

		// Token: 0x0603D4C4 RID: 251076 RVA: 0x00EC5F8C File Offset: 0x00EC418C
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

		// Token: 0x0603D4C5 RID: 251077 RVA: 0x00EC6020 File Offset: 0x00EC4220
		public void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(1);
			if (this.DefaultFullEffectNiagara == null)
			{
				this.DefaultFullEffectNiagara = uiNiagara.NiagaraSystemReference;
			}
			uiNiagara.SetNiagaraSystem(niagara);
		}

		// Token: 0x0603D4C6 RID: 251078 RVA: 0x00EC6050 File Offset: 0x00EC4250
		public void ResetFullEffect()
		{
			if (this.DefaultFullEffectNiagara != null)
			{
				base.GetUiNiagara(1).SetNiagaraSystem(this.DefaultFullEffectNiagara);
				this.DefaultFullEffectNiagara = null;
			}
		}

		// Token: 0x0603D4C7 RID: 251079 RVA: 0x00EC6073 File Offset: 0x00EC4273
		protected override void OnBeforeDestroy()
		{
			this.ResetFullEffect();
		}

		// Token: 0x0401FF73 RID: 130931
		private const int POINT_EFFECT_NUM = 3;

		// Token: 0x0401FF74 RID: 130932
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401FF75 RID: 130933
		private int TotalPointNum = 1;

		// Token: 0x0401FF76 RID: 130934
		private float PointWidth;

		// Token: 0x0401FF77 RID: 130935
		private bool LeftToRight = true;

		// Token: 0x0401FF78 RID: 130936
		private int CurNum;

		// Token: 0x0401FF79 RID: 130937
		private int LeftNum;

		// Token: 0x0401FF7A RID: 130938
		private int RightNum;

		// Token: 0x0401FF7B RID: 130939
		private readonly List<SpecialEnergyBarPointEffectInfo> PointEffectInfoList = new List<SpecialEnergyBarPointEffectInfo>();

		// Token: 0x0401FF7C RID: 130940
		private int NextPointEffectIndex;

		// Token: 0x0401FF7D RID: 130941
		private bool IsAnyEffectPlaying;

		// Token: 0x0401FF7E RID: 130942
		private float FullEffectBasePercent = 1f;

		// Token: 0x0401FF7F RID: 130943
		private float FullBgEffectBasePercent = 1f;

		// Token: 0x0401FF80 RID: 130944
		private int FullEffectPointNum;

		// Token: 0x0401FF81 RID: 130945
		private int FullBgEffectPointNum;

		// Token: 0x0401FF82 RID: 130946
		[Nullable(2)]
		private UNiagaraSystem DefaultFullEffectNiagara;

		// Token: 0x0200C1A7 RID: 49575
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A847 RID: 239687
			EffectMaskItem,
			// Token: 0x0403A848 RID: 239688
			FullEffect,
			// Token: 0x0403A849 RID: 239689
			FullBgEffect,
			// Token: 0x0403A84A RID: 239690
			PointEffect1
		}
	}
}
