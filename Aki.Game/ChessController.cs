using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020011D4 RID: 4564
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ChessController : ControllerBase
{
	// Token: 0x0600799B RID: 31131 RVA: 0x00199DC8 File Offset: 0x00197FC8
	public UniTask InitChessGameAsync(List<IChessboardPointParams> chessboardPoints, List<IChessItemParams> chessItems, int terminalPointId, EChessMode gameMode = EChessMode.Stackable)
	{
		ChessController.<InitChessGameAsync>d__0 <InitChessGameAsync>d__;
		<InitChessGameAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChessGameAsync>d__.chessboardPoints = chessboardPoints;
		<InitChessGameAsync>d__.chessItems = chessItems;
		<InitChessGameAsync>d__.terminalPointId = terminalPointId;
		<InitChessGameAsync>d__.gameMode = gameMode;
		<InitChessGameAsync>d__.<>1__state = -1;
		<InitChessGameAsync>d__.<>t__builder.Start<ChessController.<InitChessGameAsync>d__0>(ref <InitChessGameAsync>d__);
		return <InitChessGameAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600799C RID: 31132 RVA: 0x00199E24 File Offset: 0x00198024
	public UniTask MoveItemToPointAsync(int itemId, int targetPointId, bool isForward = true)
	{
		ChessController.<MoveItemToPointAsync>d__1 <MoveItemToPointAsync>d__;
		<MoveItemToPointAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveItemToPointAsync>d__.itemId = itemId;
		<MoveItemToPointAsync>d__.targetPointId = targetPointId;
		<MoveItemToPointAsync>d__.isForward = isForward;
		<MoveItemToPointAsync>d__.<>1__state = -1;
		<MoveItemToPointAsync>d__.<>t__builder.Start<ChessController.<MoveItemToPointAsync>d__1>(ref <MoveItemToPointAsync>d__);
		return <MoveItemToPointAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600799D RID: 31133 RVA: 0x00199E78 File Offset: 0x00198078
	public UniTask ChessItemPerformAsync(int itemId, int type)
	{
		ChessController.<ChessItemPerformAsync>d__2 <ChessItemPerformAsync>d__;
		<ChessItemPerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChessItemPerformAsync>d__.itemId = itemId;
		<ChessItemPerformAsync>d__.type = type;
		<ChessItemPerformAsync>d__.<>1__state = -1;
		<ChessItemPerformAsync>d__.<>t__builder.Start<ChessController.<ChessItemPerformAsync>d__2>(ref <ChessItemPerformAsync>d__);
		return <ChessItemPerformAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600799E RID: 31134 RVA: 0x00199EC4 File Offset: 0x001980C4
	public static void TeleportItemToPoint(int itemId, int targetPointId)
	{
		ChessItem chessItem = ChessModel.Instance.GetChessItem(itemId);
		ChessboardPoint chessboardPoint = ChessModel.Instance.GetChessboardPoint(targetPointId);
		if (chessItem != null && chessboardPoint != null)
		{
			ChessboardPoint currentPoint = chessItem.GetCurrentPoint();
			if (currentPoint != null)
			{
				currentPoint.ItemLeave(chessItem);
			}
			ValueTuple<Vector, Rotator> moveLocationAndRotator = chessboardPoint.GetMoveLocationAndRotator(chessItem.RotationIsForward());
			chessItem.Teleport(moveLocationAndRotator.Item1, moveLocationAndRotator.Item2);
			chessboardPoint.ItemEnter(chessItem);
			ChessController.AfterUpdateItem();
		}
	}

	// Token: 0x0600799F RID: 31135 RVA: 0x00199F2C File Offset: 0x0019812C
	public void ChangeItemToMaxPriorityInPoint(int itemId)
	{
		ChessItem chessItem = ChessModel.Instance.GetChessItem(itemId);
		if (chessItem != null)
		{
			ChessboardPoint currentPoint = chessItem.GetCurrentPoint();
			if (currentPoint != null)
			{
				currentPoint.ChangeItemToMaxPriority(chessItem);
			}
		}
		ChessController.AfterUpdateItem();
	}

	// Token: 0x060079A0 RID: 31136 RVA: 0x00199F60 File Offset: 0x00198160
	public void BatchTeleportItemsToPointSorted(List<IChessTransmitData> transmitDataList)
	{
		IChessManager chessManager = ChessModel.Instance.GetChessManager();
		if (chessManager == null)
		{
			Log.Instance.Error(ELogModule.Chess, ELogAuthor.LYY, "ChessManager 不支持 BatchTeleportItemsToPointSorted 操作", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		chessManager.BatchTeleportItemsToPointSorted(transmitDataList);
		ChessController.AfterUpdateItem();
	}

	// Token: 0x060079A1 RID: 31137 RVA: 0x00199FA7 File Offset: 0x001981A7
	private static void AfterUpdateItem()
	{
		ChessModel.Instance.CacheRankingItemIdList = null;
	}

	// Token: 0x060079A2 RID: 31138 RVA: 0x00199FB4 File Offset: 0x001981B4
	public static List<int> GetRankingItemIdList()
	{
		int[] cacheRankingItemIdList = ChessModel.Instance.CacheRankingItemIdList;
		if (cacheRankingItemIdList != null)
		{
			return new List<int>(cacheRankingItemIdList);
		}
		ChessboardPoint terminalPoint = ChessModel.Instance.GetTerminalPoint();
		if (terminalPoint == null)
		{
			Log.Instance.Error(ELogModule.Chess, ELogAuthor.LYY, "未设置终点，无法比较优先级", default(ReadOnlySpan<ValueTuple<string, object>>));
			return ChessModel.Instance.GetChessItemIdList(null);
		}
		int terminalSortIndex = terminalPoint.GetSortIndex();
		List<int> chessItemIdList = ChessModel.Instance.GetChessItemIdList(delegate(ChessItem a, ChessItem b)
		{
			int reachTerminalTimes = a.GetReachTerminalTimes();
			int reachTerminalTimes2 = b.GetReachTerminalTimes();
			if (reachTerminalTimes != reachTerminalTimes2)
			{
				return reachTerminalTimes2 - reachTerminalTimes;
			}
			ChessboardPoint currentPoint = a.GetCurrentPoint();
			ChessboardPoint currentPoint2 = b.GetCurrentPoint();
			if (currentPoint == null || currentPoint2 == null)
			{
				Log.Instance.Error(ELogModule.Chess, ELogAuthor.LYY, "棋子所在点位不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return 0;
			}
			if (currentPoint.GetId() == currentPoint2.GetId())
			{
				return currentPoint.ComparePriority(a, b);
			}
			int num = terminalSortIndex - currentPoint.GetSortIndex();
			int num2 = terminalSortIndex - currentPoint2.GetSortIndex();
			if (num == 0)
			{
				return 1;
			}
			if (num2 == 0)
			{
				return -1;
			}
			if (num * num2 <= 0)
			{
				return num2 - num;
			}
			return num - num2;
		});
		ChessModel.Instance.CacheRankingItemIdList = chessItemIdList.ToArray();
		return chessItemIdList;
	}

	// Token: 0x17000A60 RID: 2656
	// (get) Token: 0x060079A3 RID: 31139 RVA: 0x0019A04A File Offset: 0x0019824A
	public static ChessController Instance
	{
		get
		{
			return ChessController._Instance;
		}
	}

	// Token: 0x060079A4 RID: 31140 RVA: 0x0019A051 File Offset: 0x00198251
	public static ChessController GetOrCreateInstance()
	{
		if (ChessController._Instance == null)
		{
			ChessController.CreateInstance();
		}
		return ChessController._Instance;
	}

	// Token: 0x060079A5 RID: 31141 RVA: 0x0019A065 File Offset: 0x00198265
	public static bool CreateInstance()
	{
		if (ChessController._Instance != null)
		{
			return true;
		}
		ChessController._Instance = new ChessController();
		return true;
	}

	// Token: 0x060079A6 RID: 31142 RVA: 0x0019A07B File Offset: 0x0019827B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060079A7 RID: 31143 RVA: 0x0019A07D File Offset: 0x0019827D
	public static void ResetStaticDefaultValue()
	{
		ChessController._Instance = null;
	}

	// Token: 0x060079A8 RID: 31144 RVA: 0x0019A085 File Offset: 0x00198285
	static ChessController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChessController.CreateStaticDefaultValue), new Action(ChessController.ResetStaticDefaultValue));
	}

	// Token: 0x040037E9 RID: 14313
	[Nullable(2)]
	private static ChessController _Instance;
}
