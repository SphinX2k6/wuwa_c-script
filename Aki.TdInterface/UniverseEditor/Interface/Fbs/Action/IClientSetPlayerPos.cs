using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063EB RID: 25579
	public struct IClientSetPlayerPos : IFlatbufferObject
	{
		// Token: 0x1700BE86 RID: 48774
		// (get) Token: 0x0602C405 RID: 181253 RVA: 0x00612EB2 File Offset: 0x006110B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C406 RID: 181254 RVA: 0x00612EBF File Offset: 0x006110BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C407 RID: 181255 RVA: 0x00612EC8 File Offset: 0x006110C8
		public static IClientSetPlayerPos GetRootAsIClientSetPlayerPos(ByteBuffer _bb)
		{
			return IClientSetPlayerPos.GetRootAsIClientSetPlayerPos(_bb, default(IClientSetPlayerPos));
		}

		// Token: 0x0602C408 RID: 181256 RVA: 0x00612EE4 File Offset: 0x006110E4
		public static IClientSetPlayerPos GetRootAsIClientSetPlayerPos(ByteBuffer _bb, IClientSetPlayerPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C409 RID: 181257 RVA: 0x00612F01 File Offset: 0x00611101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C40A RID: 181258 RVA: 0x00612F10 File Offset: 0x00611110
		public IClientSetPlayerPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE87 RID: 48775
		// (get) Token: 0x0602C40B RID: 181259 RVA: 0x00612F20 File Offset: 0x00611120
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

		// Token: 0x0602C40C RID: 181260 RVA: 0x00612F5C File Offset: 0x0061115C
		public TTable? TelePortConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C40D RID: 181261 RVA: 0x00612FA0 File Offset: 0x006111A0
		public IClientTpRelativeEntityPos TelePortConfigAsIClientTpRelativeEntityPos()
		{
			return this.TelePortConfig<IClientTpRelativeEntityPos>().Value;
		}

		// Token: 0x0602C40E RID: 181262 RVA: 0x00612FBC File Offset: 0x006111BC
		public IClientTpToStreamingTargetPoint TelePortConfigAsIClientTpToStreamingTargetPoint()
		{
			return this.TelePortConfig<IClientTpToStreamingTargetPoint>().Value;
		}

		// Token: 0x0602C40F RID: 181263 RVA: 0x00612FD7 File Offset: 0x006111D7
		public static Offset<IClientSetPlayerPos> CreateIClientSetPlayerPos(FlatBufferBuilder builder, TClientTeleportConfig TelePortConfig_type = TClientTeleportConfig.NONE, int TelePortConfigOffset = 0)
		{
			builder.StartTable(2);
			IClientSetPlayerPos.AddTelePortConfig(builder, TelePortConfigOffset);
			IClientSetPlayerPos.AddTelePortConfigType(builder, TelePortConfig_type);
			return IClientSetPlayerPos.EndIClientSetPlayerPos(builder);
		}

		// Token: 0x0602C410 RID: 181264 RVA: 0x00612FF4 File Offset: 0x006111F4
		public static void StartIClientSetPlayerPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C411 RID: 181265 RVA: 0x00612FFD File Offset: 0x006111FD
		public static void AddTelePortConfigType(FlatBufferBuilder builder, TClientTeleportConfig telePortConfigType)
		{
			builder.AddByte(0, (byte)telePortConfigType, 0);
		}

		// Token: 0x0602C412 RID: 181266 RVA: 0x00613008 File Offset: 0x00611208
		public static void AddTelePortConfig(FlatBufferBuilder builder, int telePortConfigOffset)
		{
			builder.AddOffset(1, telePortConfigOffset, 0);
		}

		// Token: 0x0602C413 RID: 181267 RVA: 0x00613013 File Offset: 0x00611213
		public static Offset<IClientSetPlayerPos> EndIClientSetPlayerPos(FlatBufferBuilder builder)
		{
			return new Offset<IClientSetPlayerPos>(builder.EndTable());
		}

		// Token: 0x0602C414 RID: 181268 RVA: 0x00613020 File Offset: 0x00611220
		public IClientSetPlayerPosT UnPack()
		{
			IClientSetPlayerPosT clientSetPlayerPosT = new IClientSetPlayerPosT();
			this.UnPackTo(clientSetPlayerPosT);
			return clientSetPlayerPosT;
		}

		// Token: 0x0602C415 RID: 181269 RVA: 0x0061303C File Offset: 0x0061123C
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

		// Token: 0x0602C416 RID: 181270 RVA: 0x006130E0 File Offset: 0x006112E0
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

		// Token: 0x040109D1 RID: 68049
		private Table __p;
	}
}
