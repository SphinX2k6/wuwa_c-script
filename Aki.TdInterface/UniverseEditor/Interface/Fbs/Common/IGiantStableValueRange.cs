using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006410 RID: 25616
	public struct IGiantStableValueRange : IFlatbufferObject
	{
		// Token: 0x1700BD35 RID: 48437
		// (get) Token: 0x0602B850 RID: 178256 RVA: 0x005ED442 File Offset: 0x005EB642
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B851 RID: 178257 RVA: 0x005ED44F File Offset: 0x005EB64F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B852 RID: 178258 RVA: 0x005ED458 File Offset: 0x005EB658
		public static IGiantStableValueRange GetRootAsIGiantStableValueRange(ByteBuffer _bb)
		{
			return IGiantStableValueRange.GetRootAsIGiantStableValueRange(_bb, default(IGiantStableValueRange));
		}

		// Token: 0x0602B853 RID: 178259 RVA: 0x005ED474 File Offset: 0x005EB674
		public static IGiantStableValueRange GetRootAsIGiantStableValueRange(ByteBuffer _bb, IGiantStableValueRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B854 RID: 178260 RVA: 0x005ED491 File Offset: 0x005EB691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B855 RID: 178261 RVA: 0x005ED4A0 File Offset: 0x005EB6A0
		public IGiantStableValueRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD36 RID: 48438
		// (get) Token: 0x0602B856 RID: 178262 RVA: 0x005ED4B0 File Offset: 0x005EB6B0
		public IGiantStableValue? MinValue
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IGiantStableValue?(default(IGiantStableValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BD37 RID: 48439
		// (get) Token: 0x0602B857 RID: 178263 RVA: 0x005ED510 File Offset: 0x005EB710
		public IGiantStableValue? MaxValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGiantStableValue?(default(IGiantStableValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602B858 RID: 178264 RVA: 0x005ED56D File Offset: 0x005EB76D
		public static Offset<IGiantStableValueRange> CreateIGiantStableValueRange(FlatBufferBuilder builder, Offset<IGiantStableValue> MinValueOffset = default(Offset<IGiantStableValue>), Offset<IGiantStableValue> MaxValueOffset = default(Offset<IGiantStableValue>))
		{
			builder.StartTable(2);
			IGiantStableValueRange.AddMaxValue(builder, MaxValueOffset);
			IGiantStableValueRange.AddMinValue(builder, MinValueOffset);
			return IGiantStableValueRange.EndIGiantStableValueRange(builder);
		}

		// Token: 0x0602B859 RID: 178265 RVA: 0x005ED58A File Offset: 0x005EB78A
		public static void StartIGiantStableValueRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B85A RID: 178266 RVA: 0x005ED593 File Offset: 0x005EB793
		public static void AddMinValue(FlatBufferBuilder builder, Offset<IGiantStableValue> minValueOffset)
		{
			builder.AddOffset(0, minValueOffset.Value, 0);
		}

		// Token: 0x0602B85B RID: 178267 RVA: 0x005ED5A3 File Offset: 0x005EB7A3
		public static void AddMaxValue(FlatBufferBuilder builder, Offset<IGiantStableValue> maxValueOffset)
		{
			builder.AddOffset(1, maxValueOffset.Value, 0);
		}

		// Token: 0x0602B85C RID: 178268 RVA: 0x005ED5B3 File Offset: 0x005EB7B3
		public static Offset<IGiantStableValueRange> EndIGiantStableValueRange(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueRange>(builder.EndTable());
		}

		// Token: 0x0602B85D RID: 178269 RVA: 0x005ED5C0 File Offset: 0x005EB7C0
		public IGiantStableValueRangeT UnPack()
		{
			IGiantStableValueRangeT giantStableValueRangeT = new IGiantStableValueRangeT();
			this.UnPackTo(giantStableValueRangeT);
			return giantStableValueRangeT;
		}

		// Token: 0x0602B85E RID: 178270 RVA: 0x005ED5DC File Offset: 0x005EB7DC
		public void UnPackTo(IGiantStableValueRangeT _o)
		{
			_o.MinValue = ((this.MinValue != null) ? this.MinValue.Value.UnPack() : null);
			_o.MaxValue = ((this.MaxValue != null) ? this.MaxValue.Value.UnPack() : null);
		}

		// Token: 0x0602B85F RID: 178271 RVA: 0x005ED648 File Offset: 0x005EB848
		public static Offset<IGiantStableValueRange> Pack(FlatBufferBuilder builder, IGiantStableValueRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantStableValueRange>);
			}
			Offset<IGiantStableValue> minValueOffset = (_o.MinValue == null) ? default(Offset<IGiantStableValue>) : IGiantStableValue.Pack(builder, _o.MinValue);
			Offset<IGiantStableValue> maxValueOffset = (_o.MaxValue == null) ? default(Offset<IGiantStableValue>) : IGiantStableValue.Pack(builder, _o.MaxValue);
			return IGiantStableValueRange.CreateIGiantStableValueRange(builder, minValueOffset, maxValueOffset);
		}

		// Token: 0x04010514 RID: 66836
		private Table __p;
	}
}
