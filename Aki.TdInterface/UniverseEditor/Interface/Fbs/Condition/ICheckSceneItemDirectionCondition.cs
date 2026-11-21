using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200500A RID: 20490
	public struct ICheckSceneItemDirectionCondition : IFlatbufferObject
	{
		// Token: 0x17009294 RID: 37524
		// (get) Token: 0x0601FFA1 RID: 130977 RVA: 0x004701A4 File Offset: 0x0046E3A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FFA2 RID: 130978 RVA: 0x004701B1 File Offset: 0x0046E3B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FFA3 RID: 130979 RVA: 0x004701B8 File Offset: 0x0046E3B8
		public static ICheckSceneItemDirectionCondition GetRootAsICheckSceneItemDirectionCondition(ByteBuffer _bb)
		{
			return ICheckSceneItemDirectionCondition.GetRootAsICheckSceneItemDirectionCondition(_bb, default(ICheckSceneItemDirectionCondition));
		}

		// Token: 0x0601FFA4 RID: 130980 RVA: 0x004701D4 File Offset: 0x0046E3D4
		public static ICheckSceneItemDirectionCondition GetRootAsICheckSceneItemDirectionCondition(ByteBuffer _bb, ICheckSceneItemDirectionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FFA5 RID: 130981 RVA: 0x004701F1 File Offset: 0x0046E3F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FFA6 RID: 130982 RVA: 0x00470200 File Offset: 0x0046E400
		public ICheckSceneItemDirectionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009295 RID: 37525
		// (get) Token: 0x0601FFA7 RID: 130983 RVA: 0x00470210 File Offset: 0x0046E410
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009296 RID: 37526
		// (get) Token: 0x0601FFA8 RID: 130984 RVA: 0x0047024C File Offset: 0x0046E44C
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FFA9 RID: 130985 RVA: 0x00470288 File Offset: 0x0046E488
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FFAA RID: 130986 RVA: 0x004702CC File Offset: 0x0046E4CC
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0601FFAB RID: 130987 RVA: 0x004702E8 File Offset: 0x0046E4E8
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0601FFAC RID: 130988 RVA: 0x00470304 File Offset: 0x0046E504
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0601FFAD RID: 130989 RVA: 0x00470320 File Offset: 0x0046E520
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x17009297 RID: 37527
		// (get) Token: 0x0601FFAE RID: 130990 RVA: 0x0047033C File Offset: 0x0046E53C
		public string RotatePoint
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FFAF RID: 130991 RVA: 0x00470374 File Offset: 0x0046E574
		public Span<byte> GetRotatePointBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601FFB0 RID: 130992 RVA: 0x00470384 File Offset: 0x0046E584
		public byte[] GetRotatePointArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17009298 RID: 37528
		// (get) Token: 0x0601FFB1 RID: 130993 RVA: 0x00470394 File Offset: 0x0046E594
		public IVectorInfo? Direction
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

		// Token: 0x17009299 RID: 37529
		// (get) Token: 0x0601FFB2 RID: 130994 RVA: 0x004703F4 File Offset: 0x0046E5F4
		public float AngleInterval
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

		// Token: 0x0601FFB3 RID: 130995 RVA: 0x00470435 File Offset: 0x0046E635
		public static Offset<ICheckSceneItemDirectionCondition> CreateICheckSceneItemDirectionCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, StringOffset RotatePointOffset = default(StringOffset), Offset<IVectorInfo> DirectionOffset = default(Offset<IVectorInfo>), float AngleInterval = 0f)
		{
			builder.StartTable(6);
			ICheckSceneItemDirectionCondition.AddAngleInterval(builder, AngleInterval);
			ICheckSceneItemDirectionCondition.AddDirection(builder, DirectionOffset);
			ICheckSceneItemDirectionCondition.AddRotatePoint(builder, RotatePointOffset);
			ICheckSceneItemDirectionCondition.AddTarget(builder, TargetOffset);
			ICheckSceneItemDirectionCondition.AddTargetType(builder, Target_type);
			ICheckSceneItemDirectionCondition.AddType(builder, Type);
			return ICheckSceneItemDirectionCondition.EndICheckSceneItemDirectionCondition(builder);
		}

		// Token: 0x0601FFB4 RID: 130996 RVA: 0x00470471 File Offset: 0x0046E671
		public static void StartICheckSceneItemDirectionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601FFB5 RID: 130997 RVA: 0x0047047A File Offset: 0x0046E67A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FFB6 RID: 130998 RVA: 0x00470485 File Offset: 0x0046E685
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0601FFB7 RID: 130999 RVA: 0x00470490 File Offset: 0x0046E690
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0601FFB8 RID: 131000 RVA: 0x0047049B File Offset: 0x0046E69B
		public static void AddRotatePoint(FlatBufferBuilder builder, StringOffset rotatePointOffset)
		{
			builder.AddOffset(3, rotatePointOffset.Value, 0);
		}

		// Token: 0x0601FFB9 RID: 131001 RVA: 0x004704AB File Offset: 0x0046E6AB
		public static void AddDirection(FlatBufferBuilder builder, Offset<IVectorInfo> directionOffset)
		{
			builder.AddOffset(4, directionOffset.Value, 0);
		}

		// Token: 0x0601FFBA RID: 131002 RVA: 0x004704BB File Offset: 0x0046E6BB
		public static void AddAngleInterval(FlatBufferBuilder builder, float angleInterval)
		{
			builder.AddFloat(5, angleInterval, 0.0);
		}

		// Token: 0x0601FFBB RID: 131003 RVA: 0x004704CE File Offset: 0x0046E6CE
		public static Offset<ICheckSceneItemDirectionCondition> EndICheckSceneItemDirectionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSceneItemDirectionCondition>(builder.EndTable());
		}

		// Token: 0x0601FFBC RID: 131004 RVA: 0x004704DC File Offset: 0x0046E6DC
		public ICheckSceneItemDirectionConditionT UnPack()
		{
			ICheckSceneItemDirectionConditionT checkSceneItemDirectionConditionT = new ICheckSceneItemDirectionConditionT();
			this.UnPackTo(checkSceneItemDirectionConditionT);
			return checkSceneItemDirectionConditionT;
		}

		// Token: 0x0601FFBD RID: 131005 RVA: 0x004704F8 File Offset: 0x0046E6F8
		public void UnPackTo(ICheckSceneItemDirectionConditionT _o)
		{
			_o.Type = this.Type;
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.RotatePoint = this.RotatePoint;
			_o.Direction = ((this.Direction != null) ? this.Direction.Value.UnPack() : null);
			_o.AngleInterval = this.AngleInterval;
		}

		// Token: 0x0601FFBE RID: 131006 RVA: 0x0047067C File Offset: 0x0046E87C
		public static Offset<ICheckSceneItemDirectionCondition> Pack(FlatBufferBuilder builder, ICheckSceneItemDirectionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSceneItemDirectionCondition>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			StringOffset rotatePointOffset = (_o.RotatePoint == null) ? default(StringOffset) : builder.CreateString(_o.RotatePoint);
			Offset<IVectorInfo> directionOffset = (_o.Direction == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Direction);
			return ICheckSceneItemDirectionCondition.CreateICheckSceneItemDirectionCondition(builder, _o.Type, target_type, targetOffset, rotatePointOffset, directionOffset, _o.AngleInterval);
		}

		// Token: 0x0400DEC3 RID: 57027
		private Table __p;
	}
}
