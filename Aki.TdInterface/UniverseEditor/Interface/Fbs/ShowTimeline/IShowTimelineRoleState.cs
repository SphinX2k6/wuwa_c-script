using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC8 RID: 15304
	public struct IShowTimelineRoleState : IFlatbufferObject
	{
		// Token: 0x17006900 RID: 26880
		// (get) Token: 0x0601505D RID: 86109 RVA: 0x0030C42D File Offset: 0x0030A62D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601505E RID: 86110 RVA: 0x0030C43A File Offset: 0x0030A63A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601505F RID: 86111 RVA: 0x0030C444 File Offset: 0x0030A644
		public static IShowTimelineRoleState GetRootAsIShowTimelineRoleState(ByteBuffer _bb)
		{
			return IShowTimelineRoleState.GetRootAsIShowTimelineRoleState(_bb, default(IShowTimelineRoleState));
		}

		// Token: 0x06015060 RID: 86112 RVA: 0x0030C460 File Offset: 0x0030A660
		public static IShowTimelineRoleState GetRootAsIShowTimelineRoleState(ByteBuffer _bb, IShowTimelineRoleState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015061 RID: 86113 RVA: 0x0030C47D File Offset: 0x0030A67D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015062 RID: 86114 RVA: 0x0030C48C File Offset: 0x0030A68C
		public IShowTimelineRoleState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006901 RID: 26881
		// (get) Token: 0x06015063 RID: 86115 RVA: 0x0030C49C File Offset: 0x0030A69C
		public int RoleId
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

		// Token: 0x17006902 RID: 26882
		// (get) Token: 0x06015064 RID: 86116 RVA: 0x0030C4D8 File Offset: 0x0030A6D8
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

		// Token: 0x06015065 RID: 86117 RVA: 0x0030C538 File Offset: 0x0030A738
		public int Attributes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006903 RID: 26883
		// (get) Token: 0x06015066 RID: 86118 RVA: 0x0030C578 File Offset: 0x0030A778
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

		// Token: 0x06015067 RID: 86119 RVA: 0x0030C5A3 File Offset: 0x0030A7A3
		public Span<int> GetAttributesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06015068 RID: 86120 RVA: 0x0030C5B2 File Offset: 0x0030A7B2
		public int[] GetAttributesArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06015069 RID: 86121 RVA: 0x0030C5C0 File Offset: 0x0030A7C0
		public int Buffs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006904 RID: 26884
		// (get) Token: 0x0601506A RID: 86122 RVA: 0x0030C600 File Offset: 0x0030A800
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

		// Token: 0x0601506B RID: 86123 RVA: 0x0030C62C File Offset: 0x0030A82C
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601506C RID: 86124 RVA: 0x0030C63C File Offset: 0x0030A83C
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601506D RID: 86125 RVA: 0x0030C64C File Offset: 0x0030A84C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17006905 RID: 26885
		// (get) Token: 0x0601506E RID: 86126 RVA: 0x0030C690 File Offset: 0x0030A890
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

		// Token: 0x0601506F RID: 86127 RVA: 0x0030C6BC File Offset: 0x0030A8BC
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(12, 8);
		}

		// Token: 0x06015070 RID: 86128 RVA: 0x0030C6CC File Offset: 0x0030A8CC
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(12);
		}

		// Token: 0x06015071 RID: 86129 RVA: 0x0030C6DC File Offset: 0x0030A8DC
		public string BuffDebugNames(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006906 RID: 26886
		// (get) Token: 0x06015072 RID: 86130 RVA: 0x0030C718 File Offset: 0x0030A918
		public int BuffDebugNamesLength
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

		// Token: 0x06015073 RID: 86131 RVA: 0x0030C744 File Offset: 0x0030A944
		public string Tags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006907 RID: 26887
		// (get) Token: 0x06015074 RID: 86132 RVA: 0x0030C780 File Offset: 0x0030A980
		public int TagsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06015075 RID: 86133 RVA: 0x0030C7AC File Offset: 0x0030A9AC
		public static Offset<IShowTimelineRoleState> CreateIShowTimelineRoleState(FlatBufferBuilder builder, int RoleId = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>), VectorOffset AttributesOffset = default(VectorOffset), VectorOffset BuffsOffset = default(VectorOffset), VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset BuffDebugNamesOffset = default(VectorOffset), VectorOffset TagsOffset = default(VectorOffset))
		{
			builder.StartTable(7);
			IShowTimelineRoleState.AddTags(builder, TagsOffset);
			IShowTimelineRoleState.AddBuffDebugNames(builder, BuffDebugNamesOffset);
			IShowTimelineRoleState.AddBuffIds(builder, BuffIdsOffset);
			IShowTimelineRoleState.AddBuffs(builder, BuffsOffset);
			IShowTimelineRoleState.AddAttributes(builder, AttributesOffset);
			IShowTimelineRoleState.AddTransform(builder, TransformOffset);
			IShowTimelineRoleState.AddRoleId(builder, RoleId);
			return IShowTimelineRoleState.EndIShowTimelineRoleState(builder);
		}

		// Token: 0x06015076 RID: 86134 RVA: 0x0030C7FB File Offset: 0x0030A9FB
		public static void StartIShowTimelineRoleState(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06015077 RID: 86135 RVA: 0x0030C804 File Offset: 0x0030AA04
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(0, roleId, 0);
		}

		// Token: 0x06015078 RID: 86136 RVA: 0x0030C80F File Offset: 0x0030AA0F
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x06015079 RID: 86137 RVA: 0x0030C81F File Offset: 0x0030AA1F
		public static void AddAttributes(FlatBufferBuilder builder, VectorOffset attributesOffset)
		{
			builder.AddOffset(2, attributesOffset.Value, 0);
		}

		// Token: 0x0601507A RID: 86138 RVA: 0x0030C830 File Offset: 0x0030AA30
		public static VectorOffset CreateAttributesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601507B RID: 86139 RVA: 0x0030C867 File Offset: 0x0030AA67
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601507C RID: 86140 RVA: 0x0030C881 File Offset: 0x0030AA81
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601507D RID: 86141 RVA: 0x0030C89F File Offset: 0x0030AA9F
		public static VectorOffset CreateAttributesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601507E RID: 86142 RVA: 0x0030C8B8 File Offset: 0x0030AAB8
		public static void StartAttributesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601507F RID: 86143 RVA: 0x0030C8C3 File Offset: 0x0030AAC3
		public static void AddBuffs(FlatBufferBuilder builder, VectorOffset buffsOffset)
		{
			builder.AddOffset(3, buffsOffset.Value, 0);
		}

		// Token: 0x06015080 RID: 86144 RVA: 0x0030C8D4 File Offset: 0x0030AAD4
		public static VectorOffset CreateBuffsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015081 RID: 86145 RVA: 0x0030C90B File Offset: 0x0030AB0B
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015082 RID: 86146 RVA: 0x0030C925 File Offset: 0x0030AB25
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015083 RID: 86147 RVA: 0x0030C943 File Offset: 0x0030AB43
		public static VectorOffset CreateBuffsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015084 RID: 86148 RVA: 0x0030C95C File Offset: 0x0030AB5C
		public static void StartBuffsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015085 RID: 86149 RVA: 0x0030C967 File Offset: 0x0030AB67
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(4, buffIdsOffset.Value, 0);
		}

		// Token: 0x06015086 RID: 86150 RVA: 0x0030C978 File Offset: 0x0030AB78
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015087 RID: 86151 RVA: 0x0030C9AF File Offset: 0x0030ABAF
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06015088 RID: 86152 RVA: 0x0030C9C9 File Offset: 0x0030ABC9
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06015089 RID: 86153 RVA: 0x0030C9E7 File Offset: 0x0030ABE7
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601508A RID: 86154 RVA: 0x0030CA00 File Offset: 0x0030AC00
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0601508B RID: 86155 RVA: 0x0030CA0B File Offset: 0x0030AC0B
		public static void AddBuffDebugNames(FlatBufferBuilder builder, VectorOffset buffDebugNamesOffset)
		{
			builder.AddOffset(5, buffDebugNamesOffset.Value, 0);
		}

		// Token: 0x0601508C RID: 86156 RVA: 0x0030CA1C File Offset: 0x0030AC1C
		public static VectorOffset CreateBuffDebugNamesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601508D RID: 86157 RVA: 0x0030CA5C File Offset: 0x0030AC5C
		public static VectorOffset CreateBuffDebugNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601508E RID: 86158 RVA: 0x0030CA76 File Offset: 0x0030AC76
		public static VectorOffset CreateBuffDebugNamesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601508F RID: 86159 RVA: 0x0030CA94 File Offset: 0x0030AC94
		public static VectorOffset CreateBuffDebugNamesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015090 RID: 86160 RVA: 0x0030CAAD File Offset: 0x0030ACAD
		public static void StartBuffDebugNamesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015091 RID: 86161 RVA: 0x0030CAB8 File Offset: 0x0030ACB8
		public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset)
		{
			builder.AddOffset(6, tagsOffset.Value, 0);
		}

		// Token: 0x06015092 RID: 86162 RVA: 0x0030CAC8 File Offset: 0x0030ACC8
		public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015093 RID: 86163 RVA: 0x0030CB08 File Offset: 0x0030AD08
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015094 RID: 86164 RVA: 0x0030CB22 File Offset: 0x0030AD22
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06015095 RID: 86165 RVA: 0x0030CB40 File Offset: 0x0030AD40
		public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015096 RID: 86166 RVA: 0x0030CB59 File Offset: 0x0030AD59
		public static void StartTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015097 RID: 86167 RVA: 0x0030CB64 File Offset: 0x0030AD64
		public static Offset<IShowTimelineRoleState> EndIShowTimelineRoleState(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineRoleState>(builder.EndTable());
		}

		// Token: 0x06015098 RID: 86168 RVA: 0x0030CB74 File Offset: 0x0030AD74
		public IShowTimelineRoleStateT UnPack()
		{
			IShowTimelineRoleStateT showTimelineRoleStateT = new IShowTimelineRoleStateT();
			this.UnPackTo(showTimelineRoleStateT);
			return showTimelineRoleStateT;
		}

		// Token: 0x06015099 RID: 86169 RVA: 0x0030CB90 File Offset: 0x0030AD90
		public void UnPackTo(IShowTimelineRoleStateT _o)
		{
			_o.RoleId = this.RoleId;
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
			_o.BuffDebugNames = new List<string>();
			for (int l = 0; l < this.BuffDebugNamesLength; l++)
			{
				_o.BuffDebugNames.Add(this.BuffDebugNames(l));
			}
			_o.Tags = new List<string>();
			for (int m = 0; m < this.TagsLength; m++)
			{
				_o.Tags.Add(this.Tags(m));
			}
		}

		// Token: 0x0601509A RID: 86170 RVA: 0x0030CCD0 File Offset: 0x0030AED0
		public static Offset<IShowTimelineRoleState> Pack(FlatBufferBuilder builder, IShowTimelineRoleStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineRoleState>);
			}
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			VectorOffset attributesOffset = default(VectorOffset);
			if (_o.Attributes != null)
			{
				int[] data = _o.Attributes.ToArray();
				attributesOffset = IShowTimelineRoleState.CreateAttributesVector(builder, data);
			}
			VectorOffset buffsOffset = default(VectorOffset);
			if (_o.Buffs != null)
			{
				int[] data2 = _o.Buffs.ToArray();
				buffsOffset = IShowTimelineRoleState.CreateBuffsVector(builder, data2);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data3 = _o.BuffIds.ToArray();
				buffIdsOffset = IShowTimelineRoleState.CreateBuffIdsVector(builder, data3);
			}
			VectorOffset buffDebugNamesOffset = default(VectorOffset);
			if (_o.BuffDebugNames != null)
			{
				StringOffset[] array = new StringOffset[_o.BuffDebugNames.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.BuffDebugNames[i]);
				}
				buffDebugNamesOffset = IShowTimelineRoleState.CreateBuffDebugNamesVector(builder, array);
			}
			VectorOffset tagsOffset = default(VectorOffset);
			if (_o.Tags != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Tags.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Tags[j]);
				}
				tagsOffset = IShowTimelineRoleState.CreateTagsVector(builder, array2);
			}
			return IShowTimelineRoleState.CreateIShowTimelineRoleState(builder, _o.RoleId, transformOffset, attributesOffset, buffsOffset, buffIdsOffset, buffDebugNamesOffset, tagsOffset);
		}

		// Token: 0x0400B154 RID: 45396
		private Table __p;
	}
}
