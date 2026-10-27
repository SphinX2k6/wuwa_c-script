using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A9E RID: 19102
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseDevelopPreviewLevelInfoItem : GridProxyAbstract<ITrapDefenseDevelopPreviewLevelInfo>
	{
		// Token: 0x06031829 RID: 202793 RVA: 0x00B7A304 File Offset: 0x00B78504
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

		// Token: 0x0603182A RID: 202794 RVA: 0x00B7A412 File Offset: 0x00B78612
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<TrapDefenseDevelopPreviewLevelBranchItem, ITrapDefenseDevelopPreviewLevelInfo>(base.GetVerticalLayout(1), new Func<TrapDefenseDevelopPreviewLevelBranchItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x0603182B RID: 202795 RVA: 0x00B7A435 File Offset: 0x00B78635
		protected override void OnBeforeDestroy()
		{
			this.Layout = null;
		}

		// Token: 0x0603182C RID: 202796 RVA: 0x00B7A440 File Offset: 0x00B78640
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

		// Token: 0x0603182D RID: 202797 RVA: 0x00B7A530 File Offset: 0x00B78730
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

		// Token: 0x0603182E RID: 202798 RVA: 0x00B7A739 File Offset: 0x00B78939
		private TrapDefenseDevelopPreviewLevelBranchItem CreateItem()
		{
			return new TrapDefenseDevelopPreviewLevelBranchItem();
		}

		// Token: 0x0401A773 RID: 108403
		[Nullable(2)]
		protected ITrapDefenseDevelopPreviewLevelInfo Data;

		// Token: 0x0401A774 RID: 108404
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<TrapDefenseDevelopPreviewLevelBranchItem, ITrapDefenseDevelopPreviewLevelInfo> Layout;

		// Token: 0x0200ABF6 RID: 44022
		[NullableContext(0)]
		private class EDetailInfo
		{
			// Token: 0x0403440F RID: 214031
			public const int ArtTxt = 0;

			// Token: 0x04034410 RID: 214032
			public const int PanelBranchLayout = 1;

			// Token: 0x04034411 RID: 214033
			public const int BranchDescItem = 2;

			// Token: 0x04034412 RID: 214034
			public const int PanelCurLevelLayout = 3;

			// Token: 0x04034413 RID: 214035
			public const int PanelSelectState = 4;

			// Token: 0x04034414 RID: 214036
			public const int SpriteUnSelectBg = 5;

			// Token: 0x04034415 RID: 214037
			public const int PanelAlpha = 6;
		}
	}
}
