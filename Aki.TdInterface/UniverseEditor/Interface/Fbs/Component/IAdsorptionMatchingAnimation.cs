using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005376 RID: 21366
	public struct IAdsorptionMatchingAnimation : IFlatbufferObject
	{
		// Token: 0x170096DF RID: 38623
		// (get) Token: 0x0602147B RID: 136315 RVA: 0x004978EE File Offset: 0x00495AEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602147C RID: 136316 RVA: 0x004978FB File Offset: 0x00495AFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602147D RID: 136317 RVA: 0x00497904 File Offset: 0x00495B04
		public static IAdsorptionMatchingAnimation GetRootAsIAdsorptionMatchingAnimation(ByteBuffer _bb)
		{
			return IAdsorptionMatchingAnimation.GetRootAsIAdsorptionMatchingAnimation(_bb, default(IAdsorptionMatchingAnimation));
		}

		// Token: 0x0602147E RID: 136318 RVA: 0x00497920 File Offset: 0x00495B20
		public static IAdsorptionMatchingAnimation GetRootAsIAdsorptionMatchingAnimation(ByteBuffer _bb, IAdsorptionMatchingAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602147F RID: 136319 RVA: 0x0049793D File Offset: 0x00495B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021480 RID: 136320 RVA: 0x0049794C File Offset: 0x00495B4C
		public IAdsorptionMatchingAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096E0 RID: 38624
		// (get) Token: 0x06021481 RID: 136321 RVA: 0x0049795C File Offset: 0x00495B5C
		public IVectorInfo? MatchPos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170096E1 RID: 38625
		// (get) Token: 0x06021482 RID: 136322 RVA: 0x004979BC File Offset: 0x00495BBC
		public IVectorInfo? MatchRot
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

		// Token: 0x170096E2 RID: 38626
		// (get) Token: 0x06021483 RID: 136323 RVA: 0x00497A1C File Offset: 0x00495C1C
		public string MatchReferenceKey
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021484 RID: 136324 RVA: 0x00497A53 File Offset: 0x00495C53
		public Span<byte> GetMatchReferenceKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06021485 RID: 136325 RVA: 0x00497A62 File Offset: 0x00495C62
		public byte[] GetMatchReferenceKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170096E3 RID: 38627
		// (get) Token: 0x06021486 RID: 136326 RVA: 0x00497A70 File Offset: 0x00495C70
		public string MoveCurve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021487 RID: 136327 RVA: 0x00497AA8 File Offset: 0x00495CA8
		public Span<byte> GetMoveCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06021488 RID: 136328 RVA: 0x00497AB8 File Offset: 0x00495CB8
		public byte[] GetMoveCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06021489 RID: 136329 RVA: 0x00497AC7 File Offset: 0x00495CC7
		public static Offset<IAdsorptionMatchingAnimation> CreateIAdsorptionMatchingAnimation(FlatBufferBuilder builder, Offset<IVectorInfo> MatchPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> MatchRotOffset = default(Offset<IVectorInfo>), StringOffset MatchReferenceKeyOffset = default(StringOffset), StringOffset MoveCurveOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IAdsorptionMatchingAnimation.AddMoveCurve(builder, MoveCurveOffset);
			IAdsorptionMatchingAnimation.AddMatchReferenceKey(builder, MatchReferenceKeyOffset);
			IAdsorptionMatchingAnimation.AddMatchRot(builder, MatchRotOffset);
			IAdsorptionMatchingAnimation.AddMatchPos(builder, MatchPosOffset);
			return IAdsorptionMatchingAnimation.EndIAdsorptionMatchingAnimation(builder);
		}

		// Token: 0x0602148A RID: 136330 RVA: 0x00497AF3 File Offset: 0x00495CF3
		public static void StartIAdsorptionMatchingAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602148B RID: 136331 RVA: 0x00497AFC File Offset: 0x00495CFC
		public static void AddMatchPos(FlatBufferBuilder builder, Offset<IVectorInfo> matchPosOffset)
		{
			builder.AddOffset(0, matchPosOffset.Value, 0);
		}

		// Token: 0x0602148C RID: 136332 RVA: 0x00497B0C File Offset: 0x00495D0C
		public static void AddMatchRot(FlatBufferBuilder builder, Offset<IVectorInfo> matchRotOffset)
		{
			builder.AddOffset(1, matchRotOffset.Value, 0);
		}

		// Token: 0x0602148D RID: 136333 RVA: 0x00497B1C File Offset: 0x00495D1C
		public static void AddMatchReferenceKey(FlatBufferBuilder builder, StringOffset matchReferenceKeyOffset)
		{
			builder.AddOffset(2, matchReferenceKeyOffset.Value, 0);
		}

		// Token: 0x0602148E RID: 136334 RVA: 0x00497B2C File Offset: 0x00495D2C
		public static void AddMoveCurve(FlatBufferBuilder builder, StringOffset moveCurveOffset)
		{
			builder.AddOffset(3, moveCurveOffset.Value, 0);
		}

		// Token: 0x0602148F RID: 136335 RVA: 0x00497B3C File Offset: 0x00495D3C
		public static Offset<IAdsorptionMatchingAnimation> EndIAdsorptionMatchingAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IAdsorptionMatchingAnimation>(builder.EndTable());
		}

		// Token: 0x06021490 RID: 136336 RVA: 0x00497B4C File Offset: 0x00495D4C
		public IAdsorptionMatchingAnimationT UnPack()
		{
			IAdsorptionMatchingAnimationT adsorptionMatchingAnimationT = new IAdsorptionMatchingAnimationT();
			this.UnPackTo(adsorptionMatchingAnimationT);
			return adsorptionMatchingAnimationT;
		}

		// Token: 0x06021491 RID: 136337 RVA: 0x00497B68 File Offset: 0x00495D68
		public void UnPackTo(IAdsorptionMatchingAnimationT _o)
		{
			_o.MatchPos = ((this.MatchPos != null) ? this.MatchPos.Value.UnPack() : null);
			_o.MatchRot = ((this.MatchRot != null) ? this.MatchRot.Value.UnPack() : null);
			_o.MatchReferenceKey = this.MatchReferenceKey;
			_o.MoveCurve = this.MoveCurve;
		}

		// Token: 0x06021492 RID: 136338 RVA: 0x00497BEC File Offset: 0x00495DEC
		public static Offset<IAdsorptionMatchingAnimation> Pack(FlatBufferBuilder builder, IAdsorptionMatchingAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdsorptionMatchingAnimation>);
			}
			Offset<IVectorInfo> matchPosOffset = (_o.MatchPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchPos);
			Offset<IVectorInfo> matchRotOffset = (_o.MatchRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.MatchRot);
			StringOffset matchReferenceKeyOffset = (_o.MatchReferenceKey == null) ? default(StringOffset) : builder.CreateString(_o.MatchReferenceKey);
			StringOffset moveCurveOffset = (_o.MoveCurve == null) ? default(StringOffset) : builder.CreateString(_o.MoveCurve);
			return IAdsorptionMatchingAnimation.CreateIAdsorptionMatchingAnimation(builder, matchPosOffset, matchRotOffset, matchReferenceKeyOffset, moveCurveOffset);
		}

		// Token: 0x0400E786 RID: 59270
		private Table __p;
	}
}
