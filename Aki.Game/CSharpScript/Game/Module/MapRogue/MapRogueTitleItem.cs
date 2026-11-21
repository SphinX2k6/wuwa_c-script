using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045BF RID: 17855
	public class MapRogueTitleItem : UiPanelBase
	{
		// Token: 0x0602CF43 RID: 184131 RVA: 0x00C925E4 File Offset: 0x00C907E4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick))
			};
		}

		// Token: 0x0602CF44 RID: 184132 RVA: 0x00C92664 File Offset: 0x00C90864
		protected override void OnStart()
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			RogueResInstGrid? insGridConfigByInstId = MapRogueConfig.Instance.GetInsGridConfigByInstId(gameInfo.InstanceId);
			if (insGridConfigByInstId == null)
			{
				return;
			}
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, insGridConfigByInstId.Value.Title, Array.Empty<object>());
			this.RefreshProgress();
		}

		// Token: 0x0602CF45 RID: 184133 RVA: 0x00C926C8 File Offset: 0x00C908C8
		public void RefreshProgress()
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			int num = gameInfo.ExplorationCurrentProgress();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RogueResExplore_3", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x0602CF46 RID: 184134 RVA: 0x00C9270C File Offset: 0x00C9090C
		private void OnBtnClick()
		{
			if (this.CheckCanBtnClick != null && !this.CheckCanBtnClick())
			{
				return;
			}
			MapRogueController.Instance.OpenExplore();
		}

		// Token: 0x0401817A RID: 98682
		[Nullable(2)]
		public Func<bool> CheckCanBtnClick;
	}
}
