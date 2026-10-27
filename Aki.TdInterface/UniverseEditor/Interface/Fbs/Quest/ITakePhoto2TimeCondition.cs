using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A5 RID: 16805
	public struct ITakePhoto2TimeCondition : IFlatbufferObject
	{
		// Token: 0x1700772A RID: 30506
		// (get) Token: 0x06018BBC RID: 101308 RVA: 0x0038FAF8 File Offset: 0x0038DCF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018BBD RID: 101309 RVA: 0x0038FB05 File Offset: 0x0038DD05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018BBE RID: 101310 RVA: 0x0038FB0C File Offset: 0x0038DD0C
		public static ITakePhoto2TimeCondition GetRootAsITakePhoto2TimeCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TimeCondition.GetRootAsITakePhoto2TimeCondition(_bb, default(ITakePhoto2TimeCondition));
		}

		// Token: 0x06018BBF RID: 101311 RVA: 0x0038FB28 File Offset: 0x0038DD28
		public static ITakePhoto2TimeCondition GetRootAsITakePhoto2TimeCondition(ByteBuffer _bb, ITakePhoto2TimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018BC0 RID: 101312 RVA: 0x0038FB45 File Offset: 0x0038DD45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018BC1 RID: 101313 RVA: 0x0038FB54 File Offset: 0x0038DD54
		public ITakePhoto2TimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700772B RID: 30507
		// (get) Token: 0x06018BC2 RID: 101314 RVA: 0x0038FB64 File Offset: 0x0038DD64
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

		// Token: 0x1700772C RID: 30508
		// (get) Token: 0x06018BC3 RID: 101315 RVA: 0x0038FBC4 File Offset: 0x0038DDC4
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

		// Token: 0x06018BC4 RID: 101316 RVA: 0x0038FC00 File Offset: 0x0038DE00
		public static Offset<ITakePhoto2TimeCondition> CreateITakePhoto2TimeCondition(FlatBufferBuilder builder, Offset<IHourToHour> TimeRangeOffset = default(Offset<IHourToHour>), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(2);
			ITakePhoto2TimeCondition.AddTimeRange(builder, TimeRangeOffset);
			ITakePhoto2TimeCondition.AddCompare(builder, Compare);
			return ITakePhoto2TimeCondition.EndITakePhoto2TimeCondition(builder);
		}

		// Token: 0x06018BC5 RID: 101317 RVA: 0x0038FC1D File Offset: 0x0038DE1D
		public static void StartITakePhoto2TimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018BC6 RID: 101318 RVA: 0x0038FC26 File Offset: 0x0038DE26
		public static void AddTimeRange(FlatBufferBuilder builder, Offset<IHourToHour> timeRangeOffset)
		{
			builder.AddOffset(0, timeRangeOffset.Value, 0);
		}

		// Token: 0x06018BC7 RID: 101319 RVA: 0x0038FC36 File Offset: 0x0038DE36
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06018BC8 RID: 101320 RVA: 0x0038FC41 File Offset: 0x0038DE41
		public static Offset<ITakePhoto2TimeCondition> EndITakePhoto2TimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TimeCondition>(builder.EndTable());
		}

		// Token: 0x06018BC9 RID: 101321 RVA: 0x0038FC50 File Offset: 0x0038DE50
		public ITakePhoto2TimeConditionT UnPack()
		{
			ITakePhoto2TimeConditionT takePhoto2TimeConditionT = new ITakePhoto2TimeConditionT();
			this.UnPackTo(takePhoto2TimeConditionT);
			return takePhoto2TimeConditionT;
		}

		// Token: 0x06018BCA RID: 101322 RVA: 0x0038FC6C File Offset: 0x0038DE6C
		public void UnPackTo(ITakePhoto2TimeConditionT _o)
		{
			_o.TimeRange = ((this.TimeRange != null) ? this.TimeRange.Value.UnPack() : null);
			_o.Compare = this.Compare;
		}

		// Token: 0x06018BCB RID: 101323 RVA: 0x0038FCB4 File Offset: 0x0038DEB4
		public static Offset<ITakePhoto2TimeCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TimeCondition>);
			}
			Offset<IHourToHour> timeRangeOffset = (_o.TimeRange == null) ? default(Offset<IHourToHour>) : IHourToHour.Pack(builder, _o.TimeRange);
			return ITakePhoto2TimeCondition.CreateITakePhoto2TimeCondition(builder, timeRangeOffset, _o.Compare);
		}

		// Token: 0x0400BDE2 RID: 48610
		private Table __p;
	}
}
