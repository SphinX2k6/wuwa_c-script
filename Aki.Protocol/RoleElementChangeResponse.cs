using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105B RID: 4187
	[NetMessage(EMessageId.RoleElementChangeResponse)]
	public sealed class RoleElementChangeResponse : IMessage<RoleElementChangeResponse>, IMessage, IEquatable<RoleElementChangeResponse>, IDeepCloneable<RoleElementChangeResponse>, IBufferMessage
	{
		// Token: 0x06016679 RID: 91769 RVA: 0x00342785 File Offset: 0x00340985
		[NullableContext(1)]
		public static RoleElementChangeResponse Create()
		{
			return new RoleElementChangeResponse();
		}

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x0601667A RID: 91770 RVA: 0x0034278C File Offset: 0x0034098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x0601667B RID: 91771 RVA: 0x0034278F File Offset: 0x0034098F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleElementChangeResponse.Descriptor;
			}
		}

		// Token: 0x0601667C RID: 91772 RVA: 0x00342796 File Offset: 0x00340996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeResponse()
		{
		}

		// Token: 0x0601667D RID: 91773 RVA: 0x0034279E File Offset: 0x0034099E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeResponse(RoleElementChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601667E RID: 91774 RVA: 0x003427C3 File Offset: 0x003409C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleElementChangeResponse Clone()
		{
			return new RoleElementChangeResponse(this);
		}

		// Token: 0x17004B09 RID: 19209
		// (get) Token: 0x0601667F RID: 91775 RVA: 0x003427CB File Offset: 0x003409CB
		// (set) Token: 0x06016680 RID: 91776 RVA: 0x003427D3 File Offset: 0x003409D3
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

		// Token: 0x06016681 RID: 91777 RVA: 0x003427DC File Offset: 0x003409DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleElementChangeResponse);
		}

		// Token: 0x06016682 RID: 91778 RVA: 0x003427EA File Offset: 0x003409EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleElementChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016683 RID: 91779 RVA: 0x00342818 File Offset: 0x00340A18
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

		// Token: 0x06016684 RID: 91780 RVA: 0x0034285D File Offset: 0x00340A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016685 RID: 91781 RVA: 0x0034286A File Offset: 0x00340A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016686 RID: 91782 RVA: 0x00342873 File Offset: 0x00340A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016687 RID: 91783 RVA: 0x003428A8 File Offset: 0x00340AA8
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

		// Token: 0x06016688 RID: 91784 RVA: 0x003428E6 File Offset: 0x00340AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleElementChangeResponse other)
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

		// Token: 0x06016689 RID: 91785 RVA: 0x00342917 File Offset: 0x00340B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601668A RID: 91786 RVA: 0x00342920 File Offset: 0x00340B20
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008684 RID: 34436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008685 RID: 34437
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04008686 RID: 34438
		private ErrorCode errorCode_;
	}
}
