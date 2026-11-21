using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C80 RID: 19584
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiPureModeData
	{
		// Token: 0x06030DCD RID: 200141 RVA: 0x00DA05F4 File Offset: 0x00D9E7F4
		public void Init()
		{
			this.CurOperationType = Info.Instance.OperationType;
			this.GuideId = ConfigCommonParamById.GetIntConfig("PureModeGuideId").Value;
		}

		// Token: 0x06030DCE RID: 200142 RVA: 0x00DA0629 File Offset: 0x00D9E829
		public void Clear()
		{
			this.IsOpen = false;
		}

		// Token: 0x170061C1 RID: 25025
		// (get) Token: 0x06030DCF RID: 200143 RVA: 0x00DA0632 File Offset: 0x00D9E832
		// (set) Token: 0x06030DD0 RID: 200144 RVA: 0x00DA063C File Offset: 0x00D9E83C
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

		// Token: 0x06030DD1 RID: 200145 RVA: 0x00DA0694 File Offset: 0x00D9E894
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

		// Token: 0x06030DD2 RID: 200146 RVA: 0x00DA06CC File Offset: 0x00D9E8CC
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

		// Token: 0x04019EAE RID: 106158
		private static readonly IReadOnlyList<EBattleUiChild> DesktopHideChildren = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.MiniMap,
			EBattleUiChild.BossState,
			EBattleUiChild.HeadState,
			EBattleUiChild.PartState,
			EBattleUiChild.DamageView,
			EBattleUiChild.BattleHud
		});

		// Token: 0x04019EAF RID: 106159
		private static readonly IReadOnlyList<EBattleUiChild> PadHideChildren = new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
		{
			EBattleUiChild.MiniMap,
			EBattleUiChild.BossState,
			EBattleUiChild.HeadState,
			EBattleUiChild.PartState,
			EBattleUiChild.DamageView,
			EBattleUiChild.BattleHud
		});

		// Token: 0x04019EB0 RID: 106160
		private bool IsOpenInternal;

		// Token: 0x04019EB1 RID: 106161
		private EOperationType CurOperationType;

		// Token: 0x04019EB2 RID: 106162
		public bool IsSkipConfirmBox;

		// Token: 0x04019EB3 RID: 106163
		public bool IsSkipConfirmBoxTmp;

		// Token: 0x04019EB4 RID: 106164
		public int GuideId;
	}
}
