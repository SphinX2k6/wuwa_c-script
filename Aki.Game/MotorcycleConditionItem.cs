using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001718 RID: 5912
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleConditionItem : GridProxyAbstract<IMotorLevelConditionData>
{
	// Token: 0x0600E5F9 RID: 58873 RVA: 0x0043707C File Offset: 0x0043527C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.ButtonJumpClick)),
			new ValueTuple<int, Delegate>(8, new Action(this.ButtonJumpClick))
		};
	}

	// Token: 0x0600E5FA RID: 58874 RVA: 0x00437198 File Offset: 0x00435398
	[NullableContext(1)]
	public override void Refresh(IMotorLevelConditionData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = data.AccessType == 1;
		bool flag2 = data.AccessType == 3;
		UUIText text = base.GetText(4);
		if (!StringUtils.IsEmpty(data.ConditionTextId))
		{
			text.ShowTextNew(data.ConditionTextId);
		}
		else
		{
			text.SetText("", true);
		}
		base.GetItem(1).SetUIActive(flag);
		base.GetItem(2).SetUIActive(!flag);
		base.GetItem(3).SetUIActive(true);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		base.GetButton(5).RootUIComp.Get().SetUIActive(!flag2);
		base.GetButton(8).RootUIComp.Get().SetUIActive(flag2);
	}

	// Token: 0x0600E5FB RID: 58875 RVA: 0x0043726C File Offset: 0x0043546C
	private void ButtonJumpClick()
	{
		IMotorLevelConditionData data = this.Data;
		bool flag;
		if (data == null)
		{
			flag = false;
		}
		else
		{
			int accessId = data.AccessId;
			flag = true;
		}
		if (!flag || this.Data.AccessId <= 0)
		{
			IMotorLevelConditionData data2 = this.Data;
			bool flag2;
			if (data2 == null)
			{
				flag2 = false;
			}
			else
			{
				int recommendQuestId = data2.RecommendQuestId;
				flag2 = true;
			}
			if (flag2 && this.Data.RecommendQuestId > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, this.Data.RecommendQuestId, null);
				UiManager.Instance.CloseView(EUiViewName.MotorcycleConditionView, null);
			}
			return;
		}
		if (this.Data.AccessType == 3)
		{
			HelpController.Instance.OpenHelpById(this.Data.AccessId);
			return;
		}
		SkipTaskManager.RunByConfigId(this.Data.AccessId, null);
		UiManager.Instance.CloseView(EUiViewName.MotorcycleConditionView, null);
	}

	// Token: 0x04008367 RID: 33639
	[Nullable(2)]
	private IMotorLevelConditionData Data;

	// Token: 0x020078F1 RID: 30961
	private class EItemComponents
	{
		// Token: 0x04027345 RID: 160581
		public const int PanelDone = 0;

		// Token: 0x04027346 RID: 160582
		public const int PanelType1 = 1;

		// Token: 0x04027347 RID: 160583
		public const int PanelType2 = 2;

		// Token: 0x04027348 RID: 160584
		public const int SpriteGoing = 3;

		// Token: 0x04027349 RID: 160585
		public const int Txt = 4;

		// Token: 0x0402734A RID: 160586
		public const int ButtonType1 = 5;

		// Token: 0x0402734B RID: 160587
		public const int SpriteDone = 6;

		// Token: 0x0402734C RID: 160588
		public const int TxtGoing = 7;

		// Token: 0x0402734D RID: 160589
		public const int ButtonType2 = 8;
	}
}
