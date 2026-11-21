using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004511 RID: 17681
	public class TeleportMarkItemChildIconHandle : MarkItemChildIconHandle
	{
		// Token: 0x0602CA02 RID: 182786 RVA: 0x00C85741 File Offset: 0x00C83941
		[NullableContext(1)]
		public TeleportMarkItemChildIconHandle(IMarkItemComponentContext context) : base(context)
		{
		}

		// Token: 0x0602CA03 RID: 182787 RVA: 0x00C8574C File Offset: 0x00C8394C
		protected override void OnUpdate()
		{
			TeleportMarkItem teleportMarkItem = this.Context.MarkItem as TeleportMarkItem;
			if (teleportMarkItem.IsDungeonEntrance)
			{
				bool isFogUnlock = teleportMarkItem.IsFogUnlock;
				if (!isFogUnlock)
				{
					teleportMarkItem.ChildIconPath = UiResourceConfig.Instance.GetResourcePath("SP_MarkRecommend");
				}
				base.SetVisible(!isFogUnlock);
				return;
			}
			base.OnUpdate();
		}
	}
}
