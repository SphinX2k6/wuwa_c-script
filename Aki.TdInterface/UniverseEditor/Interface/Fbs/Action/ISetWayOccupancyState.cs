using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007878 RID: 30840
	public struct ISetWayOccupancyState : IFlatbufferObject
	{
		// Token: 0x1700E226 RID: 57894
		// (get) Token: 0x060363D1 RID: 222161 RVA: 0x00743E24 File Offset: 0x00742024
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060363D2 RID: 222162 RVA: 0x00743E31 File Offset: 0x00742031
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060363D3 RID: 222163 RVA: 0x00743E38 File Offset: 0x00742038
		public static ISetWayOccupancyState GetRootAsISetWayOccupancyState(ByteBuffer _bb)
		{
			return ISetWayOccupancyState.GetRootAsISetWayOccupancyState(_bb, default(ISetWayOccupancyState));
		}

		// Token: 0x060363D4 RID: 222164 RVA: 0x00743E54 File Offset: 0x00742054
		public static ISetWayOccupancyState GetRootAsISetWayOccupancyState(ByteBuffer _bb, ISetWayOccupancyState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060363D5 RID: 222165 RVA: 0x00743E71 File Offset: 0x00742071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060363D6 RID: 222166 RVA: 0x00743E80 File Offset: 0x00742080
		public ISetWayOccupancyState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E227 RID: 57895
		// (get) Token: 0x060363D7 RID: 222167 RVA: 0x00743E90 File Offset: 0x00742090
		public bool Occupy
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060363D8 RID: 222168 RVA: 0x00743ED0 File Offset: 0x007420D0
		public int TargetWay(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E228 RID: 57896
		// (get) Token: 0x060363D9 RID: 222169 RVA: 0x00743F10 File Offset: 0x00742110
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

		// Token: 0x060363DA RID: 222170 RVA: 0x00743F3B File Offset: 0x0074213B
		public Span<int> GetTargetWayBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060363DB RID: 222171 RVA: 0x00743F4A File Offset: 0x0074214A
		public int[] GetTargetWayArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060363DC RID: 222172 RVA: 0x00743F58 File Offset: 0x00742158
		public static Offset<ISetWayOccupancyState> CreateISetWayOccupancyState(FlatBufferBuilder builder, bool Occupy = false, VectorOffset TargetWayOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISetWayOccupancyState.AddTargetWay(builder, TargetWayOffset);
			ISetWayOccupancyState.AddOccupy(builder, Occupy);
			return ISetWayOccupancyState.EndISetWayOccupancyState(builder);
		}

		// Token: 0x060363DD RID: 222173 RVA: 0x00743F75 File Offset: 0x00742175
		public static void StartISetWayOccupancyState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060363DE RID: 222174 RVA: 0x00743F7E File Offset: 0x0074217E
		public static void AddOccupy(FlatBufferBuilder builder, bool occupy)
		{
			builder.AddBool(0, occupy, false);
		}

		// Token: 0x060363DF RID: 222175 RVA: 0x00743F89 File Offset: 0x00742189
		public static void AddTargetWay(FlatBufferBuilder builder, VectorOffset targetWayOffset)
		{
			builder.AddOffset(1, targetWayOffset.Value, 0);
		}

		// Token: 0x060363E0 RID: 222176 RVA: 0x00743F9C File Offset: 0x0074219C
		public static VectorOffset CreateTargetWayVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060363E1 RID: 222177 RVA: 0x00743FD3 File Offset: 0x007421D3
		public static VectorOffset CreateTargetWayVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060363E2 RID: 222178 RVA: 0x00743FED File Offset: 0x007421ED
		public static VectorOffset CreateTargetWayVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060363E3 RID: 222179 RVA: 0x0074400B File Offset: 0x0074220B
		public static VectorOffset CreateTargetWayVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060363E4 RID: 222180 RVA: 0x00744024 File Offset: 0x00742224
		public static void StartTargetWayVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060363E5 RID: 222181 RVA: 0x0074402F File Offset: 0x0074222F
		public static Offset<ISetWayOccupancyState> EndISetWayOccupancyState(FlatBufferBuilder builder)
		{
			return new Offset<ISetWayOccupancyState>(builder.EndTable());
		}

		// Token: 0x060363E6 RID: 222182 RVA: 0x0074403C File Offset: 0x0074223C
		public ISetWayOccupancyStateT UnPack()
		{
			ISetWayOccupancyStateT setWayOccupancyStateT = new ISetWayOccupancyStateT();
			this.UnPackTo(setWayOccupancyStateT);
			return setWayOccupancyStateT;
		}

		// Token: 0x060363E7 RID: 222183 RVA: 0x00744058 File Offset: 0x00742258
		public void UnPackTo(ISetWayOccupancyStateT _o)
		{
			_o.Occupy = this.Occupy;
			_o.TargetWay = new List<int>();
			for (int i = 0; i < this.TargetWayLength; i++)
			{
				_o.TargetWay.Add(this.TargetWay(i));
			}
		}

		// Token: 0x060363E8 RID: 222184 RVA: 0x007440A0 File Offset: 0x007422A0
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

		// Token: 0x04012B05 RID: 76549
		private Table __p;
	}
}
