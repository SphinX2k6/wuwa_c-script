using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Mark;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02005540 RID: 21824
	public class TemporaryTeleportMarkItemChildIconHandle : MarkItemChildIconHandle
	{
		// Token: 0x06037B34 RID: 228148 RVA: 0x00D37C85 File Offset: 0x00D35E85
		[NullableContext(1)]
		public TemporaryTeleportMarkItemChildIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B35 RID: 228149 RVA: 0x00D37C90 File Offset: 0x00D35E90
		protected override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.Context.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.ChildIcon, false))
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MarkTime");
				this.Context.MarkItemEntity.Resource.ChildIconPath = resourcePath;
				base.SetVisible(true);
			}
		}
	}
}
