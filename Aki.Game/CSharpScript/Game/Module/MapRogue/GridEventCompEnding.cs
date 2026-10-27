using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055D9 RID: 21977
	[NullableContext(2)]
	[Nullable(0)]
	public class GridEventCompEnding : UiPanelBase, IEventStepItem
	{
		// Token: 0x17008702 RID: 34562
		// (get) Token: 0x06037FFC RID: 229372 RVA: 0x00D43A8E File Offset: 0x00D41C8E
		public int StepId { get; }

		// Token: 0x17008703 RID: 34563
		// (get) Token: 0x06037FFD RID: 229373 RVA: 0x00D43A96 File Offset: 0x00D41C96
		public EStepType StepType { get; }

		// Token: 0x17008704 RID: 34564
		// (get) Token: 0x06037FFE RID: 229374 RVA: 0x00D43A9E File Offset: 0x00D41C9E
		// (set) Token: 0x06037FFF RID: 229375 RVA: 0x00D43AA6 File Offset: 0x00D41CA6
		public Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x17008705 RID: 34565
		// (get) Token: 0x06038000 RID: 229376 RVA: 0x00D43AAF File Offset: 0x00D41CAF
		// (set) Token: 0x06038001 RID: 229377 RVA: 0x00D43AB7 File Offset: 0x00D41CB7
		public Action<int, int> ExecuteStep { get; set; }

		// Token: 0x06038002 RID: 229378 RVA: 0x00D43AC0 File Offset: 0x00D41CC0
		public GridEventCompEnding(int stepId, EStepType stepType = EStepType.Ending)
		{
			this.StepId = stepId;
			this.StepType = stepType;
		}

		// Token: 0x06038003 RID: 229379 RVA: 0x00D43AD8 File Offset: 0x00D41CD8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06038004 RID: 229380 RVA: 0x00D43B34 File Offset: 0x00D41D34
		public void Refresh()
		{
			RogueResEventStep? rogueEventStepById = MapRogueConfig.Instance.GetRogueEventStepById(this.StepId);
			if (rogueEventStepById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), rogueEventStepById.Value.TitleKey, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueEventStepById.Value.TextKey, Array.Empty<object>());
			Action<int, EStepType> canInteractCallback = this.CanInteractCallback;
			if (canInteractCallback == null)
			{
				return;
			}
			canInteractCallback(this.StepId, this.StepType);
		}

		// Token: 0x06038005 RID: 229381 RVA: 0x00D43BC2 File Offset: 0x00D41DC2
		public void MaskClick()
		{
		}
	}
}
