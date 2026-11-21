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
	// Token: 0x02003E2C RID: 15916
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueBattleLinkItem : UiPanelBase
	{
		// Token: 0x0602895A RID: 166234 RVA: 0x00B635A0 File Offset: 0x00B617A0
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

		// Token: 0x0602895B RID: 166235 RVA: 0x00B63649 File Offset: 0x00B61849
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0602895C RID: 166236 RVA: 0x00B6365C File Offset: 0x00B6185C
		private void OnBtnSelf()
		{
			Action onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack();
		}

		// Token: 0x0602895D RID: 166237 RVA: 0x00B63670 File Offset: 0x00B61870
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

		// Token: 0x0602895E RID: 166238 RVA: 0x00B636DC File Offset: 0x00B618DC
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

		// Token: 0x04016080 RID: 90240
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04016081 RID: 90241
		public Action OnClickCallBack;
	}
}
