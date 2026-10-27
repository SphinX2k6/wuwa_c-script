using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029C5 RID: 10693
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerReviewItem : GridProxyAbstract<ShipTowerReviewItemData>
{
	// Token: 0x06016299 RID: 90777 RVA: 0x0059AF70 File Offset: 0x00599170
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite))
		};
	}

	// Token: 0x0601629A RID: 90778 RVA: 0x0059B00C File Offset: 0x0059920C
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerReviewItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerReviewItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601629B RID: 90779 RVA: 0x0059B04F File Offset: 0x0059924F
	public override void Refresh(ShipTowerReviewItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0601629C RID: 90780 RVA: 0x0059B058 File Offset: 0x00599258
	public void Refresh(ShipTowerReviewItemData data)
	{
		this.ItemData = data;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(this.ItemData.Title, true);
		}
		string textStringId = "GhostShipPointNoColor_Text";
		UUIText text2 = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text2, textStringId, new <>z__ReadOnlySingleElementList<object>(this.ItemData.Score.ToString()));
		bool flag = this.ItemData.Grade != null;
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		if (flag && this.ItemData.Grade != null)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.ItemData.Grade);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(this.ItemData.IsQuickPass);
		}
		bool stageIsEndlessById = ShipTowerModel.Instance.GetStageIsEndlessById(this.ItemData.StageId);
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(stageIsEndlessById);
		}
		UUIText text3 = base.GetText(3);
		if (text3 != null)
		{
			text3.SetUIActive(!stageIsEndlessById);
		}
		if (!stageIsEndlessById)
		{
			int stageOrderIndexById = ShipTowerModel.Instance.GetStageOrderIndexById(this.ItemData.StageId);
			UUIText text4 = base.GetText(3);
			if (text4 == null)
			{
				return;
			}
			text4.SetText(stageOrderIndexById.ToString(), true);
		}
	}

	// Token: 0x0400A511 RID: 42257
	private ShipTowerReviewItemData ItemData;

	// Token: 0x0400A512 RID: 42258
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerReviewItemData> ClickCallBack;

	// Token: 0x02008FE5 RID: 36837
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E991 RID: 190865
		public const int TxtName = 0;

		// Token: 0x0402E992 RID: 190866
		public const int TxtScore = 1;

		// Token: 0x0402E993 RID: 190867
		public const int TextureGrade = 2;

		// Token: 0x0402E994 RID: 190868
		public const int LevelNumText = 3;

		// Token: 0x0402E995 RID: 190869
		public const int QuickPassItem = 4;

		// Token: 0x0402E996 RID: 190870
		public const int SpriteEndless = 5;
	}
}
