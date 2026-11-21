using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005631 RID: 22065
	public struct IDurabilityWorn : IFlatbufferObject
	{
		// Token: 0x17009E72 RID: 40562
		// (get) Token: 0x060233B1 RID: 144305 RVA: 0x004D9283 File Offset: 0x004D7483
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060233B2 RID: 144306 RVA: 0x004D9290 File Offset: 0x004D7490
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060233B3 RID: 144307 RVA: 0x004D9298 File Offset: 0x004D7498
		public static IDurabilityWorn GetRootAsIDurabilityWorn(ByteBuffer _bb)
		{
			return IDurabilityWorn.GetRootAsIDurabilityWorn(_bb, default(IDurabilityWorn));
		}

		// Token: 0x060233B4 RID: 144308 RVA: 0x004D92B4 File Offset: 0x004D74B4
		public static IDurabilityWorn GetRootAsIDurabilityWorn(ByteBuffer _bb, IDurabilityWorn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060233B5 RID: 144309 RVA: 0x004D92D1 File Offset: 0x004D74D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060233B6 RID: 144310 RVA: 0x004D92E0 File Offset: 0x004D74E0
		public IDurabilityWorn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E73 RID: 40563
		// (get) Token: 0x060233B7 RID: 144311 RVA: 0x004D92F0 File Offset: 0x004D74F0
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

		// Token: 0x17009E74 RID: 40564
		// (get) Token: 0x060233B8 RID: 144312 RVA: 0x004D932C File Offset: 0x004D752C
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

		// Token: 0x17009E75 RID: 40565
		// (get) Token: 0x060233B9 RID: 144313 RVA: 0x004D9368 File Offset: 0x004D7568
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

		// Token: 0x060233BA RID: 144314 RVA: 0x004D93A4 File Offset: 0x004D75A4
		public static Offset<IDurabilityWorn> CreateIDurabilityWorn(FlatBufferBuilder builder, int SlightWear = 0, int SevereWear = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDurabilityWorn.AddSevereWear(builder, SevereWear);
			IDurabilityWorn.AddSlightWear(builder, SlightWear);
			IDurabilityWorn.AddNullMask(builder, NullMask);
			return IDurabilityWorn.EndIDurabilityWorn(builder);
		}

		// Token: 0x060233BB RID: 144315 RVA: 0x004D93C8 File Offset: 0x004D75C8
		public static void StartIDurabilityWorn(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060233BC RID: 144316 RVA: 0x004D93D1 File Offset: 0x004D75D1
		public static void AddSlightWear(FlatBufferBuilder builder, int slightWear)
		{
			builder.AddInt(0, slightWear, 0);
		}

		// Token: 0x060233BD RID: 144317 RVA: 0x004D93DC File Offset: 0x004D75DC
		public static void AddSevereWear(FlatBufferBuilder builder, int severeWear)
		{
			builder.AddInt(1, severeWear, 0);
		}

		// Token: 0x060233BE RID: 144318 RVA: 0x004D93E7 File Offset: 0x004D75E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060233BF RID: 144319 RVA: 0x004D93F2 File Offset: 0x004D75F2
		public static Offset<IDurabilityWorn> EndIDurabilityWorn(FlatBufferBuilder builder)
		{
			return new Offset<IDurabilityWorn>(builder.EndTable());
		}

		// Token: 0x060233C0 RID: 144320 RVA: 0x004D9400 File Offset: 0x004D7600
		public IDurabilityWornT UnPack()
		{
			IDurabilityWornT durabilityWornT = new IDurabilityWornT();
			this.UnPackTo(durabilityWornT);
			return durabilityWornT;
		}

		// Token: 0x060233C1 RID: 144321 RVA: 0x004D941B File Offset: 0x004D761B
		public void UnPackTo(IDurabilityWornT _o)
		{
			_o.SlightWear = this.SlightWear;
			_o.SevereWear = this.SevereWear;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060233C2 RID: 144322 RVA: 0x004D9444 File Offset: 0x004D7644
		public static Offset<IDurabilityWorn> Pack(FlatBufferBuilder builder, IDurabilityWornT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDurabilityWorn>);
			}
			return IDurabilityWorn.CreateIDurabilityWorn(builder, _o.SlightWear, _o.SevereWear, _o.NullMask);
		}

		// Token: 0x0400ED0E RID: 60686
		private Table __p;
	}
}
