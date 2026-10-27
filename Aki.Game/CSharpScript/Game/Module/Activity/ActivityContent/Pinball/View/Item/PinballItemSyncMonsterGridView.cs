using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006348 RID: 25416
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemSyncMonsterGridView : PinballItemView, ISyncGridProxy<IPinballItemSyncMonsterGridViewData>, ISyncGridProxy
	{
		// Token: 0x17009317 RID: 37655
		// (get) Token: 0x0603FF47 RID: 261959 RVA: 0x00F79BF3 File Offset: 0x00F77DF3
		// (set) Token: 0x0603FF48 RID: 261960 RVA: 0x00F79BFB File Offset: 0x00F77DFB
		public int GridIndex { get; set; }

		// Token: 0x0603FF49 RID: 261961 RVA: 0x00F79C04 File Offset: 0x00F77E04
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItemToggle().bLockStateOnSelect = true;
		}

		// Token: 0x0603FF4A RID: 261962 RVA: 0x00F79C18 File Offset: 0x00F77E18
		public void Refresh(IPinballItemSyncMonsterGridViewData data)
		{
			IPinballItemDataMonster itemData = data.ItemData;
			this.SyncGridData = data;
			this.RefreshToggleState(true);
			this.ApplyWithTask(itemData);
		}

		// Token: 0x0603FF4B RID: 261963 RVA: 0x00F79C41 File Offset: 0x00F77E41
		void ISyncGridProxy.Refresh(object data)
		{
			this.Refresh((IPinballItemSyncMonsterGridViewData)data);
		}

		// Token: 0x0603FF4C RID: 261964 RVA: 0x00F79C4F File Offset: 0x00F77E4F
		void ISyncGridProxy.CreateByActor(AActor actor)
		{
			base.CreateByActor(actor, null);
		}

		// Token: 0x0603FF4D RID: 261965 RVA: 0x00F79C59 File Offset: 0x00F77E59
		void ISyncGridProxy.CreateThenShowByActor(AActor actor)
		{
			base.CreateThenShowByActor(actor, null);
		}

		// Token: 0x0603FF4E RID: 261966 RVA: 0x00F79C64 File Offset: 0x00F77E64
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

		// Token: 0x0603FF4F RID: 261967 RVA: 0x00F79CAC File Offset: 0x00F77EAC
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

		// Token: 0x0603FF50 RID: 261968 RVA: 0x00F79CE9 File Offset: 0x00F77EE9
		public void Clear()
		{
		}

		// Token: 0x040215A5 RID: 136613
		[Nullable(2)]
		private IPinballItemSyncMonsterGridViewData SyncGridData;
	}
}
