using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007340 RID: 29504
	public struct ITalkOptionPreOption : IFlatbufferObject
	{
		// Token: 0x1700E00F RID: 57359
		// (get) Token: 0x060358A6 RID: 219302 RVA: 0x0074AF88 File Offset: 0x00749188
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358A7 RID: 219303 RVA: 0x0074AF95 File Offset: 0x00749195
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358A8 RID: 219304 RVA: 0x0074AF9C File Offset: 0x0074919C
		public static ITalkOptionPreOption GetRootAsITalkOptionPreOption(ByteBuffer _bb)
		{
			return ITalkOptionPreOption.GetRootAsITalkOptionPreOption(_bb, default(ITalkOptionPreOption));
		}

		// Token: 0x060358A9 RID: 219305 RVA: 0x0074AFB8 File Offset: 0x007491B8
		public static ITalkOptionPreOption GetRootAsITalkOptionPreOption(ByteBuffer _bb, ITalkOptionPreOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358AA RID: 219306 RVA: 0x0074AFD5 File Offset: 0x007491D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358AB RID: 219307 RVA: 0x0074AFE4 File Offset: 0x007491E4
		public ITalkOptionPreOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E010 RID: 57360
		// (get) Token: 0x060358AC RID: 219308 RVA: 0x0074AFF4 File Offset: 0x007491F4
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

		// Token: 0x060358AD RID: 219309 RVA: 0x0074B030 File Offset: 0x00749230
		public int PreOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E011 RID: 57361
		// (get) Token: 0x060358AE RID: 219310 RVA: 0x0074B070 File Offset: 0x00749270
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

		// Token: 0x060358AF RID: 219311 RVA: 0x0074B09B File Offset: 0x0074929B
		public Span<int> GetPreOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060358B0 RID: 219312 RVA: 0x0074B0AA File Offset: 0x007492AA
		public int[] GetPreOptionsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060358B1 RID: 219313 RVA: 0x0074B0B8 File Offset: 0x007492B8
		public static Offset<ITalkOptionPreOption> CreateITalkOptionPreOption(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption, VectorOffset PreOptionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITalkOptionPreOption.AddPreOptions(builder, PreOptionsOffset);
			ITalkOptionPreOption.AddType(builder, Type);
			return ITalkOptionPreOption.EndITalkOptionPreOption(builder);
		}

		// Token: 0x060358B2 RID: 219314 RVA: 0x0074B0D5 File Offset: 0x007492D5
		public static void StartITalkOptionPreOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060358B3 RID: 219315 RVA: 0x0074B0DE File Offset: 0x007492DE
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060358B4 RID: 219316 RVA: 0x0074B0E9 File Offset: 0x007492E9
		public static void AddPreOptions(FlatBufferBuilder builder, VectorOffset preOptionsOffset)
		{
			builder.AddOffset(1, preOptionsOffset.Value, 0);
		}

		// Token: 0x060358B5 RID: 219317 RVA: 0x0074B0FC File Offset: 0x007492FC
		public static VectorOffset CreatePreOptionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060358B6 RID: 219318 RVA: 0x0074B133 File Offset: 0x00749333
		public static VectorOffset CreatePreOptionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060358B7 RID: 219319 RVA: 0x0074B14D File Offset: 0x0074934D
		public static VectorOffset CreatePreOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060358B8 RID: 219320 RVA: 0x0074B16B File Offset: 0x0074936B
		public static VectorOffset CreatePreOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060358B9 RID: 219321 RVA: 0x0074B184 File Offset: 0x00749384
		public static void StartPreOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060358BA RID: 219322 RVA: 0x0074B18F File Offset: 0x0074938F
		public static Offset<ITalkOptionPreOption> EndITalkOptionPreOption(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionPreOption>(builder.EndTable());
		}

		// Token: 0x060358BB RID: 219323 RVA: 0x0074B19C File Offset: 0x0074939C
		public ITalkOptionPreOptionT UnPack()
		{
			ITalkOptionPreOptionT talkOptionPreOptionT = new ITalkOptionPreOptionT();
			this.UnPackTo(talkOptionPreOptionT);
			return talkOptionPreOptionT;
		}

		// Token: 0x060358BC RID: 219324 RVA: 0x0074B1B8 File Offset: 0x007493B8
		public void UnPackTo(ITalkOptionPreOptionT _o)
		{
			_o.Type = this.Type;
			_o.PreOptions = new List<int>();
			for (int i = 0; i < this.PreOptionsLength; i++)
			{
				_o.PreOptions.Add(this.PreOptions(i));
			}
		}

		// Token: 0x060358BD RID: 219325 RVA: 0x0074B200 File Offset: 0x00749400
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

		// Token: 0x0401213B RID: 74043
		private Table __p;
	}
}
