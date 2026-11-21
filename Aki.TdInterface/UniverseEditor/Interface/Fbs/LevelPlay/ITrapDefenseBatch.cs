using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A1C RID: 18972
	public struct ITrapDefenseBatch : IFlatbufferObject
	{
		// Token: 0x17008516 RID: 34070
		// (get) Token: 0x0601C784 RID: 116612 RVA: 0x00405158 File Offset: 0x00403358
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C785 RID: 116613 RVA: 0x00405165 File Offset: 0x00403365
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C786 RID: 116614 RVA: 0x0040516C File Offset: 0x0040336C
		public static ITrapDefenseBatch GetRootAsITrapDefenseBatch(ByteBuffer _bb)
		{
			return ITrapDefenseBatch.GetRootAsITrapDefenseBatch(_bb, default(ITrapDefenseBatch));
		}

		// Token: 0x0601C787 RID: 116615 RVA: 0x00405188 File Offset: 0x00403388
		public static ITrapDefenseBatch GetRootAsITrapDefenseBatch(ByteBuffer _bb, ITrapDefenseBatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C788 RID: 116616 RVA: 0x004051A5 File Offset: 0x004033A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C789 RID: 116617 RVA: 0x004051B4 File Offset: 0x004033B4
		public ITrapDefenseBatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C78A RID: 116618 RVA: 0x004051C4 File Offset: 0x004033C4
		public int Ids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008517 RID: 34071
		// (get) Token: 0x0601C78B RID: 116619 RVA: 0x00405204 File Offset: 0x00403404
		public int IdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601C78C RID: 116620 RVA: 0x0040522F File Offset: 0x0040342F
		public Span<int> GetIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0601C78D RID: 116621 RVA: 0x0040523E File Offset: 0x0040343E
		public int[] GetIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x17008518 RID: 34072
		// (get) Token: 0x0601C78E RID: 116622 RVA: 0x0040524C File Offset: 0x0040344C
		public int RepeatTimes
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

		// Token: 0x0601C78F RID: 116623 RVA: 0x00405288 File Offset: 0x00403488
		public static Offset<ITrapDefenseBatch> CreateITrapDefenseBatch(FlatBufferBuilder builder, VectorOffset IdsOffset = default(VectorOffset), int RepeatTimes = 0)
		{
			builder.StartTable(2);
			ITrapDefenseBatch.AddRepeatTimes(builder, RepeatTimes);
			ITrapDefenseBatch.AddIds(builder, IdsOffset);
			return ITrapDefenseBatch.EndITrapDefenseBatch(builder);
		}

		// Token: 0x0601C790 RID: 116624 RVA: 0x004052A5 File Offset: 0x004034A5
		public static void StartITrapDefenseBatch(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C791 RID: 116625 RVA: 0x004052AE File Offset: 0x004034AE
		public static void AddIds(FlatBufferBuilder builder, VectorOffset idsOffset)
		{
			builder.AddOffset(0, idsOffset.Value, 0);
		}

		// Token: 0x0601C792 RID: 116626 RVA: 0x004052C0 File Offset: 0x004034C0
		public static VectorOffset CreateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C793 RID: 116627 RVA: 0x004052F7 File Offset: 0x004034F7
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C794 RID: 116628 RVA: 0x00405311 File Offset: 0x00403511
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C795 RID: 116629 RVA: 0x0040532F File Offset: 0x0040352F
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C796 RID: 116630 RVA: 0x00405348 File Offset: 0x00403548
		public static void StartIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C797 RID: 116631 RVA: 0x00405353 File Offset: 0x00403553
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(1, repeatTimes, 0);
		}

		// Token: 0x0601C798 RID: 116632 RVA: 0x0040535E File Offset: 0x0040355E
		public static Offset<ITrapDefenseBatch> EndITrapDefenseBatch(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseBatch>(builder.EndTable());
		}

		// Token: 0x0601C799 RID: 116633 RVA: 0x0040536C File Offset: 0x0040356C
		public ITrapDefenseBatchT UnPack()
		{
			ITrapDefenseBatchT trapDefenseBatchT = new ITrapDefenseBatchT();
			this.UnPackTo(trapDefenseBatchT);
			return trapDefenseBatchT;
		}

		// Token: 0x0601C79A RID: 116634 RVA: 0x00405388 File Offset: 0x00403588
		public void UnPackTo(ITrapDefenseBatchT _o)
		{
			_o.Ids = new List<int>();
			for (int i = 0; i < this.IdsLength; i++)
			{
				_o.Ids.Add(this.Ids(i));
			}
			_o.RepeatTimes = this.RepeatTimes;
		}

		// Token: 0x0601C79B RID: 116635 RVA: 0x004053D0 File Offset: 0x004035D0
		public static Offset<ITrapDefenseBatch> Pack(FlatBufferBuilder builder, ITrapDefenseBatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseBatch>);
			}
			VectorOffset idsOffset = default(VectorOffset);
			if (_o.Ids != null)
			{
				int[] data = _o.Ids.ToArray();
				idsOffset = ITrapDefenseBatch.CreateIdsVector(builder, data);
			}
			return ITrapDefenseBatch.CreateITrapDefenseBatch(builder, idsOffset, _o.RepeatTimes);
		}

		// Token: 0x0400D0AD RID: 53421
		private Table __p;
	}
}
