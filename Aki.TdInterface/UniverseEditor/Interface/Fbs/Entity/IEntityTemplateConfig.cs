using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C40 RID: 19520
	public struct IEntityTemplateConfig : IFlatbufferObject
	{
		// Token: 0x17008A82 RID: 35458
		// (get) Token: 0x0601DEF0 RID: 122608 RVA: 0x00432987 File Offset: 0x00430B87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DEF1 RID: 122609 RVA: 0x00432994 File Offset: 0x00430B94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DEF2 RID: 122610 RVA: 0x0043299C File Offset: 0x00430B9C
		public static IEntityTemplateConfig GetRootAsIEntityTemplateConfig(ByteBuffer _bb)
		{
			return IEntityTemplateConfig.GetRootAsIEntityTemplateConfig(_bb, default(IEntityTemplateConfig));
		}

		// Token: 0x0601DEF3 RID: 122611 RVA: 0x004329B8 File Offset: 0x00430BB8
		public static IEntityTemplateConfig GetRootAsIEntityTemplateConfig(ByteBuffer _bb, IEntityTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DEF4 RID: 122612 RVA: 0x004329D5 File Offset: 0x00430BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DEF5 RID: 122613 RVA: 0x004329E4 File Offset: 0x00430BE4
		public IEntityTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DEF6 RID: 122614 RVA: 0x004329F4 File Offset: 0x00430BF4
		public IEntityTemplate? Templates(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityTemplate?(default(IEntityTemplate).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A83 RID: 35459
		// (get) Token: 0x0601DEF7 RID: 122615 RVA: 0x00432A54 File Offset: 0x00430C54
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

		// Token: 0x0601DEF8 RID: 122616 RVA: 0x00432A7F File Offset: 0x00430C7F
		public static Offset<IEntityTemplateConfig> CreateIEntityTemplateConfig(FlatBufferBuilder builder, VectorOffset TemplatesOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityTemplateConfig.AddTemplates(builder, TemplatesOffset);
			return IEntityTemplateConfig.EndIEntityTemplateConfig(builder);
		}

		// Token: 0x0601DEF9 RID: 122617 RVA: 0x00432A95 File Offset: 0x00430C95
		public static void StartIEntityTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DEFA RID: 122618 RVA: 0x00432A9E File Offset: 0x00430C9E
		public static void AddTemplates(FlatBufferBuilder builder, VectorOffset templatesOffset)
		{
			builder.AddOffset(0, templatesOffset.Value, 0);
		}

		// Token: 0x0601DEFB RID: 122619 RVA: 0x00432AB0 File Offset: 0x00430CB0
		public static VectorOffset CreateTemplatesVector(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DEFC RID: 122620 RVA: 0x00432AF0 File Offset: 0x00430CF0
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, Offset<IEntityTemplate>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEFD RID: 122621 RVA: 0x00432B0A File Offset: 0x00430D0A
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityTemplate>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityTemplate>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEFE RID: 122622 RVA: 0x00432B28 File Offset: 0x00430D28
		public static VectorOffset CreateTemplatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityTemplate>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DEFF RID: 122623 RVA: 0x00432B41 File Offset: 0x00430D41
		public static void StartTemplatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DF00 RID: 122624 RVA: 0x00432B4C File Offset: 0x00430D4C
		public static Offset<IEntityTemplateConfig> EndIEntityTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601DF01 RID: 122625 RVA: 0x00432B5C File Offset: 0x00430D5C
		public IEntityTemplateConfigT UnPack()
		{
			IEntityTemplateConfigT entityTemplateConfigT = new IEntityTemplateConfigT();
			this.UnPackTo(entityTemplateConfigT);
			return entityTemplateConfigT;
		}

		// Token: 0x0601DF02 RID: 122626 RVA: 0x00432B78 File Offset: 0x00430D78
		public void UnPackTo(IEntityTemplateConfigT _o)
		{
			_o.Templates = new List<IEntityTemplateT>();
			for (int i = 0; i < this.TemplatesLength; i++)
			{
				_o.Templates.Add((this.Templates(i) != null) ? this.Templates(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DF03 RID: 122627 RVA: 0x00432BD8 File Offset: 0x00430DD8
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

		// Token: 0x0400D6AD RID: 54957
		private Table __p;
	}
}
