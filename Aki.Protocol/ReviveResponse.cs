using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F30 RID: 3888
	[NetMessage(EMessageId.ReviveResponse)]
	public sealed class ReviveResponse : IMessage<ReviveResponse>, IMessage, IEquatable<ReviveResponse>, IDeepCloneable<ReviveResponse>, IBufferMessage
	{
		// Token: 0x06014CE4 RID: 85220 RVA: 0x00304CB4 File Offset: 0x00302EB4
		[NullableContext(1)]
		public static ReviveResponse Create()
		{
			return new ReviveResponse();
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x06014CE5 RID: 85221 RVA: 0x00304CBB File Offset: 0x00302EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x06014CE6 RID: 85222 RVA: 0x00304CBE File Offset: 0x00302EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReviveResponse.Descriptor;
			}
		}

		// Token: 0x06014CE7 RID: 85223 RVA: 0x00304CC5 File Offset: 0x00302EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveResponse()
		{
		}

		// Token: 0x06014CE8 RID: 85224 RVA: 0x00304CCD File Offset: 0x00302ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveResponse(ReviveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014CE9 RID: 85225 RVA: 0x00304CF2 File Offset: 0x00302EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReviveResponse Clone()
		{
			return new ReviveResponse(this);
		}

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x06014CEA RID: 85226 RVA: 0x00304CFA File Offset: 0x00302EFA
		// (set) Token: 0x06014CEB RID: 85227 RVA: 0x00304D02 File Offset: 0x00302F02
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

		// Token: 0x06014CEC RID: 85228 RVA: 0x00304D0B File Offset: 0x00302F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReviveResponse);
		}

		// Token: 0x06014CED RID: 85229 RVA: 0x00304D19 File Offset: 0x00302F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReviveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014CEE RID: 85230 RVA: 0x00304D48 File Offset: 0x00302F48
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

		// Token: 0x06014CEF RID: 85231 RVA: 0x00304D8D File Offset: 0x00302F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014CF0 RID: 85232 RVA: 0x00304D9A File Offset: 0x00302F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014CF1 RID: 85233 RVA: 0x00304DA3 File Offset: 0x00302FA3
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

		// Token: 0x06014CF2 RID: 85234 RVA: 0x00304DD8 File Offset: 0x00302FD8
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

		// Token: 0x06014CF3 RID: 85235 RVA: 0x00304E16 File Offset: 0x00303016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReviveResponse other)
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

		// Token: 0x06014CF4 RID: 85236 RVA: 0x00304E47 File Offset: 0x00303047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014CF5 RID: 85237 RVA: 0x00304E50 File Offset: 0x00303050
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

		// Token: 0x04007D94 RID: 32148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D95 RID: 32149
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04007D96 RID: 32150
		private ErrorCode errorCode_;
	}
}
