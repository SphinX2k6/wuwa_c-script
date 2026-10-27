using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AC RID: 26796
	public struct IGroupAiCommunicateRemoveTag : IFlatbufferObject
	{
		// Token: 0x1700C6E9 RID: 50921
		// (get) Token: 0x0602EBC6 RID: 191430 RVA: 0x0065EE40 File Offset: 0x0065D040
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EBC7 RID: 191431 RVA: 0x0065EE4D File Offset: 0x0065D04D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EBC8 RID: 191432 RVA: 0x0065EE54 File Offset: 0x0065D054
		public static IGroupAiCommunicateRemoveTag GetRootAsIGroupAiCommunicateRemoveTag(ByteBuffer _bb)
		{
			return IGroupAiCommunicateRemoveTag.GetRootAsIGroupAiCommunicateRemoveTag(_bb, default(IGroupAiCommunicateRemoveTag));
		}

		// Token: 0x0602EBC9 RID: 191433 RVA: 0x0065EE70 File Offset: 0x0065D070
		public static IGroupAiCommunicateRemoveTag GetRootAsIGroupAiCommunicateRemoveTag(ByteBuffer _bb, IGroupAiCommunicateRemoveTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBCA RID: 191434 RVA: 0x0065EE8D File Offset: 0x0065D08D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBCB RID: 191435 RVA: 0x0065EE9C File Offset: 0x0065D09C
		public IGroupAiCommunicateRemoveTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6EA RID: 50922
		// (get) Token: 0x0602EBCC RID: 191436 RVA: 0x0065EEAC File Offset: 0x0065D0AC
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

		// Token: 0x0602EBCD RID: 191437 RVA: 0x0065EEE8 File Offset: 0x0065D0E8
		public string Tags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C6EB RID: 50923
		// (get) Token: 0x0602EBCE RID: 191438 RVA: 0x0065EF24 File Offset: 0x0065D124
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

		// Token: 0x0602EBCF RID: 191439 RVA: 0x0065EF4F File Offset: 0x0065D14F
		public static Offset<IGroupAiCommunicateRemoveTag> CreateIGroupAiCommunicateRemoveTag(FlatBufferBuilder builder, EGroupAiCommunicateType Type = EGroupAiCommunicateType.AddTag, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGroupAiCommunicateRemoveTag.AddTags(builder, TagsOffset);
			IGroupAiCommunicateRemoveTag.AddType(builder, Type);
			return IGroupAiCommunicateRemoveTag.EndIGroupAiCommunicateRemoveTag(builder);
		}

		// Token: 0x0602EBD0 RID: 191440 RVA: 0x0065EF6C File Offset: 0x0065D16C
		public static void StartIGroupAiCommunicateRemoveTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EBD1 RID: 191441 RVA: 0x0065EF75 File Offset: 0x0065D175
		public static void AddType(FlatBufferBuilder builder, EGroupAiCommunicateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EBD2 RID: 191442 RVA: 0x0065EF80 File Offset: 0x0065D180
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(1, tagsOffset.Value, 0);
		}

		// Token: 0x0602EBD3 RID: 191443 RVA: 0x0065EF90 File Offset: 0x0065D190
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EBD4 RID: 191444 RVA: 0x0065EFD0 File Offset: 0x0065D1D0
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EBD5 RID: 191445 RVA: 0x0065EFEA File Offset: 0x0065D1EA
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EBD6 RID: 191446 RVA: 0x0065F008 File Offset: 0x0065D208
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EBD7 RID: 191447 RVA: 0x0065F021 File Offset: 0x0065D221
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EBD8 RID: 191448 RVA: 0x0065F02C File Offset: 0x0065D22C
		public static Offset<IGroupAiCommunicateRemoveTag> EndIGroupAiCommunicateRemoveTag(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiCommunicateRemoveTag>(builder.EndTable());
		}

		// Token: 0x0602EBD9 RID: 191449 RVA: 0x0065F03C File Offset: 0x0065D23C
		public IGroupAiCommunicateRemoveTagT UnPack()
		{
			IGroupAiCommunicateRemoveTagT groupAiCommunicateRemoveTagT = new IGroupAiCommunicateRemoveTagT();
			this.UnPackTo(groupAiCommunicateRemoveTagT);
			return groupAiCommunicateRemoveTagT;
		}

		// Token: 0x0602EBDA RID: 191450 RVA: 0x0065F058 File Offset: 0x0065D258
		public void UnPackTo(IGroupAiCommunicateRemoveTagT _o)
		{
			_o.Type = this.Type;
			_o.Tags = new List<string>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x0602EBDB RID: 191451 RVA: 0x0065F0A0 File Offset: 0x0065D2A0
		public static Offset<IGroupAiCommunicateRemoveTag> Pack(FlatBufferBuilder builder, IGroupAiCommunicateRemoveTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGroupAiCommunicateRemoveTag>);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				StringOffset[] array = new StringOffset[_o.Tags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Tags[i]);
				}
				tagsOffset = IGroupAiCommunicateRemoveTag.CreateTagsVector(builder, array);
			}
			return IGroupAiCommunicateRemoveTag.CreateIGroupAiCommunicateRemoveTag(builder, _o.Type, tagsOffset);
		}

		// Token: 0x04011000 RID: 69632
		private Table __p;
	}
}
