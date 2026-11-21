using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045FE RID: 17918
	public struct ITakePhoto2TimeCondition : IFlatbufferObject
	{
		// Token: 0x17007D56 RID: 32086
		// (get) Token: 0x0601A312 RID: 107282 RVA: 0x003BAF4C File Offset: 0x003B914C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A313 RID: 107283 RVA: 0x003BAF59 File Offset: 0x003B9159
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A314 RID: 107284 RVA: 0x003BAF60 File Offset: 0x003B9160
		public static ITakePhoto2TimeCondition GetRootAsITakePhoto2TimeCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TimeCondition.GetRootAsITakePhoto2TimeCondition(_bb, default(ITakePhoto2TimeCondition));
		}

		// Token: 0x0601A315 RID: 107285 RVA: 0x003BAF7C File Offset: 0x003B917C
		public static ITakePhoto2TimeCondition GetRootAsITakePhoto2TimeCondition(ByteBuffer _bb, ITakePhoto2TimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A316 RID: 107286 RVA: 0x003BAF99 File Offset: 0x003B9199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A317 RID: 107287 RVA: 0x003BAFA8 File Offset: 0x003B91A8
		public ITakePhoto2TimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D57 RID: 32087
		// (get) Token: 0x0601A318 RID: 107288 RVA: 0x003BAFB8 File Offset: 0x003B91B8
		public IHourToHour? TimeRange
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IHourToHour?(default(IHourToHour).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007D58 RID: 32088
		// (get) Token: 0x0601A319 RID: 107289 RVA: 0x003BB018 File Offset: 0x003B9218
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A31A RID: 107290 RVA: 0x003BB054 File Offset: 0x003B9254
		public static Offset<ITakePhoto2TimeCondition> CreateITakePhoto2TimeCondition(FlatBufferBuilder builder, Offset<IHourToHour> TimeRangeOffset = default(Offset<IHourToHour>), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			ITakePhoto2TimeCondition.AddTimeRange(builder, TimeRangeOffset);
			ITakePhoto2TimeCondition.AddCompare(builder, Compare);
			return ITakePhoto2TimeCondition.EndITakePhoto2TimeCondition(builder);
		}

		// Token: 0x0601A31B RID: 107291 RVA: 0x003BB071 File Offset: 0x003B9271
		public static void StartITakePhoto2TimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A31C RID: 107292 RVA: 0x003BB07A File Offset: 0x003B927A
		public static void AddTimeRange(FlatBufferBuilder builder, Offset<IHourToHour> timeRangeOffset)
		{
			builder.AddOffset(0, timeRangeOffset.Value, 0);
		}

		// Token: 0x0601A31D RID: 107293 RVA: 0x003BB08A File Offset: 0x003B928A
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601A31E RID: 107294 RVA: 0x003BB095 File Offset: 0x003B9295
		public static Offset<ITakePhoto2TimeCondition> EndITakePhoto2TimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TimeCondition>(builder.EndTable());
		}

		// Token: 0x0601A31F RID: 107295 RVA: 0x003BB0A4 File Offset: 0x003B92A4
		public ITakePhoto2TimeConditionT UnPack()
		{
			ITakePhoto2TimeConditionT takePhoto2TimeConditionT = new ITakePhoto2TimeConditionT();
			this.UnPackTo(takePhoto2TimeConditionT);
			return takePhoto2TimeConditionT;
		}

		// Token: 0x0601A320 RID: 107296 RVA: 0x003BB0C0 File Offset: 0x003B92C0
		public void UnPackTo(ITakePhoto2TimeConditionT _o)
		{
			_o.TimeRange = ((this.TimeRange != null) ? this.TimeRange.Value.UnPack() : null);
			_o.Compare = this.Compare;
		}

		// Token: 0x0601A321 RID: 107297 RVA: 0x003BB108 File Offset: 0x003B9308
		public static Offset<ITakePhoto2TimeCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TimeCondition>);
			}
			Offset<IHourToHour> timeRangeOffset = (_o.TimeRange == null) ? default(Offset<IHourToHour>) : IHourToHour.Pack(builder, _o.TimeRange);
			return ITakePhoto2TimeCondition.CreateITakePhoto2TimeCondition(builder, timeRangeOffset, _o.Compare);
		}

		// Token: 0x0400C7EC RID: 51180
		private Table __p;
	}
}
