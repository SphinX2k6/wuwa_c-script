using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C4 RID: 18628
	[NullableContext(2)]
	[Nullable(0)]
	public class InTurnGridAppearAnimation : GridAppearAnimationBase
	{
		// Token: 0x06030B04 RID: 199428 RVA: 0x00B4EB11 File Offset: 0x00B4CD11
		public InTurnGridAppearAnimation(IGridPreserver gridPreserver) : base(gridPreserver)
		{
		}

		// Token: 0x06030B05 RID: 199429 RVA: 0x00B4EB25 File Offset: 0x00B4CD25
		protected override void OnStart()
		{
			if (!this.IsInGridAppearAnimation)
			{
				this.StartPlayGridAppearAnimation();
			}
		}

		// Token: 0x06030B06 RID: 199430 RVA: 0x00B4EB35 File Offset: 0x00B4CD35
		protected override void OnEnd()
		{
			this.IsInGridAppearAnimation = false;
			this.GridAppearLastTime = 0f;
			this.GridAppearCurrentTime = 0f;
			this.CurrentAppearGridIndex = 0;
		}

		// Token: 0x06030B07 RID: 199431 RVA: 0x00B4EB5B File Offset: 0x00B4CD5B
		protected override void OnInterrupt()
		{
			base.OnInterrupt();
			this.IsInGridAppearAnimation = false;
			this.GridAppearLastTime = 0f;
			this.GridAppearCurrentTime = 0f;
			this.CurrentAppearGridIndex = 0;
		}

		// Token: 0x06030B08 RID: 199432 RVA: 0x00B4EB87 File Offset: 0x00B4CD87
		protected override void OnUpdate(float deltaTimeMilliseconds)
		{
			if (this.IsInGridAppearAnimation)
			{
				this.UpdatePlayGridAppearAnimation(deltaTimeMilliseconds);
			}
		}

		// Token: 0x06030B09 RID: 199433 RVA: 0x00B4EB98 File Offset: 0x00B4CD98
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

		// Token: 0x06030B0A RID: 199434 RVA: 0x00B4EC2B File Offset: 0x00B4CE2B
		private void ResetAnim()
		{
			this.GridAppearLastTime = 0f;
			this.GridAppearCurrentTime = 0f;
			this.HasShowFirstGrid = false;
			this.CurrentAppearGridIndex = this.GridPreserver.GetDisplayGridStartIndex();
		}

		// Token: 0x06030B0B RID: 199435 RVA: 0x00B4EC5B File Offset: 0x00B4CE5B
		private void HideGrid(int index, UUIItem grid)
		{
			grid.SetUIActive(false);
		}

		// Token: 0x06030B0C RID: 199436 RVA: 0x00B4EC64 File Offset: 0x00B4CE64
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

		// Token: 0x06030B0D RID: 199437 RVA: 0x00B4ED24 File Offset: 0x00B4CF24
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

		// Token: 0x0401A2A3 RID: 107171
		private float GridAppearLastTime;

		// Token: 0x0401A2A4 RID: 107172
		private float GridAppearCurrentTime;

		// Token: 0x0401A2A5 RID: 107173
		private int CurrentAppearGridIndex;

		// Token: 0x0401A2A6 RID: 107174
		private readonly float MillisecondToSecond = 1000f;
	}
}
