using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Render;
using UnrealEngine;

// Token: 0x02002A51 RID: 10833
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class HierarchyLoadingController : ControllerBase
{
	// Token: 0x0601B72E RID: 112430 RVA: 0x008736F0 File Offset: 0x008718F0
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

	// Token: 0x0601B72F RID: 112431 RVA: 0x00873754 File Offset: 0x00871954
	private bool IsMengZhouMap()
	{
		if (GameModeModel.Instance.MapConfig.MapId == 8)
		{
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(new EAreaLevel?(EAreaLevel.FirstLevel));
			return Array.IndexOf<int>(this.MengZhouAreas, currentAreaId) >= 0;
		}
		return false;
	}

	// Token: 0x0601B730 RID: 112432 RVA: 0x0087379C File Offset: 0x0087199C
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

	// Token: 0x0601B731 RID: 112433 RVA: 0x00873828 File Offset: 0x00871A28
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
			if (Array.IndexOf<string>(hideDataLayerByImageQualityLevel, text) >= 0)
			{
				RenderModuleController.Instance.SetWorldPartitionDataLayerState(text, false, false);
			}
			else
			{
				RenderModuleController.Instance.SetWorldPartitionDataLayerState(text, true, false);
			}
		}
	}

	// Token: 0x0601B732 RID: 112434 RVA: 0x008738D7 File Offset: 0x00871AD7
	protected override bool OnInit()
	{
		this.AddEvents();
		return true;
	}

	// Token: 0x0601B733 RID: 112435 RVA: 0x008738E0 File Offset: 0x00871AE0
	protected override bool OnClear()
	{
		this.RemoveEvents();
		return true;
	}

	// Token: 0x0601B734 RID: 112436 RVA: 0x008738EC File Offset: 0x00871AEC
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.SetImageQualityWithValue, new Action<int>(this.OnSetImageQuality));
		EventSystem.Instance.Add(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
		EventSystem.Instance.Add(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
	}

	// Token: 0x0601B735 RID: 112437 RVA: 0x00873950 File Offset: 0x00871B50
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.SetImageQualityWithValue, new Action<int>(this.OnSetImageQuality));
		EventSystem.Instance.Remove(EEventName.EndTravelMap, new Action(this.OnEndTravelMap));
		EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeArea));
	}

	// Token: 0x0601B736 RID: 112438 RVA: 0x008739B1 File Offset: 0x00871BB1
	private void OnSetImageQuality(int settingLevel)
	{
		this.HookLoadDataLayers();
	}

	// Token: 0x0601B737 RID: 112439 RVA: 0x008739B9 File Offset: 0x00871BB9
	private void OnEndTravelMap()
	{
		this.HookLoadDataLayers();
	}

	// Token: 0x0601B738 RID: 112440 RVA: 0x008739C1 File Offset: 0x00871BC1
	private void OnChangeArea(int? preAreaId, int curAreaId)
	{
		this.HookLoadDataLayers();
	}

	// Token: 0x17002C7D RID: 11389
	// (get) Token: 0x0601B739 RID: 112441 RVA: 0x008739C9 File Offset: 0x00871BC9
	public static HierarchyLoadingController Instance
	{
		get
		{
			return HierarchyLoadingController._Instance;
		}
	}

	// Token: 0x0601B73A RID: 112442 RVA: 0x008739D0 File Offset: 0x00871BD0
	public static HierarchyLoadingController GetOrCreateInstance()
	{
		if (HierarchyLoadingController._Instance == null)
		{
			HierarchyLoadingController.CreateInstance();
		}
		return HierarchyLoadingController._Instance;
	}

	// Token: 0x0601B73B RID: 112443 RVA: 0x008739E4 File Offset: 0x00871BE4
	public static bool CreateInstance()
	{
		if (HierarchyLoadingController._Instance != null)
		{
			return true;
		}
		HierarchyLoadingController._Instance = new HierarchyLoadingController();
		return true;
	}

	// Token: 0x0601B73C RID: 112444 RVA: 0x008739FA File Offset: 0x00871BFA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B73D RID: 112445 RVA: 0x008739FC File Offset: 0x00871BFC
	public static void ResetStaticDefaultValue()
	{
		HierarchyLoadingController._Instance = null;
	}

	// Token: 0x0601B73E RID: 112446 RVA: 0x00873A04 File Offset: 0x00871C04
	static HierarchyLoadingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HierarchyLoadingController.CreateStaticDefaultValue), new Action(HierarchyLoadingController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ED3E RID: 60734
	private const int WXSG_MAPID = 912;

	// Token: 0x0400ED3F RID: 60735
	private const int MAIN_WORLD_MAPID = 8;

	// Token: 0x0400ED40 RID: 60736
	private readonly int[] MengZhouAreas = new int[]
	{
		44001,
		44002,
		44003,
		44004
	};

	// Token: 0x0400ED41 RID: 60737
	private readonly string[] AllDataLayers = new string[]
	{
		"DataLayerRuntime_HideInLow",
		"DataLayerRuntime_HideInMedium",
		"DataLayerRuntime_HideInHigh"
	};

	// Token: 0x0400ED42 RID: 60738
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

	// Token: 0x0400ED43 RID: 60739
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

	// Token: 0x0400ED44 RID: 60740
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

	// Token: 0x0400ED45 RID: 60741
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

	// Token: 0x0400ED46 RID: 60742
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

	// Token: 0x0400ED47 RID: 60743
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

	// Token: 0x0400ED48 RID: 60744
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

	// Token: 0x0400ED49 RID: 60745
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

	// Token: 0x0400ED4A RID: 60746
	[Nullable(2)]
	private static HierarchyLoadingController _Instance;
}
