using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EFF RID: 16127
	public struct ILevelPlayRecallConfig : IFlatbufferObject
	{
		// Token: 0x17006FDD RID: 28637
		// (get) Token: 0x06016D34 RID: 93492 RVA: 0x0034AC78 File Offset: 0x00348E78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D35 RID: 93493 RVA: 0x0034AC85 File Offset: 0x00348E85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D36 RID: 93494 RVA: 0x0034AC8C File Offset: 0x00348E8C
		public static ILevelPlayRecallConfig GetRootAsILevelPlayRecallConfig(ByteBuffer _bb)
		{
			return ILevelPlayRecallConfig.GetRootAsILevelPlayRecallConfig(_bb, default(ILevelPlayRecallConfig));
		}

		// Token: 0x06016D37 RID: 93495 RVA: 0x0034ACA8 File Offset: 0x00348EA8
		public static ILevelPlayRecallConfig GetRootAsILevelPlayRecallConfig(ByteBuffer _bb, ILevelPlayRecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D38 RID: 93496 RVA: 0x0034ACC5 File Offset: 0x00348EC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D39 RID: 93497 RVA: 0x0034ACD4 File Offset: 0x00348ED4
		public ILevelPlayRecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FDE RID: 28638
		// (get) Token: 0x06016D3A RID: 93498 RVA: 0x0034ACE4 File Offset: 0x00348EE4
		public int RecallId
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

		// Token: 0x06016D3B RID: 93499 RVA: 0x0034AD20 File Offset: 0x00348F20
		public int RecallEntityList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006FDF RID: 28639
		// (get) Token: 0x06016D3C RID: 93500 RVA: 0x0034AD60 File Offset: 0x00348F60
		public int RecallEntityListLength
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

		// Token: 0x06016D3D RID: 93501 RVA: 0x0034AD8B File Offset: 0x00348F8B
		public Span<int> GetRecallEntityListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06016D3E RID: 93502 RVA: 0x0034AD9A File Offset: 0x00348F9A
		public int[] GetRecallEntityListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06016D3F RID: 93503 RVA: 0x0034ADA8 File Offset: 0x00348FA8
		public static Offset<ILevelPlayRecallConfig> CreateILevelPlayRecallConfig(FlatBufferBuilder builder, int RecallId = 0, VectorOffset RecallEntityListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlayRecallConfig.AddRecallEntityList(builder, RecallEntityListOffset);
			ILevelPlayRecallConfig.AddRecallId(builder, RecallId);
			return ILevelPlayRecallConfig.EndILevelPlayRecallConfig(builder);
		}

		// Token: 0x06016D40 RID: 93504 RVA: 0x0034ADC5 File Offset: 0x00348FC5
		public static void StartILevelPlayRecallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016D41 RID: 93505 RVA: 0x0034ADCE File Offset: 0x00348FCE
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x06016D42 RID: 93506 RVA: 0x0034ADD9 File Offset: 0x00348FD9
		public static void AddRecallEntityList(FlatBufferBuilder builder, VectorOffset recallEntityListOffset)
		{
			builder.AddOffset(1, recallEntityListOffset.Value, 0);
		}

		// Token: 0x06016D43 RID: 93507 RVA: 0x0034ADEC File Offset: 0x00348FEC
		public static VectorOffset CreateRecallEntityListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016D44 RID: 93508 RVA: 0x0034AE23 File Offset: 0x00349023
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D45 RID: 93509 RVA: 0x0034AE3D File Offset: 0x0034903D
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D46 RID: 93510 RVA: 0x0034AE5B File Offset: 0x0034905B
		public static VectorOffset CreateRecallEntityListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016D47 RID: 93511 RVA: 0x0034AE74 File Offset: 0x00349074
		public static void StartRecallEntityListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016D48 RID: 93512 RVA: 0x0034AE7F File Offset: 0x0034907F
		public static Offset<ILevelPlayRecallConfig> EndILevelPlayRecallConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayRecallConfig>(builder.EndTable());
		}

		// Token: 0x06016D49 RID: 93513 RVA: 0x0034AE8C File Offset: 0x0034908C
		public ILevelPlayRecallConfigT UnPack()
		{
			ILevelPlayRecallConfigT levelPlayRecallConfigT = new ILevelPlayRecallConfigT();
			this.UnPackTo(levelPlayRecallConfigT);
			return levelPlayRecallConfigT;
		}

		// Token: 0x06016D4A RID: 93514 RVA: 0x0034AEA8 File Offset: 0x003490A8
		public void UnPackTo(ILevelPlayRecallConfigT _o)
		{
			_o.RecallId = this.RecallId;
			_o.RecallEntityList = new List<int>();
			for (int i = 0; i < this.RecallEntityListLength; i++)
			{
				_o.RecallEntityList.Add(this.RecallEntityList(i));
			}
		}

		// Token: 0x06016D4B RID: 93515 RVA: 0x0034AEF0 File Offset: 0x003490F0
		public static Offset<ILevelPlayRecallConfig> Pack(FlatBufferBuilder builder, ILevelPlayRecallConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayRecallConfig>);
			}
			VectorOffset recallEntityListOffset = default(VectorOffset);
			if (_o.RecallEntityList != null)
			{
				int[] data = _o.RecallEntityList.ToArray();
				recallEntityListOffset = ILevelPlayRecallConfig.CreateRecallEntityListVector(builder, data);
			}
			return ILevelPlayRecallConfig.CreateILevelPlayRecallConfig(builder, _o.RecallId, recallEntityListOffset);
		}

		// Token: 0x0400B8DC RID: 47324
		private Table __p;
	}
}
