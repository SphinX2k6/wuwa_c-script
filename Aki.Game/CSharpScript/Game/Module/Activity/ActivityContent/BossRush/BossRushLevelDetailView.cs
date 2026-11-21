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
	// Token: 0x02005850 RID: 22608
	[NullableContext(2)]
	[Nullable(0)]
	public class BossRushLevelDetailView : UiTabViewBase
	{
		// Token: 0x06037BDD RID: 228317 RVA: 0x00F959B8 File Offset: 0x00F93BB8
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

		// Token: 0x06037BDE RID: 228318 RVA: 0x00F95AE8 File Offset: 0x00F93CE8
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

		// Token: 0x06037BDF RID: 228319 RVA: 0x00F95B54 File Offset: 0x00F93D54
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

		// Token: 0x06037BE0 RID: 228320 RVA: 0x00F95C8C File Offset: 0x00F93E8C
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushLevelDetailView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushLevelDetailView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037BE1 RID: 228321 RVA: 0x00F95CD0 File Offset: 0x00F93ED0
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

		// Token: 0x06037BE2 RID: 228322 RVA: 0x00F95D1F File Offset: 0x00F93F1F
		private void OnSelectBuff()
		{
			this.RefreshBuffEntry();
		}

		// Token: 0x06037BE3 RID: 228323 RVA: 0x00F95D27 File Offset: 0x00F93F27
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnChangeBossRushBuff, new Action(this.OnSelectBuff));
			EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		}

		// Token: 0x06037BE4 RID: 228324 RVA: 0x00F95D61 File Offset: 0x00F93F61
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnChangeBossRushBuff, new Action(this.OnSelectBuff));
			EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		}

		// Token: 0x06037BE5 RID: 228325 RVA: 0x00F95D9C File Offset: 0x00F93F9C
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

		// Token: 0x06037BE6 RID: 228326 RVA: 0x00F95E10 File Offset: 0x00F94010
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

		// Token: 0x06037BE7 RID: 228327 RVA: 0x00F95EA5 File Offset: 0x00F940A5
		private void OnSelectTeamRole()
		{
			this.RefreshLowLevelTips();
			this.RefreshTeamRole();
		}

		// Token: 0x06037BE8 RID: 228328 RVA: 0x00F95EB4 File Offset: 0x00F940B4
		private void RefreshLowLevelTips()
		{
			if (this.CurrentTeamInfo == null)
			{
				return;
			}
			bool ifLevelTooLow = this.CurrentTeamInfo.GetIfLevelTooLow();
			base.GetText(6).SetUIActive(ifLevelTooLow);
		}

		// Token: 0x06037BE9 RID: 228329 RVA: 0x00F95EE4 File Offset: 0x00F940E4
		private void RefreshMonsterInfo()
		{
			if (this.CurrentTeamInfo == null || this.CurrentTeamInfo.GetCurrentSelectLevel() == null)
			{
				return;
			}
			BossRushLevelDetailInfo currentSelectLevel = this.CurrentTeamInfo.GetCurrentSelectLevel();
			base.SetTextureByPath(currentSelectLevel.GetBigMonsterTexturePath(), base.GetTexture(0), new EUiViewName?(EUiViewName.BossRushMainView), null);
		}

		// Token: 0x06037BEA RID: 228330 RVA: 0x00F95F34 File Offset: 0x00F94134
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

		// Token: 0x06037BEB RID: 228331 RVA: 0x00F95FE8 File Offset: 0x00F941E8
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

		// Token: 0x06037BEC RID: 228332 RVA: 0x00F960E0 File Offset: 0x00F942E0
		private void RefreshTeamItem()
		{
			if (this.TeamItem != null && this.CurrentTeamInfo != null)
			{
				this.TeamItem.Refresh(this.CurrentTeamInfo);
			}
		}

		// Token: 0x06037BED RID: 228333 RVA: 0x00F96103 File Offset: 0x00F94303
		private void RefreshTeamRole()
		{
			if (this.TeamItem != null && this.CurrentTeamInfo != null)
			{
				this.TeamItem.RefreshTeamRole(this.CurrentTeamInfo);
			}
		}

		// Token: 0x06037BEE RID: 228334 RVA: 0x00F96128 File Offset: 0x00F94328
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

		// Token: 0x0401D6AE RID: 120494
		private BossRushTeamInfo CurrentTeamInfo;

		// Token: 0x0401D6AF RID: 120495
		private TeamItem TeamItem;

		// Token: 0x0401D6B0 RID: 120496
		private BuffEntry BuffEntryItem1;

		// Token: 0x0401D6B1 RID: 120497
		private BuffEntry BuffEntryItem2;

		// Token: 0x0401D6B2 RID: 120498
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D6B3 RID: 120499
		[Nullable(1)]
		private readonly List<BuffEntry> BuffEntryItemArray = new List<BuffEntry>();

		// Token: 0x0200B47B RID: 46203
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037D07 RID: 228615
			MonsterTexture,
			// Token: 0x04037D08 RID: 228616
			HelpBtn,
			// Token: 0x04037D09 RID: 228617
			LevelTipsText,
			// Token: 0x04037D0A RID: 228618
			BuffEntryItem1,
			// Token: 0x04037D0B RID: 228619
			BuffEntryItem2,
			// Token: 0x04037D0C RID: 228620
			TeamItem,
			// Token: 0x04037D0D RID: 228621
			LowLevelTipsText,
			// Token: 0x04037D0E RID: 228622
			ConfirmButton,
			// Token: 0x04037D0F RID: 228623
			ScoreText,
			// Token: 0x04037D10 RID: 228624
			UnFinishItem
		}
	}
}
