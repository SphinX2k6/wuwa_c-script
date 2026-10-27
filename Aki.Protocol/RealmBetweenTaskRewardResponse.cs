using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA4 RID: 3748
	[NetMessage(EMessageId.RealmBetweenTaskRewardResponse)]
	public sealed class RealmBetweenTaskRewardResponse : IMessage<RealmBetweenTaskRewardResponse>, IMessage, IEquatable<RealmBetweenTaskRewardResponse>, IDeepCloneable<RealmBetweenTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060141E0 RID: 82400 RVA: 0x002ED8A9 File Offset: 0x002EBAA9
		[NullableContext(1)]
		public static RealmBetweenTaskRewardResponse Create()
		{
			return new RealmBetweenTaskRewardResponse();
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x060141E1 RID: 82401 RVA: 0x002ED8B0 File Offset: 0x002EBAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042EB RID: 17131
		// (get) Token: 0x060141E2 RID: 82402 RVA: 0x002ED8B3 File Offset: 0x002EBAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060141E3 RID: 82403 RVA: 0x002ED8BA File Offset: 0x002EBABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardResponse()
		{
		}

		// Token: 0x060141E4 RID: 82404 RVA: 0x002ED8CD File Offset: 0x002EBACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardResponse(RealmBetweenTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141E5 RID: 82405 RVA: 0x002ED903 File Offset: 0x002EBB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenTaskRewardResponse Clone()
		{
			return new RealmBetweenTaskRewardResponse(this);
		}

		// Token: 0x170042EC RID: 17132
		// (get) Token: 0x060141E6 RID: 82406 RVA: 0x002ED90B File Offset: 0x002EBB0B
		// (set) Token: 0x060141E7 RID: 82407 RVA: 0x002ED913 File Offset: 0x002EBB13
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

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x060141E8 RID: 82408 RVA: 0x002ED91C File Offset: 0x002EBB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060141E9 RID: 82409 RVA: 0x002ED924 File Offset: 0x002EBB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenTaskRewardResponse);
		}

		// Token: 0x060141EA RID: 82410 RVA: 0x002ED934 File Offset: 0x002EBB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141EB RID: 82411 RVA: 0x002ED984 File Offset: 0x002EBB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060141EC RID: 82412 RVA: 0x002ED9D7 File Offset: 0x002EBBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141ED RID: 82413 RVA: 0x002ED9E4 File Offset: 0x002EBBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141EE RID: 82414 RVA: 0x002ED9F0 File Offset: 0x002EBBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RealmBetweenTaskRewardResponse._repeated_taskIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060141EF RID: 82415 RVA: 0x002EDA40 File Offset: 0x002EBC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskIds_.CalculateSize(RealmBetweenTaskRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060141F0 RID: 82416 RVA: 0x002EDA94 File Offset: 0x002EBC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060141F1 RID: 82417 RVA: 0x002EDAE1 File Offset: 0x002EBCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141F2 RID: 82418 RVA: 0x002EDAEC File Offset: 0x002EBCEC
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
				if (num != 24U && num != 26U)
				{
					if (num != 48U)
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
					this.taskIds_.AddEntriesFrom(ref input, RealmBetweenTaskRewardResponse._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007A98 RID: 31384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A99 RID: 31385
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04007A9A RID: 31386
		private ErrorCode errorCode_;

		// Token: 0x04007A9B RID: 31387
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x04007A9C RID: 31388
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007A9D RID: 31389
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
