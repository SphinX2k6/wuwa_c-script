using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A0D RID: 31245
	public struct ISummonVehicle : IFlatbufferObject
	{
		// Token: 0x1700E4F3 RID: 58611
		// (get) Token: 0x060370C6 RID: 225478 RVA: 0x0075B7A2 File Offset: 0x007599A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060370C7 RID: 225479 RVA: 0x0075B7AF File Offset: 0x007599AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060370C8 RID: 225480 RVA: 0x0075B7B8 File Offset: 0x007599B8
		public static ISummonVehicle GetRootAsISummonVehicle(ByteBuffer _bb)
		{
			return ISummonVehicle.GetRootAsISummonVehicle(_bb, default(ISummonVehicle));
		}

		// Token: 0x060370C9 RID: 225481 RVA: 0x0075B7D4 File Offset: 0x007599D4
		public static ISummonVehicle GetRootAsISummonVehicle(ByteBuffer _bb, ISummonVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060370CA RID: 225482 RVA: 0x0075B7F1 File Offset: 0x007599F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060370CB RID: 225483 RVA: 0x0075B800 File Offset: 0x00759A00
		public ISummonVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4F4 RID: 58612
		// (get) Token: 0x060370CC RID: 225484 RVA: 0x0075B810 File Offset: 0x00759A10
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

		// Token: 0x1700E4F5 RID: 58613
		// (get) Token: 0x060370CD RID: 225485 RVA: 0x0075B84C File Offset: 0x00759A4C
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

		// Token: 0x060370CE RID: 225486 RVA: 0x0075B883 File Offset: 0x00759A83
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060370CF RID: 225487 RVA: 0x0075B892 File Offset: 0x00759A92
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E4F6 RID: 58614
		// (get) Token: 0x060370D0 RID: 225488 RVA: 0x0075B8A0 File Offset: 0x00759AA0
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

		// Token: 0x060370D1 RID: 225489 RVA: 0x0075B8DC File Offset: 0x00759ADC
		public static Offset<ISummonVehicle> CreateISummonVehicle(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle, StringOffset TemplateIdOffset = default(StringOffset), int PositionEntityId = 0)
		{
			builder.StartTable(3);
			ISummonVehicle.AddPositionEntityId(builder, PositionEntityId);
			ISummonVehicle.AddTemplateId(builder, TemplateIdOffset);
			ISummonVehicle.AddType(builder, Type);
			return ISummonVehicle.EndISummonVehicle(builder);
		}

		// Token: 0x060370D2 RID: 225490 RVA: 0x0075B900 File Offset: 0x00759B00
		public static void StartISummonVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060370D3 RID: 225491 RVA: 0x0075B909 File Offset: 0x00759B09
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060370D4 RID: 225492 RVA: 0x0075B914 File Offset: 0x00759B14
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x060370D5 RID: 225493 RVA: 0x0075B924 File Offset: 0x00759B24
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(2, positionEntityId, 0);
		}

		// Token: 0x060370D6 RID: 225494 RVA: 0x0075B92F File Offset: 0x00759B2F
		public static Offset<ISummonVehicle> EndISummonVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ISummonVehicle>(builder.EndTable());
		}

		// Token: 0x060370D7 RID: 225495 RVA: 0x0075B93C File Offset: 0x00759B3C
		public ISummonVehicleT UnPack()
		{
			ISummonVehicleT summonVehicleT = new ISummonVehicleT();
			this.UnPackTo(summonVehicleT);
			return summonVehicleT;
		}

		// Token: 0x060370D8 RID: 225496 RVA: 0x0075B957 File Offset: 0x00759B57
		public void UnPackTo(ISummonVehicleT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
			_o.PositionEntityId = this.PositionEntityId;
		}

		// Token: 0x060370D9 RID: 225497 RVA: 0x0075B980 File Offset: 0x00759B80
		public static Offset<ISummonVehicle> Pack(FlatBufferBuilder builder, ISummonVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISummonVehicle>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return ISummonVehicle.CreateISummonVehicle(builder, _o.Type, templateIdOffset, _o.PositionEntityId);
		}

		// Token: 0x04012D2C RID: 77100
		private Table __p;
	}
}
