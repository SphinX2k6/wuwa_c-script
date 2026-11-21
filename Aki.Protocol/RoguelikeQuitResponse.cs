using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9A RID: 3994
	[NetMessage(EMessageId.RoguelikeQuitResponse)]
	public sealed class RoguelikeQuitResponse : IMessage<RoguelikeQuitResponse>, IMessage, IEquatable<RoguelikeQuitResponse>, IDeepCloneable<RoguelikeQuitResponse>, IBufferMessage
	{
		// Token: 0x0601562A RID: 87594 RVA: 0x0031B34E File Offset: 0x0031954E
		[NullableContext(1)]
		public static RoguelikeQuitResponse Create()
		{
			return new RoguelikeQuitResponse();
		}

		// Token: 0x1700474E RID: 18254
		// (get) Token: 0x0601562B RID: 87595 RVA: 0x0031B355 File Offset: 0x00319555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700474F RID: 18255
		// (get) Token: 0x0601562C RID: 87596 RVA: 0x0031B358 File Offset: 0x00319558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeQuitResponse.Descriptor;
			}
		}

		// Token: 0x0601562D RID: 87597 RVA: 0x0031B35F File Offset: 0x0031955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitResponse()
		{
		}

		// Token: 0x0601562E RID: 87598 RVA: 0x0031B367 File Offset: 0x00319567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitResponse(RoguelikeQuitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601562F RID: 87599 RVA: 0x0031B38C File Offset: 0x0031958C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitResponse Clone()
		{
			return new RoguelikeQuitResponse(this);
		}

		// Token: 0x17004750 RID: 18256
		// (get) Token: 0x06015630 RID: 87600 RVA: 0x0031B394 File Offset: 0x00319594
		// (set) Token: 0x06015631 RID: 87601 RVA: 0x0031B39C File Offset: 0x0031959C
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

		// Token: 0x06015632 RID: 87602 RVA: 0x0031B3A5 File Offset: 0x003195A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeQuitResponse);
		}

		// Token: 0x06015633 RID: 87603 RVA: 0x0031B3B3 File Offset: 0x003195B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeQuitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015634 RID: 87604 RVA: 0x0031B3E4 File Offset: 0x003195E4
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

		// Token: 0x06015635 RID: 87605 RVA: 0x0031B429 File Offset: 0x00319629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015636 RID: 87606 RVA: 0x0031B436 File Offset: 0x00319636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015637 RID: 87607 RVA: 0x0031B43F File Offset: 0x0031963F
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

		// Token: 0x06015638 RID: 87608 RVA: 0x0031B474 File Offset: 0x00319674
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

		// Token: 0x06015639 RID: 87609 RVA: 0x0031B4B2 File Offset: 0x003196B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeQuitResponse other)
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

		// Token: 0x0601563A RID: 87610 RVA: 0x0031B4E3 File Offset: 0x003196E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601563B RID: 87611 RVA: 0x0031B4EC File Offset: 0x003196EC
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

		// Token: 0x04008119 RID: 33049
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400811A RID: 33050
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400811B RID: 33051
		private ErrorCode errorCode_;
	}
}
