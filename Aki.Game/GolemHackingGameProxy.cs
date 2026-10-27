using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

// Token: 0x02001002 RID: 4098
[NullableContext(1)]
[Nullable(0)]
public class GolemHackingGameProxy
{
	// Token: 0x060068FE RID: 26878 RVA: 0x0014DEDC File Offset: 0x0014C0DC
	public GolemHackingGameProxy(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x060068FF RID: 26879 RVA: 0x0014DF3C File Offset: 0x0014C13C
	public void Init()
	{
		DaemonHackConfigCsv value = GolemHackingConfig.Instance.GetPlayConfig(this.ConfigId).Value;
		this.MaxTime = (double)value.CountDown;
		this.MaxLength = value.CodeBufferSize;
		for (int i = 0; i < value.TargetCodesLength; i++)
		{
			List<string> item = new List<string>(value.TargetCodes(i).Split(' ', StringSplitOptions.None));
			this.TargetCode.Add(item);
		}
		this.TryTimeMax = value.FailThreshold;
		GolemHackingJsonConfig golemHackingJsonConfig = Json.Parse<GolemHackingJsonConfig>(value.CodeMatrix, null);
		if (golemHackingJsonConfig != null)
		{
			this.Size = golemHackingJsonConfig.MatrixSize;
			for (int j = 0; j < golemHackingJsonConfig.PresetCodes.Count; j++)
			{
				GolemHackingGridJsonConfig golemHackingGridJsonConfig = golemHackingJsonConfig.PresetCodes[j];
				GolemHackingGridInfo item2 = new GolemHackingGridInfo
				{
					Code = golemHackingGridJsonConfig.Code,
					Index = j,
					IsUsed = false,
					IsHovering = false
				};
				if (golemHackingGridJsonConfig.IsCorrect.GetValueOrDefault() && golemHackingGridJsonConfig.Order != null && golemHackingGridJsonConfig.Order.Value > 0)
				{
					if (golemHackingGridJsonConfig.Order.Value > this.OfficialAnswer.Count)
					{
						for (int k = this.OfficialAnswer.Count; k < golemHackingGridJsonConfig.Order.Value; k++)
						{
							this.OfficialAnswer.Add(0);
						}
					}
					this.OfficialAnswer[golemHackingGridJsonConfig.Order.Value - 1] = j;
				}
				this.InfoList.Add(item2);
			}
		}
	}

	// Token: 0x06006900 RID: 26880 RVA: 0x0014E0F4 File Offset: 0x0014C2F4
	public void Reset()
	{
		this.ResetCount++;
		this.IsRestart = true;
		this.CurGridGroup = 0;
		this.IsCurRow = true;
		foreach (GolemHackingGridInfo golemHackingGridInfo in this.InfoList)
		{
			golemHackingGridInfo.IsUsed = false;
		}
		this.CurAnswerIndexList.Clear();
		this.CurTime = 0.0;
		this.TryTimesAdd();
		Action resetMatrixCallback = this.ResetMatrixCallback;
		if (resetMatrixCallback != null)
		{
			resetMatrixCallback();
		}
		Action resetCodeCallback = this.ResetCodeCallback;
		if (resetCodeCallback != null)
		{
			resetCodeCallback();
		}
		this.CurTime = 0.0;
	}

	// Token: 0x06006901 RID: 26881 RVA: 0x0014E1BC File Offset: 0x0014C3BC
	protected void TryTimesAdd()
	{
		if (this.AddTryTime() >= this.TryTimeMax && !this.HasBroadcastTryTime)
		{
			this.HasBroadcastTryTime = true;
		}
	}

	// Token: 0x06006902 RID: 26882 RVA: 0x0014E1DB File Offset: 0x0014C3DB
	public int GetPadSize()
	{
		return this.Size;
	}

	// Token: 0x06006903 RID: 26883 RVA: 0x0014E1E3 File Offset: 0x0014C3E3
	public bool GetNeedTick()
	{
		return this.MaxTime > 0.0;
	}

	// Token: 0x06006904 RID: 26884 RVA: 0x0014E1F6 File Offset: 0x0014C3F6
	public double GetMaxTime()
	{
		return this.MaxTime;
	}

	// Token: 0x06006905 RID: 26885 RVA: 0x0014E1FE File Offset: 0x0014C3FE
	public int GetMaxLength()
	{
		return this.MaxLength;
	}

	// Token: 0x06006906 RID: 26886 RVA: 0x0014E206 File Offset: 0x0014C406
	public List<GolemHackingTipsGirdInfo> GetHelpTipsInfo()
	{
		if (this.HelpTipsInfo.Count == 0 && this.OnGetHelpTips != null)
		{
			this.HelpTipsInfo = this.OnGetHelpTips();
		}
		return this.HelpTipsInfo;
	}

	// Token: 0x06006907 RID: 26887 RVA: 0x0014E234 File Offset: 0x0014C434
	public List<List<GolemHackingGridInfo>> GetGridInfoMatrix()
	{
		List<List<GolemHackingGridInfo>> list = new List<List<GolemHackingGridInfo>>();
		for (int i = 0; i < this.Size; i++)
		{
			list.Add(new List<GolemHackingGridInfo>());
		}
		for (int j = 0; j < this.InfoList.Count; j++)
		{
			list[j % this.Size].Add(this.InfoList[j]);
		}
		return list;
	}

	// Token: 0x06006908 RID: 26888 RVA: 0x0014E29C File Offset: 0x0014C49C
	[NullableContext(0)]
	public ValueTuple<int, bool> OnClickedGrid(int grid)
	{
		this.IsCurRow = !this.IsCurRow;
		int num = 0;
		if (this.IsCurRow)
		{
			num = grid / this.Size;
		}
		else
		{
			num = grid % this.Size;
		}
		if (this.CurAnswerIndexList.Count == 0 && this.GetNeedTick())
		{
			Action startMatrixTickCallback = this.StartMatrixTickCallback;
			if (startMatrixTickCallback != null)
			{
				startMatrixTickCallback();
			}
		}
		this.CurAnswerIndexList.Add(grid);
		List<string> list = new List<string>();
		foreach (int index in this.CurAnswerIndexList)
		{
			GolemHackingGridInfo golemHackingGridInfo = this.InfoList[index];
			list.Add(golemHackingGridInfo.Code);
		}
		this.DoEnterLogic(list);
		this.CurGridGroup = num;
		return new ValueTuple<int, bool>(num, this.IsCurRow);
	}

	// Token: 0x06006909 RID: 26889 RVA: 0x0014E384 File Offset: 0x0014C584
	private void DoEnterLogic(List<string> codeList)
	{
		List<GolemHackingCodeEnterResult> list = this.RefreshCodePanelResult(codeList);
		int num = 0;
		int num2 = 0;
		foreach (GolemHackingCodeEnterResult golemHackingCodeEnterResult in list)
		{
			num += ((golemHackingCodeEnterResult.State == EGolemHackingBarState.Success) ? 1 : 0);
			num2 += ((golemHackingCodeEnterResult.State == EGolemHackingBarState.Fail) ? 1 : 0);
		}
		if (num == list.Count)
		{
			this.LogReport(EGolemHackingReportType.Success, true);
			this.OnOneTurnEndBeforeAnim(true);
		}
		else if (num2 > 0)
		{
			this.FailCount++;
			this.OnOneTurnEndBeforeAnim(false);
		}
		if (this.EnterCodeCallback != null)
		{
			List<string> list2 = new List<string>();
			foreach (int index in this.CurAnswerIndexList)
			{
				GolemHackingGridInfo golemHackingGridInfo = this.InfoList[index];
				list2.Add(golemHackingGridInfo.Code);
			}
			this.EnterCodeCallback(list2, list);
		}
		this.OnUnHoveredMatrixGrid();
	}

	// Token: 0x0600690A RID: 26890 RVA: 0x0014E4A4 File Offset: 0x0014C6A4
	protected void OnOneTurnEndBeforeAnim(bool isSuccess)
	{
		this.CacheResult = isSuccess;
		Action stopMatrixTickCallback = this.StopMatrixTickCallback;
		if (stopMatrixTickCallback == null)
		{
			return;
		}
		stopMatrixTickCallback();
	}

	// Token: 0x0600690B RID: 26891 RVA: 0x0014E4BD File Offset: 0x0014C6BD
	public void OnOneTurnEndAfterAnim()
	{
		this.OnOneTurnEnd(this.CacheResult);
	}

	// Token: 0x0600690C RID: 26892 RVA: 0x0014E4CC File Offset: 0x0014C6CC
	protected void OnOneTurnEnd(bool isSuccess)
	{
		Action action = delegate()
		{
			this.Reset();
		};
		GolemHackingResultInfo param = new GolemHackingResultInfo
		{
			IsSuccess = isSuccess,
			CloseCallback = (isSuccess ? this.OnGameplaySuccessCallback : action)
		};
		UiManager.Instance.OpenView(EUiViewName.GolemHackingResultPop, param, null);
	}

	// Token: 0x0600690D RID: 26893 RVA: 0x0014E516 File Offset: 0x0014C716
	public void InitCodePanelInfo()
	{
		this.DoEnterLogic(new List<string>());
	}

	// Token: 0x0600690E RID: 26894 RVA: 0x0014E523 File Offset: 0x0014C723
	public bool NeedHelpBtn()
	{
		return this.GetTryTime() >= this.TryTimeMax;
	}

	// Token: 0x0600690F RID: 26895 RVA: 0x0014E538 File Offset: 0x0014C738
	public int GetTryTime()
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.GolemCrack) as ServerStorageMap;
		int? num = (serverStorageMap != null) ? serverStorageMap.Get(this.ConfigId) : null;
		if (num == null)
		{
			serverStorageMap.Set(this.ConfigId, 0);
			return 0;
		}
		return num.Value;
	}

	// Token: 0x06006910 RID: 26896 RVA: 0x0014E594 File Offset: 0x0014C794
	public int AddTryTime()
	{
		ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.GolemCrack) as ServerStorageMap;
		int num = ((serverStorageMap != null) ? serverStorageMap.Get(this.ConfigId) : null).GetValueOrDefault() + 1;
		serverStorageMap.Set(this.ConfigId, num);
		return num;
	}

	// Token: 0x06006911 RID: 26897 RVA: 0x0014E5E8 File Offset: 0x0014C7E8
	private List<GolemHackingCodeEnterResult> RefreshCodePanelResult(List<string> inputList)
	{
		List<GolemHackingCodeEnterResult> list = new List<GolemHackingCodeEnterResult>();
		foreach (List<string> codeList in this.TargetCode)
		{
			list.Add(this.RefreshSingleCode(codeList, inputList));
		}
		return list;
	}

	// Token: 0x06006912 RID: 26898 RVA: 0x0014E64C File Offset: 0x0014C84C
	private GolemHackingCodeEnterResult RefreshSingleCode(List<string> codeList, List<string> inputList)
	{
		GolemHackingCodeEnterResult golemHackingCodeEnterResult = new GolemHackingCodeEnterResult
		{
			Code = new List<GolemHackingCodeGridInfo>(),
			State = EGolemHackingBarState.Default
		};
		int count = codeList.Count;
		int count2 = inputList.Count;
		int num = -1;
		for (int i = 0; i < count2; i++)
		{
			int count3 = Math.Min(count, count2 - i);
			List<string> range = inputList.GetRange(i, count3);
			List<string> range2 = codeList.GetRange(0, Math.Min(range.Count, count));
			bool flag = true;
			for (int j = 0; j < range.Count; j++)
			{
				if (range[j] != range2[j])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				num = i;
				break;
			}
		}
		int maxLength = this.GetMaxLength();
		num = ((num == -1) ? count2 : num);
		if (num + count <= count2)
		{
			golemHackingCodeEnterResult.State = EGolemHackingBarState.Success;
		}
		else
		{
			golemHackingCodeEnterResult.State = ((num + count <= maxLength) ? EGolemHackingBarState.Default : EGolemHackingBarState.Fail);
		}
		for (int k = 0; k < Math.Min(num, maxLength - count); k++)
		{
			GolemHackingCodeGridInfo item = new GolemHackingCodeGridInfo
			{
				Code = "",
				Correct = false,
				BarState = golemHackingCodeEnterResult.State,
				AnimIndex = 0
			};
			golemHackingCodeEnterResult.Code.Add(item);
		}
		foreach (string text in codeList)
		{
			string a = (golemHackingCodeEnterResult.Code.Count < count2) ? inputList[golemHackingCodeEnterResult.Code.Count] : null;
			GolemHackingCodeGridInfo item2 = new GolemHackingCodeGridInfo
			{
				Code = text,
				Correct = (a == text && golemHackingCodeEnterResult.State != EGolemHackingBarState.Fail),
				BarState = golemHackingCodeEnterResult.State,
				AnimIndex = 0
			};
			golemHackingCodeEnterResult.Code.Add(item2);
		}
		return golemHackingCodeEnterResult;
	}

	// Token: 0x06006913 RID: 26899 RVA: 0x0014E838 File Offset: 0x0014CA38
	[NullableContext(0)]
	public ValueTuple<int, bool> GetIndexPos(int index)
	{
		return new ValueTuple<int, bool>(this.IsCurRow ? (index % this.Size) : (index / this.Size), this.IsCurRow);
	}

	// Token: 0x06006914 RID: 26900 RVA: 0x0014E860 File Offset: 0x0014CA60
	public int GetIndexDistance(int index)
	{
		int num = index / this.Size;
		int num2 = index % this.Size;
		return num + num2;
	}

	// Token: 0x06006915 RID: 26901 RVA: 0x0014E880 File Offset: 0x0014CA80
	public void SetCanInteractive(bool value)
	{
		this.CanInteract = value;
	}

	// Token: 0x06006916 RID: 26902 RVA: 0x0014E88C File Offset: 0x0014CA8C
	public bool CheckCanInteractive()
	{
		bool flag = this.CanInteract && this.CurAnswerIndexList.Count < this.MaxLength;
		return (this.MaxTime <= 0.0 || this.CurTime < this.MaxTime) && flag;
	}

	// Token: 0x06006917 RID: 26903 RVA: 0x0014E8DC File Offset: 0x0014CADC
	public bool CheckMatrixBtnSelfInteractive(int index)
	{
		return (this.IsCurRow ? (index / this.Size) : (index % this.Size)) == this.CurGridGroup;
	}

	// Token: 0x06006918 RID: 26904 RVA: 0x0014E900 File Offset: 0x0014CB00
	public bool CheckCodeBtnSelfInteractive(int index)
	{
		return index == this.CurAnswerIndexList.Count;
	}

	// Token: 0x06006919 RID: 26905 RVA: 0x0014E910 File Offset: 0x0014CB10
	[NullableContext(0)]
	public ValueTuple<double, double> AddCurrentTime(double delta)
	{
		double num = delta * TimeUtil.Instance.Millisecond;
		this.CurTime = Math.Min(this.MaxTime, this.CurTime + num);
		double num2 = this.MaxTime - this.CurTime;
		if (num2 <= 0.0)
		{
			this.OnOneTurnEnd(false);
		}
		return new ValueTuple<double, double>(num2, this.MaxTime);
	}

	// Token: 0x0600691A RID: 26906 RVA: 0x0014E970 File Offset: 0x0014CB70
	public int GetRealHoverIndex(int indexFake, bool needCache)
	{
		int num = this.IsCurRow ? (indexFake / this.Size) : (indexFake % this.Size);
		int num2 = (this.CurGridGroup - num) * (this.IsCurRow ? this.Size : 1);
		return indexFake + num2;
	}

	// Token: 0x0600691B RID: 26907 RVA: 0x0014E9B8 File Offset: 0x0014CBB8
	public void OnHoveredMatrixGrid(int index)
	{
		if (this.HoverMatrixCallback == null)
		{
			return;
		}
		int realHoverIndex = this.GetRealHoverIndex(index, false);
		GolemHackingGridInfo golemHackingGridInfo = this.InfoList[realHoverIndex];
		int count = this.CurAnswerIndexList.Count;
		if (count >= this.GetMaxLength())
		{
			return;
		}
		this.HoverMatrixCallback(count, golemHackingGridInfo.IsUsed ? "" : golemHackingGridInfo.Code);
	}

	// Token: 0x0600691C RID: 26908 RVA: 0x0014EA1B File Offset: 0x0014CC1B
	public void OnUnHoveredMatrixGrid()
	{
		Action unHoverMatrixCallback = this.UnHoverMatrixCallback;
		if (unHoverMatrixCallback == null)
		{
			return;
		}
		unHoverMatrixCallback();
	}

	// Token: 0x0600691D RID: 26909 RVA: 0x0014EA2D File Offset: 0x0014CC2D
	public void OnHoveredCodeGrid(string value)
	{
		Action<string> hoverCodeCallback = this.HoverCodeCallback;
		if (hoverCodeCallback == null)
		{
			return;
		}
		hoverCodeCallback(value);
	}

	// Token: 0x0600691E RID: 26910 RVA: 0x0014EA40 File Offset: 0x0014CC40
	public void OnUnHoveredCodeGrid()
	{
		Action unHoverCodeCallback = this.UnHoverCodeCallback;
		if (unHoverCodeCallback == null)
		{
			return;
		}
		unHoverCodeCallback();
	}

	// Token: 0x0600691F RID: 26911 RVA: 0x0014EA54 File Offset: 0x0014CC54
	public void LogReport(EGolemHackingReportType reportType, bool isSuccess)
	{
		if (!GolemHackingController.Instance.IsActivityOpen)
		{
			return;
		}
		GolemHackingEndEvent golemHackingEndEvent = new GolemHackingEndEvent();
		golemHackingEndEvent.i_id = GolemHackingController.Instance.CacheLevelId;
		golemHackingEndEvent.i_result = (int)reportType;
		golemHackingEndEvent.s_trace_id = GolemHackingController.Instance.ActivityOpenTime.ToString();
		double num = TimeUtil.Instance.GetServerTime() - (double)GolemHackingController.Instance.ActivityOpenTime;
		golemHackingEndEvent.i_total_duration = (int)num;
		Dictionary<int, double> dictionary = LocalStorage.GetPlayer<Dictionary<int, double>>(ELocalStoragePlayerKey.GolemHackingActivityLevelTime, null) ?? new Dictionary<int, double>();
		if (isSuccess)
		{
			double num2;
			if (!dictionary.TryGetValue(golemHackingEndEvent.i_id, out num2) || num2 == 0.0 || num2 > num)
			{
				golemHackingEndEvent.i_pass_time = (int)num;
				dictionary[golemHackingEndEvent.i_id] = num;
				LocalStorage.SetPlayer<Dictionary<int, double>>(ELocalStoragePlayerKey.GolemHackingActivityLevelTime, dictionary);
			}
			else
			{
				golemHackingEndEvent.i_pass_time = (int)num2;
			}
		}
		else
		{
			double num3;
			golemHackingEndEvent.i_pass_time = (dictionary.TryGetValue(golemHackingEndEvent.i_id, out num3) ? ((int)num3) : 0);
		}
		bool flag = GolemHackingController.Instance.GetActivityData().GetLevelInfo(golemHackingEndEvent.i_id).State == GolemCrackState.GolemCrackFinished;
		golemHackingEndEvent.i_first_pass = ((!flag) ? 1 : 0);
		golemHackingEndEvent.i_recount = this.ResetCount;
		golemHackingEndEvent.i_false_count = this.FailCount;
		golemHackingEndEvent.i_count = this.CurAnswerIndexList.Count;
		golemHackingEndEvent.o_path = this.CurAnswerIndexList;
		LogReportController.Instance.LogReport(golemHackingEndEvent);
	}

	// Token: 0x0400303E RID: 12350
	protected int Size = 3;

	// Token: 0x0400303F RID: 12351
	protected int MaxLength;

	// Token: 0x04003040 RID: 12352
	protected int CurGridGroup;

	// Token: 0x04003041 RID: 12353
	protected bool IsCurRow = true;

	// Token: 0x04003042 RID: 12354
	protected List<GolemHackingGridInfo> InfoList = new List<GolemHackingGridInfo>();

	// Token: 0x04003043 RID: 12355
	protected List<List<string>> TargetCode = new List<List<string>>();

	// Token: 0x04003044 RID: 12356
	protected int TryTimeMax;

	// Token: 0x04003045 RID: 12357
	protected double CurTime;

	// Token: 0x04003046 RID: 12358
	protected double MaxTime;

	// Token: 0x04003047 RID: 12359
	protected bool CanInteract;

	// Token: 0x04003048 RID: 12360
	protected List<int> CurAnswerIndexList = new List<int>();

	// Token: 0x04003049 RID: 12361
	public List<int> OfficialAnswer = new List<int>();

	// Token: 0x0400304A RID: 12362
	public List<GolemHackingTipsGirdInfo> HelpTipsInfo = new List<GolemHackingTipsGirdInfo>();

	// Token: 0x0400304B RID: 12363
	protected int ConfigId;

	// Token: 0x0400304C RID: 12364
	protected bool HasBroadcastTryTime;

	// Token: 0x0400304D RID: 12365
	public bool IsRestart;

	// Token: 0x0400304E RID: 12366
	public int ResetCount;

	// Token: 0x0400304F RID: 12367
	public int FailCount;

	// Token: 0x04003050 RID: 12368
	protected bool CacheResult;

	// Token: 0x04003051 RID: 12369
	public bool IsCodePressing;

	// Token: 0x04003052 RID: 12370
	public bool IsMatrixPressing;

	// Token: 0x04003053 RID: 12371
	public double MatrixPressingTime;

	// Token: 0x04003054 RID: 12372
	[Nullable(2)]
	public Action ResetMatrixCallback;

	// Token: 0x04003055 RID: 12373
	[Nullable(2)]
	public Action StartMatrixTickCallback;

	// Token: 0x04003056 RID: 12374
	[Nullable(2)]
	public Action StopMatrixTickCallback;

	// Token: 0x04003057 RID: 12375
	[Nullable(2)]
	public Action ResetCodeCallback;

	// Token: 0x04003058 RID: 12376
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, string> HoverMatrixCallback;

	// Token: 0x04003059 RID: 12377
	[Nullable(2)]
	public Action UnHoverMatrixCallback;

	// Token: 0x0400305A RID: 12378
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1,
		1
	})]
	public Action<List<string>, List<GolemHackingCodeEnterResult>> EnterCodeCallback;

	// Token: 0x0400305B RID: 12379
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<string> HoverCodeCallback;

	// Token: 0x0400305C RID: 12380
	[Nullable(2)]
	public Action UnHoverCodeCallback;

	// Token: 0x0400305D RID: 12381
	[Nullable(2)]
	public Action OnGameplaySuccessCallback;

	// Token: 0x0400305E RID: 12382
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Func<List<GolemHackingTipsGirdInfo>> OnGetHelpTips;
}
