using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042DD RID: 17117
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueDungeonEntryView : UiViewBase
	{
		// Token: 0x0602B51E RID: 177438 RVA: 0x00C2B8A3 File Offset: 0x00C29AA3
		[NullableContext(1)]
		public RogueDungeonEntryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B51F RID: 177439 RVA: 0x00C2B8B4 File Offset: 0x00C29AB4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
		}

		// Token: 0x0602B520 RID: 177440 RVA: 0x00C2B994 File Offset: 0x00C29B94
		protected override UniTask OnBeforeStartAsync()
		{
			RogueDungeonEntryView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueDungeonEntryView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B521 RID: 177441 RVA: 0x00C2B9D8 File Offset: 0x00C29BD8
		protected override void OnStart()
		{
			this.DungeonConfig = (RogueDungeonParam)this.OpenParam;
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			UUIItem item = base.GetItem(3);
			UUIItem item2 = base.GetItem(8);
			this.NoCircleAttachViewInstance = new NoCircleAttachView<int, RogueDungeonDataItem>(item.GetOwner() as AUIBaseActor, false);
			NoCircleAttachView<int, RogueDungeonDataItem> noCircleAttachViewInstance = this.NoCircleAttachViewInstance;
			if (noCircleAttachViewInstance != null)
			{
				noCircleAttachViewInstance.SetIfNeedFakeItem(true);
			}
			this.NoCircleAttachViewInstance.CreateItems(base.GetItem(4).GetOwner(), 0f, new Func<AActor, int, int, RogueDungeonDataItem>(this.CreateNoCircleAttachItem), EAttachDirection.Vertical);
			NoCircleAttachView<int, RogueDungeonDataItem> noCircleAttachViewInstance2 = this.NoCircleAttachViewInstance;
			if (noCircleAttachViewInstance2 != null)
			{
				noCircleAttachViewInstance2.SetControllerItem(item2);
			}
			base.GetItem(4).SetUIActive(false);
			int currentSelectedInst = ActivityPermanentRogueModel.Instance.GetCurrentSelectedInst(this.DungeonConfig.SeasonId);
			int attachTo = (Array.IndexOf<int>(this.DungeonConfig.DungeonList, currentSelectedInst) >= 0) ? this.DungeonConfig.DungeonList.IndexOf(currentSelectedInst) : 0;
			int[] dungeonList = this.DungeonConfig.DungeonList;
			this.NoCircleAttachViewInstance.ReloadView(dungeonList.Length, dungeonList, attachTo);
		}

		// Token: 0x0602B522 RID: 177442 RVA: 0x00C2BAE6 File Offset: 0x00C29CE6
		protected override void OnBeforeShow()
		{
			this.RefreshSkillConfig();
			this.BindRedDot();
		}

		// Token: 0x0602B523 RID: 177443 RVA: 0x00C2BAF4 File Offset: 0x00C29CF4
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
		}

		// Token: 0x0602B524 RID: 177444 RVA: 0x00C2BAFC File Offset: 0x00C29CFC
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.DungeonConfig = null;
			this.NoCircleAttachViewInstance = null;
			this.InfoComponent = null;
			this.SequencePlayer = null;
		}

		// Token: 0x0602B525 RID: 177445 RVA: 0x00C2BB21 File Offset: 0x00C29D21
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RogueResTalentLevelUp, new Action<int>(this.OnSkillUpdate));
			EventSystem.Instance.Add(EEventName.RogueResEnterInstClicked, new Action(this.OnClickedEnter));
		}

		// Token: 0x0602B526 RID: 177446 RVA: 0x00C2BB5B File Offset: 0x00C29D5B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RogueResTalentLevelUp, new Action<int>(this.OnSkillUpdate));
			EventSystem.Instance.Remove(EEventName.RogueResEnterInstClicked, new Action(this.OnClickedEnter));
		}

		// Token: 0x0602B527 RID: 177447 RVA: 0x00C2BB95 File Offset: 0x00C29D95
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B528 RID: 177448 RVA: 0x00C2BBA0 File Offset: 0x00C29DA0
		[NullableContext(1)]
		private void OnItemClick(RogueDungeonDataItem item)
		{
			if (this.NoCircleAttachViewInstance.IsVelocityMoveState())
			{
				return;
			}
			if (item.GetData() == null)
			{
				return;
			}
			this.NoCircleAttachViewInstance.AttachToIndex(item.GetCurrentShowItemIndex(), false);
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(item.GetData().Value))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RogueRes_DungeonLock", Array.Empty<object>());
			}
		}

		// Token: 0x0602B529 RID: 177449 RVA: 0x00C2BC0C File Offset: 0x00C29E0C
		private void OnSkillTreeClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueResSkillView, this.DungeonConfig.SeasonId, null);
		}

		// Token: 0x0602B52A RID: 177450 RVA: 0x00C2BC2E File Offset: 0x00C29E2E
		private void OnSkillUpdate(int skillId)
		{
			this.RefreshSkillConfig();
		}

		// Token: 0x0602B52B RID: 177451 RVA: 0x00C2BC38 File Offset: 0x00C29E38
		private void OnClickedEnter()
		{
			foreach (RogueDungeonDataItem rogueDungeonDataItem in this.NoCircleAttachViewInstance.GetItems())
			{
				rogueDungeonDataItem.UnSelectWhenEnter();
			}
		}

		// Token: 0x0602B52C RID: 177452 RVA: 0x00C2BC90 File Offset: 0x00C29E90
		[NullableContext(1)]
		private RogueDungeonDataItem CreateNoCircleAttachItem(AActor actor, int index, int showNum)
		{
			RogueDungeonDataItem rogueDungeonDataItem = new RogueDungeonDataItem(actor);
			rogueDungeonDataItem.CreateByActorAsync(actor, null, false);
			rogueDungeonDataItem.OnToggleClick = new Action<RogueDungeonDataItem>(this.OnItemClick);
			rogueDungeonDataItem.OnSelectCall = new Action<int>(this.OnDungeonSelectedRefresh);
			rogueDungeonDataItem.CheckToggleCanClick = new Func<int, bool>(this.CheckToggleCanClick);
			return rogueDungeonDataItem;
		}

		// Token: 0x0602B52D RID: 177453 RVA: 0x00C2BCE3 File Offset: 0x00C29EE3
		private bool CheckToggleCanClick(int id)
		{
			return !this.NoCircleAttachViewInstance.MovingState() && id != this.SelectedId;
		}

		// Token: 0x0602B52E RID: 177454 RVA: 0x00C2BD00 File Offset: 0x00C29F00
		private void BindRedDot()
		{
			RogueButtonItemA btnSkillItem = this.BtnSkillItem;
			if (btnSkillItem == null)
			{
				return;
			}
			btnSkillItem.BindRedDot(ERedDotName.RogueResSkillTree, new int?(this.DungeonConfig.SeasonId));
		}

		// Token: 0x0602B52F RID: 177455 RVA: 0x00C2BD27 File Offset: 0x00C29F27
		private void UnbindRedDot()
		{
			RogueButtonItemA btnSkillItem = this.BtnSkillItem;
			if (btnSkillItem == null)
			{
				return;
			}
			btnSkillItem.UnBindRedDot();
		}

		// Token: 0x0602B530 RID: 177456 RVA: 0x00C2BD3C File Offset: 0x00C29F3C
		private void RefreshSkillConfig()
		{
			int skillTreeLevel = ActivityPermanentRogueModel.Instance.GetSkillTreeLevel(this.DungeonConfig.SeasonId);
			RogueButtonItemA btnSkillItem = this.BtnSkillItem;
			if (btnSkillItem == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(skillTreeLevel);
			btnSkillItem.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0602B531 RID: 177457 RVA: 0x00C2BD94 File Offset: 0x00C29F94
		private void OnDungeonSelectedRefresh(int id)
		{
			this.InfoComponent.RefreshDungeonConfig(id);
			RogueResDungeonConfig? config = ConfigRogueResDungeonConfigById.GetConfig(id, true);
			if (config == null)
			{
				return;
			}
			this.SelectedId = id;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (((sequencePlayer != null) ? sequencePlayer.GetCurrentSequence() : null) == "Switch")
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.ReplaySequenceByKey("Switch");
				}
			}
			else
			{
				LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
				if (((sequencePlayer3 != null) ? sequencePlayer3.GetCurrentSequence() : null) == null)
				{
					LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
					if (sequencePlayer4 != null)
					{
						sequencePlayer4.PlayLevelSequenceByName("Switch", false, null, false);
					}
				}
			}
			string path = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? config.Value.CoverF : config.Value.CoverM;
			base.SetTextureByPath(path, base.GetTexture(2), null, null);
			bool flag = InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(id);
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!flag);
		}

		// Token: 0x0602B532 RID: 177458 RVA: 0x00C2BE9C File Offset: 0x00C2A09C
		[NullableContext(1)]
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
			NoCircleAttachView<int, RogueDungeonDataItem> noCircleAttachViewInstance = this.NoCircleAttachViewInstance;
			UUIItem uuiitem;
			if (noCircleAttachViewInstance == null)
			{
				uuiitem = null;
			}
			else
			{
				RogueDungeonDataItem itemByShowIndex = noCircleAttachViewInstance.GetItemByShowIndex(0);
				uuiitem = ((itemByShowIndex != null) ? itemByShowIndex.GetRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x040175F5 RID: 95733
		private RogueDungeonParam DungeonConfig;

		// Token: 0x040175F6 RID: 95734
		private PopupCaptionItem CaptionItem;

		// Token: 0x040175F7 RID: 95735
		private RogueDungeonInfoItem InfoComponent;

		// Token: 0x040175F8 RID: 95736
		private RogueButtonItemA BtnSkillItem;

		// Token: 0x040175F9 RID: 95737
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private NoCircleAttachView<int, RogueDungeonDataItem> NoCircleAttachViewInstance;

		// Token: 0x040175FA RID: 95738
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x040175FB RID: 95739
		private int SelectedId = -1;
	}
}
