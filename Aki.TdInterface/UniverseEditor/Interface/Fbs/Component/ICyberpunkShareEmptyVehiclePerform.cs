using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C5 RID: 21957
	public struct ICyberpunkShareEmptyVehiclePerform : IFlatbufferObject
	{
		// Token: 0x17009D33 RID: 40243
		// (get) Token: 0x06022EEB RID: 143083 RVA: 0x004CF1A6 File Offset: 0x004CD3A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022EEC RID: 143084 RVA: 0x004CF1B3 File Offset: 0x004CD3B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022EED RID: 143085 RVA: 0x004CF1BC File Offset: 0x004CD3BC
		public static ICyberpunkShareEmptyVehiclePerform GetRootAsICyberpunkShareEmptyVehiclePerform(ByteBuffer _bb)
		{
			return ICyberpunkShareEmptyVehiclePerform.GetRootAsICyberpunkShareEmptyVehiclePerform(_bb, default(ICyberpunkShareEmptyVehiclePerform));
		}

		// Token: 0x06022EEE RID: 143086 RVA: 0x004CF1D8 File Offset: 0x004CD3D8
		public static ICyberpunkShareEmptyVehiclePerform GetRootAsICyberpunkShareEmptyVehiclePerform(ByteBuffer _bb, ICyberpunkShareEmptyVehiclePerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022EEF RID: 143087 RVA: 0x004CF1F5 File Offset: 0x004CD3F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022EF0 RID: 143088 RVA: 0x004CF204 File Offset: 0x004CD404
		public ICyberpunkShareEmptyVehiclePerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D34 RID: 40244
		// (get) Token: 0x06022EF1 RID: 143089 RVA: 0x004CF214 File Offset: 0x004CD414
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009D35 RID: 40245
		// (get) Token: 0x06022EF2 RID: 143090 RVA: 0x004CF250 File Offset: 0x004CD450
		public string Montage
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

		// Token: 0x06022EF3 RID: 143091 RVA: 0x004CF287 File Offset: 0x004CD487
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022EF4 RID: 143092 RVA: 0x004CF296 File Offset: 0x004CD496
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022EF5 RID: 143093 RVA: 0x004CF2A4 File Offset: 0x004CD4A4
		public static Offset<ICyberpunkShareEmptyVehiclePerform> CreateICyberpunkShareEmptyVehiclePerform(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICyberpunkShareEmptyVehiclePerform.AddMontage(builder, MontageOffset);
			ICyberpunkShareEmptyVehiclePerform.AddType(builder, Type);
			return ICyberpunkShareEmptyVehiclePerform.EndICyberpunkShareEmptyVehiclePerform(builder);
		}

		// Token: 0x06022EF6 RID: 143094 RVA: 0x004CF2C1 File Offset: 0x004CD4C1
		public static void StartICyberpunkShareEmptyVehiclePerform(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022EF7 RID: 143095 RVA: 0x004CF2CA File Offset: 0x004CD4CA
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022EF8 RID: 143096 RVA: 0x004CF2D5 File Offset: 0x004CD4D5
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06022EF9 RID: 143097 RVA: 0x004CF2E5 File Offset: 0x004CD4E5
		public static Offset<ICyberpunkShareEmptyVehiclePerform> EndICyberpunkShareEmptyVehiclePerform(FlatBufferBuilder builder)
		{
			return new Offset<ICyberpunkShareEmptyVehiclePerform>(builder.EndTable());
		}

		// Token: 0x06022EFA RID: 143098 RVA: 0x004CF2F4 File Offset: 0x004CD4F4
		public ICyberpunkShareEmptyVehiclePerformT UnPack()
		{
			ICyberpunkShareEmptyVehiclePerformT cyberpunkShareEmptyVehiclePerformT = new ICyberpunkShareEmptyVehiclePerformT();
			this.UnPackTo(cyberpunkShareEmptyVehiclePerformT);
			return cyberpunkShareEmptyVehiclePerformT;
		}

		// Token: 0x06022EFB RID: 143099 RVA: 0x004CF30F File Offset: 0x004CD50F
		public void UnPackTo(ICyberpunkShareEmptyVehiclePerformT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x06022EFC RID: 143100 RVA: 0x004CF32C File Offset: 0x004CD52C
		public static Offset<ICyberpunkShareEmptyVehiclePerform> Pack(FlatBufferBuilder builder, ICyberpunkShareEmptyVehiclePerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICyberpunkShareEmptyVehiclePerform>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return ICyberpunkShareEmptyVehiclePerform.CreateICyberpunkShareEmptyVehiclePerform(builder, _o.Type, montageOffset);
		}

		// Token: 0x0400EC58 RID: 60504
		private Table __p;
	}
}
