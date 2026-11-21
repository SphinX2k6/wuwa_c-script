using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007774 RID: 30580
	public struct ISetAreaTimeUnLock : IFlatbufferObject
	{
		// Token: 0x1700E01C RID: 57372
		// (get) Token: 0x06035AC1 RID: 219841 RVA: 0x007314C1 File Offset: 0x0072F6C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AC2 RID: 219842 RVA: 0x007314CE File Offset: 0x0072F6CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AC3 RID: 219843 RVA: 0x007314D8 File Offset: 0x0072F6D8
		public static ISetAreaTimeUnLock GetRootAsISetAreaTimeUnLock(ByteBuffer _bb)
		{
			return ISetAreaTimeUnLock.GetRootAsISetAreaTimeUnLock(_bb, default(ISetAreaTimeUnLock));
		}

		// Token: 0x06035AC4 RID: 219844 RVA: 0x007314F4 File Offset: 0x0072F6F4
		public static ISetAreaTimeUnLock GetRootAsISetAreaTimeUnLock(ByteBuffer _bb, ISetAreaTimeUnLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AC5 RID: 219845 RVA: 0x00731511 File Offset: 0x0072F711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035AC6 RID: 219846 RVA: 0x00731520 File Offset: 0x0072F720
		public ISetAreaTimeUnLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E01D RID: 57373
		// (get) Token: 0x06035AC7 RID: 219847 RVA: 0x00731530 File Offset: 0x0072F730
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

		// Token: 0x06035AC8 RID: 219848 RVA: 0x0073156C File Offset: 0x0072F76C
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E01E RID: 57374
		// (get) Token: 0x06035AC9 RID: 219849 RVA: 0x007315AC File Offset: 0x0072F7AC
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

		// Token: 0x06035ACA RID: 219850 RVA: 0x007315D7 File Offset: 0x0072F7D7
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06035ACB RID: 219851 RVA: 0x007315E6 File Offset: 0x0072F7E6
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06035ACC RID: 219852 RVA: 0x007315F4 File Offset: 0x0072F7F4
		public static Offset<ISetAreaTimeUnLock> CreateISetAreaTimeUnLock(FlatBufferBuilder builder, ESetAreaTime Type = ESetAreaTime.Lock, VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetAreaTimeUnLock.AddAreaIds(builder, AreaIdsOffset);
			ISetAreaTimeUnLock.AddType(builder, Type);
			return ISetAreaTimeUnLock.EndISetAreaTimeUnLock(builder);
		}

		// Token: 0x06035ACD RID: 219853 RVA: 0x00731611 File Offset: 0x0072F811
		public static void StartISetAreaTimeUnLock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035ACE RID: 219854 RVA: 0x0073161A File Offset: 0x0072F81A
		public static void AddType(FlatBufferBuilder builder, ESetAreaTime type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035ACF RID: 219855 RVA: 0x00731625 File Offset: 0x0072F825
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x06035AD0 RID: 219856 RVA: 0x00731638 File Offset: 0x0072F838
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035AD1 RID: 219857 RVA: 0x0073166F File Offset: 0x0072F86F
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035AD2 RID: 219858 RVA: 0x00731689 File Offset: 0x0072F889
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035AD3 RID: 219859 RVA: 0x007316A7 File Offset: 0x0072F8A7
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035AD4 RID: 219860 RVA: 0x007316C0 File Offset: 0x0072F8C0
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035AD5 RID: 219861 RVA: 0x007316CB File Offset: 0x0072F8CB
		public static Offset<ISetAreaTimeUnLock> EndISetAreaTimeUnLock(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeUnLock>(builder.EndTable());
		}

		// Token: 0x06035AD6 RID: 219862 RVA: 0x007316D8 File Offset: 0x0072F8D8
		public ISetAreaTimeUnLockT UnPack()
		{
			ISetAreaTimeUnLockT setAreaTimeUnLockT = new ISetAreaTimeUnLockT();
			this.UnPackTo(setAreaTimeUnLockT);
			return setAreaTimeUnLockT;
		}

		// Token: 0x06035AD7 RID: 219863 RVA: 0x007316F4 File Offset: 0x0072F8F4
		public void UnPackTo(ISetAreaTimeUnLockT _o)
		{
			_o.Type = this.Type;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
		}

		// Token: 0x06035AD8 RID: 219864 RVA: 0x0073173C File Offset: 0x0072F93C
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

		// Token: 0x04012997 RID: 76183
		private Table __p;
	}
}
