using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200477B RID: 18299
	public struct IBlueprintConfig : IFlatbufferObject
	{
		// Token: 0x17008335 RID: 33589
		// (get) Token: 0x0601C2A5 RID: 115365 RVA: 0x003FD3DC File Offset: 0x003FB5DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C2A6 RID: 115366 RVA: 0x003FD3E9 File Offset: 0x003FB5E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C2A7 RID: 115367 RVA: 0x003FD3F0 File Offset: 0x003FB5F0
		public static IBlueprintConfig GetRootAsIBlueprintConfig(ByteBuffer _bb)
		{
			return IBlueprintConfig.GetRootAsIBlueprintConfig(_bb, default(IBlueprintConfig));
		}

		// Token: 0x0601C2A8 RID: 115368 RVA: 0x003FD40C File Offset: 0x003FB60C
		public static IBlueprintConfig GetRootAsIBlueprintConfig(ByteBuffer _bb, IBlueprintConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C2A9 RID: 115369 RVA: 0x003FD429 File Offset: 0x003FB629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C2AA RID: 115370 RVA: 0x003FD438 File Offset: 0x003FB638
		public IBlueprintConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C2AB RID: 115371 RVA: 0x003FD448 File Offset: 0x003FB648
		public Record_String_IBlueprintItem? BlueprintConfig(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_IBlueprintItem?(default(Record_String_IBlueprintItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008336 RID: 33590
		// (get) Token: 0x0601C2AC RID: 115372 RVA: 0x003FD4A8 File Offset: 0x003FB6A8
		public int BlueprintConfigLength
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

		// Token: 0x0601C2AD RID: 115373 RVA: 0x003FD4D3 File Offset: 0x003FB6D3
		public static Offset<IBlueprintConfig> CreateIBlueprintConfig(FlatBufferBuilder builder, VectorOffset BlueprintConfigOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBlueprintConfig.AddBlueprintConfig(builder, BlueprintConfigOffset);
			return IBlueprintConfig.EndIBlueprintConfig(builder);
		}

		// Token: 0x0601C2AE RID: 115374 RVA: 0x003FD4E9 File Offset: 0x003FB6E9
		public static void StartIBlueprintConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C2AF RID: 115375 RVA: 0x003FD4F2 File Offset: 0x003FB6F2
		public static void AddBlueprintConfig(FlatBufferBuilder builder, VectorOffset blueprintConfigOffset)
		{
			builder.AddOffset(0, blueprintConfigOffset.Value, 0);
		}

		// Token: 0x0601C2B0 RID: 115376 RVA: 0x003FD504 File Offset: 0x003FB704
		public static VectorOffset CreateBlueprintConfigVector(FlatBufferBuilder builder, Offset<Record_String_IBlueprintItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C2B1 RID: 115377 RVA: 0x003FD544 File Offset: 0x003FB744
		public static VectorOffset CreateBlueprintConfigVectorBlock(FlatBufferBuilder builder, Offset<Record_String_IBlueprintItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_IBlueprintItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2B2 RID: 115378 RVA: 0x003FD55E File Offset: 0x003FB75E
		public static VectorOffset CreateBlueprintConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_IBlueprintItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_IBlueprintItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C2B3 RID: 115379 RVA: 0x003FD57C File Offset: 0x003FB77C
		public static VectorOffset CreateBlueprintConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_IBlueprintItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C2B4 RID: 115380 RVA: 0x003FD595 File Offset: 0x003FB795
		public static void StartBlueprintConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C2B5 RID: 115381 RVA: 0x003FD5A0 File Offset: 0x003FB7A0
		public static Offset<IBlueprintConfig> EndIBlueprintConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBlueprintConfig>(builder.EndTable());
		}

		// Token: 0x0601C2B6 RID: 115382 RVA: 0x003FD5B0 File Offset: 0x003FB7B0
		public IBlueprintConfigT UnPack()
		{
			IBlueprintConfigT blueprintConfigT = new IBlueprintConfigT();
			this.UnPackTo(blueprintConfigT);
			return blueprintConfigT;
		}

		// Token: 0x0601C2B7 RID: 115383 RVA: 0x003FD5CC File Offset: 0x003FB7CC
		public void UnPackTo(IBlueprintConfigT _o)
		{
			_o.BlueprintConfig = new List<Record_String_IBlueprintItemT>();
			for (int i = 0; i < this.BlueprintConfigLength; i++)
			{
				_o.BlueprintConfig.Add((this.BlueprintConfig(i) != null) ? this.BlueprintConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C2B8 RID: 115384 RVA: 0x003FD62C File Offset: 0x003FB82C
		public static Offset<IBlueprintConfig> Pack(FlatBufferBuilder builder, IBlueprintConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlueprintConfig>);
			}
			VectorOffset blueprintConfigOffset = default(VectorOffset);
			if (_o.BlueprintConfig != null)
			{
				Offset<Record_String_IBlueprintItem>[] array = new Offset<Record_String_IBlueprintItem>[_o.BlueprintConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Record_String_IBlueprintItem.Pack(builder, _o.BlueprintConfig[i]);
				}
				blueprintConfigOffset = IBlueprintConfig.CreateBlueprintConfigVector(builder, array);
			}
			return IBlueprintConfig.CreateIBlueprintConfig(builder, blueprintConfigOffset);
		}

		// Token: 0x0400CBD6 RID: 52182
		private Table __p;
	}
}
