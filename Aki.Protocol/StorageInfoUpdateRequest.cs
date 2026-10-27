using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129B RID: 4763
	[NetMessage(EMessageId.StorageInfoUpdateRequest)]
	public sealed class StorageInfoUpdateRequest : IMessage<StorageInfoUpdateRequest>, IMessage, IEquatable<StorageInfoUpdateRequest>, IDeepCloneable<StorageInfoUpdateRequest>, IBufferMessage
	{
		// Token: 0x060195AC RID: 103852 RVA: 0x003AFA5E File Offset: 0x003ADC5E
		[NullableContext(1)]
		public static StorageInfoUpdateRequest Create()
		{
			return new StorageInfoUpdateRequest();
		}

		// Token: 0x17005583 RID: 21891
		// (get) Token: 0x060195AD RID: 103853 RVA: 0x003AFA65 File Offset: 0x003ADC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005584 RID: 21892
		// (get) Token: 0x060195AE RID: 103854 RVA: 0x003AFA68 File Offset: 0x003ADC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoUpdateRequest.Descriptor;
			}
		}

		// Token: 0x060195AF RID: 103855 RVA: 0x003AFA6F File Offset: 0x003ADC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateRequest()
		{
		}

		// Token: 0x060195B0 RID: 103856 RVA: 0x003AFA82 File Offset: 0x003ADC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateRequest(StorageInfoUpdateRequest other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195B1 RID: 103857 RVA: 0x003AFAAC File Offset: 0x003ADCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateRequest Clone()
		{
			return new StorageInfoUpdateRequest(this);
		}

		// Token: 0x17005585 RID: 21893
		// (get) Token: 0x060195B2 RID: 103858 RVA: 0x003AFAB4 File Offset: 0x003ADCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ClientStorageInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x060195B3 RID: 103859 RVA: 0x003AFABC File Offset: 0x003ADCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoUpdateRequest);
		}

		// Token: 0x060195B4 RID: 103860 RVA: 0x003AFACA File Offset: 0x003ADCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoUpdateRequest other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195B5 RID: 103861 RVA: 0x003AFB00 File Offset: 0x003ADD00
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

		// Token: 0x060195B6 RID: 103862 RVA: 0x003AFB34 File Offset: 0x003ADD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195B7 RID: 103863 RVA: 0x003AFB41 File Offset: 0x003ADD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195B8 RID: 103864 RVA: 0x003AFB4A File Offset: 0x003ADD4A
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

		// Token: 0x060195B9 RID: 103865 RVA: 0x003AFB74 File Offset: 0x003ADD74
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

		// Token: 0x060195BA RID: 103866 RVA: 0x003AFBAD File Offset: 0x003ADDAD
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

		// Token: 0x060195BB RID: 103867 RVA: 0x003AFBDB File Offset: 0x003ADDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195BC RID: 103868 RVA: 0x003AFBE4 File Offset: 0x003ADDE4
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, StorageInfoUpdateRequest._repeated_infos_codec);
				}
			}
		}

		// Token: 0x040094F7 RID: 38135
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094F8 RID: 38136
		public const int InfosFieldNumber = 4;

		// Token: 0x040094F9 RID: 38137
		private static readonly FieldCodec<ClientStorageInfo> _repeated_infos_codec = FieldCodec.ForMessage<ClientStorageInfo>(34U, ClientStorageInfo.Parser);

		// Token: 0x040094FA RID: 38138
		private readonly RepeatedField<ClientStorageInfo> infos_ = new RepeatedField<ClientStorageInfo>();
	}
}
