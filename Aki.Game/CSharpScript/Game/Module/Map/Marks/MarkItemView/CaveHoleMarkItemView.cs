using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044D6 RID: 17622
	[NullableContext(1)]
	[Nullable(0)]
	public class CaveHoleMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C85C RID: 182364 RVA: 0x00C8118D File Offset: 0x00C7F38D
		public CaveHoleMarkItemView(CaveHoleMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C85D RID: 182365 RVA: 0x00C81198 File Offset: 0x00C7F398
		public override void UpdateIcon()
		{
			MapMark? mapMark;
			string text = (((CaveHoleMarkItem)this.Holder).MarkConfig != null) ? mapMark.GetValueOrDefault().UnlockMarkPic : null;
			this.OnIconPathChanged(text ?? "");
		}

		// Token: 0x0602C85E RID: 182366 RVA: 0x00C811E2 File Offset: 0x00C7F3E2
		protected override void OnViewRefresh()
		{
			this.UpdateIcon();
		}

		// Token: 0x0602C85F RID: 182367 RVA: 0x00C811EC File Offset: 0x00C7F3EC
		public override void OnIconPathChanged(string iconPath)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			base.LoadIcon(sprite, iconPath);
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x0602C860 RID: 182368 RVA: 0x00C81229 File Offset: 0x00C7F429
		[PreserveBaseOverrides]
		protected new virtual MarkItemChildIconHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new CaveHoleMarkItemChildIconHandle(markComponentContext);
		}
	}
}
