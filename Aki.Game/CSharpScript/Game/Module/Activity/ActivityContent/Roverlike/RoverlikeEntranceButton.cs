using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E9 RID: 20713
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeEntranceButton : ButtonItem
	{
		// Token: 0x06033D68 RID: 212328 RVA: 0x00E82B4F File Offset: 0x00E80D4F
		public RoverlikeEntranceButton(UUIItem uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x06033D69 RID: 212329 RVA: 0x00E82B58 File Offset: 0x00E80D58
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIText)));
		}

		// Token: 0x06033D6A RID: 212330 RVA: 0x00E82BBC File Offset: 0x00E80DBC
		public void RefreshSaveInfo(RoverlikeActivityData activityData)
		{
			UUIItem item = base.GetItem(3);
			bool flag = activityData != null && activityData.HasSaveProgress();
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			UUIText text = base.GetText(4);
			RoverRogueHistoryInsInfo historyInsInfo = activityData.HistoryInsInfo;
			RoverRogueIns? roverRogueIns;
			string text2 = (RoverlikeConfig.Instance.GetInsConfig(historyInsInfo.CurInsId) != null) ? roverRogueIns.GetValueOrDefault().Name : null;
			string text3 = (!string.IsNullOrEmpty(text2)) ? (ConfigMultiTextLang.GetLocalTextNew(text2, null) ?? "") : "";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(historyInsInfo.CurLayer);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(historyInsInfo.TotalLayer);
			string text4 = defaultInterpolatedStringHandler.ToStringAndClear();
			LguiUtil.Instance.SetLocalTextNew(text, "RoverRogue_GameProcessShow", new <>z__ReadOnlyArray<object>(new object[]
			{
				text3,
				text4
			}));
		}

		// Token: 0x06033D6B RID: 212331 RVA: 0x00E82CAC File Offset: 0x00E80EAC
		public void RefreshNewLevelUnlockRedDot(RoverlikeActivityData activityData)
		{
			bool uiactive = activityData != null && activityData.HasNewLevelUnlockRedDot();
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0200ADB8 RID: 44472
		[NullableContext(0)]
		private class EEntranceButtonDefine
		{
			// Token: 0x04035ACF RID: 219855
			public const int RedDotItem = 2;

			// Token: 0x04035AD0 RID: 219856
			public const int PnlSaveInfo = 3;

			// Token: 0x04035AD1 RID: 219857
			public const int TxtSaveInfo = 4;
		}
	}
}
