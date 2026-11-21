using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200383B RID: 14395
	[NullableContext(2)]
	[Nullable(0)]
	public class InTurnGridAppearAnimation : GridAppearAnimationBase
	{
		// Token: 0x06025630 RID: 153136 RVA: 0x00A89919 File Offset: 0x00A87B19
		public InTurnGridAppearAnimation(IGridPreserver gridPreserver) : base(gridPreserver)
		{
		}

		// Token: 0x06025631 RID: 153137 RVA: 0x00A8992D File Offset: 0x00A87B2D
		protected override void OnStart()
		{
			if (!this.IsInGridAppearAnimation)
			{
				this.StartPlayGridAppearAnimation();
			}
		}

		// Token: 0x06025632 RID: 153138 RVA: 0x00A8993D File Offset: 0x00A87B3D
		protected override void OnEnd()
		{
			this.IsInGridAppearAnimation = false;
			this.GridAppearLastTime = 0f;
			this.GridAppearCurrentTime = 0f;
			this.CurrentAppearGridIndex = 0;
		}

		// Token: 0x06025633 RID: 153139 RVA: 0x00A89963 File Offset: 0x00A87B63
		protected override void OnInterrupt()
		{
			base.OnInterrupt();
			this.IsInGridAppearAnimation = false;
			this.GridAppearLastTime = 0f;
			this.GridAppearCurrentTime = 0f;
			this.CurrentAppearGridIndex = 0;
		}

		// Token: 0x06025634 RID: 153140 RVA: 0x00A8998F File Offset: 0x00A87B8F
		protected override void OnUpdate(float deltaTimeMilliseconds)
		{
			if (this.IsInGridAppearAnimation)
			{
				this.UpdatePlayGridAppearAnimation(deltaTimeMilliseconds);
			}
		}

		// Token: 0x06025635 RID: 153141 RVA: 0x00A899A0 File Offset: 0x00A87BA0
		private void StartPlayGridAppearAnimation()
		{
			if ((this.GridPreserver.GetGridAnimationInterval() <= 0f && this.GridPreserver.GetGridAnimationStartTime() <= 0f) || this.DisplayGridNum <= 0)
			{
				base.RemoveTimer();
				return;
			}
			this.GridPreserver.NotifyAnimationStart();
			this.IsInGridAppearAnimation = true;
			this.GridAppearLastTime = 0f;
			this.GridAppearCurrentTime = 0f;
			this.HasShowFirstGrid = false;
			this.CurrentAppearGridIndex = this.GridPreserver.GetDisplayGridStartIndex();
			base.GridsForEach(new Action<int, UUIItem>(this.HideGrid));
		}

		// Token: 0x06025636 RID: 153142 RVA: 0x00A89A33 File Offset: 0x00A87C33
		private void ResetAnim()
		{
			this.GridAppearLastTime = 0f;
			this.GridAppearCurrentTime = 0f;
			this.HasShowFirstGrid = false;
			this.CurrentAppearGridIndex = this.GridPreserver.GetDisplayGridStartIndex();
		}

		// Token: 0x06025637 RID: 153143 RVA: 0x00A89A63 File Offset: 0x00A87C63
		private void HideGrid(int index, UUIItem grid)
		{
			grid.SetUIActive(false);
		}

		// Token: 0x06025638 RID: 153144 RVA: 0x00A89A6C File Offset: 0x00A87C6C
		private void UpdatePlayGridAppearAnimation(float deltaTimeMilliseconds)
		{
			USequencerManager sequencerManager = ALGUIManagerActor.GetSequencerManager(GlobalData.World);
			float? num = (sequencerManager != null) ? new float?(sequencerManager.GetGlobalPlayRate()) : null;
			if (num != null && num.Value != 0f)
			{
				deltaTimeMilliseconds *= num.Value;
			}
			this.GridAppearCurrentTime += deltaTimeMilliseconds / this.MillisecondToSecond;
			if (!this.HasShowFirstGrid && this.GridAppearCurrentTime < this.GridPreserver.GetGridAnimationStartTime())
			{
				return;
			}
			if (this.HasShowFirstGrid && this.GridAppearCurrentTime - this.GridAppearLastTime < this.GridPreserver.GetGridAnimationInterval())
			{
				return;
			}
			this.HasShowFirstGrid = true;
			this.GridAppearLastTime = this.GridAppearCurrentTime;
			this.ShowGridByDisplayIndexAndMoveNext();
		}

		// Token: 0x06025639 RID: 153145 RVA: 0x00A89B2C File Offset: 0x00A87D2C
		private void ShowGridByDisplayIndexAndMoveNext()
		{
			if (this.CurrentAppearGridIndex < this.GridPreserver.GetDisplayGridStartIndex() || this.CurrentAppearGridIndex > this.GridPreserver.GetDisplayGridEndIndex())
			{
				this.ResetAnim();
				return;
			}
			UUIItem grid = this.GridPreserver.GetGrid(this.CurrentAppearGridIndex);
			if (grid == null || !grid.IsValid())
			{
				base.End();
				return;
			}
			base.ShowGrid(grid, this.CurrentAppearGridIndex);
			this.CurrentAppearGridIndex++;
			if (this.CurrentAppearGridIndex > this.GridPreserver.GetDisplayGridEndIndex())
			{
				base.End();
				this.GridPreserver.NotifyAnimationEnd();
			}
		}

		// Token: 0x04014B16 RID: 84758
		private float GridAppearLastTime;

		// Token: 0x04014B17 RID: 84759
		private float GridAppearCurrentTime;

		// Token: 0x04014B18 RID: 84760
		private int CurrentAppearGridIndex;

		// Token: 0x04014B19 RID: 84761
		private readonly float MillisecondToSecond = 1000f;
	}
}
