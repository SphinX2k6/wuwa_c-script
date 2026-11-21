using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050D9 RID: 20697
	public struct IConditionRequestData : IFlatbufferObject
	{
		// Token: 0x1700944E RID: 37966
		// (get) Token: 0x0602081F RID: 133151 RVA: 0x00482C38 File Offset: 0x00480E38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020820 RID: 133152 RVA: 0x00482C45 File Offset: 0x00480E45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020821 RID: 133153 RVA: 0x00482C4C File Offset: 0x00480E4C
		public static IConditionRequestData GetRootAsIConditionRequestData(ByteBuffer _bb)
		{
			return IConditionRequestData.GetRootAsIConditionRequestData(_bb, default(IConditionRequestData));
		}

		// Token: 0x06020822 RID: 133154 RVA: 0x00482C68 File Offset: 0x00480E68
		public static IConditionRequestData GetRootAsIConditionRequestData(ByteBuffer _bb, IConditionRequestData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020823 RID: 133155 RVA: 0x00482C85 File Offset: 0x00480E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020824 RID: 133156 RVA: 0x00482C94 File Offset: 0x00480E94
		public IConditionRequestData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700944F RID: 37967
		// (get) Token: 0x06020825 RID: 133157 RVA: 0x00482CA4 File Offset: 0x00480EA4
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

		// Token: 0x17009450 RID: 37968
		// (get) Token: 0x06020826 RID: 133158 RVA: 0x00482CE0 File Offset: 0x00480EE0
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

		// Token: 0x06020827 RID: 133159 RVA: 0x00482D17 File Offset: 0x00480F17
		public Span<byte> GetUidBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020828 RID: 133160 RVA: 0x00482D26 File Offset: 0x00480F26
		public byte[] GetUidArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009451 RID: 37969
		// (get) Token: 0x06020829 RID: 133161 RVA: 0x00482D34 File Offset: 0x00480F34
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

		// Token: 0x0602082A RID: 133162 RVA: 0x00482D70 File Offset: 0x00480F70
		public TTable? ConditionGroup<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602082B RID: 133163 RVA: 0x00482DB8 File Offset: 0x00480FB8
		public IBaseAccessQuestDebugData ConditionGroupAsIBaseAccessQuestDebugData()
		{
			return this.ConditionGroup<IBaseAccessQuestDebugData>().Value;
		}

		// Token: 0x0602082C RID: 133164 RVA: 0x00482DD4 File Offset: 0x00480FD4
		public ICondition2DebugData ConditionGroupAsICondition2DebugData()
		{
			return this.ConditionGroup<ICondition2DebugData>().Value;
		}

		// Token: 0x0602082D RID: 133165 RVA: 0x00482DEF File Offset: 0x00480FEF
		public static Offset<IConditionRequestData> CreateIConditionRequestData(FlatBufferBuilder builder, int RequestId = 0, StringOffset UidOffset = default(StringOffset), TConditionDebugData ConditionGroup_type = TConditionDebugData.NONE, int ConditionGroupOffset = 0)
		{
			builder.StartTable(4);
			IConditionRequestData.AddConditionGroup(builder, ConditionGroupOffset);
			IConditionRequestData.AddUid(builder, UidOffset);
			IConditionRequestData.AddRequestId(builder, RequestId);
			IConditionRequestData.AddConditionGroupType(builder, ConditionGroup_type);
			return IConditionRequestData.EndIConditionRequestData(builder);
		}

		// Token: 0x0602082E RID: 133166 RVA: 0x00482E1B File Offset: 0x0048101B
		public static void StartIConditionRequestData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602082F RID: 133167 RVA: 0x00482E24 File Offset: 0x00481024
		public static void AddRequestId(FlatBufferBuilder builder, int requestId)
		{
			builder.AddInt(0, requestId, 0);
		}

		// Token: 0x06020830 RID: 133168 RVA: 0x00482E2F File Offset: 0x0048102F
		public static void AddUid(FlatBufferBuilder builder, StringOffset uidOffset)
		{
			builder.AddOffset(1, uidOffset.Value, 0);
		}

		// Token: 0x06020831 RID: 133169 RVA: 0x00482E3F File Offset: 0x0048103F
		public static void AddConditionGroupType(FlatBufferBuilder builder, TConditionDebugData conditionGroupType)
		{
			builder.AddByte(2, (byte)conditionGroupType, 0);
		}

		// Token: 0x06020832 RID: 133170 RVA: 0x00482E4A File Offset: 0x0048104A
		public static void AddConditionGroup(FlatBufferBuilder builder, int conditionGroupOffset)
		{
			builder.AddOffset(3, conditionGroupOffset, 0);
		}

		// Token: 0x06020833 RID: 133171 RVA: 0x00482E55 File Offset: 0x00481055
		public static Offset<IConditionRequestData> EndIConditionRequestData(FlatBufferBuilder builder)
		{
			return new Offset<IConditionRequestData>(builder.EndTable());
		}

		// Token: 0x06020834 RID: 133172 RVA: 0x00482E64 File Offset: 0x00481064
		public IConditionRequestDataT UnPack()
		{
			IConditionRequestDataT conditionRequestDataT = new IConditionRequestDataT();
			this.UnPackTo(conditionRequestDataT);
			return conditionRequestDataT;
		}

		// Token: 0x06020835 RID: 133173 RVA: 0x00482E80 File Offset: 0x00481080
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

		// Token: 0x06020836 RID: 133174 RVA: 0x00482F3C File Offset: 0x0048113C
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

		// Token: 0x0400E08C RID: 57484
		private Table __p;
	}
}
