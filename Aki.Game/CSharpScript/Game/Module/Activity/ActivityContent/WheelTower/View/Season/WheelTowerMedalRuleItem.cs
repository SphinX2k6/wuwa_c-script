using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02005F5C RID: 24412
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class WheelTowerMedalRuleItem : GridProxyAbstract<WheelTowerMedalRuleItemData>
	{
		// Token: 0x0603DFFD RID: 253949 RVA: 0x00EF6C94 File Offset: 0x00EF4E94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603DFFE RID: 253950 RVA: 0x00EF6D60 File Offset: 0x00EF4F60
		public override void Refresh(WheelTowerMedalRuleItemData data, bool isSelected, int gridIndex)
		{
			NewTowerMedal? medalConfigById = WheelTowerConfig.Instance.GetMedalConfigById(data.MedalId);
			if (medalConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(medalConfigById.Value.Icon, base.GetTexture(0), null, null);
			base.SetTextureByPath(medalConfigById.Value.Background, base.GetTexture(4), null, null);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(medalConfigById.Value.Desc);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(data.IsCompleted);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(!data.IsCompleted);
		}
	}
}
