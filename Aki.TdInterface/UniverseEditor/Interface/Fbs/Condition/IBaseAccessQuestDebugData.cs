using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004973 RID: 18803
	public struct IBaseAccessQuestDebugData : IFlatbufferObject
	{
		// Token: 0x170087D0 RID: 34768
		// (get) Token: 0x0601D4EC RID: 120044 RVA: 0x00422427 File Offset: 0x00420627
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D4ED RID: 120045 RVA: 0x00422434 File Offset: 0x00420634
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D4EE RID: 120046 RVA: 0x0042243C File Offset: 0x0042063C
		public static IBaseAccessQuestDebugData GetRootAsIBaseAccessQuestDebugData(ByteBuffer _bb)
		{
			return IBaseAccessQuestDebugData.GetRootAsIBaseAccessQuestDebugData(_bb, default(IBaseAccessQuestDebugData));
		}

		// Token: 0x0601D4EF RID: 120047 RVA: 0x00422458 File Offset: 0x00420658
		public static IBaseAccessQuestDebugData GetRootAsIBaseAccessQuestDebugData(ByteBuffer _bb, IBaseAccessQuestDebugData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D4F0 RID: 120048 RVA: 0x00422475 File Offset: 0x00420675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D4F1 RID: 120049 RVA: 0x00422484 File Offset: 0x00420684
		public IBaseAccessQuestDebugData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087D1 RID: 34769
		// (get) Token: 0x0601D4F2 RID: 120050 RVA: 0x00422494 File Offset: 0x00420694
		public EConditionLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConditionLogicType.BaseAccessQuest;
				}
				return (EConditionLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170087D2 RID: 34770
		// (get) Token: 0x0601D4F3 RID: 120051 RVA: 0x004224D0 File Offset: 0x004206D0
		public IAccessQuestCondition? BaseAccessQuestConditionGroup
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IAccessQuestCondition?(default(IAccessQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D4F4 RID: 120052 RVA: 0x0042252D File Offset: 0x0042072D
		public static Offset<IBaseAccessQuestDebugData> CreateIBaseAccessQuestDebugData(FlatBufferBuilder builder, EConditionLogicType Type = EConditionLogicType.BaseAccessQuest, Offset<IAccessQuestCondition> BaseAccessQuestConditionGroupOffset = default(Offset<IAccessQuestCondition>))
		{
			builder.StartTable(2);
			IBaseAccessQuestDebugData.AddBaseAccessQuestConditionGroup(builder, BaseAccessQuestConditionGroupOffset);
			IBaseAccessQuestDebugData.AddType(builder, Type);
			return IBaseAccessQuestDebugData.EndIBaseAccessQuestDebugData(builder);
		}

		// Token: 0x0601D4F5 RID: 120053 RVA: 0x0042254A File Offset: 0x0042074A
		public static void StartIBaseAccessQuestDebugData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D4F6 RID: 120054 RVA: 0x00422553 File Offset: 0x00420753
		public static void AddType(FlatBufferBuilder builder, EConditionLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D4F7 RID: 120055 RVA: 0x0042255E File Offset: 0x0042075E
		public static void AddBaseAccessQuestConditionGroup(FlatBufferBuilder builder, Offset<IAccessQuestCondition> baseAccessQuestConditionGroupOffset)
		{
			builder.AddOffset(1, baseAccessQuestConditionGroupOffset.Value, 0);
		}

		// Token: 0x0601D4F8 RID: 120056 RVA: 0x0042256E File Offset: 0x0042076E
		public static Offset<IBaseAccessQuestDebugData> EndIBaseAccessQuestDebugData(FlatBufferBuilder builder)
		{
			return new Offset<IBaseAccessQuestDebugData>(builder.EndTable());
		}

		// Token: 0x0601D4F9 RID: 120057 RVA: 0x0042257C File Offset: 0x0042077C
		public IBaseAccessQuestDebugDataT UnPack()
		{
			IBaseAccessQuestDebugDataT baseAccessQuestDebugDataT = new IBaseAccessQuestDebugDataT();
			this.UnPackTo(baseAccessQuestDebugDataT);
			return baseAccessQuestDebugDataT;
		}

		// Token: 0x0601D4FA RID: 120058 RVA: 0x00422598 File Offset: 0x00420798
		public void UnPackTo(IBaseAccessQuestDebugDataT _o)
		{
			_o.Type = this.Type;
			_o.BaseAccessQuestConditionGroup = ((this.BaseAccessQuestConditionGroup != null) ? this.BaseAccessQuestConditionGroup.Value.UnPack() : null);
		}

		// Token: 0x0601D4FB RID: 120059 RVA: 0x004225E0 File Offset: 0x004207E0
		public static Offset<IBaseAccessQuestDebugData> Pack(FlatBufferBuilder builder, IBaseAccessQuestDebugDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseAccessQuestDebugData>);
			}
			Offset<IAccessQuestCondition> baseAccessQuestConditionGroupOffset = (_o.BaseAccessQuestConditionGroup == null) ? default(Offset<IAccessQuestCondition>) : IAccessQuestCondition.Pack(builder, _o.BaseAccessQuestConditionGroup);
			return IBaseAccessQuestDebugData.CreateIBaseAccessQuestDebugData(builder, _o.Type, baseAccessQuestConditionGroupOffset);
		}

		// Token: 0x0400D178 RID: 53624
		private Table __p;
	}
}
