using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060AD RID: 24749
	public struct IActorFxEmoteOverrideConfig : IFlatbufferObject
	{
		// Token: 0x1700B65A RID: 46682
		// (get) Token: 0x0602A3EE RID: 173038 RVA: 0x005D2D98 File Offset: 0x005D0F98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A3EF RID: 173039 RVA: 0x005D2DA5 File Offset: 0x005D0FA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A3F0 RID: 173040 RVA: 0x005D2DAC File Offset: 0x005D0FAC
		public static IActorFxEmoteOverrideConfig GetRootAsIActorFxEmoteOverrideConfig(ByteBuffer _bb)
		{
			return IActorFxEmoteOverrideConfig.GetRootAsIActorFxEmoteOverrideConfig(_bb, default(IActorFxEmoteOverrideConfig));
		}

		// Token: 0x0602A3F1 RID: 173041 RVA: 0x005D2DC8 File Offset: 0x005D0FC8
		public static IActorFxEmoteOverrideConfig GetRootAsIActorFxEmoteOverrideConfig(ByteBuffer _bb, IActorFxEmoteOverrideConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A3F2 RID: 173042 RVA: 0x005D2DE5 File Offset: 0x005D0FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A3F3 RID: 173043 RVA: 0x005D2DF4 File Offset: 0x005D0FF4
		public IActorFxEmoteOverrideConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B65B RID: 46683
		// (get) Token: 0x0602A3F4 RID: 173044 RVA: 0x005D2E04 File Offset: 0x005D1004
		public string SocketName
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

		// Token: 0x0602A3F5 RID: 173045 RVA: 0x005D2E3B File Offset: 0x005D103B
		public Span<byte> GetSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602A3F6 RID: 173046 RVA: 0x005D2E4A File Offset: 0x005D104A
		public byte[] GetSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B65C RID: 46684
		// (get) Token: 0x0602A3F7 RID: 173047 RVA: 0x005D2E58 File Offset: 0x005D1058
		public IVectorInfo? RelativePosition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B65D RID: 46685
		// (get) Token: 0x0602A3F8 RID: 173048 RVA: 0x005D2EB8 File Offset: 0x005D10B8
		public IVectorInfo? RelativeRotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B65E RID: 46686
		// (get) Token: 0x0602A3F9 RID: 173049 RVA: 0x005D2F18 File Offset: 0x005D1118
		public IVectorInfo? Scale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A3FA RID: 173050 RVA: 0x005D2F76 File Offset: 0x005D1176
		public static Offset<IActorFxEmoteOverrideConfig> CreateIActorFxEmoteOverrideConfig(FlatBufferBuilder builder, StringOffset SocketNameOffset = default(StringOffset), Offset<IVectorInfo> RelativePositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RelativeRotationOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ScaleOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IActorFxEmoteOverrideConfig.AddScale(builder, ScaleOffset);
			IActorFxEmoteOverrideConfig.AddRelativeRotation(builder, RelativeRotationOffset);
			IActorFxEmoteOverrideConfig.AddRelativePosition(builder, RelativePositionOffset);
			IActorFxEmoteOverrideConfig.AddSocketName(builder, SocketNameOffset);
			return IActorFxEmoteOverrideConfig.EndIActorFxEmoteOverrideConfig(builder);
		}

		// Token: 0x0602A3FB RID: 173051 RVA: 0x005D2FA2 File Offset: 0x005D11A2
		public static void StartIActorFxEmoteOverrideConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A3FC RID: 173052 RVA: 0x005D2FAB File Offset: 0x005D11AB
		public static void AddSocketName(FlatBufferBuilder builder, StringOffset socketNameOffset)
		{
			builder.AddOffset(0, socketNameOffset.Value, 0);
		}

		// Token: 0x0602A3FD RID: 173053 RVA: 0x005D2FBB File Offset: 0x005D11BB
		public static void AddRelativePosition(FlatBufferBuilder builder, Offset<IVectorInfo> relativePositionOffset)
		{
			builder.AddOffset(1, relativePositionOffset.Value, 0);
		}

		// Token: 0x0602A3FE RID: 173054 RVA: 0x005D2FCB File Offset: 0x005D11CB
		public static void AddRelativeRotation(FlatBufferBuilder builder, Offset<IVectorInfo> relativeRotationOffset)
		{
			builder.AddOffset(2, relativeRotationOffset.Value, 0);
		}

		// Token: 0x0602A3FF RID: 173055 RVA: 0x005D2FDB File Offset: 0x005D11DB
		public static void AddScale(FlatBufferBuilder builder, Offset<IVectorInfo> scaleOffset)
		{
			builder.AddOffset(3, scaleOffset.Value, 0);
		}

		// Token: 0x0602A400 RID: 173056 RVA: 0x005D2FEB File Offset: 0x005D11EB
		public static Offset<IActorFxEmoteOverrideConfig> EndIActorFxEmoteOverrideConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteOverrideConfig>(builder.EndTable());
		}

		// Token: 0x0602A401 RID: 173057 RVA: 0x005D2FF8 File Offset: 0x005D11F8
		public IActorFxEmoteOverrideConfigT UnPack()
		{
			IActorFxEmoteOverrideConfigT actorFxEmoteOverrideConfigT = new IActorFxEmoteOverrideConfigT();
			this.UnPackTo(actorFxEmoteOverrideConfigT);
			return actorFxEmoteOverrideConfigT;
		}

		// Token: 0x0602A402 RID: 173058 RVA: 0x005D3014 File Offset: 0x005D1214
		public void UnPackTo(IActorFxEmoteOverrideConfigT _o)
		{
			_o.SocketName = this.SocketName;
			_o.RelativePosition = ((this.RelativePosition != null) ? this.RelativePosition.Value.UnPack() : null);
			_o.RelativeRotation = ((this.RelativeRotation != null) ? this.RelativeRotation.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
		}

		// Token: 0x0602A403 RID: 173059 RVA: 0x005D30BC File Offset: 0x005D12BC
		public static Offset<IActorFxEmoteOverrideConfig> Pack(FlatBufferBuilder builder, IActorFxEmoteOverrideConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteOverrideConfig>);
			}
			StringOffset socketNameOffset = (_o.SocketName == null) ? default(StringOffset) : builder.CreateString(_o.SocketName);
			Offset<IVectorInfo> relativePositionOffset = (_o.RelativePosition == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativePosition);
			Offset<IVectorInfo> relativeRotationOffset = (_o.RelativeRotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativeRotation);
			Offset<IVectorInfo> scaleOffset = (_o.Scale == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Scale);
			return IActorFxEmoteOverrideConfig.CreateIActorFxEmoteOverrideConfig(builder, socketNameOffset, relativePositionOffset, relativeRotationOffset, scaleOffset);
		}

		// Token: 0x04010449 RID: 66633
		private Table __p;
	}
}
