using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005656 RID: 22102
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DropItemListItem : GridProxyAbstract<IDropItemListItemData>
	{
		// Token: 0x0603695C RID: 223580 RVA: 0x00F3B7A8 File Offset: 0x00F399A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText))
			};
		}

		// Token: 0x0603695D RID: 223581 RVA: 0x00F3B804 File Offset: 0x00F39A04
		public override void Refresh(IDropItemListItemData data, bool isSelected, int gridIndex)
		{
			UUIArtText artText = base.GetArtText(2);
			if (artText != null)
			{
				artText.SetText(data.Count.ToString());
			}
			DropCatchDropItem? dropCatchDropItemById = DropCatchConfig.Instance.GetDropCatchDropItemById(data.Id);
			if (dropCatchDropItemById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "获取掉落物配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", data.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), dropCatchDropItemById.Value.Name, Array.Empty<object>());
			base.TrySetSpriteByPath(dropCatchDropItemById.Value.Icon, base.GetSprite(0), false, null, null);
		}
	}
}
