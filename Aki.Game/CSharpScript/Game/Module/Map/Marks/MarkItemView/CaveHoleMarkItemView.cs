using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005503 RID: 21763
	[NullableContext(1)]
	[Nullable(0)]
	public class CaveHoleMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0603798D RID: 227725 RVA: 0x00D331BF File Offset: 0x00D313BF
		public CaveHoleMarkItemView(CaveHoleMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0603798E RID: 227726 RVA: 0x00D331C8 File Offset: 0x00D313C8
		public override void UpdateIcon()
		{
			MapMark? mapMark;
			string iconPath = (base.MarkConfig != null) ? mapMark.GetValueOrDefault().UnlockMarkPic : null;
			this.OnIconPathChanged(iconPath);
		}

		// Token: 0x0603798F RID: 227727 RVA: 0x00D331FF File Offset: 0x00D313FF
		protected override void OnViewRefresh()
		{
			this.UpdateIcon();
		}

		// Token: 0x06037990 RID: 227728 RVA: 0x00D33208 File Offset: 0x00D31408
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

		// Token: 0x06037991 RID: 227729 RVA: 0x00D33245 File Offset: 0x00D31445
		[PreserveBaseOverrides]
		protected new virtual MarkItemChildIconHandle CreateChildIconHandle(IMarkItemComponentContext markComponentContext)
		{
			return new CaveHoleMarkItemChildIconHandle(markComponentContext);
		}
	}
}
