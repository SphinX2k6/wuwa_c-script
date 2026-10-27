using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414B RID: 16715
	public struct ISubBehaviorTreeFile : IFlatbufferObject
	{
		// Token: 0x1700766A RID: 30314
		// (get) Token: 0x06018882 RID: 100482 RVA: 0x00389487 File Offset: 0x00387687
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018883 RID: 100483 RVA: 0x00389494 File Offset: 0x00387694
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018884 RID: 100484 RVA: 0x0038949C File Offset: 0x0038769C
		public static ISubBehaviorTreeFile GetRootAsISubBehaviorTreeFile(ByteBuffer _bb)
		{
			return ISubBehaviorTreeFile.GetRootAsISubBehaviorTreeFile(_bb, default(ISubBehaviorTreeFile));
		}

		// Token: 0x06018885 RID: 100485 RVA: 0x003894B8 File Offset: 0x003876B8
		public static ISubBehaviorTreeFile GetRootAsISubBehaviorTreeFile(ByteBuffer _bb, ISubBehaviorTreeFile obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018886 RID: 100486 RVA: 0x003894D5 File Offset: 0x003876D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018887 RID: 100487 RVA: 0x003894E4 File Offset: 0x003876E4
		public ISubBehaviorTreeFile __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700766B RID: 30315
		// (get) Token: 0x06018888 RID: 100488 RVA: 0x003894F4 File Offset: 0x003876F4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700766C RID: 30316
		// (get) Token: 0x06018889 RID: 100489 RVA: 0x00389530 File Offset: 0x00387730
		public string ParentUid
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601888A RID: 100490 RVA: 0x00389567 File Offset: 0x00387767
		public Span<byte> GetParentUidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601888B RID: 100491 RVA: 0x00389576 File Offset: 0x00387776
		public byte[] GetParentUidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700766D RID: 30317
		// (get) Token: 0x0601888C RID: 100492 RVA: 0x00389584 File Offset: 0x00387784
		public IBehaviorTree? Tree
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IBehaviorTree?(default(IBehaviorTree).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601888D RID: 100493 RVA: 0x003895E4 File Offset: 0x003877E4
		public string Children(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700766E RID: 30318
		// (get) Token: 0x0601888E RID: 100494 RVA: 0x00389620 File Offset: 0x00387820
		public int ChildrenLength
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

		// Token: 0x0601888F RID: 100495 RVA: 0x0038964C File Offset: 0x0038784C
		public string Reference(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700766F RID: 30319
		// (get) Token: 0x06018890 RID: 100496 RVA: 0x00389688 File Offset: 0x00387888
		public int ReferenceLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018891 RID: 100497 RVA: 0x003896B4 File Offset: 0x003878B4
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007670 RID: 30320
		// (get) Token: 0x06018892 RID: 100498 RVA: 0x003896F0 File Offset: 0x003878F0
		public int WeakReferenceLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007671 RID: 30321
		// (get) Token: 0x06018893 RID: 100499 RVA: 0x0038971C File Offset: 0x0038791C
		public string _Name
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

		// Token: 0x06018894 RID: 100500 RVA: 0x00389754 File Offset: 0x00387954
		public Span<byte> Get_NameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06018895 RID: 100501 RVA: 0x00389764 File Offset: 0x00387964
		public byte[] Get_NameArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17007672 RID: 30322
		// (get) Token: 0x06018896 RID: 100502 RVA: 0x00389774 File Offset: 0x00387974
		public string _Path
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

		// Token: 0x06018897 RID: 100503 RVA: 0x003897AC File Offset: 0x003879AC
		public Span<byte> Get_PathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06018898 RID: 100504 RVA: 0x003897BC File Offset: 0x003879BC
		public byte[] Get_PathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17007673 RID: 30323
		// (get) Token: 0x06018899 RID: 100505 RVA: 0x003897CC File Offset: 0x003879CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601889A RID: 100506 RVA: 0x0038980C File Offset: 0x00387A0C
		public static Offset<ISubBehaviorTreeFile> CreateISubBehaviorTreeFile(FlatBufferBuilder builder, int Id = 0, StringOffset ParentUidOffset = default(StringOffset), Offset<IBehaviorTree> TreeOffset = default(Offset<IBehaviorTree>), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), StringOffset _nameOffset = default(StringOffset), StringOffset _pathOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			ISubBehaviorTreeFile.Add_Path(builder, _pathOffset);
			ISubBehaviorTreeFile.Add_Name(builder, _nameOffset);
			ISubBehaviorTreeFile.AddWeakReference(builder, WeakReferenceOffset);
			ISubBehaviorTreeFile.AddReference(builder, ReferenceOffset);
			ISubBehaviorTreeFile.AddChildren(builder, ChildrenOffset);
			ISubBehaviorTreeFile.AddTree(builder, TreeOffset);
			ISubBehaviorTreeFile.AddParentUid(builder, ParentUidOffset);
			ISubBehaviorTreeFile.AddId(builder, Id);
			ISubBehaviorTreeFile.AddNullMask(builder, NullMask);
			return ISubBehaviorTreeFile.EndISubBehaviorTreeFile(builder);
		}

		// Token: 0x0601889B RID: 100507 RVA: 0x0038986C File Offset: 0x00387A6C
		public static void StartISubBehaviorTreeFile(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601889C RID: 100508 RVA: 0x00389876 File Offset: 0x00387A76
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601889D RID: 100509 RVA: 0x00389881 File Offset: 0x00387A81
		public static void AddParentUid(FlatBufferBuilder builder, StringOffset parentUidOffset)
		{
			builder.AddOffset(1, parentUidOffset.Value, 0);
		}

		// Token: 0x0601889E RID: 100510 RVA: 0x00389891 File Offset: 0x00387A91
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(2, treeOffset.Value, 0);
		}

		// Token: 0x0601889F RID: 100511 RVA: 0x003898A1 File Offset: 0x00387AA1
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(3, childrenOffset.Value, 0);
		}

		// Token: 0x060188A0 RID: 100512 RVA: 0x003898B4 File Offset: 0x00387AB4
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060188A1 RID: 100513 RVA: 0x003898F4 File Offset: 0x00387AF4
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188A2 RID: 100514 RVA: 0x0038990E File Offset: 0x00387B0E
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188A3 RID: 100515 RVA: 0x0038992C File Offset: 0x00387B2C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060188A4 RID: 100516 RVA: 0x00389945 File Offset: 0x00387B45
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060188A5 RID: 100517 RVA: 0x00389950 File Offset: 0x00387B50
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(4, referenceOffset.Value, 0);
		}

		// Token: 0x060188A6 RID: 100518 RVA: 0x00389960 File Offset: 0x00387B60
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060188A7 RID: 100519 RVA: 0x003899A0 File Offset: 0x00387BA0
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188A8 RID: 100520 RVA: 0x003899BA File Offset: 0x00387BBA
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188A9 RID: 100521 RVA: 0x003899D8 File Offset: 0x00387BD8
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060188AA RID: 100522 RVA: 0x003899F1 File Offset: 0x00387BF1
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060188AB RID: 100523 RVA: 0x003899FC File Offset: 0x00387BFC
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(5, weakReferenceOffset.Value, 0);
		}

		// Token: 0x060188AC RID: 100524 RVA: 0x00389A0C File Offset: 0x00387C0C
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060188AD RID: 100525 RVA: 0x00389A4C File Offset: 0x00387C4C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188AE RID: 100526 RVA: 0x00389A66 File Offset: 0x00387C66
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060188AF RID: 100527 RVA: 0x00389A84 File Offset: 0x00387C84
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060188B0 RID: 100528 RVA: 0x00389A9D File Offset: 0x00387C9D
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060188B1 RID: 100529 RVA: 0x00389AA8 File Offset: 0x00387CA8
		public static void Add_Name(FlatBufferBuilder builder, StringOffset _NameOffset)
		{
			builder.AddOffset(6, _NameOffset.Value, 0);
		}

		// Token: 0x060188B2 RID: 100530 RVA: 0x00389AB8 File Offset: 0x00387CB8
		public static void Add_Path(FlatBufferBuilder builder, StringOffset _PathOffset)
		{
			builder.AddOffset(7, _PathOffset.Value, 0);
		}

		// Token: 0x060188B3 RID: 100531 RVA: 0x00389AC8 File Offset: 0x00387CC8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060188B4 RID: 100532 RVA: 0x00389AD3 File Offset: 0x00387CD3
		public static Offset<ISubBehaviorTreeFile> EndISubBehaviorTreeFile(FlatBufferBuilder builder)
		{
			return new Offset<ISubBehaviorTreeFile>(builder.EndTable());
		}

		// Token: 0x060188B5 RID: 100533 RVA: 0x00389AE0 File Offset: 0x00387CE0
		public ISubBehaviorTreeFileT UnPack()
		{
			ISubBehaviorTreeFileT subBehaviorTreeFileT = new ISubBehaviorTreeFileT();
			this.UnPackTo(subBehaviorTreeFileT);
			return subBehaviorTreeFileT;
		}

		// Token: 0x060188B6 RID: 100534 RVA: 0x00389AFC File Offset: 0x00387CFC
		public void UnPackTo(ISubBehaviorTreeFileT _o)
		{
			_o.Id = this.Id;
			_o.ParentUid = this.ParentUid;
			_o.Tree = ((this.Tree != null) ? this.Tree.Value.UnPack() : null);
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
			_o._Name = this._Name;
			_o._Path = this._Path;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060188B7 RID: 100535 RVA: 0x00389C04 File Offset: 0x00387E04
		public static Offset<ISubBehaviorTreeFile> Pack(FlatBufferBuilder builder, ISubBehaviorTreeFileT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubBehaviorTreeFile>);
			}
			StringOffset parentUidOffset = (_o.ParentUid == null) ? default(StringOffset) : builder.CreateString(_o.ParentUid);
			Offset<IBehaviorTree> treeOffset = (_o.Tree == null) ? default(Offset<IBehaviorTree>) : IBehaviorTree.Pack(builder, _o.Tree);
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				StringOffset[] array = new StringOffset[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Children[i]);
				}
				childrenOffset = ISubBehaviorTreeFile.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = ISubBehaviorTreeFile.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = ISubBehaviorTreeFile.CreateWeakReferenceVector(builder, array3);
			}
			StringOffset nameOffset = (_o._Name == null) ? default(StringOffset) : builder.CreateString(_o._Name);
			StringOffset pathOffset = (_o._Path == null) ? default(StringOffset) : builder.CreateString(_o._Path);
			return ISubBehaviorTreeFile.CreateISubBehaviorTreeFile(builder, _o.Id, parentUidOffset, treeOffset, childrenOffset, referenceOffset, weakReferenceOffset, nameOffset, pathOffset, _o.NullMask);
		}

		// Token: 0x0400BD5D RID: 48477
		private Table __p;
	}
}
