using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061CD RID: 25037
	public class RoadBookExpComponent : UiPanelBase
	{
		// Token: 0x0603F3BE RID: 259006 RVA: 0x00F47338 File Offset: 0x00F45538
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

		// Token: 0x0603F3BF RID: 259007 RVA: 0x00F473A8 File Offset: 0x00F455A8
		protected override void OnStart()
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("RoadBookCurrentLevelExp_Text");
		}

		// Token: 0x0603F3C0 RID: 259008 RVA: 0x00F473C0 File Offset: 0x00F455C0
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

		// Token: 0x0603F3C1 RID: 259009 RVA: 0x00F47455 File Offset: 0x00F45655
		public void SetLevel(int level)
		{
			base.GetArtText(0).SetText(level.ToString());
		}
	}
}
