using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005713 RID: 22291
	public struct IPatrolSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700A5FF RID: 42495
		// (get) Token: 0x06025471 RID: 152689 RVA: 0x00524D2D File Offset: 0x00522F2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025472 RID: 152690 RVA: 0x00524D3A File Offset: 0x00522F3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025473 RID: 152691 RVA: 0x00524D44 File Offset: 0x00522F44
		public static IPatrolSplinePoint GetRootAsIPatrolSplinePoint(ByteBuffer _bb)
		{
			return IPatrolSplinePoint.GetRootAsIPatrolSplinePoint(_bb, default(IPatrolSplinePoint));
		}

		// Token: 0x06025474 RID: 152692 RVA: 0x00524D60 File Offset: 0x00522F60
		public static IPatrolSplinePoint GetRootAsIPatrolSplinePoint(ByteBuffer _bb, IPatrolSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025475 RID: 152693 RVA: 0x00524D7D File Offset: 0x00522F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025476 RID: 152694 RVA: 0x00524D8C File Offset: 0x00522F8C
		public IPatrolSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A600 RID: 42496
		// (get) Token: 0x06025477 RID: 152695 RVA: 0x00524D9C File Offset: 0x00522F9C
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A601 RID: 42497
		// (get) Token: 0x06025478 RID: 152696 RVA: 0x00524DFC File Offset: 0x00522FFC
		public IVectorInfo? ArriveTangent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A602 RID: 42498
		// (get) Token: 0x06025479 RID: 152697 RVA: 0x00524E5C File Offset: 0x0052305C
		public IVectorInfo? LeaveTangent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A603 RID: 42499
		// (get) Token: 0x0602547A RID: 152698 RVA: 0x00524EBC File Offset: 0x005230BC
		public ESplineLine LineType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ESplineLine.Linear;
				}
				return (ESplineLine)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A604 RID: 42500
		// (get) Token: 0x0602547B RID: 152699 RVA: 0x00524EFC File Offset: 0x005230FC
		public IVectorInfo? Rotation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A605 RID: 42501
		// (get) Token: 0x0602547C RID: 152700 RVA: 0x00524F5C File Offset: 0x0052315C
		public EPatrolMoveState MoveState
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return EPatrolMoveState.None;
				}
				return (EPatrolMoveState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A606 RID: 42502
		// (get) Token: 0x0602547D RID: 152701 RVA: 0x00524F9C File Offset: 0x0052319C
		public ECharPositionStateType CharPositionState
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ECharPositionStateType.Ground;
				}
				return (ECharPositionStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A607 RID: 42503
		// (get) Token: 0x0602547E RID: 152702 RVA: 0x00524FDC File Offset: 0x005231DC
		public int MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A608 RID: 42504
		// (get) Token: 0x0602547F RID: 152703 RVA: 0x0052501C File Offset: 0x0052321C
		public bool IgnorePoint
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A609 RID: 42505
		// (get) Token: 0x06025480 RID: 152704 RVA: 0x0052505C File Offset: 0x0052325C
		public int StayTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A60A RID: 42506
		// (get) Token: 0x06025481 RID: 152705 RVA: 0x0052509C File Offset: 0x0052329C
		public bool IsHide
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025482 RID: 152706 RVA: 0x005250DC File Offset: 0x005232DC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A60B RID: 42507
		// (get) Token: 0x06025483 RID: 152707 RVA: 0x00525140 File Offset: 0x00523340
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A60C RID: 42508
		// (get) Token: 0x06025484 RID: 152708 RVA: 0x0052516C File Offset: 0x0052336C
		public bool IsEnableIk
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A60D RID: 42509
		// (get) Token: 0x06025485 RID: 152709 RVA: 0x005251AC File Offset: 0x005233AC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025486 RID: 152710 RVA: 0x005251EC File Offset: 0x005233EC
		public static Offset<IPatrolSplinePoint> CreateIPatrolSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), EPatrolMoveState MoveState = EPatrolMoveState.None, ECharPositionStateType CharPositionState = ECharPositionStateType.Ground, int MoveSpeed = 0, bool IgnorePoint = false, int StayTime = 0, bool IsHide = false, VectorOffset ActionsOffset = default(VectorOffset), bool IsEnableIk = false, byte NullMask = 0)
		{
			builder.StartTable(14);
			IPatrolSplinePoint.AddActions(builder, ActionsOffset);
			IPatrolSplinePoint.AddStayTime(builder, StayTime);
			IPatrolSplinePoint.AddMoveSpeed(builder, MoveSpeed);
			IPatrolSplinePoint.AddRotation(builder, RotationOffset);
			IPatrolSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IPatrolSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IPatrolSplinePoint.AddPosition(builder, PositionOffset);
			IPatrolSplinePoint.AddNullMask(builder, NullMask);
			IPatrolSplinePoint.AddIsEnableIk(builder, IsEnableIk);
			IPatrolSplinePoint.AddIsHide(builder, IsHide);
			IPatrolSplinePoint.AddIgnorePoint(builder, IgnorePoint);
			IPatrolSplinePoint.AddCharPositionState(builder, CharPositionState);
			IPatrolSplinePoint.AddMoveState(builder, MoveState);
			IPatrolSplinePoint.AddLineType(builder, LineType);
			return IPatrolSplinePoint.EndIPatrolSplinePoint(builder);
		}

		// Token: 0x06025487 RID: 152711 RVA: 0x00525274 File Offset: 0x00523474
		public static void StartIPatrolSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06025488 RID: 152712 RVA: 0x0052527E File Offset: 0x0052347E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06025489 RID: 152713 RVA: 0x0052528E File Offset: 0x0052348E
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x0602548A RID: 152714 RVA: 0x0052529E File Offset: 0x0052349E
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x0602548B RID: 152715 RVA: 0x005252AE File Offset: 0x005234AE
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x0602548C RID: 152716 RVA: 0x005252B9 File Offset: 0x005234B9
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x0602548D RID: 152717 RVA: 0x005252C9 File Offset: 0x005234C9
		public static void AddMoveState(FlatBufferBuilder builder, EPatrolMoveState moveState)
		{
			builder.AddByte(5, (byte)moveState, 0);
		}

		// Token: 0x0602548E RID: 152718 RVA: 0x005252D4 File Offset: 0x005234D4
		public static void AddCharPositionState(FlatBufferBuilder builder, ECharPositionStateType charPositionState)
		{
			builder.AddByte(6, (byte)charPositionState, 0);
		}

		// Token: 0x0602548F RID: 152719 RVA: 0x005252DF File Offset: 0x005234DF
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(7, moveSpeed, 0);
		}

		// Token: 0x06025490 RID: 152720 RVA: 0x005252EA File Offset: 0x005234EA
		public static void AddIgnorePoint(FlatBufferBuilder builder, bool ignorePoint)
		{
			builder.AddBool(8, ignorePoint, false);
		}

		// Token: 0x06025491 RID: 152721 RVA: 0x005252F5 File Offset: 0x005234F5
		public static void AddStayTime(FlatBufferBuilder builder, int stayTime)
		{
			builder.AddInt(9, stayTime, 0);
		}

		// Token: 0x06025492 RID: 152722 RVA: 0x00525301 File Offset: 0x00523501
		public static void AddIsHide(FlatBufferBuilder builder, bool isHide)
		{
			builder.AddBool(10, isHide, false);
		}

		// Token: 0x06025493 RID: 152723 RVA: 0x0052530D File Offset: 0x0052350D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(11, actionsOffset.Value, 0);
		}

		// Token: 0x06025494 RID: 152724 RVA: 0x00525320 File Offset: 0x00523520
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025495 RID: 152725 RVA: 0x00525360 File Offset: 0x00523560
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025496 RID: 152726 RVA: 0x0052537A File Offset: 0x0052357A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025497 RID: 152727 RVA: 0x00525398 File Offset: 0x00523598
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025498 RID: 152728 RVA: 0x005253B1 File Offset: 0x005235B1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025499 RID: 152729 RVA: 0x005253BC File Offset: 0x005235BC
		public static void AddIsEnableIk(FlatBufferBuilder builder, bool isEnableIk)
		{
			builder.AddBool(12, isEnableIk, false);
		}

		// Token: 0x0602549A RID: 152730 RVA: 0x005253C8 File Offset: 0x005235C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x0602549B RID: 152731 RVA: 0x005253D4 File Offset: 0x005235D4
		public static Offset<IPatrolSplinePoint> EndIPatrolSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolSplinePoint>(builder.EndTable());
		}

		// Token: 0x0602549C RID: 152732 RVA: 0x005253E4 File Offset: 0x005235E4
		public IPatrolSplinePointT UnPack()
		{
			IPatrolSplinePointT patrolSplinePointT = new IPatrolSplinePointT();
			this.UnPackTo(patrolSplinePointT);
			return patrolSplinePointT;
		}

		// Token: 0x0602549D RID: 152733 RVA: 0x00525400 File Offset: 0x00523600
		public void UnPackTo(IPatrolSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.MoveState = this.MoveState;
			_o.CharPositionState = this.CharPositionState;
			_o.MoveSpeed = this.MoveSpeed;
			_o.IgnorePoint = this.IgnorePoint;
			_o.StayTime = this.StayTime;
			_o.IsHide = this.IsHide;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.IsEnableIk = this.IsEnableIk;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602549E RID: 152734 RVA: 0x00525588 File Offset: 0x00523788
		public static Offset<IPatrolSplinePoint> Pack(FlatBufferBuilder builder, IPatrolSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IPatrolSplinePoint.CreateActionsVector(builder, array);
			}
			return IPatrolSplinePoint.CreateIPatrolSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.MoveState, _o.CharPositionState, _o.MoveSpeed, _o.IgnorePoint, _o.StayTime, _o.IsHide, actionsOffset, _o.IsEnableIk, _o.NullMask);
		}

		// Token: 0x0400EB78 RID: 60280
		private Table __p;
	}
}
