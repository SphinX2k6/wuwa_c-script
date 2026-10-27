using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAE RID: 28590
	public struct ISetAreaTimeUnLock : IFlatbufferObject
	{
		// Token: 0x1700D44D RID: 54349
		// (get) Token: 0x06032871 RID: 206961 RVA: 0x006D1B09 File Offset: 0x006CFD09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032872 RID: 206962 RVA: 0x006D1B16 File Offset: 0x006CFD16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032873 RID: 206963 RVA: 0x006D1B20 File Offset: 0x006CFD20
		public static ISetAreaTimeUnLock GetRootAsISetAreaTimeUnLock(ByteBuffer _bb)
		{
			return ISetAreaTimeUnLock.GetRootAsISetAreaTimeUnLock(_bb, default(ISetAreaTimeUnLock));
		}

		// Token: 0x06032874 RID: 206964 RVA: 0x006D1B3C File Offset: 0x006CFD3C
		public static ISetAreaTimeUnLock GetRootAsISetAreaTimeUnLock(ByteBuffer _bb, ISetAreaTimeUnLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032875 RID: 206965 RVA: 0x006D1B59 File Offset: 0x006CFD59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032876 RID: 206966 RVA: 0x006D1B68 File Offset: 0x006CFD68
		public ISetAreaTimeUnLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D44E RID: 54350
		// (get) Token: 0x06032877 RID: 206967 RVA: 0x006D1B78 File Offset: 0x006CFD78
		public ESetAreaTime Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetAreaTime.Lock;
				}
				return (ESetAreaTime)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032878 RID: 206968 RVA: 0x006D1BB4 File Offset: 0x006CFDB4
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D44F RID: 54351
		// (get) Token: 0x06032879 RID: 206969 RVA: 0x006D1BF4 File Offset: 0x006CFDF4
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

		// Token: 0x0603287A RID: 206970 RVA: 0x006D1C1F File Offset: 0x006CFE1F
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603287B RID: 206971 RVA: 0x006D1C2E File Offset: 0x006CFE2E
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0603287C RID: 206972 RVA: 0x006D1C3C File Offset: 0x006CFE3C
		public static Offset<ISetAreaTimeUnLock> CreateISetAreaTimeUnLock(FlatBufferBuilder builder, ESetAreaTime Type = ESetAreaTime.Lock, VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetAreaTimeUnLock.AddAreaIds(builder, AreaIdsOffset);
			ISetAreaTimeUnLock.AddType(builder, Type);
			return ISetAreaTimeUnLock.EndISetAreaTimeUnLock(builder);
		}

		// Token: 0x0603287D RID: 206973 RVA: 0x006D1C59 File Offset: 0x006CFE59
		public static void StartISetAreaTimeUnLock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603287E RID: 206974 RVA: 0x006D1C62 File Offset: 0x006CFE62
		public static void AddType(FlatBufferBuilder builder, ESetAreaTime type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603287F RID: 206975 RVA: 0x006D1C6D File Offset: 0x006CFE6D
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x06032880 RID: 206976 RVA: 0x006D1C80 File Offset: 0x006CFE80
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032881 RID: 206977 RVA: 0x006D1CB7 File Offset: 0x006CFEB7
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032882 RID: 206978 RVA: 0x006D1CD1 File Offset: 0x006CFED1
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032883 RID: 206979 RVA: 0x006D1CEF File Offset: 0x006CFEEF
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032884 RID: 206980 RVA: 0x006D1D08 File Offset: 0x006CFF08
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032885 RID: 206981 RVA: 0x006D1D13 File Offset: 0x006CFF13
		public static Offset<ISetAreaTimeUnLock> EndISetAreaTimeUnLock(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeUnLock>(builder.EndTable());
		}

		// Token: 0x06032886 RID: 206982 RVA: 0x006D1D20 File Offset: 0x006CFF20
		public ISetAreaTimeUnLockT UnPack()
		{
			ISetAreaTimeUnLockT setAreaTimeUnLockT = new ISetAreaTimeUnLockT();
			this.UnPackTo(setAreaTimeUnLockT);
			return setAreaTimeUnLockT;
		}

		// Token: 0x06032887 RID: 206983 RVA: 0x006D1D3C File Offset: 0x006CFF3C
		public void UnPackTo(ISetAreaTimeUnLockT _o)
		{
			_o.Type = this.Type;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
		}

		// Token: 0x06032888 RID: 206984 RVA: 0x006D1D84 File Offset: 0x006CFF84
		public static Offset<ISetAreaTimeUnLock> Pack(FlatBufferBuilder builder, ISetAreaTimeUnLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaTimeUnLock>);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = ISetAreaTimeUnLock.CreateAreaIdsVector(builder, data);
			}
			return ISetAreaTimeUnLock.CreateISetAreaTimeUnLock(builder, _o.Type, areaIdsOffset);
		}

		// Token: 0x040119B5 RID: 72117
		private Table __p;
	}
}
