using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C2E RID: 19502
	public struct IGramophoneCheckCondition : IFlatbufferObject
	{
		// Token: 0x17008DAA RID: 36266
		// (get) Token: 0x0601EE67 RID: 126567 RVA: 0x00452F7E File Offset: 0x0045117E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE68 RID: 126568 RVA: 0x00452F8B File Offset: 0x0045118B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE69 RID: 126569 RVA: 0x00452F94 File Offset: 0x00451194
		public static IGramophoneCheckCondition GetRootAsIGramophoneCheckCondition(ByteBuffer _bb)
		{
			return IGramophoneCheckCondition.GetRootAsIGramophoneCheckCondition(_bb, default(IGramophoneCheckCondition));
		}

		// Token: 0x0601EE6A RID: 126570 RVA: 0x00452FB0 File Offset: 0x004511B0
		public static IGramophoneCheckCondition GetRootAsIGramophoneCheckCondition(ByteBuffer _bb, IGramophoneCheckCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE6B RID: 126571 RVA: 0x00452FCD File Offset: 0x004511CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE6C RID: 126572 RVA: 0x00452FDC File Offset: 0x004511DC
		public IGramophoneCheckCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DAB RID: 36267
		// (get) Token: 0x0601EE6D RID: 126573 RVA: 0x00452FEC File Offset: 0x004511EC
		public ECommonMatchType CheckType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonMatchType.MatchAll;
				}
				return (ECommonMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EE6E RID: 126574 RVA: 0x00453028 File Offset: 0x00451228
		public int PlayList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008DAC RID: 36268
		// (get) Token: 0x0601EE6F RID: 126575 RVA: 0x00453068 File Offset: 0x00451268
		public int PlayListLength
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

		// Token: 0x0601EE70 RID: 126576 RVA: 0x00453093 File Offset: 0x00451293
		public Span<int> GetPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601EE71 RID: 126577 RVA: 0x004530A2 File Offset: 0x004512A2
		public int[] GetPlayListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601EE72 RID: 126578 RVA: 0x004530B0 File Offset: 0x004512B0
		public static Offset<IGramophoneCheckCondition> CreateIGramophoneCheckCondition(FlatBufferBuilder builder, ECommonMatchType CheckType = ECommonMatchType.MatchAll, VectorOffset PlayListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGramophoneCheckCondition.AddPlayList(builder, PlayListOffset);
			IGramophoneCheckCondition.AddCheckType(builder, CheckType);
			return IGramophoneCheckCondition.EndIGramophoneCheckCondition(builder);
		}

		// Token: 0x0601EE73 RID: 126579 RVA: 0x004530CD File Offset: 0x004512CD
		public static void StartIGramophoneCheckCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EE74 RID: 126580 RVA: 0x004530D6 File Offset: 0x004512D6
		public static void AddCheckType(FlatBufferBuilder builder, ECommonMatchType checkType)
		{
			builder.AddByte(0, (byte)checkType, 0);
		}

		// Token: 0x0601EE75 RID: 126581 RVA: 0x004530E1 File Offset: 0x004512E1
		public static void AddPlayList(FlatBufferBuilder builder, VectorOffset playListOffset)
		{
			builder.AddOffset(1, playListOffset.Value, 0);
		}

		// Token: 0x0601EE76 RID: 126582 RVA: 0x004530F4 File Offset: 0x004512F4
		public static VectorOffset CreatePlayListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EE77 RID: 126583 RVA: 0x0045312B File Offset: 0x0045132B
		public static VectorOffset CreatePlayListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE78 RID: 126584 RVA: 0x00453145 File Offset: 0x00451345
		public static VectorOffset CreatePlayListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EE79 RID: 126585 RVA: 0x00453163 File Offset: 0x00451363
		public static VectorOffset CreatePlayListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EE7A RID: 126586 RVA: 0x0045317C File Offset: 0x0045137C
		public static void StartPlayListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EE7B RID: 126587 RVA: 0x00453187 File Offset: 0x00451387
		public static Offset<IGramophoneCheckCondition> EndIGramophoneCheckCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGramophoneCheckCondition>(builder.EndTable());
		}

		// Token: 0x0601EE7C RID: 126588 RVA: 0x00453194 File Offset: 0x00451394
		public IGramophoneCheckConditionT UnPack()
		{
			IGramophoneCheckConditionT gramophoneCheckConditionT = new IGramophoneCheckConditionT();
			this.UnPackTo(gramophoneCheckConditionT);
			return gramophoneCheckConditionT;
		}

		// Token: 0x0601EE7D RID: 126589 RVA: 0x004531B0 File Offset: 0x004513B0
		public void UnPackTo(IGramophoneCheckConditionT _o)
		{
			_o.CheckType = this.CheckType;
			_o.PlayList = new List<int>();
			for (int i = 0; i < this.PlayListLength; i++)
			{
				_o.PlayList.Add(this.PlayList(i));
			}
		}

		// Token: 0x0601EE7E RID: 126590 RVA: 0x004531F8 File Offset: 0x004513F8
		public static Offset<IGramophoneCheckCondition> Pack(FlatBufferBuilder builder, IGramophoneCheckConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGramophoneCheckCondition>);
			}
			VectorOffset playListOffset = default(VectorOffset);
			if (_o.PlayList != null)
			{
				int[] data = _o.PlayList.ToArray();
				playListOffset = IGramophoneCheckCondition.CreatePlayListVector(builder, data);
			}
			return IGramophoneCheckCondition.CreateIGramophoneCheckCondition(builder, _o.CheckType, playListOffset);
		}

		// Token: 0x0400D5D0 RID: 54736
		private Table __p;
	}
}
