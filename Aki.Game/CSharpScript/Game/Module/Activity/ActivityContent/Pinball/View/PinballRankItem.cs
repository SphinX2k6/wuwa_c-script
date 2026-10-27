using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x020062D5 RID: 25301
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballRankItem : GridProxyAbstract<PinballRankData>
	{
		// Token: 0x0603FAB7 RID: 260791 RVA: 0x00F67A24 File Offset: 0x00F65C24
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

		// Token: 0x0603FAB8 RID: 260792 RVA: 0x00F67B75 File Offset: 0x00F65D75
		protected override void OnStart()
		{
			this.FormationLayout = new GenericLayout<PinballRankRoleHeadItem, PinballRankRoleHeadData>(base.GetHorizontalLayout(6), new Func<PinballRankRoleHeadItem>(this.CreateRoleHeadItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603FAB9 RID: 260793 RVA: 0x00F67BA8 File Offset: 0x00F65DA8
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

		// Token: 0x0603FABA RID: 260794 RVA: 0x00F67C00 File Offset: 0x00F65E00
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

		// Token: 0x0603FABB RID: 260795 RVA: 0x00F67CC0 File Offset: 0x00F65EC0
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

		// Token: 0x0603FABC RID: 260796 RVA: 0x00F67D00 File Offset: 0x00F65F00
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

		// Token: 0x0603FABD RID: 260797 RVA: 0x00F67E38 File Offset: 0x00F66038
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

		// Token: 0x0603FABE RID: 260798 RVA: 0x00F67F58 File Offset: 0x00F66158
		private PinballRankRoleHeadItem CreateRoleHeadItem()
		{
			return new PinballRankRoleHeadItem();
		}

		// Token: 0x04021439 RID: 136249
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballRankRoleHeadItem, PinballRankRoleHeadData> FormationLayout;

		// Token: 0x0402143A RID: 136250
		private const int TOP_RANK_COUNT = 3;

		// Token: 0x0200C4C2 RID: 50370
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403B5F3 RID: 243187
			RankIcon,
			// Token: 0x0403B5F4 RID: 243188
			TxtNum,
			// Token: 0x0403B5F5 RID: 243189
			TxtNone,
			// Token: 0x0403B5F6 RID: 243190
			TxtName,
			// Token: 0x0403B5F7 RID: 243191
			TxtLevel,
			// Token: 0x0403B5F8 RID: 243192
			TxtTime,
			// Token: 0x0403B5F9 RID: 243193
			PhiPlaylist,
			// Token: 0x0403B5FA RID: 243194
			Empty,
			// Token: 0x0403B5FB RID: 243195
			RankRoleHead
		}
	}
}
