using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E26 RID: 20006
	[NullableContext(1)]
	[Nullable(0)]
	public class TopBuffContainer
	{
		// Token: 0x0603253B RID: 206139 RVA: 0x00E1BFE0 File Offset: 0x00E1A1E0
		public UniTask InitAsync(UUIItem parentItem, BattleUiRoleData roleData)
		{
			TopBuffContainer.<InitAsync>d__3 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.parentItem = parentItem;
			<InitAsync>d__.roleData = roleData;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<TopBuffContainer.<InitAsync>d__3>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603253C RID: 206140 RVA: 0x00E1C033 File Offset: 0x00E1A233
		public virtual void SetVisible(bool visible)
		{
		}

		// Token: 0x0603253D RID: 206141 RVA: 0x00E1C035 File Offset: 0x00E1A235
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x0603253E RID: 206142 RVA: 0x00E1C037 File Offset: 0x00E1A237
		public void Destroy()
		{
			this.ClearAllTagCountChangedCallback();
			this.OnDestroy();
		}

		// Token: 0x0603253F RID: 206143 RVA: 0x00E1C045 File Offset: 0x00E1A245
		protected virtual UniTask OnInitAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06032540 RID: 206144 RVA: 0x00E1C04C File Offset: 0x00E1A24C
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06032541 RID: 206145 RVA: 0x00E1C050 File Offset: 0x00E1A250
		protected void ListenForTagCountChanged(int tagId, BaseTagComponent.TTagChangedCallback onTagCountChange)
		{
			BattleUiRoleData roleData = this.RoleData;
			ITagTask tagTask;
			if (roleData == null)
			{
				tagTask = null;
			}
			else
			{
				BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
				tagTask = ((gameplayTagComponent != null) ? gameplayTagComponent.ListenForTagAnyCountChanged(tagId, onTagCountChange) : null);
			}
			ITagTask tagTask2 = tagTask;
			if (tagTask2 != null)
			{
				this.TagTaskList.Add(tagTask2);
			}
		}

		// Token: 0x06032542 RID: 206146 RVA: 0x00E1C090 File Offset: 0x00E1A290
		protected void ListenForTagAddOrRemoveChanged(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
		{
			BattleUiRoleData roleData = this.RoleData;
			ITagTask tagTask;
			if (roleData == null)
			{
				tagTask = null;
			}
			else
			{
				BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
				tagTask = ((gameplayTagComponent != null) ? gameplayTagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null) : null);
			}
			ITagTask tagTask2 = tagTask;
			if (tagTask2 != null)
			{
				this.TagTaskList.Add(tagTask2);
			}
		}

		// Token: 0x06032543 RID: 206147 RVA: 0x00E1C0D4 File Offset: 0x00E1A2D4
		private void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x0401AAD1 RID: 109265
		[Nullable(2)]
		protected UUIItem ParentItem;

		// Token: 0x0401AAD2 RID: 109266
		[Nullable(2)]
		protected BattleUiRoleData RoleData;

		// Token: 0x0401AAD3 RID: 109267
		protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();
	}
}
