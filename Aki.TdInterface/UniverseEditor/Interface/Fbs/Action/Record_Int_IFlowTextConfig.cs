using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E2D RID: 32301
	public struct Record_Int_IFlowTextConfig : IFlatbufferObject
	{
		// Token: 0x1700F1DE RID: 61918
		// (get) Token: 0x0603A5DF RID: 239071 RVA: 0x007DC61E File Offset: 0x007DA81E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A5E0 RID: 239072 RVA: 0x007DC62B File Offset: 0x007DA82B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A5E1 RID: 239073 RVA: 0x007DC634 File Offset: 0x007DA834
		public static Record_Int_IFlowTextConfig GetRootAsRecord_Int_IFlowTextConfig(ByteBuffer _bb)
		{
			return Record_Int_IFlowTextConfig.GetRootAsRecord_Int_IFlowTextConfig(_bb, default(Record_Int_IFlowTextConfig));
		}

		// Token: 0x0603A5E2 RID: 239074 RVA: 0x007DC650 File Offset: 0x007DA850
		public static Record_Int_IFlowTextConfig GetRootAsRecord_Int_IFlowTextConfig(ByteBuffer _bb, Record_Int_IFlowTextConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A5E3 RID: 239075 RVA: 0x007DC66D File Offset: 0x007DA86D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A5E4 RID: 239076 RVA: 0x007DC67C File Offset: 0x007DA87C
		public Record_Int_IFlowTextConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1DF RID: 61919
		// (get) Token: 0x0603A5E5 RID: 239077 RVA: 0x007DC68C File Offset: 0x007DA88C
		public int Key
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

		// Token: 0x1700F1E0 RID: 61920
		// (get) Token: 0x0603A5E6 RID: 239078 RVA: 0x007DC6C8 File Offset: 0x007DA8C8
		public IFlowTextConfig? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFlowTextConfig?(default(IFlowTextConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603A5E7 RID: 239079 RVA: 0x007DC725 File Offset: 0x007DA925
		public static Offset<Record_Int_IFlowTextConfig> CreateRecord_Int_IFlowTextConfig(FlatBufferBuilder builder, int Key = 0, Offset<IFlowTextConfig> ValueOffset = default(Offset<IFlowTextConfig>))
		{
			builder.StartTable(2);
			Record_Int_IFlowTextConfig.AddValue(builder, ValueOffset);
			Record_Int_IFlowTextConfig.AddKey(builder, Key);
			return Record_Int_IFlowTextConfig.EndRecord_Int_IFlowTextConfig(builder);
		}

		// Token: 0x0603A5E8 RID: 239080 RVA: 0x007DC742 File Offset: 0x007DA942
		public static void StartRecord_Int_IFlowTextConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A5E9 RID: 239081 RVA: 0x007DC74B File Offset: 0x007DA94B
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0603A5EA RID: 239082 RVA: 0x007DC756 File Offset: 0x007DA956
		public static void AddValue(FlatBufferBuilder builder, Offset<IFlowTextConfig> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0603A5EB RID: 239083 RVA: 0x007DC766 File Offset: 0x007DA966
		public static Offset<Record_Int_IFlowTextConfig> EndRecord_Int_IFlowTextConfig(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IFlowTextConfig>(builder.EndTable());
		}

		// Token: 0x0603A5EC RID: 239084 RVA: 0x007DC774 File Offset: 0x007DA974
		public Record_Int_IFlowTextConfigT UnPack()
		{
			Record_Int_IFlowTextConfigT record_Int_IFlowTextConfigT = new Record_Int_IFlowTextConfigT();
			this.UnPackTo(record_Int_IFlowTextConfigT);
			return record_Int_IFlowTextConfigT;
		}

		// Token: 0x0603A5ED RID: 239085 RVA: 0x007DC790 File Offset: 0x007DA990
		public void UnPackTo(Record_Int_IFlowTextConfigT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0603A5EE RID: 239086 RVA: 0x007DC7D8 File Offset: 0x007DA9D8
		public static Offset<Record_Int_IFlowTextConfig> Pack(FlatBufferBuilder builder, Record_Int_IFlowTextConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IFlowTextConfig>);
			}
			Offset<IFlowTextConfig> valueOffset = (_o.Value == null) ? default(Offset<IFlowTextConfig>) : IFlowTextConfig.Pack(builder, _o.Value);
			return Record_Int_IFlowTextConfig.CreateRecord_Int_IFlowTextConfig(builder, _o.Key, valueOffset);
		}

		// Token: 0x040135D5 RID: 79317
		private Table __p;
	}
}
