using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C9 RID: 21193
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponMultiTemplateGridData : IMultiTemplateGridData<IPinballItemSyncWeaponGridViewData, PinballItemSyncWeaponGridView>, IMultiTemplateGridData
	{
		// Token: 0x17006688 RID: 26248
		// (get) Token: 0x06034C30 RID: 216112 RVA: 0x00EC0CD2 File Offset: 0x00EBEED2
		// (set) Token: 0x06034C31 RID: 216113 RVA: 0x00EC0CDA File Offset: 0x00EBEEDA
		public IPinballItemSyncWeaponGridViewData Data { get; set; }

		// Token: 0x17006689 RID: 26249
		// (get) Token: 0x06034C32 RID: 216114 RVA: 0x00EC0CE3 File Offset: 0x00EBEEE3
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06034C33 RID: 216115 RVA: 0x00EC0CEB File Offset: 0x00EBEEEB
		public PinballWeaponMultiTemplateGridData(IPinballItemSyncWeaponGridViewData data)
		{
			this.Data = data;
		}

		// Token: 0x06034C34 RID: 216116 RVA: 0x00EC0CFA File Offset: 0x00EBEEFA
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06034C35 RID: 216117 RVA: 0x00EC0CFD File Offset: 0x00EBEEFD
		public PinballItemSyncWeaponGridView CreateProxy()
		{
			PinballItemSyncWeaponGridView pinballItemSyncWeaponGridView = new PinballItemSyncWeaponGridView();
			pinballItemSyncWeaponGridView.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnStateChange));
			return pinballItemSyncWeaponGridView;
		}

		// Token: 0x06034C36 RID: 216118 RVA: 0x00EC0D16 File Offset: 0x00EBEF16
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x06034C37 RID: 216119 RVA: 0x00EC0D1E File Offset: 0x00EBEF1E
		private void OnStateChange(IPinballItemToggleCallback callbackParameter)
		{
			this.Data.OnStateChangeDelegate(callbackParameter);
		}
	}
}
