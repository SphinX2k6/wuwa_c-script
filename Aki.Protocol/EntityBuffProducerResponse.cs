using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000478 RID: 1144
	[NetMessage(EMessageId.EntityBuffProducerResponse)]
	public sealed class EntityBuffProducerResponse : IMessage<EntityBuffProducerResponse>, IMessage, IEquatable<EntityBuffProducerResponse>, IDeepCloneable<EntityBuffProducerResponse>, IBufferMessage
	{
		// Token: 0x06006CFA RID: 27898 RVA: 0x00106F80 File Offset: 0x00105180
		[NullableContext(1)]
		public static EntityBuffProducerResponse Create()
		{
			return new EntityBuffProducerResponse();
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x00106F87 File Offset: 0x00105187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06006CFC RID: 27900 RVA: 0x00106F8A File Offset: 0x0010518A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerResponse.Descriptor;
			}
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x00106F91 File Offset: 0x00105191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerResponse()
		{
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x00106F99 File Offset: 0x00105199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerResponse(EntityBuffProducerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x00106FBE File Offset: 0x001051BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerResponse Clone()
		{
			return new EntityBuffProducerResponse(this);
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x00106FC6 File Offset: 0x001051C6
		// (set) Token: 0x06006D01 RID: 27905 RVA: 0x00106FCE File Offset: 0x001051CE
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

		// Token: 0x06006D02 RID: 27906 RVA: 0x00106FD7 File Offset: 0x001051D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerResponse);
		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x00106FE5 File Offset: 0x001051E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x00107014 File Offset: 0x00105214
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

		// Token: 0x06006D05 RID: 27909 RVA: 0x00107059 File Offset: 0x00105259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x00107066 File Offset: 0x00105266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x0010706F File Offset: 0x0010526F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x001070A4 File Offset: 0x001052A4
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

		// Token: 0x06006D09 RID: 27913 RVA: 0x001070E2 File Offset: 0x001052E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffProducerResponse other)
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

		// Token: 0x06006D0A RID: 27914 RVA: 0x00107113 File Offset: 0x00105313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x0010711C File Offset: 0x0010531C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003B16 RID: 15126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B17 RID: 15127
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04003B18 RID: 15128
		private ErrorCode errorCode_;
	}
}
