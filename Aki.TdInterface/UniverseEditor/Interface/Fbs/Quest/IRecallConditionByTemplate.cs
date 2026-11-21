using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044C0 RID: 17600
	public struct IRecallConditionByTemplate : IFlatbufferObject
	{
		// Token: 0x17007A86 RID: 31366
		// (get) Token: 0x060196C8 RID: 104136 RVA: 0x003A0BE4 File Offset: 0x0039EDE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060196C9 RID: 104137 RVA: 0x003A0BF1 File Offset: 0x0039EDF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060196CA RID: 104138 RVA: 0x003A0BF8 File Offset: 0x0039EDF8
		public static IRecallConditionByTemplate GetRootAsIRecallConditionByTemplate(ByteBuffer _bb)
		{
			return IRecallConditionByTemplate.GetRootAsIRecallConditionByTemplate(_bb, default(IRecallConditionByTemplate));
		}

		// Token: 0x060196CB RID: 104139 RVA: 0x003A0C14 File Offset: 0x0039EE14
		public static IRecallConditionByTemplate GetRootAsIRecallConditionByTemplate(ByteBuffer _bb, IRecallConditionByTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060196CC RID: 104140 RVA: 0x003A0C31 File Offset: 0x0039EE31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060196CD RID: 104141 RVA: 0x003A0C40 File Offset: 0x0039EE40
		public IRecallConditionByTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A87 RID: 31367
		// (get) Token: 0x060196CE RID: 104142 RVA: 0x003A0C50 File Offset: 0x0039EE50
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

		// Token: 0x17007A88 RID: 31368
		// (get) Token: 0x060196CF RID: 104143 RVA: 0x003A0C8C File Offset: 0x0039EE8C
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

		// Token: 0x060196D0 RID: 104144 RVA: 0x003A0CC8 File Offset: 0x0039EEC8
		public string Templates(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A89 RID: 31369
		// (get) Token: 0x060196D1 RID: 104145 RVA: 0x003A0D04 File Offset: 0x0039EF04
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

		// Token: 0x060196D2 RID: 104146 RVA: 0x003A0D30 File Offset: 0x0039EF30
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A8A RID: 31370
		// (get) Token: 0x060196D3 RID: 104147 RVA: 0x003A0D70 File Offset: 0x0039EF70
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

		// Token: 0x060196D4 RID: 104148 RVA: 0x003A0D9C File Offset: 0x0039EF9C
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060196D5 RID: 104149 RVA: 0x003A0DAC File Offset: 0x0039EFAC
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x060196D6 RID: 104150 RVA: 0x003A0DBB File Offset: 0x0039EFBB
		public static Offset<IRecallConditionByTemplate> CreateIRecallConditionByTemplate(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include, VectorOffset TemplatesOffset = default(VectorOffset), VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IRecallConditionByTemplate.AddAreaIds(builder, AreaIdsOffset);
			IRecallConditionByTemplate.AddTemplates(builder, TemplatesOffset);
			IRecallConditionByTemplate.AddOperation(builder, Operation);
			IRecallConditionByTemplate.AddType(builder, Type);
			return IRecallConditionByTemplate.EndIRecallConditionByTemplate(builder);
		}

		// Token: 0x060196D7 RID: 104151 RVA: 0x003A0DE7 File Offset: 0x0039EFE7
		public static void StartIRecallConditionByTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060196D8 RID: 104152 RVA: 0x003A0DF0 File Offset: 0x0039EFF0
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060196D9 RID: 104153 RVA: 0x003A0DFB File Offset: 0x0039EFFB
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x060196DA RID: 104154 RVA: 0x003A0E06 File Offset: 0x0039F006
		public static void AddTemplates(FlatBufferBuilder builder, VectorOffset templatesOffset)
		{
			builder.AddOffset(2, templatesOffset.Value, 0);
		}

		// Token: 0x060196DB RID: 104155 RVA: 0x003A0E18 File Offset: 0x0039F018
		public static VectorOffset CreateTemplatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060196DC RID: 104156 RVA: 0x003A0E58 File Offset: 0x0039F058
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060196DD RID: 104157 RVA: 0x003A0E72 File Offset: 0x0039F072
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060196DE RID: 104158 RVA: 0x003A0E90 File Offset: 0x0039F090
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060196DF RID: 104159 RVA: 0x003A0EA9 File Offset: 0x0039F0A9
		public static void StartTemplatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060196E0 RID: 104160 RVA: 0x003A0EB4 File Offset: 0x0039F0B4
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(3, areaIdsOffset.Value, 0);
		}

		// Token: 0x060196E1 RID: 104161 RVA: 0x003A0EC4 File Offset: 0x0039F0C4
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060196E2 RID: 104162 RVA: 0x003A0EFB File Offset: 0x0039F0FB
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060196E3 RID: 104163 RVA: 0x003A0F15 File Offset: 0x0039F115
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060196E4 RID: 104164 RVA: 0x003A0F33 File Offset: 0x0039F133
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060196E5 RID: 104165 RVA: 0x003A0F4C File Offset: 0x0039F14C
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060196E6 RID: 104166 RVA: 0x003A0F57 File Offset: 0x0039F157
		public static Offset<IRecallConditionByTemplate> EndIRecallConditionByTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionByTemplate>(builder.EndTable());
		}

		// Token: 0x060196E7 RID: 104167 RVA: 0x003A0F64 File Offset: 0x0039F164
		public IRecallConditionByTemplateT UnPack()
		{
			IRecallConditionByTemplateT recallConditionByTemplateT = new IRecallConditionByTemplateT();
			this.UnPackTo(recallConditionByTemplateT);
			return recallConditionByTemplateT;
		}

		// Token: 0x060196E8 RID: 104168 RVA: 0x003A0F80 File Offset: 0x0039F180
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

		// Token: 0x060196E9 RID: 104169 RVA: 0x003A1004 File Offset: 0x0039F204
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

		// Token: 0x0400C5EA RID: 50666
		private Table __p;
	}
}
