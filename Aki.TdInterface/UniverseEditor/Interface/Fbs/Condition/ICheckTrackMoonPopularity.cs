using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005046 RID: 20550
	public struct ICheckTrackMoonPopularity : IFlatbufferObject
	{
		// Token: 0x17009310 RID: 37648
		// (get) Token: 0x060201D5 RID: 131541 RVA: 0x00474610 File Offset: 0x00472810
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060201D6 RID: 131542 RVA: 0x0047461D File Offset: 0x0047281D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060201D7 RID: 131543 RVA: 0x00474624 File Offset: 0x00472824
		public static ICheckTrackMoonPopularity GetRootAsICheckTrackMoonPopularity(ByteBuffer _bb)
		{
			return ICheckTrackMoonPopularity.GetRootAsICheckTrackMoonPopularity(_bb, default(ICheckTrackMoonPopularity));
		}

		// Token: 0x060201D8 RID: 131544 RVA: 0x00474640 File Offset: 0x00472840
		public static ICheckTrackMoonPopularity GetRootAsICheckTrackMoonPopularity(ByteBuffer _bb, ICheckTrackMoonPopularity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060201D9 RID: 131545 RVA: 0x0047465D File Offset: 0x0047285D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060201DA RID: 131546 RVA: 0x0047466C File Offset: 0x0047286C
		public ICheckTrackMoonPopularity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009311 RID: 37649
		// (get) Token: 0x060201DB RID: 131547 RVA: 0x0047467C File Offset: 0x0047287C
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009312 RID: 37650
		// (get) Token: 0x060201DC RID: 131548 RVA: 0x004746B8 File Offset: 0x004728B8
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

		// Token: 0x17009313 RID: 37651
		// (get) Token: 0x060201DD RID: 131549 RVA: 0x004746F4 File Offset: 0x004728F4
		public int Popularity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060201DE RID: 131550 RVA: 0x00474730 File Offset: 0x00472930
		public static Offset<ICheckTrackMoonPopularity> CreateICheckTrackMoonPopularity(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, ECompare Compare = ECompare.Eq, int Popularity = 0)
		{
			builder.StartTable(3);
			ICheckTrackMoonPopularity.AddPopularity(builder, Popularity);
			ICheckTrackMoonPopularity.AddCompare(builder, Compare);
			ICheckTrackMoonPopularity.AddType(builder, Type);
			return ICheckTrackMoonPopularity.EndICheckTrackMoonPopularity(builder);
		}

		// Token: 0x060201DF RID: 131551 RVA: 0x00474754 File Offset: 0x00472954
		public static void StartICheckTrackMoonPopularity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060201E0 RID: 131552 RVA: 0x0047475D File Offset: 0x0047295D
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060201E1 RID: 131553 RVA: 0x00474768 File Offset: 0x00472968
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060201E2 RID: 131554 RVA: 0x00474773 File Offset: 0x00472973
		public static void AddPopularity(FlatBufferBuilder builder, int popularity)
		{
			builder.AddInt(2, popularity, 0);
		}

		// Token: 0x060201E3 RID: 131555 RVA: 0x0047477E File Offset: 0x0047297E
		public static Offset<ICheckTrackMoonPopularity> EndICheckTrackMoonPopularity(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrackMoonPopularity>(builder.EndTable());
		}

		// Token: 0x060201E4 RID: 131556 RVA: 0x0047478C File Offset: 0x0047298C
		public ICheckTrackMoonPopularityT UnPack()
		{
			ICheckTrackMoonPopularityT checkTrackMoonPopularityT = new ICheckTrackMoonPopularityT();
			this.UnPackTo(checkTrackMoonPopularityT);
			return checkTrackMoonPopularityT;
		}

		// Token: 0x060201E5 RID: 131557 RVA: 0x004747A7 File Offset: 0x004729A7
		public void UnPackTo(ICheckTrackMoonPopularityT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Popularity = this.Popularity;
		}

		// Token: 0x060201E6 RID: 131558 RVA: 0x004747D0 File Offset: 0x004729D0
		public static Offset<ICheckTrackMoonPopularity> Pack(FlatBufferBuilder builder, ICheckTrackMoonPopularityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrackMoonPopularity>);
			}
			return ICheckTrackMoonPopularity.CreateICheckTrackMoonPopularity(builder, _o.Type, _o.Compare, _o.Popularity);
		}

		// Token: 0x0400DF25 RID: 57125
		private Table __p;
	}
}
