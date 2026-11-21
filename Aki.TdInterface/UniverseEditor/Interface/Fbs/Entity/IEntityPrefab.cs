using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C31 RID: 19505
	public struct IEntityPrefab : IFlatbufferObject
	{
		// Token: 0x17008A3D RID: 35389
		// (get) Token: 0x0601DDD8 RID: 122328 RVA: 0x0043009A File Offset: 0x0042E29A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DDD9 RID: 122329 RVA: 0x004300A7 File Offset: 0x0042E2A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DDDA RID: 122330 RVA: 0x004300B0 File Offset: 0x0042E2B0
		public static IEntityPrefab GetRootAsIEntityPrefab(ByteBuffer _bb)
		{
			return IEntityPrefab.GetRootAsIEntityPrefab(_bb, default(IEntityPrefab));
		}

		// Token: 0x0601DDDB RID: 122331 RVA: 0x004300CC File Offset: 0x0042E2CC
		public static IEntityPrefab GetRootAsIEntityPrefab(ByteBuffer _bb, IEntityPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DDDC RID: 122332 RVA: 0x004300E9 File Offset: 0x0042E2E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DDDD RID: 122333 RVA: 0x004300F8 File Offset: 0x0042E2F8
		public IEntityPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A3E RID: 35390
		// (get) Token: 0x0601DDDE RID: 122334 RVA: 0x00430108 File Offset: 0x0042E308
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

		// Token: 0x0601DDDF RID: 122335 RVA: 0x0043013F File Offset: 0x0042E33F
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DDE0 RID: 122336 RVA: 0x0043014E File Offset: 0x0042E34E
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601DDE1 RID: 122337 RVA: 0x0043015C File Offset: 0x0042E35C
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A3F RID: 35391
		// (get) Token: 0x0601DDE2 RID: 122338 RVA: 0x00430198 File Offset: 0x0042E398
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

		// Token: 0x0601DDE3 RID: 122339 RVA: 0x004301C4 File Offset: 0x0042E3C4
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A40 RID: 35392
		// (get) Token: 0x0601DDE4 RID: 122340 RVA: 0x00430200 File Offset: 0x0042E400
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

		// Token: 0x0601DDE5 RID: 122341 RVA: 0x0043022C File Offset: 0x0042E42C
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A41 RID: 35393
		// (get) Token: 0x0601DDE6 RID: 122342 RVA: 0x00430268 File Offset: 0x0042E468
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

		// Token: 0x17008A42 RID: 35394
		// (get) Token: 0x0601DDE7 RID: 122343 RVA: 0x00430294 File Offset: 0x0042E494
		public int PrefabId
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

		// Token: 0x17008A43 RID: 35395
		// (get) Token: 0x0601DDE8 RID: 122344 RVA: 0x004302D4 File Offset: 0x0042E4D4
		public string Name
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

		// Token: 0x0601DDE9 RID: 122345 RVA: 0x0043030C File Offset: 0x0042E50C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601DDEA RID: 122346 RVA: 0x0043031C File Offset: 0x0042E51C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0601DDEB RID: 122347 RVA: 0x0043032C File Offset: 0x0042E52C
		public IEntityPrefabElement? Entities(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPrefabElement?(default(IEntityPrefabElement).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A44 RID: 35396
		// (get) Token: 0x0601DDEC RID: 122348 RVA: 0x00430390 File Offset: 0x0042E590
		public int EntitiesLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008A45 RID: 35397
		// (get) Token: 0x0601DDED RID: 122349 RVA: 0x004303BC File Offset: 0x0042E5BC
		public string BpPath
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

		// Token: 0x0601DDEE RID: 122350 RVA: 0x004303F4 File Offset: 0x0042E5F4
		public Span<byte> GetBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601DDEF RID: 122351 RVA: 0x00430404 File Offset: 0x0042E604
		public byte[] GetBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008A46 RID: 35398
		// (get) Token: 0x0601DDF0 RID: 122352 RVA: 0x00430414 File Offset: 0x0042E614
		public int _SelectedEntityId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A47 RID: 35399
		// (get) Token: 0x0601DDF1 RID: 122353 RVA: 0x00430454 File Offset: 0x0042E654
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DDF2 RID: 122354 RVA: 0x00430494 File Offset: 0x0042E694
		public static Offset<IEntityPrefab> CreateIEntityPrefab(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int PrefabId = 0, StringOffset NameOffset = default(StringOffset), VectorOffset EntitiesOffset = default(VectorOffset), StringOffset BpPathOffset = default(StringOffset), int _SelectedEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(10);
			IEntityPrefab.Add_SelectedEntityId(builder, _SelectedEntityId);
			IEntityPrefab.AddBpPath(builder, BpPathOffset);
			IEntityPrefab.AddEntities(builder, EntitiesOffset);
			IEntityPrefab.AddName(builder, NameOffset);
			IEntityPrefab.AddPrefabId(builder, PrefabId);
			IEntityPrefab.AddWeakReference(builder, WeakReferenceOffset);
			IEntityPrefab.AddReference(builder, ReferenceOffset);
			IEntityPrefab.AddChildren(builder, ChildrenOffset);
			IEntityPrefab.AddObjType(builder, ObjTypeOffset);
			IEntityPrefab.AddNullMask(builder, NullMask);
			return IEntityPrefab.EndIEntityPrefab(builder);
		}

		// Token: 0x0601DDF3 RID: 122355 RVA: 0x004304FC File Offset: 0x0042E6FC
		public static void StartIEntityPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601DDF4 RID: 122356 RVA: 0x00430506 File Offset: 0x0042E706
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601DDF5 RID: 122357 RVA: 0x00430516 File Offset: 0x0042E716
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601DDF6 RID: 122358 RVA: 0x00430528 File Offset: 0x0042E728
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DDF7 RID: 122359 RVA: 0x00430568 File Offset: 0x0042E768
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DDF8 RID: 122360 RVA: 0x00430582 File Offset: 0x0042E782
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DDF9 RID: 122361 RVA: 0x004305A0 File Offset: 0x0042E7A0
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DDFA RID: 122362 RVA: 0x004305B9 File Offset: 0x0042E7B9
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DDFB RID: 122363 RVA: 0x004305C4 File Offset: 0x0042E7C4
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601DDFC RID: 122364 RVA: 0x004305D4 File Offset: 0x0042E7D4
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DDFD RID: 122365 RVA: 0x00430614 File Offset: 0x0042E814
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DDFE RID: 122366 RVA: 0x0043062E File Offset: 0x0042E82E
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DDFF RID: 122367 RVA: 0x0043064C File Offset: 0x0042E84C
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE00 RID: 122368 RVA: 0x00430665 File Offset: 0x0042E865
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE01 RID: 122369 RVA: 0x00430670 File Offset: 0x0042E870
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601DE02 RID: 122370 RVA: 0x00430680 File Offset: 0x0042E880
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE03 RID: 122371 RVA: 0x004306C0 File Offset: 0x0042E8C0
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE04 RID: 122372 RVA: 0x004306DA File Offset: 0x0042E8DA
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE05 RID: 122373 RVA: 0x004306F8 File Offset: 0x0042E8F8
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE06 RID: 122374 RVA: 0x00430711 File Offset: 0x0042E911
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE07 RID: 122375 RVA: 0x0043071C File Offset: 0x0042E91C
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(4, prefabId, 0);
		}

		// Token: 0x0601DE08 RID: 122376 RVA: 0x00430727 File Offset: 0x0042E927
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x0601DE09 RID: 122377 RVA: 0x00430737 File Offset: 0x0042E937
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(6, entitiesOffset.Value, 0);
		}

		// Token: 0x0601DE0A RID: 122378 RVA: 0x00430748 File Offset: 0x0042E948
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityPrefabElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE0B RID: 122379 RVA: 0x00430788 File Offset: 0x0042E988
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityPrefabElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPrefabElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE0C RID: 122380 RVA: 0x004307A2 File Offset: 0x0042E9A2
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPrefabElement>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPrefabElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE0D RID: 122381 RVA: 0x004307C0 File Offset: 0x0042E9C0
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPrefabElement>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE0E RID: 122382 RVA: 0x004307D9 File Offset: 0x0042E9D9
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE0F RID: 122383 RVA: 0x004307E4 File Offset: 0x0042E9E4
		public static void AddBpPath(FlatBufferBuilder builder, StringOffset bpPathOffset)
		{
			builder.AddOffset(7, bpPathOffset.Value, 0);
		}

		// Token: 0x0601DE10 RID: 122384 RVA: 0x004307F4 File Offset: 0x0042E9F4
		public static void Add_SelectedEntityId(FlatBufferBuilder builder, int _SelectedEntityId)
		{
			builder.AddInt(8, _SelectedEntityId, 0);
		}

		// Token: 0x0601DE11 RID: 122385 RVA: 0x004307FF File Offset: 0x0042E9FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601DE12 RID: 122386 RVA: 0x0043080B File Offset: 0x0042EA0B
		public static Offset<IEntityPrefab> EndIEntityPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPrefab>(builder.EndTable());
		}

		// Token: 0x0601DE13 RID: 122387 RVA: 0x00430818 File Offset: 0x0042EA18
		public IEntityPrefabT UnPack()
		{
			IEntityPrefabT entityPrefabT = new IEntityPrefabT();
			this.UnPackTo(entityPrefabT);
			return entityPrefabT;
		}

		// Token: 0x0601DE14 RID: 122388 RVA: 0x00430834 File Offset: 0x0042EA34
		public void UnPackTo(IEntityPrefabT _o)
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
			_o.PrefabId = this.PrefabId;
			_o.Name = this.Name;
			_o.Entities = new List<IEntityPrefabElementT>();
			for (int l = 0; l < this.EntitiesLength; l++)
			{
				_o.Entities.Add((this.Entities(l) != null) ? this.Entities(l).Value.UnPack() : null);
			}
			_o.BpPath = this.BpPath;
			_o._SelectedEntityId = this._SelectedEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601DE15 RID: 122389 RVA: 0x00430968 File Offset: 0x0042EB68
		public static Offset<IEntityPrefab> Pack(FlatBufferBuilder builder, IEntityPrefabT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPrefab>);
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
				childrenOffset = IEntityPrefab.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IEntityPrefab.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IEntityPrefab.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				Offset<IEntityPrefabElement>[] array4 = new Offset<IEntityPrefabElement>[_o.Entities.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IEntityPrefabElement.Pack(builder, _o.Entities[l]);
				}
				entitiesOffset = IEntityPrefab.CreateEntitiesVector(builder, array4);
			}
			StringOffset bpPathOffset = (_o.BpPath == null) ? default(StringOffset) : builder.CreateString(_o.BpPath);
			return IEntityPrefab.CreateIEntityPrefab(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.PrefabId, nameOffset, entitiesOffset, bpPathOffset, _o._SelectedEntityId, _o.NullMask);
		}

		// Token: 0x0400D688 RID: 54920
		private Table __p;
	}
}
