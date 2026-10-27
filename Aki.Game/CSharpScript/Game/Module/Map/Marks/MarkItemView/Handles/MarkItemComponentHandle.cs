using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005533 RID: 21811
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MarkItemComponentHandle<[Nullable(0)] T> : IMarkItemHandle, IMarkItemRangeHandle where T : MarkPanelBase, new()
	{
		// Token: 0x06037ADD RID: 228061 RVA: 0x00D36CF0 File Offset: 0x00D34EF0
		public MarkItemComponentHandle(IMarkItemComponentContext context)
		{
			this.Context = context;
		}

		// Token: 0x06037ADE RID: 228062 RVA: 0x00D36CFF File Offset: 0x00D34EFF
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06037ADF RID: 228063 RVA: 0x00D36D07 File Offset: 0x00D34F07
		private bool CanExecuteComponentLogic()
		{
			return this.Context.CanExecuteComponentLogic();
		}

		// Token: 0x06037AE0 RID: 228064 RVA: 0x00D36D14 File Offset: 0x00D34F14
		public void Update()
		{
			if (this.CanExecuteComponentLogic())
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06037AE1 RID: 228065 RVA: 0x00D36D24 File Offset: 0x00D34F24
		public void UpdateNoCheck()
		{
			this.OnUpdate();
		}

		// Token: 0x06037AE2 RID: 228066 RVA: 0x00D36D2C File Offset: 0x00D34F2C
		public void SetVisible(bool active)
		{
			if (this.CanExecuteComponentLogic())
			{
				this.OnSetVisible(active);
			}
		}

		// Token: 0x06037AE3 RID: 228067 RVA: 0x00D36D3D File Offset: 0x00D34F3D
		public void ApplyModified()
		{
			if (this.CanExecuteComponentLogic())
			{
				this.OnApplyModified();
			}
		}

		// Token: 0x06037AE4 RID: 228068 RVA: 0x00D36D4D File Offset: 0x00D34F4D
		public void ApplyModifiedNoCheck()
		{
			this.OnApplyModified();
		}

		// Token: 0x06037AE5 RID: 228069 RVA: 0x00D36D55 File Offset: 0x00D34F55
		public void Dispose()
		{
			this.OnDispose();
		}

		// Token: 0x06037AE6 RID: 228070 RVA: 0x00D36D5D File Offset: 0x00D34F5D
		protected virtual void OnInit()
		{
		}

		// Token: 0x06037AE7 RID: 228071 RVA: 0x00D36D5F File Offset: 0x00D34F5F
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06037AE8 RID: 228072 RVA: 0x00D36D61 File Offset: 0x00D34F61
		protected virtual void OnDispose()
		{
			this.DestroyComponent();
		}

		// Token: 0x06037AE9 RID: 228073 RVA: 0x00D36D69 File Offset: 0x00D34F69
		protected virtual void OnSetVisible(bool active)
		{
		}

		// Token: 0x06037AEA RID: 228074 RVA: 0x00D36D6B File Offset: 0x00D34F6B
		protected virtual void OnApplyModified()
		{
		}

		// Token: 0x06037AEB RID: 228075 RVA: 0x00D36D70 File Offset: 0x00D34F70
		protected virtual UniTask PreloadComponentAsync()
		{
			MarkItemComponentHandle<T>.<PreloadComponentAsync>d__16 <PreloadComponentAsync>d__;
			<PreloadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreloadComponentAsync>d__.<>4__this = this;
			<PreloadComponentAsync>d__.<>1__state = -1;
			<PreloadComponentAsync>d__.<>t__builder.Start<MarkItemComponentHandle<T>.<PreloadComponentAsync>d__16>(ref <PreloadComponentAsync>d__);
			return <PreloadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037AEC RID: 228076 RVA: 0x00D36DB4 File Offset: 0x00D34FB4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected virtual UniTask<T> LoadComponentAsync()
		{
			MarkItemComponentHandle<T>.<LoadComponentAsync>d__17 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemComponentHandle<T>.<LoadComponentAsync>d__17>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037AED RID: 228077 RVA: 0x00D36DF7 File Offset: 0x00D34FF7
		protected virtual T GetOrCreateComponent()
		{
			return this.ComponentInternal;
		}

		// Token: 0x06037AEE RID: 228078 RVA: 0x00D36DFF File Offset: 0x00D34FFF
		protected virtual void DestroyComponent()
		{
			if (this.ComponentInternal != null)
			{
				this.ComponentInternal.RecycleToPool();
				this.ComponentInternal = default(T);
			}
		}

		// Token: 0x06037AEF RID: 228079 RVA: 0x00D36E2A File Offset: 0x00D3502A
		protected virtual bool IsComponentValid(T component)
		{
			return component.IsStart || component.IsShowOrShowing || component.IsHideOrHiding;
		}

		// Token: 0x06037AF0 RID: 228080 RVA: 0x00D36E53 File Offset: 0x00D35053
		protected static void SetComponentActive(MarkPanelBase component, bool active)
		{
			if (active ? component.IsShow : component.IsHide)
			{
				return;
			}
			component.SetActive(active);
		}

		// Token: 0x0401D43A RID: 119866
		protected IMarkItemComponentContext Context;

		// Token: 0x0401D43B RID: 119867
		[Nullable(2)]
		protected T ComponentInternal;
	}
}
