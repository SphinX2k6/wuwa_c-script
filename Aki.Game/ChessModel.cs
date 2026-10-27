using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020011DA RID: 4570
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ChessModel : ModelBase
{
	// Token: 0x060079B7 RID: 31159 RVA: 0x0019A0E7 File Offset: 0x001982E7
	protected override bool OnLeaveLevel()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x060079B8 RID: 31160 RVA: 0x0019A0F0 File Offset: 0x001982F0
	protected override bool OnClear()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x060079B9 RID: 31161 RVA: 0x0019A0FC File Offset: 0x001982FC
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

	// Token: 0x060079BA RID: 31162 RVA: 0x0019A180 File Offset: 0x00198380
	[NullableContext(2)]
	public IChessManager GetChessManager()
	{
		return this.ChessManager;
	}

	// Token: 0x060079BB RID: 31163 RVA: 0x0019A188 File Offset: 0x00198388
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

	// Token: 0x060079BC RID: 31164 RVA: 0x0019A1A8 File Offset: 0x001983A8
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

	// Token: 0x060079BD RID: 31165 RVA: 0x0019A2A8 File Offset: 0x001984A8
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

	// Token: 0x060079BE RID: 31166 RVA: 0x0019A2C8 File Offset: 0x001984C8
	[NullableContext(2)]
	public ChessboardPoint GetTerminalPoint()
	{
		return this.TerminalPoint;
	}

	// Token: 0x060079BF RID: 31167 RVA: 0x0019A2D0 File Offset: 0x001984D0
	public void UpdateChessMode(EChessMode mode, EChessAgentType agentType = EChessAgentType.EntityComponent)
	{
		this.ChessAgentType = agentType;
		this.ChessManager = ChessManagerCreator.CreateChessManager(mode);
	}

	// Token: 0x060079C0 RID: 31168 RVA: 0x0019A2E8 File Offset: 0x001984E8
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

	// Token: 0x060079C1 RID: 31169 RVA: 0x0019A344 File Offset: 0x00198544
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

	// Token: 0x060079C2 RID: 31170 RVA: 0x0019A3D4 File Offset: 0x001985D4
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

	// Token: 0x17000A67 RID: 2663
	// (get) Token: 0x060079C3 RID: 31171 RVA: 0x0019A400 File Offset: 0x00198600
	public static ChessModel Instance
	{
		get
		{
			return ChessModel._Instance;
		}
	}

	// Token: 0x060079C4 RID: 31172 RVA: 0x0019A407 File Offset: 0x00198607
	public static ChessModel GetOrCreateInstance()
	{
		if (ChessModel._Instance == null)
		{
			ChessModel.CreateInstance();
		}
		return ChessModel._Instance;
	}

	// Token: 0x060079C5 RID: 31173 RVA: 0x0019A41B File Offset: 0x0019861B
	public static bool CreateInstance()
	{
		if (ChessModel._Instance != null)
		{
			return true;
		}
		ChessModel._Instance = new ChessModel();
		return true;
	}

	// Token: 0x060079C6 RID: 31174 RVA: 0x0019A431 File Offset: 0x00198631
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060079C7 RID: 31175 RVA: 0x0019A433 File Offset: 0x00198633
	public static void ResetStaticDefaultValue()
	{
		ChessModel._Instance = null;
	}

	// Token: 0x060079C8 RID: 31176 RVA: 0x0019A43B File Offset: 0x0019863B
	static ChessModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChessModel.CreateStaticDefaultValue), new Action(ChessModel.ResetStaticDefaultValue));
	}

	// Token: 0x040037F5 RID: 14325
	[Nullable(2)]
	private IChessManager ChessManager;

	// Token: 0x040037F6 RID: 14326
	private EChessAgentType ChessAgentType;

	// Token: 0x040037F7 RID: 14327
	private readonly Dictionary<int, ChessboardPoint> ChessboardPoints = new Dictionary<int, ChessboardPoint>();

	// Token: 0x040037F8 RID: 14328
	private readonly Dictionary<int, ChessItem> ChessItems = new Dictionary<int, ChessItem>();

	// Token: 0x040037F9 RID: 14329
	[Nullable(2)]
	private ChessboardPoint TerminalPoint;

	// Token: 0x040037FA RID: 14330
	[Nullable(2)]
	public int[] CacheRankingItemIdList;

	// Token: 0x040037FB RID: 14331
	[Nullable(2)]
	private static ChessModel _Instance;
}
