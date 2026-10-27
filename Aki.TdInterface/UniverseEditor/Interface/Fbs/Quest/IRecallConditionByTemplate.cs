using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200407F RID: 16511
	public struct IRecallConditionByTemplate : IFlatbufferObject
	{
		// Token: 0x17007484 RID: 29828
		// (get) Token: 0x0601802F RID: 98351 RVA: 0x00376DAC File Offset: 0x00374FAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018030 RID: 98352 RVA: 0x00376DB9 File Offset: 0x00374FB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018031 RID: 98353 RVA: 0x00376DC0 File Offset: 0x00374FC0
		public static IRecallConditionByTemplate GetRootAsIRecallConditionByTemplate(ByteBuffer _bb)
		{
			return IRecallConditionByTemplate.GetRootAsIRecallConditionByTemplate(_bb, default(IRecallConditionByTemplate));
		}

		// Token: 0x06018032 RID: 98354 RVA: 0x00376DDC File Offset: 0x00374FDC
		public static IRecallConditionByTemplate GetRootAsIRecallConditionByTemplate(ByteBuffer _bb, IRecallConditionByTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018033 RID: 98355 RVA: 0x00376DF9 File Offset: 0x00374FF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018034 RID: 98356 RVA: 0x00376E08 File Offset: 0x00375008
		public IRecallConditionByTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007485 RID: 29829
		// (get) Token: 0x06018035 RID: 98357 RVA: 0x00376E18 File Offset: 0x00375018
		public ERecallConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallConditionType.ByEntityType;
				}
				return (ERecallConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007486 RID: 29830
		// (get) Token: 0x06018036 RID: 98358 RVA: 0x00376E54 File Offset: 0x00375054
		public ERecallOperation Operation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERecallOperation.Include;
				}
				return (ERecallOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018037 RID: 98359 RVA: 0x00376E90 File Offset: 0x00375090
		public string Templates(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007487 RID: 29831
		// (get) Token: 0x06018038 RID: 98360 RVA: 0x00376ECC File Offset: 0x003750CC
		public int TemplatesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018039 RID: 98361 RVA: 0x00376EF8 File Offset: 0x003750F8
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007488 RID: 29832
		// (get) Token: 0x0601803A RID: 98362 RVA: 0x00376F38 File Offset: 0x00375138
		public int AreaIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601803B RID: 98363 RVA: 0x00376F64 File Offset: 0x00375164
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601803C RID: 98364 RVA: 0x00376F74 File Offset: 0x00375174
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601803D RID: 98365 RVA: 0x00376F83 File Offset: 0x00375183
		public static Offset<IRecallConditionByTemplate> CreateIRecallConditionByTemplate(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include, VectorOffset TemplatesOffset = default(VectorOffset), VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IRecallConditionByTemplate.AddAreaIds(builder, AreaIdsOffset);
			IRecallConditionByTemplate.AddTemplates(builder, TemplatesOffset);
			IRecallConditionByTemplate.AddOperation(builder, Operation);
			IRecallConditionByTemplate.AddType(builder, Type);
			return IRecallConditionByTemplate.EndIRecallConditionByTemplate(builder);
		}

		// Token: 0x0601803E RID: 98366 RVA: 0x00376FAF File Offset: 0x003751AF
		public static void StartIRecallConditionByTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601803F RID: 98367 RVA: 0x00376FB8 File Offset: 0x003751B8
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018040 RID: 98368 RVA: 0x00376FC3 File Offset: 0x003751C3
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x06018041 RID: 98369 RVA: 0x00376FCE File Offset: 0x003751CE
		public static void AddTemplates(FlatBufferBuilder builder, VectorOffset templatesOffset)
		{
			builder.AddOffset(2, templatesOffset.Value, 0);
		}

		// Token: 0x06018042 RID: 98370 RVA: 0x00376FE0 File Offset: 0x003751E0
		public static VectorOffset CreateTemplatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018043 RID: 98371 RVA: 0x00377020 File Offset: 0x00375220
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018044 RID: 98372 RVA: 0x0037703A File Offset: 0x0037523A
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06018045 RID: 98373 RVA: 0x00377058 File Offset: 0x00375258
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018046 RID: 98374 RVA: 0x00377071 File Offset: 0x00375271
		public static void StartTemplatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018047 RID: 98375 RVA: 0x0037707C File Offset: 0x0037527C
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(3, areaIdsOffset.Value, 0);
		}

		// Token: 0x06018048 RID: 98376 RVA: 0x0037708C File Offset: 0x0037528C
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018049 RID: 98377 RVA: 0x003770C3 File Offset: 0x003752C3
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601804A RID: 98378 RVA: 0x003770DD File Offset: 0x003752DD
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601804B RID: 98379 RVA: 0x003770FB File Offset: 0x003752FB
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601804C RID: 98380 RVA: 0x00377114 File Offset: 0x00375314
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601804D RID: 98381 RVA: 0x0037711F File Offset: 0x0037531F
		public static Offset<IRecallConditionByTemplate> EndIRecallConditionByTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionByTemplate>(builder.EndTable());
		}

		// Token: 0x0601804E RID: 98382 RVA: 0x0037712C File Offset: 0x0037532C
		public IRecallConditionByTemplateT UnPack()
		{
			IRecallConditionByTemplateT recallConditionByTemplateT = new IRecallConditionByTemplateT();
			this.UnPackTo(recallConditionByTemplateT);
			return recallConditionByTemplateT;
		}

		// Token: 0x0601804F RID: 98383 RVA: 0x00377148 File Offset: 0x00375348
		public void UnPackTo(IRecallConditionByTemplateT _o)
		{
			_o.Type = this.Type;
			_o.Operation = this.Operation;
			_o.Templates = new List<string>();
			for (int i = 0; i < this.TemplatesLength; i++)
			{
				_o.Templates.Add(this.Templates(i));
			}
			_o.AreaIds = new List<int>();
			for (int j = 0; j < this.AreaIdsLength; j++)
			{
				_o.AreaIds.Add(this.AreaIds(j));
			}
		}

		// Token: 0x06018050 RID: 98384 RVA: 0x003771CC File Offset: 0x003753CC
		public static Offset<IRecallConditionByTemplate> Pack(FlatBufferBuilder builder, IRecallConditionByTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallConditionByTemplate>);
			}
			VectorOffset templatesOffset = default(VectorOffset);
			if (_o.Templates != null)
			{
				StringOffset[] array = new StringOffset[_o.Templates.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Templates[i]);
				}
				templatesOffset = IRecallConditionByTemplate.CreateTemplatesVector(builder, array);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = IRecallConditionByTemplate.CreateAreaIdsVector(builder, data);
			}
			return IRecallConditionByTemplate.CreateIRecallConditionByTemplate(builder, _o.Type, _o.Operation, templatesOffset, areaIdsOffset);
		}

		// Token: 0x0400BC03 RID: 48131
		private Table __p;
	}
}
