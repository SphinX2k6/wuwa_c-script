using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200220A RID: 8714
[NullableContext(2)]
[Nullable(0)]
public class FilterSettingViewModel
{
	// Token: 0x17001590 RID: 5520
	// (get) Token: 0x06010FBD RID: 69565 RVA: 0x004242A0 File Offset: 0x004224A0
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

	// Token: 0x17001591 RID: 5521
	// (get) Token: 0x06010FBE RID: 69566 RVA: 0x004242FA File Offset: 0x004224FA
	[Nullable(1)]
	public string CoordinateTextId
	{
		[NullableContext(1)]
		get
		{
			return "PrefabTextItem_2070808429_Text";
		}
	}

	// Token: 0x17001592 RID: 5522
	// (get) Token: 0x06010FBF RID: 69567 RVA: 0x00424301 File Offset: 0x00422501
	// (set) Token: 0x06010FC0 RID: 69568 RVA: 0x00424314 File Offset: 0x00422514
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

	// Token: 0x17001593 RID: 5523
	// (get) Token: 0x06010FC1 RID: 69569 RVA: 0x00424358 File Offset: 0x00422558
	[Nullable(1)]
	public string IntensityString
	{
		[NullableContext(1)]
		get
		{
			return Math.Round((double)(this.IntensityNormalized * 100f)).ToString();
		}
	}

	// Token: 0x17001594 RID: 5524
	// (get) Token: 0x06010FC2 RID: 69570 RVA: 0x0042437F File Offset: 0x0042257F
	// (set) Token: 0x06010FC3 RID: 69571 RVA: 0x00424394 File Offset: 0x00422594
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

	// Token: 0x06010FC4 RID: 69572 RVA: 0x00424414 File Offset: 0x00422614
	private void SetHorizontalNormalized(float value)
	{
		float? horizontalNormalizedInternal = this.HorizontalNormalizedInternal;
		if (!(horizontalNormalizedInternal.GetValueOrDefault() == value & horizontalNormalizedInternal != null))
		{
			this.HorizontalNormalizedInternal = new float?(MathUtils.Instance.Clamp(value, 0f, 1f));
			this.DirtyFlags |= 4;
		}
	}

	// Token: 0x17001595 RID: 5525
	// (get) Token: 0x06010FC5 RID: 69573 RVA: 0x0042446C File Offset: 0x0042266C
	[Nullable(1)]
	public string HorizontalString
	{
		[NullableContext(1)]
		get
		{
			return Math.Round((double)MathUtils.Instance.Lerp(-5f, 5f, this.HorizontalNormalized)).ToString();
		}
	}

	// Token: 0x17001596 RID: 5526
	// (get) Token: 0x06010FC6 RID: 69574 RVA: 0x004244A1 File Offset: 0x004226A1
	// (set) Token: 0x06010FC7 RID: 69575 RVA: 0x004244B4 File Offset: 0x004226B4
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

	// Token: 0x06010FC8 RID: 69576 RVA: 0x00424534 File Offset: 0x00422734
	private void SetVerticalNormalized(float value)
	{
		float? verticalNormalizedInternal = this.VerticalNormalizedInternal;
		if (!(verticalNormalizedInternal.GetValueOrDefault() == value & verticalNormalizedInternal != null))
		{
			this.VerticalNormalizedInternal = new float?(MathUtils.Instance.Clamp(value, 0f, 1f));
			this.DirtyFlags |= 8;
		}
	}

	// Token: 0x17001597 RID: 5527
	// (get) Token: 0x06010FC9 RID: 69577 RVA: 0x0042458C File Offset: 0x0042278C
	[Nullable(1)]
	public string VerticalString
	{
		[NullableContext(1)]
		get
		{
			return Math.Round((double)MathUtils.Instance.Lerp(-5f, 5f, this.VerticalNormalized)).ToString();
		}
	}

	// Token: 0x17001598 RID: 5528
	// (get) Token: 0x06010FCA RID: 69578 RVA: 0x004245C4 File Offset: 0x004227C4
	// (set) Token: 0x06010FCB RID: 69579 RVA: 0x00424640 File Offset: 0x00422840
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

	// Token: 0x17001599 RID: 5529
	// (get) Token: 0x06010FCC RID: 69580 RVA: 0x004246E0 File Offset: 0x004228E0
	// (set) Token: 0x06010FCD RID: 69581 RVA: 0x0042475C File Offset: 0x0042295C
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

	// Token: 0x1700159A RID: 5530
	// (get) Token: 0x06010FCE RID: 69582 RVA: 0x004247FB File Offset: 0x004229FB
	// (set) Token: 0x06010FCF RID: 69583 RVA: 0x00424803 File Offset: 0x00422A03
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

	// Token: 0x1700159B RID: 5531
	// (get) Token: 0x06010FD0 RID: 69584 RVA: 0x00424829 File Offset: 0x00422A29
	// (set) Token: 0x06010FD1 RID: 69585 RVA: 0x00424831 File Offset: 0x00422A31
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

	// Token: 0x1700159C RID: 5532
	// (get) Token: 0x06010FD2 RID: 69586 RVA: 0x00424857 File Offset: 0x00422A57
	// (set) Token: 0x06010FD3 RID: 69587 RVA: 0x0042485F File Offset: 0x00422A5F
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

	// Token: 0x1700159D RID: 5533
	// (get) Token: 0x06010FD4 RID: 69588 RVA: 0x0042488E File Offset: 0x00422A8E
	// (set) Token: 0x06010FD5 RID: 69589 RVA: 0x00424896 File Offset: 0x00422A96
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

	// Token: 0x1700159E RID: 5534
	// (get) Token: 0x06010FD6 RID: 69590 RVA: 0x004248C8 File Offset: 0x00422AC8
	// (set) Token: 0x06010FD7 RID: 69591 RVA: 0x004248D0 File Offset: 0x00422AD0
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

	// Token: 0x1700159F RID: 5535
	// (get) Token: 0x06010FD8 RID: 69592 RVA: 0x004248F4 File Offset: 0x00422AF4
	// (set) Token: 0x06010FD9 RID: 69593 RVA: 0x004248FC File Offset: 0x00422AFC
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

	// Token: 0x170015A0 RID: 5536
	// (get) Token: 0x06010FDA RID: 69594 RVA: 0x0042491A File Offset: 0x00422B1A
	// (set) Token: 0x06010FDB RID: 69595 RVA: 0x00424922 File Offset: 0x00422B22
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

	// Token: 0x170015A1 RID: 5537
	// (get) Token: 0x06010FDC RID: 69596 RVA: 0x0042494F File Offset: 0x00422B4F
	public bool IsOtherViewOpen
	{
		get
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.HelpView);
		}
	}

	// Token: 0x170015A2 RID: 5538
	// (get) Token: 0x06010FDD RID: 69597 RVA: 0x00424960 File Offset: 0x00422B60
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

	// Token: 0x170015A3 RID: 5539
	// (get) Token: 0x06010FDE RID: 69598 RVA: 0x004249C8 File Offset: 0x00422BC8
	public bool IsDirty
	{
		get
		{
			return this.DirtyFlags != 0;
		}
	}

	// Token: 0x06010FDF RID: 69599 RVA: 0x004249D3 File Offset: 0x00422BD3
	public bool IsPropertyDirty(int flag)
	{
		return (this.DirtyFlags & flag) != 0;
	}

	// Token: 0x06010FE0 RID: 69600 RVA: 0x004249E0 File Offset: 0x00422BE0
	public void CleanDirty()
	{
		this.DirtyFlags = 0;
	}

	// Token: 0x0400811E RID: 33054
	private int DirtyFlags;

	// Token: 0x0400811F RID: 33055
	private float? ControlCameraRateInternal;

	// Token: 0x04008120 RID: 33056
	private float? IntensityNormalizedInternal;

	// Token: 0x04008121 RID: 33057
	private float? HorizontalNormalizedInternal;

	// Token: 0x04008122 RID: 33058
	private float? VerticalNormalizedInternal;

	// Token: 0x04008123 RID: 33059
	private float? HorizontalRealInternal;

	// Token: 0x04008124 RID: 33060
	private float? VerticalRealInternal;

	// Token: 0x04008125 RID: 33061
	private string FilterNameTextIdInternal;

	// Token: 0x04008126 RID: 33062
	private string FilterPadTexturePathInternal;

	// Token: 0x04008127 RID: 33063
	private bool IsHideByPadInternal;

	// Token: 0x04008128 RID: 33064
	private bool IsHideByClickInternal;

	// Token: 0x04008129 RID: 33065
	private bool IsSliderActiveInternal = true;

	// Token: 0x0400812A RID: 33066
	private bool IsSeniorParamRefreshInternal;

	// Token: 0x0400812B RID: 33067
	public bool IsApplyClicked;

	// Token: 0x0400812C RID: 33068
	private bool IsFilterChangedInternal;

	// Token: 0x0400812D RID: 33069
	public bool IsLeftStickHorizontalMoved;

	// Token: 0x0400812E RID: 33070
	public bool IsLeftStickVerticalMoved;

	// Token: 0x0400812F RID: 33071
	public FVector? LastMoveVector;

	// Token: 0x04008130 RID: 33072
	public FVector? UpLeftPos;

	// Token: 0x04008131 RID: 33073
	public FVector? UpRightPos;

	// Token: 0x04008132 RID: 33074
	public FVector? DownLeftPos;

	// Token: 0x04008133 RID: 33075
	public UiCameraPhotographerStructure UiCameraPhotographerStructure;

	// Token: 0x04008134 RID: 33076
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> PhotographOptionMap = new Dictionary<EPhotoSetupValueType, float>();

	// Token: 0x04008135 RID: 33077
	public int? EntityDisableId = new int?(0);

	// Token: 0x04008136 RID: 33078
	public EntityHandle SetDisableEntity;

	// Token: 0x04008137 RID: 33079
	public bool CameraRotationLock;

	// Token: 0x04008138 RID: 33080
	public bool PadLock;

	// Token: 0x04008139 RID: 33081
	public int InitFilterIndex;

	// Token: 0x0400813A RID: 33082
	private FilterSetting[] FilterListInternal;

	// Token: 0x0400813B RID: 33083
	public Action OnHideClick;

	// Token: 0x0400813C RID: 33084
	public Action OnResetClick;

	// Token: 0x0400813D RID: 33085
	public Action OnResetPointClick;

	// Token: 0x0400813E RID: 33086
	public Action OnResetAllSeniorParamClick;

	// Token: 0x0400813F RID: 33087
	public Action<EFilterSettingValueIndex> OnResetSingleParamClick;

	// Token: 0x04008140 RID: 33088
	public Action OnConfirmClick;

	// Token: 0x04008141 RID: 33089
	public Action OnCloseClick;

	// Token: 0x04008142 RID: 33090
	public Action OnPadChanged;

	// Token: 0x04008143 RID: 33091
	public Action OnPadChangeStop;

	// Token: 0x04008144 RID: 33092
	public Action OnSliderChanged;

	// Token: 0x04008145 RID: 33093
	public Action<EFilterSettingValueIndex, float> OnSeniorSliderChanged;

	// Token: 0x04008146 RID: 33094
	public Action OnViewBeforeCreate;

	// Token: 0x04008147 RID: 33095
	public Action OnViewBeforeStart;

	// Token: 0x04008148 RID: 33096
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> OnViewBeforeShow;

	// Token: 0x04008149 RID: 33097
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> OnViewAfterHide;

	// Token: 0x0400814A RID: 33098
	public Action OnViewDestroy;

	// Token: 0x0400814B RID: 33099
	public Action<ULGUIPointerEventData> OnDragMoved;

	// Token: 0x0400814C RID: 33100
	public Action OnDragBegin;

	// Token: 0x0400814D RID: 33101
	public Action OnDragEnded;

	// Token: 0x0400814E RID: 33102
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiLookUp;

	// Token: 0x0400814F RID: 33103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiTurn;

	// Token: 0x04008150 RID: 33104
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiMoveForward;

	// Token: 0x04008151 RID: 33105
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string, float> OnInputUiMoveRight;

	// Token: 0x04008152 RID: 33106
	public Action<int> OnIndexChanged;

	// Token: 0x04008153 RID: 33107
	public Action OnLeftArrowClick;

	// Token: 0x04008154 RID: 33108
	public Action OnRightArrowClick;

	// Token: 0x02008745 RID: 34629
	[NullableContext(0)]
	public static class Flags
	{
		// Token: 0x0402BF90 RID: 180112
		public const int PointTexturePosition = 1;

		// Token: 0x0402BF91 RID: 180113
		public const int IntensityNormalized = 2;

		// Token: 0x0402BF92 RID: 180114
		public const int HorizontalNormalized = 4;

		// Token: 0x0402BF93 RID: 180115
		public const int VerticalNormalized = 8;

		// Token: 0x0402BF94 RID: 180116
		public const int FilterNameTextId = 16;

		// Token: 0x0402BF95 RID: 180117
		public const int FilterPadTexturePath = 32;

		// Token: 0x0402BF96 RID: 180118
		public const int IsHideByPad = 64;

		// Token: 0x0402BF97 RID: 180119
		public const int IsHideByClick = 128;

		// Token: 0x0402BF98 RID: 180120
		public const int IsSliderActive = 256;

		// Token: 0x0402BF99 RID: 180121
		public const int IsSeniorParamRefresh = 512;
	}
}
