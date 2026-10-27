using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DD RID: 22237
	public struct IPasserbyNpcSpawnCountOverride : IFlatbufferObject
	{
		// Token: 0x1700A583 RID: 42371
		// (get) Token: 0x0602526A RID: 152170 RVA: 0x00520DA3 File Offset: 0x0051EFA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602526B RID: 152171 RVA: 0x00520DB0 File Offset: 0x0051EFB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602526C RID: 152172 RVA: 0x00520DB8 File Offset: 0x0051EFB8
		public static IPasserbyNpcSpawnCountOverride GetRootAsIPasserbyNpcSpawnCountOverride(ByteBuffer _bb)
		{
			return IPasserbyNpcSpawnCountOverride.GetRootAsIPasserbyNpcSpawnCountOverride(_bb, default(IPasserbyNpcSpawnCountOverride));
		}

		// Token: 0x0602526D RID: 152173 RVA: 0x00520DD4 File Offset: 0x0051EFD4
		public static IPasserbyNpcSpawnCountOverride GetRootAsIPasserbyNpcSpawnCountOverride(ByteBuffer _bb, IPasserbyNpcSpawnCountOverride obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602526E RID: 152174 RVA: 0x00520DF1 File Offset: 0x0051EFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602526F RID: 152175 RVA: 0x00520E00 File Offset: 0x0051F000
		public IPasserbyNpcSpawnCountOverride __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A584 RID: 42372
		// (get) Token: 0x06025270 RID: 152176 RVA: 0x00520E10 File Offset: 0x0051F010
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

		// Token: 0x1700A585 RID: 42373
		// (get) Token: 0x06025271 RID: 152177 RVA: 0x00520E4C File Offset: 0x0051F04C
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

		// Token: 0x1700A586 RID: 42374
		// (get) Token: 0x06025272 RID: 152178 RVA: 0x00520E88 File Offset: 0x0051F088
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

		// Token: 0x06025273 RID: 152179 RVA: 0x00520EC4 File Offset: 0x0051F0C4
		public static Offset<IPasserbyNpcSpawnCountOverride> CreateIPasserbyNpcSpawnCountOverride(FlatBufferBuilder builder, int PcSpawnCount = 0, int MobileSpawnCount = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPasserbyNpcSpawnCountOverride.AddMobileSpawnCount(builder, MobileSpawnCount);
			IPasserbyNpcSpawnCountOverride.AddPcSpawnCount(builder, PcSpawnCount);
			IPasserbyNpcSpawnCountOverride.AddNullMask(builder, NullMask);
			return IPasserbyNpcSpawnCountOverride.EndIPasserbyNpcSpawnCountOverride(builder);
		}

		// Token: 0x06025274 RID: 152180 RVA: 0x00520EE8 File Offset: 0x0051F0E8
		public static void StartIPasserbyNpcSpawnCountOverride(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025275 RID: 152181 RVA: 0x00520EF1 File Offset: 0x0051F0F1
		public static void AddPcSpawnCount(FlatBufferBuilder builder, int pcSpawnCount)
		{
			builder.AddInt(0, pcSpawnCount, 0);
		}

		// Token: 0x06025276 RID: 152182 RVA: 0x00520EFC File Offset: 0x0051F0FC
		public static void AddMobileSpawnCount(FlatBufferBuilder builder, int mobileSpawnCount)
		{
			builder.AddInt(1, mobileSpawnCount, 0);
		}

		// Token: 0x06025277 RID: 152183 RVA: 0x00520F07 File Offset: 0x0051F107
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025278 RID: 152184 RVA: 0x00520F12 File Offset: 0x0051F112
		public static Offset<IPasserbyNpcSpawnCountOverride> EndIPasserbyNpcSpawnCountOverride(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpawnCountOverride>(builder.EndTable());
		}

		// Token: 0x06025279 RID: 152185 RVA: 0x00520F20 File Offset: 0x0051F120
		public IPasserbyNpcSpawnCountOverrideT UnPack()
		{
			IPasserbyNpcSpawnCountOverrideT passerbyNpcSpawnCountOverrideT = new IPasserbyNpcSpawnCountOverrideT();
			this.UnPackTo(passerbyNpcSpawnCountOverrideT);
			return passerbyNpcSpawnCountOverrideT;
		}

		// Token: 0x0602527A RID: 152186 RVA: 0x00520F3B File Offset: 0x0051F13B
		public void UnPackTo(IPasserbyNpcSpawnCountOverrideT _o)
		{
			_o.PcSpawnCount = this.PcSpawnCount;
			_o.MobileSpawnCount = this.MobileSpawnCount;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602527B RID: 152187 RVA: 0x00520F64 File Offset: 0x0051F164
		public static Offset<IPasserbyNpcSpawnCountOverride> Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnCountOverrideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpawnCountOverride>);
			}
			return IPasserbyNpcSpawnCountOverride.CreateIPasserbyNpcSpawnCountOverride(builder, _o.PcSpawnCount, _o.MobileSpawnCount, _o.NullMask);
		}

		// Token: 0x0400EB28 RID: 60200
		private Table __p;
	}
}
