using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F40 RID: 8000
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerReviewItem : GridProxyAbstract<ShipTowerReviewItemData>
{
	// Token: 0x06013C9F RID: 81055 RVA: 0x005C5F28 File Offset: 0x005C4128
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

	// Token: 0x06013CA0 RID: 81056 RVA: 0x005C5FC4 File Offset: 0x005C41C4
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerReviewItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerReviewItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CA1 RID: 81057 RVA: 0x005C6007 File Offset: 0x005C4207
	public override void Refresh(ShipTowerReviewItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x06013CA2 RID: 81058 RVA: 0x005C6010 File Offset: 0x005C4210
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

	// Token: 0x0400A8FB RID: 43259
	private ShipTowerReviewItemData ItemData;

	// Token: 0x0400A8FC RID: 43260
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerReviewItemData> ClickCallBack;

	// Token: 0x0200822C RID: 33324
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A089 RID: 172169
		public const int TxtName = 0;

		// Token: 0x0402A08A RID: 172170
		public const int TxtScore = 1;

		// Token: 0x0402A08B RID: 172171
		public const int TextureGrade = 2;

		// Token: 0x0402A08C RID: 172172
		public const int LevelNumText = 3;

		// Token: 0x0402A08D RID: 172173
		public const int QuickPassItem = 4;

		// Token: 0x0402A08E RID: 172174
		public const int SpriteEndless = 5;
	}
}
