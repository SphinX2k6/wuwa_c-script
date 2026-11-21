using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A25 RID: 23077
	public class SolarSchoolGalleryOpTabView : UiTabViewBase
	{
		// Token: 0x06038D57 RID: 232791 RVA: 0x00FE9388 File Offset: 0x00FE7588
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D58 RID: 232792 RVA: 0x00FE9430 File Offset: 0x00FE7630
		private void OnClickBtn()
		{
			List<SolarSchoolGalleryData> galleryDataList = this.ActivityData.GetGalleryDataList(SolarSchoolGalleryType.Op);
			if (galleryDataList.Count == 0)
			{
				return;
			}
			SolarSchoolGalleryData param = galleryDataList[0];
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolGalleryOpDetailView, param, null);
		}

		// Token: 0x06038D59 RID: 232793 RVA: 0x00FE946C File Offset: 0x00FE766C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolGalleryOpTabView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolGalleryOpTabView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D5A RID: 232794 RVA: 0x00FE94A7 File Offset: 0x00FE76A7
		protected override void OnStart()
		{
			this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
		}

		// Token: 0x06038D5B RID: 232795 RVA: 0x00FE94BC File Offset: 0x00FE76BC
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06038D5C RID: 232796 RVA: 0x00FE94EC File Offset: 0x00FE76EC
		private void RefreshView()
		{
			List<SolarSchoolGalleryData> galleryDataList = this.ActivityData.GetGalleryDataList(SolarSchoolGalleryType.Op);
			if (galleryDataList.Count == 0)
			{
				return;
			}
			SolarSchoolGallery config = galleryDataList[0].Config;
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			base.SetTextureByPath((playerGender == EPlayerGender.Male) ? config.IconMale : config.IconFemale, base.GetTexture(1), null, null);
		}

		// Token: 0x0401DE97 RID: 122519
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0200B5F3 RID: 46579
		private class EComponents
		{
			// Token: 0x04038442 RID: 230466
			public const int Btn = 0;

			// Token: 0x04038443 RID: 230467
			public const int Texture = 1;
		}
	}
}
