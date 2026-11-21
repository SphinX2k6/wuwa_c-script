using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F44 RID: 28484
	public struct IGroupAiCommunicateAddTag : IFlatbufferObject
	{
		// Token: 0x1700D0C5 RID: 53445
		// (get) Token: 0x060314C4 RID: 201924 RVA: 0x006AD8BD File Offset: 0x006ABABD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060314C5 RID: 201925 RVA: 0x006AD8CA File Offset: 0x006ABACA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060314C6 RID: 201926 RVA: 0x006AD8D4 File Offset: 0x006ABAD4
		public static IGroupAiCommunicateAddTag GetRootAsIGroupAiCommunicateAddTag(ByteBuffer _bb)
		{
			return IGroupAiCommunicateAddTag.GetRootAsIGroupAiCommunicateAddTag(_bb, default(IGroupAiCommunicateAddTag));
		}

		// Token: 0x060314C7 RID: 201927 RVA: 0x006AD8F0 File Offset: 0x006ABAF0
		public static IGroupAiCommunicateAddTag GetRootAsIGroupAiCommunicateAddTag(ByteBuffer _bb, IGroupAiCommunicateAddTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060314C8 RID: 201928 RVA: 0x006AD90D File Offset: 0x006ABB0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060314C9 RID: 201929 RVA: 0x006AD91C File Offset: 0x006ABB1C
		public IGroupAiCommunicateAddTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0C6 RID: 53446
		// (get) Token: 0x060314CA RID: 201930 RVA: 0x006AD92C File Offset: 0x006ABB2C
		public EGroupAiCommunicateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGroupAiCommunicateType.AddTag;
				}
				return (EGroupAiCommunicateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060314CB RID: 201931 RVA: 0x006AD968 File Offset: 0x006ABB68
		public string Tags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D0C7 RID: 53447
		// (get) Token: 0x060314CC RID: 201932 RVA: 0x006AD9A4 File Offset: 0x006ABBA4
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060314CD RID: 201933 RVA: 0x006AD9CF File Offset: 0x006ABBCF
		public static Offset<IGroupAiCommunicateAddTag> CreateIGroupAiCommunicateAddTag(FlatBufferBuilder builder, EGroupAiCommunicateType Type = EGroupAiCommunicateType.AddTag, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGroupAiCommunicateAddTag.AddTags(builder, TagsOffset);
			IGroupAiCommunicateAddTag.AddType(builder, Type);
			return IGroupAiCommunicateAddTag.EndIGroupAiCommunicateAddTag(builder);
		}

		// Token: 0x060314CE RID: 201934 RVA: 0x006AD9EC File Offset: 0x006ABBEC
		public static void StartIGroupAiCommunicateAddTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060314CF RID: 201935 RVA: 0x006AD9F5 File Offset: 0x006ABBF5
		public static void AddType(FlatBufferBuilder builder, EGroupAiCommunicateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060314D0 RID: 201936 RVA: 0x006ADA00 File Offset: 0x006ABC00
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(1, tagsOffset.Value, 0);
		}

		// Token: 0x060314D1 RID: 201937 RVA: 0x006ADA10 File Offset: 0x006ABC10
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060314D2 RID: 201938 RVA: 0x006ADA50 File Offset: 0x006ABC50
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060314D3 RID: 201939 RVA: 0x006ADA6A File Offset: 0x006ABC6A
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060314D4 RID: 201940 RVA: 0x006ADA88 File Offset: 0x006ABC88
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060314D5 RID: 201941 RVA: 0x006ADAA1 File Offset: 0x006ABCA1
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060314D6 RID: 201942 RVA: 0x006ADAAC File Offset: 0x006ABCAC
		public static Offset<IGroupAiCommunicateAddTag> EndIGroupAiCommunicateAddTag(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiCommunicateAddTag>(builder.EndTable());
		}

		// Token: 0x060314D7 RID: 201943 RVA: 0x006ADABC File Offset: 0x006ABCBC
		public IGroupAiCommunicateAddTagT UnPack()
		{
			IGroupAiCommunicateAddTagT groupAiCommunicateAddTagT = new IGroupAiCommunicateAddTagT();
			this.UnPackTo(groupAiCommunicateAddTagT);
			return groupAiCommunicateAddTagT;
		}

		// Token: 0x060314D8 RID: 201944 RVA: 0x006ADAD8 File Offset: 0x006ABCD8
		public void UnPackTo(IGroupAiCommunicateAddTagT _o)
		{
			_o.Type = this.Type;
			_o.Tags = new List<string>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x060314D9 RID: 201945 RVA: 0x006ADB20 File Offset: 0x006ABD20
		public static Offset<IGroupAiCommunicateAddTag> Pack(FlatBufferBuilder builder, IGroupAiCommunicateAddTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiCommunicateAddTag>);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				StringOffset[] array = new StringOffset[_o.Tags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Tags[i]);
				}
				tagsOffset = IGroupAiCommunicateAddTag.CreateTagsVector(builder, array);
			}
			return IGroupAiCommunicateAddTag.CreateIGroupAiCommunicateAddTag(builder, _o.Type, tagsOffset);
		}

		// Token: 0x04011E49 RID: 73289
		private Table __p;
	}
}
