using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA8 RID: 23720
	public struct IPasserbyNpcRandomGroup : IFlatbufferObject
	{
		// Token: 0x1700AE3D RID: 44605
		// (get) Token: 0x0602759D RID: 161181 RVA: 0x00562FFF File Offset: 0x005611FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602759E RID: 161182 RVA: 0x0056300C File Offset: 0x0056120C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602759F RID: 161183 RVA: 0x00563014 File Offset: 0x00561214
		public static IPasserbyNpcRandomGroup GetRootAsIPasserbyNpcRandomGroup(ByteBuffer _bb)
		{
			return IPasserbyNpcRandomGroup.GetRootAsIPasserbyNpcRandomGroup(_bb, default(IPasserbyNpcRandomGroup));
		}

		// Token: 0x060275A0 RID: 161184 RVA: 0x00563030 File Offset: 0x00561230
		public static IPasserbyNpcRandomGroup GetRootAsIPasserbyNpcRandomGroup(ByteBuffer _bb, IPasserbyNpcRandomGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060275A1 RID: 161185 RVA: 0x0056304D File Offset: 0x0056124D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060275A2 RID: 161186 RVA: 0x0056305C File Offset: 0x0056125C
		public IPasserbyNpcRandomGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE3E RID: 44606
		// (get) Token: 0x060275A3 RID: 161187 RVA: 0x0056306C File Offset: 0x0056126C
		public int Weight
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

		// Token: 0x1700AE3F RID: 44607
		// (get) Token: 0x060275A4 RID: 161188 RVA: 0x005630A8 File Offset: 0x005612A8
		public int NpcCount
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060275A5 RID: 161189 RVA: 0x005630E4 File Offset: 0x005612E4
		public IPasserbyNpcStandPos? StandPositions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IPasserbyNpcStandPos?(default(IPasserbyNpcStandPos).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE40 RID: 44608
		// (get) Token: 0x060275A6 RID: 161190 RVA: 0x00563144 File Offset: 0x00561344
		public int StandPositionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060275A7 RID: 161191 RVA: 0x0056316F File Offset: 0x0056136F
		public static Offset<IPasserbyNpcRandomGroup> CreateIPasserbyNpcRandomGroup(FlatBufferBuilder builder, int Weight = 0, int NpcCount = 0, VectorOffset StandPositionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IPasserbyNpcRandomGroup.AddStandPositions(builder, StandPositionsOffset);
			IPasserbyNpcRandomGroup.AddNpcCount(builder, NpcCount);
			IPasserbyNpcRandomGroup.AddWeight(builder, Weight);
			return IPasserbyNpcRandomGroup.EndIPasserbyNpcRandomGroup(builder);
		}

		// Token: 0x060275A8 RID: 161192 RVA: 0x00563193 File Offset: 0x00561393
		public static void StartIPasserbyNpcRandomGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060275A9 RID: 161193 RVA: 0x0056319C File Offset: 0x0056139C
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(0, weight, 0);
		}

		// Token: 0x060275AA RID: 161194 RVA: 0x005631A7 File Offset: 0x005613A7
		public static void AddNpcCount(FlatBufferBuilder builder, int npcCount)
		{
			builder.AddInt(1, npcCount, 0);
		}

		// Token: 0x060275AB RID: 161195 RVA: 0x005631B2 File Offset: 0x005613B2
		public static void AddStandPositions(FlatBufferBuilder builder, VectorOffset standPositionsOffset)
		{
			builder.AddOffset(2, standPositionsOffset.Value, 0);
		}

		// Token: 0x060275AC RID: 161196 RVA: 0x005631C4 File Offset: 0x005613C4
		public static VectorOffset CreateStandPositionsVector(FlatBufferBuilder builder, Offset<IPasserbyNpcStandPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060275AD RID: 161197 RVA: 0x00563204 File Offset: 0x00561404
		public static VectorOffset CreateStandPositionsVectorBlock(FlatBufferBuilder builder, Offset<IPasserbyNpcStandPos>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPasserbyNpcStandPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x060275AE RID: 161198 RVA: 0x0056321E File Offset: 0x0056141E
		public static VectorOffset CreateStandPositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPasserbyNpcStandPos>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPasserbyNpcStandPos>>(data);
			return builder.EndVector();
		}

		// Token: 0x060275AF RID: 161199 RVA: 0x0056323C File Offset: 0x0056143C
		public static VectorOffset CreateStandPositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPasserbyNpcStandPos>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060275B0 RID: 161200 RVA: 0x00563255 File Offset: 0x00561455
		public static void StartStandPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060275B1 RID: 161201 RVA: 0x00563260 File Offset: 0x00561460
		public static Offset<IPasserbyNpcRandomGroup> EndIPasserbyNpcRandomGroup(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcRandomGroup>(builder.EndTable());
		}

		// Token: 0x060275B2 RID: 161202 RVA: 0x00563270 File Offset: 0x00561470
		public IPasserbyNpcRandomGroupT UnPack()
		{
			IPasserbyNpcRandomGroupT passerbyNpcRandomGroupT = new IPasserbyNpcRandomGroupT();
			this.UnPackTo(passerbyNpcRandomGroupT);
			return passerbyNpcRandomGroupT;
		}

		// Token: 0x060275B3 RID: 161203 RVA: 0x0056328C File Offset: 0x0056148C
		public void UnPackTo(IPasserbyNpcRandomGroupT _o)
		{
			_o.Weight = this.Weight;
			_o.NpcCount = this.NpcCount;
			_o.StandPositions = new List<IPasserbyNpcStandPosT>();
			for (int i = 0; i < this.StandPositionsLength; i++)
			{
				_o.StandPositions.Add((this.StandPositions(i) != null) ? this.StandPositions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060275B4 RID: 161204 RVA: 0x00563304 File Offset: 0x00561504
		public static Offset<IPasserbyNpcRandomGroup> Pack(FlatBufferBuilder builder, IPasserbyNpcRandomGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcRandomGroup>);
			}
			VectorOffset standPositionsOffset = default(VectorOffset);
			if (_o.StandPositions != null)
			{
				Offset<IPasserbyNpcStandPos>[] array = new Offset<IPasserbyNpcStandPos>[_o.StandPositions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPasserbyNpcStandPos.Pack(builder, _o.StandPositions[i]);
				}
				standPositionsOffset = IPasserbyNpcRandomGroup.CreateStandPositionsVector(builder, array);
			}
			return IPasserbyNpcRandomGroup.CreateIPasserbyNpcRandomGroup(builder, _o.Weight, _o.NpcCount, standPositionsOffset);
		}

		// Token: 0x0400F7BC RID: 63420
		private Table __p;
	}
}
