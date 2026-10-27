using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005535 RID: 21813
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MarkItemNameHandle : MarkItemComponentHandle<MarkNameComponent>
	{
		// Token: 0x06037AF7 RID: 228087 RVA: 0x00D36FBC File Offset: 0x00D351BC
		public MarkItemNameHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037AF8 RID: 228088 RVA: 0x00D36FC8 File Offset: 0x00D351C8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkNameComponent> LoadComponentAsync()
		{
			MarkItemNameHandle.<LoadComponentAsync>d__2 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkNameComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<MarkItemNameHandle.<LoadComponentAsync>d__2>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037AF9 RID: 228089 RVA: 0x00D3700B File Offset: 0x00D3520B
		protected override MarkNameComponent GetOrCreateComponent()
		{
			if (this.ComponentInternal == null)
			{
				this.LoadComponentAsync().ContinueWith(delegate(MarkNameComponent _)
				{
					base.ApplyModified();
				});
			}
			return this.ComponentInternal;
		}

		// Token: 0x06037AFA RID: 228090 RVA: 0x00D37033 File Offset: 0x00D35233
		public void SetName(IMarkItemParam param)
		{
			this.Param = param;
		}

		// Token: 0x06037AFB RID: 228091 RVA: 0x00D3703C File Offset: 0x00D3523C
		protected override void OnSetVisible(bool active)
		{
			this.Context.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.Name, active);
		}

		// Token: 0x06037AFC RID: 228092 RVA: 0x00D37058 File Offset: 0x00D35258
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.Name))
			{
				MarkNameComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.Name, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.Name);
				if (this.Param != null)
				{
					orCreateComponent.SetNameParam(this.Param);
				}
				MarkItemComponentHandle<MarkNameComponent>.SetComponentActive(orCreateComponent, active);
			}
		}

		// Token: 0x0401D43C RID: 119868
		[Nullable(2)]
		private IMarkItemParam Param;
	}
}
