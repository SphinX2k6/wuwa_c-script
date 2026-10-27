using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006457 RID: 25687
	public struct IColorMapData : IFlatbufferObject
	{
		// Token: 0x1700BF2D RID: 48941
		// (get) Token: 0x0602C735 RID: 182069 RVA: 0x00618C02 File Offset: 0x00616E02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C736 RID: 182070 RVA: 0x00618C0F File Offset: 0x00616E0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C737 RID: 182071 RVA: 0x00618C18 File Offset: 0x00616E18
		public static IColorMapData GetRootAsIColorMapData(ByteBuffer _bb)
		{
			return IColorMapData.GetRootAsIColorMapData(_bb, default(IColorMapData));
		}

		// Token: 0x0602C738 RID: 182072 RVA: 0x00618C34 File Offset: 0x00616E34
		public static IColorMapData GetRootAsIColorMapData(ByteBuffer _bb, IColorMapData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C739 RID: 182073 RVA: 0x00618C51 File Offset: 0x00616E51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C73A RID: 182074 RVA: 0x00618C60 File Offset: 0x00616E60
		public IColorMapData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF2E RID: 48942
		// (get) Token: 0x0602C73B RID: 182075 RVA: 0x00618C70 File Offset: 0x00616E70
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

		// Token: 0x0602C73C RID: 182076 RVA: 0x00618CA7 File Offset: 0x00616EA7
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602C73D RID: 182077 RVA: 0x00618CB6 File Offset: 0x00616EB6
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BF2F RID: 48943
		// (get) Token: 0x0602C73E RID: 182078 RVA: 0x00618CC4 File Offset: 0x00616EC4
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

		// Token: 0x0602C73F RID: 182079 RVA: 0x00618D21 File Offset: 0x00616F21
		public static Offset<IColorMapData> CreateIColorMapData(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), Offset<IColor> ColorOffset = default(Offset<IColor>))
		{
			builder.StartTable(2);
			IColorMapData.AddColor(builder, ColorOffset);
			IColorMapData.AddKey(builder, KeyOffset);
			return IColorMapData.EndIColorMapData(builder);
		}

		// Token: 0x0602C740 RID: 182080 RVA: 0x00618D3E File Offset: 0x00616F3E
		public static void StartIColorMapData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C741 RID: 182081 RVA: 0x00618D47 File Offset: 0x00616F47
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602C742 RID: 182082 RVA: 0x00618D57 File Offset: 0x00616F57
		public static void AddColor(FlatBufferBuilder builder, Offset<IColor> colorOffset)
		{
			builder.AddOffset(1, colorOffset.Value, 0);
		}

		// Token: 0x0602C743 RID: 182083 RVA: 0x00618D67 File Offset: 0x00616F67
		public static Offset<IColorMapData> EndIColorMapData(FlatBufferBuilder builder)
		{
			return new Offset<IColorMapData>(builder.EndTable());
		}

		// Token: 0x0602C744 RID: 182084 RVA: 0x00618D74 File Offset: 0x00616F74
		public IColorMapDataT UnPack()
		{
			IColorMapDataT colorMapDataT = new IColorMapDataT();
			this.UnPackTo(colorMapDataT);
			return colorMapDataT;
		}

		// Token: 0x0602C745 RID: 182085 RVA: 0x00618D90 File Offset: 0x00616F90
		public void UnPackTo(IColorMapDataT _o)
		{
			_o.Key = this.Key;
			_o.Color = ((this.Color != null) ? this.Color.Value.UnPack() : null);
		}

		// Token: 0x0602C746 RID: 182086 RVA: 0x00618DD8 File Offset: 0x00616FD8
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

		// Token: 0x04010A55 RID: 68181
		private Table __p;
	}
}
