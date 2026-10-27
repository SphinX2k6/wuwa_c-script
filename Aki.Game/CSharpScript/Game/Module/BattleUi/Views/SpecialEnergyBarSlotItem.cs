using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E2A RID: 24106
	public class SpecialEnergyBarSlotItem : UiPanelBase
	{
		// Token: 0x0603D4D9 RID: 251097 RVA: 0x00EC6630 File Offset: 0x00EC4830
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

		// Token: 0x0603D4DA RID: 251098 RVA: 0x00EC6784 File Offset: 0x00EC4984
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

		// Token: 0x0603D4DB RID: 251099 RVA: 0x00EC6849 File Offset: 0x00EC4A49
		public void SetBarColor(in FColor color)
		{
			base.GetSprite(1).SetColor(color);
		}

		// Token: 0x0603D4DC RID: 251100 RVA: 0x00EC685D File Offset: 0x00EC4A5D
		public void SetPointBgColor(in FColor color)
		{
			base.GetSprite(7).SetColor(color);
		}

		// Token: 0x0603D4DD RID: 251101 RVA: 0x00EC6871 File Offset: 0x00EC4A71
		public void SetPointColor(in FColor color)
		{
			base.GetSprite(8).SetColor(color);
		}

		// Token: 0x0603D4DE RID: 251102 RVA: 0x00EC6888 File Offset: 0x00EC4A88
		public void SetFullEffectColor(in FLinearColor color, bool isMorph = false)
		{
			base.GetUiNiagara(3).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(4).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(6).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(3).SetNiagaraVarFloat("Default", !isMorph);
			base.GetUiNiagara(3).SetNiagaraVarFloat("Shift", isMorph > false);
		}

		// Token: 0x0603D4DF RID: 251103 RVA: 0x00EC6906 File Offset: 0x00EC4B06
		public void SetBgAndUseEffectColor(in FLinearColor color)
		{
			base.GetUiNiagara(4).SetNiagaraVarLinearColor("Color", color);
			base.GetUiNiagara(6).SetNiagaraVarLinearColor("Color", color);
		}

		// Token: 0x0603D4E0 RID: 251104 RVA: 0x00EC6936 File Offset: 0x00EC4B36
		public void SetChangeEffectColor(in FLinearColor color)
		{
			base.GetUiNiagara(5).SetNiagaraVarLinearColor("Color", color);
		}

		// Token: 0x0603D4E1 RID: 251105 RVA: 0x00EC6950 File Offset: 0x00EC4B50
		public void SetEffectBasePercent(float value)
		{
			this.EffectBasePercent = value;
			base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
			base.GetUiNiagara(4).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
			base.GetUiNiagara(5).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
			base.GetUiNiagara(6).SetNiagaraVarFloat("Dissolve", this.EffectBasePercent);
		}

		// Token: 0x0603D4E2 RID: 251106 RVA: 0x00EC69C0 File Offset: 0x00EC4BC0
		public void SetFullEffectPercent(float value)
		{
			base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", value);
		}

		// Token: 0x0603D4E3 RID: 251107 RVA: 0x00EC69D4 File Offset: 0x00EC4BD4
		public void SetUseEffectMode(EUseEffectMode mode)
		{
			if (this.UseEffectMode == mode)
			{
				return;
			}
			this.UseEffectMode = mode;
		}

		// Token: 0x0603D4E4 RID: 251108 RVA: 0x00EC69E8 File Offset: 0x00EC4BE8
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

		// Token: 0x0603D4E5 RID: 251109 RVA: 0x00EC6B9C File Offset: 0x00EC4D9C
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

		// Token: 0x0603D4E6 RID: 251110 RVA: 0x00EC6CB8 File Offset: 0x00EC4EB8
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

		// Token: 0x0603D4E7 RID: 251111 RVA: 0x00EC6D6C File Offset: 0x00EC4F6C
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

		// Token: 0x0603D4E8 RID: 251112 RVA: 0x00EC6FB8 File Offset: 0x00EC51B8
		private void SetPointPercent(float percent)
		{
			float num = Math.Max(0f, Math.Min(1f, percent));
			UUISprite sprite = base.GetSprite(8);
			sprite.SetStretchRight(this.InitStretchRight + this.InitWidth * (1f - num));
			sprite.SetTileX(this.InitTileX * num);
		}

		// Token: 0x0603D4E9 RID: 251113 RVA: 0x00EC700A File Offset: 0x00EC520A
		public void SetBarPercent(float percent)
		{
			base.GetSprite(1).SetUIActive(true);
			base.GetSprite(1).SetFillAmount(percent);
		}

		// Token: 0x0603D4EA RID: 251114 RVA: 0x00EC7026 File Offset: 0x00EC5226
		public void PlayUseEffectWithPercent(float percent)
		{
			base.GetUiNiagara(6).SetNiagaraVarFloat("Dissolve", percent * this.EffectBasePercent);
			this.PlayUseEffect(false);
		}

		// Token: 0x0603D4EB RID: 251115 RVA: 0x00EC7048 File Offset: 0x00EC5248
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

		// Token: 0x0603D4EC RID: 251116 RVA: 0x00EC70A8 File Offset: 0x00EC52A8
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

		// Token: 0x0603D4ED RID: 251117 RVA: 0x00EC7118 File Offset: 0x00EC5318
		private void PlayChangeEffect()
		{
			base.GetUiNiagara(5).SetUIActive(true);
			this.IsAnyEffectPlaying = true;
			this.ChangeEffectFinishTime = 500.0 + Time.Instance.Now;
		}

		// Token: 0x0603D4EE RID: 251118 RVA: 0x00EC7148 File Offset: 0x00EC5348
		public void PlayChangeEffectWithPercent(float percent)
		{
			base.GetUiNiagara(5).SetNiagaraVarFloat("Dissolve", percent);
			this.PlayChangeEffect();
		}

		// Token: 0x0603D4EF RID: 251119 RVA: 0x00EC7164 File Offset: 0x00EC5364
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

		// Token: 0x0603D4F0 RID: 251120 RVA: 0x00EC719C File Offset: 0x00EC539C
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

		// Token: 0x0603D4F1 RID: 251121 RVA: 0x00EC71E4 File Offset: 0x00EC53E4
		private void SetUseEffectOffsetXByPercent(float percent)
		{
			UUIItem uiNiagara = base.GetUiNiagara(6);
			UUIItem item = base.GetItem(2);
			float num = (item != null) ? item.Width : base.GetRootItem().Width;
			uiNiagara.SetAnchorOffsetX(this.InitUseEffectOffsetX + num * percent);
		}

		// Token: 0x0603D4F2 RID: 251122 RVA: 0x00EC7228 File Offset: 0x00EC5428
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

		// Token: 0x0603D4F3 RID: 251123 RVA: 0x00EC72D4 File Offset: 0x00EC54D4
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

		// Token: 0x0603D4F4 RID: 251124 RVA: 0x00EC7304 File Offset: 0x00EC5504
		public void RevertFullEffect()
		{
			if (this.DefaultFullEffectNiagara != null)
			{
				base.GetUiNiagara(3).SetNiagaraSystem(this.DefaultFullEffectNiagara);
				this.DefaultFullEffectNiagara = null;
			}
		}

		// Token: 0x0603D4F5 RID: 251125 RVA: 0x00EC7328 File Offset: 0x00EC5528
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

		// Token: 0x0603D4F6 RID: 251126 RVA: 0x00EC735F File Offset: 0x00EC555F
		public void SetFullEffectVisible(bool visible)
		{
			base.GetUiNiagara(3).SetUIActive(visible);
		}

		// Token: 0x0603D4F7 RID: 251127 RVA: 0x00EC7370 File Offset: 0x00EC5570
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

		// Token: 0x0401FF8D RID: 130957
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401FF8E RID: 130958
		protected int State;

		// Token: 0x0401FF8F RID: 130959
		private bool IsAnyEffectPlaying;

		// Token: 0x0401FF90 RID: 130960
		private double ChangeEffectFinishTime;

		// Token: 0x0401FF91 RID: 130961
		private double UseEffectFinishTime;

		// Token: 0x0401FF92 RID: 130962
		private float EffectBasePercent = 1f;

		// Token: 0x0401FF93 RID: 130963
		private float InitStretchRight;

		// Token: 0x0401FF94 RID: 130964
		private float InitWidth;

		// Token: 0x0401FF95 RID: 130965
		private float InitTileX;

		// Token: 0x0401FF96 RID: 130966
		[Nullable(2)]
		private UNiagaraSystem DefaultFullEffectNiagara;

		// Token: 0x0401FF97 RID: 130967
		private float DefaultFullEffectOffsetX = -1f;

		// Token: 0x0401FF98 RID: 130968
		private bool IsFullEffectOffsetModify;

		// Token: 0x0401FF99 RID: 130969
		private float DefaultChangeEffectOffsetX = -1f;

		// Token: 0x0401FF9A RID: 130970
		private bool IsChangeEffectOffsetModify;

		// Token: 0x0401FF9B RID: 130971
		private EUseEffectMode UseEffectMode;

		// Token: 0x0401FF9C RID: 130972
		private float InitUseEffectOffsetX;

		// Token: 0x0401FF9D RID: 130973
		private float LastUseEffectPercent = -1f;

		// Token: 0x0200C1AA RID: 49578
		private enum EChildType
		{
			// Token: 0x0403A856 RID: 239702
			BgSprite,
			// Token: 0x0403A857 RID: 239703
			BarSprite,
			// Token: 0x0403A858 RID: 239704
			EffectMaskItem,
			// Token: 0x0403A859 RID: 239705
			FullEffect,
			// Token: 0x0403A85A RID: 239706
			FullBgEffect,
			// Token: 0x0403A85B RID: 239707
			ChangeEffect,
			// Token: 0x0403A85C RID: 239708
			UseEffect,
			// Token: 0x0403A85D RID: 239709
			PointBgSprite,
			// Token: 0x0403A85E RID: 239710
			PointFgSprite
		}
	}
}
