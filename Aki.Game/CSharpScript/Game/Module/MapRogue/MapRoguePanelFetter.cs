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
	// Token: 0x020055E1 RID: 21985
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoguePanelFetter : UiPanelBase
	{
		// Token: 0x0603801E RID: 229406 RVA: 0x00D43D30 File Offset: 0x00D41F30
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

		// Token: 0x0603801F RID: 229407 RVA: 0x00D43DF4 File Offset: 0x00D41FF4
		protected override void OnStart()
		{
			this.LevelSequencePlayerInstance = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayerInstance.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnCloseEvent), false);
			this.FetterLayout = new GenericLayout<FetterItem, IRogueBattleRoleBondUpdateInfo>(base.GetVerticalLayout(0), new Func<FetterItem>(this.OnCreateItem), null, false, true);
			this.RefreshTxt();
		}

		// Token: 0x06038020 RID: 229408 RVA: 0x00D43E51 File Offset: 0x00D42051
		protected override void OnBeforeShow()
		{
			this.RefreshFetter();
		}

		// Token: 0x06038021 RID: 229409 RVA: 0x00D43E5C File Offset: 0x00D4205C
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

		// Token: 0x06038022 RID: 229410 RVA: 0x00D43F1C File Offset: 0x00D4211C
		private FetterItem OnCreateItem()
		{
			return new FetterItem
			{
				OpenMenuFunc = new Action<IRogueBattleRoleBondUpdateInfo>(this.OnFetterItemClick)
			};
		}

		// Token: 0x06038023 RID: 229411 RVA: 0x00D43F38 File Offset: 0x00D42138
		private void OnBtnFetterClick()
		{
			if (this.CheckCanOpenMenu != null && !this.CheckCanOpenMenu())
			{
				return;
			}
			MapRogueController.Instance.OpenRogueFetterView(null);
		}

		// Token: 0x06038024 RID: 229412 RVA: 0x00D43F70 File Offset: 0x00D42170
		private void OnCloseEvent(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.GetVerticalLayout(0).RootUIComp.Get().SetUIActive(this.VisibleState);
				base.GetButton(2).RootUIComp.Get().SetUIActive(this.VisibleState);
			}
		}

		// Token: 0x06038025 RID: 229413 RVA: 0x00D43FC8 File Offset: 0x00D421C8
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

		// Token: 0x06038026 RID: 229414 RVA: 0x00D4405B File Offset: 0x00D4225B
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

		// Token: 0x06038027 RID: 229415 RVA: 0x00D4409C File Offset: 0x00D4229C
		private void RefreshTxt()
		{
			string textStringId = this.VisibleState ? "RogueRes_BondMain_Open" : "RogueRes_BondMain_Close";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
		}

		// Token: 0x06038028 RID: 229416 RVA: 0x00D440D8 File Offset: 0x00D422D8
		public void SetToggleVisible(bool bVisible)
		{
			base.GetExtendToggle(3).RootUIComp.Get().SetUIActive(bVisible);
		}

		// Token: 0x06038029 RID: 229417 RVA: 0x00D44100 File Offset: 0x00D42300
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

		// Token: 0x0401D6C7 RID: 120519
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayerInstance;

		// Token: 0x0401D6C8 RID: 120520
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<FetterItem, IRogueBattleRoleBondUpdateInfo> FetterLayout;

		// Token: 0x0401D6C9 RID: 120521
		[Nullable(2)]
		public Func<bool> CheckCanOpenMenu;

		// Token: 0x0401D6CA RID: 120522
		private bool VisibleState = true;

		// Token: 0x0401D6CB RID: 120523
		private const int FETTER_DISPLAY_NUM = 5;

		// Token: 0x0200B7AA RID: 47018
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04037945 RID: 227653
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<IRogueBattleRoleBondUpdateInfo> <0>__SortRogueBattleRoleBondUpdateInfo;
		}
	}
}
