using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006536 RID: 25910
	public struct ITagsConfig : IFlatbufferObject
	{
		// Token: 0x1700BF24 RID: 48932
		// (get) Token: 0x0602C2A0 RID: 180896 RVA: 0x00603CD4 File Offset: 0x00601ED4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C2A1 RID: 180897 RVA: 0x00603CE1 File Offset: 0x00601EE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C2A2 RID: 180898 RVA: 0x00603CE8 File Offset: 0x00601EE8
		public static ITagsConfig GetRootAsITagsConfig(ByteBuffer _bb)
		{
			return ITagsConfig.GetRootAsITagsConfig(_bb, default(ITagsConfig));
		}

		// Token: 0x0602C2A3 RID: 180899 RVA: 0x00603D04 File Offset: 0x00601F04
		public static ITagsConfig GetRootAsITagsConfig(ByteBuffer _bb, ITagsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C2A4 RID: 180900 RVA: 0x00603D21 File Offset: 0x00601F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C2A5 RID: 180901 RVA: 0x00603D30 File Offset: 0x00601F30
		public ITagsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C2A6 RID: 180902 RVA: 0x00603D40 File Offset: 0x00601F40
		public ITagConfig? Tags(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ITagConfig?(default(ITagConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF25 RID: 48933
		// (get) Token: 0x0602C2A7 RID: 180903 RVA: 0x00603DA0 File Offset: 0x00601FA0
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

		// Token: 0x0602C2A8 RID: 180904 RVA: 0x00603DCB File Offset: 0x00601FCB
		public static Offset<ITagsConfig> CreateITagsConfig(FlatBufferBuilder builder, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITagsConfig.AddTags(builder, TagsOffset);
			return ITagsConfig.EndITagsConfig(builder);
		}

		// Token: 0x0602C2A9 RID: 180905 RVA: 0x00603DE1 File Offset: 0x00601FE1
		public static void StartITagsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C2AA RID: 180906 RVA: 0x00603DEA File Offset: 0x00601FEA
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(0, tagsOffset.Value, 0);
		}

		// Token: 0x0602C2AB RID: 180907 RVA: 0x00603DFC File Offset: 0x00601FFC
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, Offset<ITagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C2AC RID: 180908 RVA: 0x00603E3C File Offset: 0x0060203C
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, Offset<ITagConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C2AD RID: 180909 RVA: 0x00603E56 File Offset: 0x00602056
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITagConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITagConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C2AE RID: 180910 RVA: 0x00603E74 File Offset: 0x00602074
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITagConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C2AF RID: 180911 RVA: 0x00603E8D File Offset: 0x0060208D
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C2B0 RID: 180912 RVA: 0x00603E98 File Offset: 0x00602098
		public static Offset<ITagsConfig> EndITagsConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITagsConfig>(builder.EndTable());
		}

		// Token: 0x0602C2B1 RID: 180913 RVA: 0x00603EA8 File Offset: 0x006020A8
		public ITagsConfigT UnPack()
		{
			ITagsConfigT tagsConfigT = new ITagsConfigT();
			this.UnPackTo(tagsConfigT);
			return tagsConfigT;
		}

		// Token: 0x0602C2B2 RID: 180914 RVA: 0x00603EC4 File Offset: 0x006020C4
		public void UnPackTo(ITagsConfigT _o)
		{
			_o.Tags = new List<ITagConfigT>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add((this.Tags(i) != null) ? this.Tags(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C2B3 RID: 180915 RVA: 0x00603F24 File Offset: 0x00602124
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

		// Token: 0x0401075A RID: 67418
		private Table __p;
	}
}
