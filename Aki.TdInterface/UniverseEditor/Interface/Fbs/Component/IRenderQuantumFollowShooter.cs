using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E53 RID: 24147
	public struct IRenderQuantumFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700B20D RID: 45581
		// (get) Token: 0x060285C7 RID: 165319 RVA: 0x00584C4E File Offset: 0x00582E4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060285C8 RID: 165320 RVA: 0x00584C5B File Offset: 0x00582E5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060285C9 RID: 165321 RVA: 0x00584C64 File Offset: 0x00582E64
		public static IRenderQuantumFollowShooter GetRootAsIRenderQuantumFollowShooter(ByteBuffer _bb)
		{
			return IRenderQuantumFollowShooter.GetRootAsIRenderQuantumFollowShooter(_bb, default(IRenderQuantumFollowShooter));
		}

		// Token: 0x060285CA RID: 165322 RVA: 0x00584C80 File Offset: 0x00582E80
		public static IRenderQuantumFollowShooter GetRootAsIRenderQuantumFollowShooter(ByteBuffer _bb, IRenderQuantumFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060285CB RID: 165323 RVA: 0x00584C9D File Offset: 0x00582E9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060285CC RID: 165324 RVA: 0x00584CAC File Offset: 0x00582EAC
		public IRenderQuantumFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B20E RID: 45582
		// (get) Token: 0x060285CD RID: 165325 RVA: 0x00584CBC File Offset: 0x00582EBC
		public ERenderSpecifiedRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return (ERenderSpecifiedRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B20F RID: 45583
		// (get) Token: 0x060285CE RID: 165326 RVA: 0x00584CF8 File Offset: 0x00582EF8
		public TTargetEntity CenterTargetType
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

		// Token: 0x060285CF RID: 165327 RVA: 0x00584D34 File Offset: 0x00582F34
		public TTable? CenterTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060285D0 RID: 165328 RVA: 0x00584D78 File Offset: 0x00582F78
		public IPlayerEntity CenterTargetAsIPlayerEntity()
		{
			return this.CenterTarget<IPlayerEntity>().Value;
		}

		// Token: 0x060285D1 RID: 165329 RVA: 0x00584D94 File Offset: 0x00582F94
		public ISelfEntity CenterTargetAsISelfEntity()
		{
			return this.CenterTarget<ISelfEntity>().Value;
		}

		// Token: 0x060285D2 RID: 165330 RVA: 0x00584DB0 File Offset: 0x00582FB0
		public ITargetEntity CenterTargetAsITargetEntity()
		{
			return this.CenterTarget<ITargetEntity>().Value;
		}

		// Token: 0x060285D3 RID: 165331 RVA: 0x00584DCC File Offset: 0x00582FCC
		public ITriggeredEntity CenterTargetAsITriggeredEntity()
		{
			return this.CenterTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x060285D4 RID: 165332 RVA: 0x00584DE8 File Offset: 0x00582FE8
		public IVehicleEntity CenterTargetAsIVehicleEntity()
		{
			return this.CenterTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700B210 RID: 45584
		// (get) Token: 0x060285D5 RID: 165333 RVA: 0x00584E04 File Offset: 0x00583004
		public IVectorInfo? Center
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

		// Token: 0x1700B211 RID: 45585
		// (get) Token: 0x060285D6 RID: 165334 RVA: 0x00584E64 File Offset: 0x00583064
		public IVectorInfo? Size
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

		// Token: 0x1700B212 RID: 45586
		// (get) Token: 0x060285D7 RID: 165335 RVA: 0x00584EC4 File Offset: 0x005830C4
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060285D8 RID: 165336 RVA: 0x00584F22 File Offset: 0x00583122
		public static Offset<IRenderQuantumFollowShooter> CreateIRenderQuantumFollowShooter(FlatBufferBuilder builder, ERenderSpecifiedRangeType Type = ERenderSpecifiedRangeType.FlowerBridge, TTargetEntity CenterTarget_type = TTargetEntity.NONE, int CenterTargetOffset = 0, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(6);
			IRenderQuantumFollowShooter.AddRotator(builder, RotatorOffset);
			IRenderQuantumFollowShooter.AddSize(builder, SizeOffset);
			IRenderQuantumFollowShooter.AddCenter(builder, CenterOffset);
			IRenderQuantumFollowShooter.AddCenterTarget(builder, CenterTargetOffset);
			IRenderQuantumFollowShooter.AddCenterTargetType(builder, CenterTarget_type);
			IRenderQuantumFollowShooter.AddType(builder, Type);
			return IRenderQuantumFollowShooter.EndIRenderQuantumFollowShooter(builder);
		}

		// Token: 0x060285D9 RID: 165337 RVA: 0x00584F5E File Offset: 0x0058315E
		public static void StartIRenderQuantumFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060285DA RID: 165338 RVA: 0x00584F67 File Offset: 0x00583167
		public static void AddType(FlatBufferBuilder builder, ERenderSpecifiedRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060285DB RID: 165339 RVA: 0x00584F72 File Offset: 0x00583172
		public static void AddCenterTargetType(FlatBufferBuilder builder, TTargetEntity centerTargetType)
		{
			builder.AddByte(1, (byte)centerTargetType, 0);
		}

		// Token: 0x060285DC RID: 165340 RVA: 0x00584F7D File Offset: 0x0058317D
		public static void AddCenterTarget(FlatBufferBuilder builder, int centerTargetOffset)
		{
			builder.AddOffset(2, centerTargetOffset, 0);
		}

		// Token: 0x060285DD RID: 165341 RVA: 0x00584F88 File Offset: 0x00583188
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(3, centerOffset.Value, 0);
		}

		// Token: 0x060285DE RID: 165342 RVA: 0x00584F98 File Offset: 0x00583198
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(4, sizeOffset.Value, 0);
		}

		// Token: 0x060285DF RID: 165343 RVA: 0x00584FA8 File Offset: 0x005831A8
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(5, rotatorOffset.Value, 0);
		}

		// Token: 0x060285E0 RID: 165344 RVA: 0x00584FB8 File Offset: 0x005831B8
		public static Offset<IRenderQuantumFollowShooter> EndIRenderQuantumFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IRenderQuantumFollowShooter>(builder.EndTable());
		}

		// Token: 0x060285E1 RID: 165345 RVA: 0x00584FC8 File Offset: 0x005831C8
		public IRenderQuantumFollowShooterT UnPack()
		{
			IRenderQuantumFollowShooterT renderQuantumFollowShooterT = new IRenderQuantumFollowShooterT();
			this.UnPackTo(renderQuantumFollowShooterT);
			return renderQuantumFollowShooterT;
		}

		// Token: 0x060285E2 RID: 165346 RVA: 0x00584FE4 File Offset: 0x005831E4
		public void UnPackTo(IRenderQuantumFollowShooterT _o)
		{
			_o.Type = this.Type;
			_o.CenterTarget = new TTargetEntityUnion();
			_o.CenterTarget.Type = this.CenterTargetType;
			switch (this.CenterTargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IPlayerEntity>() != null) ? this.CenterTarget<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ISelfEntity>() != null) ? this.CenterTarget<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITargetEntity>() != null) ? this.CenterTarget<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<ITriggeredEntity>() != null) ? this.CenterTarget<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.CenterTarget.Value = ((this.CenterTarget<IVehicleEntity>() != null) ? this.CenterTarget<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x060285E3 RID: 165347 RVA: 0x005851F4 File Offset: 0x005833F4
		public static Offset<IRenderQuantumFollowShooter> Pack(FlatBufferBuilder builder, IRenderQuantumFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenderQuantumFollowShooter>);
			}
			TTargetEntity centerTarget_type = (_o.CenterTarget == null) ? TTargetEntity.NONE : _o.CenterTarget.Type;
			int centerTargetOffset = (_o.CenterTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CenterTarget);
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IRenderQuantumFollowShooter.CreateIRenderQuantumFollowShooter(builder, _o.Type, centerTarget_type, centerTargetOffset, centerOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400FA5A RID: 64090
		private Table __p;
	}
}
