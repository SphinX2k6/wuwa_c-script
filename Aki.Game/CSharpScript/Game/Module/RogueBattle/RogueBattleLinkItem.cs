using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E63 RID: 20067
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleLinkItem : UiPanelBase
	{
		// Token: 0x06033AEF RID: 211695 RVA: 0x00C1A078 File Offset: 0x00C18278
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnSelf))
			};
		}

		// Token: 0x06033AF0 RID: 211696 RVA: 0x00C1A121 File Offset: 0x00C18321
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06033AF1 RID: 211697 RVA: 0x00C1A134 File Offset: 0x00C18334
		private void OnBtnSelf()
		{
			Action onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack();
		}

		// Token: 0x06033AF2 RID: 211698 RVA: 0x00C1A148 File Offset: 0x00C18348
		private bool IsAnyBondLinkCanActivate()
		{
			foreach (RoleBondInfo roleBondInfo in RogueBattleModel.Instance.GetAllOwnedRoleBondData())
			{
				if (RogueBattleModel.Instance.IsBondLinkCanActivate(roleBondInfo.ConfigId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06033AF3 RID: 211699 RVA: 0x00C1A1B4 File Offset: 0x00C183B4
		public void RefreshLinkInfo(int formationIndex)
		{
			RogueResFormation formationDataByIndex = RogueBattleModel.Instance.GetFormationDataByIndex(formationIndex);
			if (formationDataByIndex == null)
			{
				return;
			}
			int linkId = formationDataByIndex.LinkId;
			if (linkId == 0)
			{
				bool flag = this.IsAnyBondLinkCanActivate();
				string textStringId = flag ? "RogueRes_LinkActHint_Desc" : "RogueBattle_TeamEdit_LinkLock";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_TeamRoleSkillNone");
				base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(2), null);
				base.GetItem(3).SetUIActive(flag);
				base.GetItem(4).SetUIActive(flag);
				if (flag)
				{
					if (this.LevelSequencePlayer.GetCurrentSequence() == "Loop")
					{
						this.LevelSequencePlayer.ReplaySequenceByKey("Loop");
					}
					else
					{
						this.LevelSequencePlayer.StopPlayingSequence(false, true);
						this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
					}
				}
				else
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.StopSequenceByKey("Loop", false, true);
					}
				}
			}
			else
			{
				RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(linkId);
				base.SetTextureShowUntilLoaded(rogueResBond.Value.Icon, base.GetTexture(2), null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueBattle_TeamEdit_LinkUnlock", new <>z__ReadOnlySingleElementList<object>(TextConfig.Instance.GetMultiText(rogueResBond.Value.Name, Array.Empty<string>())));
				base.GetItem(3).SetUIActive(true);
				base.GetItem(4).SetUIActive(true);
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.StopSequenceByKey("Loop", false, true);
				}
			}
			EventSystem.Instance.Emit<bool>(EEventName.RogueTeamEditViewLinkBtnRefresh, linkId != 0);
		}

		// Token: 0x0401B6AD RID: 112301
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B6AE RID: 112302
		public Action OnClickCallBack;
	}
}
