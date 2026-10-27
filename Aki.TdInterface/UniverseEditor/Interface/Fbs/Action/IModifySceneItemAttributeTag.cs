using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACA RID: 27338
	public struct IModifySceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x1700CACE RID: 51918
		// (get) Token: 0x0602FE7E RID: 196222 RVA: 0x006841BA File Offset: 0x006823BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE7F RID: 196223 RVA: 0x006841C7 File Offset: 0x006823C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE80 RID: 196224 RVA: 0x006841D0 File Offset: 0x006823D0
		public static IModifySceneItemAttributeTag GetRootAsIModifySceneItemAttributeTag(ByteBuffer _bb)
		{
			return IModifySceneItemAttributeTag.GetRootAsIModifySceneItemAttributeTag(_bb, default(IModifySceneItemAttributeTag));
		}

		// Token: 0x0602FE81 RID: 196225 RVA: 0x006841EC File Offset: 0x006823EC
		public static IModifySceneItemAttributeTag GetRootAsIModifySceneItemAttributeTag(ByteBuffer _bb, IModifySceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE82 RID: 196226 RVA: 0x00684209 File Offset: 0x00682409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE83 RID: 196227 RVA: 0x00684218 File Offset: 0x00682418
		public IModifySceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CACF RID: 51919
		// (get) Token: 0x0602FE84 RID: 196228 RVA: 0x00684228 File Offset: 0x00682428
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

		// Token: 0x1700CAD0 RID: 51920
		// (get) Token: 0x0602FE85 RID: 196229 RVA: 0x00684264 File Offset: 0x00682464
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FE86 RID: 196230 RVA: 0x006842A4 File Offset: 0x006824A4
		public int PerformanceTag(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CAD1 RID: 51921
		// (get) Token: 0x0602FE87 RID: 196231 RVA: 0x006842E4 File Offset: 0x006824E4
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

		// Token: 0x0602FE88 RID: 196232 RVA: 0x0068430F File Offset: 0x0068250F
		public Span<int> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602FE89 RID: 196233 RVA: 0x0068431E File Offset: 0x0068251E
		public int[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602FE8A RID: 196234 RVA: 0x0068432C File Offset: 0x0068252C
		public static Offset<IModifySceneItemAttributeTag> CreateIModifySceneItemAttributeTag(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, bool IsAddTag = false, VectorOffset PerformanceTagOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IModifySceneItemAttributeTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IModifySceneItemAttributeTag.AddIsAddTag(builder, IsAddTag);
			IModifySceneItemAttributeTag.AddType(builder, Type);
			return IModifySceneItemAttributeTag.EndIModifySceneItemAttributeTag(builder);
		}

		// Token: 0x0602FE8B RID: 196235 RVA: 0x00684350 File Offset: 0x00682550
		public static void StartIModifySceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FE8C RID: 196236 RVA: 0x00684359 File Offset: 0x00682559
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE8D RID: 196237 RVA: 0x00684364 File Offset: 0x00682564
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(1, isAddTag, false);
		}

		// Token: 0x0602FE8E RID: 196238 RVA: 0x0068436F File Offset: 0x0068256F
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602FE8F RID: 196239 RVA: 0x00684380 File Offset: 0x00682580
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FE90 RID: 196240 RVA: 0x006843B7 File Offset: 0x006825B7
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FE91 RID: 196241 RVA: 0x006843D1 File Offset: 0x006825D1
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FE92 RID: 196242 RVA: 0x006843EF File Offset: 0x006825EF
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FE93 RID: 196243 RVA: 0x00684408 File Offset: 0x00682608
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FE94 RID: 196244 RVA: 0x00684413 File Offset: 0x00682613
		public static Offset<IModifySceneItemAttributeTag> EndIModifySceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<IModifySceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x0602FE95 RID: 196245 RVA: 0x00684420 File Offset: 0x00682620
		public IModifySceneItemAttributeTagT UnPack()
		{
			IModifySceneItemAttributeTagT modifySceneItemAttributeTagT = new IModifySceneItemAttributeTagT();
			this.UnPackTo(modifySceneItemAttributeTagT);
			return modifySceneItemAttributeTagT;
		}

		// Token: 0x0602FE96 RID: 196246 RVA: 0x0068443C File Offset: 0x0068263C
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

		// Token: 0x0602FE97 RID: 196247 RVA: 0x00684490 File Offset: 0x00682690
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

		// Token: 0x04011310 RID: 70416
		private Table __p;
	}
}
