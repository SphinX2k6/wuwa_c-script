using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02005897 RID: 22679
	public class InstanceDungeonBuffItem : UiPanelBase
	{
		// Token: 0x06039B52 RID: 236370 RVA: 0x00DB6990 File Offset: 0x00DB4B90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnMonster));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039B53 RID: 236371 RVA: 0x00DB6A58 File Offset: 0x00DB4C58
		[NullableContext(2)]
		public void RefreshItem(string buffText, bool showMonsterPreview, InstanceDungeonBuffItem.EBuffInfoType buffInfoType = InstanceDungeonBuffItem.EBuffInfoType.Buff)
		{
			this.ItemDataHandle = new InstanceDungeonBuffItemData
			{
				BuffText = buffText,
				ShowMonsterPreview = showMonsterPreview,
				BuffInfoType = buffInfoType
			};
			InstanceDungeonBuffItem.EBuffInfoType buffInfoType2 = this.ItemDataHandle.BuffInfoType;
			if (buffInfoType2 != InstanceDungeonBuffItem.EBuffInfoType.Buff)
			{
				if (buffInfoType2 == InstanceDungeonBuffItem.EBuffInfoType.Resistance)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WeeklyBossInfo_OuterTitle", Array.Empty<object>());
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PrefabTextItem_3585581324_Text", Array.Empty<object>());
			}
			base.GetButton(1).RootUIComp.Get().SetUIActive(showMonsterPreview);
			if (string.IsNullOrEmpty(buffText))
			{
				base.GetText(0).SetUIActive(false);
				return;
			}
			base.GetText(0).SetUIActive(true);
			base.GetText(0).ShowTextNew(buffText);
		}

		// Token: 0x06039B54 RID: 236372 RVA: 0x00DB6B1C File Offset: 0x00DB4D1C
		private void OnClickBtnMonster()
		{
			int selectInstanceId = InstanceDungeonEntranceModel.Instance.SelectInstanceId;
			InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam instanceDungeonMonsterViewOpenParam = new InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam();
			instanceDungeonMonsterViewOpenParam.InstanceId = selectInstanceId;
			InstanceDungeonBuffItemData itemDataHandle = this.ItemDataHandle;
			instanceDungeonMonsterViewOpenParam.InfoType = new InstanceDungeonBuffItem.EBuffInfoType?((itemDataHandle != null) ? itemDataHandle.BuffInfoType : InstanceDungeonBuffItem.EBuffInfoType.Buff);
			InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam param = instanceDungeonMonsterViewOpenParam;
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, param, null);
		}

		// Token: 0x0401E24B RID: 123467
		[Nullable(2)]
		private InstanceDungeonBuffItemData ItemDataHandle;

		// Token: 0x0200BAF0 RID: 47856
		public enum EBuffInfoType
		{
			// Token: 0x040387BF RID: 231359
			Buff,
			// Token: 0x040387C0 RID: 231360
			Resistance
		}

		// Token: 0x0200BAF1 RID: 47857
		private enum EChildType
		{
			// Token: 0x040387C2 RID: 231362
			BuffText,
			// Token: 0x040387C3 RID: 231363
			BtnMonsterPreView,
			// Token: 0x040387C4 RID: 231364
			TitleText
		}
	}
}
