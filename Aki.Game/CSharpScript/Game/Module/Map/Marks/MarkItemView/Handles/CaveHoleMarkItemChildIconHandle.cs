using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200552B RID: 21803
	public class CaveHoleMarkItemChildIconHandle : MarkItemChildIconHandle
	{
		// Token: 0x06037AA1 RID: 228001 RVA: 0x00D36700 File Offset: 0x00D34900
		[NullableContext(1)]
		public CaveHoleMarkItemChildIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037AA2 RID: 228002 RVA: 0x00D3670C File Offset: 0x00D3490C
		protected override void OnUpdate()
		{
			MarkItem markItem = this.Context.MarkItem;
			if (markItem.IsMultiMap())
			{
				bool isSelectThisFloor = markItem.IsSelectThisFloor;
				bool flag = markItem.LocateInGround() && isSelectThisFloor;
				base.SetVisible(!flag);
				this.Context.MarkItemEntity.Resource.ChildIconPath = UiResourceConfig.Instance.GetResourcePath(isSelectThisFloor ? "SP_MarkMultiMapSelect" : "SP_MarkMultiMap");
				return;
			}
			base.SetVisible(false);
		}
	}
}
