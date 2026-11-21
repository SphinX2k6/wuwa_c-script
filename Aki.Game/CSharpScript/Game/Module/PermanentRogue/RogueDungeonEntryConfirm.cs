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
	// Token: 0x020042D9 RID: 17113
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueDungeonEntryConfirm : UiPanelBase
	{
		// Token: 0x0602B50F RID: 177423 RVA: 0x00C2B278 File Offset: 0x00C29478
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

		// Token: 0x0602B510 RID: 177424 RVA: 0x00C2B340 File Offset: 0x00C29540
		protected override UniTask OnBeforeStartAsync()
		{
			RogueDungeonEntryConfirm.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueDungeonEntryConfirm.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B511 RID: 177425 RVA: 0x00C2B383 File Offset: 0x00C29583
		private void ExtraButtonFunction()
		{
			EventSystem.Instance.Emit(EEventName.RogueResEnterInstClicked);
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestEnterDungeon(this.DungeonId);
			ActivityPermanentRogueModel.Instance.SetCurrentSelectedInst(this.DungeonId);
		}

		// Token: 0x0602B512 RID: 177426 RVA: 0x00C2B3BC File Offset: 0x00C295BC
		[NullableContext(1)]
		public void SetLockTextByTextId(string textId, params string[] args)
		{
			this.PanelLock.SetTextByTextId(textId, args);
		}

		// Token: 0x0602B513 RID: 177427 RVA: 0x00C2B3CB File Offset: 0x00C295CB
		public void SetLockSpriteVisible(bool bVisible)
		{
			this.PanelLock.SetSpriteVisible(bVisible);
		}

		// Token: 0x0602B514 RID: 177428 RVA: 0x00C2B3D9 File Offset: 0x00C295D9
		public void SetPanelConditionVisible(bool bVisible)
		{
			base.GetItem(0).SetUIActive(bVisible);
		}

		// Token: 0x0602B515 RID: 177429 RVA: 0x00C2B3E8 File Offset: 0x00C295E8
		public void SetLockConditionButtonVisible(bool bVisible)
		{
			this.PanelLock.SetButtonVisible(bVisible);
		}

		// Token: 0x0602B516 RID: 177430 RVA: 0x00C2B3F8 File Offset: 0x00C295F8
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

		// Token: 0x040175DB RID: 95707
		protected int DungeonId;

		// Token: 0x040175DC RID: 95708
		public ActivityButtonItem FunctionButton;

		// Token: 0x040175DD RID: 95709
		public FunctionalPanelConditionLock PanelLock;
	}
}
