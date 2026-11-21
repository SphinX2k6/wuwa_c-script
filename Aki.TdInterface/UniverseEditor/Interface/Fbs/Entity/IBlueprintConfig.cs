using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE3 RID: 19427
	public struct IBlueprintConfig : IFlatbufferObject
	{
		// Token: 0x17008976 RID: 35190
		// (get) Token: 0x0601DA7A RID: 121466 RVA: 0x00429678 File Offset: 0x00427878
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA7B RID: 121467 RVA: 0x00429685 File Offset: 0x00427885
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA7C RID: 121468 RVA: 0x0042968C File Offset: 0x0042788C
		public static IBlueprintConfig GetRootAsIBlueprintConfig(ByteBuffer _bb)
		{
			return IBlueprintConfig.GetRootAsIBlueprintConfig(_bb, default(IBlueprintConfig));
		}

		// Token: 0x0601DA7D RID: 121469 RVA: 0x004296A8 File Offset: 0x004278A8
		public static IBlueprintConfig GetRootAsIBlueprintConfig(ByteBuffer _bb, IBlueprintConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA7E RID: 121470 RVA: 0x004296C5 File Offset: 0x004278C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA7F RID: 121471 RVA: 0x004296D4 File Offset: 0x004278D4
		public IBlueprintConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DA80 RID: 121472 RVA: 0x004296E4 File Offset: 0x004278E4
		public Record_String_IBlueprintItem? BlueprintConfig(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new Record_String_IBlueprintItem?(default(Record_String_IBlueprintItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008977 RID: 35191
		// (get) Token: 0x0601DA81 RID: 121473 RVA: 0x00429744 File Offset: 0x00427944
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

		// Token: 0x0601DA82 RID: 121474 RVA: 0x0042976F File Offset: 0x0042796F
		public static Offset<IBlueprintConfig> CreateIBlueprintConfig(FlatBufferBuilder builder, VectorOffset BlueprintConfigOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBlueprintConfig.AddBlueprintConfig(builder, BlueprintConfigOffset);
			return IBlueprintConfig.EndIBlueprintConfig(builder);
		}

		// Token: 0x0601DA83 RID: 121475 RVA: 0x00429785 File Offset: 0x00427985
		public static void StartIBlueprintConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DA84 RID: 121476 RVA: 0x0042978E File Offset: 0x0042798E
		public static void AddBlueprintConfig(FlatBufferBuilder builder, VectorOffset blueprintConfigOffset)
		{
			builder.AddOffset(0, blueprintConfigOffset.Value, 0);
		}

		// Token: 0x0601DA85 RID: 121477 RVA: 0x004297A0 File Offset: 0x004279A0
		public static VectorOffset CreateBlueprintConfigVector(FlatBufferBuilder builder, Offset<Record_String_IBlueprintItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DA86 RID: 121478 RVA: 0x004297E0 File Offset: 0x004279E0
		public static VectorOffset CreateBlueprintConfigVectorBlock(FlatBufferBuilder builder, Offset<Record_String_IBlueprintItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_String_IBlueprintItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA87 RID: 121479 RVA: 0x004297FA File Offset: 0x004279FA
		public static VectorOffset CreateBlueprintConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_String_IBlueprintItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_String_IBlueprintItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA88 RID: 121480 RVA: 0x00429818 File Offset: 0x00427A18
		public static VectorOffset CreateBlueprintConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_String_IBlueprintItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DA89 RID: 121481 RVA: 0x00429831 File Offset: 0x00427A31
		public static void StartBlueprintConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DA8A RID: 121482 RVA: 0x0042983C File Offset: 0x00427A3C
		public static Offset<IBlueprintConfig> EndIBlueprintConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBlueprintConfig>(builder.EndTable());
		}

		// Token: 0x0601DA8B RID: 121483 RVA: 0x0042984C File Offset: 0x00427A4C
		public IBlueprintConfigT UnPack()
		{
			IBlueprintConfigT blueprintConfigT = new IBlueprintConfigT();
			this.UnPackTo(blueprintConfigT);
			return blueprintConfigT;
		}

		// Token: 0x0601DA8C RID: 121484 RVA: 0x00429868 File Offset: 0x00427A68
		public void UnPackTo(IBlueprintConfigT _o)
		{
			_o.BlueprintConfig = new List<Record_String_IBlueprintItemT>();
			for (int i = 0; i < this.BlueprintConfigLength; i++)
			{
				_o.BlueprintConfig.Add((this.BlueprintConfig(i) != null) ? this.BlueprintConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DA8D RID: 121485 RVA: 0x004298C8 File Offset: 0x00427AC8
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

		// Token: 0x0400D60C RID: 54796
		private Table __p;
	}
}
