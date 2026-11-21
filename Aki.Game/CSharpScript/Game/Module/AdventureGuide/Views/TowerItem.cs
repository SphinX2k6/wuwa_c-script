using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004ECA RID: 20170
	public class TowerItem : GridProxyAbstract<int>
	{
		// Token: 0x06032B69 RID: 207721 RVA: 0x00E3D540 File Offset: 0x00E3B740
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032B6A RID: 207722 RVA: 0x00E3D5EC File Offset: 0x00E3B7EC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(data);
			if (towerInfo == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), towerInfo.Value.AreaName, Array.Empty<object>());
			int areaAllStars = TowerModel.Instance.GetAreaAllStars(towerInfo.Value.Difficulty, towerInfo.Value.AreaNum);
			int areaStars = TowerModel.Instance.GetAreaStars(towerInfo.Value.Difficulty, towerInfo.Value.AreaNum, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "PeriodicityChallenge_ScoreText", new <>z__ReadOnlyArray<object>(new object[]
			{
				areaStars.ToString(),
				areaAllStars.ToString()
			}));
			base.GetItem(0).SetUIActive(areaStars < areaAllStars);
			base.GetItem(1).SetUIActive(areaStars >= areaAllStars);
		}
	}
}
