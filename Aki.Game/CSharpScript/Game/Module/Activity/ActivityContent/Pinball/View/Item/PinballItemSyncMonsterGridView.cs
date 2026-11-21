using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052C6 RID: 21190
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncMonsterGridView : PinballItemView, ISyncGridProxy<IPinballItemSyncMonsterGridViewData>, ISyncGridProxy
	{
		// Token: 0x17006679 RID: 26233
		// (get) Token: 0x06034C08 RID: 216072 RVA: 0x00EC0B53 File Offset: 0x00EBED53
		// (set) Token: 0x06034C09 RID: 216073 RVA: 0x00EC0B5B File Offset: 0x00EBED5B
		public int GridIndex { get; set; }

		// Token: 0x06034C0A RID: 216074 RVA: 0x00EC0B64 File Offset: 0x00EBED64
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItemToggle().bLockStateOnSelect = true;
		}

		// Token: 0x06034C0B RID: 216075 RVA: 0x00EC0B78 File Offset: 0x00EBED78
		public void Refresh(IPinballItemSyncMonsterGridViewData data)
		{
			IPinballItemDataMonster itemData = data.ItemData;
			this.SyncGridData = data;
			this.RefreshToggleState(true);
			this.ApplyWithTask(itemData);
		}

		// Token: 0x06034C0C RID: 216076 RVA: 0x00EC0BA1 File Offset: 0x00EBEDA1
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((IPinballItemSyncMonsterGridViewData)data);
		}

		// Token: 0x06034C0D RID: 216077 RVA: 0x00EC0BAF File Offset: 0x00EBEDAF
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x06034C0E RID: 216078 RVA: 0x00EC0BB9 File Offset: 0x00EBEDB9
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x06034C0F RID: 216079 RVA: 0x00EC0BC4 File Offset: 0x00EBEDC4
		private void ApplyWithTask(IPinballItemDataMonster data)
		{
			PinballItemSyncMonsterGridView.<>c__DisplayClass10_0 CS$<>8__locals1 = new PinballItemSyncMonsterGridView.<>c__DisplayClass10_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			UiAsyncTask task = new UiAsyncTask("PinballItemSyncMonsterGridView.Apply", delegate()
			{
				PinballItemSyncMonsterGridView.<>c__DisplayClass10_0.<<ApplyWithTask>b__0>d <<ApplyWithTask>b__0>d;
				<<ApplyWithTask>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ApplyWithTask>b__0>d.<>4__this = CS$<>8__locals1;
				<<ApplyWithTask>b__0>d.<>1__state = -1;
				<<ApplyWithTask>b__0>d.<>t__builder.Start<PinballItemSyncMonsterGridView.<>c__DisplayClass10_0.<<ApplyWithTask>b__0>d>(ref <<ApplyWithTask>b__0>d);
				return <<ApplyWithTask>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06034C10 RID: 216080 RVA: 0x00EC0C0C File Offset: 0x00EBEE0C
		public void RefreshToggleState(bool bJumpToEnd)
		{
			if (this.SyncGridData == null)
			{
				return;
			}
			EToggleState state = this.SyncGridData.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle itemToggle = base.GetItemToggle();
			if (itemToggle == null)
			{
				return;
			}
			itemToggle.SetToggleState(state, false, false, bJumpToEnd);
		}

		// Token: 0x06034C11 RID: 216081 RVA: 0x00EC0C49 File Offset: 0x00EBEE49
		public void Clear()
		{
		}

		// Token: 0x0401BED4 RID: 114388
		[Nullable(2)]
		private IPinballItemSyncMonsterGridViewData SyncGridData;
	}
}
