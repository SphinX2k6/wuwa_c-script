using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D08 RID: 7432
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRecordFloorItem : GridProxyAbstract<RoleTowerFloorRecordData>
{
	// Token: 0x06012652 RID: 75346 RVA: 0x0056F640 File Offset: 0x0056D840
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06012653 RID: 75347 RVA: 0x0056F6C8 File Offset: 0x0056D8C8
	public override void Refresh(RoleTowerFloorRecordData data, bool isSelected, int gridIndex)
	{
		RoleTowerFloor? floorCfg = RoleTowerModel.Instance.GetFloorCfg(data.FloorId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), (floorCfg != null) ? floorCfg.GetValueOrDefault().FloorShortName : null, Array.Empty<object>());
		UUIText text = base.GetText(1);
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = !data.IsPlaceholder && data.DeltaTimeMs > 0L;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			text.SetText(data.IsPlaceholder ? "--:--:--" : RoleTowerTimeUtil.FormatDeltaHud(data.DeltaTimeMs), true);
		}
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
		UUISprite sprite2 = base.GetSprite(3);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(false);
		}
		if (sprite != null)
		{
			UUIItem uuiitem2 = sprite;
			bool isPlaceholder = data.IsPlaceholder;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem2.SetChangeColor(isPlaceholder, fcolor);
		}
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAlpha(data.IsPlaceholder ? 0.5f : 1f);
	}

	// Token: 0x06012654 RID: 75348 RVA: 0x0056F7D4 File Offset: 0x0056D9D4
	public override object GetKey(RoleTowerFloorRecordData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x02008036 RID: 32822
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297C7 RID: 169927
		public const int TxtNum = 0;

		// Token: 0x040297C8 RID: 169928
		public const int TxtUseTime = 1;

		// Token: 0x040297C9 RID: 169929
		public const int SprBg = 2;

		// Token: 0x040297CA RID: 169930
		public const int SprBgRed = 3;

		// Token: 0x040297CB RID: 169931
		public const int PnlContent = 4;
	}
}
