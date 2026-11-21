using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDF RID: 3807
	[NetMessage(EMessageId.RemoteBatchCollectResponse)]
	public sealed class RemoteBatchCollectResponse : IMessage<RemoteBatchCollectResponse>, IMessage, IEquatable<RemoteBatchCollectResponse>, IDeepCloneable<RemoteBatchCollectResponse>, IBufferMessage
	{
		// Token: 0x060146E1 RID: 83681 RVA: 0x002F89AC File Offset: 0x002F6BAC
		[NullableContext(1)]
		public static RemoteBatchCollectResponse Create()
		{
			return new RemoteBatchCollectResponse();
		}

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x060146E2 RID: 83682 RVA: 0x002F89B3 File Offset: 0x002F6BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x060146E3 RID: 83683 RVA: 0x002F89B6 File Offset: 0x002F6BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoteBatchCollectResponse.Descriptor;
			}
		}

		// Token: 0x060146E4 RID: 83684 RVA: 0x002F89BD File Offset: 0x002F6BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectResponse()
		{
		}

		// Token: 0x060146E5 RID: 83685 RVA: 0x002F89D0 File Offset: 0x002F6BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectResponse(RemoteBatchCollectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146E6 RID: 83686 RVA: 0x002F8A06 File Offset: 0x002F6C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectResponse Clone()
		{
			return new RemoteBatchCollectResponse(this);
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x060146E7 RID: 83687 RVA: 0x002F8A0E File Offset: 0x002F6C0E
		// (set) Token: 0x060146E8 RID: 83688 RVA: 0x002F8A16 File Offset: 0x002F6C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x060146E9 RID: 83689 RVA: 0x002F8A1F File Offset: 0x002F6C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x060146EA RID: 83690 RVA: 0x002F8A27 File Offset: 0x002F6C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoteBatchCollectResponse);
		}

		// Token: 0x060146EB RID: 83691 RVA: 0x002F8A38 File Offset: 0x002F6C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoteBatchCollectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146EC RID: 83692 RVA: 0x002F8A88 File Offset: 0x002F6C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060146ED RID: 83693 RVA: 0x002F8ADB File Offset: 0x002F6CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146EE RID: 83694 RVA: 0x002F8AE8 File Offset: 0x002F6CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146EF RID: 83695 RVA: 0x002F8AF4 File Offset: 0x002F6CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, RemoteBatchCollectResponse._repeated_entityIds_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146F0 RID: 83696 RVA: 0x002F8B44 File Offset: 0x002F6D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.entityIds_.CalculateSize(RemoteBatchCollectResponse._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060146F1 RID: 83697 RVA: 0x002F8B98 File Offset: 0x002F6D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoteBatchCollectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060146F2 RID: 83698 RVA: 0x002F8BE5 File Offset: 0x002F6DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146F3 RID: 83699 RVA: 0x002F8BF0 File Offset: 0x002F6DF0
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
				if (num != 16U && num != 18U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, RemoteBatchCollectResponse._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04007C68 RID: 31848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C69 RID: 31849
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04007C6A RID: 31850
		private ErrorCode errCode_;

		// Token: 0x04007C6B RID: 31851
		public const int EntityIdsFieldNumber = 2;

		// Token: 0x04007C6C RID: 31852
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04007C6D RID: 31853
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
