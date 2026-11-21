using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x020052F5 RID: 21237
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleRoleInfoView : UiPanelBase
	{
		// Token: 0x170066B0 RID: 26288
		// (get) Token: 0x06034D7A RID: 216442 RVA: 0x00EC59C2 File Offset: 0x00EC3BC2
		// (set) Token: 0x06034D7B RID: 216443 RVA: 0x00EC59CA File Offset: 0x00EC3BCA
		public new IPinballBattleRoleInfoViewParam OpenParam { get; set; }

		// Token: 0x06034D7C RID: 216444 RVA: 0x00EC59D4 File Offset: 0x00EC3BD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034D7D RID: 216445 RVA: 0x00EC5C9C File Offset: 0x00EC3E9C
		protected override void OnStart()
		{
			this.InitRoleLayout();
			this.InitDetailTabLayout();
			this.InitSkillScroll();
			this.InitAttrScroll();
			this.InitBuffScroll();
			UUISprite sprite = base.GetSprite(4);
			this.OriginalHpBarWidth = ((sprite != null) ? sprite.GetWidth() : 0f);
			UUISprite sprite2 = base.GetSprite(6);
			this.OriginalShieldBarWidth = ((sprite2 != null) ? sprite2.GetWidth() : 0f);
		}

		// Token: 0x06034D7E RID: 216446 RVA: 0x00EC5D04 File Offset: 0x00EC3F04
		protected override void OnBeforeShow()
		{
			List<PinballRoleHeadItemData> list = new List<PinballRoleHeadItemData>();
			for (int i = 0; i < this.OpenParam.RoleList.Count; i++)
			{
				int id = this.OpenParam.RoleList[i];
				PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(id);
				PinballRoleHeadItemData item = new PinballRoleHeadItemData
				{
					RoleConfig = pinballRoleConfigById.Value,
					IsSelected = (i == 0),
					IsLocked = false,
					IsTrail = pinballRoleConfigById.Value.IsTrail,
					NeedRedDot = false
				};
				list.Add(item);
			}
			GenericLayout<PinballRoleHeadItem, IPinballRoleHeadItemData> roleLayout = this.RoleLayout;
			if (roleLayout != null)
			{
				roleLayout.RefreshByData(list, null, false);
			}
			this.OnRoleHeadItemSelect(list[0]);
		}

		// Token: 0x06034D7F RID: 216447 RVA: 0x00EC5DBB File Offset: 0x00EC3FBB
		private void InitRoleLayout()
		{
			this.RoleLayout = new GenericLayout<PinballRoleHeadItem, IPinballRoleHeadItemData>(base.GetVerticalLayout(17), new Func<PinballRoleHeadItem>(this.CreateRoleHeadItem), null, false, true);
		}

		// Token: 0x06034D80 RID: 216448 RVA: 0x00EC5DDF File Offset: 0x00EC3FDF
		private PinballRoleHeadItem CreateRoleHeadItem()
		{
			return new PinballRoleHeadItem
			{
				OnSelectCallBack = delegate(IPinballRoleHeadItemData d)
				{
					this.OnRoleHeadItemSelect((PinballRoleHeadItemData)d);
				}
			};
		}

		// Token: 0x06034D81 RID: 216449 RVA: 0x00EC5DF8 File Offset: 0x00EC3FF8
		private void SelectRoleHeadData(PinballRoleHeadItemData data)
		{
			if (this.SelectedRoleHeadData != null)
			{
				this.SelectedRoleHeadData.IsSelected = false;
				GenericLayout<PinballRoleHeadItem, IPinballRoleHeadItemData> roleLayout = this.RoleLayout;
				if (roleLayout != null)
				{
					roleLayout.RefreshGridProxyByKey<int>(this.SelectedRoleHeadData.RoleConfig.Id);
				}
			}
			data.IsSelected = true;
			this.SelectedRoleHeadData = data;
			GenericLayout<PinballRoleHeadItem, IPinballRoleHeadItemData> roleLayout2 = this.RoleLayout;
			if (roleLayout2 == null)
			{
				return;
			}
			roleLayout2.RefreshGridProxyByKey<int>(data.RoleConfig.Id);
		}

		// Token: 0x06034D82 RID: 216450 RVA: 0x00EC5E6C File Offset: 0x00EC406C
		private void OnRoleHeadItemSelect(PinballRoleHeadItemData data)
		{
			this.SelectRoleHeadData(data);
			this.RefreshRole(data.RoleConfig).Forget();
			PinballBdConfig? pinballBdConfigById = PinballConfig.Instance.GetPinballBdConfigById(data.RoleConfig.Bd);
			base.TrySetTextureByPath((pinballBdConfigById != null) ? pinballBdConfigById.GetValueOrDefault().MiddleIcon : null, base.GetTexture(0), null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), PinballModel.Instance.GetRoleNameByPinballRoleConfig(data.RoleConfig), Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "Pinball_Character_List_01", new <>z__ReadOnlySingleElementList<object>(data.RoleConfig.IsTrail ? data.RoleConfig.InitLevelId : PinballModel.Instance.GetRoleLevel(data.RoleConfig.Id)));
			KscEntityHandle kscEntityByRoleId = (KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel).GetKscEntityByRoleId(data.RoleConfig.Id);
			if (kscEntityByRoleId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.LJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
				defaultInterpolatedStringHandler.AppendLiteral("找不到角色id对应的KSC实体！RoleId：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.RoleConfig.Id);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			AKSC_Entity kscEntity = kscEntityByRoleId.KscEntity;
			UKSC_SkillComp uksc_SkillComp = (kscEntity != null) ? kscEntity.GetSkillComp() : null;
			if (uksc_SkillComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.LJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral("找不到角色id对应的技能组件！RoleId：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.RoleConfig.Id);
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UKSC_AttrSet attrSet_ = uksc_SkillComp.AttrSet_;
			if (attrSet_ == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PinballBattle;
				ELogAuthor author3 = ELogAuthor.LJ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
				defaultInterpolatedStringHandler.AppendLiteral("找不到角色id对应的技能属性组件！RoleId：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.RoleConfig.Id);
				instance3.Error(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int num;
			attrSet_.Attrs_.TryGetValue(EKSC_AttrType.Life, out num);
			int num2;
			attrSet_.Attrs_.TryGetValue(EKSC_AttrType.LifeMax, out num2);
			float num3 = (float)num / (float)num2;
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetWidth(num3 * this.OriginalHpBarWidth);
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			int num4;
			attrSet_.Attrs_.TryGetValue(EKSC_AttrType.Shield, out num4);
			int num5;
			attrSet_.Attrs_.TryGetValue(EKSC_AttrType.ShieldMax, out num5);
			base.GetItem(19).SetUIActive(num4 > 0);
			base.GetSprite(6).SetUIActive(num4 > 0);
			if (num4 > 0)
			{
				float num6 = (float)num4 / (float)num5;
				base.GetSprite(6).SetWidth(num6 * this.OriginalShieldBarWidth);
				UUIText text2 = base.GetText(5);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num5);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			List<int> list = new List<int>();
			for (int i = 0; i < data.RoleConfig.SkillDisplayListLength; i++)
			{
				list.Add(data.RoleConfig.SkillDisplayList(i));
			}
			GenericScrollViewNew<PinballBattleRoleDetailSkillItem, int> skillScroll = this.SkillScroll;
			if (skillScroll != null)
			{
				skillScroll.RefreshByData(list, null, false);
			}
			List<PinballAttributeItemData> data2 = this.BuildAttrDataList(attrSet_.Attrs_);
			GenericScrollViewNew<PinballAttributeItem, IPinballAttributeItemData> attrScroll = this.AttrScroll;
			if (attrScroll != null)
			{
				attrScroll.RefreshByData(data2, null, false);
			}
			this.RefreshBuffScroll(uksc_SkillComp);
		}

		// Token: 0x06034D83 RID: 216451 RVA: 0x00EC6234 File Offset: 0x00EC4434
		private void RefreshBuffScroll(UKSC_SkillComp skillComp)
		{
			TMap<UKSC_DA_Buff, int> tmap = new TMap<UKSC_DA_Buff, int>();
			skillComp.GetAllBuffs(ref tmap);
			List<BuffView> list = new List<BuffView>();
			foreach (KeyValuePair<UKSC_DA_Buff, int> keyValuePair in tmap)
			{
				UKSC_DA_Buff uksc_DA_Buff;
				int num;
				keyValuePair.Deconstruct(out uksc_DA_Buff, out num);
				UKSC_DA_Buff key = uksc_DA_Buff;
				int buffCount = num;
				UKuroSimpleCombatSubsystem kscSubsystem = KscEnv.Instance.KscSubsystem;
				int? num2;
				if (kscSubsystem == null)
				{
					num2 = null;
				}
				else
				{
					UKSC_World kscworld = kscSubsystem.GetKSCWorld();
					num2 = ((kscworld != null) ? new int?(kscworld.LoadedBuffDa.Get(key)) : null);
				}
				int? num3 = num2;
				if (num3 != null)
				{
					BuffView buffView = PinballModel.Instance.CreateBuffView(num3.Value, buffCount);
					if (buffView != null)
					{
						list.Add(buffView);
					}
				}
			}
			if (list.Count > 0)
			{
				list.Sort((BuffView a, BuffView b) => b.Sort - a.Sort);
				GenericScrollViewNew<PinballBattleRoleDetailBuffItem, BuffView> buffScroll = this.BuffScroll;
				if (buffScroll != null)
				{
					buffScroll.RefreshByData(list, null, false);
				}
				UUIItem item = base.GetItem(9);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				GenericScrollViewNew<PinballBattleRoleDetailBuffItem, BuffView> buffScroll2 = this.BuffScroll;
				if (buffScroll2 != null)
				{
					buffScroll2.RefreshByData(list, null, false);
				}
				UUIItem item2 = base.GetItem(9);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
				return;
			}
		}

		// Token: 0x06034D84 RID: 216452 RVA: 0x00EC6390 File Offset: 0x00EC4590
		private List<PinballAttributeItemData> BuildAttrDataList(TMap<EKSC_AttrType, int> attrs)
		{
			List<PinballAttributeItemData> list = new List<PinballAttributeItemData>();
			int id = PinballModel.Instance.ActivityData.Id;
			PinballActivity? pinballActivityConfigByActivityId = PinballConfig.Instance.GetPinballActivityConfigByActivityId(id);
			if (pinballActivityConfigByActivityId == null)
			{
				return list;
			}
			int battleAttrShowListLength = pinballActivityConfigByActivityId.Value.BattleAttrShowListLength;
			for (int i = 0; i < battleAttrShowListLength; i++)
			{
				int num = pinballActivityConfigByActivityId.Value.BattleAttrShowList(i);
				PinballPropertyIndex? pinballPropertyIndexConfigById = PinballConfig.Instance.GetPinballPropertyIndexConfigById(num);
				if (pinballPropertyIndexConfigById == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Pinball;
					ELogAuthor author = ELogAuthor.CB;
					string message = "属性配置不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("attrId", num);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					EPinballAttr epinballAttr = (EPinballAttr)num;
					int attributeValue;
					if (epinballAttr != EPinballAttr.Atk)
					{
						if (epinballAttr != EPinballAttr.CritDamage)
						{
							int num2;
							attrs.TryGetValue((EKSC_AttrType)pinballPropertyIndexConfigById.Value.KscAttrType, out num2);
							attributeValue = num2;
						}
						else
						{
							int num3;
							attrs.TryGetValue(EKSC_AttrType.CritDamage, out num3);
							attributeValue = num3 + 10000;
						}
					}
					else
					{
						int num4;
						attrs.TryGetValue(EKSC_AttrType.Atk, out num4);
						int num5;
						attrs.TryGetValue(EKSC_AttrType.AtkChange, out num5);
						int num6;
						attrs.TryGetValue(EKSC_AttrType.AtkExtra, out num6);
						attributeValue = (int)Math.Ceiling((double)((float)num4 * (1f + (float)num5 * 0.0001f) + (float)num6));
					}
					PinballAttributeItemData item = new PinballAttributeItemData
					{
						IsBgShow = (i % 2 == 1),
						AttributeConfig = pinballPropertyIndexConfigById.Value,
						AttributeValue = attributeValue
					};
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06034D85 RID: 216453 RVA: 0x00EC6510 File Offset: 0x00EC4710
		private UniTask RefreshRole(PinballRoleConfig config)
		{
			PinballBattleRoleInfoView.<RefreshRole>d__22 <RefreshRole>d__;
			<RefreshRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRole>d__.<>4__this = this;
			<RefreshRole>d__.config = config;
			<RefreshRole>d__.<>1__state = -1;
			<RefreshRole>d__.<>t__builder.Start<PinballBattleRoleInfoView.<RefreshRole>d__22>(ref <RefreshRole>d__);
			return <RefreshRole>d__.<>t__builder.Task;
		}

		// Token: 0x06034D86 RID: 216454 RVA: 0x00EC655C File Offset: 0x00EC475C
		private void InitDetailTabLayout()
		{
			this.DetailTabLayout = new GenericLayout<PinballBattleRoleDetailTabItem, EPinballBattleRoleDetailTabType>(base.GetHorizontalLayout(7), new Func<PinballBattleRoleDetailTabItem>(this.CreateDetailTabItem), null, false, true);
			List<EPinballBattleRoleDetailTabType> data = new List<EPinballBattleRoleDetailTabType>
			{
				EPinballBattleRoleDetailTabType.Buff,
				EPinballBattleRoleDetailTabType.Attr,
				EPinballBattleRoleDetailTabType.Skill
			};
			GenericLayout<PinballBattleRoleDetailTabItem, EPinballBattleRoleDetailTabType> detailTabLayout = this.DetailTabLayout;
			if (detailTabLayout == null)
			{
				return;
			}
			detailTabLayout.RefreshByData(data, delegate
			{
				GenericLayout<PinballBattleRoleDetailTabItem, EPinballBattleRoleDetailTabType> detailTabLayout2 = this.DetailTabLayout;
				if (detailTabLayout2 == null)
				{
					return;
				}
				detailTabLayout2.SelectGridProxy(0, true);
			}, false);
		}

		// Token: 0x06034D87 RID: 216455 RVA: 0x00EC65C3 File Offset: 0x00EC47C3
		private PinballBattleRoleDetailTabItem CreateDetailTabItem()
		{
			return new PinballBattleRoleDetailTabItem
			{
				OnSelectCallBack = new Action<EPinballBattleRoleDetailTabType>(this.OnDetailTabItemSelect)
			};
		}

		// Token: 0x06034D88 RID: 216456 RVA: 0x00EC65DC File Offset: 0x00EC47DC
		private void OnDetailTabItemSelect(EPinballBattleRoleDetailTabType data)
		{
			switch (data)
			{
			case EPinballBattleRoleDetailTabType.Buff:
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(14);
				if (scrollViewWithScrollbar != null)
				{
					scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(true);
				}
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(12);
				if (scrollViewWithScrollbar2 != null)
				{
					scrollViewWithScrollbar2.RootUIComp.Get().SetUIActive(false);
				}
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar3 = base.GetScrollViewWithScrollbar(10);
				if (scrollViewWithScrollbar3 == null)
				{
					return;
				}
				scrollViewWithScrollbar3.RootUIComp.Get().SetUIActive(false);
				return;
			}
			case EPinballBattleRoleDetailTabType.Attr:
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar4 = base.GetScrollViewWithScrollbar(14);
				if (scrollViewWithScrollbar4 != null)
				{
					scrollViewWithScrollbar4.RootUIComp.Get().SetUIActive(false);
				}
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar5 = base.GetScrollViewWithScrollbar(12);
				if (scrollViewWithScrollbar5 != null)
				{
					scrollViewWithScrollbar5.RootUIComp.Get().SetUIActive(true);
				}
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar6 = base.GetScrollViewWithScrollbar(10);
				if (scrollViewWithScrollbar6 == null)
				{
					return;
				}
				scrollViewWithScrollbar6.RootUIComp.Get().SetUIActive(false);
				return;
			}
			case EPinballBattleRoleDetailTabType.Skill:
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar7 = base.GetScrollViewWithScrollbar(14);
				if (scrollViewWithScrollbar7 != null)
				{
					scrollViewWithScrollbar7.RootUIComp.Get().SetUIActive(false);
				}
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar8 = base.GetScrollViewWithScrollbar(12);
				if (scrollViewWithScrollbar8 != null)
				{
					scrollViewWithScrollbar8.RootUIComp.Get().SetUIActive(false);
				}
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar9 = base.GetScrollViewWithScrollbar(10);
				if (scrollViewWithScrollbar9 == null)
				{
					return;
				}
				scrollViewWithScrollbar9.RootUIComp.Get().SetUIActive(true);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06034D89 RID: 216457 RVA: 0x00EC6724 File Offset: 0x00EC4924
		private void InitSkillScroll()
		{
			this.SkillScroll = new GenericScrollViewNew<PinballBattleRoleDetailSkillItem, int>(base.GetScrollViewWithScrollbar(10), new Func<PinballBattleRoleDetailSkillItem>(this.CreateSkillItem), null, false, null);
		}

		// Token: 0x06034D8A RID: 216458 RVA: 0x00EC6748 File Offset: 0x00EC4948
		private PinballBattleRoleDetailSkillItem CreateSkillItem()
		{
			return new PinballBattleRoleDetailSkillItem();
		}

		// Token: 0x06034D8B RID: 216459 RVA: 0x00EC674F File Offset: 0x00EC494F
		private void InitAttrScroll()
		{
			this.AttrScroll = new GenericScrollViewNew<PinballAttributeItem, IPinballAttributeItemData>(base.GetScrollViewWithScrollbar(12), new Func<PinballAttributeItem>(this.CreateAttrItem), null, false, null);
		}

		// Token: 0x06034D8C RID: 216460 RVA: 0x00EC6773 File Offset: 0x00EC4973
		private PinballAttributeItem CreateAttrItem()
		{
			return new PinballAttributeItem();
		}

		// Token: 0x06034D8D RID: 216461 RVA: 0x00EC677A File Offset: 0x00EC497A
		private void InitBuffScroll()
		{
			this.BuffScroll = new GenericScrollViewNew<PinballBattleRoleDetailBuffItem, BuffView>(base.GetScrollViewWithScrollbar(14), new Func<PinballBattleRoleDetailBuffItem>(this.CreateBuffItem), null, false, null);
		}

		// Token: 0x06034D8E RID: 216462 RVA: 0x00EC679E File Offset: 0x00EC499E
		private PinballBattleRoleDetailBuffItem CreateBuffItem()
		{
			return new PinballBattleRoleDetailBuffItem();
		}

		// Token: 0x0401BF3A RID: 114490
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballRoleHeadItem, IPinballRoleHeadItemData> RoleLayout;

		// Token: 0x0401BF3B RID: 114491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PinballBattleRoleDetailTabItem, EPinballBattleRoleDetailTabType> DetailTabLayout;

		// Token: 0x0401BF3C RID: 114492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<PinballBattleRoleDetailSkillItem, int> SkillScroll;

		// Token: 0x0401BF3D RID: 114493
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<PinballAttributeItem, IPinballAttributeItemData> AttrScroll;

		// Token: 0x0401BF3E RID: 114494
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<PinballBattleRoleDetailBuffItem, BuffView> BuffScroll;

		// Token: 0x0401BF3F RID: 114495
		private float OriginalHpBarWidth;

		// Token: 0x0401BF40 RID: 114496
		private float OriginalShieldBarWidth;

		// Token: 0x0401BF41 RID: 114497
		[Nullable(2)]
		private PinballRoleHeadItemData SelectedRoleHeadData;

		// Token: 0x0200AF77 RID: 44919
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036391 RID: 222097
			TexRoleType,
			// Token: 0x04036392 RID: 222098
			TxtRoleName,
			// Token: 0x04036393 RID: 222099
			TxtRoleLevel,
			// Token: 0x04036394 RID: 222100
			TxtHpNum,
			// Token: 0x04036395 RID: 222101
			SpriteHpBar,
			// Token: 0x04036396 RID: 222102
			TxtShieldNum,
			// Token: 0x04036397 RID: 222103
			SpriteShieldBar,
			// Token: 0x04036398 RID: 222104
			DetailTabLayout,
			// Token: 0x04036399 RID: 222105
			DetailTabLayoutItem,
			// Token: 0x0403639A RID: 222106
			DetailEmpty,
			// Token: 0x0403639B RID: 222107
			ScrollSkill,
			// Token: 0x0403639C RID: 222108
			ScrollSkillItem,
			// Token: 0x0403639D RID: 222109
			ScrollAttr,
			// Token: 0x0403639E RID: 222110
			ScrollAttrItem,
			// Token: 0x0403639F RID: 222111
			ScrollBuff,
			// Token: 0x040363A0 RID: 222112
			BuffLayoutItem,
			// Token: 0x040363A1 RID: 222113
			SpineRole,
			// Token: 0x040363A2 RID: 222114
			RoleHeadLayout,
			// Token: 0x040363A3 RID: 222115
			RoleHeadLayoutItem,
			// Token: 0x040363A4 RID: 222116
			PnlShiledNum
		}
	}
}
