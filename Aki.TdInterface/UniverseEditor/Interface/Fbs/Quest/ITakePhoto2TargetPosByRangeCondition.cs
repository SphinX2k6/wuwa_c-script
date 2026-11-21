using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F8 RID: 17912
	public struct ITakePhoto2TargetPosByRangeCondition : IFlatbufferObject
	{
		// Token: 0x17007D51 RID: 32081
		// (get) Token: 0x0601A2E9 RID: 107241 RVA: 0x003BAA2C File Offset: 0x003B8C2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A2EA RID: 107242 RVA: 0x003BAA39 File Offset: 0x003B8C39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A2EB RID: 107243 RVA: 0x003BAA40 File Offset: 0x003B8C40
		public static ITakePhoto2TargetPosByRangeCondition GetRootAsITakePhoto2TargetPosByRangeCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetPosByRangeCondition.GetRootAsITakePhoto2TargetPosByRangeCondition(_bb, default(ITakePhoto2TargetPosByRangeCondition));
		}

		// Token: 0x0601A2EC RID: 107244 RVA: 0x003BAA5C File Offset: 0x003B8C5C
		public static ITakePhoto2TargetPosByRangeCondition GetRootAsITakePhoto2TargetPosByRangeCondition(ByteBuffer _bb, ITakePhoto2TargetPosByRangeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A2ED RID: 107245 RVA: 0x003BAA79 File Offset: 0x003B8C79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A2EE RID: 107246 RVA: 0x003BAA88 File Offset: 0x003B8C88
		public ITakePhoto2TargetPosByRangeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D52 RID: 32082
		// (get) Token: 0x0601A2EF RID: 107247 RVA: 0x003BAA98 File Offset: 0x003B8C98
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

		// Token: 0x0601A2F0 RID: 107248 RVA: 0x003BAAD4 File Offset: 0x003B8CD4
		public TTable? Range<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A2F1 RID: 107249 RVA: 0x003BAB18 File Offset: 0x003B8D18
		public IBoxRange RangeAsIBoxRange()
		{
			return this.Range<IBoxRange>().Value;
		}

		// Token: 0x0601A2F2 RID: 107250 RVA: 0x003BAB34 File Offset: 0x003B8D34
		public ICircleRange RangeAsICircleRange()
		{
			return this.Range<ICircleRange>().Value;
		}

		// Token: 0x0601A2F3 RID: 107251 RVA: 0x003BAB50 File Offset: 0x003B8D50
		public ICylinder RangeAsICylinder()
		{
			return this.Range<ICylinder>().Value;
		}

		// Token: 0x0601A2F4 RID: 107252 RVA: 0x003BAB6B File Offset: 0x003B8D6B
		public static Offset<ITakePhoto2TargetPosByRangeCondition> CreateITakePhoto2TargetPosByRangeCondition(FlatBufferBuilder builder, TRange Range_type = TRange.NONE, int RangeOffset = 0)
		{
			builder.StartTable(2);
			ITakePhoto2TargetPosByRangeCondition.AddRange(builder, RangeOffset);
			ITakePhoto2TargetPosByRangeCondition.AddRangeType(builder, Range_type);
			return ITakePhoto2TargetPosByRangeCondition.EndITakePhoto2TargetPosByRangeCondition(builder);
		}

		// Token: 0x0601A2F5 RID: 107253 RVA: 0x003BAB88 File Offset: 0x003B8D88
		public static void StartITakePhoto2TargetPosByRangeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A2F6 RID: 107254 RVA: 0x003BAB91 File Offset: 0x003B8D91
		public static void AddRangeType(FlatBufferBuilder builder, TRange rangeType)
		{
			builder.AddByte(0, (byte)rangeType, 0);
		}

		// Token: 0x0601A2F7 RID: 107255 RVA: 0x003BAB9C File Offset: 0x003B8D9C
		public static void AddRange(FlatBufferBuilder builder, int rangeOffset)
		{
			builder.AddOffset(1, rangeOffset, 0);
		}

		// Token: 0x0601A2F8 RID: 107256 RVA: 0x003BABA7 File Offset: 0x003B8DA7
		public static Offset<ITakePhoto2TargetPosByRangeCondition> EndITakePhoto2TargetPosByRangeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetPosByRangeCondition>(builder.EndTable());
		}

		// Token: 0x0601A2F9 RID: 107257 RVA: 0x003BABB4 File Offset: 0x003B8DB4
		public ITakePhoto2TargetPosByRangeConditionT UnPack()
		{
			ITakePhoto2TargetPosByRangeConditionT takePhoto2TargetPosByRangeConditionT = new ITakePhoto2TargetPosByRangeConditionT();
			this.UnPackTo(takePhoto2TargetPosByRangeConditionT);
			return takePhoto2TargetPosByRangeConditionT;
		}

		// Token: 0x0601A2FA RID: 107258 RVA: 0x003BABD0 File Offset: 0x003B8DD0
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

		// Token: 0x0601A2FB RID: 107259 RVA: 0x003BACB8 File Offset: 0x003B8EB8
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

		// Token: 0x0400C7E1 RID: 51169
		private Table __p;
	}
}
