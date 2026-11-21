using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE8 RID: 3560
	[NetMessage(EMessageId.PullingFoundationResponse)]
	public sealed class PullingFoundationResponse : IMessage<PullingFoundationResponse>, IMessage, IEquatable<PullingFoundationResponse>, IDeepCloneable<PullingFoundationResponse>, IBufferMessage
	{
		// Token: 0x060132E0 RID: 78560 RVA: 0x002CBD15 File Offset: 0x002C9F15
		[NullableContext(1)]
		public static PullingFoundationResponse Create()
		{
			return new PullingFoundationResponse();
		}

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x060132E1 RID: 78561 RVA: 0x002CBD1C File Offset: 0x002C9F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x060132E2 RID: 78562 RVA: 0x002CBD1F File Offset: 0x002C9F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PullingFoundationResponse.Descriptor;
			}
		}

		// Token: 0x060132E3 RID: 78563 RVA: 0x002CBD26 File Offset: 0x002C9F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationResponse()
		{
		}

		// Token: 0x060132E4 RID: 78564 RVA: 0x002CBD2E File Offset: 0x002C9F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationResponse(PullingFoundationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132E5 RID: 78565 RVA: 0x002CBD53 File Offset: 0x002C9F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationResponse Clone()
		{
			return new PullingFoundationResponse(this);
		}

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x060132E6 RID: 78566 RVA: 0x002CBD5B File Offset: 0x002C9F5B
		// (set) Token: 0x060132E7 RID: 78567 RVA: 0x002CBD63 File Offset: 0x002C9F63
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

		// Token: 0x060132E8 RID: 78568 RVA: 0x002CBD6C File Offset: 0x002C9F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PullingFoundationResponse);
		}

		// Token: 0x060132E9 RID: 78569 RVA: 0x002CBD7A File Offset: 0x002C9F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PullingFoundationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132EA RID: 78570 RVA: 0x002CBDA8 File Offset: 0x002C9FA8
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

		// Token: 0x060132EB RID: 78571 RVA: 0x002CBDED File Offset: 0x002C9FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132EC RID: 78572 RVA: 0x002CBDFA File Offset: 0x002C9FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132ED RID: 78573 RVA: 0x002CBE03 File Offset: 0x002CA003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060132EE RID: 78574 RVA: 0x002CBE38 File Offset: 0x002CA038
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

		// Token: 0x060132EF RID: 78575 RVA: 0x002CBE76 File Offset: 0x002CA076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PullingFoundationResponse other)
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

		// Token: 0x060132F0 RID: 78576 RVA: 0x002CBEA7 File Offset: 0x002CA0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132F1 RID: 78577 RVA: 0x002CBEB0 File Offset: 0x002CA0B0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007691 RID: 30353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007692 RID: 30354
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007693 RID: 30355
		private ErrorCode errorCode_;
	}
}
