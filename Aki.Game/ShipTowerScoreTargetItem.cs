using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4A RID: 8010
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerScoreTargetItem : GridProxyAbstract<ShipTowerScoreTargetData>
{
	// Token: 0x06013CF2 RID: 81138 RVA: 0x005C7430 File Offset: 0x005C5630
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

	// Token: 0x06013CF3 RID: 81139 RVA: 0x005C74CC File Offset: 0x005C56CC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerScoreTargetItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerScoreTargetItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CF4 RID: 81140 RVA: 0x005C750F File Offset: 0x005C570F
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06013CF5 RID: 81141 RVA: 0x005C7511 File Offset: 0x005C5711
	protected override void OnStart()
	{
	}

	// Token: 0x06013CF6 RID: 81142 RVA: 0x005C7513 File Offset: 0x005C5713
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06013CF7 RID: 81143 RVA: 0x005C7518 File Offset: 0x005C5718
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

	// Token: 0x06013CF8 RID: 81144 RVA: 0x005C7598 File Offset: 0x005C5798
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

	// Token: 0x0400A915 RID: 43285
	[Nullable(2)]
	private ShipTowerScoreTargetData ItemData;

	// Token: 0x0200823C RID: 33340
	private static class EChildType
	{
		// Token: 0x0402A0CF RID: 172239
		public const int SpriteUnFinish = 0;

		// Token: 0x0402A0D0 RID: 172240
		public const int SpriteFinish = 1;

		// Token: 0x0402A0D1 RID: 172241
		public const int TxtTitle = 2;

		// Token: 0x0402A0D2 RID: 172242
		public const int TxtScore = 3;

		// Token: 0x0402A0D3 RID: 172243
		public const int ItemGradeRoot = 4;

		// Token: 0x0402A0D4 RID: 172244
		public const int TextureGrade = 5;
	}
}
