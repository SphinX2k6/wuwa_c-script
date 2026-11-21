using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006347 RID: 25415
	public struct IAreaFunction : IFlatbufferObject
	{
		// Token: 0x1700BBE6 RID: 48102
		// (get) Token: 0x0602B191 RID: 176529 RVA: 0x005DFCAB File Offset: 0x005DDEAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B192 RID: 176530 RVA: 0x005DFCB8 File Offset: 0x005DDEB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B193 RID: 176531 RVA: 0x005DFCC0 File Offset: 0x005DDEC0
		public static IAreaFunction GetRootAsIAreaFunction(ByteBuffer _bb)
		{
			return IAreaFunction.GetRootAsIAreaFunction(_bb, default(IAreaFunction));
		}

		// Token: 0x0602B194 RID: 176532 RVA: 0x005DFCDC File Offset: 0x005DDEDC
		public static IAreaFunction GetRootAsIAreaFunction(ByteBuffer _bb, IAreaFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B195 RID: 176533 RVA: 0x005DFCF9 File Offset: 0x005DDEF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B196 RID: 176534 RVA: 0x005DFD08 File Offset: 0x005DDF08
		public IAreaFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBE7 RID: 48103
		// (get) Token: 0x0602B197 RID: 176535 RVA: 0x005DFD18 File Offset: 0x005DDF18
		public int Id
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

		// Token: 0x1700BBE8 RID: 48104
		// (get) Token: 0x0602B198 RID: 176536 RVA: 0x005DFD54 File Offset: 0x005DDF54
		public string Desc
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

		// Token: 0x0602B199 RID: 176537 RVA: 0x005DFD8B File Offset: 0x005DDF8B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B19A RID: 176538 RVA: 0x005DFD9A File Offset: 0x005DDF9A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BBE9 RID: 48105
		// (get) Token: 0x0602B19B RID: 176539 RVA: 0x005DFDA8 File Offset: 0x005DDFA8
		public IAirCurrentData? Data
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAirCurrentData?(default(IAirCurrentData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602B19C RID: 176540 RVA: 0x005DFE05 File Offset: 0x005DE005
		public static Offset<IAreaFunction> CreateIAreaFunction(FlatBufferBuilder builder, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IAirCurrentData> DataOffset = default(Offset<IAirCurrentData>))
		{
			builder.StartTable(3);
			IAreaFunction.AddData(builder, DataOffset);
			IAreaFunction.AddDesc(builder, DescOffset);
			IAreaFunction.AddId(builder, Id);
			return IAreaFunction.EndIAreaFunction(builder);
		}

		// Token: 0x0602B19D RID: 176541 RVA: 0x005DFE29 File Offset: 0x005DE029
		public static void StartIAreaFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B19E RID: 176542 RVA: 0x005DFE32 File Offset: 0x005DE032
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602B19F RID: 176543 RVA: 0x005DFE3D File Offset: 0x005DE03D
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x0602B1A0 RID: 176544 RVA: 0x005DFE4D File Offset: 0x005DE04D
		public static void AddData(FlatBufferBuilder builder, Offset<IAirCurrentData> dataOffset)
		{
			builder.AddOffset(2, dataOffset.Value, 0);
		}

		// Token: 0x0602B1A1 RID: 176545 RVA: 0x005DFE5D File Offset: 0x005DE05D
		public static Offset<IAreaFunction> EndIAreaFunction(FlatBufferBuilder builder)
		{
			return new Offset<IAreaFunction>(builder.EndTable());
		}

		// Token: 0x0602B1A2 RID: 176546 RVA: 0x005DFE6C File Offset: 0x005DE06C
		public IAreaFunctionT UnPack()
		{
			IAreaFunctionT areaFunctionT = new IAreaFunctionT();
			this.UnPackTo(areaFunctionT);
			return areaFunctionT;
		}

		// Token: 0x0602B1A3 RID: 176547 RVA: 0x005DFE88 File Offset: 0x005DE088
		public void UnPackTo(IAreaFunctionT _o)
		{
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0602B1A4 RID: 176548 RVA: 0x005DFEDC File Offset: 0x005DE0DC
		public static Offset<IAreaFunction> Pack(FlatBufferBuilder builder, IAreaFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaFunction>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IAirCurrentData> dataOffset = (_o.Data == null) ? default(Offset<IAirCurrentData>) : IAirCurrentData.Pack(builder, _o.Data);
			return IAreaFunction.CreateIAreaFunction(builder, _o.Id, descOffset, dataOffset);
		}

		// Token: 0x04010409 RID: 66569
		private Table __p;
	}
}
