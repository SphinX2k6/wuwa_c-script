using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045B7 RID: 17847
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoguePanelFetter : UiPanelBase
	{
		// Token: 0x0602CF1C RID: 184092 RVA: 0x00C91A78 File Offset: 0x00C8FC78
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnBtnFetterClick)),
				new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnTogFoldClick))
			};
		}

		// Token: 0x0602CF1D RID: 184093 RVA: 0x00C91B3C File Offset: 0x00C8FD3C
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayerInstance.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnCloseEvent), false);
			this.FetterLayout = new GenericLayout<FetterItem, IRogueBattleRoleBondUpdateInfo>(base.GetVerticalLayout(0), new Func<FetterItem>(this.OnCreateItem), null, false, true);
			this.RefreshTxt();
		}

		// Token: 0x0602CF1E RID: 184094 RVA: 0x00C91B99 File Offset: 0x00C8FD99
		protected override void OnBeforeShow()
		{
			this.RefreshFetter();
		}

		// Token: 0x0602CF1F RID: 184095 RVA: 0x00C91BA4 File Offset: 0x00C8FDA4
		public void RefreshFetter()
		{
			List<RoleBondInfo> allOwnedRoleBondData = RogueBattleModel.Instance.GetAllOwnedRoleBondData();
			List<IRogueBattleRoleBondUpdateInfo> list = new List<IRogueBattleRoleBondUpdateInfo>();
			foreach (RoleBondInfo roleBondInfo in allOwnedRoleBondData)
			{
				RogueBattleRoleBondUpdateInfo item = new RogueBattleRoleBondUpdateInfo
				{
					NewRoleBondInfo = roleBondInfo,
					OldRoleBondInfo = roleBondInfo,
					AddStar = 0
				};
				list.Add(item);
			}
			List<IRogueBattleRoleBondUpdateInfo> list2 = list;
			Comparison<IRogueBattleRoleBondUpdateInfo> comparison;
			if ((comparison = MapRoguePanelFetter.<>O.<0>__SortRogueBattleRoleBondUpdateInfo) == null)
			{
				comparison = (MapRoguePanelFetter.<>O.<0>__SortRogueBattleRoleBondUpdateInfo = new Comparison<IRogueBattleRoleBondUpdateInfo>(RogueBattleDefine.SortRogueBattleRoleBondUpdateInfo));
			}
			list2.Sort(comparison);
			List<IRogueBattleRoleBondUpdateInfo> data = (list.Count > 5) ? list.GetRange(0, 5) : list;
			this.FetterLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0602CF20 RID: 184096 RVA: 0x00C91C64 File Offset: 0x00C8FE64
		private FetterItem OnCreateItem()
		{
			return new FetterItem
			{
				OpenMenuFunc = new Action<IRogueBattleRoleBondUpdateInfo>(this.OnFetterItemClick)
			};
		}

		// Token: 0x0602CF21 RID: 184097 RVA: 0x00C91C80 File Offset: 0x00C8FE80
		private void OnBtnFetterClick()
		{
			if (this.CheckCanOpenMenu != null && !this.CheckCanOpenMenu())
			{
				return;
			}
			MapRogueController.Instance.OpenRogueFetterView(null);
		}

		// Token: 0x0602CF22 RID: 184098 RVA: 0x00C91CB8 File Offset: 0x00C8FEB8
		private void OnCloseEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.GetVerticalLayout(0).RootUIComp.Get().SetUIActive(this.VisibleState);
				base.GetButton(2).RootUIComp.Get().SetUIActive(this.VisibleState);
			}
		}

		// Token: 0x0602CF23 RID: 184099 RVA: 0x00C91D10 File Offset: 0x00C8FF10
		private void OnTogFoldClick(EToggleState state)
		{
			this.VisibleState = !this.VisibleState;
			this.RefreshTxt();
			base.GetVerticalLayout(0).RootUIComp.Get().SetUIActive(true);
			base.GetButton(2).RootUIComp.Get().SetUIActive(true);
			if (this.VisibleState)
			{
				this.LevelSequencePlayerInstance.PlayOrReplaySequenceByName("Start", false, null);
				return;
			}
			this.LevelSequencePlayerInstance.PlayOrReplaySequenceByName("Close", false, null);
		}

		// Token: 0x0602CF24 RID: 184100 RVA: 0x00C91DA3 File Offset: 0x00C8FFA3
		private void OnFetterItemClick(IRogueBattleRoleBondUpdateInfo fetterData)
		{
			if (fetterData.NewRoleBondInfo.ConfigId == 0)
			{
				return;
			}
			if (this.CheckCanOpenMenu != null && !this.CheckCanOpenMenu())
			{
				return;
			}
			MapRogueController.Instance.OpenRogueFetterView(new int?(fetterData.NewRoleBondInfo.ConfigId));
		}

		// Token: 0x0602CF25 RID: 184101 RVA: 0x00C91DE4 File Offset: 0x00C8FFE4
		private void RefreshTxt()
		{
			string textStringId = this.VisibleState ? "RogueRes_BondMain_Open" : "RogueRes_BondMain_Close";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
		}

		// Token: 0x0602CF26 RID: 184102 RVA: 0x00C91E20 File Offset: 0x00C90020
		public void SetToggleVisible(bool bVisible)
		{
			base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x0602CF27 RID: 184103 RVA: 0x00C91E48 File Offset: 0x00C90048
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			GenericLayout<FetterItem, IRogueBattleRoleBondUpdateInfo> fetterLayout = this.FetterLayout;
			UUIItem uuiitem = (fetterLayout != null) ? fetterLayout.GetGridByDisplayIndex(0) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04018152 RID: 98642
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x04018153 RID: 98643
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<FetterItem, IRogueBattleRoleBondUpdateInfo> FetterLayout;

		// Token: 0x04018154 RID: 98644
		[Nullable(2)]
		public Func<bool> CheckCanOpenMenu;

		// Token: 0x04018155 RID: 98645
		private bool VisibleState = true;

		// Token: 0x04018156 RID: 98646
		private const int FETTER_DISPLAY_NUM = 5;

		// Token: 0x0200A1D5 RID: 41429
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403236F RID: 205679
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IRogueBattleRoleBondUpdateInfo> <0>__SortRogueBattleRoleBondUpdateInfo;
		}
	}
}
