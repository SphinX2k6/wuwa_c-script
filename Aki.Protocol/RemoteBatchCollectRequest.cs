using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDE RID: 3806
	[NetMessage(EMessageId.RemoteBatchCollectRequest)]
	public sealed class RemoteBatchCollectRequest : IMessage<RemoteBatchCollectRequest>, IMessage, IEquatable<RemoteBatchCollectRequest>, IDeepCloneable<RemoteBatchCollectRequest>, IBufferMessage
	{
		// Token: 0x060146CD RID: 83661 RVA: 0x002F8703 File Offset: 0x002F6903
		[NullableContext(1)]
		public static RemoteBatchCollectRequest Create()
		{
			return new RemoteBatchCollectRequest();
		}

		// Token: 0x170043F2 RID: 17394
		// (get) Token: 0x060146CE RID: 83662 RVA: 0x002F870A File Offset: 0x002F690A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043F3 RID: 17395
		// (get) Token: 0x060146CF RID: 83663 RVA: 0x002F870D File Offset: 0x002F690D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoteBatchCollectRequest.Descriptor;
			}
		}

		// Token: 0x060146D0 RID: 83664 RVA: 0x002F8714 File Offset: 0x002F6914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectRequest()
		{
		}

		// Token: 0x060146D1 RID: 83665 RVA: 0x002F8727 File Offset: 0x002F6927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectRequest(RemoteBatchCollectRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146D2 RID: 83666 RVA: 0x002F875D File Offset: 0x002F695D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectRequest Clone()
		{
			return new RemoteBatchCollectRequest(this);
		}

		// Token: 0x170043F4 RID: 17396
		// (get) Token: 0x060146D3 RID: 83667 RVA: 0x002F8765 File Offset: 0x002F6965
		// (set) Token: 0x060146D4 RID: 83668 RVA: 0x002F876D File Offset: 0x002F696D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x170043F5 RID: 17397
		// (get) Token: 0x060146D5 RID: 83669 RVA: 0x002F8776 File Offset: 0x002F6976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x060146D6 RID: 83670 RVA: 0x002F877E File Offset: 0x002F697E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoteBatchCollectRequest);
		}

		// Token: 0x060146D7 RID: 83671 RVA: 0x002F878C File Offset: 0x002F698C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoteBatchCollectRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146D8 RID: 83672 RVA: 0x002F87DC File Offset: 0x002F69DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060146D9 RID: 83673 RVA: 0x002F8829 File Offset: 0x002F6A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146DA RID: 83674 RVA: 0x002F8836 File Offset: 0x002F6A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146DB RID: 83675 RVA: 0x002F8840 File Offset: 0x002F6A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, RemoteBatchCollectRequest._repeated_entityIds_codec);
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146DC RID: 83676 RVA: 0x002F8890 File Offset: 0x002F6A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			num += this.entityIds_.CalculateSize(RemoteBatchCollectRequest._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060146DD RID: 83677 RVA: 0x002F88E4 File Offset: 0x002F6AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoteBatchCollectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060146DE RID: 83678 RVA: 0x002F8931 File Offset: 0x002F6B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146DF RID: 83679 RVA: 0x002F893C File Offset: 0x002F6B3C
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
				if (num != 40U && num != 42U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HostPlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, RemoteBatchCollectRequest._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04007C62 RID: 31842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C63 RID: 31843
		public const int HostPlayerIdFieldNumber = 11;

		// Token: 0x04007C64 RID: 31844
		private int hostPlayerId_;

		// Token: 0x04007C65 RID: 31845
		public const int EntityIdsFieldNumber = 5;

		// Token: 0x04007C66 RID: 31846
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(42U);

		// Token: 0x04007C67 RID: 31847
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
