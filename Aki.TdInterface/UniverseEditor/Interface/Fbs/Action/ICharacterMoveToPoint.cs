using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C3 RID: 27075
	public struct ICharacterMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700C738 RID: 51000
		// (get) Token: 0x0602E712 RID: 190226 RVA: 0x00656331 File Offset: 0x00654531
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E713 RID: 190227 RVA: 0x0065633E File Offset: 0x0065453E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E714 RID: 190228 RVA: 0x00656348 File Offset: 0x00654548
		public static ICharacterMoveToPoint GetRootAsICharacterMoveToPoint(ByteBuffer _bb)
		{
			return ICharacterMoveToPoint.GetRootAsICharacterMoveToPoint(_bb, default(ICharacterMoveToPoint));
		}

		// Token: 0x0602E715 RID: 190229 RVA: 0x00656364 File Offset: 0x00654564
		public static ICharacterMoveToPoint GetRootAsICharacterMoveToPoint(ByteBuffer _bb, ICharacterMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E716 RID: 190230 RVA: 0x00656381 File Offset: 0x00654581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E717 RID: 190231 RVA: 0x00656390 File Offset: 0x00654590
		public ICharacterMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C739 RID: 51001
		// (get) Token: 0x0602E718 RID: 190232 RVA: 0x006563A0 File Offset: 0x006545A0
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

		// Token: 0x0602E719 RID: 190233 RVA: 0x006563DC File Offset: 0x006545DC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E71A RID: 190234 RVA: 0x00656420 File Offset: 0x00654620
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602E71B RID: 190235 RVA: 0x0065643C File Offset: 0x0065463C
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602E71C RID: 190236 RVA: 0x00656458 File Offset: 0x00654658
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602E71D RID: 190237 RVA: 0x00656474 File Offset: 0x00654674
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602E71E RID: 190238 RVA: 0x00656490 File Offset: 0x00654690
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700C73A RID: 51002
		// (get) Token: 0x0602E71F RID: 190239 RVA: 0x006564AC File Offset: 0x006546AC
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

		// Token: 0x1700C73B RID: 51003
		// (get) Token: 0x0602E720 RID: 190240 RVA: 0x0065650C File Offset: 0x0065470C
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

		// Token: 0x0602E721 RID: 190241 RVA: 0x00656549 File Offset: 0x00654749
		public static Offset<ICharacterMoveToPoint> CreateICharacterMoveToPoint(FlatBufferBuilder builder, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), ECharacterMoveToPointType MoveType = ECharacterMoveToPointType.Walk)
		{
			builder.StartTable(4);
			ICharacterMoveToPoint.AddPos(builder, PosOffset);
			ICharacterMoveToPoint.AddTarget(builder, TargetOffset);
			ICharacterMoveToPoint.AddMoveType(builder, MoveType);
			ICharacterMoveToPoint.AddTargetType(builder, Target_type);
			return ICharacterMoveToPoint.EndICharacterMoveToPoint(builder);
		}

		// Token: 0x0602E722 RID: 190242 RVA: 0x00656575 File Offset: 0x00654775
		public static void StartICharacterMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E723 RID: 190243 RVA: 0x0065657E File Offset: 0x0065477E
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(0, (byte)targetType, 0);
		}

		// Token: 0x0602E724 RID: 190244 RVA: 0x00656589 File Offset: 0x00654789
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(1, targetOffset, 0);
		}

		// Token: 0x0602E725 RID: 190245 RVA: 0x00656594 File Offset: 0x00654794
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0602E726 RID: 190246 RVA: 0x006565A4 File Offset: 0x006547A4
		public static void AddMoveType(FlatBufferBuilder builder, ECharacterMoveToPointType moveType)
		{
			builder.AddByte(3, (byte)moveType, 0);
		}

		// Token: 0x0602E727 RID: 190247 RVA: 0x006565AF File Offset: 0x006547AF
		public static Offset<ICharacterMoveToPoint> EndICharacterMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<ICharacterMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0602E728 RID: 190248 RVA: 0x006565BC File Offset: 0x006547BC
		public ICharacterMoveToPointT UnPack()
		{
			ICharacterMoveToPointT characterMoveToPointT = new ICharacterMoveToPointT();
			this.UnPackTo(characterMoveToPointT);
			return characterMoveToPointT;
		}

		// Token: 0x0602E729 RID: 190249 RVA: 0x006565D8 File Offset: 0x006547D8
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

		// Token: 0x0602E72A RID: 190250 RVA: 0x00656784 File Offset: 0x00654984
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

		// Token: 0x04011731 RID: 71473
		private Table __p;
	}
}
