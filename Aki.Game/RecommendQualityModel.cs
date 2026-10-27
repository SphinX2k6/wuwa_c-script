using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;

// Token: 0x02002744 RID: 10052
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RecommendQualityModel : ModelBase
{
	// Token: 0x060149F1 RID: 84465 RVA: 0x00537990 File Offset: 0x00535B90
	protected override bool OnInit()
	{
		if (CloudGameManager.Instance.IsCloudGame)
		{
			this.IsFinishRecommendQuality = true;
			EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
			if (recommendQualityLv == null)
			{
				return false;
			}
			this.SaveApply(recommendQualityLv.Value);
			return true;
		}
		else
		{
			if (Info.Instance.IsHomeConsolePlatform() && !Info.Instance.IsWinGDKPlatform())
			{
				this.IsFinishRecommendQuality = true;
				return true;
			}
			this.IsFinishRecommendQuality = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.IsFinishRecommendQuality, false);
			if (!this.IsFinishRecommendQuality)
			{
				this.InitQualityRangeMap();
				this.InitQualityList();
			}
			return true;
		}
	}

	// Token: 0x060149F2 RID: 84466 RVA: 0x00537A19 File Offset: 0x00535C19
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x060149F3 RID: 84467 RVA: 0x00537A1C File Offset: 0x00535C1C
	public void InitQualityRangeMap()
	{
		this.QualityRangeMap = new Dictionary<EGameQualityRange, List<EGameQualitySettingLevel>>
		{
			{
				EGameQualityRange.Zero2Two,
				new List<EGameQualitySettingLevel>
				{
					EGameQualitySettingLevel.VeryLow,
					EGameQualitySettingLevel.Low,
					EGameQualitySettingLevel.Middle
				}
			},
			{
				EGameQualityRange.One2Three,
				new List<EGameQualitySettingLevel>
				{
					EGameQualitySettingLevel.Low,
					EGameQualitySettingLevel.Middle,
					EGameQualitySettingLevel.High
				}
			},
			{
				EGameQualityRange.Zero2One,
				new List<EGameQualitySettingLevel>
				{
					EGameQualitySettingLevel.Middle,
					EGameQualitySettingLevel.High
				}
			},
			{
				EGameQualityRange.One,
				new List<EGameQualitySettingLevel>
				{
					EGameQualitySettingLevel.High
				}
			},
			{
				EGameQualityRange.Two2Four,
				new List<EGameQualitySettingLevel>
				{
					EGameQualitySettingLevel.Middle,
					EGameQualitySettingLevel.High,
					EGameQualitySettingLevel.VeryHigh
				}
			},
			{
				EGameQualityRange.Three2Five,
				new List<EGameQualitySettingLevel>
				{
					EGameQualitySettingLevel.High,
					EGameQualitySettingLevel.VeryHigh,
					EGameQualitySettingLevel.Highest
				}
			}
		};
	}

	// Token: 0x060149F4 RID: 84468 RVA: 0x00537AE8 File Offset: 0x00535CE8
	public void InitQualityList()
	{
		EGameQualityRange qualityRange = GameSettingsDeviceRender.Instance.GetQualityRange();
		List<EGameQualitySettingLevel> list;
		if (this.QualityRangeMap == null || !this.QualityRangeMap.TryGetValue(qualityRange, out list))
		{
			return;
		}
		this.QualityList = new List<IRecommendQualityItemData>();
		MenuConfig? valueOrNull = GameSettingsManager.Instance.ValidApplyConfigMap.GetValueOrNull(EFunction.IMAGEQUALITY);
		string[] array = ((valueOrNull != null) ? valueOrNull.GetValueOrDefault().OptionsName() : null) ?? Array.Empty<string>();
		EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
		for (int i = 0; i < list.Count; i++)
		{
			EGameQualitySettingLevel egameQualitySettingLevel = list[i];
			string resourceId = "T_LoginSetQuality" + ((int)(egameQualitySettingLevel + 1)).ToString();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			int[] array2 = (valueOrNull != null) ? valueOrNull.GetValueOrDefault().OptionsValue() : null;
			int num = -1;
			if (array2 != null)
			{
				num = Array.IndexOf<int>(array2, (int)egameQualitySettingLevel);
			}
			RecommendQualityItemData recommendQualityItemData = new RecommendQualityItemData
			{
				Quality = egameQualitySettingLevel,
				Name = ((num >= 0 && num < array.Length) ? array[num] : ((array.Length != 0) ? array[0] : "")),
				IsRecommend = (recommendQualityLv != null && recommendQualityLv.Value == egameQualitySettingLevel),
				Bg = (resourcePath ?? "")
			};
			this.QualityList.Add(recommendQualityItemData);
			if (recommendQualityItemData.IsRecommend)
			{
				this.RecommendQualityIndex = i;
			}
		}
	}

	// Token: 0x060149F5 RID: 84469 RVA: 0x00537C65 File Offset: 0x00535E65
	public List<IRecommendQualityItemData> GetQualityList()
	{
		return this.QualityList ?? new List<IRecommendQualityItemData>();
	}

	// Token: 0x060149F6 RID: 84470 RVA: 0x00537C76 File Offset: 0x00535E76
	public int GetRecommendQualityIndex()
	{
		return this.RecommendQualityIndex;
	}

	// Token: 0x060149F7 RID: 84471 RVA: 0x00537C7E File Offset: 0x00535E7E
	public void SaveApply(EGameQualitySettingLevel quality)
	{
		this.IsNeedApply = true;
		this.NeedApplyQuality = quality;
	}

	// Token: 0x060149F8 RID: 84472 RVA: 0x00537C8E File Offset: 0x00535E8E
	public void FinishRecommendQualityShow()
	{
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsFinishRecommendQuality, true);
	}

	// Token: 0x060149F9 RID: 84473 RVA: 0x00537C99 File Offset: 0x00535E99
	public void CheckOpenRecommendQuality()
	{
		if (this.IsFinishRecommendQuality || GameSettingsManager.HasImageQualityOrSubSettingLoginOverride())
		{
			UiManager.Instance.CloseView(EUiViewName.CreateCharacterView, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RecommendQualityView, null, null);
	}

	// Token: 0x17001B07 RID: 6919
	// (get) Token: 0x060149FA RID: 84474 RVA: 0x00537CCC File Offset: 0x00535ECC
	public static RecommendQualityModel Instance
	{
		get
		{
			return RecommendQualityModel._Instance;
		}
	}

	// Token: 0x060149FB RID: 84475 RVA: 0x00537CD3 File Offset: 0x00535ED3
	public static RecommendQualityModel GetOrCreateInstance()
	{
		if (RecommendQualityModel._Instance == null)
		{
			RecommendQualityModel.CreateInstance();
		}
		return RecommendQualityModel._Instance;
	}

	// Token: 0x060149FC RID: 84476 RVA: 0x00537CE7 File Offset: 0x00535EE7
	public static bool CreateInstance()
	{
		if (RecommendQualityModel._Instance != null)
		{
			return true;
		}
		RecommendQualityModel._Instance = new RecommendQualityModel();
		return true;
	}

	// Token: 0x060149FD RID: 84477 RVA: 0x00537CFD File Offset: 0x00535EFD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060149FE RID: 84478 RVA: 0x00537CFF File Offset: 0x00535EFF
	public static void ResetStaticDefaultValue()
	{
		RecommendQualityModel._Instance = null;
	}

	// Token: 0x060149FF RID: 84479 RVA: 0x00537D07 File Offset: 0x00535F07
	static RecommendQualityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RecommendQualityModel.CreateStaticDefaultValue), new Action(RecommendQualityModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009AE9 RID: 39657
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<EGameQualityRange, List<EGameQualitySettingLevel>> QualityRangeMap;

	// Token: 0x04009AEA RID: 39658
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IRecommendQualityItemData> QualityList;

	// Token: 0x04009AEB RID: 39659
	private int RecommendQualityIndex;

	// Token: 0x04009AEC RID: 39660
	private bool IsFinishRecommendQuality;

	// Token: 0x04009AED RID: 39661
	public bool IsNeedApply;

	// Token: 0x04009AEE RID: 39662
	public EGameQualitySettingLevel NeedApplyQuality = EGameQualitySettingLevel.Middle;

	// Token: 0x04009AEF RID: 39663
	[Nullable(2)]
	private static RecommendQualityModel _Instance;
}
