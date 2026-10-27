using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED0 RID: 28368
	public struct IRideMotorcycleInteract : IFlatbufferObject
	{
		// Token: 0x1700D31B RID: 54043
		// (get) Token: 0x06032223 RID: 205347 RVA: 0x006C6ED8 File Offset: 0x006C50D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032224 RID: 205348 RVA: 0x006C6EE5 File Offset: 0x006C50E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032225 RID: 205349 RVA: 0x006C6EEC File Offset: 0x006C50EC
		public static IRideMotorcycleInteract GetRootAsIRideMotorcycleInteract(ByteBuffer _bb)
		{
			return IRideMotorcycleInteract.GetRootAsIRideMotorcycleInteract(_bb, default(IRideMotorcycleInteract));
		}

		// Token: 0x06032226 RID: 205350 RVA: 0x006C6F08 File Offset: 0x006C5108
		public static IRideMotorcycleInteract GetRootAsIRideMotorcycleInteract(ByteBuffer _bb, IRideMotorcycleInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032227 RID: 205351 RVA: 0x006C6F25 File Offset: 0x006C5125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032228 RID: 205352 RVA: 0x006C6F34 File Offset: 0x006C5134
		public IRideMotorcycleInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D31C RID: 54044
		// (get) Token: 0x06032229 RID: 205353 RVA: 0x006C6F44 File Offset: 0x006C5144
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D31D RID: 54045
		// (get) Token: 0x0603222A RID: 205354 RVA: 0x006C6F80 File Offset: 0x006C5180
		public int MotorcycleEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603222B RID: 205355 RVA: 0x006C6FBC File Offset: 0x006C51BC
		public static Offset<IRideMotorcycleInteract> CreateIRideMotorcycleInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int MotorcycleEntityId = 0)
		{
			builder.StartTable(2);
			IRideMotorcycleInteract.AddMotorcycleEntityId(builder, MotorcycleEntityId);
			IRideMotorcycleInteract.AddType(builder, Type);
			return IRideMotorcycleInteract.EndIRideMotorcycleInteract(builder);
		}

		// Token: 0x0603222C RID: 205356 RVA: 0x006C6FD9 File Offset: 0x006C51D9
		public static void StartIRideMotorcycleInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603222D RID: 205357 RVA: 0x006C6FE2 File Offset: 0x006C51E2
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603222E RID: 205358 RVA: 0x006C6FED File Offset: 0x006C51ED
		public static void AddMotorcycleEntityId(FlatBufferBuilder builder, int motorcycleEntityId)
		{
			builder.AddInt(1, motorcycleEntityId, 0);
		}

		// Token: 0x0603222F RID: 205359 RVA: 0x006C6FF8 File Offset: 0x006C51F8
		public static Offset<IRideMotorcycleInteract> EndIRideMotorcycleInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRideMotorcycleInteract>(builder.EndTable());
		}

		// Token: 0x06032230 RID: 205360 RVA: 0x006C7008 File Offset: 0x006C5208
		public IRideMotorcycleInteractT UnPack()
		{
			IRideMotorcycleInteractT rideMotorcycleInteractT = new IRideMotorcycleInteractT();
			this.UnPackTo(rideMotorcycleInteractT);
			return rideMotorcycleInteractT;
		}

		// Token: 0x06032231 RID: 205361 RVA: 0x006C7023 File Offset: 0x006C5223
		public void UnPackTo(IRideMotorcycleInteractT _o)
		{
			_o.Type = this.Type;
			_o.MotorcycleEntityId = this.MotorcycleEntityId;
		}

		// Token: 0x06032232 RID: 205362 RVA: 0x006C7040 File Offset: 0x006C5240
		public static Offset<IRideMotorcycleInteract> Pack(FlatBufferBuilder builder, IRideMotorcycleInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRideMotorcycleInteract>);
			}
			return IRideMotorcycleInteract.CreateIRideMotorcycleInteract(builder, _o.Type, _o.MotorcycleEntityId);
		}

		// Token: 0x040118C4 RID: 71876
		private Table __p;
	}
}
