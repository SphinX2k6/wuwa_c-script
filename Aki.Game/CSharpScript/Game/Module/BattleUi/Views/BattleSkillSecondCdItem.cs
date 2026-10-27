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
	// Token: 0x02005CF0 RID: 23792
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillSecondCdItem : UiPanelBase
	{
		// Token: 0x0603C3F7 RID: 246775 RVA: 0x00E6C24E File Offset: 0x00E6A44E
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x0603C3F8 RID: 246776 RVA: 0x00E6C258 File Offset: 0x00E6A458
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

		// Token: 0x0603C3F9 RID: 246777 RVA: 0x00E6C2A0 File Offset: 0x00E6A4A0
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

		// Token: 0x0603C3FA RID: 246778 RVA: 0x00E6C2E8 File Offset: 0x00E6A4E8
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

		// Token: 0x0603C3FB RID: 246779 RVA: 0x00E6C351 File Offset: 0x00E6A551
		public void Tick(float delta)
		{
			this.TickSkillCoolDown(delta);
		}

		// Token: 0x0603C3FC RID: 246780 RVA: 0x00E6C35A File Offset: 0x00E6A55A
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

		// Token: 0x0603C3FD RID: 246781 RVA: 0x00E6C393 File Offset: 0x00E6A593
		private void FinishSkillCoolDown()
		{
			if (base.IsShowOrShowing)
			{
				base.Hide(null);
			}
			this.CurrentCoolDownTime = 0f;
		}

		// Token: 0x0603C3FE RID: 246782 RVA: 0x00E6C3B0 File Offset: 0x00E6A5B0
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

		// Token: 0x0603C3FF RID: 246783 RVA: 0x00E6C47A File Offset: 0x00E6A67A
		private bool IsSkillInItemUseBuffCd()
		{
			SkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseBuffCd();
		}

		// Token: 0x0603C400 RID: 246784 RVA: 0x00E6C4A4 File Offset: 0x00E6A6A4
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

		// Token: 0x0603C401 RID: 246785 RVA: 0x00E6C4E2 File Offset: 0x00E6A6E2
		private bool IsSkillInItemUseSkillCd()
		{
			SkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseSkillCd();
		}

		// Token: 0x0603C402 RID: 246786 RVA: 0x00E6C50C File Offset: 0x00E6A70C
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

		// Token: 0x0603C403 RID: 246787 RVA: 0x00E6C54C File Offset: 0x00E6A74C
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

		// Token: 0x0603C404 RID: 246788 RVA: 0x00E6C5B8 File Offset: 0x00E6A7B8
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

		// Token: 0x0401F655 RID: 128597
		private const float AMOUNT_START = 0.3f;

		// Token: 0x0401F656 RID: 128598
		private const float AMOUNT_SCALE = 0.4f;

		// Token: 0x0401F657 RID: 128599
		private int Index;

		// Token: 0x0401F658 RID: 128600
		private SkillButtonData SkillButtonData;

		// Token: 0x0401F659 RID: 128601
		private UUISprite CoolDownBarUiSprite;

		// Token: 0x0401F65A RID: 128602
		private float CurrentCoolDownTime;

		// Token: 0x0401F65B RID: 128603
		private float TotalCoolDownTime;

		// Token: 0x0200BF4F RID: 48975
		[NullableContext(0)]
		private enum EBattleSkillItem
		{
			// Token: 0x04039B32 RID: 236338
			CoolDownBarSprite
		}
	}
}
