using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B2 RID: 28850
	public struct ISetWeatherLockState : IFlatbufferObject
	{
		// Token: 0x1700D64F RID: 54863
		// (get) Token: 0x0603316F RID: 209263 RVA: 0x006E3EF8 File Offset: 0x006E20F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033170 RID: 209264 RVA: 0x006E3F05 File Offset: 0x006E2105
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033171 RID: 209265 RVA: 0x006E3F0C File Offset: 0x006E210C
		public static ISetWeatherLockState GetRootAsISetWeatherLockState(ByteBuffer _bb)
		{
			return ISetWeatherLockState.GetRootAsISetWeatherLockState(_bb, default(ISetWeatherLockState));
		}

		// Token: 0x06033172 RID: 209266 RVA: 0x006E3F28 File Offset: 0x006E2128
		public static ISetWeatherLockState GetRootAsISetWeatherLockState(ByteBuffer _bb, ISetWeatherLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033173 RID: 209267 RVA: 0x006E3F45 File Offset: 0x006E2145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033174 RID: 209268 RVA: 0x006E3F54 File Offset: 0x006E2154
		public ISetWeatherLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D650 RID: 54864
		// (get) Token: 0x06033175 RID: 209269 RVA: 0x006E3F64 File Offset: 0x006E2164
		public ELockState LockState
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELockState.Lock;
				}
				return (ELockState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033176 RID: 209270 RVA: 0x006E3FA0 File Offset: 0x006E21A0
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D651 RID: 54865
		// (get) Token: 0x06033177 RID: 209271 RVA: 0x006E3FE0 File Offset: 0x006E21E0
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

		// Token: 0x06033178 RID: 209272 RVA: 0x006E400B File Offset: 0x006E220B
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033179 RID: 209273 RVA: 0x006E401A File Offset: 0x006E221A
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D652 RID: 54866
		// (get) Token: 0x0603317A RID: 209274 RVA: 0x006E4028 File Offset: 0x006E2228
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

		// Token: 0x0603317B RID: 209275 RVA: 0x006E4064 File Offset: 0x006E2264
		public static Offset<ISetWeatherLockState> CreateISetWeatherLockState(FlatBufferBuilder builder, ELockState LockState = ELockState.Lock, VectorOffset AreaIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISetWeatherLockState.AddAreaIds(builder, AreaIdsOffset);
			ISetWeatherLockState.AddNullMask(builder, NullMask);
			ISetWeatherLockState.AddLockState(builder, LockState);
			return ISetWeatherLockState.EndISetWeatherLockState(builder);
		}

		// Token: 0x0603317C RID: 209276 RVA: 0x006E4088 File Offset: 0x006E2288
		public static void StartISetWeatherLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603317D RID: 209277 RVA: 0x006E4091 File Offset: 0x006E2291
		public static void AddLockState(FlatBufferBuilder builder, ELockState lockState)
		{
			builder.AddByte(0, (byte)lockState, 0);
		}

		// Token: 0x0603317E RID: 209278 RVA: 0x006E409C File Offset: 0x006E229C
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x0603317F RID: 209279 RVA: 0x006E40AC File Offset: 0x006E22AC
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033180 RID: 209280 RVA: 0x006E40E3 File Offset: 0x006E22E3
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033181 RID: 209281 RVA: 0x006E40FD File Offset: 0x006E22FD
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033182 RID: 209282 RVA: 0x006E411B File Offset: 0x006E231B
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033183 RID: 209283 RVA: 0x006E4134 File Offset: 0x006E2334
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033184 RID: 209284 RVA: 0x006E413F File Offset: 0x006E233F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06033185 RID: 209285 RVA: 0x006E414A File Offset: 0x006E234A
		public static Offset<ISetWeatherLockState> EndISetWeatherLockState(FlatBufferBuilder builder)
		{
			return new Offset<ISetWeatherLockState>(builder.EndTable());
		}

		// Token: 0x06033186 RID: 209286 RVA: 0x006E4158 File Offset: 0x006E2358
		public ISetWeatherLockStateT UnPack()
		{
			ISetWeatherLockStateT setWeatherLockStateT = new ISetWeatherLockStateT();
			this.UnPackTo(setWeatherLockStateT);
			return setWeatherLockStateT;
		}

		// Token: 0x06033187 RID: 209287 RVA: 0x006E4174 File Offset: 0x006E2374
		public void UnPackTo(ISetWeatherLockStateT _o)
		{
			_o.LockState = this.LockState;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033188 RID: 209288 RVA: 0x006E41C8 File Offset: 0x006E23C8
		public static Offset<ISetWeatherLockState> Pack(FlatBufferBuilder builder, ISetWeatherLockStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetWeatherLockState>);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = ISetWeatherLockState.CreateAreaIdsVector(builder, data);
			}
			return ISetWeatherLockState.CreateISetWeatherLockState(builder, _o.LockState, areaIdsOffset, _o.NullMask);
		}

		// Token: 0x04011B1E RID: 72478
		private Table __p;
	}
}
