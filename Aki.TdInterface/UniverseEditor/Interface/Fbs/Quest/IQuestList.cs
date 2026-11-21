using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200442D RID: 17453
	public struct IQuestList : IFlatbufferObject
	{
		// Token: 0x170078D5 RID: 30933
		// (get) Token: 0x06018F78 RID: 102264 RVA: 0x0038F622 File Offset: 0x0038D822
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F79 RID: 102265 RVA: 0x0038F62F File Offset: 0x0038D82F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F7A RID: 102266 RVA: 0x0038F638 File Offset: 0x0038D838
		public static IQuestList GetRootAsIQuestList(ByteBuffer _bb)
		{
			return IQuestList.GetRootAsIQuestList(_bb, default(IQuestList));
		}

		// Token: 0x06018F7B RID: 102267 RVA: 0x0038F654 File Offset: 0x0038D854
		public static IQuestList GetRootAsIQuestList(ByteBuffer _bb, IQuestList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F7C RID: 102268 RVA: 0x0038F671 File Offset: 0x0038D871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F7D RID: 102269 RVA: 0x0038F680 File Offset: 0x0038D880
		public IQuestList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018F7E RID: 102270 RVA: 0x0038F690 File Offset: 0x0038D890
		public IQuest? Quests(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IQuest?(default(IQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170078D6 RID: 30934
		// (get) Token: 0x06018F7F RID: 102271 RVA: 0x0038F6F0 File Offset: 0x0038D8F0
		public int QuestsLength
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

		// Token: 0x170078D7 RID: 30935
		// (get) Token: 0x06018F80 RID: 102272 RVA: 0x0038F71C File Offset: 0x0038D91C
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

		// Token: 0x170078D8 RID: 30936
		// (get) Token: 0x06018F81 RID: 102273 RVA: 0x0038F758 File Offset: 0x0038D958
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06018F82 RID: 102274 RVA: 0x0038F798 File Offset: 0x0038D998
		public ISyncBlockGroup? _SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170078D9 RID: 30937
		// (get) Token: 0x06018F83 RID: 102275 RVA: 0x0038F7FC File Offset: 0x0038D9FC
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

		// Token: 0x170078DA RID: 30938
		// (get) Token: 0x06018F84 RID: 102276 RVA: 0x0038F828 File Offset: 0x0038DA28
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

		// Token: 0x06018F85 RID: 102277 RVA: 0x0038F865 File Offset: 0x0038DA65
		public static Offset<IQuestList> CreateIQuestList(FlatBufferBuilder builder, VectorOffset QuestsOffset = default(VectorOffset), int _selected = 0, bool _isSelectBt = false, VectorOffset _syncBlockGroupsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IQuestList.Add_SyncBlockGroups(builder, _syncBlockGroupsOffset);
			IQuestList.Add_Selected(builder, _selected);
			IQuestList.AddQuests(builder, QuestsOffset);
			IQuestList.AddNullMask(builder, NullMask);
			IQuestList.Add_IsSelectBt(builder, _isSelectBt);
			return IQuestList.EndIQuestList(builder);
		}

		// Token: 0x06018F86 RID: 102278 RVA: 0x0038F899 File Offset: 0x0038DA99
		public static void StartIQuestList(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06018F87 RID: 102279 RVA: 0x0038F8A2 File Offset: 0x0038DAA2
		public static void AddQuests(FlatBufferBuilder builder, VectorOffset questsOffset)
		{
			builder.AddOffset(0, questsOffset.Value, 0);
		}

		// Token: 0x06018F88 RID: 102280 RVA: 0x0038F8B4 File Offset: 0x0038DAB4
		public static VectorOffset CreateQuestsVector(FlatBufferBuilder builder, Offset<IQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018F89 RID: 102281 RVA: 0x0038F8F4 File Offset: 0x0038DAF4
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, Offset<IQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F8A RID: 102282 RVA: 0x0038F90E File Offset: 0x0038DB0E
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F8B RID: 102283 RVA: 0x0038F92C File Offset: 0x0038DB2C
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018F8C RID: 102284 RVA: 0x0038F945 File Offset: 0x0038DB45
		public static void StartQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018F8D RID: 102285 RVA: 0x0038F950 File Offset: 0x0038DB50
		public static void Add_Selected(FlatBufferBuilder builder, int _Selected)
		{
			builder.AddInt(1, _Selected, 0);
		}

		// Token: 0x06018F8E RID: 102286 RVA: 0x0038F95B File Offset: 0x0038DB5B
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(2, _IsSelectBt, false);
		}

		// Token: 0x06018F8F RID: 102287 RVA: 0x0038F966 File Offset: 0x0038DB66
		public static void Add_SyncBlockGroups(FlatBufferBuilder builder, VectorOffset _SyncBlockGroupsOffset)
		{
			builder.AddOffset(3, _SyncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x06018F90 RID: 102288 RVA: 0x0038F978 File Offset: 0x0038DB78
		public static VectorOffset Create_SyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018F91 RID: 102289 RVA: 0x0038F9B8 File Offset: 0x0038DBB8
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F92 RID: 102290 RVA: 0x0038F9D2 File Offset: 0x0038DBD2
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F93 RID: 102291 RVA: 0x0038F9F0 File Offset: 0x0038DBF0
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018F94 RID: 102292 RVA: 0x0038FA09 File Offset: 0x0038DC09
		public static void Start_SyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018F95 RID: 102293 RVA: 0x0038FA14 File Offset: 0x0038DC14
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06018F96 RID: 102294 RVA: 0x0038FA1F File Offset: 0x0038DC1F
		public static Offset<IQuestList> EndIQuestList(FlatBufferBuilder builder)
		{
			return new Offset<IQuestList>(builder.EndTable());
		}

		// Token: 0x06018F97 RID: 102295 RVA: 0x0038FA2C File Offset: 0x0038DC2C
		public IQuestListT UnPack()
		{
			IQuestListT questListT = new IQuestListT();
			this.UnPackTo(questListT);
			return questListT;
		}

		// Token: 0x06018F98 RID: 102296 RVA: 0x0038FA48 File Offset: 0x0038DC48
		public void UnPackTo(IQuestListT _o)
		{
			_o.Quests = new List<IQuestT>();
			for (int i = 0; i < this.QuestsLength; i++)
			{
				_o.Quests.Add((this.Quests(i) != null) ? this.Quests(i).Value.UnPack() : null);
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

		// Token: 0x06018F99 RID: 102297 RVA: 0x0038FB20 File Offset: 0x0038DD20
		public static Offset<IQuestList> Pack(FlatBufferBuilder builder, IQuestListT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestList>);
			}
			VectorOffset questsOffset = default(VectorOffset);
			if (_o.Quests != null)
			{
				Offset<IQuest>[] array = new Offset<IQuest>[_o.Quests.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IQuest.Pack(builder, _o.Quests[i]);
				}
				questsOffset = IQuestList.CreateQuestsVector(builder, array);
			}
			VectorOffset syncBlockGroupsOffset = default(VectorOffset);
			if (_o._SyncBlockGroups != null)
			{
				Offset<ISyncBlockGroup>[] array2 = new Offset<ISyncBlockGroup>[_o._SyncBlockGroups.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ISyncBlockGroup.Pack(builder, _o._SyncBlockGroups[j]);
				}
				syncBlockGroupsOffset = IQuestList.Create_SyncBlockGroupsVector(builder, array2);
			}
			return IQuestList.CreateIQuestList(builder, questsOffset, _o._Selected, _o._IsSelectBt, syncBlockGroupsOffset, _o.NullMask);
		}

		// Token: 0x0400C4D2 RID: 50386
		private Table __p;
	}
}
