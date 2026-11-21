using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200130A RID: 4874
	[NetMessage(EMessageId.StorageInfoUpdateRequest)]
	public sealed class StorageInfoUpdateRequest : IMessage<StorageInfoUpdateRequest>, IMessage, IEquatable<StorageInfoUpdateRequest>, IDeepCloneable<StorageInfoUpdateRequest>, IBufferMessage
	{
		// Token: 0x06019FE2 RID: 106466 RVA: 0x003CA18A File Offset: 0x003C838A
		[NullableContext(1)]
		public static StorageInfoUpdateRequest Create()
		{
			return new StorageInfoUpdateRequest();
		}

		// Token: 0x17005804 RID: 22532
		// (get) Token: 0x06019FE3 RID: 106467 RVA: 0x003CA191 File Offset: 0x003C8391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005805 RID: 22533
		// (get) Token: 0x06019FE4 RID: 106468 RVA: 0x003CA194 File Offset: 0x003C8394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06019FE5 RID: 106469 RVA: 0x003CA19B File Offset: 0x003C839B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateRequest()
		{
		}

		// Token: 0x06019FE6 RID: 106470 RVA: 0x003CA1AE File Offset: 0x003C83AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateRequest(StorageInfoUpdateRequest other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FE7 RID: 106471 RVA: 0x003CA1D8 File Offset: 0x003C83D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateRequest Clone()
		{
			return new StorageInfoUpdateRequest(this);
		}

		// Token: 0x17005806 RID: 22534
		// (get) Token: 0x06019FE8 RID: 106472 RVA: 0x003CA1E0 File Offset: 0x003C83E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x06019FE9 RID: 106473 RVA: 0x003CA1E8 File Offset: 0x003C83E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoUpdateRequest);
		}

		// Token: 0x06019FEA RID: 106474 RVA: 0x003CA1F6 File Offset: 0x003C83F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoUpdateRequest other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FEB RID: 106475 RVA: 0x003CA22C File Offset: 0x003C842C
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

		// Token: 0x06019FEC RID: 106476 RVA: 0x003CA260 File Offset: 0x003C8460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FED RID: 106477 RVA: 0x003CA26D File Offset: 0x003C846D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FEE RID: 106478 RVA: 0x003CA276 File Offset: 0x003C8476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, StorageInfoUpdateRequest._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FEF RID: 106479 RVA: 0x003CA2A0 File Offset: 0x003C84A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(StorageInfoUpdateRequest._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FF0 RID: 106480 RVA: 0x003CA2D9 File Offset: 0x003C84D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FF1 RID: 106481 RVA: 0x003CA307 File Offset: 0x003C8507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FF2 RID: 106482 RVA: 0x003CA310 File Offset: 0x003C8510
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, StorageInfoUpdateRequest._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04009921 RID: 39201
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009922 RID: 39202
		public const int InfosFieldNumber = 2;

		// Token: 0x04009923 RID: 39203
		private static readonly FieldCodec<ClientStorageInfo> _repeated_infos_codec = FieldCodec.ForMessage<ClientStorageInfo>(18U, ClientStorageInfo.Parser);

		// Token: 0x04009924 RID: 39204
		private readonly RepeatedField<ClientStorageInfo> infos_ = new RepeatedField<ClientStorageInfo>();
	}
}
