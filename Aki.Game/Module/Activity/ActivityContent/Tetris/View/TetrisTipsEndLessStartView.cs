using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FEB RID: 12267
	public class TetrisTipsEndLessStartView : TetrisTipsBaseView
	{
		// Token: 0x0601D1C3 RID: 119235 RVA: 0x008E5A10 File Offset: 0x008E3C10
		[NullableContext(1)]
		public TetrisTipsEndLessStartView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D1C4 RID: 119236 RVA: 0x008E5A1C File Offset: 0x008E3C1C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D1C5 RID: 119237 RVA: 0x008E5A64 File Offset: 0x008E3C64
		protected override void OnStart()
		{
			object openParam = this.OpenParam;
			if (openParam is bool)
			{
				bool isActivityEndlessLevel = (bool)openParam;
				this.IsActivityEndlessLevel = isActivityEndlessLevel;
			}
		}

		// Token: 0x0601D1C6 RID: 119238 RVA: 0x008E5A8E File Offset: 0x008E3C8E
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0601D1C7 RID: 119239 RVA: 0x008E5A98 File Offset: 0x008E3C98
		private void Refresh()
		{
			if (this.IsActivityEndlessLevel)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Tetristext_16", Array.Empty<object>());
				return;
			}
			AchievementData achievementData = AchievementModel.Instance.GetAchievementData(101119);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), (achievementData == null || achievementData.GetFinishState() > EAchievementStateEnum.UnFinished) ? "Tetristext_16" : "Tetristext_15", Array.Empty<object>());
		}

		// Token: 0x0400F54E RID: 62798
		private const int ACHIEVEMENT_ID = 101119;

		// Token: 0x0400F54F RID: 62799
		private bool IsActivityEndlessLevel;

		// Token: 0x02008C62 RID: 35938
		private static class EComponents
		{
			// Token: 0x0402C6E1 RID: 181985
			public const int TxtContent = 0;
		}
	}
}
