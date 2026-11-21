using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;

// Token: 0x02001C2F RID: 7215
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RecommendQualityModel : ModelBase
{
	// Token: 0x06011ED3 RID: 73427 RVA: 0x0054669C File Offset: 0x0054489C
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
			return true;
		}
	}

	// Token: 0x06011ED4 RID: 73428 RVA: 0x00546711 File Offset: 0x00544911
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06011ED5 RID: 73429 RVA: 0x00546714 File Offset: 0x00544914
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

	// Token: 0x06011ED6 RID: 73430 RVA: 0x005467E0 File Offset: 0x005449E0
	public void InitQualityList()
	{
		if (this.QualityRangeMap == null)
		{
			this.InitQualityRangeMap();
		}
		this.QualityList = new List<IRecommendQualityItemData>();
		this.RecommendQualityIndex = 0;
		EGameQualityRange qualityRange = GameSettingsDeviceRender.Instance.GetQualityRange();
		List<EGameQualitySettingLevel> list;
		if (this.QualityRangeMap == null || !this.QualityRangeMap.TryGetValue(qualityRange, out list))
		{
			return;
		}
		MenuConfig? valueOrNull = GameSettingsManager.Instance.ValidApplyConfigMap.GetValueOrNull(EFunction.IMAGEQUALITY);
		string[] array = ((valueOrNull != null) ? valueOrNull.GetValueOrDefault().OptionsName() : null) ?? Array.Empty<string>();
		int[] array2 = ((valueOrNull != null) ? valueOrNull.GetValueOrDefault().OptionsValue() : null) ?? Array.Empty<int>();
		EGameQualitySettingLevel? resourceCap = GameSettingsManager.Instance.GetMaxQualityLevelByResourceTier();
		if (resourceCap != null && list.Exists((EGameQualitySettingLevel quality) => quality > resourceCap.Value))
		{
			List<EGameQualitySettingLevel> list2 = new List<EGameQualitySettingLevel>();
			foreach (EGameQualitySettingLevel egameQualitySettingLevel in array2)
			{
				if (egameQualitySettingLevel <= resourceCap.Value && GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(egameQualitySettingLevel) != null)
				{
					list2.Add(egameQualitySettingLevel);
				}
			}
			list2.Sort();
			if (list2.Count > list.Count)
			{
				list2.RemoveRange(0, list2.Count - list.Count);
			}
			list = list2;
		}
		EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
		for (int j = 0; j < list.Count; j++)
		{
			EGameQualitySettingLevel egameQualitySettingLevel2 = list[j];
			string resourceId = "T_LoginSetQuality" + ((int)(egameQualitySettingLevel2 + 1)).ToString();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			int num = Array.IndexOf<int>(array2, (int)egameQualitySettingLevel2);
			RecommendQualityItemData recommendQualityItemData = new RecommendQualityItemData
			{
				Quality = egameQualitySettingLevel2,
				Name = ((num >= 0 && num < array.Length) ? array[num] : ((array.Length != 0) ? array[0] : "")),
				IsRecommend = (recommendQualityLv != null && recommendQualityLv.Value == egameQualitySettingLevel2),
				Bg = (resourcePath ?? "")
			};
			this.QualityList.Add(recommendQualityItemData);
			if (recommendQualityItemData.IsRecommend)
			{
				this.RecommendQualityIndex = j;
			}
		}
	}

	// Token: 0x06011ED7 RID: 73431 RVA: 0x00546A39 File Offset: 0x00544C39
	public List<IRecommendQualityItemData> GetQualityList()
	{
		return this.QualityList ?? new List<IRecommendQualityItemData>();
	}

	// Token: 0x06011ED8 RID: 73432 RVA: 0x00546A4A File Offset: 0x00544C4A
	public int GetRecommendQualityIndex()
	{
		return this.RecommendQualityIndex;
	}

	// Token: 0x06011ED9 RID: 73433 RVA: 0x00546A52 File Offset: 0x00544C52
	public void SaveApply(EGameQualitySettingLevel quality)
	{
		this.IsNeedApply = true;
		this.NeedApplyQuality = quality;
	}

	// Token: 0x06011EDA RID: 73434 RVA: 0x00546A62 File Offset: 0x00544C62
	public void FinishRecommendQualityShow()
	{
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.IsFinishRecommendQuality, true);
	}

	// Token: 0x06011EDB RID: 73435 RVA: 0x00546A6D File Offset: 0x00544C6D
	public void CheckOpenRecommendQuality()
	{
		if (this.IsFinishRecommendQuality || GameSettingsManager.HasImageQualityOrSubSettingLoginOverride())
		{
			UiManager.Instance.CloseView(EUiViewName.CreateCharacterView, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RecommendQualityView, null, null);
	}

	// Token: 0x17001B3F RID: 6975
	// (get) Token: 0x06011EDC RID: 73436 RVA: 0x00546AA0 File Offset: 0x00544CA0
	public static RecommendQualityModel Instance
	{
		get
		{
			return RecommendQualityModel._Instance;
		}
	}

	// Token: 0x06011EDD RID: 73437 RVA: 0x00546AA7 File Offset: 0x00544CA7
	public static RecommendQualityModel GetOrCreateInstance()
	{
		if (RecommendQualityModel._Instance == null)
		{
			RecommendQualityModel.CreateInstance();
		}
		return RecommendQualityModel._Instance;
	}

	// Token: 0x06011EDE RID: 73438 RVA: 0x00546ABB File Offset: 0x00544CBB
	public static bool CreateInstance()
	{
		if (RecommendQualityModel._Instance != null)
		{
			return true;
		}
		RecommendQualityModel._Instance = new RecommendQualityModel();
		return true;
	}

	// Token: 0x06011EDF RID: 73439 RVA: 0x00546AD1 File Offset: 0x00544CD1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011EE0 RID: 73440 RVA: 0x00546AD3 File Offset: 0x00544CD3
	public static void ResetStaticDefaultValue()
	{
		RecommendQualityModel._Instance = null;
	}

	// Token: 0x06011EE1 RID: 73441 RVA: 0x00546ADB File Offset: 0x00544CDB
	static RecommendQualityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RecommendQualityModel.CreateStaticDefaultValue), new Action(RecommendQualityModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009C41 RID: 40001
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<EGameQualityRange, List<EGameQualitySettingLevel>> QualityRangeMap;

	// Token: 0x04009C42 RID: 40002
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IRecommendQualityItemData> QualityList;

	// Token: 0x04009C43 RID: 40003
	private int RecommendQualityIndex;

	// Token: 0x04009C44 RID: 40004
	private bool IsFinishRecommendQuality;

	// Token: 0x04009C45 RID: 40005
	public bool IsNeedApply;

	// Token: 0x04009C46 RID: 40006
	public EGameQualitySettingLevel NeedApplyQuality = EGameQualitySettingLevel.Middle;

	// Token: 0x04009C47 RID: 40007
	[Nullable(2)]
	private static RecommendQualityModel _Instance;
}
