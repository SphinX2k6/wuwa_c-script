using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001308 RID: 4872
	[NetMessage(EMessageId.StorageInfoResponse)]
	public sealed class StorageInfoResponse : IMessage<StorageInfoResponse>, IMessage, IEquatable<StorageInfoResponse>, IDeepCloneable<StorageInfoResponse>, IBufferMessage
	{
		// Token: 0x06019FBC RID: 106428 RVA: 0x003C9C46 File Offset: 0x003C7E46
		[NullableContext(1)]
		public static StorageInfoResponse Create()
		{
			return new StorageInfoResponse();
		}

		// Token: 0x170057FC RID: 22524
		// (get) Token: 0x06019FBD RID: 106429 RVA: 0x003C9C4D File Offset: 0x003C7E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057FD RID: 22525
		// (get) Token: 0x06019FBE RID: 106430 RVA: 0x003C9C50 File Offset: 0x003C7E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoResponse.Descriptor;
			}
		}

		// Token: 0x06019FBF RID: 106431 RVA: 0x003C9C57 File Offset: 0x003C7E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoResponse()
		{
		}

		// Token: 0x06019FC0 RID: 106432 RVA: 0x003C9C6A File Offset: 0x003C7E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoResponse(StorageInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FC1 RID: 106433 RVA: 0x003C9C94 File Offset: 0x003C7E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoResponse Clone()
		{
			return new StorageInfoResponse(this);
		}

		// Token: 0x170057FE RID: 22526
		// (get) Token: 0x06019FC2 RID: 106434 RVA: 0x003C9C9C File Offset: 0x003C7E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x06019FC3 RID: 106435 RVA: 0x003C9CA4 File Offset: 0x003C7EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoResponse);
		}

		// Token: 0x06019FC4 RID: 106436 RVA: 0x003C9CB2 File Offset: 0x003C7EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FC5 RID: 106437 RVA: 0x003C9CE8 File Offset: 0x003C7EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019FC6 RID: 106438 RVA: 0x003C9D1C File Offset: 0x003C7F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FC7 RID: 106439 RVA: 0x003C9D29 File Offset: 0x003C7F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FC8 RID: 106440 RVA: 0x003C9D32 File Offset: 0x003C7F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, StorageInfoResponse._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FC9 RID: 106441 RVA: 0x003C9D5C File Offset: 0x003C7F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(StorageInfoResponse._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FCA RID: 106442 RVA: 0x003C9D95 File Offset: 0x003C7F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FCB RID: 106443 RVA: 0x003C9DC3 File Offset: 0x003C7FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FCC RID: 106444 RVA: 0x003C9DCC File Offset: 0x003C7FCC
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, StorageInfoResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04009913 RID: 39187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009914 RID: 39188
		public const int InfosFieldNumber = 5;

		// Token: 0x04009915 RID: 39189
		private static readonly FieldCodec<ClientStorageInfo> _repeated_infos_codec = FieldCodec.ForMessage<ClientStorageInfo>(42U, ClientStorageInfo.Parser);

		// Token: 0x04009916 RID: 39190
		private readonly RepeatedField<ClientStorageInfo> infos_ = new RepeatedField<ClientStorageInfo>();
	}
}
