using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E65 RID: 20069
	public struct IAdsorptionMatchingAnimation : IFlatbufferObject
	{
		// Token: 0x17008FA6 RID: 36774
		// (get) Token: 0x0601F830 RID: 129072 RVA: 0x004638D6 File Offset: 0x00461AD6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F831 RID: 129073 RVA: 0x004638E3 File Offset: 0x00461AE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F832 RID: 129074 RVA: 0x004638EC File Offset: 0x00461AEC
		public static IAdsorptionMatchingAnimation GetRootAsIAdsorptionMatchingAnimation(ByteBuffer _bb)
		{
			return IAdsorptionMatchingAnimation.GetRootAsIAdsorptionMatchingAnimation(_bb, default(IAdsorptionMatchingAnimation));
		}

		// Token: 0x0601F833 RID: 129075 RVA: 0x00463908 File Offset: 0x00461B08
		public static IAdsorptionMatchingAnimation GetRootAsIAdsorptionMatchingAnimation(ByteBuffer _bb, IAdsorptionMatchingAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F834 RID: 129076 RVA: 0x00463925 File Offset: 0x00461B25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F835 RID: 129077 RVA: 0x00463934 File Offset: 0x00461B34
		public IAdsorptionMatchingAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FA7 RID: 36775
		// (get) Token: 0x0601F836 RID: 129078 RVA: 0x00463944 File Offset: 0x00461B44
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

		// Token: 0x17008FA8 RID: 36776
		// (get) Token: 0x0601F837 RID: 129079 RVA: 0x004639A4 File Offset: 0x00461BA4
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

		// Token: 0x17008FA9 RID: 36777
		// (get) Token: 0x0601F838 RID: 129080 RVA: 0x00463A04 File Offset: 0x00461C04
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

		// Token: 0x0601F839 RID: 129081 RVA: 0x00463A3B File Offset: 0x00461C3B
		public Span<byte> GetMatchReferenceKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601F83A RID: 129082 RVA: 0x00463A4A File Offset: 0x00461C4A
		public byte[] GetMatchReferenceKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008FAA RID: 36778
		// (get) Token: 0x0601F83B RID: 129083 RVA: 0x00463A58 File Offset: 0x00461C58
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

		// Token: 0x0601F83C RID: 129084 RVA: 0x00463A90 File Offset: 0x00461C90
		public Span<byte> GetMoveCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601F83D RID: 129085 RVA: 0x00463AA0 File Offset: 0x00461CA0
		public byte[] GetMoveCurveArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601F83E RID: 129086 RVA: 0x00463AAF File Offset: 0x00461CAF
		public static Offset<IAdsorptionMatchingAnimation> CreateIAdsorptionMatchingAnimation(FlatBufferBuilder builder, Offset<IVectorInfo> MatchPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> MatchRotOffset = default(Offset<IVectorInfo>), StringOffset MatchReferenceKeyOffset = default(StringOffset), StringOffset MoveCurveOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IAdsorptionMatchingAnimation.AddMoveCurve(builder, MoveCurveOffset);
			IAdsorptionMatchingAnimation.AddMatchReferenceKey(builder, MatchReferenceKeyOffset);
			IAdsorptionMatchingAnimation.AddMatchRot(builder, MatchRotOffset);
			IAdsorptionMatchingAnimation.AddMatchPos(builder, MatchPosOffset);
			return IAdsorptionMatchingAnimation.EndIAdsorptionMatchingAnimation(builder);
		}

		// Token: 0x0601F83F RID: 129087 RVA: 0x00463ADB File Offset: 0x00461CDB
		public static void StartIAdsorptionMatchingAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F840 RID: 129088 RVA: 0x00463AE4 File Offset: 0x00461CE4
		public static void AddMatchPos(FlatBufferBuilder builder, Offset<IVectorInfo> matchPosOffset)
		{
			builder.AddOffset(0, matchPosOffset.Value, 0);
		}

		// Token: 0x0601F841 RID: 129089 RVA: 0x00463AF4 File Offset: 0x00461CF4
		public static void AddMatchRot(FlatBufferBuilder builder, Offset<IVectorInfo> matchRotOffset)
		{
			builder.AddOffset(1, matchRotOffset.Value, 0);
		}

		// Token: 0x0601F842 RID: 129090 RVA: 0x00463B04 File Offset: 0x00461D04
		public static void AddMatchReferenceKey(FlatBufferBuilder builder, StringOffset matchReferenceKeyOffset)
		{
			builder.AddOffset(2, matchReferenceKeyOffset.Value, 0);
		}

		// Token: 0x0601F843 RID: 129091 RVA: 0x00463B14 File Offset: 0x00461D14
		public static void AddMoveCurve(FlatBufferBuilder builder, StringOffset moveCurveOffset)
		{
			builder.AddOffset(3, moveCurveOffset.Value, 0);
		}

		// Token: 0x0601F844 RID: 129092 RVA: 0x00463B24 File Offset: 0x00461D24
		public static Offset<IAdsorptionMatchingAnimation> EndIAdsorptionMatchingAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IAdsorptionMatchingAnimation>(builder.EndTable());
		}

		// Token: 0x0601F845 RID: 129093 RVA: 0x00463B34 File Offset: 0x00461D34
		public IAdsorptionMatchingAnimationT UnPack()
		{
			IAdsorptionMatchingAnimationT adsorptionMatchingAnimationT = new IAdsorptionMatchingAnimationT();
			this.UnPackTo(adsorptionMatchingAnimationT);
			return adsorptionMatchingAnimationT;
		}

		// Token: 0x0601F846 RID: 129094 RVA: 0x00463B50 File Offset: 0x00461D50
		public void UnPackTo(IAdsorptionMatchingAnimationT _o)
		{
			_o.MatchPos = ((this.MatchPos != null) ? this.MatchPos.Value.UnPack() : null);
			_o.MatchRot = ((this.MatchRot != null) ? this.MatchRot.Value.UnPack() : null);
			_o.MatchReferenceKey = this.MatchReferenceKey;
			_o.MoveCurve = this.MoveCurve;
		}

		// Token: 0x0601F847 RID: 129095 RVA: 0x00463BD4 File Offset: 0x00461DD4
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

		// Token: 0x0400DC0C RID: 56332
		private Table __p;
	}
}
