using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AE RID: 16814
	public struct ITakePhotoTimeCondition : IFlatbufferObject
	{
		// Token: 0x1700773F RID: 30527
		// (get) Token: 0x06018C12 RID: 101394 RVA: 0x0039069D File Offset: 0x0038E89D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018C13 RID: 101395 RVA: 0x003906AA File Offset: 0x0038E8AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018C14 RID: 101396 RVA: 0x003906B4 File Offset: 0x0038E8B4
		public static ITakePhotoTimeCondition GetRootAsITakePhotoTimeCondition(ByteBuffer _bb)
		{
			return ITakePhotoTimeCondition.GetRootAsITakePhotoTimeCondition(_bb, default(ITakePhotoTimeCondition));
		}

		// Token: 0x06018C15 RID: 101397 RVA: 0x003906D0 File Offset: 0x0038E8D0
		public static ITakePhotoTimeCondition GetRootAsITakePhotoTimeCondition(ByteBuffer _bb, ITakePhotoTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018C16 RID: 101398 RVA: 0x003906ED File Offset: 0x0038E8ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018C17 RID: 101399 RVA: 0x003906FC File Offset: 0x0038E8FC
		public ITakePhotoTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007740 RID: 30528
		// (get) Token: 0x06018C18 RID: 101400 RVA: 0x0039070C File Offset: 0x0038E90C
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

		// Token: 0x17007741 RID: 30529
		// (get) Token: 0x06018C19 RID: 101401 RVA: 0x0039076C File Offset: 0x0038E96C
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

		// Token: 0x17007742 RID: 30530
		// (get) Token: 0x06018C1A RID: 101402 RVA: 0x003907A8 File Offset: 0x0038E9A8
		public string TidDescription
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018C1B RID: 101403 RVA: 0x003907DF File Offset: 0x0038E9DF
		public Span<byte> GetTidDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018C1C RID: 101404 RVA: 0x003907EE File Offset: 0x0038E9EE
		public byte[] GetTidDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06018C1D RID: 101405 RVA: 0x003907FC File Offset: 0x0038E9FC
		public static Offset<ITakePhotoTimeCondition> CreateITakePhotoTimeCondition(FlatBufferBuilder builder, Offset<IHourToHour> TimeRangeOffset = default(Offset<IHourToHour>), ECompare Compare = ECompare.Eq, StringOffset TidDescriptionOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITakePhotoTimeCondition.AddTidDescription(builder, TidDescriptionOffset);
			ITakePhotoTimeCondition.AddTimeRange(builder, TimeRangeOffset);
			ITakePhotoTimeCondition.AddCompare(builder, Compare);
			return ITakePhotoTimeCondition.EndITakePhotoTimeCondition(builder);
		}

		// Token: 0x06018C1E RID: 101406 RVA: 0x00390820 File Offset: 0x0038EA20
		public static void StartITakePhotoTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018C1F RID: 101407 RVA: 0x00390829 File Offset: 0x0038EA29
		public static void AddTimeRange(FlatBufferBuilder builder, Offset<IHourToHour> timeRangeOffset)
		{
			builder.AddOffset(0, timeRangeOffset.Value, 0);
		}

		// Token: 0x06018C20 RID: 101408 RVA: 0x00390839 File Offset: 0x0038EA39
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06018C21 RID: 101409 RVA: 0x00390844 File Offset: 0x0038EA44
		public static void AddTidDescription(FlatBufferBuilder builder, StringOffset tidDescriptionOffset)
		{
			builder.AddOffset(2, tidDescriptionOffset.Value, 0);
		}

		// Token: 0x06018C22 RID: 101410 RVA: 0x00390854 File Offset: 0x0038EA54
		public static Offset<ITakePhotoTimeCondition> EndITakePhotoTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhotoTimeCondition>(builder.EndTable());
		}

		// Token: 0x06018C23 RID: 101411 RVA: 0x00390864 File Offset: 0x0038EA64
		public ITakePhotoTimeConditionT UnPack()
		{
			ITakePhotoTimeConditionT takePhotoTimeConditionT = new ITakePhotoTimeConditionT();
			this.UnPackTo(takePhotoTimeConditionT);
			return takePhotoTimeConditionT;
		}

		// Token: 0x06018C24 RID: 101412 RVA: 0x00390880 File Offset: 0x0038EA80
		public void UnPackTo(ITakePhotoTimeConditionT _o)
		{
			_o.TimeRange = ((this.TimeRange != null) ? this.TimeRange.Value.UnPack() : null);
			_o.Compare = this.Compare;
			_o.TidDescription = this.TidDescription;
		}

		// Token: 0x06018C25 RID: 101413 RVA: 0x003908D4 File Offset: 0x0038EAD4
		public static Offset<ITakePhotoTimeCondition> Pack(FlatBufferBuilder builder, ITakePhotoTimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhotoTimeCondition>);
			}
			Offset<IHourToHour> timeRangeOffset = (_o.TimeRange == null) ? default(Offset<IHourToHour>) : IHourToHour.Pack(builder, _o.TimeRange);
			StringOffset tidDescriptionOffset = (_o.TidDescription == null) ? default(StringOffset) : builder.CreateString(_o.TidDescription);
			return ITakePhotoTimeCondition.CreateITakePhotoTimeCondition(builder, timeRangeOffset, _o.Compare, tidDescriptionOffset);
		}

		// Token: 0x0400BDEE RID: 48622
		private Table __p;
	}
}
