using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713F RID: 28991
	public struct ILiveUiFinishConfig : IFlatbufferObject
	{
		// Token: 0x1700D438 RID: 54328
		// (get) Token: 0x060325D6 RID: 206294 RVA: 0x006CF318 File Offset: 0x006CD518
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325D7 RID: 206295 RVA: 0x006CF325 File Offset: 0x006CD525
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060325D8 RID: 206296 RVA: 0x006CF32C File Offset: 0x006CD52C
		public static ILiveUiFinishConfig GetRootAsILiveUiFinishConfig(ByteBuffer _bb)
		{
			return ILiveUiFinishConfig.GetRootAsILiveUiFinishConfig(_bb, default(ILiveUiFinishConfig));
		}

		// Token: 0x060325D9 RID: 206297 RVA: 0x006CF348 File Offset: 0x006CD548
		public static ILiveUiFinishConfig GetRootAsILiveUiFinishConfig(ByteBuffer _bb, ILiveUiFinishConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060325DA RID: 206298 RVA: 0x006CF365 File Offset: 0x006CD565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060325DB RID: 206299 RVA: 0x006CF374 File Offset: 0x006CD574
		public ILiveUiFinishConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D439 RID: 54329
		// (get) Token: 0x060325DC RID: 206300 RVA: 0x006CF384 File Offset: 0x006CD584
		public ELiveUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveUiType.Start;
				}
				return (ELiveUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D43A RID: 54330
		// (get) Token: 0x060325DD RID: 206301 RVA: 0x006CF3C0 File Offset: 0x006CD5C0
		public int SettlementId
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

		// Token: 0x060325DE RID: 206302 RVA: 0x006CF3FC File Offset: 0x006CD5FC
		public static Offset<ILiveUiFinishConfig> CreateILiveUiFinishConfig(FlatBufferBuilder builder, ELiveUiType Type = ELiveUiType.Start, int SettlementId = 0)
		{
			builder.StartTable(2);
			ILiveUiFinishConfig.AddSettlementId(builder, SettlementId);
			ILiveUiFinishConfig.AddType(builder, Type);
			return ILiveUiFinishConfig.EndILiveUiFinishConfig(builder);
		}

		// Token: 0x060325DF RID: 206303 RVA: 0x006CF419 File Offset: 0x006CD619
		public static void StartILiveUiFinishConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060325E0 RID: 206304 RVA: 0x006CF422 File Offset: 0x006CD622
		public static void AddType(FlatBufferBuilder builder, ELiveUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325E1 RID: 206305 RVA: 0x006CF42D File Offset: 0x006CD62D
		public static void AddSettlementId(FlatBufferBuilder builder, int settlementId)
		{
			builder.AddInt(1, settlementId, 0);
		}

		// Token: 0x060325E2 RID: 206306 RVA: 0x006CF438 File Offset: 0x006CD638
		public static Offset<ILiveUiFinishConfig> EndILiveUiFinishConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUiFinishConfig>(builder.EndTable());
		}

		// Token: 0x060325E3 RID: 206307 RVA: 0x006CF448 File Offset: 0x006CD648
		public ILiveUiFinishConfigT UnPack()
		{
			ILiveUiFinishConfigT liveUiFinishConfigT = new ILiveUiFinishConfigT();
			this.UnPackTo(liveUiFinishConfigT);
			return liveUiFinishConfigT;
		}

		// Token: 0x060325E4 RID: 206308 RVA: 0x006CF463 File Offset: 0x006CD663
		public void UnPackTo(ILiveUiFinishConfigT _o)
		{
			_o.Type = this.Type;
			_o.SettlementId = this.SettlementId;
		}

		// Token: 0x060325E5 RID: 206309 RVA: 0x006CF480 File Offset: 0x006CD680
		public static Offset<ILiveUiFinishConfig> Pack(FlatBufferBuilder builder, ILiveUiFinishConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUiFinishConfig>);
			}
			return ILiveUiFinishConfig.CreateILiveUiFinishConfig(builder, _o.Type, _o.SettlementId);
		}

		// Token: 0x0401212A RID: 74026
		private Table __p;
	}
}
