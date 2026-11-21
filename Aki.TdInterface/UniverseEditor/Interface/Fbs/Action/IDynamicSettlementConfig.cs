using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8F RID: 27791
	public struct IDynamicSettlementConfig : IFlatbufferObject
	{
		// Token: 0x1700CBDB RID: 52187
		// (get) Token: 0x0602FE28 RID: 196136 RVA: 0x00685121 File Offset: 0x00683321
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE29 RID: 196137 RVA: 0x0068512E File Offset: 0x0068332E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE2A RID: 196138 RVA: 0x00685138 File Offset: 0x00683338
		public static IDynamicSettlementConfig GetRootAsIDynamicSettlementConfig(ByteBuffer _bb)
		{
			return IDynamicSettlementConfig.GetRootAsIDynamicSettlementConfig(_bb, default(IDynamicSettlementConfig));
		}

		// Token: 0x0602FE2B RID: 196139 RVA: 0x00685154 File Offset: 0x00683354
		public static IDynamicSettlementConfig GetRootAsIDynamicSettlementConfig(ByteBuffer _bb, IDynamicSettlementConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE2C RID: 196140 RVA: 0x00685171 File Offset: 0x00683371
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE2D RID: 196141 RVA: 0x00685180 File Offset: 0x00683380
		public IDynamicSettlementConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBDC RID: 52188
		// (get) Token: 0x0602FE2E RID: 196142 RVA: 0x00685190 File Offset: 0x00683390
		public EDynamicSettlementType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicSettlementType.Battle;
				}
				return (EDynamicSettlementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE2F RID: 196143 RVA: 0x006851CC File Offset: 0x006833CC
		public static Offset<IDynamicSettlementConfig> CreateIDynamicSettlementConfig(FlatBufferBuilder builder, EDynamicSettlementType Type = EDynamicSettlementType.Battle)
		{
			builder.StartTable(1);
			IDynamicSettlementConfig.AddType(builder, Type);
			return IDynamicSettlementConfig.EndIDynamicSettlementConfig(builder);
		}

		// Token: 0x0602FE30 RID: 196144 RVA: 0x006851E2 File Offset: 0x006833E2
		public static void StartIDynamicSettlementConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FE31 RID: 196145 RVA: 0x006851EB File Offset: 0x006833EB
		public static void AddType(FlatBufferBuilder builder, EDynamicSettlementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE32 RID: 196146 RVA: 0x006851F6 File Offset: 0x006833F6
		public static Offset<IDynamicSettlementConfig> EndIDynamicSettlementConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSettlementConfig>(builder.EndTable());
		}

		// Token: 0x0602FE33 RID: 196147 RVA: 0x00685204 File Offset: 0x00683404
		public IDynamicSettlementConfigT UnPack()
		{
			IDynamicSettlementConfigT dynamicSettlementConfigT = new IDynamicSettlementConfigT();
			this.UnPackTo(dynamicSettlementConfigT);
			return dynamicSettlementConfigT;
		}

		// Token: 0x0602FE34 RID: 196148 RVA: 0x0068521F File Offset: 0x0068341F
		public void UnPackTo(IDynamicSettlementConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FE35 RID: 196149 RVA: 0x00685230 File Offset: 0x00683430
		public static Offset<IDynamicSettlementConfig> Pack(FlatBufferBuilder builder, IDynamicSettlementConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSettlementConfig>);
			}
			return IDynamicSettlementConfig.CreateIDynamicSettlementConfig(builder, _o.Type);
		}

		// Token: 0x04011AC6 RID: 72390
		private Table __p;
	}
}
