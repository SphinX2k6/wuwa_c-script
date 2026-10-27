using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D13 RID: 23827
	public struct IAreaFunction : IFlatbufferObject
	{
		// Token: 0x1700B28A RID: 45706
		// (get) Token: 0x06028B3D RID: 166717 RVA: 0x0059743B File Offset: 0x0059563B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B3E RID: 166718 RVA: 0x00597448 File Offset: 0x00595648
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B3F RID: 166719 RVA: 0x00597450 File Offset: 0x00595650
		public static IAreaFunction GetRootAsIAreaFunction(ByteBuffer _bb)
		{
			return IAreaFunction.GetRootAsIAreaFunction(_bb, default(IAreaFunction));
		}

		// Token: 0x06028B40 RID: 166720 RVA: 0x0059746C File Offset: 0x0059566C
		public static IAreaFunction GetRootAsIAreaFunction(ByteBuffer _bb, IAreaFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B41 RID: 166721 RVA: 0x00597489 File Offset: 0x00595689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B42 RID: 166722 RVA: 0x00597498 File Offset: 0x00595698
		public IAreaFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B28B RID: 45707
		// (get) Token: 0x06028B43 RID: 166723 RVA: 0x005974A8 File Offset: 0x005956A8
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

		// Token: 0x1700B28C RID: 45708
		// (get) Token: 0x06028B44 RID: 166724 RVA: 0x005974E4 File Offset: 0x005956E4
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

		// Token: 0x06028B45 RID: 166725 RVA: 0x0059751B File Offset: 0x0059571B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028B46 RID: 166726 RVA: 0x0059752A File Offset: 0x0059572A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B28D RID: 45709
		// (get) Token: 0x06028B47 RID: 166727 RVA: 0x00597538 File Offset: 0x00595738
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

		// Token: 0x06028B48 RID: 166728 RVA: 0x00597595 File Offset: 0x00595795
		public static Offset<IAreaFunction> CreateIAreaFunction(FlatBufferBuilder builder, int Id = 0, StringOffset DescOffset = default(StringOffset), Offset<IAirCurrentData> DataOffset = default(Offset<IAirCurrentData>))
		{
			builder.StartTable(3);
			IAreaFunction.AddData(builder, DataOffset);
			IAreaFunction.AddDesc(builder, DescOffset);
			IAreaFunction.AddId(builder, Id);
			return IAreaFunction.EndIAreaFunction(builder);
		}

		// Token: 0x06028B49 RID: 166729 RVA: 0x005975B9 File Offset: 0x005957B9
		public static void StartIAreaFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028B4A RID: 166730 RVA: 0x005975C2 File Offset: 0x005957C2
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06028B4B RID: 166731 RVA: 0x005975CD File Offset: 0x005957CD
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x06028B4C RID: 166732 RVA: 0x005975DD File Offset: 0x005957DD
		public static void AddData(FlatBufferBuilder builder, Offset<IAirCurrentData> dataOffset)
		{
			builder.AddOffset(2, dataOffset.Value, 0);
		}

		// Token: 0x06028B4D RID: 166733 RVA: 0x005975ED File Offset: 0x005957ED
		public static Offset<IAreaFunction> EndIAreaFunction(FlatBufferBuilder builder)
		{
			return new Offset<IAreaFunction>(builder.EndTable());
		}

		// Token: 0x06028B4E RID: 166734 RVA: 0x005975FC File Offset: 0x005957FC
		public IAreaFunctionT UnPack()
		{
			IAreaFunctionT areaFunctionT = new IAreaFunctionT();
			this.UnPackTo(areaFunctionT);
			return areaFunctionT;
		}

		// Token: 0x06028B4F RID: 166735 RVA: 0x00597618 File Offset: 0x00595818
		public void UnPackTo(IAreaFunctionT _o)
		{
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x06028B50 RID: 166736 RVA: 0x0059766C File Offset: 0x0059586C
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

		// Token: 0x0400F6BA RID: 63162
		private Table __p;
	}
}
