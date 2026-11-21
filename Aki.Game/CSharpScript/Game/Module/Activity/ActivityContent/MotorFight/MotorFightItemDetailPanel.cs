using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005390 RID: 21392
	public class MotorFightItemDetailPanel : UiPanelBase
	{
		// Token: 0x060353B1 RID: 218033 RVA: 0x00EDD300 File Offset: 0x00EDB500
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060353B2 RID: 218034 RVA: 0x00EDD430 File Offset: 0x00EDB630
		[NullableContext(1)]
		public void Refresh(MotorFightItemData data)
		{
			base.SetTextureByPath(MotorFightConfig.Instance.GetMotorFightQuality(data.Quality).Value.DetailCardBg, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
			base.SetTextureByPath(data.BigIcon, base.GetTexture(3), null, null);
			MotorFightItemType? motorFightItemType = MotorFightConfig.Instance.GetMotorFightItemType(data.Type);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), motorFightItemType.Value.Name, Array.Empty<object>());
			this.SetSpriteByPath(motorFightItemType.Value.Icon, base.GetSprite(5), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.Desc, data.DescParams);
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(!data.IsUnLock);
			}
			if (!data.IsUnLock)
			{
				string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(data.ConditionId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), conditionGroupHintText, Array.Empty<object>());
			}
		}

		// Token: 0x0200B01D RID: 45085
		private class EComponents
		{
			// Token: 0x040366C2 RID: 222914
			public const int ToggleRoot = 0;

			// Token: 0x040366C3 RID: 222915
			public const int TextureQuality = 1;

			// Token: 0x040366C4 RID: 222916
			public const int TextName = 2;

			// Token: 0x040366C5 RID: 222917
			public const int TextureIcon = 3;

			// Token: 0x040366C6 RID: 222918
			public const int TextTypeName = 4;

			// Token: 0x040366C7 RID: 222919
			public const int SpriteTypeIcon = 5;

			// Token: 0x040366C8 RID: 222920
			public const int TextDesc = 6;

			// Token: 0x040366C9 RID: 222921
			public const int ItemUnlockPanel = 7;

			// Token: 0x040366CA RID: 222922
			public const int TextLockTip = 8;
		}
	}
}
