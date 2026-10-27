using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129A RID: 4762
	[NetMessage(EMessageId.StorageInfoUpdateNotify)]
	public sealed class StorageInfoUpdateNotify : IMessage<StorageInfoUpdateNotify>, IMessage, IEquatable<StorageInfoUpdateNotify>, IDeepCloneable<StorageInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019598 RID: 103832 RVA: 0x003AF6FD File Offset: 0x003AD8FD
		[NullableContext(1)]
		public static StorageInfoUpdateNotify Create()
		{
			return new StorageInfoUpdateNotify();
		}

		// Token: 0x1700557E RID: 21886
		// (get) Token: 0x06019599 RID: 103833 RVA: 0x003AF704 File Offset: 0x003AD904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700557F RID: 21887
		// (get) Token: 0x0601959A RID: 103834 RVA: 0x003AF707 File Offset: 0x003AD907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601959B RID: 103835 RVA: 0x003AF70E File Offset: 0x003AD90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateNotify()
		{
		}

		// Token: 0x0601959C RID: 103836 RVA: 0x003AF738 File Offset: 0x003AD938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateNotify(StorageInfoUpdateNotify other) : this()
		{
			this.adds_ = other.adds_.Clone();
			this.updates_ = other.updates_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601959D RID: 103837 RVA: 0x003AF78F File Offset: 0x003AD98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateNotify Clone()
		{
			return new StorageInfoUpdateNotify(this);
		}

		// Token: 0x17005580 RID: 21888
		// (get) Token: 0x0601959E RID: 103838 RVA: 0x003AF797 File Offset: 0x003AD997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x17005581 RID: 21889
		// (get) Token: 0x0601959F RID: 103839 RVA: 0x003AF79F File Offset: 0x003AD99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x17005582 RID: 21890
		// (get) Token: 0x060195A0 RID: 103840 RVA: 0x003AF7A7 File Offset: 0x003AD9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x060195A1 RID: 103841 RVA: 0x003AF7AF File Offset: 0x003AD9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoUpdateNotify);
		}

		// Token: 0x060195A2 RID: 103842 RVA: 0x003AF7C0 File Offset: 0x003AD9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.adds_.Equals(other.adds_) && this.updates_.Equals(other.updates_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195A3 RID: 103843 RVA: 0x003AF828 File Offset: 0x003ADA28
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

		// Token: 0x060195A4 RID: 103844 RVA: 0x003AF878 File Offset: 0x003ADA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195A5 RID: 103845 RVA: 0x003AF885 File Offset: 0x003ADA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195A6 RID: 103846 RVA: 0x003AF890 File Offset: 0x003ADA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, StorageInfoUpdateNotify._repeated_updates_codec);
			this.adds_.WriteTo(ref output, StorageInfoUpdateNotify._repeated_adds_codec);
			this.removes_.WriteTo(ref output, StorageInfoUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195A7 RID: 103847 RVA: 0x003AF8E4 File Offset: 0x003ADAE4
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

		// Token: 0x060195A8 RID: 103848 RVA: 0x003AF944 File Offset: 0x003ADB44
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

		// Token: 0x060195A9 RID: 103849 RVA: 0x003AF99F File Offset: 0x003ADB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195AA RID: 103850 RVA: 0x003AF9A8 File Offset: 0x003ADBA8
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
				if (num <= 50U)
				{
					if (num == 10U)
					{
						this.updates_.AddEntriesFrom(ref input, StorageInfoUpdateNotify._repeated_updates_codec);
						continue;
					}
					if (num == 50U)
					{
						this.adds_.AddEntriesFrom(ref input, StorageInfoUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.removes_.AddEntriesFrom(ref input, StorageInfoUpdateNotify._repeated_removes_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040094ED RID: 38125
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094EE RID: 38126
		public const int AddsFieldNumber = 6;

		// Token: 0x040094EF RID: 38127
		private static readonly FieldCodec<ClientStorageInfo> _repeated_adds_codec = FieldCodec.ForMessage<ClientStorageInfo>(50U, ClientStorageInfo.Parser);

		// Token: 0x040094F0 RID: 38128
		private readonly RepeatedField<ClientStorageInfo> adds_ = new RepeatedField<ClientStorageInfo>();

		// Token: 0x040094F1 RID: 38129
		public const int UpdatesFieldNumber = 1;

		// Token: 0x040094F2 RID: 38130
		private static readonly FieldCodec<ClientStorageInfo> _repeated_updates_codec = FieldCodec.ForMessage<ClientStorageInfo>(10U, ClientStorageInfo.Parser);

		// Token: 0x040094F3 RID: 38131
		private readonly RepeatedField<ClientStorageInfo> updates_ = new RepeatedField<ClientStorageInfo>();

		// Token: 0x040094F4 RID: 38132
		public const int RemovesFieldNumber = 11;

		// Token: 0x040094F5 RID: 38133
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040094F6 RID: 38134
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
