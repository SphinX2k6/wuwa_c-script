using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006352 RID: 25426
	public struct ICharacterMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700BDB0 RID: 48560
		// (get) Token: 0x0602BFA8 RID: 180136 RVA: 0x0060B1DD File Offset: 0x006093DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BFA9 RID: 180137 RVA: 0x0060B1EA File Offset: 0x006093EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BFAA RID: 180138 RVA: 0x0060B1F4 File Offset: 0x006093F4
		public static ICharacterMoveToPoint GetRootAsICharacterMoveToPoint(ByteBuffer _bb)
		{
			return ICharacterMoveToPoint.GetRootAsICharacterMoveToPoint(_bb, default(ICharacterMoveToPoint));
		}

		// Token: 0x0602BFAB RID: 180139 RVA: 0x0060B210 File Offset: 0x00609410
		public static ICharacterMoveToPoint GetRootAsICharacterMoveToPoint(ByteBuffer _bb, ICharacterMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BFAC RID: 180140 RVA: 0x0060B22D File Offset: 0x0060942D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BFAD RID: 180141 RVA: 0x0060B23C File Offset: 0x0060943C
		public ICharacterMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDB1 RID: 48561
		// (get) Token: 0x0602BFAE RID: 180142 RVA: 0x0060B24C File Offset: 0x0060944C
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BFAF RID: 180143 RVA: 0x0060B288 File Offset: 0x00609488
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BFB0 RID: 180144 RVA: 0x0060B2CC File Offset: 0x006094CC
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602BFB1 RID: 180145 RVA: 0x0060B2E8 File Offset: 0x006094E8
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602BFB2 RID: 180146 RVA: 0x0060B304 File Offset: 0x00609504
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602BFB3 RID: 180147 RVA: 0x0060B320 File Offset: 0x00609520
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602BFB4 RID: 180148 RVA: 0x0060B33C File Offset: 0x0060953C
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700BDB2 RID: 48562
		// (get) Token: 0x0602BFB5 RID: 180149 RVA: 0x0060B358 File Offset: 0x00609558
		public IVectorInfo? Pos
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

		// Token: 0x1700BDB3 RID: 48563
		// (get) Token: 0x0602BFB6 RID: 180150 RVA: 0x0060B3B8 File Offset: 0x006095B8
		public ECharacterMoveToPointType MoveType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECharacterMoveToPointType.Walk;
				}
				return (ECharacterMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BFB7 RID: 180151 RVA: 0x0060B3F5 File Offset: 0x006095F5
		public static Offset<ICharacterMoveToPoint> CreateICharacterMoveToPoint(FlatBufferBuilder builder, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), ECharacterMoveToPointType MoveType = ECharacterMoveToPointType.Walk)
		{
			builder.StartTable(4);
			ICharacterMoveToPoint.AddPos(builder, PosOffset);
			ICharacterMoveToPoint.AddTarget(builder, TargetOffset);
			ICharacterMoveToPoint.AddMoveType(builder, MoveType);
			ICharacterMoveToPoint.AddTargetType(builder, Target_type);
			return ICharacterMoveToPoint.EndICharacterMoveToPoint(builder);
		}

		// Token: 0x0602BFB8 RID: 180152 RVA: 0x0060B421 File Offset: 0x00609621
		public static void StartICharacterMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602BFB9 RID: 180153 RVA: 0x0060B42A File Offset: 0x0060962A
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x0602BFBA RID: 180154 RVA: 0x0060B435 File Offset: 0x00609635
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x0602BFBB RID: 180155 RVA: 0x0060B440 File Offset: 0x00609640
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0602BFBC RID: 180156 RVA: 0x0060B450 File Offset: 0x00609650
		public static void AddMoveType(FlatBufferBuilder builder, ECharacterMoveToPointType moveType)
		{
			builder.AddByte(3, (byte)moveType, 0);
		}

		// Token: 0x0602BFBD RID: 180157 RVA: 0x0060B45B File Offset: 0x0060965B
		public static Offset<ICharacterMoveToPoint> EndICharacterMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602BFBE RID: 180158 RVA: 0x0060B468 File Offset: 0x00609668
		public ICharacterMoveToPointT UnPack()
		{
			ICharacterMoveToPointT characterMoveToPointT = new ICharacterMoveToPointT();
			this.UnPackTo(characterMoveToPointT);
			return characterMoveToPointT;
		}

		// Token: 0x0602BFBF RID: 180159 RVA: 0x0060B484 File Offset: 0x00609684
		public void UnPackTo(ICharacterMoveToPointT _o)
		{
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
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.MoveType = this.MoveType;
		}

		// Token: 0x0602BFC0 RID: 180160 RVA: 0x0060B630 File Offset: 0x00609830
		public static Offset<ICharacterMoveToPoint> Pack(FlatBufferBuilder builder, ICharacterMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICharacterMoveToPoint>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICharacterMoveToPoint.CreateICharacterMoveToPoint(builder, target_type, targetOffset, posOffset, _o.MoveType);
		}

		// Token: 0x0401091C RID: 67868
		private Table __p;
	}
}
