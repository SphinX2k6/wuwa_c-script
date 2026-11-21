using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x0200569B RID: 22171
	internal class DirectTrainDetailBgPanel : UiPanelBase
	{
		// Token: 0x06036B40 RID: 224064 RVA: 0x00F434DC File Offset: 0x00F416DC
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

		// Token: 0x06036B41 RID: 224065 RVA: 0x00F43548 File Offset: 0x00F41748
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
