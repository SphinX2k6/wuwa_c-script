using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050C7 RID: 20679
	public struct ICondition2DebugData : IFlatbufferObject
	{
		// Token: 0x17009437 RID: 37943
		// (get) Token: 0x06020665 RID: 132709 RVA: 0x0047CA99 File Offset: 0x0047AC99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020666 RID: 132710 RVA: 0x0047CAA6 File Offset: 0x0047ACA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020667 RID: 132711 RVA: 0x0047CAB0 File Offset: 0x0047ACB0
		public static ICondition2DebugData GetRootAsICondition2DebugData(ByteBuffer _bb)
		{
			return ICondition2DebugData.GetRootAsICondition2DebugData(_bb, default(ICondition2DebugData));
		}

		// Token: 0x06020668 RID: 132712 RVA: 0x0047CACC File Offset: 0x0047ACCC
		public static ICondition2DebugData GetRootAsICondition2DebugData(ByteBuffer _bb, ICondition2DebugData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020669 RID: 132713 RVA: 0x0047CAE9 File Offset: 0x0047ACE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602066A RID: 132714 RVA: 0x0047CAF8 File Offset: 0x0047ACF8
		public ICondition2DebugData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009438 RID: 37944
		// (get) Token: 0x0602066B RID: 132715 RVA: 0x0047CB08 File Offset: 0x0047AD08
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

		// Token: 0x17009439 RID: 37945
		// (get) Token: 0x0602066C RID: 132716 RVA: 0x0047CB44 File Offset: 0x0047AD44
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

		// Token: 0x0602066D RID: 132717 RVA: 0x0047CBA1 File Offset: 0x0047ADA1
		public static Offset<ICondition2DebugData> CreateICondition2DebugData(FlatBufferBuilder builder, EConditionLogicType Type = EConditionLogicType.BaseAccessQuest, Offset<IConditionGroup> Condition2GroupOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ICondition2DebugData.AddCondition2Group(builder, Condition2GroupOffset);
			ICondition2DebugData.AddType(builder, Type);
			return ICondition2DebugData.EndICondition2DebugData(builder);
		}

		// Token: 0x0602066E RID: 132718 RVA: 0x0047CBBE File Offset: 0x0047ADBE
		public static void StartICondition2DebugData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602066F RID: 132719 RVA: 0x0047CBC7 File Offset: 0x0047ADC7
		public static void AddType(FlatBufferBuilder builder, EConditionLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020670 RID: 132720 RVA: 0x0047CBD2 File Offset: 0x0047ADD2
		public static void AddCondition2Group(FlatBufferBuilder builder, Offset<IConditionGroup> condition2GroupOffset)
		{
			builder.AddOffset(1, condition2GroupOffset.Value, 0);
		}

		// Token: 0x06020671 RID: 132721 RVA: 0x0047CBE2 File Offset: 0x0047ADE2
		public static Offset<ICondition2DebugData> EndICondition2DebugData(FlatBufferBuilder builder)
		{
			return new Offset<ICondition2DebugData>(builder.EndTable());
		}

		// Token: 0x06020672 RID: 132722 RVA: 0x0047CBF0 File Offset: 0x0047ADF0
		public ICondition2DebugDataT UnPack()
		{
			ICondition2DebugDataT condition2DebugDataT = new ICondition2DebugDataT();
			this.UnPackTo(condition2DebugDataT);
			return condition2DebugDataT;
		}

		// Token: 0x06020673 RID: 132723 RVA: 0x0047CC0C File Offset: 0x0047AE0C
		public void UnPackTo(ICondition2DebugDataT _o)
		{
			_o.Type = this.Type;
			_o.Condition2Group = ((this.Condition2Group != null) ? this.Condition2Group.Value.UnPack() : null);
		}

		// Token: 0x06020674 RID: 132724 RVA: 0x0047CC54 File Offset: 0x0047AE54
		public static Offset<ICondition2DebugData> Pack(FlatBufferBuilder builder, ICondition2DebugDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICondition2DebugData>);
			}
			Offset<IConditionGroup> condition2GroupOffset = (_o.Condition2Group == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition2Group);
			return ICondition2DebugData.CreateICondition2DebugData(builder, _o.Type, condition2GroupOffset);
		}

		// Token: 0x0400DFD9 RID: 57305
		private Table __p;
	}
}
