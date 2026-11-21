using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200458F RID: 17807
	public struct ISubBehaviorTreeFile : IFlatbufferObject
	{
		// Token: 0x17007C79 RID: 31865
		// (get) Token: 0x06019F4A RID: 106314 RVA: 0x003B3A43 File Offset: 0x003B1C43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F4B RID: 106315 RVA: 0x003B3A50 File Offset: 0x003B1C50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F4C RID: 106316 RVA: 0x003B3A58 File Offset: 0x003B1C58
		public static ISubBehaviorTreeFile GetRootAsISubBehaviorTreeFile(ByteBuffer _bb)
		{
			return ISubBehaviorTreeFile.GetRootAsISubBehaviorTreeFile(_bb, default(ISubBehaviorTreeFile));
		}

		// Token: 0x06019F4D RID: 106317 RVA: 0x003B3A74 File Offset: 0x003B1C74
		public static ISubBehaviorTreeFile GetRootAsISubBehaviorTreeFile(ByteBuffer _bb, ISubBehaviorTreeFile obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F4E RID: 106318 RVA: 0x003B3A91 File Offset: 0x003B1C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F4F RID: 106319 RVA: 0x003B3AA0 File Offset: 0x003B1CA0
		public ISubBehaviorTreeFile __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C7A RID: 31866
		// (get) Token: 0x06019F50 RID: 106320 RVA: 0x003B3AB0 File Offset: 0x003B1CB0
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

		// Token: 0x17007C7B RID: 31867
		// (get) Token: 0x06019F51 RID: 106321 RVA: 0x003B3AEC File Offset: 0x003B1CEC
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

		// Token: 0x06019F52 RID: 106322 RVA: 0x003B3B23 File Offset: 0x003B1D23
		public Span<byte> GetParentUidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06019F53 RID: 106323 RVA: 0x003B3B32 File Offset: 0x003B1D32
		public byte[] GetParentUidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007C7C RID: 31868
		// (get) Token: 0x06019F54 RID: 106324 RVA: 0x003B3B40 File Offset: 0x003B1D40
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

		// Token: 0x06019F55 RID: 106325 RVA: 0x003B3BA0 File Offset: 0x003B1DA0
		public string Children(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C7D RID: 31869
		// (get) Token: 0x06019F56 RID: 106326 RVA: 0x003B3BDC File Offset: 0x003B1DDC
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

		// Token: 0x06019F57 RID: 106327 RVA: 0x003B3C08 File Offset: 0x003B1E08
		public string Reference(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C7E RID: 31870
		// (get) Token: 0x06019F58 RID: 106328 RVA: 0x003B3C44 File Offset: 0x003B1E44
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

		// Token: 0x06019F59 RID: 106329 RVA: 0x003B3C70 File Offset: 0x003B1E70
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C7F RID: 31871
		// (get) Token: 0x06019F5A RID: 106330 RVA: 0x003B3CAC File Offset: 0x003B1EAC
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

		// Token: 0x17007C80 RID: 31872
		// (get) Token: 0x06019F5B RID: 106331 RVA: 0x003B3CD8 File Offset: 0x003B1ED8
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

		// Token: 0x06019F5C RID: 106332 RVA: 0x003B3D10 File Offset: 0x003B1F10
		public Span<byte> Get_NameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06019F5D RID: 106333 RVA: 0x003B3D20 File Offset: 0x003B1F20
		public byte[] Get_NameArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17007C81 RID: 31873
		// (get) Token: 0x06019F5E RID: 106334 RVA: 0x003B3D30 File Offset: 0x003B1F30
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

		// Token: 0x06019F5F RID: 106335 RVA: 0x003B3D68 File Offset: 0x003B1F68
		public Span<byte> Get_PathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06019F60 RID: 106336 RVA: 0x003B3D78 File Offset: 0x003B1F78
		public byte[] Get_PathArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17007C82 RID: 31874
		// (get) Token: 0x06019F61 RID: 106337 RVA: 0x003B3D88 File Offset: 0x003B1F88
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

		// Token: 0x06019F62 RID: 106338 RVA: 0x003B3DC8 File Offset: 0x003B1FC8
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

		// Token: 0x06019F63 RID: 106339 RVA: 0x003B3E28 File Offset: 0x003B2028
		public static void StartISubBehaviorTreeFile(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06019F64 RID: 106340 RVA: 0x003B3E32 File Offset: 0x003B2032
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06019F65 RID: 106341 RVA: 0x003B3E3D File Offset: 0x003B203D
		public static void AddParentUid(FlatBufferBuilder builder, StringOffset parentUidOffset)
		{
			builder.AddOffset(1, parentUidOffset.Value, 0);
		}

		// Token: 0x06019F66 RID: 106342 RVA: 0x003B3E4D File Offset: 0x003B204D
		public static void AddTree(FlatBufferBuilder builder, Offset<IBehaviorTree> treeOffset)
		{
			builder.AddOffset(2, treeOffset.Value, 0);
		}

		// Token: 0x06019F67 RID: 106343 RVA: 0x003B3E5D File Offset: 0x003B205D
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(3, childrenOffset.Value, 0);
		}

		// Token: 0x06019F68 RID: 106344 RVA: 0x003B3E70 File Offset: 0x003B2070
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F69 RID: 106345 RVA: 0x003B3EB0 File Offset: 0x003B20B0
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F6A RID: 106346 RVA: 0x003B3ECA File Offset: 0x003B20CA
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F6B RID: 106347 RVA: 0x003B3EE8 File Offset: 0x003B20E8
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F6C RID: 106348 RVA: 0x003B3F01 File Offset: 0x003B2101
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F6D RID: 106349 RVA: 0x003B3F0C File Offset: 0x003B210C
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(4, referenceOffset.Value, 0);
		}

		// Token: 0x06019F6E RID: 106350 RVA: 0x003B3F1C File Offset: 0x003B211C
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F6F RID: 106351 RVA: 0x003B3F5C File Offset: 0x003B215C
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F70 RID: 106352 RVA: 0x003B3F76 File Offset: 0x003B2176
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F71 RID: 106353 RVA: 0x003B3F94 File Offset: 0x003B2194
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F72 RID: 106354 RVA: 0x003B3FAD File Offset: 0x003B21AD
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F73 RID: 106355 RVA: 0x003B3FB8 File Offset: 0x003B21B8
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(5, weakReferenceOffset.Value, 0);
		}

		// Token: 0x06019F74 RID: 106356 RVA: 0x003B3FC8 File Offset: 0x003B21C8
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019F75 RID: 106357 RVA: 0x003B4008 File Offset: 0x003B2208
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F76 RID: 106358 RVA: 0x003B4022 File Offset: 0x003B2222
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019F77 RID: 106359 RVA: 0x003B4040 File Offset: 0x003B2240
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019F78 RID: 106360 RVA: 0x003B4059 File Offset: 0x003B2259
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019F79 RID: 106361 RVA: 0x003B4064 File Offset: 0x003B2264
		public static void Add_Name(FlatBufferBuilder builder, StringOffset _NameOffset)
		{
			builder.AddOffset(6, _NameOffset.Value, 0);
		}

		// Token: 0x06019F7A RID: 106362 RVA: 0x003B4074 File Offset: 0x003B2274
		public static void Add_Path(FlatBufferBuilder builder, StringOffset _PathOffset)
		{
			builder.AddOffset(7, _PathOffset.Value, 0);
		}

		// Token: 0x06019F7B RID: 106363 RVA: 0x003B4084 File Offset: 0x003B2284
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06019F7C RID: 106364 RVA: 0x003B408F File Offset: 0x003B228F
		public static Offset<ISubBehaviorTreeFile> EndISubBehaviorTreeFile(FlatBufferBuilder builder)
		{
			return new Offset<ISubBehaviorTreeFile>(builder.EndTable());
		}

		// Token: 0x06019F7D RID: 106365 RVA: 0x003B409C File Offset: 0x003B229C
		public ISubBehaviorTreeFileT UnPack()
		{
			ISubBehaviorTreeFileT subBehaviorTreeFileT = new ISubBehaviorTreeFileT();
			this.UnPackTo(subBehaviorTreeFileT);
			return subBehaviorTreeFileT;
		}

		// Token: 0x06019F7E RID: 106366 RVA: 0x003B40B8 File Offset: 0x003B22B8
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

		// Token: 0x06019F7F RID: 106367 RVA: 0x003B41C0 File Offset: 0x003B23C0
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

		// Token: 0x0400C74B RID: 51019
		private Table __p;
	}
}
