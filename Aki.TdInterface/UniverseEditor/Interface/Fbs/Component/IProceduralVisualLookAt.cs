using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005799 RID: 22425
	public struct IProceduralVisualLookAt : IFlatbufferObject
	{
		// Token: 0x1700A73D RID: 42813
		// (get) Token: 0x06025993 RID: 154003 RVA: 0x0052F8E1 File Offset: 0x0052DAE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025994 RID: 154004 RVA: 0x0052F8EE File Offset: 0x0052DAEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025995 RID: 154005 RVA: 0x0052F8F8 File Offset: 0x0052DAF8
		public static IProceduralVisualLookAt GetRootAsIProceduralVisualLookAt(ByteBuffer _bb)
		{
			return IProceduralVisualLookAt.GetRootAsIProceduralVisualLookAt(_bb, default(IProceduralVisualLookAt));
		}

		// Token: 0x06025996 RID: 154006 RVA: 0x0052F914 File Offset: 0x0052DB14
		public static IProceduralVisualLookAt GetRootAsIProceduralVisualLookAt(ByteBuffer _bb, IProceduralVisualLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025997 RID: 154007 RVA: 0x0052F931 File Offset: 0x0052DB31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025998 RID: 154008 RVA: 0x0052F940 File Offset: 0x0052DB40
		public IProceduralVisualLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A73E RID: 42814
		// (get) Token: 0x06025999 RID: 154009 RVA: 0x0052F950 File Offset: 0x0052DB50
		public EProceduralVisualType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProceduralVisualType.LookAt;
				}
				return (EProceduralVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A73F RID: 42815
		// (get) Token: 0x0602599A RID: 154010 RVA: 0x0052F98C File Offset: 0x0052DB8C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A740 RID: 42816
		// (get) Token: 0x0602599B RID: 154011 RVA: 0x0052F9EC File Offset: 0x0052DBEC
		public TLookAtTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TLookAtTarget.NONE;
				}
				return (TLookAtTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602599C RID: 154012 RVA: 0x0052FA28 File Offset: 0x0052DC28
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602599D RID: 154013 RVA: 0x0052FA70 File Offset: 0x0052DC70
		public ILookAtTargetEntity TargetAsILookAtTargetEntity()
		{
			return this.Target<ILookAtTargetEntity>().Value;
		}

		// Token: 0x0602599E RID: 154014 RVA: 0x0052FA8C File Offset: 0x0052DC8C
		public ILookAtTargetPlayer TargetAsILookAtTargetPlayer()
		{
			return this.Target<ILookAtTargetPlayer>().Value;
		}

		// Token: 0x1700A741 RID: 42817
		// (get) Token: 0x0602599F RID: 154015 RVA: 0x0052FAA8 File Offset: 0x0052DCA8
		public string RotateNode
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060259A0 RID: 154016 RVA: 0x0052FAE0 File Offset: 0x0052DCE0
		public Span<byte> GetRotateNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060259A1 RID: 154017 RVA: 0x0052FAF0 File Offset: 0x0052DCF0
		public byte[] GetRotateNodeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700A742 RID: 42818
		// (get) Token: 0x060259A2 RID: 154018 RVA: 0x0052FB00 File Offset: 0x0052DD00
		public float MaxAngleSpeed
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

		// Token: 0x1700A743 RID: 42819
		// (get) Token: 0x060259A3 RID: 154019 RVA: 0x0052FB44 File Offset: 0x0052DD44
		public ELookAtRotateMode RotateMode
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return ELookAtRotateMode.KeepInitialPitchRoll;
				}
				return (ELookAtRotateMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A744 RID: 42820
		// (get) Token: 0x060259A4 RID: 154020 RVA: 0x0052FB84 File Offset: 0x0052DD84
		public EWorldAxisType ForwardDirection
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EWorldAxisType.PositiveX;
				}
				return (EWorldAxisType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A745 RID: 42821
		// (get) Token: 0x060259A5 RID: 154021 RVA: 0x0052FBC4 File Offset: 0x0052DDC4
		public ELookAtInvalidProcess InvalidProcess
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return ELookAtInvalidProcess.Reset;
				}
				return (ELookAtInvalidProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A746 RID: 42822
		// (get) Token: 0x060259A6 RID: 154022 RVA: 0x0052FC04 File Offset: 0x0052DE04
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

		// Token: 0x060259A7 RID: 154023 RVA: 0x0052FC44 File Offset: 0x0052DE44
		public static Offset<IProceduralVisualLookAt> CreateIProceduralVisualLookAt(FlatBufferBuilder builder, EProceduralVisualType Type = EProceduralVisualType.LookAt, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), TLookAtTarget Target_type = TLookAtTarget.NONE, int TargetOffset = 0, StringOffset RotateNodeOffset = default(StringOffset), float MaxAngleSpeed = 0f, ELookAtRotateMode RotateMode = ELookAtRotateMode.KeepInitialPitchRoll, EWorldAxisType ForwardDirection = EWorldAxisType.PositiveX, ELookAtInvalidProcess InvalidProcess = ELookAtInvalidProcess.Reset, byte NullMask = 0)
		{
			builder.StartTable(10);
			IProceduralVisualLookAt.AddMaxAngleSpeed(builder, MaxAngleSpeed);
			IProceduralVisualLookAt.AddRotateNode(builder, RotateNodeOffset);
			IProceduralVisualLookAt.AddTarget(builder, TargetOffset);
			IProceduralVisualLookAt.AddCondition(builder, ConditionOffset);
			IProceduralVisualLookAt.AddNullMask(builder, NullMask);
			IProceduralVisualLookAt.AddInvalidProcess(builder, InvalidProcess);
			IProceduralVisualLookAt.AddForwardDirection(builder, ForwardDirection);
			IProceduralVisualLookAt.AddRotateMode(builder, RotateMode);
			IProceduralVisualLookAt.AddTargetType(builder, Target_type);
			IProceduralVisualLookAt.AddType(builder, Type);
			return IProceduralVisualLookAt.EndIProceduralVisualLookAt(builder);
		}

		// Token: 0x060259A8 RID: 154024 RVA: 0x0052FCAC File Offset: 0x0052DEAC
		public static void StartIProceduralVisualLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060259A9 RID: 154025 RVA: 0x0052FCB6 File Offset: 0x0052DEB6
		public static void AddType(FlatBufferBuilder builder, EProceduralVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060259AA RID: 154026 RVA: 0x0052FCC1 File Offset: 0x0052DEC1
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060259AB RID: 154027 RVA: 0x0052FCD1 File Offset: 0x0052DED1
		public static void AddTargetType(FlatBufferBuilder builder, TLookAtTarget targetType)
		{
			builder.AddByte(2, (byte)targetType, 0);
		}

		// Token: 0x060259AC RID: 154028 RVA: 0x0052FCDC File Offset: 0x0052DEDC
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(3, targetOffset, 0);
		}

		// Token: 0x060259AD RID: 154029 RVA: 0x0052FCE7 File Offset: 0x0052DEE7
		public static void AddRotateNode(FlatBufferBuilder builder, StringOffset rotateNodeOffset)
		{
			builder.AddOffset(4, rotateNodeOffset.Value, 0);
		}

		// Token: 0x060259AE RID: 154030 RVA: 0x0052FCF7 File Offset: 0x0052DEF7
		public static void AddMaxAngleSpeed(FlatBufferBuilder builder, float maxAngleSpeed)
		{
			builder.AddFloat(5, maxAngleSpeed, 0.0);
		}

		// Token: 0x060259AF RID: 154031 RVA: 0x0052FD0A File Offset: 0x0052DF0A
		public static void AddRotateMode(FlatBufferBuilder builder, ELookAtRotateMode rotateMode)
		{
			builder.AddByte(6, (byte)rotateMode, 0);
		}

		// Token: 0x060259B0 RID: 154032 RVA: 0x0052FD15 File Offset: 0x0052DF15
		public static void AddForwardDirection(FlatBufferBuilder builder, EWorldAxisType forwardDirection)
		{
			builder.AddByte(7, (byte)forwardDirection, 0);
		}

		// Token: 0x060259B1 RID: 154033 RVA: 0x0052FD20 File Offset: 0x0052DF20
		public static void AddInvalidProcess(FlatBufferBuilder builder, ELookAtInvalidProcess invalidProcess)
		{
			builder.AddByte(8, (byte)invalidProcess, 0);
		}

		// Token: 0x060259B2 RID: 154034 RVA: 0x0052FD2B File Offset: 0x0052DF2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060259B3 RID: 154035 RVA: 0x0052FD37 File Offset: 0x0052DF37
		public static Offset<IProceduralVisualLookAt> EndIProceduralVisualLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralVisualLookAt>(builder.EndTable());
		}

		// Token: 0x060259B4 RID: 154036 RVA: 0x0052FD44 File Offset: 0x0052DF44
		public IProceduralVisualLookAtT UnPack()
		{
			IProceduralVisualLookAtT proceduralVisualLookAtT = new IProceduralVisualLookAtT();
			this.UnPackTo(proceduralVisualLookAtT);
			return proceduralVisualLookAtT;
		}

		// Token: 0x060259B5 RID: 154037 RVA: 0x0052FD60 File Offset: 0x0052DF60
		public void UnPackTo(IProceduralVisualLookAtT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Target = new TLookAtTargetUnion();
			_o.Target.Type = this.TargetType;
			TLookAtTarget targetType = this.TargetType;
			if (targetType != TLookAtTarget.ILookAtTargetEntity)
			{
				if (targetType == TLookAtTarget.ILookAtTargetPlayer)
				{
					_o.Target.Value = ((this.Target<ILookAtTargetPlayer>() != null) ? this.Target<ILookAtTargetPlayer>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<ILookAtTargetEntity>() != null) ? this.Target<ILookAtTargetEntity>().Value.UnPack() : null);
			}
			_o.RotateNode = this.RotateNode;
			_o.MaxAngleSpeed = this.MaxAngleSpeed;
			_o.RotateMode = this.RotateMode;
			_o.ForwardDirection = this.ForwardDirection;
			_o.InvalidProcess = this.InvalidProcess;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060259B6 RID: 154038 RVA: 0x0052FE8C File Offset: 0x0052E08C
		public static Offset<IProceduralVisualLookAt> Pack(FlatBufferBuilder builder, IProceduralVisualLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralVisualLookAt>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			TLookAtTarget target_type = (_o.Target == null) ? TLookAtTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TLookAtTargetUnion.Pack(builder, _o.Target);
			StringOffset rotateNodeOffset = (_o.RotateNode == null) ? default(StringOffset) : builder.CreateString(_o.RotateNode);
			return IProceduralVisualLookAt.CreateIProceduralVisualLookAt(builder, _o.Type, conditionOffset, target_type, targetOffset, rotateNodeOffset, _o.MaxAngleSpeed, _o.RotateMode, _o.ForwardDirection, _o.InvalidProcess, _o.NullMask);
		}

		// Token: 0x0400EC4F RID: 60495
		private Table __p;
	}
}
