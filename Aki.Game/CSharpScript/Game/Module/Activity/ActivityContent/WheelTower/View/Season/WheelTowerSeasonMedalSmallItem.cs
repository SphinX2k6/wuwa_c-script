using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02005F64 RID: 24420
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class WheelTowerSeasonMedalSmallItem : GridProxyAbstract<IWheelTowerMedalItemData>
	{
		// Token: 0x0603E019 RID: 253977 RVA: 0x00EF7A34 File Offset: 0x00EF5C34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E01A RID: 253978 RVA: 0x00EF7AE0 File Offset: 0x00EF5CE0
		public override void Refresh(IWheelTowerMedalItemData data, bool isSelected, int gridIndex)
		{
			IWheelTowerMedalGroupData medalGroupData = WheelTowerModel.Instance.GetMedalGroupData(data.GroupId);
			if (medalGroupData == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(medalGroupData.IsMaxLevel);
			}
			UUITexture texture2 = base.GetTexture(3);
			if (texture2 != null)
			{
				texture2.SetUIActive(!medalGroupData.IsMaxLevel);
			}
			if (medalGroupData.CurrentMedalId == 0)
			{
				return;
			}
			NewTowerMedal? medalConfigById = WheelTowerConfig.Instance.GetMedalConfigById(medalGroupData.CurrentMedalId);
			if (medalConfigById == null)
			{
				return;
			}
			base.SetTextureByPath(medalConfigById.Value.Background, base.GetTexture(0), null, null);
			base.SetTextureByPath(medalConfigById.Value.Icon, base.GetTexture(1), null, null);
		}
	}
}
