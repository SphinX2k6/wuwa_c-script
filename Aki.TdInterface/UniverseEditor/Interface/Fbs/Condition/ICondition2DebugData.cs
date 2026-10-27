using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BDA RID: 19418
	public struct ICondition2DebugData : IFlatbufferObject
	{
		// Token: 0x17008D13 RID: 36115
		// (get) Token: 0x0601EA97 RID: 125591 RVA: 0x00449B8D File Offset: 0x00447D8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA98 RID: 125592 RVA: 0x00449B9A File Offset: 0x00447D9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA99 RID: 125593 RVA: 0x00449BA4 File Offset: 0x00447DA4
		public static ICondition2DebugData GetRootAsICondition2DebugData(ByteBuffer _bb)
		{
			return ICondition2DebugData.GetRootAsICondition2DebugData(_bb, default(ICondition2DebugData));
		}

		// Token: 0x0601EA9A RID: 125594 RVA: 0x00449BC0 File Offset: 0x00447DC0
		public static ICondition2DebugData GetRootAsICondition2DebugData(ByteBuffer _bb, ICondition2DebugData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA9B RID: 125595 RVA: 0x00449BDD File Offset: 0x00447DDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA9C RID: 125596 RVA: 0x00449BEC File Offset: 0x00447DEC
		public ICondition2DebugData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D14 RID: 36116
		// (get) Token: 0x0601EA9D RID: 125597 RVA: 0x00449BFC File Offset: 0x00447DFC
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

		// Token: 0x17008D15 RID: 36117
		// (get) Token: 0x0601EA9E RID: 125598 RVA: 0x00449C38 File Offset: 0x00447E38
		public IConditionGroup? Condition2Group
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601EA9F RID: 125599 RVA: 0x00449C95 File Offset: 0x00447E95
		public static Offset<ICondition2DebugData> CreateICondition2DebugData(FlatBufferBuilder builder, EConditionLogicType Type = EConditionLogicType.BaseAccessQuest, Offset<IConditionGroup> Condition2GroupOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ICondition2DebugData.AddCondition2Group(builder, Condition2GroupOffset);
			ICondition2DebugData.AddType(builder, Type);
			return ICondition2DebugData.EndICondition2DebugData(builder);
		}

		// Token: 0x0601EAA0 RID: 125600 RVA: 0x00449CB2 File Offset: 0x00447EB2
		public static void StartICondition2DebugData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EAA1 RID: 125601 RVA: 0x00449CBB File Offset: 0x00447EBB
		public static void AddType(FlatBufferBuilder builder, EConditionLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EAA2 RID: 125602 RVA: 0x00449CC6 File Offset: 0x00447EC6
		public static void AddCondition2Group(FlatBufferBuilder builder, Offset<IConditionGroup> condition2GroupOffset)
		{
			builder.AddOffset(1, condition2GroupOffset.Value, 0);
		}

		// Token: 0x0601EAA3 RID: 125603 RVA: 0x00449CD6 File Offset: 0x00447ED6
		public static Offset<ICondition2DebugData> EndICondition2DebugData(FlatBufferBuilder builder)
		{
			return new Offset<ICondition2DebugData>(builder.EndTable());
		}

		// Token: 0x0601EAA4 RID: 125604 RVA: 0x00449CE4 File Offset: 0x00447EE4
		public ICondition2DebugDataT UnPack()
		{
			ICondition2DebugDataT condition2DebugDataT = new ICondition2DebugDataT();
			this.UnPackTo(condition2DebugDataT);
			return condition2DebugDataT;
		}

		// Token: 0x0601EAA5 RID: 125605 RVA: 0x00449D00 File Offset: 0x00447F00
		public void UnPackTo(ICondition2DebugDataT _o)
		{
			_o.Type = this.Type;
			_o.Condition2Group = ((this.Condition2Group != null) ? this.Condition2Group.Value.UnPack() : null);
		}

		// Token: 0x0601EAA6 RID: 125606 RVA: 0x00449D48 File Offset: 0x00447F48
		public static Offset<ICondition2DebugData> Pack(FlatBufferBuilder builder, ICondition2DebugDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICondition2DebugData>);
			}
			Offset<IConditionGroup> condition2GroupOffset = (_o.Condition2Group == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition2Group);
			return ICondition2DebugData.CreateICondition2DebugData(builder, _o.Type, condition2GroupOffset);
		}

		// Token: 0x0400D4CE RID: 54478
		private Table __p;
	}
}
