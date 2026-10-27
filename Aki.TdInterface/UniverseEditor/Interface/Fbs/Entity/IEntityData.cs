using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A2 RID: 18338
	public struct IEntityData : IFlatbufferObject
	{
		// Token: 0x17008391 RID: 33681
		// (get) Token: 0x0601C443 RID: 115779 RVA: 0x00400616 File Offset: 0x003FE816
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C444 RID: 115780 RVA: 0x00400623 File Offset: 0x003FE823
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C445 RID: 115781 RVA: 0x0040062C File Offset: 0x003FE82C
		public static IEntityData GetRootAsIEntityData(ByteBuffer _bb)
		{
			return IEntityData.GetRootAsIEntityData(_bb, default(IEntityData));
		}

		// Token: 0x0601C446 RID: 115782 RVA: 0x00400648 File Offset: 0x003FE848
		public static IEntityData GetRootAsIEntityData(ByteBuffer _bb, IEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C447 RID: 115783 RVA: 0x00400665 File Offset: 0x003FE865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C448 RID: 115784 RVA: 0x00400674 File Offset: 0x003FE874
		public IEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008392 RID: 33682
		// (get) Token: 0x0601C449 RID: 115785 RVA: 0x00400684 File Offset: 0x003FE884
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

		// Token: 0x0601C44A RID: 115786 RVA: 0x004006BB File Offset: 0x003FE8BB
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C44B RID: 115787 RVA: 0x004006CA File Offset: 0x003FE8CA
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601C44C RID: 115788 RVA: 0x004006D8 File Offset: 0x003FE8D8
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008393 RID: 33683
		// (get) Token: 0x0601C44D RID: 115789 RVA: 0x00400714 File Offset: 0x003FE914
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

		// Token: 0x0601C44E RID: 115790 RVA: 0x00400740 File Offset: 0x003FE940
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008394 RID: 33684
		// (get) Token: 0x0601C44F RID: 115791 RVA: 0x0040077C File Offset: 0x003FE97C
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

		// Token: 0x0601C450 RID: 115792 RVA: 0x004007A8 File Offset: 0x003FE9A8
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008395 RID: 33685
		// (get) Token: 0x0601C451 RID: 115793 RVA: 0x004007E4 File Offset: 0x003FE9E4
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

		// Token: 0x17008396 RID: 33686
		// (get) Token: 0x0601C452 RID: 115794 RVA: 0x00400810 File Offset: 0x003FEA10
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

		// Token: 0x0601C453 RID: 115795 RVA: 0x00400848 File Offset: 0x003FEA48
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601C454 RID: 115796 RVA: 0x00400858 File Offset: 0x003FEA58
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008397 RID: 33687
		// (get) Token: 0x0601C455 RID: 115797 RVA: 0x00400868 File Offset: 0x003FEA68
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

		// Token: 0x0601C456 RID: 115798 RVA: 0x004008A0 File Offset: 0x003FEAA0
		public Span<byte> GetBlueprintTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601C457 RID: 115799 RVA: 0x004008B0 File Offset: 0x003FEAB0
		public byte[] GetBlueprintTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008398 RID: 33688
		// (get) Token: 0x0601C458 RID: 115800 RVA: 0x004008C0 File Offset: 0x003FEAC0
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

		// Token: 0x17008399 RID: 33689
		// (get) Token: 0x0601C459 RID: 115801 RVA: 0x00400920 File Offset: 0x003FEB20
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

		// Token: 0x1700839A RID: 33690
		// (get) Token: 0x0601C45A RID: 115802 RVA: 0x00400960 File Offset: 0x003FEB60
		public bool InSleep
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700839B RID: 33691
		// (get) Token: 0x0601C45B RID: 115803 RVA: 0x004009A0 File Offset: 0x003FEBA0
		public bool IsHidden
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700839C RID: 33692
		// (get) Token: 0x0601C45C RID: 115804 RVA: 0x004009E0 File Offset: 0x003FEBE0
		public bool IsClientHidden
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700839D RID: 33693
		// (get) Token: 0x0601C45D RID: 115805 RVA: 0x00400A20 File Offset: 0x003FEC20
		public bool IsAlwaysLoad
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700839E RID: 33694
		// (get) Token: 0x0601C45E RID: 115806 RVA: 0x00400A60 File Offset: 0x003FEC60
		public bool IsClientAlwaysLoad
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700839F RID: 33695
		// (get) Token: 0x0601C45F RID: 115807 RVA: 0x00400AA0 File Offset: 0x003FECA0
		public bool IsDeprecated
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170083A0 RID: 33696
		// (get) Token: 0x0601C460 RID: 115808 RVA: 0x00400AE0 File Offset: 0x003FECE0
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

		// Token: 0x170083A1 RID: 33697
		// (get) Token: 0x0601C461 RID: 115809 RVA: 0x00400B20 File Offset: 0x003FED20
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

		// Token: 0x170083A2 RID: 33698
		// (get) Token: 0x0601C462 RID: 115810 RVA: 0x00400B80 File Offset: 0x003FED80
		public bool IsScaleEnabled
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170083A3 RID: 33699
		// (get) Token: 0x0601C463 RID: 115811 RVA: 0x00400BC0 File Offset: 0x003FEDC0
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

		// Token: 0x170083A4 RID: 33700
		// (get) Token: 0x0601C464 RID: 115812 RVA: 0x00400C00 File Offset: 0x003FEE00
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

		// Token: 0x0601C465 RID: 115813 RVA: 0x00400C40 File Offset: 0x003FEE40
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

		// Token: 0x0601C466 RID: 115814 RVA: 0x00400CF0 File Offset: 0x003FEEF0
		public static void StartIEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(19);
		}

		// Token: 0x0601C467 RID: 115815 RVA: 0x00400CFA File Offset: 0x003FEEFA
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601C468 RID: 115816 RVA: 0x00400D0A File Offset: 0x003FEF0A
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601C469 RID: 115817 RVA: 0x00400D1C File Offset: 0x003FEF1C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C46A RID: 115818 RVA: 0x00400D5C File Offset: 0x003FEF5C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C46B RID: 115819 RVA: 0x00400D76 File Offset: 0x003FEF76
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C46C RID: 115820 RVA: 0x00400D94 File Offset: 0x003FEF94
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C46D RID: 115821 RVA: 0x00400DAD File Offset: 0x003FEFAD
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C46E RID: 115822 RVA: 0x00400DB8 File Offset: 0x003FEFB8
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601C46F RID: 115823 RVA: 0x00400DC8 File Offset: 0x003FEFC8
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C470 RID: 115824 RVA: 0x00400E08 File Offset: 0x003FF008
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C471 RID: 115825 RVA: 0x00400E22 File Offset: 0x003FF022
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C472 RID: 115826 RVA: 0x00400E40 File Offset: 0x003FF040
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C473 RID: 115827 RVA: 0x00400E59 File Offset: 0x003FF059
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C474 RID: 115828 RVA: 0x00400E64 File Offset: 0x003FF064
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601C475 RID: 115829 RVA: 0x00400E74 File Offset: 0x003FF074
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C476 RID: 115830 RVA: 0x00400EB4 File Offset: 0x003FF0B4
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C477 RID: 115831 RVA: 0x00400ECE File Offset: 0x003FF0CE
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C478 RID: 115832 RVA: 0x00400EEC File Offset: 0x003FF0EC
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C479 RID: 115833 RVA: 0x00400F05 File Offset: 0x003FF105
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C47A RID: 115834 RVA: 0x00400F10 File Offset: 0x003FF110
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(4, nameOffset.Value, 0);
		}

		// Token: 0x0601C47B RID: 115835 RVA: 0x00400F20 File Offset: 0x003FF120
		public static void AddBlueprintType(FlatBufferBuilder builder, StringOffset blueprintTypeOffset)
		{
			builder.AddOffset(5, blueprintTypeOffset.Value, 0);
		}

		// Token: 0x0601C47C RID: 115836 RVA: 0x00400F30 File Offset: 0x003FF130
		public static void AddComponentsData(FlatBufferBuilder builder, Offset<TComponentsData> componentsDataOffset)
		{
			builder.AddOffset(6, componentsDataOffset.Value, 0);
		}

		// Token: 0x0601C47D RID: 115837 RVA: 0x00400F40 File Offset: 0x003FF140
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(7, id, 0);
		}

		// Token: 0x0601C47E RID: 115838 RVA: 0x00400F4B File Offset: 0x003FF14B
		public static void AddInSleep(FlatBufferBuilder builder, bool inSleep)
		{
			builder.AddBool(8, inSleep, false);
		}

		// Token: 0x0601C47F RID: 115839 RVA: 0x00400F56 File Offset: 0x003FF156
		public static void AddIsHidden(FlatBufferBuilder builder, bool isHidden)
		{
			builder.AddBool(9, isHidden, false);
		}

		// Token: 0x0601C480 RID: 115840 RVA: 0x00400F62 File Offset: 0x003FF162
		public static void AddIsClientHidden(FlatBufferBuilder builder, bool isClientHidden)
		{
			builder.AddBool(10, isClientHidden, false);
		}

		// Token: 0x0601C481 RID: 115841 RVA: 0x00400F6E File Offset: 0x003FF16E
		public static void AddIsAlwaysLoad(FlatBufferBuilder builder, bool isAlwaysLoad)
		{
			builder.AddBool(11, isAlwaysLoad, false);
		}

		// Token: 0x0601C482 RID: 115842 RVA: 0x00400F7A File Offset: 0x003FF17A
		public static void AddIsClientAlwaysLoad(FlatBufferBuilder builder, bool isClientAlwaysLoad)
		{
			builder.AddBool(12, isClientAlwaysLoad, false);
		}

		// Token: 0x0601C483 RID: 115843 RVA: 0x00400F86 File Offset: 0x003FF186
		public static void AddIsDeprecated(FlatBufferBuilder builder, bool isDeprecated)
		{
			builder.AddBool(13, isDeprecated, false);
		}

		// Token: 0x0601C484 RID: 115844 RVA: 0x00400F92 File Offset: 0x003FF192
		public static void Add_PrevTemplateId(FlatBufferBuilder builder, int _PrevTemplateId)
		{
			builder.AddInt(14, _PrevTemplateId, 0);
		}

		// Token: 0x0601C485 RID: 115845 RVA: 0x00400F9E File Offset: 0x003FF19E
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(15, transformOffset.Value, 0);
		}

		// Token: 0x0601C486 RID: 115846 RVA: 0x00400FAF File Offset: 0x003FF1AF
		public static void AddIsScaleEnabled(FlatBufferBuilder builder, bool isScaleEnabled)
		{
			builder.AddBool(16, isScaleEnabled, false);
		}

		// Token: 0x0601C487 RID: 115847 RVA: 0x00400FBB File Offset: 0x003FF1BB
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(17, areaId, 0);
		}

		// Token: 0x0601C488 RID: 115848 RVA: 0x00400FC7 File Offset: 0x003FF1C7
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(18, nullMask, 0);
		}

		// Token: 0x0601C489 RID: 115849 RVA: 0x00400FD3 File Offset: 0x003FF1D3
		public static Offset<IEntityData> EndIEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityData>(builder.EndTable());
		}

		// Token: 0x0601C48A RID: 115850 RVA: 0x00400FE0 File Offset: 0x003FF1E0
		public IEntityDataT UnPack()
		{
			IEntityDataT entityDataT = new IEntityDataT();
			this.UnPackTo(entityDataT);
			return entityDataT;
		}

		// Token: 0x0601C48B RID: 115851 RVA: 0x00400FFC File Offset: 0x003FF1FC
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

		// Token: 0x0601C48C RID: 115852 RVA: 0x004011A0 File Offset: 0x003FF3A0
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

		// Token: 0x0400CC10 RID: 52240
		private Table __p;
	}
}
