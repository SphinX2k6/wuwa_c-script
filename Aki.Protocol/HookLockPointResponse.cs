using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A6 RID: 1958
	[NetMessage(EMessageId.HookLockPointResponse)]
	public sealed class HookLockPointResponse : IMessage<HookLockPointResponse>, IMessage, IEquatable<HookLockPointResponse>, IDeepCloneable<HookLockPointResponse>, IBufferMessage
	{
		// Token: 0x0600B0B5 RID: 45237 RVA: 0x001A7DD5 File Offset: 0x001A5FD5
		[NullableContext(1)]
		public static HookLockPointResponse Create()
		{
			return new HookLockPointResponse();
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600B0B6 RID: 45238 RVA: 0x001A7DDC File Offset: 0x001A5FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x0600B0B7 RID: 45239 RVA: 0x001A7DDF File Offset: 0x001A5FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointResponse.Descriptor;
			}
		}

		// Token: 0x0600B0B8 RID: 45240 RVA: 0x001A7DE6 File Offset: 0x001A5FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointResponse()
		{
		}

		// Token: 0x0600B0B9 RID: 45241 RVA: 0x001A7DEE File Offset: 0x001A5FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointResponse(HookLockPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0BA RID: 45242 RVA: 0x001A7E13 File Offset: 0x001A6013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointResponse Clone()
		{
			return new HookLockPointResponse(this);
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x0600B0BB RID: 45243 RVA: 0x001A7E1B File Offset: 0x001A601B
		// (set) Token: 0x0600B0BC RID: 45244 RVA: 0x001A7E23 File Offset: 0x001A6023
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

		// Token: 0x0600B0BD RID: 45245 RVA: 0x001A7E2C File Offset: 0x001A602C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointResponse);
		}

		// Token: 0x0600B0BE RID: 45246 RVA: 0x001A7E3A File Offset: 0x001A603A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x001A7E68 File Offset: 0x001A6068
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

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x001A7EAD File Offset: 0x001A60AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x001A7EBA File Offset: 0x001A60BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x001A7EC3 File Offset: 0x001A60C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x001A7EF8 File Offset: 0x001A60F8
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

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x001A7F36 File Offset: 0x001A6136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointResponse other)
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

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x001A7F67 File Offset: 0x001A6167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x001A7F70 File Offset: 0x001A6170
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004FA7 RID: 20391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA8 RID: 20392
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004FA9 RID: 20393
		private ErrorCode errorCode_;
	}
}
