using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FirstPersonTurret.View
{
	// Token: 0x02005A84 RID: 23172
	[NullableContext(1)]
	[Nullable(0)]
	public class FirstPersonTurretRoleHpItem : UiPanelBase
	{
		// Token: 0x0603AAFD RID: 240381 RVA: 0x00DF9DA8 File Offset: 0x00DF7FA8
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

		// Token: 0x0603AAFE RID: 240382 RVA: 0x00DF9F60 File Offset: 0x00DF8160
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

		// Token: 0x0603AAFF RID: 240383 RVA: 0x00DFA05F File Offset: 0x00DF825F
		public void Refresh(float hp, float hpMax)
		{
			this.RefreshHpAndShield(hp, hpMax);
		}

		// Token: 0x0603AB00 RID: 240384 RVA: 0x00DFA069 File Offset: 0x00DF8269
		public void Tick(float delta)
		{
			this.LerpBarPercent(delta);
		}

		// Token: 0x0603AB01 RID: 240385 RVA: 0x00DFA072 File Offset: 0x00DF8272
		private void InitHpBar()
		{
			this.LowHpBarSprite.SetUIActive(false);
			this.HpBarSprite.SetUIActive(true);
			this.HpBufferSprite.SetUIActive(false);
			this.ShieldBarSprite.SetUIActive(false);
		}

		// Token: 0x0603AB02 RID: 240386 RVA: 0x00DFA0A4 File Offset: 0x00DF82A4
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

		// Token: 0x0603AB03 RID: 240387 RVA: 0x00DFA160 File Offset: 0x00DF8360
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

		// Token: 0x0603AB04 RID: 240388 RVA: 0x00DFA1C0 File Offset: 0x00DF83C0
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

		// Token: 0x0603AB05 RID: 240389 RVA: 0x00DFA200 File Offset: 0x00DF8400
		private void StopBarLerpAnimation()
		{
			this.TargetBarPercent = 0f;
			this.SourceBarPercent = 0f;
			this.HpBufferAnimTime = -1f;
			this.HpBufferSprite.SetUIActive(false);
		}

		// Token: 0x0603AB06 RID: 240390 RVA: 0x00DFA230 File Offset: 0x00DF8430
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

		// Token: 0x0401EA20 RID: 125472
		private const float LOW_HP_PERCENT = 0.2f;

		// Token: 0x0401EA21 RID: 125473
		private UUISprite HpBarSprite;

		// Token: 0x0401EA22 RID: 125474
		private UUISprite LowHpBarSprite;

		// Token: 0x0401EA23 RID: 125475
		private UUISprite HpBufferSprite;

		// Token: 0x0401EA24 RID: 125476
		private UUISprite ShieldBarSprite;

		// Token: 0x0401EA25 RID: 125477
		private UUIText HpText;

		// Token: 0x0401EA26 RID: 125478
		private UUIText HpText2;

		// Token: 0x0401EA27 RID: 125479
		private ULGUICanvas HpTextMask;

		// Token: 0x0401EA28 RID: 125480
		private float HpTextWidth;

		// Token: 0x0401EA29 RID: 125481
		private FMargin UeMargin;

		// Token: 0x0401EA2A RID: 125482
		private float CurrentBarPercent = -1f;

		// Token: 0x0401EA2B RID: 125483
		private float TargetBarPercent;

		// Token: 0x0401EA2C RID: 125484
		private float SourceBarPercent;

		// Token: 0x0401EA2D RID: 125485
		private float HpBufferAnimTime = -1f;

		// Token: 0x0401EA2E RID: 125486
		private float HpBufferAnimDuration;

		// Token: 0x0401EA2F RID: 125487
		private float CurHp;

		// Token: 0x0401EA30 RID: 125488
		private float CurHpMax = 1f;
	}
}
