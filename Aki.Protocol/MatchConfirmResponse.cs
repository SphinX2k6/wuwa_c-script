using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A8 RID: 2472
	[NetMessage(EMessageId.MatchConfirmResponse)]
	public sealed class MatchConfirmResponse : IMessage<MatchConfirmResponse>, IMessage, IEquatable<MatchConfirmResponse>, IDeepCloneable<MatchConfirmResponse>, IBufferMessage
	{
		// Token: 0x0600D943 RID: 55619 RVA: 0x001FECB5 File Offset: 0x001FCEB5
		[NullableContext(1)]
		public static MatchConfirmResponse Create()
		{
			return new MatchConfirmResponse();
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0600D944 RID: 55620 RVA: 0x001FECBC File Offset: 0x001FCEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0600D945 RID: 55621 RVA: 0x001FECBF File Offset: 0x001FCEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchConfirmResponse.Descriptor;
			}
		}

		// Token: 0x0600D946 RID: 55622 RVA: 0x001FECC6 File Offset: 0x001FCEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmResponse()
		{
		}

		// Token: 0x0600D947 RID: 55623 RVA: 0x001FECCE File Offset: 0x001FCECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmResponse(MatchConfirmResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D948 RID: 55624 RVA: 0x001FECF3 File Offset: 0x001FCEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmResponse Clone()
		{
			return new MatchConfirmResponse(this);
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x0600D949 RID: 55625 RVA: 0x001FECFB File Offset: 0x001FCEFB
		// (set) Token: 0x0600D94A RID: 55626 RVA: 0x001FED03 File Offset: 0x001FCF03
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

		// Token: 0x0600D94B RID: 55627 RVA: 0x001FED0C File Offset: 0x001FCF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchConfirmResponse);
		}

		// Token: 0x0600D94C RID: 55628 RVA: 0x001FED1A File Offset: 0x001FCF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchConfirmResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D94D RID: 55629 RVA: 0x001FED48 File Offset: 0x001FCF48
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

		// Token: 0x0600D94E RID: 55630 RVA: 0x001FED8D File Offset: 0x001FCF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D94F RID: 55631 RVA: 0x001FED9A File Offset: 0x001FCF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D950 RID: 55632 RVA: 0x001FEDA3 File Offset: 0x001FCFA3
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

		// Token: 0x0600D951 RID: 55633 RVA: 0x001FEDD8 File Offset: 0x001FCFD8
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

		// Token: 0x0600D952 RID: 55634 RVA: 0x001FEE16 File Offset: 0x001FD016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchConfirmResponse other)
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

		// Token: 0x0600D953 RID: 55635 RVA: 0x001FEE47 File Offset: 0x001FD047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D954 RID: 55636 RVA: 0x001FEE50 File Offset: 0x001FD050
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

		// Token: 0x04005AB8 RID: 23224
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB9 RID: 23225
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005ABA RID: 23226
		private ErrorCode errorCode_;
	}
}
