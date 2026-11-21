using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EFC RID: 20220
	public class ActivityInstanceEntranceMonsterTipsItem : UiPanelBase
	{
		// Token: 0x06032D14 RID: 208148 RVA: 0x00E4421C File Offset: 0x00E4241C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnMonster));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032D15 RID: 208149 RVA: 0x00E442C4 File Offset: 0x00E424C4
		[NullableContext(1)]
		public void RefreshView(ActivityInstanceEntranceData data)
		{
			this.CurrentData = data;
			int selectDataIndex = this.CurrentData.GetActivityEntranceSelectItemData().GetCurrentSelectData().GetSelectDataIndex();
			ActivityEntranceMonsterPreviewData activityEntranceMonsterPreviewData = this.CurrentData.GetActivityEntranceMonsterPreviewData();
			string monsterTips = activityEntranceMonsterPreviewData.GetMonsterTips(selectDataIndex);
			bool monsterPreviewState = activityEntranceMonsterPreviewData.GetMonsterPreviewState(selectDataIndex);
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(monsterTips, true);
			}
			UUIButtonComponent button = base.GetButton(1);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(monsterPreviewState);
		}

		// Token: 0x06032D16 RID: 208150 RVA: 0x00E4433C File Offset: 0x00E4253C
		private void OnClickBtnMonster()
		{
			int selectDataIndex = this.CurrentData.GetActivityEntranceSelectItemData().GetCurrentSelectData().GetSelectDataIndex();
			Action<int> previewCallBack = this.CurrentData.GetActivityEntranceMonsterPreviewData().GetPreviewCallBack();
			if (previewCallBack != null)
			{
				previewCallBack(selectDataIndex);
			}
		}

		// Token: 0x0401AFA3 RID: 110499
		[Nullable(2)]
		private ActivityInstanceEntranceData CurrentData;

		// Token: 0x0200AC57 RID: 44119
		private enum EComponent
		{
			// Token: 0x04035510 RID: 218384
			BuffText,
			// Token: 0x04035511 RID: 218385
			BtnMonsterPreView
		}
	}
}
