using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E41 RID: 24129
	[NullableContext(1)]
	[Nullable(0)]
	public class TopBuffContainer
	{
		// Token: 0x0603D5AB RID: 251307 RVA: 0x00ECAA74 File Offset: 0x00EC8C74
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

		// Token: 0x0603D5AC RID: 251308 RVA: 0x00ECAAC7 File Offset: 0x00EC8CC7
		public virtual void SetVisible(bool visible)
		{
		}

		// Token: 0x0603D5AD RID: 251309 RVA: 0x00ECAAC9 File Offset: 0x00EC8CC9
		public virtual void Tick(float delta)
		{
		}

		// Token: 0x0603D5AE RID: 251310 RVA: 0x00ECAACB File Offset: 0x00EC8CCB
		public void Destroy()
		{
			this.ClearAllTagCountChangedCallback();
			this.OnDestroy();
		}

		// Token: 0x0603D5AF RID: 251311 RVA: 0x00ECAAD9 File Offset: 0x00EC8CD9
		protected virtual UniTask OnInitAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603D5B0 RID: 251312 RVA: 0x00ECAAE0 File Offset: 0x00EC8CE0
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0603D5B1 RID: 251313 RVA: 0x00ECAAE4 File Offset: 0x00EC8CE4
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

		// Token: 0x0603D5B2 RID: 251314 RVA: 0x00ECAB24 File Offset: 0x00EC8D24
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

		// Token: 0x0603D5B3 RID: 251315 RVA: 0x00ECAB68 File Offset: 0x00EC8D68
		private void ClearAllTagCountChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagTaskList)
			{
				tagTask.EndTask();
			}
			this.TagTaskList.Clear();
		}

		// Token: 0x0402000A RID: 131082
		[Nullable(2)]
		protected UUIItem ParentItem;

		// Token: 0x0402000B RID: 131083
		[Nullable(2)]
		protected BattleUiRoleData RoleData;

		// Token: 0x0402000C RID: 131084
		protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();
	}
}
