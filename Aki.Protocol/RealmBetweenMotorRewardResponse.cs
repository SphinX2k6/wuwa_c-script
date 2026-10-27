using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA2 RID: 3746
	[NetMessage(EMessageId.RealmBetweenMotorRewardResponse)]
	public sealed class RealmBetweenMotorRewardResponse : IMessage<RealmBetweenMotorRewardResponse>, IMessage, IEquatable<RealmBetweenMotorRewardResponse>, IDeepCloneable<RealmBetweenMotorRewardResponse>, IBufferMessage
	{
		// Token: 0x060141BA RID: 82362 RVA: 0x002ED415 File Offset: 0x002EB615
		[NullableContext(1)]
		public static RealmBetweenMotorRewardResponse Create()
		{
			return new RealmBetweenMotorRewardResponse();
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x060141BB RID: 82363 RVA: 0x002ED41C File Offset: 0x002EB61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042E4 RID: 17124
		// (get) Token: 0x060141BC RID: 82364 RVA: 0x002ED41F File Offset: 0x002EB61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenMotorRewardResponse.Descriptor;
			}
		}

		// Token: 0x060141BD RID: 82365 RVA: 0x002ED426 File Offset: 0x002EB626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardResponse()
		{
		}

		// Token: 0x060141BE RID: 82366 RVA: 0x002ED439 File Offset: 0x002EB639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardResponse(RealmBetweenMotorRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141BF RID: 82367 RVA: 0x002ED46F File Offset: 0x002EB66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenMotorRewardResponse Clone()
		{
			return new RealmBetweenMotorRewardResponse(this);
		}

		// Token: 0x170042E5 RID: 17125
		// (get) Token: 0x060141C0 RID: 82368 RVA: 0x002ED477 File Offset: 0x002EB677
		// (set) Token: 0x060141C1 RID: 82369 RVA: 0x002ED47F File Offset: 0x002EB67F
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

		// Token: 0x170042E6 RID: 17126
		// (get) Token: 0x060141C2 RID: 82370 RVA: 0x002ED488 File Offset: 0x002EB688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060141C3 RID: 82371 RVA: 0x002ED490 File Offset: 0x002EB690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenMotorRewardResponse);
		}

		// Token: 0x060141C4 RID: 82372 RVA: 0x002ED4A0 File Offset: 0x002EB6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenMotorRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141C5 RID: 82373 RVA: 0x002ED4F0 File Offset: 0x002EB6F0
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

		// Token: 0x060141C6 RID: 82374 RVA: 0x002ED543 File Offset: 0x002EB743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141C7 RID: 82375 RVA: 0x002ED550 File Offset: 0x002EB750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141C8 RID: 82376 RVA: 0x002ED55C File Offset: 0x002EB75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskIds_.WriteTo(ref output, RealmBetweenMotorRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060141C9 RID: 82377 RVA: 0x002ED5AC File Offset: 0x002EB7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskIds_.CalculateSize(RealmBetweenMotorRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060141CA RID: 82378 RVA: 0x002ED600 File Offset: 0x002EB800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenMotorRewardResponse other)
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

		// Token: 0x060141CB RID: 82379 RVA: 0x002ED64D File Offset: 0x002EB84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141CC RID: 82380 RVA: 0x002ED658 File Offset: 0x002EB858
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
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, RealmBetweenMotorRewardResponse._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A8E RID: 31374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A8F RID: 31375
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007A90 RID: 31376
		private ErrorCode errorCode_;

		// Token: 0x04007A91 RID: 31377
		public const int TaskIdsFieldNumber = 4;

		// Token: 0x04007A92 RID: 31378
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007A93 RID: 31379
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
