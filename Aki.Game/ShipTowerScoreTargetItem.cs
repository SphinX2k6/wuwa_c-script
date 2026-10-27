using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029CF RID: 10703
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerScoreTargetItem : GridProxyAbstract<ShipTowerScoreTargetData>
{
	// Token: 0x060162EC RID: 90860 RVA: 0x0059C478 File Offset: 0x0059A678
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUITexture))
		};
	}

	// Token: 0x060162ED RID: 90861 RVA: 0x0059C514 File Offset: 0x0059A714
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerScoreTargetItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerScoreTargetItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162EE RID: 90862 RVA: 0x0059C557 File Offset: 0x0059A757
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x060162EF RID: 90863 RVA: 0x0059C559 File Offset: 0x0059A759
	protected override void OnStart()
	{
	}

	// Token: 0x060162F0 RID: 90864 RVA: 0x0059C55B File Offset: 0x0059A75B
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060162F1 RID: 90865 RVA: 0x0059C560 File Offset: 0x0059A760
	[NullableContext(1)]
	public override void Refresh(ShipTowerScoreTargetData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		base.GetText(2).SetText(this.ItemData.Title, true);
		base.GetText(3).SetText(this.ItemData.ScoreTarget.ToString(), true);
		base.GetSprite(0).SetUIActive(!this.ItemData.IsFinish);
		base.GetSprite(1).SetUIActive(this.ItemData.IsFinish);
		this.UpdateGrade();
	}

	// Token: 0x060162F2 RID: 90866 RVA: 0x0059C5E0 File Offset: 0x0059A7E0
	private void UpdateGrade()
	{
		ShipTowerScoreTargetData itemData = this.ItemData;
		string text = (itemData != null) ? itemData.ScoreGradeRes : null;
		base.GetItem(4).SetUIActive(text != null);
		if (text != null)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			base.SetTextureByPath(resourcePath, base.GetTexture(5), null, null);
		}
	}

	// Token: 0x0400A52B RID: 42283
	[Nullable(2)]
	private ShipTowerScoreTargetData ItemData;

	// Token: 0x02008FF5 RID: 36853
	private static class EChildType
	{
		// Token: 0x0402E9D7 RID: 190935
		public const int SpriteUnFinish = 0;

		// Token: 0x0402E9D8 RID: 190936
		public const int SpriteFinish = 1;

		// Token: 0x0402E9D9 RID: 190937
		public const int TxtTitle = 2;

		// Token: 0x0402E9DA RID: 190938
		public const int TxtScore = 3;

		// Token: 0x0402E9DB RID: 190939
		public const int ItemGradeRoot = 4;

		// Token: 0x0402E9DC RID: 190940
		public const int TextureGrade = 5;
	}
}
