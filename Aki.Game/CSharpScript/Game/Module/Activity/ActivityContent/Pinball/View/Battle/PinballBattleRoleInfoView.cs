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
	// Token: 0x02006377 RID: 25463
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballBattleRoleInfoView : UiPanelBase
	{
		// Token: 0x1700934E RID: 37710
		// (get) Token: 0x060400B9 RID: 262329 RVA: 0x00F7EA62 File Offset: 0x00F7CC62
		// (set) Token: 0x060400BA RID: 262330 RVA: 0x00F7EA6A File Offset: 0x00F7CC6A
		public new IPinballBattleRoleInfoViewParam OpenParam { get; set; }

		// Token: 0x060400BB RID: 262331 RVA: 0x00F7EA74 File Offset: 0x00F7CC74
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

		// Token: 0x060400BC RID: 262332 RVA: 0x00F7ED3C File Offset: 0x00F7CF3C
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

		// Token: 0x060400BD RID: 262333 RVA: 0x00F7EDA4 File Offset: 0x00F7CFA4
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

		// Token: 0x060400BE RID: 262334 RVA: 0x00F7EE5B File Offset: 0x00F7D05B
		private void InitRoleLayout()
		{
			this.RoleLayout = new GenericLayout<PinballRoleHeadItem, IPinballRoleHeadItemData>(base.GetVerticalLayout(17), new Func<PinballRoleHeadItem>(this.CreateRoleHeadItem), null, false, true);
		}

		// Token: 0x060400BF RID: 262335 RVA: 0x00F7EE7F File Offset: 0x00F7D07F
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

		// Token: 0x060400C0 RID: 262336 RVA: 0x00F7EE98 File Offset: 0x00F7D098
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

		// Token: 0x060400C1 RID: 262337 RVA: 0x00F7EF0C File Offset: 0x00F7D10C
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

		// Token: 0x060400C2 RID: 262338 RVA: 0x00F7F2D4 File Offset: 0x00F7D4D4
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

		// Token: 0x060400C3 RID: 262339 RVA: 0x00F7F42C File Offset: 0x00F7D62C
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

		// Token: 0x060400C4 RID: 262340 RVA: 0x00F7F5AC File Offset: 0x00F7D7AC
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

		// Token: 0x060400C5 RID: 262341 RVA: 0x00F7F5F8 File Offset: 0x00F7D7F8
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

		// Token: 0x060400C6 RID: 262342 RVA: 0x00F7F65F File Offset: 0x00F7D85F
		private PinballBattleRoleDetailTabItem CreateDetailTabItem()
		{
			return new PinballBattleRoleDetailTabItem
			{
				OnSelectCallBack = new Action<EPinballBattleRoleDetailTabType>(this.OnDetailTabItemSelect)
			};
		}

		// Token: 0x060400C7 RID: 262343 RVA: 0x00F7F678 File Offset: 0x00F7D878
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

		// Token: 0x060400C8 RID: 262344 RVA: 0x00F7F7C0 File Offset: 0x00F7D9C0
		private void InitSkillScroll()
		{
			this.SkillScroll = new GenericScrollViewNew<PinballBattleRoleDetailSkillItem, int>(base.GetScrollViewWithScrollbar(10), new Func<PinballBattleRoleDetailSkillItem>(this.CreateSkillItem), null, false, null);
		}

		// Token: 0x060400C9 RID: 262345 RVA: 0x00F7F7E4 File Offset: 0x00F7D9E4
		private PinballBattleRoleDetailSkillItem CreateSkillItem()
		{
			return new PinballBattleRoleDetailSkillItem();
		}

		// Token: 0x060400CA RID: 262346 RVA: 0x00F7F7EB File Offset: 0x00F7D9EB
		private void InitAttrScroll()
		{
			this.AttrScroll = new GenericScrollViewNew<PinballAttributeItem, IPinballAttributeItemData>(base.GetScrollViewWithScrollbar(12), new Func<PinballAttributeItem>(this.CreateAttrItem), null, false, null);
		}

		// Token: 0x060400CB RID: 262347 RVA: 0x00F7F80F File Offset: 0x00F7DA0F
		private PinballAttributeItem CreateAttrItem()
		{
			return new PinballAttributeItem();
		}

		// Token: 0x060400CC RID: 262348 RVA: 0x00F7F816 File Offset: 0x00F7DA16
		private void InitBuffScroll()
		{
			this.BuffScroll = new GenericScrollViewNew<PinballBattleRoleDetailBuffItem, BuffView>(base.GetScrollViewWithScrollbar(14), new Func<PinballBattleRoleDetailBuffItem>(this.CreateBuffItem), null, false, null);
		}

		// Token: 0x060400CD RID: 262349 RVA: 0x00F7F83A File Offset: 0x00F7DA3A
		private PinballBattleRoleDetailBuffItem CreateBuffItem()
		{
			return new PinballBattleRoleDetailBuffItem();
		}

		// Token: 0x0402160B RID: 136715
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballRoleHeadItem, IPinballRoleHeadItemData> RoleLayout;

		// Token: 0x0402160C RID: 136716
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PinballBattleRoleDetailTabItem, EPinballBattleRoleDetailTabType> DetailTabLayout;

		// Token: 0x0402160D RID: 136717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<PinballBattleRoleDetailSkillItem, int> SkillScroll;

		// Token: 0x0402160E RID: 136718
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<PinballAttributeItem, IPinballAttributeItemData> AttrScroll;

		// Token: 0x0402160F RID: 136719
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<PinballBattleRoleDetailBuffItem, BuffView> BuffScroll;

		// Token: 0x04021610 RID: 136720
		private float OriginalHpBarWidth;

		// Token: 0x04021611 RID: 136721
		private float OriginalShieldBarWidth;

		// Token: 0x04021612 RID: 136722
		[Nullable(2)]
		private PinballRoleHeadItemData SelectedRoleHeadData;

		// Token: 0x0200C590 RID: 50576
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403BA2F RID: 244271
			TexRoleType,
			// Token: 0x0403BA30 RID: 244272
			TxtRoleName,
			// Token: 0x0403BA31 RID: 244273
			TxtRoleLevel,
			// Token: 0x0403BA32 RID: 244274
			TxtHpNum,
			// Token: 0x0403BA33 RID: 244275
			SpriteHpBar,
			// Token: 0x0403BA34 RID: 244276
			TxtShieldNum,
			// Token: 0x0403BA35 RID: 244277
			SpriteShieldBar,
			// Token: 0x0403BA36 RID: 244278
			DetailTabLayout,
			// Token: 0x0403BA37 RID: 244279
			DetailTabLayoutItem,
			// Token: 0x0403BA38 RID: 244280
			DetailEmpty,
			// Token: 0x0403BA39 RID: 244281
			ScrollSkill,
			// Token: 0x0403BA3A RID: 244282
			ScrollSkillItem,
			// Token: 0x0403BA3B RID: 244283
			ScrollAttr,
			// Token: 0x0403BA3C RID: 244284
			ScrollAttrItem,
			// Token: 0x0403BA3D RID: 244285
			ScrollBuff,
			// Token: 0x0403BA3E RID: 244286
			BuffLayoutItem,
			// Token: 0x0403BA3F RID: 244287
			SpineRole,
			// Token: 0x0403BA40 RID: 244288
			RoleHeadLayout,
			// Token: 0x0403BA41 RID: 244289
			RoleHeadLayoutItem,
			// Token: 0x0403BA42 RID: 244290
			PnlShiledNum
		}
	}
}
