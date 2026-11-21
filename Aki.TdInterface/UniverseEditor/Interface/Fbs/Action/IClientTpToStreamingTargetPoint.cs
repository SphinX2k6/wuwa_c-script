using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A83 RID: 27267
	public struct IClientTpToStreamingTargetPoint : IFlatbufferObject
	{
		// Token: 0x1700C840 RID: 51264
		// (get) Token: 0x0602EC88 RID: 191624 RVA: 0x006602AC File Offset: 0x0065E4AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC89 RID: 191625 RVA: 0x006602B9 File Offset: 0x0065E4B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC8A RID: 191626 RVA: 0x006602C0 File Offset: 0x0065E4C0
		public static IClientTpToStreamingTargetPoint GetRootAsIClientTpToStreamingTargetPoint(ByteBuffer _bb)
		{
			return IClientTpToStreamingTargetPoint.GetRootAsIClientTpToStreamingTargetPoint(_bb, default(IClientTpToStreamingTargetPoint));
		}

		// Token: 0x0602EC8B RID: 191627 RVA: 0x006602DC File Offset: 0x0065E4DC
		public static IClientTpToStreamingTargetPoint GetRootAsIClientTpToStreamingTargetPoint(ByteBuffer _bb, IClientTpToStreamingTargetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC8C RID: 191628 RVA: 0x006602F9 File Offset: 0x0065E4F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC8D RID: 191629 RVA: 0x00660308 File Offset: 0x0065E508
		public IClientTpToStreamingTargetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C841 RID: 51265
		// (get) Token: 0x0602EC8E RID: 191630 RVA: 0x00660318 File Offset: 0x0065E518
		public EClientTeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientTeleportType.RelativeEntityPos;
				}
				return (EClientTeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C842 RID: 51266
		// (get) Token: 0x0602EC8F RID: 191631 RVA: 0x00660354 File Offset: 0x0065E554
		public IClientTpToStreamingTargetSuccessEffect? StreamingSuccessEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IClientTpToStreamingTargetSuccessEffect?(default(IClientTpToStreamingTargetSuccessEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C843 RID: 51267
		// (get) Token: 0x0602EC90 RID: 191632 RVA: 0x006603B4 File Offset: 0x0065E5B4
		public TTeleportTransitionOption StreamingTimeoutEffectType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EC91 RID: 191633 RVA: 0x006603F0 File Offset: 0x0065E5F0
		public TTable? StreamingTimeoutEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EC92 RID: 191634 RVA: 0x00660438 File Offset: 0x0065E638
		public ITeleportTransitionInDigitalScreen StreamingTimeoutEffectAsITeleportTransitionInDigitalScreen()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x0602EC93 RID: 191635 RVA: 0x00660454 File Offset: 0x0065E654
		public ITeleportTransitionInSeamlessType StreamingTimeoutEffectAsITeleportTransitionInSeamlessType()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x0602EC94 RID: 191636 RVA: 0x00660470 File Offset: 0x0065E670
		public ITeleportTransitionWithCenterText StreamingTimeoutEffectAsITeleportTransitionWithCenterText()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x0602EC95 RID: 191637 RVA: 0x0066048C File Offset: 0x0065E68C
		public ITeleportTransitionWithCharacterDisplay StreamingTimeoutEffectAsITeleportTransitionWithCharacterDisplay()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x0602EC96 RID: 191638 RVA: 0x006604A8 File Offset: 0x0065E6A8
		public ITeleportTransitionWithCustomLoading StreamingTimeoutEffectAsITeleportTransitionWithCustomLoading()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x0602EC97 RID: 191639 RVA: 0x006604C4 File Offset: 0x0065E6C4
		public ITeleportTransitionWithCustomScreen StreamingTimeoutEffectAsITeleportTransitionWithCustomScreen()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x0602EC98 RID: 191640 RVA: 0x006604E0 File Offset: 0x0065E6E0
		public ITeleportTransitionWithEffect StreamingTimeoutEffectAsITeleportTransitionWithEffect()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x0602EC99 RID: 191641 RVA: 0x006604FC File Offset: 0x0065E6FC
		public ITeleportTransitionWithFadeInScreen StreamingTimeoutEffectAsITeleportTransitionWithFadeInScreen()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x0602EC9A RID: 191642 RVA: 0x00660518 File Offset: 0x0065E718
		public ITeleportTransitionWithMp4 StreamingTimeoutEffectAsITeleportTransitionWithMp4()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x0602EC9B RID: 191643 RVA: 0x00660534 File Offset: 0x0065E734
		public ITeleportTransitionWithPlayFlow StreamingTimeoutEffectAsITeleportTransitionWithPlayFlow()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x0602EC9C RID: 191644 RVA: 0x00660550 File Offset: 0x0065E750
		public ITeleportTransitionWithSpecialCustomLoading StreamingTimeoutEffectAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700C844 RID: 51268
		// (get) Token: 0x0602EC9D RID: 191645 RVA: 0x0066056C File Offset: 0x0065E76C
		public IVectorInfo? LocationOffset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C845 RID: 51269
		// (get) Token: 0x0602EC9E RID: 191646 RVA: 0x006605CC File Offset: 0x0065E7CC
		public IVectorInfo? RotationOffset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602EC9F RID: 191647 RVA: 0x0066062A File Offset: 0x0065E82A
		public static Offset<IClientTpToStreamingTargetPoint> CreateIClientTpToStreamingTargetPoint(FlatBufferBuilder builder, EClientTeleportType Type = EClientTeleportType.RelativeEntityPos, Offset<IClientTpToStreamingTargetSuccessEffect> StreamingSuccessEffectOffset = default(Offset<IClientTpToStreamingTargetSuccessEffect>), TTeleportTransitionOption StreamingTimeoutEffect_type = TTeleportTransitionOption.NONE, int StreamingTimeoutEffectOffset = 0, Offset<IVectorInfo> LocationOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(6);
			IClientTpToStreamingTargetPoint.AddRotationOffset(builder, RotationOffsetOffset);
			IClientTpToStreamingTargetPoint.AddLocationOffset(builder, LocationOffsetOffset);
			IClientTpToStreamingTargetPoint.AddStreamingTimeoutEffect(builder, StreamingTimeoutEffectOffset);
			IClientTpToStreamingTargetPoint.AddStreamingSuccessEffect(builder, StreamingSuccessEffectOffset);
			IClientTpToStreamingTargetPoint.AddStreamingTimeoutEffectType(builder, StreamingTimeoutEffect_type);
			IClientTpToStreamingTargetPoint.AddType(builder, Type);
			return IClientTpToStreamingTargetPoint.EndIClientTpToStreamingTargetPoint(builder);
		}

		// Token: 0x0602ECA0 RID: 191648 RVA: 0x00660666 File Offset: 0x0065E866
		public static void StartIClientTpToStreamingTargetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602ECA1 RID: 191649 RVA: 0x0066066F File Offset: 0x0065E86F
		public static void AddType(FlatBufferBuilder builder, EClientTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ECA2 RID: 191650 RVA: 0x0066067A File Offset: 0x0065E87A
		public static void AddStreamingSuccessEffect(FlatBufferBuilder builder, Offset<IClientTpToStreamingTargetSuccessEffect> streamingSuccessEffectOffset)
		{
			builder.AddOffset(1, streamingSuccessEffectOffset.Value, 0);
		}

		// Token: 0x0602ECA3 RID: 191651 RVA: 0x0066068A File Offset: 0x0065E88A
		public static void AddStreamingTimeoutEffectType(FlatBufferBuilder builder, TTeleportTransitionOption streamingTimeoutEffectType)
		{
			builder.AddByte(2, (byte)streamingTimeoutEffectType, 0);
		}

		// Token: 0x0602ECA4 RID: 191652 RVA: 0x00660695 File Offset: 0x0065E895
		public static void AddStreamingTimeoutEffect(FlatBufferBuilder builder, int streamingTimeoutEffectOffset)
		{
			builder.AddOffset(3, streamingTimeoutEffectOffset, 0);
		}

		// Token: 0x0602ECA5 RID: 191653 RVA: 0x006606A0 File Offset: 0x0065E8A0
		public static void AddLocationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> locationOffsetOffset)
		{
			builder.AddOffset(4, locationOffsetOffset.Value, 0);
		}

		// Token: 0x0602ECA6 RID: 191654 RVA: 0x006606B0 File Offset: 0x0065E8B0
		public static void AddRotationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffsetOffset)
		{
			builder.AddOffset(5, rotationOffsetOffset.Value, 0);
		}

		// Token: 0x0602ECA7 RID: 191655 RVA: 0x006606C0 File Offset: 0x0065E8C0
		public static Offset<IClientTpToStreamingTargetPoint> EndIClientTpToStreamingTargetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IClientTpToStreamingTargetPoint>(builder.EndTable());
		}

		// Token: 0x0602ECA8 RID: 191656 RVA: 0x006606D0 File Offset: 0x0065E8D0
		public IClientTpToStreamingTargetPointT UnPack()
		{
			IClientTpToStreamingTargetPointT clientTpToStreamingTargetPointT = new IClientTpToStreamingTargetPointT();
			this.UnPackTo(clientTpToStreamingTargetPointT);
			return clientTpToStreamingTargetPointT;
		}

		// Token: 0x0602ECA9 RID: 191657 RVA: 0x006606EC File Offset: 0x0065E8EC
		public void UnPackTo(IClientTpToStreamingTargetPointT _o)
		{
			_o.Type = this.Type;
			_o.StreamingSuccessEffect = ((this.StreamingSuccessEffect != null) ? this.StreamingSuccessEffect.Value.UnPack() : null);
			_o.StreamingTimeoutEffect = new TTeleportTransitionOptionUnion();
			_o.StreamingTimeoutEffect.Type = this.StreamingTimeoutEffectType;
			switch (this.StreamingTimeoutEffectType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionInDigitalScreen>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionInSeamlessType>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithCenterText>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithCharacterDisplay>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithCustomLoading>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithCustomScreen>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithEffect>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithFadeInScreen>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithMp4>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithPlayFlow>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.StreamingTimeoutEffect.Value = ((this.StreamingTimeoutEffect<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.StreamingTimeoutEffect<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				break;
			}
			_o.LocationOffset = ((this.LocationOffset != null) ? this.LocationOffset.Value.UnPack() : null);
			_o.RotationOffset = ((this.RotationOffset != null) ? this.RotationOffset.Value.UnPack() : null);
		}

		// Token: 0x0602ECAA RID: 191658 RVA: 0x00660A7C File Offset: 0x0065EC7C
		public static Offset<IClientTpToStreamingTargetPoint> Pack(FlatBufferBuilder builder, IClientTpToStreamingTargetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTpToStreamingTargetPoint>);
			}
			Offset<IClientTpToStreamingTargetSuccessEffect> streamingSuccessEffectOffset = (_o.StreamingSuccessEffect == null) ? default(Offset<IClientTpToStreamingTargetSuccessEffect>) : IClientTpToStreamingTargetSuccessEffect.Pack(builder, _o.StreamingSuccessEffect);
			TTeleportTransitionOption streamingTimeoutEffect_type = (_o.StreamingTimeoutEffect == null) ? TTeleportTransitionOption.NONE : _o.StreamingTimeoutEffect.Type;
			int streamingTimeoutEffectOffset = (_o.StreamingTimeoutEffect == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.StreamingTimeoutEffect);
			Offset<IVectorInfo> locationOffsetOffset = (_o.LocationOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LocationOffset);
			Offset<IVectorInfo> rotationOffsetOffset = (_o.RotationOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RotationOffset);
			return IClientTpToStreamingTargetPoint.CreateIClientTpToStreamingTargetPoint(builder, _o.Type, streamingSuccessEffectOffset, streamingTimeoutEffect_type, streamingTimeoutEffectOffset, locationOffsetOffset, rotationOffsetOffset);
		}

		// Token: 0x04011816 RID: 71702
		private Table __p;
	}
}
