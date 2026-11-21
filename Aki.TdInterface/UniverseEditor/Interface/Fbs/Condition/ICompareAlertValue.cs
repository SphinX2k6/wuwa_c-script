using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200506A RID: 20586
	public struct ICompareAlertValue : IFlatbufferObject
	{
		// Token: 0x17009357 RID: 37719
		// (get) Token: 0x060202FB RID: 131835 RVA: 0x00476620 File Offset: 0x00474820
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060202FC RID: 131836 RVA: 0x0047662D File Offset: 0x0047482D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060202FD RID: 131837 RVA: 0x00476634 File Offset: 0x00474834
		public static ICompareAlertValue GetRootAsICompareAlertValue(ByteBuffer _bb)
		{
			return ICompareAlertValue.GetRootAsICompareAlertValue(_bb, default(ICompareAlertValue));
		}

		// Token: 0x060202FE RID: 131838 RVA: 0x00476650 File Offset: 0x00474850
		public static ICompareAlertValue GetRootAsICompareAlertValue(ByteBuffer _bb, ICompareAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060202FF RID: 131839 RVA: 0x0047666D File Offset: 0x0047486D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020300 RID: 131840 RVA: 0x0047667C File Offset: 0x0047487C
		public ICompareAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009358 RID: 37720
		// (get) Token: 0x06020301 RID: 131841 RVA: 0x0047668C File Offset: 0x0047488C
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

		// Token: 0x17009359 RID: 37721
		// (get) Token: 0x06020302 RID: 131842 RVA: 0x004766C8 File Offset: 0x004748C8
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700935A RID: 37722
		// (get) Token: 0x06020303 RID: 131843 RVA: 0x00476704 File Offset: 0x00474904
		public ECompare CompareType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700935B RID: 37723
		// (get) Token: 0x06020304 RID: 131844 RVA: 0x00476740 File Offset: 0x00474940
		public TComparedAlertValue CompareValueType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TComparedAlertValue.NONE;
				}
				return (TComparedAlertValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020305 RID: 131845 RVA: 0x00476780 File Offset: 0x00474980
		public TTable? CompareValue<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020306 RID: 131846 RVA: 0x004767C8 File Offset: 0x004749C8
		public ICompareCustomAlertValue CompareValueAsICompareCustomAlertValue()
		{
			return this.CompareValue<ICompareCustomAlertValue>().Value;
		}

		// Token: 0x06020307 RID: 131847 RVA: 0x004767E4 File Offset: 0x004749E4
		public ICompareMaxAlertValue CompareValueAsICompareMaxAlertValue()
		{
			return this.CompareValue<ICompareMaxAlertValue>().Value;
		}

		// Token: 0x06020308 RID: 131848 RVA: 0x00476800 File Offset: 0x00474A00
		public ICompareMinAlertValue CompareValueAsICompareMinAlertValue()
		{
			return this.CompareValue<ICompareMinAlertValue>().Value;
		}

		// Token: 0x06020309 RID: 131849 RVA: 0x0047681B File Offset: 0x00474A1B
		public static Offset<ICompareAlertValue> CreateICompareAlertValue(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int AreaId = 0, ECompare CompareType = ECompare.Eq, TComparedAlertValue CompareValue_type = TComparedAlertValue.NONE, int CompareValueOffset = 0)
		{
			builder.StartTable(5);
			ICompareAlertValue.AddCompareValue(builder, CompareValueOffset);
			ICompareAlertValue.AddAreaId(builder, AreaId);
			ICompareAlertValue.AddCompareValueType(builder, CompareValue_type);
			ICompareAlertValue.AddCompareType(builder, CompareType);
			ICompareAlertValue.AddType(builder, Type);
			return ICompareAlertValue.EndICompareAlertValue(builder);
		}

		// Token: 0x0602030A RID: 131850 RVA: 0x0047684F File Offset: 0x00474A4F
		public static void StartICompareAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602030B RID: 131851 RVA: 0x00476858 File Offset: 0x00474A58
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602030C RID: 131852 RVA: 0x00476863 File Offset: 0x00474A63
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602030D RID: 131853 RVA: 0x0047686E File Offset: 0x00474A6E
		public static void AddCompareType(FlatBufferBuilder builder, ECompare compareType)
		{
			builder.AddByte(2, (byte)compareType, 0);
		}

		// Token: 0x0602030E RID: 131854 RVA: 0x00476879 File Offset: 0x00474A79
		public static void AddCompareValueType(FlatBufferBuilder builder, TComparedAlertValue compareValueType)
		{
			builder.AddByte(3, (byte)compareValueType, 0);
		}

		// Token: 0x0602030F RID: 131855 RVA: 0x00476884 File Offset: 0x00474A84
		public static void AddCompareValue(FlatBufferBuilder builder, int compareValueOffset)
		{
			builder.AddOffset(4, compareValueOffset, 0);
		}

		// Token: 0x06020310 RID: 131856 RVA: 0x0047688F File Offset: 0x00474A8F
		public static Offset<ICompareAlertValue> EndICompareAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<ICompareAlertValue>(builder.EndTable());
		}

		// Token: 0x06020311 RID: 131857 RVA: 0x0047689C File Offset: 0x00474A9C
		public ICompareAlertValueT UnPack()
		{
			ICompareAlertValueT compareAlertValueT = new ICompareAlertValueT();
			this.UnPackTo(compareAlertValueT);
			return compareAlertValueT;
		}

		// Token: 0x06020312 RID: 131858 RVA: 0x004768B8 File Offset: 0x00474AB8
		public void UnPackTo(ICompareAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.CompareType = this.CompareType;
			_o.CompareValue = new TComparedAlertValueUnion();
			_o.CompareValue.Type = this.CompareValueType;
			switch (this.CompareValueType)
			{
			case TComparedAlertValue.ICompareCustomAlertValue:
				_o.CompareValue.Value = ((this.CompareValue<ICompareCustomAlertValue>() != null) ? this.CompareValue<ICompareCustomAlertValue>().Value.UnPack() : null);
				return;
			case TComparedAlertValue.ICompareMaxAlertValue:
				_o.CompareValue.Value = ((this.CompareValue<ICompareMaxAlertValue>() != null) ? this.CompareValue<ICompareMaxAlertValue>().Value.UnPack() : null);
				return;
			case TComparedAlertValue.ICompareMinAlertValue:
				_o.CompareValue.Value = ((this.CompareValue<ICompareMinAlertValue>() != null) ? this.CompareValue<ICompareMinAlertValue>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06020313 RID: 131859 RVA: 0x004769C4 File Offset: 0x00474BC4
		public static Offset<ICompareAlertValue> Pack(FlatBufferBuilder builder, ICompareAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareAlertValue>);
			}
			TComparedAlertValue compareValue_type = (_o.CompareValue == null) ? TComparedAlertValue.NONE : _o.CompareValue.Type;
			int compareValueOffset = (_o.CompareValue == null) ? 0 : TComparedAlertValueUnion.Pack(builder, _o.CompareValue);
			return ICompareAlertValue.CreateICompareAlertValue(builder, _o.Type, _o.AreaId, _o.CompareType, compareValue_type, compareValueOffset);
		}

		// Token: 0x0400DF53 RID: 57171
		private Table __p;
	}
}
