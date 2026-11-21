using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C11 RID: 27665
	public struct IDestroySummonedVehicle : IFlatbufferObject
	{
		// Token: 0x1700CACD RID: 51917
		// (get) Token: 0x0602F9CD RID: 195021 RVA: 0x0067CF9E File Offset: 0x0067B19E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F9CE RID: 195022 RVA: 0x0067CFAB File Offset: 0x0067B1AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F9CF RID: 195023 RVA: 0x0067CFB4 File Offset: 0x0067B1B4
		public static IDestroySummonedVehicle GetRootAsIDestroySummonedVehicle(ByteBuffer _bb)
		{
			return IDestroySummonedVehicle.GetRootAsIDestroySummonedVehicle(_bb, default(IDestroySummonedVehicle));
		}

		// Token: 0x0602F9D0 RID: 195024 RVA: 0x0067CFD0 File Offset: 0x0067B1D0
		public static IDestroySummonedVehicle GetRootAsIDestroySummonedVehicle(ByteBuffer _bb, IDestroySummonedVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F9D1 RID: 195025 RVA: 0x0067CFED File Offset: 0x0067B1ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F9D2 RID: 195026 RVA: 0x0067CFFC File Offset: 0x0067B1FC
		public IDestroySummonedVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CACE RID: 51918
		// (get) Token: 0x0602F9D3 RID: 195027 RVA: 0x0067D00C File Offset: 0x0067B20C
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

		// Token: 0x1700CACF RID: 51919
		// (get) Token: 0x0602F9D4 RID: 195028 RVA: 0x0067D048 File Offset: 0x0067B248
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

		// Token: 0x0602F9D5 RID: 195029 RVA: 0x0067D07F File Offset: 0x0067B27F
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F9D6 RID: 195030 RVA: 0x0067D08E File Offset: 0x0067B28E
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F9D7 RID: 195031 RVA: 0x0067D09C File Offset: 0x0067B29C
		public static Offset<IDestroySummonedVehicle> CreateIDestroySummonedVehicle(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDestroySummonedVehicle.AddTemplateId(builder, TemplateIdOffset);
			IDestroySummonedVehicle.AddType(builder, Type);
			return IDestroySummonedVehicle.EndIDestroySummonedVehicle(builder);
		}

		// Token: 0x0602F9D8 RID: 195032 RVA: 0x0067D0B9 File Offset: 0x0067B2B9
		public static void StartIDestroySummonedVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F9D9 RID: 195033 RVA: 0x0067D0C2 File Offset: 0x0067B2C2
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F9DA RID: 195034 RVA: 0x0067D0CD File Offset: 0x0067B2CD
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0602F9DB RID: 195035 RVA: 0x0067D0DD File Offset: 0x0067B2DD
		public static Offset<IDestroySummonedVehicle> EndIDestroySummonedVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySummonedVehicle>(builder.EndTable());
		}

		// Token: 0x0602F9DC RID: 195036 RVA: 0x0067D0EC File Offset: 0x0067B2EC
		public IDestroySummonedVehicleT UnPack()
		{
			IDestroySummonedVehicleT destroySummonedVehicleT = new IDestroySummonedVehicleT();
			this.UnPackTo(destroySummonedVehicleT);
			return destroySummonedVehicleT;
		}

		// Token: 0x0602F9DD RID: 195037 RVA: 0x0067D107 File Offset: 0x0067B307
		public void UnPackTo(IDestroySummonedVehicleT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0602F9DE RID: 195038 RVA: 0x0067D124 File Offset: 0x0067B324
		public static Offset<IDestroySummonedVehicle> Pack(FlatBufferBuilder builder, IDestroySummonedVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySummonedVehicle>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDestroySummonedVehicle.CreateIDestroySummonedVehicle(builder, _o.Type, templateIdOffset);
		}

		// Token: 0x04011A17 RID: 72215
		private Table __p;
	}
}
