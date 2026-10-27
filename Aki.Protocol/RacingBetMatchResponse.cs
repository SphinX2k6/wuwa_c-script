using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E41 RID: 3649
	[NetMessage(EMessageId.RacingBetMatchResponse)]
	public sealed class RacingBetMatchResponse : IMessage<RacingBetMatchResponse>, IMessage, IEquatable<RacingBetMatchResponse>, IDeepCloneable<RacingBetMatchResponse>, IBufferMessage
	{
		// Token: 0x06013964 RID: 80228 RVA: 0x002D88F4 File Offset: 0x002D6AF4
		[NullableContext(1)]
		public static RacingBetMatchResponse Create()
		{
			return new RacingBetMatchResponse();
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x06013965 RID: 80229 RVA: 0x002D88FB File Offset: 0x002D6AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x06013966 RID: 80230 RVA: 0x002D88FE File Offset: 0x002D6AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchResponse.Descriptor;
			}
		}

		// Token: 0x06013967 RID: 80231 RVA: 0x002D8905 File Offset: 0x002D6B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchResponse()
		{
		}

		// Token: 0x06013968 RID: 80232 RVA: 0x002D8924 File Offset: 0x002D6B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchResponse(RacingBetMatchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this.rounds_ = other.rounds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013969 RID: 80233 RVA: 0x002D898E File Offset: 0x002D6B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchResponse Clone()
		{
			return new RacingBetMatchResponse(this);
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x0601396A RID: 80234 RVA: 0x002D8996 File Offset: 0x002D6B96
		// (set) Token: 0x0601396B RID: 80235 RVA: 0x002D899E File Offset: 0x002D6B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x0601396C RID: 80236 RVA: 0x002D89A7 File Offset: 0x002D6BA7
		// (set) Token: 0x0601396D RID: 80237 RVA: 0x002D89AF File Offset: 0x002D6BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x0601396E RID: 80238 RVA: 0x002D89B8 File Offset: 0x002D6BB8
		// (set) Token: 0x0601396F RID: 80239 RVA: 0x002D89C0 File Offset: 0x002D6BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x06013970 RID: 80240 RVA: 0x002D89C9 File Offset: 0x002D6BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x06013971 RID: 80241 RVA: 0x002D89D1 File Offset: 0x002D6BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsMatchRound> Rounds
		{
			get
			{
				return this.rounds_;
			}
		}

		// Token: 0x06013972 RID: 80242 RVA: 0x002D89D9 File Offset: 0x002D6BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchResponse);
		}

		// Token: 0x06013973 RID: 80243 RVA: 0x002D89E8 File Offset: 0x002D6BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.dangoInfo_.Equals(other.dangoInfo_) && this.rounds_.Equals(other.rounds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013974 RID: 80244 RVA: 0x002D8A6C File Offset: 0x002D6C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			num ^= this.dangoInfo_.GetHashCode();
			num ^= this.rounds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013975 RID: 80245 RVA: 0x002D8AFF File Offset: 0x002D6CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013976 RID: 80246 RVA: 0x002D8B0C File Offset: 0x002D6D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013977 RID: 80247 RVA: 0x002D8B18 File Offset: 0x002D6D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LegMatchId);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetMatchResponse._repeated_dangoInfo_codec);
			this.rounds_.WriteTo(ref output, RacingBetMatchResponse._repeated_rounds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013978 RID: 80248 RVA: 0x002D8BB0 File Offset: 0x002D6DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetMatchResponse._repeated_dangoInfo_codec);
			num += this.rounds_.CalculateSize(RacingBetMatchResponse._repeated_rounds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013979 RID: 80249 RVA: 0x002D8C44 File Offset: 0x002D6E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			this.rounds_.Add(other.rounds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601397A RID: 80250 RVA: 0x002D8CCA File Offset: 0x002D6ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601397B RID: 80251 RVA: 0x002D8CD4 File Offset: 0x002D6ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.dangoInfo_.AddEntriesFrom(ref input, RacingBetMatchResponse._repeated_dangoInfo_codec);
						continue;
					}
					if (num == 90U)
					{
						this.rounds_.AddEntriesFrom(ref input, RacingBetMatchResponse._repeated_rounds_codec);
						continue;
					}
					if (num == 96U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040077D9 RID: 30681
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077DA RID: 30682
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040077DB RID: 30683
		private ErrorCode errorCode_;

		// Token: 0x040077DC RID: 30684
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040077DD RID: 30685
		private int activityId_;

		// Token: 0x040077DE RID: 30686
		public const int LegMatchIdFieldNumber = 7;

		// Token: 0x040077DF RID: 30687
		private int legMatchId_;

		// Token: 0x040077E0 RID: 30688
		public const int DangoInfoFieldNumber = 9;

		// Token: 0x040077E1 RID: 30689
		private static readonly FieldCodec<RacingBetsInstanceDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoInfo>(74U, RacingBetsInstanceDangoInfo.Parser);

		// Token: 0x040077E2 RID: 30690
		private readonly RepeatedField<RacingBetsInstanceDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsInstanceDangoInfo>();

		// Token: 0x040077E3 RID: 30691
		public const int RoundsFieldNumber = 11;

		// Token: 0x040077E4 RID: 30692
		private static readonly FieldCodec<RacingBetsMatchRound> _repeated_rounds_codec = FieldCodec.ForMessage<RacingBetsMatchRound>(90U, RacingBetsMatchRound.Parser);

		// Token: 0x040077E5 RID: 30693
		private readonly RepeatedField<RacingBetsMatchRound> rounds_ = new RepeatedField<RacingBetsMatchRound>();
	}
}
