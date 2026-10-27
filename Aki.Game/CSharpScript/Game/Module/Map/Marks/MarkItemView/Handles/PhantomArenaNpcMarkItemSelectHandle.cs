using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components.SubComponents;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200553D RID: 21821
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkItemSelectHandle : MarkItemSelectHandle
	{
		// Token: 0x06037B29 RID: 228137 RVA: 0x00D37A37 File Offset: 0x00D35C37
		public PhantomArenaNpcMarkItemSelectHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B2A RID: 228138 RVA: 0x00D37A40 File Offset: 0x00D35C40
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected override UniTask<MarkSelectComponent> LoadComponentAsync()
		{
			PhantomArenaNpcMarkItemSelectHandle.<LoadComponentAsync>d__3 <LoadComponentAsync>d__;
			<LoadComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<MarkSelectComponent>.Create();
			<LoadComponentAsync>d__.<>4__this = this;
			<LoadComponentAsync>d__.<>1__state = -1;
			<LoadComponentAsync>d__.<>t__builder.Start<PhantomArenaNpcMarkItemSelectHandle.<LoadComponentAsync>d__3>(ref <LoadComponentAsync>d__);
			return <LoadComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B2B RID: 228139 RVA: 0x00D37A84 File Offset: 0x00D35C84
		protected override MarkSelectComponent GetOrCreateComponent()
		{
			MapModel instance = MapModel.Instance;
			if (instance != null && instance.IsExtraUiMarkType(EMapType.WorldMap, EMarkType.PhantomArenaNpc))
			{
				if (this.PhantomArenaSelectComponent == null)
				{
					this.LoadComponentAsync().ContinueWith(delegate(MarkSelectComponent _)
					{
						base.ApplyModified();
					});
				}
				this.ComponentInternal = this.PhantomArenaSelectComponent;
			}
			else
			{
				if (this.NormalComponent == null)
				{
					this.LoadComponentAsync().ContinueWith(delegate(MarkSelectComponent _)
					{
						base.ApplyModified();
					});
				}
				this.ComponentInternal = this.NormalComponent;
			}
			return this.ComponentInternal;
		}

		// Token: 0x06037B2C RID: 228140 RVA: 0x00D37B08 File Offset: 0x00D35D08
		protected override void OnApplyModified()
		{
			MarkViewLifeCircleComponent viewLifeCircle = this.Context.MarkItemEntity.ViewLifeCircle;
			if (viewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.Select))
			{
				MarkSelectComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool active = viewLifeCircle.IsChildViewVisible(EMarkViewComponentType.Select, false);
				viewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.Select);
				MarkItemComponentHandle<MarkSelectComponent>.SetComponentActive(orCreateComponent, active);
			}
		}

		// Token: 0x0401D43E RID: 119870
		[Nullable(2)]
		private MarkSelectComponent NormalComponent;

		// Token: 0x0401D43F RID: 119871
		[Nullable(2)]
		private PhantomArenaNpcMarkSelectComponent PhantomArenaSelectComponent;
	}
}
