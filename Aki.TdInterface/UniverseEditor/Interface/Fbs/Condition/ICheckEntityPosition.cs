using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ECF RID: 20175
	public struct ICheckEntityPosition : IFlatbufferObject
	{
		// Token: 0x17009009 RID: 36873
		// (get) Token: 0x0601F4F1 RID: 128241 RVA: 0x0045D120 File Offset: 0x0045B320
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F4F2 RID: 128242 RVA: 0x0045D12D File Offset: 0x0045B32D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F4F3 RID: 128243 RVA: 0x0045D134 File Offset: 0x0045B334
		public static ICheckEntityPosition GetRootAsICheckEntityPosition(ByteBuffer _bb)
		{
			return ICheckEntityPosition.GetRootAsICheckEntityPosition(_bb, default(ICheckEntityPosition));
		}

		// Token: 0x0601F4F4 RID: 128244 RVA: 0x0045D150 File Offset: 0x0045B350
		public static ICheckEntityPosition GetRootAsICheckEntityPosition(ByteBuffer _bb, ICheckEntityPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F4F5 RID: 128245 RVA: 0x0045D16D File Offset: 0x0045B36D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F4F6 RID: 128246 RVA: 0x0045D17C File Offset: 0x0045B37C
		public ICheckEntityPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700900A RID: 36874
		// (get) Token: 0x0601F4F7 RID: 128247 RVA: 0x0045D18C File Offset: 0x0045B38C
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

		// Token: 0x1700900B RID: 36875
		// (get) Token: 0x0601F4F8 RID: 128248 RVA: 0x0045D1C8 File Offset: 0x0045B3C8
		public int EntityId
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

		// Token: 0x1700900C RID: 36876
		// (get) Token: 0x0601F4F9 RID: 128249 RVA: 0x0045D204 File Offset: 0x0045B404
		public TRange RangeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TRange.NONE;
				}
				return (TRange)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F4FA RID: 128250 RVA: 0x0045D240 File Offset: 0x0045B440
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F4FB RID: 128251 RVA: 0x0045D288 File Offset: 0x0045B488
		public IBoxRange RangeAsIBoxRange()
		{
			return this.Range<IBoxRange>().Value;
		}

		// Token: 0x0601F4FC RID: 128252 RVA: 0x0045D2A4 File Offset: 0x0045B4A4
		public ICircleRange RangeAsICircleRange()
		{
			return this.Range<ICircleRange>().Value;
		}

		// Token: 0x0601F4FD RID: 128253 RVA: 0x0045D2C0 File Offset: 0x0045B4C0
		public ICylinder RangeAsICylinder()
		{
			return this.Range<ICylinder>().Value;
		}

		// Token: 0x1700900D RID: 36877
		// (get) Token: 0x0601F4FE RID: 128254 RVA: 0x0045D2DC File Offset: 0x0045B4DC
		public bool IsOnRange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F4FF RID: 128255 RVA: 0x0045D31C File Offset: 0x0045B51C
		public static Offset<ICheckEntityPosition> CreateICheckEntityPosition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, TRange Range_type = TRange.NONE, int RangeOffset = 0, bool IsOnRange = false)
		{
			builder.StartTable(5);
			ICheckEntityPosition.AddRange(builder, RangeOffset);
			ICheckEntityPosition.AddEntityId(builder, EntityId);
			ICheckEntityPosition.AddIsOnRange(builder, IsOnRange);
			ICheckEntityPosition.AddRangeType(builder, Range_type);
			ICheckEntityPosition.AddType(builder, Type);
			return ICheckEntityPosition.EndICheckEntityPosition(builder);
		}

		// Token: 0x0601F500 RID: 128256 RVA: 0x0045D350 File Offset: 0x0045B550
		public static void StartICheckEntityPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F501 RID: 128257 RVA: 0x0045D359 File Offset: 0x0045B559
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F502 RID: 128258 RVA: 0x0045D364 File Offset: 0x0045B564
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601F503 RID: 128259 RVA: 0x0045D36F File Offset: 0x0045B56F
		public static void AddRangeType(FlatBufferBuilder builder, TRange rangeType)
		{
			builder.AddByte(2, (byte)rangeType, 0);
		}

		// Token: 0x0601F504 RID: 128260 RVA: 0x0045D37A File Offset: 0x0045B57A
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(3, rangeOffset, 0);
		}

		// Token: 0x0601F505 RID: 128261 RVA: 0x0045D385 File Offset: 0x0045B585
		public static void AddIsOnRange(FlatBufferBuilder builder, bool isOnRange)
		{
			builder.AddBool(4, isOnRange, false);
		}

		// Token: 0x0601F506 RID: 128262 RVA: 0x0045D390 File Offset: 0x0045B590
		public static Offset<ICheckEntityPosition> EndICheckEntityPosition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityPosition>(builder.EndTable());
		}

		// Token: 0x0601F507 RID: 128263 RVA: 0x0045D3A0 File Offset: 0x0045B5A0
		public ICheckEntityPositionT UnPack()
		{
			ICheckEntityPositionT checkEntityPositionT = new ICheckEntityPositionT();
			this.UnPackTo(checkEntityPositionT);
			return checkEntityPositionT;
		}

		// Token: 0x0601F508 RID: 128264 RVA: 0x0045D3BC File Offset: 0x0045B5BC
		public void UnPackTo(ICheckEntityPositionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Range = new TRangeUnion();
			_o.Range.Type = this.RangeType;
			switch (this.RangeType)
			{
			case TRange.IBoxRange:
				_o.Range.Value = ((this.Range<IBoxRange>() != null) ? this.Range<IBoxRange>().Value.UnPack() : null);
				break;
			case TRange.ICircleRange:
				_o.Range.Value = ((this.Range<ICircleRange>() != null) ? this.Range<ICircleRange>().Value.UnPack() : null);
				break;
			case TRange.ICylinder:
				_o.Range.Value = ((this.Range<ICylinder>() != null) ? this.Range<ICylinder>().Value.UnPack() : null);
				break;
			}
			_o.IsOnRange = this.IsOnRange;
		}

		// Token: 0x0601F509 RID: 128265 RVA: 0x0045D4D0 File Offset: 0x0045B6D0
		public static Offset<ICheckEntityPosition> Pack(FlatBufferBuilder builder, ICheckEntityPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityPosition>);
			}
			TRange range_type = (_o.Range == null) ? TRange.NONE : _o.Range.Type;
			int rangeOffset = (_o.Range == null) ? 0 : TRangeUnion.Pack(builder, _o.Range);
			return ICheckEntityPosition.CreateICheckEntityPosition(builder, _o.Type, _o.EntityId, range_type, rangeOffset, _o.IsOnRange);
		}

		// Token: 0x0400DD2B RID: 56619
		private Table __p;
	}
}
