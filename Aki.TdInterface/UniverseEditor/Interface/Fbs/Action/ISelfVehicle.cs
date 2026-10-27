using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5A RID: 28506
	public struct ISelfVehicle : IFlatbufferObject
	{
		// Token: 0x1700D3CB RID: 54219
		// (get) Token: 0x060325BD RID: 206269 RVA: 0x006CC965 File Offset: 0x006CAB65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325BE RID: 206270 RVA: 0x006CC972 File Offset: 0x006CAB72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060325BF RID: 206271 RVA: 0x006CC97C File Offset: 0x006CAB7C
		public static ISelfVehicle GetRootAsISelfVehicle(ByteBuffer _bb)
		{
			return ISelfVehicle.GetRootAsISelfVehicle(_bb, default(ISelfVehicle));
		}

		// Token: 0x060325C0 RID: 206272 RVA: 0x006CC998 File Offset: 0x006CAB98
		public static ISelfVehicle GetRootAsISelfVehicle(ByteBuffer _bb, ISelfVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060325C1 RID: 206273 RVA: 0x006CC9B5 File Offset: 0x006CABB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060325C2 RID: 206274 RVA: 0x006CC9C4 File Offset: 0x006CABC4
		public ISelfVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3CC RID: 54220
		// (get) Token: 0x060325C3 RID: 206275 RVA: 0x006CC9D4 File Offset: 0x006CABD4
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

		// Token: 0x060325C4 RID: 206276 RVA: 0x006CCA10 File Offset: 0x006CAC10
		public static Offset<ISelfVehicle> CreateISelfVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ISelfVehicle.AddType(builder, Type);
			return ISelfVehicle.EndISelfVehicle(builder);
		}

		// Token: 0x060325C5 RID: 206277 RVA: 0x006CCA26 File Offset: 0x006CAC26
		public static void StartISelfVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060325C6 RID: 206278 RVA: 0x006CCA2F File Offset: 0x006CAC2F
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325C7 RID: 206279 RVA: 0x006CCA3A File Offset: 0x006CAC3A
		public static Offset<ISelfVehicle> EndISelfVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ISelfVehicle>(builder.EndTable());
		}

		// Token: 0x060325C8 RID: 206280 RVA: 0x006CCA48 File Offset: 0x006CAC48
		public ISelfVehicleT UnPack()
		{
			ISelfVehicleT selfVehicleT = new ISelfVehicleT();
			this.UnPackTo(selfVehicleT);
			return selfVehicleT;
		}

		// Token: 0x060325C9 RID: 206281 RVA: 0x006CCA63 File Offset: 0x006CAC63
		public void UnPackTo(ISelfVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060325CA RID: 206282 RVA: 0x006CCA74 File Offset: 0x006CAC74
		public static Offset<ISelfVehicle> Pack(FlatBufferBuilder builder, ISelfVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfVehicle>);
			}
			return ISelfVehicle.CreateISelfVehicle(builder, _o.Type);
		}

		// Token: 0x04011953 RID: 72019
		private Table __p;
	}
}
