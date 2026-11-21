using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200265F RID: 9823
[NullableContext(1)]
[Nullable(0)]
public class PatrolMovePointsLogic
{
	// Token: 0x06018988 RID: 100744 RVA: 0x00774F9A File Offset: 0x0077319A
	public void Init(CharacterActorComponent actorComp)
	{
		this.ActorComp = actorComp;
	}

	// Token: 0x06018989 RID: 100745 RVA: 0x00774FA3 File Offset: 0x007731A3
	public void Reset()
	{
		this.TargetIndex = 0;
		this.PreviousIndex = -1;
	}

	// Token: 0x0601898A RID: 100746 RVA: 0x00774FB3 File Offset: 0x007731B3
	public bool CheckMoveLastPoint()
	{
		return !this.IsLoop && this.TargetIndex == this.MovePoint.Count - 1;
	}

	// Token: 0x0601898B RID: 100747 RVA: 0x00774FD4 File Offset: 0x007731D4
	[NullableContext(2)]
	public global::Vector GetPreviousLocation()
	{
		if (this.PreviousIndex < 0)
		{
			return null;
		}
		return this.MovePoint[this.PreviousIndex].Position;
	}

	// Token: 0x0601898C RID: 100748 RVA: 0x00774FF8 File Offset: 0x007731F8
	public unsafe void UpdateMovePoints(MoveCharacterConfig config)
	{
		IList<MoveCharacterPoint> list;
		if (config.Points.IsT2)
		{
			list = config.Points.AsT2;
		}
		else
		{
			list = new MoveCharacterPoint[]
			{
				config.Points.AsT1
			};
		}
		bool flag = true;
		if (!this.IsPathEqual(this.MovePoint, list))
		{
			this.PreviousIndex = -1;
			if (config.Loop && !config.CircleMove.GetValueOrDefault() && config.StartWithInversePath != null)
			{
				this.InversePath = config.StartWithInversePath.Value;
			}
		}
		else
		{
			flag = false;
		}
		this.MovePoint = list;
		this.IsLoop = config.Loop;
		this.IsCircle = config.CircleMove.GetValueOrDefault();
		if (config.StartIndex != null)
		{
			int? startIndex = config.StartIndex;
			int num = 0;
			if (startIndex.GetValueOrDefault() >= num & startIndex != null)
			{
				startIndex = config.StartIndex;
				num = this.MovePoint.Count;
				if (startIndex.GetValueOrDefault() < num & startIndex != null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.AI;
					ELogAuthor author = ELogAuthor.YJX;
					string message = "使用起始点移动";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("实体ID", this.ActorComp.CreatureData.GetPbDataId());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("初始点Index", config.StartIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetIndex", this.TargetIndex);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					this.UpdateMoveTarget(config.StartIndex.Value);
					return;
				}
			}
		}
		if (config.UsePreviousIndex.GetValueOrDefault() && this.PreviousIndex >= 0 && this.PreviousIndex < this.MovePoint.Count)
		{
			this.UpdateMoveTarget(this.PreviousIndex);
			if (this.GetNextPoint() < this.MovePoint.Count)
			{
				this.UpdateMoveTarget(this.GetNextPoint());
				return;
			}
		}
		else
		{
			if (config.UseNearestPoint.GetValueOrDefault() && flag)
			{
				this.UpdateNearestPoint();
				return;
			}
			this.UpdateMoveTarget(0);
		}
	}

	// Token: 0x0601898D RID: 100749 RVA: 0x00775224 File Offset: 0x00773424
	public bool ChangeToNextPoint()
	{
		return this.UpdateMoveIndex(this.GetNextPoint());
	}

	// Token: 0x0601898E RID: 100750 RVA: 0x00775234 File Offset: 0x00773434
	public int GetNextPoint()
	{
		int result;
		if (this.IsLoop)
		{
			if (this.IsCircle)
			{
				result = (this.TargetIndex + 1) % this.MovePoint.Count;
			}
			else if (this.InversePath)
			{
				if (this.TargetIndex == 0)
				{
					this.InversePath = false;
					result = 0;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.AI;
					ELogAuthor author = ELogAuthor.YJX;
					string message = "往返式巡逻：回到起点";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataID", this.ActorComp.CreatureData.GetPbDataId());
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					EntityPatrolChangeDirRequest message2 = new EntityPatrolChangeDirRequest
					{
						EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId()),
						Dir = true
					};
					Net.Instance.Call(ERequestMessageId.EntityPatrolChangeDirRequest, message2, delegate(IMessage response, Net.CallbackStatus _)
					{
					}, 0);
				}
				else
				{
					result = this.TargetIndex - 1;
				}
			}
			else if (this.TargetIndex == this.MovePoint.Count - 1)
			{
				this.InversePath = true;
				result = this.MovePoint.Count - 2;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.AI;
				ELogAuthor author2 = ELogAuthor.YJX;
				string message3 = "往返式巡逻：走到终点";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataID", this.ActorComp.CreatureData.GetPbDataId());
				instance2.Info(module2, author2, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				EntityPatrolChangeDirRequest message4 = new EntityPatrolChangeDirRequest
				{
					EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId()),
					Dir = false
				};
				Net.Instance.Call(ERequestMessageId.EntityPatrolChangeDirRequest, message4, delegate(IMessage response, Net.CallbackStatus _)
				{
				}, 0);
			}
			else
			{
				result = this.TargetIndex + 1;
			}
		}
		else
		{
			result = this.TargetIndex + 1;
		}
		return result;
	}

	// Token: 0x0601898F RID: 100751 RVA: 0x00775418 File Offset: 0x00773618
	[NullableContext(2)]
	public void OnArriveMovePoint(MoveCharacterPoint point = null)
	{
		MoveCharacterPoint moveCharacterPoint = point ?? this.TargetPoint;
		if (moveCharacterPoint != null && moveCharacterPoint.Index == -1)
		{
			return;
		}
		if (((moveCharacterPoint != null) ? moveCharacterPoint.Actions : null) != null && moveCharacterPoint.Actions.Count > 0)
		{
			LevelGeneralController.Instance.ExecuteActionsNew(moveCharacterPoint.Actions, EntityContext.Create(this.ActorComp.Entity.Id, null), null);
		}
		if (moveCharacterPoint != null)
		{
			Action callback = moveCharacterPoint.Callback;
			if (callback != null)
			{
				callback();
			}
		}
		if (moveCharacterPoint != null && moveCharacterPoint.IsHide.GetValueOrDefault())
		{
			this.SetMoveHide(moveCharacterPoint);
		}
	}

	// Token: 0x06018990 RID: 100752 RVA: 0x007754B4 File Offset: 0x007736B4
	private void SetMoveHide(MoveCharacterPoint curPoint)
	{
		USkeletalMeshComponent skeletalMesh = this.ActorComp.SkeletalMesh;
		if (skeletalMesh != null)
		{
			bool? isHide = curPoint.IsHide;
			bool flag = false;
			skeletalMesh.SetVisibility(isHide.GetValueOrDefault() == flag & isHide != null, false);
		}
		BaseTagComponent component = this.ActorComp.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		int num = GameplayTagDefine.EGameplayTagId["怪物.common.状态标识.巡逻中隐身"];
		if (curPoint.IsHide.GetValueOrDefault())
		{
			if (!component.HasTag(num))
			{
				component.AddTag(new int?(num));
				return;
			}
		}
		else if (component.HasTag(num))
		{
			component.RemoveTag(new int?(num));
		}
	}

	// Token: 0x06018991 RID: 100753 RVA: 0x00775554 File Offset: 0x00773754
	public int UpdatePreIndex()
	{
		if (this.PreviousIndex < 0)
		{
			if (!this.InversePath)
			{
				this.PreviousIndex = Math.Max(0, this.TargetIndex - 1);
			}
			else
			{
				this.PreviousIndex = Math.Min(this.MovePoint.Count, this.TargetIndex + 1);
			}
		}
		return this.PreviousIndex;
	}

	// Token: 0x06018992 RID: 100754 RVA: 0x007755AC File Offset: 0x007737AC
	private bool IsPointEqual(MoveCharacterPoint point, MoveCharacterPoint otherPoint)
	{
		return point == otherPoint || (point != null && otherPoint != null && point.Index == otherPoint.Index && point.Position.Equals(otherPoint.Position, 9.999999747378752E-05));
	}

	// Token: 0x06018993 RID: 100755 RVA: 0x007755EC File Offset: 0x007737EC
	private bool IsPathEqual(IList<MoveCharacterPoint> path, IList<MoveCharacterPoint> otherPath)
	{
		if (path == otherPath)
		{
			return true;
		}
		if (path == null || otherPath == null)
		{
			return false;
		}
		if (path.Count != otherPath.Count)
		{
			return false;
		}
		int count = path.Count;
		for (int i = 0; i < count; i++)
		{
			if (!this.IsPointEqual(path[i], otherPath[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06018994 RID: 100756 RVA: 0x00775643 File Offset: 0x00773843
	private bool UpdateMoveIndex(int newIndex)
	{
		this.PreviousIndex = this.TargetIndex;
		return this.UpdateMoveTarget(newIndex);
	}

	// Token: 0x06018995 RID: 100757 RVA: 0x00775658 File Offset: 0x00773858
	private bool UpdateMoveTarget(int newIndex)
	{
		this.TargetIndex = newIndex;
		if (this.TargetIndex < this.MovePoint.Count)
		{
			this.TargetPoint = this.MovePoint[this.TargetIndex];
			return true;
		}
		this.TargetPoint = null;
		return false;
	}

	// Token: 0x06018996 RID: 100758 RVA: 0x00775698 File Offset: 0x00773898
	private void UpdateNearestPoint()
	{
		int nearestPatrolPointIndex = this.GetNearestPatrolPointIndex();
		this.TargetIndex = ((nearestPatrolPointIndex - 1 >= 0) ? (nearestPatrolPointIndex - 1) : 0);
		this.UpdateMoveTarget(nearestPatrolPointIndex);
	}

	// Token: 0x06018997 RID: 100759 RVA: 0x007756C8 File Offset: 0x007738C8
	private int GetNearestPatrolPointIndex()
	{
		int num = 0;
		float num2 = float.MaxValue;
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		for (int i = 0; i < this.MovePoint.Count; i++)
		{
			MoveCharacterPoint moveCharacterPoint = this.MovePoint[i];
			if (moveCharacterPoint.Index >= 0)
			{
				float num3 = (float)global::Vector.Dist(actorLocationProxy, moveCharacterPoint.Position);
				if (num3 < num2)
				{
					num2 = num3;
					num = i;
				}
			}
		}
		if (num == 0 || (num == this.MovePoint.Count - 1 && num2 < 200f && global::Vector.Dist(this.MovePoint[0].Position, this.MovePoint[this.MovePoint.Count - 1].Position) < 200.0))
		{
			return 0;
		}
		for (int j = 0; j < this.MovePoint.Count - 1; j++)
		{
			global::Vector position = this.MovePoint[j].Position;
			global::Vector position2 = this.MovePoint[j + 1].Position;
			this.CacheVector.Set(position2.X, position2.Y, position2.Z);
			this.CacheVector.Subtraction(position, this.CacheVector);
			float num4 = (float)this.CacheVector.Size();
			this.CacheVector2.Set(actorLocationProxy.X, actorLocationProxy.Y, actorLocationProxy.Z);
			this.CacheVector2.Subtraction(position2, this.CacheVector2);
			if (this.CacheVector.DotProduct(this.CacheVector2) <= 0.0)
			{
				this.CacheVector2.Set(actorLocationProxy.X, actorLocationProxy.Y, actorLocationProxy.Z);
				this.CacheVector2.Subtraction(position, this.CacheVector2);
				if (this.CacheVector.DotProduct(this.CacheVector2) >= 0.0)
				{
					this.CacheVector.CrossProduct(this.CacheVector2, this.CacheVector);
					float num5 = (float)this.CacheVector.Size() / num4;
					if (num5 < num2)
					{
						num2 = num5;
						num = (this.InversePath ? j : (j + 1));
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06018998 RID: 100760 RVA: 0x007758FC File Offset: 0x00773AFC
	public bool FindNearestPointOnPath(global::Vector outVector)
	{
		if (this.TargetIndex == -1)
		{
			return false;
		}
		if (this.PreviousIndex == -1)
		{
			outVector.DeepCopy(this.MovePoint[this.TargetIndex].Position);
			return true;
		}
		this.MovePoint[this.TargetIndex].Position.Subtraction(this.MovePoint[this.PreviousIndex].Position, this.CacheVector2);
		if (!this.CacheVector2.Normalize(9.99999993922529E-09))
		{
			outVector.DeepCopy(this.MovePoint[this.TargetIndex].Position);
			return true;
		}
		this.ActorComp.ActorLocationProxy.Subtraction(this.MovePoint[this.PreviousIndex].Position, this.CacheVector);
		this.CacheVector2.MultiplyEqual(this.CacheVector.DotProduct(this.CacheVector2));
		this.MovePoint[this.PreviousIndex].Position.Addition(this.CacheVector2, outVector);
		return true;
	}

	// Token: 0x0400D53F RID: 54591
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D540 RID: 54592
	private bool IsLoop;

	// Token: 0x0400D541 RID: 54593
	private bool IsCircle;

	// Token: 0x0400D542 RID: 54594
	private bool InversePath;

	// Token: 0x0400D543 RID: 54595
	private int PreviousIndex = -1;

	// Token: 0x0400D544 RID: 54596
	public int TargetIndex;

	// Token: 0x0400D545 RID: 54597
	[Nullable(2)]
	public MoveCharacterPoint TargetPoint;

	// Token: 0x0400D546 RID: 54598
	public IList<MoveCharacterPoint> MovePoint = Array.Empty<MoveCharacterPoint>();

	// Token: 0x0400D547 RID: 54599
	private readonly global::Vector CacheVector = global::Vector.Create();

	// Token: 0x0400D548 RID: 54600
	private readonly global::Vector CacheVector2 = global::Vector.Create();

	// Token: 0x0400D549 RID: 54601
	private const float MAX_DISTANCE = 200f;
}
