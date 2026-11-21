using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D70 RID: 28016
	public struct IEntityTurnTo : IFlatbufferObject
	{
		// Token: 0x1700CD89 RID: 52617
		// (get) Token: 0x06030566 RID: 197990 RVA: 0x006917ED File Offset: 0x0068F9ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030567 RID: 197991 RVA: 0x006917FA File Offset: 0x0068F9FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030568 RID: 197992 RVA: 0x00691804 File Offset: 0x0068FA04
		public static IEntityTurnTo GetRootAsIEntityTurnTo(ByteBuffer _bb)
		{
			return IEntityTurnTo.GetRootAsIEntityTurnTo(_bb, default(IEntityTurnTo));
		}

		// Token: 0x06030569 RID: 197993 RVA: 0x00691820 File Offset: 0x0068FA20
		public static IEntityTurnTo GetRootAsIEntityTurnTo(ByteBuffer _bb, IEntityTurnTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603056A RID: 197994 RVA: 0x0069183D File Offset: 0x0068FA3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603056B RID: 197995 RVA: 0x0069184C File Offset: 0x0068FA4C
		public IEntityTurnTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD8A RID: 52618
		// (get) Token: 0x0603056C RID: 197996 RVA: 0x0069185C File Offset: 0x0068FA5C
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

		// Token: 0x1700CD8B RID: 52619
		// (get) Token: 0x0603056D RID: 197997 RVA: 0x00691898 File Offset: 0x0068FA98
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

		// Token: 0x0603056E RID: 197998 RVA: 0x006918D4 File Offset: 0x0068FAD4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603056F RID: 197999 RVA: 0x00691918 File Offset: 0x0068FB18
		public IActorTurnToEmptyData TargetAsIActorTurnToEmptyData()
		{
			return this.Target<IActorTurnToEmptyData>().Value;
		}

		// Token: 0x06030570 RID: 198000 RVA: 0x00691934 File Offset: 0x0068FB34
		public IActorTurnToEntityData TargetAsIActorTurnToEntityData()
		{
			return this.Target<IActorTurnToEntityData>().Value;
		}

		// Token: 0x06030571 RID: 198001 RVA: 0x00691950 File Offset: 0x0068FB50
		public IActorTurnToPlayerData TargetAsIActorTurnToPlayerData()
		{
			return this.Target<IActorTurnToPlayerData>().Value;
		}

		// Token: 0x06030572 RID: 198002 RVA: 0x0069196C File Offset: 0x0068FB6C
		public IActorTurnToPositionData TargetAsIActorTurnToPositionData()
		{
			return this.Target<IActorTurnToPositionData>().Value;
		}

		// Token: 0x06030573 RID: 198003 RVA: 0x00691988 File Offset: 0x0068FB88
		public IActorTurnToTalkerData TargetAsIActorTurnToTalkerData()
		{
			return this.Target<IActorTurnToTalkerData>().Value;
		}

		// Token: 0x1700CD8C RID: 52620
		// (get) Token: 0x06030574 RID: 198004 RVA: 0x006919A4 File Offset: 0x0068FBA4
		public bool UseLookAtForSmallAngle
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CD8D RID: 52621
		// (get) Token: 0x06030575 RID: 198005 RVA: 0x006919E4 File Offset: 0x0068FBE4
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

		// Token: 0x06030576 RID: 198006 RVA: 0x00691A21 File Offset: 0x0068FC21
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

		// Token: 0x06030577 RID: 198007 RVA: 0x00691A55 File Offset: 0x0068FC55
		public static void StartIEntityTurnTo(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030578 RID: 198008 RVA: 0x00691A5E File Offset: 0x0068FC5E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06030579 RID: 198009 RVA: 0x00691A69 File Offset: 0x0068FC69
		public static void AddTargetType(FlatBufferBuilder builder, TActorTurnToData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0603057A RID: 198010 RVA: 0x00691A74 File Offset: 0x0068FC74
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0603057B RID: 198011 RVA: 0x00691A7F File Offset: 0x0068FC7F
		public static void AddUseLookAtForSmallAngle(FlatBufferBuilder builder, bool useLookAtForSmallAngle)
		{
			builder.AddBool(3, useLookAtForSmallAngle, false);
		}

		// Token: 0x0603057C RID: 198012 RVA: 0x00691A8A File Offset: 0x0068FC8A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603057D RID: 198013 RVA: 0x00691A95 File Offset: 0x0068FC95
		public static Offset<IEntityTurnTo> EndIEntityTurnTo(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTurnTo>(builder.EndTable());
		}

		// Token: 0x0603057E RID: 198014 RVA: 0x00691AA4 File Offset: 0x0068FCA4
		public IEntityTurnToT UnPack()
		{
			IEntityTurnToT entityTurnToT = new IEntityTurnToT();
			this.UnPackTo(entityTurnToT);
			return entityTurnToT;
		}

		// Token: 0x0603057F RID: 198015 RVA: 0x00691AC0 File Offset: 0x0068FCC0
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

		// Token: 0x06030580 RID: 198016 RVA: 0x00691C54 File Offset: 0x0068FE54
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

		// Token: 0x04011BF3 RID: 72691
		private Table __p;
	}
}
