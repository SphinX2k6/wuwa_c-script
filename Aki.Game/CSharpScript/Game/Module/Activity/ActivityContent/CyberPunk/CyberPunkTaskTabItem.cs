using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068BC RID: 26812
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CyberPunkTaskTabItem : GridProxyAbstract<CyberPunkTaskTabData>
	{
		// Token: 0x06042E76 RID: 274038 RVA: 0x0104A150 File Offset: 0x01048350
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTab));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042E77 RID: 274039 RVA: 0x0104A25C File Offset: 0x0104845C
		[NullableContext(1)]
		public override void Refresh(CyberPunkTaskTabData data, bool isSelected, int gridIndex)
		{
			this.TabId = data.TabId;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(isSelected);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(data.TabName, true);
			}
			this.BindRedDot();
		}

		// Token: 0x06042E78 RID: 274040 RVA: 0x0104A2C4 File Offset: 0x010484C4
		private void BindRedDot()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.RedDotCyberPunkTaskTab, item, null, this.TabId);
			}
		}

		// Token: 0x06042E79 RID: 274041 RVA: 0x0104A2F4 File Offset: 0x010484F4
		private void UnBindRedDot()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotCyberPunkTaskTab, item, this.TabId);
			}
		}

		// Token: 0x06042E7A RID: 274042 RVA: 0x0104A322 File Offset: 0x01048522
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06042E7B RID: 274043 RVA: 0x0104A32A File Offset: 0x0104852A
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x06042E7C RID: 274044 RVA: 0x0104A340 File Offset: 0x01048540
		public void SetSelected(bool selected, bool fireEvent = false)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(selected);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			if (fireEvent)
			{
				Action<int, CyberPunkTaskTabItem> onTabClickCallback = this.OnTabClickCallback;
				if (onTabClickCallback == null)
				{
					return;
				}
				onTabClickCallback(this.TabId, this);
			}
		}

		// Token: 0x06042E7D RID: 274045 RVA: 0x0104A396 File Offset: 0x01048596
		public int GetTabId()
		{
			return this.TabId;
		}

		// Token: 0x06042E7E RID: 274046 RVA: 0x0104A3A0 File Offset: 0x010485A0
		public void SetTabIconByTabId(int tabId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_TogTabBg");
			defaultInterpolatedStringHandler.AppendFormatted<int>(tabId);
			string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
			}
		}

		// Token: 0x06042E7F RID: 274047 RVA: 0x0104A400 File Offset: 0x01048600
		private void OnClickTab(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<int, CyberPunkTaskTabItem> onTabClickCallback = this.OnTabClickCallback;
				if (onTabClickCallback == null)
				{
					return;
				}
				onTabClickCallback(this.TabId, this);
			}
		}

		// Token: 0x04022CF6 RID: 142582
		private int TabId;

		// Token: 0x04022CF7 RID: 142583
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, CyberPunkTaskTabItem> OnTabClickCallback;

		// Token: 0x0200CA8D RID: 51853
		private static class ETabComponents
		{
			// Token: 0x0403D393 RID: 250771
			public const int TogTab = 0;

			// Token: 0x0403D394 RID: 250772
			public const int TogBgSprite = 1;

			// Token: 0x0403D395 RID: 250773
			public const int TxtTabName = 2;

			// Token: 0x0403D396 RID: 250774
			public const int PitchState = 3;

			// Token: 0x0403D397 RID: 250775
			public const int Red = 4;
		}
	}
}
