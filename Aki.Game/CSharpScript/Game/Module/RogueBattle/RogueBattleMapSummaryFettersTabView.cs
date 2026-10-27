using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EEC RID: 20204
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapSummaryFettersTabView : UiTabViewBase
	{
		// Token: 0x06033D6D RID: 212333 RVA: 0x00C24440 File Offset: 0x00C22640
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(16, typeof(UUIItem))
			};
		}

		// Token: 0x06033D6E RID: 212334 RVA: 0x00C245D6 File Offset: 0x00C227D6
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryBondUpdate, new Action<int>(this.OnRefreshBond));
			EventSystem.Instance.Add(EEventName.RogueResMapSummaryFettersSubTabUpdate, new Action(this.OnTabDataReady));
		}

		// Token: 0x06033D6F RID: 212335 RVA: 0x00C24610 File Offset: 0x00C22810
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryBondUpdate, new Action<int>(this.OnRefreshBond));
			EventSystem.Instance.Remove(EEventName.RogueResMapSummaryFettersSubTabUpdate, new Action(this.OnTabDataReady));
		}

		// Token: 0x06033D70 RID: 212336 RVA: 0x00C2464C File Offset: 0x00C2284C
		protected override void OnStart()
		{
			this.TabScrollView = new GenericScrollViewNew<RogueBattleMapFetterTabItem, IRogueBattleMapFetterTabInfo>(base.GetScrollViewWithScrollbar(0), new Func<RogueBattleMapFetterTabItem>(this.InitTabItem), null, false, null);
			this.MemberLayout = new GenericLayout<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo>(base.GetHorizontalLayout(8), new Func<RogueBattleMapRoleLayoutGrid>(this.InitMember), null, false, true);
			this.FetterLayout = new GenericLayout<RogueBattleMapFetterInfoItem, IRogueBattleMapFetterInfo>(base.GetVerticalLayout(10), new Func<RogueBattleMapFetterInfoItem>(this.InitFetter), null, false, true);
			this.StarLvLayout = new GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData>(base.GetHorizontalLayout(15), new Func<MapRogueFetterStarLvItem>(this.InitStarLv), null, false, true);
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06033D71 RID: 212337 RVA: 0x00C24705 File Offset: 0x00C22905
		protected override void OnBeforeShow()
		{
			this.RefreshTabScroll();
		}

		// Token: 0x06033D72 RID: 212338 RVA: 0x00C24710 File Offset: 0x00C22910
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06033D73 RID: 212339 RVA: 0x00C24737 File Offset: 0x00C22937
		protected override void OnBeforeDestroy()
		{
			this.TabScrollView = null;
			this.MemberLayout = null;
			this.FetterLayout = null;
		}

		// Token: 0x06033D74 RID: 212340 RVA: 0x00C2474E File Offset: 0x00C2294E
		private RogueBattleMapFetterTabItem InitTabItem()
		{
			return new RogueBattleMapFetterTabItem();
		}

		// Token: 0x06033D75 RID: 212341 RVA: 0x00C24755 File Offset: 0x00C22955
		private RogueBattleMapRoleLayoutGrid InitMember()
		{
			return new RogueBattleMapRoleLayoutGrid();
		}

		// Token: 0x06033D76 RID: 212342 RVA: 0x00C2475C File Offset: 0x00C2295C
		private RogueBattleMapFetterInfoItem InitFetter()
		{
			return new RogueBattleMapFetterInfoItem();
		}

		// Token: 0x06033D77 RID: 212343 RVA: 0x00C24763 File Offset: 0x00C22963
		private MapRogueFetterStarLvItem InitStarLv()
		{
			return new MapRogueFetterStarLvItem();
		}

		// Token: 0x06033D78 RID: 212344 RVA: 0x00C2476C File Offset: 0x00C2296C
		private void OnRefreshBond(int bondId)
		{
			if (!this.UiViewSequence.HasSequenceNameInPlaying("Start"))
			{
				if (this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
				{
					this.UiViewSequence.ReplaySequence("Switch");
				}
				else
				{
					this.UiViewSequence.PlaySequence("Switch", false, null);
				}
			}
			this.RefreshTxt(bondId);
			this.RefreshRole(bondId);
			this.RefreshDetail(bondId);
		}

		// Token: 0x06033D79 RID: 212345 RVA: 0x00C247E0 File Offset: 0x00C229E0
		private unsafe void RefreshTabScroll()
		{
			IReadOnlyList<RogueResBond> allRogueResBond = RogueBattleConfig.Instance.GetAllRogueResBond();
			IReadOnlyList<RogueResSynergyType> allRogueResBondType = RogueBattleConfig.Instance.GetAllRogueResBondType();
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (RogueResSynergyType rogueResSynergyType in allRogueResBondType)
			{
				dictionary[rogueResSynergyType.Id] = new List<int>();
			}
			foreach (RogueResBond rogueResBond in allRogueResBond)
			{
				RogueResBond value = RogueBattleConfig.Instance.GetRogueResBond(rogueResBond.Id).Value;
				int rarity = value.Rarity;
				List<int> list;
				if (!dictionary.TryGetValue(rarity, out list))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RogueBattle;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "常驻肉鸽缺少羁绊类型";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bondId", value.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("type", rarity);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					list.Add(value.Id);
				}
			}
			List<IRogueBattleMapFetterTabInfo> list2 = new List<IRogueBattleMapFetterTabInfo>();
			foreach (RogueResSynergyType rogueResSynergyType2 in allRogueResBondType)
			{
				List<int> list3;
				if (dictionary.TryGetValue(rogueResSynergyType2.Id, out list3) && list3.Count != 0)
				{
					List<int> list4 = new List<int>(list3);
					list4.Sort(delegate(int a, int b)
					{
						RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(a);
						RoleBondInfo roleBondDataById2 = RogueBattleModel.Instance.GetRoleBondDataById(b);
						if (roleBondDataById.Level != roleBondDataById2.Level)
						{
							return roleBondDataById2.Level - roleBondDataById.Level;
						}
						if (roleBondDataById.CurStar == roleBondDataById2.CurStar)
						{
							return roleBondDataById.ConfigId - roleBondDataById2.ConfigId;
						}
						return roleBondDataById2.CurStar - roleBondDataById.CurStar;
					});
					if (RogueBattleModel.Instance.CurrentMapSummaryBond == 0 && list4.Count > 0)
					{
						RogueBattleModel.Instance.CurrentMapSummaryBond = list4[0];
					}
					RogueBattleMapFetterTabInfo item = new RogueBattleMapFetterTabInfo
					{
						IsSelected = list3.Contains(RogueBattleModel.Instance.CurrentMapSummaryBond),
						Config = list4
					};
					list2.Add(item);
				}
			}
			this.DataList = list2;
			this.TabScrollView.RefreshByData(list2, delegate
			{
				EventSystem.Instance.Emit<int>(EEventName.RogueResMapSummaryBondUpdate, RogueBattleModel.Instance.CurrentMapSummaryBond);
			}, false);
		}

		// Token: 0x06033D7A RID: 212346 RVA: 0x00C24A54 File Offset: 0x00C22C54
		private void RefreshTxt(int bondId)
		{
			RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(bondId);
			RoleBondInfo roleBondDataById2 = RogueBattleModel.Instance.GetRoleBondDataById(bondId);
			RogueResBondLv value = RogueBattleConfig.Instance.GetBondLvConfigByLv(roleBondDataById.Level).Value;
			if (roleBondDataById2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "未找到羁绊";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bondId", bondId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			FColor color = FColor.FromHex(value.LvColor);
			base.GetText(6).SetColor(color);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "RogueResSynergyLV", new <>z__ReadOnlySingleElementList<object>(roleBondDataById2.Level));
			UUIText text = base.GetText(14);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleBondDataById2.CurStar);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			RogueResBond value2 = RogueBattleConfig.Instance.GetRogueResBond(bondId).Value;
			base.GetText(5).SetColor(color);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value2.Name, Array.Empty<object>());
			base.SetTextureByPath(value2.Icon, base.GetTexture(4), null, null);
			base.SetTextureByPath(value2.Icon, base.GetTexture(3), null, null);
		}

		// Token: 0x06033D7B RID: 212347 RVA: 0x00C24BB0 File Offset: 0x00C22DB0
		private void RefreshRole(int bondId)
		{
			List<IRogueBattleMapRoleGridInfo> roleListByBond = RogueBattleModel.Instance.GetRoleListByBond(bondId);
			GenericLayout<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo> memberLayout = this.MemberLayout;
			if (memberLayout == null)
			{
				return;
			}
			memberLayout.RefreshByData(roleListByBond, null, false);
		}

		// Token: 0x06033D7C RID: 212348 RVA: 0x00C24BDC File Offset: 0x00C22DDC
		private void RefreshDetail(int bondId)
		{
			RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(bondId);
			RogueResBond value = RogueBattleConfig.Instance.GetRogueResBond(bondId).Value;
			List<IRogueBattleMapFetterInfo> list = new List<IRogueBattleMapFetterInfo>();
			List<IFetterStarLvData> list2 = new List<IFetterStarLvData>();
			List<DicIntInt> list3 = value.StarMapIter().ToList<DicIntInt>();
			list3.Sort((DicIntInt a, DicIntInt b) => a.Key - b.Key);
			if (list3.Count > 0)
			{
				int key = list3[list3.Count - 1].Key;
				foreach (DicIntInt dicIntInt in list3)
				{
					int key2 = dicIntInt.Key;
					int value2 = dicIntInt.Value;
					FetterStarLvData item = new FetterStarLvData
					{
						StageLv = key2,
						StageStarLv = value2,
						CurrentLv = roleBondDataById.Level,
						MaxLv = key
					};
					list2.Add(item);
					RogueBattleMapFetterInfo item2 = new RogueBattleMapFetterInfo
					{
						ConfigId = bondId,
						Level = key2,
						IsReached = (key2 <= roleBondDataById.Level)
					};
					list.Add(item2);
				}
				this.StarLvLayout.SetActive(true);
				this.FetterLayout.SetActive(true);
				this.StarLvLayout.RefreshByData(list2, null, true);
				this.FetterLayout.RefreshByData(list, null, false);
				return;
			}
			this.StarLvLayout.SetActive(false);
			this.FetterLayout.SetActive(false);
		}

		// Token: 0x06033D7D RID: 212349 RVA: 0x00C24D78 File Offset: 0x00C22F78
		private void OnTabDataReady()
		{
			if (!RogueBattleModel.Instance.IsMapSummaryBondJumping)
			{
				return;
			}
			RogueBattleModel.Instance.IsMapSummaryBondJumping = false;
			float value = 0f;
			int num = 0;
			foreach (IRogueBattleMapFetterTabInfo rogueBattleMapFetterTabInfo in this.DataList)
			{
				num++;
				for (int i = 0; i < rogueBattleMapFetterTabInfo.Config.Count; i++)
				{
					if (rogueBattleMapFetterTabInfo.Config[i] == RogueBattleModel.Instance.CurrentMapSummaryBond)
					{
						value = (float)i / (float)(rogueBattleMapFetterTabInfo.Config.Count + num);
						break;
					}
				}
				if (value != 0f)
				{
					break;
				}
			}
			UUIScrollViewWithScrollbarComponent item = base.GetScrollViewWithScrollbar(0);
			GenericScrollViewNew<RogueBattleMapFetterTabItem, IRogueBattleMapFetterTabInfo> tabScrollView = this.TabScrollView;
			if (tabScrollView == null)
			{
				return;
			}
			tabScrollView.BindLateUpdate(delegate(float _)
			{
				UUIScrollViewWithScrollbarComponent item = item;
				if (item != null)
				{
					item.SetScrollProgress(value);
				}
				GenericScrollViewNew<RogueBattleMapFetterTabItem, IRogueBattleMapFetterTabInfo> tabScrollView2 = this.TabScrollView;
				if (tabScrollView2 == null)
				{
					return;
				}
				tabScrollView2.UnBindLateUpdate();
			});
		}

		// Token: 0x06033D7E RID: 212350 RVA: 0x00C24E80 File Offset: 0x00C23080
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length < 3)
			{
				return null;
			}
			int num = int.Parse(configParams[1]);
			GenericLayout<RogueBattleMapFetterInfoItem, IRogueBattleMapFetterInfo> fetterLayout = this.FetterLayout;
			RogueBattleMapFetterInfoItem rogueBattleMapFetterInfoItem = (fetterLayout != null) ? fetterLayout.GetLayoutItemByIndex(num - 1) : null;
			if (rogueBattleMapFetterInfoItem == null)
			{
				return null;
			}
			return rogueBattleMapFetterInfoItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401B8A9 RID: 112809
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueBattleMapFetterTabItem, IRogueBattleMapFetterTabInfo> TabScrollView;

		// Token: 0x0401B8AA RID: 112810
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo> MemberLayout;

		// Token: 0x0401B8AB RID: 112811
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleMapFetterInfoItem, IRogueBattleMapFetterInfo> FetterLayout;

		// Token: 0x0401B8AC RID: 112812
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapRogueFetterStarLvItem, IFetterStarLvData> StarLvLayout;

		// Token: 0x0401B8AD RID: 112813
		private List<IRogueBattleMapFetterTabInfo> DataList = new List<IRogueBattleMapFetterTabInfo>();
	}
}
