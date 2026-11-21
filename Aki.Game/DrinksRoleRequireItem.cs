using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200041F RID: 1055
[Nullable(new byte[]
{
	0,
	1
})]
public class DrinksRoleRequireItem : GridProxyAbstract<IDrinksRequireInfo>
{
	// Token: 0x0600388C RID: 14476 RVA: 0x001491A8 File Offset: 0x001473A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x0600388D RID: 14477 RVA: 0x00149230 File Offset: 0x00147430
	[NullableContext(1)]
	public override void Refresh(IDrinksRequireInfo data, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			sprite.SetUIActive(data.Completed);
		}
		UUISprite sprite2 = base.GetSprite(4);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(data.Type == EDrinksRequireType.Flavor);
		}
		UUIItem text = base.GetText(3);
		bool completed = data.Completed;
		FColor? fcolor = new FColor?(base.GetText(3).changeColor);
		text.SetChangeColor(completed, fcolor);
		if (data.Type != EDrinksRequireType.Flavor || data.FlavorRangeId == null)
		{
			DrinksRequireList? requireList = DrinksConfig.Instance.GetRequireList(data.RequireId);
			string textStringId;
			switch (data.Type)
			{
			case EDrinksRequireType.DrinksBase:
				textStringId = requireList.Value.DrinkNeedKey;
				break;
			case EDrinksRequireType.Batching:
				textStringId = requireList.Value.BatchingNeedKey;
				break;
			case EDrinksRequireType.Ornament:
				textStringId = requireList.Value.OrnamentNeedKey;
				break;
			default:
				textStringId = "";
				break;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
			return;
		}
		DrinksFlavorRange? flavorRange = DrinksConfig.Instance.GetFlavorRange(data.FlavorRangeId.Value);
		DrinksFlavorType? flavorType = DrinksConfig.Instance.GetFlavorType((EDrinksFlavorType)flavorRange.Value.FlavorTypeRef);
		int[] flavorValuesArray = flavorRange.Value.GetFlavorValuesArray();
		int num = flavorValuesArray[0];
		int num2 = flavorValuesArray[1];
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), flavorRange.Value.Desc, new <>z__ReadOnlyArray<object>(new object[]
		{
			flavorType.Value.IconRichTxt,
			num,
			num2
		}));
	}

	// Token: 0x02006749 RID: 26441
	private static class EItem
	{
		// Token: 0x040221BD RID: 139709
		public const int IconLock = 0;

		// Token: 0x040221BE RID: 139710
		public const int PanelCheck = 1;

		// Token: 0x040221BF RID: 139711
		public const int SpriteCheck = 2;

		// Token: 0x040221C0 RID: 139712
		public const int Desc = 3;

		// Token: 0x040221C1 RID: 139713
		public const int SpriteMain = 4;
	}
}
