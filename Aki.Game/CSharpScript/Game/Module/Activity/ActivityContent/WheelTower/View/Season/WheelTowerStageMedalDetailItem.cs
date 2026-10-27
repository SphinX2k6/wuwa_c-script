using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02005F53 RID: 24403
	public class WheelTowerStageMedalDetailItem : UiPanelBase
	{
		// Token: 0x0603DFE4 RID: 253924 RVA: 0x00EF60D0 File Offset: 0x00EF42D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603DFE5 RID: 253925 RVA: 0x00EF61C0 File Offset: 0x00EF43C0
		[NullableContext(1)]
		public void Refresh(IWheelTowerMedalGroupData groupData)
		{
			int currentMedalId = groupData.CurrentMedalId;
			bool flag = currentMedalId == 0;
			UUITexture texture = base.GetTexture(1);
			UUITexture texture2 = base.GetTexture(2);
			UUITexture texture3 = base.GetTexture(4);
			UUITexture texture4 = base.GetTexture(5);
			UUITexture texture5 = base.GetTexture(0);
			if (texture5 != null)
			{
				texture5.SetUIActive(flag);
			}
			UUITexture texture6 = base.GetTexture(3);
			if (texture6 != null)
			{
				texture6.SetUIActive(flag);
			}
			if (texture != null)
			{
				texture.SetUIActive(!flag);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(!flag);
			}
			if (texture3 != null)
			{
				texture3.SetUIActive(!flag);
			}
			if (texture4 != null)
			{
				texture4.SetUIActive(!flag);
			}
			if (flag)
			{
				return;
			}
			int id = (currentMedalId == 0) ? groupData.NextMedalId : currentMedalId;
			NewTowerMedal? medalConfigById = WheelTowerConfig.Instance.GetMedalConfigById(id);
			string background = medalConfigById.Value.Background;
			string icon = medalConfigById.Value.Icon;
			base.SetTextureByPath(background, texture, null, null);
			base.SetTextureByPath(icon, texture2, null, null);
			base.SetTextureByPath(background, texture3, null, null);
			base.SetTextureByPath(icon, texture4, null, null);
		}
	}
}
