using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FE RID: 29182
	public struct IModifySceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x1700D596 RID: 54678
		// (get) Token: 0x06032C34 RID: 207924 RVA: 0x006DB45E File Offset: 0x006D965E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C35 RID: 207925 RVA: 0x006DB46B File Offset: 0x006D966B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C36 RID: 207926 RVA: 0x006DB474 File Offset: 0x006D9674
		public static IModifySceneItemAttributeTag GetRootAsIModifySceneItemAttributeTag(ByteBuffer _bb)
		{
			return IModifySceneItemAttributeTag.GetRootAsIModifySceneItemAttributeTag(_bb, default(IModifySceneItemAttributeTag));
		}

		// Token: 0x06032C37 RID: 207927 RVA: 0x006DB490 File Offset: 0x006D9690
		public static IModifySceneItemAttributeTag GetRootAsIModifySceneItemAttributeTag(ByteBuffer _bb, IModifySceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C38 RID: 207928 RVA: 0x006DB4AD File Offset: 0x006D96AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C39 RID: 207929 RVA: 0x006DB4BC File Offset: 0x006D96BC
		public IModifySceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D597 RID: 54679
		// (get) Token: 0x06032C3A RID: 207930 RVA: 0x006DB4CC File Offset: 0x006D96CC
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

		// Token: 0x1700D598 RID: 54680
		// (get) Token: 0x06032C3B RID: 207931 RVA: 0x006DB508 File Offset: 0x006D9708
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032C3C RID: 207932 RVA: 0x006DB548 File Offset: 0x006D9748
		public int PerformanceTag(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D599 RID: 54681
		// (get) Token: 0x06032C3D RID: 207933 RVA: 0x006DB588 File Offset: 0x006D9788
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

		// Token: 0x06032C3E RID: 207934 RVA: 0x006DB5B3 File Offset: 0x006D97B3
		public Span<int> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06032C3F RID: 207935 RVA: 0x006DB5C2 File Offset: 0x006D97C2
		public int[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06032C40 RID: 207936 RVA: 0x006DB5D0 File Offset: 0x006D97D0
		public static Offset<IModifySceneItemAttributeTag> CreateIModifySceneItemAttributeTag(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, bool IsAddTag = false, VectorOffset PerformanceTagOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IModifySceneItemAttributeTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IModifySceneItemAttributeTag.AddIsAddTag(builder, IsAddTag);
			IModifySceneItemAttributeTag.AddType(builder, Type);
			return IModifySceneItemAttributeTag.EndIModifySceneItemAttributeTag(builder);
		}

		// Token: 0x06032C41 RID: 207937 RVA: 0x006DB5F4 File Offset: 0x006D97F4
		public static void StartIModifySceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032C42 RID: 207938 RVA: 0x006DB5FD File Offset: 0x006D97FD
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032C43 RID: 207939 RVA: 0x006DB608 File Offset: 0x006D9808
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(1, isAddTag, false);
		}

		// Token: 0x06032C44 RID: 207940 RVA: 0x006DB613 File Offset: 0x006D9813
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x06032C45 RID: 207941 RVA: 0x006DB624 File Offset: 0x006D9824
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032C46 RID: 207942 RVA: 0x006DB65B File Offset: 0x006D985B
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C47 RID: 207943 RVA: 0x006DB675 File Offset: 0x006D9875
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C48 RID: 207944 RVA: 0x006DB693 File Offset: 0x006D9893
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032C49 RID: 207945 RVA: 0x006DB6AC File Offset: 0x006D98AC
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032C4A RID: 207946 RVA: 0x006DB6B7 File Offset: 0x006D98B7
		public static Offset<IModifySceneItemAttributeTag> EndIModifySceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<IModifySceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x06032C4B RID: 207947 RVA: 0x006DB6C4 File Offset: 0x006D98C4
		public IModifySceneItemAttributeTagT UnPack()
		{
			IModifySceneItemAttributeTagT modifySceneItemAttributeTagT = new IModifySceneItemAttributeTagT();
			this.UnPackTo(modifySceneItemAttributeTagT);
			return modifySceneItemAttributeTagT;
		}

		// Token: 0x06032C4C RID: 207948 RVA: 0x006DB6E0 File Offset: 0x006D98E0
		public void UnPackTo(IModifySceneItemAttributeTagT _o)
		{
			_o.Type = this.Type;
			_o.IsAddTag = this.IsAddTag;
			_o.PerformanceTag = new List<int>();
			for (int i = 0; i < this.PerformanceTagLength; i++)
			{
				_o.PerformanceTag.Add(this.PerformanceTag(i));
			}
		}

		// Token: 0x06032C4D RID: 207949 RVA: 0x006DB734 File Offset: 0x006D9934
		public static Offset<IModifySceneItemAttributeTag> Pack(FlatBufferBuilder builder, IModifySceneItemAttributeTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifySceneItemAttributeTag>);
			}
			VectorOffset performanceTagOffset = default(VectorOffset);
			if (_o.PerformanceTag != null)
			{
				int[] data = _o.PerformanceTag.ToArray();
				performanceTagOffset = IModifySceneItemAttributeTag.CreatePerformanceTagVector(builder, data);
			}
			return IModifySceneItemAttributeTag.CreateIModifySceneItemAttributeTag(builder, _o.Type, _o.IsAddTag, performanceTagOffset);
		}

		// Token: 0x0401221F RID: 74271
		private Table __p;
	}
}
