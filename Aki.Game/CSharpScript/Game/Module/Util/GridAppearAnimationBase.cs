using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200383A RID: 14394
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class GridAppearAnimationBase
	{
		// Token: 0x0602561E RID: 153118 RVA: 0x00A895C4 File Offset: 0x00A877C4
		public GridAppearAnimationBase(IGridPreserver gridPreserver)
		{
			if (gridPreserver == null)
			{
				Log.Instance.Error(ELogModule.ScrollViewGrid, ELogAuthor.WY, "设置错误，gridPreserver为空!", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.GridPreserver = gridPreserver;
		}

		// Token: 0x0602561F RID: 153119 RVA: 0x00A8960F File Offset: 0x00A8780F
		public bool IsGridControlValid()
		{
			return !this.IsInGridAppearAnimation;
		}

		// Token: 0x06025620 RID: 153120 RVA: 0x00A8961C File Offset: 0x00A8781C
		public void PlayGridAnim(int showLength, bool isScrollViewItem = false)
		{
			if (this.AnimController != null)
			{
				this.GridPreserver.NotifyAnimationStart();
				this.AnimController.Play("", showLength, isScrollViewItem);
				return;
			}
			if (this.GridPreserver.GetGridAnimationInterval() <= 0f && this.GridPreserver.GetGridAnimationStartTime() <= 0f)
			{
				this.GridPreserver.NotifyAnimationEnd();
				return;
			}
			this.Interrupt();
			this.Start();
		}

		// Token: 0x06025621 RID: 153121 RVA: 0x00A8968C File Offset: 0x00A8788C
		public void Clear()
		{
			if (this.AnimController != null)
			{
				this.AnimController.OnFinish.Unbind();
				this.GridPreserver.NotifyAnimationEnd();
				return;
			}
			if (this.GridPreserver.GetGridAnimationInterval() <= 0f && this.GridPreserver.GetGridAnimationStartTime() <= 0f)
			{
				return;
			}
			this.Interrupt();
		}

		// Token: 0x06025622 RID: 153122 RVA: 0x00A896E8 File Offset: 0x00A878E8
		public void RegisterAnimController()
		{
			this.AnimController = this.GridPreserver.GetUiAnimController();
			if (this.AnimController != null)
			{
				this.AnimController.SetTickableWhenPaused(true);
				this.AnimController.OnFinish.Bind(new Action(this.OnAnimFinish));
			}
		}

		// Token: 0x06025623 RID: 153123 RVA: 0x00A89736 File Offset: 0x00A87936
		private void OnAnimFinish()
		{
			this.GridPreserver.NotifyAnimationEnd();
		}

		// Token: 0x06025624 RID: 153124 RVA: 0x00A89743 File Offset: 0x00A87943
		private void Interrupt()
		{
			this.GridPreserver.NotifyAnimationEnd();
			this.RemoveTimer();
			this.OnInterrupt();
		}

		// Token: 0x06025625 RID: 153125 RVA: 0x00A8975C File Offset: 0x00A8795C
		private void Start()
		{
			this.DisplayGridNum = this.GridPreserver.GetDisplayGridNum();
			this.StartTimer();
			this.OnStart();
		}

		// Token: 0x06025626 RID: 153126 RVA: 0x00A8977B File Offset: 0x00A8797B
		protected virtual void OnStart()
		{
		}

		// Token: 0x06025627 RID: 153127 RVA: 0x00A8977D File Offset: 0x00A8797D
		public void Tick(float deltaTimeMilliseconds)
		{
			this.OnUpdate(deltaTimeMilliseconds);
		}

		// Token: 0x06025628 RID: 153128 RVA: 0x00A89786 File Offset: 0x00A87986
		protected virtual void OnUpdate(float deltaTimeMilliseconds)
		{
		}

		// Token: 0x06025629 RID: 153129 RVA: 0x00A89788 File Offset: 0x00A87988
		protected void GridsForEach([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, UUIItem> gridUpdateCallback)
		{
			int num = this.GridPreserver.GetPreservedGridNum() - 1;
			for (int i = 0; i <= num; i++)
			{
				UUIItem gridByDisplayIndex = this.GridPreserver.GetGridByDisplayIndex(i);
				gridUpdateCallback(i, gridByDisplayIndex);
			}
		}

		// Token: 0x0602562A RID: 153130 RVA: 0x00A897C4 File Offset: 0x00A879C4
		protected void End()
		{
			this.RemoveTimer();
			this.OnEnd();
		}

		// Token: 0x0602562B RID: 153131 RVA: 0x00A897D2 File Offset: 0x00A879D2
		protected virtual void OnEnd()
		{
		}

		// Token: 0x0602562C RID: 153132 RVA: 0x00A897D4 File Offset: 0x00A879D4
		protected virtual void OnInterrupt()
		{
			foreach (LevelSequencePlayer levelSequencePlayer in this.ItemLevelSequenceMap.Values)
			{
				levelSequencePlayer.StopSequenceByKey("Start".ToString(), false, false);
				levelSequencePlayer.Clear();
			}
			this.ItemLevelSequenceMap.Clear();
		}

		// Token: 0x0602562D RID: 153133 RVA: 0x00A89848 File Offset: 0x00A87A48
		[NullableContext(1)]
		protected void ShowGrid(UUIItem grid, int gridIndex)
		{
			grid.SetUIActive(true);
			LevelSequencePlayer levelSequencePlayer;
			if (!this.ItemLevelSequenceMap.TryGetValue(grid, out levelSequencePlayer))
			{
				levelSequencePlayer = new LevelSequencePlayer(grid);
				this.ItemLevelSequenceMap[grid] = levelSequencePlayer;
			}
			levelSequencePlayer.StopSequenceByKey("Start".ToString(), false, false);
			levelSequencePlayer.PlayLevelSequenceByName("Start".ToString(), false, null, false);
			EventSystem.Instance.Emit<int, UUIItem>(EEventName.OnShowGridAnimation, gridIndex, grid);
		}

		// Token: 0x0602562E RID: 153134 RVA: 0x00A898BF File Offset: 0x00A87ABF
		private void StartTimer()
		{
			if (this.TickId != -1)
			{
				return;
			}
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.Tick), "GridAppearAnimation", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x0602562F RID: 153135 RVA: 0x00A898F5 File Offset: 0x00A87AF5
		protected void RemoveTimer()
		{
			if (this.TickId == -1)
			{
				return;
			}
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}

		// Token: 0x04014B0F RID: 84751
		protected readonly IGridPreserver GridPreserver;

		// Token: 0x04014B10 RID: 84752
		private UUIInturnAnimController AnimController;

		// Token: 0x04014B11 RID: 84753
		protected int DisplayGridNum;

		// Token: 0x04014B12 RID: 84754
		private int TickId = -1;

		// Token: 0x04014B13 RID: 84755
		protected bool IsInGridAppearAnimation;

		// Token: 0x04014B14 RID: 84756
		protected bool HasShowFirstGrid;

		// Token: 0x04014B15 RID: 84757
		[Nullable(1)]
		private readonly Dictionary<UUIItem, LevelSequencePlayer> ItemLevelSequenceMap = new Dictionary<UUIItem, LevelSequencePlayer>();
	}
}
