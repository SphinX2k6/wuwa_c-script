using System;
using Aki.UniverseEditor.Interface.Fbs.Physics;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005733 RID: 22323
	public struct IPhysicsConstraintComponent : IFlatbufferObject
	{
		// Token: 0x1700A660 RID: 42592
		// (get) Token: 0x060255E0 RID: 153056 RVA: 0x00527E64 File Offset: 0x00526064
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060255E1 RID: 153057 RVA: 0x00527E71 File Offset: 0x00526071
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060255E2 RID: 153058 RVA: 0x00527E78 File Offset: 0x00526078
		public static IPhysicsConstraintComponent GetRootAsIPhysicsConstraintComponent(ByteBuffer _bb)
		{
			return IPhysicsConstraintComponent.GetRootAsIPhysicsConstraintComponent(_bb, default(IPhysicsConstraintComponent));
		}

		// Token: 0x060255E3 RID: 153059 RVA: 0x00527E94 File Offset: 0x00526094
		public static IPhysicsConstraintComponent GetRootAsIPhysicsConstraintComponent(ByteBuffer _bb, IPhysicsConstraintComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060255E4 RID: 153060 RVA: 0x00527EB1 File Offset: 0x005260B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060255E5 RID: 153061 RVA: 0x00527EC0 File Offset: 0x005260C0
		public IPhysicsConstraintComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A661 RID: 42593
		// (get) Token: 0x060255E6 RID: 153062 RVA: 0x00527ED0 File Offset: 0x005260D0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A662 RID: 42594
		// (get) Token: 0x060255E7 RID: 153063 RVA: 0x00527F10 File Offset: 0x00526110
		public string EffectPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060255E8 RID: 153064 RVA: 0x00527F47 File Offset: 0x00526147
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060255E9 RID: 153065 RVA: 0x00527F56 File Offset: 0x00526156
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A663 RID: 42595
		// (get) Token: 0x060255EA RID: 153066 RVA: 0x00527F64 File Offset: 0x00526164
		public TPhysicsAttachTarget AttachTargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TPhysicsAttachTarget.NONE;
				}
				return (TPhysicsAttachTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060255EB RID: 153067 RVA: 0x00527FA0 File Offset: 0x005261A0
		public TTable? AttachTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060255EC RID: 153068 RVA: 0x00527FE8 File Offset: 0x005261E8
		public IActorAttachTarget AttachTargetAsIActorAttachTarget()
		{
			return this.AttachTarget<IActorAttachTarget>().Value;
		}

		// Token: 0x060255ED RID: 153069 RVA: 0x00528004 File Offset: 0x00526204
		public IEntityAttachTarget AttachTargetAsIEntityAttachTarget()
		{
			return this.AttachTarget<IEntityAttachTarget>().Value;
		}

		// Token: 0x060255EE RID: 153070 RVA: 0x00528020 File Offset: 0x00526220
		public IPointAttachTarget AttachTargetAsIPointAttachTarget()
		{
			return this.AttachTarget<IPointAttachTarget>().Value;
		}

		// Token: 0x060255EF RID: 153071 RVA: 0x0052803C File Offset: 0x0052623C
		public IDynamicAttachTarget AttachTargetAsIDynamicAttachTarget()
		{
			return this.AttachTarget<IDynamicAttachTarget>().Value;
		}

		// Token: 0x060255F0 RID: 153072 RVA: 0x00528058 File Offset: 0x00526258
		public IPlayerAttachTarget AttachTargetAsIPlayerAttachTarget()
		{
			return this.AttachTarget<IPlayerAttachTarget>().Value;
		}

		// Token: 0x1700A664 RID: 42596
		// (get) Token: 0x060255F1 RID: 153073 RVA: 0x00528074 File Offset: 0x00526274
		public IPhysicsAngularLimit? AngularLimit
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IPhysicsAngularLimit?(default(IPhysicsAngularLimit).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A665 RID: 42597
		// (get) Token: 0x060255F2 RID: 153074 RVA: 0x005280D4 File Offset: 0x005262D4
		public float DampingCoefficient
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

		// Token: 0x1700A666 RID: 42598
		// (get) Token: 0x060255F3 RID: 153075 RVA: 0x00528118 File Offset: 0x00526318
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060255F4 RID: 153076 RVA: 0x00528158 File Offset: 0x00526358
		public static Offset<IPhysicsConstraintComponent> CreateIPhysicsConstraintComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset EffectPathOffset = default(StringOffset), TPhysicsAttachTarget AttachTarget_type = TPhysicsAttachTarget.NONE, int AttachTargetOffset = 0, Offset<IPhysicsAngularLimit> AngularLimitOffset = default(Offset<IPhysicsAngularLimit>), float DampingCoefficient = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPhysicsConstraintComponent.AddDampingCoefficient(builder, DampingCoefficient);
			IPhysicsConstraintComponent.AddAngularLimit(builder, AngularLimitOffset);
			IPhysicsConstraintComponent.AddAttachTarget(builder, AttachTargetOffset);
			IPhysicsConstraintComponent.AddEffectPath(builder, EffectPathOffset);
			IPhysicsConstraintComponent.AddNullMask(builder, NullMask);
			IPhysicsConstraintComponent.AddAttachTargetType(builder, AttachTarget_type);
			IPhysicsConstraintComponent.AddDisabled(builder, Disabled);
			return IPhysicsConstraintComponent.EndIPhysicsConstraintComponent(builder);
		}

		// Token: 0x060255F5 RID: 153077 RVA: 0x005281A7 File Offset: 0x005263A7
		public static void StartIPhysicsConstraintComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060255F6 RID: 153078 RVA: 0x005281B0 File Offset: 0x005263B0
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060255F7 RID: 153079 RVA: 0x005281BB File Offset: 0x005263BB
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(1, effectPathOffset.Value, 0);
		}

		// Token: 0x060255F8 RID: 153080 RVA: 0x005281CB File Offset: 0x005263CB
		public static void AddAttachTargetType(FlatBufferBuilder builder, TPhysicsAttachTarget attachTargetType)
		{
			builder.AddByte(2, (byte)attachTargetType, 0);
		}

		// Token: 0x060255F9 RID: 153081 RVA: 0x005281D6 File Offset: 0x005263D6
		public static void AddAttachTarget(FlatBufferBuilder builder, int attachTargetOffset)
		{
			builder.AddOffset(3, attachTargetOffset, 0);
		}

		// Token: 0x060255FA RID: 153082 RVA: 0x005281E1 File Offset: 0x005263E1
		public static void AddAngularLimit(FlatBufferBuilder builder, Offset<IPhysicsAngularLimit> angularLimitOffset)
		{
			builder.AddOffset(4, angularLimitOffset.Value, 0);
		}

		// Token: 0x060255FB RID: 153083 RVA: 0x005281F1 File Offset: 0x005263F1
		public static void AddDampingCoefficient(FlatBufferBuilder builder, float dampingCoefficient)
		{
			builder.AddFloat(5, dampingCoefficient, 0.0);
		}

		// Token: 0x060255FC RID: 153084 RVA: 0x00528204 File Offset: 0x00526404
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060255FD RID: 153085 RVA: 0x0052820F File Offset: 0x0052640F
		public static Offset<IPhysicsConstraintComponent> EndIPhysicsConstraintComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPhysicsConstraintComponent>(builder.EndTable());
		}

		// Token: 0x060255FE RID: 153086 RVA: 0x0052821C File Offset: 0x0052641C
		public IPhysicsConstraintComponentT UnPack()
		{
			IPhysicsConstraintComponentT physicsConstraintComponentT = new IPhysicsConstraintComponentT();
			this.UnPackTo(physicsConstraintComponentT);
			return physicsConstraintComponentT;
		}

		// Token: 0x060255FF RID: 153087 RVA: 0x00528238 File Offset: 0x00526438
		public void UnPackTo(IPhysicsConstraintComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.EffectPath = this.EffectPath;
			_o.AttachTarget = new TPhysicsAttachTargetUnion();
			_o.AttachTarget.Type = this.AttachTargetType;
			switch (this.AttachTargetType)
			{
			case TPhysicsAttachTarget.IActorAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IActorAttachTarget>() != null) ? this.AttachTarget<IActorAttachTarget>().Value.UnPack() : null);
				break;
			case TPhysicsAttachTarget.IEntityAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IEntityAttachTarget>() != null) ? this.AttachTarget<IEntityAttachTarget>().Value.UnPack() : null);
				break;
			case TPhysicsAttachTarget.IPointAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IPointAttachTarget>() != null) ? this.AttachTarget<IPointAttachTarget>().Value.UnPack() : null);
				break;
			case TPhysicsAttachTarget.IDynamicAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IDynamicAttachTarget>() != null) ? this.AttachTarget<IDynamicAttachTarget>().Value.UnPack() : null);
				break;
			case TPhysicsAttachTarget.IPlayerAttachTarget:
				_o.AttachTarget.Value = ((this.AttachTarget<IPlayerAttachTarget>() != null) ? this.AttachTarget<IPlayerAttachTarget>().Value.UnPack() : null);
				break;
			}
			_o.AngularLimit = ((this.AngularLimit != null) ? this.AngularLimit.Value.UnPack() : null);
			_o.DampingCoefficient = this.DampingCoefficient;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025600 RID: 153088 RVA: 0x00528408 File Offset: 0x00526608
		public static Offset<IPhysicsConstraintComponent> Pack(FlatBufferBuilder builder, IPhysicsConstraintComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhysicsConstraintComponent>);
			}
			StringOffset effectPathOffset = (_o.EffectPath == null) ? default(StringOffset) : builder.CreateString(_o.EffectPath);
			TPhysicsAttachTarget attachTarget_type = (_o.AttachTarget == null) ? TPhysicsAttachTarget.NONE : _o.AttachTarget.Type;
			int attachTargetOffset = (_o.AttachTarget == null) ? 0 : TPhysicsAttachTargetUnion.Pack(builder, _o.AttachTarget);
			Offset<IPhysicsAngularLimit> angularLimitOffset = (_o.AngularLimit == null) ? default(Offset<IPhysicsAngularLimit>) : IPhysicsAngularLimit.Pack(builder, _o.AngularLimit);
			return IPhysicsConstraintComponent.CreateIPhysicsConstraintComponent(builder, _o.Disabled, effectPathOffset, attachTarget_type, attachTargetOffset, angularLimitOffset, _o.DampingCoefficient, _o.NullMask);
		}

		// Token: 0x0400EBB3 RID: 60339
		private Table __p;
	}
}
