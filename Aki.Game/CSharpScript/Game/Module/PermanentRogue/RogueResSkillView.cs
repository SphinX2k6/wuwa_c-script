using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004306 RID: 17158
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResSkillView : UiViewBase
	{
		// Token: 0x0602B621 RID: 177697 RVA: 0x00C31967 File Offset: 0x00C2FB67
		public RogueResSkillView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B622 RID: 177698 RVA: 0x00C31994 File Offset: 0x00C2FB94
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnBtnSkillOverViewClick)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnBtnMaskClick))
			};
		}

		// Token: 0x0602B623 RID: 177699 RVA: 0x00C31A84 File Offset: 0x00C2FC84
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResSkillView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResSkillView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B624 RID: 177700 RVA: 0x00C31AC8 File Offset: 0x00C2FCC8
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			});
			int num = (int)this.OpenParam;
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(num, true);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetCurrencyItemList(new int[]
				{
					config.Value.SkillItem
				});
			}
			ActivityPermanentRogueModel.Instance.SetCacheSkillTreeOpen(num);
			EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, num);
		}

		// Token: 0x0602B625 RID: 177701 RVA: 0x00C31B58 File Offset: 0x00C2FD58
		protected override void OnBeforeShow()
		{
			if (this.SelectColumn > 0 && this.TotalColumn > 0)
			{
				this.ScrollView.BindLateUpdate(delegate(float delta)
				{
					if (this.ExecuteCount == 15)
					{
						base.GetScrollViewWithScrollbar(3).SetScrollProgress(1f - (float)(this.SelectColumn + 1) / (float)(this.TotalColumn + 1));
						this.SelectColumn = -1;
						this.TotalColumn = -1;
						this.ScrollView.UnBindLateUpdate();
					}
					this.ExecuteCount++;
				});
			}
		}

		// Token: 0x0602B626 RID: 177702 RVA: 0x00C31B83 File Offset: 0x00C2FD83
		protected override void OnBeforeDestroy()
		{
			GenericScrollViewNew<RogueResSkillGridPanel, List<RogueResTalentTree>> scrollView = this.ScrollView;
			if (scrollView == null)
			{
				return;
			}
			scrollView.UnBindLateUpdate();
		}

		// Token: 0x0602B627 RID: 177703 RVA: 0x00C31B95 File Offset: 0x00C2FD95
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RogueResSkillNode>(EEventName.RogueResSelectSkill, new Action<RogueResSkillNode>(this.OnSelectSkill));
			EventSystem.Instance.Add<int>(EEventName.RogueResTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x0602B628 RID: 177704 RVA: 0x00C31BCF File Offset: 0x00C2FDCF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueResSelectSkill, new Action<RogueResSkillNode>(this.OnSelectSkill));
			EventSystem.Instance.Remove(EEventName.RogueResTalentLevelUp, new Action<int>(this.OnSkillLevelUp));
		}

		// Token: 0x0602B629 RID: 177705 RVA: 0x00C31C09 File Offset: 0x00C2FE09
		protected RogueResSkillGridPanel CreateGridPanel()
		{
			return new RogueResSkillGridPanel();
		}

		// Token: 0x0602B62A RID: 177706 RVA: 0x00C31C10 File Offset: 0x00C2FE10
		protected void OnSkillLevelUp(int skillId)
		{
			int p = (int)this.OpenParam;
			EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, p);
			GenericScrollViewNew<RogueResSkillGridPanel, List<RogueResTalentTree>> scrollView = this.ScrollView;
			List<RogueResSkillGridPanel> list = (scrollView != null) ? scrollView.GetScrollItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (RogueResSkillGridPanel rogueResSkillGridPanel in list)
			{
				foreach (RogueResSkillNode rogueResSkillNode in rogueResSkillGridPanel.NodeMap)
				{
					if (rogueResSkillNode != null)
					{
						rogueResSkillNode.Refresh(null);
						RogueResTheme? config = ConfigRogueResThemeById.GetConfig((int)this.OpenParam, true);
						this.CaptionItem.SetCurrencyItemList(new int[]
						{
							config.Value.SkillItem
						});
					}
				}
			}
		}

		// Token: 0x0602B62B RID: 177707 RVA: 0x00C31D18 File Offset: 0x00C2FF18
		protected void OnBtnMaskClick()
		{
			(base.GetButton(6).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(false);
			this.SkillDetailPanel.SetActive(false);
			this.CurSelectNode.SetToggleState(EToggleState.ETT_UnChecked);
		}

		// Token: 0x0602B62C RID: 177708 RVA: 0x00C31D58 File Offset: 0x00C2FF58
		protected void OnBtnSkillOverViewClick()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueResSkillOverView, this.OpenParam, null);
		}

		// Token: 0x0602B62D RID: 177709 RVA: 0x00C31D70 File Offset: 0x00C2FF70
		protected void OnSelectSkill(RogueResSkillNode skillNode)
		{
			if (this.CurSelectNode != null)
			{
				this.CurSelectNode.SetToggleState(EToggleState.ETT_UnChecked);
			}
			ActivityPermanentRogueModel.Instance.SelectSkillId = skillNode.Data.Value.Id;
			this.CurSelectNode = skillNode;
			this.CurSelectNode.SetToggleState(EToggleState.ETT_Checked);
			if (this.SelectColumn == -1)
			{
				GenericScrollViewNew<RogueResSkillGridPanel, List<RogueResTalentTree>> scrollView = this.ScrollView;
				if (scrollView != null)
				{
					scrollView.ScrollTo(skillNode.GridPanelItem, false);
				}
			}
			this.SkillDetailPanel.Refresh(skillNode.Data.Value);
			this.SkillDetailPanel.SetActive(true);
		}

		// Token: 0x0602B62E RID: 177710 RVA: 0x00C31E04 File Offset: 0x00C30004
		public void BuildSkillTreeConfig()
		{
			int num = (int)this.OpenParam;
			IEnumerable<RogueResTalentTree> configList = ConfigRogueResTalentTreeAll.GetConfigList(true);
			List<RogueResTalentTree> list = new List<RogueResTalentTree>();
			foreach (RogueResTalentTree item in configList)
			{
				if (item.SeasonId == num)
				{
					list.Add(item);
				}
			}
			Dictionary<int, RogueResSort> sortParamMap = new Dictionary<int, RogueResSort>();
			foreach (RogueResTalentTree rogueResTalentTree in list)
			{
				sortParamMap[rogueResTalentTree.Id] = ConfigRogueResSortById.GetConfig(rogueResTalentTree.Id, true).Value;
			}
			list.Sort((RogueResTalentTree a, RogueResTalentTree b) => sortParamMap[a.Id].Column - sortParamMap[b.Id].Column);
			foreach (RogueResTalentTree item2 in list)
			{
				RogueResSort rogueResSort = sortParamMap[item2.Id];
				while (this.SkillTreeConfigList.Count <= rogueResSort.Column)
				{
					this.SkillTreeConfigList.Add(new List<RogueResTalentTree>());
				}
				if (ActivityPermanentRogueModel.Instance.GetSkillLevelById(item2.Id) == 0 && rogueResSort.Column > this.SelectColumn)
				{
					this.SelectColumn = rogueResSort.Column;
				}
				if (rogueResSort.Column > this.TotalColumn)
				{
					this.TotalColumn = rogueResSort.Column;
				}
				this.SkillTreeConfigList[rogueResSort.Column].Add(item2);
			}
			Comparison<RogueResTalentTree> <>9__1;
			foreach (List<RogueResTalentTree> list2 in this.SkillTreeConfigList)
			{
				if (list2 != null)
				{
					Comparison<RogueResTalentTree> comparison;
					if ((comparison = <>9__1) == null)
					{
						comparison = (<>9__1 = ((RogueResTalentTree a, RogueResTalentTree b) => sortParamMap[a.Id].Row - sortParamMap[b.Id].Row));
					}
					list2.Sort(comparison);
				}
			}
			ActivityPermanentRogueModel.Instance.SelectSkillId = ActivityPermanentRogueModel.Instance.GetNextCanUnlockSkillId(num);
		}

		// Token: 0x040176F2 RID: 95986
		private const int ANIM_ENDCOUNT = 15;

		// Token: 0x040176F3 RID: 95987
		public List<List<RogueResTalentTree>> SkillTreeConfigList = new List<List<RogueResTalentTree>>();

		// Token: 0x040176F4 RID: 95988
		public List<RogueResSkillGridPanel> SkillGridList = new List<RogueResSkillGridPanel>();

		// Token: 0x040176F5 RID: 95989
		[Nullable(2)]
		public PopupCaptionItem CaptionItem;

		// Token: 0x040176F6 RID: 95990
		[Nullable(2)]
		public RogueResSkillNode CurSelectNode;

		// Token: 0x040176F7 RID: 95991
		[Nullable(2)]
		public RogueResSkillDetail SkillDetailPanel;

		// Token: 0x040176F8 RID: 95992
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericScrollViewNew<RogueResSkillGridPanel, List<RogueResTalentTree>> ScrollView;

		// Token: 0x040176F9 RID: 95993
		public int SelectColumn;

		// Token: 0x040176FA RID: 95994
		private int TotalColumn = -1;

		// Token: 0x040176FB RID: 95995
		public int ExecuteCount = 1;
	}
}
