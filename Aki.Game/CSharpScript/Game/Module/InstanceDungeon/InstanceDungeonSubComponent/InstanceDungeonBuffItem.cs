using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200486F RID: 18543
	public class InstanceDungeonBuffItem : UiPanelBase
	{
		// Token: 0x0602EA75 RID: 191093 RVA: 0x00D058A8 File Offset: 0x00D03AA8
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

		// Token: 0x0602EA76 RID: 191094 RVA: 0x00D05970 File Offset: 0x00D03B70
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

		// Token: 0x0602EA77 RID: 191095 RVA: 0x00D05A34 File Offset: 0x00D03C34
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

		// Token: 0x04018CE8 RID: 101608
		[Nullable(2)]
		private InstanceDungeonBuffItemData ItemDataHandle;

		// Token: 0x0200A509 RID: 42249
		public enum EBuffInfoType
		{
			// Token: 0x040331C0 RID: 209344
			Buff,
			// Token: 0x040331C1 RID: 209345
			Resistance
		}

		// Token: 0x0200A50A RID: 42250
		private enum EChildType
		{
			// Token: 0x040331C3 RID: 209347
			BuffText,
			// Token: 0x040331C4 RID: 209348
			BtnMonsterPreView,
			// Token: 0x040331C5 RID: 209349
			TitleText
		}
	}
}
