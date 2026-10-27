using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006347 RID: 25415
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterMultiTemplateGridData : IMultiTemplateGridData<IPinballItemSyncMonsterGridViewData, PinballItemSyncMonsterGridView>, IMultiTemplateGridData
	{
		// Token: 0x17009315 RID: 37653
		// (get) Token: 0x0603FF3F RID: 261951 RVA: 0x00F79B94 File Offset: 0x00F77D94
		// (set) Token: 0x0603FF40 RID: 261952 RVA: 0x00F79B9C File Offset: 0x00F77D9C
		public IPinballItemSyncMonsterGridViewData Data { get; set; }

		// Token: 0x17009316 RID: 37654
		// (get) Token: 0x0603FF41 RID: 261953 RVA: 0x00F79BA5 File Offset: 0x00F77DA5
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603FF42 RID: 261954 RVA: 0x00F79BAD File Offset: 0x00F77DAD
		public PinballMonsterMultiTemplateGridData(IPinballItemSyncMonsterGridViewData data)
		{
			this.Data = data;
		}

		// Token: 0x0603FF43 RID: 261955 RVA: 0x00F79BBC File Offset: 0x00F77DBC
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603FF44 RID: 261956 RVA: 0x00F79BBF File Offset: 0x00F77DBF
		public PinballItemSyncMonsterGridView CreateProxy()
		{
			PinballItemSyncMonsterGridView pinballItemSyncMonsterGridView = new PinballItemSyncMonsterGridView();
			pinballItemSyncMonsterGridView.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnStateChange));
			return pinballItemSyncMonsterGridView;
		}

		// Token: 0x0603FF45 RID: 261957 RVA: 0x00F79BD8 File Offset: 0x00F77DD8
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0603FF46 RID: 261958 RVA: 0x00F79BE0 File Offset: 0x00F77DE0
		private void OnStateChange(IPinballItemToggleCallback callbackParameter)
		{
			this.Data.OnStateChangeDelegate(callbackParameter);
		}
	}
}
