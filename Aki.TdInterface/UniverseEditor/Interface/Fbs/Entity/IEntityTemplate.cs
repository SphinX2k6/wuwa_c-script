using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Editor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D5 RID: 18389
	public struct IEntityTemplate : IFlatbufferObject
	{
		// Token: 0x1700841C RID: 33820
		// (get) Token: 0x0601C697 RID: 116375 RVA: 0x0040524C File Offset: 0x0040344C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C698 RID: 116376 RVA: 0x00405259 File Offset: 0x00403459
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C699 RID: 116377 RVA: 0x00405260 File Offset: 0x00403460
		public static IEntityTemplate GetRootAsIEntityTemplate(ByteBuffer _bb)
		{
			return IEntityTemplate.GetRootAsIEntityTemplate(_bb, default(IEntityTemplate));
		}

		// Token: 0x0601C69A RID: 116378 RVA: 0x0040527C File Offset: 0x0040347C
		public static IEntityTemplate GetRootAsIEntityTemplate(ByteBuffer _bb, IEntityTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C69B RID: 116379 RVA: 0x00405299 File Offset: 0x00403499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C69C RID: 116380 RVA: 0x004052A8 File Offset: 0x004034A8
		public IEntityTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700841D RID: 33821
		// (get) Token: 0x0601C69D RID: 116381 RVA: 0x004052B8 File Offset: 0x004034B8
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

		// Token: 0x0601C69E RID: 116382 RVA: 0x004052EF File Offset: 0x004034EF
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C69F RID: 116383 RVA: 0x004052FE File Offset: 0x004034FE
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601C6A0 RID: 116384 RVA: 0x0040530C File Offset: 0x0040350C
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700841E RID: 33822
		// (get) Token: 0x0601C6A1 RID: 116385 RVA: 0x00405348 File Offset: 0x00403548
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

		// Token: 0x0601C6A2 RID: 116386 RVA: 0x00405374 File Offset: 0x00403574
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700841F RID: 33823
		// (get) Token: 0x0601C6A3 RID: 116387 RVA: 0x004053B0 File Offset: 0x004035B0
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

		// Token: 0x0601C6A4 RID: 116388 RVA: 0x004053DC File Offset: 0x004035DC
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008420 RID: 33824
		// (get) Token: 0x0601C6A5 RID: 116389 RVA: 0x00405418 File Offset: 0x00403618
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

		// Token: 0x17008421 RID: 33825
		// (get) Token: 0x0601C6A6 RID: 116390 RVA: 0x00405444 File Offset: 0x00403644
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

		// Token: 0x0601C6A7 RID: 116391 RVA: 0x0040547C File Offset: 0x0040367C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601C6A8 RID: 116392 RVA: 0x0040548C File Offset: 0x0040368C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008422 RID: 33826
		// (get) Token: 0x0601C6A9 RID: 116393 RVA: 0x0040549C File Offset: 0x0040369C
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

		// Token: 0x0601C6AA RID: 116394 RVA: 0x004054D4 File Offset: 0x004036D4
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601C6AB RID: 116395 RVA: 0x004054E4 File Offset: 0x004036E4
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008423 RID: 33827
		// (get) Token: 0x0601C6AC RID: 116396 RVA: 0x004054F4 File Offset: 0x004036F4
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

		// Token: 0x17008424 RID: 33828
		// (get) Token: 0x0601C6AD RID: 116397 RVA: 0x00405554 File Offset: 0x00403754
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

		// Token: 0x17008425 RID: 33829
		// (get) Token: 0x0601C6AE RID: 116398 RVA: 0x00405594 File Offset: 0x00403794
		public string BpPath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C6AF RID: 116399 RVA: 0x004055CC File Offset: 0x004037CC
		public Span<byte> GetBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601C6B0 RID: 116400 RVA: 0x004055DC File Offset: 0x004037DC
		public byte[] GetBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17008426 RID: 33830
		// (get) Token: 0x0601C6B1 RID: 116401 RVA: 0x004055EC File Offset: 0x004037EC
		public EEntity EntityType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return EEntity.CharacterEntity;
				}
				return (EEntity)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008427 RID: 33831
		// (get) Token: 0x0601C6B2 RID: 116402 RVA: 0x0040562C File Offset: 0x0040382C
		public IWorldEditorTemplateConfig? WorldEditorTemplateConfig
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IWorldEditorTemplateConfig?(default(IWorldEditorTemplateConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008428 RID: 33832
		// (get) Token: 0x0601C6B3 RID: 116403 RVA: 0x0040568C File Offset: 0x0040388C
		public EDevelopmentStatus DevelopmentStatus
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return EDevelopmentStatus.Developing;
				}
				return (EDevelopmentStatus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008429 RID: 33833
		// (get) Token: 0x0601C6B4 RID: 116404 RVA: 0x004056CC File Offset: 0x004038CC
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

		// Token: 0x0601C6B5 RID: 116405 RVA: 0x0040570C File Offset: 0x0040390C
		public static Offset<IEntityTemplate> CreateIEntityTemplate(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), StringOffset NameOffset = default(StringOffset), StringOffset BlueprintTypeOffset = default(StringOffset), Offset<TComponentsData> ComponentsDataOffset = default(Offset<TComponentsData>), int Id = 0, StringOffset BpPathOffset = default(StringOffset), EEntity EntityType = EEntity.CharacterEntity, Offset<IWorldEditorTemplateConfig> WorldEditorTemplateConfigOffset = default(Offset<IWorldEditorTemplateConfig>), EDevelopmentStatus DevelopmentStatus = EDevelopmentStatus.Developing, byte NullMask = 0)
		{
			builder.StartTable(13);
			IEntityTemplate.AddWorldEditorTemplateConfig(builder, WorldEditorTemplateConfigOffset);
			IEntityTemplate.AddBpPath(builder, BpPathOffset);
			IEntityTemplate.AddId(builder, Id);
			IEntityTemplate.AddComponentsData(builder, ComponentsDataOffset);
			IEntityTemplate.AddBlueprintType(builder, BlueprintTypeOffset);
			IEntityTemplate.AddName(builder, NameOffset);
			IEntityTemplate.AddWeakReference(builder, WeakReferenceOffset);
			IEntityTemplate.AddReference(builder, ReferenceOffset);
			IEntityTemplate.AddChildren(builder, ChildrenOffset);
			IEntityTemplate.AddObjType(builder, ObjTypeOffset);
			IEntityTemplate.AddEntityType(builder, EntityType);
			IEntityTemplate.AddNullMask(builder, NullMask);
			IEntityTemplate.AddDevelopmentStatus(builder, DevelopmentStatus);
			return IEntityTemplate.EndIEntityTemplate(builder);
		}

		// Token: 0x0601C6B6 RID: 116406 RVA: 0x0040578C File Offset: 0x0040398C
		public static void StartIEntityTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0601C6B7 RID: 116407 RVA: 0x00405796 File Offset: 0x00403996
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601C6B8 RID: 116408 RVA: 0x004057A6 File Offset: 0x004039A6
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601C6B9 RID: 116409 RVA: 0x004057B8 File Offset: 0x004039B8
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C6BA RID: 116410 RVA: 0x004057F8 File Offset: 0x004039F8
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6BB RID: 116411 RVA: 0x00405812 File Offset: 0x00403A12
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6BC RID: 116412 RVA: 0x00405830 File Offset: 0x00403A30
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C6BD RID: 116413 RVA: 0x00405849 File Offset: 0x00403A49
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C6BE RID: 116414 RVA: 0x00405854 File Offset: 0x00403A54
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601C6BF RID: 116415 RVA: 0x00405864 File Offset: 0x00403A64
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C6C0 RID: 116416 RVA: 0x004058A4 File Offset: 0x00403AA4
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6C1 RID: 116417 RVA: 0x004058BE File Offset: 0x00403ABE
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6C2 RID: 116418 RVA: 0x004058DC File Offset: 0x00403ADC
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C6C3 RID: 116419 RVA: 0x004058F5 File Offset: 0x00403AF5
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C6C4 RID: 116420 RVA: 0x00405900 File Offset: 0x00403B00
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601C6C5 RID: 116421 RVA: 0x00405910 File Offset: 0x00403B10
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C6C6 RID: 116422 RVA: 0x00405950 File Offset: 0x00403B50
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6C7 RID: 116423 RVA: 0x0040596A File Offset: 0x00403B6A
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C6C8 RID: 116424 RVA: 0x00405988 File Offset: 0x00403B88
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C6C9 RID: 116425 RVA: 0x004059A1 File Offset: 0x00403BA1
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C6CA RID: 116426 RVA: 0x004059AC File Offset: 0x00403BAC
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0601C6CB RID: 116427 RVA: 0x004059BC File Offset: 0x00403BBC
		public static void AddBlueprintType(FlatBufferBuilder builder, StringOffset blueprintTypeOffset)
		{
			builder.AddOffset(5, blueprintTypeOffset.Value, 0);
		}

		// Token: 0x0601C6CC RID: 116428 RVA: 0x004059CC File Offset: 0x00403BCC
		public static void AddComponentsData(FlatBufferBuilder builder, Offset<TComponentsData> componentsDataOffset)
		{
			builder.AddOffset(6, componentsDataOffset.Value, 0);
		}

		// Token: 0x0601C6CD RID: 116429 RVA: 0x004059DC File Offset: 0x00403BDC
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(7, id, 0);
		}

		// Token: 0x0601C6CE RID: 116430 RVA: 0x004059E7 File Offset: 0x00403BE7
		public static void AddBpPath(FlatBufferBuilder builder, StringOffset bpPathOffset)
		{
			builder.AddOffset(8, bpPathOffset.Value, 0);
		}

		// Token: 0x0601C6CF RID: 116431 RVA: 0x004059F7 File Offset: 0x00403BF7
		public static void AddEntityType(FlatBufferBuilder builder, EEntity entityType)
		{
			builder.AddUshort(9, (ushort)entityType, 0);
		}

		// Token: 0x0601C6D0 RID: 116432 RVA: 0x00405A03 File Offset: 0x00403C03
		public static void AddWorldEditorTemplateConfig(FlatBufferBuilder builder, Offset<IWorldEditorTemplateConfig> worldEditorTemplateConfigOffset)
		{
			builder.AddOffset(10, worldEditorTemplateConfigOffset.Value, 0);
		}

		// Token: 0x0601C6D1 RID: 116433 RVA: 0x00405A14 File Offset: 0x00403C14
		public static void AddDevelopmentStatus(FlatBufferBuilder builder, EDevelopmentStatus developmentStatus)
		{
			builder.AddByte(11, (byte)developmentStatus, 0);
		}

		// Token: 0x0601C6D2 RID: 116434 RVA: 0x00405A20 File Offset: 0x00403C20
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0601C6D3 RID: 116435 RVA: 0x00405A2C File Offset: 0x00403C2C
		public static Offset<IEntityTemplate> EndIEntityTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTemplate>(builder.EndTable());
		}

		// Token: 0x0601C6D4 RID: 116436 RVA: 0x00405A3C File Offset: 0x00403C3C
		public IEntityTemplateT UnPack()
		{
			IEntityTemplateT entityTemplateT = new IEntityTemplateT();
			this.UnPackTo(entityTemplateT);
			return entityTemplateT;
		}

		// Token: 0x0601C6D5 RID: 116437 RVA: 0x00405A58 File Offset: 0x00403C58
		public void UnPackTo(IEntityTemplateT _o)
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
			_o.BpPath = this.BpPath;
			_o.EntityType = this.EntityType;
			_o.WorldEditorTemplateConfig = ((this.WorldEditorTemplateConfig != null) ? this.WorldEditorTemplateConfig.Value.UnPack() : null);
			_o.DevelopmentStatus = this.DevelopmentStatus;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C6D6 RID: 116438 RVA: 0x00405BB4 File Offset: 0x00403DB4
		public static Offset<IEntityTemplate> Pack(FlatBufferBuilder builder, IEntityTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTemplate>);
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
				childrenOffset = IEntityTemplate.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IEntityTemplate.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IEntityTemplate.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset blueprintTypeOffset = (_o.BlueprintType == null) ? default(StringOffset) : builder.CreateString(_o.BlueprintType);
			Offset<TComponentsData> componentsDataOffset = (_o.ComponentsData == null) ? default(Offset<TComponentsData>) : TComponentsData.Pack(builder, _o.ComponentsData);
			StringOffset bpPathOffset = (_o.BpPath == null) ? default(StringOffset) : builder.CreateString(_o.BpPath);
			Offset<IWorldEditorTemplateConfig> worldEditorTemplateConfigOffset = (_o.WorldEditorTemplateConfig == null) ? default(Offset<IWorldEditorTemplateConfig>) : IWorldEditorTemplateConfig.Pack(builder, _o.WorldEditorTemplateConfig);
			return IEntityTemplate.CreateIEntityTemplate(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, nameOffset, blueprintTypeOffset, componentsDataOffset, _o.Id, bpPathOffset, _o.EntityType, worldEditorTemplateConfigOffset, _o.DevelopmentStatus, _o.NullMask);
		}

		// Token: 0x0400CC64 RID: 52324
		private Table __p;
	}
}
