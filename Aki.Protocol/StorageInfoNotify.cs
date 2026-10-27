using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001297 RID: 4759
	[NetMessage(EMessageId.StorageInfoNotify)]
	public sealed class StorageInfoNotify : IMessage<StorageInfoNotify>, IMessage, IEquatable<StorageInfoNotify>, IDeepCloneable<StorageInfoNotify>, IBufferMessage
	{
		// Token: 0x06019564 RID: 103780 RVA: 0x003AF201 File Offset: 0x003AD401
		[NullableContext(1)]
		public static StorageInfoNotify Create()
		{
			return new StorageInfoNotify();
		}

		// Token: 0x17005576 RID: 21878
		// (get) Token: 0x06019565 RID: 103781 RVA: 0x003AF208 File Offset: 0x003AD408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005577 RID: 21879
		// (get) Token: 0x06019566 RID: 103782 RVA: 0x003AF20B File Offset: 0x003AD40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoNotify.Descriptor;
			}
		}

		// Token: 0x06019567 RID: 103783 RVA: 0x003AF212 File Offset: 0x003AD412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoNotify()
		{
		}

		// Token: 0x06019568 RID: 103784 RVA: 0x003AF225 File Offset: 0x003AD425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoNotify(StorageInfoNotify other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019569 RID: 103785 RVA: 0x003AF24F File Offset: 0x003AD44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoNotify Clone()
		{
			return new StorageInfoNotify(this);
		}

		// Token: 0x17005578 RID: 21880
		// (get) Token: 0x0601956A RID: 103786 RVA: 0x003AF257 File Offset: 0x003AD457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x0601956B RID: 103787 RVA: 0x003AF25F File Offset: 0x003AD45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoNotify);
		}

		// Token: 0x0601956C RID: 103788 RVA: 0x003AF26D File Offset: 0x003AD46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601956D RID: 103789 RVA: 0x003AF2A0 File Offset: 0x003AD4A0
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

		// Token: 0x0601956E RID: 103790 RVA: 0x003AF2D4 File Offset: 0x003AD4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601956F RID: 103791 RVA: 0x003AF2E1 File Offset: 0x003AD4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019570 RID: 103792 RVA: 0x003AF2EA File Offset: 0x003AD4EA
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

		// Token: 0x06019571 RID: 103793 RVA: 0x003AF314 File Offset: 0x003AD514
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

		// Token: 0x06019572 RID: 103794 RVA: 0x003AF34D File Offset: 0x003AD54D
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

		// Token: 0x06019573 RID: 103795 RVA: 0x003AF37B File Offset: 0x003AD57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019574 RID: 103796 RVA: 0x003AF384 File Offset: 0x003AD584
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
					this.infos_.AddEntriesFrom(ref input, StorageInfoNotify._repeated_infos_codec);
				}
			}
		}

		// Token: 0x040094E4 RID: 38116
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094E5 RID: 38117
		public const int InfosFieldNumber = 2;

		// Token: 0x040094E6 RID: 38118
		private static readonly FieldCodec<ClientStorageInfo> _repeated_infos_codec = FieldCodec.ForMessage<ClientStorageInfo>(18U, ClientStorageInfo.Parser);

		// Token: 0x040094E7 RID: 38119
		private readonly RepeatedField<ClientStorageInfo> infos_ = new RepeatedField<ClientStorageInfo>();
	}
}
