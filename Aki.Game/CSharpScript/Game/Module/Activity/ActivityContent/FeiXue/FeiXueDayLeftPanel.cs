using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x0200663F RID: 26175
	[NullableContext(1)]
	[Nullable(0)]
	public class FeiXueDayLeftPanel : UiPanelBase
	{
		// Token: 0x060419AA RID: 268714 RVA: 0x00FE91DB File Offset: 0x00FE73DB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x060419AB RID: 268715 RVA: 0x00FE9214 File Offset: 0x00FE7414
		public void SetPanelItemActive(bool isFinish)
		{
			base.GetSprite(1).SetUIActive(true);
			if (isFinish)
			{
				UUISprite sprite = base.GetSprite(0);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				base.GetSprite(1).SetColor(FColor.FromHex(this.FrameFinishColor));
				return;
			}
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			base.GetSprite(1).SetColor(FColor.FromHex(this.FrameLockColor));
		}

		// Token: 0x060419AC RID: 268716 RVA: 0x00FE9286 File Offset: 0x00FE7486
		public void SetAllFinishState()
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(false);
		}

		// Token: 0x04022218 RID: 139800
		private string FrameLockColor = "#FFFFFFFF";

		// Token: 0x04022219 RID: 139801
		private string FrameFinishColor = "#F8EB57FF";
	}
}
