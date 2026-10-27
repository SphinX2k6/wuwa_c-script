using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x020069D3 RID: 27091
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandGridBase : UiPanelBase
	{
		// Token: 0x0604367B RID: 276091 RVA: 0x01078D55 File Offset: 0x01076F55
		public TuningStandGridBase(TuningGridData data)
		{
			this.Data = data;
			this.GridType = new ETuningStandGridType?(data.GridType);
		}

		// Token: 0x1700987A RID: 39034
		// (get) Token: 0x0604367C RID: 276092 RVA: 0x01078D75 File Offset: 0x01076F75
		// (set) Token: 0x0604367D RID: 276093 RVA: 0x01078D7D File Offset: 0x01076F7D
		protected TuningGridData Data { get; set; }

		// Token: 0x0604367E RID: 276094 RVA: 0x01078D86 File Offset: 0x01076F86
		public virtual void OnRefreshGrid()
		{
		}

		// Token: 0x0604367F RID: 276095 RVA: 0x01078D88 File Offset: 0x01076F88
		protected virtual void OnResetGrid()
		{
		}

		// Token: 0x06043680 RID: 276096 RVA: 0x01078D8A File Offset: 0x01076F8A
		public void ResetGrid(TuningGridData data)
		{
			this.Data = data;
			this.CurSelected = false;
			this.OnResetGrid();
		}

		// Token: 0x06043681 RID: 276097 RVA: 0x01078DA0 File Offset: 0x01076FA0
		protected virtual void InitGrid()
		{
		}

		// Token: 0x06043682 RID: 276098 RVA: 0x01078DA2 File Offset: 0x01076FA2
		protected virtual void OnToggleHover()
		{
		}

		// Token: 0x06043683 RID: 276099 RVA: 0x01078DA4 File Offset: 0x01076FA4
		protected virtual void OnToggleUnHover()
		{
		}

		// Token: 0x06043684 RID: 276100 RVA: 0x01078DA6 File Offset: 0x01076FA6
		protected virtual void OnTogglePress()
		{
		}

		// Token: 0x06043685 RID: 276101 RVA: 0x01078DA8 File Offset: 0x01076FA8
		protected virtual void OnToggleRelease()
		{
		}

		// Token: 0x06043686 RID: 276102 RVA: 0x01078DAA File Offset: 0x01076FAA
		protected virtual void OnToggleCancel()
		{
		}

		// Token: 0x06043687 RID: 276103 RVA: 0x01078DAC File Offset: 0x01076FAC
		public virtual void PlayInAnim(float dist)
		{
		}

		// Token: 0x06043688 RID: 276104 RVA: 0x01078DAE File Offset: 0x01076FAE
		public virtual void OnLinkMiss(bool isEnd)
		{
		}

		// Token: 0x06043689 RID: 276105 RVA: 0x01078DB0 File Offset: 0x01076FB0
		protected ETuningStandPrevDirect GetPrevDirection()
		{
			ITuningStateData curGridState = this.Data.GetCurGridState();
			int index = this.Data.Index;
			if (curGridState.Prev == null)
			{
				return ETuningStandPrevDirect.None;
			}
			int value = curGridState.Prev.Value;
			if (value == index - 1)
			{
				return ETuningStandPrevDirect.Left;
			}
			if (value == index + 1)
			{
				return ETuningStandPrevDirect.Right;
			}
			if (value <= index)
			{
				return ETuningStandPrevDirect.Top;
			}
			return ETuningStandPrevDirect.Bottom;
		}

		// Token: 0x0604368A RID: 276106 RVA: 0x01078E0D File Offset: 0x0107700D
		public virtual void StartRevolving()
		{
		}

		// Token: 0x040232B1 RID: 144049
		protected ETuningStandGridType? GridType;

		// Token: 0x040232B2 RID: 144050
		protected bool CurSelected;
	}
}
