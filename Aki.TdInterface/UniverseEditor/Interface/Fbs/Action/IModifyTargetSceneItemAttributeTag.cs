using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720A RID: 29194
	public struct IModifyTargetSceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x1700D5A9 RID: 54697
		// (get) Token: 0x06032C9C RID: 208028 RVA: 0x006DC00C File Offset: 0x006DA20C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C9D RID: 208029 RVA: 0x006DC019 File Offset: 0x006DA219
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C9E RID: 208030 RVA: 0x006DC020 File Offset: 0x006DA220
		public static IModifyTargetSceneItemAttributeTag GetRootAsIModifyTargetSceneItemAttributeTag(ByteBuffer _bb)
		{
			return IModifyTargetSceneItemAttributeTag.GetRootAsIModifyTargetSceneItemAttributeTag(_bb, default(IModifyTargetSceneItemAttributeTag));
		}

		// Token: 0x06032C9F RID: 208031 RVA: 0x006DC03C File Offset: 0x006DA23C
		public static IModifyTargetSceneItemAttributeTag GetRootAsIModifyTargetSceneItemAttributeTag(ByteBuffer _bb, IModifyTargetSceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032CA0 RID: 208032 RVA: 0x006DC059 File Offset: 0x006DA259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032CA1 RID: 208033 RVA: 0x006DC068 File Offset: 0x006DA268
		public IModifyTargetSceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5AA RID: 54698
		// (get) Token: 0x06032CA2 RID: 208034 RVA: 0x006DC078 File Offset: 0x006DA278
		public EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return (EChangeEntityPrefabPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D5AB RID: 54699
		// (get) Token: 0x06032CA3 RID: 208035 RVA: 0x006DC0B4 File Offset: 0x006DA2B4
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032CA4 RID: 208036 RVA: 0x006DC0F4 File Offset: 0x006DA2F4
		public int PerformanceTag(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D5AC RID: 54700
		// (get) Token: 0x06032CA5 RID: 208037 RVA: 0x006DC134 File Offset: 0x006DA334
		public int PerformanceTagLength
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

		// Token: 0x06032CA6 RID: 208038 RVA: 0x006DC15F File Offset: 0x006DA35F
		public Span<int> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06032CA7 RID: 208039 RVA: 0x006DC16E File Offset: 0x006DA36E
		public int[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06032CA8 RID: 208040 RVA: 0x006DC17C File Offset: 0x006DA37C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D5AD RID: 54701
		// (get) Token: 0x06032CA9 RID: 208041 RVA: 0x006DC1BC File Offset: 0x006DA3BC
		public int EntityIdsLength
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

		// Token: 0x06032CAA RID: 208042 RVA: 0x006DC1E8 File Offset: 0x006DA3E8
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06032CAB RID: 208043 RVA: 0x006DC1F8 File Offset: 0x006DA3F8
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06032CAC RID: 208044 RVA: 0x006DC207 File Offset: 0x006DA407
		public static Offset<IModifyTargetSceneItemAttributeTag> CreateIModifyTargetSceneItemAttributeTag(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, bool IsAddTag = false, VectorOffset PerformanceTagOffset = default(VectorOffset), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IModifyTargetSceneItemAttributeTag.AddEntityIds(builder, EntityIdsOffset);
			IModifyTargetSceneItemAttributeTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IModifyTargetSceneItemAttributeTag.AddIsAddTag(builder, IsAddTag);
			IModifyTargetSceneItemAttributeTag.AddType(builder, Type);
			return IModifyTargetSceneItemAttributeTag.EndIModifyTargetSceneItemAttributeTag(builder);
		}

		// Token: 0x06032CAD RID: 208045 RVA: 0x006DC233 File Offset: 0x006DA433
		public static void StartIModifyTargetSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032CAE RID: 208046 RVA: 0x006DC23C File Offset: 0x006DA43C
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032CAF RID: 208047 RVA: 0x006DC247 File Offset: 0x006DA447
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(1, isAddTag, false);
		}

		// Token: 0x06032CB0 RID: 208048 RVA: 0x006DC252 File Offset: 0x006DA452
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x06032CB1 RID: 208049 RVA: 0x006DC264 File Offset: 0x006DA464
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032CB2 RID: 208050 RVA: 0x006DC29B File Offset: 0x006DA49B
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032CB3 RID: 208051 RVA: 0x006DC2B5 File Offset: 0x006DA4B5
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032CB4 RID: 208052 RVA: 0x006DC2D3 File Offset: 0x006DA4D3
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032CB5 RID: 208053 RVA: 0x006DC2EC File Offset: 0x006DA4EC
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032CB6 RID: 208054 RVA: 0x006DC2F7 File Offset: 0x006DA4F7
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x06032CB7 RID: 208055 RVA: 0x006DC308 File Offset: 0x006DA508
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032CB8 RID: 208056 RVA: 0x006DC33F File Offset: 0x006DA53F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032CB9 RID: 208057 RVA: 0x006DC359 File Offset: 0x006DA559
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032CBA RID: 208058 RVA: 0x006DC377 File Offset: 0x006DA577
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032CBB RID: 208059 RVA: 0x006DC390 File Offset: 0x006DA590
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032CBC RID: 208060 RVA: 0x006DC39B File Offset: 0x006DA59B
		public static Offset<IModifyTargetSceneItemAttributeTag> EndIModifyTargetSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<IModifyTargetSceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x06032CBD RID: 208061 RVA: 0x006DC3A8 File Offset: 0x006DA5A8
		public IModifyTargetSceneItemAttributeTagT UnPack()
		{
			IModifyTargetSceneItemAttributeTagT modifyTargetSceneItemAttributeTagT = new IModifyTargetSceneItemAttributeTagT();
			this.UnPackTo(modifyTargetSceneItemAttributeTagT);
			return modifyTargetSceneItemAttributeTagT;
		}

		// Token: 0x06032CBE RID: 208062 RVA: 0x006DC3C4 File Offset: 0x006DA5C4
		public void UnPackTo(IModifyTargetSceneItemAttributeTagT _o)
		{
			_o.Type = this.Type;
			_o.IsAddTag = this.IsAddTag;
			_o.PerformanceTag = new List<int>();
			for (int i = 0; i < this.PerformanceTagLength; i++)
			{
				_o.PerformanceTag.Add(this.PerformanceTag(i));
			}
			_o.EntityIds = new List<int>();
			for (int j = 0; j < this.EntityIdsLength; j++)
			{
				_o.EntityIds.Add(this.EntityIds(j));
			}
		}

		// Token: 0x06032CBF RID: 208063 RVA: 0x006DC448 File Offset: 0x006DA648
		public static Offset<IModifyTargetSceneItemAttributeTag> Pack(FlatBufferBuilder builder, IModifyTargetSceneItemAttributeTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyTargetSceneItemAttributeTag>);
			}
			VectorOffset performanceTagOffset = default(VectorOffset);
			if (_o.PerformanceTag != null)
			{
				int[] data = _o.PerformanceTag.ToArray();
				performanceTagOffset = IModifyTargetSceneItemAttributeTag.CreatePerformanceTagVector(builder, data);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data2 = _o.EntityIds.ToArray();
				entityIdsOffset = IModifyTargetSceneItemAttributeTag.CreateEntityIdsVector(builder, data2);
			}
			return IModifyTargetSceneItemAttributeTag.CreateIModifyTargetSceneItemAttributeTag(builder, _o.Type, _o.IsAddTag, performanceTagOffset, entityIdsOffset);
		}

		// Token: 0x04012230 RID: 74288
		private Table __p;
	}
}
