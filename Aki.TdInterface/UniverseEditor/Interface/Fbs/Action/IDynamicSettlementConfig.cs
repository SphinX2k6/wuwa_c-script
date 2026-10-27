using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200661E RID: 26142
	public struct IDynamicSettlementConfig : IFlatbufferObject
	{
		// Token: 0x1700C23D RID: 49725
		// (get) Token: 0x0602D657 RID: 185943 RVA: 0x006385B9 File Offset: 0x006367B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D658 RID: 185944 RVA: 0x006385C6 File Offset: 0x006367C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D659 RID: 185945 RVA: 0x006385D0 File Offset: 0x006367D0
		public static IDynamicSettlementConfig GetRootAsIDynamicSettlementConfig(ByteBuffer _bb)
		{
			return IDynamicSettlementConfig.GetRootAsIDynamicSettlementConfig(_bb, default(IDynamicSettlementConfig));
		}

		// Token: 0x0602D65A RID: 185946 RVA: 0x006385EC File Offset: 0x006367EC
		public static IDynamicSettlementConfig GetRootAsIDynamicSettlementConfig(ByteBuffer _bb, IDynamicSettlementConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D65B RID: 185947 RVA: 0x00638609 File Offset: 0x00636809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D65C RID: 185948 RVA: 0x00638618 File Offset: 0x00636818
		public IDynamicSettlementConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C23E RID: 49726
		// (get) Token: 0x0602D65D RID: 185949 RVA: 0x00638628 File Offset: 0x00636828
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

		// Token: 0x0602D65E RID: 185950 RVA: 0x00638664 File Offset: 0x00636864
		public static Offset<IDynamicSettlementConfig> CreateIDynamicSettlementConfig(FlatBufferBuilder builder, EDynamicSettlementType Type = EDynamicSettlementType.Battle)
		{
			builder.StartTable(1);
			IDynamicSettlementConfig.AddType(builder, Type);
			return IDynamicSettlementConfig.EndIDynamicSettlementConfig(builder);
		}

		// Token: 0x0602D65F RID: 185951 RVA: 0x0063867A File Offset: 0x0063687A
		public static void StartIDynamicSettlementConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D660 RID: 185952 RVA: 0x00638683 File Offset: 0x00636883
		public static void AddType(FlatBufferBuilder builder, EDynamicSettlementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D661 RID: 185953 RVA: 0x0063868E File Offset: 0x0063688E
		public static Offset<IDynamicSettlementConfig> EndIDynamicSettlementConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSettlementConfig>(builder.EndTable());
		}

		// Token: 0x0602D662 RID: 185954 RVA: 0x0063869C File Offset: 0x0063689C
		public IDynamicSettlementConfigT UnPack()
		{
			IDynamicSettlementConfigT dynamicSettlementConfigT = new IDynamicSettlementConfigT();
			this.UnPackTo(dynamicSettlementConfigT);
			return dynamicSettlementConfigT;
		}

		// Token: 0x0602D663 RID: 185955 RVA: 0x006386B7 File Offset: 0x006368B7
		public void UnPackTo(IDynamicSettlementConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D664 RID: 185956 RVA: 0x006386C8 File Offset: 0x006368C8
		public static Offset<IDynamicSettlementConfig> Pack(FlatBufferBuilder builder, IDynamicSettlementConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSettlementConfig>);
			}
			return IDynamicSettlementConfig.CreateIDynamicSettlementConfig(builder, _o.Type);
		}

		// Token: 0x04010CAB RID: 68779
		private Table __p;
	}
}
