using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6B RID: 27243
	public struct IClientSetPlayerPos : IFlatbufferObject
	{
		// Token: 0x1700C820 RID: 51232
		// (get) Token: 0x0602EBDB RID: 191451 RVA: 0x0065ED3E File Offset: 0x0065CF3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EBDC RID: 191452 RVA: 0x0065ED4B File Offset: 0x0065CF4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EBDD RID: 191453 RVA: 0x0065ED54 File Offset: 0x0065CF54
		public static IClientSetPlayerPos GetRootAsIClientSetPlayerPos(ByteBuffer _bb)
		{
			return IClientSetPlayerPos.GetRootAsIClientSetPlayerPos(_bb, default(IClientSetPlayerPos));
		}

		// Token: 0x0602EBDE RID: 191454 RVA: 0x0065ED70 File Offset: 0x0065CF70
		public static IClientSetPlayerPos GetRootAsIClientSetPlayerPos(ByteBuffer _bb, IClientSetPlayerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBDF RID: 191455 RVA: 0x0065ED8D File Offset: 0x0065CF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBE0 RID: 191456 RVA: 0x0065ED9C File Offset: 0x0065CF9C
		public IClientSetPlayerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C821 RID: 51233
		// (get) Token: 0x0602EBE1 RID: 191457 RVA: 0x0065EDAC File Offset: 0x0065CFAC
		public TClientTeleportConfig TelePortConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TClientTeleportConfig.NONE;
				}
				return (TClientTeleportConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EBE2 RID: 191458 RVA: 0x0065EDE8 File Offset: 0x0065CFE8
		public TTable? TelePortConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EBE3 RID: 191459 RVA: 0x0065EE2C File Offset: 0x0065D02C
		public IClientTpRelativeEntityPos TelePortConfigAsIClientTpRelativeEntityPos()
		{
			return this.TelePortConfig<IClientTpRelativeEntityPos>().Value;
		}

		// Token: 0x0602EBE4 RID: 191460 RVA: 0x0065EE48 File Offset: 0x0065D048
		public IClientTpToStreamingTargetPoint TelePortConfigAsIClientTpToStreamingTargetPoint()
		{
			return this.TelePortConfig<IClientTpToStreamingTargetPoint>().Value;
		}

		// Token: 0x0602EBE5 RID: 191461 RVA: 0x0065EE63 File Offset: 0x0065D063
		public static Offset<IClientSetPlayerPos> CreateIClientSetPlayerPos(FlatBufferBuilder builder, TClientTeleportConfig TelePortConfig_type = TClientTeleportConfig.NONE, int TelePortConfigOffset = 0)
		{
			builder.StartTable(2);
			IClientSetPlayerPos.AddTelePortConfig(builder, TelePortConfigOffset);
			IClientSetPlayerPos.AddTelePortConfigType(builder, TelePortConfig_type);
			return IClientSetPlayerPos.EndIClientSetPlayerPos(builder);
		}

		// Token: 0x0602EBE6 RID: 191462 RVA: 0x0065EE80 File Offset: 0x0065D080
		public static void StartIClientSetPlayerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EBE7 RID: 191463 RVA: 0x0065EE89 File Offset: 0x0065D089
		public static void AddTelePortConfigType(FlatBufferBuilder builder, TClientTeleportConfig telePortConfigType)
		{
			builder.AddByte(0, (byte)telePortConfigType, 0);
		}

		// Token: 0x0602EBE8 RID: 191464 RVA: 0x0065EE94 File Offset: 0x0065D094
		public static void AddTelePortConfig(FlatBufferBuilder builder, int telePortConfigOffset)
		{
			builder.AddOffset(1, telePortConfigOffset, 0);
		}

		// Token: 0x0602EBE9 RID: 191465 RVA: 0x0065EE9F File Offset: 0x0065D09F
		public static Offset<IClientSetPlayerPos> EndIClientSetPlayerPos(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetPlayerPos>(builder.EndTable());
		}

		// Token: 0x0602EBEA RID: 191466 RVA: 0x0065EEAC File Offset: 0x0065D0AC
		public IClientSetPlayerPosT UnPack()
		{
			IClientSetPlayerPosT clientSetPlayerPosT = new IClientSetPlayerPosT();
			this.UnPackTo(clientSetPlayerPosT);
			return clientSetPlayerPosT;
		}

		// Token: 0x0602EBEB RID: 191467 RVA: 0x0065EEC8 File Offset: 0x0065D0C8
		public void UnPackTo(IClientSetPlayerPosT _o)
		{
			_o.TelePortConfig = new TClientTeleportConfigUnion();
			_o.TelePortConfig.Type = this.TelePortConfigType;
			TClientTeleportConfig telePortConfigType = this.TelePortConfigType;
			if (telePortConfigType == TClientTeleportConfig.IClientTpRelativeEntityPos)
			{
				_o.TelePortConfig.Value = ((this.TelePortConfig<IClientTpRelativeEntityPos>() != null) ? this.TelePortConfig<IClientTpRelativeEntityPos>().Value.UnPack() : null);
				return;
			}
			if (telePortConfigType != TClientTeleportConfig.IClientTpToStreamingTargetPoint)
			{
				return;
			}
			_o.TelePortConfig.Value = ((this.TelePortConfig<IClientTpToStreamingTargetPoint>() != null) ? this.TelePortConfig<IClientTpToStreamingTargetPoint>().Value.UnPack() : null);
		}

		// Token: 0x0602EBEC RID: 191468 RVA: 0x0065EF6C File Offset: 0x0065D16C
		public static Offset<IClientSetPlayerPos> Pack(FlatBufferBuilder builder, IClientSetPlayerPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientSetPlayerPos>);
			}
			TClientTeleportConfig telePortConfig_type = (_o.TelePortConfig == null) ? TClientTeleportConfig.NONE : _o.TelePortConfig.Type;
			int telePortConfigOffset = (_o.TelePortConfig == null) ? 0 : TClientTeleportConfigUnion.Pack(builder, _o.TelePortConfig);
			return IClientSetPlayerPos.CreateIClientSetPlayerPos(builder, telePortConfig_type, telePortConfigOffset);
		}

		// Token: 0x040117F7 RID: 71671
		private Table __p;
	}
}
