using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4F RID: 8015
public class ShipTowerStageItem : UiPanelBase
{
	// Token: 0x06013D11 RID: 81169 RVA: 0x005C7C4C File Offset: 0x005C5E4C
	[NullableContext(1)]
	public UniTask Init(UUIItem item, int data)
	{
		ShipTowerStageItem.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.data = data;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerStageItem.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06013D12 RID: 81170 RVA: 0x005C7CA0 File Offset: 0x005C5EA0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUITexture))
		};
	}

	// Token: 0x06013D13 RID: 81171 RVA: 0x005C7D68 File Offset: 0x005C5F68
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06013D14 RID: 81172 RVA: 0x005C7D70 File Offset: 0x005C5F70
	public void UpdateData()
	{
		ShipTowerStageData stageDataById = ShipTowerModel.Instance.GetStageDataById(this.ItemDataId);
		if (stageDataById == null)
		{
			return;
		}
		bool flag = stageDataById.IsUnLocked();
		bool uiactive = stageDataById.IsPassed();
		bool uiactive2 = stageDataById.IsCurrent();
		base.GetItem(1).SetUIActive(flag);
		base.GetItem(0).SetUIActive(!flag);
		base.GetItem(2).SetUIActive(uiactive);
		base.GetText(3).SetText(stageDataById.OrderIndex.ToString(), true);
		base.GetText(5).ShowTextNew(stageDataById.TitleKey);
		base.GetSprite(6).SetUIActive(uiactive2);
		string stageGradeResIdByScore = stageDataById.GetStageGradeResIdByScore(stageDataById.CurrentScore);
		bool flag2 = stageGradeResIdByScore != null;
		UUITexture texture = base.GetTexture(7);
		if (texture != null)
		{
			texture.SetUIActive(flag2);
		}
		if (flag2 && stageGradeResIdByScore != null)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(stageGradeResIdByScore);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}
		bool flag3 = stageDataById.CurrentScore > 0;
		UUIText text = base.GetText(4);
		text.SetUIActive(flag3);
		if (flag3)
		{
			string textStringId = "GhostShipPoint_Text";
			LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(stageDataById.CurrentScore.ToString()));
		}
	}

	// Token: 0x0400A91D RID: 43293
	protected int ItemDataId;

	// Token: 0x02008245 RID: 33349
	private static class EChildType
	{
		// Token: 0x0402A0FA RID: 172282
		public const int ItemLocked = 0;

		// Token: 0x0402A0FB RID: 172283
		public const int ItemUnlocked = 1;

		// Token: 0x0402A0FC RID: 172284
		public const int ItemPassed = 2;

		// Token: 0x0402A0FD RID: 172285
		public const int TxtStageOrderId = 3;

		// Token: 0x0402A0FE RID: 172286
		public const int TxtScore = 4;

		// Token: 0x0402A0FF RID: 172287
		public const int TxtTitle = 5;

		// Token: 0x0402A100 RID: 172288
		public const int SpriteCurrent = 6;

		// Token: 0x0402A101 RID: 172289
		public const int TexScoreGrade = 7;
	}
}
