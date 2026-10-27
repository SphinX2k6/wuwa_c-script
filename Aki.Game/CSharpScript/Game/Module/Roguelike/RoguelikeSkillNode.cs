using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E2D RID: 20013
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeSkillNode : UiPanelBase
	{
		// Token: 0x060339B1 RID: 211377 RVA: 0x00C13268 File Offset: 0x00C11468
		public RoguelikeSkillNode(UUIItem parent, RogueTalentTree data, UUIItem gridPanelItem)
		{
			this.Data = new RogueTalentTree?(data);
			this.PreItem = parent;
			this.GridPanelItem = gridPanelItem;
		}

		// Token: 0x060339B2 RID: 211378 RVA: 0x00C13298 File Offset: 0x00C11498
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060339B3 RID: 211379 RVA: 0x00C13471 File Offset: 0x00C11671
		protected void OnToggleStateChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				EventSystem.Instance.Emit<RoguelikeSkillNode>(EEventName.RoguelikeSelectSkill, this);
			}
		}

		// Token: 0x060339B4 RID: 211380 RVA: 0x00C13488 File Offset: 0x00C11688
		protected override void OnStart()
		{
			base.GetExtendToggle(11).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
			base.GetExtendToggle(11).bLockStateOnSelect = true;
		}

		// Token: 0x060339B5 RID: 211381 RVA: 0x00C134B8 File Offset: 0x00C116B8
		public void Refresh(RogueTalentTree? data = null)
		{
			this.Data = ((data != null) ? data : this.Data);
			UUIItem uuiitem = this.RootItem.GetOwner().GetAttachParentActor().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			float parentWidth = uuiitem.GetWidth();
			float parentHeight = uuiitem.GetHeight();
			float rootWidth = base.GetItem(4).GetAnchorOffsetX();
			float lineDefaultWidth = (parentWidth / 2f - rootWidth) * 2f;
			int num = RoguelikeModel.Instance.RoguelikeSkillDataMap[this.Data.Value.Id];
			bool flag = num == this.Data.Value.ConsuleLength;
			int i;
			int j;
			for (i = 0; i < this.Data.Value.PostIdLength; i = j + 1)
			{
				RogueTalentTree? rogueTalentTreeById = RoguelikeConfig.Instance.GetRogueTalentTreeById(this.Data.Value.PostId(i));
				int childLevel = RoguelikeModel.Instance.RoguelikeSkillDataMap[rogueTalentTreeById.Value.Id];
				int offset = rogueTalentTreeById.Value.Row - this.Data.Value.Row;
				UUIItem outPosItem = this.GetOutPosItem(offset);
				if (this.LineComponentList.Count <= i || this.LineComponentList[i] == null)
				{
					LguiUtil.Instance.LoadPrefabByResourceIdAsync("UiItem_RoguelikeSkillLine", outPosItem, null, ResourceSystem.EResourceLoadPriority.Default, "js_undefined").ContinueWith(delegate(AActor prefab)
					{
						if (prefab == null)
						{
							return;
						}
						RoguelikeSkillLine component = new RoguelikeSkillLine();
						UUIItem uuiitem2 = prefab.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
						int curLevel = RoguelikeModel.Instance.RoguelikeSkillDataMap[this.Data.Value.Id];
						if (offset == 0)
						{
							uuiitem2.SetWidth(lineDefaultWidth);
						}
						else
						{
							uuiitem2.SetWidth((float)Math.Sqrt((double)(parentWidth * parentWidth + parentHeight * parentHeight)) - rootWidth * 2f);
						}
						component.CreateThenShowByActorAsync(prefab, null, false).ContinueWith(delegate()
						{
							component.Refresh(curLevel > 0 && childLevel > 0, offset, this.Data.Value.Row);
						});
						while (this.LineComponentList.Count <= i)
						{
							this.LineComponentList.Add(null);
						}
						this.LineComponentList[i] = component;
					});
				}
				else
				{
					RoguelikeSkillLine roguelikeSkillLine = this.LineComponentList[i];
					int num2 = RoguelikeModel.Instance.RoguelikeSkillDataMap[this.Data.Value.Id];
					roguelikeSkillLine.Refresh(num2 > 0 && childLevel > 0, offset, this.Data.Value.Row);
				}
				j = i;
			}
			RogueTalentTreeDesc? rogueTalentTreeDescConfig = RoguelikeConfig.Instance.GetRogueTalentTreeDescConfig(this.Data.Value.Describe);
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			RoguelikeModel instance = RoguelikeModel.Instance;
			int? num3 = (instance != null) ? new int?(instance.GetRoguelikeCurrency(paramConfigBySeasonId.Value.SkillPoint)) : null;
			bool flag2 = num >= 0 && num < this.Data.Value.ConsuleLength && num3.Value >= this.Data.Value.Consule(num);
			this.SetSpriteByPath(rogueTalentTreeDescConfig.Value.TalentIcon, base.GetSprite(9), false, null, null);
			if (num < 0)
			{
				base.GetItem(6).SetUIActive(true);
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(10).SetUIActive(false);
				base.GetItem(12).SetUIActive(true);
				base.GetSprite(9).SetColor(FColor.FromHex("808080"));
				return;
			}
			if (num == 0)
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

		// Token: 0x060339B6 RID: 211382 RVA: 0x00C1392E File Offset: 0x00C11B2E
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

		// Token: 0x060339B7 RID: 211383 RVA: 0x00C1394F File Offset: 0x00C11B4F
		public void SetToggleState(EToggleState state)
		{
			base.GetExtendToggle(11).SetToggleState(state, false, false, false);
		}

		// Token: 0x0401B5F2 RID: 112114
		public RogueTalentTree? Data;

		// Token: 0x0401B5F3 RID: 112115
		[Nullable(2)]
		public UUIItem PreItem;

		// Token: 0x0401B5F4 RID: 112116
		public List<RoguelikeSkillLine> LineComponentList = new List<RoguelikeSkillLine>();

		// Token: 0x0401B5F5 RID: 112117
		[Nullable(2)]
		public UUIItem GridPanelItem;

		// Token: 0x0200AFDC RID: 45020
		[NullableContext(0)]
		public class ERoguelikeSkillNodeDefine
		{
			// Token: 0x0403563B RID: 218683
			public const int InPos1 = 0;

			// Token: 0x0403563C RID: 218684
			public const int InPos2 = 1;

			// Token: 0x0403563D RID: 218685
			public const int InPos3 = 2;

			// Token: 0x0403563E RID: 218686
			public const int OutPos1 = 3;

			// Token: 0x0403563F RID: 218687
			public const int OutPos2 = 4;

			// Token: 0x04035640 RID: 218688
			public const int OutPos3 = 5;

			// Token: 0x04035641 RID: 218689
			public const int LockItem = 6;

			// Token: 0x04035642 RID: 218690
			public const int UnlockItem = 7;

			// Token: 0x04035643 RID: 218691
			public const int ActivateItem = 8;

			// Token: 0x04035644 RID: 218692
			public const int SkillIcon = 9;

			// Token: 0x04035645 RID: 218693
			public const int UpItem = 10;

			// Token: 0x04035646 RID: 218694
			public const int Toggle = 11;

			// Token: 0x04035647 RID: 218695
			public const int SpriteLock = 12;
		}
	}
}
