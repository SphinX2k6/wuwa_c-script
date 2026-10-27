using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD3 RID: 27347
	public struct IModifyTargetSceneItemAttributeTag : IFlatbufferObject
	{
		// Token: 0x1700CADE RID: 51934
		// (get) Token: 0x0602FED0 RID: 196304 RVA: 0x00684A70 File Offset: 0x00682C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FED1 RID: 196305 RVA: 0x00684A7D File Offset: 0x00682C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FED2 RID: 196306 RVA: 0x00684A84 File Offset: 0x00682C84
		public static IModifyTargetSceneItemAttributeTag GetRootAsIModifyTargetSceneItemAttributeTag(ByteBuffer _bb)
		{
			return IModifyTargetSceneItemAttributeTag.GetRootAsIModifyTargetSceneItemAttributeTag(_bb, default(IModifyTargetSceneItemAttributeTag));
		}

		// Token: 0x0602FED3 RID: 196307 RVA: 0x00684AA0 File Offset: 0x00682CA0
		public static IModifyTargetSceneItemAttributeTag GetRootAsIModifyTargetSceneItemAttributeTag(ByteBuffer _bb, IModifyTargetSceneItemAttributeTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FED4 RID: 196308 RVA: 0x00684ABD File Offset: 0x00682CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FED5 RID: 196309 RVA: 0x00684ACC File Offset: 0x00682CCC
		public IModifyTargetSceneItemAttributeTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CADF RID: 51935
		// (get) Token: 0x0602FED6 RID: 196310 RVA: 0x00684ADC File Offset: 0x00682CDC
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

		// Token: 0x1700CAE0 RID: 51936
		// (get) Token: 0x0602FED7 RID: 196311 RVA: 0x00684B18 File Offset: 0x00682D18
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FED8 RID: 196312 RVA: 0x00684B58 File Offset: 0x00682D58
		public int PerformanceTag(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CAE1 RID: 51937
		// (get) Token: 0x0602FED9 RID: 196313 RVA: 0x00684B98 File Offset: 0x00682D98
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

		// Token: 0x0602FEDA RID: 196314 RVA: 0x00684BC3 File Offset: 0x00682DC3
		public Span<int> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602FEDB RID: 196315 RVA: 0x00684BD2 File Offset: 0x00682DD2
		public int[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0602FEDC RID: 196316 RVA: 0x00684BE0 File Offset: 0x00682DE0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CAE2 RID: 51938
		// (get) Token: 0x0602FEDD RID: 196317 RVA: 0x00684C20 File Offset: 0x00682E20
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

		// Token: 0x0602FEDE RID: 196318 RVA: 0x00684C4C File Offset: 0x00682E4C
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602FEDF RID: 196319 RVA: 0x00684C5C File Offset: 0x00682E5C
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0602FEE0 RID: 196320 RVA: 0x00684C6B File Offset: 0x00682E6B
		public static Offset<IModifyTargetSceneItemAttributeTag> CreateIModifyTargetSceneItemAttributeTag(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType Type = EChangeEntityPrefabPerformanceType.Target, bool IsAddTag = false, VectorOffset PerformanceTagOffset = default(VectorOffset), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IModifyTargetSceneItemAttributeTag.AddEntityIds(builder, EntityIdsOffset);
			IModifyTargetSceneItemAttributeTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IModifyTargetSceneItemAttributeTag.AddIsAddTag(builder, IsAddTag);
			IModifyTargetSceneItemAttributeTag.AddType(builder, Type);
			return IModifyTargetSceneItemAttributeTag.EndIModifyTargetSceneItemAttributeTag(builder);
		}

		// Token: 0x0602FEE1 RID: 196321 RVA: 0x00684C97 File Offset: 0x00682E97
		public static void StartIModifyTargetSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FEE2 RID: 196322 RVA: 0x00684CA0 File Offset: 0x00682EA0
		public static void AddType(FlatBufferBuilder builder, EChangeEntityPrefabPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FEE3 RID: 196323 RVA: 0x00684CAB File Offset: 0x00682EAB
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(1, isAddTag, false);
		}

		// Token: 0x0602FEE4 RID: 196324 RVA: 0x00684CB6 File Offset: 0x00682EB6
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602FEE5 RID: 196325 RVA: 0x00684CC8 File Offset: 0x00682EC8
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FEE6 RID: 196326 RVA: 0x00684CFF File Offset: 0x00682EFF
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FEE7 RID: 196327 RVA: 0x00684D19 File Offset: 0x00682F19
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FEE8 RID: 196328 RVA: 0x00684D37 File Offset: 0x00682F37
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FEE9 RID: 196329 RVA: 0x00684D50 File Offset: 0x00682F50
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FEEA RID: 196330 RVA: 0x00684D5B File Offset: 0x00682F5B
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602FEEB RID: 196331 RVA: 0x00684D6C File Offset: 0x00682F6C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FEEC RID: 196332 RVA: 0x00684DA3 File Offset: 0x00682FA3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FEED RID: 196333 RVA: 0x00684DBD File Offset: 0x00682FBD
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FEEE RID: 196334 RVA: 0x00684DDB File Offset: 0x00682FDB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FEEF RID: 196335 RVA: 0x00684DF4 File Offset: 0x00682FF4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FEF0 RID: 196336 RVA: 0x00684DFF File Offset: 0x00682FFF
		public static Offset<IModifyTargetSceneItemAttributeTag> EndIModifyTargetSceneItemAttributeTag(FlatBufferBuilder builder)
		{
			return new Offset<IModifyTargetSceneItemAttributeTag>(builder.EndTable());
		}

		// Token: 0x0602FEF1 RID: 196337 RVA: 0x00684E0C File Offset: 0x0068300C
		public IModifyTargetSceneItemAttributeTagT UnPack()
		{
			IModifyTargetSceneItemAttributeTagT modifyTargetSceneItemAttributeTagT = new IModifyTargetSceneItemAttributeTagT();
			this.UnPackTo(modifyTargetSceneItemAttributeTagT);
			return modifyTargetSceneItemAttributeTagT;
		}

		// Token: 0x0602FEF2 RID: 196338 RVA: 0x00684E28 File Offset: 0x00683028
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

		// Token: 0x0602FEF3 RID: 196339 RVA: 0x00684EAC File Offset: 0x006830AC
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

		// Token: 0x0401131F RID: 70431
		private Table __p;
	}
}
