using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BEC RID: 19436
	public struct IConditionRequestData : IFlatbufferObject
	{
		// Token: 0x17008D2A RID: 36138
		// (get) Token: 0x0601EC39 RID: 126009 RVA: 0x0044F5D0 File Offset: 0x0044D7D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC3A RID: 126010 RVA: 0x0044F5DD File Offset: 0x0044D7DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC3B RID: 126011 RVA: 0x0044F5E4 File Offset: 0x0044D7E4
		public static IConditionRequestData GetRootAsIConditionRequestData(ByteBuffer _bb)
		{
			return IConditionRequestData.GetRootAsIConditionRequestData(_bb, default(IConditionRequestData));
		}

		// Token: 0x0601EC3C RID: 126012 RVA: 0x0044F600 File Offset: 0x0044D800
		public static IConditionRequestData GetRootAsIConditionRequestData(ByteBuffer _bb, IConditionRequestData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC3D RID: 126013 RVA: 0x0044F61D File Offset: 0x0044D81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC3E RID: 126014 RVA: 0x0044F62C File Offset: 0x0044D82C
		public IConditionRequestData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D2B RID: 36139
		// (get) Token: 0x0601EC3F RID: 126015 RVA: 0x0044F63C File Offset: 0x0044D83C
		public int RequestId
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

		// Token: 0x17008D2C RID: 36140
		// (get) Token: 0x0601EC40 RID: 126016 RVA: 0x0044F678 File Offset: 0x0044D878
		public string Uid
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

		// Token: 0x0601EC41 RID: 126017 RVA: 0x0044F6AF File Offset: 0x0044D8AF
		public Span<byte> GetUidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601EC42 RID: 126018 RVA: 0x0044F6BE File Offset: 0x0044D8BE
		public byte[] GetUidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008D2D RID: 36141
		// (get) Token: 0x0601EC43 RID: 126019 RVA: 0x0044F6CC File Offset: 0x0044D8CC
		public TConditionDebugData ConditionGroupType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TConditionDebugData.NONE;
				}
				return (TConditionDebugData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EC44 RID: 126020 RVA: 0x0044F708 File Offset: 0x0044D908
		public TTable? ConditionGroup<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EC45 RID: 126021 RVA: 0x0044F750 File Offset: 0x0044D950
		public IBaseAccessQuestDebugData ConditionGroupAsIBaseAccessQuestDebugData()
		{
			return this.ConditionGroup<IBaseAccessQuestDebugData>().Value;
		}

		// Token: 0x0601EC46 RID: 126022 RVA: 0x0044F76C File Offset: 0x0044D96C
		public ICondition2DebugData ConditionGroupAsICondition2DebugData()
		{
			return this.ConditionGroup<ICondition2DebugData>().Value;
		}

		// Token: 0x0601EC47 RID: 126023 RVA: 0x0044F787 File Offset: 0x0044D987
		public static Offset<IConditionRequestData> CreateIConditionRequestData(FlatBufferBuilder builder, int RequestId = 0, StringOffset UidOffset = default(StringOffset), TConditionDebugData ConditionGroup_type = TConditionDebugData.NONE, int ConditionGroupOffset = 0)
		{
			builder.StartTable(4);
			IConditionRequestData.AddConditionGroup(builder, ConditionGroupOffset);
			IConditionRequestData.AddUid(builder, UidOffset);
			IConditionRequestData.AddRequestId(builder, RequestId);
			IConditionRequestData.AddConditionGroupType(builder, ConditionGroup_type);
			return IConditionRequestData.EndIConditionRequestData(builder);
		}

		// Token: 0x0601EC48 RID: 126024 RVA: 0x0044F7B3 File Offset: 0x0044D9B3
		public static void StartIConditionRequestData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EC49 RID: 126025 RVA: 0x0044F7BC File Offset: 0x0044D9BC
		public static void AddRequestId(FlatBufferBuilder builder, int requestId)
		{
			builder.AddInt(0, requestId, 0);
		}

		// Token: 0x0601EC4A RID: 126026 RVA: 0x0044F7C7 File Offset: 0x0044D9C7
		public static void AddUid(FlatBufferBuilder builder, StringOffset uidOffset)
		{
			builder.AddOffset(1, uidOffset.Value, 0);
		}

		// Token: 0x0601EC4B RID: 126027 RVA: 0x0044F7D7 File Offset: 0x0044D9D7
		public static void AddConditionGroupType(FlatBufferBuilder builder, TConditionDebugData conditionGroupType)
		{
			builder.AddByte(2, (byte)conditionGroupType, 0);
		}

		// Token: 0x0601EC4C RID: 126028 RVA: 0x0044F7E2 File Offset: 0x0044D9E2
		public static void AddConditionGroup(FlatBufferBuilder builder, int conditionGroupOffset)
		{
			builder.AddOffset(3, conditionGroupOffset, 0);
		}

		// Token: 0x0601EC4D RID: 126029 RVA: 0x0044F7ED File Offset: 0x0044D9ED
		public static Offset<IConditionRequestData> EndIConditionRequestData(FlatBufferBuilder builder)
		{
			return new Offset<IConditionRequestData>(builder.EndTable());
		}

		// Token: 0x0601EC4E RID: 126030 RVA: 0x0044F7FC File Offset: 0x0044D9FC
		public IConditionRequestDataT UnPack()
		{
			IConditionRequestDataT conditionRequestDataT = new IConditionRequestDataT();
			this.UnPackTo(conditionRequestDataT);
			return conditionRequestDataT;
		}

		// Token: 0x0601EC4F RID: 126031 RVA: 0x0044F818 File Offset: 0x0044DA18
		public void UnPackTo(IConditionRequestDataT _o)
		{
			_o.RequestId = this.RequestId;
			_o.Uid = this.Uid;
			_o.ConditionGroup = new TConditionDebugDataUnion();
			_o.ConditionGroup.Type = this.ConditionGroupType;
			TConditionDebugData conditionGroupType = this.ConditionGroupType;
			if (conditionGroupType == TConditionDebugData.IBaseAccessQuestDebugData)
			{
				_o.ConditionGroup.Value = ((this.ConditionGroup<IBaseAccessQuestDebugData>() != null) ? this.ConditionGroup<IBaseAccessQuestDebugData>().Value.UnPack() : null);
				return;
			}
			if (conditionGroupType != TConditionDebugData.ICondition2DebugData)
			{
				return;
			}
			_o.ConditionGroup.Value = ((this.ConditionGroup<ICondition2DebugData>() != null) ? this.ConditionGroup<ICondition2DebugData>().Value.UnPack() : null);
		}

		// Token: 0x0601EC50 RID: 126032 RVA: 0x0044F8D4 File Offset: 0x0044DAD4
		public static Offset<IConditionRequestData> Pack(FlatBufferBuilder builder, IConditionRequestDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionRequestData>);
			}
			StringOffset uidOffset = (_o.Uid == null) ? default(StringOffset) : builder.CreateString(_o.Uid);
			TConditionDebugData conditionGroup_type = (_o.ConditionGroup == null) ? TConditionDebugData.NONE : _o.ConditionGroup.Type;
			int conditionGroupOffset = (_o.ConditionGroup == null) ? 0 : TConditionDebugDataUnion.Pack(builder, _o.ConditionGroup);
			return IConditionRequestData.CreateIConditionRequestData(builder, _o.RequestId, uidOffset, conditionGroup_type, conditionGroupOffset);
		}

		// Token: 0x0400D575 RID: 54645
		private Table __p;
	}
}
