using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006270 RID: 25200
	public class RealmBetweenExpComponent : UiPanelBase
	{
		// Token: 0x0603F736 RID: 259894 RVA: 0x00F56A58 File Offset: 0x00F54C58
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

		// Token: 0x0603F737 RID: 259895 RVA: 0x00F56AC8 File Offset: 0x00F54CC8
		protected override void OnStart()
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("RealmBetweenCurrentLevelExp_Text");
		}

		// Token: 0x0603F738 RID: 259896 RVA: 0x00F56AE0 File Offset: 0x00F54CE0
		public void SetProgress(int current, int target, bool isMax)
		{
			if (isMax)
			{
				base.GetSprite(1).SetFillAmount(1f);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RealmBetweenLevelMax_Text", Array.Empty<object>());
				return;
			}
			base.GetSprite(1).SetFillAmount(MathUtils.Instance.Clamp((float)current / (float)target, 0f, 1f));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RealmBetweenExp_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				current,
				target
			}));
		}

		// Token: 0x0603F739 RID: 259897 RVA: 0x00F56B75 File Offset: 0x00F54D75
		public void SetLevel(int level)
		{
			base.GetArtText(0).SetText(level.ToString());
		}
	}
}
