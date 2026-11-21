using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200771D RID: 30493
	public struct ISelfVehicle : IFlatbufferObject
	{
		// Token: 0x1700DF97 RID: 57239
		// (get) Token: 0x060357FB RID: 219131 RVA: 0x0072C1A5 File Offset: 0x0072A3A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060357FC RID: 219132 RVA: 0x0072C1B2 File Offset: 0x0072A3B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060357FD RID: 219133 RVA: 0x0072C1BC File Offset: 0x0072A3BC
		public static ISelfVehicle GetRootAsISelfVehicle(ByteBuffer _bb)
		{
			return ISelfVehicle.GetRootAsISelfVehicle(_bb, default(ISelfVehicle));
		}

		// Token: 0x060357FE RID: 219134 RVA: 0x0072C1D8 File Offset: 0x0072A3D8
		public static ISelfVehicle GetRootAsISelfVehicle(ByteBuffer _bb, ISelfVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060357FF RID: 219135 RVA: 0x0072C1F5 File Offset: 0x0072A3F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035800 RID: 219136 RVA: 0x0072C204 File Offset: 0x0072A404
		public ISelfVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF98 RID: 57240
		// (get) Token: 0x06035801 RID: 219137 RVA: 0x0072C214 File Offset: 0x0072A414
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035802 RID: 219138 RVA: 0x0072C250 File Offset: 0x0072A450
		public static Offset<ISelfVehicle> CreateISelfVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ISelfVehicle.AddType(builder, Type);
			return ISelfVehicle.EndISelfVehicle(builder);
		}

		// Token: 0x06035803 RID: 219139 RVA: 0x0072C266 File Offset: 0x0072A466
		public static void StartISelfVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035804 RID: 219140 RVA: 0x0072C26F File Offset: 0x0072A46F
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035805 RID: 219141 RVA: 0x0072C27A File Offset: 0x0072A47A
		public static Offset<ISelfVehicle> EndISelfVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ISelfVehicle>(builder.EndTable());
		}

		// Token: 0x06035806 RID: 219142 RVA: 0x0072C288 File Offset: 0x0072A488
		public ISelfVehicleT UnPack()
		{
			ISelfVehicleT selfVehicleT = new ISelfVehicleT();
			this.UnPackTo(selfVehicleT);
			return selfVehicleT;
		}

		// Token: 0x06035807 RID: 219143 RVA: 0x0072C2A3 File Offset: 0x0072A4A3
		public void UnPackTo(ISelfVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035808 RID: 219144 RVA: 0x0072C2B4 File Offset: 0x0072A4B4
		public static Offset<ISelfVehicle> Pack(FlatBufferBuilder builder, ISelfVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfVehicle>);
			}
			return ISelfVehicle.CreateISelfVehicle(builder, _o.Type);
		}

		// Token: 0x04012933 RID: 76083
		private Table __p;
	}
}
