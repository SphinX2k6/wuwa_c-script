using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C3 RID: 18627
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class GridAppearAnimationBase
	{
		// Token: 0x06030AF2 RID: 199410 RVA: 0x00B4E7BC File Offset: 0x00B4C9BC
		public GridAppearAnimationBase(IGridPreserver gridPreserver)
		{
			if (gridPreserver == null)
			{
				Log.Instance.Error(ELogModule.ScrollViewGrid, ELogAuthor.WY, "设置错误，gridPreserver为空!", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.GridPreserver = gridPreserver;
		}

		// Token: 0x06030AF3 RID: 199411 RVA: 0x00B4E807 File Offset: 0x00B4CA07
		public bool IsGridControlValid()
		{
			return !this.IsInGridAppearAnimation;
		}

		// Token: 0x06030AF4 RID: 199412 RVA: 0x00B4E814 File Offset: 0x00B4CA14
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

		// Token: 0x06030AF5 RID: 199413 RVA: 0x00B4E884 File Offset: 0x00B4CA84
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

		// Token: 0x06030AF6 RID: 199414 RVA: 0x00B4E8E0 File Offset: 0x00B4CAE0
		public void RegisterAnimController()
		{
			this.AnimController = this.GridPreserver.GetUiAnimController();
			if (this.AnimController != null)
			{
				this.AnimController.SetTickableWhenPaused(true);
				this.AnimController.OnFinish.Bind(new Action(this.OnAnimFinish));
			}
		}

		// Token: 0x06030AF7 RID: 199415 RVA: 0x00B4E92E File Offset: 0x00B4CB2E
		private void OnAnimFinish()
		{
			this.GridPreserver.NotifyAnimationEnd();
		}

		// Token: 0x06030AF8 RID: 199416 RVA: 0x00B4E93B File Offset: 0x00B4CB3B
		private void Interrupt()
		{
			this.GridPreserver.NotifyAnimationEnd();
			this.RemoveTimer();
			this.OnInterrupt();
		}

		// Token: 0x06030AF9 RID: 199417 RVA: 0x00B4E954 File Offset: 0x00B4CB54
		private void Start()
		{
			this.DisplayGridNum = this.GridPreserver.GetDisplayGridNum();
			this.StartTimer();
			this.OnStart();
		}

		// Token: 0x06030AFA RID: 199418 RVA: 0x00B4E973 File Offset: 0x00B4CB73
		protected virtual void OnStart()
		{
		}

		// Token: 0x06030AFB RID: 199419 RVA: 0x00B4E975 File Offset: 0x00B4CB75
		public void Tick(float deltaTimeMilliseconds)
		{
			this.OnUpdate(deltaTimeMilliseconds);
		}

		// Token: 0x06030AFC RID: 199420 RVA: 0x00B4E97E File Offset: 0x00B4CB7E
		protected virtual void OnUpdate(float deltaTimeMilliseconds)
		{
		}

		// Token: 0x06030AFD RID: 199421 RVA: 0x00B4E980 File Offset: 0x00B4CB80
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

		// Token: 0x06030AFE RID: 199422 RVA: 0x00B4E9BC File Offset: 0x00B4CBBC
		protected void End()
		{
			this.RemoveTimer();
			this.OnEnd();
		}

		// Token: 0x06030AFF RID: 199423 RVA: 0x00B4E9CA File Offset: 0x00B4CBCA
		protected virtual void OnEnd()
		{
		}

		// Token: 0x06030B00 RID: 199424 RVA: 0x00B4E9CC File Offset: 0x00B4CBCC
		protected virtual void OnInterrupt()
		{
			foreach (LevelSequencePlayer levelSequencePlayer in this.ItemLevelSequenceMap.Values)
			{
				levelSequencePlayer.StopSequenceByKey("Start".ToString(), false, false);
				levelSequencePlayer.Clear();
			}
			this.ItemLevelSequenceMap.Clear();
		}

		// Token: 0x06030B01 RID: 199425 RVA: 0x00B4EA40 File Offset: 0x00B4CC40
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

		// Token: 0x06030B02 RID: 199426 RVA: 0x00B4EAB7 File Offset: 0x00B4CCB7
		private void StartTimer()
		{
			if (this.TickId != -1)
			{
				return;
			}
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.Tick), "GridAppearAnimation", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06030B03 RID: 199427 RVA: 0x00B4EAED File Offset: 0x00B4CCED
		protected void RemoveTimer()
		{
			if (this.TickId == -1)
			{
				return;
			}
			TickSystem.Instance.Remove(this.TickId);
			this.TickId = -1;
		}

		// Token: 0x0401A29C RID: 107164
		protected readonly IGridPreserver GridPreserver;

		// Token: 0x0401A29D RID: 107165
		private UUIInturnAnimController AnimController;

		// Token: 0x0401A29E RID: 107166
		protected int DisplayGridNum;

		// Token: 0x0401A29F RID: 107167
		private int TickId = -1;

		// Token: 0x0401A2A0 RID: 107168
		protected bool IsInGridAppearAnimation;

		// Token: 0x0401A2A1 RID: 107169
		protected bool HasShowFirstGrid;

		// Token: 0x0401A2A2 RID: 107170
		[Nullable(1)]
		private readonly Dictionary<UUIItem, LevelSequencePlayer> ItemLevelSequenceMap = new Dictionary<UUIItem, LevelSequencePlayer>();
	}
}
