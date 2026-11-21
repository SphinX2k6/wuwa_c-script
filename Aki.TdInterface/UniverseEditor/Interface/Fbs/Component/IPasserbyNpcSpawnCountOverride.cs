using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC9 RID: 23753
	public struct IPasserbyNpcSpawnCountOverride : IFlatbufferObject
	{
		// Token: 0x1700AE81 RID: 44673
		// (get) Token: 0x060276BB RID: 161467 RVA: 0x0056555F File Offset: 0x0056375F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060276BC RID: 161468 RVA: 0x0056556C File Offset: 0x0056376C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060276BD RID: 161469 RVA: 0x00565574 File Offset: 0x00563774
		public static IPasserbyNpcSpawnCountOverride GetRootAsIPasserbyNpcSpawnCountOverride(ByteBuffer _bb)
		{
			return IPasserbyNpcSpawnCountOverride.GetRootAsIPasserbyNpcSpawnCountOverride(_bb, default(IPasserbyNpcSpawnCountOverride));
		}

		// Token: 0x060276BE RID: 161470 RVA: 0x00565590 File Offset: 0x00563790
		public static IPasserbyNpcSpawnCountOverride GetRootAsIPasserbyNpcSpawnCountOverride(ByteBuffer _bb, IPasserbyNpcSpawnCountOverride obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060276BF RID: 161471 RVA: 0x005655AD File Offset: 0x005637AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060276C0 RID: 161472 RVA: 0x005655BC File Offset: 0x005637BC
		public IPasserbyNpcSpawnCountOverride __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE82 RID: 44674
		// (get) Token: 0x060276C1 RID: 161473 RVA: 0x005655CC File Offset: 0x005637CC
		public int PcSpawnCount
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

		// Token: 0x1700AE83 RID: 44675
		// (get) Token: 0x060276C2 RID: 161474 RVA: 0x00565608 File Offset: 0x00563808
		public int MobileSpawnCount
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

		// Token: 0x1700AE84 RID: 44676
		// (get) Token: 0x060276C3 RID: 161475 RVA: 0x00565644 File Offset: 0x00563844
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

		// Token: 0x060276C4 RID: 161476 RVA: 0x00565680 File Offset: 0x00563880
		public static Offset<IPasserbyNpcSpawnCountOverride> CreateIPasserbyNpcSpawnCountOverride(FlatBufferBuilder builder, int PcSpawnCount = 0, int MobileSpawnCount = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPasserbyNpcSpawnCountOverride.AddMobileSpawnCount(builder, MobileSpawnCount);
			IPasserbyNpcSpawnCountOverride.AddPcSpawnCount(builder, PcSpawnCount);
			IPasserbyNpcSpawnCountOverride.AddNullMask(builder, NullMask);
			return IPasserbyNpcSpawnCountOverride.EndIPasserbyNpcSpawnCountOverride(builder);
		}

		// Token: 0x060276C5 RID: 161477 RVA: 0x005656A4 File Offset: 0x005638A4
		public static void StartIPasserbyNpcSpawnCountOverride(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060276C6 RID: 161478 RVA: 0x005656AD File Offset: 0x005638AD
		public static void AddPcSpawnCount(FlatBufferBuilder builder, int pcSpawnCount)
		{
			builder.AddInt(0, pcSpawnCount, 0);
		}

		// Token: 0x060276C7 RID: 161479 RVA: 0x005656B8 File Offset: 0x005638B8
		public static void AddMobileSpawnCount(FlatBufferBuilder builder, int mobileSpawnCount)
		{
			builder.AddInt(1, mobileSpawnCount, 0);
		}

		// Token: 0x060276C8 RID: 161480 RVA: 0x005656C3 File Offset: 0x005638C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060276C9 RID: 161481 RVA: 0x005656CE File Offset: 0x005638CE
		public static Offset<IPasserbyNpcSpawnCountOverride> EndIPasserbyNpcSpawnCountOverride(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpawnCountOverride>(builder.EndTable());
		}

		// Token: 0x060276CA RID: 161482 RVA: 0x005656DC File Offset: 0x005638DC
		public IPasserbyNpcSpawnCountOverrideT UnPack()
		{
			IPasserbyNpcSpawnCountOverrideT passerbyNpcSpawnCountOverrideT = new IPasserbyNpcSpawnCountOverrideT();
			this.UnPackTo(passerbyNpcSpawnCountOverrideT);
			return passerbyNpcSpawnCountOverrideT;
		}

		// Token: 0x060276CB RID: 161483 RVA: 0x005656F7 File Offset: 0x005638F7
		public void UnPackTo(IPasserbyNpcSpawnCountOverrideT _o)
		{
			_o.PcSpawnCount = this.PcSpawnCount;
			_o.MobileSpawnCount = this.MobileSpawnCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060276CC RID: 161484 RVA: 0x00565720 File Offset: 0x00563920
		public static Offset<IPasserbyNpcSpawnCountOverride> Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnCountOverrideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpawnCountOverride>);
			}
			return IPasserbyNpcSpawnCountOverride.CreateIPasserbyNpcSpawnCountOverride(builder, _o.PcSpawnCount, _o.MobileSpawnCount, _o.NullMask);
		}

		// Token: 0x0400F7F2 RID: 63474
		private Table __p;
	}
}
