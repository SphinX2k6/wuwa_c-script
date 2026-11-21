using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DA0 RID: 23968
	public struct IProceduralVisualLookAt : IFlatbufferObject
	{
		// Token: 0x1700B061 RID: 45153
		// (get) Token: 0x06027EB3 RID: 163507 RVA: 0x00575A6D File Offset: 0x00573C6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027EB4 RID: 163508 RVA: 0x00575A7A File Offset: 0x00573C7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027EB5 RID: 163509 RVA: 0x00575A84 File Offset: 0x00573C84
		public static IProceduralVisualLookAt GetRootAsIProceduralVisualLookAt(ByteBuffer _bb)
		{
			return IProceduralVisualLookAt.GetRootAsIProceduralVisualLookAt(_bb, default(IProceduralVisualLookAt));
		}

		// Token: 0x06027EB6 RID: 163510 RVA: 0x00575AA0 File Offset: 0x00573CA0
		public static IProceduralVisualLookAt GetRootAsIProceduralVisualLookAt(ByteBuffer _bb, IProceduralVisualLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027EB7 RID: 163511 RVA: 0x00575ABD File Offset: 0x00573CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027EB8 RID: 163512 RVA: 0x00575ACC File Offset: 0x00573CCC
		public IProceduralVisualLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B062 RID: 45154
		// (get) Token: 0x06027EB9 RID: 163513 RVA: 0x00575ADC File Offset: 0x00573CDC
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

		// Token: 0x1700B063 RID: 45155
		// (get) Token: 0x06027EBA RID: 163514 RVA: 0x00575B18 File Offset: 0x00573D18
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

		// Token: 0x1700B064 RID: 45156
		// (get) Token: 0x06027EBB RID: 163515 RVA: 0x00575B78 File Offset: 0x00573D78
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

		// Token: 0x06027EBC RID: 163516 RVA: 0x00575BB4 File Offset: 0x00573DB4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027EBD RID: 163517 RVA: 0x00575BFC File Offset: 0x00573DFC
		public ILookAtTargetEntity TargetAsILookAtTargetEntity()
		{
			return this.Target<ILookAtTargetEntity>().Value;
		}

		// Token: 0x06027EBE RID: 163518 RVA: 0x00575C18 File Offset: 0x00573E18
		public ILookAtTargetPlayer TargetAsILookAtTargetPlayer()
		{
			return this.Target<ILookAtTargetPlayer>().Value;
		}

		// Token: 0x1700B065 RID: 45157
		// (get) Token: 0x06027EBF RID: 163519 RVA: 0x00575C34 File Offset: 0x00573E34
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

		// Token: 0x06027EC0 RID: 163520 RVA: 0x00575C6C File Offset: 0x00573E6C
		public Span<byte> GetRotateNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06027EC1 RID: 163521 RVA: 0x00575C7C File Offset: 0x00573E7C
		public byte[] GetRotateNodeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700B066 RID: 45158
		// (get) Token: 0x06027EC2 RID: 163522 RVA: 0x00575C8C File Offset: 0x00573E8C
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

		// Token: 0x1700B067 RID: 45159
		// (get) Token: 0x06027EC3 RID: 163523 RVA: 0x00575CD0 File Offset: 0x00573ED0
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

		// Token: 0x1700B068 RID: 45160
		// (get) Token: 0x06027EC4 RID: 163524 RVA: 0x00575D10 File Offset: 0x00573F10
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

		// Token: 0x1700B069 RID: 45161
		// (get) Token: 0x06027EC5 RID: 163525 RVA: 0x00575D50 File Offset: 0x00573F50
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

		// Token: 0x1700B06A RID: 45162
		// (get) Token: 0x06027EC6 RID: 163526 RVA: 0x00575D90 File Offset: 0x00573F90
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

		// Token: 0x06027EC7 RID: 163527 RVA: 0x00575DD0 File Offset: 0x00573FD0
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

		// Token: 0x06027EC8 RID: 163528 RVA: 0x00575E38 File Offset: 0x00574038
		public static void StartIProceduralVisualLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06027EC9 RID: 163529 RVA: 0x00575E42 File Offset: 0x00574042
		public static void AddType(FlatBufferBuilder builder, EProceduralVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027ECA RID: 163530 RVA: 0x00575E4D File Offset: 0x0057404D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06027ECB RID: 163531 RVA: 0x00575E5D File Offset: 0x0057405D
		public static void AddTargetType(FlatBufferBuilder builder, TLookAtTarget targetType)
		{
			builder.AddByte(2, (byte)targetType, 0);
		}

		// Token: 0x06027ECC RID: 163532 RVA: 0x00575E68 File Offset: 0x00574068
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(3, targetOffset, 0);
		}

		// Token: 0x06027ECD RID: 163533 RVA: 0x00575E73 File Offset: 0x00574073
		public static void AddRotateNode(FlatBufferBuilder builder, StringOffset rotateNodeOffset)
		{
			builder.AddOffset(4, rotateNodeOffset.Value, 0);
		}

		// Token: 0x06027ECE RID: 163534 RVA: 0x00575E83 File Offset: 0x00574083
		public static void AddMaxAngleSpeed(FlatBufferBuilder builder, float maxAngleSpeed)
		{
			builder.AddFloat(5, maxAngleSpeed, 0.0);
		}

		// Token: 0x06027ECF RID: 163535 RVA: 0x00575E96 File Offset: 0x00574096
		public static void AddRotateMode(FlatBufferBuilder builder, ELookAtRotateMode rotateMode)
		{
			builder.AddByte(6, (byte)rotateMode, 0);
		}

		// Token: 0x06027ED0 RID: 163536 RVA: 0x00575EA1 File Offset: 0x005740A1
		public static void AddForwardDirection(FlatBufferBuilder builder, EWorldAxisType forwardDirection)
		{
			builder.AddByte(7, (byte)forwardDirection, 0);
		}

		// Token: 0x06027ED1 RID: 163537 RVA: 0x00575EAC File Offset: 0x005740AC
		public static void AddInvalidProcess(FlatBufferBuilder builder, ELookAtInvalidProcess invalidProcess)
		{
			builder.AddByte(8, (byte)invalidProcess, 0);
		}

		// Token: 0x06027ED2 RID: 163538 RVA: 0x00575EB7 File Offset: 0x005740B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06027ED3 RID: 163539 RVA: 0x00575EC3 File Offset: 0x005740C3
		public static Offset<IProceduralVisualLookAt> EndIProceduralVisualLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralVisualLookAt>(builder.EndTable());
		}

		// Token: 0x06027ED4 RID: 163540 RVA: 0x00575ED0 File Offset: 0x005740D0
		public IProceduralVisualLookAtT UnPack()
		{
			IProceduralVisualLookAtT proceduralVisualLookAtT = new IProceduralVisualLookAtT();
			this.UnPackTo(proceduralVisualLookAtT);
			return proceduralVisualLookAtT;
		}

		// Token: 0x06027ED5 RID: 163541 RVA: 0x00575EEC File Offset: 0x005740EC
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

		// Token: 0x06027ED6 RID: 163542 RVA: 0x00576018 File Offset: 0x00574218
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

		// Token: 0x0400F93A RID: 63802
		private Table __p;
	}
}
