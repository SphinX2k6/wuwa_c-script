using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C8B RID: 19595
	public struct IBehaviorTreeFragment : IFlatbufferObject
	{
		// Token: 0x17008AC1 RID: 35521
		// (get) Token: 0x0601E052 RID: 122962 RVA: 0x004351CE File Offset: 0x004333CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E053 RID: 122963 RVA: 0x004351DB File Offset: 0x004333DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E054 RID: 122964 RVA: 0x004351E4 File Offset: 0x004333E4
		public static IBehaviorTreeFragment GetRootAsIBehaviorTreeFragment(ByteBuffer _bb)
		{
			return IBehaviorTreeFragment.GetRootAsIBehaviorTreeFragment(_bb, default(IBehaviorTreeFragment));
		}

		// Token: 0x0601E055 RID: 122965 RVA: 0x00435200 File Offset: 0x00433400
		public static IBehaviorTreeFragment GetRootAsIBehaviorTreeFragment(ByteBuffer _bb, IBehaviorTreeFragment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E056 RID: 122966 RVA: 0x0043521D File Offset: 0x0043341D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E057 RID: 122967 RVA: 0x0043522C File Offset: 0x0043342C
		public IBehaviorTreeFragment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AC2 RID: 35522
		// (get) Token: 0x0601E058 RID: 122968 RVA: 0x0043523C File Offset: 0x0043343C
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

		// Token: 0x0601E059 RID: 122969 RVA: 0x00435273 File Offset: 0x00433473
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E05A RID: 122970 RVA: 0x00435282 File Offset: 0x00433482
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601E05B RID: 122971 RVA: 0x00435290 File Offset: 0x00433490
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008AC3 RID: 35523
		// (get) Token: 0x0601E05C RID: 122972 RVA: 0x004352CC File Offset: 0x004334CC
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

		// Token: 0x0601E05D RID: 122973 RVA: 0x004352F8 File Offset: 0x004334F8
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008AC4 RID: 35524
		// (get) Token: 0x0601E05E RID: 122974 RVA: 0x00435334 File Offset: 0x00433534
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

		// Token: 0x0601E05F RID: 122975 RVA: 0x00435360 File Offset: 0x00433560
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008AC5 RID: 35525
		// (get) Token: 0x0601E060 RID: 122976 RVA: 0x0043539C File Offset: 0x0043359C
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

		// Token: 0x17008AC6 RID: 35526
		// (get) Token: 0x0601E061 RID: 122977 RVA: 0x004353C8 File Offset: 0x004335C8
		public EFragmentType Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EFragmentType.LevelPlay;
				}
				return (EFragmentType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AC7 RID: 35527
		// (get) Token: 0x0601E062 RID: 122978 RVA: 0x00435408 File Offset: 0x00433608
		public int Id
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008AC8 RID: 35528
		// (get) Token: 0x0601E063 RID: 122979 RVA: 0x00435448 File Offset: 0x00433648
		public string Description
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E064 RID: 122980 RVA: 0x00435480 File Offset: 0x00433680
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601E065 RID: 122981 RVA: 0x00435490 File Offset: 0x00433690
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17008AC9 RID: 35529
		// (get) Token: 0x0601E066 RID: 122982 RVA: 0x004354A0 File Offset: 0x004336A0
		public int DungeonId
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

		// Token: 0x17008ACA RID: 35530
		// (get) Token: 0x0601E067 RID: 122983 RVA: 0x004354E0 File Offset: 0x004336E0
		public bool AutoUnbind
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008ACB RID: 35531
		// (get) Token: 0x0601E068 RID: 122984 RVA: 0x00435520 File Offset: 0x00433720
		public IBehaviorTree? Tree
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IBehaviorTree?(default(IBehaviorTree).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008ACC RID: 35532
		// (get) Token: 0x0601E069 RID: 122985 RVA: 0x00435580 File Offset: 0x00433780
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E06A RID: 122986 RVA: 0x004355C0 File Offset: 0x004337C0
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008ACD RID: 35533
		// (get) Token: 0x0601E06B RID: 122987 RVA: 0x004355FC File Offset: 0x004337FC
		public int _HighlightDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008ACE RID: 35534
		// (get) Token: 0x0601E06C RID: 122988 RVA: 0x00435628 File Offset: 0x00433828
		public string _FocusDataPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E06D RID: 122989 RVA: 0x00435660 File Offset: 0x00433860
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0601E06E RID: 122990 RVA: 0x00435670 File Offset: 0x00433870
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(28);
		}

		// Token: 0x0601E06F RID: 122991 RVA: 0x00435680 File Offset: 0x00433880
		public IPlaceholder? _RemovedPlaceholders(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new IPlaceholder?(default(IPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008ACF RID: 35535
		// (get) Token: 0x0601E070 RID: 122992 RVA: 0x004356E4 File Offset: 0x004338E4
		public int _RemovedPlaceholdersLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008AD0 RID: 35536
		// (get) Token: 0x0601E071 RID: 122993 RVA: 0x00435710 File Offset: 0x00433910
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E072 RID: 122994 RVA: 0x00435750 File Offset: 0x00433950
		public static Offset<IBehaviorTreeFragment> CreateIBehaviorTreeFragment(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), EFragmentType Type = EFragmentType.LevelPlay, int Id = 0, StringOffset DescriptionOffset = default(StringOffset), int DungeonId = 0, bool AutoUnbind = false, Offset<IBehaviorTree> TreeOffset = default(Offset<IBehaviorTree>), bool _isSelectBt = false, VectorOffset _highlightDataPathsOffset = default(VectorOffset), StringOffset _focusDataPathOffset = default(StringOffset), VectorOffset _removedPlaceholdersOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(15);
			IBehaviorTreeFragment.Add_RemovedPlaceholders(builder, _removedPlaceholdersOffset);
			IBehaviorTreeFragment.Add_FocusDataPath(builder, _focusDataPathOffset);
			IBehaviorTreeFragment.Add_HighlightDataPaths(builder, _highlightDataPathsOffset);
			IBehaviorTreeFragment.AddTree(builder, TreeOffset);
			IBehaviorTreeFragment.AddDungeonId(builder, DungeonId);
			IBehaviorTreeFragment.AddDescription(builder, DescriptionOffset);
			IBehaviorTreeFragment.AddId(builder, Id);
			IBehaviorTreeFragment.AddWeakReference(builder, WeakReferenceOffset);
			IBehaviorTreeFragment.AddReference(builder, ReferenceOffset);
			IBehaviorTreeFragment.AddChildren(builder, ChildrenOffset);
			IBehaviorTreeFragment.AddObjType(builder, ObjTypeOffset);
			IBehaviorTreeFragment.AddNullMask(builder, NullMask);
			IBehaviorTreeFragment.Add_IsSelectBt(builder, _isSelectBt);
			IBehaviorTreeFragment.AddAutoUnbind(builder, AutoUnbind);
			IBehaviorTreeFragment.AddType(builder, Type);
			return IBehaviorTreeFragment.EndIBehaviorTreeFragment(builder);
		}

		// Token: 0x0601E073 RID: 122995 RVA: 0x004357E0 File Offset: 0x004339E0
		public static void StartIBehaviorTreeFragment(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x0601E074 RID: 122996 RVA: 0x004357EA File Offset: 0x004339EA
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601E075 RID: 122997 RVA: 0x004357FA File Offset: 0x004339FA
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601E076 RID: 122998 RVA: 0x0043580C File Offset: 0x00433A0C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E077 RID: 122999 RVA: 0x0043584C File Offset: 0x00433A4C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E078 RID: 123000 RVA: 0x00435866 File Offset: 0x00433A66
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E079 RID: 123001 RVA: 0x00435884 File Offset: 0x00433A84
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E07A RID: 123002 RVA: 0x0043589D File Offset: 0x00433A9D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E07B RID: 123003 RVA: 0x004358A8 File Offset: 0x00433AA8
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601E07C RID: 123004 RVA: 0x004358B8 File Offset: 0x00433AB8
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E07D RID: 123005 RVA: 0x004358F8 File Offset: 0x00433AF8
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E07E RID: 123006 RVA: 0x00435912 File Offset: 0x00433B12
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E07F RID: 123007 RVA: 0x00435930 File Offset: 0x00433B30
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E080 RID: 123008 RVA: 0x00435949 File Offset: 0x00433B49
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E081 RID: 123009 RVA: 0x00435954 File Offset: 0x00433B54
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601E082 RID: 123010 RVA: 0x00435964 File Offset: 0x00433B64
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E083 RID: 123011 RVA: 0x004359A4 File Offset: 0x00433BA4
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E084 RID: 123012 RVA: 0x004359BE File Offset: 0x00433BBE
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E085 RID: 123013 RVA: 0x004359DC File Offset: 0x00433BDC
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E086 RID: 123014 RVA: 0x004359F5 File Offset: 0x00433BF5
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E087 RID: 123015 RVA: 0x00435A00 File Offset: 0x00433C00
		public static void AddType(FlatBufferBuilder builder, EFragmentType type)
		{
			builder.AddByte(4, (byte)type, 0);
		}

		// Token: 0x0601E088 RID: 123016 RVA: 0x00435A0B File Offset: 0x00433C0B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(5, id, 0);
		}

		// Token: 0x0601E089 RID: 123017 RVA: 0x00435A16 File Offset: 0x00433C16
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(6, descriptionOffset.Value, 0);
		}

		// Token: 0x0601E08A RID: 123018 RVA: 0x00435A26 File Offset: 0x00433C26
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(7, dungeonId, 0);
		}

		// Token: 0x0601E08B RID: 123019 RVA: 0x00435A31 File Offset: 0x00433C31
		public static void AddAutoUnbind(FlatBufferBuilder builder, bool autoUnbind)
		{
			builder.AddBool(8, autoUnbind, false);
		}

		// Token: 0x0601E08C RID: 123020 RVA: 0x00435A3C File Offset: 0x00433C3C
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(9, treeOffset.Value, 0);
		}

		// Token: 0x0601E08D RID: 123021 RVA: 0x00435A4D File Offset: 0x00433C4D
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(10, _IsSelectBt, false);
		}

		// Token: 0x0601E08E RID: 123022 RVA: 0x00435A59 File Offset: 0x00433C59
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(11, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x0601E08F RID: 123023 RVA: 0x00435A6C File Offset: 0x00433C6C
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E090 RID: 123024 RVA: 0x00435AAC File Offset: 0x00433CAC
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E091 RID: 123025 RVA: 0x00435AC6 File Offset: 0x00433CC6
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E092 RID: 123026 RVA: 0x00435AE4 File Offset: 0x00433CE4
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E093 RID: 123027 RVA: 0x00435AFD File Offset: 0x00433CFD
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E094 RID: 123028 RVA: 0x00435B08 File Offset: 0x00433D08
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(12, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x0601E095 RID: 123029 RVA: 0x00435B19 File Offset: 0x00433D19
		public static void Add_RemovedPlaceholders(FlatBufferBuilder builder, VectorOffset _RemovedPlaceholdersOffset)
		{
			builder.AddOffset(13, _RemovedPlaceholdersOffset.Value, 0);
		}

		// Token: 0x0601E096 RID: 123030 RVA: 0x00435B2C File Offset: 0x00433D2C
		public static VectorOffset Create_RemovedPlaceholdersVector(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E097 RID: 123031 RVA: 0x00435B6C File Offset: 0x00433D6C
		public static VectorOffset Create_RemovedPlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E098 RID: 123032 RVA: 0x00435B86 File Offset: 0x00433D86
		public static VectorOffset Create_RemovedPlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E099 RID: 123033 RVA: 0x00435BA4 File Offset: 0x00433DA4
		public static VectorOffset Create_RemovedPlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E09A RID: 123034 RVA: 0x00435BBD File Offset: 0x00433DBD
		public static void Start_RemovedPlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E09B RID: 123035 RVA: 0x00435BC8 File Offset: 0x00433DC8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x0601E09C RID: 123036 RVA: 0x00435BD4 File Offset: 0x00433DD4
		public static Offset<IBehaviorTreeFragment> EndIBehaviorTreeFragment(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorTreeFragment>(builder.EndTable());
		}

		// Token: 0x0601E09D RID: 123037 RVA: 0x00435BE4 File Offset: 0x00433DE4
		public IBehaviorTreeFragmentT UnPack()
		{
			IBehaviorTreeFragmentT behaviorTreeFragmentT = new IBehaviorTreeFragmentT();
			this.UnPackTo(behaviorTreeFragmentT);
			return behaviorTreeFragmentT;
		}

		// Token: 0x0601E09E RID: 123038 RVA: 0x00435C00 File Offset: 0x00433E00
		public void UnPackTo(IBehaviorTreeFragmentT _o)
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
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Description = this.Description;
			_o.DungeonId = this.DungeonId;
			_o.AutoUnbind = this.AutoUnbind;
			_o.Tree = ((this.Tree != null) ? this.Tree.Value.UnPack() : null);
			_o._IsSelectBt = this._IsSelectBt;
			_o._HighlightDataPaths = new List<string>();
			for (int l = 0; l < this._HighlightDataPathsLength; l++)
			{
				_o._HighlightDataPaths.Add(this._HighlightDataPaths(l));
			}
			_o._FocusDataPath = this._FocusDataPath;
			_o._RemovedPlaceholders = new List<IPlaceholderT>();
			for (int m = 0; m < this._RemovedPlaceholdersLength; m++)
			{
				_o._RemovedPlaceholders.Add((this._RemovedPlaceholders(m) != null) ? this._RemovedPlaceholders(m).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E09F RID: 123039 RVA: 0x00435DC4 File Offset: 0x00433FC4
		public static Offset<IBehaviorTreeFragment> Pack(FlatBufferBuilder builder, IBehaviorTreeFragmentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehaviorTreeFragment>);
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
				childrenOffset = IBehaviorTreeFragment.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IBehaviorTreeFragment.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IBehaviorTreeFragment.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset descriptionOffset = (_o.Description == null) ? default(StringOffset) : builder.CreateString(_o.Description);
			Offset<IBehaviorTree> treeOffset = (_o.Tree == null) ? default(Offset<IBehaviorTree>) : IBehaviorTree.Pack(builder, _o.Tree);
			VectorOffset highlightDataPathsOffset = default(VectorOffset);
			if (_o._HighlightDataPaths != null)
			{
				StringOffset[] array4 = new StringOffset[_o._HighlightDataPaths.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = builder.CreateString(_o._HighlightDataPaths[l]);
				}
				highlightDataPathsOffset = IBehaviorTreeFragment.Create_HighlightDataPathsVector(builder, array4);
			}
			StringOffset focusDataPathOffset = (_o._FocusDataPath == null) ? default(StringOffset) : builder.CreateString(_o._FocusDataPath);
			VectorOffset removedPlaceholdersOffset = default(VectorOffset);
			if (_o._RemovedPlaceholders != null)
			{
				Offset<IPlaceholder>[] array5 = new Offset<IPlaceholder>[_o._RemovedPlaceholders.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = IPlaceholder.Pack(builder, _o._RemovedPlaceholders[m]);
				}
				removedPlaceholdersOffset = IBehaviorTreeFragment.Create_RemovedPlaceholdersVector(builder, array5);
			}
			return IBehaviorTreeFragment.CreateIBehaviorTreeFragment(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, _o.Type, _o.Id, descriptionOffset, _o.DungeonId, _o.AutoUnbind, treeOffset, _o._IsSelectBt, highlightDataPathsOffset, focusDataPathOffset, removedPlaceholdersOffset, _o.NullMask);
		}

		// Token: 0x0400D77A RID: 55162
		private Table __p;
	}
}
