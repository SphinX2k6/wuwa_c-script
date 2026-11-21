using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001306 RID: 4870
	[NetMessage(EMessageId.StorageInfoNotify)]
	public sealed class StorageInfoNotify : IMessage<StorageInfoNotify>, IMessage, IEquatable<StorageInfoNotify>, IDeepCloneable<StorageInfoNotify>, IBufferMessage
	{
		// Token: 0x06019F9A RID: 106394 RVA: 0x003C992D File Offset: 0x003C7B2D
		[NullableContext(1)]
		public static StorageInfoNotify Create()
		{
			return new StorageInfoNotify();
		}

		// Token: 0x170057F7 RID: 22519
		// (get) Token: 0x06019F9B RID: 106395 RVA: 0x003C9934 File Offset: 0x003C7B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057F8 RID: 22520
		// (get) Token: 0x06019F9C RID: 106396 RVA: 0x003C9937 File Offset: 0x003C7B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoNotify.Descriptor;
			}
		}

		// Token: 0x06019F9D RID: 106397 RVA: 0x003C993E File Offset: 0x003C7B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoNotify()
		{
		}

		// Token: 0x06019F9E RID: 106398 RVA: 0x003C9951 File Offset: 0x003C7B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoNotify(StorageInfoNotify other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F9F RID: 106399 RVA: 0x003C997B File Offset: 0x003C7B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoNotify Clone()
		{
			return new StorageInfoNotify(this);
		}

		// Token: 0x170057F9 RID: 22521
		// (get) Token: 0x06019FA0 RID: 106400 RVA: 0x003C9983 File Offset: 0x003C7B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x06019FA1 RID: 106401 RVA: 0x003C998B File Offset: 0x003C7B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoNotify);
		}

		// Token: 0x06019FA2 RID: 106402 RVA: 0x003C9999 File Offset: 0x003C7B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FA3 RID: 106403 RVA: 0x003C99CC File Offset: 0x003C7BCC
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

		// Token: 0x06019FA4 RID: 106404 RVA: 0x003C9A00 File Offset: 0x003C7C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FA5 RID: 106405 RVA: 0x003C9A0D File Offset: 0x003C7C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FA6 RID: 106406 RVA: 0x003C9A16 File Offset: 0x003C7C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, StorageInfoNotify._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FA7 RID: 106407 RVA: 0x003C9A40 File Offset: 0x003C7C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(StorageInfoNotify._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FA8 RID: 106408 RVA: 0x003C9A79 File Offset: 0x003C7C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FA9 RID: 106409 RVA: 0x003C9AA7 File Offset: 0x003C7CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FAA RID: 106410 RVA: 0x003C9AB0 File Offset: 0x003C7CB0
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, StorageInfoNotify._repeated_infos_codec);
				}
			}
		}

		// Token: 0x0400990E RID: 39182
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400990F RID: 39183
		public const int InfosFieldNumber = 9;

		// Token: 0x04009910 RID: 39184
		private static readonly FieldCodec<ClientStorageInfo> _repeated_infos_codec = FieldCodec.ForMessage<ClientStorageInfo>(74U, ClientStorageInfo.Parser);

		// Token: 0x04009911 RID: 39185
		private readonly RepeatedField<ClientStorageInfo> infos_ = new RepeatedField<ClientStorageInfo>();
	}
}
