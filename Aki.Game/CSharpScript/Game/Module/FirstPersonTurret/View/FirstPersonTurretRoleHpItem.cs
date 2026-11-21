using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FirstPersonTurret.View
{
	// Token: 0x02004A60 RID: 19040
	[NullableContext(1)]
	[Nullable(0)]
	public class FirstPersonTurretRoleHpItem : UiPanelBase
	{
		// Token: 0x0602FA46 RID: 195142 RVA: 0x00D4A33C File Offset: 0x00D4853C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FA47 RID: 195143 RVA: 0x00D4A4F4 File Offset: 0x00D486F4
		protected override void OnStart()
		{
			this.HpBarSprite = base.GetSprite(0);
			this.LowHpBarSprite = base.GetSprite(3);
			this.HpBufferSprite = base.GetSprite(4);
			this.ShieldBarSprite = base.GetSprite(5);
			this.HpText = base.GetText(1);
			this.HpText2 = base.GetText(7);
			this.HpTextMask = (base.GetItem(8).GetOwner().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
			this.HpTextWidth = this.HpText.GetWidth();
			this.HpBufferAnimDuration = (float)ConfigCommonParamById.GetIntConfig("PlayerHPAttenuateBufferSpeed").GetValueOrDefault();
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			UUISprite sprite = base.GetSprite(10);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			this.InitHpBar();
		}

		// Token: 0x0602FA48 RID: 195144 RVA: 0x00D4A5F3 File Offset: 0x00D487F3
		public void Refresh(float hp, float hpMax)
		{
			this.RefreshHpAndShield(hp, hpMax);
		}

		// Token: 0x0602FA49 RID: 195145 RVA: 0x00D4A5FD File Offset: 0x00D487FD
		public void Tick(float delta)
		{
			this.LerpBarPercent(delta);
		}

		// Token: 0x0602FA4A RID: 195146 RVA: 0x00D4A606 File Offset: 0x00D48806
		private void InitHpBar()
		{
			this.LowHpBarSprite.SetUIActive(false);
			this.HpBarSprite.SetUIActive(true);
			this.HpBufferSprite.SetUIActive(false);
			this.ShieldBarSprite.SetUIActive(false);
		}

		// Token: 0x0602FA4B RID: 195147 RVA: 0x00D4A638 File Offset: 0x00D48838
		private void RefreshHpAndShield(float hp, float hpMax)
		{
			if (hpMax <= 0f)
			{
				return;
			}
			this.CurHp = hp;
			this.CurHpMax = hpMax;
			float num = hp / hpMax;
			this.UeMargin.Right = -(1f - num) * this.HpTextWidth;
			this.HpTextMask.SetRectClipOffset(this.UeMargin);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling((double)hp));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling((double)hpMax));
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			this.HpText.SetText(newText, true);
			this.HpText2.SetText(newText, true);
			this.SetHpBarPercent(num);
			this.PlayBarAnimation();
			this.CurrentBarPercent = num;
		}

		// Token: 0x0602FA4C RID: 195148 RVA: 0x00D4A6F4 File Offset: 0x00D488F4
		private void SetHpBarPercent(float percent)
		{
			if (percent <= 0.2f)
			{
				this.LowHpBarSprite.SetUIActive(true);
				this.HpBarSprite.SetUIActive(false);
				this.LowHpBarSprite.SetFillAmount(percent);
				return;
			}
			this.LowHpBarSprite.SetUIActive(false);
			this.HpBarSprite.SetUIActive(true);
			this.HpBarSprite.SetFillAmount(percent);
		}

		// Token: 0x0602FA4D RID: 195149 RVA: 0x00D4A754 File Offset: 0x00D48954
		private void PlayBarAnimation()
		{
			float num = this.CurHp / this.CurHpMax;
			float currentBarPercent = this.CurrentBarPercent;
			if (num >= currentBarPercent)
			{
				return;
			}
			this.TargetBarPercent = num;
			this.SourceBarPercent = currentBarPercent;
			this.HpBufferAnimTime = 0f;
		}

		// Token: 0x0602FA4E RID: 195150 RVA: 0x00D4A794 File Offset: 0x00D48994
		private void StopBarLerpAnimation()
		{
			this.TargetBarPercent = 0f;
			this.SourceBarPercent = 0f;
			this.HpBufferAnimTime = -1f;
			this.HpBufferSprite.SetUIActive(false);
		}

		// Token: 0x0602FA4F RID: 195151 RVA: 0x00D4A7C4 File Offset: 0x00D489C4
		private void LerpBarPercent(float delta)
		{
			if (this.HpBufferAnimTime == -1f)
			{
				return;
			}
			if (this.HpBufferAnimTime >= this.HpBufferAnimDuration)
			{
				this.StopBarLerpAnimation();
				return;
			}
			if (this.TargetBarPercent >= this.SourceBarPercent)
			{
				return;
			}
			float alpha = this.HpBufferAnimTime / this.HpBufferAnimDuration;
			float fillAmount = MathUtils.Instance.Lerp(this.SourceBarPercent, this.TargetBarPercent, alpha);
			this.HpBufferSprite.SetFillAmount(fillAmount);
			this.HpBufferSprite.SetUIActive(true);
			this.HpBufferAnimTime += delta;
		}

		// Token: 0x040194C7 RID: 103623
		private const float LOW_HP_PERCENT = 0.2f;

		// Token: 0x040194C8 RID: 103624
		private UUISprite HpBarSprite;

		// Token: 0x040194C9 RID: 103625
		private UUISprite LowHpBarSprite;

		// Token: 0x040194CA RID: 103626
		private UUISprite HpBufferSprite;

		// Token: 0x040194CB RID: 103627
		private UUISprite ShieldBarSprite;

		// Token: 0x040194CC RID: 103628
		private UUIText HpText;

		// Token: 0x040194CD RID: 103629
		private UUIText HpText2;

		// Token: 0x040194CE RID: 103630
		private ULGUICanvas HpTextMask;

		// Token: 0x040194CF RID: 103631
		private float HpTextWidth;

		// Token: 0x040194D0 RID: 103632
		private FMargin UeMargin;

		// Token: 0x040194D1 RID: 103633
		private float CurrentBarPercent = -1f;

		// Token: 0x040194D2 RID: 103634
		private float TargetBarPercent;

		// Token: 0x040194D3 RID: 103635
		private float SourceBarPercent;

		// Token: 0x040194D4 RID: 103636
		private float HpBufferAnimTime = -1f;

		// Token: 0x040194D5 RID: 103637
		private float HpBufferAnimDuration;

		// Token: 0x040194D6 RID: 103638
		private float CurHp;

		// Token: 0x040194D7 RID: 103639
		private float CurHpMax = 1f;
	}
}
