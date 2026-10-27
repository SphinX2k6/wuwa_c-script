using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055E9 RID: 21993
	public class MapRogueTitleItem : UiPanelBase
	{
		// Token: 0x06038045 RID: 229445 RVA: 0x00D4489C File Offset: 0x00D42A9C
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

		// Token: 0x06038046 RID: 229446 RVA: 0x00D4491C File Offset: 0x00D42B1C
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

		// Token: 0x06038047 RID: 229447 RVA: 0x00D44980 File Offset: 0x00D42B80
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

		// Token: 0x06038048 RID: 229448 RVA: 0x00D449C4 File Offset: 0x00D42BC4
		private void OnBtnClick()
		{
			if (this.CheckCanBtnClick != null && !this.CheckCanBtnClick())
			{
				return;
			}
			MapRogueController.Instance.OpenExplore();
		}

		// Token: 0x0401D6EF RID: 120559
		[Nullable(2)]
		public Func<bool> CheckCanBtnClick;
	}
}
