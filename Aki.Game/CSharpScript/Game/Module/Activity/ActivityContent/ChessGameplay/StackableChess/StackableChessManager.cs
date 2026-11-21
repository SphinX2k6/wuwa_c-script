using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component;

namespace CSharpScript.Game.Module.Activity.ActivityContent.ChessGameplay.StackableChess
{
	// Token: 0x02005848 RID: 22600
	[NullableContext(1)]
	[Nullable(0)]
	public class StackableChessManager : IChessManager
	{
		// Token: 0x06037BAC RID: 228268 RVA: 0x00F945F3 File Offset: 0x00F927F3
		public ChessboardPoint CreateChessboardPoint()
		{
			return new StackableChessboardPoint();
		}

		// Token: 0x06037BAD RID: 228269 RVA: 0x00F945FA File Offset: 0x00F927FA
		public ChessItem CreateChessItem()
		{
			return new StackableChessItem();
		}

		// Token: 0x06037BAE RID: 228270 RVA: 0x00F94604 File Offset: 0x00F92804
		[NullableContext(2)]
		public IChessAgent GetChessAgent(EChessAgentType type, EntityHandle entityHandle = null)
		{
			if (type == EChessAgentType.EntityComponent)
			{
				WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
				if (worldEntity != null && worldEntity.Valid)
				{
					return worldEntity.GetComponent<StackableChessComponent>();
				}
			}
			return null;
		}

		// Token: 0x06037BAF RID: 228271 RVA: 0x00F94634 File Offset: 0x00F92834
		public void BatchTeleportItemsToPointSorted(List<IChessTransmitData> transmitDataList)
		{
			Dictionary<int, List<IChessTransmitData>> dictionary = new Dictionary<int, List<IChessTransmitData>>();
			foreach (IChessTransmitData chessTransmitData in transmitDataList)
			{
				if (!dictionary.ContainsKey(chessTransmitData.TargetPointId))
				{
					dictionary[chessTransmitData.TargetPointId] = new List<IChessTransmitData>();
				}
				dictionary[chessTransmitData.TargetPointId].Add(chessTransmitData);
			}
			foreach (KeyValuePair<int, List<IChessTransmitData>> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				List<IChessTransmitData> value = keyValuePair.Value;
				value.Sort((IChessTransmitData a, IChessTransmitData b) => a.High - b.High);
				StackableChessboardPoint stackableChessboardPoint = ChessModel.Instance.GetChessboardPoint(key) as StackableChessboardPoint;
				if (stackableChessboardPoint != null)
				{
					List<StackableChessItem> list = new List<StackableChessItem>();
					foreach (IChessTransmitData chessTransmitData2 in value)
					{
						StackableChessItem stackableChessItem = ChessModel.Instance.GetChessItem(chessTransmitData2.ItemId) as StackableChessItem;
						if (stackableChessItem != null)
						{
							ChessboardPoint currentPoint = stackableChessItem.GetCurrentPoint();
							if (currentPoint != null)
							{
								stackableChessItem.DetachSelfFromChain();
								currentPoint.ItemLeave(stackableChessItem);
							}
							list.Add(stackableChessItem);
						}
					}
					foreach (StackableChessItem chessItem in list)
					{
						stackableChessboardPoint.ItemEnter(chessItem);
					}
					StackableChessItem stackableChessItem2 = stackableChessboardPoint.GetHeadItem();
					Vector vector = stackableChessboardPoint.GetPointLocation();
					while (stackableChessItem2 != null)
					{
						Rotator pointRotator = stackableChessboardPoint.GetPointRotator(stackableChessItem2.RotationIsForward());
						stackableChessItem2.Teleport(vector, pointRotator);
						vector = (stackableChessItem2.GetStackableLocation() ?? vector);
						stackableChessItem2 = stackableChessItem2.GetNextItem();
					}
				}
			}
		}
	}
}
