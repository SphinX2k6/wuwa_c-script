using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC6 RID: 19654
	public class BattleSkillExtraEffectItem : UiPanelBase
	{
		// Token: 0x0603121F RID: 201247 RVA: 0x00DB8167 File Offset: 0x00DB6367
		public void SetEffectType(ESkillButtonExtraEffect effectType)
		{
			this.EffectType = effectType;
		}

		// Token: 0x06031220 RID: 201248 RVA: 0x00DB8170 File Offset: 0x00DB6370
		public ESkillButtonExtraEffect GetEffectType()
		{
			return this.EffectType;
		}

		// Token: 0x06031221 RID: 201249 RVA: 0x00DB8178 File Offset: 0x00DB6378
		[NullableContext(1)]
		public virtual void Init(UUIItem rootUiItem)
		{
		}

		// Token: 0x06031222 RID: 201250 RVA: 0x00DB817A File Offset: 0x00DB637A
		public void SetComponentActive(bool visibility)
		{
			this.TargetVisible = visibility;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.SetActive(visibility);
		}

		// Token: 0x06031223 RID: 201251 RVA: 0x00DB8193 File Offset: 0x00DB6393
		public void Refresh(float extraEffectDuration)
		{
			this.ExtraEffectDuration = extraEffectDuration;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.OnRefresh();
		}

		// Token: 0x06031224 RID: 201252 RVA: 0x00DB81AB File Offset: 0x00DB63AB
		protected virtual void OnRefresh()
		{
		}

		// Token: 0x06031225 RID: 201253 RVA: 0x00DB81AD File Offset: 0x00DB63AD
		protected override void OnStart()
		{
			if (this.TargetVisible)
			{
				base.Show(null);
			}
		}

		// Token: 0x06031226 RID: 201254 RVA: 0x00DB81BE File Offset: 0x00DB63BE
		protected override void OnBeforeShow()
		{
			this.OnRefresh();
		}

		// Token: 0x06031227 RID: 201255 RVA: 0x00DB81C6 File Offset: 0x00DB63C6
		public virtual void Stop()
		{
		}

		// Token: 0x0401A0A1 RID: 106657
		protected bool TargetVisible;

		// Token: 0x0401A0A2 RID: 106658
		protected float ExtraEffectDuration;

		// Token: 0x0401A0A3 RID: 106659
		protected ESkillButtonExtraEffect EffectType;
	}
}
