using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A46 RID: 14918
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseDevelopPreviewLevelInfoItem : GridProxyAbstract<ITrapDefenseDevelopPreviewLevelInfo>
	{
		// Token: 0x060265B9 RID: 157113 RVA: 0x00ABE2B8 File Offset: 0x00ABC4B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060265BA RID: 157114 RVA: 0x00ABE3C6 File Offset: 0x00ABC5C6
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<TrapDefenseDevelopPreviewLevelBranchItem, ITrapDefenseDevelopPreviewLevelInfo>(base.GetVerticalLayout(1), new Func<TrapDefenseDevelopPreviewLevelBranchItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x060265BB RID: 157115 RVA: 0x00ABE3E9 File Offset: 0x00ABC5E9
		protected override void OnBeforeDestroy()
		{
			this.Layout = null;
		}

		// Token: 0x060265BC RID: 157116 RVA: 0x00ABE3F4 File Offset: 0x00ABC5F4
		public override void Refresh(ITrapDefenseDevelopPreviewLevelInfo data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			int id = data.Id;
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(id);
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetAlpha(data.IsCurLevel ? 1f : 0.75f);
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetUIActive(!data.IsCurLevel);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsCurLevel);
			}
			UUIArtText artText = base.GetArtText(0);
			if (artText != null)
			{
				string text;
				if (trapDefenseMachineIdInfo.Level < 10)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("0");
					defaultInterpolatedStringHandler.AppendFormatted<int>(trapDefenseMachineIdInfo.Level);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					text = trapDefenseMachineIdInfo.Level.ToString();
				}
				artText.SetText(text);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(data.IsCurLevel);
			}
			this.RefreshData();
		}

		// Token: 0x060265BD RID: 157117 RVA: 0x00ABE4E4 File Offset: 0x00ABC6E4
		protected void RefreshData()
		{
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(this.Data.Id);
			bool flag;
			int branchCount;
			if (trapDefenseMachineIdInfo.MachineType == ETrapDefenseMachineType.Building)
			{
				TrapDefenseBuilding? buildingById = TrapDefenseConfig.Instance.GetBuildingById(this.Data.Id);
				TrapDefenseBuildingType? buildingTypeById = TrapDefenseConfig.Instance.GetBuildingTypeById(buildingById.Value.BuildingType);
				int maxLevel = buildingTypeById.Value.MaxLevel;
				flag = (trapDefenseMachineIdInfo.Level == maxLevel);
				branchCount = buildingTypeById.Value.BranchCount;
			}
			else
			{
				TrapDefenseAuxiliary? auxiliaryById = TrapDefenseConfig.Instance.GetAuxiliaryById(this.Data.Id);
				TrapDefenseAuxiliaryType? auxiliaryTypeById = TrapDefenseConfig.Instance.GetAuxiliaryTypeById(auxiliaryById.Value.AuxiliaryType);
				int maxLevel2 = auxiliaryTypeById.Value.MaxLevel;
				branchCount = auxiliaryTypeById.Value.BranchCount;
				flag = (trapDefenseMachineIdInfo.Level == maxLevel2);
			}
			if (flag && branchCount > 1)
			{
				List<ITrapDefenseDevelopPreviewLevelInfo> list = new List<ITrapDefenseDevelopPreviewLevelInfo>();
				for (int i = 0; i <= branchCount; i++)
				{
					ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
					{
						MachineType = trapDefenseMachineIdInfo.MachineType,
						DataType = trapDefenseMachineIdInfo.DataType,
						Level = trapDefenseMachineIdInfo.Level,
						Branch = i
					};
					int num = TrapDefenseModel.Instance.ComposeMachineId(info);
					bool flag2 = this.Data.IsCurLevel && num != this.Data.Id && i != 0;
					ITrapDefenseDevelopPreviewLevelInfo item = new TrapDefenseDevelopPreviewLevelInfo
					{
						Id = num,
						IsCurLevel = ((i == 0 || num == this.Data.Id) && this.Data.IsCurLevel),
						NeedAlpha = (flag2 ? new bool?(true) : null)
					};
					list.Add(item);
				}
				this.Layout.RefreshByData(list, null, true);
				return;
			}
			this.Layout.RefreshByData(new <>z__ReadOnlySingleElementList<ITrapDefenseDevelopPreviewLevelInfo>(this.Data), null, true);
		}

		// Token: 0x060265BE RID: 157118 RVA: 0x00ABE6ED File Offset: 0x00ABC8ED
		private TrapDefenseDevelopPreviewLevelBranchItem CreateItem()
		{
			return new TrapDefenseDevelopPreviewLevelBranchItem();
		}

		// Token: 0x040150C5 RID: 86213
		[Nullable(2)]
		protected ITrapDefenseDevelopPreviewLevelInfo Data;

		// Token: 0x040150C6 RID: 86214
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TrapDefenseDevelopPreviewLevelBranchItem, ITrapDefenseDevelopPreviewLevelInfo> Layout;

		// Token: 0x02009616 RID: 38422
		[NullableContext(0)]
		private class EDetailInfo
		{
			// Token: 0x0402EDC0 RID: 191936
			public const int ArtTxt = 0;

			// Token: 0x0402EDC1 RID: 191937
			public const int PanelBranchLayout = 1;

			// Token: 0x0402EDC2 RID: 191938
			public const int BranchDescItem = 2;

			// Token: 0x0402EDC3 RID: 191939
			public const int PanelCurLevelLayout = 3;

			// Token: 0x0402EDC4 RID: 191940
			public const int PanelSelectState = 4;

			// Token: 0x0402EDC5 RID: 191941
			public const int SpriteUnSelectBg = 5;

			// Token: 0x0402EDC6 RID: 191942
			public const int PanelAlpha = 6;
		}
	}
}
