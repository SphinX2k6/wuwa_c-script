using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E89 RID: 16009
	public struct IFishFollowState : IFlatbufferObject
	{
		// Token: 0x17006C27 RID: 27687
		// (get) Token: 0x06015994 RID: 88468 RVA: 0x0031CC6A File Offset: 0x0031AE6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015995 RID: 88469 RVA: 0x0031CC77 File Offset: 0x0031AE77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015996 RID: 88470 RVA: 0x0031CC80 File Offset: 0x0031AE80
		public static IFishFollowState GetRootAsIFishFollowState(ByteBuffer _bb)
		{
			return IFishFollowState.GetRootAsIFishFollowState(_bb, default(IFishFollowState));
		}

		// Token: 0x06015997 RID: 88471 RVA: 0x0031CC9C File Offset: 0x0031AE9C
		public static IFishFollowState GetRootAsIFishFollowState(ByteBuffer _bb, IFishFollowState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015998 RID: 88472 RVA: 0x0031CCB9 File Offset: 0x0031AEB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015999 RID: 88473 RVA: 0x0031CCC8 File Offset: 0x0031AEC8
		public IFishFollowState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C28 RID: 27688
		// (get) Token: 0x0601599A RID: 88474 RVA: 0x0031CCD8 File Offset: 0x0031AED8
		public EFishState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFishState.Idle;
				}
				return (EFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C29 RID: 27689
		// (get) Token: 0x0601599B RID: 88475 RVA: 0x0031CD14 File Offset: 0x0031AF14
		public TTargetType TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetType.NONE;
				}
				return (TTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601599C RID: 88476 RVA: 0x0031CD50 File Offset: 0x0031AF50
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601599D RID: 88477 RVA: 0x0031CD94 File Offset: 0x0031AF94
		public ITargetLevelEntity TargetAsITargetLevelEntity()
		{
			return this.Target<ITargetLevelEntity>().Value;
		}

		// Token: 0x0601599E RID: 88478 RVA: 0x0031CDB0 File Offset: 0x0031AFB0
		public ITargetPlay TargetAsITargetPlay()
		{
			return this.Target<ITargetPlay>().Value;
		}

		// Token: 0x17006C2A RID: 27690
		// (get) Token: 0x0601599F RID: 88479 RVA: 0x0031CDCC File Offset: 0x0031AFCC
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006C2B RID: 27691
		// (get) Token: 0x060159A0 RID: 88480 RVA: 0x0031CE2C File Offset: 0x0031B02C
		public bool FollowOffsetInTargetSpace
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006C2C RID: 27692
		// (get) Token: 0x060159A1 RID: 88481 RVA: 0x0031CE6C File Offset: 0x0031B06C
		public float MaxSpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C2D RID: 27693
		// (get) Token: 0x060159A2 RID: 88482 RVA: 0x0031CEB0 File Offset: 0x0031B0B0
		public float StopDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C2E RID: 27694
		// (get) Token: 0x060159A3 RID: 88483 RVA: 0x0031CEF4 File Offset: 0x0031B0F4
		public float FollowDistanceGraceTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C2F RID: 27695
		// (get) Token: 0x060159A4 RID: 88484 RVA: 0x0031CF38 File Offset: 0x0031B138
		public float NiagaraFollowStrength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C30 RID: 27696
		// (get) Token: 0x060159A5 RID: 88485 RVA: 0x0031CF7C File Offset: 0x0031B17C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060159A6 RID: 88486 RVA: 0x0031CFBC File Offset: 0x0031B1BC
		public static Offset<IFishFollowState> CreateIFishFollowState(FlatBufferBuilder builder, EFishState Type = EFishState.Idle, TTargetType Target_type = TTargetType.NONE, int TargetOffset = 0, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), bool FollowOffsetInTargetSpace = false, float MaxSpeed = 0f, float StopDistance = 0f, float FollowDistanceGraceTime = 0f, float NiagaraFollowStrength = 0f, byte NullMask = 0)
		{
			builder.StartTable(10);
			IFishFollowState.AddNiagaraFollowStrength(builder, NiagaraFollowStrength);
			IFishFollowState.AddFollowDistanceGraceTime(builder, FollowDistanceGraceTime);
			IFishFollowState.AddStopDistance(builder, StopDistance);
			IFishFollowState.AddMaxSpeed(builder, MaxSpeed);
			IFishFollowState.AddOffset(builder, OffsetOffset);
			IFishFollowState.AddTarget(builder, TargetOffset);
			IFishFollowState.AddNullMask(builder, NullMask);
			IFishFollowState.AddFollowOffsetInTargetSpace(builder, FollowOffsetInTargetSpace);
			IFishFollowState.AddTargetType(builder, Target_type);
			IFishFollowState.AddType(builder, Type);
			return IFishFollowState.EndIFishFollowState(builder);
		}

		// Token: 0x060159A7 RID: 88487 RVA: 0x0031D024 File Offset: 0x0031B224
		public static void StartIFishFollowState(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060159A8 RID: 88488 RVA: 0x0031D02E File Offset: 0x0031B22E
		public static void AddType(FlatBufferBuilder builder, EFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060159A9 RID: 88489 RVA: 0x0031D039 File Offset: 0x0031B239
		public static void AddTargetType(FlatBufferBuilder builder, TTargetType targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x060159AA RID: 88490 RVA: 0x0031D044 File Offset: 0x0031B244
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x060159AB RID: 88491 RVA: 0x0031D04F File Offset: 0x0031B24F
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(3, offsetOffset.Value, 0);
		}

		// Token: 0x060159AC RID: 88492 RVA: 0x0031D05F File Offset: 0x0031B25F
		public static void AddFollowOffsetInTargetSpace(FlatBufferBuilder builder, bool followOffsetInTargetSpace)
		{
			builder.AddBool(4, followOffsetInTargetSpace, false);
		}

		// Token: 0x060159AD RID: 88493 RVA: 0x0031D06A File Offset: 0x0031B26A
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(5, maxSpeed, 0.0);
		}

		// Token: 0x060159AE RID: 88494 RVA: 0x0031D07D File Offset: 0x0031B27D
		public static void AddStopDistance(FlatBufferBuilder builder, float stopDistance)
		{
			builder.AddFloat(6, stopDistance, 0.0);
		}

		// Token: 0x060159AF RID: 88495 RVA: 0x0031D090 File Offset: 0x0031B290
		public static void AddFollowDistanceGraceTime(FlatBufferBuilder builder, float followDistanceGraceTime)
		{
			builder.AddFloat(7, followDistanceGraceTime, 0.0);
		}

		// Token: 0x060159B0 RID: 88496 RVA: 0x0031D0A3 File Offset: 0x0031B2A3
		public static void AddNiagaraFollowStrength(FlatBufferBuilder builder, float niagaraFollowStrength)
		{
			builder.AddFloat(8, niagaraFollowStrength, 0.0);
		}

		// Token: 0x060159B1 RID: 88497 RVA: 0x0031D0B6 File Offset: 0x0031B2B6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060159B2 RID: 88498 RVA: 0x0031D0C2 File Offset: 0x0031B2C2
		public static Offset<IFishFollowState> EndIFishFollowState(FlatBufferBuilder builder)
		{
			return new Offset<IFishFollowState>(builder.EndTable());
		}

		// Token: 0x060159B3 RID: 88499 RVA: 0x0031D0D0 File Offset: 0x0031B2D0
		public IFishFollowStateT UnPack()
		{
			IFishFollowStateT fishFollowStateT = new IFishFollowStateT();
			this.UnPackTo(fishFollowStateT);
			return fishFollowStateT;
		}

		// Token: 0x060159B4 RID: 88500 RVA: 0x0031D0EC File Offset: 0x0031B2EC
		public void UnPackTo(IFishFollowStateT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetTypeUnion();
			_o.Target.Type = this.TargetType;
			TTargetType targetType = this.TargetType;
			if (targetType != TTargetType.ITargetLevelEntity)
			{
				if (targetType == TTargetType.ITargetPlay)
				{
					_o.Target.Value = ((this.Target<ITargetPlay>() != null) ? this.Target<ITargetPlay>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<ITargetLevelEntity>() != null) ? this.Target<ITargetLevelEntity>().Value.UnPack() : null);
			}
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.FollowOffsetInTargetSpace = this.FollowOffsetInTargetSpace;
			_o.MaxSpeed = this.MaxSpeed;
			_o.StopDistance = this.StopDistance;
			_o.FollowDistanceGraceTime = this.FollowDistanceGraceTime;
			_o.NiagaraFollowStrength = this.NiagaraFollowStrength;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060159B5 RID: 88501 RVA: 0x0031D218 File Offset: 0x0031B418
		public static Offset<IFishFollowState> Pack(FlatBufferBuilder builder, IFishFollowStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishFollowState>);
			}
			TTargetType target_type = (_o.Target == null) ? TTargetType.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetTypeUnion.Pack(builder, _o.Target);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			return IFishFollowState.CreateIFishFollowState(builder, _o.Type, target_type, targetOffset, offsetOffset, _o.FollowOffsetInTargetSpace, _o.MaxSpeed, _o.StopDistance, _o.FollowDistanceGraceTime, _o.NiagaraFollowStrength, _o.NullMask);
		}

		// Token: 0x0400B85D RID: 47197
		private Table __p;
	}
}
