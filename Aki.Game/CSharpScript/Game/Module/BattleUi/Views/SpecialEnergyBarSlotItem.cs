using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E0F RID: 19983
	public class SpecialEnergyBarSlotItem : UiPanelBase
	{
		// Token: 0x06032469 RID: 205929 RVA: 0x00E17B9C File Offset: 0x00E15D9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603246A RID: 205930 RVA: 0x00E17CF0 File Offset: 0x00E15EF0
		protected override void OnStart()
		{
			base.GetSprite(0).SetUIActive(true);
			base.GetSprite(1).SetUIActive(true);
			base.GetSprite(7).SetUIActive(true);
			base.GetSprite(8).SetUIActive(true);
			base.GetUiNiagara(3).SetUIActive(false);
			base.GetUiNiagara(4).SetUIActive(false);
			base.GetUiNiagara(5).SetUIActive(false);
			base.GetUiNiagara(6).SetUIActive(false);
			this.InitUseEffectOffsetX = base.GetUiNiagara(6).GetAnchorOffsetX();
			UUISprite sprite = base.GetSprite(7);
			base.GetSprite(8).SetStretchLeft(sprite.GetStretchLeft());
			this.InitStretchRight = sprite.GetStretchRight();
			this.InitWidth = sprite.Width;
			this.InitTileX = sprite.tileX;
		}

		// Token: 0x0603246B RID: 205931 RVA: 0x00E17DB5 File Offset: 0x00E15FB5
		public void SetBarColor(in FColor color)
		{
			base.GetSprite(1).SetColor(color);
		}

		// Token: 0x0603246C RID: 205932 RVA: 0x00E17DC9 File Offset: 0x00E15FC9
		public void SetPointBgColor(in FColor color)
		{
			base.GetSprite(7).SetColor(color);
		}

		// Token: 0x0603246D RID: 205933 RVA: 0x00E17DDD File Offset: 0x00E15FDD
		public void SetPointColor(in FColor color)
		{
			base.GetSprite(8).SetColor(color);
		}

		// Token: 0x0603246E RID: 205934 RVA: 0x00E17DF4 File Offset: 0x00E15FF4
		public void SetFullEffectColor(in FLinearColor color, bool isMorph = false)
		{
			base.GetUiNiagara(3).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(4).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(6).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(3).SetNiagaraVarFloat("Default", !isMorph);
			base.GetUiNiagara(3).SetNiagaraVarFloat("Shift", isMorph > false);
		}

		// Token: 0x0603246F RID: 205935 RVA: 0x00E17E72 File Offset: 0x00E16072
		public void SetBgAndUseEffectColor(in FLinearColor color)
		{
			base.GetUiNiagara(4).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(6).SetNiagaraVarLinearColor("Color", color);
		}

		// Token: 0x06032470 RID: 205936 RVA: 0x00E17EA2 File Offset: 0x00E160A2
		public void SetChangeEffectColor(in FLinearColor color)
		{
			base.GetUiNiagara(5).SetNiagaraVarLinearColor("Color", color);
		}

		// Token: 0x06032471 RID: 205937 RVA: 0x00E17EBC File Offset: 0x00E160BC
		public void SetEffectBasePercent(float value)
		{
			this.EffectBasePercent = value;
			base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
			base.GetUiNiagara(4).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
			base.GetUiNiagara(5).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
			base.GetUiNiagara(6).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
		}

		// Token: 0x06032472 RID: 205938 RVA: 0x00E17F2C File Offset: 0x00E1612C
		public void SetFullEffectPercent(float value)
		{
			base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", value);
		}

		// Token: 0x06032473 RID: 205939 RVA: 0x00E17F40 File Offset: 0x00E16140
		public void SetUseEffectMode(EUseEffectMode mode)
		{
			if (this.UseEffectMode == mode)
			{
				return;
			}
			this.UseEffectMode = mode;
		}

		// Token: 0x06032474 RID: 205940 RVA: 0x00E17F54 File Offset: 0x00E16154
		public void UpdatePercent(float percent, bool fullEffectEnable, bool ignoreUseEffect = false)
		{
			int num = 0;
			if ((double)percent <= 1E-08)
			{
				num = -1;
			}
			else if ((double)percent >= 0.99999999 && fullEffectEnable)
			{
				num = 1;
			}
			if (this.State != num)
			{
				if (num == -1)
				{
					base.GetSprite(0).SetUIActive(true);
					base.GetSprite(7).SetUIActive(true);
					base.GetSprite(8).SetUIActive(false);
					base.GetSprite(1).SetUIActive(false);
					base.GetUiNiagara(3).SetUIActive(false);
					base.GetUiNiagara(4).SetUIActive(false);
					base.GetUiNiagara(5).SetUIActive(false);
					if (this.State == 1 && !ignoreUseEffect)
					{
						this.PlayUseEffect(false);
					}
				}
				else if (num == 1)
				{
					base.GetSprite(0).SetUIActive(false);
					base.GetSprite(7).SetUIActive(false);
					base.GetSprite(8).SetUIActive(false);
					base.GetSprite(1).SetUIActive(false);
					base.GetUiNiagara(3).SetUIActive(true);
					base.GetUiNiagara(4).SetUIActive(true);
					base.GetUiNiagara(6).SetUIActive(false);
					this.PlayChangeEffect();
				}
				else
				{
					base.GetSprite(0).SetUIActive(true);
					base.GetSprite(7).SetUIActive(true);
					base.GetSprite(8).SetUIActive(true);
					base.GetSprite(1).SetUIActive(true);
					base.GetUiNiagara(3).SetUIActive(false);
					base.GetUiNiagara(4).SetUIActive(false);
					base.GetUiNiagara(5).SetUIActive(false);
					if (this.State == 1 && !ignoreUseEffect)
					{
						this.PlayUseEffect(false);
					}
				}
				this.State = num;
			}
			if (num == 0)
			{
				base.GetSprite(1).SetFillAmount(percent);
				this.SetPointPercent(percent);
			}
		}

		// Token: 0x06032475 RID: 205941 RVA: 0x00E18108 File Offset: 0x00E16308
		public void UpdatePercentWithVisible(float percent, bool visible, bool changeVisible, bool isStart, float lastPercent)
		{
			if (visible)
			{
				base.GetSprite(1).SetFillAmount(percent);
				this.SetPointPercent(percent);
			}
			if (isStart)
			{
				base.GetSprite(0).SetUIActive(visible);
				base.GetSprite(1).SetUIActive(visible);
				base.GetSprite(7).SetUIActive(visible);
				base.GetSprite(8).SetUIActive(visible);
				base.GetUiNiagara(5).SetUIActive(false);
				base.GetUiNiagara(6).SetUIActive(false);
				return;
			}
			if (changeVisible)
			{
				base.GetSprite(0).SetUIActive(visible);
				base.GetSprite(1).SetUIActive(visible);
				base.GetSprite(7).SetUIActive(visible);
				base.GetSprite(8).SetUIActive(visible);
				if (visible)
				{
					base.GetUiNiagara(5).SetUIActive(false);
				}
				else
				{
					base.GetUiNiagara(5).SetNiagaraVarFloat("Dissolve", percent * this.EffectBasePercent);
					this.PlayChangeEffect();
				}
				if (visible && percent == 0f)
				{
					base.GetUiNiagara(6).SetNiagaraVarFloat("Dissolve", lastPercent * this.EffectBasePercent);
					this.PlayUseEffect(false);
					return;
				}
				base.GetUiNiagara(6).SetUIActive(false);
			}
		}

		// Token: 0x06032476 RID: 205942 RVA: 0x00E18224 File Offset: 0x00E16424
		public void UpdatePercentWithFullEffect(float fullEffectPercent, float fullBgEffectPercent, bool isStart)
		{
			if (isStart)
			{
				base.GetSprite(1).SetUIActive(false);
				base.GetSprite(8).SetUIActive(false);
				base.GetUiNiagara(5).SetUIActive(false);
				base.GetUiNiagara(6).SetUIActive(false);
				base.GetUiNiagara(3).SetUIActive(true);
				base.GetUiNiagara(4).SetUIActive(true);
			}
			base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", fullEffectPercent);
			base.GetUiNiagara(4).SetNiagaraVarFloat("Dissolve", fullBgEffectPercent);
			base.GetUiNiagara(3).SetUIActive(fullEffectPercent > 0f);
			base.GetUiNiagara(4).SetUIActive(fullBgEffectPercent > 0f);
			this.UpdateUseEffectByMode(fullEffectPercent, isStart);
		}

		// Token: 0x06032477 RID: 205943 RVA: 0x00E182D8 File Offset: 0x00E164D8
		public void UpdatePercentWithFullEffectEnable(float percent, bool fullEffectEnable, bool ignoreUseEffect = false)
		{
			int num = 0;
			if ((double)percent <= 1E-08)
			{
				num = -1;
			}
			else if (fullEffectEnable)
			{
				if ((double)percent < 0.99999999)
				{
					num = 1;
				}
				else
				{
					num = 2;
				}
			}
			if (this.State != num)
			{
				if (num == -1)
				{
					base.GetSprite(0).SetUIActive(true);
					base.GetSprite(7).SetUIActive(true);
					base.GetSprite(8).SetUIActive(false);
					base.GetSprite(1).SetUIActive(false);
					base.GetUiNiagara(3).SetUIActive(false);
					base.GetUiNiagara(4).SetUIActive(false);
					base.GetUiNiagara(5).SetUIActive(false);
					if (this.State == 1 && !ignoreUseEffect)
					{
						this.PlayUseEffect(false);
					}
				}
				else if (num == 1)
				{
					base.GetSprite(0).SetUIActive(false);
					base.GetSprite(7).SetUIActive(true);
					base.GetSprite(8).SetUIActive(false);
					base.GetSprite(1).SetUIActive(false);
					base.GetUiNiagara(3).SetUIActive(true);
					base.GetUiNiagara(4).SetUIActive(true);
					base.GetUiNiagara(6).SetUIActive(false);
					this.PlayChangeEffect();
				}
				else if (num == 2)
				{
					base.GetSprite(0).SetUIActive(false);
					base.GetSprite(7).SetUIActive(false);
					base.GetSprite(8).SetUIActive(false);
					base.GetSprite(1).SetUIActive(false);
					base.GetUiNiagara(3).SetUIActive(true);
					base.GetUiNiagara(4).SetUIActive(true);
					base.GetUiNiagara(6).SetUIActive(false);
					this.PlayChangeEffect();
				}
				else
				{
					base.GetSprite(0).SetUIActive(true);
					base.GetSprite(7).SetUIActive(true);
					base.GetSprite(8).SetUIActive(true);
					base.GetSprite(1).SetUIActive(true);
					base.GetUiNiagara(3).SetUIActive(false);
					base.GetUiNiagara(4).SetUIActive(false);
					base.GetUiNiagara(5).SetUIActive(false);
					if (this.State == 1 && !ignoreUseEffect)
					{
						this.PlayUseEffect(false);
					}
				}
				this.State = num;
			}
			if (num == 0)
			{
				base.GetSprite(1).SetFillAmount(percent);
				this.SetPointPercent(percent);
				return;
			}
			if (num == 1 || num == 2)
			{
				base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", percent);
				base.GetUiNiagara(4).SetNiagaraVarFloat("Dissolve", percent);
			}
		}

		// Token: 0x06032478 RID: 205944 RVA: 0x00E18524 File Offset: 0x00E16724
		private void SetPointPercent(float percent)
		{
			float num = Math.Max(0f, Math.Min(1f, percent));
			UUISprite sprite = base.GetSprite(8);
			sprite.SetStretchRight(this.InitStretchRight + this.InitWidth * (1f - num));
			sprite.SetTileX(this.InitTileX * num);
		}

		// Token: 0x06032479 RID: 205945 RVA: 0x00E18576 File Offset: 0x00E16776
		public void SetBarPercent(float percent)
		{
			base.GetSprite(1).SetUIActive(true);
			base.GetSprite(1).SetFillAmount(percent);
		}

		// Token: 0x0603247A RID: 205946 RVA: 0x00E18592 File Offset: 0x00E16792
		public void PlayUseEffectWithPercent(float percent)
		{
			base.GetUiNiagara(6).SetNiagaraVarFloat("Dissolve", percent * this.EffectBasePercent);
			this.PlayUseEffect(false);
		}

		// Token: 0x0603247B RID: 205947 RVA: 0x00E185B4 File Offset: 0x00E167B4
		public void UpdateUseEffectByMode(float percent, bool isStart = false)
		{
			float num = Math.Max(0f, Math.Min(1f, percent));
			if (this.LastUseEffectPercent < 0f || isStart)
			{
				this.LastUseEffectPercent = num;
				return;
			}
			float lastUseEffectPercent = this.LastUseEffectPercent;
			this.LastUseEffectPercent = num;
			EUseEffectMode useEffectMode = this.UseEffectMode;
			if (useEffectMode != EUseEffectMode.Default && useEffectMode == EUseEffectMode.EnergyDecreaseSegment)
			{
				this.PlayUseEffectSegment(num, lastUseEffectPercent);
			}
		}

		// Token: 0x0603247C RID: 205948 RVA: 0x00E18614 File Offset: 0x00E16814
		private void PlayUseEffectSegment(float startPercent, float endPercent)
		{
			float num = Math.Max(0f, Math.Min(1f, startPercent));
			float num2 = Math.Max(0f, Math.Min(1f, endPercent)) - num;
			if ((double)num2 <= 1E-08)
			{
				return;
			}
			base.GetUiNiagara(6).SetNiagaraVarFloat("Dissolve", num2 * this.EffectBasePercent);
			this.SetUseEffectOffsetXByPercent(num);
			this.PlayUseEffect(true);
		}

		// Token: 0x0603247D RID: 205949 RVA: 0x00E18684 File Offset: 0x00E16884
		private void PlayChangeEffect()
		{
			base.GetUiNiagara(5).SetUIActive(true);
			this.IsAnyEffectPlaying = true;
			this.ChangeEffectFinishTime = 500.0 + Time.Instance.Now;
		}

		// Token: 0x0603247E RID: 205950 RVA: 0x00E186B4 File Offset: 0x00E168B4
		public void PlayChangeEffectWithPercent(float percent)
		{
			base.GetUiNiagara(5).SetNiagaraVarFloat("Dissolve", percent);
			this.PlayChangeEffect();
		}

		// Token: 0x0603247F RID: 205951 RVA: 0x00E186D0 File Offset: 0x00E168D0
		public void SetChangeEffectOffsetX(float offsetX)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(5);
			if (!this.IsChangeEffectOffsetModify)
			{
				this.IsChangeEffectOffsetModify = true;
				this.DefaultChangeEffectOffsetX = uiNiagara.GetAnchorOffsetX();
			}
			uiNiagara.SetAnchorOffsetX(offsetX);
		}

		// Token: 0x06032480 RID: 205952 RVA: 0x00E18708 File Offset: 0x00E16908
		private void PlayUseEffect(bool restart = false)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			if (restart)
			{
				uiNiagara.SetUIActive(false);
			}
			uiNiagara.SetUIActive(true);
			this.IsAnyEffectPlaying = true;
			this.UseEffectFinishTime = 500.0 + Time.Instance.Now;
		}

		// Token: 0x06032481 RID: 205953 RVA: 0x00E18750 File Offset: 0x00E16950
		private void SetUseEffectOffsetXByPercent(float percent)
		{
			UUIItem uiNiagara = base.GetUiNiagara(6);
			UUIItem item = base.GetItem(2);
			float num = (item != null) ? item.Width : base.GetRootItem().Width;
			uiNiagara.SetAnchorOffsetX(this.InitUseEffectOffsetX + num * percent);
		}

		// Token: 0x06032482 RID: 205954 RVA: 0x00E18794 File Offset: 0x00E16994
		public void Tick(float delta)
		{
			if (!this.IsAnyEffectPlaying)
			{
				return;
			}
			this.IsAnyEffectPlaying = false;
			if (this.ChangeEffectFinishTime > 0.0)
			{
				if (this.ChangeEffectFinishTime <= Time.Instance.Now)
				{
					base.GetUiNiagara(5).SetUIActive(false);
					this.ChangeEffectFinishTime = 0.0;
				}
				else
				{
					this.IsAnyEffectPlaying = true;
				}
			}
			if (this.UseEffectFinishTime > 0.0)
			{
				if (this.UseEffectFinishTime <= Time.Instance.Now)
				{
					base.GetUiNiagara(6).SetUIActive(false);
					this.UseEffectFinishTime = 0.0;
					return;
				}
				this.IsAnyEffectPlaying = true;
			}
		}

		// Token: 0x06032483 RID: 205955 RVA: 0x00E18840 File Offset: 0x00E16A40
		[NullableContext(1)]
		public void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (this.DefaultFullEffectNiagara == null)
			{
				this.DefaultFullEffectNiagara = uiNiagara.NiagaraSystemReference;
			}
			uiNiagara.SetNiagaraSystem(niagara);
		}

		// Token: 0x06032484 RID: 205956 RVA: 0x00E18870 File Offset: 0x00E16A70
		public void RevertFullEffect()
		{
			if (this.DefaultFullEffectNiagara != null)
			{
				base.GetUiNiagara(3).SetNiagaraSystem(this.DefaultFullEffectNiagara);
				this.DefaultFullEffectNiagara = null;
			}
		}

		// Token: 0x06032485 RID: 205957 RVA: 0x00E18894 File Offset: 0x00E16A94
		public void SetFullEffectOffsetX(float offsetX)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (!this.IsFullEffectOffsetModify)
			{
				this.IsFullEffectOffsetModify = true;
				this.DefaultFullEffectOffsetX = uiNiagara.GetAnchorOffsetX();
			}
			uiNiagara.SetAnchorOffsetX(offsetX);
		}

		// Token: 0x06032486 RID: 205958 RVA: 0x00E188CB File Offset: 0x00E16ACB
		public void SetFullEffectVisible(bool visible)
		{
			base.GetUiNiagara(3).SetUIActive(visible);
		}

		// Token: 0x06032487 RID: 205959 RVA: 0x00E188DC File Offset: 0x00E16ADC
		protected override void OnBeforeDestroy()
		{
			if (this.DefaultFullEffectNiagara != null)
			{
				base.GetUiNiagara(3).SetNiagaraSystem(this.DefaultFullEffectNiagara);
				this.DefaultFullEffectNiagara = null;
			}
			if (this.IsFullEffectOffsetModify)
			{
				base.GetUiNiagara(3).SetAnchorOffsetX(this.DefaultFullEffectOffsetX);
				this.IsFullEffectOffsetModify = false;
			}
			if (this.IsChangeEffectOffsetModify)
			{
				base.GetUiNiagara(5).SetAnchorOffsetX(this.DefaultChangeEffectOffsetX);
				this.IsChangeEffectOffsetModify = false;
			}
			base.GetUiNiagara(6).SetAnchorOffsetX(this.InitUseEffectOffsetX);
		}

		// Token: 0x0401AA54 RID: 109140
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401AA55 RID: 109141
		protected int State;

		// Token: 0x0401AA56 RID: 109142
		private bool IsAnyEffectPlaying;

		// Token: 0x0401AA57 RID: 109143
		private double ChangeEffectFinishTime;

		// Token: 0x0401AA58 RID: 109144
		private double UseEffectFinishTime;

		// Token: 0x0401AA59 RID: 109145
		private float EffectBasePercent = 1f;

		// Token: 0x0401AA5A RID: 109146
		private float InitStretchRight;

		// Token: 0x0401AA5B RID: 109147
		private float InitWidth;

		// Token: 0x0401AA5C RID: 109148
		private float InitTileX;

		// Token: 0x0401AA5D RID: 109149
		[Nullable(2)]
		private UNiagaraSystem DefaultFullEffectNiagara;

		// Token: 0x0401AA5E RID: 109150
		private float DefaultFullEffectOffsetX = -1f;

		// Token: 0x0401AA5F RID: 109151
		private bool IsFullEffectOffsetModify;

		// Token: 0x0401AA60 RID: 109152
		private float DefaultChangeEffectOffsetX = -1f;

		// Token: 0x0401AA61 RID: 109153
		private bool IsChangeEffectOffsetModify;

		// Token: 0x0401AA62 RID: 109154
		private EUseEffectMode UseEffectMode;

		// Token: 0x0401AA63 RID: 109155
		private float InitUseEffectOffsetX;

		// Token: 0x0401AA64 RID: 109156
		private float LastUseEffectPercent = -1f;

		// Token: 0x0200ABB9 RID: 43961
		private enum EChildType
		{
			// Token: 0x04035248 RID: 217672
			BgSprite,
			// Token: 0x04035249 RID: 217673
			BarSprite,
			// Token: 0x0403524A RID: 217674
			EffectMaskItem,
			// Token: 0x0403524B RID: 217675
			FullEffect,
			// Token: 0x0403524C RID: 217676
			FullBgEffect,
			// Token: 0x0403524D RID: 217677
			ChangeEffect,
			// Token: 0x0403524E RID: 217678
			UseEffect,
			// Token: 0x0403524F RID: 217679
			PointBgSprite,
			// Token: 0x04035250 RID: 217680
			PointFgSprite
		}
	}
}
