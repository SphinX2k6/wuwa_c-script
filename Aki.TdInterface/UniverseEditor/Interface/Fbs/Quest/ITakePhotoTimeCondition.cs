using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004607 RID: 17927
	public struct ITakePhotoTimeCondition : IFlatbufferObject
	{
		// Token: 0x17007D6B RID: 32107
		// (get) Token: 0x0601A368 RID: 107368 RVA: 0x003BBAF1 File Offset: 0x003B9CF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A369 RID: 107369 RVA: 0x003BBAFE File Offset: 0x003B9CFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A36A RID: 107370 RVA: 0x003BBB08 File Offset: 0x003B9D08
		public static ITakePhotoTimeCondition GetRootAsITakePhotoTimeCondition(ByteBuffer _bb)
		{
			return ITakePhotoTimeCondition.GetRootAsITakePhotoTimeCondition(_bb, default(ITakePhotoTimeCondition));
		}

		// Token: 0x0601A36B RID: 107371 RVA: 0x003BBB24 File Offset: 0x003B9D24
		public static ITakePhotoTimeCondition GetRootAsITakePhotoTimeCondition(ByteBuffer _bb, ITakePhotoTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A36C RID: 107372 RVA: 0x003BBB41 File Offset: 0x003B9D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A36D RID: 107373 RVA: 0x003BBB50 File Offset: 0x003B9D50
		public ITakePhotoTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D6C RID: 32108
		// (get) Token: 0x0601A36E RID: 107374 RVA: 0x003BBB60 File Offset: 0x003B9D60
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

		// Token: 0x17007D6D RID: 32109
		// (get) Token: 0x0601A36F RID: 107375 RVA: 0x003BBBC0 File Offset: 0x003B9DC0
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

		// Token: 0x17007D6E RID: 32110
		// (get) Token: 0x0601A370 RID: 107376 RVA: 0x003BBBFC File Offset: 0x003B9DFC
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

		// Token: 0x0601A371 RID: 107377 RVA: 0x003BBC33 File Offset: 0x003B9E33
		public Span<byte> GetTidDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601A372 RID: 107378 RVA: 0x003BBC42 File Offset: 0x003B9E42
		public byte[] GetTidDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601A373 RID: 107379 RVA: 0x003BBC50 File Offset: 0x003B9E50
		public static Offset<ITakePhotoTimeCondition> CreateITakePhotoTimeCondition(FlatBufferBuilder builder, Offset<IHourToHour> TimeRangeOffset = default(Offset<IHourToHour>), ECompare Compare = ECompare.Eq, StringOffset TidDescriptionOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITakePhotoTimeCondition.AddTidDescription(builder, TidDescriptionOffset);
			ITakePhotoTimeCondition.AddTimeRange(builder, TimeRangeOffset);
			ITakePhotoTimeCondition.AddCompare(builder, Compare);
			return ITakePhotoTimeCondition.EndITakePhotoTimeCondition(builder);
		}

		// Token: 0x0601A374 RID: 107380 RVA: 0x003BBC74 File Offset: 0x003B9E74
		public static void StartITakePhotoTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A375 RID: 107381 RVA: 0x003BBC7D File Offset: 0x003B9E7D
		public static void AddTimeRange(FlatBufferBuilder builder, Offset<IHourToHour> timeRangeOffset)
		{
			builder.AddOffset(0, timeRangeOffset.Value, 0);
		}

		// Token: 0x0601A376 RID: 107382 RVA: 0x003BBC8D File Offset: 0x003B9E8D
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601A377 RID: 107383 RVA: 0x003BBC98 File Offset: 0x003B9E98
		public static void AddTidDescription(FlatBufferBuilder builder, StringOffset tidDescriptionOffset)
		{
			builder.AddOffset(2, tidDescriptionOffset.Value, 0);
		}

		// Token: 0x0601A378 RID: 107384 RVA: 0x003BBCA8 File Offset: 0x003B9EA8
		public static Offset<ITakePhotoTimeCondition> EndITakePhotoTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhotoTimeCondition>(builder.EndTable());
		}

		// Token: 0x0601A379 RID: 107385 RVA: 0x003BBCB8 File Offset: 0x003B9EB8
		public ITakePhotoTimeConditionT UnPack()
		{
			ITakePhotoTimeConditionT takePhotoTimeConditionT = new ITakePhotoTimeConditionT();
			this.UnPackTo(takePhotoTimeConditionT);
			return takePhotoTimeConditionT;
		}

		// Token: 0x0601A37A RID: 107386 RVA: 0x003BBCD4 File Offset: 0x003B9ED4
		public void UnPackTo(ITakePhotoTimeConditionT _o)
		{
			_o.TimeRange = ((this.TimeRange != null) ? this.TimeRange.Value.UnPack() : null);
			_o.Compare = this.Compare;
			_o.TidDescription = this.TidDescription;
		}

		// Token: 0x0601A37B RID: 107387 RVA: 0x003BBD28 File Offset: 0x003B9F28
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

		// Token: 0x0400C7F8 RID: 51192
		private Table __p;
	}
}
