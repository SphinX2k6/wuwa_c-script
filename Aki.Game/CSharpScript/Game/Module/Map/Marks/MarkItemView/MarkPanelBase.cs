using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044EC RID: 17644
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkPanelBase : UiPanelBase
	{
		// Token: 0x17005946 RID: 22854
		// (get) Token: 0x0602C900 RID: 182528 RVA: 0x00C82F60 File Offset: 0x00C81160
		public UniTaskCompletionSource LoadingPromise
		{
			get
			{
				return this.LoadingTaskCompletionSource;
			}
		}

		// Token: 0x0602C901 RID: 182529 RVA: 0x00C82F68 File Offset: 0x00C81168
		[NullableContext(1)]
		public UniTask CreateByPoolResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
		{
			MarkPanelBase.<CreateByPoolResourceIdAsync>d__4 <CreateByPoolResourceIdAsync>d__;
			<CreateByPoolResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateByPoolResourceIdAsync>d__.<>4__this = this;
			<CreateByPoolResourceIdAsync>d__.resourceId = resourceId;
			<CreateByPoolResourceIdAsync>d__.parentItem = parentItem;
			<CreateByPoolResourceIdAsync>d__.<>1__state = -1;
			<CreateByPoolResourceIdAsync>d__.<>t__builder.Start<MarkPanelBase.<CreateByPoolResourceIdAsync>d__4>(ref <CreateByPoolResourceIdAsync>d__);
			return <CreateByPoolResourceIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C902 RID: 182530 RVA: 0x00C82FBC File Offset: 0x00C811BC
		[NullableContext(1)]
		public UniTask CreateThenShowByPoolResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
		{
			MarkPanelBase.<CreateThenShowByPoolResourceIdAsync>d__5 <CreateThenShowByPoolResourceIdAsync>d__;
			<CreateThenShowByPoolResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateThenShowByPoolResourceIdAsync>d__.<>4__this = this;
			<CreateThenShowByPoolResourceIdAsync>d__.resourceId = resourceId;
			<CreateThenShowByPoolResourceIdAsync>d__.parentItem = parentItem;
			<CreateThenShowByPoolResourceIdAsync>d__.<>1__state = -1;
			<CreateThenShowByPoolResourceIdAsync>d__.<>t__builder.Start<MarkPanelBase.<CreateThenShowByPoolResourceIdAsync>d__5>(ref <CreateThenShowByPoolResourceIdAsync>d__);
			return <CreateThenShowByPoolResourceIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C903 RID: 182531 RVA: 0x00C8300F File Offset: 0x00C8120F
		private bool IsCreateFailedAfterLoad(UUIItem parentItem)
		{
			return base.IsDestroyOrDestroying || this.WaitToDestroy || this.RootItem == null || !MarkPanelBase.IsParentItemValid(parentItem);
		}

		// Token: 0x0602C904 RID: 182532 RVA: 0x00C83034 File Offset: 0x00C81234
		private static bool IsParentItemValid(UUIItem parentItem)
		{
			if (parentItem != null && parentItem.IsValid())
			{
				AActor owner = parentItem.GetOwner();
				return owner != null && owner.IsValid();
			}
			return false;
		}

		// Token: 0x17005947 RID: 22855
		// (get) Token: 0x0602C905 RID: 182533 RVA: 0x00C83054 File Offset: 0x00C81254
		// (set) Token: 0x0602C906 RID: 182534 RVA: 0x00C8305C File Offset: 0x00C8125C
		public bool EventRegistered { get; private set; }

		// Token: 0x0602C907 RID: 182535 RVA: 0x00C83065 File Offset: 0x00C81265
		protected void DoRegisterEvents()
		{
			if (this.EventRegistered)
			{
				return;
			}
			this.EventRegistered = true;
			this.RegisterEvents();
		}

		// Token: 0x0602C908 RID: 182536 RVA: 0x00C8307D File Offset: 0x00C8127D
		protected void DoUnRegisterEvents()
		{
			if (!this.EventRegistered)
			{
				return;
			}
			this.EventRegistered = false;
			this.UnRegisterEvents();
		}

		// Token: 0x0602C909 RID: 182537 RVA: 0x00C83095 File Offset: 0x00C81295
		public virtual void RegisterEvents()
		{
		}

		// Token: 0x0602C90A RID: 182538 RVA: 0x00C83097 File Offset: 0x00C81297
		public virtual void UnRegisterEvents()
		{
		}

		// Token: 0x0602C90B RID: 182539 RVA: 0x00C83099 File Offset: 0x00C81299
		public virtual void RecycleToPool()
		{
			this.DoUnRegisterEvents();
			this.RecycleToPoolAsync();
		}

		// Token: 0x0602C90C RID: 182540 RVA: 0x00C830A8 File Offset: 0x00C812A8
		private UniTask RecycleToPoolAsync()
		{
			MarkPanelBase.<RecycleToPoolAsync>d__17 <RecycleToPoolAsync>d__;
			<RecycleToPoolAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RecycleToPoolAsync>d__.<>4__this = this;
			<RecycleToPoolAsync>d__.<>1__state = -1;
			<RecycleToPoolAsync>d__.<>t__builder.Start<MarkPanelBase.<RecycleToPoolAsync>d__17>(ref <RecycleToPoolAsync>d__);
			return <RecycleToPoolAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C90D RID: 182541 RVA: 0x00C830EB File Offset: 0x00C812EB
		protected override void OnAfterHide()
		{
			MarkSpritePool.UnRef(this.ComponentId);
		}

		// Token: 0x0602C90E RID: 182542 RVA: 0x00C830F8 File Offset: 0x00C812F8
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
				base.CancelSpriteLoad(uiSprite);
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

		// Token: 0x0602C90F RID: 182543 RVA: 0x00C831B7 File Offset: 0x00C813B7
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

		// Token: 0x0602C910 RID: 182544 RVA: 0x00C831F7 File Offset: 0x00C813F7
		private void SaveLastVisiblePosition()
		{
			this.LastVisibleAnchorOffsetX = new float?(this.RootItem.GetAnchorOffsetX());
		}

		// Token: 0x0602C911 RID: 182545 RVA: 0x00C8320F File Offset: 0x00C8140F
		private void RestoreLastVisiblePosition()
		{
			if (this.LastVisibleAnchorOffsetX != null)
			{
				this.RootItem.SetAnchorOffsetX(this.LastVisibleAnchorOffsetX.Value);
			}
		}

		// Token: 0x04017EA4 RID: 97956
		protected UniTaskCompletionSource LoadingTaskCompletionSource;

		// Token: 0x04017EA5 RID: 97957
		private float? LastVisibleAnchorOffsetX;
	}
}
