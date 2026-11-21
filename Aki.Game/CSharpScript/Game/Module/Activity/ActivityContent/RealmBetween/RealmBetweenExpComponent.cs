using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051EE RID: 20974
	public class RealmBetweenExpComponent : UiPanelBase
	{
		// Token: 0x060343F7 RID: 214007 RVA: 0x00E9D9B4 File Offset: 0x00E9BBB4
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

		// Token: 0x060343F8 RID: 214008 RVA: 0x00E9DA24 File Offset: 0x00E9BC24
		protected override void OnStart()
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("RealmBetweenCurrentLevelExp_Text");
		}

		// Token: 0x060343F9 RID: 214009 RVA: 0x00E9DA3C File Offset: 0x00E9BC3C
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

		// Token: 0x060343FA RID: 214010 RVA: 0x00E9DAD1 File Offset: 0x00E9BCD1
		public void SetLevel(int level)
		{
			base.GetArtText(0).SetText(level.ToString());
		}
	}
}
