using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007207 RID: 29191
	public struct IModifySelfSceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x1700D5A2 RID: 54690
		// (get) Token: 0x06032C7A RID: 207994 RVA: 0x006DBC55 File Offset: 0x006D9E55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032C7B RID: 207995 RVA: 0x006DBC62 File Offset: 0x006D9E62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032C7C RID: 207996 RVA: 0x006DBC6C File Offset: 0x006D9E6C
		public static IModifySelfSceneItemAttributeTag GetRootAsIModifySelfSceneItemAttributeTag(ByteBuffer _bb)
		{
			return IModifySelfSceneItemAttributeTag.GetRootAsIModifySelfSceneItemAttributeTag(_bb, default(IModifySelfSceneItemAttributeTag));
		}

		// Token: 0x06032C7D RID: 207997 RVA: 0x006DBC88 File Offset: 0x006D9E88
		public static IModifySelfSceneItemAttributeTag GetRootAsIModifySelfSceneItemAttributeTag(ByteBuffer _bb, IModifySelfSceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032C7E RID: 207998 RVA: 0x006DBCA5 File Offset: 0x006D9EA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032C7F RID: 207999 RVA: 0x006DBCB4 File Offset: 0x006D9EB4
		public IModifySelfSceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5A3 RID: 54691
		// (get) Token: 0x06032C80 RID: 208000 RVA: 0x006DBCC4 File Offset: 0x006D9EC4
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

		// Token: 0x1700D5A4 RID: 54692
		// (get) Token: 0x06032C81 RID: 208001 RVA: 0x006DBD00 File Offset: 0x006D9F00
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032C82 RID: 208002 RVA: 0x006DBD40 File Offset: 0x006D9F40
		public int PerformanceTag(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D5A5 RID: 54693
		// (get) Token: 0x06032C83 RID: 208003 RVA: 0x006DBD80 File Offset: 0x006D9F80
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

		// Token: 0x06032C84 RID: 208004 RVA: 0x006DBDAB File Offset: 0x006D9FAB
		public Span<int> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06032C85 RID: 208005 RVA: 0x006DBDBA File Offset: 0x006D9FBA
		public int[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06032C86 RID: 208006 RVA: 0x006DBDC8 File Offset: 0x006D9FC8
		public static Offset<IModifySelfSceneItemAttributeTag> CreateIModifySelfSceneItemAttributeTag(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, bool IsAddTag = false, VectorOffset PerformanceTagOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IModifySelfSceneItemAttributeTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IModifySelfSceneItemAttributeTag.AddIsAddTag(builder, IsAddTag);
			IModifySelfSceneItemAttributeTag.AddType(builder, Type);
			return IModifySelfSceneItemAttributeTag.EndIModifySelfSceneItemAttributeTag(builder);
		}

		// Token: 0x06032C87 RID: 208007 RVA: 0x006DBDEC File Offset: 0x006D9FEC
		public static void StartIModifySelfSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032C88 RID: 208008 RVA: 0x006DBDF5 File Offset: 0x006D9FF5
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032C89 RID: 208009 RVA: 0x006DBE00 File Offset: 0x006DA000
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(1, isAddTag, false);
		}

		// Token: 0x06032C8A RID: 208010 RVA: 0x006DBE0B File Offset: 0x006DA00B
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x06032C8B RID: 208011 RVA: 0x006DBE1C File Offset: 0x006DA01C
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06032C8C RID: 208012 RVA: 0x006DBE53 File Offset: 0x006DA053
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C8D RID: 208013 RVA: 0x006DBE6D File Offset: 0x006DA06D
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06032C8E RID: 208014 RVA: 0x006DBE8B File Offset: 0x006DA08B
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032C8F RID: 208015 RVA: 0x006DBEA4 File Offset: 0x006DA0A4
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032C90 RID: 208016 RVA: 0x006DBEAF File Offset: 0x006DA0AF
		public static Offset<IModifySelfSceneItemAttributeTag> EndIModifySelfSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<IModifySelfSceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x06032C91 RID: 208017 RVA: 0x006DBEBC File Offset: 0x006DA0BC
		public IModifySelfSceneItemAttributeTagT UnPack()
		{
			IModifySelfSceneItemAttributeTagT modifySelfSceneItemAttributeTagT = new IModifySelfSceneItemAttributeTagT();
			this.UnPackTo(modifySelfSceneItemAttributeTagT);
			return modifySelfSceneItemAttributeTagT;
		}

		// Token: 0x06032C92 RID: 208018 RVA: 0x006DBED8 File Offset: 0x006DA0D8
		public void UnPackTo(IModifySelfSceneItemAttributeTagT _o)
		{
			_o.Type = this.Type;
			_o.IsAddTag = this.IsAddTag;
			_o.PerformanceTag = new List<int>();
			for (int i = 0; i < this.PerformanceTagLength; i++)
			{
				_o.PerformanceTag.Add(this.PerformanceTag(i));
			}
		}

		// Token: 0x06032C93 RID: 208019 RVA: 0x006DBF2C File Offset: 0x006DA12C
		public static Offset<IModifySelfSceneItemAttributeTag> Pack(FlatBufferBuilder builder, IModifySelfSceneItemAttributeTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifySelfSceneItemAttributeTag>);
			}
			VectorOffset performanceTagOffset = default(VectorOffset);
			if (_o.PerformanceTag != null)
			{
				int[] data = _o.PerformanceTag.ToArray();
				performanceTagOffset = IModifySelfSceneItemAttributeTag.CreatePerformanceTagVector(builder, data);
			}
			return IModifySelfSceneItemAttributeTag.CreateIModifySelfSceneItemAttributeTag(builder, _o.Type, _o.IsAddTag, performanceTagOffset);
		}

		// Token: 0x0401222C RID: 74284
		private Table __p;
	}
}
