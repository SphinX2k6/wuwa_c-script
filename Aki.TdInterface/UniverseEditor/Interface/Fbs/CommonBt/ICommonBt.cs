using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005E9C RID: 24220
	public struct ICommonBt : IFlatbufferObject
	{
		// Token: 0x1700B4E3 RID: 46307
		// (get) Token: 0x0602977A RID: 169850 RVA: 0x005AE766 File Offset: 0x005AC966
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602977B RID: 169851 RVA: 0x005AE773 File Offset: 0x005AC973
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602977C RID: 169852 RVA: 0x005AE77C File Offset: 0x005AC97C
		public static ICommonBt GetRootAsICommonBt(ByteBuffer _bb)
		{
			return ICommonBt.GetRootAsICommonBt(_bb, default(ICommonBt));
		}

		// Token: 0x0602977D RID: 169853 RVA: 0x005AE798 File Offset: 0x005AC998
		public static ICommonBt GetRootAsICommonBt(ByteBuffer _bb, ICommonBt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602977E RID: 169854 RVA: 0x005AE7B5 File Offset: 0x005AC9B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602977F RID: 169855 RVA: 0x005AE7C4 File Offset: 0x005AC9C4
		public ICommonBt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4E4 RID: 46308
		// (get) Token: 0x06029780 RID: 169856 RVA: 0x005AE7D4 File Offset: 0x005AC9D4
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

		// Token: 0x06029781 RID: 169857 RVA: 0x005AE80B File Offset: 0x005ACA0B
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029782 RID: 169858 RVA: 0x005AE81A File Offset: 0x005ACA1A
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06029783 RID: 169859 RVA: 0x005AE828 File Offset: 0x005ACA28
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B4E5 RID: 46309
		// (get) Token: 0x06029784 RID: 169860 RVA: 0x005AE864 File Offset: 0x005ACA64
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

		// Token: 0x06029785 RID: 169861 RVA: 0x005AE890 File Offset: 0x005ACA90
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B4E6 RID: 46310
		// (get) Token: 0x06029786 RID: 169862 RVA: 0x005AE8CC File Offset: 0x005ACACC
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

		// Token: 0x06029787 RID: 169863 RVA: 0x005AE8F8 File Offset: 0x005ACAF8
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B4E7 RID: 46311
		// (get) Token: 0x06029788 RID: 169864 RVA: 0x005AE934 File Offset: 0x005ACB34
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

		// Token: 0x1700B4E8 RID: 46312
		// (get) Token: 0x06029789 RID: 169865 RVA: 0x005AE960 File Offset: 0x005ACB60
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

		// Token: 0x1700B4E9 RID: 46313
		// (get) Token: 0x0602978A RID: 169866 RVA: 0x005AE9A0 File Offset: 0x005ACBA0
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

		// Token: 0x0602978B RID: 169867 RVA: 0x005AE9D8 File Offset: 0x005ACBD8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602978C RID: 169868 RVA: 0x005AE9E8 File Offset: 0x005ACBE8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700B4EA RID: 46314
		// (get) Token: 0x0602978D RID: 169869 RVA: 0x005AE9F8 File Offset: 0x005ACBF8
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

		// Token: 0x1700B4EB RID: 46315
		// (get) Token: 0x0602978E RID: 169870 RVA: 0x005AEA38 File Offset: 0x005ACC38
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

		// Token: 0x0602978F RID: 169871 RVA: 0x005AEA70 File Offset: 0x005ACC70
		public Span<byte> GetAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06029790 RID: 169872 RVA: 0x005AEA80 File Offset: 0x005ACC80
		public byte[] GetAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700B4EC RID: 46316
		// (get) Token: 0x06029791 RID: 169873 RVA: 0x005AEA90 File Offset: 0x005ACC90
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

		// Token: 0x06029792 RID: 169874 RVA: 0x005AEAF0 File Offset: 0x005ACCF0
		public ICommonBtPlaceholder? Placeholders(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtPlaceholder?(default(ICommonBtPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B4ED RID: 46317
		// (get) Token: 0x06029793 RID: 169875 RVA: 0x005AEB54 File Offset: 0x005ACD54
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

		// Token: 0x1700B4EE RID: 46318
		// (get) Token: 0x06029794 RID: 169876 RVA: 0x005AEB80 File Offset: 0x005ACD80
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B4EF RID: 46319
		// (get) Token: 0x06029795 RID: 169877 RVA: 0x005AEBC0 File Offset: 0x005ACDC0
		public bool _IsShowTaskId
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029796 RID: 169878 RVA: 0x005AEC00 File Offset: 0x005ACE00
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B4F0 RID: 46320
		// (get) Token: 0x06029797 RID: 169879 RVA: 0x005AEC3C File Offset: 0x005ACE3C
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

		// Token: 0x1700B4F1 RID: 46321
		// (get) Token: 0x06029798 RID: 169880 RVA: 0x005AEC68 File Offset: 0x005ACE68
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

		// Token: 0x06029799 RID: 169881 RVA: 0x005AECA0 File Offset: 0x005ACEA0
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0602979A RID: 169882 RVA: 0x005AECB0 File Offset: 0x005ACEB0
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(30);
		}

		// Token: 0x1700B4F2 RID: 46322
		// (get) Token: 0x0602979B RID: 169883 RVA: 0x005AECC0 File Offset: 0x005ACEC0
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

		// Token: 0x0602979C RID: 169884 RVA: 0x005AECF8 File Offset: 0x005ACEF8
		public Span<byte> Get_FocusPlaceholderNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0602979D RID: 169885 RVA: 0x005AED08 File Offset: 0x005ACF08
		public byte[] Get_FocusPlaceholderNameArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x1700B4F3 RID: 46323
		// (get) Token: 0x0602979E RID: 169886 RVA: 0x005AED18 File Offset: 0x005ACF18
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

		// Token: 0x0602979F RID: 169887 RVA: 0x005AED58 File Offset: 0x005ACF58
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

		// Token: 0x060297A0 RID: 169888 RVA: 0x005AEDF0 File Offset: 0x005ACFF0
		public static void StartICommonBt(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x060297A1 RID: 169889 RVA: 0x005AEDFA File Offset: 0x005ACFFA
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x060297A2 RID: 169890 RVA: 0x005AEE0A File Offset: 0x005AD00A
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x060297A3 RID: 169891 RVA: 0x005AEE1C File Offset: 0x005AD01C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297A4 RID: 169892 RVA: 0x005AEE5C File Offset: 0x005AD05C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297A5 RID: 169893 RVA: 0x005AEE76 File Offset: 0x005AD076
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297A6 RID: 169894 RVA: 0x005AEE94 File Offset: 0x005AD094
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297A7 RID: 169895 RVA: 0x005AEEAD File Offset: 0x005AD0AD
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297A8 RID: 169896 RVA: 0x005AEEB8 File Offset: 0x005AD0B8
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x060297A9 RID: 169897 RVA: 0x005AEEC8 File Offset: 0x005AD0C8
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297AA RID: 169898 RVA: 0x005AEF08 File Offset: 0x005AD108
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297AB RID: 169899 RVA: 0x005AEF22 File Offset: 0x005AD122
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297AC RID: 169900 RVA: 0x005AEF40 File Offset: 0x005AD140
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297AD RID: 169901 RVA: 0x005AEF59 File Offset: 0x005AD159
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297AE RID: 169902 RVA: 0x005AEF64 File Offset: 0x005AD164
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x060297AF RID: 169903 RVA: 0x005AEF74 File Offset: 0x005AD174
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297B0 RID: 169904 RVA: 0x005AEFB4 File Offset: 0x005AD1B4
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297B1 RID: 169905 RVA: 0x005AEFCE File Offset: 0x005AD1CE
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297B2 RID: 169906 RVA: 0x005AEFEC File Offset: 0x005AD1EC
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297B3 RID: 169907 RVA: 0x005AF005 File Offset: 0x005AD205
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297B4 RID: 169908 RVA: 0x005AF010 File Offset: 0x005AD210
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(4, id, 0);
		}

		// Token: 0x060297B5 RID: 169909 RVA: 0x005AF01B File Offset: 0x005AD21B
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(5, nameOffset.Value, 0);
		}

		// Token: 0x060297B6 RID: 169910 RVA: 0x005AF02B File Offset: 0x005AD22B
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(6, levelId, 0);
		}

		// Token: 0x060297B7 RID: 169911 RVA: 0x005AF036 File Offset: 0x005AD236
		public static void AddAssetPath(FlatBufferBuilder builder, StringOffset assetPathOffset)
		{
			builder.AddOffset(7, assetPathOffset.Value, 0);
		}

		// Token: 0x060297B8 RID: 169912 RVA: 0x005AF046 File Offset: 0x005AD246
		public static void AddTree(FlatBufferBuilder builder, Offset<ICommonBtTree> treeOffset)
		{
			builder.AddOffset(8, treeOffset.Value, 0);
		}

		// Token: 0x060297B9 RID: 169913 RVA: 0x005AF056 File Offset: 0x005AD256
		public static void AddPlaceholders(FlatBufferBuilder builder, VectorOffset placeholdersOffset)
		{
			builder.AddOffset(9, placeholdersOffset.Value, 0);
		}

		// Token: 0x060297BA RID: 169914 RVA: 0x005AF068 File Offset: 0x005AD268
		public static VectorOffset CreatePlaceholdersVector(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297BB RID: 169915 RVA: 0x005AF0A8 File Offset: 0x005AD2A8
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297BC RID: 169916 RVA: 0x005AF0C2 File Offset: 0x005AD2C2
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297BD RID: 169917 RVA: 0x005AF0E0 File Offset: 0x005AD2E0
		public static VectorOffset CreatePlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297BE RID: 169918 RVA: 0x005AF0F9 File Offset: 0x005AD2F9
		public static void StartPlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297BF RID: 169919 RVA: 0x005AF104 File Offset: 0x005AD304
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(10, _IsSelectBt, false);
		}

		// Token: 0x060297C0 RID: 169920 RVA: 0x005AF110 File Offset: 0x005AD310
		public static void Add_IsShowTaskId(FlatBufferBuilder builder, bool _IsShowTaskId)
		{
			builder.AddBool(11, _IsShowTaskId, false);
		}

		// Token: 0x060297C1 RID: 169921 RVA: 0x005AF11C File Offset: 0x005AD31C
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(12, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x060297C2 RID: 169922 RVA: 0x005AF130 File Offset: 0x005AD330
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297C3 RID: 169923 RVA: 0x005AF170 File Offset: 0x005AD370
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297C4 RID: 169924 RVA: 0x005AF18A File Offset: 0x005AD38A
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060297C5 RID: 169925 RVA: 0x005AF1A8 File Offset: 0x005AD3A8
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297C6 RID: 169926 RVA: 0x005AF1C1 File Offset: 0x005AD3C1
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297C7 RID: 169927 RVA: 0x005AF1CC File Offset: 0x005AD3CC
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(13, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x060297C8 RID: 169928 RVA: 0x005AF1DD File Offset: 0x005AD3DD
		public static void Add_FocusPlaceholderName(FlatBufferBuilder builder, StringOffset _FocusPlaceholderNameOffset)
		{
			builder.AddOffset(14, _FocusPlaceholderNameOffset.Value, 0);
		}

		// Token: 0x060297C9 RID: 169929 RVA: 0x005AF1EE File Offset: 0x005AD3EE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x060297CA RID: 169930 RVA: 0x005AF1FA File Offset: 0x005AD3FA
		public static Offset<ICommonBt> EndICommonBt(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBt>(builder.EndTable());
		}

		// Token: 0x060297CB RID: 169931 RVA: 0x005AF208 File Offset: 0x005AD408
		public ICommonBtT UnPack()
		{
			ICommonBtT commonBtT = new ICommonBtT();
			this.UnPackTo(commonBtT);
			return commonBtT;
		}

		// Token: 0x060297CC RID: 169932 RVA: 0x005AF224 File Offset: 0x005AD424
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

		// Token: 0x060297CD RID: 169933 RVA: 0x005AF3F4 File Offset: 0x005AD5F4
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

		// Token: 0x0400F8FE RID: 63742
		private Table __p;
	}
}
