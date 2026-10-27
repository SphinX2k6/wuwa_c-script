using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047C9 RID: 18377
	public struct IEntityPrefab : IFlatbufferObject
	{
		// Token: 0x170083FC RID: 33788
		// (get) Token: 0x0601C603 RID: 116227 RVA: 0x00403DFE File Offset: 0x00401FFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C604 RID: 116228 RVA: 0x00403E0B File Offset: 0x0040200B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C605 RID: 116229 RVA: 0x00403E14 File Offset: 0x00402014
		public static IEntityPrefab GetRootAsIEntityPrefab(ByteBuffer _bb)
		{
			return IEntityPrefab.GetRootAsIEntityPrefab(_bb, default(IEntityPrefab));
		}

		// Token: 0x0601C606 RID: 116230 RVA: 0x00403E30 File Offset: 0x00402030
		public static IEntityPrefab GetRootAsIEntityPrefab(ByteBuffer _bb, IEntityPrefab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C607 RID: 116231 RVA: 0x00403E4D File Offset: 0x0040204D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C608 RID: 116232 RVA: 0x00403E5C File Offset: 0x0040205C
		public IEntityPrefab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083FD RID: 33789
		// (get) Token: 0x0601C609 RID: 116233 RVA: 0x00403E6C File Offset: 0x0040206C
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

		// Token: 0x0601C60A RID: 116234 RVA: 0x00403EA3 File Offset: 0x004020A3
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C60B RID: 116235 RVA: 0x00403EB2 File Offset: 0x004020B2
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601C60C RID: 116236 RVA: 0x00403EC0 File Offset: 0x004020C0
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170083FE RID: 33790
		// (get) Token: 0x0601C60D RID: 116237 RVA: 0x00403EFC File Offset: 0x004020FC
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

		// Token: 0x0601C60E RID: 116238 RVA: 0x00403F28 File Offset: 0x00402128
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170083FF RID: 33791
		// (get) Token: 0x0601C60F RID: 116239 RVA: 0x00403F64 File Offset: 0x00402164
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

		// Token: 0x0601C610 RID: 116240 RVA: 0x00403F90 File Offset: 0x00402190
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008400 RID: 33792
		// (get) Token: 0x0601C611 RID: 116241 RVA: 0x00403FCC File Offset: 0x004021CC
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

		// Token: 0x17008401 RID: 33793
		// (get) Token: 0x0601C612 RID: 116242 RVA: 0x00403FF8 File Offset: 0x004021F8
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

		// Token: 0x17008402 RID: 33794
		// (get) Token: 0x0601C613 RID: 116243 RVA: 0x00404038 File Offset: 0x00402238
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

		// Token: 0x0601C614 RID: 116244 RVA: 0x00404070 File Offset: 0x00402270
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601C615 RID: 116245 RVA: 0x00404080 File Offset: 0x00402280
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x0601C616 RID: 116246 RVA: 0x00404090 File Offset: 0x00402290
		public IEntityPrefabElement? Entities(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPrefabElement?(default(IEntityPrefabElement).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008403 RID: 33795
		// (get) Token: 0x0601C617 RID: 116247 RVA: 0x004040F4 File Offset: 0x004022F4
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

		// Token: 0x17008404 RID: 33796
		// (get) Token: 0x0601C618 RID: 116248 RVA: 0x00404120 File Offset: 0x00402320
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

		// Token: 0x0601C619 RID: 116249 RVA: 0x00404158 File Offset: 0x00402358
		public Span<byte> GetBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601C61A RID: 116250 RVA: 0x00404168 File Offset: 0x00402368
		public byte[] GetBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008405 RID: 33797
		// (get) Token: 0x0601C61B RID: 116251 RVA: 0x00404178 File Offset: 0x00402378
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

		// Token: 0x17008406 RID: 33798
		// (get) Token: 0x0601C61C RID: 116252 RVA: 0x004041B8 File Offset: 0x004023B8
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

		// Token: 0x0601C61D RID: 116253 RVA: 0x004041F8 File Offset: 0x004023F8
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

		// Token: 0x0601C61E RID: 116254 RVA: 0x00404260 File Offset: 0x00402460
		public static void StartIEntityPrefab(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601C61F RID: 116255 RVA: 0x0040426A File Offset: 0x0040246A
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601C620 RID: 116256 RVA: 0x0040427A File Offset: 0x0040247A
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601C621 RID: 116257 RVA: 0x0040428C File Offset: 0x0040248C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C622 RID: 116258 RVA: 0x004042CC File Offset: 0x004024CC
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C623 RID: 116259 RVA: 0x004042E6 File Offset: 0x004024E6
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C624 RID: 116260 RVA: 0x00404304 File Offset: 0x00402504
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C625 RID: 116261 RVA: 0x0040431D File Offset: 0x0040251D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C626 RID: 116262 RVA: 0x00404328 File Offset: 0x00402528
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601C627 RID: 116263 RVA: 0x00404338 File Offset: 0x00402538
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C628 RID: 116264 RVA: 0x00404378 File Offset: 0x00402578
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C629 RID: 116265 RVA: 0x00404392 File Offset: 0x00402592
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C62A RID: 116266 RVA: 0x004043B0 File Offset: 0x004025B0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C62B RID: 116267 RVA: 0x004043C9 File Offset: 0x004025C9
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C62C RID: 116268 RVA: 0x004043D4 File Offset: 0x004025D4
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601C62D RID: 116269 RVA: 0x004043E4 File Offset: 0x004025E4
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C62E RID: 116270 RVA: 0x00404424 File Offset: 0x00402624
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C62F RID: 116271 RVA: 0x0040443E File Offset: 0x0040263E
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C630 RID: 116272 RVA: 0x0040445C File Offset: 0x0040265C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C631 RID: 116273 RVA: 0x00404475 File Offset: 0x00402675
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C632 RID: 116274 RVA: 0x00404480 File Offset: 0x00402680
		public static void AddPrefabId(FlatBufferBuilder builder, int prefabId)
		{
			builder.AddInt(4, prefabId, 0);
		}

		// Token: 0x0601C633 RID: 116275 RVA: 0x0040448B File Offset: 0x0040268B
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x0601C634 RID: 116276 RVA: 0x0040449B File Offset: 0x0040269B
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(6, entitiesOffset.Value, 0);
		}

		// Token: 0x0601C635 RID: 116277 RVA: 0x004044AC File Offset: 0x004026AC
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, Offset<IEntityPrefabElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C636 RID: 116278 RVA: 0x004044EC File Offset: 0x004026EC
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, Offset<IEntityPrefabElement>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPrefabElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C637 RID: 116279 RVA: 0x00404506 File Offset: 0x00402706
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPrefabElement>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPrefabElement>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C638 RID: 116280 RVA: 0x00404524 File Offset: 0x00402724
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPrefabElement>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C639 RID: 116281 RVA: 0x0040453D File Offset: 0x0040273D
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C63A RID: 116282 RVA: 0x00404548 File Offset: 0x00402748
		public static void AddBpPath(FlatBufferBuilder builder, StringOffset bpPathOffset)
		{
			builder.AddOffset(7, bpPathOffset.Value, 0);
		}

		// Token: 0x0601C63B RID: 116283 RVA: 0x00404558 File Offset: 0x00402758
		public static void Add_SelectedEntityId(FlatBufferBuilder builder, int _SelectedEntityId)
		{
			builder.AddInt(8, _SelectedEntityId, 0);
		}

		// Token: 0x0601C63C RID: 116284 RVA: 0x00404563 File Offset: 0x00402763
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601C63D RID: 116285 RVA: 0x0040456F File Offset: 0x0040276F
		public static Offset<IEntityPrefab> EndIEntityPrefab(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPrefab>(builder.EndTable());
		}

		// Token: 0x0601C63E RID: 116286 RVA: 0x0040457C File Offset: 0x0040277C
		public IEntityPrefabT UnPack()
		{
			IEntityPrefabT entityPrefabT = new IEntityPrefabT();
			this.UnPackTo(entityPrefabT);
			return entityPrefabT;
		}

		// Token: 0x0601C63F RID: 116287 RVA: 0x00404598 File Offset: 0x00402798
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

		// Token: 0x0601C640 RID: 116288 RVA: 0x004046CC File Offset: 0x004028CC
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

		// Token: 0x0400CC52 RID: 52306
		private Table __p;
	}
}
