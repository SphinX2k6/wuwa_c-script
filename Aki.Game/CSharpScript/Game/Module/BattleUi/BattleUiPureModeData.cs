using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C9E RID: 23710
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiPureModeData
	{
		// Token: 0x0603BE7A RID: 245370 RVA: 0x00E4FF6C File Offset: 0x00E4E16C
		public void Init()
		{
			this.CurOperationType = Info.Instance.OperationType;
			this.GuideId = ConfigCommonParamById.GetIntConfig("PureModeGuideId").Value;
		}

		// Token: 0x0603BE7B RID: 245371 RVA: 0x00E4FFA1 File Offset: 0x00E4E1A1
		public void Clear()
		{
			this.IsOpen = false;
		}

		// Token: 0x17008DEF RID: 36335
		// (get) Token: 0x0603BE7C RID: 245372 RVA: 0x00E4FFAA File Offset: 0x00E4E1AA
		// (set) Token: 0x0603BE7D RID: 245373 RVA: 0x00E4FFB4 File Offset: 0x00E4E1B4
		public bool IsOpen
		{
			get
			{
				return this.IsOpenInternal;
			}
			set
			{
				if (this.IsOpenInternal == value)
				{
					return;
				}
				this.IsOpenInternal = value;
				this.Refresh(!value);
				UiManager.Instance.RefreshByPureModeChanged();
				EventSystem.Instance.Emit<bool>(EEventName.BattleUiPureModeChanged, value);
				EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.UIPureMode);
			}
		}

		// Token: 0x0603BE7E RID: 245374 RVA: 0x00E5000C File Offset: 0x00E4E20C
		public void ShowTypeChange(EOperationType last, EOperationType now)
		{
			if (now == EOperationType.None)
			{
				return;
			}
			if (this.CurOperationType == now)
			{
				return;
			}
			if (this.IsOpen)
			{
				this.Refresh(false);
				this.CurOperationType = now;
				this.Refresh(false);
				return;
			}
			this.CurOperationType = now;
		}

		// Token: 0x0603BE7F RID: 245375 RVA: 0x00E50044 File Offset: 0x00E4E244
		private void Refresh(bool bVisible)
		{
			if (this.CurOperationType == EOperationType.None)
			{
				return;
			}
			if (this.CurOperationType == EOperationType.Desktop)
			{
				BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
				if (childViewData == null)
				{
					return;
				}
				childViewData.SetChildrenVisible(EBattleUiVisibleReason.PureMode, BattleUiPureModeData.DesktopHideChildren, bVisible, true, 0);
				return;
			}
			else
			{
				BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
				if (childViewData2 == null)
				{
					return;
				}
				childViewData2.SetChildrenVisible(EBattleUiVisibleReason.PureMode, BattleUiPureModeData.PadHideChildren, bVisible, true, 0);
				return;
			}
		}

		// Token: 0x0401F3F5 RID: 127989
		private static readonly IReadOnlyList<EBattleUiChild> DesktopHideChildren = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.MiniMap,
			EBattleUiChild.BossState,
			EBattleUiChild.HeadState,
			EBattleUiChild.PartState,
			EBattleUiChild.DamageView,
			EBattleUiChild.BattleHud
		});

		// Token: 0x0401F3F6 RID: 127990
		private static readonly IReadOnlyList<EBattleUiChild> PadHideChildren = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.MiniMap,
			EBattleUiChild.BossState,
			EBattleUiChild.HeadState,
			EBattleUiChild.PartState,
			EBattleUiChild.DamageView,
			EBattleUiChild.BattleHud
		});

		// Token: 0x0401F3F7 RID: 127991
		private bool IsOpenInternal;

		// Token: 0x0401F3F8 RID: 127992
		private EOperationType CurOperationType;

		// Token: 0x0401F3F9 RID: 127993
		public bool IsSkipConfirmBox;

		// Token: 0x0401F3FA RID: 127994
		public bool IsSkipConfirmBoxTmp;

		// Token: 0x0401F3FB RID: 127995
		public int GuideId;
	}
}
