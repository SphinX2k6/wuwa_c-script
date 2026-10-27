using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D8E RID: 23950
	public struct IDynamicSummonGongduolaDictionary : IFlatbufferObject
	{
		// Token: 0x1700B35E RID: 45918
		// (get) Token: 0x06028FB8 RID: 167864 RVA: 0x005A10F7 File Offset: 0x0059F2F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028FB9 RID: 167865 RVA: 0x005A1104 File Offset: 0x0059F304
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028FBA RID: 167866 RVA: 0x005A110C File Offset: 0x0059F30C
		public static IDynamicSummonGongduolaDictionary GetRootAsIDynamicSummonGongduolaDictionary(ByteBuffer _bb)
		{
			return IDynamicSummonGongduolaDictionary.GetRootAsIDynamicSummonGongduolaDictionary(_bb, default(IDynamicSummonGongduolaDictionary));
		}

		// Token: 0x06028FBB RID: 167867 RVA: 0x005A1128 File Offset: 0x0059F328
		public static IDynamicSummonGongduolaDictionary GetRootAsIDynamicSummonGongduolaDictionary(ByteBuffer _bb, IDynamicSummonGongduolaDictionary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028FBC RID: 167868 RVA: 0x005A1145 File Offset: 0x0059F345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028FBD RID: 167869 RVA: 0x005A1154 File Offset: 0x0059F354
		public IDynamicSummonGongduolaDictionary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06028FBE RID: 167870 RVA: 0x005A1164 File Offset: 0x0059F364
		public IDynamicSummonGongduolaConfig? Configs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSummonGongduolaConfig?(default(IDynamicSummonGongduolaConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B35F RID: 45919
		// (get) Token: 0x06028FBF RID: 167871 RVA: 0x005A11C4 File Offset: 0x0059F3C4
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

		// Token: 0x06028FC0 RID: 167872 RVA: 0x005A11EF File Offset: 0x0059F3EF
		public static Offset<IDynamicSummonGongduolaDictionary> CreateIDynamicSummonGongduolaDictionary(FlatBufferBuilder builder, VectorOffset ConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IDynamicSummonGongduolaDictionary.AddConfigs(builder, ConfigsOffset);
			return IDynamicSummonGongduolaDictionary.EndIDynamicSummonGongduolaDictionary(builder);
		}

		// Token: 0x06028FC1 RID: 167873 RVA: 0x005A1205 File Offset: 0x0059F405
		public static void StartIDynamicSummonGongduolaDictionary(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028FC2 RID: 167874 RVA: 0x005A120E File Offset: 0x0059F40E
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(0, configsOffset.Value, 0);
		}

		// Token: 0x06028FC3 RID: 167875 RVA: 0x005A1220 File Offset: 0x0059F420
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028FC4 RID: 167876 RVA: 0x005A1260 File Offset: 0x0059F460
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSummonGongduolaConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSummonGongduolaConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028FC5 RID: 167877 RVA: 0x005A127A File Offset: 0x0059F47A
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSummonGongduolaConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSummonGongduolaConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028FC6 RID: 167878 RVA: 0x005A1298 File Offset: 0x0059F498
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSummonGongduolaConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028FC7 RID: 167879 RVA: 0x005A12B1 File Offset: 0x0059F4B1
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028FC8 RID: 167880 RVA: 0x005A12BC File Offset: 0x0059F4BC
		public static Offset<IDynamicSummonGongduolaDictionary> EndIDynamicSummonGongduolaDictionary(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSummonGongduolaDictionary>(builder.EndTable());
		}

		// Token: 0x06028FC9 RID: 167881 RVA: 0x005A12CC File Offset: 0x0059F4CC
		public IDynamicSummonGongduolaDictionaryT UnPack()
		{
			IDynamicSummonGongduolaDictionaryT dynamicSummonGongduolaDictionaryT = new IDynamicSummonGongduolaDictionaryT();
			this.UnPackTo(dynamicSummonGongduolaDictionaryT);
			return dynamicSummonGongduolaDictionaryT;
		}

		// Token: 0x06028FCA RID: 167882 RVA: 0x005A12E8 File Offset: 0x0059F4E8
		public void UnPackTo(IDynamicSummonGongduolaDictionaryT _o)
		{
			_o.Configs = new List<IDynamicSummonGongduolaConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028FCB RID: 167883 RVA: 0x005A1348 File Offset: 0x0059F548
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

		// Token: 0x0400F760 RID: 63328
		private Table __p;
	}
}
