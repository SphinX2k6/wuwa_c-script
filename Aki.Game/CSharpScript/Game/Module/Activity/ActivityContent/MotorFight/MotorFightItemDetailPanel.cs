using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006412 RID: 25618
	public class MotorFightItemDetailPanel : UiPanelBase
	{
		// Token: 0x060406F0 RID: 263920 RVA: 0x00F96360 File Offset: 0x00F94560
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

		// Token: 0x060406F1 RID: 263921 RVA: 0x00F96490 File Offset: 0x00F94690
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

		// Token: 0x0200C636 RID: 50742
		private class EComponents
		{
			// Token: 0x0403BD65 RID: 245093
			public const int ToggleRoot = 0;

			// Token: 0x0403BD66 RID: 245094
			public const int TextureQuality = 1;

			// Token: 0x0403BD67 RID: 245095
			public const int TextName = 2;

			// Token: 0x0403BD68 RID: 245096
			public const int TextureIcon = 3;

			// Token: 0x0403BD69 RID: 245097
			public const int TextTypeName = 4;

			// Token: 0x0403BD6A RID: 245098
			public const int SpriteTypeIcon = 5;

			// Token: 0x0403BD6B RID: 245099
			public const int TextDesc = 6;

			// Token: 0x0403BD6C RID: 245100
			public const int ItemUnlockPanel = 7;

			// Token: 0x0403BD6D RID: 245101
			public const int TextLockTip = 8;
		}
	}
}
