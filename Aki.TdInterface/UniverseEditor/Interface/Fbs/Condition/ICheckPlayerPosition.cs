using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF6 RID: 19190
	public struct ICheckPlayerPosition : IFlatbufferObject
	{
		// Token: 0x17008B26 RID: 35622
		// (get) Token: 0x0601E284 RID: 123524 RVA: 0x0043AA40 File Offset: 0x00438C40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E285 RID: 123525 RVA: 0x0043AA4D File Offset: 0x00438C4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E286 RID: 123526 RVA: 0x0043AA54 File Offset: 0x00438C54
		public static ICheckPlayerPosition GetRootAsICheckPlayerPosition(ByteBuffer _bb)
		{
			return ICheckPlayerPosition.GetRootAsICheckPlayerPosition(_bb, default(ICheckPlayerPosition));
		}

		// Token: 0x0601E287 RID: 123527 RVA: 0x0043AA70 File Offset: 0x00438C70
		public static ICheckPlayerPosition GetRootAsICheckPlayerPosition(ByteBuffer _bb, ICheckPlayerPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E288 RID: 123528 RVA: 0x0043AA8D File Offset: 0x00438C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E289 RID: 123529 RVA: 0x0043AA9C File Offset: 0x00438C9C
		public ICheckPlayerPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B27 RID: 35623
		// (get) Token: 0x0601E28A RID: 123530 RVA: 0x0043AAAC File Offset: 0x00438CAC
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

		// Token: 0x17008B28 RID: 35624
		// (get) Token: 0x0601E28B RID: 123531 RVA: 0x0043AAE8 File Offset: 0x00438CE8
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

		// Token: 0x0601E28C RID: 123532 RVA: 0x0043AB24 File Offset: 0x00438D24
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E28D RID: 123533 RVA: 0x0043AB68 File Offset: 0x00438D68
		public IBoxRange RangeAsIBoxRange()
		{
			return this.Range<IBoxRange>().Value;
		}

		// Token: 0x0601E28E RID: 123534 RVA: 0x0043AB84 File Offset: 0x00438D84
		public ICircleRange RangeAsICircleRange()
		{
			return this.Range<ICircleRange>().Value;
		}

		// Token: 0x0601E28F RID: 123535 RVA: 0x0043ABA0 File Offset: 0x00438DA0
		public ICylinder RangeAsICylinder()
		{
			return this.Range<ICylinder>().Value;
		}

		// Token: 0x17008B29 RID: 35625
		// (get) Token: 0x0601E290 RID: 123536 RVA: 0x0043ABBC File Offset: 0x00438DBC
		public bool IsOnRange
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E291 RID: 123537 RVA: 0x0043ABFC File Offset: 0x00438DFC
		public static Offset<ICheckPlayerPosition> CreateICheckPlayerPosition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TRange Range_type = TRange.NONE, int RangeOffset = 0, bool IsOnRange = false)
		{
			builder.StartTable(4);
			ICheckPlayerPosition.AddRange(builder, RangeOffset);
			ICheckPlayerPosition.AddIsOnRange(builder, IsOnRange);
			ICheckPlayerPosition.AddRangeType(builder, Range_type);
			ICheckPlayerPosition.AddType(builder, Type);
			return ICheckPlayerPosition.EndICheckPlayerPosition(builder);
		}

		// Token: 0x0601E292 RID: 123538 RVA: 0x0043AC28 File Offset: 0x00438E28
		public static void StartICheckPlayerPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E293 RID: 123539 RVA: 0x0043AC31 File Offset: 0x00438E31
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E294 RID: 123540 RVA: 0x0043AC3C File Offset: 0x00438E3C
		public static void AddRangeType(FlatBufferBuilder builder, TRange rangeType)
		{
			builder.AddByte(1, (byte)rangeType, 0);
		}

		// Token: 0x0601E295 RID: 123541 RVA: 0x0043AC47 File Offset: 0x00438E47
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(2, rangeOffset, 0);
		}

		// Token: 0x0601E296 RID: 123542 RVA: 0x0043AC52 File Offset: 0x00438E52
		public static void AddIsOnRange(FlatBufferBuilder builder, bool isOnRange)
		{
			builder.AddBool(3, isOnRange, false);
		}

		// Token: 0x0601E297 RID: 123543 RVA: 0x0043AC5D File Offset: 0x00438E5D
		public static Offset<ICheckPlayerPosition> EndICheckPlayerPosition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerPosition>(builder.EndTable());
		}

		// Token: 0x0601E298 RID: 123544 RVA: 0x0043AC6C File Offset: 0x00438E6C
		public ICheckPlayerPositionT UnPack()
		{
			ICheckPlayerPositionT checkPlayerPositionT = new ICheckPlayerPositionT();
			this.UnPackTo(checkPlayerPositionT);
			return checkPlayerPositionT;
		}

		// Token: 0x0601E299 RID: 123545 RVA: 0x0043AC88 File Offset: 0x00438E88
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

		// Token: 0x0601E29A RID: 123546 RVA: 0x0043AD90 File Offset: 0x00438F90
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

		// Token: 0x0400D388 RID: 54152
		private Table __p;
	}
}
