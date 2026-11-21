using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x02005B2F RID: 23343
	[NullableContext(1)]
	[Nullable(0)]
	public class TuningStandGridBase : UiPanelBase
	{
		// Token: 0x060396B7 RID: 235191 RVA: 0x0101D209 File Offset: 0x0101B409
		public TuningStandGridBase(TuningGridData data)
		{
			this.Data = data;
			this.GridType = new ETuningStandGridType?(data.GridType);
		}

		// Token: 0x17006D5A RID: 27994
		// (get) Token: 0x060396B8 RID: 235192 RVA: 0x0101D229 File Offset: 0x0101B429
		// (set) Token: 0x060396B9 RID: 235193 RVA: 0x0101D231 File Offset: 0x0101B431
		protected TuningGridData Data { get; set; }

		// Token: 0x060396BA RID: 235194 RVA: 0x0101D23A File Offset: 0x0101B43A
		public virtual void OnRefreshGrid()
		{
		}

		// Token: 0x060396BB RID: 235195 RVA: 0x0101D23C File Offset: 0x0101B43C
		protected virtual void OnResetGrid()
		{
		}

		// Token: 0x060396BC RID: 235196 RVA: 0x0101D23E File Offset: 0x0101B43E
		public void ResetGrid(TuningGridData data)
		{
			this.Data = data;
			this.CurSelected = false;
			this.OnResetGrid();
		}

		// Token: 0x060396BD RID: 235197 RVA: 0x0101D254 File Offset: 0x0101B454
		protected virtual void InitGrid()
		{
		}

		// Token: 0x060396BE RID: 235198 RVA: 0x0101D256 File Offset: 0x0101B456
		protected virtual void OnToggleHover()
		{
		}

		// Token: 0x060396BF RID: 235199 RVA: 0x0101D258 File Offset: 0x0101B458
		protected virtual void OnToggleUnHover()
		{
		}

		// Token: 0x060396C0 RID: 235200 RVA: 0x0101D25A File Offset: 0x0101B45A
		protected virtual void OnTogglePress()
		{
		}

		// Token: 0x060396C1 RID: 235201 RVA: 0x0101D25C File Offset: 0x0101B45C
		protected virtual void OnToggleRelease()
		{
		}

		// Token: 0x060396C2 RID: 235202 RVA: 0x0101D25E File Offset: 0x0101B45E
		protected virtual void OnToggleCancel()
		{
		}

		// Token: 0x060396C3 RID: 235203 RVA: 0x0101D260 File Offset: 0x0101B460
		public virtual void PlayInAnim(float dist)
		{
		}

		// Token: 0x060396C4 RID: 235204 RVA: 0x0101D262 File Offset: 0x0101B462
		public virtual void OnLinkMiss(bool isEnd)
		{
		}

		// Token: 0x060396C5 RID: 235205 RVA: 0x0101D264 File Offset: 0x0101B464
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

		// Token: 0x060396C6 RID: 235206 RVA: 0x0101D2C1 File Offset: 0x0101B4C1
		public virtual void StartRevolving()
		{
		}

		// Token: 0x0401E4A1 RID: 124065
		protected ETuningStandGridType? GridType;

		// Token: 0x0401E4A2 RID: 124066
		protected bool CurSelected;
	}
}
