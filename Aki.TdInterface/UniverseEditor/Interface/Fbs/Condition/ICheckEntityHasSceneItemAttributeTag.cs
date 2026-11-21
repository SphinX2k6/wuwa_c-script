using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC6 RID: 20166
	public struct ICheckEntityHasSceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x17008FF2 RID: 36850
		// (get) Token: 0x0601F48F RID: 128143 RVA: 0x0045C68B File Offset: 0x0045A88B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F490 RID: 128144 RVA: 0x0045C698 File Offset: 0x0045A898
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F491 RID: 128145 RVA: 0x0045C6A0 File Offset: 0x0045A8A0
		public static ICheckEntityHasSceneItemAttributeTag GetRootAsICheckEntityHasSceneItemAttributeTag(ByteBuffer _bb)
		{
			return ICheckEntityHasSceneItemAttributeTag.GetRootAsICheckEntityHasSceneItemAttributeTag(_bb, default(ICheckEntityHasSceneItemAttributeTag));
		}

		// Token: 0x0601F492 RID: 128146 RVA: 0x0045C6BC File Offset: 0x0045A8BC
		public static ICheckEntityHasSceneItemAttributeTag GetRootAsICheckEntityHasSceneItemAttributeTag(ByteBuffer _bb, ICheckEntityHasSceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F493 RID: 128147 RVA: 0x0045C6D9 File Offset: 0x0045A8D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F494 RID: 128148 RVA: 0x0045C6E8 File Offset: 0x0045A8E8
		public ICheckEntityHasSceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FF3 RID: 36851
		// (get) Token: 0x0601F495 RID: 128149 RVA: 0x0045C6F8 File Offset: 0x0045A8F8
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

		// Token: 0x17008FF4 RID: 36852
		// (get) Token: 0x0601F496 RID: 128150 RVA: 0x0045C734 File Offset: 0x0045A934
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

		// Token: 0x17008FF5 RID: 36853
		// (get) Token: 0x0601F497 RID: 128151 RVA: 0x0045C770 File Offset: 0x0045A970
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

		// Token: 0x0601F498 RID: 128152 RVA: 0x0045C7AC File Offset: 0x0045A9AC
		public int Tags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008FF6 RID: 36854
		// (get) Token: 0x0601F499 RID: 128153 RVA: 0x0045C7EC File Offset: 0x0045A9EC
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

		// Token: 0x0601F49A RID: 128154 RVA: 0x0045C818 File Offset: 0x0045AA18
		public Span<int> GetTagsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601F49B RID: 128155 RVA: 0x0045C828 File Offset: 0x0045AA28
		public int[] GetTagsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601F49C RID: 128156 RVA: 0x0045C837 File Offset: 0x0045AA37
		public static Offset<ICheckEntityHasSceneItemAttributeTag> CreateICheckEntityHasSceneItemAttributeTag(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECheckEntityPerformanceAttributeType CheckType = ECheckEntityPerformanceAttributeType.MatchAll, int EntityId = 0, VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICheckEntityHasSceneItemAttributeTag.AddTags(builder, TagsOffset);
			ICheckEntityHasSceneItemAttributeTag.AddEntityId(builder, EntityId);
			ICheckEntityHasSceneItemAttributeTag.AddCheckType(builder, CheckType);
			ICheckEntityHasSceneItemAttributeTag.AddType(builder, Type);
			return ICheckEntityHasSceneItemAttributeTag.EndICheckEntityHasSceneItemAttributeTag(builder);
		}

		// Token: 0x0601F49D RID: 128157 RVA: 0x0045C863 File Offset: 0x0045AA63
		public static void StartICheckEntityHasSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F49E RID: 128158 RVA: 0x0045C86C File Offset: 0x0045AA6C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F49F RID: 128159 RVA: 0x0045C877 File Offset: 0x0045AA77
		public static void AddCheckType(FlatBufferBuilder builder, ECheckEntityPerformanceAttributeType checkType)
		{
			builder.AddByte(1, (byte)checkType, 0);
		}

		// Token: 0x0601F4A0 RID: 128160 RVA: 0x0045C882 File Offset: 0x0045AA82
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601F4A1 RID: 128161 RVA: 0x0045C88D File Offset: 0x0045AA8D
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(3, tagsOffset.Value, 0);
		}

		// Token: 0x0601F4A2 RID: 128162 RVA: 0x0045C8A0 File Offset: 0x0045AAA0
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F4A3 RID: 128163 RVA: 0x0045C8D7 File Offset: 0x0045AAD7
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F4A4 RID: 128164 RVA: 0x0045C8F1 File Offset: 0x0045AAF1
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F4A5 RID: 128165 RVA: 0x0045C90F File Offset: 0x0045AB0F
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F4A6 RID: 128166 RVA: 0x0045C928 File Offset: 0x0045AB28
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F4A7 RID: 128167 RVA: 0x0045C933 File Offset: 0x0045AB33
		public static Offset<ICheckEntityHasSceneItemAttributeTag> EndICheckEntityHasSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityHasSceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x0601F4A8 RID: 128168 RVA: 0x0045C940 File Offset: 0x0045AB40
		public ICheckEntityHasSceneItemAttributeTagT UnPack()
		{
			ICheckEntityHasSceneItemAttributeTagT checkEntityHasSceneItemAttributeTagT = new ICheckEntityHasSceneItemAttributeTagT();
			this.UnPackTo(checkEntityHasSceneItemAttributeTagT);
			return checkEntityHasSceneItemAttributeTagT;
		}

		// Token: 0x0601F4A9 RID: 128169 RVA: 0x0045C95C File Offset: 0x0045AB5C
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

		// Token: 0x0601F4AA RID: 128170 RVA: 0x0045C9BC File Offset: 0x0045ABBC
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

		// Token: 0x0400DD1E RID: 56606
		private Table __p;
	}
}
