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
	// Token: 0x02005450 RID: 21584
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectViewModel
	{
		// Token: 0x060371B6 RID: 225718 RVA: 0x00D0FEF4 File Offset: 0x00D0E0F4
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

		// Token: 0x1700844C RID: 33868
		// (get) Token: 0x060371B7 RID: 225719 RVA: 0x00D0FF7E File Offset: 0x00D0E17E
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

		// Token: 0x060371B8 RID: 225720 RVA: 0x00D0FFA8 File Offset: 0x00D0E1A8
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

		// Token: 0x060371B9 RID: 225721 RVA: 0x00D0FFEC File Offset: 0x00D0E1EC
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

		// Token: 0x060371BA RID: 225722 RVA: 0x00D10078 File Offset: 0x00D0E278
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

		// Token: 0x060371BB RID: 225723 RVA: 0x00D100B2 File Offset: 0x00D0E2B2
		public string GetTitle()
		{
			return this.MenuMetaData.FunctionName;
		}

		// Token: 0x060371BC RID: 225724 RVA: 0x00D100BF File Offset: 0x00D0E2BF
		public MenuData GetModeMetaData()
		{
			return this.ModeMetaData;
		}

		// Token: 0x060371BD RID: 225725 RVA: 0x00D100C8 File Offset: 0x00D0E2C8
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

		// Token: 0x060371BE RID: 225726 RVA: 0x00D1012C File Offset: 0x00D0E32C
		public UniTask InitParam()
		{
			EyeProtectViewModel.<InitParam>d__20 <InitParam>d__;
			<InitParam>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitParam>d__.<>4__this = this;
			<InitParam>d__.<>1__state = -1;
			<InitParam>d__.<>t__builder.Start<EyeProtectViewModel.<InitParam>d__20>(ref <InitParam>d__);
			return <InitParam>d__.<>t__builder.Task;
		}

		// Token: 0x060371BF RID: 225727 RVA: 0x00D10170 File Offset: 0x00D0E370
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

		// Token: 0x060371C0 RID: 225728 RVA: 0x00D101D8 File Offset: 0x00D0E3D8
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

		// Token: 0x060371C1 RID: 225729 RVA: 0x00D101F8 File Offset: 0x00D0E3F8
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

		// Token: 0x060371C2 RID: 225730 RVA: 0x00D1020F File Offset: 0x00D0E40F
		public void OnDragBegin()
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnDragBegin();
		}

		// Token: 0x060371C3 RID: 225731 RVA: 0x00D10221 File Offset: 0x00D0E421
		public void OnDragEnded()
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnDragEnded();
		}

		// Token: 0x060371C4 RID: 225732 RVA: 0x00D10233 File Offset: 0x00D0E433
		public void OnInputUiLookUp(string axisName, float value)
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnInputUiLookUp(axisName, value);
		}

		// Token: 0x060371C5 RID: 225733 RVA: 0x00D10247 File Offset: 0x00D0E447
		public void OnInputUiTurn(string axisName, float value)
		{
			FilterCameraComponent filterCameraComponent = this.FilterCameraComponent;
			if (filterCameraComponent == null)
			{
				return;
			}
			filterCameraComponent.OnInputUiTurn(axisName, value);
		}

		// Token: 0x0401D128 RID: 119080
		[Nullable(2)]
		protected MenuData MenuMetaData;

		// Token: 0x0401D129 RID: 119081
		[Nullable(2)]
		protected MenuData ModeMetaData;

		// Token: 0x0401D12A RID: 119082
		public int? ModeCurValue;

		// Token: 0x0401D12B RID: 119083
		[Nullable(2)]
		public FilterCameraComponent FilterCameraComponent;

		// Token: 0x0401D12C RID: 119084
		public bool IsModeDirty;

		// Token: 0x0401D12D RID: 119085
		public bool IsSliderDirty;

		// Token: 0x0401D12E RID: 119086
		protected readonly Dictionary<EModeValue, List<EyeProtectSliderData>> SliderDataListMap = new Dictionary<EModeValue, List<EyeProtectSliderData>>();

		// Token: 0x0401D12F RID: 119087
		[Nullable(2)]
		public UKuroScreenBlueLightFilterParameter ParamStrong;

		// Token: 0x0401D130 RID: 119088
		[Nullable(2)]
		public UKuroScreenBlueLightFilterParameter ParamWeak;

		// Token: 0x0401D131 RID: 119089
		private readonly EFunction[] SliderDataFunctionList = new EFunction[]
		{
			EFunction.EyeProtectionTemp,
			EFunction.EyeProtectionStrength,
			EFunction.EyeProtectionBrightness,
			EFunction.EyeProtectionTexture
		};

		// Token: 0x0401D132 RID: 119090
		[Nullable(2)]
		public Action OnSliderValueChange;
	}
}
