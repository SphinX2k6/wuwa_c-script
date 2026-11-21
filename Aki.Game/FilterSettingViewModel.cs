using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016EE RID: 5870
[NullableContext(2)]
[Nullable(0)]
public class FilterSettingViewModel
{
	// Token: 0x170015C7 RID: 5575
	// (get) Token: 0x0600E452 RID: 58450 RVA: 0x00430E34 File Offset: 0x0042F034
	public float ControlCameraRate
	{
		get
		{
			if (this.ControlCameraRateInternal == null)
			{
				int? intConfig = ConfigCommonParamById.GetIntConfig("ControlCameraRate");
				this.ControlCameraRateInternal = ((intConfig != null) ? new float?((float)(intConfig.GetValueOrDefault() / 100)) : null);
			}
			return this.ControlCameraRateInternal.Value;
		}
	}

	// Token: 0x170015C8 RID: 5576
	// (get) Token: 0x0600E453 RID: 58451 RVA: 0x00430E8E File Offset: 0x0042F08E
	[Nullable(1)]
	public string CoordinateTextId
	{
		[NullableContext(1)]
		get
		{
			return "PrefabTextItem_2070808429_Text";
		}
	}

	// Token: 0x170015C9 RID: 5577
	// (get) Token: 0x0600E454 RID: 58452 RVA: 0x00430E95 File Offset: 0x0042F095
	// (set) Token: 0x0600E455 RID: 58453 RVA: 0x00430EA8 File Offset: 0x0042F0A8
	public float IntensityNormalized
	{
		get
		{
			return this.IntensityNormalizedInternal.GetValueOrDefault(0.5f);
		}
		set
		{
			float? intensityNormalizedInternal = this.IntensityNormalizedInternal;
			if (!(intensityNormalizedInternal.GetValueOrDefault() == value & intensityNormalizedInternal != null))
			{
				this.IntensityNormalizedInternal = new float?(value);
				this.DirtyFlags |= 2;
			}
		}
	}

	// Token: 0x170015CA RID: 5578
	// (get) Token: 0x0600E456 RID: 58454 RVA: 0x00430EEC File Offset: 0x0042F0EC
	[Nullable(1)]
	public string IntensityString
	{
		[NullableContext(1)]
		get
		{
			return Math.Round((double)(this.IntensityNormalized * 100f)).ToString();
		}
	}

	// Token: 0x170015CB RID: 5579
	// (get) Token: 0x0600E457 RID: 58455 RVA: 0x00430F13 File Offset: 0x0042F113
	// (set) Token: 0x0600E458 RID: 58456 RVA: 0x00430F28 File Offset: 0x0042F128
	public float HorizontalNormalized
	{
		get
		{
			return this.HorizontalNormalizedInternal.GetValueOrDefault(0.5f);
		}
		set
		{
			float num = MathUtils.Instance.Clamp(value, 0f, 1f);
			this.SetHorizontalNormalized(num);
			if (this.UpLeftPos != null && this.UpRightPos != null)
			{
				float x = this.UpLeftPos.Value.X;
				float x2 = this.UpRightPos.Value.X;
				this.HorizontalRealInternal = new float?(MathUtils.Instance.Lerp(x, x2, num));
			}
		}
	}

	// Token: 0x0600E459 RID: 58457 RVA: 0x00430FA8 File Offset: 0x0042F1A8
	private void SetHorizontalNormalized(float value)
	{
		float? horizontalNormalizedInternal = this.HorizontalNormalizedInternal;
		if (!(horizontalNormalizedInternal.GetValueOrDefault() == value & horizontalNormalizedInternal != null))
		{
			this.HorizontalNormalizedInternal = new float?(MathUtils.Instance.Clamp(value, 0f, 1f));
			this.DirtyFlags |= 4;
		}
	}

	// Token: 0x170015CC RID: 5580
	// (get) Token: 0x0600E45A RID: 58458 RVA: 0x00431000 File Offset: 0x0042F200
	[Nullable(1)]
	public string HorizontalString
	{
		[NullableContext(1)]
		get
		{
			return Math.Round((double)MathUtils.Instance.Lerp(-5f, 5f, this.HorizontalNormalized)).ToString();
		}
	}

	// Token: 0x170015CD RID: 5581
	// (get) Token: 0x0600E45B RID: 58459 RVA: 0x00431035 File Offset: 0x0042F235
	// (set) Token: 0x0600E45C RID: 58460 RVA: 0x00431048 File Offset: 0x0042F248
	public float VerticalNormalized
	{
		get
		{
			return this.VerticalNormalizedInternal.GetValueOrDefault(0.5f);
		}
		set
		{
			float num = MathUtils.Instance.Clamp(value, 0f, 1f);
			this.SetVerticalNormalized(num);
			if (this.DownLeftPos != null && this.UpLeftPos != null)
			{
				float z = this.DownLeftPos.Value.Z;
				float z2 = this.UpLeftPos.Value.Z;
				this.VerticalRealInternal = new float?(MathUtils.Instance.Lerp(z, z2, num));
			}
		}
	}

	// Token: 0x0600E45D RID: 58461 RVA: 0x004310C8 File Offset: 0x0042F2C8
	private void SetVerticalNormalized(float value)
	{
		float? verticalNormalizedInternal = this.VerticalNormalizedInternal;
		if (!(verticalNormalizedInternal.GetValueOrDefault() == value & verticalNormalizedInternal != null))
		{
			this.VerticalNormalizedInternal = new float?(MathUtils.Instance.Clamp(value, 0f, 1f));
			this.DirtyFlags |= 8;
		}
	}

	// Token: 0x170015CE RID: 5582
	// (get) Token: 0x0600E45E RID: 58462 RVA: 0x00431120 File Offset: 0x0042F320
	[Nullable(1)]
	public string VerticalString
	{
		[NullableContext(1)]
		get
		{
			return Math.Round((double)MathUtils.Instance.Lerp(-5f, 5f, this.VerticalNormalized)).ToString();
		}
	}

	// Token: 0x170015CF RID: 5583
	// (get) Token: 0x0600E45F RID: 58463 RVA: 0x00431158 File Offset: 0x0042F358
	// (set) Token: 0x0600E460 RID: 58464 RVA: 0x004311D4 File Offset: 0x0042F3D4
	public float? HorizontalReal
	{
		get
		{
			if (this.HorizontalRealInternal == null && this.UpLeftPos != null && this.UpRightPos != null)
			{
				float x = this.UpLeftPos.Value.X;
				float x2 = this.UpRightPos.Value.X;
				this.HorizontalRealInternal = new float?(MathUtils.Instance.Lerp(x, x2, this.HorizontalNormalized));
			}
			return this.HorizontalRealInternal;
		}
		set
		{
			if (value == null || this.UpLeftPos == null || this.UpRightPos == null)
			{
				return;
			}
			float x = this.UpLeftPos.Value.X;
			float x2 = this.UpRightPos.Value.X;
			this.HorizontalRealInternal = new float?(MathUtils.Instance.Clamp(value.Value, x, x2));
			float horizontalNormalized = (float)MathUtils.Instance.GetRoundToNDecimalPlaces(MathUtils.Instance.InverseLerp((double)this.HorizontalRealInternal.Value, (double)x, (double)x2), 1);
			this.SetHorizontalNormalized(horizontalNormalized);
		}
	}

	// Token: 0x170015D0 RID: 5584
	// (get) Token: 0x0600E461 RID: 58465 RVA: 0x00431274 File Offset: 0x0042F474
	// (set) Token: 0x0600E462 RID: 58466 RVA: 0x004312F0 File Offset: 0x0042F4F0
	public float? VerticalReal
	{
		get
		{
			if (this.VerticalRealInternal == null && this.DownLeftPos != null && this.UpLeftPos != null)
			{
				float z = this.DownLeftPos.Value.Z;
				float z2 = this.UpLeftPos.Value.Z;
				this.VerticalRealInternal = new float?(MathUtils.Instance.Lerp(z, z2, this.VerticalNormalized));
			}
			return this.VerticalRealInternal;
		}
		set
		{
			if (value == null || this.DownLeftPos == null || this.UpLeftPos == null)
			{
				return;
			}
			float z = this.DownLeftPos.Value.Z;
			float z2 = this.UpLeftPos.Value.Z;
			this.VerticalRealInternal = new float?(MathUtils.Instance.Clamp(value.Value, z, z2));
			float verticalNormalized = (float)MathUtils.Instance.GetRoundToNDecimalPlaces(MathUtils.Instance.InverseLerp((double)this.VerticalRealInternal.Value, (double)z, (double)z2), 1);
			this.SetVerticalNormalized(verticalNormalized);
		}
	}

	// Token: 0x170015D1 RID: 5585
	// (get) Token: 0x0600E463 RID: 58467 RVA: 0x0043138F File Offset: 0x0042F58F
	// (set) Token: 0x0600E464 RID: 58468 RVA: 0x00431397 File Offset: 0x0042F597
	public string FilterNameTextId
	{
		get
		{
			return this.FilterNameTextIdInternal;
		}
		set
		{
			if (this.FilterNameTextIdInternal != value)
			{
				this.FilterNameTextIdInternal = value;
				this.DirtyFlags |= 16;
			}
		}
	}

	// Token: 0x170015D2 RID: 5586
	// (get) Token: 0x0600E465 RID: 58469 RVA: 0x004313BD File Offset: 0x0042F5BD
	// (set) Token: 0x0600E466 RID: 58470 RVA: 0x004313C5 File Offset: 0x0042F5C5
	public string FilterPadTexturePath
	{
		get
		{
			return this.FilterPadTexturePathInternal;
		}
		set
		{
			if (this.FilterPadTexturePathInternal != value)
			{
				this.FilterPadTexturePathInternal = value;
				this.DirtyFlags |= 32;
			}
		}
	}

	// Token: 0x170015D3 RID: 5587
	// (get) Token: 0x0600E467 RID: 58471 RVA: 0x004313EB File Offset: 0x0042F5EB
	// (set) Token: 0x0600E468 RID: 58472 RVA: 0x004313F3 File Offset: 0x0042F5F3
	public bool IsHideByPad
	{
		get
		{
			return this.IsHideByPadInternal;
		}
		set
		{
			if (this.IsHideByPadInternal != value)
			{
				this.IsHideByPadInternal = value;
				this.DirtyFlags |= 64;
				LoadingModel.Instance.IsShowUidView = !value;
			}
		}
	}

	// Token: 0x170015D4 RID: 5588
	// (get) Token: 0x0600E469 RID: 58473 RVA: 0x00431422 File Offset: 0x0042F622
	// (set) Token: 0x0600E46A RID: 58474 RVA: 0x0043142A File Offset: 0x0042F62A
	public bool IsHideByClick
	{
		get
		{
			return this.IsHideByClickInternal;
		}
		set
		{
			if (this.IsHideByClickInternal != value)
			{
				this.IsHideByClickInternal = value;
				this.DirtyFlags |= 128;
				LoadingModel.Instance.IsShowUidView = !value;
			}
		}
	}

	// Token: 0x170015D5 RID: 5589
	// (get) Token: 0x0600E46B RID: 58475 RVA: 0x0043145C File Offset: 0x0042F65C
	// (set) Token: 0x0600E46C RID: 58476 RVA: 0x00431464 File Offset: 0x0042F664
	public bool IsSliderActive
	{
		get
		{
			return this.IsSliderActiveInternal;
		}
		set
		{
			if (this.IsSliderActiveInternal != value)
			{
				this.IsSliderActiveInternal = value;
				this.DirtyFlags |= 256;
			}
		}
	}

	// Token: 0x170015D6 RID: 5590
	// (get) Token: 0x0600E46D RID: 58477 RVA: 0x00431488 File Offset: 0x0042F688
	// (set) Token: 0x0600E46E RID: 58478 RVA: 0x00431490 File Offset: 0x0042F690
	public bool IsSeniorParamRefresh
	{
		get
		{
			return this.IsSeniorParamRefreshInternal;
		}
		set
		{
			this.IsSeniorParamRefreshInternal = value;
			if (value)
			{
				this.DirtyFlags |= 512;
			}
		}
	}

	// Token: 0x170015D7 RID: 5591
	// (get) Token: 0x0600E46F RID: 58479 RVA: 0x004314AE File Offset: 0x0042F6AE
	// (set) Token: 0x0600E470 RID: 58480 RVA: 0x004314B6 File Offset: 0x0042F6B6
	public bool IsFilterChanged
	{
		get
		{
			return this.IsFilterChangedInternal;
		}
		set
		{
			this.IsFilterChangedInternal = value;
			if (value)
			{
				this.IsApplyClicked = false;
				MenuModel.Instance.FilterChangedMap[MenuModel.Instance.FilterSettingIdCache] = true;
			}
		}
	}

	// Token: 0x170015D8 RID: 5592
	// (get) Token: 0x0600E471 RID: 58481 RVA: 0x004314E3 File Offset: 0x0042F6E3
	public bool IsOtherViewOpen
	{
		get
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.HelpView);
		}
	}

	// Token: 0x170015D9 RID: 5593
	// (get) Token: 0x0600E472 RID: 58482 RVA: 0x004314F4 File Offset: 0x0042F6F4
	[Nullable(1)]
	public FilterSetting[] FilterList
	{
		[NullableContext(1)]
		get
		{
			if (this.FilterListInternal == null)
			{
				IReadOnlyList<FilterSetting> configList = ConfigFilterSettingAll.GetConfigList(true);
				if (configList != null)
				{
					this.FilterListInternal = new FilterSetting[configList.Count];
					for (int i = 0; i < configList.Count; i++)
					{
						this.FilterListInternal[i] = configList[i];
					}
				}
				else
				{
					this.FilterListInternal = new FilterSetting[0];
				}
			}
			return this.FilterListInternal;
		}
	}

	// Token: 0x170015DA RID: 5594
	// (get) Token: 0x0600E473 RID: 58483 RVA: 0x0043155C File Offset: 0x0042F75C
	public bool IsDirty
	{
		get
		{
			return this.DirtyFlags != 0;
		}
	}

	// Token: 0x0600E474 RID: 58484 RVA: 0x00431567 File Offset: 0x0042F767
	public bool IsPropertyDirty(int flag)
	{
		return (this.DirtyFlags & flag) != 0;
	}

	// Token: 0x0600E475 RID: 58485 RVA: 0x00431574 File Offset: 0x0042F774
	public void CleanDirty()
	{
		this.DirtyFlags = 0;
	}

	// Token: 0x0400825C RID: 33372
	private int DirtyFlags;

	// Token: 0x0400825D RID: 33373
	private float? ControlCameraRateInternal;

	// Token: 0x0400825E RID: 33374
	private float? IntensityNormalizedInternal;

	// Token: 0x0400825F RID: 33375
	private float? HorizontalNormalizedInternal;

	// Token: 0x04008260 RID: 33376
	private float? VerticalNormalizedInternal;

	// Token: 0x04008261 RID: 33377
	private float? HorizontalRealInternal;

	// Token: 0x04008262 RID: 33378
	private float? VerticalRealInternal;

	// Token: 0x04008263 RID: 33379
	private string FilterNameTextIdInternal;

	// Token: 0x04008264 RID: 33380
	private string FilterPadTexturePathInternal;

	// Token: 0x04008265 RID: 33381
	private bool IsHideByPadInternal;

	// Token: 0x04008266 RID: 33382
	private bool IsHideByClickInternal;

	// Token: 0x04008267 RID: 33383
	private bool IsSliderActiveInternal = true;

	// Token: 0x04008268 RID: 33384
	private bool IsSeniorParamRefreshInternal;

	// Token: 0x04008269 RID: 33385
	public bool IsApplyClicked;

	// Token: 0x0400826A RID: 33386
	private bool IsFilterChangedInternal;

	// Token: 0x0400826B RID: 33387
	public bool IsLeftStickHorizontalMoved;

	// Token: 0x0400826C RID: 33388
	public bool IsLeftStickVerticalMoved;

	// Token: 0x0400826D RID: 33389
	public FVector? LastMoveVector;

	// Token: 0x0400826E RID: 33390
	public FVector? UpLeftPos;

	// Token: 0x0400826F RID: 33391
	public FVector? UpRightPos;

	// Token: 0x04008270 RID: 33392
	public FVector? DownLeftPos;

	// Token: 0x04008271 RID: 33393
	public UiCameraPhotographerComponent PhotographerComponent;

	// Token: 0x04008272 RID: 33394
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> PhotographOptionMap = new Dictionary<EPhotoSetupValueType, float>();

	// Token: 0x04008273 RID: 33395
	public int? EntityDisableId = new int?(0);

	// Token: 0x04008274 RID: 33396
	public EntityHandle SetDisableEntity;

	// Token: 0x04008275 RID: 33397
	public bool CameraRotationLock;

	// Token: 0x04008276 RID: 33398
	public bool PadLock;

	// Token: 0x04008277 RID: 33399
	public int InitFilterIndex;

	// Token: 0x04008278 RID: 33400
	private FilterSetting[] FilterListInternal;

	// Token: 0x04008279 RID: 33401
	public Action OnHideClick;

	// Token: 0x0400827A RID: 33402
	public Action OnResetClick;

	// Token: 0x0400827B RID: 33403
	public Action OnResetPointClick;

	// Token: 0x0400827C RID: 33404
	public Action OnResetAllSeniorParamClick;

	// Token: 0x0400827D RID: 33405
	public Action<EFilterSettingValueIndex> OnResetSingleParamClick;

	// Token: 0x0400827E RID: 33406
	public Action OnConfirmClick;

	// Token: 0x0400827F RID: 33407
	public Action OnCloseClick;

	// Token: 0x04008280 RID: 33408
	public Action OnPadChanged;

	// Token: 0x04008281 RID: 33409
	public Action OnPadChangeStop;

	// Token: 0x04008282 RID: 33410
	public Action OnSliderChanged;

	// Token: 0x04008283 RID: 33411
	public Action<EFilterSettingValueIndex, float> OnSeniorSliderChanged;

	// Token: 0x04008284 RID: 33412
	public Action OnViewBeforeCreate;

	// Token: 0x04008285 RID: 33413
	public Action OnViewBeforeStart;

	// Token: 0x04008286 RID: 33414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> OnViewBeforeShow;

	// Token: 0x04008287 RID: 33415
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> OnViewAfterHide;

	// Token: 0x04008288 RID: 33416
	public Action OnViewDestroy;

	// Token: 0x04008289 RID: 33417
	public Action<ULGUIPointerEventData> OnDragMoved;

	// Token: 0x0400828A RID: 33418
	public Action OnDragBegin;

	// Token: 0x0400828B RID: 33419
	public Action OnDragEnded;

	// Token: 0x0400828C RID: 33420
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiLookUp;

	// Token: 0x0400828D RID: 33421
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiTurn;

	// Token: 0x0400828E RID: 33422
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiMoveForward;

	// Token: 0x0400828F RID: 33423
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiMoveRight;

	// Token: 0x04008290 RID: 33424
	public Action<int> OnIndexChanged;

	// Token: 0x04008291 RID: 33425
	public Action OnLeftArrowClick;

	// Token: 0x04008292 RID: 33426
	public Action OnRightArrowClick;

	// Token: 0x020078CE RID: 30926
	[NullableContext(0)]
	public static class Flags
	{
		// Token: 0x040272A8 RID: 160424
		public const int PointTexturePosition = 1;

		// Token: 0x040272A9 RID: 160425
		public const int IntensityNormalized = 2;

		// Token: 0x040272AA RID: 160426
		public const int HorizontalNormalized = 4;

		// Token: 0x040272AB RID: 160427
		public const int VerticalNormalized = 8;

		// Token: 0x040272AC RID: 160428
		public const int FilterNameTextId = 16;

		// Token: 0x040272AD RID: 160429
		public const int FilterPadTexturePath = 32;

		// Token: 0x040272AE RID: 160430
		public const int IsHideByPad = 64;

		// Token: 0x040272AF RID: 160431
		public const int IsHideByClick = 128;

		// Token: 0x040272B0 RID: 160432
		public const int IsSliderActive = 256;

		// Token: 0x040272B1 RID: 160433
		public const int IsSeniorParamRefresh = 512;
	}
}
