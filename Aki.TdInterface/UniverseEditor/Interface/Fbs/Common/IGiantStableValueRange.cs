using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD3 RID: 24019
	public struct IGiantStableValueRange : IFlatbufferObject
	{
		// Token: 0x1700B3CF RID: 46031
		// (get) Token: 0x060291C6 RID: 168390 RVA: 0x005A4712 File Offset: 0x005A2912
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060291C7 RID: 168391 RVA: 0x005A471F File Offset: 0x005A291F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060291C8 RID: 168392 RVA: 0x005A4728 File Offset: 0x005A2928
		public static IGiantStableValueRange GetRootAsIGiantStableValueRange(ByteBuffer _bb)
		{
			return IGiantStableValueRange.GetRootAsIGiantStableValueRange(_bb, default(IGiantStableValueRange));
		}

		// Token: 0x060291C9 RID: 168393 RVA: 0x005A4744 File Offset: 0x005A2944
		public static IGiantStableValueRange GetRootAsIGiantStableValueRange(ByteBuffer _bb, IGiantStableValueRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060291CA RID: 168394 RVA: 0x005A4761 File Offset: 0x005A2961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060291CB RID: 168395 RVA: 0x005A4770 File Offset: 0x005A2970
		public IGiantStableValueRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3D0 RID: 46032
		// (get) Token: 0x060291CC RID: 168396 RVA: 0x005A4780 File Offset: 0x005A2980
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

		// Token: 0x1700B3D1 RID: 46033
		// (get) Token: 0x060291CD RID: 168397 RVA: 0x005A47E0 File Offset: 0x005A29E0
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

		// Token: 0x060291CE RID: 168398 RVA: 0x005A483D File Offset: 0x005A2A3D
		public static Offset<IGiantStableValueRange> CreateIGiantStableValueRange(FlatBufferBuilder builder, Offset<IGiantStableValue> MinValueOffset = default(Offset<IGiantStableValue>), Offset<IGiantStableValue> MaxValueOffset = default(Offset<IGiantStableValue>))
		{
			builder.StartTable(2);
			IGiantStableValueRange.AddMaxValue(builder, MaxValueOffset);
			IGiantStableValueRange.AddMinValue(builder, MinValueOffset);
			return IGiantStableValueRange.EndIGiantStableValueRange(builder);
		}

		// Token: 0x060291CF RID: 168399 RVA: 0x005A485A File Offset: 0x005A2A5A
		public static void StartIGiantStableValueRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060291D0 RID: 168400 RVA: 0x005A4863 File Offset: 0x005A2A63
		public static void AddMinValue(FlatBufferBuilder builder, Offset<IGiantStableValue> minValueOffset)
		{
			builder.AddOffset(0, minValueOffset.Value, 0);
		}

		// Token: 0x060291D1 RID: 168401 RVA: 0x005A4873 File Offset: 0x005A2A73
		public static void AddMaxValue(FlatBufferBuilder builder, Offset<IGiantStableValue> maxValueOffset)
		{
			builder.AddOffset(1, maxValueOffset.Value, 0);
		}

		// Token: 0x060291D2 RID: 168402 RVA: 0x005A4883 File Offset: 0x005A2A83
		public static Offset<IGiantStableValueRange> EndIGiantStableValueRange(FlatBufferBuilder builder)
		{
			return new Offset<IGiantStableValueRange>(builder.EndTable());
		}

		// Token: 0x060291D3 RID: 168403 RVA: 0x005A4890 File Offset: 0x005A2A90
		public IGiantStableValueRangeT UnPack()
		{
			IGiantStableValueRangeT giantStableValueRangeT = new IGiantStableValueRangeT();
			this.UnPackTo(giantStableValueRangeT);
			return giantStableValueRangeT;
		}

		// Token: 0x060291D4 RID: 168404 RVA: 0x005A48AC File Offset: 0x005A2AAC
		public void UnPackTo(IGiantStableValueRangeT _o)
		{
			_o.MinValue = ((this.MinValue != null) ? this.MinValue.Value.UnPack() : null);
			_o.MaxValue = ((this.MaxValue != null) ? this.MaxValue.Value.UnPack() : null);
		}

		// Token: 0x060291D5 RID: 168405 RVA: 0x005A4918 File Offset: 0x005A2B18
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

		// Token: 0x0400F7B9 RID: 63417
		private Table __p;
	}
}
