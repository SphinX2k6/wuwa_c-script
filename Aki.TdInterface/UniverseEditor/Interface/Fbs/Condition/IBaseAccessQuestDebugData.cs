using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E2A RID: 20010
	public struct IBaseAccessQuestDebugData : IFlatbufferObject
	{
		// Token: 0x17008E8B RID: 36491
		// (get) Token: 0x0601EF11 RID: 126737 RVA: 0x004528DB File Offset: 0x00450ADB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF12 RID: 126738 RVA: 0x004528E8 File Offset: 0x00450AE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF13 RID: 126739 RVA: 0x004528F0 File Offset: 0x00450AF0
		public static IBaseAccessQuestDebugData GetRootAsIBaseAccessQuestDebugData(ByteBuffer _bb)
		{
			return IBaseAccessQuestDebugData.GetRootAsIBaseAccessQuestDebugData(_bb, default(IBaseAccessQuestDebugData));
		}

		// Token: 0x0601EF14 RID: 126740 RVA: 0x0045290C File Offset: 0x00450B0C
		public static IBaseAccessQuestDebugData GetRootAsIBaseAccessQuestDebugData(ByteBuffer _bb, IBaseAccessQuestDebugData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF15 RID: 126741 RVA: 0x00452929 File Offset: 0x00450B29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF16 RID: 126742 RVA: 0x00452938 File Offset: 0x00450B38
		public IBaseAccessQuestDebugData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E8C RID: 36492
		// (get) Token: 0x0601EF17 RID: 126743 RVA: 0x00452948 File Offset: 0x00450B48
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

		// Token: 0x17008E8D RID: 36493
		// (get) Token: 0x0601EF18 RID: 126744 RVA: 0x00452984 File Offset: 0x00450B84
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

		// Token: 0x0601EF19 RID: 126745 RVA: 0x004529E1 File Offset: 0x00450BE1
		public static Offset<IBaseAccessQuestDebugData> CreateIBaseAccessQuestDebugData(FlatBufferBuilder builder, EConditionLogicType Type = EConditionLogicType.BaseAccessQuest, Offset<IAccessQuestCondition> BaseAccessQuestConditionGroupOffset = default(Offset<IAccessQuestCondition>))
		{
			builder.StartTable(2);
			IBaseAccessQuestDebugData.AddBaseAccessQuestConditionGroup(builder, BaseAccessQuestConditionGroupOffset);
			IBaseAccessQuestDebugData.AddType(builder, Type);
			return IBaseAccessQuestDebugData.EndIBaseAccessQuestDebugData(builder);
		}

		// Token: 0x0601EF1A RID: 126746 RVA: 0x004529FE File Offset: 0x00450BFE
		public static void StartIBaseAccessQuestDebugData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EF1B RID: 126747 RVA: 0x00452A07 File Offset: 0x00450C07
		public static void AddType(FlatBufferBuilder builder, EConditionLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF1C RID: 126748 RVA: 0x00452A12 File Offset: 0x00450C12
		public static void AddBaseAccessQuestConditionGroup(FlatBufferBuilder builder, Offset<IAccessQuestCondition> baseAccessQuestConditionGroupOffset)
		{
			builder.AddOffset(1, baseAccessQuestConditionGroupOffset.Value, 0);
		}

		// Token: 0x0601EF1D RID: 126749 RVA: 0x00452A22 File Offset: 0x00450C22
		public static Offset<IBaseAccessQuestDebugData> EndIBaseAccessQuestDebugData(FlatBufferBuilder builder)
		{
			return new Offset<IBaseAccessQuestDebugData>(builder.EndTable());
		}

		// Token: 0x0601EF1E RID: 126750 RVA: 0x00452A30 File Offset: 0x00450C30
		public IBaseAccessQuestDebugDataT UnPack()
		{
			IBaseAccessQuestDebugDataT baseAccessQuestDebugDataT = new IBaseAccessQuestDebugDataT();
			this.UnPackTo(baseAccessQuestDebugDataT);
			return baseAccessQuestDebugDataT;
		}

		// Token: 0x0601EF1F RID: 126751 RVA: 0x00452A4C File Offset: 0x00450C4C
		public void UnPackTo(IBaseAccessQuestDebugDataT _o)
		{
			_o.Type = this.Type;
			_o.BaseAccessQuestConditionGroup = ((this.BaseAccessQuestConditionGroup != null) ? this.BaseAccessQuestConditionGroup.Value.UnPack() : null);
		}

		// Token: 0x0601EF20 RID: 126752 RVA: 0x00452A94 File Offset: 0x00450C94
		public static Offset<IBaseAccessQuestDebugData> Pack(FlatBufferBuilder builder, IBaseAccessQuestDebugDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseAccessQuestDebugData>);
			}
			Offset<IAccessQuestCondition> baseAccessQuestConditionGroupOffset = (_o.BaseAccessQuestConditionGroup == null) ? default(Offset<IAccessQuestCondition>) : IAccessQuestCondition.Pack(builder, _o.BaseAccessQuestConditionGroup);
			return IBaseAccessQuestDebugData.CreateIBaseAccessQuestDebugData(builder, _o.Type, baseAccessQuestConditionGroupOffset);
		}

		// Token: 0x0400DC40 RID: 56384
		private Table __p;
	}
}
