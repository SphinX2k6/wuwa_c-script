using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004503 RID: 17667
	public struct ILevelPlayList : IFlatbufferObject
	{
		// Token: 0x17007D3B RID: 32059
		// (get) Token: 0x0601A881 RID: 108673 RVA: 0x003C9F8A File Offset: 0x003C818A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A882 RID: 108674 RVA: 0x003C9F97 File Offset: 0x003C8197
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A883 RID: 108675 RVA: 0x003C9FA0 File Offset: 0x003C81A0
		public static ILevelPlayList GetRootAsILevelPlayList(ByteBuffer _bb)
		{
			return ILevelPlayList.GetRootAsILevelPlayList(_bb, default(ILevelPlayList));
		}

		// Token: 0x0601A884 RID: 108676 RVA: 0x003C9FBC File Offset: 0x003C81BC
		public static ILevelPlayList GetRootAsILevelPlayList(ByteBuffer _bb, ILevelPlayList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A885 RID: 108677 RVA: 0x003C9FD9 File Offset: 0x003C81D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A886 RID: 108678 RVA: 0x003C9FE8 File Offset: 0x003C81E8
		public ILevelPlayList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A887 RID: 108679 RVA: 0x003C9FF8 File Offset: 0x003C81F8
		public ILevelPlay? LevelPlays(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ILevelPlay?(default(ILevelPlay).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007D3C RID: 32060
		// (get) Token: 0x0601A888 RID: 108680 RVA: 0x003CA058 File Offset: 0x003C8258
		public int LevelPlaysLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007D3D RID: 32061
		// (get) Token: 0x0601A889 RID: 108681 RVA: 0x003CA084 File Offset: 0x003C8284
		public int _Selected
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007D3E RID: 32062
		// (get) Token: 0x0601A88A RID: 108682 RVA: 0x003CA0C0 File Offset: 0x003C82C0
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601A88B RID: 108683 RVA: 0x003CA100 File Offset: 0x003C8300
		public ISyncBlockGroup? _SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007D3F RID: 32063
		// (get) Token: 0x0601A88C RID: 108684 RVA: 0x003CA164 File Offset: 0x003C8364
		public int _SyncBlockGroupsLength
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

		// Token: 0x17007D40 RID: 32064
		// (get) Token: 0x0601A88D RID: 108685 RVA: 0x003CA190 File Offset: 0x003C8390
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A88E RID: 108686 RVA: 0x003CA1CD File Offset: 0x003C83CD
		public static Offset<ILevelPlayList> CreateILevelPlayList(FlatBufferBuilder builder, VectorOffset LevelPlaysOffset = default(VectorOffset), int _selected = 0, bool _isSelectBt = false, VectorOffset _syncBlockGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ILevelPlayList.Add_SyncBlockGroups(builder, _syncBlockGroupsOffset);
			ILevelPlayList.Add_Selected(builder, _selected);
			ILevelPlayList.AddLevelPlays(builder, LevelPlaysOffset);
			ILevelPlayList.AddNullMask(builder, NullMask);
			ILevelPlayList.Add_IsSelectBt(builder, _isSelectBt);
			return ILevelPlayList.EndILevelPlayList(builder);
		}

		// Token: 0x0601A88F RID: 108687 RVA: 0x003CA201 File Offset: 0x003C8401
		public static void StartILevelPlayList(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601A890 RID: 108688 RVA: 0x003CA20A File Offset: 0x003C840A
		public static void AddLevelPlays(FlatBufferBuilder builder, VectorOffset levelPlaysOffset)
		{
			builder.AddOffset(0, levelPlaysOffset.Value, 0);
		}

		// Token: 0x0601A891 RID: 108689 RVA: 0x003CA21C File Offset: 0x003C841C
		public static VectorOffset CreateLevelPlaysVector(FlatBufferBuilder builder, Offset<ILevelPlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A892 RID: 108690 RVA: 0x003CA25C File Offset: 0x003C845C
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, Offset<ILevelPlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelPlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A893 RID: 108691 RVA: 0x003CA276 File Offset: 0x003C8476
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelPlay>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelPlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A894 RID: 108692 RVA: 0x003CA294 File Offset: 0x003C8494
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelPlay>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A895 RID: 108693 RVA: 0x003CA2AD File Offset: 0x003C84AD
		public static void StartLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A896 RID: 108694 RVA: 0x003CA2B8 File Offset: 0x003C84B8
		public static void Add_Selected(FlatBufferBuilder builder, int _Selected)
		{
			builder.AddInt(1, _Selected, 0);
		}

		// Token: 0x0601A897 RID: 108695 RVA: 0x003CA2C3 File Offset: 0x003C84C3
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(2, _IsSelectBt, false);
		}

		// Token: 0x0601A898 RID: 108696 RVA: 0x003CA2CE File Offset: 0x003C84CE
		public static void Add_SyncBlockGroups(FlatBufferBuilder builder, VectorOffset _SyncBlockGroupsOffset)
		{
			builder.AddOffset(3, _SyncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601A899 RID: 108697 RVA: 0x003CA2E0 File Offset: 0x003C84E0
		public static VectorOffset Create_SyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A89A RID: 108698 RVA: 0x003CA320 File Offset: 0x003C8520
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A89B RID: 108699 RVA: 0x003CA33A File Offset: 0x003C853A
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A89C RID: 108700 RVA: 0x003CA358 File Offset: 0x003C8558
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A89D RID: 108701 RVA: 0x003CA371 File Offset: 0x003C8571
		public static void Start_SyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A89E RID: 108702 RVA: 0x003CA37C File Offset: 0x003C857C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601A89F RID: 108703 RVA: 0x003CA387 File Offset: 0x003C8587
		public static Offset<ILevelPlayList> EndILevelPlayList(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayList>(builder.EndTable());
		}

		// Token: 0x0601A8A0 RID: 108704 RVA: 0x003CA394 File Offset: 0x003C8594
		public ILevelPlayListT UnPack()
		{
			ILevelPlayListT levelPlayListT = new ILevelPlayListT();
			this.UnPackTo(levelPlayListT);
			return levelPlayListT;
		}

		// Token: 0x0601A8A1 RID: 108705 RVA: 0x003CA3B0 File Offset: 0x003C85B0
		public void UnPackTo(ILevelPlayListT _o)
		{
			_o.LevelPlays = new List<ILevelPlayT>();
			for (int i = 0; i < this.LevelPlaysLength; i++)
			{
				_o.LevelPlays.Add((this.LevelPlays(i) != null) ? this.LevelPlays(i).Value.UnPack() : null);
			}
			_o._Selected = this._Selected;
			_o._IsSelectBt = this._IsSelectBt;
			_o._SyncBlockGroups = new List<ISyncBlockGroupT>();
			for (int j = 0; j < this._SyncBlockGroupsLength; j++)
			{
				_o._SyncBlockGroups.Add((this._SyncBlockGroups(j) != null) ? this._SyncBlockGroups(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A8A2 RID: 108706 RVA: 0x003CA488 File Offset: 0x003C8688
		public static Offset<ILevelPlayList> Pack(FlatBufferBuilder builder, ILevelPlayListT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayList>);
			}
			VectorOffset levelPlaysOffset = default(VectorOffset);
			if (_o.LevelPlays != null)
			{
				Offset<ILevelPlay>[] array = new Offset<ILevelPlay>[_o.LevelPlays.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelPlay.Pack(builder, _o.LevelPlays[i]);
				}
				levelPlaysOffset = ILevelPlayList.CreateLevelPlaysVector(builder, array);
			}
			VectorOffset syncBlockGroupsOffset = default(VectorOffset);
			if (_o._SyncBlockGroups != null)
			{
				Offset<ISyncBlockGroup>[] array2 = new Offset<ISyncBlockGroup>[_o._SyncBlockGroups.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ISyncBlockGroup.Pack(builder, _o._SyncBlockGroups[j]);
				}
				syncBlockGroupsOffset = ILevelPlayList.Create_SyncBlockGroupsVector(builder, array2);
			}
			return ILevelPlayList.CreateILevelPlayList(builder, levelPlaysOffset, _o._Selected, _o._IsSelectBt, syncBlockGroupsOffset, _o.NullMask);
		}

		// Token: 0x0400C569 RID: 50537
		private Table __p;
	}
}
