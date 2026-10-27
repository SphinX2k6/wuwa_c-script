using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A06 RID: 18950
	public struct ICheckEntityHasSceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x17008922 RID: 35106
		// (get) Token: 0x0601DA1C RID: 121372 RVA: 0x0042BA1F File Offset: 0x00429C1F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA1D RID: 121373 RVA: 0x0042BA2C File Offset: 0x00429C2C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA1E RID: 121374 RVA: 0x0042BA34 File Offset: 0x00429C34
		public static ICheckEntityHasSceneItemAttributeTag GetRootAsICheckEntityHasSceneItemAttributeTag(ByteBuffer _bb)
		{
			return ICheckEntityHasSceneItemAttributeTag.GetRootAsICheckEntityHasSceneItemAttributeTag(_bb, default(ICheckEntityHasSceneItemAttributeTag));
		}

		// Token: 0x0601DA1F RID: 121375 RVA: 0x0042BA50 File Offset: 0x00429C50
		public static ICheckEntityHasSceneItemAttributeTag GetRootAsICheckEntityHasSceneItemAttributeTag(ByteBuffer _bb, ICheckEntityHasSceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA20 RID: 121376 RVA: 0x0042BA6D File Offset: 0x00429C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA21 RID: 121377 RVA: 0x0042BA7C File Offset: 0x00429C7C
		public ICheckEntityHasSceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008923 RID: 35107
		// (get) Token: 0x0601DA22 RID: 121378 RVA: 0x0042BA8C File Offset: 0x00429C8C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008924 RID: 35108
		// (get) Token: 0x0601DA23 RID: 121379 RVA: 0x0042BAC8 File Offset: 0x00429CC8
		public ECheckEntityPerformanceAttributeType CheckType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECheckEntityPerformanceAttributeType.MatchAll;
				}
				return (ECheckEntityPerformanceAttributeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008925 RID: 35109
		// (get) Token: 0x0601DA24 RID: 121380 RVA: 0x0042BB04 File Offset: 0x00429D04
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DA25 RID: 121381 RVA: 0x0042BB40 File Offset: 0x00429D40
		public int Tags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008926 RID: 35110
		// (get) Token: 0x0601DA26 RID: 121382 RVA: 0x0042BB80 File Offset: 0x00429D80
		public int TagsLength
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

		// Token: 0x0601DA27 RID: 121383 RVA: 0x0042BBAC File Offset: 0x00429DAC
		public Span<int> GetTagsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601DA28 RID: 121384 RVA: 0x0042BBBC File Offset: 0x00429DBC
		public int[] GetTagsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601DA29 RID: 121385 RVA: 0x0042BBCB File Offset: 0x00429DCB
		public static Offset<ICheckEntityHasSceneItemAttributeTag> CreateICheckEntityHasSceneItemAttributeTag(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECheckEntityPerformanceAttributeType CheckType = ECheckEntityPerformanceAttributeType.MatchAll, int EntityId = 0, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICheckEntityHasSceneItemAttributeTag.AddTags(builder, TagsOffset);
			ICheckEntityHasSceneItemAttributeTag.AddEntityId(builder, EntityId);
			ICheckEntityHasSceneItemAttributeTag.AddCheckType(builder, CheckType);
			ICheckEntityHasSceneItemAttributeTag.AddType(builder, Type);
			return ICheckEntityHasSceneItemAttributeTag.EndICheckEntityHasSceneItemAttributeTag(builder);
		}

		// Token: 0x0601DA2A RID: 121386 RVA: 0x0042BBF7 File Offset: 0x00429DF7
		public static void StartICheckEntityHasSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DA2B RID: 121387 RVA: 0x0042BC00 File Offset: 0x00429E00
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DA2C RID: 121388 RVA: 0x0042BC0B File Offset: 0x00429E0B
		public static void AddCheckType(FlatBufferBuilder builder, ECheckEntityPerformanceAttributeType checkType)
		{
			builder.AddByte(1, (byte)checkType, 0);
		}

		// Token: 0x0601DA2D RID: 121389 RVA: 0x0042BC16 File Offset: 0x00429E16
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601DA2E RID: 121390 RVA: 0x0042BC21 File Offset: 0x00429E21
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(3, tagsOffset.Value, 0);
		}

		// Token: 0x0601DA2F RID: 121391 RVA: 0x0042BC34 File Offset: 0x00429E34
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DA30 RID: 121392 RVA: 0x0042BC6B File Offset: 0x00429E6B
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA31 RID: 121393 RVA: 0x0042BC85 File Offset: 0x00429E85
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA32 RID: 121394 RVA: 0x0042BCA3 File Offset: 0x00429EA3
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DA33 RID: 121395 RVA: 0x0042BCBC File Offset: 0x00429EBC
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DA34 RID: 121396 RVA: 0x0042BCC7 File Offset: 0x00429EC7
		public static Offset<ICheckEntityHasSceneItemAttributeTag> EndICheckEntityHasSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityHasSceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x0601DA35 RID: 121397 RVA: 0x0042BCD4 File Offset: 0x00429ED4
		public ICheckEntityHasSceneItemAttributeTagT UnPack()
		{
			ICheckEntityHasSceneItemAttributeTagT checkEntityHasSceneItemAttributeTagT = new ICheckEntityHasSceneItemAttributeTagT();
			this.UnPackTo(checkEntityHasSceneItemAttributeTagT);
			return checkEntityHasSceneItemAttributeTagT;
		}

		// Token: 0x0601DA36 RID: 121398 RVA: 0x0042BCF0 File Offset: 0x00429EF0
		public void UnPackTo(ICheckEntityHasSceneItemAttributeTagT _o)
		{
			_o.Type = this.Type;
			_o.CheckType = this.CheckType;
			_o.EntityId = this.EntityId;
			_o.Tags = new List<int>();
			for (int i = 0; i < this.TagsLength; i++)
			{
				_o.Tags.Add(this.Tags(i));
			}
		}

		// Token: 0x0601DA37 RID: 121399 RVA: 0x0042BD50 File Offset: 0x00429F50
		public static Offset<ICheckEntityHasSceneItemAttributeTag> Pack(FlatBufferBuilder builder, ICheckEntityHasSceneItemAttributeTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityHasSceneItemAttributeTag>);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				int[] data = _o.Tags.ToArray();
				tagsOffset = ICheckEntityHasSceneItemAttributeTag.CreateTagsVector(builder, data);
			}
			return ICheckEntityHasSceneItemAttributeTag.CreateICheckEntityHasSceneItemAttributeTag(builder, _o.Type, _o.CheckType, _o.EntityId, tagsOffset);
		}

		// Token: 0x0400D24A RID: 53834
		private Table __p;
	}
}
