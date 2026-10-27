using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006028 RID: 24616
	public class TetrisTipsEndLessStartView : TetrisTipsBaseView
	{
		// Token: 0x0603E4EA RID: 255210 RVA: 0x00F0C632 File Offset: 0x00F0A832
		[NullableContext(1)]
		public TetrisTipsEndLessStartView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E4EB RID: 255211 RVA: 0x00F0C63B File Offset: 0x00F0A83B
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0603E4EC RID: 255212 RVA: 0x00F0C65E File Offset: 0x00F0A85E
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0603E4ED RID: 255213 RVA: 0x00F0C668 File Offset: 0x00F0A868
		private void Refresh()
		{
			AchievementData achievementData = AchievementModel.Instance.GetAchievementData(101119);
			if (achievementData == null || achievementData.GetFinishState() > EAchievementStateEnum.UnFinished)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Tetristext_16", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Tetristext_15", Array.Empty<object>());
		}

		// Token: 0x04020909 RID: 133385
		private const int ACHIEVEMENT_ID = 101119;
	}
}
