using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006626 RID: 26150
	public class RoleTechToggle : UiPanelBase
	{
		// Token: 0x060418F7 RID: 268535 RVA: 0x00FE634C File Offset: 0x00FE454C
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

		// Token: 0x060418F8 RID: 268536 RVA: 0x00FE63F2 File Offset: 0x00FE45F2
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(base.GetExtendToggle(0));
		}

		// Token: 0x060418F9 RID: 268537 RVA: 0x00FE640C File Offset: 0x00FE460C
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

		// Token: 0x060418FA RID: 268538 RVA: 0x00FE6477 File Offset: 0x00FE4677
		public void SelectToggle()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x040221C5 RID: 139717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200C83F RID: 51263
		private class ERoleTechToggle
		{
			// Token: 0x0403C7D8 RID: 247768
			public const int Toggle = 0;

			// Token: 0x0403C7D9 RID: 247769
			public const int Sprite = 1;
		}
	}
}
