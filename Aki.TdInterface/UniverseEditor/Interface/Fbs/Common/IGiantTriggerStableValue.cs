using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006428 RID: 25640
	public struct IGiantTriggerStableValue : IFlatbufferObject
	{
		// Token: 0x1700BD5B RID: 48475
		// (get) Token: 0x0602B908 RID: 178440 RVA: 0x005EE9B2 File Offset: 0x005ECBB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B909 RID: 178441 RVA: 0x005EE9BF File Offset: 0x005ECBBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B90A RID: 178442 RVA: 0x005EE9C8 File Offset: 0x005ECBC8
		public static IGiantTriggerStableValue GetRootAsIGiantTriggerStableValue(ByteBuffer _bb)
		{
			return IGiantTriggerStableValue.GetRootAsIGiantTriggerStableValue(_bb, default(IGiantTriggerStableValue));
		}

		// Token: 0x0602B90B RID: 178443 RVA: 0x005EE9E4 File Offset: 0x005ECBE4
		public static IGiantTriggerStableValue GetRootAsIGiantTriggerStableValue(ByteBuffer _bb, IGiantTriggerStableValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B90C RID: 178444 RVA: 0x005EEA01 File Offset: 0x005ECC01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B90D RID: 178445 RVA: 0x005EEA10 File Offset: 0x005ECC10
		public IGiantTriggerStableValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD5C RID: 48476
		// (get) Token: 0x0602B90E RID: 178446 RVA: 0x005EEA20 File Offset: 0x005ECC20
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

		// Token: 0x1700BD5D RID: 48477
		// (get) Token: 0x0602B90F RID: 178447 RVA: 0x005EEA5C File Offset: 0x005ECC5C
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

		// Token: 0x0602B910 RID: 178448 RVA: 0x005EEA98 File Offset: 0x005ECC98
		public TTable? StableValueOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B911 RID: 178449 RVA: 0x005EEADC File Offset: 0x005ECCDC
		public IGiantStableValueRegion StableValueOptionAsIGiantStableValueRegion()
		{
			return this.StableValueOption<IGiantStableValueRegion>().Value;
		}

		// Token: 0x0602B912 RID: 178450 RVA: 0x005EEAF8 File Offset: 0x005ECCF8
		public IGiantStableValueTotal StableValueOptionAsIGiantStableValueTotal()
		{
			return this.StableValueOption<IGiantStableValueTotal>().Value;
		}

		// Token: 0x0602B913 RID: 178451 RVA: 0x005EEB13 File Offset: 0x005ECD13
		public static Offset<IGiantTriggerStableValue> CreateIGiantTriggerStableValue(FlatBufferBuilder builder, EGiantTriggerType Type = EGiantTriggerType.RoleState, TGiantStableValue StableValueOption_type = TGiantStableValue.NONE, int StableValueOptionOffset = 0)
		{
			builder.StartTable(3);
			IGiantTriggerStableValue.AddStableValueOption(builder, StableValueOptionOffset);
			IGiantTriggerStableValue.AddStableValueOptionType(builder, StableValueOption_type);
			IGiantTriggerStableValue.AddType(builder, Type);
			return IGiantTriggerStableValue.EndIGiantTriggerStableValue(builder);
		}

		// Token: 0x0602B914 RID: 178452 RVA: 0x005EEB37 File Offset: 0x005ECD37
		public static void StartIGiantTriggerStableValue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B915 RID: 178453 RVA: 0x005EEB40 File Offset: 0x005ECD40
		public static void AddType(FlatBufferBuilder builder, EGiantTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B916 RID: 178454 RVA: 0x005EEB4B File Offset: 0x005ECD4B
		public static void AddStableValueOptionType(FlatBufferBuilder builder, TGiantStableValue stableValueOptionType)
		{
			builder.AddByte(1, (byte)stableValueOptionType, 0);
		}

		// Token: 0x0602B917 RID: 178455 RVA: 0x005EEB56 File Offset: 0x005ECD56
		public static void AddStableValueOption(FlatBufferBuilder builder, int stableValueOptionOffset)
		{
			builder.AddOffset(2, stableValueOptionOffset, 0);
		}

		// Token: 0x0602B918 RID: 178456 RVA: 0x005EEB61 File Offset: 0x005ECD61
		public static Offset<IGiantTriggerStableValue> EndIGiantTriggerStableValue(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerStableValue>(builder.EndTable());
		}

		// Token: 0x0602B919 RID: 178457 RVA: 0x005EEB70 File Offset: 0x005ECD70
		public IGiantTriggerStableValueT UnPack()
		{
			IGiantTriggerStableValueT giantTriggerStableValueT = new IGiantTriggerStableValueT();
			this.UnPackTo(giantTriggerStableValueT);
			return giantTriggerStableValueT;
		}

		// Token: 0x0602B91A RID: 178458 RVA: 0x005EEB8C File Offset: 0x005ECD8C
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

		// Token: 0x0602B91B RID: 178459 RVA: 0x005EEC3C File Offset: 0x005ECE3C
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

		// Token: 0x04010530 RID: 66864
		private Table __p;
	}
}
