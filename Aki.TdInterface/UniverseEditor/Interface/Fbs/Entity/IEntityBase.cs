using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BFB RID: 19451
	public struct IEntityBase : IFlatbufferObject
	{
		// Token: 0x170089AF RID: 35247
		// (get) Token: 0x0601DB68 RID: 121704 RVA: 0x0042B237 File Offset: 0x00429437
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB69 RID: 121705 RVA: 0x0042B244 File Offset: 0x00429444
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB6A RID: 121706 RVA: 0x0042B24C File Offset: 0x0042944C
		public static IEntityBase GetRootAsIEntityBase(ByteBuffer _bb)
		{
			return IEntityBase.GetRootAsIEntityBase(_bb, default(IEntityBase));
		}

		// Token: 0x0601DB6B RID: 121707 RVA: 0x0042B268 File Offset: 0x00429468
		public static IEntityBase GetRootAsIEntityBase(ByteBuffer _bb, IEntityBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB6C RID: 121708 RVA: 0x0042B285 File Offset: 0x00429485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB6D RID: 121709 RVA: 0x0042B294 File Offset: 0x00429494
		public IEntityBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089B0 RID: 35248
		// (get) Token: 0x0601DB6E RID: 121710 RVA: 0x0042B2A4 File Offset: 0x004294A4
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

		// Token: 0x0601DB6F RID: 121711 RVA: 0x0042B2DB File Offset: 0x004294DB
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DB70 RID: 121712 RVA: 0x0042B2EA File Offset: 0x004294EA
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601DB71 RID: 121713 RVA: 0x0042B2F8 File Offset: 0x004294F8
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170089B1 RID: 35249
		// (get) Token: 0x0601DB72 RID: 121714 RVA: 0x0042B334 File Offset: 0x00429534
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

		// Token: 0x0601DB73 RID: 121715 RVA: 0x0042B360 File Offset: 0x00429560
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170089B2 RID: 35250
		// (get) Token: 0x0601DB74 RID: 121716 RVA: 0x0042B39C File Offset: 0x0042959C
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

		// Token: 0x0601DB75 RID: 121717 RVA: 0x0042B3C8 File Offset: 0x004295C8
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170089B3 RID: 35251
		// (get) Token: 0x0601DB76 RID: 121718 RVA: 0x0042B404 File Offset: 0x00429604
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

		// Token: 0x170089B4 RID: 35252
		// (get) Token: 0x0601DB77 RID: 121719 RVA: 0x0042B430 File Offset: 0x00429630
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

		// Token: 0x0601DB78 RID: 121720 RVA: 0x0042B468 File Offset: 0x00429668
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601DB79 RID: 121721 RVA: 0x0042B478 File Offset: 0x00429678
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170089B5 RID: 35253
		// (get) Token: 0x0601DB7A RID: 121722 RVA: 0x0042B488 File Offset: 0x00429688
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

		// Token: 0x0601DB7B RID: 121723 RVA: 0x0042B4C0 File Offset: 0x004296C0
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601DB7C RID: 121724 RVA: 0x0042B4D0 File Offset: 0x004296D0
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170089B6 RID: 35254
		// (get) Token: 0x0601DB7D RID: 121725 RVA: 0x0042B4E0 File Offset: 0x004296E0
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

		// Token: 0x170089B7 RID: 35255
		// (get) Token: 0x0601DB7E RID: 121726 RVA: 0x0042B540 File Offset: 0x00429740
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

		// Token: 0x0601DB7F RID: 121727 RVA: 0x0042B580 File Offset: 0x00429780
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

		// Token: 0x0601DB80 RID: 121728 RVA: 0x0042B5D7 File Offset: 0x004297D7
		public static void StartIEntityBase(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601DB81 RID: 121729 RVA: 0x0042B5E0 File Offset: 0x004297E0
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601DB82 RID: 121730 RVA: 0x0042B5F0 File Offset: 0x004297F0
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601DB83 RID: 121731 RVA: 0x0042B600 File Offset: 0x00429800
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DB84 RID: 121732 RVA: 0x0042B640 File Offset: 0x00429840
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB85 RID: 121733 RVA: 0x0042B65A File Offset: 0x0042985A
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB86 RID: 121734 RVA: 0x0042B678 File Offset: 0x00429878
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DB87 RID: 121735 RVA: 0x0042B691 File Offset: 0x00429891
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DB88 RID: 121736 RVA: 0x0042B69C File Offset: 0x0042989C
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601DB89 RID: 121737 RVA: 0x0042B6AC File Offset: 0x004298AC
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DB8A RID: 121738 RVA: 0x0042B6EC File Offset: 0x004298EC
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB8B RID: 121739 RVA: 0x0042B706 File Offset: 0x00429906
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB8C RID: 121740 RVA: 0x0042B724 File Offset: 0x00429924
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DB8D RID: 121741 RVA: 0x0042B73D File Offset: 0x0042993D
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DB8E RID: 121742 RVA: 0x0042B748 File Offset: 0x00429948
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601DB8F RID: 121743 RVA: 0x0042B758 File Offset: 0x00429958
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DB90 RID: 121744 RVA: 0x0042B798 File Offset: 0x00429998
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB91 RID: 121745 RVA: 0x0042B7B2 File Offset: 0x004299B2
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DB92 RID: 121746 RVA: 0x0042B7D0 File Offset: 0x004299D0
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DB93 RID: 121747 RVA: 0x0042B7E9 File Offset: 0x004299E9
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DB94 RID: 121748 RVA: 0x0042B7F4 File Offset: 0x004299F4
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0601DB95 RID: 121749 RVA: 0x0042B804 File Offset: 0x00429A04
		public static void AddBlueprintType(FlatBufferBuilder builder, StringOffset blueprintTypeOffset)
		{
			builder.AddOffset(5, blueprintTypeOffset.Value, 0);
		}

		// Token: 0x0601DB96 RID: 121750 RVA: 0x0042B814 File Offset: 0x00429A14
		public static void AddComponentsData(FlatBufferBuilder builder, Offset<TComponentsData> componentsDataOffset)
		{
			builder.AddOffset(6, componentsDataOffset.Value, 0);
		}

		// Token: 0x0601DB97 RID: 121751 RVA: 0x0042B824 File Offset: 0x00429A24
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601DB98 RID: 121752 RVA: 0x0042B82F File Offset: 0x00429A2F
		public static Offset<IEntityBase> EndIEntityBase(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBase>(builder.EndTable());
		}

		// Token: 0x0601DB99 RID: 121753 RVA: 0x0042B83C File Offset: 0x00429A3C
		public IEntityBaseT UnPack()
		{
			IEntityBaseT entityBaseT = new IEntityBaseT();
			this.UnPackTo(entityBaseT);
			return entityBaseT;
		}

		// Token: 0x0601DB9A RID: 121754 RVA: 0x0042B858 File Offset: 0x00429A58
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

		// Token: 0x0601DB9B RID: 121755 RVA: 0x0042B950 File Offset: 0x00429B50
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

		// Token: 0x0400D632 RID: 54834
		private Table __p;
	}
}
