using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001309 RID: 4873
	[NetMessage(EMessageId.StorageInfoUpdateNotify)]
	public sealed class StorageInfoUpdateNotify : IMessage<StorageInfoUpdateNotify>, IMessage, IEquatable<StorageInfoUpdateNotify>, IDeepCloneable<StorageInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019FCE RID: 106446 RVA: 0x003C9E29 File Offset: 0x003C8029
		[NullableContext(1)]
		public static StorageInfoUpdateNotify Create()
		{
			return new StorageInfoUpdateNotify();
		}

		// Token: 0x170057FF RID: 22527
		// (get) Token: 0x06019FCF RID: 106447 RVA: 0x003C9E30 File Offset: 0x003C8030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005800 RID: 22528
		// (get) Token: 0x06019FD0 RID: 106448 RVA: 0x003C9E33 File Offset: 0x003C8033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019FD1 RID: 106449 RVA: 0x003C9E3A File Offset: 0x003C803A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateNotify()
		{
		}

		// Token: 0x06019FD2 RID: 106450 RVA: 0x003C9E64 File Offset: 0x003C8064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateNotify(StorageInfoUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FD3 RID: 106451 RVA: 0x003C9EBB File Offset: 0x003C80BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateNotify Clone()
		{
			return new StorageInfoUpdateNotify(this);
		}

		// Token: 0x17005801 RID: 22529
		// (get) Token: 0x06019FD4 RID: 106452 RVA: 0x003C9EC3 File Offset: 0x003C80C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17005802 RID: 22530
		// (get) Token: 0x06019FD5 RID: 106453 RVA: 0x003C9ECB File Offset: 0x003C80CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x17005803 RID: 22531
		// (get) Token: 0x06019FD6 RID: 106454 RVA: 0x003C9ED3 File Offset: 0x003C80D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x06019FD7 RID: 106455 RVA: 0x003C9EDB File Offset: 0x003C80DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoUpdateNotify);
		}

		// Token: 0x06019FD8 RID: 106456 RVA: 0x003C9EEC File Offset: 0x003C80EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FD9 RID: 106457 RVA: 0x003C9F54 File Offset: 0x003C8154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adds_.GetHashCode();
			num ^= this.updates_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019FDA RID: 106458 RVA: 0x003C9FA4 File Offset: 0x003C81A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FDB RID: 106459 RVA: 0x003C9FB1 File Offset: 0x003C81B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FDC RID: 106460 RVA: 0x003C9FBC File Offset: 0x003C81BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.adds_.WriteTo(ref output, StorageInfoUpdateNotify._repeated_adds_codec);
			this.updates_.WriteTo(ref output, StorageInfoUpdateNotify._repeated_updates_codec);
			this.removes_.WriteTo(ref output, StorageInfoUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019FDD RID: 106461 RVA: 0x003CA010 File Offset: 0x003C8210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adds_.CalculateSize(StorageInfoUpdateNotify._repeated_adds_codec);
			num += this.updates_.CalculateSize(StorageInfoUpdateNotify._repeated_updates_codec);
			num += this.removes_.CalculateSize(StorageInfoUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FDE RID: 106462 RVA: 0x003CA070 File Offset: 0x003C8270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.adds_.Add(other.adds_);
			this.updates_.Add(other.updates_);
			this.removes_.Add(other.removes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FDF RID: 106463 RVA: 0x003CA0CB File Offset: 0x003C82CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FE0 RID: 106464 RVA: 0x003CA0D4 File Offset: 0x003C82D4
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
				if (num <= 66U)
				{
					if (num == 42U)
					{
						this.adds_.AddEntriesFrom(ref input, StorageInfoUpdateNotify._repeated_adds_codec);
						continue;
					}
					if (num == 66U)
					{
						this.updates_.AddEntriesFrom(ref input, StorageInfoUpdateNotify._repeated_updates_codec);
						continue;
					}
				}
				else if (num == 96U || num == 98U)
				{
					this.removes_.AddEntriesFrom(ref input, StorageInfoUpdateNotify._repeated_removes_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009917 RID: 39191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009918 RID: 39192
		public const int AddsFieldNumber = 5;

		// Token: 0x04009919 RID: 39193
		private static readonly FieldCodec<ClientStorageInfo> _repeated_adds_codec = FieldCodec.ForMessage<ClientStorageInfo>(42U, ClientStorageInfo.Parser);

		// Token: 0x0400991A RID: 39194
		private readonly RepeatedField<ClientStorageInfo> adds_ = new RepeatedField<ClientStorageInfo>();

		// Token: 0x0400991B RID: 39195
		public const int UpdatesFieldNumber = 8;

		// Token: 0x0400991C RID: 39196
		private static readonly FieldCodec<ClientStorageInfo> _repeated_updates_codec = FieldCodec.ForMessage<ClientStorageInfo>(66U, ClientStorageInfo.Parser);

		// Token: 0x0400991D RID: 39197
		private readonly RepeatedField<ClientStorageInfo> updates_ = new RepeatedField<ClientStorageInfo>();

		// Token: 0x0400991E RID: 39198
		public const int RemovesFieldNumber = 12;

		// Token: 0x0400991F RID: 39199
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009920 RID: 39200
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
