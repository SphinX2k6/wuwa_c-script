using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4D RID: 28493
	public struct IGroupAiCommunicateRemoveTag : IFlatbufferObject
	{
		// Token: 0x1700D0CF RID: 53455
		// (get) Token: 0x06031500 RID: 201984 RVA: 0x006ADEC0 File Offset: 0x006AC0C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031501 RID: 201985 RVA: 0x006ADECD File Offset: 0x006AC0CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031502 RID: 201986 RVA: 0x006ADED4 File Offset: 0x006AC0D4
		public static IGroupAiCommunicateRemoveTag GetRootAsIGroupAiCommunicateRemoveTag(ByteBuffer _bb)
		{
			return IGroupAiCommunicateRemoveTag.GetRootAsIGroupAiCommunicateRemoveTag(_bb, default(IGroupAiCommunicateRemoveTag));
		}

		// Token: 0x06031503 RID: 201987 RVA: 0x006ADEF0 File Offset: 0x006AC0F0
		public static IGroupAiCommunicateRemoveTag GetRootAsIGroupAiCommunicateRemoveTag(ByteBuffer _bb, IGroupAiCommunicateRemoveTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031504 RID: 201988 RVA: 0x006ADF0D File Offset: 0x006AC10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031505 RID: 201989 RVA: 0x006ADF1C File Offset: 0x006AC11C
		public IGroupAiCommunicateRemoveTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0D0 RID: 53456
		// (get) Token: 0x06031506 RID: 201990 RVA: 0x006ADF2C File Offset: 0x006AC12C
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

		// Token: 0x06031507 RID: 201991 RVA: 0x006ADF68 File Offset: 0x006AC168
		public string Tags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D0D1 RID: 53457
		// (get) Token: 0x06031508 RID: 201992 RVA: 0x006ADFA4 File Offset: 0x006AC1A4
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

		// Token: 0x06031509 RID: 201993 RVA: 0x006ADFCF File Offset: 0x006AC1CF
		public static Offset<IGroupAiCommunicateRemoveTag> CreateIGroupAiCommunicateRemoveTag(FlatBufferBuilder builder, EGroupAiCommunicateType Type = EGroupAiCommunicateType.AddTag, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IGroupAiCommunicateRemoveTag.AddTags(builder, TagsOffset);
			IGroupAiCommunicateRemoveTag.AddType(builder, Type);
			return IGroupAiCommunicateRemoveTag.EndIGroupAiCommunicateRemoveTag(builder);
		}

		// Token: 0x0603150A RID: 201994 RVA: 0x006ADFEC File Offset: 0x006AC1EC
		public static void StartIGroupAiCommunicateRemoveTag(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603150B RID: 201995 RVA: 0x006ADFF5 File Offset: 0x006AC1F5
		public static void AddType(FlatBufferBuilder builder, EGroupAiCommunicateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603150C RID: 201996 RVA: 0x006AE000 File Offset: 0x006AC200
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(1, tagsOffset.Value, 0);
		}

		// Token: 0x0603150D RID: 201997 RVA: 0x006AE010 File Offset: 0x006AC210
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603150E RID: 201998 RVA: 0x006AE050 File Offset: 0x006AC250
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603150F RID: 201999 RVA: 0x006AE06A File Offset: 0x006AC26A
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06031510 RID: 202000 RVA: 0x006AE088 File Offset: 0x006AC288
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031511 RID: 202001 RVA: 0x006AE0A1 File Offset: 0x006AC2A1
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031512 RID: 202002 RVA: 0x006AE0AC File Offset: 0x006AC2AC
		public static Offset<IGroupAiCommunicateRemoveTag> EndIGroupAiCommunicateRemoveTag(FlatBufferBuilder builder)
		{
			return new Offset<IGroupAiCommunicateRemoveTag>(builder.EndTable());
		}

		// Token: 0x06031513 RID: 202003 RVA: 0x006AE0BC File Offset: 0x006AC2BC
		public IGroupAiCommunicateRemoveTagT UnPack()
		{
			IGroupAiCommunicateRemoveTagT groupAiCommunicateRemoveTagT = new IGroupAiCommunicateRemoveTagT();
			this.UnPackTo(groupAiCommunicateRemoveTagT);
			return groupAiCommunicateRemoveTagT;
		}

		// Token: 0x06031514 RID: 202004 RVA: 0x006AE0D8 File Offset: 0x006AC2D8
		public void UnPackTo(IGroupAiCommunicateRemoveTagT _o)
		{
			_o.Type = this.Type;
			_o.Tags = new List<string>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x06031515 RID: 202005 RVA: 0x006AE120 File Offset: 0x006AC320
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

		// Token: 0x04011E55 RID: 73301
		private Table __p;
	}
}
