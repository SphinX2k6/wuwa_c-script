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
	// Token: 0x020049EE RID: 18926
	public class DangoBrawlHpBarItem : UiPanelBase
	{
		// Token: 0x0602F6DB RID: 194267 RVA: 0x00D3A7C0 File Offset: 0x00D389C0
		public DangoBrawlHpBarItem(bool isSelf)
		{
			this.IsSelf = isSelf;
		}

		// Token: 0x0602F6DC RID: 194268 RVA: 0x00D3A7E8 File Offset: 0x00D389E8
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

		// Token: 0x0602F6DD RID: 194269 RVA: 0x00D3A8D8 File Offset: 0x00D38AD8
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

		// Token: 0x0602F6DE RID: 194270 RVA: 0x00D3A993 File Offset: 0x00D38B93
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

		// Token: 0x0602F6DF RID: 194271 RVA: 0x00D3A9D0 File Offset: 0x00D38BD0
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

		// Token: 0x0602F6E0 RID: 194272 RVA: 0x00D3AA55 File Offset: 0x00D38C55
		public void OnBeginFatigue()
		{
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(true);
		}

		// Token: 0x0602F6E1 RID: 194273 RVA: 0x00D3AA6C File Offset: 0x00D38C6C
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

		// Token: 0x0602F6E2 RID: 194274 RVA: 0x00D3AAAC File Offset: 0x00D38CAC
		private void OnMaxHpChanged(int oldValue, int newValue)
		{
			int attr = this.GetAttr(DangoBrawlProType.Hp);
			this.RefreshHpBar(attr, attr, oldValue, newValue);
		}

		// Token: 0x0602F6E3 RID: 194275 RVA: 0x00D3AACC File Offset: 0x00D38CCC
		private void OnHpChanged(int oldValue, int newValue)
		{
			int attr = this.GetAttr(DangoBrawlProType.MaxHp);
			this.RefreshHpBar(oldValue, newValue, attr, attr);
		}

		// Token: 0x0602F6E4 RID: 194276 RVA: 0x00D3AAEB File Offset: 0x00D38CEB
		private void OnShieldChanged(int oldValue, int newValue)
		{
			DangoBrawlShieldAnimator shieldAnimator = this.ShieldAnimator;
			if (shieldAnimator == null)
			{
				return;
			}
			shieldAnimator.SetShield(newValue);
		}

		// Token: 0x0602F6E5 RID: 194277 RVA: 0x00D3AB00 File Offset: 0x00D38D00
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

		// Token: 0x0602F6E6 RID: 194278 RVA: 0x00D3AB3C File Offset: 0x00D38D3C
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

		// Token: 0x0602F6E7 RID: 194279 RVA: 0x00D3AC4C File Offset: 0x00D38E4C
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

		// Token: 0x04019218 RID: 102936
		private const int TICK_INTERVAL = 50;

		// Token: 0x04019219 RID: 102937
		private int AnimDelay = 500;

		// Token: 0x0401921A RID: 102938
		private const int DEFAULT_HP_CHANGE_COLOR = 25;

		// Token: 0x0401921B RID: 102939
		private readonly bool IsSelf;

		// Token: 0x0401921C RID: 102940
		private float TweenSpeed;

		// Token: 0x0401921D RID: 102941
		private float HpChangeColorRatio = 0.25f;

		// Token: 0x0401921E RID: 102942
		[Nullable(2)]
		private TimerHandle TickHandle;

		// Token: 0x0401921F RID: 102943
		[Nullable(2)]
		private DangoBrawlShieldAnimator ShieldAnimator;

		// Token: 0x04019220 RID: 102944
		private bool NeedTick;

		// Token: 0x04019221 RID: 102945
		private double StartAnimTime;

		// Token: 0x04019222 RID: 102946
		private float CurAnimHp;

		// Token: 0x04019223 RID: 102947
		private int CurTargetHp;

		// Token: 0x04019224 RID: 102948
		private int TargetMaxHp;

		// Token: 0x0200A68B RID: 42635
		private enum EComp
		{
			// Token: 0x040337C8 RID: 210888
			SpriteHp,
			// Token: 0x040337C9 RID: 210889
			SpriteHpWhite,
			// Token: 0x040337CA RID: 210890
			SpriteHpLight,
			// Token: 0x040337CB RID: 210891
			TxtShield,
			// Token: 0x040337CC RID: 210892
			TxtHpNum,
			// Token: 0x040337CD RID: 210893
			SpriteHpIncrease,
			// Token: 0x040337CE RID: 210894
			PanelShield
		}
	}
}
