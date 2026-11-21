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
	// Token: 0x02005A1E RID: 23070
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolGalleryCgTabItem : GridProxyAbstract<SolarSchoolGalleryData>
	{
		// Token: 0x06038D18 RID: 232728 RVA: 0x00FE79D8 File Offset: 0x00FE5BD8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D19 RID: 232729 RVA: 0x00FE7AE1 File Offset: 0x00FE5CE1
		protected override void OnStart()
		{
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x06038D1A RID: 232730 RVA: 0x00FE7AF0 File Offset: 0x00FE5CF0
		private void OnClickItem(EToggleState toggleState)
		{
			SolarSchoolGalleryData data = this.Data;
			if (data != null && data.IsUnlock)
			{
				SolarSchoolActivityData activityData = this.ActivityData;
				if (activityData != null)
				{
					activityData.SetGalleryViewed(this.Data.Config.Id);
				}
				base.GetItem(5).SetUIActive(false);
				UiManager.Instance.OpenView(EUiViewName.SolarSchoolGalleryCgDetailView, this.Data.Config.Id, null);
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038D1B RID: 232731 RVA: 0x00FE7B74 File Offset: 0x00FE5D74
		[NullableContext(1)]
		public override void Refresh(SolarSchoolGalleryData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (this.ActivityData == null)
			{
				this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			}
			base.GetItem(1).SetUIActive(data.IsUnlock);
			base.GetItem(4).SetUIActive(!data.IsUnlock);
			UUIItem item = base.GetItem(5);
			bool uiactive;
			if (data.IsUnlock)
			{
				SolarSchoolActivityData activityData = this.ActivityData;
				uiactive = (activityData == null || !activityData.IsGalleryViewed(data.Config.Id));
			}
			else
			{
				uiactive = false;
			}
			item.SetUIActive(uiactive);
			SolarSchoolGallery config = data.Config;
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			base.SetTextureByPath((playerGender == EPlayerGender.Male) ? config.IconMale : config.IconFemale, base.GetTexture(2), null, null);
		}

		// Token: 0x0401DE7D RID: 122493
		private SolarSchoolGalleryData Data;

		// Token: 0x0401DE7E RID: 122494
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0200B5E5 RID: 46565
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038400 RID: 230400
			public const int Toggle = 0;

			// Token: 0x04038401 RID: 230401
			public const int ShowItem = 1;

			// Token: 0x04038402 RID: 230402
			public const int Texture = 2;

			// Token: 0x04038403 RID: 230403
			public const int NameText = 3;

			// Token: 0x04038404 RID: 230404
			public const int EmptyItem = 4;

			// Token: 0x04038405 RID: 230405
			public const int RedDotItem = 5;
		}
	}
}
