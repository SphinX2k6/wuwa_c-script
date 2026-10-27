using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063EE RID: 25582
	public struct IClientSetSeasonState : IFlatbufferObject
	{
		// Token: 0x1700BE89 RID: 48777
		// (get) Token: 0x0602C41B RID: 181275 RVA: 0x006131A9 File Offset: 0x006113A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C41C RID: 181276 RVA: 0x006131B6 File Offset: 0x006113B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C41D RID: 181277 RVA: 0x006131C0 File Offset: 0x006113C0
		public static IClientSetSeasonState GetRootAsIClientSetSeasonState(ByteBuffer _bb)
		{
			return IClientSetSeasonState.GetRootAsIClientSetSeasonState(_bb, default(IClientSetSeasonState));
		}

		// Token: 0x0602C41E RID: 181278 RVA: 0x006131DC File Offset: 0x006113DC
		public static IClientSetSeasonState GetRootAsIClientSetSeasonState(ByteBuffer _bb, IClientSetSeasonState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C41F RID: 181279 RVA: 0x006131F9 File Offset: 0x006113F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C420 RID: 181280 RVA: 0x00613208 File Offset: 0x00611408
		public IClientSetSeasonState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE8A RID: 48778
		// (get) Token: 0x0602C421 RID: 181281 RVA: 0x00613218 File Offset: 0x00611418
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

		// Token: 0x1700BE8B RID: 48779
		// (get) Token: 0x0602C422 RID: 181282 RVA: 0x00613254 File Offset: 0x00611454
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

		// Token: 0x0602C423 RID: 181283 RVA: 0x00613290 File Offset: 0x00611490
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C424 RID: 181284 RVA: 0x006132D4 File Offset: 0x006114D4
		public ILoopSeasonChange ConfigAsILoopSeasonChange()
		{
			return this.Config<ILoopSeasonChange>().Value;
		}

		// Token: 0x0602C425 RID: 181285 RVA: 0x006132F0 File Offset: 0x006114F0
		public ISwitchSeason ConfigAsISwitchSeason()
		{
			return this.Config<ISwitchSeason>().Value;
		}

		// Token: 0x0602C426 RID: 181286 RVA: 0x0061330B File Offset: 0x0061150B
		public static Offset<IClientSetSeasonState> CreateIClientSetSeasonState(FlatBufferBuilder builder, int VolumeId = 0, TClientSetSeasonState Config_type = TClientSetSeasonState.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			IClientSetSeasonState.AddConfig(builder, ConfigOffset);
			IClientSetSeasonState.AddVolumeId(builder, VolumeId);
			IClientSetSeasonState.AddConfigType(builder, Config_type);
			return IClientSetSeasonState.EndIClientSetSeasonState(builder);
		}

		// Token: 0x0602C427 RID: 181287 RVA: 0x0061332F File Offset: 0x0061152F
		public static void StartIClientSetSeasonState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C428 RID: 181288 RVA: 0x00613338 File Offset: 0x00611538
		public static void AddVolumeId(FlatBufferBuilder builder, int volumeId)
		{
			builder.AddInt(0, volumeId, 0);
		}

		// Token: 0x0602C429 RID: 181289 RVA: 0x00613343 File Offset: 0x00611543
		public static void AddConfigType(FlatBufferBuilder builder, TClientSetSeasonState configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0602C42A RID: 181290 RVA: 0x0061334E File Offset: 0x0061154E
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0602C42B RID: 181291 RVA: 0x00613359 File Offset: 0x00611559
		public static Offset<IClientSetSeasonState> EndIClientSetSeasonState(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetSeasonState>(builder.EndTable());
		}

		// Token: 0x0602C42C RID: 181292 RVA: 0x00613368 File Offset: 0x00611568
		public IClientSetSeasonStateT UnPack()
		{
			IClientSetSeasonStateT clientSetSeasonStateT = new IClientSetSeasonStateT();
			this.UnPackTo(clientSetSeasonStateT);
			return clientSetSeasonStateT;
		}

		// Token: 0x0602C42D RID: 181293 RVA: 0x00613384 File Offset: 0x00611584
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

		// Token: 0x0602C42E RID: 181294 RVA: 0x00613434 File Offset: 0x00611634
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

		// Token: 0x040109D3 RID: 68051
		private Table __p;
	}
}
