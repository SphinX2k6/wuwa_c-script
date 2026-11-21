using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004505 RID: 17669
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MarkItemComponentHandle<[Nullable(0)] T> : IMarkItemHandle where T : MarkPanelBase, new()
	{
		// Token: 0x0602C9AA RID: 182698 RVA: 0x00C84934 File Offset: 0x00C82B34
		protected MarkItemComponentHandle(IMarkItemComponentContext context)
		{
		}

		// Token: 0x17005956 RID: 22870
		// (get) Token: 0x0602C9AB RID: 182699 RVA: 0x00C84943 File Offset: 0x00C82B43
		// (set) Token: 0x0602C9AC RID: 182700 RVA: 0x00C8494B File Offset: 0x00C82B4B
		private protected bool Visible { protected get; private set; }

		// Token: 0x17005957 RID: 22871
		// (get) Token: 0x0602C9AD RID: 182701 RVA: 0x00C84954 File Offset: 0x00C82B54
		// (set) Token: 0x0602C9AE RID: 182702 RVA: 0x00C8495C File Offset: 0x00C82B5C
		private protected bool VisibleDirty { protected get; private set; }

		// Token: 0x17005958 RID: 22872
		// (get) Token: 0x0602C9AF RID: 182703 RVA: 0x00C84965 File Offset: 0x00C82B65
		public bool IsVisible
		{
			get
			{
				return this.Visible;
			}
		}

		// Token: 0x17005959 RID: 22873
		// (get) Token: 0x0602C9B0 RID: 182704 RVA: 0x00C8496D File Offset: 0x00C82B6D
		public bool IsVisibleDirty
		{
			get
			{
				return this.VisibleDirty;
			}
		}

		// Token: 0x0602C9B1 RID: 182705 RVA: 0x00C84975 File Offset: 0x00C82B75
		protected void CleanVisibleDirty()
		{
			this.VisibleDirty = false;
		}

		// Token: 0x0602C9B2 RID: 182706 RVA: 0x00C8497E File Offset: 0x00C82B7E
		protected void MarkVisibleDirty()
		{
			this.VisibleDirty = true;
		}

		// Token: 0x0602C9B3 RID: 182707 RVA: 0x00C84987 File Offset: 0x00C82B87
		public virtual void ResetVisibleState()
		{
			this.Visible = false;
			this.VisibleDirty = (this.ComponentInternal != null);
		}

		// Token: 0x0602C9B4 RID: 182708 RVA: 0x00C849A4 File Offset: 0x00C82BA4
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x0602C9B5 RID: 182709 RVA: 0x00C849AC File Offset: 0x00C82BAC
		private bool CanExecuteComponentLogic()
		{
			return this.Context.CanExecuteComponentLogic();
		}

		// Token: 0x0602C9B6 RID: 182710 RVA: 0x00C849B9 File Offset: 0x00C82BB9
		public void Update()
		{
			if (this.CanExecuteComponentLogic())
			{
				this.OnUpdate();
			}
		}

		// Token: 0x0602C9B7 RID: 182711 RVA: 0x00C849C9 File Offset: 0x00C82BC9
		public void UpdateNoCheck()
		{
			this.OnUpdate();
		}

		// Token: 0x0602C9B8 RID: 182712 RVA: 0x00C849D1 File Offset: 0x00C82BD1
		public void SetVisible(bool active)
		{
			if (this.CanExecuteComponentLogic())
			{
				if (this.Visible != active)
				{
					this.Visible = active;
					this.VisibleDirty = true;
				}
				this.OnSetVisible(active);
			}
		}

		// Token: 0x0602C9B9 RID: 182713 RVA: 0x00C849F9 File Offset: 0x00C82BF9
		public void ApplyModified()
		{
			if (this.CanExecuteComponentLogic())
			{
				this.OnApplyModified();
			}
		}

		// Token: 0x0602C9BA RID: 182714 RVA: 0x00C84A09 File Offset: 0x00C82C09
		public void ApplyModifiedNoCheck()
		{
			this.OnApplyModified();
		}

		// Token: 0x0602C9BB RID: 182715 RVA: 0x00C84A11 File Offset: 0x00C82C11
		public void Dispose()
		{
			this.OnDispose();
		}

		// Token: 0x0602C9BC RID: 182716 RVA: 0x00C84A19 File Offset: 0x00C82C19
		protected virtual void OnInit()
		{
		}

		// Token: 0x0602C9BD RID: 182717 RVA: 0x00C84A1B File Offset: 0x00C82C1B
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x0602C9BE RID: 182718 RVA: 0x00C84A1D File Offset: 0x00C82C1D
		protected virtual void OnDispose()
		{
			this.DestroyComponent();
		}

		// Token: 0x0602C9BF RID: 182719 RVA: 0x00C84A25 File Offset: 0x00C82C25
		protected virtual void OnSetVisible(bool active)
		{
		}

		// Token: 0x0602C9C0 RID: 182720 RVA: 0x00C84A27 File Offset: 0x00C82C27
		protected virtual void OnApplyModified()
		{
		}

		// Token: 0x0602C9C1 RID: 182721 RVA: 0x00C84A2C File Offset: 0x00C82C2C
		protected virtual UniTask PreloadComponentAsync()
		{
			MarkItemComponentHandle<T>.<PreloadComponentAsync>d__31 <PreloadComponentAsync>d__;
			<PreloadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadComponentAsync>d__.<>4__this = this;
			<PreloadComponentAsync>d__.<>1__state = -1;
			<PreloadComponentAsync>d__.<>t__builder.Start<MarkItemComponentHandle<T>.<PreloadComponentAsync>d__31>(ref <PreloadComponentAsync>d__);
			return <PreloadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9C2 RID: 182722 RVA: 0x00C84A70 File Offset: 0x00C82C70
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected virtual UniTask<T> LoadComponentAsync()
		{
			MarkItemComponentHandle<T>.<LoadComponentAsync>d__32 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemComponentHandle<T>.<LoadComponentAsync>d__32>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C9C3 RID: 182723 RVA: 0x00C84AB3 File Offset: 0x00C82CB3
		protected virtual T GetOrCreateComponent()
		{
			return this.ComponentInternal;
		}

		// Token: 0x0602C9C4 RID: 182724 RVA: 0x00C84ABB File Offset: 0x00C82CBB
		protected virtual void DestroyComponent()
		{
			if (this.ComponentInternal != null)
			{
				this.ComponentInternal.RecycleToPool();
				this.ComponentInternal = default(T);
			}
		}

		// Token: 0x0602C9C5 RID: 182725 RVA: 0x00C84AE6 File Offset: 0x00C82CE6
		[NullableContext(2)]
		protected virtual bool IsComponentValid(T component)
		{
			return component != null && (component.IsStart || component.IsShowOrShowing || component.IsHideOrHiding);
		}

		// Token: 0x0602C9C6 RID: 182726 RVA: 0x00C84B19 File Offset: 0x00C82D19
		protected static void SetComponentActive(MarkPanelBase component, bool active)
		{
			if (active ? component.IsShow : component.IsHide)
			{
				return;
			}
			component.SetActive(active);
		}

		// Token: 0x04017EBC RID: 97980
		protected readonly IMarkItemComponentContext Context = context;

		// Token: 0x04017EBD RID: 97981
		[Nullable(2)]
		protected T ComponentInternal;
	}
}
