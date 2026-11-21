using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AB RID: 4267
	[NetMessage(EMessageId.RoleSkinChangeResponse)]
	public sealed class RoleSkinChangeResponse : IMessage<RoleSkinChangeResponse>, IMessage, IEquatable<RoleSkinChangeResponse>, IDeepCloneable<RoleSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x06016CEE RID: 93422 RVA: 0x00350D7B File Offset: 0x0034EF7B
		[NullableContext(1)]
		public static RoleSkinChangeResponse Create()
		{
			return new RoleSkinChangeResponse();
		}

		// Token: 0x17004C71 RID: 19569
		// (get) Token: 0x06016CEF RID: 93423 RVA: 0x00350D82 File Offset: 0x0034EF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C72 RID: 19570
		// (get) Token: 0x06016CF0 RID: 93424 RVA: 0x00350D85 File Offset: 0x0034EF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x06016CF1 RID: 93425 RVA: 0x00350D8C File Offset: 0x0034EF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeResponse()
		{
		}

		// Token: 0x06016CF2 RID: 93426 RVA: 0x00350D94 File Offset: 0x0034EF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeResponse(RoleSkinChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CF3 RID: 93427 RVA: 0x00350DB9 File Offset: 0x0034EFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeResponse Clone()
		{
			return new RoleSkinChangeResponse(this);
		}

		// Token: 0x17004C73 RID: 19571
		// (get) Token: 0x06016CF4 RID: 93428 RVA: 0x00350DC1 File Offset: 0x0034EFC1
		// (set) Token: 0x06016CF5 RID: 93429 RVA: 0x00350DC9 File Offset: 0x0034EFC9
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

		// Token: 0x06016CF6 RID: 93430 RVA: 0x00350DD2 File Offset: 0x0034EFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinChangeResponse);
		}

		// Token: 0x06016CF7 RID: 93431 RVA: 0x00350DE0 File Offset: 0x0034EFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CF8 RID: 93432 RVA: 0x00350E10 File Offset: 0x0034F010
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

		// Token: 0x06016CF9 RID: 93433 RVA: 0x00350E55 File Offset: 0x0034F055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CFA RID: 93434 RVA: 0x00350E62 File Offset: 0x0034F062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CFB RID: 93435 RVA: 0x00350E6B File Offset: 0x0034F06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CFC RID: 93436 RVA: 0x00350EA0 File Offset: 0x0034F0A0
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

		// Token: 0x06016CFD RID: 93437 RVA: 0x00350EDE File Offset: 0x0034F0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinChangeResponse other)
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

		// Token: 0x06016CFE RID: 93438 RVA: 0x00350F0F File Offset: 0x0034F10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CFF RID: 93439 RVA: 0x00350F18 File Offset: 0x0034F118
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400888D RID: 34957
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400888E RID: 34958
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400888F RID: 34959
		private ErrorCode errorCode_;
	}
}
