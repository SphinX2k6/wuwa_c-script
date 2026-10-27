using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F0 RID: 26352
	public struct IEntityTurnTo : IFlatbufferObject
	{
		// Token: 0x1700C3D3 RID: 50131
		// (get) Token: 0x0602DD29 RID: 187689 RVA: 0x00644279 File Offset: 0x00642479
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD2A RID: 187690 RVA: 0x00644286 File Offset: 0x00642486
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD2B RID: 187691 RVA: 0x00644290 File Offset: 0x00642490
		public static IEntityTurnTo GetRootAsIEntityTurnTo(ByteBuffer _bb)
		{
			return IEntityTurnTo.GetRootAsIEntityTurnTo(_bb, default(IEntityTurnTo));
		}

		// Token: 0x0602DD2C RID: 187692 RVA: 0x006442AC File Offset: 0x006424AC
		public static IEntityTurnTo GetRootAsIEntityTurnTo(ByteBuffer _bb, IEntityTurnTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD2D RID: 187693 RVA: 0x006442C9 File Offset: 0x006424C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD2E RID: 187694 RVA: 0x006442D8 File Offset: 0x006424D8
		public IEntityTurnTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3D4 RID: 50132
		// (get) Token: 0x0602DD2F RID: 187695 RVA: 0x006442E8 File Offset: 0x006424E8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3D5 RID: 50133
		// (get) Token: 0x0602DD30 RID: 187696 RVA: 0x00644324 File Offset: 0x00642524
		public TActorTurnToData TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TActorTurnToData.NONE;
				}
				return (TActorTurnToData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DD31 RID: 187697 RVA: 0x00644360 File Offset: 0x00642560
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DD32 RID: 187698 RVA: 0x006443A4 File Offset: 0x006425A4
		public IActorTurnToEmptyData TargetAsIActorTurnToEmptyData()
		{
			return this.Target<IActorTurnToEmptyData>().Value;
		}

		// Token: 0x0602DD33 RID: 187699 RVA: 0x006443C0 File Offset: 0x006425C0
		public IActorTurnToEntityData TargetAsIActorTurnToEntityData()
		{
			return this.Target<IActorTurnToEntityData>().Value;
		}

		// Token: 0x0602DD34 RID: 187700 RVA: 0x006443DC File Offset: 0x006425DC
		public IActorTurnToPlayerData TargetAsIActorTurnToPlayerData()
		{
			return this.Target<IActorTurnToPlayerData>().Value;
		}

		// Token: 0x0602DD35 RID: 187701 RVA: 0x006443F8 File Offset: 0x006425F8
		public IActorTurnToPositionData TargetAsIActorTurnToPositionData()
		{
			return this.Target<IActorTurnToPositionData>().Value;
		}

		// Token: 0x0602DD36 RID: 187702 RVA: 0x00644414 File Offset: 0x00642614
		public IActorTurnToTalkerData TargetAsIActorTurnToTalkerData()
		{
			return this.Target<IActorTurnToTalkerData>().Value;
		}

		// Token: 0x1700C3D6 RID: 50134
		// (get) Token: 0x0602DD37 RID: 187703 RVA: 0x00644430 File Offset: 0x00642630
		public bool UseLookAtForSmallAngle
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C3D7 RID: 50135
		// (get) Token: 0x0602DD38 RID: 187704 RVA: 0x00644470 File Offset: 0x00642670
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DD39 RID: 187705 RVA: 0x006444AD File Offset: 0x006426AD
		public static Offset<IEntityTurnTo> CreateIEntityTurnTo(FlatBufferBuilder builder, int EntityId = 0, TActorTurnToData Target_type = TActorTurnToData.NONE, int TargetOffset = 0, bool UseLookAtForSmallAngle = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityTurnTo.AddTarget(builder, TargetOffset);
			IEntityTurnTo.AddEntityId(builder, EntityId);
			IEntityTurnTo.AddNullMask(builder, NullMask);
			IEntityTurnTo.AddUseLookAtForSmallAngle(builder, UseLookAtForSmallAngle);
			IEntityTurnTo.AddTargetType(builder, Target_type);
			return IEntityTurnTo.EndIEntityTurnTo(builder);
		}

		// Token: 0x0602DD3A RID: 187706 RVA: 0x006444E1 File Offset: 0x006426E1
		public static void StartIEntityTurnTo(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DD3B RID: 187707 RVA: 0x006444EA File Offset: 0x006426EA
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602DD3C RID: 187708 RVA: 0x006444F5 File Offset: 0x006426F5
		public static void AddTargetType(FlatBufferBuilder builder, TActorTurnToData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602DD3D RID: 187709 RVA: 0x00644500 File Offset: 0x00642700
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602DD3E RID: 187710 RVA: 0x0064450B File Offset: 0x0064270B
		public static void AddUseLookAtForSmallAngle(FlatBufferBuilder builder, bool useLookAtForSmallAngle)
		{
			builder.AddBool(3, useLookAtForSmallAngle, false);
		}

		// Token: 0x0602DD3F RID: 187711 RVA: 0x00644516 File Offset: 0x00642716
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DD40 RID: 187712 RVA: 0x00644521 File Offset: 0x00642721
		public static Offset<IEntityTurnTo> EndIEntityTurnTo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTurnTo>(builder.EndTable());
		}

		// Token: 0x0602DD41 RID: 187713 RVA: 0x00644530 File Offset: 0x00642730
		public IEntityTurnToT UnPack()
		{
			IEntityTurnToT entityTurnToT = new IEntityTurnToT();
			this.UnPackTo(entityTurnToT);
			return entityTurnToT;
		}

		// Token: 0x0602DD42 RID: 187714 RVA: 0x0064454C File Offset: 0x0064274C
		public void UnPackTo(IEntityTurnToT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Target = new TActorTurnToDataUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TActorTurnToData.IActorTurnToEmptyData:
				_o.Target.Value = ((this.Target<IActorTurnToEmptyData>() != null) ? this.Target<IActorTurnToEmptyData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToEntityData:
				_o.Target.Value = ((this.Target<IActorTurnToEntityData>() != null) ? this.Target<IActorTurnToEntityData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToPlayerData:
				_o.Target.Value = ((this.Target<IActorTurnToPlayerData>() != null) ? this.Target<IActorTurnToPlayerData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToPositionData:
				_o.Target.Value = ((this.Target<IActorTurnToPositionData>() != null) ? this.Target<IActorTurnToPositionData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToTalkerData:
				_o.Target.Value = ((this.Target<IActorTurnToTalkerData>() != null) ? this.Target<IActorTurnToTalkerData>().Value.UnPack() : null);
				break;
			}
			_o.UseLookAtForSmallAngle = this.UseLookAtForSmallAngle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DD43 RID: 187715 RVA: 0x006446E0 File Offset: 0x006428E0
		public static Offset<IEntityTurnTo> Pack(FlatBufferBuilder builder, IEntityTurnToT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTurnTo>);
			}
			TActorTurnToData target_type = (_o.Target == null) ? TActorTurnToData.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TActorTurnToDataUnion.Pack(builder, _o.Target);
			return IEntityTurnTo.CreateIEntityTurnTo(builder, _o.EntityId, target_type, targetOffset, _o.UseLookAtForSmallAngle, _o.NullMask);
		}

		// Token: 0x04010DC4 RID: 69060
		private Table __p;
	}
}
