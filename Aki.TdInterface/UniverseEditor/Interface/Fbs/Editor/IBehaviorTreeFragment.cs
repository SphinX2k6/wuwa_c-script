using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004823 RID: 18467
	public struct IBehaviorTreeFragment : IFlatbufferObject
	{
		// Token: 0x17008476 RID: 33910
		// (get) Token: 0x0601C855 RID: 116821 RVA: 0x0040887E File Offset: 0x00406A7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C856 RID: 116822 RVA: 0x0040888B File Offset: 0x00406A8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C857 RID: 116823 RVA: 0x00408894 File Offset: 0x00406A94
		public static IBehaviorTreeFragment GetRootAsIBehaviorTreeFragment(ByteBuffer _bb)
		{
			return IBehaviorTreeFragment.GetRootAsIBehaviorTreeFragment(_bb, default(IBehaviorTreeFragment));
		}

		// Token: 0x0601C858 RID: 116824 RVA: 0x004088B0 File Offset: 0x00406AB0
		public static IBehaviorTreeFragment GetRootAsIBehaviorTreeFragment(ByteBuffer _bb, IBehaviorTreeFragment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C859 RID: 116825 RVA: 0x004088CD File Offset: 0x00406ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C85A RID: 116826 RVA: 0x004088DC File Offset: 0x00406ADC
		public IBehaviorTreeFragment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008477 RID: 33911
		// (get) Token: 0x0601C85B RID: 116827 RVA: 0x004088EC File Offset: 0x00406AEC
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

		// Token: 0x0601C85C RID: 116828 RVA: 0x00408923 File Offset: 0x00406B23
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C85D RID: 116829 RVA: 0x00408932 File Offset: 0x00406B32
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601C85E RID: 116830 RVA: 0x00408940 File Offset: 0x00406B40
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008478 RID: 33912
		// (get) Token: 0x0601C85F RID: 116831 RVA: 0x0040897C File Offset: 0x00406B7C
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

		// Token: 0x0601C860 RID: 116832 RVA: 0x004089A8 File Offset: 0x00406BA8
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008479 RID: 33913
		// (get) Token: 0x0601C861 RID: 116833 RVA: 0x004089E4 File Offset: 0x00406BE4
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

		// Token: 0x0601C862 RID: 116834 RVA: 0x00408A10 File Offset: 0x00406C10
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700847A RID: 33914
		// (get) Token: 0x0601C863 RID: 116835 RVA: 0x00408A4C File Offset: 0x00406C4C
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

		// Token: 0x1700847B RID: 33915
		// (get) Token: 0x0601C864 RID: 116836 RVA: 0x00408A78 File Offset: 0x00406C78
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

		// Token: 0x1700847C RID: 33916
		// (get) Token: 0x0601C865 RID: 116837 RVA: 0x00408AB8 File Offset: 0x00406CB8
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

		// Token: 0x1700847D RID: 33917
		// (get) Token: 0x0601C866 RID: 116838 RVA: 0x00408AF8 File Offset: 0x00406CF8
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

		// Token: 0x0601C867 RID: 116839 RVA: 0x00408B30 File Offset: 0x00406D30
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601C868 RID: 116840 RVA: 0x00408B40 File Offset: 0x00406D40
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700847E RID: 33918
		// (get) Token: 0x0601C869 RID: 116841 RVA: 0x00408B50 File Offset: 0x00406D50
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

		// Token: 0x1700847F RID: 33919
		// (get) Token: 0x0601C86A RID: 116842 RVA: 0x00408B90 File Offset: 0x00406D90
		public bool AutoUnbind
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008480 RID: 33920
		// (get) Token: 0x0601C86B RID: 116843 RVA: 0x00408BD0 File Offset: 0x00406DD0
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

		// Token: 0x17008481 RID: 33921
		// (get) Token: 0x0601C86C RID: 116844 RVA: 0x00408C30 File Offset: 0x00406E30
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601C86D RID: 116845 RVA: 0x00408C70 File Offset: 0x00406E70
		public string _HighlightDataPaths(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008482 RID: 33922
		// (get) Token: 0x0601C86E RID: 116846 RVA: 0x00408CAC File Offset: 0x00406EAC
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

		// Token: 0x17008483 RID: 33923
		// (get) Token: 0x0601C86F RID: 116847 RVA: 0x00408CD8 File Offset: 0x00406ED8
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

		// Token: 0x0601C870 RID: 116848 RVA: 0x00408D10 File Offset: 0x00406F10
		public Span<byte> Get_FocusDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0601C871 RID: 116849 RVA: 0x00408D20 File Offset: 0x00406F20
		public byte[] Get_FocusDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(28);
		}

		// Token: 0x0601C872 RID: 116850 RVA: 0x00408D30 File Offset: 0x00406F30
		public IPlaceholder? _RemovedPlaceholders(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new IPlaceholder?(default(IPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008484 RID: 33924
		// (get) Token: 0x0601C873 RID: 116851 RVA: 0x00408D94 File Offset: 0x00406F94
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

		// Token: 0x17008485 RID: 33925
		// (get) Token: 0x0601C874 RID: 116852 RVA: 0x00408DC0 File Offset: 0x00406FC0
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

		// Token: 0x0601C875 RID: 116853 RVA: 0x00408E00 File Offset: 0x00407000
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

		// Token: 0x0601C876 RID: 116854 RVA: 0x00408E90 File Offset: 0x00407090
		public static void StartIBehaviorTreeFragment(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x0601C877 RID: 116855 RVA: 0x00408E9A File Offset: 0x0040709A
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601C878 RID: 116856 RVA: 0x00408EAA File Offset: 0x004070AA
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601C879 RID: 116857 RVA: 0x00408EBC File Offset: 0x004070BC
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C87A RID: 116858 RVA: 0x00408EFC File Offset: 0x004070FC
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C87B RID: 116859 RVA: 0x00408F16 File Offset: 0x00407116
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C87C RID: 116860 RVA: 0x00408F34 File Offset: 0x00407134
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C87D RID: 116861 RVA: 0x00408F4D File Offset: 0x0040714D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C87E RID: 116862 RVA: 0x00408F58 File Offset: 0x00407158
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601C87F RID: 116863 RVA: 0x00408F68 File Offset: 0x00407168
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C880 RID: 116864 RVA: 0x00408FA8 File Offset: 0x004071A8
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C881 RID: 116865 RVA: 0x00408FC2 File Offset: 0x004071C2
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C882 RID: 116866 RVA: 0x00408FE0 File Offset: 0x004071E0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C883 RID: 116867 RVA: 0x00408FF9 File Offset: 0x004071F9
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C884 RID: 116868 RVA: 0x00409004 File Offset: 0x00407204
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601C885 RID: 116869 RVA: 0x00409014 File Offset: 0x00407214
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C886 RID: 116870 RVA: 0x00409054 File Offset: 0x00407254
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C887 RID: 116871 RVA: 0x0040906E File Offset: 0x0040726E
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C888 RID: 116872 RVA: 0x0040908C File Offset: 0x0040728C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C889 RID: 116873 RVA: 0x004090A5 File Offset: 0x004072A5
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C88A RID: 116874 RVA: 0x004090B0 File Offset: 0x004072B0
		public static void AddType(FlatBufferBuilder builder, EFragmentType type)
		{
			builder.AddByte(4, (byte)type, 0);
		}

		// Token: 0x0601C88B RID: 116875 RVA: 0x004090BB File Offset: 0x004072BB
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(5, id, 0);
		}

		// Token: 0x0601C88C RID: 116876 RVA: 0x004090C6 File Offset: 0x004072C6
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(6, descriptionOffset.Value, 0);
		}

		// Token: 0x0601C88D RID: 116877 RVA: 0x004090D6 File Offset: 0x004072D6
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(7, dungeonId, 0);
		}

		// Token: 0x0601C88E RID: 116878 RVA: 0x004090E1 File Offset: 0x004072E1
		public static void AddAutoUnbind(FlatBufferBuilder builder, bool autoUnbind)
		{
			builder.AddBool(8, autoUnbind, false);
		}

		// Token: 0x0601C88F RID: 116879 RVA: 0x004090EC File Offset: 0x004072EC
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(9, treeOffset.Value, 0);
		}

		// Token: 0x0601C890 RID: 116880 RVA: 0x004090FD File Offset: 0x004072FD
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(10, _IsSelectBt, false);
		}

		// Token: 0x0601C891 RID: 116881 RVA: 0x00409109 File Offset: 0x00407309
		public static void Add_HighlightDataPaths(FlatBufferBuilder builder, VectorOffset _HighlightDataPathsOffset)
		{
			builder.AddOffset(11, _HighlightDataPathsOffset.Value, 0);
		}

		// Token: 0x0601C892 RID: 116882 RVA: 0x0040911C File Offset: 0x0040731C
		public static VectorOffset Create_HighlightDataPathsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C893 RID: 116883 RVA: 0x0040915C File Offset: 0x0040735C
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C894 RID: 116884 RVA: 0x00409176 File Offset: 0x00407376
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C895 RID: 116885 RVA: 0x00409194 File Offset: 0x00407394
		public static VectorOffset Create_HighlightDataPathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C896 RID: 116886 RVA: 0x004091AD File Offset: 0x004073AD
		public static void Start_HighlightDataPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C897 RID: 116887 RVA: 0x004091B8 File Offset: 0x004073B8
		public static void Add_FocusDataPath(FlatBufferBuilder builder, StringOffset _FocusDataPathOffset)
		{
			builder.AddOffset(12, _FocusDataPathOffset.Value, 0);
		}

		// Token: 0x0601C898 RID: 116888 RVA: 0x004091C9 File Offset: 0x004073C9
		public static void Add_RemovedPlaceholders(FlatBufferBuilder builder, VectorOffset _RemovedPlaceholdersOffset)
		{
			builder.AddOffset(13, _RemovedPlaceholdersOffset.Value, 0);
		}

		// Token: 0x0601C899 RID: 116889 RVA: 0x004091DC File Offset: 0x004073DC
		public static VectorOffset Create_RemovedPlaceholdersVector(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C89A RID: 116890 RVA: 0x0040921C File Offset: 0x0040741C
		public static VectorOffset Create_RemovedPlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<IPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C89B RID: 116891 RVA: 0x00409236 File Offset: 0x00407436
		public static VectorOffset Create_RemovedPlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C89C RID: 116892 RVA: 0x00409254 File Offset: 0x00407454
		public static VectorOffset Create_RemovedPlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C89D RID: 116893 RVA: 0x0040926D File Offset: 0x0040746D
		public static void Start_RemovedPlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C89E RID: 116894 RVA: 0x00409278 File Offset: 0x00407478
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x0601C89F RID: 116895 RVA: 0x00409284 File Offset: 0x00407484
		public static Offset<IBehaviorTreeFragment> EndIBehaviorTreeFragment(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorTreeFragment>(builder.EndTable());
		}

		// Token: 0x0601C8A0 RID: 116896 RVA: 0x00409294 File Offset: 0x00407494
		public IBehaviorTreeFragmentT UnPack()
		{
			IBehaviorTreeFragmentT behaviorTreeFragmentT = new IBehaviorTreeFragmentT();
			this.UnPackTo(behaviorTreeFragmentT);
			return behaviorTreeFragmentT;
		}

		// Token: 0x0601C8A1 RID: 116897 RVA: 0x004092B0 File Offset: 0x004074B0
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

		// Token: 0x0601C8A2 RID: 116898 RVA: 0x00409474 File Offset: 0x00407674
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

		// Token: 0x0400CD3F RID: 52543
		private Table __p;
	}
}
