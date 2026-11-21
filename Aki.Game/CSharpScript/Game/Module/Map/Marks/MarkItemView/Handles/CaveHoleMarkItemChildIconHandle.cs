using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x020044FE RID: 17662
	public class CaveHoleMarkItemChildIconHandle : MarkItemChildIconHandle
	{
		// Token: 0x0602C971 RID: 182641 RVA: 0x00C8441C File Offset: 0x00C8261C
		[NullableContext(1)]
		public CaveHoleMarkItemChildIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602C972 RID: 182642 RVA: 0x00C84428 File Offset: 0x00C82628
		protected override void OnUpdate()
		{
			MarkItem markItem = this.Context.MarkItem;
			if (markItem.IsMultiMap())
			{
				bool isSelectThisFloor = markItem.IsSelectThisFloor;
				bool flag = markItem.LocateInGround() && isSelectThisFloor;
				base.SetVisible(!flag);
				markItem.ChildIconPath = UiResourceConfig.Instance.GetResourcePath(isSelectThisFloor ? "SP_MarkMultiMapSelect" : "SP_MarkMultiMap");
				return;
			}
			base.SetVisible(false);
		}
	}
}
