using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200068E RID: 1678
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ChessModel : ModelBase
{
	// Token: 0x06004D4E RID: 19790 RVA: 0x001A2D97 File Offset: 0x001A0F97
	protected override bool OnLeaveLevel()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x06004D4F RID: 19791 RVA: 0x001A2DA0 File Offset: 0x001A0FA0
	protected override bool OnClear()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x06004D50 RID: 19792 RVA: 0x001A2DAC File Offset: 0x001A0FAC
	public void ClearAll()
	{
		this.ChessManager = null;
		this.ChessboardPoints.Clear();
		foreach (KeyValuePair<int, ChessItem> keyValuePair in this.ChessItems)
		{
			keyValuePair.Value.OnClear();
		}
		this.ChessItems.Clear();
		this.TerminalPoint = null;
		this.CacheRankingItemIdList = null;
	}

	// Token: 0x06004D51 RID: 19793 RVA: 0x001A2E30 File Offset: 0x001A1030
	[NullableContext(2)]
	public IChessManager GetChessManager()
	{
		return this.ChessManager;
	}

	// Token: 0x06004D52 RID: 19794 RVA: 0x001A2E38 File Offset: 0x001A1038
	[NullableContext(2)]
	public ChessItem GetChessItem(int id)
	{
		ChessItem result;
		if (this.ChessItems.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06004D53 RID: 19795 RVA: 0x001A2E58 File Offset: 0x001A1058
	public List<int> GetChessItemIdList([Nullable(new byte[]
	{
		2,
		1
	})] Comparison<ChessItem> compare = null)
	{
		List<int> list = new List<int>();
		if (compare == null)
		{
			foreach (KeyValuePair<int, ChessItem> keyValuePair in this.ChessItems)
			{
				list.Add(keyValuePair.Key);
			}
			return list;
		}
		List<ChessItem> list2 = new List<ChessItem>();
		foreach (KeyValuePair<int, ChessItem> keyValuePair2 in this.ChessItems)
		{
			list2.Add(keyValuePair2.Value);
		}
		list2.Sort(compare);
		foreach (ChessItem chessItem in list2)
		{
			list.Add(chessItem.GetId());
		}
		return list;
	}

	// Token: 0x06004D54 RID: 19796 RVA: 0x001A2F58 File Offset: 0x001A1158
	[NullableContext(2)]
	public ChessboardPoint GetChessboardPoint(int id)
	{
		ChessboardPoint result;
		if (this.ChessboardPoints.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06004D55 RID: 19797 RVA: 0x001A2F78 File Offset: 0x001A1178
	[NullableContext(2)]
	public ChessboardPoint GetTerminalPoint()
	{
		return this.TerminalPoint;
	}

	// Token: 0x06004D56 RID: 19798 RVA: 0x001A2F80 File Offset: 0x001A1180
	public void UpdateChessMode(EChessMode mode, EChessAgentType agentType = EChessAgentType.EntityComponent)
	{
		this.ChessAgentType = agentType;
		this.ChessManager = ChessManagerCreator.CreateChessManager(mode);
	}

	// Token: 0x06004D57 RID: 19799 RVA: 0x001A2F98 File Offset: 0x001A1198
	public void AddChessboardPoint(int id, Vector location, Rotator rotator, [Nullable(2)] Rotator backwardRotation, int sortIndex)
	{
		if (this.ChessManager == null)
		{
			Log.Instance.Error(ELogModule.Chess, ELogAuthor.LYY, "请先设置正确的棋局模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		ChessboardPoint chessboardPoint = this.ChessManager.CreateChessboardPoint();
		chessboardPoint.Init(id, location, rotator, backwardRotation, sortIndex);
		this.ChessboardPoints.Add(id, chessboardPoint);
	}

	// Token: 0x06004D58 RID: 19800 RVA: 0x001A2FF4 File Offset: 0x001A11F4
	public void AddChessItem(int id, EntityHandle entityHandle, bool rotationIsForward)
	{
		if (this.ChessManager == null)
		{
			Log.Instance.Error(ELogModule.Chess, ELogAuthor.LYY, "请设置正确的棋局模式", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		IChessAgent chessAgent = this.ChessManager.GetChessAgent(this.ChessAgentType, entityHandle);
		if (chessAgent == null)
		{
			Log.Instance.Error(ELogModule.Chess, ELogAuthor.LYY, "创建棋子代理失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		ChessItem chessItem = this.ChessManager.CreateChessItem();
		chessItem.Init(id, chessAgent, rotationIsForward);
		this.ChessItems.Add(id, chessItem);
	}

	// Token: 0x06004D59 RID: 19801 RVA: 0x001A3084 File Offset: 0x001A1284
	public void UpdateTerminalPoint(int pointId)
	{
		ChessboardPoint terminalPoint;
		if (this.ChessboardPoints.TryGetValue(pointId, out terminalPoint))
		{
			this.TerminalPoint = terminalPoint;
			return;
		}
		this.TerminalPoint = null;
	}

	// Token: 0x17000A87 RID: 2695
	// (get) Token: 0x06004D5A RID: 19802 RVA: 0x001A30B0 File Offset: 0x001A12B0
	public static ChessModel Instance
	{
		get
		{
			return ChessModel._Instance;
		}
	}

	// Token: 0x06004D5B RID: 19803 RVA: 0x001A30B7 File Offset: 0x001A12B7
	public static ChessModel GetOrCreateInstance()
	{
		if (ChessModel._Instance == null)
		{
			ChessModel.CreateInstance();
		}
		return ChessModel._Instance;
	}

	// Token: 0x06004D5C RID: 19804 RVA: 0x001A30CB File Offset: 0x001A12CB
	public static bool CreateInstance()
	{
		if (ChessModel._Instance != null)
		{
			return true;
		}
		ChessModel._Instance = new ChessModel();
		return true;
	}

	// Token: 0x06004D5D RID: 19805 RVA: 0x001A30E1 File Offset: 0x001A12E1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004D5E RID: 19806 RVA: 0x001A30E3 File Offset: 0x001A12E3
	public static void ResetStaticDefaultValue()
	{
		ChessModel._Instance = null;
	}

	// Token: 0x06004D5F RID: 19807 RVA: 0x001A30EB File Offset: 0x001A12EB
	static ChessModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChessModel.CreateStaticDefaultValue), new Action(ChessModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400388E RID: 14478
	[Nullable(2)]
	private IChessManager ChessManager;

	// Token: 0x0400388F RID: 14479
	private EChessAgentType ChessAgentType;

	// Token: 0x04003890 RID: 14480
	private readonly Dictionary<int, ChessboardPoint> ChessboardPoints = new Dictionary<int, ChessboardPoint>();

	// Token: 0x04003891 RID: 14481
	private readonly Dictionary<int, ChessItem> ChessItems = new Dictionary<int, ChessItem>();

	// Token: 0x04003892 RID: 14482
	[Nullable(2)]
	private ChessboardPoint TerminalPoint;

	// Token: 0x04003893 RID: 14483
	[Nullable(2)]
	public int[] CacheRankingItemIdList;

	// Token: 0x04003894 RID: 14484
	[Nullable(2)]
	private static ChessModel _Instance;
}
