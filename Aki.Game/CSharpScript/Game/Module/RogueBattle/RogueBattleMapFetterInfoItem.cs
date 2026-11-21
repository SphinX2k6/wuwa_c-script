using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E30 RID: 15920
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleMapFetterInfoItem : GridProxyAbstract<IRogueBattleMapFetterInfo>
	{
		// Token: 0x06028963 RID: 166243 RVA: 0x00B63A24 File Offset: 0x00B61C24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x06028964 RID: 166244 RVA: 0x00B63AAA File Offset: 0x00B61CAA
		protected override void OnStart()
		{
			this.DescLayout = new GenericLayout<RogueBattleMapFetterInfoDescItem, IRogueBattleMapFetterDescInfo>(base.GetVerticalLayout(3), new Func<RogueBattleMapFetterInfoDescItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x06028965 RID: 166245 RVA: 0x00B63ACD File Offset: 0x00B61CCD
		protected override void OnBeforeDestroy()
		{
			this.DescLayout = null;
		}

		// Token: 0x06028966 RID: 166246 RVA: 0x00B63AD8 File Offset: 0x00B61CD8
		public override void Refresh(IRogueBattleMapFetterInfo data, bool isSelected, int gridIndex)
		{
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(data.ConfigId);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Level);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RogueRes_Overall_Synergy_6", new <>z__ReadOnlySingleElementList<object>(rogueResBond.Value.GetStarMap(data.Level).Value));
			List<IRogueBattleMapFetterDescInfo> list = new List<IRogueBattleMapFetterDescInfo>();
			int num = 0;
			foreach (DicIntIntArray dicIntIntArray in rogueResBond.Value.BattleEffectIter())
			{
				if (dicIntIntArray.Key == data.Level)
				{
					RogueBattleMapFetterDescInfo item = new RogueBattleMapFetterDescInfo
					{
						TextId = rogueResBond.Value.FightEffectDesc(num),
						Param = rogueResBond.Value.FightEffectDescParam(num),
						IsReached = data.IsReached,
						EffectType = ERogueResBondEffectType.Battle
					};
					list.Add(item);
				}
				num++;
			}
			num = 0;
			foreach (DicIntInt dicIntInt in rogueResBond.Value.ExploreEffectIter())
			{
				if (dicIntInt.Key == data.Level)
				{
					RogueBattleMapFetterDescInfo item2 = new RogueBattleMapFetterDescInfo
					{
						TextId = rogueResBond.Value.ExploreEffectDesc(num),
						Param = rogueResBond.Value.ExploreEffectDescParam(num),
						IsReached = data.IsReached,
						EffectType = ERogueResBondEffectType.Explore
					};
					list.Add(item2);
				}
				num++;
			}
			foreach (DicIntInt dicIntInt2 in rogueResBond.Value.LinkEffectIter())
			{
				if (dicIntInt2.Key == data.Level)
				{
					int key = dicIntInt2.Key;
					RogueBattleMapFetterDescInfo item3 = new RogueBattleMapFetterDescInfo
					{
						TextId = rogueResBond.Value.GetLinkEffectDesc(key),
						Param = rogueResBond.Value.GetLinkEffectDescParam(key),
						IsReached = data.IsReached,
						EffectType = ERogueResBondEffectType.Link
					};
					list.Add(item3);
				}
			}
			this.DescLayout.RefreshByData(list, null, false);
			base.GetSprite(0).SetColor(FColor.FromHex(this.BgColor[data.IsReached]));
			base.GetText(2).SetColor(FColor.FromHex(this.TxtColor[data.IsReached]));
		}

		// Token: 0x06028967 RID: 166247 RVA: 0x00B63DD0 File Offset: 0x00B61FD0
		private RogueBattleMapFetterInfoDescItem CreateItem()
		{
			return new RogueBattleMapFetterInfoDescItem();
		}

		// Token: 0x06028968 RID: 166248 RVA: 0x00B63DD8 File Offset: 0x00B61FD8
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
			string a = configParams[2];
			if (a == "Star")
			{
				UUIItem guideUiItem = base.GetGuideUiItem("0");
				if (guideUiItem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					guideUiItem,
					guideUiItem
				};
			}
			else
			{
				if (!(a == "Item"))
				{
					return null;
				}
				if (configParams.Length < 4)
				{
					return null;
				}
				int num = int.Parse(configParams[3]);
				GenericLayout<RogueBattleMapFetterInfoDescItem, IRogueBattleMapFetterDescInfo> descLayout = this.DescLayout;
				UUIItem uuiitem = (descLayout != null) ? descLayout.GetItemByIndex(num - 1) : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
		}

		// Token: 0x0401608D RID: 90253
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RogueBattleMapFetterInfoDescItem, IRogueBattleMapFetterDescInfo> DescLayout;

		// Token: 0x0401608E RID: 90254
		public readonly Dictionary<bool, string> BgColor = new Dictionary<bool, string>
		{
			{
				true,
				"#D9CF86"
			},
			{
				false,
				"#9B9A96"
			}
		};

		// Token: 0x0401608F RID: 90255
		public readonly Dictionary<bool, string> TxtColor = new Dictionary<bool, string>
		{
			{
				true,
				"#B8EB60"
			},
			{
				false,
				"#C4C4C4"
			}
		};
	}
}
