using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007261 RID: 29281
	public struct IMotorRadioDisableByAreaId : IFlatbufferObject
	{
		// Token: 0x1700D6B5 RID: 54965
		// (get) Token: 0x06033050 RID: 208976 RVA: 0x006E31D4 File Offset: 0x006E13D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033051 RID: 208977 RVA: 0x006E31E1 File Offset: 0x006E13E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033052 RID: 208978 RVA: 0x006E31E8 File Offset: 0x006E13E8
		public static IMotorRadioDisableByAreaId GetRootAsIMotorRadioDisableByAreaId(ByteBuffer _bb)
		{
			return IMotorRadioDisableByAreaId.GetRootAsIMotorRadioDisableByAreaId(_bb, default(IMotorRadioDisableByAreaId));
		}

		// Token: 0x06033053 RID: 208979 RVA: 0x006E3204 File Offset: 0x006E1404
		public static IMotorRadioDisableByAreaId GetRootAsIMotorRadioDisableByAreaId(ByteBuffer _bb, IMotorRadioDisableByAreaId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033054 RID: 208980 RVA: 0x006E3221 File Offset: 0x006E1421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033055 RID: 208981 RVA: 0x006E3230 File Offset: 0x006E1430
		public IMotorRadioDisableByAreaId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6B6 RID: 54966
		// (get) Token: 0x06033056 RID: 208982 RVA: 0x006E3240 File Offset: 0x006E1440
		public EMotorRadioDisableRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioDisableRangeType.ByAreaId;
				}
				return (EMotorRadioDisableRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033057 RID: 208983 RVA: 0x006E327C File Offset: 0x006E147C
		public int AreaIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D6B7 RID: 54967
		// (get) Token: 0x06033058 RID: 208984 RVA: 0x006E32BC File Offset: 0x006E14BC
		public int AreaIdListLength
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

		// Token: 0x06033059 RID: 208985 RVA: 0x006E32E7 File Offset: 0x006E14E7
		public Span<int> GetAreaIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603305A RID: 208986 RVA: 0x006E32F6 File Offset: 0x006E14F6
		public int[] GetAreaIdListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0603305B RID: 208987 RVA: 0x006E3304 File Offset: 0x006E1504
		public static Offset<IMotorRadioDisableByAreaId> CreateIMotorRadioDisableByAreaId(FlatBufferBuilder builder, EMotorRadioDisableRangeType Type = EMotorRadioDisableRangeType.ByAreaId, VectorOffset AreaIdListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMotorRadioDisableByAreaId.AddAreaIdList(builder, AreaIdListOffset);
			IMotorRadioDisableByAreaId.AddType(builder, Type);
			return IMotorRadioDisableByAreaId.EndIMotorRadioDisableByAreaId(builder);
		}

		// Token: 0x0603305C RID: 208988 RVA: 0x006E3321 File Offset: 0x006E1521
		public static void StartIMotorRadioDisableByAreaId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603305D RID: 208989 RVA: 0x006E332A File Offset: 0x006E152A
		public static void AddType(FlatBufferBuilder builder, EMotorRadioDisableRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603305E RID: 208990 RVA: 0x006E3335 File Offset: 0x006E1535
		public static void AddAreaIdList(FlatBufferBuilder builder, VectorOffset areaIdListOffset)
		{
			builder.AddOffset(1, areaIdListOffset.Value, 0);
		}

		// Token: 0x0603305F RID: 208991 RVA: 0x006E3348 File Offset: 0x006E1548
		public static VectorOffset CreateAreaIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033060 RID: 208992 RVA: 0x006E337F File Offset: 0x006E157F
		public static VectorOffset CreateAreaIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033061 RID: 208993 RVA: 0x006E3399 File Offset: 0x006E1599
		public static VectorOffset CreateAreaIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033062 RID: 208994 RVA: 0x006E33B7 File Offset: 0x006E15B7
		public static VectorOffset CreateAreaIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033063 RID: 208995 RVA: 0x006E33D0 File Offset: 0x006E15D0
		public static void StartAreaIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033064 RID: 208996 RVA: 0x006E33DB File Offset: 0x006E15DB
		public static Offset<IMotorRadioDisableByAreaId> EndIMotorRadioDisableByAreaId(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioDisableByAreaId>(builder.EndTable());
		}

		// Token: 0x06033065 RID: 208997 RVA: 0x006E33E8 File Offset: 0x006E15E8
		public IMotorRadioDisableByAreaIdT UnPack()
		{
			IMotorRadioDisableByAreaIdT motorRadioDisableByAreaIdT = new IMotorRadioDisableByAreaIdT();
			this.UnPackTo(motorRadioDisableByAreaIdT);
			return motorRadioDisableByAreaIdT;
		}

		// Token: 0x06033066 RID: 208998 RVA: 0x006E3404 File Offset: 0x006E1604
		public void UnPackTo(IMotorRadioDisableByAreaIdT _o)
		{
			_o.Type = this.Type;
			_o.AreaIdList = new List<int>();
			for (int i = 0; i < this.AreaIdListLength; i++)
			{
				_o.AreaIdList.Add(this.AreaIdList(i));
			}
		}

		// Token: 0x06033067 RID: 208999 RVA: 0x006E344C File Offset: 0x006E164C
		public static Offset<IMotorRadioDisableByAreaId> Pack(FlatBufferBuilder builder, IMotorRadioDisableByAreaIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRadioDisableByAreaId>);
			}
			VectorOffset areaIdListOffset = default(VectorOffset);
			if (_o.AreaIdList != null)
			{
				int[] data = _o.AreaIdList.ToArray();
				areaIdListOffset = IMotorRadioDisableByAreaId.CreateAreaIdListVector(builder, data);
			}
			return IMotorRadioDisableByAreaId.CreateIMotorRadioDisableByAreaId(builder, _o.Type, areaIdListOffset);
		}

		// Token: 0x040122D4 RID: 74452
		private Table __p;
	}
}
