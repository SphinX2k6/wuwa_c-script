using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776E RID: 30574
	public struct ISetAreaTimeLock : IFlatbufferObject
	{
		// Token: 0x1700E012 RID: 57362
		// (get) Token: 0x06035A89 RID: 219785 RVA: 0x00730D8C File Offset: 0x0072EF8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A8A RID: 219786 RVA: 0x00730D99 File Offset: 0x0072EF99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A8B RID: 219787 RVA: 0x00730DA0 File Offset: 0x0072EFA0
		public static ISetAreaTimeLock GetRootAsISetAreaTimeLock(ByteBuffer _bb)
		{
			return ISetAreaTimeLock.GetRootAsISetAreaTimeLock(_bb, default(ISetAreaTimeLock));
		}

		// Token: 0x06035A8C RID: 219788 RVA: 0x00730DBC File Offset: 0x0072EFBC
		public static ISetAreaTimeLock GetRootAsISetAreaTimeLock(ByteBuffer _bb, ISetAreaTimeLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A8D RID: 219789 RVA: 0x00730DD9 File Offset: 0x0072EFD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A8E RID: 219790 RVA: 0x00730DE8 File Offset: 0x0072EFE8
		public ISetAreaTimeLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E013 RID: 57363
		// (get) Token: 0x06035A8F RID: 219791 RVA: 0x00730DF8 File Offset: 0x0072EFF8
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

		// Token: 0x06035A90 RID: 219792 RVA: 0x00730E34 File Offset: 0x0072F034
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E014 RID: 57364
		// (get) Token: 0x06035A91 RID: 219793 RVA: 0x00730E74 File Offset: 0x0072F074
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

		// Token: 0x06035A92 RID: 219794 RVA: 0x00730E9F File Offset: 0x0072F09F
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06035A93 RID: 219795 RVA: 0x00730EAE File Offset: 0x0072F0AE
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700E015 RID: 57365
		// (get) Token: 0x06035A94 RID: 219796 RVA: 0x00730EBC File Offset: 0x0072F0BC
		public IFixedTime? LockTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFixedTime?(default(IFixedTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035A95 RID: 219797 RVA: 0x00730F19 File Offset: 0x0072F119
		public static Offset<ISetAreaTimeLock> CreateISetAreaTimeLock(FlatBufferBuilder builder, ESetAreaTime Type = ESetAreaTime.Lock, VectorOffset AreaIdsOffset = default(VectorOffset), Offset<IFixedTime> LockTimeOffset = default(Offset<IFixedTime>))
		{
			builder.StartTable(3);
			ISetAreaTimeLock.AddLockTime(builder, LockTimeOffset);
			ISetAreaTimeLock.AddAreaIds(builder, AreaIdsOffset);
			ISetAreaTimeLock.AddType(builder, Type);
			return ISetAreaTimeLock.EndISetAreaTimeLock(builder);
		}

		// Token: 0x06035A96 RID: 219798 RVA: 0x00730F3D File Offset: 0x0072F13D
		public static void StartISetAreaTimeLock(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035A97 RID: 219799 RVA: 0x00730F46 File Offset: 0x0072F146
		public static void AddType(FlatBufferBuilder builder, ESetAreaTime type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035A98 RID: 219800 RVA: 0x00730F51 File Offset: 0x0072F151
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x06035A99 RID: 219801 RVA: 0x00730F64 File Offset: 0x0072F164
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035A9A RID: 219802 RVA: 0x00730F9B File Offset: 0x0072F19B
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035A9B RID: 219803 RVA: 0x00730FB5 File Offset: 0x0072F1B5
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035A9C RID: 219804 RVA: 0x00730FD3 File Offset: 0x0072F1D3
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035A9D RID: 219805 RVA: 0x00730FEC File Offset: 0x0072F1EC
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035A9E RID: 219806 RVA: 0x00730FF7 File Offset: 0x0072F1F7
		public static void AddLockTime(FlatBufferBuilder builder, Offset<IFixedTime> lockTimeOffset)
		{
			builder.AddOffset(2, lockTimeOffset.Value, 0);
		}

		// Token: 0x06035A9F RID: 219807 RVA: 0x00731007 File Offset: 0x0072F207
		public static Offset<ISetAreaTimeLock> EndISetAreaTimeLock(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeLock>(builder.EndTable());
		}

		// Token: 0x06035AA0 RID: 219808 RVA: 0x00731014 File Offset: 0x0072F214
		public ISetAreaTimeLockT UnPack()
		{
			ISetAreaTimeLockT setAreaTimeLockT = new ISetAreaTimeLockT();
			this.UnPackTo(setAreaTimeLockT);
			return setAreaTimeLockT;
		}

		// Token: 0x06035AA1 RID: 219809 RVA: 0x00731030 File Offset: 0x0072F230
		public void UnPackTo(ISetAreaTimeLockT _o)
		{
			_o.Type = this.Type;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
			_o.LockTime = ((this.LockTime != null) ? this.LockTime.Value.UnPack() : null);
		}

		// Token: 0x06035AA2 RID: 219810 RVA: 0x007310A8 File Offset: 0x0072F2A8
		public static Offset<ISetAreaTimeLock> Pack(FlatBufferBuilder builder, ISetAreaTimeLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaTimeLock>);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = ISetAreaTimeLock.CreateAreaIdsVector(builder, data);
			}
			Offset<IFixedTime> lockTimeOffset = (_o.LockTime == null) ? default(Offset<IFixedTime>) : IFixedTime.Pack(builder, _o.LockTime);
			return ISetAreaTimeLock.CreateISetAreaTimeLock(builder, _o.Type, areaIdsOffset, lockTimeOffset);
		}

		// Token: 0x04012991 RID: 76177
		private Table __p;
	}
}
