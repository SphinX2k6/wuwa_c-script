using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005752 RID: 22354
	internal class DangoBrawlHandBookFilterSortSelectItem : GridProxyAbstract<int>
	{
		// Token: 0x060371E5 RID: 225765 RVA: 0x00F61B6C File Offset: 0x00F5FD6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060371E6 RID: 225766 RVA: 0x00F61C54 File Offset: 0x00F5FE54
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ItemId = data;
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(this.ItemId);
			if (occupationConfigById != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), occupationConfigById.Value.Name, Array.Empty<object>());
				base.SetTextureByPath(occupationConfigById.Value.Icon, base.GetTexture(2), null, null);
			}
			Func<int, bool> isSelectedCheck = this.IsSelectedCheck;
			EToggleState state = (isSelectedCheck != null && isSelectedCheck(this.ItemId)) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x060371E7 RID: 225767 RVA: 0x00F61D01 File Offset: 0x00F5FF01
		private void OnToggleClick(EToggleState state)
		{
			Action<int> onClickSortSelect = this.OnClickSortSelect;
			if (onClickSortSelect == null)
			{
				return;
			}
			onClickSortSelect(this.ItemId);
		}

		// Token: 0x0401D22A RID: 119338
		[Nullable(2)]
		public Action<int> OnClickSortSelect;

		// Token: 0x0401D22B RID: 119339
		[Nullable(2)]
		public Func<int, bool> IsSelectedCheck;

		// Token: 0x0401D22C RID: 119340
		private int ItemId = -1;

		// Token: 0x0200B340 RID: 45888
		private enum EItemComponent
		{
			// Token: 0x0403763B RID: 226875
			TxtTog,
			// Token: 0x0403763C RID: 226876
			TogSort,
			// Token: 0x0403763D RID: 226877
			TexBuff,
			// Token: 0x0403763E RID: 226878
			SprSuggest
		}
	}
}
