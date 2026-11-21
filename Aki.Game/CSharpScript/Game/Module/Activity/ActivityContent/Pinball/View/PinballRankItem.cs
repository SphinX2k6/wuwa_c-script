using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x02005253 RID: 21075
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballRankItem : GridProxyAbstract<PinballRankData>
	{
		// Token: 0x06034778 RID: 214904 RVA: 0x00EAE980 File Offset: 0x00EACB80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034779 RID: 214905 RVA: 0x00EAEAD1 File Offset: 0x00EACCD1
		protected override void OnStart()
		{
			this.FormationLayout = new GenericLayout<PinballRankRoleHeadItem, PinballRankRoleHeadData>(base.GetHorizontalLayout(6), new Func<PinballRankRoleHeadItem>(this.CreateRoleHeadItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603477A RID: 214906 RVA: 0x00EAEB04 File Offset: 0x00EACD04
		public override void Refresh(PinballRankData data, bool isSelected, int gridIndex)
		{
			int rank = gridIndex + 1;
			if (data.HasData)
			{
				this.RefreshRankDisplay(rank);
			}
			else
			{
				UUITexture texture = base.GetTexture(0);
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
			this.RefreshPlayerInfo(data);
			this.RefreshFormationList(data);
		}

		// Token: 0x0603477B RID: 214907 RVA: 0x00EAEB5C File Offset: 0x00EACD5C
		private void RefreshRankDisplay(int rank)
		{
			UUITexture texture = base.GetTexture(0);
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(2);
			if (rank <= 3)
			{
				if (texture != null)
				{
					texture.SetUIActive(true);
				}
				if (text != null)
				{
					text.SetUIActive(false);
				}
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				if (texture != null)
				{
					string topRankIconPath = this.GetTopRankIconPath(rank);
					if (!string.IsNullOrEmpty(topRankIconPath))
					{
						base.SetTextureByPath(topRankIconPath, texture, null, null);
						return;
					}
					texture.SetUIActive(false);
					if (text != null)
					{
						text.SetUIActive(true);
					}
					if (text != null)
					{
						text.SetText(rank.ToString(), true);
						return;
					}
				}
			}
			else
			{
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				if (text != null)
				{
					text.SetUIActive(true);
				}
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				if (text != null)
				{
					text.SetText(rank.ToString(), true);
				}
			}
		}

		// Token: 0x0603477C RID: 214908 RVA: 0x00EAEC1C File Offset: 0x00EACE1C
		[NullableContext(2)]
		private string GetTopRankIconPath(int rank)
		{
			string text;
			if (!PinballDefine.pinballRankTopIconResourceKeys.TryGetValue(rank, out text))
			{
				return null;
			}
			if (!string.IsNullOrEmpty(text))
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
				if (!string.IsNullOrEmpty(resourcePath))
				{
					return resourcePath;
				}
			}
			return null;
		}

		// Token: 0x0603477D RID: 214909 RVA: 0x00EAEC5C File Offset: 0x00EACE5C
		private void RefreshPlayerInfo(PinballRankData data)
		{
			if (data.HasData)
			{
				UUIText text = base.GetText(3);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				UUIText text2 = base.GetText(2);
				if (text2 != null)
				{
					text2.SetUIActive(false);
				}
				UUIText text3 = base.GetText(3);
				if (text3 != null)
				{
					text3.SetText(data.Name, true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Pinball_Level_TowerLevelInfo", new <>z__ReadOnlySingleElementList<object>(data.TowerLevel));
				string timeDataFormatWithHour = TimeUtil.Instance.GetTimeDataFormatWithHour((double)data.CostTime);
				UUIText text4 = base.GetText(5);
				if (text4 == null)
				{
					return;
				}
				text4.SetText(timeDataFormatWithHour, true);
				return;
			}
			else
			{
				UUIText text5 = base.GetText(3);
				if (text5 != null)
				{
					text5.SetUIActive(true);
				}
				UUIText text6 = base.GetText(2);
				if (text6 != null)
				{
					text6.SetUIActive(true);
				}
				UUIText text7 = base.GetText(3);
				if (text7 != null)
				{
					text7.SetText(data.Name, true);
				}
				UUIText text8 = base.GetText(4);
				if (text8 != null)
				{
					text8.SetText("", true);
				}
				UUIText text9 = base.GetText(5);
				if (text9 != null)
				{
					text9.SetText("", true);
				}
				UUITexture texture = base.GetTexture(0);
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				UUIText text10 = base.GetText(1);
				if (text10 == null)
				{
					return;
				}
				text10.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603477E RID: 214910 RVA: 0x00EAED94 File Offset: 0x00EACF94
		private void RefreshFormationList(PinballRankData data)
		{
			List<ValueTuple<int, int>> formation = data.Formation;
			if (formation != null && formation.Count > 0)
			{
				GenericLayout<PinballRankRoleHeadItem, PinballRankRoleHeadData> formationLayout = this.FormationLayout;
				if (formationLayout != null)
				{
					UUIItem rootUiItem = formationLayout.GetRootUiItem();
					if (rootUiItem != null)
					{
						rootUiItem.SetUIActive(true);
					}
				}
				UUIText text = base.GetText(7);
				if (text != null)
				{
					text.SetUIActive(false);
				}
				List<PinballRankRoleHeadData> list = new List<PinballRankRoleHeadData>();
				foreach (ValueTuple<int, int> valueTuple in formation)
				{
					list.Add(new PinballRankRoleHeadData
					{
						RoleId = valueTuple.Item1,
						Level = valueTuple.Item2
					});
				}
				GenericLayout<PinballRankRoleHeadItem, PinballRankRoleHeadData> formationLayout2 = this.FormationLayout;
				if (formationLayout2 == null)
				{
					return;
				}
				formationLayout2.RefreshByData(list, null, false);
				return;
			}
			else
			{
				GenericLayout<PinballRankRoleHeadItem, PinballRankRoleHeadData> formationLayout3 = this.FormationLayout;
				if (formationLayout3 != null)
				{
					UUIItem rootUiItem2 = formationLayout3.GetRootUiItem();
					if (rootUiItem2 != null)
					{
						rootUiItem2.SetUIActive(false);
					}
				}
				if (data.IsMyRank && !data.HasData)
				{
					UUIText text2 = base.GetText(7);
					if (text2 == null)
					{
						return;
					}
					text2.SetUIActive(true);
					return;
				}
				else
				{
					UUIText text3 = base.GetText(7);
					if (text3 == null)
					{
						return;
					}
					text3.SetUIActive(false);
					return;
				}
			}
		}

		// Token: 0x0603477F RID: 214911 RVA: 0x00EAEEB4 File Offset: 0x00EAD0B4
		private PinballRankRoleHeadItem CreateRoleHeadItem()
		{
			return new PinballRankRoleHeadItem();
		}

		// Token: 0x0401BD68 RID: 114024
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballRankRoleHeadItem, PinballRankRoleHeadData> FormationLayout;

		// Token: 0x0401BD69 RID: 114025
		private const int TOP_RANK_COUNT = 3;

		// Token: 0x0200AEA9 RID: 44713
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035F55 RID: 221013
			RankIcon,
			// Token: 0x04035F56 RID: 221014
			TxtNum,
			// Token: 0x04035F57 RID: 221015
			TxtNone,
			// Token: 0x04035F58 RID: 221016
			TxtName,
			// Token: 0x04035F59 RID: 221017
			TxtLevel,
			// Token: 0x04035F5A RID: 221018
			TxtTime,
			// Token: 0x04035F5B RID: 221019
			PhiPlaylist,
			// Token: 0x04035F5C RID: 221020
			Empty,
			// Token: 0x04035F5D RID: 221021
			RankRoleHead
		}
	}
}
