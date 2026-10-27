using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DEB RID: 24043
	public struct IGiantTriggerStableValue : IFlatbufferObject
	{
		// Token: 0x1700B3F5 RID: 46069
		// (get) Token: 0x0602927E RID: 168574 RVA: 0x005A5C82 File Offset: 0x005A3E82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602927F RID: 168575 RVA: 0x005A5C8F File Offset: 0x005A3E8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029280 RID: 168576 RVA: 0x005A5C98 File Offset: 0x005A3E98
		public static IGiantTriggerStableValue GetRootAsIGiantTriggerStableValue(ByteBuffer _bb)
		{
			return IGiantTriggerStableValue.GetRootAsIGiantTriggerStableValue(_bb, default(IGiantTriggerStableValue));
		}

		// Token: 0x06029281 RID: 168577 RVA: 0x005A5CB4 File Offset: 0x005A3EB4
		public static IGiantTriggerStableValue GetRootAsIGiantTriggerStableValue(ByteBuffer _bb, IGiantTriggerStableValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029282 RID: 168578 RVA: 0x005A5CD1 File Offset: 0x005A3ED1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029283 RID: 168579 RVA: 0x005A5CE0 File Offset: 0x005A3EE0
		public IGiantTriggerStableValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3F6 RID: 46070
		// (get) Token: 0x06029284 RID: 168580 RVA: 0x005A5CF0 File Offset: 0x005A3EF0
		public EGiantTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantTriggerType.RoleState;
				}
				return (EGiantTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3F7 RID: 46071
		// (get) Token: 0x06029285 RID: 168581 RVA: 0x005A5D2C File Offset: 0x005A3F2C
		public TGiantStableValue StableValueOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGiantStableValue.NONE;
				}
				return (TGiantStableValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029286 RID: 168582 RVA: 0x005A5D68 File Offset: 0x005A3F68
		public TTable? StableValueOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029287 RID: 168583 RVA: 0x005A5DAC File Offset: 0x005A3FAC
		public IGiantStableValueRegion StableValueOptionAsIGiantStableValueRegion()
		{
			return this.StableValueOption<IGiantStableValueRegion>().Value;
		}

		// Token: 0x06029288 RID: 168584 RVA: 0x005A5DC8 File Offset: 0x005A3FC8
		public IGiantStableValueTotal StableValueOptionAsIGiantStableValueTotal()
		{
			return this.StableValueOption<IGiantStableValueTotal>().Value;
		}

		// Token: 0x06029289 RID: 168585 RVA: 0x005A5DE3 File Offset: 0x005A3FE3
		public static Offset<IGiantTriggerStableValue> CreateIGiantTriggerStableValue(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState, TGiantStableValue StableValueOption_type = TGiantStableValue.NONE, int StableValueOptionOffset = 0)
		{
			builder.StartTable(3);
			IGiantTriggerStableValue.AddStableValueOption(builder, StableValueOptionOffset);
			IGiantTriggerStableValue.AddStableValueOptionType(builder, StableValueOption_type);
			IGiantTriggerStableValue.AddType(builder, Type);
			return IGiantTriggerStableValue.EndIGiantTriggerStableValue(builder);
		}

		// Token: 0x0602928A RID: 168586 RVA: 0x005A5E07 File Offset: 0x005A4007
		public static void StartIGiantTriggerStableValue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602928B RID: 168587 RVA: 0x005A5E10 File Offset: 0x005A4010
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602928C RID: 168588 RVA: 0x005A5E1B File Offset: 0x005A401B
		public static void AddStableValueOptionType(FlatBufferBuilder builder, TGiantStableValue stableValueOptionType)
		{
			builder.AddByte(1, (byte)stableValueOptionType, 0);
		}

		// Token: 0x0602928D RID: 168589 RVA: 0x005A5E26 File Offset: 0x005A4026
		public static void AddStableValueOption(FlatBufferBuilder builder, int stableValueOptionOffset)
		{
			builder.AddOffset(2, stableValueOptionOffset, 0);
		}

		// Token: 0x0602928E RID: 168590 RVA: 0x005A5E31 File Offset: 0x005A4031
		public static Offset<IGiantTriggerStableValue> EndIGiantTriggerStableValue(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerStableValue>(builder.EndTable());
		}

		// Token: 0x0602928F RID: 168591 RVA: 0x005A5E40 File Offset: 0x005A4040
		public IGiantTriggerStableValueT UnPack()
		{
			IGiantTriggerStableValueT giantTriggerStableValueT = new IGiantTriggerStableValueT();
			this.UnPackTo(giantTriggerStableValueT);
			return giantTriggerStableValueT;
		}

		// Token: 0x06029290 RID: 168592 RVA: 0x005A5E5C File Offset: 0x005A405C
		public void UnPackTo(IGiantTriggerStableValueT _o)
		{
			_o.Type = this.Type;
			_o.StableValueOption = new TGiantStableValueUnion();
			_o.StableValueOption.Type = this.StableValueOptionType;
			TGiantStableValue stableValueOptionType = this.StableValueOptionType;
			if (stableValueOptionType == TGiantStableValue.IGiantStableValueRegion)
			{
				_o.StableValueOption.Value = ((this.StableValueOption<IGiantStableValueRegion>() != null) ? this.StableValueOption<IGiantStableValueRegion>().Value.UnPack() : null);
				return;
			}
			if (stableValueOptionType != TGiantStableValue.IGiantStableValueTotal)
			{
				return;
			}
			_o.StableValueOption.Value = ((this.StableValueOption<IGiantStableValueTotal>() != null) ? this.StableValueOption<IGiantStableValueTotal>().Value.UnPack() : null);
		}

		// Token: 0x06029291 RID: 168593 RVA: 0x005A5F0C File Offset: 0x005A410C
		public static Offset<IGiantTriggerStableValue> Pack(FlatBufferBuilder builder, IGiantTriggerStableValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerStableValue>);
			}
			TGiantStableValue stableValueOption_type = (_o.StableValueOption == null) ? TGiantStableValue.NONE : _o.StableValueOption.Type;
			int stableValueOptionOffset = (_o.StableValueOption == null) ? 0 : TGiantStableValueUnion.Pack(builder, _o.StableValueOption);
			return IGiantTriggerStableValue.CreateIGiantTriggerStableValue(builder, _o.Type, stableValueOption_type, stableValueOptionOffset);
		}

		// Token: 0x0400F7D5 RID: 63445
		private Table __p;
	}
}
