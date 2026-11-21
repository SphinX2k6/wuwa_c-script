using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004765 RID: 18277
	public class KurotatoCollectBtn : UiPanelBase
	{
		// Token: 0x0602DE00 RID: 187904 RVA: 0x00CD72C8 File Offset: 0x00CD54C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnSelfBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DE01 RID: 187905 RVA: 0x00CD7390 File Offset: 0x00CD5590
		public void RefreshView()
		{
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			ValueTuple<int, int> roleUnlockNum = activityData.GetRoleUnlockNum();
			int item = roleUnlockNum.Item1;
			int item2 = roleUnlockNum.Item2;
			ValueTuple<int, int> itemUnlockNum = activityData.GetItemUnlockNum();
			int item3 = itemUnlockNum.Item1;
			int item4 = itemUnlockNum.Item2;
			ValueTuple<int, int> weaponUnlockNum = activityData.GetWeaponUnlockNum();
			int item5 = weaponUnlockNum.Item1;
			int item6 = weaponUnlockNum.Item2;
			int num = item + item3 + item5;
			int num2 = item2 + item4 + item6;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(num.ToString() + "/" + num2.ToString(), true);
			}
			bool uiactive = activityData.IsRoleHasRedDot() || activityData.IsKurotatoItemHasRedDot() || activityData.IsKurotatoWeaponHasRedDot();
			base.GetItem(2).SetUIActive(uiactive);
		}

		// Token: 0x0602DE02 RID: 187906 RVA: 0x00CD7445 File Offset: 0x00CD5645
		private void OnSelfBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x04018817 RID: 100375
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200A3CB RID: 41931
		private enum ECollectBtnComponents
		{
			// Token: 0x04032C59 RID: 207961
			BtnSelf,
			// Token: 0x04032C5A RID: 207962
			TextNum,
			// Token: 0x04032C5B RID: 207963
			RedDot
		}
	}
}
