using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059BE RID: 22974
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolInfoPlayerTabView : UiTabViewBase
	{
		// Token: 0x060389F7 RID: 231927 RVA: 0x00FD80B8 File Offset: 0x00FD62B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389F8 RID: 231928 RVA: 0x00FD8294 File Offset: 0x00FD6494
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolInfoPlayerTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolInfoPlayerTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060389F9 RID: 231929 RVA: 0x00FD82D8 File Offset: 0x00FD64D8
		protected override void OnStart()
		{
			this.AttrLayout = new GenericLayout<SolarSchoolInfoAttrItem, SolarSchoolInfoAttrData>(base.GetGridLayout(6), () => new SolarSchoolInfoAttrItem(), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x060389FA RID: 231930 RVA: 0x00FD8329 File Offset: 0x00FD6529
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x060389FB RID: 231931 RVA: 0x00FD8347 File Offset: 0x00FD6547
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x060389FC RID: 231932 RVA: 0x00FD8368 File Offset: 0x00FD6568
		protected override void OnShowUiTabViewFromToggle()
		{
			this.RefreshPlayerInfo();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x060389FD RID: 231933 RVA: 0x00FD839A File Offset: 0x00FD659A
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			if (attr == ESolarSchoolSecondAttr.Popularity)
			{
				this.RefreshPopularity();
				return;
			}
			this.RefreshAttributes();
		}

		// Token: 0x060389FE RID: 231934 RVA: 0x00FD83AD File Offset: 0x00FD65AD
		private void RefreshPlayerInfo()
		{
			this.RefreshIdentity();
			this.RefreshAttributes();
			this.RefreshPopularity();
			this.RefreshFactions();
			this.RefreshGrades();
		}

		// Token: 0x060389FF RID: 231935 RVA: 0x00FD83D0 File Offset: 0x00FD65D0
		private void RefreshIdentity()
		{
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(PlayerInfoModel.Instance.GetPlayerName() ?? string.Empty, true);
			}
			int id = (SolarSchoolGamePlayModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? 101 : 102;
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(id);
			if (role != null)
			{
				base.SetTextureByPath(role.Value.FrameHeadIcon, base.GetTexture(1), null, null);
				base.SetTextureByPath(role.Value.Spine, base.GetTexture(5), null, null);
			}
		}

		// Token: 0x06038A00 RID: 231936 RVA: 0x00FD8478 File Offset: 0x00FD6678
		private void RefreshAttributes()
		{
			this.AttrDataList.Clear();
			foreach (ESolarSchoolSecondAttr attr in SolarSchoolDefine.AttrsShowList)
			{
				this.AttrDataList.Add(SolarSchoolInfoAttrDisplay.Build(attr));
			}
			GenericLayout<SolarSchoolInfoAttrItem, SolarSchoolInfoAttrData> attrLayout = this.AttrLayout;
			if (attrLayout == null)
			{
				return;
			}
			attrLayout.RefreshByData(this.AttrDataList, null, false);
		}

		// Token: 0x06038A01 RID: 231937 RVA: 0x00FD84D1 File Offset: 0x00FD66D1
		private void RefreshPopularity()
		{
			SolarSchoolInfoPopularityItem popularityItem = this.PopularityItem;
			if (popularityItem == null)
			{
				return;
			}
			popularityItem.Refresh(SolarSchoolInfoAttrDisplay.Build(ESolarSchoolSecondAttr.Popularity));
		}

		// Token: 0x06038A02 RID: 231938 RVA: 0x00FD84EC File Offset: 0x00FD66EC
		private void RefreshFactions()
		{
			ESolarSchoolInfluence[] array = new ESolarSchoolInfluence[]
			{
				ESolarSchoolInfluence.StudentCouncil,
				ESolarSchoolInfluence.LeagueOfSocieties
			};
			for (int i = 0; i < this.FactionItems.Count; i++)
			{
				UUIItem item = base.GetItem(9 + i);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				ESolarSchoolInfluence influence = (i < array.Length) ? array[i] : ESolarSchoolInfluence.None;
				int influenceLevel = SolarSchoolGamePlayModel.Instance.PlayerData.GetInfluenceLevel(influence);
				SolarSchoolInfluence? solarSchoolInfluence;
				this.FactionItems[i].Refresh(new SolarSchoolInfoFactionData(influence, influenceLevel, (SolarSchoolConfig.Instance.GetInfluence(influence) != null) ? solarSchoolInfluence.GetValueOrDefault().Icon : null));
			}
		}

		// Token: 0x06038A03 RID: 231939 RVA: 0x00FD8596 File Offset: 0x00FD6796
		private void RefreshGrades()
		{
			this.GradesItems[0].Refresh(this.BuildGradesData(ESolarSchoolExamType.General));
			this.GradesItems[1].Refresh(this.BuildGradesData(ESolarSchoolExamType.Art));
		}

		// Token: 0x06038A04 RID: 231940 RVA: 0x00FD85C8 File Offset: 0x00FD67C8
		private SolarSchoolInfoGradesData BuildGradesData(ESolarSchoolExamType examType)
		{
			SolarSchoolExamResult solarSchoolExamResult;
			if (!SolarSchoolGamePlayModel.Instance.PlayerData.TryGetLatestExamResult(examType, out solarSchoolExamResult))
			{
				return new SolarSchoolInfoGradesData(examType, false, 0, 0, null, null);
			}
			if (!solarSchoolExamResult.IsPublished)
			{
				return new SolarSchoolInfoGradesData(examType, false, 0, 0, null, null);
			}
			return new SolarSchoolInfoGradesData(examType, true, solarSchoolExamResult.Score, solarSchoolExamResult.Rank, this.GetRankTextId(examType), solarSchoolExamResult.GetRankIcon());
		}

		// Token: 0x06038A05 RID: 231941 RVA: 0x00FD862C File Offset: 0x00FD682C
		[NullableContext(2)]
		private string GetRankTextId(ESolarSchoolExamType examType)
		{
			string result;
			if (examType != ESolarSchoolExamType.General)
			{
				if (examType != ESolarSchoolExamType.Art)
				{
					result = null;
				}
				else
				{
					result = "SolarSchool_StudentIdRank_Art";
				}
			}
			else
			{
				result = "SolarSchool_StudentIdRank_General";
			}
			return result;
		}

		// Token: 0x0401DD1B RID: 122139
		private const int GradesGeneralSlot = 0;

		// Token: 0x0401DD1C RID: 122140
		private const int GradesArtSlot = 1;

		// Token: 0x0401DD1D RID: 122141
		private readonly List<SolarSchoolInfoAttrData> AttrDataList = new List<SolarSchoolInfoAttrData>();

		// Token: 0x0401DD1E RID: 122142
		private readonly List<SolarSchoolInfoFactionItem> FactionItems = new List<SolarSchoolInfoFactionItem>();

		// Token: 0x0401DD1F RID: 122143
		private readonly List<SolarSchoolInfoGradesItem> GradesItems = new List<SolarSchoolInfoGradesItem>();

		// Token: 0x0401DD20 RID: 122144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolInfoAttrItem, SolarSchoolInfoAttrData> AttrLayout;

		// Token: 0x0401DD21 RID: 122145
		[Nullable(2)]
		private SolarSchoolInfoPopularityItem PopularityItem;

		// Token: 0x0200B568 RID: 46440
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038170 RID: 229744
			public const int Root = 0;

			// Token: 0x04038171 RID: 229745
			public const int TexRoleBg = 1;

			// Token: 0x04038172 RID: 229746
			public const int TxtTitle = 2;

			// Token: 0x04038173 RID: 229747
			public const int TxtDay = 3;

			// Token: 0x04038174 RID: 229748
			public const int TxtIdentity = 4;

			// Token: 0x04038175 RID: 229749
			public const int TexRole = 5;

			// Token: 0x04038176 RID: 229750
			public const int PnlItemLayout = 6;

			// Token: 0x04038177 RID: 229751
			public const int PnlPopularity = 7;

			// Token: 0x04038178 RID: 229752
			public const int PnlAttrTemplate = 8;

			// Token: 0x04038179 RID: 229753
			public const int PnlFactionFirst = 9;

			// Token: 0x0403817A RID: 229754
			public const int PnlFactionSecond = 10;

			// Token: 0x0403817B RID: 229755
			public const int PnlGradesFirst = 11;

			// Token: 0x0403817C RID: 229756
			public const int PnlGradesSecond = 12;
		}
	}
}
