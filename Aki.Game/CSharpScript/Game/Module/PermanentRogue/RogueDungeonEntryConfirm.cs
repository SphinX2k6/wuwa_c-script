using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005309 RID: 21257
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueDungeonEntryConfirm : UiPanelBase
	{
		// Token: 0x06036613 RID: 222739 RVA: 0x00CDD8A8 File Offset: 0x00CDBAA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x06036614 RID: 222740 RVA: 0x00CDD970 File Offset: 0x00CDBB70
		protected override UniTask OnBeforeStartAsync()
		{
			RogueDungeonEntryConfirm.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueDungeonEntryConfirm.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036615 RID: 222741 RVA: 0x00CDD9B3 File Offset: 0x00CDBBB3
		private void ExtraButtonFunction()
		{
			EventSystem.Instance.Emit(EEventName.RogueResEnterInstClicked);
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestEnterDungeon(this.DungeonId);
			ActivityPermanentRogueModel.Instance.SetCurrentSelectedInst(this.DungeonId);
		}

		// Token: 0x06036616 RID: 222742 RVA: 0x00CDD9EC File Offset: 0x00CDBBEC
		[NullableContext(1)]
		public void SetLockTextByTextId(string textId, params string[] args)
		{
			this.PanelLock.SetTextByTextId(textId, args);
		}

		// Token: 0x06036617 RID: 222743 RVA: 0x00CDD9FB File Offset: 0x00CDBBFB
		public void SetLockSpriteVisible(bool bVisible)
		{
			this.PanelLock.SetSpriteVisible(bVisible);
		}

		// Token: 0x06036618 RID: 222744 RVA: 0x00CDDA09 File Offset: 0x00CDBC09
		public void SetPanelConditionVisible(bool bVisible)
		{
			base.GetItem(0).SetUIActive(bVisible);
		}

		// Token: 0x06036619 RID: 222745 RVA: 0x00CDDA18 File Offset: 0x00CDBC18
		public void SetLockConditionButtonVisible(bool bVisible)
		{
			this.PanelLock.SetButtonVisible(bVisible);
		}

		// Token: 0x0603661A RID: 222746 RVA: 0x00CDDA28 File Offset: 0x00CDBC28
		public void Refresh(int dungeonId)
		{
			this.DungeonId = dungeonId;
			InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
			bool flag = instance.CheckInstanceUnlock(dungeonId);
			this.SetPanelConditionVisible(!flag);
			this.SetLockSpriteVisible(!flag);
			if (!flag)
			{
				string unlockTextIdById = instance.GetUnlockTextIdById(dungeonId);
				int[] unlockCondition = InstanceDungeonConfig.Instance.GetUnlockCondition(dungeonId);
				if (unlockCondition[0] == 1)
				{
					this.SetLockTextByTextId(unlockTextIdById ?? "", new string[]
					{
						unlockCondition[1].ToString()
					});
				}
				else if (unlockCondition[0] == 4)
				{
					InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(dungeonId);
					if (config != null)
					{
						this.SetLockTextByTextId(unlockTextIdById ?? "", new string[]
						{
							config.Value.MapName
						});
					}
				}
			}
			ActivityButtonItem functionButton = this.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.SetUiActive(flag);
		}

		// Token: 0x0401CBA5 RID: 117669
		protected int DungeonId;

		// Token: 0x0401CBA6 RID: 117670
		public ActivityButtonItem FunctionButton;

		// Token: 0x0401CBA7 RID: 117671
		public FunctionalPanelConditionLock PanelLock;
	}
}
