using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FEC RID: 16364
	public struct IQuestList : IFlatbufferObject
	{
		// Token: 0x170072D3 RID: 29395
		// (get) Token: 0x060178DF RID: 96479 RVA: 0x0036582E File Offset: 0x00363A2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060178E0 RID: 96480 RVA: 0x0036583B File Offset: 0x00363A3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060178E1 RID: 96481 RVA: 0x00365844 File Offset: 0x00363A44
		public static IQuestList GetRootAsIQuestList(ByteBuffer _bb)
		{
			return IQuestList.GetRootAsIQuestList(_bb, default(IQuestList));
		}

		// Token: 0x060178E2 RID: 96482 RVA: 0x00365860 File Offset: 0x00363A60
		public static IQuestList GetRootAsIQuestList(ByteBuffer _bb, IQuestList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060178E3 RID: 96483 RVA: 0x0036587D File Offset: 0x00363A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060178E4 RID: 96484 RVA: 0x0036588C File Offset: 0x00363A8C
		public IQuestList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060178E5 RID: 96485 RVA: 0x0036589C File Offset: 0x00363A9C
		public IQuest? Quests(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IQuest?(default(IQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170072D4 RID: 29396
		// (get) Token: 0x060178E6 RID: 96486 RVA: 0x003658FC File Offset: 0x00363AFC
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

		// Token: 0x170072D5 RID: 29397
		// (get) Token: 0x060178E7 RID: 96487 RVA: 0x00365928 File Offset: 0x00363B28
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

		// Token: 0x170072D6 RID: 29398
		// (get) Token: 0x060178E8 RID: 96488 RVA: 0x00365964 File Offset: 0x00363B64
		public bool _IsSelectBt
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060178E9 RID: 96489 RVA: 0x003659A4 File Offset: 0x00363BA4
		public ISyncBlockGroup? _SyncBlockGroups(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlockGroup?(default(ISyncBlockGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170072D7 RID: 29399
		// (get) Token: 0x060178EA RID: 96490 RVA: 0x00365A08 File Offset: 0x00363C08
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

		// Token: 0x170072D8 RID: 29400
		// (get) Token: 0x060178EB RID: 96491 RVA: 0x00365A34 File Offset: 0x00363C34
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

		// Token: 0x060178EC RID: 96492 RVA: 0x00365A71 File Offset: 0x00363C71
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

		// Token: 0x060178ED RID: 96493 RVA: 0x00365AA5 File Offset: 0x00363CA5
		public static void StartIQuestList(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060178EE RID: 96494 RVA: 0x00365AAE File Offset: 0x00363CAE
		public static void AddQuests(FlatBufferBuilder builder, VectorOffset questsOffset)
		{
			builder.AddOffset(0, questsOffset.Value, 0);
		}

		// Token: 0x060178EF RID: 96495 RVA: 0x00365AC0 File Offset: 0x00363CC0
		public static VectorOffset CreateQuestsVector(FlatBufferBuilder builder, Offset<IQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060178F0 RID: 96496 RVA: 0x00365B00 File Offset: 0x00363D00
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, Offset<IQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x060178F1 RID: 96497 RVA: 0x00365B1A File Offset: 0x00363D1A
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x060178F2 RID: 96498 RVA: 0x00365B38 File Offset: 0x00363D38
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060178F3 RID: 96499 RVA: 0x00365B51 File Offset: 0x00363D51
		public static void StartQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060178F4 RID: 96500 RVA: 0x00365B5C File Offset: 0x00363D5C
		public static void Add_Selected(FlatBufferBuilder builder, int _Selected)
		{
			builder.AddInt(1, _Selected, 0);
		}

		// Token: 0x060178F5 RID: 96501 RVA: 0x00365B67 File Offset: 0x00363D67
		public static void Add_IsSelectBt(FlatBufferBuilder builder, bool _IsSelectBt)
		{
			builder.AddBool(2, _IsSelectBt, false);
		}

		// Token: 0x060178F6 RID: 96502 RVA: 0x00365B72 File Offset: 0x00363D72
		public static void Add_SyncBlockGroups(FlatBufferBuilder builder, VectorOffset _SyncBlockGroupsOffset)
		{
			builder.AddOffset(3, _SyncBlockGroupsOffset.Value, 0);
		}

		// Token: 0x060178F7 RID: 96503 RVA: 0x00365B84 File Offset: 0x00363D84
		public static VectorOffset Create_SyncBlockGroupsVector(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060178F8 RID: 96504 RVA: 0x00365BC4 File Offset: 0x00363DC4
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlockGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060178F9 RID: 96505 RVA: 0x00365BDE File Offset: 0x00363DDE
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlockGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlockGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060178FA RID: 96506 RVA: 0x00365BFC File Offset: 0x00363DFC
		public static VectorOffset Create_SyncBlockGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlockGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060178FB RID: 96507 RVA: 0x00365C15 File Offset: 0x00363E15
		public static void Start_SyncBlockGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060178FC RID: 96508 RVA: 0x00365C20 File Offset: 0x00363E20
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060178FD RID: 96509 RVA: 0x00365C2B File Offset: 0x00363E2B
		public static Offset<IQuestList> EndIQuestList(FlatBufferBuilder builder)
		{
			return new Offset<IQuestList>(builder.EndTable());
		}

		// Token: 0x060178FE RID: 96510 RVA: 0x00365C38 File Offset: 0x00363E38
		public IQuestListT UnPack()
		{
			IQuestListT questListT = new IQuestListT();
			this.UnPackTo(questListT);
			return questListT;
		}

		// Token: 0x060178FF RID: 96511 RVA: 0x00365C54 File Offset: 0x00363E54
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

		// Token: 0x06017900 RID: 96512 RVA: 0x00365D2C File Offset: 0x00363F2C
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

		// Token: 0x0400BAEB RID: 47851
		private Table __p;
	}
}
