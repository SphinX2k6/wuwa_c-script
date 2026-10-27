using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEE RID: 3822
	[NetMessage(EMessageId.RemoteBatchCollectRequest)]
	public sealed class RemoteBatchCollectRequest : IMessage<RemoteBatchCollectRequest>, IMessage, IEquatable<RemoteBatchCollectRequest>, IDeepCloneable<RemoteBatchCollectRequest>, IBufferMessage
	{
		// Token: 0x060147B2 RID: 83890 RVA: 0x002F9DBB File Offset: 0x002F7FBB
		[NullableContext(1)]
		public static RemoteBatchCollectRequest Create()
		{
			return new RemoteBatchCollectRequest();
		}

		// Token: 0x1700441C RID: 17436
		// (get) Token: 0x060147B3 RID: 83891 RVA: 0x002F9DC2 File Offset: 0x002F7FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700441D RID: 17437
		// (get) Token: 0x060147B4 RID: 83892 RVA: 0x002F9DC5 File Offset: 0x002F7FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoteBatchCollectRequest.Descriptor;
			}
		}

		// Token: 0x060147B5 RID: 83893 RVA: 0x002F9DCC File Offset: 0x002F7FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectRequest()
		{
		}

		// Token: 0x060147B6 RID: 83894 RVA: 0x002F9DDF File Offset: 0x002F7FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectRequest(RemoteBatchCollectRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060147B7 RID: 83895 RVA: 0x002F9E15 File Offset: 0x002F8015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectRequest Clone()
		{
			return new RemoteBatchCollectRequest(this);
		}

		// Token: 0x1700441E RID: 17438
		// (get) Token: 0x060147B8 RID: 83896 RVA: 0x002F9E1D File Offset: 0x002F801D
		// (set) Token: 0x060147B9 RID: 83897 RVA: 0x002F9E25 File Offset: 0x002F8025
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

		// Token: 0x1700441F RID: 17439
		// (get) Token: 0x060147BA RID: 83898 RVA: 0x002F9E2E File Offset: 0x002F802E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x060147BB RID: 83899 RVA: 0x002F9E36 File Offset: 0x002F8036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoteBatchCollectRequest);
		}

		// Token: 0x060147BC RID: 83900 RVA: 0x002F9E44 File Offset: 0x002F8044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoteBatchCollectRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147BD RID: 83901 RVA: 0x002F9E94 File Offset: 0x002F8094
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

		// Token: 0x060147BE RID: 83902 RVA: 0x002F9EE1 File Offset: 0x002F80E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147BF RID: 83903 RVA: 0x002F9EEE File Offset: 0x002F80EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147C0 RID: 83904 RVA: 0x002F9EF8 File Offset: 0x002F80F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, RemoteBatchCollectRequest._repeated_entityIds_codec);
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060147C1 RID: 83905 RVA: 0x002F9F48 File Offset: 0x002F8148
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

		// Token: 0x060147C2 RID: 83906 RVA: 0x002F9F9C File Offset: 0x002F819C
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

		// Token: 0x060147C3 RID: 83907 RVA: 0x002F9FE9 File Offset: 0x002F81E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147C4 RID: 83908 RVA: 0x002F9FF4 File Offset: 0x002F81F4
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
				if (num != 32U && num != 34U)
				{
					if (num != 72U)
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

		// Token: 0x04007C38 RID: 31800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C39 RID: 31801
		public const int HostPlayerIdFieldNumber = 9;

		// Token: 0x04007C3A RID: 31802
		private int hostPlayerId_;

		// Token: 0x04007C3B RID: 31803
		public const int EntityIdsFieldNumber = 4;

		// Token: 0x04007C3C RID: 31804
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(34U);

		// Token: 0x04007C3D RID: 31805
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
