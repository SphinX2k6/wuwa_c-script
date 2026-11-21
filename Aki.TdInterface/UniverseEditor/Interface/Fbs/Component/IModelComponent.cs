using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEC RID: 23276
	public struct IModelComponent : IFlatbufferObject
	{
		// Token: 0x1700A9CF RID: 43471
		// (get) Token: 0x060263A0 RID: 156576 RVA: 0x0053CEE9 File Offset: 0x0053B0E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060263A1 RID: 156577 RVA: 0x0053CEF6 File Offset: 0x0053B0F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060263A2 RID: 156578 RVA: 0x0053CF00 File Offset: 0x0053B100
		public static IModelComponent GetRootAsIModelComponent(ByteBuffer _bb)
		{
			return IModelComponent.GetRootAsIModelComponent(_bb, default(IModelComponent));
		}

		// Token: 0x060263A3 RID: 156579 RVA: 0x0053CF1C File Offset: 0x0053B11C
		public static IModelComponent GetRootAsIModelComponent(ByteBuffer _bb, IModelComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060263A4 RID: 156580 RVA: 0x0053CF39 File Offset: 0x0053B139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060263A5 RID: 156581 RVA: 0x0053CF48 File Offset: 0x0053B148
		public IModelComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9D0 RID: 43472
		// (get) Token: 0x060263A6 RID: 156582 RVA: 0x0053CF58 File Offset: 0x0053B158
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A9D1 RID: 43473
		// (get) Token: 0x060263A7 RID: 156583 RVA: 0x0053CF98 File Offset: 0x0053B198
		public TModelType ModelTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TModelType.NONE;
				}
				return (TModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263A8 RID: 156584 RVA: 0x0053CFD4 File Offset: 0x0053B1D4
		public TTable? ModelType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060263A9 RID: 156585 RVA: 0x0053D018 File Offset: 0x0053B218
		public IAnimalModel ModelTypeAsIAnimalModel()
		{
			return this.ModelType<IAnimalModel>().Value;
		}

		// Token: 0x060263AA RID: 156586 RVA: 0x0053D034 File Offset: 0x0053B234
		public ILevelPrefab ModelTypeAsILevelPrefab()
		{
			return this.ModelType<ILevelPrefab>().Value;
		}

		// Token: 0x060263AB RID: 156587 RVA: 0x0053D050 File Offset: 0x0053B250
		public IModelId ModelTypeAsIModelId()
		{
			return this.ModelType<IModelId>().Value;
		}

		// Token: 0x060263AC RID: 156588 RVA: 0x0053D06C File Offset: 0x0053B26C
		public INpcModel ModelTypeAsINpcModel()
		{
			return this.ModelType<INpcModel>().Value;
		}

		// Token: 0x1700A9D2 RID: 43474
		// (get) Token: 0x060263AD RID: 156589 RVA: 0x0053D088 File Offset: 0x0053B288
		public int HalfHeight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A9D3 RID: 43475
		// (get) Token: 0x060263AE RID: 156590 RVA: 0x0053D0C8 File Offset: 0x0053B2C8
		public int TrackHeight
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263AF RID: 156591 RVA: 0x0053D108 File Offset: 0x0053B308
		public int PerformanceTags(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A9D4 RID: 43476
		// (get) Token: 0x060263B0 RID: 156592 RVA: 0x0053D148 File Offset: 0x0053B348
		public int PerformanceTagsLength
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

		// Token: 0x060263B1 RID: 156593 RVA: 0x0053D174 File Offset: 0x0053B374
		public Span<int> GetPerformanceTagsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060263B2 RID: 156594 RVA: 0x0053D184 File Offset: 0x0053B384
		public int[] GetPerformanceTagsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700A9D5 RID: 43477
		// (get) Token: 0x060263B3 RID: 156595 RVA: 0x0053D194 File Offset: 0x0053B394
		public bool AoiFadeOut
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A9D6 RID: 43478
		// (get) Token: 0x060263B4 RID: 156596 RVA: 0x0053D1D4 File Offset: 0x0053B3D4
		public string PerformanceFaceSkeletalMeshPath
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263B5 RID: 156597 RVA: 0x0053D20C File Offset: 0x0053B40C
		public Span<byte> GetPerformanceFaceSkeletalMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060263B6 RID: 156598 RVA: 0x0053D21C File Offset: 0x0053B41C
		public byte[] GetPerformanceFaceSkeletalMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A9D7 RID: 43479
		// (get) Token: 0x060263B7 RID: 156599 RVA: 0x0053D22C File Offset: 0x0053B42C
		public bool IsUseSeqFace
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A9D8 RID: 43480
		// (get) Token: 0x060263B8 RID: 156600 RVA: 0x0053D26C File Offset: 0x0053B46C
		public EAbpAnimScheme AbpAnimScheme
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return EAbpAnimScheme.Default;
				}
				return (EAbpAnimScheme)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A9D9 RID: 43481
		// (get) Token: 0x060263B9 RID: 156601 RVA: 0x0053D2AC File Offset: 0x0053B4AC
		public ICollisionChannelConfig? CollisionChannelConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new ICollisionChannelConfig?(default(ICollisionChannelConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060263BA RID: 156602 RVA: 0x0053D30C File Offset: 0x0053B50C
		public string DefaultDecorationIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A9DA RID: 43482
		// (get) Token: 0x060263BB RID: 156603 RVA: 0x0053D348 File Offset: 0x0053B548
		public int DefaultDecorationIdsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A9DB RID: 43483
		// (get) Token: 0x060263BC RID: 156604 RVA: 0x0053D374 File Offset: 0x0053B574
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263BD RID: 156605 RVA: 0x0053D3B4 File Offset: 0x0053B5B4
		public static Offset<IModelComponent> CreateIModelComponent(FlatBufferBuilder builder, bool Disabled = false, TModelType ModelType_type = TModelType.NONE, int ModelTypeOffset = 0, int HalfHeight = 0, int TrackHeight = 0, VectorOffset PerformanceTagsOffset = default(VectorOffset), bool AoiFadeOut = false, StringOffset PerformanceFaceSkeletalMeshPathOffset = default(StringOffset), bool IsUseSeqFace = false, EAbpAnimScheme AbpAnimScheme = EAbpAnimScheme.Default, Offset<ICollisionChannelConfig> CollisionChannelConfigOffset = default(Offset<ICollisionChannelConfig>), VectorOffset DefaultDecorationIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(13);
			IModelComponent.AddDefaultDecorationIds(builder, DefaultDecorationIdsOffset);
			IModelComponent.AddCollisionChannelConfig(builder, CollisionChannelConfigOffset);
			IModelComponent.AddPerformanceFaceSkeletalMeshPath(builder, PerformanceFaceSkeletalMeshPathOffset);
			IModelComponent.AddPerformanceTags(builder, PerformanceTagsOffset);
			IModelComponent.AddTrackHeight(builder, TrackHeight);
			IModelComponent.AddHalfHeight(builder, HalfHeight);
			IModelComponent.AddModelType(builder, ModelTypeOffset);
			IModelComponent.AddNullMask(builder, NullMask);
			IModelComponent.AddAbpAnimScheme(builder, AbpAnimScheme);
			IModelComponent.AddIsUseSeqFace(builder, IsUseSeqFace);
			IModelComponent.AddAoiFadeOut(builder, AoiFadeOut);
			IModelComponent.AddModelTypeType(builder, ModelType_type);
			IModelComponent.AddDisabled(builder, Disabled);
			return IModelComponent.EndIModelComponent(builder);
		}

		// Token: 0x060263BE RID: 156606 RVA: 0x0053D434 File Offset: 0x0053B634
		public static void StartIModelComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x060263BF RID: 156607 RVA: 0x0053D43E File Offset: 0x0053B63E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060263C0 RID: 156608 RVA: 0x0053D449 File Offset: 0x0053B649
		public static void AddModelTypeType(FlatBufferBuilder builder, TModelType modelTypeType)
		{
			builder.AddByte(1, (byte)modelTypeType, 0);
		}

		// Token: 0x060263C1 RID: 156609 RVA: 0x0053D454 File Offset: 0x0053B654
		public static void AddModelType(FlatBufferBuilder builder, int modelTypeOffset)
		{
			builder.AddOffset(2, modelTypeOffset, 0);
		}

		// Token: 0x060263C2 RID: 156610 RVA: 0x0053D45F File Offset: 0x0053B65F
		public static void AddHalfHeight(FlatBufferBuilder builder, int halfHeight)
		{
			builder.AddInt(3, halfHeight, 0);
		}

		// Token: 0x060263C3 RID: 156611 RVA: 0x0053D46A File Offset: 0x0053B66A
		public static void AddTrackHeight(FlatBufferBuilder builder, int trackHeight)
		{
			builder.AddInt(4, trackHeight, 0);
		}

		// Token: 0x060263C4 RID: 156612 RVA: 0x0053D475 File Offset: 0x0053B675
		public static void AddPerformanceTags(FlatBufferBuilder builder, VectorOffset performanceTagsOffset)
		{
			builder.AddOffset(5, performanceTagsOffset.Value, 0);
		}

		// Token: 0x060263C5 RID: 156613 RVA: 0x0053D488 File Offset: 0x0053B688
		public static VectorOffset CreatePerformanceTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060263C6 RID: 156614 RVA: 0x0053D4BF File Offset: 0x0053B6BF
		public static VectorOffset CreatePerformanceTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060263C7 RID: 156615 RVA: 0x0053D4D9 File Offset: 0x0053B6D9
		public static VectorOffset CreatePerformanceTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060263C8 RID: 156616 RVA: 0x0053D4F7 File Offset: 0x0053B6F7
		public static VectorOffset CreatePerformanceTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060263C9 RID: 156617 RVA: 0x0053D510 File Offset: 0x0053B710
		public static void StartPerformanceTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060263CA RID: 156618 RVA: 0x0053D51B File Offset: 0x0053B71B
		public static void AddAoiFadeOut(FlatBufferBuilder builder, bool aoiFadeOut)
		{
			builder.AddBool(6, aoiFadeOut, false);
		}

		// Token: 0x060263CB RID: 156619 RVA: 0x0053D526 File Offset: 0x0053B726
		public static void AddPerformanceFaceSkeletalMeshPath(FlatBufferBuilder builder, StringOffset performanceFaceSkeletalMeshPathOffset)
		{
			builder.AddOffset(7, performanceFaceSkeletalMeshPathOffset.Value, 0);
		}

		// Token: 0x060263CC RID: 156620 RVA: 0x0053D536 File Offset: 0x0053B736
		public static void AddIsUseSeqFace(FlatBufferBuilder builder, bool isUseSeqFace)
		{
			builder.AddBool(8, isUseSeqFace, false);
		}

		// Token: 0x060263CD RID: 156621 RVA: 0x0053D541 File Offset: 0x0053B741
		public static void AddAbpAnimScheme(FlatBufferBuilder builder, EAbpAnimScheme abpAnimScheme)
		{
			builder.AddByte(9, (byte)abpAnimScheme, 0);
		}

		// Token: 0x060263CE RID: 156622 RVA: 0x0053D54D File Offset: 0x0053B74D
		public static void AddCollisionChannelConfig(FlatBufferBuilder builder, Offset<ICollisionChannelConfig> collisionChannelConfigOffset)
		{
			builder.AddOffset(10, collisionChannelConfigOffset.Value, 0);
		}

		// Token: 0x060263CF RID: 156623 RVA: 0x0053D55E File Offset: 0x0053B75E
		public static void AddDefaultDecorationIds(FlatBufferBuilder builder, VectorOffset defaultDecorationIdsOffset)
		{
			builder.AddOffset(11, defaultDecorationIdsOffset.Value, 0);
		}

		// Token: 0x060263D0 RID: 156624 RVA: 0x0053D570 File Offset: 0x0053B770
		public static VectorOffset CreateDefaultDecorationIdsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060263D1 RID: 156625 RVA: 0x0053D5B0 File Offset: 0x0053B7B0
		public static VectorOffset CreateDefaultDecorationIdsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060263D2 RID: 156626 RVA: 0x0053D5CA File Offset: 0x0053B7CA
		public static VectorOffset CreateDefaultDecorationIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060263D3 RID: 156627 RVA: 0x0053D5E8 File Offset: 0x0053B7E8
		public static VectorOffset CreateDefaultDecorationIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060263D4 RID: 156628 RVA: 0x0053D601 File Offset: 0x0053B801
		public static void StartDefaultDecorationIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060263D5 RID: 156629 RVA: 0x0053D60C File Offset: 0x0053B80C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x060263D6 RID: 156630 RVA: 0x0053D618 File Offset: 0x0053B818
		public static Offset<IModelComponent> EndIModelComponent(FlatBufferBuilder builder)
		{
			return new Offset<IModelComponent>(builder.EndTable());
		}

		// Token: 0x060263D7 RID: 156631 RVA: 0x0053D628 File Offset: 0x0053B828
		public IModelComponentT UnPack()
		{
			IModelComponentT modelComponentT = new IModelComponentT();
			this.UnPackTo(modelComponentT);
			return modelComponentT;
		}

		// Token: 0x060263D8 RID: 156632 RVA: 0x0053D644 File Offset: 0x0053B844
		public void UnPackTo(IModelComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ModelType = new TModelTypeUnion();
			_o.ModelType.Type = this.ModelTypeType;
			switch (this.ModelTypeType)
			{
			case TModelType.IAnimalModel:
				_o.ModelType.Value = ((this.ModelType<IAnimalModel>() != null) ? this.ModelType<IAnimalModel>().Value.UnPack() : null);
				break;
			case TModelType.ILevelPrefab:
				_o.ModelType.Value = ((this.ModelType<ILevelPrefab>() != null) ? this.ModelType<ILevelPrefab>().Value.UnPack() : null);
				break;
			case TModelType.IModelId:
				_o.ModelType.Value = ((this.ModelType<IModelId>() != null) ? this.ModelType<IModelId>().Value.UnPack() : null);
				break;
			case TModelType.INpcModel:
				_o.ModelType.Value = ((this.ModelType<INpcModel>() != null) ? this.ModelType<INpcModel>().Value.UnPack() : null);
				break;
			}
			_o.HalfHeight = this.HalfHeight;
			_o.TrackHeight = this.TrackHeight;
			_o.PerformanceTags = new List<int>();
			for (int i = 0; i < this.PerformanceTagsLength; i++)
			{
				_o.PerformanceTags.Add(this.PerformanceTags(i));
			}
			_o.AoiFadeOut = this.AoiFadeOut;
			_o.PerformanceFaceSkeletalMeshPath = this.PerformanceFaceSkeletalMeshPath;
			_o.IsUseSeqFace = this.IsUseSeqFace;
			_o.AbpAnimScheme = this.AbpAnimScheme;
			_o.CollisionChannelConfig = ((this.CollisionChannelConfig != null) ? this.CollisionChannelConfig.Value.UnPack() : null);
			_o.DefaultDecorationIds = new List<string>();
			for (int j = 0; j < this.DefaultDecorationIdsLength; j++)
			{
				_o.DefaultDecorationIds.Add(this.DefaultDecorationIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060263D9 RID: 156633 RVA: 0x0053D86C File Offset: 0x0053BA6C
		public static Offset<IModelComponent> Pack(FlatBufferBuilder builder, IModelComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModelComponent>);
			}
			TModelType modelType_type = (_o.ModelType == null) ? TModelType.NONE : _o.ModelType.Type;
			int modelTypeOffset = (_o.ModelType == null) ? 0 : TModelTypeUnion.Pack(builder, _o.ModelType);
			VectorOffset performanceTagsOffset = default(VectorOffset);
			if (_o.PerformanceTags != null)
			{
				int[] data = _o.PerformanceTags.ToArray();
				performanceTagsOffset = IModelComponent.CreatePerformanceTagsVector(builder, data);
			}
			StringOffset performanceFaceSkeletalMeshPathOffset = (_o.PerformanceFaceSkeletalMeshPath == null) ? default(StringOffset) : builder.CreateString(_o.PerformanceFaceSkeletalMeshPath);
			Offset<ICollisionChannelConfig> collisionChannelConfigOffset = (_o.CollisionChannelConfig == null) ? default(Offset<ICollisionChannelConfig>) : ICollisionChannelConfig.Pack(builder, _o.CollisionChannelConfig);
			VectorOffset defaultDecorationIdsOffset = default(VectorOffset);
			if (_o.DefaultDecorationIds != null)
			{
				StringOffset[] array = new StringOffset[_o.DefaultDecorationIds.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.DefaultDecorationIds[i]);
				}
				defaultDecorationIdsOffset = IModelComponent.CreateDefaultDecorationIdsVector(builder, array);
			}
			return IModelComponent.CreateIModelComponent(builder, _o.Disabled, modelType_type, modelTypeOffset, _o.HalfHeight, _o.TrackHeight, performanceTagsOffset, _o.AoiFadeOut, performanceFaceSkeletalMeshPathOffset, _o.IsUseSeqFace, _o.AbpAnimScheme, collisionChannelConfigOffset, defaultDecorationIdsOffset, _o.NullMask);
		}

		// Token: 0x0400F4B9 RID: 62649
		private Table __p;
	}
}
