using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Render;
using UnrealEngine;

// Token: 0x020034DD RID: 13533
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class HierarchyLoadingController : ControllerBase
{
	// Token: 0x0601DA24 RID: 121380 RVA: 0x0084B4EC File Offset: 0x008496EC
	private bool IsSpecialMapOrArea()
	{
		int mapId = GameModeModel.Instance.MapConfig.MapId;
		bool flag = Info.Instance.IsMobilePlatform();
		Dictionary<int, HashSet<int>> dictionary = HierarchyLoadingController.SpecialMapAreas;
		if (flag)
		{
			dictionary = HierarchyLoadingController.SpecialMapAreasMobile;
		}
		HashSet<int> hashSet;
		if (!dictionary.TryGetValue(mapId, out hashSet))
		{
			return false;
		}
		if (hashSet == null)
		{
			return true;
		}
		int currentAreaId = AreaModel.Instance.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.FirstLevel));
		return hashSet.Contains(currentAreaId);
	}

	// Token: 0x0601DA25 RID: 121381 RVA: 0x0084B550 File Offset: 0x00849750
	private bool IsMengZhouMap()
	{
		if (GameModeModel.Instance.MapConfig.MapId == 8)
		{
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.FirstLevel));
			return this.MengZhouAreas.Contains(currentAreaId);
		}
		return false;
	}

	// Token: 0x0601DA26 RID: 121382 RVA: 0x0084B594 File Offset: 0x00849794
	private string[] GetHideDataLayerByImageQualityLevel(int level)
	{
		bool flag = Info.Instance.IsPcOrGamepadPlatform();
		bool flag2 = this.IsSpecialMapOrArea();
		Dictionary<int, EQualityHierarchyLevel> dictionary = flag ? this.QualityLevelPCMap : this.QualityLevelMobileMap;
		if (flag2)
		{
			if (Info.Instance.IsMobilePlatform() && this.IsMengZhouMap())
			{
				dictionary = this.QualityLevelMobileMapMengZhou;
			}
			else
			{
				dictionary = (flag ? this.QualityLevelPCMapDown : this.QualityLevelMobileMapDown);
			}
		}
		if (!dictionary.ContainsKey(level))
		{
			return Array.Empty<string>();
		}
		EQualityHierarchyLevel key = dictionary[level];
		return this.DataLayerHideLevelMap.GetValueOrDefault(key, Array.Empty<string>());
	}

	// Token: 0x0601DA27 RID: 121383 RVA: 0x0084B620 File Offset: 0x00849820
	private void HookLoadDataLayers()
	{
		Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.RY, "触发datalayer切换", default(ReadOnlySpan<ValueTuple<string, object>>));
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (gameUserSettings == null)
		{
			Log.Instance.Info(ELogModule.GameSettings, ELogAuthor.RY, "GetGameUserSettings失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int gameQualitySettingLevel = gameUserSettings.GetGameQualitySettingLevel();
		string[] hideDataLayerByImageQualityLevel = this.GetHideDataLayerByImageQualityLevel(gameQualitySettingLevel);
		foreach (string text in this.AllDataLayers)
		{
			if (hideDataLayerByImageQualityLevel.Contains(text))
			{
				RenderModuleController.Instance.SetWorldPartitionDataLayerState(text, false, false);
			}
			else
			{
				RenderModuleController.Instance.SetWorldPartitionDataLayerState(text, true, false);
			}
		}
	}

	// Token: 0x0601DA28 RID: 121384 RVA: 0x0084B6CE File Offset: 0x008498CE
	protected override bool OnInit()
	{
		this.AddEvents();
		return true;
	}

	// Token: 0x0601DA29 RID: 121385 RVA: 0x0084B6D7 File Offset: 0x008498D7
	protected override bool OnClear()
	{
		this.RemoveEvents();
		return true;
	}

	// Token: 0x0601DA2A RID: 121386 RVA: 0x0084B6E0 File Offset: 0x008498E0
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.SetImageQualityWithValue, new Action<int>(this.OnSetImageQuality));
		EventSystem.Instance.Add(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
		EventSystem.Instance.Add(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
	}

	// Token: 0x0601DA2B RID: 121387 RVA: 0x0084B744 File Offset: 0x00849944
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.SetImageQualityWithValue, new Action<int>(this.OnSetImageQuality));
		EventSystem.Instance.Remove(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
		EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
	}

	// Token: 0x0601DA2C RID: 121388 RVA: 0x0084B7A5 File Offset: 0x008499A5
	private void OnSetImageQuality(int settingLevel)
	{
		this.HookLoadDataLayers();
	}

	// Token: 0x0601DA2D RID: 121389 RVA: 0x0084B7AD File Offset: 0x008499AD
	private void OnEndTravelMap()
	{
		this.HookLoadDataLayers();
	}

	// Token: 0x0601DA2E RID: 121390 RVA: 0x0084B7B5 File Offset: 0x008499B5
	private void OnChangeArea(int? preAreaId, int curAreaId)
	{
		this.HookLoadDataLayers();
	}

	// Token: 0x170028E5 RID: 10469
	// (get) Token: 0x0601DA2F RID: 121391 RVA: 0x0084B7BD File Offset: 0x008499BD
	public static HierarchyLoadingController Instance
	{
		get
		{
			return HierarchyLoadingController._Instance;
		}
	}

	// Token: 0x0601DA30 RID: 121392 RVA: 0x0084B7C4 File Offset: 0x008499C4
	public static HierarchyLoadingController GetOrCreateInstance()
	{
		if (HierarchyLoadingController._Instance == null)
		{
			HierarchyLoadingController.CreateInstance();
		}
		return HierarchyLoadingController._Instance;
	}

	// Token: 0x0601DA31 RID: 121393 RVA: 0x0084B7D8 File Offset: 0x008499D8
	public static bool CreateInstance()
	{
		if (HierarchyLoadingController._Instance != null)
		{
			return true;
		}
		HierarchyLoadingController._Instance = new HierarchyLoadingController();
		return true;
	}

	// Token: 0x0601DA32 RID: 121394 RVA: 0x0084B7EE File Offset: 0x008499EE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DA33 RID: 121395 RVA: 0x0084B7F0 File Offset: 0x008499F0
	public static void ResetStaticDefaultValue()
	{
		HierarchyLoadingController._Instance = null;
	}

	// Token: 0x0601DA34 RID: 121396 RVA: 0x0084B7F8 File Offset: 0x008499F8
	static HierarchyLoadingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HierarchyLoadingController.CreateStaticDefaultValue), new Action(HierarchyLoadingController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E887 RID: 59527
	private const int WXSG_MAPID = 912;

	// Token: 0x0400E888 RID: 59528
	private const int MAIN_WORLD_MAPID = 8;

	// Token: 0x0400E889 RID: 59529
	private readonly int[] MengZhouAreas = new int[]
	{
		44001,
		44002,
		44003,
		44004
	};

	// Token: 0x0400E88A RID: 59530
	private readonly string[] AllDataLayers = new string[]
	{
		"DataLayerRuntime_HideInLow",
		"DataLayerRuntime_HideInMedium",
		"DataLayerRuntime_HideInHigh"
	};

	// Token: 0x0400E88B RID: 59531
	private readonly Dictionary<EQualityHierarchyLevel, string[]> DataLayerHideLevelMap = new Dictionary<EQualityHierarchyLevel, string[]>
	{
		{
			EQualityHierarchyLevel.Low,
			new string[]
			{
				"DataLayerRuntime_HideInLow",
				"DataLayerRuntime_HideInMedium",
				"DataLayerRuntime_HideInHigh"
			}
		},
		{
			EQualityHierarchyLevel.Medium,
			new string[]
			{
				"DataLayerRuntime_HideInMedium",
				"DataLayerRuntime_HideInHigh"
			}
		},
		{
			EQualityHierarchyLevel.High,
			new string[]
			{
				"DataLayerRuntime_HideInHigh"
			}
		}
	};

	// Token: 0x0400E88C RID: 59532
	private readonly Dictionary<int, EQualityHierarchyLevel> QualityLevelPCMap = new Dictionary<int, EQualityHierarchyLevel>
	{
		{
			0,
			EQualityHierarchyLevel.Low
		},
		{
			1,
			EQualityHierarchyLevel.Low
		},
		{
			2,
			EQualityHierarchyLevel.Medium
		},
		{
			3,
			EQualityHierarchyLevel.High
		},
		{
			4,
			EQualityHierarchyLevel.Highest
		},
		{
			5,
			EQualityHierarchyLevel.Highest
		}
	};

	// Token: 0x0400E88D RID: 59533
	private readonly Dictionary<int, EQualityHierarchyLevel> QualityLevelMobileMap = new Dictionary<int, EQualityHierarchyLevel>
	{
		{
			0,
			EQualityHierarchyLevel.Low
		},
		{
			1,
			EQualityHierarchyLevel.Low
		},
		{
			2,
			EQualityHierarchyLevel.Medium
		},
		{
			3,
			EQualityHierarchyLevel.High
		},
		{
			4,
			EQualityHierarchyLevel.Highest
		}
	};

	// Token: 0x0400E88E RID: 59534
	private readonly Dictionary<int, EQualityHierarchyLevel> QualityLevelPCMapDown = new Dictionary<int, EQualityHierarchyLevel>
	{
		{
			0,
			EQualityHierarchyLevel.Low
		},
		{
			1,
			EQualityHierarchyLevel.Low
		},
		{
			2,
			EQualityHierarchyLevel.Low
		},
		{
			3,
			EQualityHierarchyLevel.Medium
		},
		{
			4,
			EQualityHierarchyLevel.High
		},
		{
			5,
			EQualityHierarchyLevel.Highest
		}
	};

	// Token: 0x0400E88F RID: 59535
	private readonly Dictionary<int, EQualityHierarchyLevel> QualityLevelMobileMapDown = new Dictionary<int, EQualityHierarchyLevel>
	{
		{
			0,
			EQualityHierarchyLevel.Low
		},
		{
			1,
			EQualityHierarchyLevel.Low
		},
		{
			2,
			EQualityHierarchyLevel.Low
		},
		{
			3,
			EQualityHierarchyLevel.Medium
		},
		{
			4,
			EQualityHierarchyLevel.High
		}
	};

	// Token: 0x0400E890 RID: 59536
	private readonly Dictionary<int, EQualityHierarchyLevel> QualityLevelMobileMapMengZhou = new Dictionary<int, EQualityHierarchyLevel>
	{
		{
			0,
			EQualityHierarchyLevel.Low
		},
		{
			1,
			EQualityHierarchyLevel.Low
		},
		{
			2,
			EQualityHierarchyLevel.Low
		},
		{
			3,
			EQualityHierarchyLevel.High
		},
		{
			4,
			EQualityHierarchyLevel.Highest
		}
	};

	// Token: 0x0400E891 RID: 59537
	[Nullable(new byte[]
	{
		1,
		2
	})]
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<int, HashSet<int>> SpecialMapAreas = new Dictionary<int, HashSet<int>>
	{
		{
			912,
			null
		}
	};

	// Token: 0x0400E892 RID: 59538
	[Nullable(new byte[]
	{
		1,
		2
	})]
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<int, HashSet<int>> SpecialMapAreasMobile = new Dictionary<int, HashSet<int>>
	{
		{
			912,
			null
		},
		{
			8,
			new HashSet<int>
			{
				44001,
				44002,
				44003,
				44004
			}
		}
	};

	// Token: 0x0400E893 RID: 59539
	[Nullable(2)]
	private static HierarchyLoadingController _Instance;
}
