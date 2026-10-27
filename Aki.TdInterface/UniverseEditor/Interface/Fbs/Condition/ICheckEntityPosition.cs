using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A0F RID: 18959
	public struct ICheckEntityPosition : IFlatbufferObject
	{
		// Token: 0x17008939 RID: 35129
		// (get) Token: 0x0601DA7E RID: 121470 RVA: 0x0042C4B4 File Offset: 0x0042A6B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA7F RID: 121471 RVA: 0x0042C4C1 File Offset: 0x0042A6C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA80 RID: 121472 RVA: 0x0042C4C8 File Offset: 0x0042A6C8
		public static ICheckEntityPosition GetRootAsICheckEntityPosition(ByteBuffer _bb)
		{
			return ICheckEntityPosition.GetRootAsICheckEntityPosition(_bb, default(ICheckEntityPosition));
		}

		// Token: 0x0601DA81 RID: 121473 RVA: 0x0042C4E4 File Offset: 0x0042A6E4
		public static ICheckEntityPosition GetRootAsICheckEntityPosition(ByteBuffer _bb, ICheckEntityPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA82 RID: 121474 RVA: 0x0042C501 File Offset: 0x0042A701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA83 RID: 121475 RVA: 0x0042C510 File Offset: 0x0042A710
		public ICheckEntityPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700893A RID: 35130
		// (get) Token: 0x0601DA84 RID: 121476 RVA: 0x0042C520 File Offset: 0x0042A720
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

		// Token: 0x1700893B RID: 35131
		// (get) Token: 0x0601DA85 RID: 121477 RVA: 0x0042C55C File Offset: 0x0042A75C
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

		// Token: 0x1700893C RID: 35132
		// (get) Token: 0x0601DA86 RID: 121478 RVA: 0x0042C598 File Offset: 0x0042A798
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

		// Token: 0x0601DA87 RID: 121479 RVA: 0x0042C5D4 File Offset: 0x0042A7D4
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DA88 RID: 121480 RVA: 0x0042C61C File Offset: 0x0042A81C
		public IBoxRange RangeAsIBoxRange()
		{
			return this.Range<IBoxRange>().Value;
		}

		// Token: 0x0601DA89 RID: 121481 RVA: 0x0042C638 File Offset: 0x0042A838
		public ICircleRange RangeAsICircleRange()
		{
			return this.Range<ICircleRange>().Value;
		}

		// Token: 0x0601DA8A RID: 121482 RVA: 0x0042C654 File Offset: 0x0042A854
		public ICylinder RangeAsICylinder()
		{
			return this.Range<ICylinder>().Value;
		}

		// Token: 0x1700893D RID: 35133
		// (get) Token: 0x0601DA8B RID: 121483 RVA: 0x0042C670 File Offset: 0x0042A870
		public bool IsOnRange
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DA8C RID: 121484 RVA: 0x0042C6B0 File Offset: 0x0042A8B0
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

		// Token: 0x0601DA8D RID: 121485 RVA: 0x0042C6E4 File Offset: 0x0042A8E4
		public static void StartICheckEntityPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601DA8E RID: 121486 RVA: 0x0042C6ED File Offset: 0x0042A8ED
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DA8F RID: 121487 RVA: 0x0042C6F8 File Offset: 0x0042A8F8
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601DA90 RID: 121488 RVA: 0x0042C703 File Offset: 0x0042A903
		public static void AddRangeType(FlatBufferBuilder builder, TRange rangeType)
		{
			builder.AddByte(2, (byte)rangeType, 0);
		}

		// Token: 0x0601DA91 RID: 121489 RVA: 0x0042C70E File Offset: 0x0042A90E
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(3, rangeOffset, 0);
		}

		// Token: 0x0601DA92 RID: 121490 RVA: 0x0042C719 File Offset: 0x0042A919
		public static void AddIsOnRange(FlatBufferBuilder builder, bool isOnRange)
		{
			builder.AddBool(4, isOnRange, false);
		}

		// Token: 0x0601DA93 RID: 121491 RVA: 0x0042C724 File Offset: 0x0042A924
		public static Offset<ICheckEntityPosition> EndICheckEntityPosition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityPosition>(builder.EndTable());
		}

		// Token: 0x0601DA94 RID: 121492 RVA: 0x0042C734 File Offset: 0x0042A934
		public ICheckEntityPositionT UnPack()
		{
			ICheckEntityPositionT checkEntityPositionT = new ICheckEntityPositionT();
			this.UnPackTo(checkEntityPositionT);
			return checkEntityPositionT;
		}

		// Token: 0x0601DA95 RID: 121493 RVA: 0x0042C750 File Offset: 0x0042A950
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

		// Token: 0x0601DA96 RID: 121494 RVA: 0x0042C864 File Offset: 0x0042AA64
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

		// Token: 0x0400D257 RID: 53847
		private Table __p;
	}
}
