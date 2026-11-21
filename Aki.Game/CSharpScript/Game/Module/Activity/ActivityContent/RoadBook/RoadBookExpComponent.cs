using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200514B RID: 20811
	public class RoadBookExpComponent : UiPanelBase
	{
		// Token: 0x0603407F RID: 213119 RVA: 0x00E8E290 File Offset: 0x00E8C490
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x06034080 RID: 213120 RVA: 0x00E8E300 File Offset: 0x00E8C500
		protected override void OnStart()
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("RoadBookCurrentLevelExp_Text");
		}

		// Token: 0x06034081 RID: 213121 RVA: 0x00E8E318 File Offset: 0x00E8C518
		public void SetProgress(int current, int target, bool isMax)
		{
			if (isMax)
			{
				base.GetSprite(1).SetFillAmount(1f);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RoadBookLevelMax_Text", Array.Empty<object>());
				return;
			}
			base.GetSprite(1).SetFillAmount(MathUtils.Instance.Clamp((float)current / (float)target, 0f, 1f));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RoadBookExp_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				current,
				target
			}));
		}

		// Token: 0x06034082 RID: 213122 RVA: 0x00E8E3AD File Offset: 0x00E8C5AD
		public void SetLevel(int level)
		{
			base.GetArtText(0).SetText(level.ToString());
		}
	}
}
