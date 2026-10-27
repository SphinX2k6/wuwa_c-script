using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200631A RID: 25370
	public struct IChangeRandomState : IFlatbufferObject
	{
		// Token: 0x1700BD65 RID: 48485
		// (get) Token: 0x0602BE17 RID: 179735 RVA: 0x006089DA File Offset: 0x00606BDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE18 RID: 179736 RVA: 0x006089E7 File Offset: 0x00606BE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE19 RID: 179737 RVA: 0x006089F0 File Offset: 0x00606BF0
		public static IChangeRandomState GetRootAsIChangeRandomState(ByteBuffer _bb)
		{
			return IChangeRandomState.GetRootAsIChangeRandomState(_bb, default(IChangeRandomState));
		}

		// Token: 0x0602BE1A RID: 179738 RVA: 0x00608A0C File Offset: 0x00606C0C
		public static IChangeRandomState GetRootAsIChangeRandomState(ByteBuffer _bb, IChangeRandomState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE1B RID: 179739 RVA: 0x00608A29 File Offset: 0x00606C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE1C RID: 179740 RVA: 0x00608A38 File Offset: 0x00606C38
		public IChangeRandomState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602BE1D RID: 179741 RVA: 0x00608A48 File Offset: 0x00606C48
		public int StateIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BD66 RID: 48486
		// (get) Token: 0x0602BE1E RID: 179742 RVA: 0x00608A88 File Offset: 0x00606C88
		public int StateIdsLength
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

		// Token: 0x0602BE1F RID: 179743 RVA: 0x00608AB3 File Offset: 0x00606CB3
		public Span<int> GetStateIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602BE20 RID: 179744 RVA: 0x00608AC2 File Offset: 0x00606CC2
		public int[] GetStateIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602BE21 RID: 179745 RVA: 0x00608AD0 File Offset: 0x00606CD0
		public static Offset<IChangeRandomState> CreateIChangeRandomState(FlatBufferBuilder builder, VectorOffset StateIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IChangeRandomState.AddStateIds(builder, StateIdsOffset);
			return IChangeRandomState.EndIChangeRandomState(builder);
		}

		// Token: 0x0602BE22 RID: 179746 RVA: 0x00608AE6 File Offset: 0x00606CE6
		public static void StartIChangeRandomState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BE23 RID: 179747 RVA: 0x00608AEF File Offset: 0x00606CEF
		public static void AddStateIds(FlatBufferBuilder builder, VectorOffset stateIdsOffset)
		{
			builder.AddOffset(0, stateIdsOffset.Value, 0);
		}

		// Token: 0x0602BE24 RID: 179748 RVA: 0x00608B00 File Offset: 0x00606D00
		public static VectorOffset CreateStateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BE25 RID: 179749 RVA: 0x00608B37 File Offset: 0x00606D37
		public static VectorOffset CreateStateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE26 RID: 179750 RVA: 0x00608B51 File Offset: 0x00606D51
		public static VectorOffset CreateStateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE27 RID: 179751 RVA: 0x00608B6F File Offset: 0x00606D6F
		public static VectorOffset CreateStateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BE28 RID: 179752 RVA: 0x00608B88 File Offset: 0x00606D88
		public static void StartStateIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BE29 RID: 179753 RVA: 0x00608B93 File Offset: 0x00606D93
		public static Offset<IChangeRandomState> EndIChangeRandomState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeRandomState>(builder.EndTable());
		}

		// Token: 0x0602BE2A RID: 179754 RVA: 0x00608BA0 File Offset: 0x00606DA0
		public IChangeRandomStateT UnPack()
		{
			IChangeRandomStateT changeRandomStateT = new IChangeRandomStateT();
			this.UnPackTo(changeRandomStateT);
			return changeRandomStateT;
		}

		// Token: 0x0602BE2B RID: 179755 RVA: 0x00608BBC File Offset: 0x00606DBC
		public void UnPackTo(IChangeRandomStateT _o)
		{
			_o.StateIds = new List<int>();
			for (int i = 0; i < this.StateIdsLength; i++)
			{
				_o.StateIds.Add(this.StateIds(i));
			}
		}

		// Token: 0x0602BE2C RID: 179756 RVA: 0x00608BF8 File Offset: 0x00606DF8
		public static Offset<IChangeRandomState> Pack(FlatBufferBuilder builder, IChangeRandomStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeRandomState>);
			}
			VectorOffset stateIdsOffset = default(VectorOffset);
			if (_o.StateIds != null)
			{
				int[] data = _o.StateIds.ToArray();
				stateIdsOffset = IChangeRandomState.CreateStateIdsVector(builder, data);
			}
			return IChangeRandomState.CreateIChangeRandomState(builder, stateIdsOffset);
		}

		// Token: 0x040108DE RID: 67806
		private Table __p;
	}
}
