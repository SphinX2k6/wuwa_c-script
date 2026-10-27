using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200168F RID: 5775
	[NetMessage(EMessageId.CombatSendPackResponse)]
	public sealed class CombatSendPackResponse : IMessage<CombatSendPackResponse>, IMessage, IEquatable<CombatSendPackResponse>, IDeepCloneable<CombatSendPackResponse>, IBufferMessage
	{
		// Token: 0x0601CEEF RID: 118511 RVA: 0x0043BA88 File Offset: 0x00439C88
		[NullableContext(1)]
		public static CombatSendPackResponse Create()
		{
			return new CombatSendPackResponse();
		}

		// Token: 0x17006220 RID: 25120
		// (get) Token: 0x0601CEF0 RID: 118512 RVA: 0x0043BA8F File Offset: 0x00439C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006221 RID: 25121
		// (get) Token: 0x0601CEF1 RID: 118513 RVA: 0x0043BA92 File Offset: 0x00439C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatSendPackResponse.Descriptor;
			}
		}

		// Token: 0x0601CEF2 RID: 118514 RVA: 0x0043BA99 File Offset: 0x00439C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackResponse()
		{
		}

		// Token: 0x0601CEF3 RID: 118515 RVA: 0x0043BAA4 File Offset: 0x00439CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackResponse(CombatSendPackResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.receivePackNotify_ = ((other.receivePackNotify_ != null) ? other.receivePackNotify_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CEF4 RID: 118516 RVA: 0x0043BAF0 File Offset: 0x00439CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackResponse Clone()
		{
			return new CombatSendPackResponse(this);
		}

		// Token: 0x17006222 RID: 25122
		// (get) Token: 0x0601CEF5 RID: 118517 RVA: 0x0043BAF8 File Offset: 0x00439CF8
		// (set) Token: 0x0601CEF6 RID: 118518 RVA: 0x0043BB00 File Offset: 0x00439D00
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

		// Token: 0x17006223 RID: 25123
		// (get) Token: 0x0601CEF7 RID: 118519 RVA: 0x0043BB09 File Offset: 0x00439D09
		// (set) Token: 0x0601CEF8 RID: 118520 RVA: 0x0043BB11 File Offset: 0x00439D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceivePackNotify ReceivePackNotify
		{
			get
			{
				return this.receivePackNotify_;
			}
			set
			{
				this.receivePackNotify_ = value;
			}
		}

		// Token: 0x0601CEF9 RID: 118521 RVA: 0x0043BB1A File Offset: 0x00439D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatSendPackResponse);
		}

		// Token: 0x0601CEFA RID: 118522 RVA: 0x0043BB28 File Offset: 0x00439D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatSendPackResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ReceivePackNotify, other.ReceivePackNotify) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEFB RID: 118523 RVA: 0x0043BB78 File Offset: 0x00439D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.receivePackNotify_ != null)
			{
				num ^= this.ReceivePackNotify.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CEFC RID: 118524 RVA: 0x0043BBD3 File Offset: 0x00439DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CEFD RID: 118525 RVA: 0x0043BBE0 File Offset: 0x00439DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEFE RID: 118526 RVA: 0x0043BBEC File Offset: 0x00439DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.receivePackNotify_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ReceivePackNotify);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CEFF RID: 118527 RVA: 0x0043BC48 File Offset: 0x00439E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.receivePackNotify_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReceivePackNotify);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF00 RID: 118528 RVA: 0x0043BCA0 File Offset: 0x00439EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatSendPackResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.receivePackNotify_ != null)
			{
				if (this.receivePackNotify_ == null)
				{
					this.ReceivePackNotify = new CombatReceivePackNotify();
				}
				this.ReceivePackNotify.MergeFrom(other.ReceivePackNotify);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF01 RID: 118529 RVA: 0x0043BD08 File Offset: 0x00439F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF02 RID: 118530 RVA: 0x0043BD14 File Offset: 0x00439F14
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
				if (num != 48U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.receivePackNotify_ == null)
						{
							this.ReceivePackNotify = new CombatReceivePackNotify();
						}
						input.ReadMessage(this.ReceivePackNotify);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C35C RID: 50012
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C35D RID: 50013
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400C35E RID: 50014
		private ErrorCode errorCode_;

		// Token: 0x0400C35F RID: 50015
		public const int ReceivePackNotifyFieldNumber = 14;

		// Token: 0x0400C360 RID: 50016
		private CombatReceivePackNotify receivePackNotify_;
	}
}
