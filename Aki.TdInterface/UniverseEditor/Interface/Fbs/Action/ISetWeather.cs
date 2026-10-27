using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AF RID: 28847
	public struct ISetWeather : IFlatbufferObject
	{
		// Token: 0x1700D648 RID: 54856
		// (get) Token: 0x0603314D RID: 209229 RVA: 0x006E3B47 File Offset: 0x006E1D47
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603314E RID: 209230 RVA: 0x006E3B54 File Offset: 0x006E1D54
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603314F RID: 209231 RVA: 0x006E3B5C File Offset: 0x006E1D5C
		public static ISetWeather GetRootAsISetWeather(ByteBuffer _bb)
		{
			return ISetWeather.GetRootAsISetWeather(_bb, default(ISetWeather));
		}

		// Token: 0x06033150 RID: 209232 RVA: 0x006E3B78 File Offset: 0x006E1D78
		public static ISetWeather GetRootAsISetWeather(ByteBuffer _bb, ISetWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033151 RID: 209233 RVA: 0x006E3B95 File Offset: 0x006E1D95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033152 RID: 209234 RVA: 0x006E3BA4 File Offset: 0x006E1DA4
		public ISetWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D649 RID: 54857
		// (get) Token: 0x06033153 RID: 209235 RVA: 0x006E3BB4 File Offset: 0x006E1DB4
		public int WeatherId
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

		// Token: 0x06033154 RID: 209236 RVA: 0x006E3BF0 File Offset: 0x006E1DF0
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D64A RID: 54858
		// (get) Token: 0x06033155 RID: 209237 RVA: 0x006E3C30 File Offset: 0x006E1E30
		public int AreaIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06033156 RID: 209238 RVA: 0x006E3C5B File Offset: 0x006E1E5B
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033157 RID: 209239 RVA: 0x006E3C6A File Offset: 0x006E1E6A
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D64B RID: 54859
		// (get) Token: 0x06033158 RID: 209240 RVA: 0x006E3C78 File Offset: 0x006E1E78
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033159 RID: 209241 RVA: 0x006E3CB4 File Offset: 0x006E1EB4
		public static Offset<ISetWeather> CreateISetWeather(FlatBufferBuilder builder, int WeatherId = 0, VectorOffset AreaIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISetWeather.AddAreaIds(builder, AreaIdsOffset);
			ISetWeather.AddWeatherId(builder, WeatherId);
			ISetWeather.AddNullMask(builder, NullMask);
			return ISetWeather.EndISetWeather(builder);
		}

		// Token: 0x0603315A RID: 209242 RVA: 0x006E3CD8 File Offset: 0x006E1ED8
		public static void StartISetWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603315B RID: 209243 RVA: 0x006E3CE1 File Offset: 0x006E1EE1
		public static void AddWeatherId(FlatBufferBuilder builder, int weatherId)
		{
			builder.AddInt(0, weatherId, 0);
		}

		// Token: 0x0603315C RID: 209244 RVA: 0x006E3CEC File Offset: 0x006E1EEC
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x0603315D RID: 209245 RVA: 0x006E3CFC File Offset: 0x006E1EFC
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603315E RID: 209246 RVA: 0x006E3D33 File Offset: 0x006E1F33
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603315F RID: 209247 RVA: 0x006E3D4D File Offset: 0x006E1F4D
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033160 RID: 209248 RVA: 0x006E3D6B File Offset: 0x006E1F6B
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033161 RID: 209249 RVA: 0x006E3D84 File Offset: 0x006E1F84
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033162 RID: 209250 RVA: 0x006E3D8F File Offset: 0x006E1F8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033163 RID: 209251 RVA: 0x006E3D9A File Offset: 0x006E1F9A
		public static Offset<ISetWeather> EndISetWeather(FlatBufferBuilder builder)
		{
			return new Offset<ISetWeather>(builder.EndTable());
		}

		// Token: 0x06033164 RID: 209252 RVA: 0x006E3DA8 File Offset: 0x006E1FA8
		public ISetWeatherT UnPack()
		{
			ISetWeatherT setWeatherT = new ISetWeatherT();
			this.UnPackTo(setWeatherT);
			return setWeatherT;
		}

		// Token: 0x06033165 RID: 209253 RVA: 0x006E3DC4 File Offset: 0x006E1FC4
		public void UnPackTo(ISetWeatherT _o)
		{
			_o.WeatherId = this.WeatherId;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033166 RID: 209254 RVA: 0x006E3E18 File Offset: 0x006E2018
		public static Offset<ISetWeather> Pack(FlatBufferBuilder builder, ISetWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetWeather>);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = ISetWeather.CreateAreaIdsVector(builder, data);
			}
			return ISetWeather.CreateISetWeather(builder, _o.WeatherId, areaIdsOffset, _o.NullMask);
		}

		// Token: 0x04011B1A RID: 72474
		private Table __p;
	}
}
