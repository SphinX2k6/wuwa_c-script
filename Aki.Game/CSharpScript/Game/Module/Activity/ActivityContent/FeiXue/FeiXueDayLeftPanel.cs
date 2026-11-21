using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055BD RID: 21949
	[NullableContext(1)]
	[Nullable(0)]
	public class FeiXueDayLeftPanel : UiPanelBase
	{
		// Token: 0x0603666F RID: 222831 RVA: 0x00F30293 File Offset: 0x00F2E493
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x06036670 RID: 222832 RVA: 0x00F302CC File Offset: 0x00F2E4CC
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

		// Token: 0x06036671 RID: 222833 RVA: 0x00F3033E File Offset: 0x00F2E53E
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

		// Token: 0x0401CB49 RID: 117577
		private string FrameLockColor = "#FFFFFFFF";

		// Token: 0x0401CB4A RID: 117578
		private string FrameFinishColor = "#F8EB57FF";
	}
}
