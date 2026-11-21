using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000688 RID: 1672
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ChessController : ControllerBase
{
	// Token: 0x06004D32 RID: 19762 RVA: 0x001A2A78 File Offset: 0x001A0C78
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

	// Token: 0x06004D33 RID: 19763 RVA: 0x001A2AD4 File Offset: 0x001A0CD4
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

	// Token: 0x06004D34 RID: 19764 RVA: 0x001A2B28 File Offset: 0x001A0D28
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

	// Token: 0x06004D35 RID: 19765 RVA: 0x001A2B74 File Offset: 0x001A0D74
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

	// Token: 0x06004D36 RID: 19766 RVA: 0x001A2BDC File Offset: 0x001A0DDC
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

	// Token: 0x06004D37 RID: 19767 RVA: 0x001A2C10 File Offset: 0x001A0E10
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

	// Token: 0x06004D38 RID: 19768 RVA: 0x001A2C57 File Offset: 0x001A0E57
	private static void AfterUpdateItem()
	{
		ChessModel.Instance.CacheRankingItemIdList = null;
	}

	// Token: 0x06004D39 RID: 19769 RVA: 0x001A2C64 File Offset: 0x001A0E64
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

	// Token: 0x17000A80 RID: 2688
	// (get) Token: 0x06004D3A RID: 19770 RVA: 0x001A2CFA File Offset: 0x001A0EFA
	public static ChessController Instance
	{
		get
		{
			return ChessController._Instance;
		}
	}

	// Token: 0x06004D3B RID: 19771 RVA: 0x001A2D01 File Offset: 0x001A0F01
	public static ChessController GetOrCreateInstance()
	{
		if (ChessController._Instance == null)
		{
			ChessController.CreateInstance();
		}
		return ChessController._Instance;
	}

	// Token: 0x06004D3C RID: 19772 RVA: 0x001A2D15 File Offset: 0x001A0F15
	public static bool CreateInstance()
	{
		if (ChessController._Instance != null)
		{
			return true;
		}
		ChessController._Instance = new ChessController();
		return true;
	}

	// Token: 0x06004D3D RID: 19773 RVA: 0x001A2D2B File Offset: 0x001A0F2B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004D3E RID: 19774 RVA: 0x001A2D2D File Offset: 0x001A0F2D
	public static void ResetStaticDefaultValue()
	{
		ChessController._Instance = null;
	}

	// Token: 0x06004D3F RID: 19775 RVA: 0x001A2D35 File Offset: 0x001A0F35
	static ChessController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChessController.CreateStaticDefaultValue), new Action(ChessController.ResetStaticDefaultValue));
	}

	// Token: 0x04003882 RID: 14466
	[Nullable(2)]
	private static ChessController _Instance;
}
