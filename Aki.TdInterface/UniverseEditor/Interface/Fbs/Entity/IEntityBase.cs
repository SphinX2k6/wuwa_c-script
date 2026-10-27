using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004793 RID: 18323
	public struct IEntityBase : IFlatbufferObject
	{
		// Token: 0x1700836E RID: 33646
		// (get) Token: 0x0601C393 RID: 115603 RVA: 0x003FEF9B File Offset: 0x003FD19B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C394 RID: 115604 RVA: 0x003FEFA8 File Offset: 0x003FD1A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C395 RID: 115605 RVA: 0x003FEFB0 File Offset: 0x003FD1B0
		public static IEntityBase GetRootAsIEntityBase(ByteBuffer _bb)
		{
			return IEntityBase.GetRootAsIEntityBase(_bb, default(IEntityBase));
		}

		// Token: 0x0601C396 RID: 115606 RVA: 0x003FEFCC File Offset: 0x003FD1CC
		public static IEntityBase GetRootAsIEntityBase(ByteBuffer _bb, IEntityBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C397 RID: 115607 RVA: 0x003FEFE9 File Offset: 0x003FD1E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C398 RID: 115608 RVA: 0x003FEFF8 File Offset: 0x003FD1F8
		public IEntityBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700836F RID: 33647
		// (get) Token: 0x0601C399 RID: 115609 RVA: 0x003FF008 File Offset: 0x003FD208
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

		// Token: 0x0601C39A RID: 115610 RVA: 0x003FF03F File Offset: 0x003FD23F
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C39B RID: 115611 RVA: 0x003FF04E File Offset: 0x003FD24E
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601C39C RID: 115612 RVA: 0x003FF05C File Offset: 0x003FD25C
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008370 RID: 33648
		// (get) Token: 0x0601C39D RID: 115613 RVA: 0x003FF098 File Offset: 0x003FD298
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

		// Token: 0x0601C39E RID: 115614 RVA: 0x003FF0C4 File Offset: 0x003FD2C4
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008371 RID: 33649
		// (get) Token: 0x0601C39F RID: 115615 RVA: 0x003FF100 File Offset: 0x003FD300
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

		// Token: 0x0601C3A0 RID: 115616 RVA: 0x003FF12C File Offset: 0x003FD32C
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008372 RID: 33650
		// (get) Token: 0x0601C3A1 RID: 115617 RVA: 0x003FF168 File Offset: 0x003FD368
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

		// Token: 0x17008373 RID: 33651
		// (get) Token: 0x0601C3A2 RID: 115618 RVA: 0x003FF194 File Offset: 0x003FD394
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

		// Token: 0x0601C3A3 RID: 115619 RVA: 0x003FF1CC File Offset: 0x003FD3CC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601C3A4 RID: 115620 RVA: 0x003FF1DC File Offset: 0x003FD3DC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008374 RID: 33652
		// (get) Token: 0x0601C3A5 RID: 115621 RVA: 0x003FF1EC File Offset: 0x003FD3EC
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

		// Token: 0x0601C3A6 RID: 115622 RVA: 0x003FF224 File Offset: 0x003FD424
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601C3A7 RID: 115623 RVA: 0x003FF234 File Offset: 0x003FD434
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008375 RID: 33653
		// (get) Token: 0x0601C3A8 RID: 115624 RVA: 0x003FF244 File Offset: 0x003FD444
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

		// Token: 0x17008376 RID: 33654
		// (get) Token: 0x0601C3A9 RID: 115625 RVA: 0x003FF2A4 File Offset: 0x003FD4A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C3AA RID: 115626 RVA: 0x003FF2E4 File Offset: 0x003FD4E4
		public static Offset<IEntityBase> CreateIEntityBase(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), StringOffset NameOffset = default(StringOffset), StringOffset BlueprintTypeOffset = default(StringOffset), Offset<TComponentsData> ComponentsDataOffset = default(Offset<TComponentsData>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IEntityBase.AddComponentsData(builder, ComponentsDataOffset);
			IEntityBase.AddBlueprintType(builder, BlueprintTypeOffset);
			IEntityBase.AddName(builder, NameOffset);
			IEntityBase.AddWeakReference(builder, WeakReferenceOffset);
			IEntityBase.AddReference(builder, ReferenceOffset);
			IEntityBase.AddChildren(builder, ChildrenOffset);
			IEntityBase.AddObjType(builder, ObjTypeOffset);
			IEntityBase.AddNullMask(builder, NullMask);
			return IEntityBase.EndIEntityBase(builder);
		}

		// Token: 0x0601C3AB RID: 115627 RVA: 0x003FF33B File Offset: 0x003FD53B
		public static void StartIEntityBase(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601C3AC RID: 115628 RVA: 0x003FF344 File Offset: 0x003FD544
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601C3AD RID: 115629 RVA: 0x003FF354 File Offset: 0x003FD554
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601C3AE RID: 115630 RVA: 0x003FF364 File Offset: 0x003FD564
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C3AF RID: 115631 RVA: 0x003FF3A4 File Offset: 0x003FD5A4
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B0 RID: 115632 RVA: 0x003FF3BE File Offset: 0x003FD5BE
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B1 RID: 115633 RVA: 0x003FF3DC File Offset: 0x003FD5DC
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C3B2 RID: 115634 RVA: 0x003FF3F5 File Offset: 0x003FD5F5
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C3B3 RID: 115635 RVA: 0x003FF400 File Offset: 0x003FD600
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601C3B4 RID: 115636 RVA: 0x003FF410 File Offset: 0x003FD610
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C3B5 RID: 115637 RVA: 0x003FF450 File Offset: 0x003FD650
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B6 RID: 115638 RVA: 0x003FF46A File Offset: 0x003FD66A
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3B7 RID: 115639 RVA: 0x003FF488 File Offset: 0x003FD688
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C3B8 RID: 115640 RVA: 0x003FF4A1 File Offset: 0x003FD6A1
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C3B9 RID: 115641 RVA: 0x003FF4AC File Offset: 0x003FD6AC
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601C3BA RID: 115642 RVA: 0x003FF4BC File Offset: 0x003FD6BC
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C3BB RID: 115643 RVA: 0x003FF4FC File Offset: 0x003FD6FC
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3BC RID: 115644 RVA: 0x003FF516 File Offset: 0x003FD716
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C3BD RID: 115645 RVA: 0x003FF534 File Offset: 0x003FD734
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C3BE RID: 115646 RVA: 0x003FF54D File Offset: 0x003FD74D
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C3BF RID: 115647 RVA: 0x003FF558 File Offset: 0x003FD758
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0601C3C0 RID: 115648 RVA: 0x003FF568 File Offset: 0x003FD768
		public static void AddBlueprintType(FlatBufferBuilder builder, StringOffset blueprintTypeOffset)
		{
			builder.AddOffset(5, blueprintTypeOffset.Value, 0);
		}

		// Token: 0x0601C3C1 RID: 115649 RVA: 0x003FF578 File Offset: 0x003FD778
		public static void AddComponentsData(FlatBufferBuilder builder, Offset<TComponentsData> componentsDataOffset)
		{
			builder.AddOffset(6, componentsDataOffset.Value, 0);
		}

		// Token: 0x0601C3C2 RID: 115650 RVA: 0x003FF588 File Offset: 0x003FD788
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601C3C3 RID: 115651 RVA: 0x003FF593 File Offset: 0x003FD793
		public static Offset<IEntityBase> EndIEntityBase(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBase>(builder.EndTable());
		}

		// Token: 0x0601C3C4 RID: 115652 RVA: 0x003FF5A0 File Offset: 0x003FD7A0
		public IEntityBaseT UnPack()
		{
			IEntityBaseT entityBaseT = new IEntityBaseT();
			this.UnPackTo(entityBaseT);
			return entityBaseT;
		}

		// Token: 0x0601C3C5 RID: 115653 RVA: 0x003FF5BC File Offset: 0x003FD7BC
		public void UnPackTo(IEntityBaseT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C3C6 RID: 115654 RVA: 0x003FF6B4 File Offset: 0x003FD8B4
		public static Offset<IEntityBase> Pack(FlatBufferBuilder builder, IEntityBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBase>);
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
				childrenOffset = IEntityBase.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IEntityBase.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IEntityBase.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset blueprintTypeOffset = (_o.BlueprintType == null) ? default(StringOffset) : builder.CreateString(_o.BlueprintType);
			Offset<TComponentsData> componentsDataOffset = (_o.ComponentsData == null) ? default(Offset<TComponentsData>) : TComponentsData.Pack(builder, _o.ComponentsData);
			return IEntityBase.CreateIEntityBase(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, nameOffset, blueprintTypeOffset, componentsDataOffset, _o.NullMask);
		}

		// Token: 0x0400CBFC RID: 52220
		private Table __p;
	}
}
