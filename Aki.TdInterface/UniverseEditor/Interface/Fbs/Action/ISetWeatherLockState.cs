using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200787E RID: 30846
	public struct ISetWeatherLockState : IFlatbufferObject
	{
		// Token: 0x1700E232 RID: 57906
		// (get) Token: 0x06036411 RID: 222225 RVA: 0x00744504 File Offset: 0x00742704
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036412 RID: 222226 RVA: 0x00744511 File Offset: 0x00742711
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036413 RID: 222227 RVA: 0x00744518 File Offset: 0x00742718
		public static ISetWeatherLockState GetRootAsISetWeatherLockState(ByteBuffer _bb)
		{
			return ISetWeatherLockState.GetRootAsISetWeatherLockState(_bb, default(ISetWeatherLockState));
		}

		// Token: 0x06036414 RID: 222228 RVA: 0x00744534 File Offset: 0x00742734
		public static ISetWeatherLockState GetRootAsISetWeatherLockState(ByteBuffer _bb, ISetWeatherLockState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036415 RID: 222229 RVA: 0x00744551 File Offset: 0x00742751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036416 RID: 222230 RVA: 0x00744560 File Offset: 0x00742760
		public ISetWeatherLockState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E233 RID: 57907
		// (get) Token: 0x06036417 RID: 222231 RVA: 0x00744570 File Offset: 0x00742770
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

		// Token: 0x06036418 RID: 222232 RVA: 0x007445AC File Offset: 0x007427AC
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E234 RID: 57908
		// (get) Token: 0x06036419 RID: 222233 RVA: 0x007445EC File Offset: 0x007427EC
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

		// Token: 0x0603641A RID: 222234 RVA: 0x00744617 File Offset: 0x00742817
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603641B RID: 222235 RVA: 0x00744626 File Offset: 0x00742826
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700E235 RID: 57909
		// (get) Token: 0x0603641C RID: 222236 RVA: 0x00744634 File Offset: 0x00742834
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

		// Token: 0x0603641D RID: 222237 RVA: 0x00744670 File Offset: 0x00742870
		public static Offset<ISetWeatherLockState> CreateISetWeatherLockState(FlatBufferBuilder builder, ELockState LockState = ELockState.Lock, VectorOffset AreaIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISetWeatherLockState.AddAreaIds(builder, AreaIdsOffset);
			ISetWeatherLockState.AddNullMask(builder, NullMask);
			ISetWeatherLockState.AddLockState(builder, LockState);
			return ISetWeatherLockState.EndISetWeatherLockState(builder);
		}

		// Token: 0x0603641E RID: 222238 RVA: 0x00744694 File Offset: 0x00742894
		public static void StartISetWeatherLockState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603641F RID: 222239 RVA: 0x0074469D File Offset: 0x0074289D
		public static void AddLockState(FlatBufferBuilder builder, ELockState lockState)
		{
			builder.AddByte(0, (byte)lockState, 0);
		}

		// Token: 0x06036420 RID: 222240 RVA: 0x007446A8 File Offset: 0x007428A8
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x06036421 RID: 222241 RVA: 0x007446B8 File Offset: 0x007428B8
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036422 RID: 222242 RVA: 0x007446EF File Offset: 0x007428EF
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036423 RID: 222243 RVA: 0x00744709 File Offset: 0x00742909
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036424 RID: 222244 RVA: 0x00744727 File Offset: 0x00742927
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036425 RID: 222245 RVA: 0x00744740 File Offset: 0x00742940
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036426 RID: 222246 RVA: 0x0074474B File Offset: 0x0074294B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06036427 RID: 222247 RVA: 0x00744756 File Offset: 0x00742956
		public static Offset<ISetWeatherLockState> EndISetWeatherLockState(FlatBufferBuilder builder)
		{
			return new Offset<ISetWeatherLockState>(builder.EndTable());
		}

		// Token: 0x06036428 RID: 222248 RVA: 0x00744764 File Offset: 0x00742964
		public ISetWeatherLockStateT UnPack()
		{
			ISetWeatherLockStateT setWeatherLockStateT = new ISetWeatherLockStateT();
			this.UnPackTo(setWeatherLockStateT);
			return setWeatherLockStateT;
		}

		// Token: 0x06036429 RID: 222249 RVA: 0x00744780 File Offset: 0x00742980
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

		// Token: 0x0603642A RID: 222250 RVA: 0x007447D4 File Offset: 0x007429D4
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

		// Token: 0x04012B0C RID: 76556
		private Table __p;
	}
}
