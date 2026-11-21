using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004512 RID: 17682
	public class TemporaryTeleportMarkItemChildIconHandle : MarkItemChildIconHandle
	{
		// Token: 0x0602CA04 RID: 182788 RVA: 0x00C857A2 File Offset: 0x00C839A2
		[NullableContext(1)]
		public TemporaryTeleportMarkItemChildIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602CA05 RID: 182789 RVA: 0x00C857AC File Offset: 0x00C839AC
		protected override void OnUpdate()
		{
			base.OnUpdate();
			if (base.Visible)
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MarkTime");
			this.Context.MarkItem.ChildIconPath = resourcePath;
			base.SetVisible(true);
		}
	}
}
