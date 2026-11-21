using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063CB RID: 25547
	public struct IDynamicSummonGongduolaDictionary : IFlatbufferObject
	{
		// Token: 0x1700BCC4 RID: 48324
		// (get) Token: 0x0602B642 RID: 177730 RVA: 0x005E9E27 File Offset: 0x005E8027
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B643 RID: 177731 RVA: 0x005E9E34 File Offset: 0x005E8034
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B644 RID: 177732 RVA: 0x005E9E3C File Offset: 0x005E803C
		public static IDynamicSummonGongduolaDictionary GetRootAsIDynamicSummonGongduolaDictionary(ByteBuffer _bb)
		{
			return IDynamicSummonGongduolaDictionary.GetRootAsIDynamicSummonGongduolaDictionary(_bb, default(IDynamicSummonGongduolaDictionary));
		}

		// Token: 0x0602B645 RID: 177733 RVA: 0x005E9E58 File Offset: 0x005E8058
		public static IDynamicSummonGongduolaDictionary GetRootAsIDynamicSummonGongduolaDictionary(ByteBuffer _bb, IDynamicSummonGongduolaDictionary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B646 RID: 177734 RVA: 0x005E9E75 File Offset: 0x005E8075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B647 RID: 177735 RVA: 0x005E9E84 File Offset: 0x005E8084
		public IDynamicSummonGongduolaDictionary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602B648 RID: 177736 RVA: 0x005E9E94 File Offset: 0x005E8094
		public IDynamicSummonGongduolaConfig? Configs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSummonGongduolaConfig?(default(IDynamicSummonGongduolaConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BCC5 RID: 48325
		// (get) Token: 0x0602B649 RID: 177737 RVA: 0x005E9EF4 File Offset: 0x005E80F4
		public int ConfigsLength
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

		// Token: 0x0602B64A RID: 177738 RVA: 0x005E9F1F File Offset: 0x005E811F
		public static Offset<IDynamicSummonGongduolaDictionary> CreateIDynamicSummonGongduolaDictionary(FlatBufferBuilder builder, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IDynamicSummonGongduolaDictionary.AddConfigs(builder, ConfigsOffset);
			return IDynamicSummonGongduolaDictionary.EndIDynamicSummonGongduolaDictionary(builder);
		}

		// Token: 0x0602B64B RID: 177739 RVA: 0x005E9F35 File Offset: 0x005E8135
		public static void StartIDynamicSummonGongduolaDictionary(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B64C RID: 177740 RVA: 0x005E9F3E File Offset: 0x005E813E
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(0, configsOffset.Value, 0);
		}

		// Token: 0x0602B64D RID: 177741 RVA: 0x005E9F50 File Offset: 0x005E8150
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B64E RID: 177742 RVA: 0x005E9F90 File Offset: 0x005E8190
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSummonGongduolaConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B64F RID: 177743 RVA: 0x005E9FAA File Offset: 0x005E81AA
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSummonGongduolaConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSummonGongduolaConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B650 RID: 177744 RVA: 0x005E9FC8 File Offset: 0x005E81C8
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSummonGongduolaConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B651 RID: 177745 RVA: 0x005E9FE1 File Offset: 0x005E81E1
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B652 RID: 177746 RVA: 0x005E9FEC File Offset: 0x005E81EC
		public static Offset<IDynamicSummonGongduolaDictionary> EndIDynamicSummonGongduolaDictionary(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSummonGongduolaDictionary>(builder.EndTable());
		}

		// Token: 0x0602B653 RID: 177747 RVA: 0x005E9FFC File Offset: 0x005E81FC
		public IDynamicSummonGongduolaDictionaryT UnPack()
		{
			IDynamicSummonGongduolaDictionaryT dynamicSummonGongduolaDictionaryT = new IDynamicSummonGongduolaDictionaryT();
			this.UnPackTo(dynamicSummonGongduolaDictionaryT);
			return dynamicSummonGongduolaDictionaryT;
		}

		// Token: 0x0602B654 RID: 177748 RVA: 0x005EA018 File Offset: 0x005E8218
		public void UnPackTo(IDynamicSummonGongduolaDictionaryT _o)
		{
			_o.Configs = new List<IDynamicSummonGongduolaConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602B655 RID: 177749 RVA: 0x005EA078 File Offset: 0x005E8278
		public static Offset<IDynamicSummonGongduolaDictionary> Pack(FlatBufferBuilder builder, IDynamicSummonGongduolaDictionaryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSummonGongduolaDictionary>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<IDynamicSummonGongduolaConfig>[] array = new Offset<IDynamicSummonGongduolaConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicSummonGongduolaConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = IDynamicSummonGongduolaDictionary.CreateConfigsVector(builder, array);
			}
			return IDynamicSummonGongduolaDictionary.CreateIDynamicSummonGongduolaDictionary(builder, configsOffset);
		}

		// Token: 0x040104BB RID: 66747
		private Table __p;
	}
}
