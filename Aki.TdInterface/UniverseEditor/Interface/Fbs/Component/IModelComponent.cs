using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555A RID: 21850
	public struct IModelComponent : IFlatbufferObject
	{
		// Token: 0x1700A15B RID: 41307
		// (get) Token: 0x06024205 RID: 147973 RVA: 0x004FD801 File Offset: 0x004FBA01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024206 RID: 147974 RVA: 0x004FD80E File Offset: 0x004FBA0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024207 RID: 147975 RVA: 0x004FD818 File Offset: 0x004FBA18
		public static IModelComponent GetRootAsIModelComponent(ByteBuffer _bb)
		{
			return IModelComponent.GetRootAsIModelComponent(_bb, default(IModelComponent));
		}

		// Token: 0x06024208 RID: 147976 RVA: 0x004FD834 File Offset: 0x004FBA34
		public static IModelComponent GetRootAsIModelComponent(ByteBuffer _bb, IModelComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024209 RID: 147977 RVA: 0x004FD851 File Offset: 0x004FBA51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602420A RID: 147978 RVA: 0x004FD860 File Offset: 0x004FBA60
		public IModelComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A15C RID: 41308
		// (get) Token: 0x0602420B RID: 147979 RVA: 0x004FD870 File Offset: 0x004FBA70
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A15D RID: 41309
		// (get) Token: 0x0602420C RID: 147980 RVA: 0x004FD8B0 File Offset: 0x004FBAB0
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

		// Token: 0x0602420D RID: 147981 RVA: 0x004FD8EC File Offset: 0x004FBAEC
		public TTable? ModelType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602420E RID: 147982 RVA: 0x004FD930 File Offset: 0x004FBB30
		public IAnimalModel ModelTypeAsIAnimalModel()
		{
			return this.ModelType<IAnimalModel>().Value;
		}

		// Token: 0x0602420F RID: 147983 RVA: 0x004FD94C File Offset: 0x004FBB4C
		public ILevelPrefab ModelTypeAsILevelPrefab()
		{
			return this.ModelType<ILevelPrefab>().Value;
		}

		// Token: 0x06024210 RID: 147984 RVA: 0x004FD968 File Offset: 0x004FBB68
		public IModelId ModelTypeAsIModelId()
		{
			return this.ModelType<IModelId>().Value;
		}

		// Token: 0x06024211 RID: 147985 RVA: 0x004FD984 File Offset: 0x004FBB84
		public INpcModel ModelTypeAsINpcModel()
		{
			return this.ModelType<INpcModel>().Value;
		}

		// Token: 0x1700A15E RID: 41310
		// (get) Token: 0x06024212 RID: 147986 RVA: 0x004FD9A0 File Offset: 0x004FBBA0
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

		// Token: 0x1700A15F RID: 41311
		// (get) Token: 0x06024213 RID: 147987 RVA: 0x004FD9E0 File Offset: 0x004FBBE0
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

		// Token: 0x06024214 RID: 147988 RVA: 0x004FDA20 File Offset: 0x004FBC20
		public int PerformanceTags(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A160 RID: 41312
		// (get) Token: 0x06024215 RID: 147989 RVA: 0x004FDA60 File Offset: 0x004FBC60
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

		// Token: 0x06024216 RID: 147990 RVA: 0x004FDA8C File Offset: 0x004FBC8C
		public Span<int> GetPerformanceTagsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06024217 RID: 147991 RVA: 0x004FDA9C File Offset: 0x004FBC9C
		public int[] GetPerformanceTagsArray()
		{
			return this.__p.__vector_as_array<int>(14);
		}

		// Token: 0x1700A161 RID: 41313
		// (get) Token: 0x06024218 RID: 147992 RVA: 0x004FDAAC File Offset: 0x004FBCAC
		public bool AoiFadeOut
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A162 RID: 41314
		// (get) Token: 0x06024219 RID: 147993 RVA: 0x004FDAEC File Offset: 0x004FBCEC
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

		// Token: 0x0602421A RID: 147994 RVA: 0x004FDB24 File Offset: 0x004FBD24
		public Span<byte> GetPerformanceFaceSkeletalMeshPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602421B RID: 147995 RVA: 0x004FDB34 File Offset: 0x004FBD34
		public byte[] GetPerformanceFaceSkeletalMeshPathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A163 RID: 41315
		// (get) Token: 0x0602421C RID: 147996 RVA: 0x004FDB44 File Offset: 0x004FBD44
		public bool IsUseSeqFace
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A164 RID: 41316
		// (get) Token: 0x0602421D RID: 147997 RVA: 0x004FDB84 File Offset: 0x004FBD84
		public EAbpAnimScheme AbpAnimScheme
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return EAbpAnimScheme.Scheme1;
				}
				return (EAbpAnimScheme)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A165 RID: 41317
		// (get) Token: 0x0602421E RID: 147998 RVA: 0x004FDBC4 File Offset: 0x004FBDC4
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

		// Token: 0x1700A166 RID: 41318
		// (get) Token: 0x0602421F RID: 147999 RVA: 0x004FDC24 File Offset: 0x004FBE24
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024220 RID: 148000 RVA: 0x004FDC64 File Offset: 0x004FBE64
		public static Offset<IModelComponent> CreateIModelComponent(FlatBufferBuilder builder, bool Disabled = false, TModelType ModelType_type = TModelType.NONE, int ModelTypeOffset = 0, int HalfHeight = 0, int TrackHeight = 0, VectorOffset PerformanceTagsOffset = default(VectorOffset), bool AoiFadeOut = false, StringOffset PerformanceFaceSkeletalMeshPathOffset = default(StringOffset), bool IsUseSeqFace = false, EAbpAnimScheme AbpAnimScheme = EAbpAnimScheme.Scheme1, Offset<ICollisionChannelConfig> CollisionChannelConfigOffset = default(Offset<ICollisionChannelConfig>), byte NullMask = 0)
		{
			builder.StartTable(12);
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

		// Token: 0x06024221 RID: 148001 RVA: 0x004FDCDC File Offset: 0x004FBEDC
		public static void StartIModelComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06024222 RID: 148002 RVA: 0x004FDCE6 File Offset: 0x004FBEE6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024223 RID: 148003 RVA: 0x004FDCF1 File Offset: 0x004FBEF1
		public static void AddModelTypeType(FlatBufferBuilder builder, TModelType modelTypeType)
		{
			builder.AddByte(1, (byte)modelTypeType, 0);
		}

		// Token: 0x06024224 RID: 148004 RVA: 0x004FDCFC File Offset: 0x004FBEFC
		public static void AddModelType(FlatBufferBuilder builder, int modelTypeOffset)
		{
			builder.AddOffset(2, modelTypeOffset, 0);
		}

		// Token: 0x06024225 RID: 148005 RVA: 0x004FDD07 File Offset: 0x004FBF07
		public static void AddHalfHeight(FlatBufferBuilder builder, int halfHeight)
		{
			builder.AddInt(3, halfHeight, 0);
		}

		// Token: 0x06024226 RID: 148006 RVA: 0x004FDD12 File Offset: 0x004FBF12
		public static void AddTrackHeight(FlatBufferBuilder builder, int trackHeight)
		{
			builder.AddInt(4, trackHeight, 0);
		}

		// Token: 0x06024227 RID: 148007 RVA: 0x004FDD1D File Offset: 0x004FBF1D
		public static void AddPerformanceTags(FlatBufferBuilder builder, VectorOffset performanceTagsOffset)
		{
			builder.AddOffset(5, performanceTagsOffset.Value, 0);
		}

		// Token: 0x06024228 RID: 148008 RVA: 0x004FDD30 File Offset: 0x004FBF30
		public static VectorOffset CreatePerformanceTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024229 RID: 148009 RVA: 0x004FDD67 File Offset: 0x004FBF67
		public static VectorOffset CreatePerformanceTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602422A RID: 148010 RVA: 0x004FDD81 File Offset: 0x004FBF81
		public static VectorOffset CreatePerformanceTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602422B RID: 148011 RVA: 0x004FDD9F File Offset: 0x004FBF9F
		public static VectorOffset CreatePerformanceTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602422C RID: 148012 RVA: 0x004FDDB8 File Offset: 0x004FBFB8
		public static void StartPerformanceTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602422D RID: 148013 RVA: 0x004FDDC3 File Offset: 0x004FBFC3
		public static void AddAoiFadeOut(FlatBufferBuilder builder, bool aoiFadeOut)
		{
			builder.AddBool(6, aoiFadeOut, false);
		}

		// Token: 0x0602422E RID: 148014 RVA: 0x004FDDCE File Offset: 0x004FBFCE
		public static void AddPerformanceFaceSkeletalMeshPath(FlatBufferBuilder builder, StringOffset performanceFaceSkeletalMeshPathOffset)
		{
			builder.AddOffset(7, performanceFaceSkeletalMeshPathOffset.Value, 0);
		}

		// Token: 0x0602422F RID: 148015 RVA: 0x004FDDDE File Offset: 0x004FBFDE
		public static void AddIsUseSeqFace(FlatBufferBuilder builder, bool isUseSeqFace)
		{
			builder.AddBool(8, isUseSeqFace, false);
		}

		// Token: 0x06024230 RID: 148016 RVA: 0x004FDDE9 File Offset: 0x004FBFE9
		public static void AddAbpAnimScheme(FlatBufferBuilder builder, EAbpAnimScheme abpAnimScheme)
		{
			builder.AddByte(9, (byte)abpAnimScheme, 0);
		}

		// Token: 0x06024231 RID: 148017 RVA: 0x004FDDF5 File Offset: 0x004FBFF5
		public static void AddCollisionChannelConfig(FlatBufferBuilder builder, Offset<ICollisionChannelConfig> collisionChannelConfigOffset)
		{
			builder.AddOffset(10, collisionChannelConfigOffset.Value, 0);
		}

		// Token: 0x06024232 RID: 148018 RVA: 0x004FDE06 File Offset: 0x004FC006
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x06024233 RID: 148019 RVA: 0x004FDE12 File Offset: 0x004FC012
		public static Offset<IModelComponent> EndIModelComponent(FlatBufferBuilder builder)
		{
			return new Offset<IModelComponent>(builder.EndTable());
		}

		// Token: 0x06024234 RID: 148020 RVA: 0x004FDE20 File Offset: 0x004FC020
		public IModelComponentT UnPack()
		{
			IModelComponentT modelComponentT = new IModelComponentT();
			this.UnPackTo(modelComponentT);
			return modelComponentT;
		}

		// Token: 0x06024235 RID: 148021 RVA: 0x004FDE3C File Offset: 0x004FC03C
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024236 RID: 148022 RVA: 0x004FE030 File Offset: 0x004FC230
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
			return IModelComponent.CreateIModelComponent(builder, _o.Disabled, modelType_type, modelTypeOffset, _o.HalfHeight, _o.TrackHeight, performanceTagsOffset, _o.AoiFadeOut, performanceFaceSkeletalMeshPathOffset, _o.IsUseSeqFace, _o.AbpAnimScheme, collisionChannelConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E868 RID: 59496
		private Table __p;
	}
}
