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
	// Token: 0x02005A1D RID: 23069
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolGalleryCgDetailView : UiViewBase
	{
		// Token: 0x06038D10 RID: 232720 RVA: 0x00FE76AC File Offset: 0x00FE58AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.PreBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.NextBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038D11 RID: 232721 RVA: 0x00FE77B8 File Offset: 0x00FE59B8
		private void PreBtnClick()
		{
			int num = this.CurrentDataIndex - 1;
			if (num < 0)
			{
				return;
			}
			this.CurrentData = this.DataList[num];
			this.CurrentDataIndex = num;
			this.RefreshView();
			base.PlayOrReplaySequence("Switch_L", false, null);
		}

		// Token: 0x06038D12 RID: 232722 RVA: 0x00FE7808 File Offset: 0x00FE5A08
		private void NextBtnClick()
		{
			int num = this.CurrentDataIndex + 1;
			if (num >= this.DataList.Count)
			{
				return;
			}
			this.CurrentData = this.DataList[num];
			this.CurrentDataIndex = num;
			this.RefreshView();
			base.PlayOrReplaySequence("Switch_R", false, null);
		}

		// Token: 0x06038D13 RID: 232723 RVA: 0x00FE7861 File Offset: 0x00FE5A61
		[NullableContext(1)]
		public SolarSchoolGalleryCgDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D14 RID: 232724 RVA: 0x00FE787C File Offset: 0x00FE5A7C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolGalleryCgDetailView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolGalleryCgDetailView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D15 RID: 232725 RVA: 0x00FE78C0 File Offset: 0x00FE5AC0
		protected override void OnStart()
		{
			this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			this.DataList = this.ActivityData.GetUnLockGalleryDataList(SolarSchoolGalleryType.Cg);
			int id = (int)this.OpenParam;
			this.CurrentDataIndex = this.DataList.FindIndex((SolarSchoolGalleryData data) => data.Config.Id == id);
			this.CurrentData = this.DataList[this.CurrentDataIndex];
			this.RefreshView();
		}

		// Token: 0x06038D16 RID: 232726 RVA: 0x00FE7940 File Offset: 0x00FE5B40
		private void RefreshView()
		{
			SolarSchoolGallery config = this.CurrentData.Config;
			this.ActivityData.SetGalleryViewed(config.Id);
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			base.SetTextureByPath((playerGender == EPlayerGender.Male) ? config.DetailResourceMale : config.DetailResourceFemale, base.GetTexture(1), null, null);
			this.RefreshBtnState();
		}

		// Token: 0x06038D17 RID: 232727 RVA: 0x00FE79A7 File Offset: 0x00FE5BA7
		private void RefreshBtnState()
		{
			base.SetButtonUiActive(2, this.CurrentDataIndex > 0);
			base.SetButtonUiActive(3, this.CurrentDataIndex < this.DataList.Count - 1);
		}

		// Token: 0x0401DE78 RID: 122488
		private SolarSchoolGalleryData CurrentData;

		// Token: 0x0401DE79 RID: 122489
		private int CurrentDataIndex = -1;

		// Token: 0x0401DE7A RID: 122490
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DE7B RID: 122491
		[Nullable(1)]
		private List<SolarSchoolGalleryData> DataList = new List<SolarSchoolGalleryData>();

		// Token: 0x0401DE7C RID: 122492
		private SolarSchoolShortCaptionItem CaptionItem;

		// Token: 0x0200B5E2 RID: 46562
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040383F7 RID: 230391
			public const int CaptionItem = 0;

			// Token: 0x040383F8 RID: 230392
			public const int Texture = 1;

			// Token: 0x040383F9 RID: 230393
			public const int PreBtn = 2;

			// Token: 0x040383FA RID: 230394
			public const int NextBtn = 3;
		}
	}
}
