using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000942 RID: 2370
	[NetMessage(EMessageId.LongShanScoreRewardResponse)]
	public sealed class LongShanScoreRewardResponse : IMessage<LongShanScoreRewardResponse>, IMessage, IEquatable<LongShanScoreRewardResponse>, IDeepCloneable<LongShanScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D145 RID: 53573 RVA: 0x001EDF24 File Offset: 0x001EC124
		[NullableContext(1)]
		public static LongShanScoreRewardResponse Create()
		{
			return new LongShanScoreRewardResponse();
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0600D146 RID: 53574 RVA: 0x001EDF2B File Offset: 0x001EC12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x0600D147 RID: 53575 RVA: 0x001EDF2E File Offset: 0x001EC12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D148 RID: 53576 RVA: 0x001EDF35 File Offset: 0x001EC135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardResponse()
		{
		}

		// Token: 0x0600D149 RID: 53577 RVA: 0x001EDF48 File Offset: 0x001EC148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardResponse(LongShanScoreRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this.scoreRewardedIds_ = other.scoreRewardedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D14A RID: 53578 RVA: 0x001EDF7E File Offset: 0x001EC17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardResponse Clone()
		{
			return new LongShanScoreRewardResponse(this);
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0600D14B RID: 53579 RVA: 0x001EDF86 File Offset: 0x001EC186
		// (set) Token: 0x0600D14C RID: 53580 RVA: 0x001EDF8E File Offset: 0x001EC18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0600D14D RID: 53581 RVA: 0x001EDF97 File Offset: 0x001EC197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardedIds
		{
			get
			{
				return this.scoreRewardedIds_;
			}
		}

		// Token: 0x0600D14E RID: 53582 RVA: 0x001EDF9F File Offset: 0x001EC19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanScoreRewardResponse);
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x001EDFB0 File Offset: 0x001EC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanScoreRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && this.scoreRewardedIds_.Equals(other.scoreRewardedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x001EE000 File Offset: 0x001EC200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			num ^= this.scoreRewardedIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D151 RID: 53585 RVA: 0x001EE053 File Offset: 0x001EC253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D152 RID: 53586 RVA: 0x001EE060 File Offset: 0x001EC260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D153 RID: 53587 RVA: 0x001EE06C File Offset: 0x001EC26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Error);
			}
			this.scoreRewardedIds_.WriteTo(ref output, LongShanScoreRewardResponse._repeated_scoreRewardedIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D154 RID: 53588 RVA: 0x001EE0BC File Offset: 0x001EC2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			num += this.scoreRewardedIds_.CalculateSize(LongShanScoreRewardResponse._repeated_scoreRewardedIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D155 RID: 53589 RVA: 0x001EE110 File Offset: 0x001EC310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongShanScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this.scoreRewardedIds_.Add(other.scoreRewardedIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D156 RID: 53590 RVA: 0x001EE15D File Offset: 0x001EC35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x001EE168 File Offset: 0x001EC368
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
				if (num != 16U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scoreRewardedIds_.AddEntriesFrom(ref input, LongShanScoreRewardResponse._repeated_scoreRewardedIds_codec);
					}
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400588A RID: 22666
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400588B RID: 22667
		public const int ErrorFieldNumber = 2;

		// Token: 0x0400588C RID: 22668
		private ErrorCode error_;

		// Token: 0x0400588D RID: 22669
		public const int ScoreRewardedIdsFieldNumber = 9;

		// Token: 0x0400588E RID: 22670
		private static readonly FieldCodec<int> _repeated_scoreRewardedIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400588F RID: 22671
		private readonly RepeatedField<int> scoreRewardedIds_ = new RepeatedField<int>();
	}
}
