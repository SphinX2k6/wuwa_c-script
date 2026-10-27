using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006706 RID: 26374
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DropItemListItem : GridProxyAbstract<IDropItemListItemData>
	{
		// Token: 0x06041E10 RID: 269840 RVA: 0x00FFA3B4 File Offset: 0x00FF85B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText))
			};
		}

		// Token: 0x06041E11 RID: 269841 RVA: 0x00FFA410 File Offset: 0x00FF8610
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
