using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050CC RID: 20684
	public struct IDurabilityWorn : IFlatbufferObject
	{
		// Token: 0x17009685 RID: 38533
		// (get) Token: 0x0602145D RID: 136285 RVA: 0x0049F2F7 File Offset: 0x0049D4F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602145E RID: 136286 RVA: 0x0049F304 File Offset: 0x0049D504
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602145F RID: 136287 RVA: 0x0049F30C File Offset: 0x0049D50C
		public static IDurabilityWorn GetRootAsIDurabilityWorn(ByteBuffer _bb)
		{
			return IDurabilityWorn.GetRootAsIDurabilityWorn(_bb, default(IDurabilityWorn));
		}

		// Token: 0x06021460 RID: 136288 RVA: 0x0049F328 File Offset: 0x0049D528
		public static IDurabilityWorn GetRootAsIDurabilityWorn(ByteBuffer _bb, IDurabilityWorn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021461 RID: 136289 RVA: 0x0049F345 File Offset: 0x0049D545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021462 RID: 136290 RVA: 0x0049F354 File Offset: 0x0049D554
		public IDurabilityWorn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009686 RID: 38534
		// (get) Token: 0x06021463 RID: 136291 RVA: 0x0049F364 File Offset: 0x0049D564
		public int SlightWear
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009687 RID: 38535
		// (get) Token: 0x06021464 RID: 136292 RVA: 0x0049F3A0 File Offset: 0x0049D5A0
		public int SevereWear
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009688 RID: 38536
		// (get) Token: 0x06021465 RID: 136293 RVA: 0x0049F3DC File Offset: 0x0049D5DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021466 RID: 136294 RVA: 0x0049F418 File Offset: 0x0049D618
		public static Offset<IDurabilityWorn> CreateIDurabilityWorn(FlatBufferBuilder builder, int SlightWear = 0, int SevereWear = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDurabilityWorn.AddSevereWear(builder, SevereWear);
			IDurabilityWorn.AddSlightWear(builder, SlightWear);
			IDurabilityWorn.AddNullMask(builder, NullMask);
			return IDurabilityWorn.EndIDurabilityWorn(builder);
		}

		// Token: 0x06021467 RID: 136295 RVA: 0x0049F43C File Offset: 0x0049D63C
		public static void StartIDurabilityWorn(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021468 RID: 136296 RVA: 0x0049F445 File Offset: 0x0049D645
		public static void AddSlightWear(FlatBufferBuilder builder, int slightWear)
		{
			builder.AddInt(0, slightWear, 0);
		}

		// Token: 0x06021469 RID: 136297 RVA: 0x0049F450 File Offset: 0x0049D650
		public static void AddSevereWear(FlatBufferBuilder builder, int severeWear)
		{
			builder.AddInt(1, severeWear, 0);
		}

		// Token: 0x0602146A RID: 136298 RVA: 0x0049F45B File Offset: 0x0049D65B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602146B RID: 136299 RVA: 0x0049F466 File Offset: 0x0049D666
		public static Offset<IDurabilityWorn> EndIDurabilityWorn(FlatBufferBuilder builder)
		{
			return new Offset<IDurabilityWorn>(builder.EndTable());
		}

		// Token: 0x0602146C RID: 136300 RVA: 0x0049F474 File Offset: 0x0049D674
		public IDurabilityWornT UnPack()
		{
			IDurabilityWornT durabilityWornT = new IDurabilityWornT();
			this.UnPackTo(durabilityWornT);
			return durabilityWornT;
		}

		// Token: 0x0602146D RID: 136301 RVA: 0x0049F48F File Offset: 0x0049D68F
		public void UnPackTo(IDurabilityWornT _o)
		{
			_o.SlightWear = this.SlightWear;
			_o.SevereWear = this.SevereWear;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602146E RID: 136302 RVA: 0x0049F4B8 File Offset: 0x0049D6B8
		public static Offset<IDurabilityWorn> Pack(FlatBufferBuilder builder, IDurabilityWornT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurabilityWorn>);
			}
			return IDurabilityWorn.CreateIDurabilityWorn(builder, _o.SlightWear, _o.SevereWear, _o.NullMask);
		}

		// Token: 0x0400E111 RID: 57617
		private Table __p;
	}
}
