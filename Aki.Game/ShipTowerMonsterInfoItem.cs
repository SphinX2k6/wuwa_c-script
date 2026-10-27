using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029B8 RID: 10680
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerMonsterInfoItem : GridProxyAbstract<ShipTowerMonsterInfoItemData>
{
	// Token: 0x06016251 RID: 90705 RVA: 0x00599C8C File Offset: 0x00597E8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout))
		};
	}

	// Token: 0x06016252 RID: 90706 RVA: 0x00599CFC File Offset: 0x00597EFC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterInfoItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterInfoItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016253 RID: 90707 RVA: 0x00599D3F File Offset: 0x00597F3F
	public override void Refresh(ShipTowerMonsterInfoItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06016254 RID: 90708 RVA: 0x00599D48 File Offset: 0x00597F48
	public void Refresh(ShipTowerMonsterInfoItemData data)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), "LevelText", new <>z__ReadOnlySingleElementList<object>(data.Level));
		base.GetText(0).ShowTextNew(data.Title);
		base.SetTextureByPath(data.MonsterIcon, base.GetTexture(2), null, null);
		GenericLayout<TowerElementItem, int> layoutElement = this.LayoutElement;
		if (layoutElement == null)
		{
			return;
		}
		layoutElement.RefreshByData(data.ElementList, null, false);
	}

	// Token: 0x06016255 RID: 90709 RVA: 0x00599DC2 File Offset: 0x00597FC2
	private TowerElementItem CreateItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x0400A4FB RID: 42235
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> LayoutElement;

	// Token: 0x02008FCC RID: 36812
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E92C RID: 190764
		public const int TxtTitle = 0;

		// Token: 0x0402E92D RID: 190765
		public const int TxtLevel = 1;

		// Token: 0x0402E92E RID: 190766
		public const int TextureMonsterIcon = 2;

		// Token: 0x0402E92F RID: 190767
		public const int HLayoutContainer = 3;
	}
}
