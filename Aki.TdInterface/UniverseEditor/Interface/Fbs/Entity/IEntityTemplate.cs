using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Editor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C3D RID: 19517
	public struct IEntityTemplate : IFlatbufferObject
	{
		// Token: 0x17008A67 RID: 35431
		// (get) Token: 0x0601DE94 RID: 122516 RVA: 0x00431B9C File Offset: 0x0042FD9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE95 RID: 122517 RVA: 0x00431BA9 File Offset: 0x0042FDA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE96 RID: 122518 RVA: 0x00431BB0 File Offset: 0x0042FDB0
		public static IEntityTemplate GetRootAsIEntityTemplate(ByteBuffer _bb)
		{
			return IEntityTemplate.GetRootAsIEntityTemplate(_bb, default(IEntityTemplate));
		}

		// Token: 0x0601DE97 RID: 122519 RVA: 0x00431BCC File Offset: 0x0042FDCC
		public static IEntityTemplate GetRootAsIEntityTemplate(ByteBuffer _bb, IEntityTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE98 RID: 122520 RVA: 0x00431BE9 File Offset: 0x0042FDE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE99 RID: 122521 RVA: 0x00431BF8 File Offset: 0x0042FDF8
		public IEntityTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A68 RID: 35432
		// (get) Token: 0x0601DE9A RID: 122522 RVA: 0x00431C08 File Offset: 0x0042FE08
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

		// Token: 0x0601DE9B RID: 122523 RVA: 0x00431C3F File Offset: 0x0042FE3F
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DE9C RID: 122524 RVA: 0x00431C4E File Offset: 0x0042FE4E
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601DE9D RID: 122525 RVA: 0x00431C5C File Offset: 0x0042FE5C
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A69 RID: 35433
		// (get) Token: 0x0601DE9E RID: 122526 RVA: 0x00431C98 File Offset: 0x0042FE98
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

		// Token: 0x0601DE9F RID: 122527 RVA: 0x00431CC4 File Offset: 0x0042FEC4
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A6A RID: 35434
		// (get) Token: 0x0601DEA0 RID: 122528 RVA: 0x00431D00 File Offset: 0x0042FF00
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

		// Token: 0x0601DEA1 RID: 122529 RVA: 0x00431D2C File Offset: 0x0042FF2C
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A6B RID: 35435
		// (get) Token: 0x0601DEA2 RID: 122530 RVA: 0x00431D68 File Offset: 0x0042FF68
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

		// Token: 0x17008A6C RID: 35436
		// (get) Token: 0x0601DEA3 RID: 122531 RVA: 0x00431D94 File Offset: 0x0042FF94
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

		// Token: 0x0601DEA4 RID: 122532 RVA: 0x00431DCC File Offset: 0x0042FFCC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601DEA5 RID: 122533 RVA: 0x00431DDC File Offset: 0x0042FFDC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008A6D RID: 35437
		// (get) Token: 0x0601DEA6 RID: 122534 RVA: 0x00431DEC File Offset: 0x0042FFEC
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

		// Token: 0x0601DEA7 RID: 122535 RVA: 0x00431E24 File Offset: 0x00430024
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601DEA8 RID: 122536 RVA: 0x00431E34 File Offset: 0x00430034
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008A6E RID: 35438
		// (get) Token: 0x0601DEA9 RID: 122537 RVA: 0x00431E44 File Offset: 0x00430044
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

		// Token: 0x17008A6F RID: 35439
		// (get) Token: 0x0601DEAA RID: 122538 RVA: 0x00431EA4 File Offset: 0x004300A4
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

		// Token: 0x17008A70 RID: 35440
		// (get) Token: 0x0601DEAB RID: 122539 RVA: 0x00431EE4 File Offset: 0x004300E4
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

		// Token: 0x0601DEAC RID: 122540 RVA: 0x00431F1C File Offset: 0x0043011C
		public Span<byte> GetBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601DEAD RID: 122541 RVA: 0x00431F2C File Offset: 0x0043012C
		public byte[] GetBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17008A71 RID: 35441
		// (get) Token: 0x0601DEAE RID: 122542 RVA: 0x00431F3C File Offset: 0x0043013C
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

		// Token: 0x17008A72 RID: 35442
		// (get) Token: 0x0601DEAF RID: 122543 RVA: 0x00431F7C File Offset: 0x0043017C
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

		// Token: 0x17008A73 RID: 35443
		// (get) Token: 0x0601DEB0 RID: 122544 RVA: 0x00431FDC File Offset: 0x004301DC
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

		// Token: 0x17008A74 RID: 35444
		// (get) Token: 0x0601DEB1 RID: 122545 RVA: 0x0043201C File Offset: 0x0043021C
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

		// Token: 0x0601DEB2 RID: 122546 RVA: 0x0043205C File Offset: 0x0043025C
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

		// Token: 0x0601DEB3 RID: 122547 RVA: 0x004320DC File Offset: 0x004302DC
		public static void StartIEntityTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0601DEB4 RID: 122548 RVA: 0x004320E6 File Offset: 0x004302E6
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601DEB5 RID: 122549 RVA: 0x004320F6 File Offset: 0x004302F6
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601DEB6 RID: 122550 RVA: 0x00432108 File Offset: 0x00430308
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DEB7 RID: 122551 RVA: 0x00432148 File Offset: 0x00430348
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEB8 RID: 122552 RVA: 0x00432162 File Offset: 0x00430362
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEB9 RID: 122553 RVA: 0x00432180 File Offset: 0x00430380
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DEBA RID: 122554 RVA: 0x00432199 File Offset: 0x00430399
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DEBB RID: 122555 RVA: 0x004321A4 File Offset: 0x004303A4
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601DEBC RID: 122556 RVA: 0x004321B4 File Offset: 0x004303B4
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DEBD RID: 122557 RVA: 0x004321F4 File Offset: 0x004303F4
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEBE RID: 122558 RVA: 0x0043220E File Offset: 0x0043040E
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEBF RID: 122559 RVA: 0x0043222C File Offset: 0x0043042C
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DEC0 RID: 122560 RVA: 0x00432245 File Offset: 0x00430445
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DEC1 RID: 122561 RVA: 0x00432250 File Offset: 0x00430450
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601DEC2 RID: 122562 RVA: 0x00432260 File Offset: 0x00430460
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DEC3 RID: 122563 RVA: 0x004322A0 File Offset: 0x004304A0
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEC4 RID: 122564 RVA: 0x004322BA File Offset: 0x004304BA
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DEC5 RID: 122565 RVA: 0x004322D8 File Offset: 0x004304D8
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DEC6 RID: 122566 RVA: 0x004322F1 File Offset: 0x004304F1
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DEC7 RID: 122567 RVA: 0x004322FC File Offset: 0x004304FC
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0601DEC8 RID: 122568 RVA: 0x0043230C File Offset: 0x0043050C
		public static void AddBlueprintType(FlatBufferBuilder builder, StringOffset blueprintTypeOffset)
		{
			builder.AddOffset(5, blueprintTypeOffset.Value, 0);
		}

		// Token: 0x0601DEC9 RID: 122569 RVA: 0x0043231C File Offset: 0x0043051C
		public static void AddComponentsData(FlatBufferBuilder builder, Offset<TComponentsData> componentsDataOffset)
		{
			builder.AddOffset(6, componentsDataOffset.Value, 0);
		}

		// Token: 0x0601DECA RID: 122570 RVA: 0x0043232C File Offset: 0x0043052C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(7, id, 0);
		}

		// Token: 0x0601DECB RID: 122571 RVA: 0x00432337 File Offset: 0x00430537
		public static void AddBpPath(FlatBufferBuilder builder, StringOffset bpPathOffset)
		{
			builder.AddOffset(8, bpPathOffset.Value, 0);
		}

		// Token: 0x0601DECC RID: 122572 RVA: 0x00432347 File Offset: 0x00430547
		public static void AddEntityType(FlatBufferBuilder builder, EEntity entityType)
		{
			builder.AddUshort(9, (ushort)entityType, 0);
		}

		// Token: 0x0601DECD RID: 122573 RVA: 0x00432353 File Offset: 0x00430553
		public static void AddWorldEditorTemplateConfig(FlatBufferBuilder builder, Offset<IWorldEditorTemplateConfig> worldEditorTemplateConfigOffset)
		{
			builder.AddOffset(10, worldEditorTemplateConfigOffset.Value, 0);
		}

		// Token: 0x0601DECE RID: 122574 RVA: 0x00432364 File Offset: 0x00430564
		public static void AddDevelopmentStatus(FlatBufferBuilder builder, EDevelopmentStatus developmentStatus)
		{
			builder.AddByte(11, (byte)developmentStatus, 0);
		}

		// Token: 0x0601DECF RID: 122575 RVA: 0x00432370 File Offset: 0x00430570
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x0601DED0 RID: 122576 RVA: 0x0043237C File Offset: 0x0043057C
		public static Offset<IEntityTemplate> EndIEntityTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTemplate>(builder.EndTable());
		}

		// Token: 0x0601DED1 RID: 122577 RVA: 0x0043238C File Offset: 0x0043058C
		public IEntityTemplateT UnPack()
		{
			IEntityTemplateT entityTemplateT = new IEntityTemplateT();
			this.UnPackTo(entityTemplateT);
			return entityTemplateT;
		}

		// Token: 0x0601DED2 RID: 122578 RVA: 0x004323A8 File Offset: 0x004305A8
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

		// Token: 0x0601DED3 RID: 122579 RVA: 0x00432504 File Offset: 0x00430704
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

		// Token: 0x0400D69F RID: 54943
		private Table __p;
	}
}
