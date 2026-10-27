using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147A RID: 5242
	[NetMessage(EMessageId.TutorialUnlockResponse)]
	public sealed class TutorialUnlockResponse : IMessage<TutorialUnlockResponse>, IMessage, IEquatable<TutorialUnlockResponse>, IDeepCloneable<TutorialUnlockResponse>, IBufferMessage
	{
		// Token: 0x0601BBEB RID: 113643 RVA: 0x004039A9 File Offset: 0x00401BA9
		[NullableContext(1)]
		public static TutorialUnlockResponse Create()
		{
			return new TutorialUnlockResponse();
		}

		// Token: 0x17005D8C RID: 23948
		// (get) Token: 0x0601BBEC RID: 113644 RVA: 0x004039B0 File Offset: 0x00401BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D8D RID: 23949
		// (get) Token: 0x0601BBED RID: 113645 RVA: 0x004039B3 File Offset: 0x00401BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0601BBEE RID: 113646 RVA: 0x004039BA File Offset: 0x00401BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockResponse()
		{
		}

		// Token: 0x0601BBEF RID: 113647 RVA: 0x004039D0 File Offset: 0x00401BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockResponse(TutorialUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.unLockInfo_ = ((other.unLockInfo_ != null) ? other.unLockInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBF0 RID: 113648 RVA: 0x00403A2D File Offset: 0x00401C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockResponse Clone()
		{
			return new TutorialUnlockResponse(this);
		}

		// Token: 0x17005D8E RID: 23950
		// (get) Token: 0x0601BBF1 RID: 113649 RVA: 0x00403A35 File Offset: 0x00401C35
		// (set) Token: 0x0601BBF2 RID: 113650 RVA: 0x00403A3D File Offset: 0x00401C3D
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

		// Token: 0x17005D8F RID: 23951
		// (get) Token: 0x0601BBF3 RID: 113651 RVA: 0x00403A46 File Offset: 0x00401C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17005D90 RID: 23952
		// (get) Token: 0x0601BBF4 RID: 113652 RVA: 0x00403A4E File Offset: 0x00401C4E
		// (set) Token: 0x0601BBF5 RID: 113653 RVA: 0x00403A56 File Offset: 0x00401C56
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

		// Token: 0x0601BBF6 RID: 113654 RVA: 0x00403A5F File Offset: 0x00401C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialUnlockResponse);
		}

		// Token: 0x0601BBF7 RID: 113655 RVA: 0x00403A70 File Offset: 0x00401C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.UnLockInfo, other.UnLockInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBF8 RID: 113656 RVA: 0x00403AD4 File Offset: 0x00401CD4
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

		// Token: 0x0601BBF9 RID: 113657 RVA: 0x00403B3D File Offset: 0x00401D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBFA RID: 113658 RVA: 0x00403B4A File Offset: 0x00401D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBFB RID: 113659 RVA: 0x00403B54 File Offset: 0x00401D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.unLockInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.UnLockInfo);
			}
			this.errorParams_.WriteTo(ref output, TutorialUnlockResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BBFC RID: 113660 RVA: 0x00403BC0 File Offset: 0x00401DC0
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

		// Token: 0x0601BBFD RID: 113661 RVA: 0x00403C2C File Offset: 0x00401E2C
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

		// Token: 0x0601BBFE RID: 113662 RVA: 0x00403CA5 File Offset: 0x00401EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BBFF RID: 113663 RVA: 0x00403CB0 File Offset: 0x00401EB0
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
				if (num != 64U)
				{
					if (num != 90U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009FBF RID: 40895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FC0 RID: 40896
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04009FC1 RID: 40897
		private ErrorCode errorCode_;

		// Token: 0x04009FC2 RID: 40898
		public const int ErrorParamsFieldNumber = 13;

		// Token: 0x04009FC3 RID: 40899
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(106U);

		// Token: 0x04009FC4 RID: 40900
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04009FC5 RID: 40901
		public const int UnLockInfoFieldNumber = 11;

		// Token: 0x04009FC6 RID: 40902
		private TutorialInfo unLockInfo_;
	}
}
