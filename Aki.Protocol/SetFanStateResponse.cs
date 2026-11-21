using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200120C RID: 4620
	[NetMessage(EMessageId.SetFanStateResponse)]
	public sealed class SetFanStateResponse : IMessage<SetFanStateResponse>, IMessage, IEquatable<SetFanStateResponse>, IDeepCloneable<SetFanStateResponse>, IBufferMessage
	{
		// Token: 0x06018AEB RID: 101099 RVA: 0x00399750 File Offset: 0x00397950
		[NullableContext(1)]
		public static SetFanStateResponse Create()
		{
			return new SetFanStateResponse();
		}

		// Token: 0x1700535C RID: 21340
		// (get) Token: 0x06018AEC RID: 101100 RVA: 0x00399757 File Offset: 0x00397957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700535D RID: 21341
		// (get) Token: 0x06018AED RID: 101101 RVA: 0x0039975A File Offset: 0x0039795A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetFanStateResponse.Descriptor;
			}
		}

		// Token: 0x06018AEE RID: 101102 RVA: 0x00399761 File Offset: 0x00397961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateResponse()
		{
		}

		// Token: 0x06018AEF RID: 101103 RVA: 0x00399769 File Offset: 0x00397969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateResponse(SetFanStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018AF0 RID: 101104 RVA: 0x0039978E File Offset: 0x0039798E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetFanStateResponse Clone()
		{
			return new SetFanStateResponse(this);
		}

		// Token: 0x1700535E RID: 21342
		// (get) Token: 0x06018AF1 RID: 101105 RVA: 0x00399796 File Offset: 0x00397996
		// (set) Token: 0x06018AF2 RID: 101106 RVA: 0x0039979E File Offset: 0x0039799E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06018AF3 RID: 101107 RVA: 0x003997A7 File Offset: 0x003979A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetFanStateResponse);
		}

		// Token: 0x06018AF4 RID: 101108 RVA: 0x003997B5 File Offset: 0x003979B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetFanStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AF5 RID: 101109 RVA: 0x003997E4 File Offset: 0x003979E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018AF6 RID: 101110 RVA: 0x00399829 File Offset: 0x00397A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AF7 RID: 101111 RVA: 0x00399836 File Offset: 0x00397A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AF8 RID: 101112 RVA: 0x0039983F File Offset: 0x00397A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AF9 RID: 101113 RVA: 0x00399874 File Offset: 0x00397A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AFA RID: 101114 RVA: 0x003998B2 File Offset: 0x00397AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetFanStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AFB RID: 101115 RVA: 0x003998E3 File Offset: 0x00397AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AFC RID: 101116 RVA: 0x003998EC File Offset: 0x00397AEC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400929F RID: 37535
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092A0 RID: 37536
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x040092A1 RID: 37537
		private ErrorCode errCode_;
	}
}
