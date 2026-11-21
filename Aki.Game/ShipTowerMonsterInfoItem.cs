using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F33 RID: 7987
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerMonsterInfoItem : GridProxyAbstract<ShipTowerMonsterInfoItemData>
{
	// Token: 0x06013C57 RID: 80983 RVA: 0x005C4C18 File Offset: 0x005C2E18
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

	// Token: 0x06013C58 RID: 80984 RVA: 0x005C4C88 File Offset: 0x005C2E88
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterInfoItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterInfoItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C59 RID: 80985 RVA: 0x005C4CCB File Offset: 0x005C2ECB
	public override void Refresh(ShipTowerMonsterInfoItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06013C5A RID: 80986 RVA: 0x005C4CD4 File Offset: 0x005C2ED4
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

	// Token: 0x06013C5B RID: 80987 RVA: 0x005C4D4E File Offset: 0x005C2F4E
	private TowerElementItem CreateItem()
	{
		return new TowerElementItem();
	}

	// Token: 0x0400A8E5 RID: 43237
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerElementItem, int> LayoutElement;

	// Token: 0x02008214 RID: 33300
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A029 RID: 172073
		public const int TxtTitle = 0;

		// Token: 0x0402A02A RID: 172074
		public const int TxtLevel = 1;

		// Token: 0x0402A02B RID: 172075
		public const int TextureMonsterIcon = 2;

		// Token: 0x0402A02C RID: 172076
		public const int HLayoutContainer = 3;
	}
}
