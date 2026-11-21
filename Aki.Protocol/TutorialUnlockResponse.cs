using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014ED RID: 5357
	[NetMessage(EMessageId.TutorialUnlockResponse)]
	public sealed class TutorialUnlockResponse : IMessage<TutorialUnlockResponse>, IMessage, IEquatable<TutorialUnlockResponse>, IDeepCloneable<TutorialUnlockResponse>, IBufferMessage
	{
		// Token: 0x0601C676 RID: 116342 RVA: 0x0041EC70 File Offset: 0x0041CE70
		[NullableContext(1)]
		public static TutorialUnlockResponse Create()
		{
			return new TutorialUnlockResponse();
		}

		// Token: 0x17006021 RID: 24609
		// (get) Token: 0x0601C677 RID: 116343 RVA: 0x0041EC77 File Offset: 0x0041CE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006022 RID: 24610
		// (get) Token: 0x0601C678 RID: 116344 RVA: 0x0041EC7A File Offset: 0x0041CE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0601C679 RID: 116345 RVA: 0x0041EC81 File Offset: 0x0041CE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockResponse()
		{
		}

		// Token: 0x0601C67A RID: 116346 RVA: 0x0041EC94 File Offset: 0x0041CE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockResponse(TutorialUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.unLockInfo_ = ((other.unLockInfo_ != null) ? other.unLockInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C67B RID: 116347 RVA: 0x0041ECF1 File Offset: 0x0041CEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockResponse Clone()
		{
			return new TutorialUnlockResponse(this);
		}

		// Token: 0x17006023 RID: 24611
		// (get) Token: 0x0601C67C RID: 116348 RVA: 0x0041ECF9 File Offset: 0x0041CEF9
		// (set) Token: 0x0601C67D RID: 116349 RVA: 0x0041ED01 File Offset: 0x0041CF01
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

		// Token: 0x17006024 RID: 24612
		// (get) Token: 0x0601C67E RID: 116350 RVA: 0x0041ED0A File Offset: 0x0041CF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17006025 RID: 24613
		// (get) Token: 0x0601C67F RID: 116351 RVA: 0x0041ED12 File Offset: 0x0041CF12
		// (set) Token: 0x0601C680 RID: 116352 RVA: 0x0041ED1A File Offset: 0x0041CF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfo UnLockInfo
		{
			get
			{
				return this.unLockInfo_;
			}
			set
			{
				this.unLockInfo_ = value;
			}
		}

		// Token: 0x0601C681 RID: 116353 RVA: 0x0041ED23 File Offset: 0x0041CF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialUnlockResponse);
		}

		// Token: 0x0601C682 RID: 116354 RVA: 0x0041ED34 File Offset: 0x0041CF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.UnLockInfo, other.UnLockInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C683 RID: 116355 RVA: 0x0041ED98 File Offset: 0x0041CF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this.unLockInfo_ != null)
			{
				num ^= this.UnLockInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C684 RID: 116356 RVA: 0x0041EE01 File Offset: 0x0041D001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C685 RID: 116357 RVA: 0x0041EE0E File Offset: 0x0041D00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C686 RID: 116358 RVA: 0x0041EE18 File Offset: 0x0041D018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unLockInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.UnLockInfo);
			}
			this.errorParams_.WriteTo(ref output, TutorialUnlockResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C687 RID: 116359 RVA: 0x0041EE84 File Offset: 0x0041D084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(TutorialUnlockResponse._repeated_errorParams_codec);
			if (this.unLockInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnLockInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C688 RID: 116360 RVA: 0x0041EEF0 File Offset: 0x0041D0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			if (other.unLockInfo_ != null)
			{
				if (this.unLockInfo_ == null)
				{
					this.UnLockInfo = new TutorialInfo();
				}
				this.UnLockInfo.MergeFrom(other.UnLockInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C689 RID: 116361 RVA: 0x0041EF69 File Offset: 0x0041D169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C68A RID: 116362 RVA: 0x0041EF74 File Offset: 0x0041D174
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
				if (num != 98U)
				{
					if (num != 114U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, TutorialUnlockResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					if (this.unLockInfo_ == null)
					{
						this.UnLockInfo = new TutorialInfo();
					}
					input.ReadMessage(this.UnLockInfo);
				}
			}
		}

		// Token: 0x0400A406 RID: 41990
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A407 RID: 41991
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A408 RID: 41992
		private ErrorCode errorCode_;

		// Token: 0x0400A409 RID: 41993
		public const int ErrorParamsFieldNumber = 14;

		// Token: 0x0400A40A RID: 41994
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(114U);

		// Token: 0x0400A40B RID: 41995
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x0400A40C RID: 41996
		public const int UnLockInfoFieldNumber = 12;

		// Token: 0x0400A40D RID: 41997
		private TutorialInfo unLockInfo_;
	}
}
