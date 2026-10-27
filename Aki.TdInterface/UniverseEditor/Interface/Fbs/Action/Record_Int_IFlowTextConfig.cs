using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761F RID: 30239
	public struct Record_Int_IFlowTextConfig : IFlatbufferObject
	{
		// Token: 0x1700E5A0 RID: 58784
		// (get) Token: 0x0603713A RID: 225594 RVA: 0x00778522 File Offset: 0x00776722
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603713B RID: 225595 RVA: 0x0077852F File Offset: 0x0077672F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603713C RID: 225596 RVA: 0x00778538 File Offset: 0x00776738
		public static Record_Int_IFlowTextConfig GetRootAsRecord_Int_IFlowTextConfig(ByteBuffer _bb)
		{
			return Record_Int_IFlowTextConfig.GetRootAsRecord_Int_IFlowTextConfig(_bb, default(Record_Int_IFlowTextConfig));
		}

		// Token: 0x0603713D RID: 225597 RVA: 0x00778554 File Offset: 0x00776754
		public static Record_Int_IFlowTextConfig GetRootAsRecord_Int_IFlowTextConfig(ByteBuffer _bb, Record_Int_IFlowTextConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603713E RID: 225598 RVA: 0x00778571 File Offset: 0x00776771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603713F RID: 225599 RVA: 0x00778580 File Offset: 0x00776780
		public Record_Int_IFlowTextConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5A1 RID: 58785
		// (get) Token: 0x06037140 RID: 225600 RVA: 0x00778590 File Offset: 0x00776790
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

		// Token: 0x1700E5A2 RID: 58786
		// (get) Token: 0x06037141 RID: 225601 RVA: 0x007785CC File Offset: 0x007767CC
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

		// Token: 0x06037142 RID: 225602 RVA: 0x00778629 File Offset: 0x00776829
		public static Offset<Record_Int_IFlowTextConfig> CreateRecord_Int_IFlowTextConfig(FlatBufferBuilder builder, int Key = 0, Offset<IFlowTextConfig> ValueOffset = default(Offset<IFlowTextConfig>))
		{
			builder.StartTable(2);
			Record_Int_IFlowTextConfig.AddValue(builder, ValueOffset);
			Record_Int_IFlowTextConfig.AddKey(builder, Key);
			return Record_Int_IFlowTextConfig.EndRecord_Int_IFlowTextConfig(builder);
		}

		// Token: 0x06037143 RID: 225603 RVA: 0x00778646 File Offset: 0x00776846
		public static void StartRecord_Int_IFlowTextConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037144 RID: 225604 RVA: 0x0077864F File Offset: 0x0077684F
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x06037145 RID: 225605 RVA: 0x0077865A File Offset: 0x0077685A
		public static void AddValue(FlatBufferBuilder builder, Offset<IFlowTextConfig> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x06037146 RID: 225606 RVA: 0x0077866A File Offset: 0x0077686A
		public static Offset<Record_Int_IFlowTextConfig> EndRecord_Int_IFlowTextConfig(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_IFlowTextConfig>(builder.EndTable());
		}

		// Token: 0x06037147 RID: 225607 RVA: 0x00778678 File Offset: 0x00776878
		public Record_Int_IFlowTextConfigT UnPack()
		{
			Record_Int_IFlowTextConfigT record_Int_IFlowTextConfigT = new Record_Int_IFlowTextConfigT();
			this.UnPackTo(record_Int_IFlowTextConfigT);
			return record_Int_IFlowTextConfigT;
		}

		// Token: 0x06037148 RID: 225608 RVA: 0x00778694 File Offset: 0x00776894
		public void UnPackTo(Record_Int_IFlowTextConfigT _o)
		{
			_o.Key = this.Key;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x06037149 RID: 225609 RVA: 0x007786DC File Offset: 0x007768DC
		public static Offset<Record_Int_IFlowTextConfig> Pack(FlatBufferBuilder builder, Record_Int_IFlowTextConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_IFlowTextConfig>);
			}
			Offset<IFlowTextConfig> valueOffset = (_o.Value == null) ? default(Offset<IFlowTextConfig>) : IFlowTextConfig.Pack(builder, _o.Value);
			return Record_Int_IFlowTextConfig.CreateRecord_Int_IFlowTextConfig(builder, _o.Key, valueOffset);
		}

		// Token: 0x0401258B RID: 75147
		private Table __p;
	}
}
