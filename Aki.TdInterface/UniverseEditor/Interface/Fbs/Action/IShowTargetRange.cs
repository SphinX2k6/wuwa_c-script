using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D2 RID: 30930
	public struct IShowTargetRange : IFlatbufferObject
	{
		// Token: 0x1700E2F8 RID: 58104
		// (get) Token: 0x06036749 RID: 223049 RVA: 0x0074A9DA File Offset: 0x00748BDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603674A RID: 223050 RVA: 0x0074A9E7 File Offset: 0x00748BE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603674B RID: 223051 RVA: 0x0074A9F0 File Offset: 0x00748BF0
		public static IShowTargetRange GetRootAsIShowTargetRange(ByteBuffer _bb)
		{
			return IShowTargetRange.GetRootAsIShowTargetRange(_bb, default(IShowTargetRange));
		}

		// Token: 0x0603674C RID: 223052 RVA: 0x0074AA0C File Offset: 0x00748C0C
		public static IShowTargetRange GetRootAsIShowTargetRange(ByteBuffer _bb, IShowTargetRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603674D RID: 223053 RVA: 0x0074AA29 File Offset: 0x00748C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603674E RID: 223054 RVA: 0x0074AA38 File Offset: 0x00748C38
		public IShowTargetRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603674F RID: 223055 RVA: 0x0074AA48 File Offset: 0x00748C48
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E2F9 RID: 58105
		// (get) Token: 0x06036750 RID: 223056 RVA: 0x0074AA88 File Offset: 0x00748C88
		public int RangeEntitiesLength
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

		// Token: 0x06036751 RID: 223057 RVA: 0x0074AAB3 File Offset: 0x00748CB3
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06036752 RID: 223058 RVA: 0x0074AAC2 File Offset: 0x00748CC2
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700E2FA RID: 58106
		// (get) Token: 0x06036753 RID: 223059 RVA: 0x0074AAD0 File Offset: 0x00748CD0
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06036754 RID: 223060 RVA: 0x0074AB0F File Offset: 0x00748D0F
		public static Offset<IShowTargetRange> CreateIShowTargetRange(FlatBufferBuilder builder, VectorOffset RangeEntitiesOffset = default(VectorOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IShowTargetRange.AddRangeEntities(builder, RangeEntitiesOffset);
			IShowTargetRange.AddDelayShow(builder, DelayShow);
			return IShowTargetRange.EndIShowTargetRange(builder);
		}

		// Token: 0x06036755 RID: 223061 RVA: 0x0074AB2C File Offset: 0x00748D2C
		public static void StartIShowTargetRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036756 RID: 223062 RVA: 0x0074AB35 File Offset: 0x00748D35
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(0, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06036757 RID: 223063 RVA: 0x0074AB48 File Offset: 0x00748D48
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036758 RID: 223064 RVA: 0x0074AB7F File Offset: 0x00748D7F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06036759 RID: 223065 RVA: 0x0074AB99 File Offset: 0x00748D99
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603675A RID: 223066 RVA: 0x0074ABB7 File Offset: 0x00748DB7
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603675B RID: 223067 RVA: 0x0074ABD0 File Offset: 0x00748DD0
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603675C RID: 223068 RVA: 0x0074ABDB File Offset: 0x00748DDB
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x0603675D RID: 223069 RVA: 0x0074ABE6 File Offset: 0x00748DE6
		public static Offset<IShowTargetRange> EndIShowTargetRange(FlatBufferBuilder builder)
		{
			return new Offset<IShowTargetRange>(builder.EndTable());
		}

		// Token: 0x0603675E RID: 223070 RVA: 0x0074ABF4 File Offset: 0x00748DF4
		public IShowTargetRangeT UnPack()
		{
			IShowTargetRangeT showTargetRangeT = new IShowTargetRangeT();
			this.UnPackTo(showTargetRangeT);
			return showTargetRangeT;
		}

		// Token: 0x0603675F RID: 223071 RVA: 0x0074AC10 File Offset: 0x00748E10
		public void UnPackTo(IShowTargetRangeT _o)
		{
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x06036760 RID: 223072 RVA: 0x0074AC58 File Offset: 0x00748E58
		public static Offset<IShowTargetRange> Pack(FlatBufferBuilder builder, IShowTargetRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTargetRange>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IShowTargetRange.CreateRangeEntitiesVector(builder, data);
			}
			return IShowTargetRange.CreateIShowTargetRange(builder, rangeEntitiesOffset, _o.DelayShow);
		}

		// Token: 0x04012B82 RID: 76674
		private Table __p;
	}
}
