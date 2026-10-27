using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200690A RID: 26890
	internal class BossRushRewardTabItem : GridProxyAbstract<BossRushTaskTab>
	{
		// Token: 0x060430DC RID: 274652 RVA: 0x01056512 File Offset: 0x01054712
		[NullableContext(1)]
		public void SetClickCallBack(Action<BossRushRewardTabItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x060430DD RID: 274653 RVA: 0x0105651C File Offset: 0x0105471C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060430DE RID: 274654 RVA: 0x01056604 File Offset: 0x01054804
		public override void Refresh(BossRushTaskTab data, bool isSelected, int gridIndex)
		{
			this.Tab = data;
			if (gridIndex == 0)
			{
				Action<BossRushRewardTabItem> clickCallBack = this.ClickCallBack;
				if (clickCallBack != null)
				{
					clickCallBack(this);
				}
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			else
			{
				this.SetToggleUnCheck();
			}
			BossRushTaskTab bossRushTaskTab = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), bossRushTaskTab.TabTitle, Array.Empty<object>());
			base.SetTextureByPath(bossRushTaskTab.Texture, base.GetTexture(2), null, null);
			this.RefreshRedDot();
		}

		// Token: 0x060430DF RID: 274655 RVA: 0x0105668C File Offset: 0x0105488C
		public void RefreshRedDot()
		{
			bool tabRedDotState = (ActivityModel.Instance.GetActivityById(this.Tab.ActivityId) as BossRushData).GetTabRedDotState(this.Tab.TabId);
			this.SetRedDotActive(tabRedDotState);
		}

		// Token: 0x060430E0 RID: 274656 RVA: 0x010566CB File Offset: 0x010548CB
		private void OnClickToggle(EToggleState state)
		{
			Action<BossRushRewardTabItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this);
		}

		// Token: 0x060430E1 RID: 274657 RVA: 0x010566DE File Offset: 0x010548DE
		public void SetToggleUnCheck()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060430E2 RID: 274658 RVA: 0x010566F1 File Offset: 0x010548F1
		public BossRushTaskTab GetTab()
		{
			return this.Tab;
		}

		// Token: 0x060430E3 RID: 274659 RVA: 0x010566F9 File Offset: 0x010548F9
		public void SetRedDotActive(bool isShow)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x04022E83 RID: 142979
		private BossRushTaskTab Tab;

		// Token: 0x04022E84 RID: 142980
		[Nullable(1)]
		public Action<BossRushRewardTabItem> ClickCallBack;

		// Token: 0x0200CABA RID: 51898
		public class EBossRushRewardTabItemComponent
		{
			// Token: 0x0403D44D RID: 250957
			public const int Toggle = 0;

			// Token: 0x0403D44E RID: 250958
			public const int Text = 1;

			// Token: 0x0403D44F RID: 250959
			public const int Texture = 2;

			// Token: 0x0403D450 RID: 250960
			public const int RedDotItem = 3;
		}
	}
}
