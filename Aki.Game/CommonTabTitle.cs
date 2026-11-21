using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E6F RID: 3695
public class CommonTabTitle : UiPanelBase
{
	// Token: 0x060093E1 RID: 37857 RVA: 0x002BF734 File Offset: 0x002BD934
	[NullableContext(1)]
	public CommonTabTitle(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060093E2 RID: 37858 RVA: 0x002BF749 File Offset: 0x002BD949
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060093E3 RID: 37859 RVA: 0x002BF784 File Offset: 0x002BD984
	[NullableContext(1)]
	public void UpdateIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x060093E4 RID: 37860 RVA: 0x002BF7AC File Offset: 0x002BD9AC
	[NullableContext(2)]
	public void UpdateTitle(CommonTabTitleData titleData)
	{
		UUIText text = base.GetText(1);
		if (titleData == null)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		if (!string.IsNullOrEmpty(titleData.RawText))
		{
			text.SetText(titleData.RawText, true);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, titleData.TextId, titleData.Args);
	}

	// Token: 0x02007065 RID: 28773
	private class ECommonTabTitle
	{
		// Token: 0x04024A6A RID: 150122
		public const int Icon = 0;

		// Token: 0x04024A6B RID: 150123
		public const int Title = 1;
	}
}
