using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007238 RID: 29240
	public struct ISummonVehicle : IFlatbufferObject
	{
		// Token: 0x1700D8FA RID: 55546
		// (get) Token: 0x06033DC4 RID: 212420 RVA: 0x006FA442 File Offset: 0x006F8642
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033DC5 RID: 212421 RVA: 0x006FA44F File Offset: 0x006F864F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033DC6 RID: 212422 RVA: 0x006FA458 File Offset: 0x006F8658
		public static ISummonVehicle GetRootAsISummonVehicle(ByteBuffer _bb)
		{
			return ISummonVehicle.GetRootAsISummonVehicle(_bb, default(ISummonVehicle));
		}

		// Token: 0x06033DC7 RID: 212423 RVA: 0x006FA474 File Offset: 0x006F8674
		public static ISummonVehicle GetRootAsISummonVehicle(ByteBuffer _bb, ISummonVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033DC8 RID: 212424 RVA: 0x006FA491 File Offset: 0x006F8691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033DC9 RID: 212425 RVA: 0x006FA4A0 File Offset: 0x006F86A0
		public ISummonVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8FB RID: 55547
		// (get) Token: 0x06033DCA RID: 212426 RVA: 0x006FA4B0 File Offset: 0x006F86B0
		public ESummonEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESummonEntityType.Vehicle;
				}
				return (ESummonEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D8FC RID: 55548
		// (get) Token: 0x06033DCB RID: 212427 RVA: 0x006FA4EC File Offset: 0x006F86EC
		public string TemplateId
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

		// Token: 0x06033DCC RID: 212428 RVA: 0x006FA523 File Offset: 0x006F8723
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033DCD RID: 212429 RVA: 0x006FA532 File Offset: 0x006F8732
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D8FD RID: 55549
		// (get) Token: 0x06033DCE RID: 212430 RVA: 0x006FA540 File Offset: 0x006F8740
		public int PositionEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033DCF RID: 212431 RVA: 0x006FA57C File Offset: 0x006F877C
		public static Offset<ISummonVehicle> CreateISummonVehicle(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle, StringOffset TemplateIdOffset = default(StringOffset), int PositionEntityId = 0)
		{
			builder.StartTable(3);
			ISummonVehicle.AddPositionEntityId(builder, PositionEntityId);
			ISummonVehicle.AddTemplateId(builder, TemplateIdOffset);
			ISummonVehicle.AddType(builder, Type);
			return ISummonVehicle.EndISummonVehicle(builder);
		}

		// Token: 0x06033DD0 RID: 212432 RVA: 0x006FA5A0 File Offset: 0x006F87A0
		public static void StartISummonVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033DD1 RID: 212433 RVA: 0x006FA5A9 File Offset: 0x006F87A9
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033DD2 RID: 212434 RVA: 0x006FA5B4 File Offset: 0x006F87B4
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x06033DD3 RID: 212435 RVA: 0x006FA5C4 File Offset: 0x006F87C4
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(2, positionEntityId, 0);
		}

		// Token: 0x06033DD4 RID: 212436 RVA: 0x006FA5CF File Offset: 0x006F87CF
		public static Offset<ISummonVehicle> EndISummonVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ISummonVehicle>(builder.EndTable());
		}

		// Token: 0x06033DD5 RID: 212437 RVA: 0x006FA5DC File Offset: 0x006F87DC
		public ISummonVehicleT UnPack()
		{
			ISummonVehicleT summonVehicleT = new ISummonVehicleT();
			this.UnPackTo(summonVehicleT);
			return summonVehicleT;
		}

		// Token: 0x06033DD6 RID: 212438 RVA: 0x006FA5F7 File Offset: 0x006F87F7
		public void UnPackTo(ISummonVehicleT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
			_o.PositionEntityId = this.PositionEntityId;
		}

		// Token: 0x06033DD7 RID: 212439 RVA: 0x006FA620 File Offset: 0x006F8820
		public static Offset<ISummonVehicle> Pack(FlatBufferBuilder builder, ISummonVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISummonVehicle>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return ISummonVehicle.CreateISummonVehicle(builder, _o.Type, templateIdOffset, _o.PositionEntityId);
		}

		// Token: 0x04011D2A RID: 73002
		private Table __p;
	}
}
