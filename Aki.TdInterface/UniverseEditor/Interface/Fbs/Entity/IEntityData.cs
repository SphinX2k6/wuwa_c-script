using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C0A RID: 19466
	public struct IEntityData : IFlatbufferObject
	{
		// Token: 0x170089D2 RID: 35282
		// (get) Token: 0x0601DC18 RID: 121880 RVA: 0x0042C8B2 File Offset: 0x0042AAB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC19 RID: 121881 RVA: 0x0042C8BF File Offset: 0x0042AABF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC1A RID: 121882 RVA: 0x0042C8C8 File Offset: 0x0042AAC8
		public static IEntityData GetRootAsIEntityData(ByteBuffer _bb)
		{
			return IEntityData.GetRootAsIEntityData(_bb, default(IEntityData));
		}

		// Token: 0x0601DC1B RID: 121883 RVA: 0x0042C8E4 File Offset: 0x0042AAE4
		public static IEntityData GetRootAsIEntityData(ByteBuffer _bb, IEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC1C RID: 121884 RVA: 0x0042C901 File Offset: 0x0042AB01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC1D RID: 121885 RVA: 0x0042C910 File Offset: 0x0042AB10
		public IEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089D3 RID: 35283
		// (get) Token: 0x0601DC1E RID: 121886 RVA: 0x0042C920 File Offset: 0x0042AB20
		public string ObjType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DC1F RID: 121887 RVA: 0x0042C957 File Offset: 0x0042AB57
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DC20 RID: 121888 RVA: 0x0042C966 File Offset: 0x0042AB66
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601DC21 RID: 121889 RVA: 0x0042C974 File Offset: 0x0042AB74
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170089D4 RID: 35284
		// (get) Token: 0x0601DC22 RID: 121890 RVA: 0x0042C9B0 File Offset: 0x0042ABB0
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601DC23 RID: 121891 RVA: 0x0042C9DC File Offset: 0x0042ABDC
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170089D5 RID: 35285
		// (get) Token: 0x0601DC24 RID: 121892 RVA: 0x0042CA18 File Offset: 0x0042AC18
		public int ReferenceLength
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

		// Token: 0x0601DC25 RID: 121893 RVA: 0x0042CA44 File Offset: 0x0042AC44
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170089D6 RID: 35286
		// (get) Token: 0x0601DC26 RID: 121894 RVA: 0x0042CA80 File Offset: 0x0042AC80
		public int WeakReferenceLength
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

		// Token: 0x170089D7 RID: 35287
		// (get) Token: 0x0601DC27 RID: 121895 RVA: 0x0042CAAC File Offset: 0x0042ACAC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DC28 RID: 121896 RVA: 0x0042CAE4 File Offset: 0x0042ACE4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601DC29 RID: 121897 RVA: 0x0042CAF4 File Offset: 0x0042ACF4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170089D8 RID: 35288
		// (get) Token: 0x0601DC2A RID: 121898 RVA: 0x0042CB04 File Offset: 0x0042AD04
		public string BlueprintType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DC2B RID: 121899 RVA: 0x0042CB3C File Offset: 0x0042AD3C
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601DC2C RID: 121900 RVA: 0x0042CB4C File Offset: 0x0042AD4C
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170089D9 RID: 35289
		// (get) Token: 0x0601DC2D RID: 121901 RVA: 0x0042CB5C File Offset: 0x0042AD5C
		public TComponentsData? ComponentsData
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new TComponentsData?(default(TComponentsData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170089DA RID: 35290
		// (get) Token: 0x0601DC2E RID: 121902 RVA: 0x0042CBBC File Offset: 0x0042ADBC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089DB RID: 35291
		// (get) Token: 0x0601DC2F RID: 121903 RVA: 0x0042CBFC File Offset: 0x0042ADFC
		public bool InSleep
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089DC RID: 35292
		// (get) Token: 0x0601DC30 RID: 121904 RVA: 0x0042CC3C File Offset: 0x0042AE3C
		public bool IsHidden
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089DD RID: 35293
		// (get) Token: 0x0601DC31 RID: 121905 RVA: 0x0042CC7C File Offset: 0x0042AE7C
		public bool IsClientHidden
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089DE RID: 35294
		// (get) Token: 0x0601DC32 RID: 121906 RVA: 0x0042CCBC File Offset: 0x0042AEBC
		public bool IsAlwaysLoad
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089DF RID: 35295
		// (get) Token: 0x0601DC33 RID: 121907 RVA: 0x0042CCFC File Offset: 0x0042AEFC
		public bool IsClientAlwaysLoad
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089E0 RID: 35296
		// (get) Token: 0x0601DC34 RID: 121908 RVA: 0x0042CD3C File Offset: 0x0042AF3C
		public bool IsDeprecated
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089E1 RID: 35297
		// (get) Token: 0x0601DC35 RID: 121909 RVA: 0x0042CD7C File Offset: 0x0042AF7C
		public int _PrevTemplateId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089E2 RID: 35298
		// (get) Token: 0x0601DC36 RID: 121910 RVA: 0x0042CDBC File Offset: 0x0042AFBC
		public ITransform? Transform
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return new ITransform?(default(ITransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170089E3 RID: 35299
		// (get) Token: 0x0601DC37 RID: 121911 RVA: 0x0042CE1C File Offset: 0x0042B01C
		public bool IsScaleEnabled
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170089E4 RID: 35300
		// (get) Token: 0x0601DC38 RID: 121912 RVA: 0x0042CE5C File Offset: 0x0042B05C
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170089E5 RID: 35301
		// (get) Token: 0x0601DC39 RID: 121913 RVA: 0x0042CE9C File Offset: 0x0042B09C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DC3A RID: 121914 RVA: 0x0042CEDC File Offset: 0x0042B0DC
		public static Offset<IEntityData> CreateIEntityData(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), StringOffset NameOffset = default(StringOffset), StringOffset BlueprintTypeOffset = default(StringOffset), Offset<TComponentsData> ComponentsDataOffset = default(Offset<TComponentsData>), int Id = 0, bool InSleep = false, bool IsHidden = false, bool IsClientHidden = false, bool IsAlwaysLoad = false, bool IsClientAlwaysLoad = false, bool IsDeprecated = false, int _prevTemplateId = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>), bool IsScaleEnabled = false, int AreaId = 0, ushort NullMask = 0)
		{
			builder.StartTable(19);
			IEntityData.AddAreaId(builder, AreaId);
			IEntityData.AddTransform(builder, TransformOffset);
			IEntityData.Add_PrevTemplateId(builder, _prevTemplateId);
			IEntityData.AddId(builder, Id);
			IEntityData.AddComponentsData(builder, ComponentsDataOffset);
			IEntityData.AddBlueprintType(builder, BlueprintTypeOffset);
			IEntityData.AddName(builder, NameOffset);
			IEntityData.AddWeakReference(builder, WeakReferenceOffset);
			IEntityData.AddReference(builder, ReferenceOffset);
			IEntityData.AddChildren(builder, ChildrenOffset);
			IEntityData.AddObjType(builder, ObjTypeOffset);
			IEntityData.AddNullMask(builder, NullMask);
			IEntityData.AddIsScaleEnabled(builder, IsScaleEnabled);
			IEntityData.AddIsDeprecated(builder, IsDeprecated);
			IEntityData.AddIsClientAlwaysLoad(builder, IsClientAlwaysLoad);
			IEntityData.AddIsAlwaysLoad(builder, IsAlwaysLoad);
			IEntityData.AddIsClientHidden(builder, IsClientHidden);
			IEntityData.AddIsHidden(builder, IsHidden);
			IEntityData.AddInSleep(builder, InSleep);
			return IEntityData.EndIEntityData(builder);
		}

		// Token: 0x0601DC3B RID: 121915 RVA: 0x0042CF8C File Offset: 0x0042B18C
		public static void StartIEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(19);
		}

		// Token: 0x0601DC3C RID: 121916 RVA: 0x0042CF96 File Offset: 0x0042B196
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601DC3D RID: 121917 RVA: 0x0042CFA6 File Offset: 0x0042B1A6
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601DC3E RID: 121918 RVA: 0x0042CFB8 File Offset: 0x0042B1B8
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DC3F RID: 121919 RVA: 0x0042CFF8 File Offset: 0x0042B1F8
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC40 RID: 121920 RVA: 0x0042D012 File Offset: 0x0042B212
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC41 RID: 121921 RVA: 0x0042D030 File Offset: 0x0042B230
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DC42 RID: 121922 RVA: 0x0042D049 File Offset: 0x0042B249
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DC43 RID: 121923 RVA: 0x0042D054 File Offset: 0x0042B254
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601DC44 RID: 121924 RVA: 0x0042D064 File Offset: 0x0042B264
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DC45 RID: 121925 RVA: 0x0042D0A4 File Offset: 0x0042B2A4
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC46 RID: 121926 RVA: 0x0042D0BE File Offset: 0x0042B2BE
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC47 RID: 121927 RVA: 0x0042D0DC File Offset: 0x0042B2DC
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DC48 RID: 121928 RVA: 0x0042D0F5 File Offset: 0x0042B2F5
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DC49 RID: 121929 RVA: 0x0042D100 File Offset: 0x0042B300
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601DC4A RID: 121930 RVA: 0x0042D110 File Offset: 0x0042B310
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DC4B RID: 121931 RVA: 0x0042D150 File Offset: 0x0042B350
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC4C RID: 121932 RVA: 0x0042D16A File Offset: 0x0042B36A
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC4D RID: 121933 RVA: 0x0042D188 File Offset: 0x0042B388
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DC4E RID: 121934 RVA: 0x0042D1A1 File Offset: 0x0042B3A1
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DC4F RID: 121935 RVA: 0x0042D1AC File Offset: 0x0042B3AC
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0601DC50 RID: 121936 RVA: 0x0042D1BC File Offset: 0x0042B3BC
		public static void AddBlueprintType(FlatBufferBuilder builder, StringOffset blueprintTypeOffset)
		{
			builder.AddOffset(5, blueprintTypeOffset.Value, 0);
		}

		// Token: 0x0601DC51 RID: 121937 RVA: 0x0042D1CC File Offset: 0x0042B3CC
		public static void AddComponentsData(FlatBufferBuilder builder, Offset<TComponentsData> componentsDataOffset)
		{
			builder.AddOffset(6, componentsDataOffset.Value, 0);
		}

		// Token: 0x0601DC52 RID: 121938 RVA: 0x0042D1DC File Offset: 0x0042B3DC
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(7, id, 0);
		}

		// Token: 0x0601DC53 RID: 121939 RVA: 0x0042D1E7 File Offset: 0x0042B3E7
		public static void AddInSleep(FlatBufferBuilder builder, bool inSleep)
		{
			builder.AddBool(8, inSleep, false);
		}

		// Token: 0x0601DC54 RID: 121940 RVA: 0x0042D1F2 File Offset: 0x0042B3F2
		public static void AddIsHidden(FlatBufferBuilder builder, bool isHidden)
		{
			builder.AddBool(9, isHidden, false);
		}

		// Token: 0x0601DC55 RID: 121941 RVA: 0x0042D1FE File Offset: 0x0042B3FE
		public static void AddIsClientHidden(FlatBufferBuilder builder, bool isClientHidden)
		{
			builder.AddBool(10, isClientHidden, false);
		}

		// Token: 0x0601DC56 RID: 121942 RVA: 0x0042D20A File Offset: 0x0042B40A
		public static void AddIsAlwaysLoad(FlatBufferBuilder builder, bool isAlwaysLoad)
		{
			builder.AddBool(11, isAlwaysLoad, false);
		}

		// Token: 0x0601DC57 RID: 121943 RVA: 0x0042D216 File Offset: 0x0042B416
		public static void AddIsClientAlwaysLoad(FlatBufferBuilder builder, bool isClientAlwaysLoad)
		{
			builder.AddBool(12, isClientAlwaysLoad, false);
		}

		// Token: 0x0601DC58 RID: 121944 RVA: 0x0042D222 File Offset: 0x0042B422
		public static void AddIsDeprecated(FlatBufferBuilder builder, bool isDeprecated)
		{
			builder.AddBool(13, isDeprecated, false);
		}

		// Token: 0x0601DC59 RID: 121945 RVA: 0x0042D22E File Offset: 0x0042B42E
		public static void Add_PrevTemplateId(FlatBufferBuilder builder, int _PrevTemplateId)
		{
			builder.AddInt(14, _PrevTemplateId, 0);
		}

		// Token: 0x0601DC5A RID: 121946 RVA: 0x0042D23A File Offset: 0x0042B43A
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(15, transformOffset.Value, 0);
		}

		// Token: 0x0601DC5B RID: 121947 RVA: 0x0042D24B File Offset: 0x0042B44B
		public static void AddIsScaleEnabled(FlatBufferBuilder builder, bool isScaleEnabled)
		{
			builder.AddBool(16, isScaleEnabled, false);
		}

		// Token: 0x0601DC5C RID: 121948 RVA: 0x0042D257 File Offset: 0x0042B457
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(17, areaId, 0);
		}

		// Token: 0x0601DC5D RID: 121949 RVA: 0x0042D263 File Offset: 0x0042B463
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(18, nullMask, 0);
		}

		// Token: 0x0601DC5E RID: 121950 RVA: 0x0042D26F File Offset: 0x0042B46F
		public static Offset<IEntityData> EndIEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityData>(builder.EndTable());
		}

		// Token: 0x0601DC5F RID: 121951 RVA: 0x0042D27C File Offset: 0x0042B47C
		public IEntityDataT UnPack()
		{
			IEntityDataT entityDataT = new IEntityDataT();
			this.UnPackTo(entityDataT);
			return entityDataT;
		}

		// Token: 0x0601DC60 RID: 121952 RVA: 0x0042D298 File Offset: 0x0042B498
		public void UnPackTo(IEntityDataT _o)
		{
			_o.ObjType = this.ObjType;
			_o.Children = new List<string>();
			for (int i = 0; i < this.ChildrenLength; i++)
			{
				_o.Children.Add(this.Children(i));
			}
			_o.Reference = new List<string>();
			for (int j = 0; j < this.ReferenceLength; j++)
			{
				_o.Reference.Add(this.Reference(j));
			}
			_o.WeakReference = new List<string>();
			for (int k = 0; k < this.WeakReferenceLength; k++)
			{
				_o.WeakReference.Add(this.WeakReference(k));
			}
			_o.Name = this.Name;
			_o.BlueprintType = this.BlueprintType;
			_o.ComponentsData = ((this.ComponentsData != null) ? this.ComponentsData.Value.UnPack() : null);
			_o.Id = this.Id;
			_o.InSleep = this.InSleep;
			_o.IsHidden = this.IsHidden;
			_o.IsClientHidden = this.IsClientHidden;
			_o.IsAlwaysLoad = this.IsAlwaysLoad;
			_o.IsClientAlwaysLoad = this.IsClientAlwaysLoad;
			_o.IsDeprecated = this.IsDeprecated;
			_o._PrevTemplateId = this._PrevTemplateId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.IsScaleEnabled = this.IsScaleEnabled;
			_o.AreaId = this.AreaId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601DC61 RID: 121953 RVA: 0x0042D43C File Offset: 0x0042B63C
		public static Offset<IEntityData> Pack(FlatBufferBuilder builder, IEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityData>);
			}
			StringOffset objTypeOffset = (_o.ObjType == null) ? default(StringOffset) : builder.CreateString(_o.ObjType);
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				StringOffset[] array = new StringOffset[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Children[i]);
				}
				childrenOffset = IEntityData.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IEntityData.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IEntityData.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset blueprintTypeOffset = (_o.BlueprintType == null) ? default(StringOffset) : builder.CreateString(_o.BlueprintType);
			Offset<TComponentsData> componentsDataOffset = (_o.ComponentsData == null) ? default(Offset<TComponentsData>) : TComponentsData.Pack(builder, _o.ComponentsData);
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			return IEntityData.CreateIEntityData(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, nameOffset, blueprintTypeOffset, componentsDataOffset, _o.Id, _o.InSleep, _o.IsHidden, _o.IsClientHidden, _o.IsAlwaysLoad, _o.IsClientAlwaysLoad, _o.IsDeprecated, _o._PrevTemplateId, transformOffset, _o.IsScaleEnabled, _o.AreaId, _o.NullMask);
		}

		// Token: 0x0400D646 RID: 54854
		private Table __p;
	}
}
