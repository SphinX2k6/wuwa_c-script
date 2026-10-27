using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A39 RID: 19001
	public struct ICheckGiantStableValue : IFlatbufferObject
	{
		// Token: 0x17008990 RID: 35216
		// (get) Token: 0x0601DBF2 RID: 121842 RVA: 0x0042EF24 File Offset: 0x0042D124
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DBF3 RID: 121843 RVA: 0x0042EF31 File Offset: 0x0042D131
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DBF4 RID: 121844 RVA: 0x0042EF38 File Offset: 0x0042D138
		public static ICheckGiantStableValue GetRootAsICheckGiantStableValue(ByteBuffer _bb)
		{
			return ICheckGiantStableValue.GetRootAsICheckGiantStableValue(_bb, default(ICheckGiantStableValue));
		}

		// Token: 0x0601DBF5 RID: 121845 RVA: 0x0042EF54 File Offset: 0x0042D154
		public static ICheckGiantStableValue GetRootAsICheckGiantStableValue(ByteBuffer _bb, ICheckGiantStableValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DBF6 RID: 121846 RVA: 0x0042EF71 File Offset: 0x0042D171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DBF7 RID: 121847 RVA: 0x0042EF80 File Offset: 0x0042D180
		public ICheckGiantStableValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008991 RID: 35217
		// (get) Token: 0x0601DBF8 RID: 121848 RVA: 0x0042EF90 File Offset: 0x0042D190
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008992 RID: 35218
		// (get) Token: 0x0601DBF9 RID: 121849 RVA: 0x0042EFCC File Offset: 0x0042D1CC
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

		// Token: 0x0601DBFA RID: 121850 RVA: 0x0042F008 File Offset: 0x0042D208
		public TTable? StableValueOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DBFB RID: 121851 RVA: 0x0042F04C File Offset: 0x0042D24C
		public IGiantStableValueRegion StableValueOptionAsIGiantStableValueRegion()
		{
			return this.StableValueOption<IGiantStableValueRegion>().Value;
		}

		// Token: 0x0601DBFC RID: 121852 RVA: 0x0042F068 File Offset: 0x0042D268
		public IGiantStableValueTotal StableValueOptionAsIGiantStableValueTotal()
		{
			return this.StableValueOption<IGiantStableValueTotal>().Value;
		}

		// Token: 0x0601DBFD RID: 121853 RVA: 0x0042F083 File Offset: 0x0042D283
		public static Offset<ICheckGiantStableValue> CreateICheckGiantStableValue(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TGiantStableValue StableValueOption_type = TGiantStableValue.NONE, int StableValueOptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckGiantStableValue.AddStableValueOption(builder, StableValueOptionOffset);
			ICheckGiantStableValue.AddStableValueOptionType(builder, StableValueOption_type);
			ICheckGiantStableValue.AddType(builder, Type);
			return ICheckGiantStableValue.EndICheckGiantStableValue(builder);
		}

		// Token: 0x0601DBFE RID: 121854 RVA: 0x0042F0A7 File Offset: 0x0042D2A7
		public static void StartICheckGiantStableValue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DBFF RID: 121855 RVA: 0x0042F0B0 File Offset: 0x0042D2B0
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DC00 RID: 121856 RVA: 0x0042F0BB File Offset: 0x0042D2BB
		public static void AddStableValueOptionType(FlatBufferBuilder builder, TGiantStableValue stableValueOptionType)
		{
			builder.AddByte(1, (byte)stableValueOptionType, 0);
		}

		// Token: 0x0601DC01 RID: 121857 RVA: 0x0042F0C6 File Offset: 0x0042D2C6
		public static void AddStableValueOption(FlatBufferBuilder builder, int stableValueOptionOffset)
		{
			builder.AddOffset(2, stableValueOptionOffset, 0);
		}

		// Token: 0x0601DC02 RID: 121858 RVA: 0x0042F0D1 File Offset: 0x0042D2D1
		public static Offset<ICheckGiantStableValue> EndICheckGiantStableValue(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantStableValue>(builder.EndTable());
		}

		// Token: 0x0601DC03 RID: 121859 RVA: 0x0042F0E0 File Offset: 0x0042D2E0
		public ICheckGiantStableValueT UnPack()
		{
			ICheckGiantStableValueT checkGiantStableValueT = new ICheckGiantStableValueT();
			this.UnPackTo(checkGiantStableValueT);
			return checkGiantStableValueT;
		}

		// Token: 0x0601DC04 RID: 121860 RVA: 0x0042F0FC File Offset: 0x0042D2FC
		public void UnPackTo(ICheckGiantStableValueT _o)
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

		// Token: 0x0601DC05 RID: 121861 RVA: 0x0042F1AC File Offset: 0x0042D3AC
		public static Offset<ICheckGiantStableValue> Pack(FlatBufferBuilder builder, ICheckGiantStableValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGiantStableValue>);
			}
			TGiantStableValue stableValueOption_type = (_o.StableValueOption == null) ? TGiantStableValue.NONE : _o.StableValueOption.Type;
			int stableValueOptionOffset = (_o.StableValueOption == null) ? 0 : TGiantStableValueUnion.Pack(builder, _o.StableValueOption);
			return ICheckGiantStableValue.CreateICheckGiantStableValue(builder, _o.Type, stableValueOption_type, stableValueOptionOffset);
		}

		// Token: 0x0400D28F RID: 53903
		private Table __p;
	}
}
