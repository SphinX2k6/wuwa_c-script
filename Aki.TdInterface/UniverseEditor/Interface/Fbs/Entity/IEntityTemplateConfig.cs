using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D8 RID: 18392
	public struct IEntityTemplateConfig : IFlatbufferObject
	{
		// Token: 0x17008437 RID: 33847
		// (get) Token: 0x0601C6F3 RID: 116467 RVA: 0x00406037 File Offset: 0x00404237
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C6F4 RID: 116468 RVA: 0x00406044 File Offset: 0x00404244
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C6F5 RID: 116469 RVA: 0x0040604C File Offset: 0x0040424C
		public static IEntityTemplateConfig GetRootAsIEntityTemplateConfig(ByteBuffer _bb)
		{
			return IEntityTemplateConfig.GetRootAsIEntityTemplateConfig(_bb, default(IEntityTemplateConfig));
		}

		// Token: 0x0601C6F6 RID: 116470 RVA: 0x00406068 File Offset: 0x00404268
		public static IEntityTemplateConfig GetRootAsIEntityTemplateConfig(ByteBuffer _bb, IEntityTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C6F7 RID: 116471 RVA: 0x00406085 File Offset: 0x00404285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C6F8 RID: 116472 RVA: 0x00406094 File Offset: 0x00404294
		public IEntityTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C6F9 RID: 116473 RVA: 0x004060A4 File Offset: 0x004042A4
		public IEntityTemplate? Templates(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityTemplate?(default(IEntityTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008438 RID: 33848
		// (get) Token: 0x0601C6FA RID: 116474 RVA: 0x00406104 File Offset: 0x00404304
		public int TemplatesLength
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

		// Token: 0x0601C6FB RID: 116475 RVA: 0x0040612F File Offset: 0x0040432F
		public static Offset<IEntityTemplateConfig> CreateIEntityTemplateConfig(FlatBufferBuilder builder, VectorOffset TemplatesOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityTemplateConfig.AddTemplates(builder, TemplatesOffset);
			return IEntityTemplateConfig.EndIEntityTemplateConfig(builder);
		}

		// Token: 0x0601C6FC RID: 116476 RVA: 0x00406145 File Offset: 0x00404345
		public static void StartIEntityTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C6FD RID: 116477 RVA: 0x0040614E File Offset: 0x0040434E
		public static void AddTemplates(FlatBufferBuilder builder, VectorOffset templatesOffset)
		{
			builder.AddOffset(0, templatesOffset.Value, 0);
		}

		// Token: 0x0601C6FE RID: 116478 RVA: 0x00406160 File Offset: 0x00404360
		public static VectorOffset CreateTemplatesVector(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C6FF RID: 116479 RVA: 0x004061A0 File Offset: 0x004043A0
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C700 RID: 116480 RVA: 0x004061BA File Offset: 0x004043BA
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C701 RID: 116481 RVA: 0x004061D8 File Offset: 0x004043D8
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C702 RID: 116482 RVA: 0x004061F1 File Offset: 0x004043F1
		public static void StartTemplatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C703 RID: 116483 RVA: 0x004061FC File Offset: 0x004043FC
		public static Offset<IEntityTemplateConfig> EndIEntityTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601C704 RID: 116484 RVA: 0x0040620C File Offset: 0x0040440C
		public IEntityTemplateConfigT UnPack()
		{
			IEntityTemplateConfigT entityTemplateConfigT = new IEntityTemplateConfigT();
			this.UnPackTo(entityTemplateConfigT);
			return entityTemplateConfigT;
		}

		// Token: 0x0601C705 RID: 116485 RVA: 0x00406228 File Offset: 0x00404428
		public void UnPackTo(IEntityTemplateConfigT _o)
		{
			_o.Templates = new List<IEntityTemplateT>();
			for (int i = 0; i < this.TemplatesLength; i++)
			{
				_o.Templates.Add((this.Templates(i) != null) ? this.Templates(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C706 RID: 116486 RVA: 0x00406288 File Offset: 0x00404488
		public static Offset<IEntityTemplateConfig> Pack(FlatBufferBuilder builder, IEntityTemplateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTemplateConfig>);
			}
			VectorOffset templatesOffset = default(VectorOffset);
			if (_o.Templates != null)
			{
				Offset<IEntityTemplate>[] array = new Offset<IEntityTemplate>[_o.Templates.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityTemplate.Pack(builder, _o.Templates[i]);
				}
				templatesOffset = IEntityTemplateConfig.CreateTemplatesVector(builder, array);
			}
			return IEntityTemplateConfig.CreateIEntityTemplateConfig(builder, templatesOffset);
		}

		// Token: 0x0400CC72 RID: 52338
		private Table __p;
	}
}
