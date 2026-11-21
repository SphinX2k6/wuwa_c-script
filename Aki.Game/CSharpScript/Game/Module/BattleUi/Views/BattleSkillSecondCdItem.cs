using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD2 RID: 19666
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillSecondCdItem : UiPanelBase
	{
		// Token: 0x0603134D RID: 201549 RVA: 0x00DBC802 File Offset: 0x00DBAA02
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x0603134E RID: 201550 RVA: 0x00DBC80C File Offset: 0x00DBAA0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603134F RID: 201551 RVA: 0x00DBC854 File Offset: 0x00DBAA54
		protected override void OnStart()
		{
			this.CoolDownBarUiSprite = base.GetSprite(0);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			FRotator frotator = new FRotator(0f, (float)(this.Index * 90), 0f);
			rootItem.SetUIRelativeRotation(frotator);
		}

		// Token: 0x06031350 RID: 201552 RVA: 0x00DBC89C File Offset: 0x00DBAA9C
		public void RefreshSkillCoolDown(SkillButtonData skillButtonData)
		{
			this.SkillButtonData = skillButtonData;
			if (this.SkillButtonData == null)
			{
				this.FinishSkillCoolDown();
				return;
			}
			if (this.IsSkillInItemUseBuffCd() && this.TryRefreshItemUseBuffCd())
			{
				return;
			}
			if (this.IsSkillInItemUseSkillCd() && this.TryRefreshItemUseSkillCd())
			{
				return;
			}
			if (this.SkillButtonData.IsMultiStageSkill().GetValueOrDefault() && this.TryRefreshMultiSkillCoolDown())
			{
				return;
			}
			this.TryRefreshCommonSkillCoolDown();
		}

		// Token: 0x06031351 RID: 201553 RVA: 0x00DBC905 File Offset: 0x00DBAB05
		public void Tick(float delta)
		{
			this.TickSkillCoolDown(delta);
		}

		// Token: 0x06031352 RID: 201554 RVA: 0x00DBC90E File Offset: 0x00DBAB0E
		private void PlayCommonCd(float remainingCoolDown, float totalCoolDown)
		{
			this.CurrentCoolDownTime = 0f;
			if (remainingCoolDown <= 0f)
			{
				this.FinishSkillCoolDown();
				return;
			}
			this.CurrentCoolDownTime = remainingCoolDown;
			this.TotalCoolDownTime = totalCoolDown;
			if (!base.IsShowOrShowing)
			{
				base.Show(null);
			}
		}

		// Token: 0x06031353 RID: 201555 RVA: 0x00DBC947 File Offset: 0x00DBAB47
		private void FinishSkillCoolDown()
		{
			if (base.IsShowOrShowing)
			{
				base.Hide(null);
			}
			this.CurrentCoolDownTime = 0f;
		}

		// Token: 0x06031354 RID: 201556 RVA: 0x00DBC964 File Offset: 0x00DBAB64
		private void TickSkillCoolDown(float delta)
		{
			if (this.CurrentCoolDownTime <= 0f || this.TotalCoolDownTime <= 0f || this.CoolDownBarUiSprite == null)
			{
				return;
			}
			if (SkillCdController.Instance.IsPause() || Time.Instance.TimeDilation <= 0f)
			{
				return;
			}
			this.CurrentCoolDownTime -= delta * Time.Instance.TimeDilation * (float)TimeUtil.Instance.Millisecond;
			if (this.CurrentCoolDownTime < 0f)
			{
				this.CurrentCoolDownTime = 0f;
				this.CoolDownBarUiSprite.SetFillAmount(0f);
				this.FinishSkillCoolDown();
				return;
			}
			float num = this.CurrentCoolDownTime / this.TotalCoolDownTime;
			num = 0.3f + num * 0.4f;
			this.CoolDownBarUiSprite.SetFillAmount(num);
		}

		// Token: 0x06031355 RID: 201557 RVA: 0x00DBCA2E File Offset: 0x00DBAC2E
		private bool IsSkillInItemUseBuffCd()
		{
			SkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseBuffCd();
		}

		// Token: 0x06031356 RID: 201558 RVA: 0x00DBCA58 File Offset: 0x00DBAC58
		private bool TryRefreshItemUseBuffCd()
		{
			ValueTuple<double, double> equippedItemUsingBuffCd = this.SkillButtonData.GetEquippedItemUsingBuffCd();
			double item = equippedItemUsingBuffCd.Item1;
			double item2 = equippedItemUsingBuffCd.Item2;
			if (item > 0.0)
			{
				this.PlayCommonCd((float)item, (float)item2);
				return true;
			}
			return false;
		}

		// Token: 0x06031357 RID: 201559 RVA: 0x00DBCA96 File Offset: 0x00DBAC96
		private bool IsSkillInItemUseSkillCd()
		{
			SkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseSkillCd();
		}

		// Token: 0x06031358 RID: 201560 RVA: 0x00DBCAC0 File Offset: 0x00DBACC0
		private bool TryRefreshItemUseSkillCd()
		{
			ValueTuple<double, double> equippedItemUsingSkillCd = this.SkillButtonData.GetEquippedItemUsingSkillCd();
			double item = equippedItemUsingSkillCd.Item1;
			double item2 = equippedItemUsingSkillCd.Item2;
			if (item > 0.0)
			{
				this.PlayCommonCd((float)item, (float)item2);
				return true;
			}
			return false;
		}

		// Token: 0x06031359 RID: 201561 RVA: 0x00DBCB00 File Offset: 0x00DBAD00
		private bool TryRefreshMultiSkillCoolDown()
		{
			MultiSkillInfo multiSkillInfo = this.SkillButtonData.GetMultiSkillInfo();
			if (multiSkillInfo != null)
			{
				int? nextSkillId = multiSkillInfo.NextSkillId;
				int num = 0;
				if (!(nextSkillId.GetValueOrDefault() == num & nextSkillId != null))
				{
					double remainingStartTime = multiSkillInfo.RemainingStartTime;
					float startTime = multiSkillInfo.StartTime;
					if (remainingStartTime > 0.0)
					{
						this.PlayCommonCd((float)remainingStartTime, startTime);
					}
					else
					{
						this.FinishSkillCoolDown();
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603135A RID: 201562 RVA: 0x00DBCB6C File Offset: 0x00DBAD6C
		private void TryRefreshCommonSkillCoolDown()
		{
			GroupSkillCdInfo groupSkillCdInfo = this.SkillButtonData.GetGroupSkillCdInfo();
			if (groupSkillCdInfo == null)
			{
				return;
			}
			float curRemainingCd = groupSkillCdInfo.CurRemainingCd;
			float curMaxCd = groupSkillCdInfo.CurMaxCd;
			this.PlayCommonCd(curRemainingCd, curMaxCd);
		}

		// Token: 0x0401A10E RID: 106766
		private const float AMOUNT_START = 0.3f;

		// Token: 0x0401A10F RID: 106767
		private const float AMOUNT_SCALE = 0.4f;

		// Token: 0x0401A110 RID: 106768
		private int Index;

		// Token: 0x0401A111 RID: 106769
		private SkillButtonData SkillButtonData;

		// Token: 0x0401A112 RID: 106770
		private UUISprite CoolDownBarUiSprite;

		// Token: 0x0401A113 RID: 106771
		private float CurrentCoolDownTime;

		// Token: 0x0401A114 RID: 106772
		private float TotalCoolDownTime;

		// Token: 0x0200A955 RID: 43349
		[NullableContext(0)]
		private enum EBattleSkillItem
		{
			// Token: 0x040344F4 RID: 214260
			CoolDownBarSprite
		}
	}
}
