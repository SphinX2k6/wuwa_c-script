using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C5 RID: 21189
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterMultiTemplateGridData : IMultiTemplateGridData<IPinballItemSyncMonsterGridViewData, PinballItemSyncMonsterGridView>, IMultiTemplateGridData
	{
		// Token: 0x17006677 RID: 26231
		// (get) Token: 0x06034C00 RID: 216064 RVA: 0x00EC0AF4 File Offset: 0x00EBECF4
		// (set) Token: 0x06034C01 RID: 216065 RVA: 0x00EC0AFC File Offset: 0x00EBECFC
		public IPinballItemSyncMonsterGridViewData Data { get; set; }

		// Token: 0x17006678 RID: 26232
		// (get) Token: 0x06034C02 RID: 216066 RVA: 0x00EC0B05 File Offset: 0x00EBED05
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06034C03 RID: 216067 RVA: 0x00EC0B0D File Offset: 0x00EBED0D
		public PinballMonsterMultiTemplateGridData(IPinballItemSyncMonsterGridViewData data)
		{
			this.Data = data;
		}

		// Token: 0x06034C04 RID: 216068 RVA: 0x00EC0B1C File Offset: 0x00EBED1C
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06034C05 RID: 216069 RVA: 0x00EC0B1F File Offset: 0x00EBED1F
		public PinballItemSyncMonsterGridView CreateProxy()
		{
			PinballItemSyncMonsterGridView pinballItemSyncMonsterGridView = new PinballItemSyncMonsterGridView();
			pinballItemSyncMonsterGridView.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnStateChange));
			return pinballItemSyncMonsterGridView;
		}

		// Token: 0x06034C06 RID: 216070 RVA: 0x00EC0B38 File Offset: 0x00EBED38
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x06034C07 RID: 216071 RVA: 0x00EC0B40 File Offset: 0x00EBED40
		private void OnStateChange(IPinballItemToggleCallback callbackParameter)
		{
			this.Data.OnStateChangeDelegate(callbackParameter);
		}
	}
}
