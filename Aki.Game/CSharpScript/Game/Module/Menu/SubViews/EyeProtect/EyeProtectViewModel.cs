using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.GameSettings;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x02004433 RID: 17459
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectViewModel
	{
		// Token: 0x0602C0FF RID: 180479 RVA: 0x00C5F30C File Offset: 0x00C5D50C
		public EyeProtectViewModel()
		{
			this.MenuMetaData = MenuModel.Instance.GetMenuDataByFunctionId(20210);
			MenuConfig metaConfig;
			if (GameSettingsManager.Instance.ValidApplyConfigMap.TryGetValue(EFunction.EyeProtectionMode, out metaConfig))
			{
				this.ModeMetaData = new MenuData(metaConfig);
				this.ModeCurValue = new int?(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true));
			}
		}

		// Token: 0x17005818 RID: 22552
		// (get) Token: 0x0602C100 RID: 180480 RVA: 0x00C5F396 File Offset: 0x00C5D596
		public bool IsDirty
		{
			get
			{
				if (this.ModeCurValue.GetValueOrDefault() != 2)
				{
					return this.IsModeDirty;
				}
				return this.IsModeDirty || this.IsSliderDirty;
			}
		}

		// Token: 0x0602C101 RID: 180481 RVA: 0x00C5F3C0 File Offset: 0x00C5D5C0
		[NullableContext(0)]
		public UniTask<bool> BuildComponentAndOpen()
		{
			EyeProtectViewModel.<BuildComponentAndOpen>d__13 <BuildComponentAndOpen>d__;
			<BuildComponentAndOpen>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<BuildComponentAndOpen>d__.<>4__this = this;
			<BuildComponentAndOpen>d__.<>1__state = -1;
			<BuildComponentAndOpen>d__.<>t__builder.Start<EyeProtectViewModel.<BuildComponentAndOpen>d__13>(ref <BuildComponentAndOpen>d__);
			return <BuildComponentAndOpen>d__.<>t__builder.Task;
		}

		// Token: 0x0602C102 RID: 180482 RVA: 0x00C5F404 File Offset: 0x00C5D604
		public void OnModeValueChange(int value)
		{
			this.ModeCurValue = new int?(value);
			GameSettingsUtils.ApplyEyeProtectionMode(value);
			if (value == 2)
			{
				List<EyeProtectSliderData> sliderDataList = this.GetSliderDataList(EModeValue.Custom);
				if (sliderDataList != null)
				{
					foreach (EyeProtectSliderData eyeProtectSliderData in sliderDataList)
					{
						eyeProtectSliderData.OnSetValue();
					}
				}
			}
			this.IsModeDirty = (GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.EyeProtectionMode, 0, true) != value);
		}

		// Token: 0x0602C103 RID: 180483 RVA: 0x00C5F490 File Offset: 0x00C5D690
		public void OnModeValueApply()
		{
			if (!this.IsModeDirty)
			{
				return;
			}
			if (this.ModeCurValue != null)
			{
				GameSettingsManager.Instance.HandleValueChange(EFunction.EyeProtectionMode, this.ModeCurValue.Value, EGameSettingsApplyReason.WhenUi);
			}
			this.IsModeDirty = false;
		}

		// Token: 0x0602C104 RID: 180484 RVA: 0x00C5F4CA File Offset: 0x00C5D6CA
		public string GetTitle()
		{
			return this.MenuMetaData.FunctionName;
		}

		// Token: 0x0602C105 RID: 180485 RVA: 0x00C5F4D7 File Offset: 0x00C5D6D7
		public MenuData GetModeMetaData()
		{
			return this.ModeMetaData;
		}

		// Token: 0x0602C106 RID: 180486 RVA: 0x00C5F4E0 File Offset: 0x00C5D6E0
		public List<EyeProtectItemData> GetModeDataList()
		{
			List<EyeProtectItemData> list = new List<EyeProtectItemData>();
			if (this.ModeMetaData == null)
			{
				return list;
			}
			IReadOnlyList<int> optionsValueList = this.ModeMetaData.OptionsValueList;
			IReadOnlyList<string> optionsNameList = this.ModeMetaData.OptionsNameList;
			for (int i = 0; i < optionsValueList.Count; i++)
			{
				list.Add(new EyeProtectItemData(optionsValueList[i], optionsNameList[i], this));
			}
			return list;
		}

		// Token: 0x0602C107 RID: 180487 RVA: 0x00C5F544 File Offset: 0x00C5D744
		public UniTask InitParam()
		{
			EyeProtectViewModel.<InitParam>d__20 <InitParam>d__;
			<InitParam>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitParam>d__.<>4__this = this;
			<InitParam>d__.<>1__state = -1;
			<InitParam>d__.<>t__builder.Start<EyeProtectViewModel.<InitParam>d__20>(ref <InitParam>d__);
			return <InitParam>d__.<>t__builder.Task;
		}

		// Token: 0x0602C108 RID: 180488 RVA: 0x00C5F588 File Offset: 0x00C5D788
		public void InitSliderDataList(EModeValue modeValue)
		{
			List<EyeProtectSliderData> list = new List<EyeProtectSliderData>();
			foreach (EFunction key in this.SliderDataFunctionList)
			{
				MenuConfig metaConfig;
				if (GameSettingsManager.Instance.ValidApplyConfigMap.TryGetValue(key, out metaConfig))
				{
					EyeProtectSliderData item = new EyeProtectSliderData(new MenuData(metaConfig), this, modeValue);
					list.Add(item);
				}
			}
			this.SliderDataListMap[modeValue] = list;
		}

		// Token: 0x0602C109 RID: 180489 RVA: 0x00C5F5F0 File Offset: 0x00C5D7F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<EyeProtectSliderData> GetSliderDataList(EModeValue modeValue)
		{
			List<EyeProtectSliderData> result;
			if (this.SliderDataListMap.TryGetValue(modeValue, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0602C10A RID: 180490 RVA: 0x00C5F610 File Offset: 0x00C5D810
		[NullableContext(2)]
		public void OnDragMoved(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnDragMoved(eventData);
		}

		// Token: 0x0602C10B RID: 180491 RVA: 0x00C5F627 File Offset: 0x00C5D827
		public void OnDragBegin()
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnDragBegin();
		}

		// Token: 0x0602C10C RID: 180492 RVA: 0x00C5F639 File Offset: 0x00C5D839
		public void OnDragEnded()
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnDragEnded();
		}

		// Token: 0x0602C10D RID: 180493 RVA: 0x00C5F64B File Offset: 0x00C5D84B
		public void OnInputUiLookUp(string axisName, float value)
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnInputUiLookUp(axisName, value);
		}

		// Token: 0x0602C10E RID: 180494 RVA: 0x00C5F65F File Offset: 0x00C5D85F
		public void OnInputUiTurn(string axisName, float value)
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnInputUiTurn(axisName, value);
		}

		// Token: 0x04017BC1 RID: 97217
		[Nullable(2)]
		protected MenuData MenuMetaData;

		// Token: 0x04017BC2 RID: 97218
		[Nullable(2)]
		protected MenuData ModeMetaData;

		// Token: 0x04017BC3 RID: 97219
		public int? ModeCurValue;

		// Token: 0x04017BC4 RID: 97220
		[Nullable(2)]
		public FilterCameraComponent FilterCameraComponent;

		// Token: 0x04017BC5 RID: 97221
		public bool IsModeDirty;

		// Token: 0x04017BC6 RID: 97222
		public bool IsSliderDirty;

		// Token: 0x04017BC7 RID: 97223
		protected readonly Dictionary<EModeValue, List<EyeProtectSliderData>> SliderDataListMap = new Dictionary<EModeValue, List<EyeProtectSliderData>>();

		// Token: 0x04017BC8 RID: 97224
		[Nullable(2)]
		public UKuroScreenBlueLightFilterParameter ParamStrong;

		// Token: 0x04017BC9 RID: 97225
		[Nullable(2)]
		public UKuroScreenBlueLightFilterParameter ParamWeak;

		// Token: 0x04017BCA RID: 97226
		private readonly EFunction[] SliderDataFunctionList = new EFunction[]
		{
			EFunction.EyeProtectionTemp,
			EFunction.EyeProtectionStrength,
			EFunction.EyeProtectionBrightness,
			EFunction.EyeProtectionTexture
		};

		// Token: 0x04017BCB RID: 97227
		[Nullable(2)]
		public Action OnSliderValueChange;
	}
}
