using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EEF RID: 3823
	[NetMessage(EMessageId.RemoteBatchCollectResponse)]
	public sealed class RemoteBatchCollectResponse : IMessage<RemoteBatchCollectResponse>, IMessage, IEquatable<RemoteBatchCollectResponse>, IDeepCloneable<RemoteBatchCollectResponse>, IBufferMessage
	{
		// Token: 0x060147C6 RID: 83910 RVA: 0x002FA064 File Offset: 0x002F8264
		[NullableContext(1)]
		public static RemoteBatchCollectResponse Create()
		{
			return new RemoteBatchCollectResponse();
		}

		// Token: 0x17004420 RID: 17440
		// (get) Token: 0x060147C7 RID: 83911 RVA: 0x002FA06B File Offset: 0x002F826B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004421 RID: 17441
		// (get) Token: 0x060147C8 RID: 83912 RVA: 0x002FA06E File Offset: 0x002F826E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoteBatchCollectResponse.Descriptor;
			}
		}

		// Token: 0x060147C9 RID: 83913 RVA: 0x002FA075 File Offset: 0x002F8275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectResponse()
		{
		}

		// Token: 0x060147CA RID: 83914 RVA: 0x002FA088 File Offset: 0x002F8288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectResponse(RemoteBatchCollectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060147CB RID: 83915 RVA: 0x002FA0BE File Offset: 0x002F82BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoteBatchCollectResponse Clone()
		{
			return new RemoteBatchCollectResponse(this);
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x060147CC RID: 83916 RVA: 0x002FA0C6 File Offset: 0x002F82C6
		// (set) Token: 0x060147CD RID: 83917 RVA: 0x002FA0CE File Offset: 0x002F82CE
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

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x060147CE RID: 83918 RVA: 0x002FA0D7 File Offset: 0x002F82D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x060147CF RID: 83919 RVA: 0x002FA0DF File Offset: 0x002F82DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoteBatchCollectResponse);
		}

		// Token: 0x060147D0 RID: 83920 RVA: 0x002FA0F0 File Offset: 0x002F82F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoteBatchCollectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060147D1 RID: 83921 RVA: 0x002FA140 File Offset: 0x002F8340
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

		// Token: 0x060147D2 RID: 83922 RVA: 0x002FA193 File Offset: 0x002F8393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060147D3 RID: 83923 RVA: 0x002FA1A0 File Offset: 0x002F83A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060147D4 RID: 83924 RVA: 0x002FA1AC File Offset: 0x002F83AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			this.entityIds_.WriteTo(ref output, RemoteBatchCollectResponse._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060147D5 RID: 83925 RVA: 0x002FA1FC File Offset: 0x002F83FC
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

		// Token: 0x060147D6 RID: 83926 RVA: 0x002FA250 File Offset: 0x002F8450
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

		// Token: 0x060147D7 RID: 83927 RVA: 0x002FA29D File Offset: 0x002F849D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060147D8 RID: 83928 RVA: 0x002FA2A8 File Offset: 0x002F84A8
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
				if (num != 8U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIds_.AddEntriesFrom(ref input, RemoteBatchCollectResponse._repeated_entityIds_codec);
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C3E RID: 31806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C3F RID: 31807
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04007C40 RID: 31808
		private ErrorCode errCode_;

		// Token: 0x04007C41 RID: 31809
		public const int EntityIdsFieldNumber = 12;

		// Token: 0x04007C42 RID: 31810
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(98U);

		// Token: 0x04007C43 RID: 31811
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
