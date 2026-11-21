using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABF RID: 27327
	public struct IColorMapData : IFlatbufferObject
	{
		// Token: 0x1700C8AF RID: 51375
		// (get) Token: 0x0602EE7A RID: 192122 RVA: 0x00663CCE File Offset: 0x00661ECE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE7B RID: 192123 RVA: 0x00663CDB File Offset: 0x00661EDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE7C RID: 192124 RVA: 0x00663CE4 File Offset: 0x00661EE4
		public static IColorMapData GetRootAsIColorMapData(ByteBuffer _bb)
		{
			return IColorMapData.GetRootAsIColorMapData(_bb, default(IColorMapData));
		}

		// Token: 0x0602EE7D RID: 192125 RVA: 0x00663D00 File Offset: 0x00661F00
		public static IColorMapData GetRootAsIColorMapData(ByteBuffer _bb, IColorMapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE7E RID: 192126 RVA: 0x00663D1D File Offset: 0x00661F1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE7F RID: 192127 RVA: 0x00663D2C File Offset: 0x00661F2C
		public IColorMapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8B0 RID: 51376
		// (get) Token: 0x0602EE80 RID: 192128 RVA: 0x00663D3C File Offset: 0x00661F3C
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EE81 RID: 192129 RVA: 0x00663D73 File Offset: 0x00661F73
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602EE82 RID: 192130 RVA: 0x00663D82 File Offset: 0x00661F82
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C8B1 RID: 51377
		// (get) Token: 0x0602EE83 RID: 192131 RVA: 0x00663D90 File Offset: 0x00661F90
		public IColor? Color
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IColor?(default(IColor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602EE84 RID: 192132 RVA: 0x00663DED File Offset: 0x00661FED
		public static Offset<IColorMapData> CreateIColorMapData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IColor> ColorOffset = default(Offset<IColor>))
		{
			builder.StartTable(2);
			IColorMapData.AddColor(builder, ColorOffset);
			IColorMapData.AddKey(builder, KeyOffset);
			return IColorMapData.EndIColorMapData(builder);
		}

		// Token: 0x0602EE85 RID: 192133 RVA: 0x00663E0A File Offset: 0x0066200A
		public static void StartIColorMapData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EE86 RID: 192134 RVA: 0x00663E13 File Offset: 0x00662013
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602EE87 RID: 192135 RVA: 0x00663E23 File Offset: 0x00662023
		public static void AddColor(FlatBufferBuilder builder, Offset<IColor> colorOffset)
		{
			builder.AddOffset(1, colorOffset.Value, 0);
		}

		// Token: 0x0602EE88 RID: 192136 RVA: 0x00663E33 File Offset: 0x00662033
		public static Offset<IColorMapData> EndIColorMapData(FlatBufferBuilder builder)
		{
			return new Offset<IColorMapData>(builder.EndTable());
		}

		// Token: 0x0602EE89 RID: 192137 RVA: 0x00663E40 File Offset: 0x00662040
		public IColorMapDataT UnPack()
		{
			IColorMapDataT colorMapDataT = new IColorMapDataT();
			this.UnPackTo(colorMapDataT);
			return colorMapDataT;
		}

		// Token: 0x0602EE8A RID: 192138 RVA: 0x00663E5C File Offset: 0x0066205C
		public void UnPackTo(IColorMapDataT _o)
		{
			_o.Key = this.Key;
			_o.Color = ((this.Color != null) ? this.Color.Value.UnPack() : null);
		}

		// Token: 0x0602EE8B RID: 192139 RVA: 0x00663EA4 File Offset: 0x006620A4
		public static Offset<IColorMapData> Pack(FlatBufferBuilder builder, IColorMapDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IColorMapData>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			Offset<IColor> colorOffset = (_o.Color == null) ? default(Offset<IColor>) : IColor.Pack(builder, _o.Color);
			return IColorMapData.CreateIColorMapData(builder, keyOffset, colorOffset);
		}

		// Token: 0x04011860 RID: 71776
		private Table __p;
	}
}
