using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x0200580C RID: 22540
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CyberPunkTaskTabItem : GridProxyAbstract<CyberPunkTaskTabData>
	{
		// Token: 0x060379CE RID: 227790 RVA: 0x00F8B778 File Offset: 0x00F89978
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

		// Token: 0x060379CF RID: 227791 RVA: 0x00F8B884 File Offset: 0x00F89A84
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

		// Token: 0x060379D0 RID: 227792 RVA: 0x00F8B8EC File Offset: 0x00F89AEC
		private void BindRedDot()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.RedDotCyberPunkTaskTab, item, null, this.TabId);
			}
		}

		// Token: 0x060379D1 RID: 227793 RVA: 0x00F8B91C File Offset: 0x00F89B1C
		private void UnBindRedDot()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotCyberPunkTaskTab, item, this.TabId);
			}
		}

		// Token: 0x060379D2 RID: 227794 RVA: 0x00F8B94A File Offset: 0x00F89B4A
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x060379D3 RID: 227795 RVA: 0x00F8B952 File Offset: 0x00F89B52
		public void SetRedDotVisible(bool visible)
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(visible);
		}

		// Token: 0x060379D4 RID: 227796 RVA: 0x00F8B968 File Offset: 0x00F89B68
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

		// Token: 0x060379D5 RID: 227797 RVA: 0x00F8B9BE File Offset: 0x00F89BBE
		public int GetTabId()
		{
			return this.TabId;
		}

		// Token: 0x060379D6 RID: 227798 RVA: 0x00F8B9C8 File Offset: 0x00F89BC8
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

		// Token: 0x060379D7 RID: 227799 RVA: 0x00F8BA28 File Offset: 0x00F89C28
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

		// Token: 0x0401D552 RID: 120146
		private int TabId;

		// Token: 0x0401D553 RID: 120147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, CyberPunkTaskTabItem> OnTabClickCallback;

		// Token: 0x0200B455 RID: 46165
		private static class ETabComponents
		{
			// Token: 0x04037C6D RID: 228461
			public const int TogTab = 0;

			// Token: 0x04037C6E RID: 228462
			public const int TogBgSprite = 1;

			// Token: 0x04037C6F RID: 228463
			public const int TxtTabName = 2;

			// Token: 0x04037C70 RID: 228464
			public const int PitchState = 3;

			// Token: 0x04037C71 RID: 228465
			public const int Red = 4;
		}
	}
}
