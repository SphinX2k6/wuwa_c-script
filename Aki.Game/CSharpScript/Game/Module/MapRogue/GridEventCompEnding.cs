using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045AF RID: 17839
	[NullableContext(2)]
	[Nullable(0)]
	public class GridEventCompEnding : UiPanelBase, IEventStepItem
	{
		// Token: 0x17005AC9 RID: 23241
		// (get) Token: 0x0602CEFA RID: 184058 RVA: 0x00C917D6 File Offset: 0x00C8F9D6
		public int StepId { get; }

		// Token: 0x17005ACA RID: 23242
		// (get) Token: 0x0602CEFB RID: 184059 RVA: 0x00C917DE File Offset: 0x00C8F9DE
		public EStepType StepType { get; }

		// Token: 0x17005ACB RID: 23243
		// (get) Token: 0x0602CEFC RID: 184060 RVA: 0x00C917E6 File Offset: 0x00C8F9E6
		// (set) Token: 0x0602CEFD RID: 184061 RVA: 0x00C917EE File Offset: 0x00C8F9EE
		public Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x17005ACC RID: 23244
		// (get) Token: 0x0602CEFE RID: 184062 RVA: 0x00C917F7 File Offset: 0x00C8F9F7
		// (set) Token: 0x0602CEFF RID: 184063 RVA: 0x00C917FF File Offset: 0x00C8F9FF
		public Action<int, int> ExecuteStep { get; set; }

		// Token: 0x0602CF00 RID: 184064 RVA: 0x00C91808 File Offset: 0x00C8FA08
		public GridEventCompEnding(int stepId, EStepType stepType = EStepType.Ending)
		{
			this.StepId = stepId;
			this.StepType = stepType;
		}

		// Token: 0x0602CF01 RID: 184065 RVA: 0x00C91820 File Offset: 0x00C8FA20
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602CF02 RID: 184066 RVA: 0x00C9187C File Offset: 0x00C8FA7C
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

		// Token: 0x0602CF03 RID: 184067 RVA: 0x00C9190A File Offset: 0x00C8FB0A
		public void MaskClick()
		{
		}
	}
}
