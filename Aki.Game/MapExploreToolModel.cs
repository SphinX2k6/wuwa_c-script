using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x020021E2 RID: 8674
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MapExploreToolModel : ModelBase
{
	// Token: 0x06010E21 RID: 69153 RVA: 0x0041C098 File Offset: 0x0041A298
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

	// Token: 0x06010E22 RID: 69154 RVA: 0x0041C328 File Offset: 0x0041A528
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

	// Token: 0x06010E23 RID: 69155 RVA: 0x0041C3AC File Offset: 0x0041A5AC
	protected override bool OnLeaveLevel()
	{
		this.CharExploreSkillIsBusy = false;
		return true;
	}

	// Token: 0x06010E24 RID: 69156 RVA: 0x0041C3B6 File Offset: 0x0041A5B6
	protected override bool OnChangeMode()
	{
		return true;
	}

	// Token: 0x06010E25 RID: 69157 RVA: 0x0041C3BC File Offset: 0x0041A5BC
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

	// Token: 0x06010E26 RID: 69158 RVA: 0x0041C460 File Offset: 0x0041A660
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

	// Token: 0x06010E27 RID: 69159 RVA: 0x0041C4F0 File Offset: 0x0041A6F0
	public ERouletteExploreId? GetPhantomSkillIdBySkillId(int skillId)
	{
		ERouletteExploreId value;
		if (this.MapSkillToPhantomSkill.TryGetValue((ERouletteSkillId)skillId, out value))
		{
			return new ERouletteExploreId?(value);
		}
		return null;
	}

	// Token: 0x06010E28 RID: 69160 RVA: 0x0041C520 File Offset: 0x0041A720
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

	// Token: 0x06010E29 RID: 69161 RVA: 0x0041C574 File Offset: 0x0041A774
	public EMapExploreToolCheckTipId? GetNotEnoughTipsId(MapExploreToolUsingInfo usingInfo)
	{
		EMapExploreToolCheckTipId value;
		if (this.SkillToNotEnoughTipsId.TryGetValue((ERouletteExploreId)usingInfo.PhantomSkillId, out value))
		{
			return new EMapExploreToolCheckTipId?(value);
		}
		return null;
	}

	// Token: 0x06010E2A RID: 69162 RVA: 0x0041C5A8 File Offset: 0x0041A7A8
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

	// Token: 0x06010E2B RID: 69163 RVA: 0x0041C68C File Offset: 0x0041A88C
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

	// Token: 0x06010E2C RID: 69164 RVA: 0x0041C6DC File Offset: 0x0041A8DC
	public bool IsRespMeanSuccess(MapExploreToolUsingInfo usingInfo, ExploreToolResponse response)
	{
		HashSet<ErrorCode> hashSet;
		return this.SkillToSuccessRespCode.TryGetValue((ERouletteExploreId)usingInfo.PhantomSkillId, out hashSet) && response.Content.HasValue && hashSet.Contains(response.GetErrorCode());
	}

	// Token: 0x06010E2D RID: 69165 RVA: 0x0041C720 File Offset: 0x0041A920
	public bool IsRespMeanCheckPass(MapExploreToolUsingInfo usingInfo, ExploreToolResponse response)
	{
		HashSet<ErrorCode> hashSet;
		return this.SkillToCheckPassRespCode.TryGetValue((ERouletteExploreId)usingInfo.PhantomSkillId, out hashSet) && response.Content.HasValue && hashSet.Contains(response.GetErrorCode());
	}

	// Token: 0x06010E2E RID: 69166 RVA: 0x0041C764 File Offset: 0x0041A964
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

	// Token: 0x06010E2F RID: 69167 RVA: 0x0041C7DA File Offset: 0x0041A9DA
	public bool GetCharExploreSkillBusy()
	{
		return this.CharExploreSkillIsBusy;
	}

	// Token: 0x06010E30 RID: 69168 RVA: 0x0041C7E4 File Offset: 0x0041A9E4
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

	// Token: 0x06010E31 RID: 69169 RVA: 0x0041C844 File Offset: 0x0041AA44
	public bool IsToolHasPlaceLimit(ERouletteExploreId phantomSkillId)
	{
		return this.GetToolPlaceLimit(phantomSkillId) != null;
	}

	// Token: 0x06010E32 RID: 69170 RVA: 0x0041C868 File Offset: 0x0041AA68
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

	// Token: 0x06010E33 RID: 69171 RVA: 0x0041C8AC File Offset: 0x0041AAAC
	public int? GetToolPlaceNum(ERouletteExploreId phantomSkillId)
	{
		int value;
		if (this.SkillToExploreToolPlaceNum.TryGetValue(phantomSkillId, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06010E34 RID: 69172 RVA: 0x0041C8DC File Offset: 0x0041AADC
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

	// Token: 0x17001561 RID: 5473
	// (get) Token: 0x06010E35 RID: 69173 RVA: 0x0041C9B6 File Offset: 0x0041ABB6
	public static MapExploreToolModel Instance
	{
		get
		{
			return MapExploreToolModel._Instance;
		}
	}

	// Token: 0x06010E36 RID: 69174 RVA: 0x0041C9BD File Offset: 0x0041ABBD
	public static MapExploreToolModel GetOrCreateInstance()
	{
		if (MapExploreToolModel._Instance == null)
		{
			MapExploreToolModel.CreateInstance();
		}
		return MapExploreToolModel._Instance;
	}

	// Token: 0x06010E37 RID: 69175 RVA: 0x0041C9D1 File Offset: 0x0041ABD1
	public static bool CreateInstance()
	{
		if (MapExploreToolModel._Instance != null)
		{
			return true;
		}
		MapExploreToolModel._Instance = new MapExploreToolModel();
		return true;
	}

	// Token: 0x06010E38 RID: 69176 RVA: 0x0041C9E7 File Offset: 0x0041ABE7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010E39 RID: 69177 RVA: 0x0041C9E9 File Offset: 0x0041ABE9
	public static void ResetStaticDefaultValue()
	{
		MapExploreToolModel._Instance = null;
	}

	// Token: 0x06010E3A RID: 69178 RVA: 0x0041C9F1 File Offset: 0x0041ABF1
	static MapExploreToolModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MapExploreToolModel.CreateStaticDefaultValue), new Action(MapExploreToolModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008047 RID: 32839
	private readonly Dictionary<ERouletteSkillId, ERouletteExploreId> MapSkillToPhantomSkill = new Dictionary<ERouletteSkillId, ERouletteExploreId>();

	// Token: 0x04008048 RID: 32840
	private readonly Dictionary<ERouletteExploreId, Dictionary<ErrorCode, EMapExploreToolCheckTipId>> RespCodeToTipsId = new Dictionary<ERouletteExploreId, Dictionary<ErrorCode, EMapExploreToolCheckTipId>>();

	// Token: 0x04008049 RID: 32841
	private readonly Dictionary<ERouletteExploreId, EMapExploreToolCheckTipId> SkillToNotEnoughTipsId = new Dictionary<ERouletteExploreId, EMapExploreToolCheckTipId>();

	// Token: 0x0400804A RID: 32842
	private readonly Dictionary<ERouletteExploreId, HashSet<ErrorCode>> SkillToSuccessRespCode = new Dictionary<ERouletteExploreId, HashSet<ErrorCode>>();

	// Token: 0x0400804B RID: 32843
	private readonly Dictionary<ERouletteExploreId, HashSet<ErrorCode>> SkillToCheckPassRespCode = new Dictionary<ERouletteExploreId, HashSet<ErrorCode>>();

	// Token: 0x0400804C RID: 32844
	private bool CharExploreSkillIsBusy;

	// Token: 0x0400804D RID: 32845
	private readonly Dictionary<ERouletteExploreId, int> SkillToExploreToolPlaceNum = new Dictionary<ERouletteExploreId, int>();

	// Token: 0x0400804E RID: 32846
	[Nullable(2)]
	private static MapExploreToolModel _Instance;
}
