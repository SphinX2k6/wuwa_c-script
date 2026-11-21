using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x020016C6 RID: 5830
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MapExploreToolModel : ModelBase
{
	// Token: 0x0600E2B2 RID: 58034 RVA: 0x00428978 File Offset: 0x00426B78
	protected override bool OnInit()
	{
		this.MapSkillToPhantomSkill.Add(ERouletteSkillId.临时传送, ERouletteExploreId.临时传送);
		this.MapSkillToPhantomSkill.Add(ERouletteSkillId.声匣探测, ERouletteExploreId.声匣探测);
		this.MapSkillToPhantomSkill.Add(ERouletteSkillId.物资探测, ERouletteExploreId.物资探测);
		this.RespCodeToTipsId.Add(ERouletteExploreId.临时传送, new Dictionary<ErrorCode, EMapExploreToolCheckTipId>
		{
			{
				ErrorCode.ErrPlayerNotInBigWorld,
				EMapExploreToolCheckTipId.IllegalExploreToolUsingPos
			},
			{
				ErrorCode.ErrInFighting,
				EMapExploreToolCheckTipId.InFight
			},
			{
				ErrorCode.ErrNotHostPlayer,
				EMapExploreToolCheckTipId.NotHost
			},
			{
				ErrorCode.ErrConsumeNotEnough,
				EMapExploreToolCheckTipId.TempTeleporterCostNotEnough
			}
		});
		this.RespCodeToTipsId.Add(ERouletteExploreId.声匣探测, new Dictionary<ErrorCode, EMapExploreToolCheckTipId>
		{
			{
				ErrorCode.ErrPlayerNotInBigWorld,
				EMapExploreToolCheckTipId.IllegalExploreToolUsingPos
			},
			{
				ErrorCode.ErrInFighting,
				EMapExploreToolCheckTipId.InFight
			},
			{
				ErrorCode.ErrNotHostPlayer,
				EMapExploreToolCheckTipId.NotHost
			},
			{
				ErrorCode.ErrNotHaveCountryAccess,
				EMapExploreToolCheckTipId.NotHaveCountryAccess
			},
			{
				ErrorCode.ErrSkillIsEffect,
				EMapExploreToolCheckTipId.SoundBoxUseReachLimit
			},
			{
				ErrorCode.ErrNoSoundBox,
				EMapExploreToolCheckTipId.Exolore_ShengXiaNoDetect
			},
			{
				ErrorCode.SoundBoxExploreFull,
				EMapExploreToolCheckTipId.SoundBoxAllCollected
			},
			{
				ErrorCode.ErrConsumeNotEnough,
				EMapExploreToolCheckTipId.SoundBoxDetectorCostNotEnough
			}
		});
		this.RespCodeToTipsId.Add(ERouletteExploreId.物资探测, new Dictionary<ErrorCode, EMapExploreToolCheckTipId>
		{
			{
				ErrorCode.ErrPlayerNotInBigWorld,
				EMapExploreToolCheckTipId.IllegalExploreToolUsingPos
			},
			{
				ErrorCode.ErrInFighting,
				EMapExploreToolCheckTipId.InFight
			},
			{
				ErrorCode.ErrNotHostPlayer,
				EMapExploreToolCheckTipId.NotHost
			},
			{
				ErrorCode.ErrNotHaveCountryAccess,
				EMapExploreToolCheckTipId.NotHaveCountryAccess
			}
		});
		this.SkillToNotEnoughTipsId.Add(ERouletteExploreId.临时传送, EMapExploreToolCheckTipId.TempTeleporterCostNotEnough);
		this.SkillToNotEnoughTipsId.Add(ERouletteExploreId.声匣探测, EMapExploreToolCheckTipId.SoundBoxDetectorCostNotEnough);
		this.SkillToSuccessRespCode.Add(ERouletteExploreId.声匣探测, new HashSet<ErrorCode>
		{
			ErrorCode.Success,
			ErrorCode.ErrSkillIsEffect
		});
		this.SkillToSuccessRespCode.Add(ERouletteExploreId.物资探测, new HashSet<ErrorCode>
		{
			ErrorCode.Success,
			ErrorCode.ErrTreasureBoxAllActive
		});
		this.SkillToSuccessRespCode.Add(ERouletteExploreId.临时传送, new HashSet<ErrorCode>
		{
			ErrorCode.Success
		});
		this.SkillToCheckPassRespCode.Add(ERouletteExploreId.声匣探测, new HashSet<ErrorCode>
		{
			ErrorCode.ExploreToolNotConfirm
		});
		this.SkillToCheckPassRespCode.Add(ERouletteExploreId.物资探测, new HashSet<ErrorCode>
		{
			ErrorCode.ExploreToolNotConfirm,
			ErrorCode.ErrTreasureBoxAllActive
		});
		this.SkillToCheckPassRespCode.Add(ERouletteExploreId.临时传送, new HashSet<ErrorCode>
		{
			ErrorCode.ExploreToolNotConfirm
		});
		this.CharExploreSkillIsBusy = false;
		EventSystem.Instance.Add<DynamicMarkCreateInfo>(EEventName.CreateMapMark, new Action<DynamicMarkCreateInfo>(this.OnCreateMapMark));
		EventSystem.Instance.Add<EMarkType, int>(EEventName.RemoveMapMark, new Action<EMarkType, int>(this.OnRemoveMapMark));
		return true;
	}

	// Token: 0x0600E2B3 RID: 58035 RVA: 0x00428C08 File Offset: 0x00426E08
	protected override bool OnClear()
	{
		this.MapSkillToPhantomSkill.Clear();
		this.RespCodeToTipsId.Clear();
		this.SkillToNotEnoughTipsId.Clear();
		this.SkillToSuccessRespCode.Clear();
		this.SkillToExploreToolPlaceNum.Clear();
		this.CharExploreSkillIsBusy = false;
		EventSystem.Instance.Remove(EEventName.CreateMapMark, new Action<DynamicMarkCreateInfo>(this.OnCreateMapMark));
		EventSystem.Instance.Remove(EEventName.RemoveMapMark, new Action<EMarkType, int>(this.OnRemoveMapMark));
		return true;
	}

	// Token: 0x0600E2B4 RID: 58036 RVA: 0x00428C8C File Offset: 0x00426E8C
	protected override bool OnLeaveLevel()
	{
		this.CharExploreSkillIsBusy = false;
		return true;
	}

	// Token: 0x0600E2B5 RID: 58037 RVA: 0x00428C96 File Offset: 0x00426E96
	protected override bool OnChangeMode()
	{
		return true;
	}

	// Token: 0x0600E2B6 RID: 58038 RVA: 0x00428C9C File Offset: 0x00426E9C
	private void OnCreateMapMark(DynamicMarkCreateInfo info)
	{
		switch (info.MarkType)
		{
		case EMarkType.TemporaryTeleport:
		{
			int markCountByType = MapModel.Instance.GetMarkCountByType(info.MarkType);
			this.SetToolPlaceNum(ERouletteExploreId.临时传送, markCountByType, true);
			return;
		}
		case EMarkType.SoundBox:
		case EMarkType.CalmingWindBell:
		{
			int markCountByType2 = MapModel.Instance.GetMarkCountByType(EMarkType.SoundBox);
			int markCountByType3 = MapModel.Instance.GetMarkCountByType(EMarkType.CalmingWindBell);
			this.SetToolPlaceNum(ERouletteExploreId.声匣探测, markCountByType2 + markCountByType3, true);
			break;
		}
		case EMarkType.TreasureBoxDetector:
		{
			int markCountByType4 = MapModel.Instance.GetMarkCountByType(info.MarkType);
			this.SetToolPlaceNum(ERouletteExploreId.物资探测, markCountByType4, true);
			return;
		}
		case EMarkType.TreasureBox:
		case EMarkType.FixedSceneGameplay:
		case EMarkType.LandscapeMark:
			break;
		default:
			return;
		}
	}

	// Token: 0x0600E2B7 RID: 58039 RVA: 0x00428D40 File Offset: 0x00426F40
	private void OnRemoveMapMark(EMarkType markType, int markId)
	{
		switch (markType)
		{
		case EMarkType.TemporaryTeleport:
		{
			int markCountByType = MapModel.Instance.GetMarkCountByType(markType);
			this.SetToolPlaceNum(ERouletteExploreId.临时传送, markCountByType, false);
			return;
		}
		case EMarkType.SoundBox:
		case EMarkType.CalmingWindBell:
		{
			int markCountByType2 = MapModel.Instance.GetMarkCountByType(EMarkType.SoundBox);
			int markCountByType3 = MapModel.Instance.GetMarkCountByType(EMarkType.CalmingWindBell);
			this.SetToolPlaceNum(ERouletteExploreId.声匣探测, markCountByType2 + markCountByType3, false);
			break;
		}
		case EMarkType.TreasureBoxDetector:
		{
			int markCountByType4 = MapModel.Instance.GetMarkCountByType(markType);
			this.SetToolPlaceNum(ERouletteExploreId.物资探测, markCountByType4, false);
			return;
		}
		case EMarkType.TreasureBox:
		case EMarkType.FixedSceneGameplay:
		case EMarkType.LandscapeMark:
			break;
		default:
			return;
		}
	}

	// Token: 0x0600E2B8 RID: 58040 RVA: 0x00428DD0 File Offset: 0x00426FD0
	public ERouletteExploreId? GetPhantomSkillIdBySkillId(int skillId)
	{
		ERouletteExploreId value;
		if (this.MapSkillToPhantomSkill.TryGetValue((ERouletteSkillId)skillId, out value))
		{
			return new ERouletteExploreId?(value);
		}
		return null;
	}

	// Token: 0x0600E2B9 RID: 58041 RVA: 0x00428E00 File Offset: 0x00427000
	public EMapExploreToolCheckTipId? GetRespTipsId(MapExploreToolUsingInfo usingInfo, ExploreToolResponse response)
	{
		Dictionary<ErrorCode, EMapExploreToolCheckTipId> dictionary;
		EMapExploreToolCheckTipId value;
		if (this.RespCodeToTipsId.TryGetValue((ERouletteExploreId)usingInfo.PhantomSkillId, out dictionary) && response.Content.HasValue && dictionary.TryGetValue(response.GetErrorCode(), out value))
		{
			return new EMapExploreToolCheckTipId?(value);
		}
		return null;
	}

	// Token: 0x0600E2BA RID: 58042 RVA: 0x00428E54 File Offset: 0x00427054
	public EMapExploreToolCheckTipId? GetNotEnoughTipsId(MapExploreToolUsingInfo usingInfo)
	{
		EMapExploreToolCheckTipId value;
		if (this.SkillToNotEnoughTipsId.TryGetValue((ERouletteExploreId)usingInfo.PhantomSkillId, out value))
		{
			return new EMapExploreToolCheckTipId?(value);
		}
		return null;
	}

	// Token: 0x0600E2BB RID: 58043 RVA: 0x00428E88 File Offset: 0x00427088
	public EConfirmBoxConfigId? GetConfirmBoxId(MapExploreToolUsingInfo usingInfo, ExploreToolResponse response = null)
	{
		bool flag = response == null;
		switch (usingInfo.PhantomSkillId)
		{
		case 1010:
			if (flag)
			{
				return new EConfirmBoxConfigId?(this.IsToolReachPlaceLimit((ERouletteExploreId)usingInfo.PhantomSkillId) ? EConfirmBoxConfigId.UseTempTeleportPointerAtLimit : EConfirmBoxConfigId.UseTempTeleportPointer);
			}
			return null;
		case 1011:
			if (!flag)
			{
				if (this.IsRespMeanCheckPass(usingInfo, response))
				{
					return new EConfirmBoxConfigId?(EConfirmBoxConfigId.UseSoundBoxDetector);
				}
				return null;
			}
			else
			{
				if (!this.IsToolReachPlaceLimit((ERouletteExploreId)usingInfo.PhantomSkillId))
				{
					return new EConfirmBoxConfigId?(EConfirmBoxConfigId.UseSoundBoxDetector);
				}
				return null;
			}
			break;
		case 1012:
			if (!flag)
			{
				return null;
			}
			if (!this.IsToolReachPlaceLimit((ERouletteExploreId)usingInfo.PhantomSkillId))
			{
				return null;
			}
			return new EConfirmBoxConfigId?(EConfirmBoxConfigId.UseTreasureBoxDetectorAtLimit);
		default:
			return null;
		}
	}

	// Token: 0x0600E2BC RID: 58044 RVA: 0x00428F6C File Offset: 0x0042716C
	public bool ShowCostConfirmBox(MapExploreToolUsingInfo usingInfo, ExploreToolResponse response = null)
	{
		bool flag = response == null;
		switch (usingInfo.PhantomSkillId)
		{
		case 1010:
			if (flag)
			{
				return true;
			}
			break;
		case 1011:
			if (!flag && this.IsRespMeanCheckPass(usingInfo, response))
			{
				return true;
			}
			break;
		case 1012:
			if (flag)
			{
				return true;
			}
			break;
		}
		return false;
	}

	// Token: 0x0600E2BD RID: 58045 RVA: 0x00428FBC File Offset: 0x004271BC
	public bool IsRespMeanSuccess(MapExploreToolUsingInfo usingInfo, ExploreToolResponse response)
	{
		HashSet<ErrorCode> hashSet;
		return this.SkillToSuccessRespCode.TryGetValue((ERouletteExploreId)usingInfo.PhantomSkillId, out hashSet) && response.Content.HasValue && hashSet.Contains(response.GetErrorCode());
	}

	// Token: 0x0600E2BE RID: 58046 RVA: 0x00429000 File Offset: 0x00427200
	public bool IsRespMeanCheckPass(MapExploreToolUsingInfo usingInfo, ExploreToolResponse response)
	{
		HashSet<ErrorCode> hashSet;
		return this.SkillToCheckPassRespCode.TryGetValue((ERouletteExploreId)usingInfo.PhantomSkillId, out hashSet) && response.Content.HasValue && hashSet.Contains(response.GetErrorCode());
	}

	// Token: 0x0600E2BF RID: 58047 RVA: 0x00429044 File Offset: 0x00427244
	public unsafe void SetCharExploreSkillBusy(bool isBusy)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "[MapExploreTool] 设置CharExploreSkillBusy";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("OldVal", this.CharExploreSkillIsBusy);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewVal", isBusy);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.CharExploreSkillIsBusy = isBusy;
	}

	// Token: 0x0600E2C0 RID: 58048 RVA: 0x004290BA File Offset: 0x004272BA
	public bool GetCharExploreSkillBusy()
	{
		return this.CharExploreSkillIsBusy;
	}

	// Token: 0x0600E2C1 RID: 58049 RVA: 0x004290C4 File Offset: 0x004272C4
	public int? GetToolPlaceLimit(ERouletteExploreId phantomSkillId)
	{
		switch (phantomSkillId)
		{
		case ERouletteExploreId.临时传送:
			return new int?(RouletteConfig.Instance.GetTempTeleporterPlaceLimit());
		case ERouletteExploreId.声匣探测:
			return new int?(RouletteConfig.Instance.GetSoundBoxPlaceLimit());
		case ERouletteExploreId.物资探测:
			return new int?(RouletteConfig.Instance.GetTreasureBoxDetectorPlaceLimit());
		default:
			return null;
		}
	}

	// Token: 0x0600E2C2 RID: 58050 RVA: 0x00429124 File Offset: 0x00427324
	public bool IsToolHasPlaceLimit(ERouletteExploreId phantomSkillId)
	{
		return this.GetToolPlaceLimit(phantomSkillId) != null;
	}

	// Token: 0x0600E2C3 RID: 58051 RVA: 0x00429148 File Offset: 0x00427348
	public bool IsToolReachPlaceLimit(ERouletteExploreId phantomSkillId)
	{
		int? toolPlaceLimit = this.GetToolPlaceLimit(phantomSkillId);
		if (toolPlaceLimit == null)
		{
			return false;
		}
		int? toolPlaceNum = this.GetToolPlaceNum(phantomSkillId);
		return toolPlaceNum != null && toolPlaceNum.Value >= toolPlaceLimit.Value;
	}

	// Token: 0x0600E2C4 RID: 58052 RVA: 0x0042918C File Offset: 0x0042738C
	public int? GetToolPlaceNum(ERouletteExploreId phantomSkillId)
	{
		int value;
		if (this.SkillToExploreToolPlaceNum.TryGetValue(phantomSkillId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x0600E2C5 RID: 58053 RVA: 0x004291BC File Offset: 0x004273BC
	public unsafe void SetToolPlaceNum(ERouletteExploreId phantomSkillId, int placeNum, bool isAdd)
	{
		int? num = null;
		int value;
		if (this.SkillToExploreToolPlaceNum.TryGetValue(phantomSkillId, out value))
		{
			num = new int?(value);
		}
		if (num != null && placeNum == num.Value)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "[MapExploreTool] 设置ToolPlaceNum";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PhantomSkillId", phantomSkillId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlaceNum", placeNum);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (this.SkillToExploreToolPlaceNum.ContainsKey(phantomSkillId))
		{
			this.SkillToExploreToolPlaceNum[phantomSkillId] = placeNum;
		}
		else
		{
			this.SkillToExploreToolPlaceNum.Add(phantomSkillId, placeNum);
		}
		EventSystem.Instance.Emit<ERouletteExploreId, int>(EEventName.OnMapExploreToolPlaceNumUpdated, phantomSkillId, placeNum);
	}

	// Token: 0x17001598 RID: 5528
	// (get) Token: 0x0600E2C6 RID: 58054 RVA: 0x00429296 File Offset: 0x00427496
	public static MapExploreToolModel Instance
	{
		get
		{
			return MapExploreToolModel._Instance;
		}
	}

	// Token: 0x0600E2C7 RID: 58055 RVA: 0x0042929D File Offset: 0x0042749D
	public static MapExploreToolModel GetOrCreateInstance()
	{
		if (MapExploreToolModel._Instance == null)
		{
			MapExploreToolModel.CreateInstance();
		}
		return MapExploreToolModel._Instance;
	}

	// Token: 0x0600E2C8 RID: 58056 RVA: 0x004292B1 File Offset: 0x004274B1
	public static bool CreateInstance()
	{
		if (MapExploreToolModel._Instance != null)
		{
			return true;
		}
		MapExploreToolModel._Instance = new MapExploreToolModel();
		return true;
	}

	// Token: 0x0600E2C9 RID: 58057 RVA: 0x004292C7 File Offset: 0x004274C7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E2CA RID: 58058 RVA: 0x004292C9 File Offset: 0x004274C9
	public static void ResetStaticDefaultValue()
	{
		MapExploreToolModel._Instance = null;
	}

	// Token: 0x0600E2CB RID: 58059 RVA: 0x004292D1 File Offset: 0x004274D1
	static MapExploreToolModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MapExploreToolModel.CreateStaticDefaultValue), new Action(MapExploreToolModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400818E RID: 33166
	private readonly Dictionary<ERouletteSkillId, ERouletteExploreId> MapSkillToPhantomSkill = new Dictionary<ERouletteSkillId, ERouletteExploreId>();

	// Token: 0x0400818F RID: 33167
	private readonly Dictionary<ERouletteExploreId, Dictionary<ErrorCode, EMapExploreToolCheckTipId>> RespCodeToTipsId = new Dictionary<ERouletteExploreId, Dictionary<ErrorCode, EMapExploreToolCheckTipId>>();

	// Token: 0x04008190 RID: 33168
	private readonly Dictionary<ERouletteExploreId, EMapExploreToolCheckTipId> SkillToNotEnoughTipsId = new Dictionary<ERouletteExploreId, EMapExploreToolCheckTipId>();

	// Token: 0x04008191 RID: 33169
	private readonly Dictionary<ERouletteExploreId, HashSet<ErrorCode>> SkillToSuccessRespCode = new Dictionary<ERouletteExploreId, HashSet<ErrorCode>>();

	// Token: 0x04008192 RID: 33170
	private readonly Dictionary<ERouletteExploreId, HashSet<ErrorCode>> SkillToCheckPassRespCode = new Dictionary<ERouletteExploreId, HashSet<ErrorCode>>();

	// Token: 0x04008193 RID: 33171
	private bool CharExploreSkillIsBusy;

	// Token: 0x04008194 RID: 33172
	private readonly Dictionary<ERouletteExploreId, int> SkillToExploreToolPlaceNum = new Dictionary<ERouletteExploreId, int>();

	// Token: 0x04008195 RID: 33173
	[Nullable(2)]
	private static MapExploreToolModel _Instance;
}
