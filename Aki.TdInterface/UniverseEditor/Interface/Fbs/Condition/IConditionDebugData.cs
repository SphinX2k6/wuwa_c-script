using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050CD RID: 20685
	public struct IConditionDebugData : IFlatbufferObject
	{
		// Token: 0x1700943E RID: 37950
		// (get) Token: 0x060207BD RID: 133053 RVA: 0x0047F82F File Offset: 0x0047DA2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060207BE RID: 133054 RVA: 0x0047F83C File Offset: 0x0047DA3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060207BF RID: 133055 RVA: 0x0047F844 File Offset: 0x0047DA44
		public static IConditionDebugData GetRootAsIConditionDebugData(ByteBuffer _bb)
		{
			return IConditionDebugData.GetRootAsIConditionDebugData(_bb, default(IConditionDebugData));
		}

		// Token: 0x060207C0 RID: 133056 RVA: 0x0047F860 File Offset: 0x0047DA60
		public static IConditionDebugData GetRootAsIConditionDebugData(ByteBuffer _bb, IConditionDebugData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060207C1 RID: 133057 RVA: 0x0047F87D File Offset: 0x0047DA7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060207C2 RID: 133058 RVA: 0x0047F88C File Offset: 0x0047DA8C
		public IConditionDebugData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700943F RID: 37951
		// (get) Token: 0x060207C3 RID: 133059 RVA: 0x0047F89C File Offset: 0x0047DA9C
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

		// Token: 0x060207C4 RID: 133060 RVA: 0x0047F8D8 File Offset: 0x0047DAD8
		public static Offset<IConditionDebugData> CreateIConditionDebugData(FlatBufferBuilder builder, EConditionLogicType Type = EConditionLogicType.BaseAccessQuest)
		{
			builder.StartTable(1);
			IConditionDebugData.AddType(builder, Type);
			return IConditionDebugData.EndIConditionDebugData(builder);
		}

		// Token: 0x060207C5 RID: 133061 RVA: 0x0047F8EE File Offset: 0x0047DAEE
		public static void StartIConditionDebugData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060207C6 RID: 133062 RVA: 0x0047F8F7 File Offset: 0x0047DAF7
		public static void AddType(FlatBufferBuilder builder, EConditionLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060207C7 RID: 133063 RVA: 0x0047F902 File Offset: 0x0047DB02
		public static Offset<IConditionDebugData> EndIConditionDebugData(FlatBufferBuilder builder)
		{
			return new Offset<IConditionDebugData>(builder.EndTable());
		}

		// Token: 0x060207C8 RID: 133064 RVA: 0x0047F910 File Offset: 0x0047DB10
		public IConditionDebugDataT UnPack()
		{
			IConditionDebugDataT conditionDebugDataT = new IConditionDebugDataT();
			this.UnPackTo(conditionDebugDataT);
			return conditionDebugDataT;
		}

		// Token: 0x060207C9 RID: 133065 RVA: 0x0047F92B File Offset: 0x0047DB2B
		public void UnPackTo(IConditionDebugDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060207CA RID: 133066 RVA: 0x0047F93C File Offset: 0x0047DB3C
		public static Offset<IConditionDebugData> Pack(FlatBufferBuilder builder, IConditionDebugDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionDebugData>);
			}
			return IConditionDebugData.CreateIConditionDebugData(builder, _o.Type);
		}

		// Token: 0x0400E07D RID: 57469
		private Table __p;
	}
}
