using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;
using CSharpScript.Game.Module.GameMainView.DangoBrawl.Item.ShieldFSM;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A12 RID: 23058
	public class DangoBrawlHpBarItem : UiPanelBase
	{
		// Token: 0x0603A792 RID: 239506 RVA: 0x00DEA228 File Offset: 0x00DE8428
		public DangoBrawlHpBarItem(bool isSelf)
		{
			this.IsSelf = isSelf;
		}

		// Token: 0x0603A793 RID: 239507 RVA: 0x00DEA250 File Offset: 0x00DE8450
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A794 RID: 239508 RVA: 0x00DEA340 File Offset: 0x00DE8540
		protected override void OnStart()
		{
			this.AnimDelay = DangoBrawlConfig.Instance.GetHpTweenDelay();
			int hpTweenTime = DangoBrawlConfig.Instance.GetHpTweenTime();
			this.TweenSpeed = ((hpTweenTime > 0) ? (1f / (float)hpTweenTime) : 0f);
			int hpChangeColor = DangoBrawlConfig.Instance.GetHpChangeColor(ActivityDangoBrawlController.Instance.MyActivityId);
			this.HpChangeColorRatio = (float)hpChangeColor / 100f;
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				this.ShieldAnimator = new DangoBrawlShieldAnimator(this.RootItem, item, base.GetText(3), DangoBrawlConfig.Instance.GetShieldAnimDelay());
			}
			this.TickHandle = TimerSystem.Instance.Forever(new TTimerAction(this.OnTick), 50f, 1f, null, null, true);
		}

		// Token: 0x0603A795 RID: 239509 RVA: 0x00DEA3FB File Offset: 0x00DE85FB
		protected override void OnBeforeDestroy()
		{
			if (this.TickHandle != null)
			{
				TimerSystem.Instance.Remove(this.TickHandle);
				this.TickHandle = null;
			}
			DangoBrawlShieldAnimator shieldAnimator = this.ShieldAnimator;
			if (shieldAnimator != null)
			{
				shieldAnimator.Clear();
			}
			this.ShieldAnimator = null;
		}

		// Token: 0x0603A796 RID: 239510 RVA: 0x00DEA438 File Offset: 0x00DE8638
		public void RefreshBind()
		{
			ActivityGameplayEntity entity = DangoBrawlModel.Instance.GetBattleManager(true).GetEntity(this.IsSelf);
			if (entity == null)
			{
				return;
			}
			DangoAttributeComponent dangoAttributeComponent = entity.CheckGetComponent<DangoAttributeComponent>();
			if (dangoAttributeComponent == null)
			{
				return;
			}
			dangoAttributeComponent.AddChangedListener(0, new TActivityAttributeChangedCallback(this.OnMaxHpChanged));
			dangoAttributeComponent.AddChangedListener(1, new TActivityAttributeChangedCallback(this.OnHpChanged));
			dangoAttributeComponent.AddChangedListener(7, new TActivityAttributeChangedCallback(this.OnShieldChanged));
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			this.InitAttribute();
		}

		// Token: 0x0603A797 RID: 239511 RVA: 0x00DEA4BD File Offset: 0x00DE86BD
		public void OnBeginFatigue()
		{
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(true);
		}

		// Token: 0x0603A798 RID: 239512 RVA: 0x00DEA4D4 File Offset: 0x00DE86D4
		protected void InitAttribute()
		{
			int attr = this.GetAttr(DangoBrawlProType.MaxHp);
			int attr2 = this.GetAttr(DangoBrawlProType.Hp);
			int attr3 = this.GetAttr(DangoBrawlProType.Shield);
			this.RefreshHpBar(attr2, attr2, attr, attr);
			DangoBrawlShieldAnimator shieldAnimator = this.ShieldAnimator;
			if (shieldAnimator == null)
			{
				return;
			}
			shieldAnimator.Init(attr3);
		}

		// Token: 0x0603A799 RID: 239513 RVA: 0x00DEA514 File Offset: 0x00DE8714
		private void OnMaxHpChanged(int oldValue, int newValue)
		{
			int attr = this.GetAttr(DangoBrawlProType.Hp);
			this.RefreshHpBar(attr, attr, oldValue, newValue);
		}

		// Token: 0x0603A79A RID: 239514 RVA: 0x00DEA534 File Offset: 0x00DE8734
		private void OnHpChanged(int oldValue, int newValue)
		{
			int attr = this.GetAttr(DangoBrawlProType.MaxHp);
			this.RefreshHpBar(oldValue, newValue, attr, attr);
		}

		// Token: 0x0603A79B RID: 239515 RVA: 0x00DEA553 File Offset: 0x00DE8753
		private void OnShieldChanged(int oldValue, int newValue)
		{
			DangoBrawlShieldAnimator shieldAnimator = this.ShieldAnimator;
			if (shieldAnimator == null)
			{
				return;
			}
			shieldAnimator.SetShield(newValue);
		}

		// Token: 0x0603A79C RID: 239516 RVA: 0x00DEA568 File Offset: 0x00DE8768
		private int GetAttr(DangoBrawlProType type)
		{
			ActivityGameplayEntity entity = DangoBrawlModel.Instance.GetBattleManager(true).GetEntity(this.IsSelf);
			DangoAttributeComponent dangoAttributeComponent = (entity != null) ? entity.CheckGetComponent<DangoAttributeComponent>() : null;
			if (dangoAttributeComponent == null)
			{
				return 0;
			}
			return dangoAttributeComponent.GetAttribute((int)type);
		}

		// Token: 0x0603A79D RID: 239517 RVA: 0x00DEA5A4 File Offset: 0x00DE87A4
		private void RefreshHpBar(int oldHp, int newHp, int oldMaxHp, int newMaxHp)
		{
			float num = (newMaxHp > 0) ? ((float)newHp / (float)newMaxHp) : 0f;
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetFillAmount(num);
			}
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = num <= this.HpChangeColorRatio;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			this.CurTargetHp = newHp;
			this.TargetMaxHp = newMaxHp;
			UUISprite sprite2 = base.GetSprite(1);
			UUIText text = base.GetText(4);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(newHp);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(newMaxHp);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			bool needTick = this.NeedTick;
			this.NeedTick = (oldHp > newHp);
			if (!this.NeedTick)
			{
				if (sprite2 != null)
				{
					sprite2.SetFillAmount(num);
				}
				return;
			}
			if (needTick)
			{
				return;
			}
			this.StartAnimTime = Time.Instance.Now;
			this.CurAnimHp = (float)oldHp;
			float fillAmount = (newMaxHp > 0) ? (this.CurAnimHp / (float)newMaxHp) : 0f;
			if (sprite2 != null)
			{
				sprite2.SetFillAmount(fillAmount);
			}
		}

		// Token: 0x0603A79E RID: 239518 RVA: 0x00DEA6B4 File Offset: 0x00DE88B4
		private void OnTick(float delta)
		{
			DangoBrawlShieldAnimator shieldAnimator = this.ShieldAnimator;
			if (shieldAnimator != null)
			{
				shieldAnimator.Tick();
			}
			if (!this.NeedTick)
			{
				return;
			}
			if (Time.Instance.Now - this.StartAnimTime < (double)this.AnimDelay)
			{
				return;
			}
			this.CurAnimHp -= delta * this.TweenSpeed * (float)this.TargetMaxHp;
			if (this.CurAnimHp <= (float)this.CurTargetHp)
			{
				this.CurAnimHp = (float)this.CurTargetHp;
				this.NeedTick = false;
			}
			float fillAmount = (this.TargetMaxHp > 0) ? (this.CurAnimHp / (float)this.TargetMaxHp) : 0f;
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x0401E771 RID: 124785
		private const int TICK_INTERVAL = 50;

		// Token: 0x0401E772 RID: 124786
		private int AnimDelay = 500;

		// Token: 0x0401E773 RID: 124787
		private const int DEFAULT_HP_CHANGE_COLOR = 25;

		// Token: 0x0401E774 RID: 124788
		private readonly bool IsSelf;

		// Token: 0x0401E775 RID: 124789
		private float TweenSpeed;

		// Token: 0x0401E776 RID: 124790
		private float HpChangeColorRatio = 0.25f;

		// Token: 0x0401E777 RID: 124791
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x0401E778 RID: 124792
		[Nullable(2)]
		private DangoBrawlShieldAnimator ShieldAnimator;

		// Token: 0x0401E779 RID: 124793
		private bool NeedTick;

		// Token: 0x0401E77A RID: 124794
		private double StartAnimTime;

		// Token: 0x0401E77B RID: 124795
		private float CurAnimHp;

		// Token: 0x0401E77C RID: 124796
		private int CurTargetHp;

		// Token: 0x0401E77D RID: 124797
		private int TargetMaxHp;

		// Token: 0x0200BC82 RID: 48258
		private enum EComp
		{
			// Token: 0x04038DFD RID: 232957
			SpriteHp,
			// Token: 0x04038DFE RID: 232958
			SpriteHpWhite,
			// Token: 0x04038DFF RID: 232959
			SpriteHpLight,
			// Token: 0x04038E00 RID: 232960
			TxtShield,
			// Token: 0x04038E01 RID: 232961
			TxtHpNum,
			// Token: 0x04038E02 RID: 232962
			SpriteHpIncrease,
			// Token: 0x04038E03 RID: 232963
			PanelShield
		}
	}
}
