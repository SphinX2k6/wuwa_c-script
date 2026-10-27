using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419F RID: 16799
	public struct ITakePhoto2TargetPosByRangeCondition : IFlatbufferObject
	{
		// Token: 0x17007725 RID: 30501
		// (get) Token: 0x06018B93 RID: 101267 RVA: 0x0038F5D8 File Offset: 0x0038D7D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B94 RID: 101268 RVA: 0x0038F5E5 File Offset: 0x0038D7E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B95 RID: 101269 RVA: 0x0038F5EC File Offset: 0x0038D7EC
		public static ITakePhoto2TargetPosByRangeCondition GetRootAsITakePhoto2TargetPosByRangeCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetPosByRangeCondition.GetRootAsITakePhoto2TargetPosByRangeCondition(_bb, default(ITakePhoto2TargetPosByRangeCondition));
		}

		// Token: 0x06018B96 RID: 101270 RVA: 0x0038F608 File Offset: 0x0038D808
		public static ITakePhoto2TargetPosByRangeCondition GetRootAsITakePhoto2TargetPosByRangeCondition(ByteBuffer _bb, ITakePhoto2TargetPosByRangeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B97 RID: 101271 RVA: 0x0038F625 File Offset: 0x0038D825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B98 RID: 101272 RVA: 0x0038F634 File Offset: 0x0038D834
		public ITakePhoto2TargetPosByRangeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007726 RID: 30502
		// (get) Token: 0x06018B99 RID: 101273 RVA: 0x0038F644 File Offset: 0x0038D844
		public TRange RangeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TRange.NONE;
				}
				return (TRange)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018B9A RID: 101274 RVA: 0x0038F680 File Offset: 0x0038D880
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018B9B RID: 101275 RVA: 0x0038F6C4 File Offset: 0x0038D8C4
		public IBoxRange RangeAsIBoxRange()
		{
			return this.Range<IBoxRange>().Value;
		}

		// Token: 0x06018B9C RID: 101276 RVA: 0x0038F6E0 File Offset: 0x0038D8E0
		public ICircleRange RangeAsICircleRange()
		{
			return this.Range<ICircleRange>().Value;
		}

		// Token: 0x06018B9D RID: 101277 RVA: 0x0038F6FC File Offset: 0x0038D8FC
		public ICylinder RangeAsICylinder()
		{
			return this.Range<ICylinder>().Value;
		}

		// Token: 0x06018B9E RID: 101278 RVA: 0x0038F717 File Offset: 0x0038D917
		public static Offset<ITakePhoto2TargetPosByRangeCondition> CreateITakePhoto2TargetPosByRangeCondition(FlatBufferBuilder builder, TRange Range_type = TRange.NONE, int RangeOffset = 0)
		{
			builder.StartTable(2);
			ITakePhoto2TargetPosByRangeCondition.AddRange(builder, RangeOffset);
			ITakePhoto2TargetPosByRangeCondition.AddRangeType(builder, Range_type);
			return ITakePhoto2TargetPosByRangeCondition.EndITakePhoto2TargetPosByRangeCondition(builder);
		}

		// Token: 0x06018B9F RID: 101279 RVA: 0x0038F734 File Offset: 0x0038D934
		public static void StartITakePhoto2TargetPosByRangeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018BA0 RID: 101280 RVA: 0x0038F73D File Offset: 0x0038D93D
		public static void AddRangeType(FlatBufferBuilder builder, TRange rangeType)
		{
			builder.AddByte(0, (byte)rangeType, 0);
		}

		// Token: 0x06018BA1 RID: 101281 RVA: 0x0038F748 File Offset: 0x0038D948
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(1, rangeOffset, 0);
		}

		// Token: 0x06018BA2 RID: 101282 RVA: 0x0038F753 File Offset: 0x0038D953
		public static Offset<ITakePhoto2TargetPosByRangeCondition> EndITakePhoto2TargetPosByRangeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetPosByRangeCondition>(builder.EndTable());
		}

		// Token: 0x06018BA3 RID: 101283 RVA: 0x0038F760 File Offset: 0x0038D960
		public ITakePhoto2TargetPosByRangeConditionT UnPack()
		{
			ITakePhoto2TargetPosByRangeConditionT takePhoto2TargetPosByRangeConditionT = new ITakePhoto2TargetPosByRangeConditionT();
			this.UnPackTo(takePhoto2TargetPosByRangeConditionT);
			return takePhoto2TargetPosByRangeConditionT;
		}

		// Token: 0x06018BA4 RID: 101284 RVA: 0x0038F77C File Offset: 0x0038D97C
		public void UnPackTo(ITakePhoto2TargetPosByRangeConditionT _o)
		{
			_o.Range = new TRangeUnion();
			_o.Range.Type = this.RangeType;
			switch (this.RangeType)
			{
			case TRange.IBoxRange:
				_o.Range.Value = ((this.Range<IBoxRange>() != null) ? this.Range<IBoxRange>().Value.UnPack() : null);
				return;
			case TRange.ICircleRange:
				_o.Range.Value = ((this.Range<ICircleRange>() != null) ? this.Range<ICircleRange>().Value.UnPack() : null);
				return;
			case TRange.ICylinder:
				_o.Range.Value = ((this.Range<ICylinder>() != null) ? this.Range<ICylinder>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06018BA5 RID: 101285 RVA: 0x0038F864 File Offset: 0x0038DA64
		public static Offset<ITakePhoto2TargetPosByRangeCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetPosByRangeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetPosByRangeCondition>);
			}
			TRange range_type = (_o.Range == null) ? TRange.NONE : _o.Range.Type;
			int rangeOffset = (_o.Range == null) ? 0 : TRangeUnion.Pack(builder, _o.Range);
			return ITakePhoto2TargetPosByRangeCondition.CreateITakePhoto2TargetPosByRangeCondition(builder, range_type, rangeOffset);
		}

		// Token: 0x0400BDD7 RID: 48599
		private Table __p;
	}
}
