using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E5 RID: 229
	public class HotFixResTierItem : LaunchComponentsAction
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x0003D394 File Offset: 0x0003B594
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

		// Token: 0x0600078D RID: 1933 RVA: 0x0003D3B8 File Offset: 0x0003B5B8
		protected override void OnBeforeDestroy()
		{
			this.OnClickCallback = null;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0003D3C1 File Offset: 0x0003B5C1
		public void RefreshItem(ETier tier)
		{
			this.Tier = tier;
			this.SetText(HotFixManager.GetResourceQualityTierTextId(tier).ToEnumString(), Array.Empty<string>());
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0003D3E0 File Offset: 0x0003B5E0
		[NullableContext(1)]
		public void SetText([Nullable(2)] string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(base.GetText(1), tableId, args);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
		public void SetToggleState(bool isOn)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(isOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0003D40E File Offset: 0x0003B60E
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

		// Token: 0x06000792 RID: 1938 RVA: 0x0003D447 File Offset: 0x0003B647
		[NullableContext(1)]
		public void BindClickCallback(Action<ETier, UUIExtendToggle> callback)
		{
			this.OnClickCallback = callback;
		}

		// Token: 0x04000499 RID: 1177
		private ETier Tier;

		// Token: 0x0400049A RID: 1178
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ETier, UUIExtendToggle> OnClickCallback;

		// Token: 0x02000388 RID: 904
		private class EComponents
		{
			// Token: 0x04001253 RID: 4691
			public const int Toggle = 0;

			// Token: 0x04001254 RID: 4692
			public const int Text = 1;

			// Token: 0x04001255 RID: 4693
			public const int CurrentTagItem = 2;

			// Token: 0x04001256 RID: 4694
			public const int CurrentTagText = 3;
		}
	}
}
