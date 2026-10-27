using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200616B RID: 24939
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeEntranceButton : ButtonItem
	{
		// Token: 0x0603F0A8 RID: 258216 RVA: 0x00F3BC7B File Offset: 0x00F39E7B
		public RoverlikeEntranceButton(UUIItem uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x0603F0A9 RID: 258217 RVA: 0x00F3BC84 File Offset: 0x00F39E84
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIText)));
		}

		// Token: 0x0603F0AA RID: 258218 RVA: 0x00F3BCE8 File Offset: 0x00F39EE8
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

		// Token: 0x0603F0AB RID: 258219 RVA: 0x00F3BDD8 File Offset: 0x00F39FD8
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

		// Token: 0x0200C3D1 RID: 50129
		[NullableContext(0)]
		private class EEntranceButtonDefine
		{
			// Token: 0x0403B16E RID: 242030
			public const int RedDotItem = 2;

			// Token: 0x0403B16F RID: 242031
			public const int PnlSaveInfo = 3;

			// Token: 0x0403B170 RID: 242032
			public const int TxtSaveInfo = 4;
		}
	}
}
