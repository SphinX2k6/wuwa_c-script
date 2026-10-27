using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200553F RID: 21823
	public class TeleportMarkItemChildIconHandle : MarkItemChildIconHandle
	{
		// Token: 0x06037B32 RID: 228146 RVA: 0x00D37C15 File Offset: 0x00D35E15
		[NullableContext(1)]
		public TeleportMarkItemChildIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x06037B33 RID: 228147 RVA: 0x00D37C20 File Offset: 0x00D35E20
		protected override void OnUpdate()
		{
			TeleportMarkItem teleportMarkItem = this.Context.MarkItem as TeleportMarkItem;
			if (teleportMarkItem.IsDungeonEntrance)
			{
				bool isFogUnlock = teleportMarkItem.IsFogUnlock;
				if (!isFogUnlock)
				{
					this.Context.MarkItemEntity.Resource.ChildIconPath = UiResourceConfig.Instance.GetResourcePath("SP_MarkRecommend");
				}
				base.SetVisible(!isFogUnlock);
				return;
			}
			base.OnUpdate();
		}
	}
}
