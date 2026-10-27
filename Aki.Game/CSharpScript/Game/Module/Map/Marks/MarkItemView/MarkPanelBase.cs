using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005519 RID: 21785
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkPanelBase : UiPanelBase
	{
		// Token: 0x170085AB RID: 34219
		// (get) Token: 0x06037A34 RID: 227892 RVA: 0x00D35174 File Offset: 0x00D33374
		public UniTaskCompletionSource LoadingPromise
		{
			get
			{
				return this.LoadingTaskCompletionSource;
			}
		}

		// Token: 0x06037A35 RID: 227893 RVA: 0x00D3517C File Offset: 0x00D3337C
		public MarkPanelBase()
		{
			base.SkipDestroyActor = true;
		}

		// Token: 0x06037A36 RID: 227894 RVA: 0x00D3518C File Offset: 0x00D3338C
		[NullableContext(1)]
		public UniTask CreateByPoolResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
		{
			MarkPanelBase.<CreateByPoolResourceIdAsync>d__6 <CreateByPoolResourceIdAsync>d__;
			<CreateByPoolResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByPoolResourceIdAsync>d__.<>4__this = this;
			<CreateByPoolResourceIdAsync>d__.resourceId = resourceId;
			<CreateByPoolResourceIdAsync>d__.parentItem = parentItem;
			<CreateByPoolResourceIdAsync>d__.<>1__state = -1;
			<CreateByPoolResourceIdAsync>d__.<>t__builder.Start<MarkPanelBase.<CreateByPoolResourceIdAsync>d__6>(ref <CreateByPoolResourceIdAsync>d__);
			return <CreateByPoolResourceIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A37 RID: 227895 RVA: 0x00D351E0 File Offset: 0x00D333E0
		[NullableContext(1)]
		public UniTask CreateThenShowByPoolResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
		{
			MarkPanelBase.<CreateThenShowByPoolResourceIdAsync>d__7 <CreateThenShowByPoolResourceIdAsync>d__;
			<CreateThenShowByPoolResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByPoolResourceIdAsync>d__.<>4__this = this;
			<CreateThenShowByPoolResourceIdAsync>d__.resourceId = resourceId;
			<CreateThenShowByPoolResourceIdAsync>d__.parentItem = parentItem;
			<CreateThenShowByPoolResourceIdAsync>d__.<>1__state = -1;
			<CreateThenShowByPoolResourceIdAsync>d__.<>t__builder.Start<MarkPanelBase.<CreateThenShowByPoolResourceIdAsync>d__7>(ref <CreateThenShowByPoolResourceIdAsync>d__);
			return <CreateThenShowByPoolResourceIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A38 RID: 227896 RVA: 0x00D35234 File Offset: 0x00D33434
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UiPoolActor> CreatePoolActorAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
		{
			MarkPanelBase.<CreatePoolActorAsync>d__8 <CreatePoolActorAsync>d__;
			<CreatePoolActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UiPoolActor>.Create();
			<CreatePoolActorAsync>d__.<>4__this = this;
			<CreatePoolActorAsync>d__.resourceId = resourceId;
			<CreatePoolActorAsync>d__.parentItem = parentItem;
			<CreatePoolActorAsync>d__.<>1__state = -1;
			<CreatePoolActorAsync>d__.<>t__builder.Start<MarkPanelBase.<CreatePoolActorAsync>d__8>(ref <CreatePoolActorAsync>d__);
			return <CreatePoolActorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A39 RID: 227897 RVA: 0x00D35287 File Offset: 0x00D33487
		private static bool IsParentItemValid(UUIItem parentItem)
		{
			if (parentItem != null && parentItem.IsValid())
			{
				AActor owner = parentItem.GetOwner();
				return owner != null && owner.IsValid();
			}
			return false;
		}

		// Token: 0x06037A3A RID: 227898 RVA: 0x00D352A7 File Offset: 0x00D334A7
		protected void DoRegisterEvents()
		{
			if (this.EventRegistered)
			{
				return;
			}
			this.EventRegistered = true;
			this.RegisterEvents();
		}

		// Token: 0x06037A3B RID: 227899 RVA: 0x00D352BF File Offset: 0x00D334BF
		protected void DoUnRegisterEvents()
		{
			if (!this.EventRegistered)
			{
				return;
			}
			this.EventRegistered = false;
			this.UnRegisterEvents();
		}

		// Token: 0x06037A3C RID: 227900 RVA: 0x00D352D7 File Offset: 0x00D334D7
		public virtual void RegisterEvents()
		{
		}

		// Token: 0x06037A3D RID: 227901 RVA: 0x00D352D9 File Offset: 0x00D334D9
		public virtual void UnRegisterEvents()
		{
		}

		// Token: 0x06037A3E RID: 227902 RVA: 0x00D352DB File Offset: 0x00D334DB
		public virtual void RecycleToPool()
		{
			this.DoUnRegisterEvents();
			this.RecycleToPoolAsync();
		}

		// Token: 0x06037A3F RID: 227903 RVA: 0x00D352EC File Offset: 0x00D334EC
		private UniTask RecycleToPoolAsync()
		{
			MarkPanelBase.<RecycleToPoolAsync>d__16 <RecycleToPoolAsync>d__;
			<RecycleToPoolAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RecycleToPoolAsync>d__.<>4__this = this;
			<RecycleToPoolAsync>d__.<>1__state = -1;
			<RecycleToPoolAsync>d__.<>t__builder.Start<MarkPanelBase.<RecycleToPoolAsync>d__16>(ref <RecycleToPoolAsync>d__);
			return <RecycleToPoolAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A40 RID: 227904 RVA: 0x00D3532F File Offset: 0x00D3352F
		protected override void OnAfterHide()
		{
			MarkSpritePool.UnRef(this.ComponentId);
		}

		// Token: 0x06037A41 RID: 227905 RVA: 0x00D3533C File Offset: 0x00D3353C
		[NullableContext(1)]
		protected override void SetSpriteByPath(string path, UUISprite uiSprite, bool setSize, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null)
		{
			if (string.IsNullOrEmpty(path))
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else
			{
				ULGUISpriteData_BaseObject ulguispriteData_BaseObject = MarkSpritePool.Get(this.ComponentId, path);
				if (ulguispriteData_BaseObject == null || !ulguispriteData_BaseObject.IsValid())
				{
					base.SetSpriteByPath(path, uiSprite, setSize, syncLoadViewName, delegate(bool result)
					{
						if (result)
						{
							MarkSpritePool.Ref(this.ComponentId, path, uiSprite.GetSprite());
						}
						if (callback != null)
						{
							callback(result);
						}
					});
					return;
				}
				uiSprite.SetSprite(ulguispriteData_BaseObject, setSize);
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(true);
				return;
			}
		}

		// Token: 0x06037A42 RID: 227906 RVA: 0x00D353EE File Offset: 0x00D335EE
		public void SetVisible(bool visible)
		{
			if (visible)
			{
				this.RestoreLastVisiblePosition();
				UUIItem rootItem = this.RootItem;
				if (rootItem == null || !rootItem.bIsUIActive)
				{
					base.SetUiActive(true);
					return;
				}
			}
			else
			{
				this.SaveLastVisiblePosition();
				this.RootItem.SetAnchorOffsetX(2.1474836E+09f);
			}
		}

		// Token: 0x06037A43 RID: 227907 RVA: 0x00D3542E File Offset: 0x00D3362E
		private void SaveLastVisiblePosition()
		{
			this.LastVisibleAnchorOffsetX = new float?(this.RootItem.GetAnchorOffsetX());
		}

		// Token: 0x06037A44 RID: 227908 RVA: 0x00D35446 File Offset: 0x00D33646
		private void RestoreLastVisiblePosition()
		{
			if (this.LastVisibleAnchorOffsetX != null)
			{
				this.RootItem.SetAnchorOffsetX(this.LastVisibleAnchorOffsetX.Value);
			}
		}

		// Token: 0x0401D420 RID: 119840
		private UiPoolActor MarkItemActor;

		// Token: 0x0401D421 RID: 119841
		protected UniTaskCompletionSource LoadingTaskCompletionSource;

		// Token: 0x0401D422 RID: 119842
		private float? LastVisibleAnchorOffsetX;

		// Token: 0x0401D423 RID: 119843
		private bool EventRegistered;
	}
}
