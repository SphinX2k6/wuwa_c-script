using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200604A RID: 24650
	public struct ITeleControlBaseCfg : IFlatbufferObject
	{
		// Token: 0x1700B703 RID: 46851
		// (get) Token: 0x060299FA RID: 170490 RVA: 0x005AEF56 File Offset: 0x005AD156
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060299FB RID: 170491 RVA: 0x005AEF63 File Offset: 0x005AD163
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060299FC RID: 170492 RVA: 0x005AEF6C File Offset: 0x005AD16C
		public static ITeleControlBaseCfg GetRootAsITeleControlBaseCfg(ByteBuffer _bb)
		{
			return ITeleControlBaseCfg.GetRootAsITeleControlBaseCfg(_bb, default(ITeleControlBaseCfg));
		}

		// Token: 0x060299FD RID: 170493 RVA: 0x005AEF88 File Offset: 0x005AD188
		public static ITeleControlBaseCfg GetRootAsITeleControlBaseCfg(ByteBuffer _bb, ITeleControlBaseCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060299FE RID: 170494 RVA: 0x005AEFA5 File Offset: 0x005AD1A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060299FF RID: 170495 RVA: 0x005AEFB4 File Offset: 0x005AD1B4
		public ITeleControlBaseCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B704 RID: 46852
		// (get) Token: 0x06029A00 RID: 170496 RVA: 0x005AEFC4 File Offset: 0x005AD1C4
		public string CommonConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029A01 RID: 170497 RVA: 0x005AEFFB File Offset: 0x005AD1FB
		public Span<byte> GetCommonConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029A02 RID: 170498 RVA: 0x005AF00A File Offset: 0x005AD20A
		public byte[] GetCommonConfigArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B705 RID: 46853
		// (get) Token: 0x06029A03 RID: 170499 RVA: 0x005AF018 File Offset: 0x005AD218
		public bool CanRotate
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B706 RID: 46854
		// (get) Token: 0x06029A04 RID: 170500 RVA: 0x005AF058 File Offset: 0x005AD258
		public bool InitialGravity
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B707 RID: 46855
		// (get) Token: 0x06029A05 RID: 170501 RVA: 0x005AF098 File Offset: 0x005AD298
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029A06 RID: 170502 RVA: 0x005AF0D5 File Offset: 0x005AD2D5
		public static Offset<ITeleControlBaseCfg> CreateITeleControlBaseCfg(FlatBufferBuilder builder, StringOffset CommonConfigOffset = default(StringOffset), bool CanRotate = false, bool InitialGravity = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleControlBaseCfg.AddCommonConfig(builder, CommonConfigOffset);
			ITeleControlBaseCfg.AddNullMask(builder, NullMask);
			ITeleControlBaseCfg.AddInitialGravity(builder, InitialGravity);
			ITeleControlBaseCfg.AddCanRotate(builder, CanRotate);
			return ITeleControlBaseCfg.EndITeleControlBaseCfg(builder);
		}

		// Token: 0x06029A07 RID: 170503 RVA: 0x005AF101 File Offset: 0x005AD301
		public static void StartITeleControlBaseCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06029A08 RID: 170504 RVA: 0x005AF10A File Offset: 0x005AD30A
		public static void AddCommonConfig(FlatBufferBuilder builder, StringOffset commonConfigOffset)
		{
			builder.AddOffset(0, commonConfigOffset.Value, 0);
		}

		// Token: 0x06029A09 RID: 170505 RVA: 0x005AF11A File Offset: 0x005AD31A
		public static void AddCanRotate(FlatBufferBuilder builder, bool canRotate)
		{
			builder.AddBool(1, canRotate, false);
		}

		// Token: 0x06029A0A RID: 170506 RVA: 0x005AF125 File Offset: 0x005AD325
		public static void AddInitialGravity(FlatBufferBuilder builder, bool initialGravity)
		{
			builder.AddBool(2, initialGravity, false);
		}

		// Token: 0x06029A0B RID: 170507 RVA: 0x005AF130 File Offset: 0x005AD330
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06029A0C RID: 170508 RVA: 0x005AF13B File Offset: 0x005AD33B
		public static Offset<ITeleControlBaseCfg> EndITeleControlBaseCfg(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControlBaseCfg>(builder.EndTable());
		}

		// Token: 0x06029A0D RID: 170509 RVA: 0x005AF148 File Offset: 0x005AD348
		public ITeleControlBaseCfgT UnPack()
		{
			ITeleControlBaseCfgT teleControlBaseCfgT = new ITeleControlBaseCfgT();
			this.UnPackTo(teleControlBaseCfgT);
			return teleControlBaseCfgT;
		}

		// Token: 0x06029A0E RID: 170510 RVA: 0x005AF163 File Offset: 0x005AD363
		public void UnPackTo(ITeleControlBaseCfgT _o)
		{
			_o.CommonConfig = this.CommonConfig;
			_o.CanRotate = this.CanRotate;
			_o.InitialGravity = this.InitialGravity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029A0F RID: 170511 RVA: 0x005AF198 File Offset: 0x005AD398
		public static Offset<ITeleControlBaseCfg> Pack(FlatBufferBuilder builder, ITeleControlBaseCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleControlBaseCfg>);
			}
			StringOffset commonConfigOffset = (_o.CommonConfig == null) ? default(StringOffset) : builder.CreateString(_o.CommonConfig);
			return ITeleControlBaseCfg.CreateITeleControlBaseCfg(builder, commonConfigOffset, _o.CanRotate, _o.InitialGravity, _o.NullMask);
		}

		// Token: 0x0400FDAE RID: 64942
		private Table __p;
	}
}
