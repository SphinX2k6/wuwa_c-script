using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EF3 RID: 24307
	public struct ITagsConfig : IFlatbufferObject
	{
		// Token: 0x1700B5B9 RID: 46521
		// (get) Token: 0x06029BEC RID: 170988 RVA: 0x005BA7F0 File Offset: 0x005B89F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029BED RID: 170989 RVA: 0x005BA7FD File Offset: 0x005B89FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029BEE RID: 170990 RVA: 0x005BA804 File Offset: 0x005B8A04
		public static ITagsConfig GetRootAsITagsConfig(ByteBuffer _bb)
		{
			return ITagsConfig.GetRootAsITagsConfig(_bb, default(ITagsConfig));
		}

		// Token: 0x06029BEF RID: 170991 RVA: 0x005BA820 File Offset: 0x005B8A20
		public static ITagsConfig GetRootAsITagsConfig(ByteBuffer _bb, ITagsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029BF0 RID: 170992 RVA: 0x005BA83D File Offset: 0x005B8A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BF1 RID: 170993 RVA: 0x005BA84C File Offset: 0x005B8A4C
		public ITagsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029BF2 RID: 170994 RVA: 0x005BA85C File Offset: 0x005B8A5C
		public ITagConfig? Tags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ITagConfig?(default(ITagConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5BA RID: 46522
		// (get) Token: 0x06029BF3 RID: 170995 RVA: 0x005BA8BC File Offset: 0x005B8ABC
		public int TagsLength
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

		// Token: 0x06029BF4 RID: 170996 RVA: 0x005BA8E7 File Offset: 0x005B8AE7
		public static Offset<ITagsConfig> CreateITagsConfig(FlatBufferBuilder builder, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITagsConfig.AddTags(builder, TagsOffset);
			return ITagsConfig.EndITagsConfig(builder);
		}

		// Token: 0x06029BF5 RID: 170997 RVA: 0x005BA8FD File Offset: 0x005B8AFD
		public static void StartITagsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029BF6 RID: 170998 RVA: 0x005BA906 File Offset: 0x005B8B06
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(0, tagsOffset.Value, 0);
		}

		// Token: 0x06029BF7 RID: 170999 RVA: 0x005BA918 File Offset: 0x005B8B18
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, Offset<ITagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029BF8 RID: 171000 RVA: 0x005BA958 File Offset: 0x005B8B58
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, Offset<ITagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029BF9 RID: 171001 RVA: 0x005BA972 File Offset: 0x005B8B72
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITagConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029BFA RID: 171002 RVA: 0x005BA990 File Offset: 0x005B8B90
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITagConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029BFB RID: 171003 RVA: 0x005BA9A9 File Offset: 0x005B8BA9
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029BFC RID: 171004 RVA: 0x005BA9B4 File Offset: 0x005B8BB4
		public static Offset<ITagsConfig> EndITagsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITagsConfig>(builder.EndTable());
		}

		// Token: 0x06029BFD RID: 171005 RVA: 0x005BA9C4 File Offset: 0x005B8BC4
		public ITagsConfigT UnPack()
		{
			ITagsConfigT tagsConfigT = new ITagsConfigT();
			this.UnPackTo(tagsConfigT);
			return tagsConfigT;
		}

		// Token: 0x06029BFE RID: 171006 RVA: 0x005BA9E0 File Offset: 0x005B8BE0
		public void UnPackTo(ITagsConfigT _o)
		{
			_o.Tags = new List<ITagConfigT>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add((this.Tags(i) != null) ? this.Tags(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029BFF RID: 171007 RVA: 0x005BAA40 File Offset: 0x005B8C40
		public static Offset<ITagsConfig> Pack(FlatBufferBuilder builder, ITagsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITagsConfig>);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				Offset<ITagConfig>[] array = new Offset<ITagConfig>[_o.Tags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITagConfig.Pack(builder, _o.Tags[i]);
				}
				tagsOffset = ITagsConfig.CreateTagsVector(builder, array);
			}
			return ITagsConfig.CreateITagsConfig(builder, tagsOffset);
		}

		// Token: 0x0400F9F6 RID: 63990
		private Table __p;
	}
}
