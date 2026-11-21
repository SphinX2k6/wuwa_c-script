using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A6E RID: 27246
	public struct IClientSetSeasonState : IFlatbufferObject
	{
		// Token: 0x1700C823 RID: 51235
		// (get) Token: 0x0602EBF1 RID: 191473 RVA: 0x0065F035 File Offset: 0x0065D235
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EBF2 RID: 191474 RVA: 0x0065F042 File Offset: 0x0065D242
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EBF3 RID: 191475 RVA: 0x0065F04C File Offset: 0x0065D24C
		public static IClientSetSeasonState GetRootAsIClientSetSeasonState(ByteBuffer _bb)
		{
			return IClientSetSeasonState.GetRootAsIClientSetSeasonState(_bb, default(IClientSetSeasonState));
		}

		// Token: 0x0602EBF4 RID: 191476 RVA: 0x0065F068 File Offset: 0x0065D268
		public static IClientSetSeasonState GetRootAsIClientSetSeasonState(ByteBuffer _bb, IClientSetSeasonState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBF5 RID: 191477 RVA: 0x0065F085 File Offset: 0x0065D285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBF6 RID: 191478 RVA: 0x0065F094 File Offset: 0x0065D294
		public IClientSetSeasonState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C824 RID: 51236
		// (get) Token: 0x0602EBF7 RID: 191479 RVA: 0x0065F0A4 File Offset: 0x0065D2A4
		public int VolumeId
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

		// Token: 0x1700C825 RID: 51237
		// (get) Token: 0x0602EBF8 RID: 191480 RVA: 0x0065F0E0 File Offset: 0x0065D2E0
		public TClientSetSeasonState ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TClientSetSeasonState.NONE;
				}
				return (TClientSetSeasonState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EBF9 RID: 191481 RVA: 0x0065F11C File Offset: 0x0065D31C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EBFA RID: 191482 RVA: 0x0065F160 File Offset: 0x0065D360
		public ILoopSeasonChange ConfigAsILoopSeasonChange()
		{
			return this.Config<ILoopSeasonChange>().Value;
		}

		// Token: 0x0602EBFB RID: 191483 RVA: 0x0065F17C File Offset: 0x0065D37C
		public ISwitchSeason ConfigAsISwitchSeason()
		{
			return this.Config<ISwitchSeason>().Value;
		}

		// Token: 0x0602EBFC RID: 191484 RVA: 0x0065F197 File Offset: 0x0065D397
		public static Offset<IClientSetSeasonState> CreateIClientSetSeasonState(FlatBufferBuilder builder, int VolumeId = 0, TClientSetSeasonState Config_type = TClientSetSeasonState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			IClientSetSeasonState.AddConfig(builder, ConfigOffset);
			IClientSetSeasonState.AddVolumeId(builder, VolumeId);
			IClientSetSeasonState.AddConfigType(builder, Config_type);
			return IClientSetSeasonState.EndIClientSetSeasonState(builder);
		}

		// Token: 0x0602EBFD RID: 191485 RVA: 0x0065F1BB File Offset: 0x0065D3BB
		public static void StartIClientSetSeasonState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EBFE RID: 191486 RVA: 0x0065F1C4 File Offset: 0x0065D3C4
		public static void AddVolumeId(FlatBufferBuilder builder, int volumeId)
		{
			builder.AddInt(0, volumeId, 0);
		}

		// Token: 0x0602EBFF RID: 191487 RVA: 0x0065F1CF File Offset: 0x0065D3CF
		public static void AddConfigType(FlatBufferBuilder builder, TClientSetSeasonState configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0602EC00 RID: 191488 RVA: 0x0065F1DA File Offset: 0x0065D3DA
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0602EC01 RID: 191489 RVA: 0x0065F1E5 File Offset: 0x0065D3E5
		public static Offset<IClientSetSeasonState> EndIClientSetSeasonState(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetSeasonState>(builder.EndTable());
		}

		// Token: 0x0602EC02 RID: 191490 RVA: 0x0065F1F4 File Offset: 0x0065D3F4
		public IClientSetSeasonStateT UnPack()
		{
			IClientSetSeasonStateT clientSetSeasonStateT = new IClientSetSeasonStateT();
			this.UnPackTo(clientSetSeasonStateT);
			return clientSetSeasonStateT;
		}

		// Token: 0x0602EC03 RID: 191491 RVA: 0x0065F210 File Offset: 0x0065D410
		public void UnPackTo(IClientSetSeasonStateT _o)
		{
			_o.VolumeId = this.VolumeId;
			_o.Config = new TClientSetSeasonStateUnion();
			_o.Config.Type = this.ConfigType;
			TClientSetSeasonState configType = this.ConfigType;
			if (configType == TClientSetSeasonState.ILoopSeasonChange)
			{
				_o.Config.Value = ((this.Config<ILoopSeasonChange>() != null) ? this.Config<ILoopSeasonChange>().Value.UnPack() : null);
				return;
			}
			if (configType != TClientSetSeasonState.ISwitchSeason)
			{
				return;
			}
			_o.Config.Value = ((this.Config<ISwitchSeason>() != null) ? this.Config<ISwitchSeason>().Value.UnPack() : null);
		}

		// Token: 0x0602EC04 RID: 191492 RVA: 0x0065F2C0 File Offset: 0x0065D4C0
		public static Offset<IClientSetSeasonState> Pack(FlatBufferBuilder builder, IClientSetSeasonStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientSetSeasonState>);
			}
			TClientSetSeasonState config_type = (_o.Config == null) ? TClientSetSeasonState.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TClientSetSeasonStateUnion.Pack(builder, _o.Config);
			return IClientSetSeasonState.CreateIClientSetSeasonState(builder, _o.VolumeId, config_type, configOffset);
		}

		// Token: 0x040117F9 RID: 71673
		private Table __p;
	}
}
