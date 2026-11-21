using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064DF RID: 25823
	public struct ICommonBt : IFlatbufferObject
	{
		// Token: 0x1700BE4E RID: 48718
		// (get) Token: 0x0602BE22 RID: 179746 RVA: 0x005F770A File Offset: 0x005F590A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE23 RID: 179747 RVA: 0x005F7717 File Offset: 0x005F5917
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE24 RID: 179748 RVA: 0x005F7720 File Offset: 0x005F5920
		public static ICommonBt GetRootAsICommonBt(ByteBuffer _bb)
		{
			return ICommonBt.GetRootAsICommonBt(_bb, default(ICommonBt));
		}

		// Token: 0x0602BE25 RID: 179749 RVA: 0x005F773C File Offset: 0x005F593C
		public static ICommonBt GetRootAsICommonBt(ByteBuffer _bb, ICommonBt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE26 RID: 179750 RVA: 0x005F7759 File Offset: 0x005F5959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE27 RID: 179751 RVA: 0x005F7768 File Offset: 0x005F5968
		public ICommonBt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE4F RID: 48719
		// (get) Token: 0x0602BE28 RID: 179752 RVA: 0x005F7778 File Offset: 0x005F5978
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

		// Token: 0x0602BE29 RID: 179753 RVA: 0x005F77AF File Offset: 0x005F59AF
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602BE2A RID: 179754 RVA: 0x005F77BE File Offset: 0x005F59BE
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602BE2B RID: 179755 RVA: 0x005F77CC File Offset: 0x005F59CC
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE50 RID: 48720
		// (get) Token: 0x0602BE2C RID: 179756 RVA: 0x005F7808 File Offset: 0x005F5A08
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

		// Token: 0x0602BE2D RID: 179757 RVA: 0x005F7834 File Offset: 0x005F5A34
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE51 RID: 48721
		// (get) Token: 0x0602BE2E RID: 179758 RVA: 0x005F7870 File Offset: 0x005F5A70
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

		// Token: 0x0602BE2F RID: 179759 RVA: 0x005F789C File Offset: 0x005F5A9C
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE52 RID: 48722
		// (get) Token: 0x0602BE30 RID: 179760 RVA: 0x005F78D8 File Offset: 0x005F5AD8
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

		// Token: 0x1700BE53 RID: 48723
		// (get) Token: 0x0602BE31 RID: 179761 RVA: 0x005F7904 File Offset: 0x005F5B04
		public int Id
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

		// Token: 0x1700BE54 RID: 48724
		// (get) Token: 0x0602BE32 RID: 179762 RVA: 0x005F7944 File Offset: 0x005F5B44
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

		// Token: 0x0602BE33 RID: 179763 RVA: 0x005F797C File Offset: 0x005F5B7C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602BE34 RID: 179764 RVA: 0x005F798C File Offset: 0x005F5B8C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700BE55 RID: 48725
		// (get) Token: 0x0602BE35 RID: 179765 RVA: 0x005F799C File Offset: 0x005F5B9C
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE56 RID: 48726
		// (get) Token: 0x0602BE36 RID: 179766 RVA: 0x005F79DC File Offset: 0x005F5BDC
		public string AssetPath
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

		// Token: 0x0602BE37 RID: 179767 RVA: 0x005F7A14 File Offset: 0x005F5C14
		public Span<byte> GetAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0602BE38 RID: 179768 RVA: 0x005F7A24 File Offset: 0x005F5C24
		public byte[] GetAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700BE57 RID: 48727
		// (get) Token: 0x0602BE39 RID: 179769 RVA: 0x005F7A34 File Offset: 0x005F5C34
		public ICommonBtTree? Tree
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtTree?(default(ICommonBtTree).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602BE3A RID: 179770 RVA: 0x005F7A94 File Offset: 0x005F5C94
		public ICommonBtPlaceholder? Placeholders(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtPlaceholder?(default(ICommonBtPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BE58 RID: 48728
		// (get) Token: 0x0602BE3B RID: 179771 RVA: 0x005F7AF8 File Offset: 0x005F5CF8
		public int PlaceholdersLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700BE59 RID: 48729
		// (get) Token: 0x0602BE3C RID: 179772 RVA: 0x005F7B24 File Offset: 0x005F5D24
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BE5A RID: 48730
		// (get) Token: 0x0602BE3D RID: 179773 RVA: 0x005F7B64 File Offset: 0x005F5D64
		public bool _IsShowTaskId
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602BE3E RID: 179774 RVA: 0x005F7BA4 File Offset: 0x005F5DA4
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE5B RID: 48731
		// (get) Token: 0x0602BE3F RID: 179775 RVA: 0x005F7BE0 File Offset: 0x005F5DE0
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700BE5C RID: 48732
		// (get) Token: 0x0602BE40 RID: 179776 RVA: 0x005F7C0C File Offset: 0x005F5E0C
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BE41 RID: 179777 RVA: 0x005F7C44 File Offset: 0x005F5E44
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0602BE42 RID: 179778 RVA: 0x005F7C54 File Offset: 0x005F5E54
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(30);
		}

		// Token: 0x1700BE5D RID: 48733
		// (get) Token: 0x0602BE43 RID: 179779 RVA: 0x005F7C64 File Offset: 0x005F5E64
		public string _FocusPlaceholderName
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BE44 RID: 179780 RVA: 0x005F7C9C File Offset: 0x005F5E9C
		public Span<byte> Get_FocusPlaceholderNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0602BE45 RID: 179781 RVA: 0x005F7CAC File Offset: 0x005F5EAC
		public byte[] Get_FocusPlaceholderNameArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x1700BE5E RID: 48734
		// (get) Token: 0x0602BE46 RID: 179782 RVA: 0x005F7CBC File Offset: 0x005F5EBC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BE47 RID: 179783 RVA: 0x005F7CFC File Offset: 0x005F5EFC
		public static Offset<ICommonBt> CreateICommonBt(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), int Id = 0, StringOffset NameOffset = default(StringOffset), int LevelId = 0, StringOffset AssetPathOffset = default(StringOffset), Offset<ICommonBtTree> TreeOffset = default(Offset<ICommonBtTree>), VectorOffset PlaceholdersOffset = default(VectorOffset), bool _isSelectBt = false, bool _isShowTaskId = false, VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), StringOffset _focusPlaceholderNameOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(16);
			ICommonBt.Add_FocusPlaceholderName(builder, _focusPlaceholderNameOffset);
			ICommonBt.Add_FocusDataPath(builder, _focusDataPathOffset);
			ICommonBt.Add_HighlightDataPaths(builder, _highlightDataPathsOffset);
			ICommonBt.AddPlaceholders(builder, PlaceholdersOffset);
			ICommonBt.AddTree(builder, TreeOffset);
			ICommonBt.AddAssetPath(builder, AssetPathOffset);
			ICommonBt.AddLevelId(builder, LevelId);
			ICommonBt.AddName(builder, NameOffset);
			ICommonBt.AddId(builder, Id);
			ICommonBt.AddWeakReference(builder, WeakReferenceOffset);
			ICommonBt.AddReference(builder, ReferenceOffset);
			ICommonBt.AddChildren(builder, ChildrenOffset);
			ICommonBt.AddObjType(builder, ObjTypeOffset);
			ICommonBt.AddNullMask(builder, NullMask);
			ICommonBt.Add_IsShowTaskId(builder, _isShowTaskId);
			ICommonBt.Add_IsSelectBt(builder, _isSelectBt);
			return ICommonBt.EndICommonBt(builder);
		}

		// Token: 0x0602BE48 RID: 179784 RVA: 0x005F7D94 File Offset: 0x005F5F94
		public static void StartICommonBt(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x0602BE49 RID: 179785 RVA: 0x005F7D9E File Offset: 0x005F5F9E
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0602BE4A RID: 179786 RVA: 0x005F7DAE File Offset: 0x005F5FAE
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0602BE4B RID: 179787 RVA: 0x005F7DC0 File Offset: 0x005F5FC0
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BE4C RID: 179788 RVA: 0x005F7E00 File Offset: 0x005F6000
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE4D RID: 179789 RVA: 0x005F7E1A File Offset: 0x005F601A
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE4E RID: 179790 RVA: 0x005F7E38 File Offset: 0x005F6038
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BE4F RID: 179791 RVA: 0x005F7E51 File Offset: 0x005F6051
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BE50 RID: 179792 RVA: 0x005F7E5C File Offset: 0x005F605C
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0602BE51 RID: 179793 RVA: 0x005F7E6C File Offset: 0x005F606C
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BE52 RID: 179794 RVA: 0x005F7EAC File Offset: 0x005F60AC
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE53 RID: 179795 RVA: 0x005F7EC6 File Offset: 0x005F60C6
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE54 RID: 179796 RVA: 0x005F7EE4 File Offset: 0x005F60E4
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BE55 RID: 179797 RVA: 0x005F7EFD File Offset: 0x005F60FD
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BE56 RID: 179798 RVA: 0x005F7F08 File Offset: 0x005F6108
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0602BE57 RID: 179799 RVA: 0x005F7F18 File Offset: 0x005F6118
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BE58 RID: 179800 RVA: 0x005F7F58 File Offset: 0x005F6158
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE59 RID: 179801 RVA: 0x005F7F72 File Offset: 0x005F6172
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE5A RID: 179802 RVA: 0x005F7F90 File Offset: 0x005F6190
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BE5B RID: 179803 RVA: 0x005F7FA9 File Offset: 0x005F61A9
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BE5C RID: 179804 RVA: 0x005F7FB4 File Offset: 0x005F61B4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x0602BE5D RID: 179805 RVA: 0x005F7FBF File Offset: 0x005F61BF
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x0602BE5E RID: 179806 RVA: 0x005F7FCF File Offset: 0x005F61CF
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(6, levelId, 0);
		}

		// Token: 0x0602BE5F RID: 179807 RVA: 0x005F7FDA File Offset: 0x005F61DA
		public static void AddAssetPath(FlatBufferBuilder builder, StringOffset assetPathOffset)
		{
			builder.AddOffset(7, assetPathOffset.Value, 0);
		}

		// Token: 0x0602BE60 RID: 179808 RVA: 0x005F7FEA File Offset: 0x005F61EA
		public static void AddTree(FlatBufferBuilder builder, Offset<ICommonBtTree> treeOffset)
		{
			builder.AddOffset(8, treeOffset.Value, 0);
		}

		// Token: 0x0602BE61 RID: 179809 RVA: 0x005F7FFA File Offset: 0x005F61FA
		public static void AddPlaceholders(FlatBufferBuilder builder, VectorOffset placeholdersOffset)
		{
			builder.AddOffset(9, placeholdersOffset.Value, 0);
		}

		// Token: 0x0602BE62 RID: 179810 RVA: 0x005F800C File Offset: 0x005F620C
		public static VectorOffset CreatePlaceholdersVector(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BE63 RID: 179811 RVA: 0x005F804C File Offset: 0x005F624C
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE64 RID: 179812 RVA: 0x005F8066 File Offset: 0x005F6266
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE65 RID: 179813 RVA: 0x005F8084 File Offset: 0x005F6284
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BE66 RID: 179814 RVA: 0x005F809D File Offset: 0x005F629D
		public static void StartPlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BE67 RID: 179815 RVA: 0x005F80A8 File Offset: 0x005F62A8
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(10, _IsSelectBt, false);
		}

		// Token: 0x0602BE68 RID: 179816 RVA: 0x005F80B4 File Offset: 0x005F62B4
		public static void Add_IsShowTaskId(FlatBufferBuilder builder, bool _IsShowTaskId)
		{
			builder.AddBool(11, _IsShowTaskId, false);
		}

		// Token: 0x0602BE69 RID: 179817 RVA: 0x005F80C0 File Offset: 0x005F62C0
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(12, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x0602BE6A RID: 179818 RVA: 0x005F80D4 File Offset: 0x005F62D4
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BE6B RID: 179819 RVA: 0x005F8114 File Offset: 0x005F6314
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE6C RID: 179820 RVA: 0x005F812E File Offset: 0x005F632E
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BE6D RID: 179821 RVA: 0x005F814C File Offset: 0x005F634C
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BE6E RID: 179822 RVA: 0x005F8165 File Offset: 0x005F6365
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BE6F RID: 179823 RVA: 0x005F8170 File Offset: 0x005F6370
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(13, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x0602BE70 RID: 179824 RVA: 0x005F8181 File Offset: 0x005F6381
		public static void Add_FocusPlaceholderName(FlatBufferBuilder builder, StringOffset _FocusPlaceholderNameOffset)
		{
			builder.AddOffset(14, _FocusPlaceholderNameOffset.Value, 0);
		}

		// Token: 0x0602BE71 RID: 179825 RVA: 0x005F8192 File Offset: 0x005F6392
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x0602BE72 RID: 179826 RVA: 0x005F819E File Offset: 0x005F639E
		public static Offset<ICommonBt> EndICommonBt(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBt>(builder.EndTable());
		}

		// Token: 0x0602BE73 RID: 179827 RVA: 0x005F81AC File Offset: 0x005F63AC
		public ICommonBtT UnPack()
		{
			ICommonBtT commonBtT = new ICommonBtT();
			this.UnPackTo(commonBtT);
			return commonBtT;
		}

		// Token: 0x0602BE74 RID: 179828 RVA: 0x005F81C8 File Offset: 0x005F63C8
		public void UnPackTo(ICommonBtT _o)
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
			_o.Id = this.Id;
			_o.Name = this.Name;
			_o.LevelId = this.LevelId;
			_o.AssetPath = this.AssetPath;
			_o.Tree = ((this.Tree != null) ? this.Tree.Value.UnPack() : null);
			_o.Placeholders = new List<ICommonBtPlaceholderT>();
			for (int l = 0; l < this.PlaceholdersLength; l++)
			{
				_o.Placeholders.Add((this.Placeholders(l) != null) ? this.Placeholders(l).Value.UnPack() : null);
			}
			_o._IsSelectBt = this._IsSelectBt;
			_o._IsShowTaskId = this._IsShowTaskId;
			_o._HighlightDataPaths = new List<string>();
			for (int m = 0; m < this._HighlightDataPathsLength; m++)
			{
				_o._HighlightDataPaths.Add(this._HighlightDataPaths(m));
			}
			_o._FocusDataPath = this._FocusDataPath;
			_o._FocusPlaceholderName = this._FocusPlaceholderName;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BE75 RID: 179829 RVA: 0x005F8398 File Offset: 0x005F6598
		public static Offset<ICommonBt> Pack(FlatBufferBuilder builder, ICommonBtT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBt>);
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
				childrenOffset = ICommonBt.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = ICommonBt.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = ICommonBt.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset assetPathOffset = (_o.AssetPath == null) ? default(StringOffset) : builder.CreateString(_o.AssetPath);
			Offset<ICommonBtTree> treeOffset = (_o.Tree == null) ? default(Offset<ICommonBtTree>) : ICommonBtTree.Pack(builder, _o.Tree);
			VectorOffset placeholdersOffset = default(VectorOffset);
			if (_o.Placeholders != null)
			{
				Offset<ICommonBtPlaceholder>[] array4 = new Offset<ICommonBtPlaceholder>[_o.Placeholders.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = ICommonBtPlaceholder.Pack(builder, _o.Placeholders[l]);
				}
				placeholdersOffset = ICommonBt.CreatePlaceholdersVector(builder, array4);
			}
			VectorOffset highlightDataPathsOffset = default(VectorOffset);
			if (_o._HighlightDataPaths != null)
			{
				StringOffset[] array5 = new StringOffset[_o._HighlightDataPaths.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = builder.CreateString(_o._HighlightDataPaths[m]);
				}
				highlightDataPathsOffset = ICommonBt.Create_HighlightDataPathsVector(builder, array5);
			}
			StringOffset focusDataPathOffset = (_o._FocusDataPath == null) ? default(StringOffset) : builder.CreateString(_o._FocusDataPath);
			StringOffset focusPlaceholderNameOffset = (_o._FocusPlaceholderName == null) ? default(StringOffset) : builder.CreateString(_o._FocusPlaceholderName);
			return ICommonBt.CreateICommonBt(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Id, nameOffset, _o.LevelId, assetPathOffset, treeOffset, placeholdersOffset, _o._IsSelectBt, _o._IsShowTaskId, highlightDataPathsOffset, focusDataPathOffset, focusPlaceholderNameOffset, _o.NullMask);
		}

		// Token: 0x04010661 RID: 67169
		private Table __p;
	}
}
