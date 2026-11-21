using System;
using Aki.UniverseEditor.Interface.Fbs.Physics;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D3A RID: 23866
	public struct IPhysicsConstraintComponent : IFlatbufferObject
	{
		// Token: 0x1700AF84 RID: 44932
		// (get) Token: 0x06027B00 RID: 162560 RVA: 0x0056DFF0 File Offset: 0x0056C1F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B01 RID: 162561 RVA: 0x0056DFFD File Offset: 0x0056C1FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B02 RID: 162562 RVA: 0x0056E004 File Offset: 0x0056C204
		public static IPhysicsConstraintComponent GetRootAsIPhysicsConstraintComponent(ByteBuffer _bb)
		{
			return IPhysicsConstraintComponent.GetRootAsIPhysicsConstraintComponent(_bb, default(IPhysicsConstraintComponent));
		}

		// Token: 0x06027B03 RID: 162563 RVA: 0x0056E020 File Offset: 0x0056C220
		public static IPhysicsConstraintComponent GetRootAsIPhysicsConstraintComponent(ByteBuffer _bb, IPhysicsConstraintComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B04 RID: 162564 RVA: 0x0056E03D File Offset: 0x0056C23D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B05 RID: 162565 RVA: 0x0056E04C File Offset: 0x0056C24C
		public IPhysicsConstraintComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF85 RID: 44933
		// (get) Token: 0x06027B06 RID: 162566 RVA: 0x0056E05C File Offset: 0x0056C25C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF86 RID: 44934
		// (get) Token: 0x06027B07 RID: 162567 RVA: 0x0056E09C File Offset: 0x0056C29C
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

		// Token: 0x06027B08 RID: 162568 RVA: 0x0056E0D3 File Offset: 0x0056C2D3
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027B09 RID: 162569 RVA: 0x0056E0E2 File Offset: 0x0056C2E2
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AF87 RID: 44935
		// (get) Token: 0x06027B0A RID: 162570 RVA: 0x0056E0F0 File Offset: 0x0056C2F0
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

		// Token: 0x06027B0B RID: 162571 RVA: 0x0056E12C File Offset: 0x0056C32C
		public TTable? AttachTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027B0C RID: 162572 RVA: 0x0056E174 File Offset: 0x0056C374
		public IActorAttachTarget AttachTargetAsIActorAttachTarget()
		{
			return this.AttachTarget<IActorAttachTarget>().Value;
		}

		// Token: 0x06027B0D RID: 162573 RVA: 0x0056E190 File Offset: 0x0056C390
		public IEntityAttachTarget AttachTargetAsIEntityAttachTarget()
		{
			return this.AttachTarget<IEntityAttachTarget>().Value;
		}

		// Token: 0x06027B0E RID: 162574 RVA: 0x0056E1AC File Offset: 0x0056C3AC
		public IPointAttachTarget AttachTargetAsIPointAttachTarget()
		{
			return this.AttachTarget<IPointAttachTarget>().Value;
		}

		// Token: 0x06027B0F RID: 162575 RVA: 0x0056E1C8 File Offset: 0x0056C3C8
		public IDynamicAttachTarget AttachTargetAsIDynamicAttachTarget()
		{
			return this.AttachTarget<IDynamicAttachTarget>().Value;
		}

		// Token: 0x06027B10 RID: 162576 RVA: 0x0056E1E4 File Offset: 0x0056C3E4
		public IPlayerAttachTarget AttachTargetAsIPlayerAttachTarget()
		{
			return this.AttachTarget<IPlayerAttachTarget>().Value;
		}

		// Token: 0x1700AF88 RID: 44936
		// (get) Token: 0x06027B11 RID: 162577 RVA: 0x0056E200 File Offset: 0x0056C400
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

		// Token: 0x1700AF89 RID: 44937
		// (get) Token: 0x06027B12 RID: 162578 RVA: 0x0056E260 File Offset: 0x0056C460
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

		// Token: 0x1700AF8A RID: 44938
		// (get) Token: 0x06027B13 RID: 162579 RVA: 0x0056E2A4 File Offset: 0x0056C4A4
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

		// Token: 0x06027B14 RID: 162580 RVA: 0x0056E2E4 File Offset: 0x0056C4E4
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

		// Token: 0x06027B15 RID: 162581 RVA: 0x0056E333 File Offset: 0x0056C533
		public static void StartIPhysicsConstraintComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06027B16 RID: 162582 RVA: 0x0056E33C File Offset: 0x0056C53C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027B17 RID: 162583 RVA: 0x0056E347 File Offset: 0x0056C547
		public static void AddEffectPath(FlatBufferBuilder builder, StringOffset effectPathOffset)
		{
			builder.AddOffset(1, effectPathOffset.Value, 0);
		}

		// Token: 0x06027B18 RID: 162584 RVA: 0x0056E357 File Offset: 0x0056C557
		public static void AddAttachTargetType(FlatBufferBuilder builder, TPhysicsAttachTarget attachTargetType)
		{
			builder.AddByte(2, (byte)attachTargetType, 0);
		}

		// Token: 0x06027B19 RID: 162585 RVA: 0x0056E362 File Offset: 0x0056C562
		public static void AddAttachTarget(FlatBufferBuilder builder, int attachTargetOffset)
		{
			builder.AddOffset(3, attachTargetOffset, 0);
		}

		// Token: 0x06027B1A RID: 162586 RVA: 0x0056E36D File Offset: 0x0056C56D
		public static void AddAngularLimit(FlatBufferBuilder builder, Offset<IPhysicsAngularLimit> angularLimitOffset)
		{
			builder.AddOffset(4, angularLimitOffset.Value, 0);
		}

		// Token: 0x06027B1B RID: 162587 RVA: 0x0056E37D File Offset: 0x0056C57D
		public static void AddDampingCoefficient(FlatBufferBuilder builder, float dampingCoefficient)
		{
			builder.AddFloat(5, dampingCoefficient, 0.0);
		}

		// Token: 0x06027B1C RID: 162588 RVA: 0x0056E390 File Offset: 0x0056C590
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06027B1D RID: 162589 RVA: 0x0056E39B File Offset: 0x0056C59B
		public static Offset<IPhysicsConstraintComponent> EndIPhysicsConstraintComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPhysicsConstraintComponent>(builder.EndTable());
		}

		// Token: 0x06027B1E RID: 162590 RVA: 0x0056E3A8 File Offset: 0x0056C5A8
		public IPhysicsConstraintComponentT UnPack()
		{
			IPhysicsConstraintComponentT physicsConstraintComponentT = new IPhysicsConstraintComponentT();
			this.UnPackTo(physicsConstraintComponentT);
			return physicsConstraintComponentT;
		}

		// Token: 0x06027B1F RID: 162591 RVA: 0x0056E3C4 File Offset: 0x0056C5C4
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

		// Token: 0x06027B20 RID: 162592 RVA: 0x0056E594 File Offset: 0x0056C794
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

		// Token: 0x0400F89E RID: 63646
		private Table __p;
	}
}
