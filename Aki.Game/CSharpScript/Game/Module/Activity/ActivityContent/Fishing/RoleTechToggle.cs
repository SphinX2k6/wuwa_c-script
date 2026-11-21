using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055A4 RID: 21924
	public class RoleTechToggle : UiPanelBase
	{
		// Token: 0x060365BC RID: 222652 RVA: 0x00F2D400 File Offset: 0x00F2B600
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060365BD RID: 222653 RVA: 0x00F2D4A6 File Offset: 0x00F2B6A6
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GetExtendToggle(0));
		}

		// Token: 0x060365BE RID: 222654 RVA: 0x00F2D4C0 File Offset: 0x00F2B6C0
		public void RefreshItem(int roleType)
		{
			string resourceId;
			if (roleType != 4)
			{
				if (roleType != 5)
				{
					resourceId = "SP_RoleFeibi";
				}
				else
				{
					resourceId = "SP_RoleFeibi";
				}
			}
			else
			{
				resourceId = ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "SP_RoleFemale" : "SP_RoleMale");
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x060365BF RID: 222655 RVA: 0x00F2D52B File Offset: 0x00F2B72B
		public void SelectToggle()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x0401CAF6 RID: 117494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200B221 RID: 45601
		private class ERoleTechToggle
		{
			// Token: 0x0403711D RID: 225565
			public const int Toggle = 0;

			// Token: 0x0403711E RID: 225566
			public const int Sprite = 1;
		}
	}
}
