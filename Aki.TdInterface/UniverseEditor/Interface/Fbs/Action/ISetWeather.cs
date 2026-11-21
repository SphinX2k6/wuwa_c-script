using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200787B RID: 30843
	public struct ISetWeather : IFlatbufferObject
	{
		// Token: 0x1700E22B RID: 57899
		// (get) Token: 0x060363EF RID: 222191 RVA: 0x00744153 File Offset: 0x00742353
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060363F0 RID: 222192 RVA: 0x00744160 File Offset: 0x00742360
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060363F1 RID: 222193 RVA: 0x00744168 File Offset: 0x00742368
		public static ISetWeather GetRootAsISetWeather(ByteBuffer _bb)
		{
			return ISetWeather.GetRootAsISetWeather(_bb, default(ISetWeather));
		}

		// Token: 0x060363F2 RID: 222194 RVA: 0x00744184 File Offset: 0x00742384
		public static ISetWeather GetRootAsISetWeather(ByteBuffer _bb, ISetWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060363F3 RID: 222195 RVA: 0x007441A1 File Offset: 0x007423A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060363F4 RID: 222196 RVA: 0x007441B0 File Offset: 0x007423B0
		public ISetWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E22C RID: 57900
		// (get) Token: 0x060363F5 RID: 222197 RVA: 0x007441C0 File Offset: 0x007423C0
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

		// Token: 0x060363F6 RID: 222198 RVA: 0x007441FC File Offset: 0x007423FC
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E22D RID: 57901
		// (get) Token: 0x060363F7 RID: 222199 RVA: 0x0074423C File Offset: 0x0074243C
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

		// Token: 0x060363F8 RID: 222200 RVA: 0x00744267 File Offset: 0x00742467
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060363F9 RID: 222201 RVA: 0x00744276 File Offset: 0x00742476
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700E22E RID: 57902
		// (get) Token: 0x060363FA RID: 222202 RVA: 0x00744284 File Offset: 0x00742484
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

		// Token: 0x060363FB RID: 222203 RVA: 0x007442C0 File Offset: 0x007424C0
		public static Offset<ISetWeather> CreateISetWeather(FlatBufferBuilder builder, int WeatherId = 0, VectorOffset AreaIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISetWeather.AddAreaIds(builder, AreaIdsOffset);
			ISetWeather.AddWeatherId(builder, WeatherId);
			ISetWeather.AddNullMask(builder, NullMask);
			return ISetWeather.EndISetWeather(builder);
		}

		// Token: 0x060363FC RID: 222204 RVA: 0x007442E4 File Offset: 0x007424E4
		public static void StartISetWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060363FD RID: 222205 RVA: 0x007442ED File Offset: 0x007424ED
		public static void AddWeatherId(FlatBufferBuilder builder, int weatherId)
		{
			builder.AddInt(0, weatherId, 0);
		}

		// Token: 0x060363FE RID: 222206 RVA: 0x007442F8 File Offset: 0x007424F8
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x060363FF RID: 222207 RVA: 0x00744308 File Offset: 0x00742508
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036400 RID: 222208 RVA: 0x0074433F File Offset: 0x0074253F
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036401 RID: 222209 RVA: 0x00744359 File Offset: 0x00742559
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036402 RID: 222210 RVA: 0x00744377 File Offset: 0x00742577
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036403 RID: 222211 RVA: 0x00744390 File Offset: 0x00742590
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036404 RID: 222212 RVA: 0x0074439B File Offset: 0x0074259B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06036405 RID: 222213 RVA: 0x007443A6 File Offset: 0x007425A6
		public static Offset<ISetWeather> EndISetWeather(FlatBufferBuilder builder)
		{
			return new Offset<ISetWeather>(builder.EndTable());
		}

		// Token: 0x06036406 RID: 222214 RVA: 0x007443B4 File Offset: 0x007425B4
		public ISetWeatherT UnPack()
		{
			ISetWeatherT setWeatherT = new ISetWeatherT();
			this.UnPackTo(setWeatherT);
			return setWeatherT;
		}

		// Token: 0x06036407 RID: 222215 RVA: 0x007443D0 File Offset: 0x007425D0
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

		// Token: 0x06036408 RID: 222216 RVA: 0x00744424 File Offset: 0x00742624
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

		// Token: 0x04012B08 RID: 76552
		private Table __p;
	}
}
