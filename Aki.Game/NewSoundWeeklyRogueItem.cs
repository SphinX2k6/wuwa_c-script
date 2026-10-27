using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016B1 RID: 5809
public class NewSoundWeeklyRogueItem : UiPanelBase, INewSoundItem
{
	// Token: 0x0600A5B1 RID: 42417 RVA: 0x00250D08 File Offset: 0x0024EF08
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

	// Token: 0x0600A5B2 RID: 42418 RVA: 0x00250DB4 File Offset: 0x0024EFB4
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

	// Token: 0x02007C87 RID: 31879
	private enum EComponentsDefine
	{
		// Token: 0x04028DB3 RID: 167347
		TxtName,
		// Token: 0x04028DB4 RID: 167348
		TextureIcon,
		// Token: 0x04028DB5 RID: 167349
		TxtTips,
		// Token: 0x04028DB6 RID: 167350
		SpriteIcon
	}
}
