using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A3 RID: 26787
	public struct IGroupAiCommunicateAddTag : IFlatbufferObject
	{
		// Token: 0x1700C6DF RID: 50911
		// (get) Token: 0x0602EB8A RID: 191370 RVA: 0x0065E83D File Offset: 0x0065CA3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB8B RID: 191371 RVA: 0x0065E84A File Offset: 0x0065CA4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB8C RID: 191372 RVA: 0x0065E854 File Offset: 0x0065CA54
		public static IGroupAiCommunicateAddTag GetRootAsIGroupAiCommunicateAddTag(ByteBuffer _bb)
		{
			return IGroupAiCommunicateAddTag.GetRootAsIGroupAiCommunicateAddTag(_bb, default(IGroupAiCommunicateAddTag));
		}

		// Token: 0x0602EB8D RID: 191373 RVA: 0x0065E870 File Offset: 0x0065CA70
		public static IGroupAiCommunicateAddTag GetRootAsIGroupAiCommunicateAddTag(ByteBuffer _bb, IGroupAiCommunicateAddTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB8E RID: 191374 RVA: 0x0065E88D File Offset: 0x0065CA8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB8F RID: 191375 RVA: 0x0065E89C File Offset: 0x0065CA9C
		public IGroupAiCommunicateAddTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6E0 RID: 50912
		// (get) Token: 0x0602EB90 RID: 191376 RVA: 0x0065E8AC File Offset: 0x0065CAAC
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

		// Token: 0x0602EB91 RID: 191377 RVA: 0x0065E8E8 File Offset: 0x0065CAE8
		public string Tags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C6E1 RID: 50913
		// (get) Token: 0x0602EB92 RID: 191378 RVA: 0x0065E924 File Offset: 0x0065CB24
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

		// Token: 0x0602EB93 RID: 191379 RVA: 0x0065E94F File Offset: 0x0065CB4F
		public static Offset<IGroupAiCommunicateAddTag> CreateIGroupAiCommunicateAddTag(FlatBufferBuilder builder, EGroupAiCommunicateType Type = EGroupAiCommunicateType.AddTag, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGroupAiCommunicateAddTag.AddTags(builder, TagsOffset);
			IGroupAiCommunicateAddTag.AddType(builder, Type);
			return IGroupAiCommunicateAddTag.EndIGroupAiCommunicateAddTag(builder);
		}

		// Token: 0x0602EB94 RID: 191380 RVA: 0x0065E96C File Offset: 0x0065CB6C
		public static void StartIGroupAiCommunicateAddTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EB95 RID: 191381 RVA: 0x0065E975 File Offset: 0x0065CB75
		public static void AddType(FlatBufferBuilder builder, EGroupAiCommunicateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB96 RID: 191382 RVA: 0x0065E980 File Offset: 0x0065CB80
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(1, tagsOffset.Value, 0);
		}

		// Token: 0x0602EB97 RID: 191383 RVA: 0x0065E990 File Offset: 0x0065CB90
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EB98 RID: 191384 RVA: 0x0065E9D0 File Offset: 0x0065CBD0
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB99 RID: 191385 RVA: 0x0065E9EA File Offset: 0x0065CBEA
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB9A RID: 191386 RVA: 0x0065EA08 File Offset: 0x0065CC08
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EB9B RID: 191387 RVA: 0x0065EA21 File Offset: 0x0065CC21
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EB9C RID: 191388 RVA: 0x0065EA2C File Offset: 0x0065CC2C
		public static Offset<IGroupAiCommunicateAddTag> EndIGroupAiCommunicateAddTag(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiCommunicateAddTag>(builder.EndTable());
		}

		// Token: 0x0602EB9D RID: 191389 RVA: 0x0065EA3C File Offset: 0x0065CC3C
		public IGroupAiCommunicateAddTagT UnPack()
		{
			IGroupAiCommunicateAddTagT groupAiCommunicateAddTagT = new IGroupAiCommunicateAddTagT();
			this.UnPackTo(groupAiCommunicateAddTagT);
			return groupAiCommunicateAddTagT;
		}

		// Token: 0x0602EB9E RID: 191390 RVA: 0x0065EA58 File Offset: 0x0065CC58
		public void UnPackTo(IGroupAiCommunicateAddTagT _o)
		{
			_o.Type = this.Type;
			_o.Tags = new List<string>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x0602EB9F RID: 191391 RVA: 0x0065EAA0 File Offset: 0x0065CCA0
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

		// Token: 0x04010FF4 RID: 69620
		private Table __p;
	}
}
