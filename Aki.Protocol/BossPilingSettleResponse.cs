using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CB RID: 459
	[NetMessage(EMessageId.BossPilingSettleResponse)]
	public sealed class BossPilingSettleResponse : IMessage<BossPilingSettleResponse>, IMessage, IEquatable<BossPilingSettleResponse>, IDeepCloneable<BossPilingSettleResponse>, IBufferMessage
	{
		// Token: 0x06003477 RID: 13431 RVA: 0x0008453A File Offset: 0x0008273A
		[NullableContext(1)]
		public static BossPilingSettleResponse Create()
		{
			return new BossPilingSettleResponse();
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x00084541 File Offset: 0x00082741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x00084544 File Offset: 0x00082744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingSettleResponse.Descriptor;
			}
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x0008454B File Offset: 0x0008274B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleResponse()
		{
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00084553 File Offset: 0x00082753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleResponse(BossPilingSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00084578 File Offset: 0x00082778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleResponse Clone()
		{
			return new BossPilingSettleResponse(this);
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x00084580 File Offset: 0x00082780
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x00084588 File Offset: 0x00082788
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

		// Token: 0x0600347F RID: 13439 RVA: 0x00084591 File Offset: 0x00082791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingSettleResponse);
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x0008459F File Offset: 0x0008279F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000845D0 File Offset: 0x000827D0
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

		// Token: 0x06003482 RID: 13442 RVA: 0x00084615 File Offset: 0x00082815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00084622 File Offset: 0x00082822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x0008462B File Offset: 0x0008282B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00084660 File Offset: 0x00082860
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

		// Token: 0x06003486 RID: 13446 RVA: 0x0008469E File Offset: 0x0008289E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingSettleResponse other)
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

		// Token: 0x06003487 RID: 13447 RVA: 0x000846CF File Offset: 0x000828CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x000846D8 File Offset: 0x000828D8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A08 RID: 10760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A09 RID: 10761
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002A0A RID: 10762
		private ErrorCode errorCode_;
	}
}
