using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006403 RID: 25603
	public struct IClientTpToStreamingTargetPoint : IFlatbufferObject
	{
		// Token: 0x1700BEA6 RID: 48806
		// (get) Token: 0x0602C4B2 RID: 181426 RVA: 0x00614420 File Offset: 0x00612620
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C4B3 RID: 181427 RVA: 0x0061442D File Offset: 0x0061262D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C4B4 RID: 181428 RVA: 0x00614434 File Offset: 0x00612634
		public static IClientTpToStreamingTargetPoint GetRootAsIClientTpToStreamingTargetPoint(ByteBuffer _bb)
		{
			return IClientTpToStreamingTargetPoint.GetRootAsIClientTpToStreamingTargetPoint(_bb, default(IClientTpToStreamingTargetPoint));
		}

		// Token: 0x0602C4B5 RID: 181429 RVA: 0x00614450 File Offset: 0x00612650
		public static IClientTpToStreamingTargetPoint GetRootAsIClientTpToStreamingTargetPoint(ByteBuffer _bb, IClientTpToStreamingTargetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C4B6 RID: 181430 RVA: 0x0061446D File Offset: 0x0061266D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C4B7 RID: 181431 RVA: 0x0061447C File Offset: 0x0061267C
		public IClientTpToStreamingTargetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BEA7 RID: 48807
		// (get) Token: 0x0602C4B8 RID: 181432 RVA: 0x0061448C File Offset: 0x0061268C
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

		// Token: 0x1700BEA8 RID: 48808
		// (get) Token: 0x0602C4B9 RID: 181433 RVA: 0x006144C8 File Offset: 0x006126C8
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

		// Token: 0x1700BEA9 RID: 48809
		// (get) Token: 0x0602C4BA RID: 181434 RVA: 0x00614528 File Offset: 0x00612728
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

		// Token: 0x0602C4BB RID: 181435 RVA: 0x00614564 File Offset: 0x00612764
		public TTable? StreamingTimeoutEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C4BC RID: 181436 RVA: 0x006145AC File Offset: 0x006127AC
		public ITeleportTransitionInDigitalScreen StreamingTimeoutEffectAsITeleportTransitionInDigitalScreen()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x0602C4BD RID: 181437 RVA: 0x006145C8 File Offset: 0x006127C8
		public ITeleportTransitionInSeamlessType StreamingTimeoutEffectAsITeleportTransitionInSeamlessType()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x0602C4BE RID: 181438 RVA: 0x006145E4 File Offset: 0x006127E4
		public ITeleportTransitionWithCenterText StreamingTimeoutEffectAsITeleportTransitionWithCenterText()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x0602C4BF RID: 181439 RVA: 0x00614600 File Offset: 0x00612800
		public ITeleportTransitionWithCharacterDisplay StreamingTimeoutEffectAsITeleportTransitionWithCharacterDisplay()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x0602C4C0 RID: 181440 RVA: 0x0061461C File Offset: 0x0061281C
		public ITeleportTransitionWithCustomLoading StreamingTimeoutEffectAsITeleportTransitionWithCustomLoading()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x0602C4C1 RID: 181441 RVA: 0x00614638 File Offset: 0x00612838
		public ITeleportTransitionWithCustomScreen StreamingTimeoutEffectAsITeleportTransitionWithCustomScreen()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x0602C4C2 RID: 181442 RVA: 0x00614654 File Offset: 0x00612854
		public ITeleportTransitionWithEffect StreamingTimeoutEffectAsITeleportTransitionWithEffect()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x0602C4C3 RID: 181443 RVA: 0x00614670 File Offset: 0x00612870
		public ITeleportTransitionWithFadeInScreen StreamingTimeoutEffectAsITeleportTransitionWithFadeInScreen()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x0602C4C4 RID: 181444 RVA: 0x0061468C File Offset: 0x0061288C
		public ITeleportTransitionWithMp4 StreamingTimeoutEffectAsITeleportTransitionWithMp4()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x0602C4C5 RID: 181445 RVA: 0x006146A8 File Offset: 0x006128A8
		public ITeleportTransitionWithPlayFlow StreamingTimeoutEffectAsITeleportTransitionWithPlayFlow()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x0602C4C6 RID: 181446 RVA: 0x006146C4 File Offset: 0x006128C4
		public ITeleportTransitionWithSpecialCustomLoading StreamingTimeoutEffectAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.StreamingTimeoutEffect<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700BEAA RID: 48810
		// (get) Token: 0x0602C4C7 RID: 181447 RVA: 0x006146E0 File Offset: 0x006128E0
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

		// Token: 0x1700BEAB RID: 48811
		// (get) Token: 0x0602C4C8 RID: 181448 RVA: 0x00614740 File Offset: 0x00612940
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

		// Token: 0x0602C4C9 RID: 181449 RVA: 0x0061479E File Offset: 0x0061299E
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

		// Token: 0x0602C4CA RID: 181450 RVA: 0x006147DA File Offset: 0x006129DA
		public static void StartIClientTpToStreamingTargetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602C4CB RID: 181451 RVA: 0x006147E3 File Offset: 0x006129E3
		public static void AddType(FlatBufferBuilder builder, EClientTeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C4CC RID: 181452 RVA: 0x006147EE File Offset: 0x006129EE
		public static void AddStreamingSuccessEffect(FlatBufferBuilder builder, Offset<IClientTpToStreamingTargetSuccessEffect> streamingSuccessEffectOffset)
		{
			builder.AddOffset(1, streamingSuccessEffectOffset.Value, 0);
		}

		// Token: 0x0602C4CD RID: 181453 RVA: 0x006147FE File Offset: 0x006129FE
		public static void AddStreamingTimeoutEffectType(FlatBufferBuilder builder, TTeleportTransitionOption streamingTimeoutEffectType)
		{
			builder.AddByte(2, (byte)streamingTimeoutEffectType, 0);
		}

		// Token: 0x0602C4CE RID: 181454 RVA: 0x00614809 File Offset: 0x00612A09
		public static void AddStreamingTimeoutEffect(FlatBufferBuilder builder, int streamingTimeoutEffectOffset)
		{
			builder.AddOffset(3, streamingTimeoutEffectOffset, 0);
		}

		// Token: 0x0602C4CF RID: 181455 RVA: 0x00614814 File Offset: 0x00612A14
		public static void AddLocationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> locationOffsetOffset)
		{
			builder.AddOffset(4, locationOffsetOffset.Value, 0);
		}

		// Token: 0x0602C4D0 RID: 181456 RVA: 0x00614824 File Offset: 0x00612A24
		public static void AddRotationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffsetOffset)
		{
			builder.AddOffset(5, rotationOffsetOffset.Value, 0);
		}

		// Token: 0x0602C4D1 RID: 181457 RVA: 0x00614834 File Offset: 0x00612A34
		public static Offset<IClientTpToStreamingTargetPoint> EndIClientTpToStreamingTargetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IClientTpToStreamingTargetPoint>(builder.EndTable());
		}

		// Token: 0x0602C4D2 RID: 181458 RVA: 0x00614844 File Offset: 0x00612A44
		public IClientTpToStreamingTargetPointT UnPack()
		{
			IClientTpToStreamingTargetPointT clientTpToStreamingTargetPointT = new IClientTpToStreamingTargetPointT();
			this.UnPackTo(clientTpToStreamingTargetPointT);
			return clientTpToStreamingTargetPointT;
		}

		// Token: 0x0602C4D3 RID: 181459 RVA: 0x00614860 File Offset: 0x00612A60
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

		// Token: 0x0602C4D4 RID: 181460 RVA: 0x00614BF0 File Offset: 0x00612DF0
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

		// Token: 0x040109F0 RID: 68080
		private Table __p;
	}
}
