using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B18 RID: 31512
	public struct ITalkOptionPreOption : IFlatbufferObject
	{
		// Token: 0x1700EC0B RID: 60427
		// (get) Token: 0x06038BD9 RID: 232409 RVA: 0x007ACB10 File Offset: 0x007AAD10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038BDA RID: 232410 RVA: 0x007ACB1D File Offset: 0x007AAD1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038BDB RID: 232411 RVA: 0x007ACB24 File Offset: 0x007AAD24
		public static ITalkOptionPreOption GetRootAsITalkOptionPreOption(ByteBuffer _bb)
		{
			return ITalkOptionPreOption.GetRootAsITalkOptionPreOption(_bb, default(ITalkOptionPreOption));
		}

		// Token: 0x06038BDC RID: 232412 RVA: 0x007ACB40 File Offset: 0x007AAD40
		public static ITalkOptionPreOption GetRootAsITalkOptionPreOption(ByteBuffer _bb, ITalkOptionPreOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038BDD RID: 232413 RVA: 0x007ACB5D File Offset: 0x007AAD5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038BDE RID: 232414 RVA: 0x007ACB6C File Offset: 0x007AAD6C
		public ITalkOptionPreOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC0C RID: 60428
		// (get) Token: 0x06038BDF RID: 232415 RVA: 0x007ACB7C File Offset: 0x007AAD7C
		public ETalkOptionPreConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return (ETalkOptionPreConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038BE0 RID: 232416 RVA: 0x007ACBB8 File Offset: 0x007AADB8
		public int PreOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EC0D RID: 60429
		// (get) Token: 0x06038BE1 RID: 232417 RVA: 0x007ACBF8 File Offset: 0x007AADF8
		public int PreOptionsLength
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

		// Token: 0x06038BE2 RID: 232418 RVA: 0x007ACC23 File Offset: 0x007AAE23
		public Span<int> GetPreOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06038BE3 RID: 232419 RVA: 0x007ACC32 File Offset: 0x007AAE32
		public int[] GetPreOptionsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06038BE4 RID: 232420 RVA: 0x007ACC40 File Offset: 0x007AAE40
		public static Offset<ITalkOptionPreOption> CreateITalkOptionPreOption(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption, VectorOffset PreOptionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITalkOptionPreOption.AddPreOptions(builder, PreOptionsOffset);
			ITalkOptionPreOption.AddType(builder, Type);
			return ITalkOptionPreOption.EndITalkOptionPreOption(builder);
		}

		// Token: 0x06038BE5 RID: 232421 RVA: 0x007ACC5D File Offset: 0x007AAE5D
		public static void StartITalkOptionPreOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038BE6 RID: 232422 RVA: 0x007ACC66 File Offset: 0x007AAE66
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038BE7 RID: 232423 RVA: 0x007ACC71 File Offset: 0x007AAE71
		public static void AddPreOptions(FlatBufferBuilder builder, VectorOffset preOptionsOffset)
		{
			builder.AddOffset(1, preOptionsOffset.Value, 0);
		}

		// Token: 0x06038BE8 RID: 232424 RVA: 0x007ACC84 File Offset: 0x007AAE84
		public static VectorOffset CreatePreOptionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06038BE9 RID: 232425 RVA: 0x007ACCBB File Offset: 0x007AAEBB
		public static VectorOffset CreatePreOptionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038BEA RID: 232426 RVA: 0x007ACCD5 File Offset: 0x007AAED5
		public static VectorOffset CreatePreOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06038BEB RID: 232427 RVA: 0x007ACCF3 File Offset: 0x007AAEF3
		public static VectorOffset CreatePreOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038BEC RID: 232428 RVA: 0x007ACD0C File Offset: 0x007AAF0C
		public static void StartPreOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038BED RID: 232429 RVA: 0x007ACD17 File Offset: 0x007AAF17
		public static Offset<ITalkOptionPreOption> EndITalkOptionPreOption(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionPreOption>(builder.EndTable());
		}

		// Token: 0x06038BEE RID: 232430 RVA: 0x007ACD24 File Offset: 0x007AAF24
		public ITalkOptionPreOptionT UnPack()
		{
			ITalkOptionPreOptionT talkOptionPreOptionT = new ITalkOptionPreOptionT();
			this.UnPackTo(talkOptionPreOptionT);
			return talkOptionPreOptionT;
		}

		// Token: 0x06038BEF RID: 232431 RVA: 0x007ACD40 File Offset: 0x007AAF40
		public void UnPackTo(ITalkOptionPreOptionT _o)
		{
			_o.Type = this.Type;
			_o.PreOptions = new List<int>();
			for (int i = 0; i < this.PreOptionsLength; i++)
			{
				_o.PreOptions.Add(this.PreOptions(i));
			}
		}

		// Token: 0x06038BF0 RID: 232432 RVA: 0x007ACD88 File Offset: 0x007AAF88
		public static Offset<ITalkOptionPreOption> Pack(FlatBufferBuilder builder, ITalkOptionPreOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionPreOption>);
			}
			VectorOffset preOptionsOffset = default(VectorOffset);
			if (_o.PreOptions != null)
			{
				int[] data = _o.PreOptions.ToArray();
				preOptionsOffset = ITalkOptionPreOption.CreatePreOptionsVector(builder, data);
			}
			return ITalkOptionPreOption.CreateITalkOptionPreOption(builder, _o.Type, preOptionsOffset);
		}

		// Token: 0x04013141 RID: 78145
		private Table __p;
	}
}
