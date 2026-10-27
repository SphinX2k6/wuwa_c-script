using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x0200578E RID: 22414
	public class KurotatoCollectBtn : UiPanelBase
	{
		// Token: 0x06038EF0 RID: 233200 RVA: 0x00D8856C File Offset: 0x00D8676C
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

		// Token: 0x06038EF1 RID: 233201 RVA: 0x00D88634 File Offset: 0x00D86834
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

		// Token: 0x06038EF2 RID: 233202 RVA: 0x00D886E9 File Offset: 0x00D868E9
		private void OnSelfBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401DD81 RID: 122241
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200B9B5 RID: 47541
		private enum ECollectBtnComponents
		{
			// Token: 0x04038268 RID: 229992
			BtnSelf,
			// Token: 0x04038269 RID: 229993
			TextNum,
			// Token: 0x0403826A RID: 229994
			RedDot
		}
	}
}
