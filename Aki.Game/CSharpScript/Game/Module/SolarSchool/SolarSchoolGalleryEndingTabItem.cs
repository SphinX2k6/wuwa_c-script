using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A22 RID: 23074
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolGalleryEndingTabItem : GridProxyAbstract<SolarSchoolGalleryData>
	{
		// Token: 0x06038D3A RID: 232762 RVA: 0x00FE8A24 File Offset: 0x00FE6C24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D3B RID: 232763 RVA: 0x00FE8B4E File Offset: 0x00FE6D4E
		private void OnClickToggle(EToggleState toggleState)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolGalleryEndingDetailView, this.Data.Config.Id, null);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038D3C RID: 232764 RVA: 0x00FE8B86 File Offset: 0x00FE6D86
		public UUIItem GetGuideEndingItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x06038D3D RID: 232765 RVA: 0x00FE8B9C File Offset: 0x00FE6D9C
		[NullableContext(1)]
		public override void Refresh(SolarSchoolGalleryData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetItem(1).SetUIActive(data.IsUnlock);
			base.GetItem(4).SetUIActive(!data.IsUnlock);
			SolarSchoolGallery config = data.Config;
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			base.SetTextureByPath((playerGender == EPlayerGender.Male) ? config.IconMale : config.IconFemale, base.GetTexture(2), null, null);
			SolarSchoolEnding? config2 = ConfigSolarSchoolEndingById.GetConfig(config.Param, true);
			if (config2 != null)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), config2.Value.Desc, Array.Empty<object>());
			}
			bool flag;
			if (data != null && data.IsUnlock && !data.IsGetReward)
			{
				SolarSchoolGallery config3 = data.Config;
				flag = (config3.DropId > 0);
			}
			else
			{
				flag = false;
			}
			bool uiactive = flag;
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x0401DE8C RID: 122508
		private SolarSchoolGalleryData Data;

		// Token: 0x0200B5ED RID: 46573
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403842A RID: 230442
			public const int Toggle = 0;

			// Token: 0x0403842B RID: 230443
			public const int ShowItem = 1;

			// Token: 0x0403842C RID: 230444
			public const int Texture = 2;

			// Token: 0x0403842D RID: 230445
			public const int NameText = 3;

			// Token: 0x0403842E RID: 230446
			public const int EmptyItem = 4;

			// Token: 0x0403842F RID: 230447
			public const int RedDotItem = 5;
		}
	}
}
