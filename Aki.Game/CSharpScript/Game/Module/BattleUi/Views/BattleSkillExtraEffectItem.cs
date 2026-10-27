using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE4 RID: 23780
	public class BattleSkillExtraEffectItem : UiPanelBase
	{
		// Token: 0x0603C2C9 RID: 246473 RVA: 0x00E67BB3 File Offset: 0x00E65DB3
		public void SetEffectType(ESkillButtonExtraEffect effectType)
		{
			this.EffectType = effectType;
		}

		// Token: 0x0603C2CA RID: 246474 RVA: 0x00E67BBC File Offset: 0x00E65DBC
		public ESkillButtonExtraEffect GetEffectType()
		{
			return this.EffectType;
		}

		// Token: 0x0603C2CB RID: 246475 RVA: 0x00E67BC4 File Offset: 0x00E65DC4
		[NullableContext(1)]
		public virtual void Init(UUIItem rootUiItem)
		{
		}

		// Token: 0x0603C2CC RID: 246476 RVA: 0x00E67BC6 File Offset: 0x00E65DC6
		public void SetComponentActive(bool visibility)
		{
			this.TargetVisible = visibility;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.SetActive(visibility);
		}

		// Token: 0x0603C2CD RID: 246477 RVA: 0x00E67BDF File Offset: 0x00E65DDF
		public void Refresh(float extraEffectDuration)
		{
			this.ExtraEffectDuration = extraEffectDuration;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.OnRefresh();
		}

		// Token: 0x0603C2CE RID: 246478 RVA: 0x00E67BF7 File Offset: 0x00E65DF7
		protected virtual void OnRefresh()
		{
		}

		// Token: 0x0603C2CF RID: 246479 RVA: 0x00E67BF9 File Offset: 0x00E65DF9
		protected override void OnStart()
		{
			if (this.TargetVisible)
			{
				base.Show(null);
			}
		}

		// Token: 0x0603C2D0 RID: 246480 RVA: 0x00E67C0A File Offset: 0x00E65E0A
		protected override void OnBeforeShow()
		{
			this.OnRefresh();
		}

		// Token: 0x0603C2D1 RID: 246481 RVA: 0x00E67C12 File Offset: 0x00E65E12
		public virtual void Stop()
		{
		}

		// Token: 0x0401F5E8 RID: 128488
		protected bool TargetVisible;

		// Token: 0x0401F5E9 RID: 128489
		protected float ExtraEffectDuration;

		// Token: 0x0401F5EA RID: 128490
		protected ESkillButtonExtraEffect EffectType;
	}
}
