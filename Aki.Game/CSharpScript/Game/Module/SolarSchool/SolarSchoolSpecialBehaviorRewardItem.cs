using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A3B RID: 23099
	public class SolarSchoolSpecialBehaviorRewardItem : GridProxyAbstract<SolarSchoolReward>
	{
		// Token: 0x06038F4B RID: 233291 RVA: 0x00FF4F14 File Offset: 0x00FF3114
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038F4C RID: 233292 RVA: 0x00FF4FC0 File Offset: 0x00FF31C0
		public override void Refresh(SolarSchoolReward data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			SolarSchoolConfig instance = SolarSchoolConfig.Instance;
			ESolarSchoolSecondAttr attr = ESolarSchoolSecondAttr.None;
			string path;
			string name;
			switch (data.RewardType)
			{
			case 0:
			{
				SolarSchoolAttr? attr2 = instance.GetAttr(data.TargetId);
				if (attr2 == null)
				{
					return;
				}
				path = attr2.Value.IconSmall;
				name = attr2.Value.Name;
				attr = (ESolarSchoolSecondAttr)attr2.Value.AttrType;
				if (sprite != null)
				{
					sprite.SetUIActive(SolarSchoolGamePlayModel.Instance.PlayerData.IsAttrImportant(attr));
				}
				break;
			}
			case 1:
			{
				SolarSchoolRole? role = instance.GetRole(data.TargetId);
				if (role == null)
				{
					return;
				}
				path = role.Value.HeadIcon;
				name = role.Value.Name;
				break;
			}
			case 2:
			{
				SolarSchoolItem? item = instance.GetItem(data.TargetId);
				if (item == null)
				{
					return;
				}
				path = item.Value.Icon;
				name = item.Value.Name;
				break;
			}
			default:
				return;
			}
			base.SetTextureByPath(path, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(SolarSchoolUtils.GetAttrDeltaText(attr, data.Value), true);
		}

		// Token: 0x0200B643 RID: 46659
		private class EComponents
		{
			// Token: 0x0403861C RID: 230940
			public const int TexIcon = 0;

			// Token: 0x0403861D RID: 230941
			public const int TxtName = 1;

			// Token: 0x0403861E RID: 230942
			public const int TxtNum = 2;

			// Token: 0x0403861F RID: 230943
			public const int SprScratch = 3;
		}
	}
}
