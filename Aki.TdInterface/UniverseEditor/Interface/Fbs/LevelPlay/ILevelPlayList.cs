using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200496B RID: 18795
	public struct ILevelPlayList : IFlatbufferObject
	{
		// Token: 0x1700837C RID: 33660
		// (get) Token: 0x0601C056 RID: 114774 RVA: 0x003F6226 File Offset: 0x003F4426
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C057 RID: 114775 RVA: 0x003F6233 File Offset: 0x003F4433
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C058 RID: 114776 RVA: 0x003F623C File Offset: 0x003F443C
		public static ILevelPlayList GetRootAsILevelPlayList(ByteBuffer _bb)
		{
			return ILevelPlayList.GetRootAsILevelPlayList(_bb, default(ILevelPlayList));
		}

		// Token: 0x0601C059 RID: 114777 RVA: 0x003F6258 File Offset: 0x003F4458
		public static ILevelPlayList GetRootAsILevelPlayList(ByteBuffer _bb, ILevelPlayList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C05A RID: 114778 RVA: 0x003F6275 File Offset: 0x003F4475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C05B RID: 114779 RVA: 0x003F6284 File Offset: 0x003F4484
		public ILevelPlayList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C05C RID: 114780 RVA: 0x003F6294 File Offset: 0x003F4494
		public ILevelPlay? LevelPlays(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ILevelPlay?(default(ILevelPlay).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700837D RID: 33661
		// (get) Token: 0x0601C05D RID: 114781 RVA: 0x003F62F4 File Offset: 0x003F44F4
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

		// Token: 0x1700837E RID: 33662
		// (get) Token: 0x0601C05E RID: 114782 RVA: 0x003F6320 File Offset: 0x003F4520
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

		// Token: 0x1700837F RID: 33663
		// (get) Token: 0x0601C05F RID: 114783 RVA: 0x003F635C File Offset: 0x003F455C
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601C060 RID: 114784 RVA: 0x003F639C File Offset: 0x003F459C
		public ISyncBlockGroup? _SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008380 RID: 33664
		// (get) Token: 0x0601C061 RID: 114785 RVA: 0x003F6400 File Offset: 0x003F4600
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

		// Token: 0x17008381 RID: 33665
		// (get) Token: 0x0601C062 RID: 114786 RVA: 0x003F642C File Offset: 0x003F462C
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

		// Token: 0x0601C063 RID: 114787 RVA: 0x003F6469 File Offset: 0x003F4669
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

		// Token: 0x0601C064 RID: 114788 RVA: 0x003F649D File Offset: 0x003F469D
		public static void StartILevelPlayList(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C065 RID: 114789 RVA: 0x003F64A6 File Offset: 0x003F46A6
		public static void AddLevelPlays(FlatBufferBuilder builder, VectorOffset levelPlaysOffset)
		{
			builder.AddOffset(0, levelPlaysOffset.Value, 0);
		}

		// Token: 0x0601C066 RID: 114790 RVA: 0x003F64B8 File Offset: 0x003F46B8
		public static VectorOffset CreateLevelPlaysVector(FlatBufferBuilder builder, Offset<ILevelPlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C067 RID: 114791 RVA: 0x003F64F8 File Offset: 0x003F46F8
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, Offset<ILevelPlay>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelPlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C068 RID: 114792 RVA: 0x003F6512 File Offset: 0x003F4712
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelPlay>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelPlay>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C069 RID: 114793 RVA: 0x003F6530 File Offset: 0x003F4730
		public static VectorOffset CreateLevelPlaysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelPlay>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C06A RID: 114794 RVA: 0x003F6549 File Offset: 0x003F4749
		public static void StartLevelPlaysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C06B RID: 114795 RVA: 0x003F6554 File Offset: 0x003F4754
		public static void Add_Selected(FlatBufferBuilder builder, int _Selected)
		{
			builder.AddInt(1, _Selected, 0);
		}

		// Token: 0x0601C06C RID: 114796 RVA: 0x003F655F File Offset: 0x003F475F
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(2, _IsSelectBt, false);
		}

		// Token: 0x0601C06D RID: 114797 RVA: 0x003F656A File Offset: 0x003F476A
		public static void Add_SyncBlockGroups(FlatBufferBuilder builder, VectorOffset _SyncBlockGroupsOffset)
		{
			builder.AddOffset(3, _SyncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x0601C06E RID: 114798 RVA: 0x003F657C File Offset: 0x003F477C
		public static VectorOffset Create_SyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C06F RID: 114799 RVA: 0x003F65BC File Offset: 0x003F47BC
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C070 RID: 114800 RVA: 0x003F65D6 File Offset: 0x003F47D6
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C071 RID: 114801 RVA: 0x003F65F4 File Offset: 0x003F47F4
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C072 RID: 114802 RVA: 0x003F660D File Offset: 0x003F480D
		public static void Start_SyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C073 RID: 114803 RVA: 0x003F6618 File Offset: 0x003F4818
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601C074 RID: 114804 RVA: 0x003F6623 File Offset: 0x003F4823
		public static Offset<ILevelPlayList> EndILevelPlayList(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayList>(builder.EndTable());
		}

		// Token: 0x0601C075 RID: 114805 RVA: 0x003F6630 File Offset: 0x003F4830
		public ILevelPlayListT UnPack()
		{
			ILevelPlayListT levelPlayListT = new ILevelPlayListT();
			this.UnPackTo(levelPlayListT);
			return levelPlayListT;
		}

		// Token: 0x0601C076 RID: 114806 RVA: 0x003F664C File Offset: 0x003F484C
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

		// Token: 0x0601C077 RID: 114807 RVA: 0x003F6724 File Offset: 0x003F4924
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

		// Token: 0x0400CF98 RID: 53144
		private Table __p;
	}
}
