using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B69 RID: 2921
public class NewSoundWeeklyRogueItem : UiPanelBase, INewSoundItem
{
	// Token: 0x06007991 RID: 31121 RVA: 0x0025B118 File Offset: 0x00259318
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007992 RID: 31122 RVA: 0x0025B1C4 File Offset: 0x002593C4
	[NullableContext(1)]
	public void Update(NewSoundDetectItemData data)
	{
		RogueWeeklyCycle? cycleConfig = WeeklyRogueModel.Instance.ActivityData.GetCycleConfig();
		int score = WeeklyRogueModel.Instance.ActivityData.Score;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PrefabTextItem_1382682910_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			score,
			cycleConfig.Value.MaxScore
		}));
	}

	// Token: 0x02006E0C RID: 28172
	private enum EComponentsDefine
	{
		// Token: 0x040240DC RID: 147676
		TxtName,
		// Token: 0x040240DD RID: 147677
		TextureIcon,
		// Token: 0x040240DE RID: 147678
		TxtTips,
		// Token: 0x040240DF RID: 147679
		SpriteIcon
	}
}
