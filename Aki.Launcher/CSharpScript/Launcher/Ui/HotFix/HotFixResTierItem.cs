using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E2 RID: 226
	public class HotFixResTierItem : LaunchComponentsAction
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x0003B7A8 File Offset: 0x000399A8
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(delegate(EToggleState state)
			{
				if (state == EToggleState.ETT_Checked)
				{
					Action<ETier, UUIExtendToggle> onClickCallback = this.OnClickCallback;
					if (onClickCallback == null)
					{
						return;
					}
					onClickCallback(this.Tier, base.GetExtendToggle(0));
				}
			});
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0003B7CC File Offset: 0x000399CC
		protected override void OnBeforeDestroy()
		{
			this.OnClickCallback = null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0003B7D5 File Offset: 0x000399D5
		public void RefreshItem(ETier tier)
		{
			this.Tier = tier;
			this.SetText(HotFixManager.GetResourceQualityTierTextId(tier).ToEnumString(), Array.Empty<string>());
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0003B7F4 File Offset: 0x000399F4
		[NullableContext(1)]
		public void SetText([Nullable(2)] string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(base.GetText(1), tableId, args);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0003B804 File Offset: 0x00039A04
		public void SetToggleState(bool isOn)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0003B822 File Offset: 0x00039A22
		public void SetCurrentTag(bool showTag, bool isRecommend)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(showTag);
			}
			if (!showTag)
			{
				return;
			}
			HotFixManager.SetLocalText(base.GetText(3), isRecommend ? "ResourceQualityTier_Recommend" : "ResourceQualityTier_Current", Array.Empty<string>());
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0003B85B File Offset: 0x00039A5B
		[NullableContext(1)]
		public void BindClickCallback(Action<ETier, UUIExtendToggle> callback)
		{
			this.OnClickCallback = callback;
		}

		// Token: 0x0400046A RID: 1130
		private ETier Tier;

		// Token: 0x0400046B RID: 1131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ETier, UUIExtendToggle> OnClickCallback;

		// Token: 0x0200037D RID: 893
		private class EComponents
		{
			// Token: 0x040011EE RID: 4590
			public const int Toggle = 0;

			// Token: 0x040011EF RID: 4591
			public const int Text = 1;

			// Token: 0x040011F0 RID: 4592
			public const int CurrentTagItem = 2;

			// Token: 0x040011F1 RID: 4593
			public const int CurrentTagText = 3;
		}
	}
}
