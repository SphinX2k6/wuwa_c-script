using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AC RID: 28844
	public struct ISetWayOccupancyState : IFlatbufferObject
	{
		// Token: 0x1700D643 RID: 54851
		// (get) Token: 0x0603312F RID: 209199 RVA: 0x006E3818 File Offset: 0x006E1A18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033130 RID: 209200 RVA: 0x006E3825 File Offset: 0x006E1A25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033131 RID: 209201 RVA: 0x006E382C File Offset: 0x006E1A2C
		public static ISetWayOccupancyState GetRootAsISetWayOccupancyState(ByteBuffer _bb)
		{
			return ISetWayOccupancyState.GetRootAsISetWayOccupancyState(_bb, default(ISetWayOccupancyState));
		}

		// Token: 0x06033132 RID: 209202 RVA: 0x006E3848 File Offset: 0x006E1A48
		public static ISetWayOccupancyState GetRootAsISetWayOccupancyState(ByteBuffer _bb, ISetWayOccupancyState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033133 RID: 209203 RVA: 0x006E3865 File Offset: 0x006E1A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033134 RID: 209204 RVA: 0x006E3874 File Offset: 0x006E1A74
		public ISetWayOccupancyState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D644 RID: 54852
		// (get) Token: 0x06033135 RID: 209205 RVA: 0x006E3884 File Offset: 0x006E1A84
		public bool Occupy
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06033136 RID: 209206 RVA: 0x006E38C4 File Offset: 0x006E1AC4
		public int TargetWay(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D645 RID: 54853
		// (get) Token: 0x06033137 RID: 209207 RVA: 0x006E3904 File Offset: 0x006E1B04
		public int TargetWayLength
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

		// Token: 0x06033138 RID: 209208 RVA: 0x006E392F File Offset: 0x006E1B2F
		public Span<int> GetTargetWayBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033139 RID: 209209 RVA: 0x006E393E File Offset: 0x006E1B3E
		public int[] GetTargetWayArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0603313A RID: 209210 RVA: 0x006E394C File Offset: 0x006E1B4C
		public static Offset<ISetWayOccupancyState> CreateISetWayOccupancyState(FlatBufferBuilder builder, bool Occupy = false, VectorOffset TargetWayOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetWayOccupancyState.AddTargetWay(builder, TargetWayOffset);
			ISetWayOccupancyState.AddOccupy(builder, Occupy);
			return ISetWayOccupancyState.EndISetWayOccupancyState(builder);
		}

		// Token: 0x0603313B RID: 209211 RVA: 0x006E3969 File Offset: 0x006E1B69
		public static void StartISetWayOccupancyState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603313C RID: 209212 RVA: 0x006E3972 File Offset: 0x006E1B72
		public static void AddOccupy(FlatBufferBuilder builder, bool occupy)
		{
			builder.AddBool(0, occupy, false);
		}

		// Token: 0x0603313D RID: 209213 RVA: 0x006E397D File Offset: 0x006E1B7D
		public static void AddTargetWay(FlatBufferBuilder builder, VectorOffset targetWayOffset)
		{
			builder.AddOffset(1, targetWayOffset.Value, 0);
		}

		// Token: 0x0603313E RID: 209214 RVA: 0x006E3990 File Offset: 0x006E1B90
		public static VectorOffset CreateTargetWayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603313F RID: 209215 RVA: 0x006E39C7 File Offset: 0x006E1BC7
		public static VectorOffset CreateTargetWayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033140 RID: 209216 RVA: 0x006E39E1 File Offset: 0x006E1BE1
		public static VectorOffset CreateTargetWayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033141 RID: 209217 RVA: 0x006E39FF File Offset: 0x006E1BFF
		public static VectorOffset CreateTargetWayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033142 RID: 209218 RVA: 0x006E3A18 File Offset: 0x006E1C18
		public static void StartTargetWayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033143 RID: 209219 RVA: 0x006E3A23 File Offset: 0x006E1C23
		public static Offset<ISetWayOccupancyState> EndISetWayOccupancyState(FlatBufferBuilder builder)
		{
			return new Offset<ISetWayOccupancyState>(builder.EndTable());
		}

		// Token: 0x06033144 RID: 209220 RVA: 0x006E3A30 File Offset: 0x006E1C30
		public ISetWayOccupancyStateT UnPack()
		{
			ISetWayOccupancyStateT setWayOccupancyStateT = new ISetWayOccupancyStateT();
			this.UnPackTo(setWayOccupancyStateT);
			return setWayOccupancyStateT;
		}

		// Token: 0x06033145 RID: 209221 RVA: 0x006E3A4C File Offset: 0x006E1C4C
		public void UnPackTo(ISetWayOccupancyStateT _o)
		{
			_o.Occupy = this.Occupy;
			_o.TargetWay = new List<int>();
			for (int i = 0; i < this.TargetWayLength; i++)
			{
				_o.TargetWay.Add(this.TargetWay(i));
			}
		}

		// Token: 0x06033146 RID: 209222 RVA: 0x006E3A94 File Offset: 0x006E1C94
		public static Offset<ISetWayOccupancyState> Pack(FlatBufferBuilder builder, ISetWayOccupancyStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetWayOccupancyState>);
			}
			VectorOffset targetWayOffset = default(VectorOffset);
			if (_o.TargetWay != null)
			{
				int[] data = _o.TargetWay.ToArray();
				targetWayOffset = ISetWayOccupancyState.CreateTargetWayVector(builder, data);
			}
			return ISetWayOccupancyState.CreateISetWayOccupancyState(builder, _o.Occupy, targetWayOffset);
		}

		// Token: 0x04011B17 RID: 72471
		private Table __p;
	}
}
