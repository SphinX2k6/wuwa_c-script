using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x0200634B RID: 25419
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponMultiTemplateGridData : IMultiTemplateGridData<IPinballItemSyncWeaponGridViewData, PinballItemSyncWeaponGridView>, IMultiTemplateGridData
	{
		// Token: 0x17009326 RID: 37670
		// (get) Token: 0x0603FF6F RID: 261999 RVA: 0x00F79D72 File Offset: 0x00F77F72
		// (set) Token: 0x0603FF70 RID: 262000 RVA: 0x00F79D7A File Offset: 0x00F77F7A
		public IPinballItemSyncWeaponGridViewData Data { get; set; }

		// Token: 0x17009327 RID: 37671
		// (get) Token: 0x0603FF71 RID: 262001 RVA: 0x00F79D83 File Offset: 0x00F77F83
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603FF72 RID: 262002 RVA: 0x00F79D8B File Offset: 0x00F77F8B
		public PinballWeaponMultiTemplateGridData(IPinballItemSyncWeaponGridViewData data)
		{
			this.Data = data;
		}

		// Token: 0x0603FF73 RID: 262003 RVA: 0x00F79D9A File Offset: 0x00F77F9A
		public int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603FF74 RID: 262004 RVA: 0x00F79D9D File Offset: 0x00F77F9D
		public PinballItemSyncWeaponGridView CreateProxy()
		{
			PinballItemSyncWeaponGridView pinballItemSyncWeaponGridView = new PinballItemSyncWeaponGridView();
			pinballItemSyncWeaponGridView.BindOnStateChangeCallback(new Action<IPinballItemToggleCallback>(this.OnStateChange));
			return pinballItemSyncWeaponGridView;
		}

		// Token: 0x0603FF75 RID: 262005 RVA: 0x00F79DB6 File Offset: 0x00F77FB6
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}

		// Token: 0x0603FF76 RID: 262006 RVA: 0x00F79DBE File Offset: 0x00F77FBE
		private void OnStateChange(IPinballItemToggleCallback callbackParameter)
		{
			this.Data.OnStateChangeDelegate(callbackParameter);
		}
	}
}
