using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD0 RID: 27344
	public struct IModifySelfSceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x1700CAD7 RID: 51927
		// (get) Token: 0x0602FEAE RID: 196270 RVA: 0x006846BC File Offset: 0x006828BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FEAF RID: 196271 RVA: 0x006846C9 File Offset: 0x006828C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FEB0 RID: 196272 RVA: 0x006846D0 File Offset: 0x006828D0
		public static IModifySelfSceneItemAttributeTag GetRootAsIModifySelfSceneItemAttributeTag(ByteBuffer _bb)
		{
			return IModifySelfSceneItemAttributeTag.GetRootAsIModifySelfSceneItemAttributeTag(_bb, default(IModifySelfSceneItemAttributeTag));
		}

		// Token: 0x0602FEB1 RID: 196273 RVA: 0x006846EC File Offset: 0x006828EC
		public static IModifySelfSceneItemAttributeTag GetRootAsIModifySelfSceneItemAttributeTag(ByteBuffer _bb, IModifySelfSceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FEB2 RID: 196274 RVA: 0x00684709 File Offset: 0x00682909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FEB3 RID: 196275 RVA: 0x00684718 File Offset: 0x00682918
		public IModifySelfSceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAD8 RID: 51928
		// (get) Token: 0x0602FEB4 RID: 196276 RVA: 0x00684728 File Offset: 0x00682928
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

		// Token: 0x1700CAD9 RID: 51929
		// (get) Token: 0x0602FEB5 RID: 196277 RVA: 0x00684764 File Offset: 0x00682964
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FEB6 RID: 196278 RVA: 0x006847A4 File Offset: 0x006829A4
		public int PerformanceTag(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CADA RID: 51930
		// (get) Token: 0x0602FEB7 RID: 196279 RVA: 0x006847E4 File Offset: 0x006829E4
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

		// Token: 0x0602FEB8 RID: 196280 RVA: 0x0068480F File Offset: 0x00682A0F
		public Span<int> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602FEB9 RID: 196281 RVA: 0x0068481E File Offset: 0x00682A1E
		public int[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602FEBA RID: 196282 RVA: 0x0068482C File Offset: 0x00682A2C
		public static Offset<IModifySelfSceneItemAttributeTag> CreateIModifySelfSceneItemAttributeTag(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, bool IsAddTag = false, VectorOffset PerformanceTagOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IModifySelfSceneItemAttributeTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IModifySelfSceneItemAttributeTag.AddIsAddTag(builder, IsAddTag);
			IModifySelfSceneItemAttributeTag.AddType(builder, Type);
			return IModifySelfSceneItemAttributeTag.EndIModifySelfSceneItemAttributeTag(builder);
		}

		// Token: 0x0602FEBB RID: 196283 RVA: 0x00684850 File Offset: 0x00682A50
		public static void StartIModifySelfSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FEBC RID: 196284 RVA: 0x00684859 File Offset: 0x00682A59
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FEBD RID: 196285 RVA: 0x00684864 File Offset: 0x00682A64
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(1, isAddTag, false);
		}

		// Token: 0x0602FEBE RID: 196286 RVA: 0x0068486F File Offset: 0x00682A6F
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602FEBF RID: 196287 RVA: 0x00684880 File Offset: 0x00682A80
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FEC0 RID: 196288 RVA: 0x006848B7 File Offset: 0x00682AB7
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FEC1 RID: 196289 RVA: 0x006848D1 File Offset: 0x00682AD1
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FEC2 RID: 196290 RVA: 0x006848EF File Offset: 0x00682AEF
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FEC3 RID: 196291 RVA: 0x00684908 File Offset: 0x00682B08
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FEC4 RID: 196292 RVA: 0x00684913 File Offset: 0x00682B13
		public static Offset<IModifySelfSceneItemAttributeTag> EndIModifySelfSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<IModifySelfSceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x0602FEC5 RID: 196293 RVA: 0x00684920 File Offset: 0x00682B20
		public IModifySelfSceneItemAttributeTagT UnPack()
		{
			IModifySelfSceneItemAttributeTagT modifySelfSceneItemAttributeTagT = new IModifySelfSceneItemAttributeTagT();
			this.UnPackTo(modifySelfSceneItemAttributeTagT);
			return modifySelfSceneItemAttributeTagT;
		}

		// Token: 0x0602FEC6 RID: 196294 RVA: 0x0068493C File Offset: 0x00682B3C
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

		// Token: 0x0602FEC7 RID: 196295 RVA: 0x00684990 File Offset: 0x00682B90
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

		// Token: 0x0401131B RID: 70427
		private Table __p;
	}
}
