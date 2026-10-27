using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029D4 RID: 10708
public class ShipTowerStageItem : UiPanelBase
{
	// Token: 0x0601630B RID: 90891 RVA: 0x0059CC94 File Offset: 0x0059AE94
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

	// Token: 0x0601630C RID: 90892 RVA: 0x0059CCE8 File Offset: 0x0059AEE8
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

	// Token: 0x0601630D RID: 90893 RVA: 0x0059CDB0 File Offset: 0x0059AFB0
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x0601630E RID: 90894 RVA: 0x0059CDB8 File Offset: 0x0059AFB8
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

	// Token: 0x0400A533 RID: 42291
	protected int ItemDataId;

	// Token: 0x02008FFE RID: 36862
	private static class EChildType
	{
		// Token: 0x0402EA02 RID: 190978
		public const int ItemLocked = 0;

		// Token: 0x0402EA03 RID: 190979
		public const int ItemUnlocked = 1;

		// Token: 0x0402EA04 RID: 190980
		public const int ItemPassed = 2;

		// Token: 0x0402EA05 RID: 190981
		public const int TxtStageOrderId = 3;

		// Token: 0x0402EA06 RID: 190982
		public const int TxtScore = 4;

		// Token: 0x0402EA07 RID: 190983
		public const int TxtTitle = 5;

		// Token: 0x0402EA08 RID: 190984
		public const int SpriteCurrent = 6;

		// Token: 0x0402EA09 RID: 190985
		public const int TexScoreGrade = 7;
	}
}
