using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066D9 RID: 26329
	public class DropCatchDropItem : GridProxyAbstract<int>
	{
		// Token: 0x06041D1F RID: 269599 RVA: 0x00FF69E0 File Offset: 0x00FF4BE0
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

		// Token: 0x06041D20 RID: 269600 RVA: 0x00FF6A68 File Offset: 0x00FF4C68
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
