using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components.SubComponents;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200450F RID: 17679
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNpcMarkItemSelectHandle : MarkItemSelectHandle
	{
		// Token: 0x0602C9F9 RID: 182777 RVA: 0x00C85577 File Offset: 0x00C83777
		public PhantomArenaNpcMarkItemSelectHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C9FA RID: 182778 RVA: 0x00C85580 File Offset: 0x00C83780
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

		// Token: 0x0602C9FB RID: 182779 RVA: 0x00C855C4 File Offset: 0x00C837C4
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

		// Token: 0x0602C9FC RID: 182780 RVA: 0x00C85648 File Offset: 0x00C83848
		protected override void OnApplyModified()
		{
			if (base.VisibleDirty)
			{
				MarkSelectComponent orCreateComponent = this.GetOrCreateComponent();
				if (!this.IsComponentValid(orCreateComponent))
				{
					return;
				}
				bool visible = base.Visible;
				base.CleanVisibleDirty();
				MarkItemComponentHandle<MarkSelectComponent>.SetComponentActive(orCreateComponent, visible);
			}
		}

		// Token: 0x04017EC4 RID: 97988
		[Nullable(2)]
		private MarkSelectComponent NormalComponent;

		// Token: 0x04017EC5 RID: 97989
		[Nullable(2)]
		private PhantomArenaNpcMarkSelectComponent PhantomArenaSelectComponent;
	}
}
