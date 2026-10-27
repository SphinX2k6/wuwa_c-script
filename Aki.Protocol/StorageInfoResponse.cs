using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001299 RID: 4761
	[NetMessage(EMessageId.StorageInfoResponse)]
	public sealed class StorageInfoResponse : IMessage<StorageInfoResponse>, IMessage, IEquatable<StorageInfoResponse>, IDeepCloneable<StorageInfoResponse>, IBufferMessage
	{
		// Token: 0x06019586 RID: 103814 RVA: 0x003AF51A File Offset: 0x003AD71A
		[NullableContext(1)]
		public static StorageInfoResponse Create()
		{
			return new StorageInfoResponse();
		}

		// Token: 0x1700557B RID: 21883
		// (get) Token: 0x06019587 RID: 103815 RVA: 0x003AF521 File Offset: 0x003AD721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700557C RID: 21884
		// (get) Token: 0x06019588 RID: 103816 RVA: 0x003AF524 File Offset: 0x003AD724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoResponse.Descriptor;
			}
		}

		// Token: 0x06019589 RID: 103817 RVA: 0x003AF52B File Offset: 0x003AD72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoResponse()
		{
		}

		// Token: 0x0601958A RID: 103818 RVA: 0x003AF53E File Offset: 0x003AD73E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoResponse(StorageInfoResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601958B RID: 103819 RVA: 0x003AF568 File Offset: 0x003AD768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoResponse Clone()
		{
			return new StorageInfoResponse(this);
		}

		// Token: 0x1700557D RID: 21885
		// (get) Token: 0x0601958C RID: 103820 RVA: 0x003AF570 File Offset: 0x003AD770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x0601958D RID: 103821 RVA: 0x003AF578 File Offset: 0x003AD778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoResponse);
		}

		// Token: 0x0601958E RID: 103822 RVA: 0x003AF586 File Offset: 0x003AD786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601958F RID: 103823 RVA: 0x003AF5BC File Offset: 0x003AD7BC
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

		// Token: 0x06019590 RID: 103824 RVA: 0x003AF5F0 File Offset: 0x003AD7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019591 RID: 103825 RVA: 0x003AF5FD File Offset: 0x003AD7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019592 RID: 103826 RVA: 0x003AF606 File Offset: 0x003AD806
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

		// Token: 0x06019593 RID: 103827 RVA: 0x003AF630 File Offset: 0x003AD830
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

		// Token: 0x06019594 RID: 103828 RVA: 0x003AF669 File Offset: 0x003AD869
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

		// Token: 0x06019595 RID: 103829 RVA: 0x003AF697 File Offset: 0x003AD897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019596 RID: 103830 RVA: 0x003AF6A0 File Offset: 0x003AD8A0
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, StorageInfoResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x040094E9 RID: 38121
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094EA RID: 38122
		public const int InfosFieldNumber = 6;

		// Token: 0x040094EB RID: 38123
		private static readonly FieldCodec<ClientStorageInfo> _repeated_infos_codec = FieldCodec.ForMessage<ClientStorageInfo>(50U, ClientStorageInfo.Parser);

		// Token: 0x040094EC RID: 38124
		private readonly RepeatedField<ClientStorageInfo> infos_ = new RepeatedField<ClientStorageInfo>();
	}
}
