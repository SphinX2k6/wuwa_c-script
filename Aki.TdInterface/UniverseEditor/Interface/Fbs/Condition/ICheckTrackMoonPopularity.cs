using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B5F RID: 19295
	public struct ICheckTrackMoonPopularity : IFlatbufferObject
	{
		// Token: 0x17008C00 RID: 35840
		// (get) Token: 0x0601E647 RID: 124487 RVA: 0x00441DC4 File Offset: 0x0043FFC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E648 RID: 124488 RVA: 0x00441DD1 File Offset: 0x0043FFD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E649 RID: 124489 RVA: 0x00441DD8 File Offset: 0x0043FFD8
		public static ICheckTrackMoonPopularity GetRootAsICheckTrackMoonPopularity(ByteBuffer _bb)
		{
			return ICheckTrackMoonPopularity.GetRootAsICheckTrackMoonPopularity(_bb, default(ICheckTrackMoonPopularity));
		}

		// Token: 0x0601E64A RID: 124490 RVA: 0x00441DF4 File Offset: 0x0043FFF4
		public static ICheckTrackMoonPopularity GetRootAsICheckTrackMoonPopularity(ByteBuffer _bb, ICheckTrackMoonPopularity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E64B RID: 124491 RVA: 0x00441E11 File Offset: 0x00440011
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E64C RID: 124492 RVA: 0x00441E20 File Offset: 0x00440020
		public ICheckTrackMoonPopularity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C01 RID: 35841
		// (get) Token: 0x0601E64D RID: 124493 RVA: 0x00441E30 File Offset: 0x00440030
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

		// Token: 0x17008C02 RID: 35842
		// (get) Token: 0x0601E64E RID: 124494 RVA: 0x00441E6C File Offset: 0x0044006C
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

		// Token: 0x17008C03 RID: 35843
		// (get) Token: 0x0601E64F RID: 124495 RVA: 0x00441EA8 File Offset: 0x004400A8
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

		// Token: 0x0601E650 RID: 124496 RVA: 0x00441EE4 File Offset: 0x004400E4
		public static Offset<ICheckTrackMoonPopularity> CreateICheckTrackMoonPopularity(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, ECompare Compare = ECompare.Eq, int Popularity = 0)
		{
			builder.StartTable(3);
			ICheckTrackMoonPopularity.AddPopularity(builder, Popularity);
			ICheckTrackMoonPopularity.AddCompare(builder, Compare);
			ICheckTrackMoonPopularity.AddType(builder, Type);
			return ICheckTrackMoonPopularity.EndICheckTrackMoonPopularity(builder);
		}

		// Token: 0x0601E651 RID: 124497 RVA: 0x00441F08 File Offset: 0x00440108
		public static void StartICheckTrackMoonPopularity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E652 RID: 124498 RVA: 0x00441F11 File Offset: 0x00440111
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E653 RID: 124499 RVA: 0x00441F1C File Offset: 0x0044011C
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E654 RID: 124500 RVA: 0x00441F27 File Offset: 0x00440127
		public static void AddPopularity(FlatBufferBuilder builder, int popularity)
		{
			builder.AddInt(2, popularity, 0);
		}

		// Token: 0x0601E655 RID: 124501 RVA: 0x00441F32 File Offset: 0x00440132
		public static Offset<ICheckTrackMoonPopularity> EndICheckTrackMoonPopularity(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrackMoonPopularity>(builder.EndTable());
		}

		// Token: 0x0601E656 RID: 124502 RVA: 0x00441F40 File Offset: 0x00440140
		public ICheckTrackMoonPopularityT UnPack()
		{
			ICheckTrackMoonPopularityT checkTrackMoonPopularityT = new ICheckTrackMoonPopularityT();
			this.UnPackTo(checkTrackMoonPopularityT);
			return checkTrackMoonPopularityT;
		}

		// Token: 0x0601E657 RID: 124503 RVA: 0x00441F5B File Offset: 0x0044015B
		public void UnPackTo(ICheckTrackMoonPopularityT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Popularity = this.Popularity;
		}

		// Token: 0x0601E658 RID: 124504 RVA: 0x00441F84 File Offset: 0x00440184
		public static Offset<ICheckTrackMoonPopularity> Pack(FlatBufferBuilder builder, ICheckTrackMoonPopularityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrackMoonPopularity>);
			}
			return ICheckTrackMoonPopularity.CreateICheckTrackMoonPopularity(builder, _o.Type, _o.Compare, _o.Popularity);
		}

		// Token: 0x0400D425 RID: 54309
		private Table __p;
	}
}
