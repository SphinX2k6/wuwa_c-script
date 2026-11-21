using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000433 RID: 1075
	[NetMessage(EMessageId.EnrichmentAreaResponse)]
	public sealed class EnrichmentAreaResponse : IMessage<EnrichmentAreaResponse>, IMessage, IEquatable<EnrichmentAreaResponse>, IDeepCloneable<EnrichmentAreaResponse>, IBufferMessage
	{
		// Token: 0x06006767 RID: 26471 RVA: 0x000F8DF9 File Offset: 0x000F6FF9
		[NullableContext(1)]
		public static EnrichmentAreaResponse Create()
		{
			return new EnrichmentAreaResponse();
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x000F8E00 File Offset: 0x000F7000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06006769 RID: 26473 RVA: 0x000F8E03 File Offset: 0x000F7003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnrichmentAreaResponse.Descriptor;
			}
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x000F8E0A File Offset: 0x000F700A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaResponse()
		{
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x000F8E12 File Offset: 0x000F7012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaResponse(EnrichmentAreaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x000F8E37 File Offset: 0x000F7037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnrichmentAreaResponse Clone()
		{
			return new EnrichmentAreaResponse(this);
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x0600676D RID: 26477 RVA: 0x000F8E3F File Offset: 0x000F703F
		// (set) Token: 0x0600676E RID: 26478 RVA: 0x000F8E47 File Offset: 0x000F7047
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

		// Token: 0x0600676F RID: 26479 RVA: 0x000F8E50 File Offset: 0x000F7050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnrichmentAreaResponse);
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x000F8E5E File Offset: 0x000F705E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnrichmentAreaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x000F8E8C File Offset: 0x000F708C
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

		// Token: 0x06006772 RID: 26482 RVA: 0x000F8ED1 File Offset: 0x000F70D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x000F8EDE File Offset: 0x000F70DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x000F8EE7 File Offset: 0x000F70E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x000F8F1C File Offset: 0x000F711C
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

		// Token: 0x06006776 RID: 26486 RVA: 0x000F8F5A File Offset: 0x000F715A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnrichmentAreaResponse other)
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

		// Token: 0x06006777 RID: 26487 RVA: 0x000F8F8B File Offset: 0x000F718B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x000F8F94 File Offset: 0x000F7194
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040039C6 RID: 14790
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C7 RID: 14791
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040039C8 RID: 14792
		private ErrorCode errorCode_;
	}
}
