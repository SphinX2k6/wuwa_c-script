using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200170B RID: 5899
	[NetMessage(EMessageId.CombatSendPackResponse)]
	public sealed class CombatSendPackResponse : IMessage<CombatSendPackResponse>, IMessage, IEquatable<CombatSendPackResponse>, IDeepCloneable<CombatSendPackResponse>, IBufferMessage
	{
		// Token: 0x0601D9BA RID: 121274 RVA: 0x00457634 File Offset: 0x00455834
		[NullableContext(1)]
		public static CombatSendPackResponse Create()
		{
			return new CombatSendPackResponse();
		}

		// Token: 0x170064C3 RID: 25795
		// (get) Token: 0x0601D9BB RID: 121275 RVA: 0x0045763B File Offset: 0x0045583B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064C4 RID: 25796
		// (get) Token: 0x0601D9BC RID: 121276 RVA: 0x0045763E File Offset: 0x0045583E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatSendPackResponse.Descriptor;
			}
		}

		// Token: 0x0601D9BD RID: 121277 RVA: 0x00457645 File Offset: 0x00455845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackResponse()
		{
		}

		// Token: 0x0601D9BE RID: 121278 RVA: 0x00457650 File Offset: 0x00455850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackResponse(CombatSendPackResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.receivePackNotify_ = ((other.receivePackNotify_ != null) ? other.receivePackNotify_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D9BF RID: 121279 RVA: 0x0045769C File Offset: 0x0045589C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackResponse Clone()
		{
			return new CombatSendPackResponse(this);
		}

		// Token: 0x170064C5 RID: 25797
		// (get) Token: 0x0601D9C0 RID: 121280 RVA: 0x004576A4 File Offset: 0x004558A4
		// (set) Token: 0x0601D9C1 RID: 121281 RVA: 0x004576AC File Offset: 0x004558AC
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

		// Token: 0x170064C6 RID: 25798
		// (get) Token: 0x0601D9C2 RID: 121282 RVA: 0x004576B5 File Offset: 0x004558B5
		// (set) Token: 0x0601D9C3 RID: 121283 RVA: 0x004576BD File Offset: 0x004558BD
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

		// Token: 0x0601D9C4 RID: 121284 RVA: 0x004576C6 File Offset: 0x004558C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatSendPackResponse);
		}

		// Token: 0x0601D9C5 RID: 121285 RVA: 0x004576D4 File Offset: 0x004558D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatSendPackResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ReceivePackNotify, other.ReceivePackNotify) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D9C6 RID: 121286 RVA: 0x00457724 File Offset: 0x00455924
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

		// Token: 0x0601D9C7 RID: 121287 RVA: 0x0045777F File Offset: 0x0045597F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D9C8 RID: 121288 RVA: 0x0045778C File Offset: 0x0045598C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D9C9 RID: 121289 RVA: 0x00457798 File Offset: 0x00455998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.receivePackNotify_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ReceivePackNotify);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D9CA RID: 121290 RVA: 0x004577F4 File Offset: 0x004559F4
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

		// Token: 0x0601D9CB RID: 121291 RVA: 0x0045784C File Offset: 0x00455A4C
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

		// Token: 0x0601D9CC RID: 121292 RVA: 0x004578B4 File Offset: 0x00455AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D9CD RID: 121293 RVA: 0x004578C0 File Offset: 0x00455AC0
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
				if (num != 10U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x0400C887 RID: 51335
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C888 RID: 51336
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400C889 RID: 51337
		private ErrorCode errorCode_;

		// Token: 0x0400C88A RID: 51338
		public const int ReceivePackNotifyFieldNumber = 1;

		// Token: 0x0400C88B RID: 51339
		private CombatReceivePackNotify receivePackNotify_;
	}
}
