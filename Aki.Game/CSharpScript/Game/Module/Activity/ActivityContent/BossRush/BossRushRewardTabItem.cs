using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200585A RID: 22618
	internal class BossRushRewardTabItem : GridProxyAbstract<BossRushTaskTab>
	{
		// Token: 0x06037C34 RID: 228404 RVA: 0x00F97B46 File Offset: 0x00F95D46
		[NullableContext(1)]
		public void SetClickCallBack(Action<BossRushRewardTabItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x06037C35 RID: 228405 RVA: 0x00F97B50 File Offset: 0x00F95D50
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

		// Token: 0x06037C36 RID: 228406 RVA: 0x00F97C38 File Offset: 0x00F95E38
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

		// Token: 0x06037C37 RID: 228407 RVA: 0x00F97CC0 File Offset: 0x00F95EC0
		public void RefreshRedDot()
		{
			bool tabRedDotState = (ActivityModel.Instance.GetActivityById(this.Tab.ActivityId) as BossRushData).GetTabRedDotState(this.Tab.TabId);
			this.SetRedDotActive(tabRedDotState);
		}

		// Token: 0x06037C38 RID: 228408 RVA: 0x00F97CFF File Offset: 0x00F95EFF
		private void OnClickToggle(EToggleState state)
		{
			Action<BossRushRewardTabItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack(this);
		}

		// Token: 0x06037C39 RID: 228409 RVA: 0x00F97D12 File Offset: 0x00F95F12
		public void SetToggleUnCheck()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06037C3A RID: 228410 RVA: 0x00F97D25 File Offset: 0x00F95F25
		public BossRushTaskTab GetTab()
		{
			return this.Tab;
		}

		// Token: 0x06037C3B RID: 228411 RVA: 0x00F97D2D File Offset: 0x00F95F2D
		public void SetRedDotActive(bool isShow)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x0401D6DF RID: 120543
		private BossRushTaskTab Tab;

		// Token: 0x0401D6E0 RID: 120544
		[Nullable(1)]
		public Action<BossRushRewardTabItem> ClickCallBack;

		// Token: 0x0200B482 RID: 46210
		public class EBossRushRewardTabItemComponent
		{
			// Token: 0x04037D27 RID: 228647
			public const int Toggle = 0;

			// Token: 0x04037D28 RID: 228648
			public const int Text = 1;

			// Token: 0x04037D29 RID: 228649
			public const int Texture = 2;

			// Token: 0x04037D2A RID: 228650
			public const int RedDotItem = 3;
		}
	}
}
