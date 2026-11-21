using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD1 RID: 20433
	public struct ICheckPlayerPosition : IFlatbufferObject
	{
		// Token: 0x17009227 RID: 37415
		// (get) Token: 0x0601FDC5 RID: 130501 RVA: 0x0046CAEC File Offset: 0x0046ACEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FDC6 RID: 130502 RVA: 0x0046CAF9 File Offset: 0x0046ACF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FDC7 RID: 130503 RVA: 0x0046CB00 File Offset: 0x0046AD00
		public static ICheckPlayerPosition GetRootAsICheckPlayerPosition(ByteBuffer _bb)
		{
			return ICheckPlayerPosition.GetRootAsICheckPlayerPosition(_bb, default(ICheckPlayerPosition));
		}

		// Token: 0x0601FDC8 RID: 130504 RVA: 0x0046CB1C File Offset: 0x0046AD1C
		public static ICheckPlayerPosition GetRootAsICheckPlayerPosition(ByteBuffer _bb, ICheckPlayerPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FDC9 RID: 130505 RVA: 0x0046CB39 File Offset: 0x0046AD39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FDCA RID: 130506 RVA: 0x0046CB48 File Offset: 0x0046AD48
		public ICheckPlayerPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009228 RID: 37416
		// (get) Token: 0x0601FDCB RID: 130507 RVA: 0x0046CB58 File Offset: 0x0046AD58
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

		// Token: 0x17009229 RID: 37417
		// (get) Token: 0x0601FDCC RID: 130508 RVA: 0x0046CB94 File Offset: 0x0046AD94
		public TRange RangeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TRange.NONE;
				}
				return (TRange)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FDCD RID: 130509 RVA: 0x0046CBD0 File Offset: 0x0046ADD0
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FDCE RID: 130510 RVA: 0x0046CC14 File Offset: 0x0046AE14
		public IBoxRange RangeAsIBoxRange()
		{
			return this.Range<IBoxRange>().Value;
		}

		// Token: 0x0601FDCF RID: 130511 RVA: 0x0046CC30 File Offset: 0x0046AE30
		public ICircleRange RangeAsICircleRange()
		{
			return this.Range<ICircleRange>().Value;
		}

		// Token: 0x0601FDD0 RID: 130512 RVA: 0x0046CC4C File Offset: 0x0046AE4C
		public ICylinder RangeAsICylinder()
		{
			return this.Range<ICylinder>().Value;
		}

		// Token: 0x1700922A RID: 37418
		// (get) Token: 0x0601FDD1 RID: 130513 RVA: 0x0046CC68 File Offset: 0x0046AE68
		public bool IsOnRange
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FDD2 RID: 130514 RVA: 0x0046CCA8 File Offset: 0x0046AEA8
		public static Offset<ICheckPlayerPosition> CreateICheckPlayerPosition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TRange Range_type = TRange.NONE, int RangeOffset = 0, bool IsOnRange = false)
		{
			builder.StartTable(4);
			ICheckPlayerPosition.AddRange(builder, RangeOffset);
			ICheckPlayerPosition.AddIsOnRange(builder, IsOnRange);
			ICheckPlayerPosition.AddRangeType(builder, Range_type);
			ICheckPlayerPosition.AddType(builder, Type);
			return ICheckPlayerPosition.EndICheckPlayerPosition(builder);
		}

		// Token: 0x0601FDD3 RID: 130515 RVA: 0x0046CCD4 File Offset: 0x0046AED4
		public static void StartICheckPlayerPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FDD4 RID: 130516 RVA: 0x0046CCDD File Offset: 0x0046AEDD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FDD5 RID: 130517 RVA: 0x0046CCE8 File Offset: 0x0046AEE8
		public static void AddRangeType(FlatBufferBuilder builder, TRange rangeType)
		{
			builder.AddByte(1, (byte)rangeType, 0);
		}

		// Token: 0x0601FDD6 RID: 130518 RVA: 0x0046CCF3 File Offset: 0x0046AEF3
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(2, rangeOffset, 0);
		}

		// Token: 0x0601FDD7 RID: 130519 RVA: 0x0046CCFE File Offset: 0x0046AEFE
		public static void AddIsOnRange(FlatBufferBuilder builder, bool isOnRange)
		{
			builder.AddBool(3, isOnRange, false);
		}

		// Token: 0x0601FDD8 RID: 130520 RVA: 0x0046CD09 File Offset: 0x0046AF09
		public static Offset<ICheckPlayerPosition> EndICheckPlayerPosition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerPosition>(builder.EndTable());
		}

		// Token: 0x0601FDD9 RID: 130521 RVA: 0x0046CD18 File Offset: 0x0046AF18
		public ICheckPlayerPositionT UnPack()
		{
			ICheckPlayerPositionT checkPlayerPositionT = new ICheckPlayerPositionT();
			this.UnPackTo(checkPlayerPositionT);
			return checkPlayerPositionT;
		}

		// Token: 0x0601FDDA RID: 130522 RVA: 0x0046CD34 File Offset: 0x0046AF34
		public void UnPackTo(ICheckPlayerPositionT _o)
		{
			_o.Type = this.Type;
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

		// Token: 0x0601FDDB RID: 130523 RVA: 0x0046CE3C File Offset: 0x0046B03C
		public static Offset<ICheckPlayerPosition> Pack(FlatBufferBuilder builder, ICheckPlayerPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerPosition>);
			}
			TRange range_type = (_o.Range == null) ? TRange.NONE : _o.Range.Type;
			int rangeOffset = (_o.Range == null) ? 0 : TRangeUnion.Pack(builder, _o.Range);
			return ICheckPlayerPosition.CreateICheckPlayerPosition(builder, _o.Type, range_type, rangeOffset, _o.IsOnRange);
		}

		// Token: 0x0400DE79 RID: 56953
		private Table __p;
	}
}
