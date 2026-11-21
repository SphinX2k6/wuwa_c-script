using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x02005629 RID: 22057
	public class DropCatchDropItem : GridProxyAbstract<int>
	{
		// Token: 0x0603686B RID: 223339 RVA: 0x00F37DE4 File Offset: 0x00F35FE4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
		}

		// Token: 0x0603686C RID: 223340 RVA: 0x00F37E6C File Offset: 0x00F3606C
		public override void Refresh(int cfgId, bool isSelected, int gridIndex)
		{
			DropCatchDropItem? dropCatchDropItemById = DropCatchConfig.Instance.GetDropCatchDropItemById(cfgId);
			if (dropCatchDropItemById == null)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(gridIndex % 2 == 0);
			}
			this.SetSpriteByPath(dropCatchDropItemById.Value.Icon, base.GetSprite(2), false, null, null);
			bool flag = dropCatchDropItemById.Value.EffectType == 1;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(flag ? "SP_GoldCatchItemBgRed" : "SP_GoldCatchItemBgGreen");
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
			base.GetText(3).ShowTextNew(dropCatchDropItemById.Value.Name);
			base.GetText(4).ShowTextNew(dropCatchDropItemById.Value.Desc);
		}
	}
}
