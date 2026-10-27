using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000953 RID: 2387
	[NetMessage(EMessageId.LongShanScoreRewardResponse)]
	public sealed class LongShanScoreRewardResponse : IMessage<LongShanScoreRewardResponse>, IMessage, IEquatable<LongShanScoreRewardResponse>, IDeepCloneable<LongShanScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600D25F RID: 53855 RVA: 0x001F010C File Offset: 0x001EE30C
		[NullableContext(1)]
		public static LongShanScoreRewardResponse Create()
		{
			return new LongShanScoreRewardResponse();
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x0600D260 RID: 53856 RVA: 0x001F0113 File Offset: 0x001EE313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x0600D261 RID: 53857 RVA: 0x001F0116 File Offset: 0x001EE316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongShanScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600D262 RID: 53858 RVA: 0x001F011D File Offset: 0x001EE31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardResponse()
		{
		}

		// Token: 0x0600D263 RID: 53859 RVA: 0x001F0130 File Offset: 0x001EE330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardResponse(LongShanScoreRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this.scoreRewardedIds_ = other.scoreRewardedIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D264 RID: 53860 RVA: 0x001F0166 File Offset: 0x001EE366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongShanScoreRewardResponse Clone()
		{
			return new LongShanScoreRewardResponse(this);
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0600D265 RID: 53861 RVA: 0x001F016E File Offset: 0x001EE36E
		// (set) Token: 0x0600D266 RID: 53862 RVA: 0x001F0176 File Offset: 0x001EE376
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

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x0600D267 RID: 53863 RVA: 0x001F017F File Offset: 0x001EE37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardedIds
		{
			get
			{
				return this.scoreRewardedIds_;
			}
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x001F0187 File Offset: 0x001EE387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongShanScoreRewardResponse);
		}

		// Token: 0x0600D269 RID: 53865 RVA: 0x001F0198 File Offset: 0x001EE398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongShanScoreRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && this.scoreRewardedIds_.Equals(other.scoreRewardedIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D26A RID: 53866 RVA: 0x001F01E8 File Offset: 0x001EE3E8
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

		// Token: 0x0600D26B RID: 53867 RVA: 0x001F023B File Offset: 0x001EE43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D26C RID: 53868 RVA: 0x001F0248 File Offset: 0x001EE448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D26D RID: 53869 RVA: 0x001F0254 File Offset: 0x001EE454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreRewardedIds_.WriteTo(ref output, LongShanScoreRewardResponse._repeated_scoreRewardedIds_codec);
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D26E RID: 53870 RVA: 0x001F02A4 File Offset: 0x001EE4A4
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

		// Token: 0x0600D26F RID: 53871 RVA: 0x001F02F8 File Offset: 0x001EE4F8
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

		// Token: 0x0600D270 RID: 53872 RVA: 0x001F0345 File Offset: 0x001EE545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D271 RID: 53873 RVA: 0x001F0350 File Offset: 0x001EE550
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
				if (num != 88U && num != 90U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Error = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.scoreRewardedIds_.AddEntriesFrom(ref input, LongShanScoreRewardResponse._repeated_scoreRewardedIds_codec);
				}
			}
		}

		// Token: 0x04005881 RID: 22657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005882 RID: 22658
		public const int ErrorFieldNumber = 12;

		// Token: 0x04005883 RID: 22659
		private ErrorCode error_;

		// Token: 0x04005884 RID: 22660
		public const int ScoreRewardedIdsFieldNumber = 11;

		// Token: 0x04005885 RID: 22661
		private static readonly FieldCodec<int> _repeated_scoreRewardedIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04005886 RID: 22662
		private readonly RepeatedField<int> scoreRewardedIds_ = new RepeatedField<int>();
	}
}
