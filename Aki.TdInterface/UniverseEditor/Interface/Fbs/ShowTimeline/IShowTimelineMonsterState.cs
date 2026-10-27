using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC5 RID: 15301
	public struct IShowTimelineMonsterState : IFlatbufferObject
	{
		// Token: 0x170068F3 RID: 26867
		// (get) Token: 0x06015019 RID: 86041 RVA: 0x0030BAA9 File Offset: 0x00309CA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601501A RID: 86042 RVA: 0x0030BAB6 File Offset: 0x00309CB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601501B RID: 86043 RVA: 0x0030BAC0 File Offset: 0x00309CC0
		public static IShowTimelineMonsterState GetRootAsIShowTimelineMonsterState(ByteBuffer _bb)
		{
			return IShowTimelineMonsterState.GetRootAsIShowTimelineMonsterState(_bb, default(IShowTimelineMonsterState));
		}

		// Token: 0x0601501C RID: 86044 RVA: 0x0030BADC File Offset: 0x00309CDC
		public static IShowTimelineMonsterState GetRootAsIShowTimelineMonsterState(ByteBuffer _bb, IShowTimelineMonsterState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601501D RID: 86045 RVA: 0x0030BAF9 File Offset: 0x00309CF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601501E RID: 86046 RVA: 0x0030BB08 File Offset: 0x00309D08
		public IShowTimelineMonsterState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068F4 RID: 26868
		// (get) Token: 0x0601501F RID: 86047 RVA: 0x0030BB18 File Offset: 0x00309D18
		public int MonsterEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170068F5 RID: 26869
		// (get) Token: 0x06015020 RID: 86048 RVA: 0x0030BB54 File Offset: 0x00309D54
		public ITransform? Transform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITransform?(default(ITransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015021 RID: 86049 RVA: 0x0030BBB4 File Offset: 0x00309DB4
		public int Attributes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170068F6 RID: 26870
		// (get) Token: 0x06015022 RID: 86050 RVA: 0x0030BBF4 File Offset: 0x00309DF4
		public int AttributesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06015023 RID: 86051 RVA: 0x0030BC1F File Offset: 0x00309E1F
		public Span<int> GetAttributesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06015024 RID: 86052 RVA: 0x0030BC2E File Offset: 0x00309E2E
		public int[] GetAttributesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06015025 RID: 86053 RVA: 0x0030BC3C File Offset: 0x00309E3C
		public int Buffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170068F7 RID: 26871
		// (get) Token: 0x06015026 RID: 86054 RVA: 0x0030BC7C File Offset: 0x00309E7C
		public int BuffsLength
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

		// Token: 0x06015027 RID: 86055 RVA: 0x0030BCA8 File Offset: 0x00309EA8
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06015028 RID: 86056 RVA: 0x0030BCB8 File Offset: 0x00309EB8
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06015029 RID: 86057 RVA: 0x0030BCC8 File Offset: 0x00309EC8
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170068F8 RID: 26872
		// (get) Token: 0x0601502A RID: 86058 RVA: 0x0030BD0C File Offset: 0x00309F0C
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601502B RID: 86059 RVA: 0x0030BD38 File Offset: 0x00309F38
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(12, 8);
		}

		// Token: 0x0601502C RID: 86060 RVA: 0x0030BD48 File Offset: 0x00309F48
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(12);
		}

		// Token: 0x0601502D RID: 86061 RVA: 0x0030BD58 File Offset: 0x00309F58
		public string Tags(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170068F9 RID: 26873
		// (get) Token: 0x0601502E RID: 86062 RVA: 0x0030BD94 File Offset: 0x00309F94
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601502F RID: 86063 RVA: 0x0030BDC0 File Offset: 0x00309FC0
		public static Offset<IShowTimelineMonsterState> CreateIShowTimelineMonsterState(FlatBufferBuilder builder, int MonsterEntityId = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>), VectorOffset AttributesOffset = default(VectorOffset), VectorOffset BuffsOffset = default(VectorOffset), VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(6);
			IShowTimelineMonsterState.AddTags(builder, TagsOffset);
			IShowTimelineMonsterState.AddBuffIds(builder, BuffIdsOffset);
			IShowTimelineMonsterState.AddBuffs(builder, BuffsOffset);
			IShowTimelineMonsterState.AddAttributes(builder, AttributesOffset);
			IShowTimelineMonsterState.AddTransform(builder, TransformOffset);
			IShowTimelineMonsterState.AddMonsterEntityId(builder, MonsterEntityId);
			return IShowTimelineMonsterState.EndIShowTimelineMonsterState(builder);
		}

		// Token: 0x06015030 RID: 86064 RVA: 0x0030BDFC File Offset: 0x00309FFC
		public static void StartIShowTimelineMonsterState(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06015031 RID: 86065 RVA: 0x0030BE05 File Offset: 0x0030A005
		public static void AddMonsterEntityId(FlatBufferBuilder builder, int monsterEntityId)
		{
			builder.AddInt(0, monsterEntityId, 0);
		}

		// Token: 0x06015032 RID: 86066 RVA: 0x0030BE10 File Offset: 0x0030A010
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x06015033 RID: 86067 RVA: 0x0030BE20 File Offset: 0x0030A020
		public static void AddAttributes(FlatBufferBuilder builder, VectorOffset attributesOffset)
		{
			builder.AddOffset(2, attributesOffset.Value, 0);
		}

		// Token: 0x06015034 RID: 86068 RVA: 0x0030BE30 File Offset: 0x0030A030
		public static VectorOffset CreateAttributesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015035 RID: 86069 RVA: 0x0030BE67 File Offset: 0x0030A067
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015036 RID: 86070 RVA: 0x0030BE81 File Offset: 0x0030A081
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015037 RID: 86071 RVA: 0x0030BE9F File Offset: 0x0030A09F
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015038 RID: 86072 RVA: 0x0030BEB8 File Offset: 0x0030A0B8
		public static void StartAttributesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015039 RID: 86073 RVA: 0x0030BEC3 File Offset: 0x0030A0C3
		public static void AddBuffs(FlatBufferBuilder builder, VectorOffset buffsOffset)
		{
			builder.AddOffset(3, buffsOffset.Value, 0);
		}

		// Token: 0x0601503A RID: 86074 RVA: 0x0030BED4 File Offset: 0x0030A0D4
		public static VectorOffset CreateBuffsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601503B RID: 86075 RVA: 0x0030BF0B File Offset: 0x0030A10B
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601503C RID: 86076 RVA: 0x0030BF25 File Offset: 0x0030A125
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601503D RID: 86077 RVA: 0x0030BF43 File Offset: 0x0030A143
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601503E RID: 86078 RVA: 0x0030BF5C File Offset: 0x0030A15C
		public static void StartBuffsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601503F RID: 86079 RVA: 0x0030BF67 File Offset: 0x0030A167
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(4, buffIdsOffset.Value, 0);
		}

		// Token: 0x06015040 RID: 86080 RVA: 0x0030BF78 File Offset: 0x0030A178
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015041 RID: 86081 RVA: 0x0030BFAF File Offset: 0x0030A1AF
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06015042 RID: 86082 RVA: 0x0030BFC9 File Offset: 0x0030A1C9
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06015043 RID: 86083 RVA: 0x0030BFE7 File Offset: 0x0030A1E7
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015044 RID: 86084 RVA: 0x0030C000 File Offset: 0x0030A200
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06015045 RID: 86085 RVA: 0x0030C00B File Offset: 0x0030A20B
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(5, tagsOffset.Value, 0);
		}

		// Token: 0x06015046 RID: 86086 RVA: 0x0030C01C File Offset: 0x0030A21C
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015047 RID: 86087 RVA: 0x0030C05C File Offset: 0x0030A25C
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015048 RID: 86088 RVA: 0x0030C076 File Offset: 0x0030A276
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015049 RID: 86089 RVA: 0x0030C094 File Offset: 0x0030A294
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601504A RID: 86090 RVA: 0x0030C0AD File Offset: 0x0030A2AD
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601504B RID: 86091 RVA: 0x0030C0B8 File Offset: 0x0030A2B8
		public static Offset<IShowTimelineMonsterState> EndIShowTimelineMonsterState(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineMonsterState>(builder.EndTable());
		}

		// Token: 0x0601504C RID: 86092 RVA: 0x0030C0C8 File Offset: 0x0030A2C8
		public IShowTimelineMonsterStateT UnPack()
		{
			IShowTimelineMonsterStateT showTimelineMonsterStateT = new IShowTimelineMonsterStateT();
			this.UnPackTo(showTimelineMonsterStateT);
			return showTimelineMonsterStateT;
		}

		// Token: 0x0601504D RID: 86093 RVA: 0x0030C0E4 File Offset: 0x0030A2E4
		public void UnPackTo(IShowTimelineMonsterStateT _o)
		{
			_o.MonsterEntityId = this.MonsterEntityId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.Attributes = new List<int>();
			for (int i = 0; i < this.AttributesLength; i++)
			{
				_o.Attributes.Add(this.Attributes(i));
			}
			_o.Buffs = new List<int>();
			for (int j = 0; j < this.BuffsLength; j++)
			{
				_o.Buffs.Add(this.Buffs(j));
			}
			_o.BuffIds = new List<long>();
			for (int k = 0; k < this.BuffIdsLength; k++)
			{
				_o.BuffIds.Add(this.BuffIds(k));
			}
			_o.Tags = new List<string>();
			for (int l = 0; l < this.TagsLength; l++)
			{
				_o.Tags.Add(this.Tags(l));
			}
		}

		// Token: 0x0601504E RID: 86094 RVA: 0x0030C1F0 File Offset: 0x0030A3F0
		public static Offset<IShowTimelineMonsterState> Pack(FlatBufferBuilder builder, IShowTimelineMonsterStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineMonsterState>);
			}
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			VectorOffset attributesOffset = default(VectorOffset);
			if (_o.Attributes != null)
			{
				int[] data = _o.Attributes.ToArray();
				attributesOffset = IShowTimelineMonsterState.CreateAttributesVector(builder, data);
			}
			VectorOffset buffsOffset = default(VectorOffset);
			if (_o.Buffs != null)
			{
				int[] data2 = _o.Buffs.ToArray();
				buffsOffset = IShowTimelineMonsterState.CreateBuffsVector(builder, data2);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data3 = _o.BuffIds.ToArray();
				buffIdsOffset = IShowTimelineMonsterState.CreateBuffIdsVector(builder, data3);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				StringOffset[] array = new StringOffset[_o.Tags.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Tags[i]);
				}
				tagsOffset = IShowTimelineMonsterState.CreateTagsVector(builder, array);
			}
			return IShowTimelineMonsterState.CreateIShowTimelineMonsterState(builder, _o.MonsterEntityId, transformOffset, attributesOffset, buffsOffset, buffIdsOffset, tagsOffset);
		}

		// Token: 0x0400B14D RID: 45389
		private Table __p;
	}
}
