using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004300 RID: 17152
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResSkillNode : UiPanelBase
	{
		// Token: 0x0602B610 RID: 177680 RVA: 0x00C310A8 File Offset: 0x00C2F2A8
		public RogueResSkillNode(UUIItem parent, RogueResTalentTree data, UUIItem gridPanelItem)
		{
			this.Data = new RogueResTalentTree?(data);
			this.PreItem = parent;
			this.GridPanelItem = gridPanelItem;
		}

		// Token: 0x0602B611 RID: 177681 RVA: 0x00C310D8 File Offset: 0x00C2F2D8
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
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
		}

		// Token: 0x0602B612 RID: 177682 RVA: 0x00C31212 File Offset: 0x00C2F412
		protected void OnToggleStateChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				EventSystem.Instance.Emit<RogueResSkillNode>(EEventName.RogueResSelectSkill, this);
			}
		}

		// Token: 0x0602B613 RID: 177683 RVA: 0x00C31229 File Offset: 0x00C2F429
		protected override void OnStart()
		{
			base.GetExtendToggle(11).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(11).bLockStateOnSelect = true;
		}

		// Token: 0x0602B614 RID: 177684 RVA: 0x00C31258 File Offset: 0x00C2F458
		public void Refresh(RogueResTalentTree? data = null)
		{
			RogueResTalentTree? rogueResTalentTree = data;
			this.Data = ((rogueResTalentTree != null) ? rogueResTalentTree : this.Data);
			UUIItem uuiitem = this.RootItem.GetOwner().GetAttachParentActor().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			float parentWidth = uuiitem.GetWidth();
			float parentHeight = uuiitem.GetHeight();
			float rootWidth = base.GetItem(4).GetAnchorOffsetX();
			float lineDefaultWidth = (parentWidth / 2f - rootWidth) * 2f;
			int skillLevelById = ActivityPermanentRogueModel.Instance.GetSkillLevelById(this.Data.Value.Id);
			bool flag = skillLevelById == this.Data.Value.ConsuleLength;
			RogueResSort? config = ConfigRogueResSortById.GetConfig(this.Data.Value.Id, true);
			int postIdLength = config.Value.PostIdLength;
			for (int i = 0; i < postIdLength; i++)
			{
				RogueResSort? config2 = ConfigRogueResSortById.GetConfig(config.Value.PostId(i), true);
				int skillLevelById2 = ActivityPermanentRogueModel.Instance.GetSkillLevelById(config2.Value.Id);
				int num = config2.Value.Row - config.Value.Row;
				UUIItem outPosItem = this.GetOutPosItem(num);
				if (i >= this.LineComponentList.Count || this.LineComponentList[i] == null)
				{
					int capturedI = i;
					int capturedOffset = num;
					int capturedCurLevel = skillLevelById;
					int capturedChildLevel = skillLevelById2;
					RogueResSort? capturedSortParam = config;
					LguiUtil.Instance.LoadPrefabByResourceIdAsync("UiItem_RoguelikeSkillLine", outPosItem, null, ResourceSystem.EResourceLoadPriority.Default, "js_undefined").ContinueWith(delegate(AActor prefab)
					{
						if (prefab == null)
						{
							return;
						}
						RogueResSkillLine component = new RogueResSkillLine();
						UUIItem uuiitem2 = prefab.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
						if (capturedOffset == 0)
						{
							uuiitem2.SetWidth(lineDefaultWidth);
						}
						else
						{
							uuiitem2.SetWidth((float)Math.Sqrt((double)(parentWidth * parentWidth + parentHeight * parentHeight)) - rootWidth * 2f);
						}
						uuiitem2.SetAnchorOffsetX(0f);
						component.CreateThenShowByActorAsync(prefab, null, false).ContinueWith(delegate()
						{
							component.Refresh(capturedCurLevel > 0 && capturedChildLevel > 0, capturedOffset, capturedSortParam.Value.Row);
						});
						while (this.LineComponentList.Count <= capturedI)
						{
							this.LineComponentList.Add(null);
						}
						this.LineComponentList[capturedI] = component;
					});
				}
				else
				{
					this.LineComponentList[i].Refresh(skillLevelById > 0 && skillLevelById2 > 0, num, config.Value.Row);
				}
			}
			RogueResTalentTreeDesc? config3 = ConfigRogueResTalentTreeDescById.GetConfig(this.Data.Value.Describe, true);
			RogueResTheme? config4 = ConfigRogueResThemeById.GetConfig(this.Data.Value.SeasonId, true);
			bool flag2 = ActivityPermanentRogueModel.Instance.GetCurrency(config4.Value.SkillItem) >= ((skillLevelById >= 0 && skillLevelById < this.Data.Value.ConsuleLength) ? this.Data.Value.Consule(skillLevelById) : 0);
			this.SetSpriteByPath(config3.Value.TalentIcon, base.GetSprite(9), false, null, null);
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			int? num2 = (instance != null) ? new int?(instance.SelectSkillId) : null;
			int id = this.Data.Value.Id;
			if (num2.GetValueOrDefault() == id & num2 != null)
			{
				EventSystem.Instance.Emit<RogueResSkillNode>(EEventName.RogueResSelectSkill, this);
			}
			if (skillLevelById < 0)
			{
				base.GetItem(6).SetUIActive(true);
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(10).SetUIActive(false);
				base.GetItem(12).SetUIActive(true);
				base.GetSprite(9).SetColor(FColor.FromHex("808080"));
				return;
			}
			if (skillLevelById == 0)
			{
				base.GetItem(6).SetUIActive(true);
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(10).SetUIActive(flag2);
				base.GetItem(12).SetUIActive(false);
				base.GetSprite(9).SetColor(FColor.FromHex("FFFFFF"));
				return;
			}
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(!flag);
			base.GetItem(8).SetUIActive(flag);
			base.GetItem(10).SetUIActive(!flag && flag2);
			base.GetItem(12).SetUIActive(false);
			base.GetSprite(9).SetColor(FColor.FromHex("FFFFFF"));
		}

		// Token: 0x0602B615 RID: 177685 RVA: 0x00C316C6 File Offset: 0x00C2F8C6
		public UUIItem GetOutPosItem(int offset)
		{
			if (offset > 0)
			{
				return base.GetItem(5);
			}
			if (offset < 0)
			{
				return base.GetItem(3);
			}
			return base.GetItem(4);
		}

		// Token: 0x0602B616 RID: 177686 RVA: 0x00C316E7 File Offset: 0x00C2F8E7
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(11).SetToggleState(state, false, false, false);
		}

		// Token: 0x040176D6 RID: 95958
		public RogueResTalentTree? Data;

		// Token: 0x040176D7 RID: 95959
		[Nullable(2)]
		public UUIItem PreItem;

		// Token: 0x040176D8 RID: 95960
		public List<RogueResSkillLine> LineComponentList = new List<RogueResSkillLine>();

		// Token: 0x040176D9 RID: 95961
		[Nullable(2)]
		public UUIItem GridPanelItem;
	}
}
