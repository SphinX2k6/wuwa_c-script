using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x0200674B RID: 26443
	internal class DirectTrainDetailBgPanel : UiPanelBase
	{
		// Token: 0x06041FF1 RID: 270321 RVA: 0x010020E8 File Offset: 0x010002E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041FF2 RID: 270322 RVA: 0x01002154 File Offset: 0x01000354
		protected override void OnStart()
		{
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(playerGender == EPlayerGender.Male);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(playerGender == EPlayerGender.Female);
		}
	}
}
