using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670F RID: 26383
	public struct IActorFxEmoteOverrideConfig : IFlatbufferObject
	{
		// Token: 0x1700BFC5 RID: 49093
		// (get) Token: 0x0602CACF RID: 182991 RVA: 0x0061CD40 File Offset: 0x0061AF40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CAD0 RID: 182992 RVA: 0x0061CD4D File Offset: 0x0061AF4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CAD1 RID: 182993 RVA: 0x0061CD54 File Offset: 0x0061AF54
		public static IActorFxEmoteOverrideConfig GetRootAsIActorFxEmoteOverrideConfig(ByteBuffer _bb)
		{
			return IActorFxEmoteOverrideConfig.GetRootAsIActorFxEmoteOverrideConfig(_bb, default(IActorFxEmoteOverrideConfig));
		}

		// Token: 0x0602CAD2 RID: 182994 RVA: 0x0061CD70 File Offset: 0x0061AF70
		public static IActorFxEmoteOverrideConfig GetRootAsIActorFxEmoteOverrideConfig(ByteBuffer _bb, IActorFxEmoteOverrideConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CAD3 RID: 182995 RVA: 0x0061CD8D File Offset: 0x0061AF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CAD4 RID: 182996 RVA: 0x0061CD9C File Offset: 0x0061AF9C
		public IActorFxEmoteOverrideConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFC6 RID: 49094
		// (get) Token: 0x0602CAD5 RID: 182997 RVA: 0x0061CDAC File Offset: 0x0061AFAC
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

		// Token: 0x0602CAD6 RID: 182998 RVA: 0x0061CDE3 File Offset: 0x0061AFE3
		public Span<byte> GetSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602CAD7 RID: 182999 RVA: 0x0061CDF2 File Offset: 0x0061AFF2
		public byte[] GetSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BFC7 RID: 49095
		// (get) Token: 0x0602CAD8 RID: 183000 RVA: 0x0061CE00 File Offset: 0x0061B000
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

		// Token: 0x1700BFC8 RID: 49096
		// (get) Token: 0x0602CAD9 RID: 183001 RVA: 0x0061CE60 File Offset: 0x0061B060
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

		// Token: 0x1700BFC9 RID: 49097
		// (get) Token: 0x0602CADA RID: 183002 RVA: 0x0061CEC0 File Offset: 0x0061B0C0
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

		// Token: 0x0602CADB RID: 183003 RVA: 0x0061CF1E File Offset: 0x0061B11E
		public static Offset<IActorFxEmoteOverrideConfig> CreateIActorFxEmoteOverrideConfig(FlatBufferBuilder builder, StringOffset SocketNameOffset = default(StringOffset), Offset<IVectorInfo> RelativePositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RelativeRotationOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ScaleOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IActorFxEmoteOverrideConfig.AddScale(builder, ScaleOffset);
			IActorFxEmoteOverrideConfig.AddRelativeRotation(builder, RelativeRotationOffset);
			IActorFxEmoteOverrideConfig.AddRelativePosition(builder, RelativePositionOffset);
			IActorFxEmoteOverrideConfig.AddSocketName(builder, SocketNameOffset);
			return IActorFxEmoteOverrideConfig.EndIActorFxEmoteOverrideConfig(builder);
		}

		// Token: 0x0602CADC RID: 183004 RVA: 0x0061CF4A File Offset: 0x0061B14A
		public static void StartIActorFxEmoteOverrideConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CADD RID: 183005 RVA: 0x0061CF53 File Offset: 0x0061B153
		public static void AddSocketName(FlatBufferBuilder builder, StringOffset socketNameOffset)
		{
			builder.AddOffset(0, socketNameOffset.Value, 0);
		}

		// Token: 0x0602CADE RID: 183006 RVA: 0x0061CF63 File Offset: 0x0061B163
		public static void AddRelativePosition(FlatBufferBuilder builder, Offset<IVectorInfo> relativePositionOffset)
		{
			builder.AddOffset(1, relativePositionOffset.Value, 0);
		}

		// Token: 0x0602CADF RID: 183007 RVA: 0x0061CF73 File Offset: 0x0061B173
		public static void AddRelativeRotation(FlatBufferBuilder builder, Offset<IVectorInfo> relativeRotationOffset)
		{
			builder.AddOffset(2, relativeRotationOffset.Value, 0);
		}

		// Token: 0x0602CAE0 RID: 183008 RVA: 0x0061CF83 File Offset: 0x0061B183
		public static void AddScale(FlatBufferBuilder builder, Offset<IVectorInfo> scaleOffset)
		{
			builder.AddOffset(3, scaleOffset.Value, 0);
		}

		// Token: 0x0602CAE1 RID: 183009 RVA: 0x0061CF93 File Offset: 0x0061B193
		public static Offset<IActorFxEmoteOverrideConfig> EndIActorFxEmoteOverrideConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteOverrideConfig>(builder.EndTable());
		}

		// Token: 0x0602CAE2 RID: 183010 RVA: 0x0061CFA0 File Offset: 0x0061B1A0
		public IActorFxEmoteOverrideConfigT UnPack()
		{
			IActorFxEmoteOverrideConfigT actorFxEmoteOverrideConfigT = new IActorFxEmoteOverrideConfigT();
			this.UnPackTo(actorFxEmoteOverrideConfigT);
			return actorFxEmoteOverrideConfigT;
		}

		// Token: 0x0602CAE3 RID: 183011 RVA: 0x0061CFBC File Offset: 0x0061B1BC
		public void UnPackTo(IActorFxEmoteOverrideConfigT _o)
		{
			_o.SocketName = this.SocketName;
			_o.RelativePosition = ((this.RelativePosition != null) ? this.RelativePosition.Value.UnPack() : null);
			_o.RelativeRotation = ((this.RelativeRotation != null) ? this.RelativeRotation.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
		}

		// Token: 0x0602CAE4 RID: 183012 RVA: 0x0061D064 File Offset: 0x0061B264
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

		// Token: 0x0401124D RID: 70221
		private Table __p;
	}
}
