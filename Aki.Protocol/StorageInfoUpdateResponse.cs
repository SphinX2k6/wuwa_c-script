using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129C RID: 4764
	[NetMessage(EMessageId.StorageInfoUpdateResponse)]
	public sealed class StorageInfoUpdateResponse : IMessage<StorageInfoUpdateResponse>, IMessage, IEquatable<StorageInfoUpdateResponse>, IDeepCloneable<StorageInfoUpdateResponse>, IBufferMessage
	{
		// Token: 0x060195BE RID: 103870 RVA: 0x003AFC41 File Offset: 0x003ADE41
		[NullableContext(1)]
		public static StorageInfoUpdateResponse Create()
		{
			return new StorageInfoUpdateResponse();
		}

		// Token: 0x17005586 RID: 21894
		// (get) Token: 0x060195BF RID: 103871 RVA: 0x003AFC48 File Offset: 0x003ADE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005587 RID: 21895
		// (get) Token: 0x060195C0 RID: 103872 RVA: 0x003AFC4B File Offset: 0x003ADE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorageInfoUpdateResponse.Descriptor;
			}
		}

		// Token: 0x060195C1 RID: 103873 RVA: 0x003AFC52 File Offset: 0x003ADE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateResponse()
		{
		}

		// Token: 0x060195C2 RID: 103874 RVA: 0x003AFC5A File Offset: 0x003ADE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateResponse(StorageInfoUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195C3 RID: 103875 RVA: 0x003AFC7F File Offset: 0x003ADE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StorageInfoUpdateResponse Clone()
		{
			return new StorageInfoUpdateResponse(this);
		}

		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x060195C4 RID: 103876 RVA: 0x003AFC87 File Offset: 0x003ADE87
		// (set) Token: 0x060195C5 RID: 103877 RVA: 0x003AFC8F File Offset: 0x003ADE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060195C6 RID: 103878 RVA: 0x003AFC98 File Offset: 0x003ADE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorageInfoUpdateResponse);
		}

		// Token: 0x060195C7 RID: 103879 RVA: 0x003AFCA6 File Offset: 0x003ADEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StorageInfoUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195C8 RID: 103880 RVA: 0x003AFCD4 File Offset: 0x003ADED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060195C9 RID: 103881 RVA: 0x003AFD19 File Offset: 0x003ADF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195CA RID: 103882 RVA: 0x003AFD26 File Offset: 0x003ADF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195CB RID: 103883 RVA: 0x003AFD2F File Offset: 0x003ADF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195CC RID: 103884 RVA: 0x003AFD60 File Offset: 0x003ADF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060195CD RID: 103885 RVA: 0x003AFD9E File Offset: 0x003ADF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StorageInfoUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060195CE RID: 103886 RVA: 0x003AFDCF File Offset: 0x003ADFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195CF RID: 103887 RVA: 0x003AFDD8 File Offset: 0x003ADFD8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040094FB RID: 38139
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094FC RID: 38140
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040094FD RID: 38141
		private ErrorCode errorCode_;
	}
}
