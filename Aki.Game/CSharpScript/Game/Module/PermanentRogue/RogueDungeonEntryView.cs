using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200530D RID: 21261
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueDungeonEntryView : UiViewBase
	{
		// Token: 0x06036622 RID: 222754 RVA: 0x00CDDED3 File Offset: 0x00CDC0D3
		[NullableContext(1)]
		public RogueDungeonEntryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036623 RID: 222755 RVA: 0x00CDDEE4 File Offset: 0x00CDC0E4
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

		// Token: 0x06036624 RID: 222756 RVA: 0x00CDDFC4 File Offset: 0x00CDC1C4
		protected override UniTask OnBeforeStartAsync()
		{
			RogueDungeonEntryView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueDungeonEntryView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036625 RID: 222757 RVA: 0x00CDE008 File Offset: 0x00CDC208
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
			int attachTo = this.DungeonConfig.DungeonList.Contains(currentSelectedInst) ? this.DungeonConfig.DungeonList.IndexOf(currentSelectedInst) : 0;
			int[] dungeonList = this.DungeonConfig.DungeonList;
			this.NoCircleAttachViewInstance.ReloadView(dungeonList.Length, dungeonList, attachTo);
		}

		// Token: 0x06036626 RID: 222758 RVA: 0x00CDE115 File Offset: 0x00CDC315
		protected override void OnBeforeShow()
		{
			this.RefreshSkillConfig();
			this.BindRedDot();
		}

		// Token: 0x06036627 RID: 222759 RVA: 0x00CDE123 File Offset: 0x00CDC323
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
		}

		// Token: 0x06036628 RID: 222760 RVA: 0x00CDE12B File Offset: 0x00CDC32B
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.DungeonConfig = null;
			this.NoCircleAttachViewInstance = null;
			this.InfoComponent = null;
			this.SequencePlayer = null;
		}

		// Token: 0x06036629 RID: 222761 RVA: 0x00CDE150 File Offset: 0x00CDC350
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RogueResTalentLevelUp, new Action<int>(this.OnSkillUpdate));
			EventSystem.Instance.Add(EEventName.RogueResEnterInstClicked, new Action(this.OnClickedEnter));
		}

		// Token: 0x0603662A RID: 222762 RVA: 0x00CDE18A File Offset: 0x00CDC38A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RogueResTalentLevelUp, new Action<int>(this.OnSkillUpdate));
			EventSystem.Instance.Remove(EEventName.RogueResEnterInstClicked, new Action(this.OnClickedEnter));
		}

		// Token: 0x0603662B RID: 222763 RVA: 0x00CDE1C4 File Offset: 0x00CDC3C4
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603662C RID: 222764 RVA: 0x00CDE1D0 File Offset: 0x00CDC3D0
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

		// Token: 0x0603662D RID: 222765 RVA: 0x00CDE23C File Offset: 0x00CDC43C
		private void OnSkillTreeClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueResSkillView, this.DungeonConfig.SeasonId, null);
		}

		// Token: 0x0603662E RID: 222766 RVA: 0x00CDE25E File Offset: 0x00CDC45E
		private void OnSkillUpdate(int skillId)
		{
			this.RefreshSkillConfig();
		}

		// Token: 0x0603662F RID: 222767 RVA: 0x00CDE268 File Offset: 0x00CDC468
		private void OnClickedEnter()
		{
			foreach (RogueDungeonDataItem rogueDungeonDataItem in this.NoCircleAttachViewInstance.GetItems())
			{
				rogueDungeonDataItem.UnSelectWhenEnter();
			}
		}

		// Token: 0x06036630 RID: 222768 RVA: 0x00CDE2C0 File Offset: 0x00CDC4C0
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

		// Token: 0x06036631 RID: 222769 RVA: 0x00CDE313 File Offset: 0x00CDC513
		private bool CheckToggleCanClick(int id)
		{
			return !this.NoCircleAttachViewInstance.MovingState() && id != this.SelectedId;
		}

		// Token: 0x06036632 RID: 222770 RVA: 0x00CDE330 File Offset: 0x00CDC530
		private void BindRedDot()
		{
			RogueButtonItemA btnSkillItem = this.BtnSkillItem;
			if (btnSkillItem == null)
			{
				return;
			}
			btnSkillItem.BindRedDot(ERedDotName.RogueResSkillTree, new int?(this.DungeonConfig.SeasonId));
		}

		// Token: 0x06036633 RID: 222771 RVA: 0x00CDE357 File Offset: 0x00CDC557
		private void UnbindRedDot()
		{
			RogueButtonItemA btnSkillItem = this.BtnSkillItem;
			if (btnSkillItem == null)
			{
				return;
			}
			btnSkillItem.UnBindRedDot();
		}

		// Token: 0x06036634 RID: 222772 RVA: 0x00CDE36C File Offset: 0x00CDC56C
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

		// Token: 0x06036635 RID: 222773 RVA: 0x00CDE3C4 File Offset: 0x00CDC5C4
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

		// Token: 0x06036636 RID: 222774 RVA: 0x00CDE4CC File Offset: 0x00CDC6CC
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

		// Token: 0x0401CBBF RID: 117695
		private RogueDungeonParam DungeonConfig;

		// Token: 0x0401CBC0 RID: 117696
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CBC1 RID: 117697
		private RogueDungeonInfoItem InfoComponent;

		// Token: 0x0401CBC2 RID: 117698
		private RogueButtonItemA BtnSkillItem;

		// Token: 0x0401CBC3 RID: 117699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private NoCircleAttachView<int, RogueDungeonDataItem> NoCircleAttachViewInstance;

		// Token: 0x0401CBC4 RID: 117700
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401CBC5 RID: 117701
		private int SelectedId = -1;
	}
}
