using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x02006900 RID: 26880
	[NullableContext(2)]
	[Nullable(0)]
	public class BossRushLevelDetailView : UiTabViewBase
	{
		// Token: 0x06043085 RID: 274565 RVA: 0x01054390 File Offset: 0x01052590
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickHelpBtn)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickConfirmButton))
			};
		}

		// Token: 0x06043086 RID: 274566 RVA: 0x010544C0 File Offset: 0x010526C0
		private void OnClickHelpBtn()
		{
			if (this.CurrentTeamInfo == null || this.CurrentTeamInfo.GetCurrentSelectLevel() == null)
			{
				return;
			}
			int instanceDungeonId = this.CurrentTeamInfo.GetCurrentSelectLevel().GetInstanceDungeonId();
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = instanceDungeonId;
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, new InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam
			{
				InstanceId = instanceDungeonId,
				InfoType = null
			}, null);
		}

		// Token: 0x06043087 RID: 274567 RVA: 0x0105452C File Offset: 0x0105272C
		private void OnClickConfirmButton()
		{
			if (this.CurrentTeamInfo == null || this.CurrentTeamInfo.LevelInfo == null)
			{
				return;
			}
			int instanceDungeonFormationNumb = this.CurrentTeamInfo.LevelInfo.GetInstanceDungeonFormationNumb();
			int num = 0;
			if (this.CurrentTeamInfo != null)
			{
				int[] currentTeamMembers = this.CurrentTeamInfo.GetCurrentTeamMembers();
				for (int i = 0; i < currentTeamMembers.Length; i++)
				{
					if (currentTeamMembers[i] != 0)
					{
						num++;
					}
				}
			}
			if (num == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("BossRushAtlestOneRole", Array.Empty<object>());
				return;
			}
			int num2 = 0;
			using (List<BuffEntry>.Enumerator enumerator = this.BuffEntryItemArray.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HaveBuff())
					{
						num2++;
					}
				}
			}
			if (num2 < 2)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("BossRushBuffCountTips", Array.Empty<object>());
				return;
			}
			if (instanceDungeonFormationNumb > num)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BossRushRoleLess);
				Action value = delegate()
				{
					if (this.CurrentTeamInfo != null)
					{
						BossRushController.Instance.RequestStartBossRushByTeamData(this.CurrentTeamInfo);
					}
				};
				confirmBoxDataNew.FunctionMap.Add(2, value);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (this.CurrentTeamInfo != null)
			{
				BossRushController.Instance.RequestStartBossRushByTeamData(this.CurrentTeamInfo);
			}
		}

		// Token: 0x06043088 RID: 274568 RVA: 0x01054664 File Offset: 0x01052864
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushLevelDetailView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushLevelDetailView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043089 RID: 274569 RVA: 0x010546A8 File Offset: 0x010528A8
		private void TryShowAnimation()
		{
			string sequenceName = "Start";
			if (BossRushModel.Instance.PlayBackAnimation)
			{
				sequenceName = "ShowView";
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
			}
			BossRushModel.Instance.PlayBackAnimation = false;
		}

		// Token: 0x0604308A RID: 274570 RVA: 0x010546F7 File Offset: 0x010528F7
		private void OnSelectBuff()
		{
			this.RefreshBuffEntry();
		}

		// Token: 0x0604308B RID: 274571 RVA: 0x010546FF File Offset: 0x010528FF
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnChangeBossRushBuff, new Action(this.OnSelectBuff));
			EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		}

		// Token: 0x0604308C RID: 274572 RVA: 0x01054739 File Offset: 0x01052939
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnChangeBossRushBuff, new Action(this.OnSelectBuff));
			EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		}

		// Token: 0x0604308D RID: 274573 RVA: 0x01054774 File Offset: 0x01052974
		private void OnRoleChangeEnd()
		{
			RoleModel instance = RoleModel.Instance;
			if (this.CurrentTeamInfo == null)
			{
				return;
			}
			int[] currentTeamMembers = this.CurrentTeamInfo.GetCurrentTeamMembers();
			for (int i = 0; i < currentTeamMembers.Length; i++)
			{
				int id = currentTeamMembers[i];
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
				int roleId = (roleDataById != null) ? roleDataById.GetRoleId() : 0;
				if (instance.IsMainRole(roleId))
				{
					this.CurrentTeamInfo.SetIndexTeamMembers(i, 0);
				}
			}
			this.OnSelectTeamRole();
		}

		// Token: 0x0604308E RID: 274574 RVA: 0x010547E8 File Offset: 0x010529E8
		protected override void OnBeforeShow()
		{
			this.CurrentTeamInfo = BossRushModel.Instance.CurrentTeamInfo;
			if (this.CurrentTeamInfo == null)
			{
				return;
			}
			foreach (int num in this.CurrentTeamInfo.GetCurrentTeamMembers())
			{
				if (RoleModel.Instance.IsMainRole(num) && RoleModel.Instance.GetRoleInstanceById(num) == null)
				{
					this.CurrentTeamInfo.ClearTeamInfo();
					break;
				}
			}
			this.TryShowAnimation();
			this.RefreshMonsterInfo();
			this.RefreshLevelBossNumText();
			this.RefreshScore();
			this.RefreshLowLevelTips();
			this.RefreshTeamItem();
			this.RefreshBuffEntry();
		}

		// Token: 0x0604308F RID: 274575 RVA: 0x0105487D File Offset: 0x01052A7D
		private void OnSelectTeamRole()
		{
			this.RefreshLowLevelTips();
			this.RefreshTeamRole();
		}

		// Token: 0x06043090 RID: 274576 RVA: 0x0105488C File Offset: 0x01052A8C
		private void RefreshLowLevelTips()
		{
			if (this.CurrentTeamInfo == null)
			{
				return;
			}
			bool ifLevelTooLow = this.CurrentTeamInfo.GetIfLevelTooLow();
			base.GetText(6).SetUIActive(ifLevelTooLow);
		}

		// Token: 0x06043091 RID: 274577 RVA: 0x010548BC File Offset: 0x01052ABC
		private void RefreshMonsterInfo()
		{
			if (this.CurrentTeamInfo == null || this.CurrentTeamInfo.GetCurrentSelectLevel() == null)
			{
				return;
			}
			BossRushLevelDetailInfo currentSelectLevel = this.CurrentTeamInfo.GetCurrentSelectLevel();
			base.SetTextureByPath(currentSelectLevel.GetBigMonsterTexturePath(), base.GetTexture(0), new EUiViewName?(EUiViewName.BossRushMainView), null);
		}

		// Token: 0x06043092 RID: 274578 RVA: 0x0105490C File Offset: 0x01052B0C
		private void RefreshLevelBossNumText()
		{
			BossRushTeamInfo currentTeamInfo = this.CurrentTeamInfo;
			bool flag;
			if (currentTeamInfo == null)
			{
				flag = true;
			}
			else
			{
				BossRushLevelDetailInfo currentSelectLevel = currentTeamInfo.GetCurrentSelectLevel();
				if (currentSelectLevel == null)
				{
					flag = true;
				}
				else
				{
					BossRushActivity? config = currentSelectLevel.GetConfig();
					flag = (config == null);
				}
			}
			if (flag)
			{
				return;
			}
			BossRushTeamInfo currentTeamInfo2 = this.CurrentTeamInfo;
			int? num;
			if (currentTeamInfo2 == null)
			{
				num = null;
			}
			else
			{
				BossRushLevelDetailInfo currentSelectLevel2 = currentTeamInfo2.GetCurrentSelectLevel();
				if (currentSelectLevel2 == null)
				{
					num = null;
				}
				else
				{
					BossRushActivity? config = currentSelectLevel2.GetConfig();
					num = ((config != null) ? new int?(config.GetValueOrDefault().BossCount) : null);
				}
			}
			int? num2 = num;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "BossRushNumTips", new <>z__ReadOnlySingleElementList<object>(num2));
		}

		// Token: 0x06043093 RID: 274579 RVA: 0x010549C0 File Offset: 0x01052BC0
		private void RefreshScore()
		{
			BossRushData bossRushData = ActivityModel.Instance.GetActivityById(BossRushModel.Instance.CurrentSelectActivityId) as BossRushData;
			if (bossRushData == null || this.CurrentTeamInfo == null || this.CurrentTeamInfo.GetCurrentSelectLevel() == null)
			{
				return;
			}
			BossRushLevelDetailInfo bossRushLevelDetailInfoById = bossRushData.GetBossRushLevelDetailInfoById(this.CurrentTeamInfo.GetCurrentSelectLevel().GetInstanceDungeonId());
			int? num = (bossRushLevelDetailInfoById != null) ? new int?(bossRushLevelDetailInfoById.GetScore()) : null;
			UUIText text = base.GetText(8);
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					if (text != null)
					{
						text.SetUIActive(true);
					}
					if (text != null)
					{
						UUIText uuitext = text;
						num2 = num;
						uuitext.SetText(num2.ToString() ?? "", true);
					}
					UUIItem item = base.GetItem(9);
					if (item == null)
					{
						return;
					}
					item.SetUIActive(false);
					return;
				}
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
		}

		// Token: 0x06043094 RID: 274580 RVA: 0x01054AB8 File Offset: 0x01052CB8
		private void RefreshTeamItem()
		{
			if (this.TeamItem != null && this.CurrentTeamInfo != null)
			{
				this.TeamItem.Refresh(this.CurrentTeamInfo);
			}
		}

		// Token: 0x06043095 RID: 274581 RVA: 0x01054ADB File Offset: 0x01052CDB
		private void RefreshTeamRole()
		{
			if (this.TeamItem != null && this.CurrentTeamInfo != null)
			{
				this.TeamItem.RefreshTeamRole(this.CurrentTeamInfo);
			}
		}

		// Token: 0x06043096 RID: 274582 RVA: 0x01054B00 File Offset: 0x01052D00
		private void RefreshBuffEntry()
		{
			if (this.CurrentTeamInfo == null)
			{
				return;
			}
			List<BossRushBuffInfo> list = (BossRushModel.Instance.CurrentSelectBuffTabName == EBuffTabName.Normal) ? this.CurrentTeamInfo.GetPrepareSelectBuff() : this.CurrentTeamInfo.GetPrepareSelectScoreBuff();
			for (int i = 0; i < list.Count; i++)
			{
				if (i < this.BuffEntryItemArray.Count)
				{
					this.BuffEntryItemArray[i].Refresh(list[i]);
				}
			}
		}

		// Token: 0x04022E52 RID: 142930
		private BossRushTeamInfo CurrentTeamInfo;

		// Token: 0x04022E53 RID: 142931
		private TeamItem TeamItem;

		// Token: 0x04022E54 RID: 142932
		private BuffEntry BuffEntryItem1;

		// Token: 0x04022E55 RID: 142933
		private BuffEntry BuffEntryItem2;

		// Token: 0x04022E56 RID: 142934
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04022E57 RID: 142935
		[Nullable(1)]
		private readonly List<BuffEntry> BuffEntryItemArray = new List<BuffEntry>();

		// Token: 0x0200CAB3 RID: 51891
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D42D RID: 250925
			MonsterTexture,
			// Token: 0x0403D42E RID: 250926
			HelpBtn,
			// Token: 0x0403D42F RID: 250927
			LevelTipsText,
			// Token: 0x0403D430 RID: 250928
			BuffEntryItem1,
			// Token: 0x0403D431 RID: 250929
			BuffEntryItem2,
			// Token: 0x0403D432 RID: 250930
			TeamItem,
			// Token: 0x0403D433 RID: 250931
			LowLevelTipsText,
			// Token: 0x0403D434 RID: 250932
			ConfirmButton,
			// Token: 0x0403D435 RID: 250933
			ScoreText,
			// Token: 0x0403D436 RID: 250934
			UnFinishItem
		}
	}
}
